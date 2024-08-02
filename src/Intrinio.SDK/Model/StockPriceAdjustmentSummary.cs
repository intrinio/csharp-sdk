

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Intrinio.SDK.Client.SwaggerDateConverter;

namespace Intrinio.SDK.Model
{
    /// <summary>
    /// A stock price adjustment for a security on a given day, most frequently representing a split and/or dividend.
    /// </summary>
    [DataContract]
    public partial class StockPriceAdjustmentSummary :  IEquatable<StockPriceAdjustmentSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockPriceAdjustmentSummary" /> class.
        /// </summary>
        /// <param name="Date">The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date..</param>
        /// <param name="Factor">The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices..</param>
        /// <param name="Dividend">The dividend amount, if a dividend was paid..</param>
        /// <param name="DividendCurrency">The currency of the dividend, if known..</param>
        /// <param name="SplitRatio">The ratio of the stock split, if a stock split occurred..</param>
        public StockPriceAdjustmentSummary(DateTime? Date = default(DateTime?), decimal? Factor = default(decimal?), decimal? Dividend = default(decimal?), string DividendCurrency = default(string), decimal? SplitRatio = default(decimal?))
        {
            this.Date = Date;
            this.Factor = Factor;
            this.Dividend = Dividend;
            this.DividendCurrency = DividendCurrency;
            this.SplitRatio = SplitRatio;
        }
        
        /// <summary>
        /// The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date.
        /// </summary>
        /// <value>The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices.
        /// </summary>
        /// <value>The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices.</value>
        [DataMember(Name="factor", EmitDefaultValue=false)]
        public decimal? Factor { get; set; }

        /// <summary>
        /// The dividend amount, if a dividend was paid.
        /// </summary>
        /// <value>The dividend amount, if a dividend was paid.</value>
        [DataMember(Name="dividend", EmitDefaultValue=false)]
        public decimal? Dividend { get; set; }

        /// <summary>
        /// The currency of the dividend, if known.
        /// </summary>
        /// <value>The currency of the dividend, if known.</value>
        [DataMember(Name="dividend_currency", EmitDefaultValue=false)]
        public string DividendCurrency { get; set; }

        /// <summary>
        /// The ratio of the stock split, if a stock split occurred.
        /// </summary>
        /// <value>The ratio of the stock split, if a stock split occurred.</value>
        [DataMember(Name="split_ratio", EmitDefaultValue=false)]
        public decimal? SplitRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockPriceAdjustmentSummary {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  Dividend: ").Append(Dividend).Append("\n");
            sb.Append("  DividendCurrency: ").Append(DividendCurrency).Append("\n");
            sb.Append("  SplitRatio: ").Append(SplitRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StockPriceAdjustmentSummary);
        }

        /// <summary>
        /// Returns true if StockPriceAdjustmentSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of StockPriceAdjustmentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockPriceAdjustmentSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Factor == input.Factor ||
                    (this.Factor != null &&
                    this.Factor.Equals(input.Factor))
                ) && 
                (
                    this.Dividend == input.Dividend ||
                    (this.Dividend != null &&
                    this.Dividend.Equals(input.Dividend))
                ) && 
                (
                    this.DividendCurrency == input.DividendCurrency ||
                    (this.DividendCurrency != null &&
                    this.DividendCurrency.Equals(input.DividendCurrency))
                ) && 
                (
                    this.SplitRatio == input.SplitRatio ||
                    (this.SplitRatio != null &&
                    this.SplitRatio.Equals(input.SplitRatio))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Factor != null)
                    hashCode = hashCode * 59 + this.Factor.GetHashCode();
                if (this.Dividend != null)
                    hashCode = hashCode * 59 + this.Dividend.GetHashCode();
                if (this.DividendCurrency != null)
                    hashCode = hashCode * 59 + this.DividendCurrency.GetHashCode();
                if (this.SplitRatio != null)
                    hashCode = hashCode * 59 + this.SplitRatio.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

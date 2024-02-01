

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
    /// A news article about a company
    /// </summary>
    [DataContract]
    public partial class CompanyDailyMetric :  IEquatable<CompanyDailyMetric>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyDailyMetric" /> class.
        /// </summary>
        /// <param name="Date">The date of the metric.</param>
        /// <param name="EnterpriseValue">The enterprise value..</param>
        /// <param name="EvToEbit">The enterprise value to earnings before interest and taxes ratio..</param>
        /// <param name="EvToEbitda">The enterprise value to earnings before interest, taxes, depreciation, and amoritization ratio..</param>
        /// <param name="MarketCap">The market cap..</param>
        /// <param name="PriceToBook">The price to book ratio..</param>
        /// <param name="PriceToEarnings">The price to earnings ratio..</param>
        /// <param name="PriceToRevenue">The price to revenue ratio..</param>
        /// <param name="PriceToTangibleBook">The price to tangible book ratio..</param>
        /// <param name="DividendYield">The dividend yield..</param>
        /// <param name="EarningsYield">The earnings yield..</param>
        /// <param name="EvToInvestedCapital">The enterprise value to invested capital ratio..</param>
        /// <param name="EvToRevenue">The enterprise value to revenue ratio..</param>
        /// <param name="EvToNopat">The enterprise value to normalized operating profit after tax ratio..</param>
        /// <param name="EvToOcf">The enterprise value to operating cash flow ratio..</param>
        /// <param name="EvToFcff">The enterprise value to free cash flow to the firm ratio..</param>
        public CompanyDailyMetric(DateTime? Date = default(DateTime?), decimal? EnterpriseValue = default(decimal?), decimal? EvToEbit = default(decimal?), decimal? EvToEbitda = default(decimal?), decimal? MarketCap = default(decimal?), decimal? PriceToBook = default(decimal?), decimal? PriceToEarnings = default(decimal?), decimal? PriceToRevenue = default(decimal?), decimal? PriceToTangibleBook = default(decimal?), decimal? DividendYield = default(decimal?), decimal? EarningsYield = default(decimal?), decimal? EvToInvestedCapital = default(decimal?), decimal? EvToRevenue = default(decimal?), decimal? EvToNopat = default(decimal?), decimal? EvToOcf = default(decimal?), decimal? EvToFcff = default(decimal?))
        {
            this.Date = Date;
            this.EnterpriseValue = EnterpriseValue;
            this.EvToEbit = EvToEbit;
            this.EvToEbitda = EvToEbitda;
            this.MarketCap = MarketCap;
            this.PriceToBook = PriceToBook;
            this.PriceToEarnings = PriceToEarnings;
            this.PriceToRevenue = PriceToRevenue;
            this.PriceToTangibleBook = PriceToTangibleBook;
            this.DividendYield = DividendYield;
            this.EarningsYield = EarningsYield;
            this.EvToInvestedCapital = EvToInvestedCapital;
            this.EvToRevenue = EvToRevenue;
            this.EvToNopat = EvToNopat;
            this.EvToOcf = EvToOcf;
            this.EvToFcff = EvToFcff;
        }
        
        /// <summary>
        /// The date of the metric
        /// </summary>
        /// <value>The date of the metric</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The enterprise value.
        /// </summary>
        /// <value>The enterprise value.</value>
        [DataMember(Name="enterprise_value", EmitDefaultValue=false)]
        public decimal? EnterpriseValue { get; set; }

        /// <summary>
        /// The enterprise value to earnings before interest and taxes ratio.
        /// </summary>
        /// <value>The enterprise value to earnings before interest and taxes ratio.</value>
        [DataMember(Name="ev_to_ebit", EmitDefaultValue=false)]
        public decimal? EvToEbit { get; set; }

        /// <summary>
        /// The enterprise value to earnings before interest, taxes, depreciation, and amoritization ratio.
        /// </summary>
        /// <value>The enterprise value to earnings before interest, taxes, depreciation, and amoritization ratio.</value>
        [DataMember(Name="ev_to_ebitda", EmitDefaultValue=false)]
        public decimal? EvToEbitda { get; set; }

        /// <summary>
        /// The market cap.
        /// </summary>
        /// <value>The market cap.</value>
        [DataMember(Name="market_cap", EmitDefaultValue=false)]
        public decimal? MarketCap { get; set; }

        /// <summary>
        /// The price to book ratio.
        /// </summary>
        /// <value>The price to book ratio.</value>
        [DataMember(Name="price_to_book", EmitDefaultValue=false)]
        public decimal? PriceToBook { get; set; }

        /// <summary>
        /// The price to earnings ratio.
        /// </summary>
        /// <value>The price to earnings ratio.</value>
        [DataMember(Name="price_to_earnings", EmitDefaultValue=false)]
        public decimal? PriceToEarnings { get; set; }

        /// <summary>
        /// The price to revenue ratio.
        /// </summary>
        /// <value>The price to revenue ratio.</value>
        [DataMember(Name="price_to_revenue", EmitDefaultValue=false)]
        public decimal? PriceToRevenue { get; set; }

        /// <summary>
        /// The price to tangible book ratio.
        /// </summary>
        /// <value>The price to tangible book ratio.</value>
        [DataMember(Name="price_to_tangible_book", EmitDefaultValue=false)]
        public decimal? PriceToTangibleBook { get; set; }

        /// <summary>
        /// The dividend yield.
        /// </summary>
        /// <value>The dividend yield.</value>
        [DataMember(Name="dividend_yield", EmitDefaultValue=false)]
        public decimal? DividendYield { get; set; }

        /// <summary>
        /// The earnings yield.
        /// </summary>
        /// <value>The earnings yield.</value>
        [DataMember(Name="earnings_yield", EmitDefaultValue=false)]
        public decimal? EarningsYield { get; set; }

        /// <summary>
        /// The enterprise value to invested capital ratio.
        /// </summary>
        /// <value>The enterprise value to invested capital ratio.</value>
        [DataMember(Name="ev_to_invested_capital", EmitDefaultValue=false)]
        public decimal? EvToInvestedCapital { get; set; }

        /// <summary>
        /// The enterprise value to revenue ratio.
        /// </summary>
        /// <value>The enterprise value to revenue ratio.</value>
        [DataMember(Name="ev_to_revenue", EmitDefaultValue=false)]
        public decimal? EvToRevenue { get; set; }

        /// <summary>
        /// The enterprise value to normalized operating profit after tax ratio.
        /// </summary>
        /// <value>The enterprise value to normalized operating profit after tax ratio.</value>
        [DataMember(Name="ev_to_nopat", EmitDefaultValue=false)]
        public decimal? EvToNopat { get; set; }

        /// <summary>
        /// The enterprise value to operating cash flow ratio.
        /// </summary>
        /// <value>The enterprise value to operating cash flow ratio.</value>
        [DataMember(Name="ev_to_ocf", EmitDefaultValue=false)]
        public decimal? EvToOcf { get; set; }

        /// <summary>
        /// The enterprise value to free cash flow to the firm ratio.
        /// </summary>
        /// <value>The enterprise value to free cash flow to the firm ratio.</value>
        [DataMember(Name="ev_to_fcff", EmitDefaultValue=false)]
        public decimal? EvToFcff { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyDailyMetric {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EnterpriseValue: ").Append(EnterpriseValue).Append("\n");
            sb.Append("  EvToEbit: ").Append(EvToEbit).Append("\n");
            sb.Append("  EvToEbitda: ").Append(EvToEbitda).Append("\n");
            sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
            sb.Append("  PriceToBook: ").Append(PriceToBook).Append("\n");
            sb.Append("  PriceToEarnings: ").Append(PriceToEarnings).Append("\n");
            sb.Append("  PriceToRevenue: ").Append(PriceToRevenue).Append("\n");
            sb.Append("  PriceToTangibleBook: ").Append(PriceToTangibleBook).Append("\n");
            sb.Append("  DividendYield: ").Append(DividendYield).Append("\n");
            sb.Append("  EarningsYield: ").Append(EarningsYield).Append("\n");
            sb.Append("  EvToInvestedCapital: ").Append(EvToInvestedCapital).Append("\n");
            sb.Append("  EvToRevenue: ").Append(EvToRevenue).Append("\n");
            sb.Append("  EvToNopat: ").Append(EvToNopat).Append("\n");
            sb.Append("  EvToOcf: ").Append(EvToOcf).Append("\n");
            sb.Append("  EvToFcff: ").Append(EvToFcff).Append("\n");
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
            return this.Equals(input as CompanyDailyMetric);
        }

        /// <summary>
        /// Returns true if CompanyDailyMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyDailyMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyDailyMetric input)
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
                    this.EnterpriseValue == input.EnterpriseValue ||
                    (this.EnterpriseValue != null &&
                    this.EnterpriseValue.Equals(input.EnterpriseValue))
                ) && 
                (
                    this.EvToEbit == input.EvToEbit ||
                    (this.EvToEbit != null &&
                    this.EvToEbit.Equals(input.EvToEbit))
                ) && 
                (
                    this.EvToEbitda == input.EvToEbitda ||
                    (this.EvToEbitda != null &&
                    this.EvToEbitda.Equals(input.EvToEbitda))
                ) && 
                (
                    this.MarketCap == input.MarketCap ||
                    (this.MarketCap != null &&
                    this.MarketCap.Equals(input.MarketCap))
                ) && 
                (
                    this.PriceToBook == input.PriceToBook ||
                    (this.PriceToBook != null &&
                    this.PriceToBook.Equals(input.PriceToBook))
                ) && 
                (
                    this.PriceToEarnings == input.PriceToEarnings ||
                    (this.PriceToEarnings != null &&
                    this.PriceToEarnings.Equals(input.PriceToEarnings))
                ) && 
                (
                    this.PriceToRevenue == input.PriceToRevenue ||
                    (this.PriceToRevenue != null &&
                    this.PriceToRevenue.Equals(input.PriceToRevenue))
                ) && 
                (
                    this.PriceToTangibleBook == input.PriceToTangibleBook ||
                    (this.PriceToTangibleBook != null &&
                    this.PriceToTangibleBook.Equals(input.PriceToTangibleBook))
                ) && 
                (
                    this.DividendYield == input.DividendYield ||
                    (this.DividendYield != null &&
                    this.DividendYield.Equals(input.DividendYield))
                ) && 
                (
                    this.EarningsYield == input.EarningsYield ||
                    (this.EarningsYield != null &&
                    this.EarningsYield.Equals(input.EarningsYield))
                ) && 
                (
                    this.EvToInvestedCapital == input.EvToInvestedCapital ||
                    (this.EvToInvestedCapital != null &&
                    this.EvToInvestedCapital.Equals(input.EvToInvestedCapital))
                ) && 
                (
                    this.EvToRevenue == input.EvToRevenue ||
                    (this.EvToRevenue != null &&
                    this.EvToRevenue.Equals(input.EvToRevenue))
                ) && 
                (
                    this.EvToNopat == input.EvToNopat ||
                    (this.EvToNopat != null &&
                    this.EvToNopat.Equals(input.EvToNopat))
                ) && 
                (
                    this.EvToOcf == input.EvToOcf ||
                    (this.EvToOcf != null &&
                    this.EvToOcf.Equals(input.EvToOcf))
                ) && 
                (
                    this.EvToFcff == input.EvToFcff ||
                    (this.EvToFcff != null &&
                    this.EvToFcff.Equals(input.EvToFcff))
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
                if (this.EnterpriseValue != null)
                    hashCode = hashCode * 59 + this.EnterpriseValue.GetHashCode();
                if (this.EvToEbit != null)
                    hashCode = hashCode * 59 + this.EvToEbit.GetHashCode();
                if (this.EvToEbitda != null)
                    hashCode = hashCode * 59 + this.EvToEbitda.GetHashCode();
                if (this.MarketCap != null)
                    hashCode = hashCode * 59 + this.MarketCap.GetHashCode();
                if (this.PriceToBook != null)
                    hashCode = hashCode * 59 + this.PriceToBook.GetHashCode();
                if (this.PriceToEarnings != null)
                    hashCode = hashCode * 59 + this.PriceToEarnings.GetHashCode();
                if (this.PriceToRevenue != null)
                    hashCode = hashCode * 59 + this.PriceToRevenue.GetHashCode();
                if (this.PriceToTangibleBook != null)
                    hashCode = hashCode * 59 + this.PriceToTangibleBook.GetHashCode();
                if (this.DividendYield != null)
                    hashCode = hashCode * 59 + this.DividendYield.GetHashCode();
                if (this.EarningsYield != null)
                    hashCode = hashCode * 59 + this.EarningsYield.GetHashCode();
                if (this.EvToInvestedCapital != null)
                    hashCode = hashCode * 59 + this.EvToInvestedCapital.GetHashCode();
                if (this.EvToRevenue != null)
                    hashCode = hashCode * 59 + this.EvToRevenue.GetHashCode();
                if (this.EvToNopat != null)
                    hashCode = hashCode * 59 + this.EvToNopat.GetHashCode();
                if (this.EvToOcf != null)
                    hashCode = hashCode * 59 + this.EvToOcf.GetHashCode();
                if (this.EvToFcff != null)
                    hashCode = hashCode * 59 + this.EvToFcff.GetHashCode();
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

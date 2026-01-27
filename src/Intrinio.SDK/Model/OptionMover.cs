

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
    /// Represents a single options contract identified as a significant mover in the market, including key price, change, and volume metrics.
    /// </summary>
    [DataContract]
    public partial class OptionMover :  IEquatable<OptionMover>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionMover" /> class.
        /// </summary>
        /// <param name="Code">The unique options contract, in a format combining ticker symbol, expiration, strike, and put or call. Example - AAPL__260101P00123500.  The ticker symbol is right padded by underscores to 6 characters. Following that is the 2 digit year, 2 digit month, and 2 digit day, then a P for put or C for call.  The last section is the strike. The first 5 digits are the whole number portion, left padded by zeros. The last 3 digits are the decimal portion, right padded by zeros..</param>
        /// <param name="Ticker">The ticker symbol of the underlying security for the options contract..</param>
        /// <param name="LastPrice">The most recent trade price of the options contract..</param>
        /// <param name="LastClosePrice">The closing price of the options contract from the previous trading session..</param>
        /// <param name="Change">The absolute dollar change in the contract&#39;s price from the previous close to the last price..</param>
        /// <param name="PercentChange">The percentage change in the contract&#39;s price from the previous close to the last price, expressed as a decimal (e.g., 0.12 for 12%)..</param>
        /// <param name="Volume">The total trading volume for this options contract during the current session..</param>
        /// <param name="OpenInterest">The total number of outstanding contracts for this option that have not yet been closed or exercised..</param>
        /// <param name="LastCloseDate">The date of the previous trading session&#39;s close for this contract..</param>
        public OptionMover(string Code = default(string), string Ticker = default(string), decimal? LastPrice = default(decimal?), decimal? LastClosePrice = default(decimal?), decimal? Change = default(decimal?), decimal? PercentChange = default(decimal?), int? Volume = default(int?), int? OpenInterest = default(int?), DateTime? LastCloseDate = default(DateTime?))
        {
            this.Code = Code;
            this.Ticker = Ticker;
            this.LastPrice = LastPrice;
            this.LastClosePrice = LastClosePrice;
            this.Change = Change;
            this.PercentChange = PercentChange;
            this.Volume = Volume;
            this.OpenInterest = OpenInterest;
            this.LastCloseDate = LastCloseDate;
        }
        
        /// <summary>
        /// The unique options contract, in a format combining ticker symbol, expiration, strike, and put or call. Example - AAPL__260101P00123500.  The ticker symbol is right padded by underscores to 6 characters. Following that is the 2 digit year, 2 digit month, and 2 digit day, then a P for put or C for call.  The last section is the strike. The first 5 digits are the whole number portion, left padded by zeros. The last 3 digits are the decimal portion, right padded by zeros.
        /// </summary>
        /// <value>The unique options contract, in a format combining ticker symbol, expiration, strike, and put or call. Example - AAPL__260101P00123500.  The ticker symbol is right padded by underscores to 6 characters. Following that is the 2 digit year, 2 digit month, and 2 digit day, then a P for put or C for call.  The last section is the strike. The first 5 digits are the whole number portion, left padded by zeros. The last 3 digits are the decimal portion, right padded by zeros.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ticker symbol of the underlying security for the options contract.
        /// </summary>
        /// <value>The ticker symbol of the underlying security for the options contract.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The most recent trade price of the options contract.
        /// </summary>
        /// <value>The most recent trade price of the options contract.</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The closing price of the options contract from the previous trading session.
        /// </summary>
        /// <value>The closing price of the options contract from the previous trading session.</value>
        [DataMember(Name="last_close_price", EmitDefaultValue=false)]
        public decimal? LastClosePrice { get; set; }

        /// <summary>
        /// The absolute dollar change in the contract&#39;s price from the previous close to the last price.
        /// </summary>
        /// <value>The absolute dollar change in the contract&#39;s price from the previous close to the last price.</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The percentage change in the contract&#39;s price from the previous close to the last price, expressed as a decimal (e.g., 0.12 for 12%).
        /// </summary>
        /// <value>The percentage change in the contract&#39;s price from the previous close to the last price, expressed as a decimal (e.g., 0.12 for 12%).</value>
        [DataMember(Name="percent_change", EmitDefaultValue=false)]
        public decimal? PercentChange { get; set; }

        /// <summary>
        /// The total trading volume for this options contract during the current session.
        /// </summary>
        /// <value>The total trading volume for this options contract during the current session.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public int? Volume { get; set; }

        /// <summary>
        /// The total number of outstanding contracts for this option that have not yet been closed or exercised.
        /// </summary>
        /// <value>The total number of outstanding contracts for this option that have not yet been closed or exercised.</value>
        [DataMember(Name="open_interest", EmitDefaultValue=false)]
        public int? OpenInterest { get; set; }

        /// <summary>
        /// The date of the previous trading session&#39;s close for this contract.
        /// </summary>
        /// <value>The date of the previous trading session&#39;s close for this contract.</value>
        [DataMember(Name="last_close_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastCloseDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionMover {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  LastClosePrice: ").Append(LastClosePrice).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  PercentChange: ").Append(PercentChange).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
            sb.Append("  LastCloseDate: ").Append(LastCloseDate).Append("\n");
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
            return this.Equals(input as OptionMover);
        }

        /// <summary>
        /// Returns true if OptionMover instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionMover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionMover input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.LastPrice == input.LastPrice ||
                    (this.LastPrice != null &&
                    this.LastPrice.Equals(input.LastPrice))
                ) && 
                (
                    this.LastClosePrice == input.LastClosePrice ||
                    (this.LastClosePrice != null &&
                    this.LastClosePrice.Equals(input.LastClosePrice))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.PercentChange == input.PercentChange ||
                    (this.PercentChange != null &&
                    this.PercentChange.Equals(input.PercentChange))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.OpenInterest == input.OpenInterest ||
                    (this.OpenInterest != null &&
                    this.OpenInterest.Equals(input.OpenInterest))
                ) && 
                (
                    this.LastCloseDate == input.LastCloseDate ||
                    (this.LastCloseDate != null &&
                    this.LastCloseDate.Equals(input.LastCloseDate))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.LastPrice != null)
                    hashCode = hashCode * 59 + this.LastPrice.GetHashCode();
                if (this.LastClosePrice != null)
                    hashCode = hashCode * 59 + this.LastClosePrice.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.PercentChange != null)
                    hashCode = hashCode * 59 + this.PercentChange.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.OpenInterest != null)
                    hashCode = hashCode * 59 + this.OpenInterest.GetHashCode();
                if (this.LastCloseDate != null)
                    hashCode = hashCode * 59 + this.LastCloseDate.GetHashCode();
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

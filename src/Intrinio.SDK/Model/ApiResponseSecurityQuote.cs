

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
    /// A realtime price quote of a security.
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityQuote :  IEquatable<ApiResponseSecurityQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityQuote" /> class.
        /// </summary>
        /// <param name="Security">The Security of the stock quote.</param>
        /// <param name="Last">The price of the latest trade.</param>
        /// <param name="LastTime">The date and time when the last trade occurred..</param>
        /// <param name="Source">The source of the pricing data..</param>
        /// <param name="Open">The open price from the latest day of trading..</param>
        /// <param name="High">The highest price from the latest day of trading..</param>
        /// <param name="Low">The lowest price from the latest day of trading..</param>
        /// <param name="ExchangeVolume">The volume of the security from the source..</param>
        /// <param name="EodFiftyTwoWeekHigh">The 52 week high price..</param>
        /// <param name="EodFiftyTwoWeekLow">The 52 week low price..</param>
        /// <param name="Marketcap">The current market cap..</param>
        /// <param name="Pricetoearnings">The current price to earnings..</param>
        /// <param name="PreviousClose">The previous close price..</param>
        /// <param name="PreviousCloseDate">The date of the previous close..</param>
        /// <param name="Change">The difference in last price from the last close price.</param>
        /// <param name="ChangePercent">The percent difference in last price from the last close price.</param>
        public ApiResponseSecurityQuote(SecuritySummary Security = default(SecuritySummary), decimal? Last = default(decimal?), DateTime? LastTime = default(DateTime?), string Source = default(string), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? ExchangeVolume = default(decimal?), decimal? EodFiftyTwoWeekHigh = default(decimal?), decimal? EodFiftyTwoWeekLow = default(decimal?), decimal? Marketcap = default(decimal?), decimal? Pricetoearnings = default(decimal?), decimal? PreviousClose = default(decimal?), decimal? PreviousCloseDate = default(decimal?), decimal? Change = default(decimal?), decimal? ChangePercent = default(decimal?))
        {
            this.Security = Security;
            this.Last = Last;
            this.LastTime = LastTime;
            this.Source = Source;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.ExchangeVolume = ExchangeVolume;
            this.EodFiftyTwoWeekHigh = EodFiftyTwoWeekHigh;
            this.EodFiftyTwoWeekLow = EodFiftyTwoWeekLow;
            this.Marketcap = Marketcap;
            this.Pricetoearnings = Pricetoearnings;
            this.PreviousClose = PreviousClose;
            this.PreviousCloseDate = PreviousCloseDate;
            this.Change = Change;
            this.ChangePercent = ChangePercent;
        }
        
        /// <summary>
        /// The Security of the stock quote
        /// </summary>
        /// <value>The Security of the stock quote</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// The price of the latest trade
        /// </summary>
        /// <value>The price of the latest trade</value>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public decimal? Last { get; set; }

        /// <summary>
        /// The date and time when the last trade occurred.
        /// </summary>
        /// <value>The date and time when the last trade occurred.</value>
        [DataMember(Name="last_time", EmitDefaultValue=false)]
        public DateTime? LastTime { get; set; }

        /// <summary>
        /// The source of the pricing data.
        /// </summary>
        /// <value>The source of the pricing data.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// The open price from the latest day of trading.
        /// </summary>
        /// <value>The open price from the latest day of trading.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The highest price from the latest day of trading.
        /// </summary>
        /// <value>The highest price from the latest day of trading.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest price from the latest day of trading.
        /// </summary>
        /// <value>The lowest price from the latest day of trading.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The volume of the security from the source.
        /// </summary>
        /// <value>The volume of the security from the source.</value>
        [DataMember(Name="exchange_volume", EmitDefaultValue=false)]
        public decimal? ExchangeVolume { get; set; }

        /// <summary>
        /// The 52 week high price.
        /// </summary>
        /// <value>The 52 week high price.</value>
        [DataMember(Name="eod_fifty_two_week_high", EmitDefaultValue=false)]
        public decimal? EodFiftyTwoWeekHigh { get; set; }

        /// <summary>
        /// The 52 week low price.
        /// </summary>
        /// <value>The 52 week low price.</value>
        [DataMember(Name="eod_fifty_two_week_low", EmitDefaultValue=false)]
        public decimal? EodFiftyTwoWeekLow { get; set; }

        /// <summary>
        /// The current market cap.
        /// </summary>
        /// <value>The current market cap.</value>
        [DataMember(Name="marketcap", EmitDefaultValue=false)]
        public decimal? Marketcap { get; set; }

        /// <summary>
        /// The current price to earnings.
        /// </summary>
        /// <value>The current price to earnings.</value>
        [DataMember(Name="pricetoearnings", EmitDefaultValue=false)]
        public decimal? Pricetoearnings { get; set; }

        /// <summary>
        /// The previous close price.
        /// </summary>
        /// <value>The previous close price.</value>
        [DataMember(Name="previous_close", EmitDefaultValue=false)]
        public decimal? PreviousClose { get; set; }

        /// <summary>
        /// The date of the previous close.
        /// </summary>
        /// <value>The date of the previous close.</value>
        [DataMember(Name="previous_close_date", EmitDefaultValue=false)]
        public decimal? PreviousCloseDate { get; set; }

        /// <summary>
        /// The difference in last price from the last close price
        /// </summary>
        /// <value>The difference in last price from the last close price</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The percent difference in last price from the last close price
        /// </summary>
        /// <value>The percent difference in last price from the last close price</value>
        [DataMember(Name="change_percent", EmitDefaultValue=false)]
        public decimal? ChangePercent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityQuote {\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  LastTime: ").Append(LastTime).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  ExchangeVolume: ").Append(ExchangeVolume).Append("\n");
            sb.Append("  EodFiftyTwoWeekHigh: ").Append(EodFiftyTwoWeekHigh).Append("\n");
            sb.Append("  EodFiftyTwoWeekLow: ").Append(EodFiftyTwoWeekLow).Append("\n");
            sb.Append("  Marketcap: ").Append(Marketcap).Append("\n");
            sb.Append("  Pricetoearnings: ").Append(Pricetoearnings).Append("\n");
            sb.Append("  PreviousClose: ").Append(PreviousClose).Append("\n");
            sb.Append("  PreviousCloseDate: ").Append(PreviousCloseDate).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  ChangePercent: ").Append(ChangePercent).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityQuote);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityQuote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.LastTime == input.LastTime ||
                    (this.LastTime != null &&
                    this.LastTime.Equals(input.LastTime))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.ExchangeVolume == input.ExchangeVolume ||
                    (this.ExchangeVolume != null &&
                    this.ExchangeVolume.Equals(input.ExchangeVolume))
                ) && 
                (
                    this.EodFiftyTwoWeekHigh == input.EodFiftyTwoWeekHigh ||
                    (this.EodFiftyTwoWeekHigh != null &&
                    this.EodFiftyTwoWeekHigh.Equals(input.EodFiftyTwoWeekHigh))
                ) && 
                (
                    this.EodFiftyTwoWeekLow == input.EodFiftyTwoWeekLow ||
                    (this.EodFiftyTwoWeekLow != null &&
                    this.EodFiftyTwoWeekLow.Equals(input.EodFiftyTwoWeekLow))
                ) && 
                (
                    this.Marketcap == input.Marketcap ||
                    (this.Marketcap != null &&
                    this.Marketcap.Equals(input.Marketcap))
                ) && 
                (
                    this.Pricetoearnings == input.Pricetoearnings ||
                    (this.Pricetoearnings != null &&
                    this.Pricetoearnings.Equals(input.Pricetoearnings))
                ) && 
                (
                    this.PreviousClose == input.PreviousClose ||
                    (this.PreviousClose != null &&
                    this.PreviousClose.Equals(input.PreviousClose))
                ) && 
                (
                    this.PreviousCloseDate == input.PreviousCloseDate ||
                    (this.PreviousCloseDate != null &&
                    this.PreviousCloseDate.Equals(input.PreviousCloseDate))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.ChangePercent == input.ChangePercent ||
                    (this.ChangePercent != null &&
                    this.ChangePercent.Equals(input.ChangePercent))
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
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.LastTime != null)
                    hashCode = hashCode * 59 + this.LastTime.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.ExchangeVolume != null)
                    hashCode = hashCode * 59 + this.ExchangeVolume.GetHashCode();
                if (this.EodFiftyTwoWeekHigh != null)
                    hashCode = hashCode * 59 + this.EodFiftyTwoWeekHigh.GetHashCode();
                if (this.EodFiftyTwoWeekLow != null)
                    hashCode = hashCode * 59 + this.EodFiftyTwoWeekLow.GetHashCode();
                if (this.Marketcap != null)
                    hashCode = hashCode * 59 + this.Marketcap.GetHashCode();
                if (this.Pricetoearnings != null)
                    hashCode = hashCode * 59 + this.Pricetoearnings.GetHashCode();
                if (this.PreviousClose != null)
                    hashCode = hashCode * 59 + this.PreviousClose.GetHashCode();
                if (this.PreviousCloseDate != null)
                    hashCode = hashCode * 59 + this.PreviousCloseDate.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.ChangePercent != null)
                    hashCode = hashCode * 59 + this.ChangePercent.GetHashCode();
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



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
    /// The stock price of a security on a given date.
    /// </summary>
    [DataContract]
    public partial class StockPrice :  IEquatable<StockPrice>, IValidatableObject
    {
        /// <summary>
        /// The type of period that the stock price represents
        /// </summary>
        /// <value>The type of period that the stock price represents</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,
            
            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,
            
            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,
            
            /// <summary>
            /// Enum Quarterly for value: quarterly
            /// </summary>
            [EnumMember(Value = "quarterly")]
            Quarterly = 4,
            
            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 5
        }

        /// <summary>
        /// The type of period that the stock price represents
        /// </summary>
        /// <value>The type of period that the stock price represents</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StockPrice" /> class.
        /// </summary>
        /// <param name="Date">The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc).</param>
        /// <param name="Intraperiod">If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period.</param>
        /// <param name="Frequency">The type of period that the stock price represents.</param>
        /// <param name="Open">The price at the beginning of the period.</param>
        /// <param name="High">The highest price over the span of the period.</param>
        /// <param name="Low">The lowest price over the span of the period.</param>
        /// <param name="Close">The price at the end of the period.</param>
        /// <param name="Volume">The number of shares exchanged during the period.</param>
        /// <param name="AdjOpen">The price at the beginning of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjHigh">The highest price over the span of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjLow">The lowest price over the span of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjClose">The price at the end of the period, adjusted for splits and dividends.</param>
        /// <param name="AdjVolume">The number of shares exchanged during the period, adjusted for splits and dividends.</param>
        /// <param name="Security">The Security of the stock price.</param>
        public StockPrice(DateTime? Date = default(DateTime?), bool? Intraperiod = default(bool?), FrequencyEnum? Frequency = default(FrequencyEnum?), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Close = default(decimal?), decimal? Volume = default(decimal?), decimal? AdjOpen = default(decimal?), decimal? AdjHigh = default(decimal?), decimal? AdjLow = default(decimal?), decimal? AdjClose = default(decimal?), decimal? AdjVolume = default(decimal?), SecuritySummary Security = default(SecuritySummary))
        {
            this.Date = Date;
            this.Intraperiod = Intraperiod;
            this.Frequency = Frequency;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Close = Close;
            this.Volume = Volume;
            this.AdjOpen = AdjOpen;
            this.AdjHigh = AdjHigh;
            this.AdjLow = AdjLow;
            this.AdjClose = AdjClose;
            this.AdjVolume = AdjVolume;
            this.Security = Security;
        }
        
        /// <summary>
        /// The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc)
        /// </summary>
        /// <value>The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc)</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period
        /// </summary>
        /// <value>If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period</value>
        [DataMember(Name="intraperiod", EmitDefaultValue=false)]
        public bool? Intraperiod { get; set; }


        /// <summary>
        /// The price at the beginning of the period
        /// </summary>
        /// <value>The price at the beginning of the period</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The highest price over the span of the period
        /// </summary>
        /// <value>The highest price over the span of the period</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest price over the span of the period
        /// </summary>
        /// <value>The lowest price over the span of the period</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The price at the end of the period
        /// </summary>
        /// <value>The price at the end of the period</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The number of shares exchanged during the period
        /// </summary>
        /// <value>The number of shares exchanged during the period</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The price at the beginning of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The price at the beginning of the period, adjusted for splits and dividends</value>
        [DataMember(Name="adj_open", EmitDefaultValue=false)]
        public decimal? AdjOpen { get; set; }

        /// <summary>
        /// The highest price over the span of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The highest price over the span of the period, adjusted for splits and dividends</value>
        [DataMember(Name="adj_high", EmitDefaultValue=false)]
        public decimal? AdjHigh { get; set; }

        /// <summary>
        /// The lowest price over the span of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The lowest price over the span of the period, adjusted for splits and dividends</value>
        [DataMember(Name="adj_low", EmitDefaultValue=false)]
        public decimal? AdjLow { get; set; }

        /// <summary>
        /// The price at the end of the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The price at the end of the period, adjusted for splits and dividends</value>
        [DataMember(Name="adj_close", EmitDefaultValue=false)]
        public decimal? AdjClose { get; set; }

        /// <summary>
        /// The number of shares exchanged during the period, adjusted for splits and dividends
        /// </summary>
        /// <value>The number of shares exchanged during the period, adjusted for splits and dividends</value>
        [DataMember(Name="adj_volume", EmitDefaultValue=false)]
        public decimal? AdjVolume { get; set; }

        /// <summary>
        /// The Security of the stock price
        /// </summary>
        /// <value>The Security of the stock price</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockPrice {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Intraperiod: ").Append(Intraperiod).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  AdjOpen: ").Append(AdjOpen).Append("\n");
            sb.Append("  AdjHigh: ").Append(AdjHigh).Append("\n");
            sb.Append("  AdjLow: ").Append(AdjLow).Append("\n");
            sb.Append("  AdjClose: ").Append(AdjClose).Append("\n");
            sb.Append("  AdjVolume: ").Append(AdjVolume).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as StockPrice);
        }

        /// <summary>
        /// Returns true if StockPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of StockPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockPrice input)
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
                    this.Intraperiod == input.Intraperiod ||
                    (this.Intraperiod != null &&
                    this.Intraperiod.Equals(input.Intraperiod))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
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
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.AdjOpen == input.AdjOpen ||
                    (this.AdjOpen != null &&
                    this.AdjOpen.Equals(input.AdjOpen))
                ) && 
                (
                    this.AdjHigh == input.AdjHigh ||
                    (this.AdjHigh != null &&
                    this.AdjHigh.Equals(input.AdjHigh))
                ) && 
                (
                    this.AdjLow == input.AdjLow ||
                    (this.AdjLow != null &&
                    this.AdjLow.Equals(input.AdjLow))
                ) && 
                (
                    this.AdjClose == input.AdjClose ||
                    (this.AdjClose != null &&
                    this.AdjClose.Equals(input.AdjClose))
                ) && 
                (
                    this.AdjVolume == input.AdjVolume ||
                    (this.AdjVolume != null &&
                    this.AdjVolume.Equals(input.AdjVolume))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.Intraperiod != null)
                    hashCode = hashCode * 59 + this.Intraperiod.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.AdjOpen != null)
                    hashCode = hashCode * 59 + this.AdjOpen.GetHashCode();
                if (this.AdjHigh != null)
                    hashCode = hashCode * 59 + this.AdjHigh.GetHashCode();
                if (this.AdjLow != null)
                    hashCode = hashCode * 59 + this.AdjLow.GetHashCode();
                if (this.AdjClose != null)
                    hashCode = hashCode * 59 + this.AdjClose.GetHashCode();
                if (this.AdjVolume != null)
                    hashCode = hashCode * 59 + this.AdjVolume.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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



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
    /// Open, close, high, low, volume, average price, and change ratio for a particular interval
    /// </summary>
    [DataContract]
    public partial class StockPriceInterval :  IEquatable<StockPriceInterval>, IValidatableObject
    {
        /// <summary>
        /// The size of the interval.
        /// </summary>
        /// <value>The size of the interval.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            
            /// <summary>
            /// Enum SixtyMinute for value: SixtyMinute
            /// </summary>
            [EnumMember(Value = "SixtyMinute")]
            SixtyMinute = 1,
            
            /// <summary>
            /// Enum ThirtyMinute for value: ThirtyMinute
            /// </summary>
            [EnumMember(Value = "ThirtyMinute")]
            ThirtyMinute = 2,
            
            /// <summary>
            /// Enum FifteenMinute for value: FifteenMinute
            /// </summary>
            [EnumMember(Value = "FifteenMinute")]
            FifteenMinute = 3,
            
            /// <summary>
            /// Enum TenMinute for value: TenMinute
            /// </summary>
            [EnumMember(Value = "TenMinute")]
            TenMinute = 4,
            
            /// <summary>
            /// Enum FiveMinute for value: FiveMinute
            /// </summary>
            [EnumMember(Value = "FiveMinute")]
            FiveMinute = 5,
            
            /// <summary>
            /// Enum OneMinute for value: OneMinute
            /// </summary>
            [EnumMember(Value = "OneMinute")]
            OneMinute = 6
        }

        /// <summary>
        /// The size of the interval.
        /// </summary>
        /// <value>The size of the interval.</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public IntervalEnum? Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StockPriceInterval" /> class.
        /// </summary>
        /// <param name="Time">The timestamp that represents the start of the interval span..</param>
        /// <param name="Open">The first traded price during the period.</param>
        /// <param name="Close">The last traded price during the period.</param>
        /// <param name="High">The highest price over the span of the period.</param>
        /// <param name="Low">The lowest price over the span of the period.</param>
        /// <param name="Volume">The number of shares exchanged during the period.</param>
        /// <param name="CloseTime">The timestamp that represents the end of the interval span..</param>
        /// <param name="Interval">The size of the interval..</param>
        /// <param name="Average">The average trade price of an individual stock during the interval..</param>
        /// <param name="Change">The change ratio from open to close.  ((Close - Open)/Open)..</param>
        /// <param name="BidHigh">The highest bid price from the interval..</param>
        /// <param name="BidLow">The lowest bid price from the interval..</param>
        /// <param name="BidClose">The last bid price from the interval..</param>
        /// <param name="BidOpen">The first bid price from the interval..</param>
        /// <param name="BidFirstTime">The timestamp that represents the first bid time from the interval span..</param>
        /// <param name="BidLastTime">The timestamp that represents the last bid time from the interval span..</param>
        /// <param name="BidChangePercent">The ratio of the close to open bid difference, in percent..</param>
        /// <param name="AskHigh">The highest ask price from the interval..</param>
        /// <param name="AskLow">The lowest ask price from the interval..</param>
        /// <param name="AskClose">The last ask price from the interval..</param>
        /// <param name="AskOpen">The first ask price from the interval..</param>
        /// <param name="AskFirstTime">The timestamp that represents the first ask time from the interval span..</param>
        /// <param name="AskLastTime">The timestamp that represents the last ask time from the interval span..</param>
        /// <param name="AskChangePercent">The ratio of the close to open ask difference, in percent..</param>
        /// <param name="TradeCount">The number of qualified trades executed during the period.</param>
        public StockPriceInterval(DateTime? Time = default(DateTime?), decimal? Open = default(decimal?), decimal? Close = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Volume = default(decimal?), DateTime? CloseTime = default(DateTime?), IntervalEnum? Interval = default(IntervalEnum?), decimal? Average = default(decimal?), decimal? Change = default(decimal?), decimal? BidHigh = default(decimal?), decimal? BidLow = default(decimal?), decimal? BidClose = default(decimal?), decimal? BidOpen = default(decimal?), DateTime? BidFirstTime = default(DateTime?), DateTime? BidLastTime = default(DateTime?), decimal? BidChangePercent = default(decimal?), decimal? AskHigh = default(decimal?), decimal? AskLow = default(decimal?), decimal? AskClose = default(decimal?), decimal? AskOpen = default(decimal?), DateTime? AskFirstTime = default(DateTime?), DateTime? AskLastTime = default(DateTime?), decimal? AskChangePercent = default(decimal?), decimal? TradeCount = default(decimal?))
        {
            this.Time = Time;
            this.Open = Open;
            this.Close = Close;
            this.High = High;
            this.Low = Low;
            this.Volume = Volume;
            this.CloseTime = CloseTime;
            this.Interval = Interval;
            this.Average = Average;
            this.Change = Change;
            this.BidHigh = BidHigh;
            this.BidLow = BidLow;
            this.BidClose = BidClose;
            this.BidOpen = BidOpen;
            this.BidFirstTime = BidFirstTime;
            this.BidLastTime = BidLastTime;
            this.BidChangePercent = BidChangePercent;
            this.AskHigh = AskHigh;
            this.AskLow = AskLow;
            this.AskClose = AskClose;
            this.AskOpen = AskOpen;
            this.AskFirstTime = AskFirstTime;
            this.AskLastTime = AskLastTime;
            this.AskChangePercent = AskChangePercent;
            this.TradeCount = TradeCount;
        }
        
        /// <summary>
        /// The timestamp that represents the start of the interval span.
        /// </summary>
        /// <value>The timestamp that represents the start of the interval span.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The first traded price during the period
        /// </summary>
        /// <value>The first traded price during the period</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The last traded price during the period
        /// </summary>
        /// <value>The last traded price during the period</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

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
        /// The number of shares exchanged during the period
        /// </summary>
        /// <value>The number of shares exchanged during the period</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The timestamp that represents the end of the interval span.
        /// </summary>
        /// <value>The timestamp that represents the end of the interval span.</value>
        [DataMember(Name="close_time", EmitDefaultValue=false)]
        public DateTime? CloseTime { get; set; }


        /// <summary>
        /// The average trade price of an individual stock during the interval.
        /// </summary>
        /// <value>The average trade price of an individual stock during the interval.</value>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public decimal? Average { get; set; }

        /// <summary>
        /// The change ratio from open to close.  ((Close - Open)/Open).
        /// </summary>
        /// <value>The change ratio from open to close.  ((Close - Open)/Open).</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The highest bid price from the interval.
        /// </summary>
        /// <value>The highest bid price from the interval.</value>
        [DataMember(Name="bid_high", EmitDefaultValue=false)]
        public decimal? BidHigh { get; set; }

        /// <summary>
        /// The lowest bid price from the interval.
        /// </summary>
        /// <value>The lowest bid price from the interval.</value>
        [DataMember(Name="bid_low", EmitDefaultValue=false)]
        public decimal? BidLow { get; set; }

        /// <summary>
        /// The last bid price from the interval.
        /// </summary>
        /// <value>The last bid price from the interval.</value>
        [DataMember(Name="bid_close", EmitDefaultValue=false)]
        public decimal? BidClose { get; set; }

        /// <summary>
        /// The first bid price from the interval.
        /// </summary>
        /// <value>The first bid price from the interval.</value>
        [DataMember(Name="bid_open", EmitDefaultValue=false)]
        public decimal? BidOpen { get; set; }

        /// <summary>
        /// The timestamp that represents the first bid time from the interval span.
        /// </summary>
        /// <value>The timestamp that represents the first bid time from the interval span.</value>
        [DataMember(Name="bid_first_time", EmitDefaultValue=false)]
        public DateTime? BidFirstTime { get; set; }

        /// <summary>
        /// The timestamp that represents the last bid time from the interval span.
        /// </summary>
        /// <value>The timestamp that represents the last bid time from the interval span.</value>
        [DataMember(Name="bid_last_time", EmitDefaultValue=false)]
        public DateTime? BidLastTime { get; set; }

        /// <summary>
        /// The ratio of the close to open bid difference, in percent.
        /// </summary>
        /// <value>The ratio of the close to open bid difference, in percent.</value>
        [DataMember(Name="bid_change_percent", EmitDefaultValue=false)]
        public decimal? BidChangePercent { get; set; }

        /// <summary>
        /// The highest ask price from the interval.
        /// </summary>
        /// <value>The highest ask price from the interval.</value>
        [DataMember(Name="ask_high", EmitDefaultValue=false)]
        public decimal? AskHigh { get; set; }

        /// <summary>
        /// The lowest ask price from the interval.
        /// </summary>
        /// <value>The lowest ask price from the interval.</value>
        [DataMember(Name="ask_low", EmitDefaultValue=false)]
        public decimal? AskLow { get; set; }

        /// <summary>
        /// The last ask price from the interval.
        /// </summary>
        /// <value>The last ask price from the interval.</value>
        [DataMember(Name="ask_close", EmitDefaultValue=false)]
        public decimal? AskClose { get; set; }

        /// <summary>
        /// The first ask price from the interval.
        /// </summary>
        /// <value>The first ask price from the interval.</value>
        [DataMember(Name="ask_open", EmitDefaultValue=false)]
        public decimal? AskOpen { get; set; }

        /// <summary>
        /// The timestamp that represents the first ask time from the interval span.
        /// </summary>
        /// <value>The timestamp that represents the first ask time from the interval span.</value>
        [DataMember(Name="ask_first_time", EmitDefaultValue=false)]
        public DateTime? AskFirstTime { get; set; }

        /// <summary>
        /// The timestamp that represents the last ask time from the interval span.
        /// </summary>
        /// <value>The timestamp that represents the last ask time from the interval span.</value>
        [DataMember(Name="ask_last_time", EmitDefaultValue=false)]
        public DateTime? AskLastTime { get; set; }

        /// <summary>
        /// The ratio of the close to open ask difference, in percent.
        /// </summary>
        /// <value>The ratio of the close to open ask difference, in percent.</value>
        [DataMember(Name="ask_change_percent", EmitDefaultValue=false)]
        public decimal? AskChangePercent { get; set; }

        /// <summary>
        /// The number of qualified trades executed during the period
        /// </summary>
        /// <value>The number of qualified trades executed during the period</value>
        [DataMember(Name="trade_count", EmitDefaultValue=false)]
        public decimal? TradeCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockPriceInterval {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  BidHigh: ").Append(BidHigh).Append("\n");
            sb.Append("  BidLow: ").Append(BidLow).Append("\n");
            sb.Append("  BidClose: ").Append(BidClose).Append("\n");
            sb.Append("  BidOpen: ").Append(BidOpen).Append("\n");
            sb.Append("  BidFirstTime: ").Append(BidFirstTime).Append("\n");
            sb.Append("  BidLastTime: ").Append(BidLastTime).Append("\n");
            sb.Append("  BidChangePercent: ").Append(BidChangePercent).Append("\n");
            sb.Append("  AskHigh: ").Append(AskHigh).Append("\n");
            sb.Append("  AskLow: ").Append(AskLow).Append("\n");
            sb.Append("  AskClose: ").Append(AskClose).Append("\n");
            sb.Append("  AskOpen: ").Append(AskOpen).Append("\n");
            sb.Append("  AskFirstTime: ").Append(AskFirstTime).Append("\n");
            sb.Append("  AskLastTime: ").Append(AskLastTime).Append("\n");
            sb.Append("  AskChangePercent: ").Append(AskChangePercent).Append("\n");
            sb.Append("  TradeCount: ").Append(TradeCount).Append("\n");
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
            return this.Equals(input as StockPriceInterval);
        }

        /// <summary>
        /// Returns true if StockPriceInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of StockPriceInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockPriceInterval input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
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
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.CloseTime == input.CloseTime ||
                    (this.CloseTime != null &&
                    this.CloseTime.Equals(input.CloseTime))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Average == input.Average ||
                    (this.Average != null &&
                    this.Average.Equals(input.Average))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.BidHigh == input.BidHigh ||
                    (this.BidHigh != null &&
                    this.BidHigh.Equals(input.BidHigh))
                ) && 
                (
                    this.BidLow == input.BidLow ||
                    (this.BidLow != null &&
                    this.BidLow.Equals(input.BidLow))
                ) && 
                (
                    this.BidClose == input.BidClose ||
                    (this.BidClose != null &&
                    this.BidClose.Equals(input.BidClose))
                ) && 
                (
                    this.BidOpen == input.BidOpen ||
                    (this.BidOpen != null &&
                    this.BidOpen.Equals(input.BidOpen))
                ) && 
                (
                    this.BidFirstTime == input.BidFirstTime ||
                    (this.BidFirstTime != null &&
                    this.BidFirstTime.Equals(input.BidFirstTime))
                ) && 
                (
                    this.BidLastTime == input.BidLastTime ||
                    (this.BidLastTime != null &&
                    this.BidLastTime.Equals(input.BidLastTime))
                ) && 
                (
                    this.BidChangePercent == input.BidChangePercent ||
                    (this.BidChangePercent != null &&
                    this.BidChangePercent.Equals(input.BidChangePercent))
                ) && 
                (
                    this.AskHigh == input.AskHigh ||
                    (this.AskHigh != null &&
                    this.AskHigh.Equals(input.AskHigh))
                ) && 
                (
                    this.AskLow == input.AskLow ||
                    (this.AskLow != null &&
                    this.AskLow.Equals(input.AskLow))
                ) && 
                (
                    this.AskClose == input.AskClose ||
                    (this.AskClose != null &&
                    this.AskClose.Equals(input.AskClose))
                ) && 
                (
                    this.AskOpen == input.AskOpen ||
                    (this.AskOpen != null &&
                    this.AskOpen.Equals(input.AskOpen))
                ) && 
                (
                    this.AskFirstTime == input.AskFirstTime ||
                    (this.AskFirstTime != null &&
                    this.AskFirstTime.Equals(input.AskFirstTime))
                ) && 
                (
                    this.AskLastTime == input.AskLastTime ||
                    (this.AskLastTime != null &&
                    this.AskLastTime.Equals(input.AskLastTime))
                ) && 
                (
                    this.AskChangePercent == input.AskChangePercent ||
                    (this.AskChangePercent != null &&
                    this.AskChangePercent.Equals(input.AskChangePercent))
                ) && 
                (
                    this.TradeCount == input.TradeCount ||
                    (this.TradeCount != null &&
                    this.TradeCount.Equals(input.TradeCount))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.CloseTime != null)
                    hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Average != null)
                    hashCode = hashCode * 59 + this.Average.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.BidHigh != null)
                    hashCode = hashCode * 59 + this.BidHigh.GetHashCode();
                if (this.BidLow != null)
                    hashCode = hashCode * 59 + this.BidLow.GetHashCode();
                if (this.BidClose != null)
                    hashCode = hashCode * 59 + this.BidClose.GetHashCode();
                if (this.BidOpen != null)
                    hashCode = hashCode * 59 + this.BidOpen.GetHashCode();
                if (this.BidFirstTime != null)
                    hashCode = hashCode * 59 + this.BidFirstTime.GetHashCode();
                if (this.BidLastTime != null)
                    hashCode = hashCode * 59 + this.BidLastTime.GetHashCode();
                if (this.BidChangePercent != null)
                    hashCode = hashCode * 59 + this.BidChangePercent.GetHashCode();
                if (this.AskHigh != null)
                    hashCode = hashCode * 59 + this.AskHigh.GetHashCode();
                if (this.AskLow != null)
                    hashCode = hashCode * 59 + this.AskLow.GetHashCode();
                if (this.AskClose != null)
                    hashCode = hashCode * 59 + this.AskClose.GetHashCode();
                if (this.AskOpen != null)
                    hashCode = hashCode * 59 + this.AskOpen.GetHashCode();
                if (this.AskFirstTime != null)
                    hashCode = hashCode * 59 + this.AskFirstTime.GetHashCode();
                if (this.AskLastTime != null)
                    hashCode = hashCode * 59 + this.AskLastTime.GetHashCode();
                if (this.AskChangePercent != null)
                    hashCode = hashCode * 59 + this.AskChangePercent.GetHashCode();
                if (this.TradeCount != null)
                    hashCode = hashCode * 59 + this.TradeCount.GetHashCode();
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

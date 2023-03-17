

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
        public StockPriceInterval(DateTime? Time = default(DateTime?), decimal? Open = default(decimal?), decimal? Close = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Volume = default(decimal?), DateTime? CloseTime = default(DateTime?), IntervalEnum? Interval = default(IntervalEnum?), decimal? Average = default(decimal?), decimal? Change = default(decimal?))
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

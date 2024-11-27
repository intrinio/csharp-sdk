

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
    /// A security interval data point.
    /// </summary>
    [DataContract]
    public partial class SecurityIntervalMover :  IEquatable<SecurityIntervalMover>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityIntervalMover" /> class.
        /// </summary>
        /// <param name="Symbol">The ticker symbol for the interval.</param>
        /// <param name="Change">The ratio of Close minus Open to Open..</param>
        /// <param name="Open">The first traded price in this interval..</param>
        /// <param name="High">The highest traded price in this interval..</param>
        /// <param name="Low">The lowest traded price in this interval..</param>
        /// <param name="Close">The last traded price in this interval..</param>
        /// <param name="Volume">The volume of shares in this interval..</param>
        /// <param name="Average">The volume weighted average price of trades in this interval..</param>
        /// <param name="TradeCount">The of trades in this interval..</param>
        public SecurityIntervalMover(string Symbol = default(string), decimal? Change = default(decimal?), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Close = default(decimal?), decimal? Volume = default(decimal?), decimal? Average = default(decimal?), decimal? TradeCount = default(decimal?))
        {
            this.Symbol = Symbol;
            this.Change = Change;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Close = Close;
            this.Volume = Volume;
            this.Average = Average;
            this.TradeCount = TradeCount;
        }
        
        /// <summary>
        /// The ticker symbol for the interval
        /// </summary>
        /// <value>The ticker symbol for the interval</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The ratio of Close minus Open to Open.
        /// </summary>
        /// <value>The ratio of Close minus Open to Open.</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The first traded price in this interval.
        /// </summary>
        /// <value>The first traded price in this interval.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The highest traded price in this interval.
        /// </summary>
        /// <value>The highest traded price in this interval.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest traded price in this interval.
        /// </summary>
        /// <value>The lowest traded price in this interval.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The last traded price in this interval.
        /// </summary>
        /// <value>The last traded price in this interval.</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The volume of shares in this interval.
        /// </summary>
        /// <value>The volume of shares in this interval.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The volume weighted average price of trades in this interval.
        /// </summary>
        /// <value>The volume weighted average price of trades in this interval.</value>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public decimal? Average { get; set; }

        /// <summary>
        /// The of trades in this interval.
        /// </summary>
        /// <value>The of trades in this interval.</value>
        [DataMember(Name="trade_count", EmitDefaultValue=false)]
        public decimal? TradeCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityIntervalMover {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
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
            return this.Equals(input as SecurityIntervalMover);
        }

        /// <summary>
        /// Returns true if SecurityIntervalMover instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityIntervalMover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityIntervalMover input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
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
                    this.Average == input.Average ||
                    (this.Average != null &&
                    this.Average.Equals(input.Average))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
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
                if (this.Average != null)
                    hashCode = hashCode * 59 + this.Average.GetHashCode();
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

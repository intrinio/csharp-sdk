

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
    /// Open, High, Low, Close, and Volume for a particular interval
    /// </summary>
    [DataContract]
    public partial class StockPriceInterval :  IEquatable<StockPriceInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockPriceInterval" /> class.
        /// </summary>
        /// <param name="Time">The timestamp that the &#x60;last_price&#x60; represents..</param>
        /// <param name="Open">The price at the beginning of the period.</param>
        /// <param name="Close">The price at the end of the period.</param>
        /// <param name="High">The highest price over the span of the period.</param>
        /// <param name="Low">The lowest price over the span of the period.</param>
        /// <param name="Volume">The number of shares exchanged during the period.</param>
        public StockPriceInterval(DateTime? Time = default(DateTime?), decimal? Open = default(decimal?), decimal? Close = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Volume = default(decimal?))
        {
            this.Time = Time;
            this.Open = Open;
            this.Close = Close;
            this.High = High;
            this.Low = Low;
            this.Volume = Volume;
        }
        
        /// <summary>
        /// The timestamp that the &#x60;last_price&#x60; represents.
        /// </summary>
        /// <value>The timestamp that the &#x60;last_price&#x60; represents.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The price at the beginning of the period
        /// </summary>
        /// <value>The price at the beginning of the period</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The price at the end of the period
        /// </summary>
        /// <value>The price at the end of the period</value>
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

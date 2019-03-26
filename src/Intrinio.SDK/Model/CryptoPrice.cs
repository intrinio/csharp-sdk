

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
    /// All the BAR prices, time, and volume for the given Crypto Currency Pair on the given Crypto Exchange.
    /// </summary>
    [DataContract]
    public partial class CryptoPrice :  IEquatable<CryptoPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoPrice" /> class.
        /// </summary>
        /// <param name="Time">The date and time of the beginning of the timeframe (in UTC). The open prices would be at this time, while close prices would be at this time plus the timeframe..</param>
        /// <param name="Open">The opening price of the timeframe..</param>
        /// <param name="High">The high price of the timeframe..</param>
        /// <param name="Low">The low price of the timeframe..</param>
        /// <param name="Close">The closing price of the timeframe..</param>
        /// <param name="Volume">The volume during the timeframe..</param>
        public CryptoPrice(string Time = default(string), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Close = default(decimal?), decimal? Volume = default(decimal?))
        {
            this.Time = Time;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Close = Close;
            this.Volume = Volume;
        }
        
        /// <summary>
        /// The date and time of the beginning of the timeframe (in UTC). The open prices would be at this time, while close prices would be at this time plus the timeframe.
        /// </summary>
        /// <value>The date and time of the beginning of the timeframe (in UTC). The open prices would be at this time, while close prices would be at this time plus the timeframe.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// The opening price of the timeframe.
        /// </summary>
        /// <value>The opening price of the timeframe.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The high price of the timeframe.
        /// </summary>
        /// <value>The high price of the timeframe.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The low price of the timeframe.
        /// </summary>
        /// <value>The low price of the timeframe.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The closing price of the timeframe.
        /// </summary>
        /// <value>The closing price of the timeframe.</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The volume during the timeframe.
        /// </summary>
        /// <value>The volume during the timeframe.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoPrice {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
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
            return this.Equals(input as CryptoPrice);
        }

        /// <summary>
        /// Returns true if CryptoPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoPrice input)
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
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
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

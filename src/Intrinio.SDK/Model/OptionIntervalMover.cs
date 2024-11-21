

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
    /// An options interval data point.
    /// </summary>
    [DataContract]
    public partial class OptionIntervalMover :  IEquatable<OptionIntervalMover>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionIntervalMover" /> class.
        /// </summary>
        /// <param name="Contract">The option contract for the intervals.</param>
        /// <param name="Change">The ratio of Close minus Open to Open..</param>
        /// <param name="Open">The first traded contract price in this interval..</param>
        /// <param name="High">The highest traded contract price in this interval..</param>
        /// <param name="Low">The lowest traded contract price in this interval..</param>
        /// <param name="Close">The last traded contract price in this interval..</param>
        /// <param name="Volume">The volume of contract trades in this interval..</param>
        /// <param name="Average">The volume weighted average price of contract trades in this interval..</param>
        public OptionIntervalMover(string Contract = default(string), decimal? Change = default(decimal?), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Close = default(decimal?), decimal? Volume = default(decimal?), decimal? Average = default(decimal?))
        {
            this.Contract = Contract;
            this.Change = Change;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Close = Close;
            this.Volume = Volume;
            this.Average = Average;
        }
        
        /// <summary>
        /// The option contract for the intervals
        /// </summary>
        /// <value>The option contract for the intervals</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// The ratio of Close minus Open to Open.
        /// </summary>
        /// <value>The ratio of Close minus Open to Open.</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The first traded contract price in this interval.
        /// </summary>
        /// <value>The first traded contract price in this interval.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The highest traded contract price in this interval.
        /// </summary>
        /// <value>The highest traded contract price in this interval.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest traded contract price in this interval.
        /// </summary>
        /// <value>The lowest traded contract price in this interval.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The last traded contract price in this interval.
        /// </summary>
        /// <value>The last traded contract price in this interval.</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The volume of contract trades in this interval.
        /// </summary>
        /// <value>The volume of contract trades in this interval.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The volume weighted average price of contract trades in this interval.
        /// </summary>
        /// <value>The volume weighted average price of contract trades in this interval.</value>
        [DataMember(Name="average", EmitDefaultValue=false)]
        public decimal? Average { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionIntervalMover {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Average: ").Append(Average).Append("\n");
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
            return this.Equals(input as OptionIntervalMover);
        }

        /// <summary>
        /// Returns true if OptionIntervalMover instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionIntervalMover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionIntervalMover input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
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

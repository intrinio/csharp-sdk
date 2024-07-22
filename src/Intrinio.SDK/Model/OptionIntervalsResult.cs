

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
    /// An options intervals result contains all options intervals corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class OptionIntervalsResult :  IEquatable<OptionIntervalsResult>, IValidatableObject
    {
        /// <summary>
        /// The size of the time span for the interval.
        /// </summary>
        /// <value>The size of the time span for the interval.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeEnum
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
        /// The size of the time span for the interval.
        /// </summary>
        /// <value>The size of the time span for the interval.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionIntervalsResult" /> class.
        /// </summary>
        /// <param name="Intervals">Array of all the intervals in the result..</param>
        /// <param name="Contract">The option contract for the intervals.</param>
        /// <param name="Size">The size of the time span for the interval..</param>
        public OptionIntervalsResult(List<OptionInterval> Intervals = default(List<OptionInterval>), string Contract = default(string), SizeEnum? Size = default(SizeEnum?))
        {
            this.Intervals = Intervals;
            this.Contract = Contract;
            this.Size = Size;
        }
        
        /// <summary>
        /// Array of all the intervals in the result.
        /// </summary>
        /// <value>Array of all the intervals in the result.</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<OptionInterval> Intervals { get; set; }

        /// <summary>
        /// The option contract for the intervals
        /// </summary>
        /// <value>The option contract for the intervals</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionIntervalsResult {\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as OptionIntervalsResult);
        }

        /// <summary>
        /// Returns true if OptionIntervalsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionIntervalsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionIntervalsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Intervals == input.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(input.Intervals)
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Intervals != null)
                    hashCode = hashCode * 59 + this.Intervals.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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

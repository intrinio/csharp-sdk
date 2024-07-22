

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
    /// An security intervals result contains all security intervals corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class SecurityIntervalsMoversResult :  IEquatable<SecurityIntervalsMoversResult>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="SecurityIntervalsMoversResult" /> class.
        /// </summary>
        /// <param name="OpenTime">The UTC timestamp for the time this interval opened..</param>
        /// <param name="CloseTime">The UTC timestamp for the time this interval closed..</param>
        /// <param name="Size">The size of the time span for the interval..</param>
        /// <param name="Intervals">Array of all the intervals in the result..</param>
        public SecurityIntervalsMoversResult(DateTime? OpenTime = default(DateTime?), DateTime? CloseTime = default(DateTime?), SizeEnum? Size = default(SizeEnum?), List<SecurityIntervalMover> Intervals = default(List<SecurityIntervalMover>))
        {
            this.OpenTime = OpenTime;
            this.CloseTime = CloseTime;
            this.Size = Size;
            this.Intervals = Intervals;
        }
        
        /// <summary>
        /// The UTC timestamp for the time this interval opened.
        /// </summary>
        /// <value>The UTC timestamp for the time this interval opened.</value>
        [DataMember(Name="open_time", EmitDefaultValue=false)]
        public DateTime? OpenTime { get; set; }

        /// <summary>
        /// The UTC timestamp for the time this interval closed.
        /// </summary>
        /// <value>The UTC timestamp for the time this interval closed.</value>
        [DataMember(Name="close_time", EmitDefaultValue=false)]
        public DateTime? CloseTime { get; set; }


        /// <summary>
        /// Array of all the intervals in the result.
        /// </summary>
        /// <value>Array of all the intervals in the result.</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<SecurityIntervalMover> Intervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityIntervalsMoversResult {\n");
            sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
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
            return this.Equals(input as SecurityIntervalsMoversResult);
        }

        /// <summary>
        /// Returns true if SecurityIntervalsMoversResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityIntervalsMoversResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityIntervalsMoversResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpenTime == input.OpenTime ||
                    (this.OpenTime != null &&
                    this.OpenTime.Equals(input.OpenTime))
                ) && 
                (
                    this.CloseTime == input.CloseTime ||
                    (this.CloseTime != null &&
                    this.CloseTime.Equals(input.CloseTime))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Intervals == input.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(input.Intervals)
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
                if (this.OpenTime != null)
                    hashCode = hashCode * 59 + this.OpenTime.GetHashCode();
                if (this.CloseTime != null)
                    hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Intervals != null)
                    hashCode = hashCode * 59 + this.Intervals.GetHashCode();
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



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
    /// EarningsDateEstimateConfidenceIntervals
    /// </summary>
    [DataContract]
    public partial class EarningsDateEstimateConfidenceIntervals :  IEquatable<EarningsDateEstimateConfidenceIntervals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarningsDateEstimateConfidenceIntervals" /> class.
        /// </summary>
        /// <param name="Earliest">The earliest date in this confidence interval.</param>
        /// <param name="Latest">The latest date in this confidence interval.</param>
        public EarningsDateEstimateConfidenceIntervals(DateTime? Earliest = default(DateTime?), DateTime? Latest = default(DateTime?))
        {
            this.Earliest = Earliest;
            this.Latest = Latest;
        }
        
        /// <summary>
        /// The earliest date in this confidence interval
        /// </summary>
        /// <value>The earliest date in this confidence interval</value>
        [DataMember(Name="earliest", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Earliest { get; set; }

        /// <summary>
        /// The latest date in this confidence interval
        /// </summary>
        /// <value>The latest date in this confidence interval</value>
        [DataMember(Name="latest", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Latest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsDateEstimateConfidenceIntervals {\n");
            sb.Append("  Earliest: ").Append(Earliest).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
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
            return this.Equals(input as EarningsDateEstimateConfidenceIntervals);
        }

        /// <summary>
        /// Returns true if EarningsDateEstimateConfidenceIntervals instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsDateEstimateConfidenceIntervals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsDateEstimateConfidenceIntervals input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Earliest == input.Earliest ||
                    (this.Earliest != null &&
                    this.Earliest.Equals(input.Earliest))
                ) && 
                (
                    this.Latest == input.Latest ||
                    (this.Latest != null &&
                    this.Latest.Equals(input.Latest))
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
                if (this.Earliest != null)
                    hashCode = hashCode * 59 + this.Earliest.GetHashCode();
                if (this.Latest != null)
                    hashCode = hashCode * 59 + this.Latest.GetHashCode();
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

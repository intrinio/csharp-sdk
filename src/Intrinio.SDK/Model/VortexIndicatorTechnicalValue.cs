

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
    /// The date_time, negative_vi, and positive_vi values of a Vortex Indicator technical indicator calculation
    /// </summary>
    [DataContract]
    public partial class VortexIndicatorTechnicalValue :  IEquatable<VortexIndicatorTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VortexIndicatorTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="NegativeVi">The negative Vortex Indicator value.</param>
        /// <param name="PositiveVi">The positive Vortex Indicator value.</param>
        public VortexIndicatorTechnicalValue(DateTime? DateTime = default(DateTime?), float? NegativeVi = default(float?), float? PositiveVi = default(float?))
        {
            this.DateTime = DateTime;
            this.NegativeVi = NegativeVi;
            this.PositiveVi = PositiveVi;
        }
        
        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The negative Vortex Indicator value
        /// </summary>
        /// <value>The negative Vortex Indicator value</value>
        [DataMember(Name="negative_vi", EmitDefaultValue=false)]
        public float? NegativeVi { get; set; }

        /// <summary>
        /// The positive Vortex Indicator value
        /// </summary>
        /// <value>The positive Vortex Indicator value</value>
        [DataMember(Name="positive_vi", EmitDefaultValue=false)]
        public float? PositiveVi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VortexIndicatorTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  NegativeVi: ").Append(NegativeVi).Append("\n");
            sb.Append("  PositiveVi: ").Append(PositiveVi).Append("\n");
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
            return this.Equals(input as VortexIndicatorTechnicalValue);
        }

        /// <summary>
        /// Returns true if VortexIndicatorTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of VortexIndicatorTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VortexIndicatorTechnicalValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.NegativeVi == input.NegativeVi ||
                    (this.NegativeVi != null &&
                    this.NegativeVi.Equals(input.NegativeVi))
                ) && 
                (
                    this.PositiveVi == input.PositiveVi ||
                    (this.PositiveVi != null &&
                    this.PositiveVi.Equals(input.PositiveVi))
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
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.NegativeVi != null)
                    hashCode = hashCode * 59 + this.NegativeVi.GetHashCode();
                if (this.PositiveVi != null)
                    hashCode = hashCode * 59 + this.PositiveVi.GetHashCode();
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

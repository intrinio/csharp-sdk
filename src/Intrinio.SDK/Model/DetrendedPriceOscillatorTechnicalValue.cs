

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
    /// The date_time and dpo values of a Detrended Price Oscillator technical indicator calculation
    /// </summary>
    [DataContract]
    public partial class DetrendedPriceOscillatorTechnicalValue :  IEquatable<DetrendedPriceOscillatorTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetrendedPriceOscillatorTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Dpo">The Detrended Price Oscillator calculation value.</param>
        public DetrendedPriceOscillatorTechnicalValue(DateTime? DateTime = default(DateTime?), float? Dpo = default(float?))
        {
            this.DateTime = DateTime;
            this.Dpo = Dpo;
        }
        
        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Detrended Price Oscillator calculation value
        /// </summary>
        /// <value>The Detrended Price Oscillator calculation value</value>
        [DataMember(Name="dpo", EmitDefaultValue=false)]
        public float? Dpo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetrendedPriceOscillatorTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Dpo: ").Append(Dpo).Append("\n");
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
            return this.Equals(input as DetrendedPriceOscillatorTechnicalValue);
        }

        /// <summary>
        /// Returns true if DetrendedPriceOscillatorTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of DetrendedPriceOscillatorTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetrendedPriceOscillatorTechnicalValue input)
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
                    this.Dpo == input.Dpo ||
                    (this.Dpo != null &&
                    this.Dpo.Equals(input.Dpo))
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
                if (this.Dpo != null)
                    hashCode = hashCode * 59 + this.Dpo.GetHashCode();
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

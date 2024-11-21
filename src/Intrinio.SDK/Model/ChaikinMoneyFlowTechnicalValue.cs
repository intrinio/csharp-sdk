

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
    /// The date_time and cmf values of a Chaikin Money Flow technical indicator calculation
    /// </summary>
    [DataContract]
    public partial class ChaikinMoneyFlowTechnicalValue :  IEquatable<ChaikinMoneyFlowTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChaikinMoneyFlowTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="Cmf">The Chaikin Money Flow calculation value.</param>
        public ChaikinMoneyFlowTechnicalValue(DateTime? DateTime = default(DateTime?), float? Cmf = default(float?))
        {
            this.DateTime = DateTime;
            this.Cmf = Cmf;
        }
        
        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Chaikin Money Flow calculation value
        /// </summary>
        /// <value>The Chaikin Money Flow calculation value</value>
        [DataMember(Name="cmf", EmitDefaultValue=false)]
        public float? Cmf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChaikinMoneyFlowTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Cmf: ").Append(Cmf).Append("\n");
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
            return this.Equals(input as ChaikinMoneyFlowTechnicalValue);
        }

        /// <summary>
        /// Returns true if ChaikinMoneyFlowTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ChaikinMoneyFlowTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChaikinMoneyFlowTechnicalValue input)
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
                    this.Cmf == input.Cmf ||
                    (this.Cmf != null &&
                    this.Cmf.Equals(input.Cmf))
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
                if (this.Cmf != null)
                    hashCode = hashCode * 59 + this.Cmf.GetHashCode();
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

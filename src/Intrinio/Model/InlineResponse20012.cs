

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// InlineResponse20012
    /// </summary>
    [DataContract]
    public partial class InlineResponse20012 :  IEquatable<InlineResponse20012>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20012" /> class.
        /// </summary>
        /// <param name="StandardizedFinancials">StandardizedFinancials.</param>
        /// <param name="Fundamental">Fundamental.</param>
        public InlineResponse20012(List<StandardizedFinancial> StandardizedFinancials = default(List<StandardizedFinancial>), Fundamental Fundamental = default(Fundamental))
        {
            this.StandardizedFinancials = StandardizedFinancials;
            this.Fundamental = Fundamental;
        }
        
        /// <summary>
        /// Gets or Sets StandardizedFinancials
        /// </summary>
        [DataMember(Name="standardized_financials", EmitDefaultValue=false)]
        public List<StandardizedFinancial> StandardizedFinancials { get; set; }

        /// <summary>
        /// Gets or Sets Fundamental
        /// </summary>
        [DataMember(Name="fundamental", EmitDefaultValue=false)]
        public Fundamental Fundamental { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20012 {\n");
            sb.Append("  StandardizedFinancials: ").Append(StandardizedFinancials).Append("\n");
            sb.Append("  Fundamental: ").Append(Fundamental).Append("\n");
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
            return this.Equals(input as InlineResponse20012);
        }

        /// <summary>
        /// Returns true if InlineResponse20012 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20012 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20012 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StandardizedFinancials == input.StandardizedFinancials ||
                    this.StandardizedFinancials != null &&
                    this.StandardizedFinancials.SequenceEqual(input.StandardizedFinancials)
                ) && 
                (
                    this.Fundamental == input.Fundamental ||
                    (this.Fundamental != null &&
                    this.Fundamental.Equals(input.Fundamental))
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
                if (this.StandardizedFinancials != null)
                    hashCode = hashCode * 59 + this.StandardizedFinancials.GetHashCode();
                if (this.Fundamental != null)
                    hashCode = hashCode * 59 + this.Fundamental.GetHashCode();
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

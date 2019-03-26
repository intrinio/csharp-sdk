

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
    /// ApiResponseOptionsChain
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsChain :  IEquatable<ApiResponseOptionsChain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsChain" /> class.
        /// </summary>
        /// <param name="Chains">A list of options for the provided expiration date their respective option prices..</param>
        public ApiResponseOptionsChain(List<OptionChain> Chains = default(List<OptionChain>))
        {
            this.Chains = Chains;
        }
        
        /// <summary>
        /// A list of options for the provided expiration date their respective option prices.
        /// </summary>
        /// <value>A list of options for the provided expiration date their respective option prices.</value>
        [DataMember(Name="chains", EmitDefaultValue=false)]
        public List<OptionChain> Chains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsChain {\n");
            sb.Append("  Chains: ").Append(Chains).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsChain);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsChain instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsChain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsChain input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chains == input.Chains ||
                    this.Chains != null &&
                    this.Chains.SequenceEqual(input.Chains)
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
                if (this.Chains != null)
                    hashCode = hashCode * 59 + this.Chains.GetHashCode();
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

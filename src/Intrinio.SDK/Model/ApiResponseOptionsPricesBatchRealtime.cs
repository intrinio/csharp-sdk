

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
    /// ApiResponseOptionsPricesBatchRealtime
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsPricesBatchRealtime :  IEquatable<ApiResponseOptionsPricesBatchRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsPricesBatchRealtime" /> class.
        /// </summary>
        /// <param name="Contracts">Contracts.</param>
        public ApiResponseOptionsPricesBatchRealtime(List<OptionPriceBatchRealtime> Contracts = default(List<OptionPriceBatchRealtime>))
        {
            this.Contracts = Contracts;
        }
        
        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public List<OptionPriceBatchRealtime> Contracts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsPricesBatchRealtime {\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsPricesBatchRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsPricesBatchRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsPricesBatchRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsPricesBatchRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contracts == input.Contracts ||
                    this.Contracts != null &&
                    this.Contracts.SequenceEqual(input.Contracts)
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
                if (this.Contracts != null)
                    hashCode = hashCode * 59 + this.Contracts.GetHashCode();
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

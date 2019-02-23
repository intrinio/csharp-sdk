

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
    /// ApiResponseForexPairs
    /// </summary>
    [DataContract]
    public partial class ApiResponseForexPairs :  IEquatable<ApiResponseForexPairs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseForexPairs" /> class.
        /// </summary>
        /// <param name="Pairs">Pairs.</param>
        public ApiResponseForexPairs(List<ForexPair> Pairs = default(List<ForexPair>))
        {
            this.Pairs = Pairs;
        }
        
        /// <summary>
        /// Gets or Sets Pairs
        /// </summary>
        [DataMember(Name="pairs", EmitDefaultValue=false)]
        public List<ForexPair> Pairs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseForexPairs {\n");
            sb.Append("  Pairs: ").Append(Pairs).Append("\n");
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
            return this.Equals(input as ApiResponseForexPairs);
        }

        /// <summary>
        /// Returns true if ApiResponseForexPairs instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseForexPairs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseForexPairs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pairs == input.Pairs ||
                    this.Pairs != null &&
                    this.Pairs.SequenceEqual(input.Pairs)
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
                if (this.Pairs != null)
                    hashCode = hashCode * 59 + this.Pairs.GetHashCode();
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

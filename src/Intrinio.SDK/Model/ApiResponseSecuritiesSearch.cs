

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
    /// ApiResponseSecuritiesSearch
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecuritiesSearch :  IEquatable<ApiResponseSecuritiesSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecuritiesSearch" /> class.
        /// </summary>
        /// <param name="Securities">Securities.</param>
        public ApiResponseSecuritiesSearch(List<SecuritySummary> Securities = default(List<SecuritySummary>))
        {
            this.Securities = Securities;
        }
        
        /// <summary>
        /// Gets or Sets Securities
        /// </summary>
        [DataMember(Name="securities", EmitDefaultValue=false)]
        public List<SecuritySummary> Securities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecuritiesSearch {\n");
            sb.Append("  Securities: ").Append(Securities).Append("\n");
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
            return this.Equals(input as ApiResponseSecuritiesSearch);
        }

        /// <summary>
        /// Returns true if ApiResponseSecuritiesSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecuritiesSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecuritiesSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Securities == input.Securities ||
                    this.Securities != null &&
                    this.Securities.SequenceEqual(input.Securities)
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
                if (this.Securities != null)
                    hashCode = hashCode * 59 + this.Securities.GetHashCode();
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

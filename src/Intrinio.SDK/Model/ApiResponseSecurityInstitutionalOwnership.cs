

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
    /// ApiResponseSecurityInstitutionalOwnership
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityInstitutionalOwnership :  IEquatable<ApiResponseSecurityInstitutionalOwnership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityInstitutionalOwnership" /> class.
        /// </summary>
        /// <param name="Ownership">Ownership.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityInstitutionalOwnership(List<InstitutionalOwnership> Ownership = default(List<InstitutionalOwnership>), string NextPage = default(string))
        {
            this.Ownership = Ownership;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets Ownership
        /// </summary>
        [DataMember(Name="ownership", EmitDefaultValue=false)]
        public List<InstitutionalOwnership> Ownership { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityInstitutionalOwnership {\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityInstitutionalOwnership);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityInstitutionalOwnership instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityInstitutionalOwnership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityInstitutionalOwnership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ownership == input.Ownership ||
                    this.Ownership != null &&
                    this.Ownership.SequenceEqual(input.Ownership)
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.Ownership != null)
                    hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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

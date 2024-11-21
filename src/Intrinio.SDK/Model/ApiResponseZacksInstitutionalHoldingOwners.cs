

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
    /// ApiResponseZacksInstitutionalHoldingOwners
    /// </summary>
    [DataContract]
    public partial class ApiResponseZacksInstitutionalHoldingOwners :  IEquatable<ApiResponseZacksInstitutionalHoldingOwners>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseZacksInstitutionalHoldingOwners" /> class.
        /// </summary>
        /// <param name="Owners">Zacks institutional holding owners data.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseZacksInstitutionalHoldingOwners(List<ZacksInstitutionalHoldingOwnerDetail> Owners = default(List<ZacksInstitutionalHoldingOwnerDetail>), string NextPage = default(string))
        {
            this.Owners = Owners;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Zacks institutional holding owners data
        /// </summary>
        /// <value>Zacks institutional holding owners data</value>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<ZacksInstitutionalHoldingOwnerDetail> Owners { get; set; }

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
            sb.Append("class ApiResponseZacksInstitutionalHoldingOwners {\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
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
            return this.Equals(input as ApiResponseZacksInstitutionalHoldingOwners);
        }

        /// <summary>
        /// Returns true if ApiResponseZacksInstitutionalHoldingOwners instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseZacksInstitutionalHoldingOwners to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseZacksInstitutionalHoldingOwners input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
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
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
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

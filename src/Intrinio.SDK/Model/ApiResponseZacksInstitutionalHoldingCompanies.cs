

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
    /// ApiResponseZacksInstitutionalHoldingCompanies
    /// </summary>
    [DataContract]
    public partial class ApiResponseZacksInstitutionalHoldingCompanies :  IEquatable<ApiResponseZacksInstitutionalHoldingCompanies>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseZacksInstitutionalHoldingCompanies" /> class.
        /// </summary>
        /// <param name="Companies">Zacks institutional holding company data.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseZacksInstitutionalHoldingCompanies(List<ZacksInstitutionalHoldingCompanyDetail> Companies = default(List<ZacksInstitutionalHoldingCompanyDetail>), string NextPage = default(string))
        {
            this.Companies = Companies;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Zacks institutional holding company data
        /// </summary>
        /// <value>Zacks institutional holding company data</value>
        [DataMember(Name="companies", EmitDefaultValue=false)]
        public List<ZacksInstitutionalHoldingCompanyDetail> Companies { get; set; }

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
            sb.Append("class ApiResponseZacksInstitutionalHoldingCompanies {\n");
            sb.Append("  Companies: ").Append(Companies).Append("\n");
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
            return this.Equals(input as ApiResponseZacksInstitutionalHoldingCompanies);
        }

        /// <summary>
        /// Returns true if ApiResponseZacksInstitutionalHoldingCompanies instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseZacksInstitutionalHoldingCompanies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseZacksInstitutionalHoldingCompanies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Companies == input.Companies ||
                    this.Companies != null &&
                    this.Companies.SequenceEqual(input.Companies)
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
                if (this.Companies != null)
                    hashCode = hashCode * 59 + this.Companies.GetHashCode();
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

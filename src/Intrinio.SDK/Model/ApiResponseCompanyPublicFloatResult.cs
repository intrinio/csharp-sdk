

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
    /// An company public floats result contains all public floats corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class ApiResponseCompanyPublicFloatResult :  IEquatable<ApiResponseCompanyPublicFloatResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanyPublicFloatResult" /> class.
        /// </summary>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        /// <param name="Company">Company.</param>
        /// <param name="PublicFloats">Array of all the public floats in this page of the result..</param>
        public ApiResponseCompanyPublicFloatResult(string NextPage = default(string), CompanySummary Company = default(CompanySummary), List<CompanyPublicFloat> PublicFloats = default(List<CompanyPublicFloat>))
        {
            this.NextPage = NextPage;
            this.Company = Company;
            this.PublicFloats = PublicFloats;
        }
        
        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// Array of all the public floats in this page of the result.
        /// </summary>
        /// <value>Array of all the public floats in this page of the result.</value>
        [DataMember(Name="public_floats", EmitDefaultValue=false)]
        public List<CompanyPublicFloat> PublicFloats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCompanyPublicFloatResult {\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  PublicFloats: ").Append(PublicFloats).Append("\n");
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
            return this.Equals(input as ApiResponseCompanyPublicFloatResult);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanyPublicFloatResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCompanyPublicFloatResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanyPublicFloatResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.PublicFloats == input.PublicFloats ||
                    this.PublicFloats != null &&
                    this.PublicFloats.SequenceEqual(input.PublicFloats)
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
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.PublicFloats != null)
                    hashCode = hashCode * 59 + this.PublicFloats.GetHashCode();
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

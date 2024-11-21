

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
    /// ApiResponseCompanyFundamentals
    /// </summary>
    [DataContract]
    public partial class ApiResponseCompanyFundamentals :  IEquatable<ApiResponseCompanyFundamentals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanyFundamentals" /> class.
        /// </summary>
        /// <param name="Fundamentals">Fundamentals.</param>
        /// <param name="Company">Company.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseCompanyFundamentals(List<FundamentalSummary> Fundamentals = default(List<FundamentalSummary>), CompanySummary Company = default(CompanySummary), string NextPage = default(string))
        {
            this.Fundamentals = Fundamentals;
            this.Company = Company;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets Fundamentals
        /// </summary>
        [DataMember(Name="fundamentals", EmitDefaultValue=false)]
        public List<FundamentalSummary> Fundamentals { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

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
            sb.Append("class ApiResponseCompanyFundamentals {\n");
            sb.Append("  Fundamentals: ").Append(Fundamentals).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
            return this.Equals(input as ApiResponseCompanyFundamentals);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanyFundamentals instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCompanyFundamentals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanyFundamentals input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fundamentals == input.Fundamentals ||
                    this.Fundamentals != null &&
                    this.Fundamentals.SequenceEqual(input.Fundamentals)
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
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
                if (this.Fundamentals != null)
                    hashCode = hashCode * 59 + this.Fundamentals.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
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

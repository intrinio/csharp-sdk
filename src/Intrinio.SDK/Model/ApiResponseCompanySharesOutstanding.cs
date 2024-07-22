

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
    /// ApiResponseCompanySharesOutstanding
    /// </summary>
    [DataContract]
    public partial class ApiResponseCompanySharesOutstanding :  IEquatable<ApiResponseCompanySharesOutstanding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanySharesOutstanding" /> class.
        /// </summary>
        /// <param name="SharesOutstanding">SharesOutstanding.</param>
        /// <param name="Company">Company.</param>
        public ApiResponseCompanySharesOutstanding(List<CompanySharesOutstanding> SharesOutstanding = default(List<CompanySharesOutstanding>), CompanySummary Company = default(CompanySummary))
        {
            this.SharesOutstanding = SharesOutstanding;
            this.Company = Company;
        }
        
        /// <summary>
        /// Gets or Sets SharesOutstanding
        /// </summary>
        [DataMember(Name="shares_outstanding", EmitDefaultValue=false)]
        public List<CompanySharesOutstanding> SharesOutstanding { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCompanySharesOutstanding {\n");
            sb.Append("  SharesOutstanding: ").Append(SharesOutstanding).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
            return this.Equals(input as ApiResponseCompanySharesOutstanding);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanySharesOutstanding instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCompanySharesOutstanding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanySharesOutstanding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharesOutstanding == input.SharesOutstanding ||
                    this.SharesOutstanding != null &&
                    this.SharesOutstanding.SequenceEqual(input.SharesOutstanding)
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
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
                if (this.SharesOutstanding != null)
                    hashCode = hashCode * 59 + this.SharesOutstanding.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
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

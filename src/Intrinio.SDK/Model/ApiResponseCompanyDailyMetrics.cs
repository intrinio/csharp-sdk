

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
    /// ApiResponseCompanyDailyMetrics
    /// </summary>
    [DataContract]
    public partial class ApiResponseCompanyDailyMetrics :  IEquatable<ApiResponseCompanyDailyMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanyDailyMetrics" /> class.
        /// </summary>
        /// <param name="DailyMetrics">DailyMetrics.</param>
        /// <param name="Company">Company.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseCompanyDailyMetrics(List<CompanyDailyMetric> DailyMetrics = default(List<CompanyDailyMetric>), CompanySummary Company = default(CompanySummary), string NextPage = default(string))
        {
            this.DailyMetrics = DailyMetrics;
            this.Company = Company;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets DailyMetrics
        /// </summary>
        [DataMember(Name="daily_metrics", EmitDefaultValue=false)]
        public List<CompanyDailyMetric> DailyMetrics { get; set; }

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
            sb.Append("class ApiResponseCompanyDailyMetrics {\n");
            sb.Append("  DailyMetrics: ").Append(DailyMetrics).Append("\n");
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
            return this.Equals(input as ApiResponseCompanyDailyMetrics);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanyDailyMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCompanyDailyMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanyDailyMetrics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DailyMetrics == input.DailyMetrics ||
                    this.DailyMetrics != null &&
                    this.DailyMetrics.SequenceEqual(input.DailyMetrics)
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
                if (this.DailyMetrics != null)
                    hashCode = hashCode * 59 + this.DailyMetrics.GetHashCode();
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

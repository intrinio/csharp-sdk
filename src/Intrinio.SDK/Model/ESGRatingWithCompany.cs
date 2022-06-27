

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
    /// ESGRatingWithCompany
    /// </summary>
    [DataContract]
    public partial class ESGRatingWithCompany :  IEquatable<ESGRatingWithCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ESGRatingWithCompany" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="CommunityRating">CommunityRating.</param>
        /// <param name="EmployeeRating">EmployeeRating.</param>
        /// <param name="EnvironmentRating">EnvironmentRating.</param>
        /// <param name="GovernanceRating">GovernanceRating.</param>
        /// <param name="Company">Company.</param>
        public ESGRatingWithCompany(DateTime? Date = default(DateTime?), decimal? CommunityRating = default(decimal?), decimal? EmployeeRating = default(decimal?), decimal? EnvironmentRating = default(decimal?), decimal? GovernanceRating = default(decimal?), ESGCompanySummary Company = default(ESGCompanySummary))
        {
            this.Date = Date;
            this.CommunityRating = CommunityRating;
            this.EmployeeRating = EmployeeRating;
            this.EnvironmentRating = EnvironmentRating;
            this.GovernanceRating = GovernanceRating;
            this.Company = Company;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets CommunityRating
        /// </summary>
        [DataMember(Name="community_rating", EmitDefaultValue=false)]
        public decimal? CommunityRating { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeRating
        /// </summary>
        [DataMember(Name="employee_rating", EmitDefaultValue=false)]
        public decimal? EmployeeRating { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentRating
        /// </summary>
        [DataMember(Name="environment_rating", EmitDefaultValue=false)]
        public decimal? EnvironmentRating { get; set; }

        /// <summary>
        /// Gets or Sets GovernanceRating
        /// </summary>
        [DataMember(Name="governance_rating", EmitDefaultValue=false)]
        public decimal? GovernanceRating { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public ESGCompanySummary Company { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESGRatingWithCompany {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CommunityRating: ").Append(CommunityRating).Append("\n");
            sb.Append("  EmployeeRating: ").Append(EmployeeRating).Append("\n");
            sb.Append("  EnvironmentRating: ").Append(EnvironmentRating).Append("\n");
            sb.Append("  GovernanceRating: ").Append(GovernanceRating).Append("\n");
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
            return this.Equals(input as ESGRatingWithCompany);
        }

        /// <summary>
        /// Returns true if ESGRatingWithCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of ESGRatingWithCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESGRatingWithCompany input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CommunityRating == input.CommunityRating ||
                    (this.CommunityRating != null &&
                    this.CommunityRating.Equals(input.CommunityRating))
                ) && 
                (
                    this.EmployeeRating == input.EmployeeRating ||
                    (this.EmployeeRating != null &&
                    this.EmployeeRating.Equals(input.EmployeeRating))
                ) && 
                (
                    this.EnvironmentRating == input.EnvironmentRating ||
                    (this.EnvironmentRating != null &&
                    this.EnvironmentRating.Equals(input.EnvironmentRating))
                ) && 
                (
                    this.GovernanceRating == input.GovernanceRating ||
                    (this.GovernanceRating != null &&
                    this.GovernanceRating.Equals(input.GovernanceRating))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.CommunityRating != null)
                    hashCode = hashCode * 59 + this.CommunityRating.GetHashCode();
                if (this.EmployeeRating != null)
                    hashCode = hashCode * 59 + this.EmployeeRating.GetHashCode();
                if (this.EnvironmentRating != null)
                    hashCode = hashCode * 59 + this.EnvironmentRating.GetHashCode();
                if (this.GovernanceRating != null)
                    hashCode = hashCode * 59 + this.GovernanceRating.GetHashCode();
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



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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// ApiResponseReportedFinancials
    /// </summary>
    [DataContract]
    public partial class ApiResponseReportedFinancials :  IEquatable<ApiResponseReportedFinancials>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseReportedFinancials" /> class.
        /// </summary>
        /// <param name="ReportedFinancials">ReportedFinancials.</param>
        /// <param name="Fundamental">Fundamental.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseReportedFinancials(List<ReportedFinancial> ReportedFinancials = default(List<ReportedFinancial>), Fundamental Fundamental = default(Fundamental), string NextPage = default(string))
        {
            this.ReportedFinancials = ReportedFinancials;
            this.Fundamental = Fundamental;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets ReportedFinancials
        /// </summary>
        [DataMember(Name="reported_financials", EmitDefaultValue=false)]
        public List<ReportedFinancial> ReportedFinancials { get; set; }

        /// <summary>
        /// Gets or Sets Fundamental
        /// </summary>
        [DataMember(Name="fundamental", EmitDefaultValue=false)]
        public Fundamental Fundamental { get; set; }

        /// <summary>
        /// The token required to request the next page of the data
        /// </summary>
        /// <value>The token required to request the next page of the data</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseReportedFinancials {\n");
            sb.Append("  ReportedFinancials: ").Append(ReportedFinancials).Append("\n");
            sb.Append("  Fundamental: ").Append(Fundamental).Append("\n");
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
            return this.Equals(input as ApiResponseReportedFinancials);
        }

        /// <summary>
        /// Returns true if ApiResponseReportedFinancials instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseReportedFinancials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseReportedFinancials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportedFinancials == input.ReportedFinancials ||
                    this.ReportedFinancials != null &&
                    this.ReportedFinancials.SequenceEqual(input.ReportedFinancials)
                ) && 
                (
                    this.Fundamental == input.Fundamental ||
                    (this.Fundamental != null &&
                    this.Fundamental.Equals(input.Fundamental))
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
                if (this.ReportedFinancials != null)
                    hashCode = hashCode * 59 + this.ReportedFinancials.GetHashCode();
                if (this.Fundamental != null)
                    hashCode = hashCode * 59 + this.Fundamental.GetHashCode();
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

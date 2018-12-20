

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
    /// A filing submitted to the SEC by a company
    /// </summary>
    [DataContract]
    public partial class Filing :  IEquatable<Filing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filing" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the Filing.</param>
        /// <param name="FilingDate">The date when the filing was submitted to the SEC by the company.</param>
        /// <param name="AcceptedDate">The date and time when the filing was accepted by SEC.</param>
        /// <param name="PeriodEndDate">The ending date of the fiscal period for the filing.</param>
        /// <param name="ReportType">The filing report type.</param>
        /// <param name="SecUniqueId">A unique identifier for the filing provided by the SEC.</param>
        /// <param name="FilingUrl">The URL to the filing page on the SEC site.</param>
        /// <param name="ReportUrl">The URL to the actual report on the SEC site.</param>
        /// <param name="InstanceUrl">The URL for the XBRL filing for the report.</param>
        /// <param name="Company">Company.</param>
        public Filing(string Id = default(string), DateTime? FilingDate = default(DateTime?), DateTime? AcceptedDate = default(DateTime?), DateTime? PeriodEndDate = default(DateTime?), string ReportType = default(string), string SecUniqueId = default(string), string FilingUrl = default(string), string ReportUrl = default(string), string InstanceUrl = default(string), CompanySummary Company = default(CompanySummary))
        {
            this.Id = Id;
            this.FilingDate = FilingDate;
            this.AcceptedDate = AcceptedDate;
            this.PeriodEndDate = PeriodEndDate;
            this.ReportType = ReportType;
            this.SecUniqueId = SecUniqueId;
            this.FilingUrl = FilingUrl;
            this.ReportUrl = ReportUrl;
            this.InstanceUrl = InstanceUrl;
            this.Company = Company;
        }
        
        /// <summary>
        /// The Intrinio ID of the Filing
        /// </summary>
        /// <value>The Intrinio ID of the Filing</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date when the filing was submitted to the SEC by the company
        /// </summary>
        /// <value>The date when the filing was submitted to the SEC by the company</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FilingDate { get; set; }

        /// <summary>
        /// The date and time when the filing was accepted by SEC
        /// </summary>
        /// <value>The date and time when the filing was accepted by SEC</value>
        [DataMember(Name="accepted_date", EmitDefaultValue=false)]
        public DateTime? AcceptedDate { get; set; }

        /// <summary>
        /// The ending date of the fiscal period for the filing
        /// </summary>
        /// <value>The ending date of the fiscal period for the filing</value>
        [DataMember(Name="period_end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// The filing report type
        /// </summary>
        /// <value>The filing report type</value>
        [DataMember(Name="report_type", EmitDefaultValue=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// A unique identifier for the filing provided by the SEC
        /// </summary>
        /// <value>A unique identifier for the filing provided by the SEC</value>
        [DataMember(Name="sec_unique_id", EmitDefaultValue=false)]
        public string SecUniqueId { get; set; }

        /// <summary>
        /// The URL to the filing page on the SEC site
        /// </summary>
        /// <value>The URL to the filing page on the SEC site</value>
        [DataMember(Name="filing_url", EmitDefaultValue=false)]
        public string FilingUrl { get; set; }

        /// <summary>
        /// The URL to the actual report on the SEC site
        /// </summary>
        /// <value>The URL to the actual report on the SEC site</value>
        [DataMember(Name="report_url", EmitDefaultValue=false)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// The URL for the XBRL filing for the report
        /// </summary>
        /// <value>The URL for the XBRL filing for the report</value>
        [DataMember(Name="instance_url", EmitDefaultValue=false)]
        public string InstanceUrl { get; set; }

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
            sb.Append("class Filing {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
            sb.Append("  AcceptedDate: ").Append(AcceptedDate).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  SecUniqueId: ").Append(SecUniqueId).Append("\n");
            sb.Append("  FilingUrl: ").Append(FilingUrl).Append("\n");
            sb.Append("  ReportUrl: ").Append(ReportUrl).Append("\n");
            sb.Append("  InstanceUrl: ").Append(InstanceUrl).Append("\n");
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
            return this.Equals(input as Filing);
        }

        /// <summary>
        /// Returns true if Filing instances are equal
        /// </summary>
        /// <param name="input">Instance of Filing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
                ) && 
                (
                    this.AcceptedDate == input.AcceptedDate ||
                    (this.AcceptedDate != null &&
                    this.AcceptedDate.Equals(input.AcceptedDate))
                ) && 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.SecUniqueId == input.SecUniqueId ||
                    (this.SecUniqueId != null &&
                    this.SecUniqueId.Equals(input.SecUniqueId))
                ) && 
                (
                    this.FilingUrl == input.FilingUrl ||
                    (this.FilingUrl != null &&
                    this.FilingUrl.Equals(input.FilingUrl))
                ) && 
                (
                    this.ReportUrl == input.ReportUrl ||
                    (this.ReportUrl != null &&
                    this.ReportUrl.Equals(input.ReportUrl))
                ) && 
                (
                    this.InstanceUrl == input.InstanceUrl ||
                    (this.InstanceUrl != null &&
                    this.InstanceUrl.Equals(input.InstanceUrl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
                if (this.AcceptedDate != null)
                    hashCode = hashCode * 59 + this.AcceptedDate.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.SecUniqueId != null)
                    hashCode = hashCode * 59 + this.SecUniqueId.GetHashCode();
                if (this.FilingUrl != null)
                    hashCode = hashCode * 59 + this.FilingUrl.GetHashCode();
                if (this.ReportUrl != null)
                    hashCode = hashCode * 59 + this.ReportUrl.GetHashCode();
                if (this.InstanceUrl != null)
                    hashCode = hashCode * 59 + this.InstanceUrl.GetHashCode();
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

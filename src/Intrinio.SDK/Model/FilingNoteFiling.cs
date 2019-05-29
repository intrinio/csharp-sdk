

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
    public partial class FilingNoteFiling :  IEquatable<FilingNoteFiling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilingNoteFiling" /> class.
        /// </summary>
        /// <param name="Cik">The Central Index Key (CIK) assigned to the company.</param>
        /// <param name="ReportType">The filing &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;.</param>
        /// <param name="PeriodEndDate">The ending date of the fiscal period for the filing.</param>
        /// <param name="FilingDate">The date the report was filed with the SEC.</param>
        public FilingNoteFiling(string Cik = default(string), string ReportType = default(string), DateTime? PeriodEndDate = default(DateTime?), DateTime? FilingDate = default(DateTime?))
        {
            this.Cik = Cik;
            this.ReportType = ReportType;
            this.PeriodEndDate = PeriodEndDate;
            this.FilingDate = FilingDate;
        }
        
        /// <summary>
        /// The Central Index Key (CIK) assigned to the company
        /// </summary>
        /// <value>The Central Index Key (CIK) assigned to the company</value>
        [DataMember(Name="cik", EmitDefaultValue=false)]
        public string Cik { get; set; }

        /// <summary>
        /// The filing &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;
        /// </summary>
        /// <value>The filing &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;</value>
        [DataMember(Name="report_type", EmitDefaultValue=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// The ending date of the fiscal period for the filing
        /// </summary>
        /// <value>The ending date of the fiscal period for the filing</value>
        [DataMember(Name="period_end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// The date the report was filed with the SEC
        /// </summary>
        /// <value>The date the report was filed with the SEC</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FilingDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilingNoteFiling {\n");
            sb.Append("  Cik: ").Append(Cik).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
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
            return this.Equals(input as FilingNoteFiling);
        }

        /// <summary>
        /// Returns true if FilingNoteFiling instances are equal
        /// </summary>
        /// <param name="input">Instance of FilingNoteFiling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilingNoteFiling input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cik == input.Cik ||
                    (this.Cik != null &&
                    this.Cik.Equals(input.Cik))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
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
                if (this.Cik != null)
                    hashCode = hashCode * 59 + this.Cik.GetHashCode();
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
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

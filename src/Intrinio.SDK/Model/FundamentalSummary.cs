

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
    /// FundamentalSummary
    /// </summary>
    [DataContract]
    public partial class FundamentalSummary :  IEquatable<FundamentalSummary>, IValidatableObject
    {
        /// <summary>
        /// The type of Fundamental
        /// </summary>
        /// <value>The type of Fundamental</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Reported for value: reported
            /// </summary>
            [EnumMember(Value = "reported")]
            Reported = 1,
            
            /// <summary>
            /// Enum Restated for value: restated
            /// </summary>
            [EnumMember(Value = "restated")]
            Restated = 2,
            
            /// <summary>
            /// Enum Calculated for value: calculated
            /// </summary>
            [EnumMember(Value = "calculated")]
            Calculated = 3
        }

        /// <summary>
        /// The type of Fundamental
        /// </summary>
        /// <value>The type of Fundamental</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundamentalSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the Fundamental.</param>
        /// <param name="StatementCode">The code of the financial statement that the Fundamental represents.</param>
        /// <param name="FiscalYear">The fiscal year.</param>
        /// <param name="FiscalPeriod">The fiscal period.</param>
        /// <param name="Type">The type of Fundamental.</param>
        /// <param name="StartDate">The period start date.</param>
        /// <param name="EndDate">The period start date.</param>
        /// <param name="FilingDate">The date and time when the Fundamental was filed with the SEC.</param>
        /// <param name="IsLatest">Is this the latest fundamental available based on the company&#39;s most recent filings? Use the Lookup Fundamental endpoint to find the latest fundamental (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/web_api/lookup_fundamental_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;).</param>
        /// <param name="UpdatedDate">The date and time when the data related to the fundamental was last updated.</param>
        public FundamentalSummary(string Id = default(string), string StatementCode = default(string), decimal? FiscalYear = default(decimal?), string FiscalPeriod = default(string), TypeEnum? Type = default(TypeEnum?), DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?), DateTime? FilingDate = default(DateTime?), bool? IsLatest = default(bool?), DateTime? UpdatedDate = default(DateTime?))
        {
            this.Id = Id;
            this.StatementCode = StatementCode;
            this.FiscalYear = FiscalYear;
            this.FiscalPeriod = FiscalPeriod;
            this.Type = Type;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.FilingDate = FilingDate;
            this.IsLatest = IsLatest;
            this.UpdatedDate = UpdatedDate;
        }
        
        /// <summary>
        /// The Intrinio ID of the Fundamental
        /// </summary>
        /// <value>The Intrinio ID of the Fundamental</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The code of the financial statement that the Fundamental represents
        /// </summary>
        /// <value>The code of the financial statement that the Fundamental represents</value>
        [DataMember(Name="statement_code", EmitDefaultValue=false)]
        public string StatementCode { get; set; }

        /// <summary>
        /// The fiscal year
        /// </summary>
        /// <value>The fiscal year</value>
        [DataMember(Name="fiscal_year", EmitDefaultValue=false)]
        public decimal? FiscalYear { get; set; }

        /// <summary>
        /// The fiscal period
        /// </summary>
        /// <value>The fiscal period</value>
        [DataMember(Name="fiscal_period", EmitDefaultValue=false)]
        public string FiscalPeriod { get; set; }


        /// <summary>
        /// The period start date
        /// </summary>
        /// <value>The period start date</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The period start date
        /// </summary>
        /// <value>The period start date</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The date and time when the Fundamental was filed with the SEC
        /// </summary>
        /// <value>The date and time when the Fundamental was filed with the SEC</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        public DateTime? FilingDate { get; set; }

        /// <summary>
        /// Is this the latest fundamental available based on the company&#39;s most recent filings? Use the Lookup Fundamental endpoint to find the latest fundamental (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/web_api/lookup_fundamental_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)
        /// </summary>
        /// <value>Is this the latest fundamental available based on the company&#39;s most recent filings? Use the Lookup Fundamental endpoint to find the latest fundamental (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/web_api/lookup_fundamental_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)</value>
        [DataMember(Name="is_latest", EmitDefaultValue=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// The date and time when the data related to the fundamental was last updated
        /// </summary>
        /// <value>The date and time when the data related to the fundamental was last updated</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundamentalSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StatementCode: ").Append(StatementCode).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  FiscalPeriod: ").Append(FiscalPeriod).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
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
            return this.Equals(input as FundamentalSummary);
        }

        /// <summary>
        /// Returns true if FundamentalSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of FundamentalSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundamentalSummary input)
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
                    this.StatementCode == input.StatementCode ||
                    (this.StatementCode != null &&
                    this.StatementCode.Equals(input.StatementCode))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    (this.FiscalYear != null &&
                    this.FiscalYear.Equals(input.FiscalYear))
                ) && 
                (
                    this.FiscalPeriod == input.FiscalPeriod ||
                    (this.FiscalPeriod != null &&
                    this.FiscalPeriod.Equals(input.FiscalPeriod))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
                ) && 
                (
                    this.IsLatest == input.IsLatest ||
                    (this.IsLatest != null &&
                    this.IsLatest.Equals(input.IsLatest))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
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
                if (this.StatementCode != null)
                    hashCode = hashCode * 59 + this.StatementCode.GetHashCode();
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.FiscalPeriod != null)
                    hashCode = hashCode * 59 + this.FiscalPeriod.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
                if (this.IsLatest != null)
                    hashCode = hashCode * 59 + this.IsLatest.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
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

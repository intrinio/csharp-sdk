

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
    /// EarningsDateEstimateWithCompany
    /// </summary>
    [DataContract]
    public partial class EarningsDateEstimateWithCompany :  IEquatable<EarningsDateEstimateWithCompany>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarningsDateEstimateWithCompany" /> class.
        /// </summary>
        /// <param name="FiscalYear">The fiscal year for the earnings report.</param>
        /// <param name="FiscalPeriod">The fiscal period for the earnings report (Q1, Q2, Q3, Q4, or FY).</param>
        /// <param name="ExpectedDate">The expected date of the earnings announcement.</param>
        /// <param name="Expected8kAt">The expected timestamp when the 8-K filing will be available.</param>
        /// <param name="HistoricallyEarliest">The earliest date (MM-DD format) this company has historically announced earnings for this fiscal period.</param>
        /// <param name="HistoricallyLatest">The latest date (MM-DD format) this company has historically announced earnings for this fiscal period.</param>
        /// <param name="ConfidenceIntervals">Confidence intervals for the expected date, sorted by confidence level (descending).</param>
        /// <param name="CompanyId">The Intrinio ID for the company.</param>
        /// <param name="Ticker">The ticker symbol of the company.</param>
        public EarningsDateEstimateWithCompany(int? FiscalYear = default(int?), string FiscalPeriod = default(string), DateTime? ExpectedDate = default(DateTime?), DateTime? Expected8kAt = default(DateTime?), string HistoricallyEarliest = default(string), string HistoricallyLatest = default(string), Dictionary<string, EarningsDateEstimateConfidenceIntervals> ConfidenceIntervals = default(Dictionary<string, EarningsDateEstimateConfidenceIntervals>), string CompanyId = default(string), string Ticker = default(string))
        {
            this.FiscalYear = FiscalYear;
            this.FiscalPeriod = FiscalPeriod;
            this.ExpectedDate = ExpectedDate;
            this.Expected8kAt = Expected8kAt;
            this.HistoricallyEarliest = HistoricallyEarliest;
            this.HistoricallyLatest = HistoricallyLatest;
            this.ConfidenceIntervals = ConfidenceIntervals;
            this.CompanyId = CompanyId;
            this.Ticker = Ticker;
        }
        
        /// <summary>
        /// The fiscal year for the earnings report
        /// </summary>
        /// <value>The fiscal year for the earnings report</value>
        [DataMember(Name="fiscal_year", EmitDefaultValue=false)]
        public int? FiscalYear { get; set; }

        /// <summary>
        /// The fiscal period for the earnings report (Q1, Q2, Q3, Q4, or FY)
        /// </summary>
        /// <value>The fiscal period for the earnings report (Q1, Q2, Q3, Q4, or FY)</value>
        [DataMember(Name="fiscal_period", EmitDefaultValue=false)]
        public string FiscalPeriod { get; set; }

        /// <summary>
        /// The expected date of the earnings announcement
        /// </summary>
        /// <value>The expected date of the earnings announcement</value>
        [DataMember(Name="expected_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExpectedDate { get; set; }

        /// <summary>
        /// The expected timestamp when the 8-K filing will be available
        /// </summary>
        /// <value>The expected timestamp when the 8-K filing will be available</value>
        [DataMember(Name="expected_8k_at", EmitDefaultValue=false)]
        public DateTime? Expected8kAt { get; set; }

        /// <summary>
        /// The earliest date (MM-DD format) this company has historically announced earnings for this fiscal period
        /// </summary>
        /// <value>The earliest date (MM-DD format) this company has historically announced earnings for this fiscal period</value>
        [DataMember(Name="historically_earliest", EmitDefaultValue=false)]
        public string HistoricallyEarliest { get; set; }

        /// <summary>
        /// The latest date (MM-DD format) this company has historically announced earnings for this fiscal period
        /// </summary>
        /// <value>The latest date (MM-DD format) this company has historically announced earnings for this fiscal period</value>
        [DataMember(Name="historically_latest", EmitDefaultValue=false)]
        public string HistoricallyLatest { get; set; }

        /// <summary>
        /// Confidence intervals for the expected date, sorted by confidence level (descending)
        /// </summary>
        /// <value>Confidence intervals for the expected date, sorted by confidence level (descending)</value>
        [DataMember(Name="confidence_intervals", EmitDefaultValue=false)]
        public Dictionary<string, EarningsDateEstimateConfidenceIntervals> ConfidenceIntervals { get; set; }

        /// <summary>
        /// The Intrinio ID for the company
        /// </summary>
        /// <value>The Intrinio ID for the company</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The ticker symbol of the company
        /// </summary>
        /// <value>The ticker symbol of the company</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsDateEstimateWithCompany {\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  FiscalPeriod: ").Append(FiscalPeriod).Append("\n");
            sb.Append("  ExpectedDate: ").Append(ExpectedDate).Append("\n");
            sb.Append("  Expected8kAt: ").Append(Expected8kAt).Append("\n");
            sb.Append("  HistoricallyEarliest: ").Append(HistoricallyEarliest).Append("\n");
            sb.Append("  HistoricallyLatest: ").Append(HistoricallyLatest).Append("\n");
            sb.Append("  ConfidenceIntervals: ").Append(ConfidenceIntervals).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
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
            return this.Equals(input as EarningsDateEstimateWithCompany);
        }

        /// <summary>
        /// Returns true if EarningsDateEstimateWithCompany instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsDateEstimateWithCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsDateEstimateWithCompany input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ExpectedDate == input.ExpectedDate ||
                    (this.ExpectedDate != null &&
                    this.ExpectedDate.Equals(input.ExpectedDate))
                ) && 
                (
                    this.Expected8kAt == input.Expected8kAt ||
                    (this.Expected8kAt != null &&
                    this.Expected8kAt.Equals(input.Expected8kAt))
                ) && 
                (
                    this.HistoricallyEarliest == input.HistoricallyEarliest ||
                    (this.HistoricallyEarliest != null &&
                    this.HistoricallyEarliest.Equals(input.HistoricallyEarliest))
                ) && 
                (
                    this.HistoricallyLatest == input.HistoricallyLatest ||
                    (this.HistoricallyLatest != null &&
                    this.HistoricallyLatest.Equals(input.HistoricallyLatest))
                ) && 
                (
                    this.ConfidenceIntervals == input.ConfidenceIntervals ||
                    this.ConfidenceIntervals != null &&
                    this.ConfidenceIntervals.SequenceEqual(input.ConfidenceIntervals)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
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
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.FiscalPeriod != null)
                    hashCode = hashCode * 59 + this.FiscalPeriod.GetHashCode();
                if (this.ExpectedDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDate.GetHashCode();
                if (this.Expected8kAt != null)
                    hashCode = hashCode * 59 + this.Expected8kAt.GetHashCode();
                if (this.HistoricallyEarliest != null)
                    hashCode = hashCode * 59 + this.HistoricallyEarliest.GetHashCode();
                if (this.HistoricallyLatest != null)
                    hashCode = hashCode * 59 + this.HistoricallyLatest.GetHashCode();
                if (this.ConfidenceIntervals != null)
                    hashCode = hashCode * 59 + this.ConfidenceIntervals.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
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

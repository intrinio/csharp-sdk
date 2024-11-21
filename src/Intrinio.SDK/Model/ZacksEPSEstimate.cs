

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
    /// Zacks consensus earnings-per-share (EPS) estimates from analysts for thousands of stocks.  Zacks storied research team aggregates and validates the estimates.  Each EPS Estimate includes metadata about the corresponding Company.
    /// </summary>
    [DataContract]
    public partial class ZacksEPSEstimate :  IEquatable<ZacksEPSEstimate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksEPSEstimate" /> class.
        /// </summary>
        /// <param name="Company">Company.</param>
        /// <param name="Date">The period end date.</param>
        /// <param name="FiscalYear">The company’s fiscal year for the reported period.</param>
        /// <param name="FiscalQuarter">The company’s fiscal quarter for the reported period.</param>
        /// <param name="CalendarYear">The closest calendar year for the company’s fiscal year.</param>
        /// <param name="CalendarQuarter">The closest calendar quarter for the company’s fiscal year.</param>
        /// <param name="Count">The number of estimates for the period.</param>
        /// <param name="Mean">The earnings per share (EPS) mean estimate for the period.</param>
        /// <param name="Median">The earnings per share (EPS) median estimate for the period.</param>
        /// <param name="High">The earnings per share (EPS) high estimate for the period.</param>
        /// <param name="Low">The earnings per share (EPS) low estimate for the period.</param>
        /// <param name="StandardDeviation">The earnings per share (EPS) standard deviation estimate for the period.</param>
        /// <param name="PercentChange">The earnings per share (EPS) percent change in estimate for the period.</param>
        /// <param name="Mean7DaysAgo">The long term growth mean estimate - 7 Days Ago.</param>
        /// <param name="Mean30DaysAgo">The long term growth mean estimate - 30 Days Ago.</param>
        /// <param name="Mean60DaysAgo">The long term growth mean estimate - 60 Days Ago.</param>
        /// <param name="Mean90DaysAgo">The long term growth mean estimate - 90 Days Ago.</param>
        public ZacksEPSEstimate(CompanySummary Company = default(CompanySummary), DateTime? Date = default(DateTime?), int? FiscalYear = default(int?), string FiscalQuarter = default(string), int? CalendarYear = default(int?), string CalendarQuarter = default(string), int? Count = default(int?), decimal? Mean = default(decimal?), decimal? Median = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? StandardDeviation = default(decimal?), decimal? PercentChange = default(decimal?), decimal? Mean7DaysAgo = default(decimal?), decimal? Mean30DaysAgo = default(decimal?), decimal? Mean60DaysAgo = default(decimal?), decimal? Mean90DaysAgo = default(decimal?))
        {
            this.Company = Company;
            this.Date = Date;
            this.FiscalYear = FiscalYear;
            this.FiscalQuarter = FiscalQuarter;
            this.CalendarYear = CalendarYear;
            this.CalendarQuarter = CalendarQuarter;
            this.Count = Count;
            this.Mean = Mean;
            this.Median = Median;
            this.High = High;
            this.Low = Low;
            this.StandardDeviation = StandardDeviation;
            this.PercentChange = PercentChange;
            this.Mean7DaysAgo = Mean7DaysAgo;
            this.Mean30DaysAgo = Mean30DaysAgo;
            this.Mean60DaysAgo = Mean60DaysAgo;
            this.Mean90DaysAgo = Mean90DaysAgo;
        }
        
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// The period end date
        /// </summary>
        /// <value>The period end date</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The company’s fiscal year for the reported period
        /// </summary>
        /// <value>The company’s fiscal year for the reported period</value>
        [DataMember(Name="fiscal_year", EmitDefaultValue=false)]
        public int? FiscalYear { get; set; }

        /// <summary>
        /// The company’s fiscal quarter for the reported period
        /// </summary>
        /// <value>The company’s fiscal quarter for the reported period</value>
        [DataMember(Name="fiscal_quarter", EmitDefaultValue=false)]
        public string FiscalQuarter { get; set; }

        /// <summary>
        /// The closest calendar year for the company’s fiscal year
        /// </summary>
        /// <value>The closest calendar year for the company’s fiscal year</value>
        [DataMember(Name="calendar_year", EmitDefaultValue=false)]
        public int? CalendarYear { get; set; }

        /// <summary>
        /// The closest calendar quarter for the company’s fiscal year
        /// </summary>
        /// <value>The closest calendar quarter for the company’s fiscal year</value>
        [DataMember(Name="calendar_quarter", EmitDefaultValue=false)]
        public string CalendarQuarter { get; set; }

        /// <summary>
        /// The number of estimates for the period
        /// </summary>
        /// <value>The number of estimates for the period</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The earnings per share (EPS) mean estimate for the period
        /// </summary>
        /// <value>The earnings per share (EPS) mean estimate for the period</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public decimal? Mean { get; set; }

        /// <summary>
        /// The earnings per share (EPS) median estimate for the period
        /// </summary>
        /// <value>The earnings per share (EPS) median estimate for the period</value>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public decimal? Median { get; set; }

        /// <summary>
        /// The earnings per share (EPS) high estimate for the period
        /// </summary>
        /// <value>The earnings per share (EPS) high estimate for the period</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The earnings per share (EPS) low estimate for the period
        /// </summary>
        /// <value>The earnings per share (EPS) low estimate for the period</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The earnings per share (EPS) standard deviation estimate for the period
        /// </summary>
        /// <value>The earnings per share (EPS) standard deviation estimate for the period</value>
        [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
        public decimal? StandardDeviation { get; set; }

        /// <summary>
        /// The earnings per share (EPS) percent change in estimate for the period
        /// </summary>
        /// <value>The earnings per share (EPS) percent change in estimate for the period</value>
        [DataMember(Name="percent_change", EmitDefaultValue=false)]
        public decimal? PercentChange { get; set; }

        /// <summary>
        /// The long term growth mean estimate - 7 Days Ago
        /// </summary>
        /// <value>The long term growth mean estimate - 7 Days Ago</value>
        [DataMember(Name="mean_7_days_ago", EmitDefaultValue=false)]
        public decimal? Mean7DaysAgo { get; set; }

        /// <summary>
        /// The long term growth mean estimate - 30 Days Ago
        /// </summary>
        /// <value>The long term growth mean estimate - 30 Days Ago</value>
        [DataMember(Name="mean_30_days_ago", EmitDefaultValue=false)]
        public decimal? Mean30DaysAgo { get; set; }

        /// <summary>
        /// The long term growth mean estimate - 60 Days Ago
        /// </summary>
        /// <value>The long term growth mean estimate - 60 Days Ago</value>
        [DataMember(Name="mean_60_days_ago", EmitDefaultValue=false)]
        public decimal? Mean60DaysAgo { get; set; }

        /// <summary>
        /// The long term growth mean estimate - 90 Days Ago
        /// </summary>
        /// <value>The long term growth mean estimate - 90 Days Ago</value>
        [DataMember(Name="mean_90_days_ago", EmitDefaultValue=false)]
        public decimal? Mean90DaysAgo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksEPSEstimate {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  FiscalQuarter: ").Append(FiscalQuarter).Append("\n");
            sb.Append("  CalendarYear: ").Append(CalendarYear).Append("\n");
            sb.Append("  CalendarQuarter: ").Append(CalendarQuarter).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
            sb.Append("  PercentChange: ").Append(PercentChange).Append("\n");
            sb.Append("  Mean7DaysAgo: ").Append(Mean7DaysAgo).Append("\n");
            sb.Append("  Mean30DaysAgo: ").Append(Mean30DaysAgo).Append("\n");
            sb.Append("  Mean60DaysAgo: ").Append(Mean60DaysAgo).Append("\n");
            sb.Append("  Mean90DaysAgo: ").Append(Mean90DaysAgo).Append("\n");
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
            return this.Equals(input as ZacksEPSEstimate);
        }

        /// <summary>
        /// Returns true if ZacksEPSEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksEPSEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksEPSEstimate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    (this.FiscalYear != null &&
                    this.FiscalYear.Equals(input.FiscalYear))
                ) && 
                (
                    this.FiscalQuarter == input.FiscalQuarter ||
                    (this.FiscalQuarter != null &&
                    this.FiscalQuarter.Equals(input.FiscalQuarter))
                ) && 
                (
                    this.CalendarYear == input.CalendarYear ||
                    (this.CalendarYear != null &&
                    this.CalendarYear.Equals(input.CalendarYear))
                ) && 
                (
                    this.CalendarQuarter == input.CalendarQuarter ||
                    (this.CalendarQuarter != null &&
                    this.CalendarQuarter.Equals(input.CalendarQuarter))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Mean == input.Mean ||
                    (this.Mean != null &&
                    this.Mean.Equals(input.Mean))
                ) && 
                (
                    this.Median == input.Median ||
                    (this.Median != null &&
                    this.Median.Equals(input.Median))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.StandardDeviation == input.StandardDeviation ||
                    (this.StandardDeviation != null &&
                    this.StandardDeviation.Equals(input.StandardDeviation))
                ) && 
                (
                    this.PercentChange == input.PercentChange ||
                    (this.PercentChange != null &&
                    this.PercentChange.Equals(input.PercentChange))
                ) && 
                (
                    this.Mean7DaysAgo == input.Mean7DaysAgo ||
                    (this.Mean7DaysAgo != null &&
                    this.Mean7DaysAgo.Equals(input.Mean7DaysAgo))
                ) && 
                (
                    this.Mean30DaysAgo == input.Mean30DaysAgo ||
                    (this.Mean30DaysAgo != null &&
                    this.Mean30DaysAgo.Equals(input.Mean30DaysAgo))
                ) && 
                (
                    this.Mean60DaysAgo == input.Mean60DaysAgo ||
                    (this.Mean60DaysAgo != null &&
                    this.Mean60DaysAgo.Equals(input.Mean60DaysAgo))
                ) && 
                (
                    this.Mean90DaysAgo == input.Mean90DaysAgo ||
                    (this.Mean90DaysAgo != null &&
                    this.Mean90DaysAgo.Equals(input.Mean90DaysAgo))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.FiscalQuarter != null)
                    hashCode = hashCode * 59 + this.FiscalQuarter.GetHashCode();
                if (this.CalendarYear != null)
                    hashCode = hashCode * 59 + this.CalendarYear.GetHashCode();
                if (this.CalendarQuarter != null)
                    hashCode = hashCode * 59 + this.CalendarQuarter.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Mean != null)
                    hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.Median != null)
                    hashCode = hashCode * 59 + this.Median.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.StandardDeviation != null)
                    hashCode = hashCode * 59 + this.StandardDeviation.GetHashCode();
                if (this.PercentChange != null)
                    hashCode = hashCode * 59 + this.PercentChange.GetHashCode();
                if (this.Mean7DaysAgo != null)
                    hashCode = hashCode * 59 + this.Mean7DaysAgo.GetHashCode();
                if (this.Mean30DaysAgo != null)
                    hashCode = hashCode * 59 + this.Mean30DaysAgo.GetHashCode();
                if (this.Mean60DaysAgo != null)
                    hashCode = hashCode * 59 + this.Mean60DaysAgo.GetHashCode();
                if (this.Mean90DaysAgo != null)
                    hashCode = hashCode * 59 + this.Mean90DaysAgo.GetHashCode();
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

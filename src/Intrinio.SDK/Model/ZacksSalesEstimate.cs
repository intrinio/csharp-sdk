

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
    /// Zacks consensus sales estimates from analysts for thousands of stocks.  Zacks storied research team aggregates and validates the estimates.  Each sales Estimate includes metadata about the corresponding Company.
    /// </summary>
    [DataContract]
    public partial class ZacksSalesEstimate :  IEquatable<ZacksSalesEstimate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksSalesEstimate" /> class.
        /// </summary>
        /// <param name="Company">Company.</param>
        /// <param name="Date">The period end date.</param>
        /// <param name="FiscalYear">The company’s fiscal year for the reported period.</param>
        /// <param name="FiscalPeriod">The company’s fiscal quarter for the reported period.</param>
        /// <param name="CalendarYear">The closest calendar year for the company’s fiscal year.</param>
        /// <param name="CalendarPeriod">The closest calendar quarter for the company’s fiscal year.</param>
        /// <param name="Count">The number of estimates for the period.</param>
        /// <param name="Mean">The sales estimate mean estimate for the period.</param>
        /// <param name="Median">The sales estimate median estimate for the period.</param>
        /// <param name="High">The sales estimate high estimate for the period.</param>
        /// <param name="Low">The sales estimate low estimate for the period.</param>
        /// <param name="StandardDeviation">The sales estimate standard deviation estimate for the period.</param>
        /// <param name="AnalystRevisionsPercentChange1w">The analyst revisions percent change in estimate for the period of 1 week..</param>
        /// <param name="AnalystRevisionsUp1w">The analyst revisions going up for the period of 1 week..</param>
        /// <param name="AnalystRevisionsDown1w">The analyst revisions going down for the period of 1 week..</param>
        /// <param name="AnalystRevisionsPercentChange1m">The analyst revisions percent change in estimate for the period of 1 month..</param>
        /// <param name="AnalystRevisionsUp1m">The analyst revisions going up for the period of 1 month..</param>
        /// <param name="AnalystRevisionsDown1m">The analyst revisions going down for the period of 1 month..</param>
        /// <param name="AnalystRevisionsPercentChange3m">The analyst revisions percent change in estimate for the period of 3 months..</param>
        /// <param name="AnalystRevisionsUp3m">The analyst revisions going up for the period of 3 months..</param>
        /// <param name="AnalystRevisionsDown3m">The analyst revisions going down for the period of 3 months..</param>
        public ZacksSalesEstimate(CompanySummary Company = default(CompanySummary), DateTime? Date = default(DateTime?), int? FiscalYear = default(int?), string FiscalPeriod = default(string), int? CalendarYear = default(int?), string CalendarPeriod = default(string), int? Count = default(int?), decimal? Mean = default(decimal?), decimal? Median = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? StandardDeviation = default(decimal?), decimal? AnalystRevisionsPercentChange1w = default(decimal?), decimal? AnalystRevisionsUp1w = default(decimal?), decimal? AnalystRevisionsDown1w = default(decimal?), decimal? AnalystRevisionsPercentChange1m = default(decimal?), decimal? AnalystRevisionsUp1m = default(decimal?), decimal? AnalystRevisionsDown1m = default(decimal?), decimal? AnalystRevisionsPercentChange3m = default(decimal?), decimal? AnalystRevisionsUp3m = default(decimal?), decimal? AnalystRevisionsDown3m = default(decimal?))
        {
            this.Company = Company;
            this.Date = Date;
            this.FiscalYear = FiscalYear;
            this.FiscalPeriod = FiscalPeriod;
            this.CalendarYear = CalendarYear;
            this.CalendarPeriod = CalendarPeriod;
            this.Count = Count;
            this.Mean = Mean;
            this.Median = Median;
            this.High = High;
            this.Low = Low;
            this.StandardDeviation = StandardDeviation;
            this.AnalystRevisionsPercentChange1w = AnalystRevisionsPercentChange1w;
            this.AnalystRevisionsUp1w = AnalystRevisionsUp1w;
            this.AnalystRevisionsDown1w = AnalystRevisionsDown1w;
            this.AnalystRevisionsPercentChange1m = AnalystRevisionsPercentChange1m;
            this.AnalystRevisionsUp1m = AnalystRevisionsUp1m;
            this.AnalystRevisionsDown1m = AnalystRevisionsDown1m;
            this.AnalystRevisionsPercentChange3m = AnalystRevisionsPercentChange3m;
            this.AnalystRevisionsUp3m = AnalystRevisionsUp3m;
            this.AnalystRevisionsDown3m = AnalystRevisionsDown3m;
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
        [DataMember(Name="fiscal_period", EmitDefaultValue=false)]
        public string FiscalPeriod { get; set; }

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
        [DataMember(Name="calendar_period", EmitDefaultValue=false)]
        public string CalendarPeriod { get; set; }

        /// <summary>
        /// The number of estimates for the period
        /// </summary>
        /// <value>The number of estimates for the period</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The sales estimate mean estimate for the period
        /// </summary>
        /// <value>The sales estimate mean estimate for the period</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public decimal? Mean { get; set; }

        /// <summary>
        /// The sales estimate median estimate for the period
        /// </summary>
        /// <value>The sales estimate median estimate for the period</value>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public decimal? Median { get; set; }

        /// <summary>
        /// The sales estimate high estimate for the period
        /// </summary>
        /// <value>The sales estimate high estimate for the period</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The sales estimate low estimate for the period
        /// </summary>
        /// <value>The sales estimate low estimate for the period</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The sales estimate standard deviation estimate for the period
        /// </summary>
        /// <value>The sales estimate standard deviation estimate for the period</value>
        [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
        public decimal? StandardDeviation { get; set; }

        /// <summary>
        /// The analyst revisions percent change in estimate for the period of 1 week.
        /// </summary>
        /// <value>The analyst revisions percent change in estimate for the period of 1 week.</value>
        [DataMember(Name="analyst_revisions_percent_change_1w", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsPercentChange1w { get; set; }

        /// <summary>
        /// The analyst revisions going up for the period of 1 week.
        /// </summary>
        /// <value>The analyst revisions going up for the period of 1 week.</value>
        [DataMember(Name="analyst_revisions_up_1w", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsUp1w { get; set; }

        /// <summary>
        /// The analyst revisions going down for the period of 1 week.
        /// </summary>
        /// <value>The analyst revisions going down for the period of 1 week.</value>
        [DataMember(Name="analyst_revisions_down_1w", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsDown1w { get; set; }

        /// <summary>
        /// The analyst revisions percent change in estimate for the period of 1 month.
        /// </summary>
        /// <value>The analyst revisions percent change in estimate for the period of 1 month.</value>
        [DataMember(Name="analyst_revisions_percent_change_1m", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsPercentChange1m { get; set; }

        /// <summary>
        /// The analyst revisions going up for the period of 1 month.
        /// </summary>
        /// <value>The analyst revisions going up for the period of 1 month.</value>
        [DataMember(Name="analyst_revisions_up_1m", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsUp1m { get; set; }

        /// <summary>
        /// The analyst revisions going down for the period of 1 month.
        /// </summary>
        /// <value>The analyst revisions going down for the period of 1 month.</value>
        [DataMember(Name="analyst_revisions_down_1m", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsDown1m { get; set; }

        /// <summary>
        /// The analyst revisions percent change in estimate for the period of 3 months.
        /// </summary>
        /// <value>The analyst revisions percent change in estimate for the period of 3 months.</value>
        [DataMember(Name="analyst_revisions_percent_change_3m", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsPercentChange3m { get; set; }

        /// <summary>
        /// The analyst revisions going up for the period of 3 months.
        /// </summary>
        /// <value>The analyst revisions going up for the period of 3 months.</value>
        [DataMember(Name="analyst_revisions_up_3m", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsUp3m { get; set; }

        /// <summary>
        /// The analyst revisions going down for the period of 3 months.
        /// </summary>
        /// <value>The analyst revisions going down for the period of 3 months.</value>
        [DataMember(Name="analyst_revisions_down_3m", EmitDefaultValue=false)]
        public decimal? AnalystRevisionsDown3m { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksSalesEstimate {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  FiscalPeriod: ").Append(FiscalPeriod).Append("\n");
            sb.Append("  CalendarYear: ").Append(CalendarYear).Append("\n");
            sb.Append("  CalendarPeriod: ").Append(CalendarPeriod).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
            sb.Append("  AnalystRevisionsPercentChange1w: ").Append(AnalystRevisionsPercentChange1w).Append("\n");
            sb.Append("  AnalystRevisionsUp1w: ").Append(AnalystRevisionsUp1w).Append("\n");
            sb.Append("  AnalystRevisionsDown1w: ").Append(AnalystRevisionsDown1w).Append("\n");
            sb.Append("  AnalystRevisionsPercentChange1m: ").Append(AnalystRevisionsPercentChange1m).Append("\n");
            sb.Append("  AnalystRevisionsUp1m: ").Append(AnalystRevisionsUp1m).Append("\n");
            sb.Append("  AnalystRevisionsDown1m: ").Append(AnalystRevisionsDown1m).Append("\n");
            sb.Append("  AnalystRevisionsPercentChange3m: ").Append(AnalystRevisionsPercentChange3m).Append("\n");
            sb.Append("  AnalystRevisionsUp3m: ").Append(AnalystRevisionsUp3m).Append("\n");
            sb.Append("  AnalystRevisionsDown3m: ").Append(AnalystRevisionsDown3m).Append("\n");
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
            return this.Equals(input as ZacksSalesEstimate);
        }

        /// <summary>
        /// Returns true if ZacksSalesEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksSalesEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksSalesEstimate input)
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
                    this.FiscalPeriod == input.FiscalPeriod ||
                    (this.FiscalPeriod != null &&
                    this.FiscalPeriod.Equals(input.FiscalPeriod))
                ) && 
                (
                    this.CalendarYear == input.CalendarYear ||
                    (this.CalendarYear != null &&
                    this.CalendarYear.Equals(input.CalendarYear))
                ) && 
                (
                    this.CalendarPeriod == input.CalendarPeriod ||
                    (this.CalendarPeriod != null &&
                    this.CalendarPeriod.Equals(input.CalendarPeriod))
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
                    this.AnalystRevisionsPercentChange1w == input.AnalystRevisionsPercentChange1w ||
                    (this.AnalystRevisionsPercentChange1w != null &&
                    this.AnalystRevisionsPercentChange1w.Equals(input.AnalystRevisionsPercentChange1w))
                ) && 
                (
                    this.AnalystRevisionsUp1w == input.AnalystRevisionsUp1w ||
                    (this.AnalystRevisionsUp1w != null &&
                    this.AnalystRevisionsUp1w.Equals(input.AnalystRevisionsUp1w))
                ) && 
                (
                    this.AnalystRevisionsDown1w == input.AnalystRevisionsDown1w ||
                    (this.AnalystRevisionsDown1w != null &&
                    this.AnalystRevisionsDown1w.Equals(input.AnalystRevisionsDown1w))
                ) && 
                (
                    this.AnalystRevisionsPercentChange1m == input.AnalystRevisionsPercentChange1m ||
                    (this.AnalystRevisionsPercentChange1m != null &&
                    this.AnalystRevisionsPercentChange1m.Equals(input.AnalystRevisionsPercentChange1m))
                ) && 
                (
                    this.AnalystRevisionsUp1m == input.AnalystRevisionsUp1m ||
                    (this.AnalystRevisionsUp1m != null &&
                    this.AnalystRevisionsUp1m.Equals(input.AnalystRevisionsUp1m))
                ) && 
                (
                    this.AnalystRevisionsDown1m == input.AnalystRevisionsDown1m ||
                    (this.AnalystRevisionsDown1m != null &&
                    this.AnalystRevisionsDown1m.Equals(input.AnalystRevisionsDown1m))
                ) && 
                (
                    this.AnalystRevisionsPercentChange3m == input.AnalystRevisionsPercentChange3m ||
                    (this.AnalystRevisionsPercentChange3m != null &&
                    this.AnalystRevisionsPercentChange3m.Equals(input.AnalystRevisionsPercentChange3m))
                ) && 
                (
                    this.AnalystRevisionsUp3m == input.AnalystRevisionsUp3m ||
                    (this.AnalystRevisionsUp3m != null &&
                    this.AnalystRevisionsUp3m.Equals(input.AnalystRevisionsUp3m))
                ) && 
                (
                    this.AnalystRevisionsDown3m == input.AnalystRevisionsDown3m ||
                    (this.AnalystRevisionsDown3m != null &&
                    this.AnalystRevisionsDown3m.Equals(input.AnalystRevisionsDown3m))
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
                if (this.FiscalPeriod != null)
                    hashCode = hashCode * 59 + this.FiscalPeriod.GetHashCode();
                if (this.CalendarYear != null)
                    hashCode = hashCode * 59 + this.CalendarYear.GetHashCode();
                if (this.CalendarPeriod != null)
                    hashCode = hashCode * 59 + this.CalendarPeriod.GetHashCode();
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
                if (this.AnalystRevisionsPercentChange1w != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsPercentChange1w.GetHashCode();
                if (this.AnalystRevisionsUp1w != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsUp1w.GetHashCode();
                if (this.AnalystRevisionsDown1w != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsDown1w.GetHashCode();
                if (this.AnalystRevisionsPercentChange1m != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsPercentChange1m.GetHashCode();
                if (this.AnalystRevisionsUp1m != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsUp1m.GetHashCode();
                if (this.AnalystRevisionsDown1m != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsDown1m.GetHashCode();
                if (this.AnalystRevisionsPercentChange3m != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsPercentChange3m.GetHashCode();
                if (this.AnalystRevisionsUp3m != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsUp3m.GetHashCode();
                if (this.AnalystRevisionsDown3m != null)
                    hashCode = hashCode * 59 + this.AnalystRevisionsDown3m.GetHashCode();
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

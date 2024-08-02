

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
    /// Zacks estimates for EBITDA, EBITDA margin, EBIT, Enterprise Value, Cash Flow Per Share, and Pretax Income
    /// </summary>
    [DataContract]
    public partial class ZacksEBITDAConsensus :  IEquatable<ZacksEBITDAConsensus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksEBITDAConsensus" /> class.
        /// </summary>
        /// <param name="Ticker">The Zacks common exchange ticker.</param>
        /// <param name="CompanyName">The company name.</param>
        /// <param name="EstimateYear">Fiscal year of the estimate.</param>
        /// <param name="EstimateMonth">Fiscal month of the estimate.</param>
        /// <param name="Period">Whether the estimate year and month are fiscal year (fy) or quarter (fq).</param>
        /// <param name="ConsensusType">The type of estimate (ebitda, ebitda, ebit, enterprise_value, cash_flow_per_share, pretax_income).</param>
        /// <param name="EstimateCount">The number of estimates.</param>
        /// <param name="High">The highest estimate.</param>
        /// <param name="Low">The lowest estimate.</param>
        /// <param name="Mean">The mean value of all estimates.</param>
        /// <param name="StdDev">The standard deviation of all estimates.</param>
        public ZacksEBITDAConsensus(string Ticker = default(string), string CompanyName = default(string), decimal? EstimateYear = default(decimal?), decimal? EstimateMonth = default(decimal?), string Period = default(string), string ConsensusType = default(string), decimal? EstimateCount = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Mean = default(decimal?), decimal? StdDev = default(decimal?))
        {
            this.Ticker = Ticker;
            this.CompanyName = CompanyName;
            this.EstimateYear = EstimateYear;
            this.EstimateMonth = EstimateMonth;
            this.Period = Period;
            this.ConsensusType = ConsensusType;
            this.EstimateCount = EstimateCount;
            this.High = High;
            this.Low = Low;
            this.Mean = Mean;
            this.StdDev = StdDev;
        }
        
        /// <summary>
        /// The Zacks common exchange ticker
        /// </summary>
        /// <value>The Zacks common exchange ticker</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The company name
        /// </summary>
        /// <value>The company name</value>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Fiscal year of the estimate
        /// </summary>
        /// <value>Fiscal year of the estimate</value>
        [DataMember(Name="estimate_year", EmitDefaultValue=false)]
        public decimal? EstimateYear { get; set; }

        /// <summary>
        /// Fiscal month of the estimate
        /// </summary>
        /// <value>Fiscal month of the estimate</value>
        [DataMember(Name="estimate_month", EmitDefaultValue=false)]
        public decimal? EstimateMonth { get; set; }

        /// <summary>
        /// Whether the estimate year and month are fiscal year (fy) or quarter (fq)
        /// </summary>
        /// <value>Whether the estimate year and month are fiscal year (fy) or quarter (fq)</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// The type of estimate (ebitda, ebitda, ebit, enterprise_value, cash_flow_per_share, pretax_income)
        /// </summary>
        /// <value>The type of estimate (ebitda, ebitda, ebit, enterprise_value, cash_flow_per_share, pretax_income)</value>
        [DataMember(Name="consensus_type", EmitDefaultValue=false)]
        public string ConsensusType { get; set; }

        /// <summary>
        /// The number of estimates
        /// </summary>
        /// <value>The number of estimates</value>
        [DataMember(Name="estimate_count", EmitDefaultValue=false)]
        public decimal? EstimateCount { get; set; }

        /// <summary>
        /// The highest estimate
        /// </summary>
        /// <value>The highest estimate</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest estimate
        /// </summary>
        /// <value>The lowest estimate</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The mean value of all estimates
        /// </summary>
        /// <value>The mean value of all estimates</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public decimal? Mean { get; set; }

        /// <summary>
        /// The standard deviation of all estimates
        /// </summary>
        /// <value>The standard deviation of all estimates</value>
        [DataMember(Name="std_dev", EmitDefaultValue=false)]
        public decimal? StdDev { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksEBITDAConsensus {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  EstimateYear: ").Append(EstimateYear).Append("\n");
            sb.Append("  EstimateMonth: ").Append(EstimateMonth).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  ConsensusType: ").Append(ConsensusType).Append("\n");
            sb.Append("  EstimateCount: ").Append(EstimateCount).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  StdDev: ").Append(StdDev).Append("\n");
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
            return this.Equals(input as ZacksEBITDAConsensus);
        }

        /// <summary>
        /// Returns true if ZacksEBITDAConsensus instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksEBITDAConsensus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksEBITDAConsensus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.EstimateYear == input.EstimateYear ||
                    (this.EstimateYear != null &&
                    this.EstimateYear.Equals(input.EstimateYear))
                ) && 
                (
                    this.EstimateMonth == input.EstimateMonth ||
                    (this.EstimateMonth != null &&
                    this.EstimateMonth.Equals(input.EstimateMonth))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.ConsensusType == input.ConsensusType ||
                    (this.ConsensusType != null &&
                    this.ConsensusType.Equals(input.ConsensusType))
                ) && 
                (
                    this.EstimateCount == input.EstimateCount ||
                    (this.EstimateCount != null &&
                    this.EstimateCount.Equals(input.EstimateCount))
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
                    this.Mean == input.Mean ||
                    (this.Mean != null &&
                    this.Mean.Equals(input.Mean))
                ) && 
                (
                    this.StdDev == input.StdDev ||
                    (this.StdDev != null &&
                    this.StdDev.Equals(input.StdDev))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.EstimateYear != null)
                    hashCode = hashCode * 59 + this.EstimateYear.GetHashCode();
                if (this.EstimateMonth != null)
                    hashCode = hashCode * 59 + this.EstimateMonth.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.ConsensusType != null)
                    hashCode = hashCode * 59 + this.ConsensusType.GetHashCode();
                if (this.EstimateCount != null)
                    hashCode = hashCode * 59 + this.EstimateCount.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Mean != null)
                    hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.StdDev != null)
                    hashCode = hashCode * 59 + this.StdDev.GetHashCode();
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

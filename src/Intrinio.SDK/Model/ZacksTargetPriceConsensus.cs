

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
    /// Zacks target price consensus estimates from analysts for thousands of stocks. Zacks storied research team aggregates and validates the estimates.  Each Growth Rate includes metadata about the corresponding Company.
    /// </summary>
    [DataContract]
    public partial class ZacksTargetPriceConsensus :  IEquatable<ZacksTargetPriceConsensus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksTargetPriceConsensus" /> class.
        /// </summary>
        /// <param name="Ticker">The Zacks common exchange ticker.</param>
        /// <param name="CompanyName">The company name.</param>
        /// <param name="IndustryGroupNumber">The Zacks industry group number.</param>
        /// <param name="High">The high target price estimate.</param>
        /// <param name="Low">The low target price estimate.</param>
        /// <param name="Mean">The mean target price estimate.</param>
        /// <param name="StandardDeviation">The standard deviation of target price estimates.</param>
        /// <param name="Total">The number of target price estimates in consensus.</param>
        /// <param name="MostRecentDate">The date of most recent estimate.</param>
        /// <param name="Median">The median target price estimate.</param>
        /// <param name="Raised">The number of estimates raised.</param>
        /// <param name="Lowered">The number of estimates lowered.</param>
        /// <param name="Company">Company.</param>
        public ZacksTargetPriceConsensus(string Ticker = default(string), string CompanyName = default(string), string IndustryGroupNumber = default(string), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Mean = default(decimal?), decimal? StandardDeviation = default(decimal?), int? Total = default(int?), DateTime? MostRecentDate = default(DateTime?), decimal? Median = default(decimal?), int? Raised = default(int?), int? Lowered = default(int?), CompanySummary Company = default(CompanySummary))
        {
            this.Ticker = Ticker;
            this.CompanyName = CompanyName;
            this.IndustryGroupNumber = IndustryGroupNumber;
            this.High = High;
            this.Low = Low;
            this.Mean = Mean;
            this.StandardDeviation = StandardDeviation;
            this.Total = Total;
            this.MostRecentDate = MostRecentDate;
            this.Median = Median;
            this.Raised = Raised;
            this.Lowered = Lowered;
            this.Company = Company;
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
        /// The Zacks industry group number
        /// </summary>
        /// <value>The Zacks industry group number</value>
        [DataMember(Name="industry_group_number", EmitDefaultValue=false)]
        public string IndustryGroupNumber { get; set; }

        /// <summary>
        /// The high target price estimate
        /// </summary>
        /// <value>The high target price estimate</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The low target price estimate
        /// </summary>
        /// <value>The low target price estimate</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The mean target price estimate
        /// </summary>
        /// <value>The mean target price estimate</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public decimal? Mean { get; set; }

        /// <summary>
        /// The standard deviation of target price estimates
        /// </summary>
        /// <value>The standard deviation of target price estimates</value>
        [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
        public decimal? StandardDeviation { get; set; }

        /// <summary>
        /// The number of target price estimates in consensus
        /// </summary>
        /// <value>The number of target price estimates in consensus</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// The date of most recent estimate
        /// </summary>
        /// <value>The date of most recent estimate</value>
        [DataMember(Name="most_recent_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? MostRecentDate { get; set; }

        /// <summary>
        /// The median target price estimate
        /// </summary>
        /// <value>The median target price estimate</value>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public decimal? Median { get; set; }

        /// <summary>
        /// The number of estimates raised
        /// </summary>
        /// <value>The number of estimates raised</value>
        [DataMember(Name="raised", EmitDefaultValue=false)]
        public int? Raised { get; set; }

        /// <summary>
        /// The number of estimates lowered
        /// </summary>
        /// <value>The number of estimates lowered</value>
        [DataMember(Name="lowered", EmitDefaultValue=false)]
        public int? Lowered { get; set; }

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
            sb.Append("class ZacksTargetPriceConsensus {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  IndustryGroupNumber: ").Append(IndustryGroupNumber).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  MostRecentDate: ").Append(MostRecentDate).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  Raised: ").Append(Raised).Append("\n");
            sb.Append("  Lowered: ").Append(Lowered).Append("\n");
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
            return this.Equals(input as ZacksTargetPriceConsensus);
        }

        /// <summary>
        /// Returns true if ZacksTargetPriceConsensus instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksTargetPriceConsensus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksTargetPriceConsensus input)
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
                    this.IndustryGroupNumber == input.IndustryGroupNumber ||
                    (this.IndustryGroupNumber != null &&
                    this.IndustryGroupNumber.Equals(input.IndustryGroupNumber))
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
                    this.StandardDeviation == input.StandardDeviation ||
                    (this.StandardDeviation != null &&
                    this.StandardDeviation.Equals(input.StandardDeviation))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.MostRecentDate == input.MostRecentDate ||
                    (this.MostRecentDate != null &&
                    this.MostRecentDate.Equals(input.MostRecentDate))
                ) && 
                (
                    this.Median == input.Median ||
                    (this.Median != null &&
                    this.Median.Equals(input.Median))
                ) && 
                (
                    this.Raised == input.Raised ||
                    (this.Raised != null &&
                    this.Raised.Equals(input.Raised))
                ) && 
                (
                    this.Lowered == input.Lowered ||
                    (this.Lowered != null &&
                    this.Lowered.Equals(input.Lowered))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.IndustryGroupNumber != null)
                    hashCode = hashCode * 59 + this.IndustryGroupNumber.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Mean != null)
                    hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.StandardDeviation != null)
                    hashCode = hashCode * 59 + this.StandardDeviation.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.MostRecentDate != null)
                    hashCode = hashCode * 59 + this.MostRecentDate.GetHashCode();
                if (this.Median != null)
                    hashCode = hashCode * 59 + this.Median.GetHashCode();
                if (this.Raised != null)
                    hashCode = hashCode * 59 + this.Raised.GetHashCode();
                if (this.Lowered != null)
                    hashCode = hashCode * 59 + this.Lowered.GetHashCode();
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

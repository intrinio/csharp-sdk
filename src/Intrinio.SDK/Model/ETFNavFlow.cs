

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
    /// NAV (Net Asset Value) and flows data for an Exchange Traded Fund (ETF) on a specific date
    /// </summary>
    [DataContract]
    public partial class ETFNavFlow :  IEquatable<ETFNavFlow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFNavFlow" /> class.
        /// </summary>
        /// <param name="AsOfDate">The date of the NAV flows data.</param>
        /// <param name="NavReturnDaily">Daily NAV return as a decimal (percentage).</param>
        /// <param name="NavReturnOneMonth">One month NAV return as a decimal (percentage).</param>
        /// <param name="NavReturnThreeMonth">Three month NAV return as a decimal (percentage).</param>
        /// <param name="NavReturnYtd">Year-to-date NAV return as a decimal (percentage).</param>
        /// <param name="NavReturnOneYear">One year NAV return as a decimal (percentage).</param>
        /// <param name="NavReturn1YearPrior">NAV return 1 year prior as a decimal (percentage).</param>
        /// <param name="NavReturn2YearPrior">NAV return 2 years prior as a decimal (percentage).</param>
        /// <param name="NavReturn3YearPrior">NAV return 3 years prior as a decimal (percentage).</param>
        /// <param name="NavReturn4YearPrior">NAV return 4 years prior as a decimal (percentage).</param>
        /// <param name="NavReturn5YearPrior">NAV return 5 years prior as a decimal (percentage).</param>
        /// <param name="NavAnnualizedReturnThreeYear">Three year annualized NAV return as a decimal (percentage).</param>
        /// <param name="NavAnnualizedReturnFiveYear">Five year annualized NAV return as a decimal (percentage).</param>
        /// <param name="NavAnnualizedReturnTenYear">Ten year annualized NAV return as a decimal (percentage).</param>
        /// <param name="NavAnnualizedReturnInception">Annualized NAV return since inception as a decimal (percentage).</param>
        /// <param name="NavUnadjusted">Net asset value unadjusted for splits or dividends.</param>
        /// <param name="NavSplitAdjusted">Net asset value adjusted for splits only.</param>
        /// <param name="NavSplitDividendAdjusted">Net asset value adjusted for both splits and dividends.</param>
        /// <param name="NetFlowsDaily">Daily net flows in dollars.</param>
        /// <param name="NetFlowsOneMonth">One month net flows in dollars.</param>
        /// <param name="NetFlowsThreeMonth">Three month net flows in dollars.</param>
        /// <param name="NetFlowsYtd">Year-to-date net flows in dollars.</param>
        /// <param name="NetFlowsOneYear">One year net flows in dollars.</param>
        /// <param name="NetFlowsThreeYear">Three year net flows in dollars.</param>
        /// <param name="NetFlowsFiveYear">Five year net flows in dollars.</param>
        /// <param name="NetFlowsTenYear">Ten year net flows in dollars.</param>
        /// <param name="NetFlows1YearPrior">Net flows 1 year prior in dollars.</param>
        /// <param name="NetFlows2YearPrior">Net flows 2 years prior in dollars.</param>
        /// <param name="NetFlows3YearPrior">Net flows 3 years prior in dollars.</param>
        /// <param name="NetFlows4YearPrior">Net flows 4 years prior in dollars.</param>
        /// <param name="NetFlows5YearPrior">Net flows 5 years prior in dollars.</param>
        /// <param name="NetFlowsInception">Net flows since inception in dollars.</param>
        /// <param name="ShareOutstandingUnadjusted">Shares outstanding unadjusted for splits.</param>
        /// <param name="ShareOutstandingSplitAdjusted">Shares outstanding adjusted for splits.</param>
        /// <param name="TotalNetAssets">Total net assets in dollars.</param>
        public ETFNavFlow(DateTime? AsOfDate = default(DateTime?), decimal? NavReturnDaily = default(decimal?), decimal? NavReturnOneMonth = default(decimal?), decimal? NavReturnThreeMonth = default(decimal?), decimal? NavReturnYtd = default(decimal?), decimal? NavReturnOneYear = default(decimal?), decimal? NavReturn1YearPrior = default(decimal?), decimal? NavReturn2YearPrior = default(decimal?), decimal? NavReturn3YearPrior = default(decimal?), decimal? NavReturn4YearPrior = default(decimal?), decimal? NavReturn5YearPrior = default(decimal?), decimal? NavAnnualizedReturnThreeYear = default(decimal?), decimal? NavAnnualizedReturnFiveYear = default(decimal?), decimal? NavAnnualizedReturnTenYear = default(decimal?), decimal? NavAnnualizedReturnInception = default(decimal?), decimal? NavUnadjusted = default(decimal?), decimal? NavSplitAdjusted = default(decimal?), decimal? NavSplitDividendAdjusted = default(decimal?), decimal? NetFlowsDaily = default(decimal?), decimal? NetFlowsOneMonth = default(decimal?), decimal? NetFlowsThreeMonth = default(decimal?), decimal? NetFlowsYtd = default(decimal?), decimal? NetFlowsOneYear = default(decimal?), decimal? NetFlowsThreeYear = default(decimal?), decimal? NetFlowsFiveYear = default(decimal?), decimal? NetFlowsTenYear = default(decimal?), decimal? NetFlows1YearPrior = default(decimal?), decimal? NetFlows2YearPrior = default(decimal?), decimal? NetFlows3YearPrior = default(decimal?), decimal? NetFlows4YearPrior = default(decimal?), decimal? NetFlows5YearPrior = default(decimal?), decimal? NetFlowsInception = default(decimal?), decimal? ShareOutstandingUnadjusted = default(decimal?), decimal? ShareOutstandingSplitAdjusted = default(decimal?), decimal? TotalNetAssets = default(decimal?))
        {
            this.AsOfDate = AsOfDate;
            this.NavReturnDaily = NavReturnDaily;
            this.NavReturnOneMonth = NavReturnOneMonth;
            this.NavReturnThreeMonth = NavReturnThreeMonth;
            this.NavReturnYtd = NavReturnYtd;
            this.NavReturnOneYear = NavReturnOneYear;
            this.NavReturn1YearPrior = NavReturn1YearPrior;
            this.NavReturn2YearPrior = NavReturn2YearPrior;
            this.NavReturn3YearPrior = NavReturn3YearPrior;
            this.NavReturn4YearPrior = NavReturn4YearPrior;
            this.NavReturn5YearPrior = NavReturn5YearPrior;
            this.NavAnnualizedReturnThreeYear = NavAnnualizedReturnThreeYear;
            this.NavAnnualizedReturnFiveYear = NavAnnualizedReturnFiveYear;
            this.NavAnnualizedReturnTenYear = NavAnnualizedReturnTenYear;
            this.NavAnnualizedReturnInception = NavAnnualizedReturnInception;
            this.NavUnadjusted = NavUnadjusted;
            this.NavSplitAdjusted = NavSplitAdjusted;
            this.NavSplitDividendAdjusted = NavSplitDividendAdjusted;
            this.NetFlowsDaily = NetFlowsDaily;
            this.NetFlowsOneMonth = NetFlowsOneMonth;
            this.NetFlowsThreeMonth = NetFlowsThreeMonth;
            this.NetFlowsYtd = NetFlowsYtd;
            this.NetFlowsOneYear = NetFlowsOneYear;
            this.NetFlowsThreeYear = NetFlowsThreeYear;
            this.NetFlowsFiveYear = NetFlowsFiveYear;
            this.NetFlowsTenYear = NetFlowsTenYear;
            this.NetFlows1YearPrior = NetFlows1YearPrior;
            this.NetFlows2YearPrior = NetFlows2YearPrior;
            this.NetFlows3YearPrior = NetFlows3YearPrior;
            this.NetFlows4YearPrior = NetFlows4YearPrior;
            this.NetFlows5YearPrior = NetFlows5YearPrior;
            this.NetFlowsInception = NetFlowsInception;
            this.ShareOutstandingUnadjusted = ShareOutstandingUnadjusted;
            this.ShareOutstandingSplitAdjusted = ShareOutstandingSplitAdjusted;
            this.TotalNetAssets = TotalNetAssets;
        }
        
        /// <summary>
        /// The date of the NAV flows data
        /// </summary>
        /// <value>The date of the NAV flows data</value>
        [DataMember(Name="as_of_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AsOfDate { get; set; }

        /// <summary>
        /// Daily NAV return as a decimal (percentage)
        /// </summary>
        /// <value>Daily NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_return_daily", EmitDefaultValue=false)]
        public decimal? NavReturnDaily { get; set; }

        /// <summary>
        /// One month NAV return as a decimal (percentage)
        /// </summary>
        /// <value>One month NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_return_one_month", EmitDefaultValue=false)]
        public decimal? NavReturnOneMonth { get; set; }

        /// <summary>
        /// Three month NAV return as a decimal (percentage)
        /// </summary>
        /// <value>Three month NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_return_three_month", EmitDefaultValue=false)]
        public decimal? NavReturnThreeMonth { get; set; }

        /// <summary>
        /// Year-to-date NAV return as a decimal (percentage)
        /// </summary>
        /// <value>Year-to-date NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_return_ytd", EmitDefaultValue=false)]
        public decimal? NavReturnYtd { get; set; }

        /// <summary>
        /// One year NAV return as a decimal (percentage)
        /// </summary>
        /// <value>One year NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_return_one_year", EmitDefaultValue=false)]
        public decimal? NavReturnOneYear { get; set; }

        /// <summary>
        /// NAV return 1 year prior as a decimal (percentage)
        /// </summary>
        /// <value>NAV return 1 year prior as a decimal (percentage)</value>
        [DataMember(Name="nav_return_1_year_prior", EmitDefaultValue=false)]
        public decimal? NavReturn1YearPrior { get; set; }

        /// <summary>
        /// NAV return 2 years prior as a decimal (percentage)
        /// </summary>
        /// <value>NAV return 2 years prior as a decimal (percentage)</value>
        [DataMember(Name="nav_return_2_year_prior", EmitDefaultValue=false)]
        public decimal? NavReturn2YearPrior { get; set; }

        /// <summary>
        /// NAV return 3 years prior as a decimal (percentage)
        /// </summary>
        /// <value>NAV return 3 years prior as a decimal (percentage)</value>
        [DataMember(Name="nav_return_3_year_prior", EmitDefaultValue=false)]
        public decimal? NavReturn3YearPrior { get; set; }

        /// <summary>
        /// NAV return 4 years prior as a decimal (percentage)
        /// </summary>
        /// <value>NAV return 4 years prior as a decimal (percentage)</value>
        [DataMember(Name="nav_return_4_year_prior", EmitDefaultValue=false)]
        public decimal? NavReturn4YearPrior { get; set; }

        /// <summary>
        /// NAV return 5 years prior as a decimal (percentage)
        /// </summary>
        /// <value>NAV return 5 years prior as a decimal (percentage)</value>
        [DataMember(Name="nav_return_5_year_prior", EmitDefaultValue=false)]
        public decimal? NavReturn5YearPrior { get; set; }

        /// <summary>
        /// Three year annualized NAV return as a decimal (percentage)
        /// </summary>
        /// <value>Three year annualized NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_annualized_return_three_year", EmitDefaultValue=false)]
        public decimal? NavAnnualizedReturnThreeYear { get; set; }

        /// <summary>
        /// Five year annualized NAV return as a decimal (percentage)
        /// </summary>
        /// <value>Five year annualized NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_annualized_return_five_year", EmitDefaultValue=false)]
        public decimal? NavAnnualizedReturnFiveYear { get; set; }

        /// <summary>
        /// Ten year annualized NAV return as a decimal (percentage)
        /// </summary>
        /// <value>Ten year annualized NAV return as a decimal (percentage)</value>
        [DataMember(Name="nav_annualized_return_ten_year", EmitDefaultValue=false)]
        public decimal? NavAnnualizedReturnTenYear { get; set; }

        /// <summary>
        /// Annualized NAV return since inception as a decimal (percentage)
        /// </summary>
        /// <value>Annualized NAV return since inception as a decimal (percentage)</value>
        [DataMember(Name="nav_annualized_return_inception", EmitDefaultValue=false)]
        public decimal? NavAnnualizedReturnInception { get; set; }

        /// <summary>
        /// Net asset value unadjusted for splits or dividends
        /// </summary>
        /// <value>Net asset value unadjusted for splits or dividends</value>
        [DataMember(Name="nav_unadjusted", EmitDefaultValue=false)]
        public decimal? NavUnadjusted { get; set; }

        /// <summary>
        /// Net asset value adjusted for splits only
        /// </summary>
        /// <value>Net asset value adjusted for splits only</value>
        [DataMember(Name="nav_split_adjusted", EmitDefaultValue=false)]
        public decimal? NavSplitAdjusted { get; set; }

        /// <summary>
        /// Net asset value adjusted for both splits and dividends
        /// </summary>
        /// <value>Net asset value adjusted for both splits and dividends</value>
        [DataMember(Name="nav_split_dividend_adjusted", EmitDefaultValue=false)]
        public decimal? NavSplitDividendAdjusted { get; set; }

        /// <summary>
        /// Daily net flows in dollars
        /// </summary>
        /// <value>Daily net flows in dollars</value>
        [DataMember(Name="net_flows_daily", EmitDefaultValue=false)]
        public decimal? NetFlowsDaily { get; set; }

        /// <summary>
        /// One month net flows in dollars
        /// </summary>
        /// <value>One month net flows in dollars</value>
        [DataMember(Name="net_flows_one_month", EmitDefaultValue=false)]
        public decimal? NetFlowsOneMonth { get; set; }

        /// <summary>
        /// Three month net flows in dollars
        /// </summary>
        /// <value>Three month net flows in dollars</value>
        [DataMember(Name="net_flows_three_month", EmitDefaultValue=false)]
        public decimal? NetFlowsThreeMonth { get; set; }

        /// <summary>
        /// Year-to-date net flows in dollars
        /// </summary>
        /// <value>Year-to-date net flows in dollars</value>
        [DataMember(Name="net_flows_ytd", EmitDefaultValue=false)]
        public decimal? NetFlowsYtd { get; set; }

        /// <summary>
        /// One year net flows in dollars
        /// </summary>
        /// <value>One year net flows in dollars</value>
        [DataMember(Name="net_flows_one_year", EmitDefaultValue=false)]
        public decimal? NetFlowsOneYear { get; set; }

        /// <summary>
        /// Three year net flows in dollars
        /// </summary>
        /// <value>Three year net flows in dollars</value>
        [DataMember(Name="net_flows_three_year", EmitDefaultValue=false)]
        public decimal? NetFlowsThreeYear { get; set; }

        /// <summary>
        /// Five year net flows in dollars
        /// </summary>
        /// <value>Five year net flows in dollars</value>
        [DataMember(Name="net_flows_five_year", EmitDefaultValue=false)]
        public decimal? NetFlowsFiveYear { get; set; }

        /// <summary>
        /// Ten year net flows in dollars
        /// </summary>
        /// <value>Ten year net flows in dollars</value>
        [DataMember(Name="net_flows_ten_year", EmitDefaultValue=false)]
        public decimal? NetFlowsTenYear { get; set; }

        /// <summary>
        /// Net flows 1 year prior in dollars
        /// </summary>
        /// <value>Net flows 1 year prior in dollars</value>
        [DataMember(Name="net_flows_1_year_prior", EmitDefaultValue=false)]
        public decimal? NetFlows1YearPrior { get; set; }

        /// <summary>
        /// Net flows 2 years prior in dollars
        /// </summary>
        /// <value>Net flows 2 years prior in dollars</value>
        [DataMember(Name="net_flows_2_year_prior", EmitDefaultValue=false)]
        public decimal? NetFlows2YearPrior { get; set; }

        /// <summary>
        /// Net flows 3 years prior in dollars
        /// </summary>
        /// <value>Net flows 3 years prior in dollars</value>
        [DataMember(Name="net_flows_3_year_prior", EmitDefaultValue=false)]
        public decimal? NetFlows3YearPrior { get; set; }

        /// <summary>
        /// Net flows 4 years prior in dollars
        /// </summary>
        /// <value>Net flows 4 years prior in dollars</value>
        [DataMember(Name="net_flows_4_year_prior", EmitDefaultValue=false)]
        public decimal? NetFlows4YearPrior { get; set; }

        /// <summary>
        /// Net flows 5 years prior in dollars
        /// </summary>
        /// <value>Net flows 5 years prior in dollars</value>
        [DataMember(Name="net_flows_5_year_prior", EmitDefaultValue=false)]
        public decimal? NetFlows5YearPrior { get; set; }

        /// <summary>
        /// Net flows since inception in dollars
        /// </summary>
        /// <value>Net flows since inception in dollars</value>
        [DataMember(Name="net_flows_inception", EmitDefaultValue=false)]
        public decimal? NetFlowsInception { get; set; }

        /// <summary>
        /// Shares outstanding unadjusted for splits
        /// </summary>
        /// <value>Shares outstanding unadjusted for splits</value>
        [DataMember(Name="share_outstanding_unadjusted", EmitDefaultValue=false)]
        public decimal? ShareOutstandingUnadjusted { get; set; }

        /// <summary>
        /// Shares outstanding adjusted for splits
        /// </summary>
        /// <value>Shares outstanding adjusted for splits</value>
        [DataMember(Name="share_outstanding_split_adjusted", EmitDefaultValue=false)]
        public decimal? ShareOutstandingSplitAdjusted { get; set; }

        /// <summary>
        /// Total net assets in dollars
        /// </summary>
        /// <value>Total net assets in dollars</value>
        [DataMember(Name="total_net_assets", EmitDefaultValue=false)]
        public decimal? TotalNetAssets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFNavFlow {\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  NavReturnDaily: ").Append(NavReturnDaily).Append("\n");
            sb.Append("  NavReturnOneMonth: ").Append(NavReturnOneMonth).Append("\n");
            sb.Append("  NavReturnThreeMonth: ").Append(NavReturnThreeMonth).Append("\n");
            sb.Append("  NavReturnYtd: ").Append(NavReturnYtd).Append("\n");
            sb.Append("  NavReturnOneYear: ").Append(NavReturnOneYear).Append("\n");
            sb.Append("  NavReturn1YearPrior: ").Append(NavReturn1YearPrior).Append("\n");
            sb.Append("  NavReturn2YearPrior: ").Append(NavReturn2YearPrior).Append("\n");
            sb.Append("  NavReturn3YearPrior: ").Append(NavReturn3YearPrior).Append("\n");
            sb.Append("  NavReturn4YearPrior: ").Append(NavReturn4YearPrior).Append("\n");
            sb.Append("  NavReturn5YearPrior: ").Append(NavReturn5YearPrior).Append("\n");
            sb.Append("  NavAnnualizedReturnThreeYear: ").Append(NavAnnualizedReturnThreeYear).Append("\n");
            sb.Append("  NavAnnualizedReturnFiveYear: ").Append(NavAnnualizedReturnFiveYear).Append("\n");
            sb.Append("  NavAnnualizedReturnTenYear: ").Append(NavAnnualizedReturnTenYear).Append("\n");
            sb.Append("  NavAnnualizedReturnInception: ").Append(NavAnnualizedReturnInception).Append("\n");
            sb.Append("  NavUnadjusted: ").Append(NavUnadjusted).Append("\n");
            sb.Append("  NavSplitAdjusted: ").Append(NavSplitAdjusted).Append("\n");
            sb.Append("  NavSplitDividendAdjusted: ").Append(NavSplitDividendAdjusted).Append("\n");
            sb.Append("  NetFlowsDaily: ").Append(NetFlowsDaily).Append("\n");
            sb.Append("  NetFlowsOneMonth: ").Append(NetFlowsOneMonth).Append("\n");
            sb.Append("  NetFlowsThreeMonth: ").Append(NetFlowsThreeMonth).Append("\n");
            sb.Append("  NetFlowsYtd: ").Append(NetFlowsYtd).Append("\n");
            sb.Append("  NetFlowsOneYear: ").Append(NetFlowsOneYear).Append("\n");
            sb.Append("  NetFlowsThreeYear: ").Append(NetFlowsThreeYear).Append("\n");
            sb.Append("  NetFlowsFiveYear: ").Append(NetFlowsFiveYear).Append("\n");
            sb.Append("  NetFlowsTenYear: ").Append(NetFlowsTenYear).Append("\n");
            sb.Append("  NetFlows1YearPrior: ").Append(NetFlows1YearPrior).Append("\n");
            sb.Append("  NetFlows2YearPrior: ").Append(NetFlows2YearPrior).Append("\n");
            sb.Append("  NetFlows3YearPrior: ").Append(NetFlows3YearPrior).Append("\n");
            sb.Append("  NetFlows4YearPrior: ").Append(NetFlows4YearPrior).Append("\n");
            sb.Append("  NetFlows5YearPrior: ").Append(NetFlows5YearPrior).Append("\n");
            sb.Append("  NetFlowsInception: ").Append(NetFlowsInception).Append("\n");
            sb.Append("  ShareOutstandingUnadjusted: ").Append(ShareOutstandingUnadjusted).Append("\n");
            sb.Append("  ShareOutstandingSplitAdjusted: ").Append(ShareOutstandingSplitAdjusted).Append("\n");
            sb.Append("  TotalNetAssets: ").Append(TotalNetAssets).Append("\n");
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
            return this.Equals(input as ETFNavFlow);
        }

        /// <summary>
        /// Returns true if ETFNavFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFNavFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFNavFlow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.NavReturnDaily == input.NavReturnDaily ||
                    (this.NavReturnDaily != null &&
                    this.NavReturnDaily.Equals(input.NavReturnDaily))
                ) && 
                (
                    this.NavReturnOneMonth == input.NavReturnOneMonth ||
                    (this.NavReturnOneMonth != null &&
                    this.NavReturnOneMonth.Equals(input.NavReturnOneMonth))
                ) && 
                (
                    this.NavReturnThreeMonth == input.NavReturnThreeMonth ||
                    (this.NavReturnThreeMonth != null &&
                    this.NavReturnThreeMonth.Equals(input.NavReturnThreeMonth))
                ) && 
                (
                    this.NavReturnYtd == input.NavReturnYtd ||
                    (this.NavReturnYtd != null &&
                    this.NavReturnYtd.Equals(input.NavReturnYtd))
                ) && 
                (
                    this.NavReturnOneYear == input.NavReturnOneYear ||
                    (this.NavReturnOneYear != null &&
                    this.NavReturnOneYear.Equals(input.NavReturnOneYear))
                ) && 
                (
                    this.NavReturn1YearPrior == input.NavReturn1YearPrior ||
                    (this.NavReturn1YearPrior != null &&
                    this.NavReturn1YearPrior.Equals(input.NavReturn1YearPrior))
                ) && 
                (
                    this.NavReturn2YearPrior == input.NavReturn2YearPrior ||
                    (this.NavReturn2YearPrior != null &&
                    this.NavReturn2YearPrior.Equals(input.NavReturn2YearPrior))
                ) && 
                (
                    this.NavReturn3YearPrior == input.NavReturn3YearPrior ||
                    (this.NavReturn3YearPrior != null &&
                    this.NavReturn3YearPrior.Equals(input.NavReturn3YearPrior))
                ) && 
                (
                    this.NavReturn4YearPrior == input.NavReturn4YearPrior ||
                    (this.NavReturn4YearPrior != null &&
                    this.NavReturn4YearPrior.Equals(input.NavReturn4YearPrior))
                ) && 
                (
                    this.NavReturn5YearPrior == input.NavReturn5YearPrior ||
                    (this.NavReturn5YearPrior != null &&
                    this.NavReturn5YearPrior.Equals(input.NavReturn5YearPrior))
                ) && 
                (
                    this.NavAnnualizedReturnThreeYear == input.NavAnnualizedReturnThreeYear ||
                    (this.NavAnnualizedReturnThreeYear != null &&
                    this.NavAnnualizedReturnThreeYear.Equals(input.NavAnnualizedReturnThreeYear))
                ) && 
                (
                    this.NavAnnualizedReturnFiveYear == input.NavAnnualizedReturnFiveYear ||
                    (this.NavAnnualizedReturnFiveYear != null &&
                    this.NavAnnualizedReturnFiveYear.Equals(input.NavAnnualizedReturnFiveYear))
                ) && 
                (
                    this.NavAnnualizedReturnTenYear == input.NavAnnualizedReturnTenYear ||
                    (this.NavAnnualizedReturnTenYear != null &&
                    this.NavAnnualizedReturnTenYear.Equals(input.NavAnnualizedReturnTenYear))
                ) && 
                (
                    this.NavAnnualizedReturnInception == input.NavAnnualizedReturnInception ||
                    (this.NavAnnualizedReturnInception != null &&
                    this.NavAnnualizedReturnInception.Equals(input.NavAnnualizedReturnInception))
                ) && 
                (
                    this.NavUnadjusted == input.NavUnadjusted ||
                    (this.NavUnadjusted != null &&
                    this.NavUnadjusted.Equals(input.NavUnadjusted))
                ) && 
                (
                    this.NavSplitAdjusted == input.NavSplitAdjusted ||
                    (this.NavSplitAdjusted != null &&
                    this.NavSplitAdjusted.Equals(input.NavSplitAdjusted))
                ) && 
                (
                    this.NavSplitDividendAdjusted == input.NavSplitDividendAdjusted ||
                    (this.NavSplitDividendAdjusted != null &&
                    this.NavSplitDividendAdjusted.Equals(input.NavSplitDividendAdjusted))
                ) && 
                (
                    this.NetFlowsDaily == input.NetFlowsDaily ||
                    (this.NetFlowsDaily != null &&
                    this.NetFlowsDaily.Equals(input.NetFlowsDaily))
                ) && 
                (
                    this.NetFlowsOneMonth == input.NetFlowsOneMonth ||
                    (this.NetFlowsOneMonth != null &&
                    this.NetFlowsOneMonth.Equals(input.NetFlowsOneMonth))
                ) && 
                (
                    this.NetFlowsThreeMonth == input.NetFlowsThreeMonth ||
                    (this.NetFlowsThreeMonth != null &&
                    this.NetFlowsThreeMonth.Equals(input.NetFlowsThreeMonth))
                ) && 
                (
                    this.NetFlowsYtd == input.NetFlowsYtd ||
                    (this.NetFlowsYtd != null &&
                    this.NetFlowsYtd.Equals(input.NetFlowsYtd))
                ) && 
                (
                    this.NetFlowsOneYear == input.NetFlowsOneYear ||
                    (this.NetFlowsOneYear != null &&
                    this.NetFlowsOneYear.Equals(input.NetFlowsOneYear))
                ) && 
                (
                    this.NetFlowsThreeYear == input.NetFlowsThreeYear ||
                    (this.NetFlowsThreeYear != null &&
                    this.NetFlowsThreeYear.Equals(input.NetFlowsThreeYear))
                ) && 
                (
                    this.NetFlowsFiveYear == input.NetFlowsFiveYear ||
                    (this.NetFlowsFiveYear != null &&
                    this.NetFlowsFiveYear.Equals(input.NetFlowsFiveYear))
                ) && 
                (
                    this.NetFlowsTenYear == input.NetFlowsTenYear ||
                    (this.NetFlowsTenYear != null &&
                    this.NetFlowsTenYear.Equals(input.NetFlowsTenYear))
                ) && 
                (
                    this.NetFlows1YearPrior == input.NetFlows1YearPrior ||
                    (this.NetFlows1YearPrior != null &&
                    this.NetFlows1YearPrior.Equals(input.NetFlows1YearPrior))
                ) && 
                (
                    this.NetFlows2YearPrior == input.NetFlows2YearPrior ||
                    (this.NetFlows2YearPrior != null &&
                    this.NetFlows2YearPrior.Equals(input.NetFlows2YearPrior))
                ) && 
                (
                    this.NetFlows3YearPrior == input.NetFlows3YearPrior ||
                    (this.NetFlows3YearPrior != null &&
                    this.NetFlows3YearPrior.Equals(input.NetFlows3YearPrior))
                ) && 
                (
                    this.NetFlows4YearPrior == input.NetFlows4YearPrior ||
                    (this.NetFlows4YearPrior != null &&
                    this.NetFlows4YearPrior.Equals(input.NetFlows4YearPrior))
                ) && 
                (
                    this.NetFlows5YearPrior == input.NetFlows5YearPrior ||
                    (this.NetFlows5YearPrior != null &&
                    this.NetFlows5YearPrior.Equals(input.NetFlows5YearPrior))
                ) && 
                (
                    this.NetFlowsInception == input.NetFlowsInception ||
                    (this.NetFlowsInception != null &&
                    this.NetFlowsInception.Equals(input.NetFlowsInception))
                ) && 
                (
                    this.ShareOutstandingUnadjusted == input.ShareOutstandingUnadjusted ||
                    (this.ShareOutstandingUnadjusted != null &&
                    this.ShareOutstandingUnadjusted.Equals(input.ShareOutstandingUnadjusted))
                ) && 
                (
                    this.ShareOutstandingSplitAdjusted == input.ShareOutstandingSplitAdjusted ||
                    (this.ShareOutstandingSplitAdjusted != null &&
                    this.ShareOutstandingSplitAdjusted.Equals(input.ShareOutstandingSplitAdjusted))
                ) && 
                (
                    this.TotalNetAssets == input.TotalNetAssets ||
                    (this.TotalNetAssets != null &&
                    this.TotalNetAssets.Equals(input.TotalNetAssets))
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
                if (this.AsOfDate != null)
                    hashCode = hashCode * 59 + this.AsOfDate.GetHashCode();
                if (this.NavReturnDaily != null)
                    hashCode = hashCode * 59 + this.NavReturnDaily.GetHashCode();
                if (this.NavReturnOneMonth != null)
                    hashCode = hashCode * 59 + this.NavReturnOneMonth.GetHashCode();
                if (this.NavReturnThreeMonth != null)
                    hashCode = hashCode * 59 + this.NavReturnThreeMonth.GetHashCode();
                if (this.NavReturnYtd != null)
                    hashCode = hashCode * 59 + this.NavReturnYtd.GetHashCode();
                if (this.NavReturnOneYear != null)
                    hashCode = hashCode * 59 + this.NavReturnOneYear.GetHashCode();
                if (this.NavReturn1YearPrior != null)
                    hashCode = hashCode * 59 + this.NavReturn1YearPrior.GetHashCode();
                if (this.NavReturn2YearPrior != null)
                    hashCode = hashCode * 59 + this.NavReturn2YearPrior.GetHashCode();
                if (this.NavReturn3YearPrior != null)
                    hashCode = hashCode * 59 + this.NavReturn3YearPrior.GetHashCode();
                if (this.NavReturn4YearPrior != null)
                    hashCode = hashCode * 59 + this.NavReturn4YearPrior.GetHashCode();
                if (this.NavReturn5YearPrior != null)
                    hashCode = hashCode * 59 + this.NavReturn5YearPrior.GetHashCode();
                if (this.NavAnnualizedReturnThreeYear != null)
                    hashCode = hashCode * 59 + this.NavAnnualizedReturnThreeYear.GetHashCode();
                if (this.NavAnnualizedReturnFiveYear != null)
                    hashCode = hashCode * 59 + this.NavAnnualizedReturnFiveYear.GetHashCode();
                if (this.NavAnnualizedReturnTenYear != null)
                    hashCode = hashCode * 59 + this.NavAnnualizedReturnTenYear.GetHashCode();
                if (this.NavAnnualizedReturnInception != null)
                    hashCode = hashCode * 59 + this.NavAnnualizedReturnInception.GetHashCode();
                if (this.NavUnadjusted != null)
                    hashCode = hashCode * 59 + this.NavUnadjusted.GetHashCode();
                if (this.NavSplitAdjusted != null)
                    hashCode = hashCode * 59 + this.NavSplitAdjusted.GetHashCode();
                if (this.NavSplitDividendAdjusted != null)
                    hashCode = hashCode * 59 + this.NavSplitDividendAdjusted.GetHashCode();
                if (this.NetFlowsDaily != null)
                    hashCode = hashCode * 59 + this.NetFlowsDaily.GetHashCode();
                if (this.NetFlowsOneMonth != null)
                    hashCode = hashCode * 59 + this.NetFlowsOneMonth.GetHashCode();
                if (this.NetFlowsThreeMonth != null)
                    hashCode = hashCode * 59 + this.NetFlowsThreeMonth.GetHashCode();
                if (this.NetFlowsYtd != null)
                    hashCode = hashCode * 59 + this.NetFlowsYtd.GetHashCode();
                if (this.NetFlowsOneYear != null)
                    hashCode = hashCode * 59 + this.NetFlowsOneYear.GetHashCode();
                if (this.NetFlowsThreeYear != null)
                    hashCode = hashCode * 59 + this.NetFlowsThreeYear.GetHashCode();
                if (this.NetFlowsFiveYear != null)
                    hashCode = hashCode * 59 + this.NetFlowsFiveYear.GetHashCode();
                if (this.NetFlowsTenYear != null)
                    hashCode = hashCode * 59 + this.NetFlowsTenYear.GetHashCode();
                if (this.NetFlows1YearPrior != null)
                    hashCode = hashCode * 59 + this.NetFlows1YearPrior.GetHashCode();
                if (this.NetFlows2YearPrior != null)
                    hashCode = hashCode * 59 + this.NetFlows2YearPrior.GetHashCode();
                if (this.NetFlows3YearPrior != null)
                    hashCode = hashCode * 59 + this.NetFlows3YearPrior.GetHashCode();
                if (this.NetFlows4YearPrior != null)
                    hashCode = hashCode * 59 + this.NetFlows4YearPrior.GetHashCode();
                if (this.NetFlows5YearPrior != null)
                    hashCode = hashCode * 59 + this.NetFlows5YearPrior.GetHashCode();
                if (this.NetFlowsInception != null)
                    hashCode = hashCode * 59 + this.NetFlowsInception.GetHashCode();
                if (this.ShareOutstandingUnadjusted != null)
                    hashCode = hashCode * 59 + this.ShareOutstandingUnadjusted.GetHashCode();
                if (this.ShareOutstandingSplitAdjusted != null)
                    hashCode = hashCode * 59 + this.ShareOutstandingSplitAdjusted.GetHashCode();
                if (this.TotalNetAssets != null)
                    hashCode = hashCode * 59 + this.TotalNetAssets.GetHashCode();
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

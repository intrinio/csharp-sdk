

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
    /// Zacks earnings-per-share (EPS) growth rates from analysts for thousands of stocks.  Zacks storied research team aggregates and validates the estimates.  Each Growth Rate includes metadata about the corresponding Company.
    /// </summary>
    [DataContract]
    public partial class ZacksEPSGrowthRate :  IEquatable<ZacksEPSGrowthRate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksEPSGrowthRate" /> class.
        /// </summary>
        /// <param name="Ticker">The Zacks common exchange ticker.</param>
        /// <param name="CompanyName">The company name.</param>
        /// <param name="IndustryGroupNumber">The Zacks industry group number.</param>
        /// <param name="IndustryGroupName">The Zacks industry group name.</param>
        /// <param name="FiscalYear0">The current fiscal year.</param>
        /// <param name="FiscalYear1">The next fiscal year.</param>
        /// <param name="FiscalYear2">The fiscal year after the next fiscal year.</param>
        /// <param name="CompanyLast5YearActual">The company&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="CompanyFiscalYear1VsFiscalYear0">The company&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="CompanyFiscalYear2VsFiscalYear1">The company&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="CompanyLongTermGrowthMean">The company&#39;s long term growth rate mean estimate.</param>
        /// <param name="CompanyFiscalYear1ForwardPriceToEarnings">The company&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio.</param>
        /// <param name="IndustryLast5YearActual">The industry&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="IndustryFiscalYear1VsFiscalYear0">The industry&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="IndustryFiscalYear2VsFiscalYear1">The industry&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="IndustryLongTermGrowthMean">The industry&#39;s long term growth rate mean estimate.</param>
        /// <param name="IndustryFiscalYear1ForwardPriceToEarnings">The industry&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio.</param>
        /// <param name="Sp500Last5YearActual">The S&amp;P 500&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="Sp500FiscalYear1VsFiscalYear0">The S&amp;P 500&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="Sp500FiscalYear2VsFiscalYear1">The S&amp;P 500&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate.</param>
        /// <param name="Sp500LongTermGrowth">The S&amp;P 500&#39;s long term growth rate mean estimate.</param>
        /// <param name="Sp500FiscalYear1PriceToEarnings">The S&amp;P 500&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio.</param>
        /// <param name="Company">Company.</param>
        public ZacksEPSGrowthRate(string Ticker = default(string), string CompanyName = default(string), string IndustryGroupNumber = default(string), string IndustryGroupName = default(string), int? FiscalYear0 = default(int?), int? FiscalYear1 = default(int?), int? FiscalYear2 = default(int?), decimal? CompanyLast5YearActual = default(decimal?), decimal? CompanyFiscalYear1VsFiscalYear0 = default(decimal?), decimal? CompanyFiscalYear2VsFiscalYear1 = default(decimal?), decimal? CompanyLongTermGrowthMean = default(decimal?), decimal? CompanyFiscalYear1ForwardPriceToEarnings = default(decimal?), decimal? IndustryLast5YearActual = default(decimal?), decimal? IndustryFiscalYear1VsFiscalYear0 = default(decimal?), decimal? IndustryFiscalYear2VsFiscalYear1 = default(decimal?), decimal? IndustryLongTermGrowthMean = default(decimal?), decimal? IndustryFiscalYear1ForwardPriceToEarnings = default(decimal?), decimal? Sp500Last5YearActual = default(decimal?), decimal? Sp500FiscalYear1VsFiscalYear0 = default(decimal?), decimal? Sp500FiscalYear2VsFiscalYear1 = default(decimal?), decimal? Sp500LongTermGrowth = default(decimal?), decimal? Sp500FiscalYear1PriceToEarnings = default(decimal?), CompanySummary Company = default(CompanySummary))
        {
            this.Ticker = Ticker;
            this.CompanyName = CompanyName;
            this.IndustryGroupNumber = IndustryGroupNumber;
            this.IndustryGroupName = IndustryGroupName;
            this.FiscalYear0 = FiscalYear0;
            this.FiscalYear1 = FiscalYear1;
            this.FiscalYear2 = FiscalYear2;
            this.CompanyLast5YearActual = CompanyLast5YearActual;
            this.CompanyFiscalYear1VsFiscalYear0 = CompanyFiscalYear1VsFiscalYear0;
            this.CompanyFiscalYear2VsFiscalYear1 = CompanyFiscalYear2VsFiscalYear1;
            this.CompanyLongTermGrowthMean = CompanyLongTermGrowthMean;
            this.CompanyFiscalYear1ForwardPriceToEarnings = CompanyFiscalYear1ForwardPriceToEarnings;
            this.IndustryLast5YearActual = IndustryLast5YearActual;
            this.IndustryFiscalYear1VsFiscalYear0 = IndustryFiscalYear1VsFiscalYear0;
            this.IndustryFiscalYear2VsFiscalYear1 = IndustryFiscalYear2VsFiscalYear1;
            this.IndustryLongTermGrowthMean = IndustryLongTermGrowthMean;
            this.IndustryFiscalYear1ForwardPriceToEarnings = IndustryFiscalYear1ForwardPriceToEarnings;
            this.Sp500Last5YearActual = Sp500Last5YearActual;
            this.Sp500FiscalYear1VsFiscalYear0 = Sp500FiscalYear1VsFiscalYear0;
            this.Sp500FiscalYear2VsFiscalYear1 = Sp500FiscalYear2VsFiscalYear1;
            this.Sp500LongTermGrowth = Sp500LongTermGrowth;
            this.Sp500FiscalYear1PriceToEarnings = Sp500FiscalYear1PriceToEarnings;
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
        /// The Zacks industry group name
        /// </summary>
        /// <value>The Zacks industry group name</value>
        [DataMember(Name="industry_group_name", EmitDefaultValue=false)]
        public string IndustryGroupName { get; set; }

        /// <summary>
        /// The current fiscal year
        /// </summary>
        /// <value>The current fiscal year</value>
        [DataMember(Name="fiscal_year_0", EmitDefaultValue=false)]
        public int? FiscalYear0 { get; set; }

        /// <summary>
        /// The next fiscal year
        /// </summary>
        /// <value>The next fiscal year</value>
        [DataMember(Name="fiscal_year_1", EmitDefaultValue=false)]
        public int? FiscalYear1 { get; set; }

        /// <summary>
        /// The fiscal year after the next fiscal year
        /// </summary>
        /// <value>The fiscal year after the next fiscal year</value>
        [DataMember(Name="fiscal_year_2", EmitDefaultValue=false)]
        public int? FiscalYear2 { get; set; }

        /// <summary>
        /// The company&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The company&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="company_last_5_year_actual", EmitDefaultValue=false)]
        public decimal? CompanyLast5YearActual { get; set; }

        /// <summary>
        /// The company&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The company&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="company_fiscal_year_1_vs_fiscal_year_0", EmitDefaultValue=false)]
        public decimal? CompanyFiscalYear1VsFiscalYear0 { get; set; }

        /// <summary>
        /// The company&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The company&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="company_fiscal_year_2_vs_fiscal_year_1", EmitDefaultValue=false)]
        public decimal? CompanyFiscalYear2VsFiscalYear1 { get; set; }

        /// <summary>
        /// The company&#39;s long term growth rate mean estimate
        /// </summary>
        /// <value>The company&#39;s long term growth rate mean estimate</value>
        [DataMember(Name="company_long_term_growth_mean", EmitDefaultValue=false)]
        public decimal? CompanyLongTermGrowthMean { get; set; }

        /// <summary>
        /// The company&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio
        /// </summary>
        /// <value>The company&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio</value>
        [DataMember(Name="company_fiscal_year_1_forward_price_to_earnings", EmitDefaultValue=false)]
        public decimal? CompanyFiscalYear1ForwardPriceToEarnings { get; set; }

        /// <summary>
        /// The industry&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The industry&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="industry_last_5_year_actual", EmitDefaultValue=false)]
        public decimal? IndustryLast5YearActual { get; set; }

        /// <summary>
        /// The industry&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The industry&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="industry_fiscal_year_1_vs_fiscal_year_0", EmitDefaultValue=false)]
        public decimal? IndustryFiscalYear1VsFiscalYear0 { get; set; }

        /// <summary>
        /// The industry&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The industry&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="industry_fiscal_year_2_vs_fiscal_year_1", EmitDefaultValue=false)]
        public decimal? IndustryFiscalYear2VsFiscalYear1 { get; set; }

        /// <summary>
        /// The industry&#39;s long term growth rate mean estimate
        /// </summary>
        /// <value>The industry&#39;s long term growth rate mean estimate</value>
        [DataMember(Name="industry_long_term_growth_mean", EmitDefaultValue=false)]
        public decimal? IndustryLongTermGrowthMean { get; set; }

        /// <summary>
        /// The industry&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio
        /// </summary>
        /// <value>The industry&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio</value>
        [DataMember(Name="industry_fiscal_year_1_forward_price_to_earnings", EmitDefaultValue=false)]
        public decimal? IndustryFiscalYear1ForwardPriceToEarnings { get; set; }

        /// <summary>
        /// The S&amp;P 500&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The S&amp;P 500&#39;s last 5 year actual percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="sp500_last_5_year_actual", EmitDefaultValue=false)]
        public decimal? Sp500Last5YearActual { get; set; }

        /// <summary>
        /// The S&amp;P 500&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The S&amp;P 500&#39;s current fiscal year / last fiscal year percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="sp500_fiscal_year_1_vs_fiscal_year_0", EmitDefaultValue=false)]
        public decimal? Sp500FiscalYear1VsFiscalYear0 { get; set; }

        /// <summary>
        /// The S&amp;P 500&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate
        /// </summary>
        /// <value>The S&amp;P 500&#39;s next fiscal year / current fiscal year percentage earnings-per-share (EPS) growth rate</value>
        [DataMember(Name="sp500_fiscal_year_2_vs_fiscal_year_1", EmitDefaultValue=false)]
        public decimal? Sp500FiscalYear2VsFiscalYear1 { get; set; }

        /// <summary>
        /// The S&amp;P 500&#39;s long term growth rate mean estimate
        /// </summary>
        /// <value>The S&amp;P 500&#39;s long term growth rate mean estimate</value>
        [DataMember(Name="sp500_long_term_growth", EmitDefaultValue=false)]
        public decimal? Sp500LongTermGrowth { get; set; }

        /// <summary>
        /// The S&amp;P 500&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio
        /// </summary>
        /// <value>The S&amp;P 500&#39;s forward (current fiscal year) price-to-earnings (P/E) ratio</value>
        [DataMember(Name="sp500_fiscal_year_1_price_to_earnings", EmitDefaultValue=false)]
        public decimal? Sp500FiscalYear1PriceToEarnings { get; set; }

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
            sb.Append("class ZacksEPSGrowthRate {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  IndustryGroupNumber: ").Append(IndustryGroupNumber).Append("\n");
            sb.Append("  IndustryGroupName: ").Append(IndustryGroupName).Append("\n");
            sb.Append("  FiscalYear0: ").Append(FiscalYear0).Append("\n");
            sb.Append("  FiscalYear1: ").Append(FiscalYear1).Append("\n");
            sb.Append("  FiscalYear2: ").Append(FiscalYear2).Append("\n");
            sb.Append("  CompanyLast5YearActual: ").Append(CompanyLast5YearActual).Append("\n");
            sb.Append("  CompanyFiscalYear1VsFiscalYear0: ").Append(CompanyFiscalYear1VsFiscalYear0).Append("\n");
            sb.Append("  CompanyFiscalYear2VsFiscalYear1: ").Append(CompanyFiscalYear2VsFiscalYear1).Append("\n");
            sb.Append("  CompanyLongTermGrowthMean: ").Append(CompanyLongTermGrowthMean).Append("\n");
            sb.Append("  CompanyFiscalYear1ForwardPriceToEarnings: ").Append(CompanyFiscalYear1ForwardPriceToEarnings).Append("\n");
            sb.Append("  IndustryLast5YearActual: ").Append(IndustryLast5YearActual).Append("\n");
            sb.Append("  IndustryFiscalYear1VsFiscalYear0: ").Append(IndustryFiscalYear1VsFiscalYear0).Append("\n");
            sb.Append("  IndustryFiscalYear2VsFiscalYear1: ").Append(IndustryFiscalYear2VsFiscalYear1).Append("\n");
            sb.Append("  IndustryLongTermGrowthMean: ").Append(IndustryLongTermGrowthMean).Append("\n");
            sb.Append("  IndustryFiscalYear1ForwardPriceToEarnings: ").Append(IndustryFiscalYear1ForwardPriceToEarnings).Append("\n");
            sb.Append("  Sp500Last5YearActual: ").Append(Sp500Last5YearActual).Append("\n");
            sb.Append("  Sp500FiscalYear1VsFiscalYear0: ").Append(Sp500FiscalYear1VsFiscalYear0).Append("\n");
            sb.Append("  Sp500FiscalYear2VsFiscalYear1: ").Append(Sp500FiscalYear2VsFiscalYear1).Append("\n");
            sb.Append("  Sp500LongTermGrowth: ").Append(Sp500LongTermGrowth).Append("\n");
            sb.Append("  Sp500FiscalYear1PriceToEarnings: ").Append(Sp500FiscalYear1PriceToEarnings).Append("\n");
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
            return this.Equals(input as ZacksEPSGrowthRate);
        }

        /// <summary>
        /// Returns true if ZacksEPSGrowthRate instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksEPSGrowthRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksEPSGrowthRate input)
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
                    this.IndustryGroupName == input.IndustryGroupName ||
                    (this.IndustryGroupName != null &&
                    this.IndustryGroupName.Equals(input.IndustryGroupName))
                ) && 
                (
                    this.FiscalYear0 == input.FiscalYear0 ||
                    (this.FiscalYear0 != null &&
                    this.FiscalYear0.Equals(input.FiscalYear0))
                ) && 
                (
                    this.FiscalYear1 == input.FiscalYear1 ||
                    (this.FiscalYear1 != null &&
                    this.FiscalYear1.Equals(input.FiscalYear1))
                ) && 
                (
                    this.FiscalYear2 == input.FiscalYear2 ||
                    (this.FiscalYear2 != null &&
                    this.FiscalYear2.Equals(input.FiscalYear2))
                ) && 
                (
                    this.CompanyLast5YearActual == input.CompanyLast5YearActual ||
                    (this.CompanyLast5YearActual != null &&
                    this.CompanyLast5YearActual.Equals(input.CompanyLast5YearActual))
                ) && 
                (
                    this.CompanyFiscalYear1VsFiscalYear0 == input.CompanyFiscalYear1VsFiscalYear0 ||
                    (this.CompanyFiscalYear1VsFiscalYear0 != null &&
                    this.CompanyFiscalYear1VsFiscalYear0.Equals(input.CompanyFiscalYear1VsFiscalYear0))
                ) && 
                (
                    this.CompanyFiscalYear2VsFiscalYear1 == input.CompanyFiscalYear2VsFiscalYear1 ||
                    (this.CompanyFiscalYear2VsFiscalYear1 != null &&
                    this.CompanyFiscalYear2VsFiscalYear1.Equals(input.CompanyFiscalYear2VsFiscalYear1))
                ) && 
                (
                    this.CompanyLongTermGrowthMean == input.CompanyLongTermGrowthMean ||
                    (this.CompanyLongTermGrowthMean != null &&
                    this.CompanyLongTermGrowthMean.Equals(input.CompanyLongTermGrowthMean))
                ) && 
                (
                    this.CompanyFiscalYear1ForwardPriceToEarnings == input.CompanyFiscalYear1ForwardPriceToEarnings ||
                    (this.CompanyFiscalYear1ForwardPriceToEarnings != null &&
                    this.CompanyFiscalYear1ForwardPriceToEarnings.Equals(input.CompanyFiscalYear1ForwardPriceToEarnings))
                ) && 
                (
                    this.IndustryLast5YearActual == input.IndustryLast5YearActual ||
                    (this.IndustryLast5YearActual != null &&
                    this.IndustryLast5YearActual.Equals(input.IndustryLast5YearActual))
                ) && 
                (
                    this.IndustryFiscalYear1VsFiscalYear0 == input.IndustryFiscalYear1VsFiscalYear0 ||
                    (this.IndustryFiscalYear1VsFiscalYear0 != null &&
                    this.IndustryFiscalYear1VsFiscalYear0.Equals(input.IndustryFiscalYear1VsFiscalYear0))
                ) && 
                (
                    this.IndustryFiscalYear2VsFiscalYear1 == input.IndustryFiscalYear2VsFiscalYear1 ||
                    (this.IndustryFiscalYear2VsFiscalYear1 != null &&
                    this.IndustryFiscalYear2VsFiscalYear1.Equals(input.IndustryFiscalYear2VsFiscalYear1))
                ) && 
                (
                    this.IndustryLongTermGrowthMean == input.IndustryLongTermGrowthMean ||
                    (this.IndustryLongTermGrowthMean != null &&
                    this.IndustryLongTermGrowthMean.Equals(input.IndustryLongTermGrowthMean))
                ) && 
                (
                    this.IndustryFiscalYear1ForwardPriceToEarnings == input.IndustryFiscalYear1ForwardPriceToEarnings ||
                    (this.IndustryFiscalYear1ForwardPriceToEarnings != null &&
                    this.IndustryFiscalYear1ForwardPriceToEarnings.Equals(input.IndustryFiscalYear1ForwardPriceToEarnings))
                ) && 
                (
                    this.Sp500Last5YearActual == input.Sp500Last5YearActual ||
                    (this.Sp500Last5YearActual != null &&
                    this.Sp500Last5YearActual.Equals(input.Sp500Last5YearActual))
                ) && 
                (
                    this.Sp500FiscalYear1VsFiscalYear0 == input.Sp500FiscalYear1VsFiscalYear0 ||
                    (this.Sp500FiscalYear1VsFiscalYear0 != null &&
                    this.Sp500FiscalYear1VsFiscalYear0.Equals(input.Sp500FiscalYear1VsFiscalYear0))
                ) && 
                (
                    this.Sp500FiscalYear2VsFiscalYear1 == input.Sp500FiscalYear2VsFiscalYear1 ||
                    (this.Sp500FiscalYear2VsFiscalYear1 != null &&
                    this.Sp500FiscalYear2VsFiscalYear1.Equals(input.Sp500FiscalYear2VsFiscalYear1))
                ) && 
                (
                    this.Sp500LongTermGrowth == input.Sp500LongTermGrowth ||
                    (this.Sp500LongTermGrowth != null &&
                    this.Sp500LongTermGrowth.Equals(input.Sp500LongTermGrowth))
                ) && 
                (
                    this.Sp500FiscalYear1PriceToEarnings == input.Sp500FiscalYear1PriceToEarnings ||
                    (this.Sp500FiscalYear1PriceToEarnings != null &&
                    this.Sp500FiscalYear1PriceToEarnings.Equals(input.Sp500FiscalYear1PriceToEarnings))
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
                if (this.IndustryGroupName != null)
                    hashCode = hashCode * 59 + this.IndustryGroupName.GetHashCode();
                if (this.FiscalYear0 != null)
                    hashCode = hashCode * 59 + this.FiscalYear0.GetHashCode();
                if (this.FiscalYear1 != null)
                    hashCode = hashCode * 59 + this.FiscalYear1.GetHashCode();
                if (this.FiscalYear2 != null)
                    hashCode = hashCode * 59 + this.FiscalYear2.GetHashCode();
                if (this.CompanyLast5YearActual != null)
                    hashCode = hashCode * 59 + this.CompanyLast5YearActual.GetHashCode();
                if (this.CompanyFiscalYear1VsFiscalYear0 != null)
                    hashCode = hashCode * 59 + this.CompanyFiscalYear1VsFiscalYear0.GetHashCode();
                if (this.CompanyFiscalYear2VsFiscalYear1 != null)
                    hashCode = hashCode * 59 + this.CompanyFiscalYear2VsFiscalYear1.GetHashCode();
                if (this.CompanyLongTermGrowthMean != null)
                    hashCode = hashCode * 59 + this.CompanyLongTermGrowthMean.GetHashCode();
                if (this.CompanyFiscalYear1ForwardPriceToEarnings != null)
                    hashCode = hashCode * 59 + this.CompanyFiscalYear1ForwardPriceToEarnings.GetHashCode();
                if (this.IndustryLast5YearActual != null)
                    hashCode = hashCode * 59 + this.IndustryLast5YearActual.GetHashCode();
                if (this.IndustryFiscalYear1VsFiscalYear0 != null)
                    hashCode = hashCode * 59 + this.IndustryFiscalYear1VsFiscalYear0.GetHashCode();
                if (this.IndustryFiscalYear2VsFiscalYear1 != null)
                    hashCode = hashCode * 59 + this.IndustryFiscalYear2VsFiscalYear1.GetHashCode();
                if (this.IndustryLongTermGrowthMean != null)
                    hashCode = hashCode * 59 + this.IndustryLongTermGrowthMean.GetHashCode();
                if (this.IndustryFiscalYear1ForwardPriceToEarnings != null)
                    hashCode = hashCode * 59 + this.IndustryFiscalYear1ForwardPriceToEarnings.GetHashCode();
                if (this.Sp500Last5YearActual != null)
                    hashCode = hashCode * 59 + this.Sp500Last5YearActual.GetHashCode();
                if (this.Sp500FiscalYear1VsFiscalYear0 != null)
                    hashCode = hashCode * 59 + this.Sp500FiscalYear1VsFiscalYear0.GetHashCode();
                if (this.Sp500FiscalYear2VsFiscalYear1 != null)
                    hashCode = hashCode * 59 + this.Sp500FiscalYear2VsFiscalYear1.GetHashCode();
                if (this.Sp500LongTermGrowth != null)
                    hashCode = hashCode * 59 + this.Sp500LongTermGrowth.GetHashCode();
                if (this.Sp500FiscalYear1PriceToEarnings != null)
                    hashCode = hashCode * 59 + this.Sp500FiscalYear1PriceToEarnings.GetHashCode();
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

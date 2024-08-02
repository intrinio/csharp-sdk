

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
    /// Daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and volatility
    /// </summary>
    [DataContract]
    public partial class ETFStats :  IEquatable<ETFStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFStats" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="NetAssetValue">The net asset value (NAV &#x3D; Total Assets - Total Liabilities).</param>
        /// <param name="BetaVsSpy">Volatility this ETF is versus the SPY ETF.</param>
        /// <param name="TrailingOneMonthReturnSplitAndDividend">Trailing one month return including dividends.</param>
        /// <param name="TrailingOneMonthReturnSplitOnly">Trailing one month return excluding dividends.</param>
        /// <param name="TrailingOneYearReturnSplitAndDividend">Trailing one year return including dividends.</param>
        /// <param name="TrailingOneYearReturnSplitOnly">Trailing one year return excluding dividends.</param>
        /// <param name="TrailingOneYearVolatilityAnnualized">Annualized standard deviation of daily price returns over trailing 252 trading days.</param>
        /// <param name="TrailingThreeYearAnnualizedReturnSplitAndDividend">Trailing three year return including dividends.</param>
        /// <param name="TrailingThreeYearAnnualizedReturnSplitOnly">Trailing three year return excluding dividends.</param>
        /// <param name="TrailingThreeYearVolatilityAnnualized">Annualized standard deviation of daily price returns over trailing 756 trading days.</param>
        /// <param name="TrailingFiveYearAnnualizedReturnSplitAndDividend">Trailing five year return including dividends.</param>
        /// <param name="TrailingFiveYearAnnualizedReturnSplitOnly">Trailing five year return excluding dividends.</param>
        /// <param name="TrailingFiveYearVolatilityAnnualized">Annualized standard  deviation  of  daily  price  returns  over  trailing 1260 trading days.</param>
        /// <param name="TrailingTenYearAnnualizedReturnSplitAndDividend">Trailing ten year return including dividends.</param>
        /// <param name="TrailingTenYearAnnualizedReturnSplitOnly">Trailing ten year return excluding dividends.</param>
        /// <param name="InceptionAnnualizedReturnSplitAndDividend">Annualized return including dividends since inception.</param>
        /// <param name="InceptionAnnualizedReturnSplitOnly">Annualized return excluding dividends since inception.</param>
        /// <param name="CalendarYear5ReturnSplitAndDividend">Five years ago calendar year return including dividends.</param>
        /// <param name="CalendarYear5ReturnSplitOnly">Five years ago calendar year return excluding dividends.</param>
        /// <param name="CalendarYear4ReturnSplitAndDividend">Four years ago calendar year return including dividends.</param>
        /// <param name="CalendarYear4ReturnSplitOnly">Four years ago calendar year return excluding dividends.</param>
        /// <param name="CalendarYear3ReturnSplitAndDividend">Three years ago calendar year return including dividends.</param>
        /// <param name="CalendarYear3ReturnSplitOnly">Three years ago calendar year return excluding dividends.</param>
        /// <param name="CalendarYear2ReturnSplitAndDividend">Two years ago calendar year return including dividends.</param>
        /// <param name="CalendarYear2ReturnSplitOnly">Two years ago calendar year return excluding dividends.</param>
        /// <param name="CalendarYear1ReturnSplitAndDividend">One year ago calendar year return including dividends.</param>
        /// <param name="CalendarYear1ReturnSplitOnly">One year ago calendar year return excluding dividends.</param>
        /// <param name="CalendarYearToDateReturnSplitAndDividend">Calendar year to date (YTD) return including dividends.</param>
        /// <param name="CalendarYearToDateReturnSplitOnly">Calendar year to date (YTD) return excluding dividends.</param>
        /// <param name="Etf">Etf.</param>
        public ETFStats(DateTime? Date = default(DateTime?), decimal? NetAssetValue = default(decimal?), decimal? BetaVsSpy = default(decimal?), decimal? TrailingOneMonthReturnSplitAndDividend = default(decimal?), decimal? TrailingOneMonthReturnSplitOnly = default(decimal?), decimal? TrailingOneYearReturnSplitAndDividend = default(decimal?), decimal? TrailingOneYearReturnSplitOnly = default(decimal?), decimal? TrailingOneYearVolatilityAnnualized = default(decimal?), decimal? TrailingThreeYearAnnualizedReturnSplitAndDividend = default(decimal?), decimal? TrailingThreeYearAnnualizedReturnSplitOnly = default(decimal?), decimal? TrailingThreeYearVolatilityAnnualized = default(decimal?), decimal? TrailingFiveYearAnnualizedReturnSplitAndDividend = default(decimal?), decimal? TrailingFiveYearAnnualizedReturnSplitOnly = default(decimal?), decimal? TrailingFiveYearVolatilityAnnualized = default(decimal?), decimal? TrailingTenYearAnnualizedReturnSplitAndDividend = default(decimal?), decimal? TrailingTenYearAnnualizedReturnSplitOnly = default(decimal?), decimal? InceptionAnnualizedReturnSplitAndDividend = default(decimal?), decimal? InceptionAnnualizedReturnSplitOnly = default(decimal?), decimal? CalendarYear5ReturnSplitAndDividend = default(decimal?), decimal? CalendarYear5ReturnSplitOnly = default(decimal?), decimal? CalendarYear4ReturnSplitAndDividend = default(decimal?), decimal? CalendarYear4ReturnSplitOnly = default(decimal?), decimal? CalendarYear3ReturnSplitAndDividend = default(decimal?), decimal? CalendarYear3ReturnSplitOnly = default(decimal?), decimal? CalendarYear2ReturnSplitAndDividend = default(decimal?), decimal? CalendarYear2ReturnSplitOnly = default(decimal?), decimal? CalendarYear1ReturnSplitAndDividend = default(decimal?), decimal? CalendarYear1ReturnSplitOnly = default(decimal?), decimal? CalendarYearToDateReturnSplitAndDividend = default(decimal?), decimal? CalendarYearToDateReturnSplitOnly = default(decimal?), ETFSummary Etf = default(ETFSummary))
        {
            this.Date = Date;
            this.NetAssetValue = NetAssetValue;
            this.BetaVsSpy = BetaVsSpy;
            this.TrailingOneMonthReturnSplitAndDividend = TrailingOneMonthReturnSplitAndDividend;
            this.TrailingOneMonthReturnSplitOnly = TrailingOneMonthReturnSplitOnly;
            this.TrailingOneYearReturnSplitAndDividend = TrailingOneYearReturnSplitAndDividend;
            this.TrailingOneYearReturnSplitOnly = TrailingOneYearReturnSplitOnly;
            this.TrailingOneYearVolatilityAnnualized = TrailingOneYearVolatilityAnnualized;
            this.TrailingThreeYearAnnualizedReturnSplitAndDividend = TrailingThreeYearAnnualizedReturnSplitAndDividend;
            this.TrailingThreeYearAnnualizedReturnSplitOnly = TrailingThreeYearAnnualizedReturnSplitOnly;
            this.TrailingThreeYearVolatilityAnnualized = TrailingThreeYearVolatilityAnnualized;
            this.TrailingFiveYearAnnualizedReturnSplitAndDividend = TrailingFiveYearAnnualizedReturnSplitAndDividend;
            this.TrailingFiveYearAnnualizedReturnSplitOnly = TrailingFiveYearAnnualizedReturnSplitOnly;
            this.TrailingFiveYearVolatilityAnnualized = TrailingFiveYearVolatilityAnnualized;
            this.TrailingTenYearAnnualizedReturnSplitAndDividend = TrailingTenYearAnnualizedReturnSplitAndDividend;
            this.TrailingTenYearAnnualizedReturnSplitOnly = TrailingTenYearAnnualizedReturnSplitOnly;
            this.InceptionAnnualizedReturnSplitAndDividend = InceptionAnnualizedReturnSplitAndDividend;
            this.InceptionAnnualizedReturnSplitOnly = InceptionAnnualizedReturnSplitOnly;
            this.CalendarYear5ReturnSplitAndDividend = CalendarYear5ReturnSplitAndDividend;
            this.CalendarYear5ReturnSplitOnly = CalendarYear5ReturnSplitOnly;
            this.CalendarYear4ReturnSplitAndDividend = CalendarYear4ReturnSplitAndDividend;
            this.CalendarYear4ReturnSplitOnly = CalendarYear4ReturnSplitOnly;
            this.CalendarYear3ReturnSplitAndDividend = CalendarYear3ReturnSplitAndDividend;
            this.CalendarYear3ReturnSplitOnly = CalendarYear3ReturnSplitOnly;
            this.CalendarYear2ReturnSplitAndDividend = CalendarYear2ReturnSplitAndDividend;
            this.CalendarYear2ReturnSplitOnly = CalendarYear2ReturnSplitOnly;
            this.CalendarYear1ReturnSplitAndDividend = CalendarYear1ReturnSplitAndDividend;
            this.CalendarYear1ReturnSplitOnly = CalendarYear1ReturnSplitOnly;
            this.CalendarYearToDateReturnSplitAndDividend = CalendarYearToDateReturnSplitAndDividend;
            this.CalendarYearToDateReturnSplitOnly = CalendarYearToDateReturnSplitOnly;
            this.Etf = Etf;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The net asset value (NAV &#x3D; Total Assets - Total Liabilities)
        /// </summary>
        /// <value>The net asset value (NAV &#x3D; Total Assets - Total Liabilities)</value>
        [DataMember(Name="net_asset_value", EmitDefaultValue=false)]
        public decimal? NetAssetValue { get; set; }

        /// <summary>
        /// Volatility this ETF is versus the SPY ETF
        /// </summary>
        /// <value>Volatility this ETF is versus the SPY ETF</value>
        [DataMember(Name="beta_vs_spy", EmitDefaultValue=false)]
        public decimal? BetaVsSpy { get; set; }

        /// <summary>
        /// Trailing one month return including dividends
        /// </summary>
        /// <value>Trailing one month return including dividends</value>
        [DataMember(Name="trailing_one_month_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? TrailingOneMonthReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Trailing one month return excluding dividends
        /// </summary>
        /// <value>Trailing one month return excluding dividends</value>
        [DataMember(Name="trailing_one_month_return_split_only", EmitDefaultValue=false)]
        public decimal? TrailingOneMonthReturnSplitOnly { get; set; }

        /// <summary>
        /// Trailing one year return including dividends
        /// </summary>
        /// <value>Trailing one year return including dividends</value>
        [DataMember(Name="trailing_one_year_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? TrailingOneYearReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Trailing one year return excluding dividends
        /// </summary>
        /// <value>Trailing one year return excluding dividends</value>
        [DataMember(Name="trailing_one_year_return_split_only", EmitDefaultValue=false)]
        public decimal? TrailingOneYearReturnSplitOnly { get; set; }

        /// <summary>
        /// Annualized standard deviation of daily price returns over trailing 252 trading days
        /// </summary>
        /// <value>Annualized standard deviation of daily price returns over trailing 252 trading days</value>
        [DataMember(Name="trailing_one_year_volatility_annualized", EmitDefaultValue=false)]
        public decimal? TrailingOneYearVolatilityAnnualized { get; set; }

        /// <summary>
        /// Trailing three year return including dividends
        /// </summary>
        /// <value>Trailing three year return including dividends</value>
        [DataMember(Name="trailing_three_year_annualized_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? TrailingThreeYearAnnualizedReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Trailing three year return excluding dividends
        /// </summary>
        /// <value>Trailing three year return excluding dividends</value>
        [DataMember(Name="trailing_three_year_annualized_return_split_only", EmitDefaultValue=false)]
        public decimal? TrailingThreeYearAnnualizedReturnSplitOnly { get; set; }

        /// <summary>
        /// Annualized standard deviation of daily price returns over trailing 756 trading days
        /// </summary>
        /// <value>Annualized standard deviation of daily price returns over trailing 756 trading days</value>
        [DataMember(Name="trailing_three_year_volatility_annualized", EmitDefaultValue=false)]
        public decimal? TrailingThreeYearVolatilityAnnualized { get; set; }

        /// <summary>
        /// Trailing five year return including dividends
        /// </summary>
        /// <value>Trailing five year return including dividends</value>
        [DataMember(Name="trailing_five_year_annualized_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? TrailingFiveYearAnnualizedReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Trailing five year return excluding dividends
        /// </summary>
        /// <value>Trailing five year return excluding dividends</value>
        [DataMember(Name="trailing_five_year_annualized_return_split_only", EmitDefaultValue=false)]
        public decimal? TrailingFiveYearAnnualizedReturnSplitOnly { get; set; }

        /// <summary>
        /// Annualized standard  deviation  of  daily  price  returns  over  trailing 1260 trading days
        /// </summary>
        /// <value>Annualized standard  deviation  of  daily  price  returns  over  trailing 1260 trading days</value>
        [DataMember(Name="trailing_five_year_volatility_annualized", EmitDefaultValue=false)]
        public decimal? TrailingFiveYearVolatilityAnnualized { get; set; }

        /// <summary>
        /// Trailing ten year return including dividends
        /// </summary>
        /// <value>Trailing ten year return including dividends</value>
        [DataMember(Name="trailing_ten_year_annualized_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? TrailingTenYearAnnualizedReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Trailing ten year return excluding dividends
        /// </summary>
        /// <value>Trailing ten year return excluding dividends</value>
        [DataMember(Name="trailing_ten_year_annualized_return_split_only", EmitDefaultValue=false)]
        public decimal? TrailingTenYearAnnualizedReturnSplitOnly { get; set; }

        /// <summary>
        /// Annualized return including dividends since inception
        /// </summary>
        /// <value>Annualized return including dividends since inception</value>
        [DataMember(Name="inception_annualized_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? InceptionAnnualizedReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Annualized return excluding dividends since inception
        /// </summary>
        /// <value>Annualized return excluding dividends since inception</value>
        [DataMember(Name="inception_annualized_return_split_only", EmitDefaultValue=false)]
        public decimal? InceptionAnnualizedReturnSplitOnly { get; set; }

        /// <summary>
        /// Five years ago calendar year return including dividends
        /// </summary>
        /// <value>Five years ago calendar year return including dividends</value>
        [DataMember(Name="calendar_year_5_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? CalendarYear5ReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Five years ago calendar year return excluding dividends
        /// </summary>
        /// <value>Five years ago calendar year return excluding dividends</value>
        [DataMember(Name="calendar_year_5_return_split_only", EmitDefaultValue=false)]
        public decimal? CalendarYear5ReturnSplitOnly { get; set; }

        /// <summary>
        /// Four years ago calendar year return including dividends
        /// </summary>
        /// <value>Four years ago calendar year return including dividends</value>
        [DataMember(Name="calendar_year_4_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? CalendarYear4ReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Four years ago calendar year return excluding dividends
        /// </summary>
        /// <value>Four years ago calendar year return excluding dividends</value>
        [DataMember(Name="calendar_year_4_return_split_only", EmitDefaultValue=false)]
        public decimal? CalendarYear4ReturnSplitOnly { get; set; }

        /// <summary>
        /// Three years ago calendar year return including dividends
        /// </summary>
        /// <value>Three years ago calendar year return including dividends</value>
        [DataMember(Name="calendar_year_3_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? CalendarYear3ReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Three years ago calendar year return excluding dividends
        /// </summary>
        /// <value>Three years ago calendar year return excluding dividends</value>
        [DataMember(Name="calendar_year_3_return_split_only", EmitDefaultValue=false)]
        public decimal? CalendarYear3ReturnSplitOnly { get; set; }

        /// <summary>
        /// Two years ago calendar year return including dividends
        /// </summary>
        /// <value>Two years ago calendar year return including dividends</value>
        [DataMember(Name="calendar_year_2_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? CalendarYear2ReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Two years ago calendar year return excluding dividends
        /// </summary>
        /// <value>Two years ago calendar year return excluding dividends</value>
        [DataMember(Name="calendar_year_2_return_split_only", EmitDefaultValue=false)]
        public decimal? CalendarYear2ReturnSplitOnly { get; set; }

        /// <summary>
        /// One year ago calendar year return including dividends
        /// </summary>
        /// <value>One year ago calendar year return including dividends</value>
        [DataMember(Name="calendar_year_1_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? CalendarYear1ReturnSplitAndDividend { get; set; }

        /// <summary>
        /// One year ago calendar year return excluding dividends
        /// </summary>
        /// <value>One year ago calendar year return excluding dividends</value>
        [DataMember(Name="calendar_year_1_return_split_only", EmitDefaultValue=false)]
        public decimal? CalendarYear1ReturnSplitOnly { get; set; }

        /// <summary>
        /// Calendar year to date (YTD) return including dividends
        /// </summary>
        /// <value>Calendar year to date (YTD) return including dividends</value>
        [DataMember(Name="calendar_year_to_date_return_split_and_dividend", EmitDefaultValue=false)]
        public decimal? CalendarYearToDateReturnSplitAndDividend { get; set; }

        /// <summary>
        /// Calendar year to date (YTD) return excluding dividends
        /// </summary>
        /// <value>Calendar year to date (YTD) return excluding dividends</value>
        [DataMember(Name="calendar_year_to_date_return_split_only", EmitDefaultValue=false)]
        public decimal? CalendarYearToDateReturnSplitOnly { get; set; }

        /// <summary>
        /// Gets or Sets Etf
        /// </summary>
        [DataMember(Name="etf", EmitDefaultValue=false)]
        public ETFSummary Etf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFStats {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  NetAssetValue: ").Append(NetAssetValue).Append("\n");
            sb.Append("  BetaVsSpy: ").Append(BetaVsSpy).Append("\n");
            sb.Append("  TrailingOneMonthReturnSplitAndDividend: ").Append(TrailingOneMonthReturnSplitAndDividend).Append("\n");
            sb.Append("  TrailingOneMonthReturnSplitOnly: ").Append(TrailingOneMonthReturnSplitOnly).Append("\n");
            sb.Append("  TrailingOneYearReturnSplitAndDividend: ").Append(TrailingOneYearReturnSplitAndDividend).Append("\n");
            sb.Append("  TrailingOneYearReturnSplitOnly: ").Append(TrailingOneYearReturnSplitOnly).Append("\n");
            sb.Append("  TrailingOneYearVolatilityAnnualized: ").Append(TrailingOneYearVolatilityAnnualized).Append("\n");
            sb.Append("  TrailingThreeYearAnnualizedReturnSplitAndDividend: ").Append(TrailingThreeYearAnnualizedReturnSplitAndDividend).Append("\n");
            sb.Append("  TrailingThreeYearAnnualizedReturnSplitOnly: ").Append(TrailingThreeYearAnnualizedReturnSplitOnly).Append("\n");
            sb.Append("  TrailingThreeYearVolatilityAnnualized: ").Append(TrailingThreeYearVolatilityAnnualized).Append("\n");
            sb.Append("  TrailingFiveYearAnnualizedReturnSplitAndDividend: ").Append(TrailingFiveYearAnnualizedReturnSplitAndDividend).Append("\n");
            sb.Append("  TrailingFiveYearAnnualizedReturnSplitOnly: ").Append(TrailingFiveYearAnnualizedReturnSplitOnly).Append("\n");
            sb.Append("  TrailingFiveYearVolatilityAnnualized: ").Append(TrailingFiveYearVolatilityAnnualized).Append("\n");
            sb.Append("  TrailingTenYearAnnualizedReturnSplitAndDividend: ").Append(TrailingTenYearAnnualizedReturnSplitAndDividend).Append("\n");
            sb.Append("  TrailingTenYearAnnualizedReturnSplitOnly: ").Append(TrailingTenYearAnnualizedReturnSplitOnly).Append("\n");
            sb.Append("  InceptionAnnualizedReturnSplitAndDividend: ").Append(InceptionAnnualizedReturnSplitAndDividend).Append("\n");
            sb.Append("  InceptionAnnualizedReturnSplitOnly: ").Append(InceptionAnnualizedReturnSplitOnly).Append("\n");
            sb.Append("  CalendarYear5ReturnSplitAndDividend: ").Append(CalendarYear5ReturnSplitAndDividend).Append("\n");
            sb.Append("  CalendarYear5ReturnSplitOnly: ").Append(CalendarYear5ReturnSplitOnly).Append("\n");
            sb.Append("  CalendarYear4ReturnSplitAndDividend: ").Append(CalendarYear4ReturnSplitAndDividend).Append("\n");
            sb.Append("  CalendarYear4ReturnSplitOnly: ").Append(CalendarYear4ReturnSplitOnly).Append("\n");
            sb.Append("  CalendarYear3ReturnSplitAndDividend: ").Append(CalendarYear3ReturnSplitAndDividend).Append("\n");
            sb.Append("  CalendarYear3ReturnSplitOnly: ").Append(CalendarYear3ReturnSplitOnly).Append("\n");
            sb.Append("  CalendarYear2ReturnSplitAndDividend: ").Append(CalendarYear2ReturnSplitAndDividend).Append("\n");
            sb.Append("  CalendarYear2ReturnSplitOnly: ").Append(CalendarYear2ReturnSplitOnly).Append("\n");
            sb.Append("  CalendarYear1ReturnSplitAndDividend: ").Append(CalendarYear1ReturnSplitAndDividend).Append("\n");
            sb.Append("  CalendarYear1ReturnSplitOnly: ").Append(CalendarYear1ReturnSplitOnly).Append("\n");
            sb.Append("  CalendarYearToDateReturnSplitAndDividend: ").Append(CalendarYearToDateReturnSplitAndDividend).Append("\n");
            sb.Append("  CalendarYearToDateReturnSplitOnly: ").Append(CalendarYearToDateReturnSplitOnly).Append("\n");
            sb.Append("  Etf: ").Append(Etf).Append("\n");
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
            return this.Equals(input as ETFStats);
        }

        /// <summary>
        /// Returns true if ETFStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.NetAssetValue == input.NetAssetValue ||
                    (this.NetAssetValue != null &&
                    this.NetAssetValue.Equals(input.NetAssetValue))
                ) && 
                (
                    this.BetaVsSpy == input.BetaVsSpy ||
                    (this.BetaVsSpy != null &&
                    this.BetaVsSpy.Equals(input.BetaVsSpy))
                ) && 
                (
                    this.TrailingOneMonthReturnSplitAndDividend == input.TrailingOneMonthReturnSplitAndDividend ||
                    (this.TrailingOneMonthReturnSplitAndDividend != null &&
                    this.TrailingOneMonthReturnSplitAndDividend.Equals(input.TrailingOneMonthReturnSplitAndDividend))
                ) && 
                (
                    this.TrailingOneMonthReturnSplitOnly == input.TrailingOneMonthReturnSplitOnly ||
                    (this.TrailingOneMonthReturnSplitOnly != null &&
                    this.TrailingOneMonthReturnSplitOnly.Equals(input.TrailingOneMonthReturnSplitOnly))
                ) && 
                (
                    this.TrailingOneYearReturnSplitAndDividend == input.TrailingOneYearReturnSplitAndDividend ||
                    (this.TrailingOneYearReturnSplitAndDividend != null &&
                    this.TrailingOneYearReturnSplitAndDividend.Equals(input.TrailingOneYearReturnSplitAndDividend))
                ) && 
                (
                    this.TrailingOneYearReturnSplitOnly == input.TrailingOneYearReturnSplitOnly ||
                    (this.TrailingOneYearReturnSplitOnly != null &&
                    this.TrailingOneYearReturnSplitOnly.Equals(input.TrailingOneYearReturnSplitOnly))
                ) && 
                (
                    this.TrailingOneYearVolatilityAnnualized == input.TrailingOneYearVolatilityAnnualized ||
                    (this.TrailingOneYearVolatilityAnnualized != null &&
                    this.TrailingOneYearVolatilityAnnualized.Equals(input.TrailingOneYearVolatilityAnnualized))
                ) && 
                (
                    this.TrailingThreeYearAnnualizedReturnSplitAndDividend == input.TrailingThreeYearAnnualizedReturnSplitAndDividend ||
                    (this.TrailingThreeYearAnnualizedReturnSplitAndDividend != null &&
                    this.TrailingThreeYearAnnualizedReturnSplitAndDividend.Equals(input.TrailingThreeYearAnnualizedReturnSplitAndDividend))
                ) && 
                (
                    this.TrailingThreeYearAnnualizedReturnSplitOnly == input.TrailingThreeYearAnnualizedReturnSplitOnly ||
                    (this.TrailingThreeYearAnnualizedReturnSplitOnly != null &&
                    this.TrailingThreeYearAnnualizedReturnSplitOnly.Equals(input.TrailingThreeYearAnnualizedReturnSplitOnly))
                ) && 
                (
                    this.TrailingThreeYearVolatilityAnnualized == input.TrailingThreeYearVolatilityAnnualized ||
                    (this.TrailingThreeYearVolatilityAnnualized != null &&
                    this.TrailingThreeYearVolatilityAnnualized.Equals(input.TrailingThreeYearVolatilityAnnualized))
                ) && 
                (
                    this.TrailingFiveYearAnnualizedReturnSplitAndDividend == input.TrailingFiveYearAnnualizedReturnSplitAndDividend ||
                    (this.TrailingFiveYearAnnualizedReturnSplitAndDividend != null &&
                    this.TrailingFiveYearAnnualizedReturnSplitAndDividend.Equals(input.TrailingFiveYearAnnualizedReturnSplitAndDividend))
                ) && 
                (
                    this.TrailingFiveYearAnnualizedReturnSplitOnly == input.TrailingFiveYearAnnualizedReturnSplitOnly ||
                    (this.TrailingFiveYearAnnualizedReturnSplitOnly != null &&
                    this.TrailingFiveYearAnnualizedReturnSplitOnly.Equals(input.TrailingFiveYearAnnualizedReturnSplitOnly))
                ) && 
                (
                    this.TrailingFiveYearVolatilityAnnualized == input.TrailingFiveYearVolatilityAnnualized ||
                    (this.TrailingFiveYearVolatilityAnnualized != null &&
                    this.TrailingFiveYearVolatilityAnnualized.Equals(input.TrailingFiveYearVolatilityAnnualized))
                ) && 
                (
                    this.TrailingTenYearAnnualizedReturnSplitAndDividend == input.TrailingTenYearAnnualizedReturnSplitAndDividend ||
                    (this.TrailingTenYearAnnualizedReturnSplitAndDividend != null &&
                    this.TrailingTenYearAnnualizedReturnSplitAndDividend.Equals(input.TrailingTenYearAnnualizedReturnSplitAndDividend))
                ) && 
                (
                    this.TrailingTenYearAnnualizedReturnSplitOnly == input.TrailingTenYearAnnualizedReturnSplitOnly ||
                    (this.TrailingTenYearAnnualizedReturnSplitOnly != null &&
                    this.TrailingTenYearAnnualizedReturnSplitOnly.Equals(input.TrailingTenYearAnnualizedReturnSplitOnly))
                ) && 
                (
                    this.InceptionAnnualizedReturnSplitAndDividend == input.InceptionAnnualizedReturnSplitAndDividend ||
                    (this.InceptionAnnualizedReturnSplitAndDividend != null &&
                    this.InceptionAnnualizedReturnSplitAndDividend.Equals(input.InceptionAnnualizedReturnSplitAndDividend))
                ) && 
                (
                    this.InceptionAnnualizedReturnSplitOnly == input.InceptionAnnualizedReturnSplitOnly ||
                    (this.InceptionAnnualizedReturnSplitOnly != null &&
                    this.InceptionAnnualizedReturnSplitOnly.Equals(input.InceptionAnnualizedReturnSplitOnly))
                ) && 
                (
                    this.CalendarYear5ReturnSplitAndDividend == input.CalendarYear5ReturnSplitAndDividend ||
                    (this.CalendarYear5ReturnSplitAndDividend != null &&
                    this.CalendarYear5ReturnSplitAndDividend.Equals(input.CalendarYear5ReturnSplitAndDividend))
                ) && 
                (
                    this.CalendarYear5ReturnSplitOnly == input.CalendarYear5ReturnSplitOnly ||
                    (this.CalendarYear5ReturnSplitOnly != null &&
                    this.CalendarYear5ReturnSplitOnly.Equals(input.CalendarYear5ReturnSplitOnly))
                ) && 
                (
                    this.CalendarYear4ReturnSplitAndDividend == input.CalendarYear4ReturnSplitAndDividend ||
                    (this.CalendarYear4ReturnSplitAndDividend != null &&
                    this.CalendarYear4ReturnSplitAndDividend.Equals(input.CalendarYear4ReturnSplitAndDividend))
                ) && 
                (
                    this.CalendarYear4ReturnSplitOnly == input.CalendarYear4ReturnSplitOnly ||
                    (this.CalendarYear4ReturnSplitOnly != null &&
                    this.CalendarYear4ReturnSplitOnly.Equals(input.CalendarYear4ReturnSplitOnly))
                ) && 
                (
                    this.CalendarYear3ReturnSplitAndDividend == input.CalendarYear3ReturnSplitAndDividend ||
                    (this.CalendarYear3ReturnSplitAndDividend != null &&
                    this.CalendarYear3ReturnSplitAndDividend.Equals(input.CalendarYear3ReturnSplitAndDividend))
                ) && 
                (
                    this.CalendarYear3ReturnSplitOnly == input.CalendarYear3ReturnSplitOnly ||
                    (this.CalendarYear3ReturnSplitOnly != null &&
                    this.CalendarYear3ReturnSplitOnly.Equals(input.CalendarYear3ReturnSplitOnly))
                ) && 
                (
                    this.CalendarYear2ReturnSplitAndDividend == input.CalendarYear2ReturnSplitAndDividend ||
                    (this.CalendarYear2ReturnSplitAndDividend != null &&
                    this.CalendarYear2ReturnSplitAndDividend.Equals(input.CalendarYear2ReturnSplitAndDividend))
                ) && 
                (
                    this.CalendarYear2ReturnSplitOnly == input.CalendarYear2ReturnSplitOnly ||
                    (this.CalendarYear2ReturnSplitOnly != null &&
                    this.CalendarYear2ReturnSplitOnly.Equals(input.CalendarYear2ReturnSplitOnly))
                ) && 
                (
                    this.CalendarYear1ReturnSplitAndDividend == input.CalendarYear1ReturnSplitAndDividend ||
                    (this.CalendarYear1ReturnSplitAndDividend != null &&
                    this.CalendarYear1ReturnSplitAndDividend.Equals(input.CalendarYear1ReturnSplitAndDividend))
                ) && 
                (
                    this.CalendarYear1ReturnSplitOnly == input.CalendarYear1ReturnSplitOnly ||
                    (this.CalendarYear1ReturnSplitOnly != null &&
                    this.CalendarYear1ReturnSplitOnly.Equals(input.CalendarYear1ReturnSplitOnly))
                ) && 
                (
                    this.CalendarYearToDateReturnSplitAndDividend == input.CalendarYearToDateReturnSplitAndDividend ||
                    (this.CalendarYearToDateReturnSplitAndDividend != null &&
                    this.CalendarYearToDateReturnSplitAndDividend.Equals(input.CalendarYearToDateReturnSplitAndDividend))
                ) && 
                (
                    this.CalendarYearToDateReturnSplitOnly == input.CalendarYearToDateReturnSplitOnly ||
                    (this.CalendarYearToDateReturnSplitOnly != null &&
                    this.CalendarYearToDateReturnSplitOnly.Equals(input.CalendarYearToDateReturnSplitOnly))
                ) && 
                (
                    this.Etf == input.Etf ||
                    (this.Etf != null &&
                    this.Etf.Equals(input.Etf))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.NetAssetValue != null)
                    hashCode = hashCode * 59 + this.NetAssetValue.GetHashCode();
                if (this.BetaVsSpy != null)
                    hashCode = hashCode * 59 + this.BetaVsSpy.GetHashCode();
                if (this.TrailingOneMonthReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.TrailingOneMonthReturnSplitAndDividend.GetHashCode();
                if (this.TrailingOneMonthReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.TrailingOneMonthReturnSplitOnly.GetHashCode();
                if (this.TrailingOneYearReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.TrailingOneYearReturnSplitAndDividend.GetHashCode();
                if (this.TrailingOneYearReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.TrailingOneYearReturnSplitOnly.GetHashCode();
                if (this.TrailingOneYearVolatilityAnnualized != null)
                    hashCode = hashCode * 59 + this.TrailingOneYearVolatilityAnnualized.GetHashCode();
                if (this.TrailingThreeYearAnnualizedReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.TrailingThreeYearAnnualizedReturnSplitAndDividend.GetHashCode();
                if (this.TrailingThreeYearAnnualizedReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.TrailingThreeYearAnnualizedReturnSplitOnly.GetHashCode();
                if (this.TrailingThreeYearVolatilityAnnualized != null)
                    hashCode = hashCode * 59 + this.TrailingThreeYearVolatilityAnnualized.GetHashCode();
                if (this.TrailingFiveYearAnnualizedReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.TrailingFiveYearAnnualizedReturnSplitAndDividend.GetHashCode();
                if (this.TrailingFiveYearAnnualizedReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.TrailingFiveYearAnnualizedReturnSplitOnly.GetHashCode();
                if (this.TrailingFiveYearVolatilityAnnualized != null)
                    hashCode = hashCode * 59 + this.TrailingFiveYearVolatilityAnnualized.GetHashCode();
                if (this.TrailingTenYearAnnualizedReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.TrailingTenYearAnnualizedReturnSplitAndDividend.GetHashCode();
                if (this.TrailingTenYearAnnualizedReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.TrailingTenYearAnnualizedReturnSplitOnly.GetHashCode();
                if (this.InceptionAnnualizedReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.InceptionAnnualizedReturnSplitAndDividend.GetHashCode();
                if (this.InceptionAnnualizedReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.InceptionAnnualizedReturnSplitOnly.GetHashCode();
                if (this.CalendarYear5ReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.CalendarYear5ReturnSplitAndDividend.GetHashCode();
                if (this.CalendarYear5ReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.CalendarYear5ReturnSplitOnly.GetHashCode();
                if (this.CalendarYear4ReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.CalendarYear4ReturnSplitAndDividend.GetHashCode();
                if (this.CalendarYear4ReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.CalendarYear4ReturnSplitOnly.GetHashCode();
                if (this.CalendarYear3ReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.CalendarYear3ReturnSplitAndDividend.GetHashCode();
                if (this.CalendarYear3ReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.CalendarYear3ReturnSplitOnly.GetHashCode();
                if (this.CalendarYear2ReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.CalendarYear2ReturnSplitAndDividend.GetHashCode();
                if (this.CalendarYear2ReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.CalendarYear2ReturnSplitOnly.GetHashCode();
                if (this.CalendarYear1ReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.CalendarYear1ReturnSplitAndDividend.GetHashCode();
                if (this.CalendarYear1ReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.CalendarYear1ReturnSplitOnly.GetHashCode();
                if (this.CalendarYearToDateReturnSplitAndDividend != null)
                    hashCode = hashCode * 59 + this.CalendarYearToDateReturnSplitAndDividend.GetHashCode();
                if (this.CalendarYearToDateReturnSplitOnly != null)
                    hashCode = hashCode * 59 + this.CalendarYearToDateReturnSplitOnly.GetHashCode();
                if (this.Etf != null)
                    hashCode = hashCode * 59 + this.Etf.GetHashCode();
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

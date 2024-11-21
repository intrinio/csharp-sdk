

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
    /// A realtime price quote of a security.
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityQuote :  IEquatable<ApiResponseSecurityQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityQuote" /> class.
        /// </summary>
        /// <param name="Security">The Security of the stock quote.</param>
        /// <param name="Last">The price of the latest trade.</param>
        /// <param name="LastTime">The date and time when the last trade occurred..</param>
        /// <param name="Source">The source of the pricing data..</param>
        /// <param name="Open">The open price from the latest day of trading..</param>
        /// <param name="High">The highest price from the latest day of trading..</param>
        /// <param name="Low">The lowest price from the latest day of trading..</param>
        /// <param name="ExchangeVolume">The volume of the security from the source..</param>
        /// <param name="MarketVolume">The volume of the security for the entire market..</param>
        /// <param name="EodFiftyTwoWeekHigh">The 52 week high price..</param>
        /// <param name="EodFiftyTwoWeekLow">The 52 week low price..</param>
        /// <param name="Marketcap">The current market cap..</param>
        /// <param name="Pricetoearnings">The current price to earnings..</param>
        /// <param name="PreviousClose">The previous close price..</param>
        /// <param name="PreviousCloseDate">The date of the previous close..</param>
        /// <param name="Change">The difference in last price from the last close price.</param>
        /// <param name="ChangePercent">The percent difference in last price from the last close price.</param>
        /// <param name="AdjClose5DaysAgo">The adjusted close price 5 days ago..</param>
        /// <param name="AdjClose30DaysAgo">The adjusted close price 30 days ago..</param>
        /// <param name="AdjClose90DaysAgo">The adjusted close price 90 days ago..</param>
        /// <param name="AdjClose180DaysAgo">The adjusted close price 180 days ago..</param>
        /// <param name="AdjClose365DaysAgo">The adjusted close price 365 days ago..</param>
        /// <param name="AdjClose730DaysAgo">The adjusted close price 730 days ago..</param>
        /// <param name="AdjClose1825DaysAgo">The adjusted close price 1825 days ago..</param>
        /// <param name="AdjCloseYearToDate">The adjusted close price at the start of the calendar year..</param>
        /// <param name="ChangePercent5Days">The percent change from the adjusted price 5 days ago to now..</param>
        /// <param name="ChangePercent30Days">The percent change from the adjusted price 30 days ago to now..</param>
        /// <param name="ChangePercent90Days">The percent change from the adjusted price 90 days ago to now..</param>
        /// <param name="ChangePercent180Days">The percent change from the adjusted price 180 days ago to now..</param>
        /// <param name="ChangePercent365Days">The percent change from the adjusted price 365 days ago to now..</param>
        /// <param name="ChangePercent730DaysAgo">The percent change from the adjusted price 730 days ago to now..</param>
        /// <param name="ChangePercent1825Days">The percent change from the adjusted price 1825 days ago to now..</param>
        /// <param name="ChangePercentYearToDate">The percent change from the adjusted price since the start of the calendar year to now..</param>
        /// <param name="ExtendedHoursLast">The price of the latest trade in pre and post market trading.  Might be null during normal trading.</param>
        /// <param name="ExtendedHoursChange">The difference in extended_hours_last price from most recent official close price.</param>
        /// <param name="ExtendedHoursChangePercent">The percent difference in extended_hours_last from the most recent official close price.</param>
        public ApiResponseSecurityQuote(SecuritySummary Security = default(SecuritySummary), decimal? Last = default(decimal?), DateTime? LastTime = default(DateTime?), string Source = default(string), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? ExchangeVolume = default(decimal?), decimal? MarketVolume = default(decimal?), decimal? EodFiftyTwoWeekHigh = default(decimal?), decimal? EodFiftyTwoWeekLow = default(decimal?), decimal? Marketcap = default(decimal?), decimal? Pricetoearnings = default(decimal?), decimal? PreviousClose = default(decimal?), DateTime? PreviousCloseDate = default(DateTime?), decimal? Change = default(decimal?), decimal? ChangePercent = default(decimal?), decimal? AdjClose5DaysAgo = default(decimal?), decimal? AdjClose30DaysAgo = default(decimal?), decimal? AdjClose90DaysAgo = default(decimal?), decimal? AdjClose180DaysAgo = default(decimal?), decimal? AdjClose365DaysAgo = default(decimal?), decimal? AdjClose730DaysAgo = default(decimal?), decimal? AdjClose1825DaysAgo = default(decimal?), decimal? AdjCloseYearToDate = default(decimal?), decimal? ChangePercent5Days = default(decimal?), decimal? ChangePercent30Days = default(decimal?), decimal? ChangePercent90Days = default(decimal?), decimal? ChangePercent180Days = default(decimal?), decimal? ChangePercent365Days = default(decimal?), decimal? ChangePercent730DaysAgo = default(decimal?), decimal? ChangePercent1825Days = default(decimal?), decimal? ChangePercentYearToDate = default(decimal?), decimal? ExtendedHoursLast = default(decimal?), decimal? ExtendedHoursChange = default(decimal?), decimal? ExtendedHoursChangePercent = default(decimal?))
        {
            this.Security = Security;
            this.Last = Last;
            this.LastTime = LastTime;
            this.Source = Source;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.ExchangeVolume = ExchangeVolume;
            this.MarketVolume = MarketVolume;
            this.EodFiftyTwoWeekHigh = EodFiftyTwoWeekHigh;
            this.EodFiftyTwoWeekLow = EodFiftyTwoWeekLow;
            this.Marketcap = Marketcap;
            this.Pricetoearnings = Pricetoearnings;
            this.PreviousClose = PreviousClose;
            this.PreviousCloseDate = PreviousCloseDate;
            this.Change = Change;
            this.ChangePercent = ChangePercent;
            this.AdjClose5DaysAgo = AdjClose5DaysAgo;
            this.AdjClose30DaysAgo = AdjClose30DaysAgo;
            this.AdjClose90DaysAgo = AdjClose90DaysAgo;
            this.AdjClose180DaysAgo = AdjClose180DaysAgo;
            this.AdjClose365DaysAgo = AdjClose365DaysAgo;
            this.AdjClose730DaysAgo = AdjClose730DaysAgo;
            this.AdjClose1825DaysAgo = AdjClose1825DaysAgo;
            this.AdjCloseYearToDate = AdjCloseYearToDate;
            this.ChangePercent5Days = ChangePercent5Days;
            this.ChangePercent30Days = ChangePercent30Days;
            this.ChangePercent90Days = ChangePercent90Days;
            this.ChangePercent180Days = ChangePercent180Days;
            this.ChangePercent365Days = ChangePercent365Days;
            this.ChangePercent730DaysAgo = ChangePercent730DaysAgo;
            this.ChangePercent1825Days = ChangePercent1825Days;
            this.ChangePercentYearToDate = ChangePercentYearToDate;
            this.ExtendedHoursLast = ExtendedHoursLast;
            this.ExtendedHoursChange = ExtendedHoursChange;
            this.ExtendedHoursChangePercent = ExtendedHoursChangePercent;
        }
        
        /// <summary>
        /// The Security of the stock quote
        /// </summary>
        /// <value>The Security of the stock quote</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// The price of the latest trade
        /// </summary>
        /// <value>The price of the latest trade</value>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public decimal? Last { get; set; }

        /// <summary>
        /// The date and time when the last trade occurred.
        /// </summary>
        /// <value>The date and time when the last trade occurred.</value>
        [DataMember(Name="last_time", EmitDefaultValue=false)]
        public DateTime? LastTime { get; set; }

        /// <summary>
        /// The source of the pricing data.
        /// </summary>
        /// <value>The source of the pricing data.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// The open price from the latest day of trading.
        /// </summary>
        /// <value>The open price from the latest day of trading.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The highest price from the latest day of trading.
        /// </summary>
        /// <value>The highest price from the latest day of trading.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest price from the latest day of trading.
        /// </summary>
        /// <value>The lowest price from the latest day of trading.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The volume of the security from the source.
        /// </summary>
        /// <value>The volume of the security from the source.</value>
        [DataMember(Name="exchange_volume", EmitDefaultValue=false)]
        public decimal? ExchangeVolume { get; set; }

        /// <summary>
        /// The volume of the security for the entire market.
        /// </summary>
        /// <value>The volume of the security for the entire market.</value>
        [DataMember(Name="market_volume", EmitDefaultValue=false)]
        public decimal? MarketVolume { get; set; }

        /// <summary>
        /// The 52 week high price.
        /// </summary>
        /// <value>The 52 week high price.</value>
        [DataMember(Name="eod_fifty_two_week_high", EmitDefaultValue=false)]
        public decimal? EodFiftyTwoWeekHigh { get; set; }

        /// <summary>
        /// The 52 week low price.
        /// </summary>
        /// <value>The 52 week low price.</value>
        [DataMember(Name="eod_fifty_two_week_low", EmitDefaultValue=false)]
        public decimal? EodFiftyTwoWeekLow { get; set; }

        /// <summary>
        /// The current market cap.
        /// </summary>
        /// <value>The current market cap.</value>
        [DataMember(Name="marketcap", EmitDefaultValue=false)]
        public decimal? Marketcap { get; set; }

        /// <summary>
        /// The current price to earnings.
        /// </summary>
        /// <value>The current price to earnings.</value>
        [DataMember(Name="pricetoearnings", EmitDefaultValue=false)]
        public decimal? Pricetoearnings { get; set; }

        /// <summary>
        /// The previous close price.
        /// </summary>
        /// <value>The previous close price.</value>
        [DataMember(Name="previous_close", EmitDefaultValue=false)]
        public decimal? PreviousClose { get; set; }

        /// <summary>
        /// The date of the previous close.
        /// </summary>
        /// <value>The date of the previous close.</value>
        [DataMember(Name="previous_close_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PreviousCloseDate { get; set; }

        /// <summary>
        /// The difference in last price from the last close price
        /// </summary>
        /// <value>The difference in last price from the last close price</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The percent difference in last price from the last close price
        /// </summary>
        /// <value>The percent difference in last price from the last close price</value>
        [DataMember(Name="change_percent", EmitDefaultValue=false)]
        public decimal? ChangePercent { get; set; }

        /// <summary>
        /// The adjusted close price 5 days ago.
        /// </summary>
        /// <value>The adjusted close price 5 days ago.</value>
        [DataMember(Name="adj_close_5_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose5DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price 30 days ago.
        /// </summary>
        /// <value>The adjusted close price 30 days ago.</value>
        [DataMember(Name="adj_close_30_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose30DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price 90 days ago.
        /// </summary>
        /// <value>The adjusted close price 90 days ago.</value>
        [DataMember(Name="adj_close_90_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose90DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price 180 days ago.
        /// </summary>
        /// <value>The adjusted close price 180 days ago.</value>
        [DataMember(Name="adj_close_180_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose180DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price 365 days ago.
        /// </summary>
        /// <value>The adjusted close price 365 days ago.</value>
        [DataMember(Name="adj_close_365_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose365DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price 730 days ago.
        /// </summary>
        /// <value>The adjusted close price 730 days ago.</value>
        [DataMember(Name="adj_close_730_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose730DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price 1825 days ago.
        /// </summary>
        /// <value>The adjusted close price 1825 days ago.</value>
        [DataMember(Name="adj_close_1825_days_ago", EmitDefaultValue=false)]
        public decimal? AdjClose1825DaysAgo { get; set; }

        /// <summary>
        /// The adjusted close price at the start of the calendar year.
        /// </summary>
        /// <value>The adjusted close price at the start of the calendar year.</value>
        [DataMember(Name="adj_close_year_to_date", EmitDefaultValue=false)]
        public decimal? AdjCloseYearToDate { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 5 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 5 days ago to now.</value>
        [DataMember(Name="change_percent_5_days", EmitDefaultValue=false)]
        public decimal? ChangePercent5Days { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 30 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 30 days ago to now.</value>
        [DataMember(Name="change_percent_30_days", EmitDefaultValue=false)]
        public decimal? ChangePercent30Days { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 90 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 90 days ago to now.</value>
        [DataMember(Name="change_percent_90_days", EmitDefaultValue=false)]
        public decimal? ChangePercent90Days { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 180 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 180 days ago to now.</value>
        [DataMember(Name="change_percent_180_days", EmitDefaultValue=false)]
        public decimal? ChangePercent180Days { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 365 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 365 days ago to now.</value>
        [DataMember(Name="change_percent_365_days", EmitDefaultValue=false)]
        public decimal? ChangePercent365Days { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 730 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 730 days ago to now.</value>
        [DataMember(Name="change_percent_730_days_ago", EmitDefaultValue=false)]
        public decimal? ChangePercent730DaysAgo { get; set; }

        /// <summary>
        /// The percent change from the adjusted price 1825 days ago to now.
        /// </summary>
        /// <value>The percent change from the adjusted price 1825 days ago to now.</value>
        [DataMember(Name="change_percent_1825_days", EmitDefaultValue=false)]
        public decimal? ChangePercent1825Days { get; set; }

        /// <summary>
        /// The percent change from the adjusted price since the start of the calendar year to now.
        /// </summary>
        /// <value>The percent change from the adjusted price since the start of the calendar year to now.</value>
        [DataMember(Name="change_percent_year_to_date", EmitDefaultValue=false)]
        public decimal? ChangePercentYearToDate { get; set; }

        /// <summary>
        /// The price of the latest trade in pre and post market trading.  Might be null during normal trading
        /// </summary>
        /// <value>The price of the latest trade in pre and post market trading.  Might be null during normal trading</value>
        [DataMember(Name="extended_hours_last", EmitDefaultValue=false)]
        public decimal? ExtendedHoursLast { get; set; }

        /// <summary>
        /// The difference in extended_hours_last price from most recent official close price
        /// </summary>
        /// <value>The difference in extended_hours_last price from most recent official close price</value>
        [DataMember(Name="extended_hours_change", EmitDefaultValue=false)]
        public decimal? ExtendedHoursChange { get; set; }

        /// <summary>
        /// The percent difference in extended_hours_last from the most recent official close price
        /// </summary>
        /// <value>The percent difference in extended_hours_last from the most recent official close price</value>
        [DataMember(Name="extended_hours_change_percent", EmitDefaultValue=false)]
        public decimal? ExtendedHoursChangePercent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityQuote {\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  LastTime: ").Append(LastTime).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  ExchangeVolume: ").Append(ExchangeVolume).Append("\n");
            sb.Append("  MarketVolume: ").Append(MarketVolume).Append("\n");
            sb.Append("  EodFiftyTwoWeekHigh: ").Append(EodFiftyTwoWeekHigh).Append("\n");
            sb.Append("  EodFiftyTwoWeekLow: ").Append(EodFiftyTwoWeekLow).Append("\n");
            sb.Append("  Marketcap: ").Append(Marketcap).Append("\n");
            sb.Append("  Pricetoearnings: ").Append(Pricetoearnings).Append("\n");
            sb.Append("  PreviousClose: ").Append(PreviousClose).Append("\n");
            sb.Append("  PreviousCloseDate: ").Append(PreviousCloseDate).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  ChangePercent: ").Append(ChangePercent).Append("\n");
            sb.Append("  AdjClose5DaysAgo: ").Append(AdjClose5DaysAgo).Append("\n");
            sb.Append("  AdjClose30DaysAgo: ").Append(AdjClose30DaysAgo).Append("\n");
            sb.Append("  AdjClose90DaysAgo: ").Append(AdjClose90DaysAgo).Append("\n");
            sb.Append("  AdjClose180DaysAgo: ").Append(AdjClose180DaysAgo).Append("\n");
            sb.Append("  AdjClose365DaysAgo: ").Append(AdjClose365DaysAgo).Append("\n");
            sb.Append("  AdjClose730DaysAgo: ").Append(AdjClose730DaysAgo).Append("\n");
            sb.Append("  AdjClose1825DaysAgo: ").Append(AdjClose1825DaysAgo).Append("\n");
            sb.Append("  AdjCloseYearToDate: ").Append(AdjCloseYearToDate).Append("\n");
            sb.Append("  ChangePercent5Days: ").Append(ChangePercent5Days).Append("\n");
            sb.Append("  ChangePercent30Days: ").Append(ChangePercent30Days).Append("\n");
            sb.Append("  ChangePercent90Days: ").Append(ChangePercent90Days).Append("\n");
            sb.Append("  ChangePercent180Days: ").Append(ChangePercent180Days).Append("\n");
            sb.Append("  ChangePercent365Days: ").Append(ChangePercent365Days).Append("\n");
            sb.Append("  ChangePercent730DaysAgo: ").Append(ChangePercent730DaysAgo).Append("\n");
            sb.Append("  ChangePercent1825Days: ").Append(ChangePercent1825Days).Append("\n");
            sb.Append("  ChangePercentYearToDate: ").Append(ChangePercentYearToDate).Append("\n");
            sb.Append("  ExtendedHoursLast: ").Append(ExtendedHoursLast).Append("\n");
            sb.Append("  ExtendedHoursChange: ").Append(ExtendedHoursChange).Append("\n");
            sb.Append("  ExtendedHoursChangePercent: ").Append(ExtendedHoursChangePercent).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityQuote);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityQuote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.LastTime == input.LastTime ||
                    (this.LastTime != null &&
                    this.LastTime.Equals(input.LastTime))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
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
                    this.ExchangeVolume == input.ExchangeVolume ||
                    (this.ExchangeVolume != null &&
                    this.ExchangeVolume.Equals(input.ExchangeVolume))
                ) && 
                (
                    this.MarketVolume == input.MarketVolume ||
                    (this.MarketVolume != null &&
                    this.MarketVolume.Equals(input.MarketVolume))
                ) && 
                (
                    this.EodFiftyTwoWeekHigh == input.EodFiftyTwoWeekHigh ||
                    (this.EodFiftyTwoWeekHigh != null &&
                    this.EodFiftyTwoWeekHigh.Equals(input.EodFiftyTwoWeekHigh))
                ) && 
                (
                    this.EodFiftyTwoWeekLow == input.EodFiftyTwoWeekLow ||
                    (this.EodFiftyTwoWeekLow != null &&
                    this.EodFiftyTwoWeekLow.Equals(input.EodFiftyTwoWeekLow))
                ) && 
                (
                    this.Marketcap == input.Marketcap ||
                    (this.Marketcap != null &&
                    this.Marketcap.Equals(input.Marketcap))
                ) && 
                (
                    this.Pricetoearnings == input.Pricetoearnings ||
                    (this.Pricetoearnings != null &&
                    this.Pricetoearnings.Equals(input.Pricetoearnings))
                ) && 
                (
                    this.PreviousClose == input.PreviousClose ||
                    (this.PreviousClose != null &&
                    this.PreviousClose.Equals(input.PreviousClose))
                ) && 
                (
                    this.PreviousCloseDate == input.PreviousCloseDate ||
                    (this.PreviousCloseDate != null &&
                    this.PreviousCloseDate.Equals(input.PreviousCloseDate))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.ChangePercent == input.ChangePercent ||
                    (this.ChangePercent != null &&
                    this.ChangePercent.Equals(input.ChangePercent))
                ) && 
                (
                    this.AdjClose5DaysAgo == input.AdjClose5DaysAgo ||
                    (this.AdjClose5DaysAgo != null &&
                    this.AdjClose5DaysAgo.Equals(input.AdjClose5DaysAgo))
                ) && 
                (
                    this.AdjClose30DaysAgo == input.AdjClose30DaysAgo ||
                    (this.AdjClose30DaysAgo != null &&
                    this.AdjClose30DaysAgo.Equals(input.AdjClose30DaysAgo))
                ) && 
                (
                    this.AdjClose90DaysAgo == input.AdjClose90DaysAgo ||
                    (this.AdjClose90DaysAgo != null &&
                    this.AdjClose90DaysAgo.Equals(input.AdjClose90DaysAgo))
                ) && 
                (
                    this.AdjClose180DaysAgo == input.AdjClose180DaysAgo ||
                    (this.AdjClose180DaysAgo != null &&
                    this.AdjClose180DaysAgo.Equals(input.AdjClose180DaysAgo))
                ) && 
                (
                    this.AdjClose365DaysAgo == input.AdjClose365DaysAgo ||
                    (this.AdjClose365DaysAgo != null &&
                    this.AdjClose365DaysAgo.Equals(input.AdjClose365DaysAgo))
                ) && 
                (
                    this.AdjClose730DaysAgo == input.AdjClose730DaysAgo ||
                    (this.AdjClose730DaysAgo != null &&
                    this.AdjClose730DaysAgo.Equals(input.AdjClose730DaysAgo))
                ) && 
                (
                    this.AdjClose1825DaysAgo == input.AdjClose1825DaysAgo ||
                    (this.AdjClose1825DaysAgo != null &&
                    this.AdjClose1825DaysAgo.Equals(input.AdjClose1825DaysAgo))
                ) && 
                (
                    this.AdjCloseYearToDate == input.AdjCloseYearToDate ||
                    (this.AdjCloseYearToDate != null &&
                    this.AdjCloseYearToDate.Equals(input.AdjCloseYearToDate))
                ) && 
                (
                    this.ChangePercent5Days == input.ChangePercent5Days ||
                    (this.ChangePercent5Days != null &&
                    this.ChangePercent5Days.Equals(input.ChangePercent5Days))
                ) && 
                (
                    this.ChangePercent30Days == input.ChangePercent30Days ||
                    (this.ChangePercent30Days != null &&
                    this.ChangePercent30Days.Equals(input.ChangePercent30Days))
                ) && 
                (
                    this.ChangePercent90Days == input.ChangePercent90Days ||
                    (this.ChangePercent90Days != null &&
                    this.ChangePercent90Days.Equals(input.ChangePercent90Days))
                ) && 
                (
                    this.ChangePercent180Days == input.ChangePercent180Days ||
                    (this.ChangePercent180Days != null &&
                    this.ChangePercent180Days.Equals(input.ChangePercent180Days))
                ) && 
                (
                    this.ChangePercent365Days == input.ChangePercent365Days ||
                    (this.ChangePercent365Days != null &&
                    this.ChangePercent365Days.Equals(input.ChangePercent365Days))
                ) && 
                (
                    this.ChangePercent730DaysAgo == input.ChangePercent730DaysAgo ||
                    (this.ChangePercent730DaysAgo != null &&
                    this.ChangePercent730DaysAgo.Equals(input.ChangePercent730DaysAgo))
                ) && 
                (
                    this.ChangePercent1825Days == input.ChangePercent1825Days ||
                    (this.ChangePercent1825Days != null &&
                    this.ChangePercent1825Days.Equals(input.ChangePercent1825Days))
                ) && 
                (
                    this.ChangePercentYearToDate == input.ChangePercentYearToDate ||
                    (this.ChangePercentYearToDate != null &&
                    this.ChangePercentYearToDate.Equals(input.ChangePercentYearToDate))
                ) && 
                (
                    this.ExtendedHoursLast == input.ExtendedHoursLast ||
                    (this.ExtendedHoursLast != null &&
                    this.ExtendedHoursLast.Equals(input.ExtendedHoursLast))
                ) && 
                (
                    this.ExtendedHoursChange == input.ExtendedHoursChange ||
                    (this.ExtendedHoursChange != null &&
                    this.ExtendedHoursChange.Equals(input.ExtendedHoursChange))
                ) && 
                (
                    this.ExtendedHoursChangePercent == input.ExtendedHoursChangePercent ||
                    (this.ExtendedHoursChangePercent != null &&
                    this.ExtendedHoursChangePercent.Equals(input.ExtendedHoursChangePercent))
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
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.LastTime != null)
                    hashCode = hashCode * 59 + this.LastTime.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.ExchangeVolume != null)
                    hashCode = hashCode * 59 + this.ExchangeVolume.GetHashCode();
                if (this.MarketVolume != null)
                    hashCode = hashCode * 59 + this.MarketVolume.GetHashCode();
                if (this.EodFiftyTwoWeekHigh != null)
                    hashCode = hashCode * 59 + this.EodFiftyTwoWeekHigh.GetHashCode();
                if (this.EodFiftyTwoWeekLow != null)
                    hashCode = hashCode * 59 + this.EodFiftyTwoWeekLow.GetHashCode();
                if (this.Marketcap != null)
                    hashCode = hashCode * 59 + this.Marketcap.GetHashCode();
                if (this.Pricetoearnings != null)
                    hashCode = hashCode * 59 + this.Pricetoearnings.GetHashCode();
                if (this.PreviousClose != null)
                    hashCode = hashCode * 59 + this.PreviousClose.GetHashCode();
                if (this.PreviousCloseDate != null)
                    hashCode = hashCode * 59 + this.PreviousCloseDate.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.ChangePercent != null)
                    hashCode = hashCode * 59 + this.ChangePercent.GetHashCode();
                if (this.AdjClose5DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose5DaysAgo.GetHashCode();
                if (this.AdjClose30DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose30DaysAgo.GetHashCode();
                if (this.AdjClose90DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose90DaysAgo.GetHashCode();
                if (this.AdjClose180DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose180DaysAgo.GetHashCode();
                if (this.AdjClose365DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose365DaysAgo.GetHashCode();
                if (this.AdjClose730DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose730DaysAgo.GetHashCode();
                if (this.AdjClose1825DaysAgo != null)
                    hashCode = hashCode * 59 + this.AdjClose1825DaysAgo.GetHashCode();
                if (this.AdjCloseYearToDate != null)
                    hashCode = hashCode * 59 + this.AdjCloseYearToDate.GetHashCode();
                if (this.ChangePercent5Days != null)
                    hashCode = hashCode * 59 + this.ChangePercent5Days.GetHashCode();
                if (this.ChangePercent30Days != null)
                    hashCode = hashCode * 59 + this.ChangePercent30Days.GetHashCode();
                if (this.ChangePercent90Days != null)
                    hashCode = hashCode * 59 + this.ChangePercent90Days.GetHashCode();
                if (this.ChangePercent180Days != null)
                    hashCode = hashCode * 59 + this.ChangePercent180Days.GetHashCode();
                if (this.ChangePercent365Days != null)
                    hashCode = hashCode * 59 + this.ChangePercent365Days.GetHashCode();
                if (this.ChangePercent730DaysAgo != null)
                    hashCode = hashCode * 59 + this.ChangePercent730DaysAgo.GetHashCode();
                if (this.ChangePercent1825Days != null)
                    hashCode = hashCode * 59 + this.ChangePercent1825Days.GetHashCode();
                if (this.ChangePercentYearToDate != null)
                    hashCode = hashCode * 59 + this.ChangePercentYearToDate.GetHashCode();
                if (this.ExtendedHoursLast != null)
                    hashCode = hashCode * 59 + this.ExtendedHoursLast.GetHashCode();
                if (this.ExtendedHoursChange != null)
                    hashCode = hashCode * 59 + this.ExtendedHoursChange.GetHashCode();
                if (this.ExtendedHoursChangePercent != null)
                    hashCode = hashCode * 59 + this.ExtendedHoursChangePercent.GetHashCode();
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



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
    /// A record of a company&#39;s initial public offering (IPO). The act of \&quot;going public\&quot; is initiated by an IPO, at which point the company&#39;s stock trades on a major stock exchange (such as NYSE or NASDAQ)
    /// </summary>
    [DataContract]
    public partial class CompanyInitialPublicOffering :  IEquatable<CompanyInitialPublicOffering>, IValidatableObject
    {
        /// <summary>
        /// The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place
        /// </summary>
        /// <value>The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Upcoming for value: "upcoming"
            /// </summary>
            [EnumMember(Value = "upcoming")]
            Upcoming = 1,
            
            /// <summary>
            /// Enum Priced for value: "priced"
            /// </summary>
            [EnumMember(Value = "priced")]
            Priced = 2,
            
            /// <summary>
            /// Enum Withdrawn for value: "withdrawn"
            /// </summary>
            [EnumMember(Value = "withdrawn")]
            Withdrawn = 3
        }

        /// <summary>
        /// The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place
        /// </summary>
        /// <value>The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyInitialPublicOffering" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the IPO.</param>
        /// <param name="Ticker">The ticker under which the Company will be traded after the IPO takes place.</param>
        /// <param name="Date">The date of the IPO, when the stock first trades on a major exchange.</param>
        /// <param name="Status">The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place.</param>
        /// <param name="Exchange">The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE or NASDAQ.</param>
        /// <param name="OfferAmount">The total dollar amount of shares offered in the IPO. Typically this is share price * share count.</param>
        /// <param name="SharePrice">The price per share at which the IPO was offered.</param>
        /// <param name="SharePriceLowest">The expected lowest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs).</param>
        /// <param name="SharePriceHighest">The expected highest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs).</param>
        /// <param name="ShareCount">The number of shares offered in the IPO.</param>
        /// <param name="ShareCountLowest">The expected lowest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs).</param>
        /// <param name="ShareCountHighest">The expected highest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs).</param>
        /// <param name="AnnouncementUrl">The URL to the company&#39;s announcement of the IPO.</param>
        /// <param name="SecReportUrl">The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be filed before an IPO takes place..</param>
        /// <param name="OpenPrice">The opening price at the beginning of the first trading day (only available for priced IPOs).</param>
        /// <param name="ClosePrice">The closing price at the end of the first trading day (only available for priced IPOs).</param>
        /// <param name="Volume">The volume at the end of the first trading day (only available for priced IPOs).</param>
        /// <param name="DayChange">The percentage change between the open price and the close price on the first trading day (only available for priced IPOs).</param>
        /// <param name="WeekChange">The percentage change between the open price on the first trading day and the close price approximately a week after the first trading day (only available for priced IPOs).</param>
        /// <param name="MonthChange">The percentage change between the open price on the first trading day and the close price approximately a month after the first trading day (only available for priced IPOs).</param>
        /// <param name="Company">The Company that is going public via the IPO.</param>
        /// <param name="Security">The primary Security for the Company that is going public via the IPO.</param>
        public CompanyInitialPublicOffering(string Id = default(string), string Ticker = default(string), DateTime? Date = default(DateTime?), StatusEnum? Status = default(StatusEnum?), string Exchange = default(string), decimal? OfferAmount = default(decimal?), decimal? SharePrice = default(decimal?), decimal? SharePriceLowest = default(decimal?), decimal? SharePriceHighest = default(decimal?), decimal? ShareCount = default(decimal?), decimal? ShareCountLowest = default(decimal?), decimal? ShareCountHighest = default(decimal?), string AnnouncementUrl = default(string), string SecReportUrl = default(string), decimal? OpenPrice = default(decimal?), decimal? ClosePrice = default(decimal?), decimal? Volume = default(decimal?), decimal? DayChange = default(decimal?), decimal? WeekChange = default(decimal?), decimal? MonthChange = default(decimal?), CompanySummary Company = default(CompanySummary), SecuritySummary Security = default(SecuritySummary))
        {
            this.Id = Id;
            this.Ticker = Ticker;
            this.Date = Date;
            this.Status = Status;
            this.Exchange = Exchange;
            this.OfferAmount = OfferAmount;
            this.SharePrice = SharePrice;
            this.SharePriceLowest = SharePriceLowest;
            this.SharePriceHighest = SharePriceHighest;
            this.ShareCount = ShareCount;
            this.ShareCountLowest = ShareCountLowest;
            this.ShareCountHighest = ShareCountHighest;
            this.AnnouncementUrl = AnnouncementUrl;
            this.SecReportUrl = SecReportUrl;
            this.OpenPrice = OpenPrice;
            this.ClosePrice = ClosePrice;
            this.Volume = Volume;
            this.DayChange = DayChange;
            this.WeekChange = WeekChange;
            this.MonthChange = MonthChange;
            this.Company = Company;
            this.Security = Security;
        }
        
        /// <summary>
        /// The Intrinio ID for the IPO
        /// </summary>
        /// <value>The Intrinio ID for the IPO</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The ticker under which the Company will be traded after the IPO takes place
        /// </summary>
        /// <value>The ticker under which the Company will be traded after the IPO takes place</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The date of the IPO, when the stock first trades on a major exchange
        /// </summary>
        /// <value>The date of the IPO, when the stock first trades on a major exchange</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }


        /// <summary>
        /// The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE or NASDAQ
        /// </summary>
        /// <value>The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE or NASDAQ</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// The total dollar amount of shares offered in the IPO. Typically this is share price * share count
        /// </summary>
        /// <value>The total dollar amount of shares offered in the IPO. Typically this is share price * share count</value>
        [DataMember(Name="offer_amount", EmitDefaultValue=false)]
        public decimal? OfferAmount { get; set; }

        /// <summary>
        /// The price per share at which the IPO was offered
        /// </summary>
        /// <value>The price per share at which the IPO was offered</value>
        [DataMember(Name="share_price", EmitDefaultValue=false)]
        public decimal? SharePrice { get; set; }

        /// <summary>
        /// The expected lowest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs)
        /// </summary>
        /// <value>The expected lowest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs)</value>
        [DataMember(Name="share_price_lowest", EmitDefaultValue=false)]
        public decimal? SharePriceLowest { get; set; }

        /// <summary>
        /// The expected highest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs)
        /// </summary>
        /// <value>The expected highest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs)</value>
        [DataMember(Name="share_price_highest", EmitDefaultValue=false)]
        public decimal? SharePriceHighest { get; set; }

        /// <summary>
        /// The number of shares offered in the IPO
        /// </summary>
        /// <value>The number of shares offered in the IPO</value>
        [DataMember(Name="share_count", EmitDefaultValue=false)]
        public decimal? ShareCount { get; set; }

        /// <summary>
        /// The expected lowest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)
        /// </summary>
        /// <value>The expected lowest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)</value>
        [DataMember(Name="share_count_lowest", EmitDefaultValue=false)]
        public decimal? ShareCountLowest { get; set; }

        /// <summary>
        /// The expected highest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)
        /// </summary>
        /// <value>The expected highest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)</value>
        [DataMember(Name="share_count_highest", EmitDefaultValue=false)]
        public decimal? ShareCountHighest { get; set; }

        /// <summary>
        /// The URL to the company&#39;s announcement of the IPO
        /// </summary>
        /// <value>The URL to the company&#39;s announcement of the IPO</value>
        [DataMember(Name="announcement_url", EmitDefaultValue=false)]
        public string AnnouncementUrl { get; set; }

        /// <summary>
        /// The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be filed before an IPO takes place.
        /// </summary>
        /// <value>The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be filed before an IPO takes place.</value>
        [DataMember(Name="sec_report_url", EmitDefaultValue=false)]
        public string SecReportUrl { get; set; }

        /// <summary>
        /// The opening price at the beginning of the first trading day (only available for priced IPOs)
        /// </summary>
        /// <value>The opening price at the beginning of the first trading day (only available for priced IPOs)</value>
        [DataMember(Name="open_price", EmitDefaultValue=false)]
        public decimal? OpenPrice { get; set; }

        /// <summary>
        /// The closing price at the end of the first trading day (only available for priced IPOs)
        /// </summary>
        /// <value>The closing price at the end of the first trading day (only available for priced IPOs)</value>
        [DataMember(Name="close_price", EmitDefaultValue=false)]
        public decimal? ClosePrice { get; set; }

        /// <summary>
        /// The volume at the end of the first trading day (only available for priced IPOs)
        /// </summary>
        /// <value>The volume at the end of the first trading day (only available for priced IPOs)</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The percentage change between the open price and the close price on the first trading day (only available for priced IPOs)
        /// </summary>
        /// <value>The percentage change between the open price and the close price on the first trading day (only available for priced IPOs)</value>
        [DataMember(Name="day_change", EmitDefaultValue=false)]
        public decimal? DayChange { get; set; }

        /// <summary>
        /// The percentage change between the open price on the first trading day and the close price approximately a week after the first trading day (only available for priced IPOs)
        /// </summary>
        /// <value>The percentage change between the open price on the first trading day and the close price approximately a week after the first trading day (only available for priced IPOs)</value>
        [DataMember(Name="week_change", EmitDefaultValue=false)]
        public decimal? WeekChange { get; set; }

        /// <summary>
        /// The percentage change between the open price on the first trading day and the close price approximately a month after the first trading day (only available for priced IPOs)
        /// </summary>
        /// <value>The percentage change between the open price on the first trading day and the close price approximately a month after the first trading day (only available for priced IPOs)</value>
        [DataMember(Name="month_change", EmitDefaultValue=false)]
        public decimal? MonthChange { get; set; }

        /// <summary>
        /// The Company that is going public via the IPO
        /// </summary>
        /// <value>The Company that is going public via the IPO</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// The primary Security for the Company that is going public via the IPO
        /// </summary>
        /// <value>The primary Security for the Company that is going public via the IPO</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyInitialPublicOffering {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  OfferAmount: ").Append(OfferAmount).Append("\n");
            sb.Append("  SharePrice: ").Append(SharePrice).Append("\n");
            sb.Append("  SharePriceLowest: ").Append(SharePriceLowest).Append("\n");
            sb.Append("  SharePriceHighest: ").Append(SharePriceHighest).Append("\n");
            sb.Append("  ShareCount: ").Append(ShareCount).Append("\n");
            sb.Append("  ShareCountLowest: ").Append(ShareCountLowest).Append("\n");
            sb.Append("  ShareCountHighest: ").Append(ShareCountHighest).Append("\n");
            sb.Append("  AnnouncementUrl: ").Append(AnnouncementUrl).Append("\n");
            sb.Append("  SecReportUrl: ").Append(SecReportUrl).Append("\n");
            sb.Append("  OpenPrice: ").Append(OpenPrice).Append("\n");
            sb.Append("  ClosePrice: ").Append(ClosePrice).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  DayChange: ").Append(DayChange).Append("\n");
            sb.Append("  WeekChange: ").Append(WeekChange).Append("\n");
            sb.Append("  MonthChange: ").Append(MonthChange).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as CompanyInitialPublicOffering);
        }

        /// <summary>
        /// Returns true if CompanyInitialPublicOffering instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyInitialPublicOffering to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyInitialPublicOffering input)
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
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.OfferAmount == input.OfferAmount ||
                    (this.OfferAmount != null &&
                    this.OfferAmount.Equals(input.OfferAmount))
                ) && 
                (
                    this.SharePrice == input.SharePrice ||
                    (this.SharePrice != null &&
                    this.SharePrice.Equals(input.SharePrice))
                ) && 
                (
                    this.SharePriceLowest == input.SharePriceLowest ||
                    (this.SharePriceLowest != null &&
                    this.SharePriceLowest.Equals(input.SharePriceLowest))
                ) && 
                (
                    this.SharePriceHighest == input.SharePriceHighest ||
                    (this.SharePriceHighest != null &&
                    this.SharePriceHighest.Equals(input.SharePriceHighest))
                ) && 
                (
                    this.ShareCount == input.ShareCount ||
                    (this.ShareCount != null &&
                    this.ShareCount.Equals(input.ShareCount))
                ) && 
                (
                    this.ShareCountLowest == input.ShareCountLowest ||
                    (this.ShareCountLowest != null &&
                    this.ShareCountLowest.Equals(input.ShareCountLowest))
                ) && 
                (
                    this.ShareCountHighest == input.ShareCountHighest ||
                    (this.ShareCountHighest != null &&
                    this.ShareCountHighest.Equals(input.ShareCountHighest))
                ) && 
                (
                    this.AnnouncementUrl == input.AnnouncementUrl ||
                    (this.AnnouncementUrl != null &&
                    this.AnnouncementUrl.Equals(input.AnnouncementUrl))
                ) && 
                (
                    this.SecReportUrl == input.SecReportUrl ||
                    (this.SecReportUrl != null &&
                    this.SecReportUrl.Equals(input.SecReportUrl))
                ) && 
                (
                    this.OpenPrice == input.OpenPrice ||
                    (this.OpenPrice != null &&
                    this.OpenPrice.Equals(input.OpenPrice))
                ) && 
                (
                    this.ClosePrice == input.ClosePrice ||
                    (this.ClosePrice != null &&
                    this.ClosePrice.Equals(input.ClosePrice))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.DayChange == input.DayChange ||
                    (this.DayChange != null &&
                    this.DayChange.Equals(input.DayChange))
                ) && 
                (
                    this.WeekChange == input.WeekChange ||
                    (this.WeekChange != null &&
                    this.WeekChange.Equals(input.WeekChange))
                ) && 
                (
                    this.MonthChange == input.MonthChange ||
                    (this.MonthChange != null &&
                    this.MonthChange.Equals(input.MonthChange))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.OfferAmount != null)
                    hashCode = hashCode * 59 + this.OfferAmount.GetHashCode();
                if (this.SharePrice != null)
                    hashCode = hashCode * 59 + this.SharePrice.GetHashCode();
                if (this.SharePriceLowest != null)
                    hashCode = hashCode * 59 + this.SharePriceLowest.GetHashCode();
                if (this.SharePriceHighest != null)
                    hashCode = hashCode * 59 + this.SharePriceHighest.GetHashCode();
                if (this.ShareCount != null)
                    hashCode = hashCode * 59 + this.ShareCount.GetHashCode();
                if (this.ShareCountLowest != null)
                    hashCode = hashCode * 59 + this.ShareCountLowest.GetHashCode();
                if (this.ShareCountHighest != null)
                    hashCode = hashCode * 59 + this.ShareCountHighest.GetHashCode();
                if (this.AnnouncementUrl != null)
                    hashCode = hashCode * 59 + this.AnnouncementUrl.GetHashCode();
                if (this.SecReportUrl != null)
                    hashCode = hashCode * 59 + this.SecReportUrl.GetHashCode();
                if (this.OpenPrice != null)
                    hashCode = hashCode * 59 + this.OpenPrice.GetHashCode();
                if (this.ClosePrice != null)
                    hashCode = hashCode * 59 + this.ClosePrice.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.DayChange != null)
                    hashCode = hashCode * 59 + this.DayChange.GetHashCode();
                if (this.WeekChange != null)
                    hashCode = hashCode * 59 + this.WeekChange.GetHashCode();
                if (this.MonthChange != null)
                    hashCode = hashCode * 59 + this.MonthChange.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

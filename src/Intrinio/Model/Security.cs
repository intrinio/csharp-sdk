

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// A financial instrument representing shares of ownership in a publicly-traded company
    /// </summary>
    [DataContract]
    public partial class Security :  IEquatable<Security>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Security" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the Security.</param>
        /// <param name="CompanyId">The Intrinio ID for the company for which the Security is issued.</param>
        /// <param name="Name">The name of the Security.</param>
        /// <param name="Type">The Security&#39;s type.</param>
        /// <param name="Code">A 2-3 digit code classifying the Security.</param>
        /// <param name="ShareClass">The Security&#39;s share class (if applicable).</param>
        /// <param name="Currency">The currency in which the Security is traded on the exchange.</param>
        /// <param name="RoundLotSize">The normal unit of trading.</param>
        /// <param name="Ticker">The common ticker.</param>
        /// <param name="ExchangeTicker">The exchange-level ticker.</param>
        /// <param name="CompositeTicker">The country-composite ticker.</param>
        /// <param name="AlternateTickers">Alternate formats of the common ticker.</param>
        /// <param name="Figi">The exchange-level OpenFIGI identifier.</param>
        /// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
        /// <param name="ShareClassFigi">The global-composite OpenFIGI identifier.</param>
        /// <param name="FigiUniqueid">The OpenFIGI unique ID.</param>
        /// <param name="Active">If true, the Security is active and has been recently traded.</param>
        /// <param name="Etf">If true, this Security is an ETF.</param>
        /// <param name="Delisted">If true, the Security is no longer traded on the exchange.</param>
        /// <param name="PrimaryListing">If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange.</param>
        /// <param name="PrimarySecurity">If true, the Security is considered by Intrinio to be the primary Security for its company.</param>
        /// <param name="FirstStockPrice">The date of the first recorded stock price.</param>
        /// <param name="LastStockPrice">The date of the last recorded stock price (or the most recent trading day).</param>
        /// <param name="LastStockPriceAdjustment">The date of the last stock price adjustment (dividend, split, etc).</param>
        /// <param name="LastCorporateAction">The date of the last corporate action.</param>
        /// <param name="PreviousTickers">Previous tickers used by this security.</param>
        public Security(string Id = default(string), string CompanyId = default(string), string Name = default(string), string Type = default(string), string Code = default(string), string ShareClass = default(string), string Currency = default(string), decimal? RoundLotSize = default(decimal?), string Ticker = default(string), string ExchangeTicker = default(string), string CompositeTicker = default(string), List<string> AlternateTickers = default(List<string>), string Figi = default(string), string CompositeFigi = default(string), string ShareClassFigi = default(string), string FigiUniqueid = default(string), bool? Active = default(bool?), bool? Etf = default(bool?), bool? Delisted = default(bool?), bool? PrimaryListing = default(bool?), bool? PrimarySecurity = default(bool?), DateTime? FirstStockPrice = default(DateTime?), DateTime? LastStockPrice = default(DateTime?), DateTime? LastStockPriceAdjustment = default(DateTime?), DateTime? LastCorporateAction = default(DateTime?), List<string> PreviousTickers = default(List<string>))
        {
            this.Id = Id;
            this.CompanyId = CompanyId;
            this.Name = Name;
            this.Type = Type;
            this.Code = Code;
            this.ShareClass = ShareClass;
            this.Currency = Currency;
            this.RoundLotSize = RoundLotSize;
            this.Ticker = Ticker;
            this.ExchangeTicker = ExchangeTicker;
            this.CompositeTicker = CompositeTicker;
            this.AlternateTickers = AlternateTickers;
            this.Figi = Figi;
            this.CompositeFigi = CompositeFigi;
            this.ShareClassFigi = ShareClassFigi;
            this.FigiUniqueid = FigiUniqueid;
            this.Active = Active;
            this.Etf = Etf;
            this.Delisted = Delisted;
            this.PrimaryListing = PrimaryListing;
            this.PrimarySecurity = PrimarySecurity;
            this.FirstStockPrice = FirstStockPrice;
            this.LastStockPrice = LastStockPrice;
            this.LastStockPriceAdjustment = LastStockPriceAdjustment;
            this.LastCorporateAction = LastCorporateAction;
            this.PreviousTickers = PreviousTickers;
        }
        
        /// <summary>
        /// The Intrinio ID for the Security
        /// </summary>
        /// <value>The Intrinio ID for the Security</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The Intrinio ID for the company for which the Security is issued
        /// </summary>
        /// <value>The Intrinio ID for the company for which the Security is issued</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The name of the Security
        /// </summary>
        /// <value>The name of the Security</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Security&#39;s type
        /// </summary>
        /// <value>The Security&#39;s type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// A 2-3 digit code classifying the Security
        /// </summary>
        /// <value>A 2-3 digit code classifying the Security</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The Security&#39;s share class (if applicable)
        /// </summary>
        /// <value>The Security&#39;s share class (if applicable)</value>
        [DataMember(Name="share_class", EmitDefaultValue=false)]
        public string ShareClass { get; set; }

        /// <summary>
        /// The currency in which the Security is traded on the exchange
        /// </summary>
        /// <value>The currency in which the Security is traded on the exchange</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The normal unit of trading
        /// </summary>
        /// <value>The normal unit of trading</value>
        [DataMember(Name="round_lot_size", EmitDefaultValue=false)]
        public decimal? RoundLotSize { get; set; }

        /// <summary>
        /// The common ticker
        /// </summary>
        /// <value>The common ticker</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The exchange-level ticker
        /// </summary>
        /// <value>The exchange-level ticker</value>
        [DataMember(Name="exchange_ticker", EmitDefaultValue=false)]
        public string ExchangeTicker { get; set; }

        /// <summary>
        /// The country-composite ticker
        /// </summary>
        /// <value>The country-composite ticker</value>
        [DataMember(Name="composite_ticker", EmitDefaultValue=false)]
        public string CompositeTicker { get; set; }

        /// <summary>
        /// Alternate formats of the common ticker
        /// </summary>
        /// <value>Alternate formats of the common ticker</value>
        [DataMember(Name="alternate_tickers", EmitDefaultValue=false)]
        public List<string> AlternateTickers { get; set; }

        /// <summary>
        /// The exchange-level OpenFIGI identifier
        /// </summary>
        /// <value>The exchange-level OpenFIGI identifier</value>
        [DataMember(Name="figi", EmitDefaultValue=false)]
        public string Figi { get; set; }

        /// <summary>
        /// The country-composite OpenFIGI identifier
        /// </summary>
        /// <value>The country-composite OpenFIGI identifier</value>
        [DataMember(Name="composite_figi", EmitDefaultValue=false)]
        public string CompositeFigi { get; set; }

        /// <summary>
        /// The global-composite OpenFIGI identifier
        /// </summary>
        /// <value>The global-composite OpenFIGI identifier</value>
        [DataMember(Name="share_class_figi", EmitDefaultValue=false)]
        public string ShareClassFigi { get; set; }

        /// <summary>
        /// The OpenFIGI unique ID
        /// </summary>
        /// <value>The OpenFIGI unique ID</value>
        [DataMember(Name="figi_uniqueid", EmitDefaultValue=false)]
        public string FigiUniqueid { get; set; }

        /// <summary>
        /// If true, the Security is active and has been recently traded
        /// </summary>
        /// <value>If true, the Security is active and has been recently traded</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// If true, this Security is an ETF
        /// </summary>
        /// <value>If true, this Security is an ETF</value>
        [DataMember(Name="etf", EmitDefaultValue=false)]
        public bool? Etf { get; set; }

        /// <summary>
        /// If true, the Security is no longer traded on the exchange
        /// </summary>
        /// <value>If true, the Security is no longer traded on the exchange</value>
        [DataMember(Name="delisted", EmitDefaultValue=false)]
        public bool? Delisted { get; set; }

        /// <summary>
        /// If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange
        /// </summary>
        /// <value>If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange</value>
        [DataMember(Name="primary_listing", EmitDefaultValue=false)]
        public bool? PrimaryListing { get; set; }

        /// <summary>
        /// If true, the Security is considered by Intrinio to be the primary Security for its company
        /// </summary>
        /// <value>If true, the Security is considered by Intrinio to be the primary Security for its company</value>
        [DataMember(Name="primary_security", EmitDefaultValue=false)]
        public bool? PrimarySecurity { get; set; }

        /// <summary>
        /// The date of the first recorded stock price
        /// </summary>
        /// <value>The date of the first recorded stock price</value>
        [DataMember(Name="first_stock_price", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FirstStockPrice { get; set; }

        /// <summary>
        /// The date of the last recorded stock price (or the most recent trading day)
        /// </summary>
        /// <value>The date of the last recorded stock price (or the most recent trading day)</value>
        [DataMember(Name="last_stock_price", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastStockPrice { get; set; }

        /// <summary>
        /// The date of the last stock price adjustment (dividend, split, etc)
        /// </summary>
        /// <value>The date of the last stock price adjustment (dividend, split, etc)</value>
        [DataMember(Name="last_stock_price_adjustment", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastStockPriceAdjustment { get; set; }

        /// <summary>
        /// The date of the last corporate action
        /// </summary>
        /// <value>The date of the last corporate action</value>
        [DataMember(Name="last_corporate_action", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastCorporateAction { get; set; }

        /// <summary>
        /// Previous tickers used by this security
        /// </summary>
        /// <value>Previous tickers used by this security</value>
        [DataMember(Name="previous_tickers", EmitDefaultValue=false)]
        public List<string> PreviousTickers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Security {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ShareClass: ").Append(ShareClass).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RoundLotSize: ").Append(RoundLotSize).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  ExchangeTicker: ").Append(ExchangeTicker).Append("\n");
            sb.Append("  CompositeTicker: ").Append(CompositeTicker).Append("\n");
            sb.Append("  AlternateTickers: ").Append(AlternateTickers).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
            sb.Append("  ShareClassFigi: ").Append(ShareClassFigi).Append("\n");
            sb.Append("  FigiUniqueid: ").Append(FigiUniqueid).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Etf: ").Append(Etf).Append("\n");
            sb.Append("  Delisted: ").Append(Delisted).Append("\n");
            sb.Append("  PrimaryListing: ").Append(PrimaryListing).Append("\n");
            sb.Append("  PrimarySecurity: ").Append(PrimarySecurity).Append("\n");
            sb.Append("  FirstStockPrice: ").Append(FirstStockPrice).Append("\n");
            sb.Append("  LastStockPrice: ").Append(LastStockPrice).Append("\n");
            sb.Append("  LastStockPriceAdjustment: ").Append(LastStockPriceAdjustment).Append("\n");
            sb.Append("  LastCorporateAction: ").Append(LastCorporateAction).Append("\n");
            sb.Append("  PreviousTickers: ").Append(PreviousTickers).Append("\n");
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
            return this.Equals(input as Security);
        }

        /// <summary>
        /// Returns true if Security instances are equal
        /// </summary>
        /// <param name="input">Instance of Security to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Security input)
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
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ShareClass == input.ShareClass ||
                    (this.ShareClass != null &&
                    this.ShareClass.Equals(input.ShareClass))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.RoundLotSize == input.RoundLotSize ||
                    (this.RoundLotSize != null &&
                    this.RoundLotSize.Equals(input.RoundLotSize))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.ExchangeTicker == input.ExchangeTicker ||
                    (this.ExchangeTicker != null &&
                    this.ExchangeTicker.Equals(input.ExchangeTicker))
                ) && 
                (
                    this.CompositeTicker == input.CompositeTicker ||
                    (this.CompositeTicker != null &&
                    this.CompositeTicker.Equals(input.CompositeTicker))
                ) && 
                (
                    this.AlternateTickers == input.AlternateTickers ||
                    this.AlternateTickers != null &&
                    this.AlternateTickers.SequenceEqual(input.AlternateTickers)
                ) && 
                (
                    this.Figi == input.Figi ||
                    (this.Figi != null &&
                    this.Figi.Equals(input.Figi))
                ) && 
                (
                    this.CompositeFigi == input.CompositeFigi ||
                    (this.CompositeFigi != null &&
                    this.CompositeFigi.Equals(input.CompositeFigi))
                ) && 
                (
                    this.ShareClassFigi == input.ShareClassFigi ||
                    (this.ShareClassFigi != null &&
                    this.ShareClassFigi.Equals(input.ShareClassFigi))
                ) && 
                (
                    this.FigiUniqueid == input.FigiUniqueid ||
                    (this.FigiUniqueid != null &&
                    this.FigiUniqueid.Equals(input.FigiUniqueid))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Etf == input.Etf ||
                    (this.Etf != null &&
                    this.Etf.Equals(input.Etf))
                ) && 
                (
                    this.Delisted == input.Delisted ||
                    (this.Delisted != null &&
                    this.Delisted.Equals(input.Delisted))
                ) && 
                (
                    this.PrimaryListing == input.PrimaryListing ||
                    (this.PrimaryListing != null &&
                    this.PrimaryListing.Equals(input.PrimaryListing))
                ) && 
                (
                    this.PrimarySecurity == input.PrimarySecurity ||
                    (this.PrimarySecurity != null &&
                    this.PrimarySecurity.Equals(input.PrimarySecurity))
                ) && 
                (
                    this.FirstStockPrice == input.FirstStockPrice ||
                    (this.FirstStockPrice != null &&
                    this.FirstStockPrice.Equals(input.FirstStockPrice))
                ) && 
                (
                    this.LastStockPrice == input.LastStockPrice ||
                    (this.LastStockPrice != null &&
                    this.LastStockPrice.Equals(input.LastStockPrice))
                ) && 
                (
                    this.LastStockPriceAdjustment == input.LastStockPriceAdjustment ||
                    (this.LastStockPriceAdjustment != null &&
                    this.LastStockPriceAdjustment.Equals(input.LastStockPriceAdjustment))
                ) && 
                (
                    this.LastCorporateAction == input.LastCorporateAction ||
                    (this.LastCorporateAction != null &&
                    this.LastCorporateAction.Equals(input.LastCorporateAction))
                ) && 
                (
                    this.PreviousTickers == input.PreviousTickers ||
                    this.PreviousTickers != null &&
                    this.PreviousTickers.SequenceEqual(input.PreviousTickers)
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
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ShareClass != null)
                    hashCode = hashCode * 59 + this.ShareClass.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.RoundLotSize != null)
                    hashCode = hashCode * 59 + this.RoundLotSize.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.ExchangeTicker != null)
                    hashCode = hashCode * 59 + this.ExchangeTicker.GetHashCode();
                if (this.CompositeTicker != null)
                    hashCode = hashCode * 59 + this.CompositeTicker.GetHashCode();
                if (this.AlternateTickers != null)
                    hashCode = hashCode * 59 + this.AlternateTickers.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.CompositeFigi != null)
                    hashCode = hashCode * 59 + this.CompositeFigi.GetHashCode();
                if (this.ShareClassFigi != null)
                    hashCode = hashCode * 59 + this.ShareClassFigi.GetHashCode();
                if (this.FigiUniqueid != null)
                    hashCode = hashCode * 59 + this.FigiUniqueid.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Etf != null)
                    hashCode = hashCode * 59 + this.Etf.GetHashCode();
                if (this.Delisted != null)
                    hashCode = hashCode * 59 + this.Delisted.GetHashCode();
                if (this.PrimaryListing != null)
                    hashCode = hashCode * 59 + this.PrimaryListing.GetHashCode();
                if (this.PrimarySecurity != null)
                    hashCode = hashCode * 59 + this.PrimarySecurity.GetHashCode();
                if (this.FirstStockPrice != null)
                    hashCode = hashCode * 59 + this.FirstStockPrice.GetHashCode();
                if (this.LastStockPrice != null)
                    hashCode = hashCode * 59 + this.LastStockPrice.GetHashCode();
                if (this.LastStockPriceAdjustment != null)
                    hashCode = hashCode * 59 + this.LastStockPriceAdjustment.GetHashCode();
                if (this.LastCorporateAction != null)
                    hashCode = hashCode * 59 + this.LastCorporateAction.GetHashCode();
                if (this.PreviousTickers != null)
                    hashCode = hashCode * 59 + this.PreviousTickers.GetHashCode();
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

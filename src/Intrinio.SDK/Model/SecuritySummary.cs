

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
    /// The summary of a financial instrument representing shares of ownership in a publicly-traded company
    /// </summary>
    [DataContract]
    public partial class SecuritySummary :  IEquatable<SecuritySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for Security.</param>
        /// <param name="CompanyId">The Intrinio ID for the Company for which the Security is issued.</param>
        /// <param name="Exchange">The exchange&#39;s MIC.</param>
        /// <param name="ExchangeMic">The security&#39;s exchange MIC.</param>
        /// <param name="StockExchangeId">The exchange&#39;s Intrinio ID.</param>
        /// <param name="Name">The name of the Security.</param>
        /// <param name="Code">A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;).</param>
        /// <param name="Currency">The currency in which the Security is traded on the exchange.</param>
        /// <param name="Ticker">The common/local ticker of the Security.</param>
        /// <param name="CompositeTicker">The country-composite ticker of the Security.</param>
        /// <param name="Figi">The OpenFIGI identifier.</param>
        /// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
        /// <param name="ShareClassFigi">The global-composite OpenFIGI identifier.</param>
        /// <param name="PrimaryListing">If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange.</param>
        public SecuritySummary(string Id = default(string), string CompanyId = default(string), string Exchange = default(string), string ExchangeMic = default(string), string StockExchangeId = default(string), string Name = default(string), string Code = default(string), string Currency = default(string), string Ticker = default(string), string CompositeTicker = default(string), string Figi = default(string), string CompositeFigi = default(string), string ShareClassFigi = default(string), bool? PrimaryListing = default(bool?))
        {
            this.Id = Id;
            this.CompanyId = CompanyId;
            this.Exchange = Exchange;
            this.ExchangeMic = ExchangeMic;
            this.StockExchangeId = StockExchangeId;
            this.Name = Name;
            this.Code = Code;
            this.Currency = Currency;
            this.Ticker = Ticker;
            this.CompositeTicker = CompositeTicker;
            this.Figi = Figi;
            this.CompositeFigi = CompositeFigi;
            this.ShareClassFigi = ShareClassFigi;
            this.PrimaryListing = PrimaryListing;
        }
        
        /// <summary>
        /// The Intrinio ID for Security
        /// </summary>
        /// <value>The Intrinio ID for Security</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The Intrinio ID for the Company for which the Security is issued
        /// </summary>
        /// <value>The Intrinio ID for the Company for which the Security is issued</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The exchange&#39;s MIC
        /// </summary>
        /// <value>The exchange&#39;s MIC</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// The security&#39;s exchange MIC
        /// </summary>
        /// <value>The security&#39;s exchange MIC</value>
        [DataMember(Name="exchange_mic", EmitDefaultValue=false)]
        public string ExchangeMic { get; set; }

        /// <summary>
        /// The exchange&#39;s Intrinio ID
        /// </summary>
        /// <value>The exchange&#39;s Intrinio ID</value>
        [DataMember(Name="stock_exchange_id", EmitDefaultValue=false)]
        public string StockExchangeId { get; set; }

        /// <summary>
        /// The name of the Security
        /// </summary>
        /// <value>The name of the Security</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)
        /// </summary>
        /// <value>A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The currency in which the Security is traded on the exchange
        /// </summary>
        /// <value>The currency in which the Security is traded on the exchange</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The common/local ticker of the Security
        /// </summary>
        /// <value>The common/local ticker of the Security</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The country-composite ticker of the Security
        /// </summary>
        /// <value>The country-composite ticker of the Security</value>
        [DataMember(Name="composite_ticker", EmitDefaultValue=false)]
        public string CompositeTicker { get; set; }

        /// <summary>
        /// The OpenFIGI identifier
        /// </summary>
        /// <value>The OpenFIGI identifier</value>
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
        /// If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange
        /// </summary>
        /// <value>If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange</value>
        [DataMember(Name="primary_listing", EmitDefaultValue=false)]
        public bool? PrimaryListing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  ExchangeMic: ").Append(ExchangeMic).Append("\n");
            sb.Append("  StockExchangeId: ").Append(StockExchangeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  CompositeTicker: ").Append(CompositeTicker).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
            sb.Append("  ShareClassFigi: ").Append(ShareClassFigi).Append("\n");
            sb.Append("  PrimaryListing: ").Append(PrimaryListing).Append("\n");
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
            return this.Equals(input as SecuritySummary);
        }

        /// <summary>
        /// Returns true if SecuritySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of SecuritySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecuritySummary input)
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
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.ExchangeMic == input.ExchangeMic ||
                    (this.ExchangeMic != null &&
                    this.ExchangeMic.Equals(input.ExchangeMic))
                ) && 
                (
                    this.StockExchangeId == input.StockExchangeId ||
                    (this.StockExchangeId != null &&
                    this.StockExchangeId.Equals(input.StockExchangeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.CompositeTicker == input.CompositeTicker ||
                    (this.CompositeTicker != null &&
                    this.CompositeTicker.Equals(input.CompositeTicker))
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
                    this.PrimaryListing == input.PrimaryListing ||
                    (this.PrimaryListing != null &&
                    this.PrimaryListing.Equals(input.PrimaryListing))
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
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.ExchangeMic != null)
                    hashCode = hashCode * 59 + this.ExchangeMic.GetHashCode();
                if (this.StockExchangeId != null)
                    hashCode = hashCode * 59 + this.StockExchangeId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.CompositeTicker != null)
                    hashCode = hashCode * 59 + this.CompositeTicker.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.CompositeFigi != null)
                    hashCode = hashCode * 59 + this.CompositeFigi.GetHashCode();
                if (this.ShareClassFigi != null)
                    hashCode = hashCode * 59 + this.ShareClassFigi.GetHashCode();
                if (this.PrimaryListing != null)
                    hashCode = hashCode * 59 + this.PrimaryListing.GetHashCode();
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

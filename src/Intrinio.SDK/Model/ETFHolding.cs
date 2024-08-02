

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
    /// The Exchange Traded Fund (ETF) holding data
    /// </summary>
    [DataContract]
    public partial class ETFHolding :  IEquatable<ETFHolding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFHolding" /> class.
        /// </summary>
        /// <param name="AsOfDate">The date on which the holding and their weights correspond.</param>
        /// <param name="Name">The common name for the holding.</param>
        /// <param name="Ticker">The common exchange ticker for the holding.</param>
        /// <param name="Type">The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;EQUI&#39;, Options &#x3D; &#39;OPTN&#39;).</param>
        /// <param name="CompositeFigi">DEPRECATED.</param>
        /// <param name="ShareClassFigi">The OpenFIGI symbol for the holding.</param>
        /// <param name="Isin">International Securities Identification Number (ISIN) for the holding.</param>
        /// <param name="Ric">Reuters Instrument Code (RIC) for the holding.</param>
        /// <param name="Sedol">Stock Exchange Daily Official List (SEDOL) for the holding.</param>
        /// <param name="Face">Face value of the debt security, if available.</param>
        /// <param name="Coupon">Coupon rate of the debt security, if available.</param>
        /// <param name="MarketValueHeld">The market value of this holding in the ETF as of the &#x60;as_of_date&#x60;.</param>
        /// <param name="NotionalValue">Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN).</param>
        /// <param name="Maturity">Maturity date for the debt security, if available.</param>
        /// <param name="QuantityHeld">Number of units of the security held if available.</param>
        /// <param name="Weighting">Fraction of the funds market value held.</param>
        /// <param name="QuantityUnits">The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;, &#39;contracts&#39;).</param>
        /// <param name="QuantityPerShare">Number of units of the security held per units of shares outstanding of the Exchange Traded Fund (ETF), if available.</param>
        /// <param name="ContractExpiryDate">Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN).</param>
        public ETFHolding(DateTime? AsOfDate = default(DateTime?), string Name = default(string), string Ticker = default(string), string Type = default(string), string CompositeFigi = default(string), string ShareClassFigi = default(string), string Isin = default(string), string Ric = default(string), string Sedol = default(string), decimal? Face = default(decimal?), decimal? Coupon = default(decimal?), decimal? MarketValueHeld = default(decimal?), decimal? NotionalValue = default(decimal?), DateTime? Maturity = default(DateTime?), decimal? QuantityHeld = default(decimal?), decimal? Weighting = default(decimal?), decimal? QuantityUnits = default(decimal?), decimal? QuantityPerShare = default(decimal?), DateTime? ContractExpiryDate = default(DateTime?))
        {
            this.AsOfDate = AsOfDate;
            this.Name = Name;
            this.Ticker = Ticker;
            this.Type = Type;
            this.CompositeFigi = CompositeFigi;
            this.ShareClassFigi = ShareClassFigi;
            this.Isin = Isin;
            this.Ric = Ric;
            this.Sedol = Sedol;
            this.Face = Face;
            this.Coupon = Coupon;
            this.MarketValueHeld = MarketValueHeld;
            this.NotionalValue = NotionalValue;
            this.Maturity = Maturity;
            this.QuantityHeld = QuantityHeld;
            this.Weighting = Weighting;
            this.QuantityUnits = QuantityUnits;
            this.QuantityPerShare = QuantityPerShare;
            this.ContractExpiryDate = ContractExpiryDate;
        }
        
        /// <summary>
        /// The date on which the holding and their weights correspond
        /// </summary>
        /// <value>The date on which the holding and their weights correspond</value>
        [DataMember(Name="as_of_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AsOfDate { get; set; }

        /// <summary>
        /// The common name for the holding
        /// </summary>
        /// <value>The common name for the holding</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The common exchange ticker for the holding
        /// </summary>
        /// <value>The common exchange ticker for the holding</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;EQUI&#39;, Options &#x3D; &#39;OPTN&#39;)
        /// </summary>
        /// <value>The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;EQUI&#39;, Options &#x3D; &#39;OPTN&#39;)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// DEPRECATED
        /// </summary>
        /// <value>DEPRECATED</value>
        [DataMember(Name="composite_figi", EmitDefaultValue=false)]
        public string CompositeFigi { get; set; }

        /// <summary>
        /// The OpenFIGI symbol for the holding
        /// </summary>
        /// <value>The OpenFIGI symbol for the holding</value>
        [DataMember(Name="share_class_figi", EmitDefaultValue=false)]
        public string ShareClassFigi { get; set; }

        /// <summary>
        /// International Securities Identification Number (ISIN) for the holding
        /// </summary>
        /// <value>International Securities Identification Number (ISIN) for the holding</value>
        [DataMember(Name="isin", EmitDefaultValue=false)]
        public string Isin { get; set; }

        /// <summary>
        /// Reuters Instrument Code (RIC) for the holding
        /// </summary>
        /// <value>Reuters Instrument Code (RIC) for the holding</value>
        [DataMember(Name="ric", EmitDefaultValue=false)]
        public string Ric { get; set; }

        /// <summary>
        /// Stock Exchange Daily Official List (SEDOL) for the holding
        /// </summary>
        /// <value>Stock Exchange Daily Official List (SEDOL) for the holding</value>
        [DataMember(Name="sedol", EmitDefaultValue=false)]
        public string Sedol { get; set; }

        /// <summary>
        /// Face value of the debt security, if available
        /// </summary>
        /// <value>Face value of the debt security, if available</value>
        [DataMember(Name="face", EmitDefaultValue=false)]
        public decimal? Face { get; set; }

        /// <summary>
        /// Coupon rate of the debt security, if available
        /// </summary>
        /// <value>Coupon rate of the debt security, if available</value>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        public decimal? Coupon { get; set; }

        /// <summary>
        /// The market value of this holding in the ETF as of the &#x60;as_of_date&#x60;
        /// </summary>
        /// <value>The market value of this holding in the ETF as of the &#x60;as_of_date&#x60;</value>
        [DataMember(Name="market_value_held", EmitDefaultValue=false)]
        public decimal? MarketValueHeld { get; set; }

        /// <summary>
        /// Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)
        /// </summary>
        /// <value>Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)</value>
        [DataMember(Name="notional_value", EmitDefaultValue=false)]
        public decimal? NotionalValue { get; set; }

        /// <summary>
        /// Maturity date for the debt security, if available
        /// </summary>
        /// <value>Maturity date for the debt security, if available</value>
        [DataMember(Name="maturity", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Maturity { get; set; }

        /// <summary>
        /// Number of units of the security held if available
        /// </summary>
        /// <value>Number of units of the security held if available</value>
        [DataMember(Name="quantity_held", EmitDefaultValue=false)]
        public decimal? QuantityHeld { get; set; }

        /// <summary>
        /// Fraction of the funds market value held
        /// </summary>
        /// <value>Fraction of the funds market value held</value>
        [DataMember(Name="weighting", EmitDefaultValue=false)]
        public decimal? Weighting { get; set; }

        /// <summary>
        /// The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;, &#39;contracts&#39;)
        /// </summary>
        /// <value>The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;, &#39;contracts&#39;)</value>
        [DataMember(Name="quantity_units", EmitDefaultValue=false)]
        public decimal? QuantityUnits { get; set; }

        /// <summary>
        /// Number of units of the security held per units of shares outstanding of the Exchange Traded Fund (ETF), if available
        /// </summary>
        /// <value>Number of units of the security held per units of shares outstanding of the Exchange Traded Fund (ETF), if available</value>
        [DataMember(Name="quantity_per_share", EmitDefaultValue=false)]
        public decimal? QuantityPerShare { get; set; }

        /// <summary>
        /// Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)
        /// </summary>
        /// <value>Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)</value>
        [DataMember(Name="contract_expiry_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ContractExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFHolding {\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
            sb.Append("  ShareClassFigi: ").Append(ShareClassFigi).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  Ric: ").Append(Ric).Append("\n");
            sb.Append("  Sedol: ").Append(Sedol).Append("\n");
            sb.Append("  Face: ").Append(Face).Append("\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  MarketValueHeld: ").Append(MarketValueHeld).Append("\n");
            sb.Append("  NotionalValue: ").Append(NotionalValue).Append("\n");
            sb.Append("  Maturity: ").Append(Maturity).Append("\n");
            sb.Append("  QuantityHeld: ").Append(QuantityHeld).Append("\n");
            sb.Append("  Weighting: ").Append(Weighting).Append("\n");
            sb.Append("  QuantityUnits: ").Append(QuantityUnits).Append("\n");
            sb.Append("  QuantityPerShare: ").Append(QuantityPerShare).Append("\n");
            sb.Append("  ContractExpiryDate: ").Append(ContractExpiryDate).Append("\n");
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
            return this.Equals(input as ETFHolding);
        }

        /// <summary>
        /// Returns true if ETFHolding instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFHolding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFHolding input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.Isin == input.Isin ||
                    (this.Isin != null &&
                    this.Isin.Equals(input.Isin))
                ) && 
                (
                    this.Ric == input.Ric ||
                    (this.Ric != null &&
                    this.Ric.Equals(input.Ric))
                ) && 
                (
                    this.Sedol == input.Sedol ||
                    (this.Sedol != null &&
                    this.Sedol.Equals(input.Sedol))
                ) && 
                (
                    this.Face == input.Face ||
                    (this.Face != null &&
                    this.Face.Equals(input.Face))
                ) && 
                (
                    this.Coupon == input.Coupon ||
                    (this.Coupon != null &&
                    this.Coupon.Equals(input.Coupon))
                ) && 
                (
                    this.MarketValueHeld == input.MarketValueHeld ||
                    (this.MarketValueHeld != null &&
                    this.MarketValueHeld.Equals(input.MarketValueHeld))
                ) && 
                (
                    this.NotionalValue == input.NotionalValue ||
                    (this.NotionalValue != null &&
                    this.NotionalValue.Equals(input.NotionalValue))
                ) && 
                (
                    this.Maturity == input.Maturity ||
                    (this.Maturity != null &&
                    this.Maturity.Equals(input.Maturity))
                ) && 
                (
                    this.QuantityHeld == input.QuantityHeld ||
                    (this.QuantityHeld != null &&
                    this.QuantityHeld.Equals(input.QuantityHeld))
                ) && 
                (
                    this.Weighting == input.Weighting ||
                    (this.Weighting != null &&
                    this.Weighting.Equals(input.Weighting))
                ) && 
                (
                    this.QuantityUnits == input.QuantityUnits ||
                    (this.QuantityUnits != null &&
                    this.QuantityUnits.Equals(input.QuantityUnits))
                ) && 
                (
                    this.QuantityPerShare == input.QuantityPerShare ||
                    (this.QuantityPerShare != null &&
                    this.QuantityPerShare.Equals(input.QuantityPerShare))
                ) && 
                (
                    this.ContractExpiryDate == input.ContractExpiryDate ||
                    (this.ContractExpiryDate != null &&
                    this.ContractExpiryDate.Equals(input.ContractExpiryDate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CompositeFigi != null)
                    hashCode = hashCode * 59 + this.CompositeFigi.GetHashCode();
                if (this.ShareClassFigi != null)
                    hashCode = hashCode * 59 + this.ShareClassFigi.GetHashCode();
                if (this.Isin != null)
                    hashCode = hashCode * 59 + this.Isin.GetHashCode();
                if (this.Ric != null)
                    hashCode = hashCode * 59 + this.Ric.GetHashCode();
                if (this.Sedol != null)
                    hashCode = hashCode * 59 + this.Sedol.GetHashCode();
                if (this.Face != null)
                    hashCode = hashCode * 59 + this.Face.GetHashCode();
                if (this.Coupon != null)
                    hashCode = hashCode * 59 + this.Coupon.GetHashCode();
                if (this.MarketValueHeld != null)
                    hashCode = hashCode * 59 + this.MarketValueHeld.GetHashCode();
                if (this.NotionalValue != null)
                    hashCode = hashCode * 59 + this.NotionalValue.GetHashCode();
                if (this.Maturity != null)
                    hashCode = hashCode * 59 + this.Maturity.GetHashCode();
                if (this.QuantityHeld != null)
                    hashCode = hashCode * 59 + this.QuantityHeld.GetHashCode();
                if (this.Weighting != null)
                    hashCode = hashCode * 59 + this.Weighting.GetHashCode();
                if (this.QuantityUnits != null)
                    hashCode = hashCode * 59 + this.QuantityUnits.GetHashCode();
                if (this.QuantityPerShare != null)
                    hashCode = hashCode * 59 + this.QuantityPerShare.GetHashCode();
                if (this.ContractExpiryDate != null)
                    hashCode = hashCode * 59 + this.ContractExpiryDate.GetHashCode();
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



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
    /// Exchange Traded Fund (ETF) sourced from FirstBridge
    /// </summary>
    [DataContract]
    public partial class ETFSummary :  IEquatable<ETFSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the ETF.</param>
        /// <param name="Name">The common name of the ETF.</param>
        /// <param name="Ticker">The common ticker symbol for the ETF.</param>
        /// <param name="FigiTicker">The OpenFIGI ticker for the ETF.</param>
        /// <param name="Ric">Reuters Instrument Code (RIC) for the ETF.</param>
        /// <param name="Isin">International Securities Identification Number (ISIN) for the ETF.</param>
        /// <param name="Sedol">Stock Exchange Daily Official List (SEDOL) for the ETF.</param>
        /// <param name="ExchangeMic">The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO).</param>
        public ETFSummary(string Id = default(string), string Name = default(string), string Ticker = default(string), string FigiTicker = default(string), string Ric = default(string), string Isin = default(string), string Sedol = default(string), string ExchangeMic = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Ticker = Ticker;
            this.FigiTicker = FigiTicker;
            this.Ric = Ric;
            this.Isin = Isin;
            this.Sedol = Sedol;
            this.ExchangeMic = ExchangeMic;
        }
        
        /// <summary>
        /// The Intrinio ID of the ETF
        /// </summary>
        /// <value>The Intrinio ID of the ETF</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The common name of the ETF
        /// </summary>
        /// <value>The common name of the ETF</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The common ticker symbol for the ETF
        /// </summary>
        /// <value>The common ticker symbol for the ETF</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The OpenFIGI ticker for the ETF
        /// </summary>
        /// <value>The OpenFIGI ticker for the ETF</value>
        [DataMember(Name="figi_ticker", EmitDefaultValue=false)]
        public string FigiTicker { get; set; }

        /// <summary>
        /// Reuters Instrument Code (RIC) for the ETF
        /// </summary>
        /// <value>Reuters Instrument Code (RIC) for the ETF</value>
        [DataMember(Name="ric", EmitDefaultValue=false)]
        public string Ric { get; set; }

        /// <summary>
        /// International Securities Identification Number (ISIN) for the ETF
        /// </summary>
        /// <value>International Securities Identification Number (ISIN) for the ETF</value>
        [DataMember(Name="isin", EmitDefaultValue=false)]
        public string Isin { get; set; }

        /// <summary>
        /// Stock Exchange Daily Official List (SEDOL) for the ETF
        /// </summary>
        /// <value>Stock Exchange Daily Official List (SEDOL) for the ETF</value>
        [DataMember(Name="sedol", EmitDefaultValue=false)]
        public string Sedol { get; set; }

        /// <summary>
        /// The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO)
        /// </summary>
        /// <value>The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO)</value>
        [DataMember(Name="exchange_mic", EmitDefaultValue=false)]
        public string ExchangeMic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  FigiTicker: ").Append(FigiTicker).Append("\n");
            sb.Append("  Ric: ").Append(Ric).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  Sedol: ").Append(Sedol).Append("\n");
            sb.Append("  ExchangeMic: ").Append(ExchangeMic).Append("\n");
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
            return this.Equals(input as ETFSummary);
        }

        /// <summary>
        /// Returns true if ETFSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFSummary input)
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
                    this.FigiTicker == input.FigiTicker ||
                    (this.FigiTicker != null &&
                    this.FigiTicker.Equals(input.FigiTicker))
                ) && 
                (
                    this.Ric == input.Ric ||
                    (this.Ric != null &&
                    this.Ric.Equals(input.Ric))
                ) && 
                (
                    this.Isin == input.Isin ||
                    (this.Isin != null &&
                    this.Isin.Equals(input.Isin))
                ) && 
                (
                    this.Sedol == input.Sedol ||
                    (this.Sedol != null &&
                    this.Sedol.Equals(input.Sedol))
                ) && 
                (
                    this.ExchangeMic == input.ExchangeMic ||
                    (this.ExchangeMic != null &&
                    this.ExchangeMic.Equals(input.ExchangeMic))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.FigiTicker != null)
                    hashCode = hashCode * 59 + this.FigiTicker.GetHashCode();
                if (this.Ric != null)
                    hashCode = hashCode * 59 + this.Ric.GetHashCode();
                if (this.Isin != null)
                    hashCode = hashCode * 59 + this.Isin.GetHashCode();
                if (this.Sedol != null)
                    hashCode = hashCode * 59 + this.Sedol.GetHashCode();
                if (this.ExchangeMic != null)
                    hashCode = hashCode * 59 + this.ExchangeMic.GetHashCode();
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

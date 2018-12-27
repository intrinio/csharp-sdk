

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
    /// The Security of the stock price
    /// </summary>
    [DataContract]
    public partial class RealtimeStockPriceSecurity :  IEquatable<RealtimeStockPriceSecurity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeStockPriceSecurity" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for Security.</param>
        /// <param name="Ticker">The common/local ticker of the Security.</param>
        /// <param name="ExchangeTicker">The exchange-level ticker.</param>
        /// <param name="Figi">The OpenFIGI identifier.</param>
        /// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
        public RealtimeStockPriceSecurity(string Id = default(string), string Ticker = default(string), string ExchangeTicker = default(string), string Figi = default(string), string CompositeFigi = default(string))
        {
            this.Id = Id;
            this.Ticker = Ticker;
            this.ExchangeTicker = ExchangeTicker;
            this.Figi = Figi;
            this.CompositeFigi = CompositeFigi;
        }
        
        /// <summary>
        /// The Intrinio ID for Security
        /// </summary>
        /// <value>The Intrinio ID for Security</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The common/local ticker of the Security
        /// </summary>
        /// <value>The common/local ticker of the Security</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The exchange-level ticker
        /// </summary>
        /// <value>The exchange-level ticker</value>
        [DataMember(Name="exchange_ticker", EmitDefaultValue=false)]
        public string ExchangeTicker { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeStockPriceSecurity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  ExchangeTicker: ").Append(ExchangeTicker).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
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
            return this.Equals(input as RealtimeStockPriceSecurity);
        }

        /// <summary>
        /// Returns true if RealtimeStockPriceSecurity instances are equal
        /// </summary>
        /// <param name="input">Instance of RealtimeStockPriceSecurity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealtimeStockPriceSecurity input)
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
                    this.ExchangeTicker == input.ExchangeTicker ||
                    (this.ExchangeTicker != null &&
                    this.ExchangeTicker.Equals(input.ExchangeTicker))
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
                if (this.ExchangeTicker != null)
                    hashCode = hashCode * 59 + this.ExchangeTicker.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.CompositeFigi != null)
                    hashCode = hashCode * 59 + this.CompositeFigi.GetHashCode();
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

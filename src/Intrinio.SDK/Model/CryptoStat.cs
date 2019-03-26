

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
    /// Marketwide stats for a Crypto Currency including market cap, available supply, total supply, and max supply
    /// </summary>
    [DataContract]
    public partial class CryptoStat :  IEquatable<CryptoStat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoStat" /> class.
        /// </summary>
        /// <param name="Name">The common name of the crypto currency..</param>
        /// <param name="Code">A code representing the crypto currency..</param>
        /// <param name="Symbol">The symbol of the Crypto Currency..</param>
        /// <param name="MarketCapUsd">The market cap of the Crypto Currency in USD..</param>
        /// <param name="AvailableSupply">The available supply of the Crypto Currency..</param>
        /// <param name="TotalSupply">The total supply of the Crypto Currency..</param>
        /// <param name="MaxSupply">The maxmium supply of coins available to mine..</param>
        /// <param name="LastUpdated">UTC timestamp of when the data was last updated..</param>
        public CryptoStat(string Name = default(string), string Code = default(string), string Symbol = default(string), decimal? MarketCapUsd = default(decimal?), decimal? AvailableSupply = default(decimal?), decimal? TotalSupply = default(decimal?), decimal? MaxSupply = default(decimal?), string LastUpdated = default(string))
        {
            this.Name = Name;
            this.Code = Code;
            this.Symbol = Symbol;
            this.MarketCapUsd = MarketCapUsd;
            this.AvailableSupply = AvailableSupply;
            this.TotalSupply = TotalSupply;
            this.MaxSupply = MaxSupply;
            this.LastUpdated = LastUpdated;
        }
        
        /// <summary>
        /// The common name of the crypto currency.
        /// </summary>
        /// <value>The common name of the crypto currency.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A code representing the crypto currency.
        /// </summary>
        /// <value>A code representing the crypto currency.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The symbol of the Crypto Currency.
        /// </summary>
        /// <value>The symbol of the Crypto Currency.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The market cap of the Crypto Currency in USD.
        /// </summary>
        /// <value>The market cap of the Crypto Currency in USD.</value>
        [DataMember(Name="market_cap_usd", EmitDefaultValue=false)]
        public decimal? MarketCapUsd { get; set; }

        /// <summary>
        /// The available supply of the Crypto Currency.
        /// </summary>
        /// <value>The available supply of the Crypto Currency.</value>
        [DataMember(Name="available_supply", EmitDefaultValue=false)]
        public decimal? AvailableSupply { get; set; }

        /// <summary>
        /// The total supply of the Crypto Currency.
        /// </summary>
        /// <value>The total supply of the Crypto Currency.</value>
        [DataMember(Name="total_supply", EmitDefaultValue=false)]
        public decimal? TotalSupply { get; set; }

        /// <summary>
        /// The maxmium supply of coins available to mine.
        /// </summary>
        /// <value>The maxmium supply of coins available to mine.</value>
        [DataMember(Name="max_supply", EmitDefaultValue=false)]
        public decimal? MaxSupply { get; set; }

        /// <summary>
        /// UTC timestamp of when the data was last updated.
        /// </summary>
        /// <value>UTC timestamp of when the data was last updated.</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoStat {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  MarketCapUsd: ").Append(MarketCapUsd).Append("\n");
            sb.Append("  AvailableSupply: ").Append(AvailableSupply).Append("\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
            sb.Append("  MaxSupply: ").Append(MaxSupply).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as CryptoStat);
        }

        /// <summary>
        /// Returns true if CryptoStat instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoStat input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.MarketCapUsd == input.MarketCapUsd ||
                    (this.MarketCapUsd != null &&
                    this.MarketCapUsd.Equals(input.MarketCapUsd))
                ) && 
                (
                    this.AvailableSupply == input.AvailableSupply ||
                    (this.AvailableSupply != null &&
                    this.AvailableSupply.Equals(input.AvailableSupply))
                ) && 
                (
                    this.TotalSupply == input.TotalSupply ||
                    (this.TotalSupply != null &&
                    this.TotalSupply.Equals(input.TotalSupply))
                ) && 
                (
                    this.MaxSupply == input.MaxSupply ||
                    (this.MaxSupply != null &&
                    this.MaxSupply.Equals(input.MaxSupply))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.MarketCapUsd != null)
                    hashCode = hashCode * 59 + this.MarketCapUsd.GetHashCode();
                if (this.AvailableSupply != null)
                    hashCode = hashCode * 59 + this.AvailableSupply.GetHashCode();
                if (this.TotalSupply != null)
                    hashCode = hashCode * 59 + this.TotalSupply.GetHashCode();
                if (this.MaxSupply != null)
                    hashCode = hashCode * 59 + this.MaxSupply.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
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

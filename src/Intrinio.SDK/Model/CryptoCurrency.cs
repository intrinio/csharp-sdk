

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
    /// A Crypto Currency is a digital or virtual currency that uses cryptography for security. They trade as Crypto Currency Pairs with fiat currencies (USD) or other Crypto Currences (ETH) on Crypto Exchanges, similar to Forex. Included are the name, code, symbol, and the first and last dates for which price data is available for the given Crypto Currency.
    /// </summary>
    [DataContract]
    public partial class CryptoCurrency :  IEquatable<CryptoCurrency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoCurrency" /> class.
        /// </summary>
        /// <param name="Name">The common name of the crypto currency..</param>
        /// <param name="Code">A code representing the crypto currency..</param>
        /// <param name="Symbol">The symbol of the Crypto Currency..</param>
        /// <param name="FirstPriceDate">The earliest date that daily historical pricing is available for..</param>
        /// <param name="LastPriceDate">The most recent date that daily historical pricing is available for..</param>
        public CryptoCurrency(string Name = default(string), string Code = default(string), string Symbol = default(string), string FirstPriceDate = default(string), string LastPriceDate = default(string))
        {
            this.Name = Name;
            this.Code = Code;
            this.Symbol = Symbol;
            this.FirstPriceDate = FirstPriceDate;
            this.LastPriceDate = LastPriceDate;
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
        /// The earliest date that daily historical pricing is available for.
        /// </summary>
        /// <value>The earliest date that daily historical pricing is available for.</value>
        [DataMember(Name="first_price_date", EmitDefaultValue=false)]
        public string FirstPriceDate { get; set; }

        /// <summary>
        /// The most recent date that daily historical pricing is available for.
        /// </summary>
        /// <value>The most recent date that daily historical pricing is available for.</value>
        [DataMember(Name="last_price_date", EmitDefaultValue=false)]
        public string LastPriceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoCurrency {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  FirstPriceDate: ").Append(FirstPriceDate).Append("\n");
            sb.Append("  LastPriceDate: ").Append(LastPriceDate).Append("\n");
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
            return this.Equals(input as CryptoCurrency);
        }

        /// <summary>
        /// Returns true if CryptoCurrency instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoCurrency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoCurrency input)
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
                    this.FirstPriceDate == input.FirstPriceDate ||
                    (this.FirstPriceDate != null &&
                    this.FirstPriceDate.Equals(input.FirstPriceDate))
                ) && 
                (
                    this.LastPriceDate == input.LastPriceDate ||
                    (this.LastPriceDate != null &&
                    this.LastPriceDate.Equals(input.LastPriceDate))
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
                if (this.FirstPriceDate != null)
                    hashCode = hashCode * 59 + this.FirstPriceDate.GetHashCode();
                if (this.LastPriceDate != null)
                    hashCode = hashCode * 59 + this.LastPriceDate.GetHashCode();
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



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
    /// ApiResponseCryptoBookAsks
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoBookAsks :  IEquatable<ApiResponseCryptoBookAsks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoBookAsks" /> class.
        /// </summary>
        /// <param name="Asks">The ask prices and their respective sizes, in ascending order of price..</param>
        /// <param name="Pair">Pair.</param>
        /// <param name="Exchange">Exchange.</param>
        /// <param name="LastUpdated">The UTC timestamp of when the order book was last updated..</param>
        public ApiResponseCryptoBookAsks(List<CryptoBookEntry> Asks = default(List<CryptoBookEntry>), CryptoPairSummary Pair = default(CryptoPairSummary), CryptoExchangeSummary Exchange = default(CryptoExchangeSummary), string LastUpdated = default(string))
        {
            this.Asks = Asks;
            this.Pair = Pair;
            this.Exchange = Exchange;
            this.LastUpdated = LastUpdated;
        }
        
        /// <summary>
        /// The ask prices and their respective sizes, in ascending order of price.
        /// </summary>
        /// <value>The ask prices and their respective sizes, in ascending order of price.</value>
        [DataMember(Name="asks", EmitDefaultValue=false)]
        public List<CryptoBookEntry> Asks { get; set; }

        /// <summary>
        /// Gets or Sets Pair
        /// </summary>
        [DataMember(Name="pair", EmitDefaultValue=false)]
        public CryptoPairSummary Pair { get; set; }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public CryptoExchangeSummary Exchange { get; set; }

        /// <summary>
        /// The UTC timestamp of when the order book was last updated.
        /// </summary>
        /// <value>The UTC timestamp of when the order book was last updated.</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoBookAsks {\n");
            sb.Append("  Asks: ").Append(Asks).Append("\n");
            sb.Append("  Pair: ").Append(Pair).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoBookAsks);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoBookAsks instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoBookAsks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoBookAsks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Asks == input.Asks ||
                    this.Asks != null &&
                    this.Asks.SequenceEqual(input.Asks)
                ) && 
                (
                    this.Pair == input.Pair ||
                    (this.Pair != null &&
                    this.Pair.Equals(input.Pair))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
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
                if (this.Asks != null)
                    hashCode = hashCode * 59 + this.Asks.GetHashCode();
                if (this.Pair != null)
                    hashCode = hashCode * 59 + this.Pair.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
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

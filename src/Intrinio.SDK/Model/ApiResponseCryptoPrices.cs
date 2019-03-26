

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
    /// ApiResponseCryptoPrices
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoPrices :  IEquatable<ApiResponseCryptoPrices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoPrices" /> class.
        /// </summary>
        /// <param name="Prices">All the BAR prices, time, and volume..</param>
        /// <param name="Pair">Pair.</param>
        /// <param name="Exchange">Exchange.</param>
        /// <param name="Timeframe">The time interval for the crypto currency prices..</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseCryptoPrices(List<CryptoPrice> Prices = default(List<CryptoPrice>), CryptoPairSummary Pair = default(CryptoPairSummary), CryptoExchangeSummary Exchange = default(CryptoExchangeSummary), string Timeframe = default(string), string NextPage = default(string))
        {
            this.Prices = Prices;
            this.Pair = Pair;
            this.Exchange = Exchange;
            this.Timeframe = Timeframe;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// All the BAR prices, time, and volume.
        /// </summary>
        /// <value>All the BAR prices, time, and volume.</value>
        [DataMember(Name="prices", EmitDefaultValue=false)]
        public List<CryptoPrice> Prices { get; set; }

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
        /// The time interval for the crypto currency prices.
        /// </summary>
        /// <value>The time interval for the crypto currency prices.</value>
        [DataMember(Name="timeframe", EmitDefaultValue=false)]
        public string Timeframe { get; set; }

        /// <summary>
        /// The token required to request the next page of the data
        /// </summary>
        /// <value>The token required to request the next page of the data</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoPrices {\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  Pair: ").Append(Pair).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Timeframe: ").Append(Timeframe).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoPrices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
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
                    this.Timeframe == input.Timeframe ||
                    (this.Timeframe != null &&
                    this.Timeframe.Equals(input.Timeframe))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.Prices != null)
                    hashCode = hashCode * 59 + this.Prices.GetHashCode();
                if (this.Pair != null)
                    hashCode = hashCode * 59 + this.Pair.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.Timeframe != null)
                    hashCode = hashCode * 59 + this.Timeframe.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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

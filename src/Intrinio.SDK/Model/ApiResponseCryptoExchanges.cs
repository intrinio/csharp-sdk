

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
    /// ApiResponseCryptoExchanges
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoExchanges :  IEquatable<ApiResponseCryptoExchanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoExchanges" /> class.
        /// </summary>
        /// <param name="Exchanges">A list of Crypto Exchanges for the given Crypto Currency Pair sorted alphabetically by code..</param>
        public ApiResponseCryptoExchanges(List<CryptoExchange> Exchanges = default(List<CryptoExchange>))
        {
            this.Exchanges = Exchanges;
        }
        
        /// <summary>
        /// A list of Crypto Exchanges for the given Crypto Currency Pair sorted alphabetically by code.
        /// </summary>
        /// <value>A list of Crypto Exchanges for the given Crypto Currency Pair sorted alphabetically by code.</value>
        [DataMember(Name="exchanges", EmitDefaultValue=false)]
        public List<CryptoExchange> Exchanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoExchanges {\n");
            sb.Append("  Exchanges: ").Append(Exchanges).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoExchanges);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoExchanges instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoExchanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoExchanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exchanges == input.Exchanges ||
                    this.Exchanges != null &&
                    this.Exchanges.SequenceEqual(input.Exchanges)
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
                if (this.Exchanges != null)
                    hashCode = hashCode * 59 + this.Exchanges.GetHashCode();
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

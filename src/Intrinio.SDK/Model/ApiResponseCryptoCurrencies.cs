

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
    /// ApiResponseCryptoCurrencies
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoCurrencies :  IEquatable<ApiResponseCryptoCurrencies>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoCurrencies" /> class.
        /// </summary>
        /// <param name="Currencies">A list of Crypto Currencies for the given Crypto Exchange sorted by alphabetically by symbol..</param>
        public ApiResponseCryptoCurrencies(List<CryptoCurrency> Currencies = default(List<CryptoCurrency>))
        {
            this.Currencies = Currencies;
        }
        
        /// <summary>
        /// A list of Crypto Currencies for the given Crypto Exchange sorted by alphabetically by symbol.
        /// </summary>
        /// <value>A list of Crypto Currencies for the given Crypto Exchange sorted by alphabetically by symbol.</value>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<CryptoCurrency> Currencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoCurrencies {\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoCurrencies);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoCurrencies instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoCurrencies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoCurrencies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currencies == input.Currencies ||
                    this.Currencies != null &&
                    this.Currencies.SequenceEqual(input.Currencies)
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
                if (this.Currencies != null)
                    hashCode = hashCode * 59 + this.Currencies.GetHashCode();
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

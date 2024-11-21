

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
    /// ApiResponseForexCurrencies
    /// </summary>
    [DataContract]
    public partial class ApiResponseForexCurrencies :  IEquatable<ApiResponseForexCurrencies>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseForexCurrencies" /> class.
        /// </summary>
        /// <param name="Currencies">Currencies.</param>
        public ApiResponseForexCurrencies(List<ForexCurrency> Currencies = default(List<ForexCurrency>))
        {
            this.Currencies = Currencies;
        }
        
        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<ForexCurrency> Currencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseForexCurrencies {\n");
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
            return this.Equals(input as ApiResponseForexCurrencies);
        }

        /// <summary>
        /// Returns true if ApiResponseForexCurrencies instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseForexCurrencies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseForexCurrencies input)
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



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
    /// ApiResponseStockExchangeQuote
    /// </summary>
    [DataContract]
    public partial class ApiResponseStockExchangeQuote :  IEquatable<ApiResponseStockExchangeQuote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStockExchangeQuote" /> class.
        /// </summary>
        /// <param name="Quotes">The realtime stock prices for all Securities traded on the Stock Exchange.</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        public ApiResponseStockExchangeQuote(List<ApiResponseSecurityQuote> Quotes = default(List<ApiResponseSecurityQuote>), StockExchange StockExchange = default(StockExchange))
        {
            this.Quotes = Quotes;
            this.StockExchange = StockExchange;
        }
        
        /// <summary>
        /// The realtime stock prices for all Securities traded on the Stock Exchange
        /// </summary>
        /// <value>The realtime stock prices for all Securities traded on the Stock Exchange</value>
        [DataMember(Name="quotes", EmitDefaultValue=false)]
        public List<ApiResponseSecurityQuote> Quotes { get; set; }

        /// <summary>
        /// The Stock Exchange resolved from the given identifier
        /// </summary>
        /// <value>The Stock Exchange resolved from the given identifier</value>
        [DataMember(Name="stock_exchange", EmitDefaultValue=false)]
        public StockExchange StockExchange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseStockExchangeQuote {\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
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
            return this.Equals(input as ApiResponseStockExchangeQuote);
        }

        /// <summary>
        /// Returns true if ApiResponseStockExchangeQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStockExchangeQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStockExchangeQuote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
                ) && 
                (
                    this.StockExchange == input.StockExchange ||
                    (this.StockExchange != null &&
                    this.StockExchange.Equals(input.StockExchange))
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
                if (this.Quotes != null)
                    hashCode = hashCode * 59 + this.Quotes.GetHashCode();
                if (this.StockExchange != null)
                    hashCode = hashCode * 59 + this.StockExchange.GetHashCode();
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

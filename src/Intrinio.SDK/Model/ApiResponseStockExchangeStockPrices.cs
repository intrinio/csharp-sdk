

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
    /// ApiResponseStockExchangeStockPrices
    /// </summary>
    [DataContract]
    public partial class ApiResponseStockExchangeStockPrices :  IEquatable<ApiResponseStockExchangeStockPrices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStockExchangeStockPrices" /> class.
        /// </summary>
        /// <param name="StockPrices">The stock prices for all Securities traded on the Stock Exchange on the given date.</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseStockExchangeStockPrices(List<StockPrice> StockPrices = default(List<StockPrice>), StockExchange StockExchange = default(StockExchange), string NextPage = default(string))
        {
            this.StockPrices = StockPrices;
            this.StockExchange = StockExchange;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The stock prices for all Securities traded on the Stock Exchange on the given date
        /// </summary>
        /// <value>The stock prices for all Securities traded on the Stock Exchange on the given date</value>
        [DataMember(Name="stock_prices", EmitDefaultValue=false)]
        public List<StockPrice> StockPrices { get; set; }

        /// <summary>
        /// The Stock Exchange resolved from the given identifier
        /// </summary>
        /// <value>The Stock Exchange resolved from the given identifier</value>
        [DataMember(Name="stock_exchange", EmitDefaultValue=false)]
        public StockExchange StockExchange { get; set; }

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
            sb.Append("class ApiResponseStockExchangeStockPrices {\n");
            sb.Append("  StockPrices: ").Append(StockPrices).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
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
            return this.Equals(input as ApiResponseStockExchangeStockPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseStockExchangeStockPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStockExchangeStockPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStockExchangeStockPrices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StockPrices == input.StockPrices ||
                    this.StockPrices != null &&
                    this.StockPrices.SequenceEqual(input.StockPrices)
                ) && 
                (
                    this.StockExchange == input.StockExchange ||
                    (this.StockExchange != null &&
                    this.StockExchange.Equals(input.StockExchange))
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
                if (this.StockPrices != null)
                    hashCode = hashCode * 59 + this.StockPrices.GetHashCode();
                if (this.StockExchange != null)
                    hashCode = hashCode * 59 + this.StockExchange.GetHashCode();
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

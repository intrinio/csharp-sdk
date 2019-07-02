

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
    /// ApiResponseStockExchangeRealtimeStockPrices
    /// </summary>
    [DataContract]
    public partial class ApiResponseStockExchangeRealtimeStockPrices :  IEquatable<ApiResponseStockExchangeRealtimeStockPrices>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStockExchangeRealtimeStockPrices" /> class.
        /// </summary>
        /// <param name="StockPrices">The realtime stock prices for all Securities traded on the Stock Exchange.</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseStockExchangeRealtimeStockPrices(List<RealtimeStockPrice> StockPrices = default(List<RealtimeStockPrice>), StockExchange StockExchange = default(StockExchange), string NextPage = default(string))
        {
            this.StockPrices = StockPrices;
            this.StockExchange = StockExchange;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The realtime stock prices for all Securities traded on the Stock Exchange
        /// </summary>
        /// <value>The realtime stock prices for all Securities traded on the Stock Exchange</value>
        [DataMember(Name="stock_prices", EmitDefaultValue=false)]
        public List<RealtimeStockPrice> StockPrices { get; set; }

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
            sb.Append("class ApiResponseStockExchangeRealtimeStockPrices {\n");
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
            return this.Equals(input as ApiResponseStockExchangeRealtimeStockPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseStockExchangeRealtimeStockPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStockExchangeRealtimeStockPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStockExchangeRealtimeStockPrices input)
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

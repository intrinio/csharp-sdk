

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// ApiResponseStockExchangeSecurities
    /// </summary>
    [DataContract]
    public partial class ApiResponseStockExchangeSecurities :  IEquatable<ApiResponseStockExchangeSecurities>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStockExchangeSecurities" /> class.
        /// </summary>
        /// <param name="Securities">The securities traded on the Stock Exchange.</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseStockExchangeSecurities(List<SecuritySummary> Securities = default(List<SecuritySummary>), StockExchange StockExchange = default(StockExchange), string NextPage = default(string))
        {
            this.Securities = Securities;
            this.StockExchange = StockExchange;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The securities traded on the Stock Exchange
        /// </summary>
        /// <value>The securities traded on the Stock Exchange</value>
        [DataMember(Name="securities", EmitDefaultValue=false)]
        public List<SecuritySummary> Securities { get; set; }

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
            sb.Append("class ApiResponseStockExchangeSecurities {\n");
            sb.Append("  Securities: ").Append(Securities).Append("\n");
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
            return this.Equals(input as ApiResponseStockExchangeSecurities);
        }

        /// <summary>
        /// Returns true if ApiResponseStockExchangeSecurities instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStockExchangeSecurities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStockExchangeSecurities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Securities == input.Securities ||
                    this.Securities != null &&
                    this.Securities.SequenceEqual(input.Securities)
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
                if (this.Securities != null)
                    hashCode = hashCode * 59 + this.Securities.GetHashCode();
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

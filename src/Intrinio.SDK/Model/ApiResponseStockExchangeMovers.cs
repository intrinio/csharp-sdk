

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
    /// ApiResponseStockExchangeMovers
    /// </summary>
    [DataContract]
    public partial class ApiResponseStockExchangeMovers :  IEquatable<ApiResponseStockExchangeMovers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStockExchangeMovers" /> class.
        /// </summary>
        /// <param name="Movers">The mover security..</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        public ApiResponseStockExchangeMovers(List<StockExchangeMover> Movers = default(List<StockExchangeMover>), StockExchange StockExchange = default(StockExchange))
        {
            this.Movers = Movers;
            this.StockExchange = StockExchange;
        }
        
        /// <summary>
        /// The mover security.
        /// </summary>
        /// <value>The mover security.</value>
        [DataMember(Name="movers", EmitDefaultValue=false)]
        public List<StockExchangeMover> Movers { get; set; }

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
            sb.Append("class ApiResponseStockExchangeMovers {\n");
            sb.Append("  Movers: ").Append(Movers).Append("\n");
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
            return this.Equals(input as ApiResponseStockExchangeMovers);
        }

        /// <summary>
        /// Returns true if ApiResponseStockExchangeMovers instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStockExchangeMovers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStockExchangeMovers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Movers == input.Movers ||
                    this.Movers != null &&
                    this.Movers.SequenceEqual(input.Movers)
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
                if (this.Movers != null)
                    hashCode = hashCode * 59 + this.Movers.GetHashCode();
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

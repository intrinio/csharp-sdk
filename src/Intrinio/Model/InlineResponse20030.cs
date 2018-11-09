

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
    /// InlineResponse20030
    /// </summary>
    [DataContract]
    public partial class InlineResponse20030 :  IEquatable<InlineResponse20030>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20030" /> class.
        /// </summary>
        /// <param name="StockPriceAdjustments">The stock price adjustments for all Securities traded on the Stock Exchange on the given date.</param>
        /// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public InlineResponse20030(List<StockPriceAdjustment> StockPriceAdjustments = default(List<StockPriceAdjustment>), StockExchange StockExchange = default(StockExchange), string NextPage = default(string))
        {
            this.StockPriceAdjustments = StockPriceAdjustments;
            this.StockExchange = StockExchange;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The stock price adjustments for all Securities traded on the Stock Exchange on the given date
        /// </summary>
        /// <value>The stock price adjustments for all Securities traded on the Stock Exchange on the given date</value>
        [DataMember(Name="stock_price_adjustments", EmitDefaultValue=false)]
        public List<StockPriceAdjustment> StockPriceAdjustments { get; set; }

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
            sb.Append("class InlineResponse20030 {\n");
            sb.Append("  StockPriceAdjustments: ").Append(StockPriceAdjustments).Append("\n");
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
            return this.Equals(input as InlineResponse20030);
        }

        /// <summary>
        /// Returns true if InlineResponse20030 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20030 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20030 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StockPriceAdjustments == input.StockPriceAdjustments ||
                    this.StockPriceAdjustments != null &&
                    this.StockPriceAdjustments.SequenceEqual(input.StockPriceAdjustments)
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
                if (this.StockPriceAdjustments != null)
                    hashCode = hashCode * 59 + this.StockPriceAdjustments.GetHashCode();
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

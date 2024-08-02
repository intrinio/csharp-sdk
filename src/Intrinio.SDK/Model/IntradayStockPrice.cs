

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
    /// An intraday stock price for a Security.
    /// </summary>
    [DataContract]
    public partial class IntradayStockPrice :  IEquatable<IntradayStockPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayStockPrice" /> class.
        /// </summary>
        /// <param name="Time">The timestamp that the &#x60;last_price&#x60; represents..</param>
        /// <param name="LastPrice">The price of the last trade..</param>
        /// <param name="AskPrice">The price of the top ask order..</param>
        /// <param name="AskSize">The size of the top ask order..</param>
        /// <param name="BidPrice">The price of the top bid order..</param>
        /// <param name="BidSize">The size of the top bid order..</param>
        /// <param name="Volume">The number of shares exchanged during the trading day on the exchange..</param>
        /// <param name="Source">The source of the data..</param>
        public IntradayStockPrice(DateTime? Time = default(DateTime?), decimal? LastPrice = default(decimal?), decimal? AskPrice = default(decimal?), decimal? AskSize = default(decimal?), decimal? BidPrice = default(decimal?), decimal? BidSize = default(decimal?), decimal? Volume = default(decimal?), string Source = default(string))
        {
            this.Time = Time;
            this.LastPrice = LastPrice;
            this.AskPrice = AskPrice;
            this.AskSize = AskSize;
            this.BidPrice = BidPrice;
            this.BidSize = BidSize;
            this.Volume = Volume;
            this.Source = Source;
        }
        
        /// <summary>
        /// The timestamp that the &#x60;last_price&#x60; represents.
        /// </summary>
        /// <value>The timestamp that the &#x60;last_price&#x60; represents.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// The price of the last trade.
        /// </summary>
        /// <value>The price of the last trade.</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The price of the top ask order.
        /// </summary>
        /// <value>The price of the top ask order.</value>
        [DataMember(Name="ask_price", EmitDefaultValue=false)]
        public decimal? AskPrice { get; set; }

        /// <summary>
        /// The size of the top ask order.
        /// </summary>
        /// <value>The size of the top ask order.</value>
        [DataMember(Name="ask_size", EmitDefaultValue=false)]
        public decimal? AskSize { get; set; }

        /// <summary>
        /// The price of the top bid order.
        /// </summary>
        /// <value>The price of the top bid order.</value>
        [DataMember(Name="bid_price", EmitDefaultValue=false)]
        public decimal? BidPrice { get; set; }

        /// <summary>
        /// The size of the top bid order.
        /// </summary>
        /// <value>The size of the top bid order.</value>
        [DataMember(Name="bid_size", EmitDefaultValue=false)]
        public decimal? BidSize { get; set; }

        /// <summary>
        /// The number of shares exchanged during the trading day on the exchange.
        /// </summary>
        /// <value>The number of shares exchanged during the trading day on the exchange.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The source of the data.
        /// </summary>
        /// <value>The source of the data.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayStockPrice {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as IntradayStockPrice);
        }

        /// <summary>
        /// Returns true if IntradayStockPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of IntradayStockPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayStockPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.LastPrice == input.LastPrice ||
                    (this.LastPrice != null &&
                    this.LastPrice.Equals(input.LastPrice))
                ) && 
                (
                    this.AskPrice == input.AskPrice ||
                    (this.AskPrice != null &&
                    this.AskPrice.Equals(input.AskPrice))
                ) && 
                (
                    this.AskSize == input.AskSize ||
                    (this.AskSize != null &&
                    this.AskSize.Equals(input.AskSize))
                ) && 
                (
                    this.BidPrice == input.BidPrice ||
                    (this.BidPrice != null &&
                    this.BidPrice.Equals(input.BidPrice))
                ) && 
                (
                    this.BidSize == input.BidSize ||
                    (this.BidSize != null &&
                    this.BidSize.Equals(input.BidSize))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.LastPrice != null)
                    hashCode = hashCode * 59 + this.LastPrice.GetHashCode();
                if (this.AskPrice != null)
                    hashCode = hashCode * 59 + this.AskPrice.GetHashCode();
                if (this.AskSize != null)
                    hashCode = hashCode * 59 + this.AskSize.GetHashCode();
                if (this.BidPrice != null)
                    hashCode = hashCode * 59 + this.BidPrice.GetHashCode();
                if (this.BidSize != null)
                    hashCode = hashCode * 59 + this.BidSize.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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

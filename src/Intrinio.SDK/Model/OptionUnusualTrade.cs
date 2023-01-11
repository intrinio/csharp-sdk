

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
    /// A large market order that is broken into a collection of smaller orders to take advantage of all contracts and prices offered across all exchanges.
    /// </summary>
    [DataContract]
    public partial class OptionUnusualTrade :  IEquatable<OptionUnusualTrade>, IValidatableObject
    {
        /// <summary>
        /// Bullish, Bearish, or Neutral Sentiment is estimated based on whether the trade was executed at the bid, ask, or mark price.
        /// </summary>
        /// <value>Bullish, Bearish, or Neutral Sentiment is estimated based on whether the trade was executed at the bid, ask, or mark price.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SentimentEnum
        {
            
            /// <summary>
            /// Enum Bullish for value: bullish
            /// </summary>
            [EnumMember(Value = "bullish")]
            Bullish = 1,
            
            /// <summary>
            /// Enum Bearish for value: bearish
            /// </summary>
            [EnumMember(Value = "bearish")]
            Bearish = 2,
            
            /// <summary>
            /// Enum Neutral for value: neutral
            /// </summary>
            [EnumMember(Value = "neutral")]
            Neutral = 3
        }

        /// <summary>
        /// Bullish, Bearish, or Neutral Sentiment is estimated based on whether the trade was executed at the bid, ask, or mark price.
        /// </summary>
        /// <value>Bullish, Bearish, or Neutral Sentiment is estimated based on whether the trade was executed at the bid, ask, or mark price.</value>
        [DataMember(Name="sentiment", EmitDefaultValue=false)]
        public SentimentEnum? Sentiment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionUnusualTrade" /> class.
        /// </summary>
        /// <param name="Symbol">The underlying option security symbol for the trade.</param>
        /// <param name="Timestamp">The UTC timestamp of order placement.</param>
        /// <param name="Type">The type of unusual trade.</param>
        /// <param name="TotalValue">The aggregated value of all option contract premiums included in the trade.</param>
        /// <param name="TotalSize">The total number of contracts involved in a single transaction.</param>
        /// <param name="AveragePrice">The average premium paid per option contract.</param>
        /// <param name="Contract">The option contract symbol.</param>
        /// <param name="AskAtExecution">Ask price at execution.</param>
        /// <param name="BidAtExecution">Bid price at execution.</param>
        /// <param name="Sentiment">Bullish, Bearish, or Neutral Sentiment is estimated based on whether the trade was executed at the bid, ask, or mark price..</param>
        /// <param name="UnderlyingPriceAtExecution">Price of the underlying security at execution of trade.</param>
        public OptionUnusualTrade(string Symbol = default(string), DateTime? Timestamp = default(DateTime?), string Type = default(string), decimal? TotalValue = default(decimal?), decimal? TotalSize = default(decimal?), decimal? AveragePrice = default(decimal?), string Contract = default(string), decimal? AskAtExecution = default(decimal?), decimal? BidAtExecution = default(decimal?), SentimentEnum? Sentiment = default(SentimentEnum?), decimal? UnderlyingPriceAtExecution = default(decimal?))
        {
            this.Symbol = Symbol;
            this.Timestamp = Timestamp;
            this.Type = Type;
            this.TotalValue = TotalValue;
            this.TotalSize = TotalSize;
            this.AveragePrice = AveragePrice;
            this.Contract = Contract;
            this.AskAtExecution = AskAtExecution;
            this.BidAtExecution = BidAtExecution;
            this.Sentiment = Sentiment;
            this.UnderlyingPriceAtExecution = UnderlyingPriceAtExecution;
        }
        
        /// <summary>
        /// The underlying option security symbol for the trade
        /// </summary>
        /// <value>The underlying option security symbol for the trade</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The UTC timestamp of order placement
        /// </summary>
        /// <value>The UTC timestamp of order placement</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of unusual trade
        /// </summary>
        /// <value>The type of unusual trade</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The aggregated value of all option contract premiums included in the trade
        /// </summary>
        /// <value>The aggregated value of all option contract premiums included in the trade</value>
        [DataMember(Name="total_value", EmitDefaultValue=false)]
        public decimal? TotalValue { get; set; }

        /// <summary>
        /// The total number of contracts involved in a single transaction
        /// </summary>
        /// <value>The total number of contracts involved in a single transaction</value>
        [DataMember(Name="total_size", EmitDefaultValue=false)]
        public decimal? TotalSize { get; set; }

        /// <summary>
        /// The average premium paid per option contract
        /// </summary>
        /// <value>The average premium paid per option contract</value>
        [DataMember(Name="average_price", EmitDefaultValue=false)]
        public decimal? AveragePrice { get; set; }

        /// <summary>
        /// The option contract symbol
        /// </summary>
        /// <value>The option contract symbol</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// Ask price at execution
        /// </summary>
        /// <value>Ask price at execution</value>
        [DataMember(Name="ask_at_execution", EmitDefaultValue=false)]
        public decimal? AskAtExecution { get; set; }

        /// <summary>
        /// Bid price at execution
        /// </summary>
        /// <value>Bid price at execution</value>
        [DataMember(Name="bid_at_execution", EmitDefaultValue=false)]
        public decimal? BidAtExecution { get; set; }


        /// <summary>
        /// Price of the underlying security at execution of trade
        /// </summary>
        /// <value>Price of the underlying security at execution of trade</value>
        [DataMember(Name="underlying_price_at_execution", EmitDefaultValue=false)]
        public decimal? UnderlyingPriceAtExecution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionUnusualTrade {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TotalValue: ").Append(TotalValue).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  AveragePrice: ").Append(AveragePrice).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  AskAtExecution: ").Append(AskAtExecution).Append("\n");
            sb.Append("  BidAtExecution: ").Append(BidAtExecution).Append("\n");
            sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
            sb.Append("  UnderlyingPriceAtExecution: ").Append(UnderlyingPriceAtExecution).Append("\n");
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
            return this.Equals(input as OptionUnusualTrade);
        }

        /// <summary>
        /// Returns true if OptionUnusualTrade instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionUnusualTrade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionUnusualTrade input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TotalValue == input.TotalValue ||
                    (this.TotalValue != null &&
                    this.TotalValue.Equals(input.TotalValue))
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
                ) && 
                (
                    this.AveragePrice == input.AveragePrice ||
                    (this.AveragePrice != null &&
                    this.AveragePrice.Equals(input.AveragePrice))
                ) && 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.AskAtExecution == input.AskAtExecution ||
                    (this.AskAtExecution != null &&
                    this.AskAtExecution.Equals(input.AskAtExecution))
                ) && 
                (
                    this.BidAtExecution == input.BidAtExecution ||
                    (this.BidAtExecution != null &&
                    this.BidAtExecution.Equals(input.BidAtExecution))
                ) && 
                (
                    this.Sentiment == input.Sentiment ||
                    (this.Sentiment != null &&
                    this.Sentiment.Equals(input.Sentiment))
                ) && 
                (
                    this.UnderlyingPriceAtExecution == input.UnderlyingPriceAtExecution ||
                    (this.UnderlyingPriceAtExecution != null &&
                    this.UnderlyingPriceAtExecution.Equals(input.UnderlyingPriceAtExecution))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TotalValue != null)
                    hashCode = hashCode * 59 + this.TotalValue.GetHashCode();
                if (this.TotalSize != null)
                    hashCode = hashCode * 59 + this.TotalSize.GetHashCode();
                if (this.AveragePrice != null)
                    hashCode = hashCode * 59 + this.AveragePrice.GetHashCode();
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.AskAtExecution != null)
                    hashCode = hashCode * 59 + this.AskAtExecution.GetHashCode();
                if (this.BidAtExecution != null)
                    hashCode = hashCode * 59 + this.BidAtExecution.GetHashCode();
                if (this.Sentiment != null)
                    hashCode = hashCode * 59 + this.Sentiment.GetHashCode();
                if (this.UnderlyingPriceAtExecution != null)
                    hashCode = hashCode * 59 + this.UnderlyingPriceAtExecution.GetHashCode();
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

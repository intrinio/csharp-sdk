

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
    /// A trade.
    /// </summary>
    [DataContract]
    public partial class OptionTrades :  IEquatable<OptionTrades>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionTrades" /> class.
        /// </summary>
        /// <param name="Contract">The option contract.</param>
        /// <param name="UnderlyingSymbol">The ticker symbol.</param>
        /// <param name="Timestamp">The UTC timestamp at the time of the trade..</param>
        /// <param name="Price">The price of the trade..</param>
        /// <param name="Size">The size of the trade..</param>
        /// <param name="TotalVolume">The total volume of the symbol for the day up to the timestamp point in time..</param>
        /// <param name="AskPriceAtExecution">The price of ask quote at the time of the trade..</param>
        /// <param name="BidPriceAtExecution">The price of bid quote at the time of the trade..</param>
        /// <param name="Exchange">The exchange for the trade..</param>
        /// <param name="Conditions">The condition of the trade..</param>
        /// <param name="SequenceId">The sequential ID for the trade, ordered as temporally received from the exchange..</param>
        public OptionTrades(string Contract = default(string), string UnderlyingSymbol = default(string), DateTime? Timestamp = default(DateTime?), decimal? Price = default(decimal?), decimal? Size = default(decimal?), decimal? TotalVolume = default(decimal?), decimal? AskPriceAtExecution = default(decimal?), decimal? BidPriceAtExecution = default(decimal?), string Exchange = default(string), string Conditions = default(string), decimal? SequenceId = default(decimal?))
        {
            this.Contract = Contract;
            this.UnderlyingSymbol = UnderlyingSymbol;
            this.Timestamp = Timestamp;
            this.Price = Price;
            this.Size = Size;
            this.TotalVolume = TotalVolume;
            this.AskPriceAtExecution = AskPriceAtExecution;
            this.BidPriceAtExecution = BidPriceAtExecution;
            this.Exchange = Exchange;
            this.Conditions = Conditions;
            this.SequenceId = SequenceId;
        }
        
        /// <summary>
        /// The option contract
        /// </summary>
        /// <value>The option contract</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public string Contract { get; set; }

        /// <summary>
        /// The ticker symbol
        /// </summary>
        /// <value>The ticker symbol</value>
        [DataMember(Name="underlying_symbol", EmitDefaultValue=false)]
        public string UnderlyingSymbol { get; set; }

        /// <summary>
        /// The UTC timestamp at the time of the trade.
        /// </summary>
        /// <value>The UTC timestamp at the time of the trade.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The price of the trade.
        /// </summary>
        /// <value>The price of the trade.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The size of the trade.
        /// </summary>
        /// <value>The size of the trade.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// The total volume of the symbol for the day up to the timestamp point in time.
        /// </summary>
        /// <value>The total volume of the symbol for the day up to the timestamp point in time.</value>
        [DataMember(Name="total_volume", EmitDefaultValue=false)]
        public decimal? TotalVolume { get; set; }

        /// <summary>
        /// The price of ask quote at the time of the trade.
        /// </summary>
        /// <value>The price of ask quote at the time of the trade.</value>
        [DataMember(Name="ask_price_at_execution", EmitDefaultValue=false)]
        public decimal? AskPriceAtExecution { get; set; }

        /// <summary>
        /// The price of bid quote at the time of the trade.
        /// </summary>
        /// <value>The price of bid quote at the time of the trade.</value>
        [DataMember(Name="bid_price_at_execution", EmitDefaultValue=false)]
        public decimal? BidPriceAtExecution { get; set; }

        /// <summary>
        /// The exchange for the trade.
        /// </summary>
        /// <value>The exchange for the trade.</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// The condition of the trade.
        /// </summary>
        /// <value>The condition of the trade.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// The sequential ID for the trade, ordered as temporally received from the exchange.
        /// </summary>
        /// <value>The sequential ID for the trade, ordered as temporally received from the exchange.</value>
        [DataMember(Name="sequence_id", EmitDefaultValue=false)]
        public decimal? SequenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionTrades {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  UnderlyingSymbol: ").Append(UnderlyingSymbol).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
            sb.Append("  AskPriceAtExecution: ").Append(AskPriceAtExecution).Append("\n");
            sb.Append("  BidPriceAtExecution: ").Append(BidPriceAtExecution).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  SequenceId: ").Append(SequenceId).Append("\n");
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
            return this.Equals(input as OptionTrades);
        }

        /// <summary>
        /// Returns true if OptionTrades instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionTrades to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionTrades input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.UnderlyingSymbol == input.UnderlyingSymbol ||
                    (this.UnderlyingSymbol != null &&
                    this.UnderlyingSymbol.Equals(input.UnderlyingSymbol))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.TotalVolume == input.TotalVolume ||
                    (this.TotalVolume != null &&
                    this.TotalVolume.Equals(input.TotalVolume))
                ) && 
                (
                    this.AskPriceAtExecution == input.AskPriceAtExecution ||
                    (this.AskPriceAtExecution != null &&
                    this.AskPriceAtExecution.Equals(input.AskPriceAtExecution))
                ) && 
                (
                    this.BidPriceAtExecution == input.BidPriceAtExecution ||
                    (this.BidPriceAtExecution != null &&
                    this.BidPriceAtExecution.Equals(input.BidPriceAtExecution))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    (this.Conditions != null &&
                    this.Conditions.Equals(input.Conditions))
                ) && 
                (
                    this.SequenceId == input.SequenceId ||
                    (this.SequenceId != null &&
                    this.SequenceId.Equals(input.SequenceId))
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
                if (this.Contract != null)
                    hashCode = hashCode * 59 + this.Contract.GetHashCode();
                if (this.UnderlyingSymbol != null)
                    hashCode = hashCode * 59 + this.UnderlyingSymbol.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TotalVolume != null)
                    hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
                if (this.AskPriceAtExecution != null)
                    hashCode = hashCode * 59 + this.AskPriceAtExecution.GetHashCode();
                if (this.BidPriceAtExecution != null)
                    hashCode = hashCode * 59 + this.BidPriceAtExecution.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.SequenceId != null)
                    hashCode = hashCode * 59 + this.SequenceId.GetHashCode();
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

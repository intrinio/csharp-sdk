

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
    /// An extended option price contains extended price information for a specific options contract.
    /// </summary>
    [DataContract]
    public partial class OptionPriceRealtimeExtended :  IEquatable<OptionPriceRealtimeExtended>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionPriceRealtimeExtended" /> class.
        /// </summary>
        /// <param name="BidOpen">The price of the bid at open.</param>
        /// <param name="BidHigh">The high bid so far today.</param>
        /// <param name="BidLow">The low bid so far today.</param>
        /// <param name="AskOpen">The price of the ask at open.</param>
        /// <param name="AskHigh">The high ask so far today.</param>
        /// <param name="AskLow">The low ask so far today.</param>
        /// <param name="TradeOpen">The price of the trade at open.</param>
        /// <param name="TradeHigh">The high trade so far today.</param>
        /// <param name="TradeLow">The low trade so far today.</param>
        /// <param name="AskClose">The price of ask at close today.</param>
        /// <param name="BidClose">The price of bid at close today.</param>
        /// <param name="TradeClose">The price of the last trade of the day.</param>
        /// <param name="Mark">The mark price.</param>
        public OptionPriceRealtimeExtended(decimal? BidOpen = default(decimal?), decimal? BidHigh = default(decimal?), decimal? BidLow = default(decimal?), decimal? AskOpen = default(decimal?), decimal? AskHigh = default(decimal?), decimal? AskLow = default(decimal?), decimal? TradeOpen = default(decimal?), decimal? TradeHigh = default(decimal?), decimal? TradeLow = default(decimal?), decimal? AskClose = default(decimal?), decimal? BidClose = default(decimal?), decimal? TradeClose = default(decimal?), decimal? Mark = default(decimal?))
        {
            this.BidOpen = BidOpen;
            this.BidHigh = BidHigh;
            this.BidLow = BidLow;
            this.AskOpen = AskOpen;
            this.AskHigh = AskHigh;
            this.AskLow = AskLow;
            this.TradeOpen = TradeOpen;
            this.TradeHigh = TradeHigh;
            this.TradeLow = TradeLow;
            this.AskClose = AskClose;
            this.BidClose = BidClose;
            this.TradeClose = TradeClose;
            this.Mark = Mark;
        }
        
        /// <summary>
        /// The price of the bid at open
        /// </summary>
        /// <value>The price of the bid at open</value>
        [DataMember(Name="bid_open", EmitDefaultValue=false)]
        public decimal? BidOpen { get; set; }

        /// <summary>
        /// The high bid so far today
        /// </summary>
        /// <value>The high bid so far today</value>
        [DataMember(Name="bid_high", EmitDefaultValue=false)]
        public decimal? BidHigh { get; set; }

        /// <summary>
        /// The low bid so far today
        /// </summary>
        /// <value>The low bid so far today</value>
        [DataMember(Name="bid_low", EmitDefaultValue=false)]
        public decimal? BidLow { get; set; }

        /// <summary>
        /// The price of the ask at open
        /// </summary>
        /// <value>The price of the ask at open</value>
        [DataMember(Name="ask_open", EmitDefaultValue=false)]
        public decimal? AskOpen { get; set; }

        /// <summary>
        /// The high ask so far today
        /// </summary>
        /// <value>The high ask so far today</value>
        [DataMember(Name="ask_high", EmitDefaultValue=false)]
        public decimal? AskHigh { get; set; }

        /// <summary>
        /// The low ask so far today
        /// </summary>
        /// <value>The low ask so far today</value>
        [DataMember(Name="ask_low", EmitDefaultValue=false)]
        public decimal? AskLow { get; set; }

        /// <summary>
        /// The price of the trade at open
        /// </summary>
        /// <value>The price of the trade at open</value>
        [DataMember(Name="trade_open", EmitDefaultValue=false)]
        public decimal? TradeOpen { get; set; }

        /// <summary>
        /// The high trade so far today
        /// </summary>
        /// <value>The high trade so far today</value>
        [DataMember(Name="trade_high", EmitDefaultValue=false)]
        public decimal? TradeHigh { get; set; }

        /// <summary>
        /// The low trade so far today
        /// </summary>
        /// <value>The low trade so far today</value>
        [DataMember(Name="trade_low", EmitDefaultValue=false)]
        public decimal? TradeLow { get; set; }

        /// <summary>
        /// The price of ask at close today
        /// </summary>
        /// <value>The price of ask at close today</value>
        [DataMember(Name="ask_close", EmitDefaultValue=false)]
        public decimal? AskClose { get; set; }

        /// <summary>
        /// The price of bid at close today
        /// </summary>
        /// <value>The price of bid at close today</value>
        [DataMember(Name="bid_close", EmitDefaultValue=false)]
        public decimal? BidClose { get; set; }

        /// <summary>
        /// The price of the last trade of the day
        /// </summary>
        /// <value>The price of the last trade of the day</value>
        [DataMember(Name="trade_close", EmitDefaultValue=false)]
        public decimal? TradeClose { get; set; }

        /// <summary>
        /// The mark price
        /// </summary>
        /// <value>The mark price</value>
        [DataMember(Name="mark", EmitDefaultValue=false)]
        public decimal? Mark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionPriceRealtimeExtended {\n");
            sb.Append("  BidOpen: ").Append(BidOpen).Append("\n");
            sb.Append("  BidHigh: ").Append(BidHigh).Append("\n");
            sb.Append("  BidLow: ").Append(BidLow).Append("\n");
            sb.Append("  AskOpen: ").Append(AskOpen).Append("\n");
            sb.Append("  AskHigh: ").Append(AskHigh).Append("\n");
            sb.Append("  AskLow: ").Append(AskLow).Append("\n");
            sb.Append("  TradeOpen: ").Append(TradeOpen).Append("\n");
            sb.Append("  TradeHigh: ").Append(TradeHigh).Append("\n");
            sb.Append("  TradeLow: ").Append(TradeLow).Append("\n");
            sb.Append("  AskClose: ").Append(AskClose).Append("\n");
            sb.Append("  BidClose: ").Append(BidClose).Append("\n");
            sb.Append("  TradeClose: ").Append(TradeClose).Append("\n");
            sb.Append("  Mark: ").Append(Mark).Append("\n");
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
            return this.Equals(input as OptionPriceRealtimeExtended);
        }

        /// <summary>
        /// Returns true if OptionPriceRealtimeExtended instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionPriceRealtimeExtended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionPriceRealtimeExtended input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BidOpen == input.BidOpen ||
                    (this.BidOpen != null &&
                    this.BidOpen.Equals(input.BidOpen))
                ) && 
                (
                    this.BidHigh == input.BidHigh ||
                    (this.BidHigh != null &&
                    this.BidHigh.Equals(input.BidHigh))
                ) && 
                (
                    this.BidLow == input.BidLow ||
                    (this.BidLow != null &&
                    this.BidLow.Equals(input.BidLow))
                ) && 
                (
                    this.AskOpen == input.AskOpen ||
                    (this.AskOpen != null &&
                    this.AskOpen.Equals(input.AskOpen))
                ) && 
                (
                    this.AskHigh == input.AskHigh ||
                    (this.AskHigh != null &&
                    this.AskHigh.Equals(input.AskHigh))
                ) && 
                (
                    this.AskLow == input.AskLow ||
                    (this.AskLow != null &&
                    this.AskLow.Equals(input.AskLow))
                ) && 
                (
                    this.TradeOpen == input.TradeOpen ||
                    (this.TradeOpen != null &&
                    this.TradeOpen.Equals(input.TradeOpen))
                ) && 
                (
                    this.TradeHigh == input.TradeHigh ||
                    (this.TradeHigh != null &&
                    this.TradeHigh.Equals(input.TradeHigh))
                ) && 
                (
                    this.TradeLow == input.TradeLow ||
                    (this.TradeLow != null &&
                    this.TradeLow.Equals(input.TradeLow))
                ) && 
                (
                    this.AskClose == input.AskClose ||
                    (this.AskClose != null &&
                    this.AskClose.Equals(input.AskClose))
                ) && 
                (
                    this.BidClose == input.BidClose ||
                    (this.BidClose != null &&
                    this.BidClose.Equals(input.BidClose))
                ) && 
                (
                    this.TradeClose == input.TradeClose ||
                    (this.TradeClose != null &&
                    this.TradeClose.Equals(input.TradeClose))
                ) && 
                (
                    this.Mark == input.Mark ||
                    (this.Mark != null &&
                    this.Mark.Equals(input.Mark))
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
                if (this.BidOpen != null)
                    hashCode = hashCode * 59 + this.BidOpen.GetHashCode();
                if (this.BidHigh != null)
                    hashCode = hashCode * 59 + this.BidHigh.GetHashCode();
                if (this.BidLow != null)
                    hashCode = hashCode * 59 + this.BidLow.GetHashCode();
                if (this.AskOpen != null)
                    hashCode = hashCode * 59 + this.AskOpen.GetHashCode();
                if (this.AskHigh != null)
                    hashCode = hashCode * 59 + this.AskHigh.GetHashCode();
                if (this.AskLow != null)
                    hashCode = hashCode * 59 + this.AskLow.GetHashCode();
                if (this.TradeOpen != null)
                    hashCode = hashCode * 59 + this.TradeOpen.GetHashCode();
                if (this.TradeHigh != null)
                    hashCode = hashCode * 59 + this.TradeHigh.GetHashCode();
                if (this.TradeLow != null)
                    hashCode = hashCode * 59 + this.TradeLow.GetHashCode();
                if (this.AskClose != null)
                    hashCode = hashCode * 59 + this.AskClose.GetHashCode();
                if (this.BidClose != null)
                    hashCode = hashCode * 59 + this.BidClose.GetHashCode();
                if (this.TradeClose != null)
                    hashCode = hashCode * 59 + this.TradeClose.GetHashCode();
                if (this.Mark != null)
                    hashCode = hashCode * 59 + this.Mark.GetHashCode();
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

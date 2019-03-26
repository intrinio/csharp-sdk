

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
    /// A snapshot is a point in time look at the given Crypto Currency Pair on the given Crypto Currency Exchange. The snapshot includes information from the last 24 hours such as bid price, bid size, ask price, ask size, notional change in price, percent change in price, volume, open price, high price, low price, and details of the last trade (price, time, size, and side).
    /// </summary>
    [DataContract]
    public partial class CryptoSnapshot :  IEquatable<CryptoSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoSnapshot" /> class.
        /// </summary>
        /// <param name="LastUpdated">UTC timestamp of when the snapshot was last updated..</param>
        /// <param name="Bid">The bid for the Crypto Currency Pair on the exchange..</param>
        /// <param name="BidSize">The size of the bid for the Crypto Currency Pair on the exchange..</param>
        /// <param name="Ask">The ask for the Crypto Currency Pair on the exchange..</param>
        /// <param name="AskSize">The size of the ask for the Crypto Currency Pair on the exchange..</param>
        /// <param name="Change">The notional change in price over the last 24 hours..</param>
        /// <param name="ChangePercent">The percent change in price over the last 24 hours..</param>
        /// <param name="Volume">The volume of the Crypto Currency Pair on the exchange..</param>
        /// <param name="Open">The opening price of the currency on the exchange..</param>
        /// <param name="High">The highest price of the currency on the exchange for the last 24 hours..</param>
        /// <param name="Low">The lowest price of the currency on the exchange for the last 24 hours..</param>
        /// <param name="LastTradeSide">The side of the last trade, either buy or sell..</param>
        /// <param name="LastTradeTime">UTC timestamp of the last trade for the Crypto Currency Pair on the exchange..</param>
        /// <param name="LastTradePrice">The price of the last trade for the Crypto Currency Pair on the exchange..</param>
        /// <param name="LastTradeSize">The size of the last trade for the Crypto Currency Pair on the exchange..</param>
        public CryptoSnapshot(string LastUpdated = default(string), decimal? Bid = default(decimal?), decimal? BidSize = default(decimal?), decimal? Ask = default(decimal?), decimal? AskSize = default(decimal?), decimal? Change = default(decimal?), decimal? ChangePercent = default(decimal?), decimal? Volume = default(decimal?), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), string LastTradeSide = default(string), string LastTradeTime = default(string), decimal? LastTradePrice = default(decimal?), decimal? LastTradeSize = default(decimal?))
        {
            this.LastUpdated = LastUpdated;
            this.Bid = Bid;
            this.BidSize = BidSize;
            this.Ask = Ask;
            this.AskSize = AskSize;
            this.Change = Change;
            this.ChangePercent = ChangePercent;
            this.Volume = Volume;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.LastTradeSide = LastTradeSide;
            this.LastTradeTime = LastTradeTime;
            this.LastTradePrice = LastTradePrice;
            this.LastTradeSize = LastTradeSize;
        }
        
        /// <summary>
        /// UTC timestamp of when the snapshot was last updated.
        /// </summary>
        /// <value>UTC timestamp of when the snapshot was last updated.</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// The bid for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The bid for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="bid", EmitDefaultValue=false)]
        public decimal? Bid { get; set; }

        /// <summary>
        /// The size of the bid for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The size of the bid for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="bid_size", EmitDefaultValue=false)]
        public decimal? BidSize { get; set; }

        /// <summary>
        /// The ask for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The ask for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="ask", EmitDefaultValue=false)]
        public decimal? Ask { get; set; }

        /// <summary>
        /// The size of the ask for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The size of the ask for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="ask_size", EmitDefaultValue=false)]
        public decimal? AskSize { get; set; }

        /// <summary>
        /// The notional change in price over the last 24 hours.
        /// </summary>
        /// <value>The notional change in price over the last 24 hours.</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The percent change in price over the last 24 hours.
        /// </summary>
        /// <value>The percent change in price over the last 24 hours.</value>
        [DataMember(Name="change_percent", EmitDefaultValue=false)]
        public decimal? ChangePercent { get; set; }

        /// <summary>
        /// The volume of the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The volume of the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// The opening price of the currency on the exchange.
        /// </summary>
        /// <value>The opening price of the currency on the exchange.</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The highest price of the currency on the exchange for the last 24 hours.
        /// </summary>
        /// <value>The highest price of the currency on the exchange for the last 24 hours.</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The lowest price of the currency on the exchange for the last 24 hours.
        /// </summary>
        /// <value>The lowest price of the currency on the exchange for the last 24 hours.</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The side of the last trade, either buy or sell.
        /// </summary>
        /// <value>The side of the last trade, either buy or sell.</value>
        [DataMember(Name="last_trade_side", EmitDefaultValue=false)]
        public string LastTradeSide { get; set; }

        /// <summary>
        /// UTC timestamp of the last trade for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>UTC timestamp of the last trade for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="last_trade_time", EmitDefaultValue=false)]
        public string LastTradeTime { get; set; }

        /// <summary>
        /// The price of the last trade for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The price of the last trade for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="last_trade_price", EmitDefaultValue=false)]
        public decimal? LastTradePrice { get; set; }

        /// <summary>
        /// The size of the last trade for the Crypto Currency Pair on the exchange.
        /// </summary>
        /// <value>The size of the last trade for the Crypto Currency Pair on the exchange.</value>
        [DataMember(Name="last_trade_size", EmitDefaultValue=false)]
        public decimal? LastTradeSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoSnapshot {\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  Ask: ").Append(Ask).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  ChangePercent: ").Append(ChangePercent).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  LastTradeSide: ").Append(LastTradeSide).Append("\n");
            sb.Append("  LastTradeTime: ").Append(LastTradeTime).Append("\n");
            sb.Append("  LastTradePrice: ").Append(LastTradePrice).Append("\n");
            sb.Append("  LastTradeSize: ").Append(LastTradeSize).Append("\n");
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
            return this.Equals(input as CryptoSnapshot);
        }

        /// <summary>
        /// Returns true if CryptoSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoSnapshot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
                ) && 
                (
                    this.BidSize == input.BidSize ||
                    (this.BidSize != null &&
                    this.BidSize.Equals(input.BidSize))
                ) && 
                (
                    this.Ask == input.Ask ||
                    (this.Ask != null &&
                    this.Ask.Equals(input.Ask))
                ) && 
                (
                    this.AskSize == input.AskSize ||
                    (this.AskSize != null &&
                    this.AskSize.Equals(input.AskSize))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.ChangePercent == input.ChangePercent ||
                    (this.ChangePercent != null &&
                    this.ChangePercent.Equals(input.ChangePercent))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.LastTradeSide == input.LastTradeSide ||
                    (this.LastTradeSide != null &&
                    this.LastTradeSide.Equals(input.LastTradeSide))
                ) && 
                (
                    this.LastTradeTime == input.LastTradeTime ||
                    (this.LastTradeTime != null &&
                    this.LastTradeTime.Equals(input.LastTradeTime))
                ) && 
                (
                    this.LastTradePrice == input.LastTradePrice ||
                    (this.LastTradePrice != null &&
                    this.LastTradePrice.Equals(input.LastTradePrice))
                ) && 
                (
                    this.LastTradeSize == input.LastTradeSize ||
                    (this.LastTradeSize != null &&
                    this.LastTradeSize.Equals(input.LastTradeSize))
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
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.Bid != null)
                    hashCode = hashCode * 59 + this.Bid.GetHashCode();
                if (this.BidSize != null)
                    hashCode = hashCode * 59 + this.BidSize.GetHashCode();
                if (this.Ask != null)
                    hashCode = hashCode * 59 + this.Ask.GetHashCode();
                if (this.AskSize != null)
                    hashCode = hashCode * 59 + this.AskSize.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.ChangePercent != null)
                    hashCode = hashCode * 59 + this.ChangePercent.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.LastTradeSide != null)
                    hashCode = hashCode * 59 + this.LastTradeSide.GetHashCode();
                if (this.LastTradeTime != null)
                    hashCode = hashCode * 59 + this.LastTradeTime.GetHashCode();
                if (this.LastTradePrice != null)
                    hashCode = hashCode * 59 + this.LastTradePrice.GetHashCode();
                if (this.LastTradeSize != null)
                    hashCode = hashCode * 59 + this.LastTradeSize.GetHashCode();
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



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
    /// The realtime stock price of a security.
    /// </summary>
    [DataContract]
    public partial class RealtimeStockPrice :  IEquatable<RealtimeStockPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeStockPrice" /> class.
        /// </summary>
        /// <param name="LastPrice">The price of the last trade..</param>
        /// <param name="LastTime">The date and time when the last trade occurred..</param>
        /// <param name="LastSize">The size of the last trade..</param>
        /// <param name="BidPrice">The price of the top bid order..</param>
        /// <param name="BidSize">The size of the top bid order..</param>
        /// <param name="AskPrice">The price of the top ask order..</param>
        /// <param name="AskSize">The size of the top ask order..</param>
        /// <param name="OpenPrice">The price at the open of the trading day..</param>
        /// <param name="HighPrice">The high price for the trading day..</param>
        /// <param name="LowPrice">The low price for the trading day..</param>
        /// <param name="ExchangeVolume">The number of shares exchanged during the trading day on the exchange..</param>
        /// <param name="MarketVolume">The number of shares exchanged during the trading day for the whole market..</param>
        /// <param name="UpdatedOn">The date and time when the data was last updated..</param>
        /// <param name="Source">The source of the data..</param>
        /// <param name="Security">Security.</param>
        public RealtimeStockPrice(decimal? LastPrice = default(decimal?), DateTime? LastTime = default(DateTime?), decimal? LastSize = default(decimal?), decimal? BidPrice = default(decimal?), decimal? BidSize = default(decimal?), decimal? AskPrice = default(decimal?), decimal? AskSize = default(decimal?), decimal? OpenPrice = default(decimal?), decimal? HighPrice = default(decimal?), decimal? LowPrice = default(decimal?), decimal? ExchangeVolume = default(decimal?), decimal? MarketVolume = default(decimal?), DateTime? UpdatedOn = default(DateTime?), string Source = default(string), RealtimeStockPriceSecurity Security = default(RealtimeStockPriceSecurity))
        {
            this.LastPrice = LastPrice;
            this.LastTime = LastTime;
            this.LastSize = LastSize;
            this.BidPrice = BidPrice;
            this.BidSize = BidSize;
            this.AskPrice = AskPrice;
            this.AskSize = AskSize;
            this.OpenPrice = OpenPrice;
            this.HighPrice = HighPrice;
            this.LowPrice = LowPrice;
            this.ExchangeVolume = ExchangeVolume;
            this.MarketVolume = MarketVolume;
            this.UpdatedOn = UpdatedOn;
            this.Source = Source;
            this.Security = Security;
        }
        
        /// <summary>
        /// The price of the last trade.
        /// </summary>
        /// <value>The price of the last trade.</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The date and time when the last trade occurred.
        /// </summary>
        /// <value>The date and time when the last trade occurred.</value>
        [DataMember(Name="last_time", EmitDefaultValue=false)]
        public DateTime? LastTime { get; set; }

        /// <summary>
        /// The size of the last trade.
        /// </summary>
        /// <value>The size of the last trade.</value>
        [DataMember(Name="last_size", EmitDefaultValue=false)]
        public decimal? LastSize { get; set; }

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
        /// The price at the open of the trading day.
        /// </summary>
        /// <value>The price at the open of the trading day.</value>
        [DataMember(Name="open_price", EmitDefaultValue=false)]
        public decimal? OpenPrice { get; set; }

        /// <summary>
        /// The high price for the trading day.
        /// </summary>
        /// <value>The high price for the trading day.</value>
        [DataMember(Name="high_price", EmitDefaultValue=false)]
        public decimal? HighPrice { get; set; }

        /// <summary>
        /// The low price for the trading day.
        /// </summary>
        /// <value>The low price for the trading day.</value>
        [DataMember(Name="low_price", EmitDefaultValue=false)]
        public decimal? LowPrice { get; set; }

        /// <summary>
        /// The number of shares exchanged during the trading day on the exchange.
        /// </summary>
        /// <value>The number of shares exchanged during the trading day on the exchange.</value>
        [DataMember(Name="exchange_volume", EmitDefaultValue=false)]
        public decimal? ExchangeVolume { get; set; }

        /// <summary>
        /// The number of shares exchanged during the trading day for the whole market.
        /// </summary>
        /// <value>The number of shares exchanged during the trading day for the whole market.</value>
        [DataMember(Name="market_volume", EmitDefaultValue=false)]
        public decimal? MarketVolume { get; set; }

        /// <summary>
        /// The date and time when the data was last updated.
        /// </summary>
        /// <value>The date and time when the data was last updated.</value>
        [DataMember(Name="updated_on", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// The source of the data.
        /// </summary>
        /// <value>The source of the data.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public RealtimeStockPriceSecurity Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeStockPrice {\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  LastTime: ").Append(LastTime).Append("\n");
            sb.Append("  LastSize: ").Append(LastSize).Append("\n");
            sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("  OpenPrice: ").Append(OpenPrice).Append("\n");
            sb.Append("  HighPrice: ").Append(HighPrice).Append("\n");
            sb.Append("  LowPrice: ").Append(LowPrice).Append("\n");
            sb.Append("  ExchangeVolume: ").Append(ExchangeVolume).Append("\n");
            sb.Append("  MarketVolume: ").Append(MarketVolume).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as RealtimeStockPrice);
        }

        /// <summary>
        /// Returns true if RealtimeStockPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of RealtimeStockPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealtimeStockPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastPrice == input.LastPrice ||
                    (this.LastPrice != null &&
                    this.LastPrice.Equals(input.LastPrice))
                ) && 
                (
                    this.LastTime == input.LastTime ||
                    (this.LastTime != null &&
                    this.LastTime.Equals(input.LastTime))
                ) && 
                (
                    this.LastSize == input.LastSize ||
                    (this.LastSize != null &&
                    this.LastSize.Equals(input.LastSize))
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
                    this.OpenPrice == input.OpenPrice ||
                    (this.OpenPrice != null &&
                    this.OpenPrice.Equals(input.OpenPrice))
                ) && 
                (
                    this.HighPrice == input.HighPrice ||
                    (this.HighPrice != null &&
                    this.HighPrice.Equals(input.HighPrice))
                ) && 
                (
                    this.LowPrice == input.LowPrice ||
                    (this.LowPrice != null &&
                    this.LowPrice.Equals(input.LowPrice))
                ) && 
                (
                    this.ExchangeVolume == input.ExchangeVolume ||
                    (this.ExchangeVolume != null &&
                    this.ExchangeVolume.Equals(input.ExchangeVolume))
                ) && 
                (
                    this.MarketVolume == input.MarketVolume ||
                    (this.MarketVolume != null &&
                    this.MarketVolume.Equals(input.MarketVolume))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.LastPrice != null)
                    hashCode = hashCode * 59 + this.LastPrice.GetHashCode();
                if (this.LastTime != null)
                    hashCode = hashCode * 59 + this.LastTime.GetHashCode();
                if (this.LastSize != null)
                    hashCode = hashCode * 59 + this.LastSize.GetHashCode();
                if (this.BidPrice != null)
                    hashCode = hashCode * 59 + this.BidPrice.GetHashCode();
                if (this.BidSize != null)
                    hashCode = hashCode * 59 + this.BidSize.GetHashCode();
                if (this.AskPrice != null)
                    hashCode = hashCode * 59 + this.AskPrice.GetHashCode();
                if (this.AskSize != null)
                    hashCode = hashCode * 59 + this.AskSize.GetHashCode();
                if (this.OpenPrice != null)
                    hashCode = hashCode * 59 + this.OpenPrice.GetHashCode();
                if (this.HighPrice != null)
                    hashCode = hashCode * 59 + this.HighPrice.GetHashCode();
                if (this.LowPrice != null)
                    hashCode = hashCode * 59 + this.LowPrice.GetHashCode();
                if (this.ExchangeVolume != null)
                    hashCode = hashCode * 59 + this.ExchangeVolume.GetHashCode();
                if (this.MarketVolume != null)
                    hashCode = hashCode * 59 + this.MarketVolume.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

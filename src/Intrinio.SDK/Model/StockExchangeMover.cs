

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
    /// An security intervals result contains all security intervals corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class StockExchangeMover :  IEquatable<StockExchangeMover>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchangeMover" /> class.
        /// </summary>
        /// <param name="SecurityId">The Intrinio Identifier for this security..</param>
        /// <param name="Ticker">The ticker symbol for this security..</param>
        /// <param name="LastPrice">The last price of the last trade..</param>
        /// <param name="Change">The raw change in price..</param>
        /// <param name="PercentChange">The percent change in price..</param>
        /// <param name="MarketVolume">The market volume for the most recent (today) trading day..</param>
        /// <param name="Source">The source of the data..</param>
        public StockExchangeMover(string SecurityId = default(string), string Ticker = default(string), decimal? LastPrice = default(decimal?), decimal? Change = default(decimal?), decimal? PercentChange = default(decimal?), decimal? MarketVolume = default(decimal?), string Source = default(string))
        {
            this.SecurityId = SecurityId;
            this.Ticker = Ticker;
            this.LastPrice = LastPrice;
            this.Change = Change;
            this.PercentChange = PercentChange;
            this.MarketVolume = MarketVolume;
            this.Source = Source;
        }
        
        /// <summary>
        /// The Intrinio Identifier for this security.
        /// </summary>
        /// <value>The Intrinio Identifier for this security.</value>
        [DataMember(Name="security_id", EmitDefaultValue=false)]
        public string SecurityId { get; set; }

        /// <summary>
        /// The ticker symbol for this security.
        /// </summary>
        /// <value>The ticker symbol for this security.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The last price of the last trade.
        /// </summary>
        /// <value>The last price of the last trade.</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The raw change in price.
        /// </summary>
        /// <value>The raw change in price.</value>
        [DataMember(Name="change", EmitDefaultValue=false)]
        public decimal? Change { get; set; }

        /// <summary>
        /// The percent change in price.
        /// </summary>
        /// <value>The percent change in price.</value>
        [DataMember(Name="percent_change", EmitDefaultValue=false)]
        public decimal? PercentChange { get; set; }

        /// <summary>
        /// The market volume for the most recent (today) trading day.
        /// </summary>
        /// <value>The market volume for the most recent (today) trading day.</value>
        [DataMember(Name="market_volume", EmitDefaultValue=false)]
        public decimal? MarketVolume { get; set; }

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
            sb.Append("class StockExchangeMover {\n");
            sb.Append("  SecurityId: ").Append(SecurityId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  PercentChange: ").Append(PercentChange).Append("\n");
            sb.Append("  MarketVolume: ").Append(MarketVolume).Append("\n");
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
            return this.Equals(input as StockExchangeMover);
        }

        /// <summary>
        /// Returns true if StockExchangeMover instances are equal
        /// </summary>
        /// <param name="input">Instance of StockExchangeMover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockExchangeMover input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityId == input.SecurityId ||
                    (this.SecurityId != null &&
                    this.SecurityId.Equals(input.SecurityId))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.LastPrice == input.LastPrice ||
                    (this.LastPrice != null &&
                    this.LastPrice.Equals(input.LastPrice))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.PercentChange == input.PercentChange ||
                    (this.PercentChange != null &&
                    this.PercentChange.Equals(input.PercentChange))
                ) && 
                (
                    this.MarketVolume == input.MarketVolume ||
                    (this.MarketVolume != null &&
                    this.MarketVolume.Equals(input.MarketVolume))
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
                if (this.SecurityId != null)
                    hashCode = hashCode * 59 + this.SecurityId.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.LastPrice != null)
                    hashCode = hashCode * 59 + this.LastPrice.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.PercentChange != null)
                    hashCode = hashCode * 59 + this.PercentChange.GetHashCode();
                if (this.MarketVolume != null)
                    hashCode = hashCode * 59 + this.MarketVolume.GetHashCode();
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

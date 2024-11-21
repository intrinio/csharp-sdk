

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
    public partial class SecurityTrades :  IEquatable<SecurityTrades>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityTrades" /> class.
        /// </summary>
        /// <param name="Symbol">The ticker symbol.</param>
        /// <param name="Timestamp">The UTC timestamp at the time of the trade..</param>
        /// <param name="Price">The price of the trade..</param>
        /// <param name="Size">The size of the trade..</param>
        /// <param name="TotalVolume">The total volume of the symbol for the day up to the timestamp point in time..</param>
        /// <param name="MarketCenter">The market center for the trade..</param>
        /// <param name="Condition">The condition of the trade..</param>
        /// <param name="IsDarkpool">If the trade was darkpool or not..</param>
        public SecurityTrades(string Symbol = default(string), DateTime? Timestamp = default(DateTime?), decimal? Price = default(decimal?), decimal? Size = default(decimal?), decimal? TotalVolume = default(decimal?), string MarketCenter = default(string), string Condition = default(string), bool? IsDarkpool = default(bool?))
        {
            this.Symbol = Symbol;
            this.Timestamp = Timestamp;
            this.Price = Price;
            this.Size = Size;
            this.TotalVolume = TotalVolume;
            this.MarketCenter = MarketCenter;
            this.Condition = Condition;
            this.IsDarkpool = IsDarkpool;
        }
        
        /// <summary>
        /// The ticker symbol
        /// </summary>
        /// <value>The ticker symbol</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

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
        /// The market center for the trade.
        /// </summary>
        /// <value>The market center for the trade.</value>
        [DataMember(Name="market_center", EmitDefaultValue=false)]
        public string MarketCenter { get; set; }

        /// <summary>
        /// The condition of the trade.
        /// </summary>
        /// <value>The condition of the trade.</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public string Condition { get; set; }

        /// <summary>
        /// If the trade was darkpool or not.
        /// </summary>
        /// <value>If the trade was darkpool or not.</value>
        [DataMember(Name="is_darkpool", EmitDefaultValue=false)]
        public bool? IsDarkpool { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityTrades {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
            sb.Append("  MarketCenter: ").Append(MarketCenter).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  IsDarkpool: ").Append(IsDarkpool).Append("\n");
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
            return this.Equals(input as SecurityTrades);
        }

        /// <summary>
        /// Returns true if SecurityTrades instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityTrades to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityTrades input)
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
                    this.MarketCenter == input.MarketCenter ||
                    (this.MarketCenter != null &&
                    this.MarketCenter.Equals(input.MarketCenter))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.IsDarkpool == input.IsDarkpool ||
                    (this.IsDarkpool != null &&
                    this.IsDarkpool.Equals(input.IsDarkpool))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TotalVolume != null)
                    hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
                if (this.MarketCenter != null)
                    hashCode = hashCode * 59 + this.MarketCenter.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.IsDarkpool != null)
                    hashCode = hashCode * 59 + this.IsDarkpool.GetHashCode();
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

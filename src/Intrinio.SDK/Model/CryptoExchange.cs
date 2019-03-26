

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
    /// An exchange that a Crypto Currency Pair trades on. Crypto Exchange data includes name, code, book depth availability, historical data availability, snapshot availability, trade data availability, and a list of Crypto Currency Pairs that trade on it. Each exchange may provide different kinds of data (book depth, trades, etc.) about the Crypto Currency Pairs that trade on it.
    /// </summary>
    [DataContract]
    public partial class CryptoExchange :  IEquatable<CryptoExchange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoExchange" /> class.
        /// </summary>
        /// <param name="Name">The Crypto Exchange name..</param>
        /// <param name="Code">The Crypto Exchange code..</param>
        /// <param name="BookDepthAvailable">A boolean, representing whether book depth data is provided by this exchange or not..</param>
        /// <param name="HistoryAvailable">A boolean, representing whether historical data is provided by this exchange or not..</param>
        /// <param name="SnapshotAvailable">A boolean, representing whether snpashot data is provided by this exchange or not..</param>
        /// <param name="TradesAvailable">A boolean, representing whether trade data is provided by this exchange or not..</param>
        public CryptoExchange(string Name = default(string), string Code = default(string), bool? BookDepthAvailable = default(bool?), bool? HistoryAvailable = default(bool?), bool? SnapshotAvailable = default(bool?), bool? TradesAvailable = default(bool?))
        {
            this.Name = Name;
            this.Code = Code;
            this.BookDepthAvailable = BookDepthAvailable;
            this.HistoryAvailable = HistoryAvailable;
            this.SnapshotAvailable = SnapshotAvailable;
            this.TradesAvailable = TradesAvailable;
        }
        
        /// <summary>
        /// The Crypto Exchange name.
        /// </summary>
        /// <value>The Crypto Exchange name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Crypto Exchange code.
        /// </summary>
        /// <value>The Crypto Exchange code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// A boolean, representing whether book depth data is provided by this exchange or not.
        /// </summary>
        /// <value>A boolean, representing whether book depth data is provided by this exchange or not.</value>
        [DataMember(Name="book_depth_available", EmitDefaultValue=false)]
        public bool? BookDepthAvailable { get; set; }

        /// <summary>
        /// A boolean, representing whether historical data is provided by this exchange or not.
        /// </summary>
        /// <value>A boolean, representing whether historical data is provided by this exchange or not.</value>
        [DataMember(Name="history_available", EmitDefaultValue=false)]
        public bool? HistoryAvailable { get; set; }

        /// <summary>
        /// A boolean, representing whether snpashot data is provided by this exchange or not.
        /// </summary>
        /// <value>A boolean, representing whether snpashot data is provided by this exchange or not.</value>
        [DataMember(Name="snapshot_available", EmitDefaultValue=false)]
        public bool? SnapshotAvailable { get; set; }

        /// <summary>
        /// A boolean, representing whether trade data is provided by this exchange or not.
        /// </summary>
        /// <value>A boolean, representing whether trade data is provided by this exchange or not.</value>
        [DataMember(Name="trades_available", EmitDefaultValue=false)]
        public bool? TradesAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoExchange {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  BookDepthAvailable: ").Append(BookDepthAvailable).Append("\n");
            sb.Append("  HistoryAvailable: ").Append(HistoryAvailable).Append("\n");
            sb.Append("  SnapshotAvailable: ").Append(SnapshotAvailable).Append("\n");
            sb.Append("  TradesAvailable: ").Append(TradesAvailable).Append("\n");
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
            return this.Equals(input as CryptoExchange);
        }

        /// <summary>
        /// Returns true if CryptoExchange instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoExchange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoExchange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.BookDepthAvailable == input.BookDepthAvailable ||
                    (this.BookDepthAvailable != null &&
                    this.BookDepthAvailable.Equals(input.BookDepthAvailable))
                ) && 
                (
                    this.HistoryAvailable == input.HistoryAvailable ||
                    (this.HistoryAvailable != null &&
                    this.HistoryAvailable.Equals(input.HistoryAvailable))
                ) && 
                (
                    this.SnapshotAvailable == input.SnapshotAvailable ||
                    (this.SnapshotAvailable != null &&
                    this.SnapshotAvailable.Equals(input.SnapshotAvailable))
                ) && 
                (
                    this.TradesAvailable == input.TradesAvailable ||
                    (this.TradesAvailable != null &&
                    this.TradesAvailable.Equals(input.TradesAvailable))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.BookDepthAvailable != null)
                    hashCode = hashCode * 59 + this.BookDepthAvailable.GetHashCode();
                if (this.HistoryAvailable != null)
                    hashCode = hashCode * 59 + this.HistoryAvailable.GetHashCode();
                if (this.SnapshotAvailable != null)
                    hashCode = hashCode * 59 + this.SnapshotAvailable.GetHashCode();
                if (this.TradesAvailable != null)
                    hashCode = hashCode * 59 + this.TradesAvailable.GetHashCode();
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

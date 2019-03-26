

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
    /// A Crypto Currency Pair is a currency pair traded on a Crypto Exchange and includes at least one Crypto Currency (i.e. BTCUSD, BTCETH, etc.). Details of a Crypto Currency Pair include name, code, the Crypto Currencies in the pair, and the Crypto Exchanges that the Crypto Currency Pair trades on. Included are also details about the data available for this Crypto Currency Pair such as the first and last date that price is available, book depth availability, history availability, snapshot availability, and trade data availability.
    /// </summary>
    [DataContract]
    public partial class CryptoPair :  IEquatable<CryptoPair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoPair" /> class.
        /// </summary>
        /// <param name="Name">The Crypto Currency Pair name..</param>
        /// <param name="Code">The Crypto Currency Pair code..</param>
        /// <param name="FirstPriceDate">The earliest date that daily historical pricing is available for..</param>
        /// <param name="LastPriceDate">The most recent date that daily historical pricing is available for..</param>
        /// <param name="BookDepthAvailable">A boolean, representing whether this pair has book depth data available or not..</param>
        /// <param name="HistoryAvailable">A boolean, representing whether this pair has historical price data available or not..</param>
        /// <param name="SnapshotAvailable">A boolean, representing whether this pair has snapshot data available or not..</param>
        /// <param name="TradesAvailable">A boolean, representing whether this pair has trade data available or not..</param>
        public CryptoPair(string Name = default(string), string Code = default(string), string FirstPriceDate = default(string), string LastPriceDate = default(string), bool? BookDepthAvailable = default(bool?), bool? HistoryAvailable = default(bool?), bool? SnapshotAvailable = default(bool?), bool? TradesAvailable = default(bool?))
        {
            this.Name = Name;
            this.Code = Code;
            this.FirstPriceDate = FirstPriceDate;
            this.LastPriceDate = LastPriceDate;
            this.BookDepthAvailable = BookDepthAvailable;
            this.HistoryAvailable = HistoryAvailable;
            this.SnapshotAvailable = SnapshotAvailable;
            this.TradesAvailable = TradesAvailable;
        }
        
        /// <summary>
        /// The Crypto Currency Pair name.
        /// </summary>
        /// <value>The Crypto Currency Pair name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Crypto Currency Pair code.
        /// </summary>
        /// <value>The Crypto Currency Pair code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The earliest date that daily historical pricing is available for.
        /// </summary>
        /// <value>The earliest date that daily historical pricing is available for.</value>
        [DataMember(Name="first_price_date", EmitDefaultValue=false)]
        public string FirstPriceDate { get; set; }

        /// <summary>
        /// The most recent date that daily historical pricing is available for.
        /// </summary>
        /// <value>The most recent date that daily historical pricing is available for.</value>
        [DataMember(Name="last_price_date", EmitDefaultValue=false)]
        public string LastPriceDate { get; set; }

        /// <summary>
        /// A boolean, representing whether this pair has book depth data available or not.
        /// </summary>
        /// <value>A boolean, representing whether this pair has book depth data available or not.</value>
        [DataMember(Name="book_depth_available", EmitDefaultValue=false)]
        public bool? BookDepthAvailable { get; set; }

        /// <summary>
        /// A boolean, representing whether this pair has historical price data available or not.
        /// </summary>
        /// <value>A boolean, representing whether this pair has historical price data available or not.</value>
        [DataMember(Name="history_available", EmitDefaultValue=false)]
        public bool? HistoryAvailable { get; set; }

        /// <summary>
        /// A boolean, representing whether this pair has snapshot data available or not.
        /// </summary>
        /// <value>A boolean, representing whether this pair has snapshot data available or not.</value>
        [DataMember(Name="snapshot_available", EmitDefaultValue=false)]
        public bool? SnapshotAvailable { get; set; }

        /// <summary>
        /// A boolean, representing whether this pair has trade data available or not.
        /// </summary>
        /// <value>A boolean, representing whether this pair has trade data available or not.</value>
        [DataMember(Name="trades_available", EmitDefaultValue=false)]
        public bool? TradesAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoPair {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FirstPriceDate: ").Append(FirstPriceDate).Append("\n");
            sb.Append("  LastPriceDate: ").Append(LastPriceDate).Append("\n");
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
            return this.Equals(input as CryptoPair);
        }

        /// <summary>
        /// Returns true if CryptoPair instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoPair input)
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
                    this.FirstPriceDate == input.FirstPriceDate ||
                    (this.FirstPriceDate != null &&
                    this.FirstPriceDate.Equals(input.FirstPriceDate))
                ) && 
                (
                    this.LastPriceDate == input.LastPriceDate ||
                    (this.LastPriceDate != null &&
                    this.LastPriceDate.Equals(input.LastPriceDate))
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
                if (this.FirstPriceDate != null)
                    hashCode = hashCode * 59 + this.FirstPriceDate.GetHashCode();
                if (this.LastPriceDate != null)
                    hashCode = hashCode * 59 + this.LastPriceDate.GetHashCode();
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



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
    /// ApiResponseCryptoSnapshot
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoSnapshot :  IEquatable<ApiResponseCryptoSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoSnapshot" /> class.
        /// </summary>
        /// <param name="Pair">Pair.</param>
        /// <param name="Exchange">Exchange.</param>
        /// <param name="Snapshot">Snapshot.</param>
        public ApiResponseCryptoSnapshot(CryptoPairSummary Pair = default(CryptoPairSummary), CryptoExchangeSummary Exchange = default(CryptoExchangeSummary), CryptoSnapshot Snapshot = default(CryptoSnapshot))
        {
            this.Pair = Pair;
            this.Exchange = Exchange;
            this.Snapshot = Snapshot;
        }
        
        /// <summary>
        /// Gets or Sets Pair
        /// </summary>
        [DataMember(Name="pair", EmitDefaultValue=false)]
        public CryptoPairSummary Pair { get; set; }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public CryptoExchangeSummary Exchange { get; set; }

        /// <summary>
        /// Gets or Sets Snapshot
        /// </summary>
        [DataMember(Name="snapshot", EmitDefaultValue=false)]
        public CryptoSnapshot Snapshot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoSnapshot {\n");
            sb.Append("  Pair: ").Append(Pair).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Snapshot: ").Append(Snapshot).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoSnapshot);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoSnapshot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pair == input.Pair ||
                    (this.Pair != null &&
                    this.Pair.Equals(input.Pair))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.Snapshot == input.Snapshot ||
                    (this.Snapshot != null &&
                    this.Snapshot.Equals(input.Snapshot))
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
                if (this.Pair != null)
                    hashCode = hashCode * 59 + this.Pair.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.Snapshot != null)
                    hashCode = hashCode * 59 + this.Snapshot.GetHashCode();
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

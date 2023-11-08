

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
    /// The realtime price of an index.
    /// </summary>
    [DataContract]
    public partial class RealtimeIndexPrice :  IEquatable<RealtimeIndexPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeIndexPrice" /> class.
        /// </summary>
        /// <param name="LastPrice">The last price.</param>
        /// <param name="LastTime">The timestamp of the last price.</param>
        /// <param name="Index">Index.</param>
        public RealtimeIndexPrice(decimal? LastPrice = default(decimal?), DateTime? LastTime = default(DateTime?), RealtimeIndexPriceIndex Index = default(RealtimeIndexPriceIndex))
        {
            this.LastPrice = LastPrice;
            this.LastTime = LastTime;
            this.Index = Index;
        }
        
        /// <summary>
        /// The last price
        /// </summary>
        /// <value>The last price</value>
        [DataMember(Name="last_price", EmitDefaultValue=false)]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The timestamp of the last price
        /// </summary>
        /// <value>The timestamp of the last price</value>
        [DataMember(Name="last_time", EmitDefaultValue=false)]
        public DateTime? LastTime { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public RealtimeIndexPriceIndex Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealtimeIndexPrice {\n");
            sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
            sb.Append("  LastTime: ").Append(LastTime).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as RealtimeIndexPrice);
        }

        /// <summary>
        /// Returns true if RealtimeIndexPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of RealtimeIndexPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealtimeIndexPrice input)
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
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
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

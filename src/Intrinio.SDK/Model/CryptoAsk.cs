

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
    /// A Crypto Currency Ask Price
    /// </summary>
    [DataContract]
    public partial class CryptoAsk :  IEquatable<CryptoAsk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoAsk" /> class.
        /// </summary>
        /// <param name="Price">The ask price of the book entry..</param>
        /// <param name="Size">The size for the ask price of the book entry..</param>
        public CryptoAsk(decimal? Price = default(decimal?), decimal? Size = default(decimal?))
        {
            this.Price = Price;
            this.Size = Size;
        }
        
        /// <summary>
        /// The ask price of the book entry.
        /// </summary>
        /// <value>The ask price of the book entry.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The size for the ask price of the book entry.
        /// </summary>
        /// <value>The size for the ask price of the book entry.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoAsk {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as CryptoAsk);
        }

        /// <summary>
        /// Returns true if CryptoAsk instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoAsk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoAsk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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

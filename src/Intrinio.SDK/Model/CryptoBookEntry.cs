

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
    /// A Crypto Currency Book Entry that includes size and price
    /// </summary>
    [DataContract]
    public partial class CryptoBookEntry :  IEquatable<CryptoBookEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoBookEntry" /> class.
        /// </summary>
        /// <param name="Price">The price of the book entry..</param>
        /// <param name="Size">The size for the price of the book entry..</param>
        public CryptoBookEntry(decimal? Price = default(decimal?), decimal? Size = default(decimal?))
        {
            this.Price = Price;
            this.Size = Size;
        }
        
        /// <summary>
        /// The price of the book entry.
        /// </summary>
        /// <value>The price of the book entry.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The size for the price of the book entry.
        /// </summary>
        /// <value>The size for the price of the book entry.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoBookEntry {\n");
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
            return this.Equals(input as CryptoBookEntry);
        }

        /// <summary>
        /// Returns true if CryptoBookEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoBookEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoBookEntry input)
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



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
    /// Data for the provided Crypto Currency Pair.
    /// </summary>
    [DataContract]
    public partial class CryptoPairSummary :  IEquatable<CryptoPairSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoPairSummary" /> class.
        /// </summary>
        /// <param name="Name">The Crypto Currency Pair name..</param>
        /// <param name="Code">The Crypto Currency Pair code..</param>
        public CryptoPairSummary(string Name = default(string), string Code = default(string))
        {
            this.Name = Name;
            this.Code = Code;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptoPairSummary {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as CryptoPairSummary);
        }

        /// <summary>
        /// Returns true if CryptoPairSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptoPairSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptoPairSummary input)
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

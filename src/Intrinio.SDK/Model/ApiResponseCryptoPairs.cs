

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
    /// ApiResponseCryptoPairs
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoPairs :  IEquatable<ApiResponseCryptoPairs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoPairs" /> class.
        /// </summary>
        /// <param name="Pairs">A list of Crypto Currency Pairs for the given Crypto Exchange and Crypto Currency sorted alphabetically by code..</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseCryptoPairs(List<CryptoPair> Pairs = default(List<CryptoPair>), string NextPage = default(string))
        {
            this.Pairs = Pairs;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// A list of Crypto Currency Pairs for the given Crypto Exchange and Crypto Currency sorted alphabetically by code.
        /// </summary>
        /// <value>A list of Crypto Currency Pairs for the given Crypto Exchange and Crypto Currency sorted alphabetically by code.</value>
        [DataMember(Name="pairs", EmitDefaultValue=false)]
        public List<CryptoPair> Pairs { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoPairs {\n");
            sb.Append("  Pairs: ").Append(Pairs).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoPairs);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoPairs instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoPairs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoPairs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pairs == input.Pairs ||
                    this.Pairs != null &&
                    this.Pairs.SequenceEqual(input.Pairs)
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.Pairs != null)
                    hashCode = hashCode * 59 + this.Pairs.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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

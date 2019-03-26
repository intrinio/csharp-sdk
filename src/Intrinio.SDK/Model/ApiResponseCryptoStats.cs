

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
    /// ApiResponseCryptoStats
    /// </summary>
    [DataContract]
    public partial class ApiResponseCryptoStats :  IEquatable<ApiResponseCryptoStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCryptoStats" /> class.
        /// </summary>
        /// <param name="Stats">A list of Crypto Currencies and their stats..</param>
        public ApiResponseCryptoStats(List<CryptoStat> Stats = default(List<CryptoStat>))
        {
            this.Stats = Stats;
        }
        
        /// <summary>
        /// A list of Crypto Currencies and their stats.
        /// </summary>
        /// <value>A list of Crypto Currencies and their stats.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public List<CryptoStat> Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCryptoStats {\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
            return this.Equals(input as ApiResponseCryptoStats);
        }

        /// <summary>
        /// Returns true if ApiResponseCryptoStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCryptoStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCryptoStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    this.Stats.SequenceEqual(input.Stats)
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
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
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

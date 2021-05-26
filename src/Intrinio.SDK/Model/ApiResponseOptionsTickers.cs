

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
    /// ApiResponseOptionsTickers
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsTickers :  IEquatable<ApiResponseOptionsTickers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsTickers" /> class.
        /// </summary>
        /// <param name="Tickers">Tickers.</param>
        public ApiResponseOptionsTickers(List<string> Tickers = default(List<string>))
        {
            this.Tickers = Tickers;
        }
        
        /// <summary>
        /// Gets or Sets Tickers
        /// </summary>
        [DataMember(Name="tickers", EmitDefaultValue=false)]
        public List<string> Tickers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsTickers {\n");
            sb.Append("  Tickers: ").Append(Tickers).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsTickers);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsTickers instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsTickers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsTickers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tickers == input.Tickers ||
                    this.Tickers != null &&
                    this.Tickers.SequenceEqual(input.Tickers)
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
                if (this.Tickers != null)
                    hashCode = hashCode * 59 + this.Tickers.GetHashCode();
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

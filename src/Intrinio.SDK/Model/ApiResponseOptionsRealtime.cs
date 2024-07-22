

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
    /// ApiResponseOptionsRealtime
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsRealtime :  IEquatable<ApiResponseOptionsRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsRealtime" /> class.
        /// </summary>
        /// <param name="Options">A list of options contracts with the given symbol.</param>
        public ApiResponseOptionsRealtime(List<OptionRealtime> Options = default(List<OptionRealtime>))
        {
            this.Options = Options;
        }
        
        /// <summary>
        /// A list of options contracts with the given symbol
        /// </summary>
        /// <value>A list of options contracts with the given symbol</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<OptionRealtime> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsRealtime {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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

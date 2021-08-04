

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
    /// ApiResponseOptionsUnusualActivity
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsUnusualActivity :  IEquatable<ApiResponseOptionsUnusualActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsUnusualActivity" /> class.
        /// </summary>
        /// <param name="Trades">A list of unusual trades for a given company identifier.</param>
        public ApiResponseOptionsUnusualActivity(List<OptionUnusualTrade> Trades = default(List<OptionUnusualTrade>))
        {
            this.Trades = Trades;
        }
        
        /// <summary>
        /// A list of unusual trades for a given company identifier
        /// </summary>
        /// <value>A list of unusual trades for a given company identifier</value>
        [DataMember(Name="trades", EmitDefaultValue=false)]
        public List<OptionUnusualTrade> Trades { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsUnusualActivity {\n");
            sb.Append("  Trades: ").Append(Trades).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsUnusualActivity);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsUnusualActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsUnusualActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsUnusualActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Trades == input.Trades ||
                    this.Trades != null &&
                    this.Trades.SequenceEqual(input.Trades)
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
                if (this.Trades != null)
                    hashCode = hashCode * 59 + this.Trades.GetHashCode();
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

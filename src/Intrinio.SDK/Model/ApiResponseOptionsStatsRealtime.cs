

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
    /// ApiResponseOptionsStatsRealtime
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsStatsRealtime :  IEquatable<ApiResponseOptionsStatsRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsStatsRealtime" /> class.
        /// </summary>
        /// <param name="Stats">Stats.</param>
        /// <param name="Factors">Factors.</param>
        /// <param name="Option">Option.</param>
        public ApiResponseOptionsStatsRealtime(OptionStatsRealtime Stats = default(OptionStatsRealtime), OptionFactorsRealtime Factors = default(OptionFactorsRealtime), OptionRealtime Option = default(OptionRealtime))
        {
            this.Stats = Stats;
            this.Factors = Factors;
            this.Option = Option;
        }
        
        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public OptionStatsRealtime Stats { get; set; }

        /// <summary>
        /// Gets or Sets Factors
        /// </summary>
        [DataMember(Name="factors", EmitDefaultValue=false)]
        public OptionFactorsRealtime Factors { get; set; }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public OptionRealtime Option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsStatsRealtime {\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Factors: ").Append(Factors).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsStatsRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsStatsRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsStatsRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsStatsRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Factors == input.Factors ||
                    (this.Factors != null &&
                    this.Factors.Equals(input.Factors))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.Factors != null)
                    hashCode = hashCode * 59 + this.Factors.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
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

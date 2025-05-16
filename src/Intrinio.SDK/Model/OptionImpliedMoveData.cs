

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
    /// The data pertaining to the implied move.
    /// </summary>
    [DataContract]
    public partial class OptionImpliedMoveData :  IEquatable<OptionImpliedMoveData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionImpliedMoveData" /> class.
        /// </summary>
        /// <param name="Amount">The amount of the implied move..</param>
        /// <param name="Percentage">The percentage of the implied move..</param>
        public OptionImpliedMoveData(decimal? Amount = default(decimal?), decimal? Percentage = default(decimal?))
        {
            this.Amount = Amount;
            this.Percentage = Percentage;
        }
        
        /// <summary>
        /// The amount of the implied move.
        /// </summary>
        /// <value>The amount of the implied move.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The percentage of the implied move.
        /// </summary>
        /// <value>The percentage of the implied move.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionImpliedMoveData {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(input as OptionImpliedMoveData);
        }

        /// <summary>
        /// Returns true if OptionImpliedMoveData instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionImpliedMoveData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionImpliedMoveData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
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

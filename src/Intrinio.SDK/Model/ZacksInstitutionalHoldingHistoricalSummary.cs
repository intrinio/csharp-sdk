

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
    /// Returns number of shares held in previous quarters
    /// </summary>
    [DataContract]
    public partial class ZacksInstitutionalHoldingHistoricalSummary :  IEquatable<ZacksInstitutionalHoldingHistoricalSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksInstitutionalHoldingHistoricalSummary" /> class.
        /// </summary>
        /// <param name="AsOfDate">The date of the institutional holding.</param>
        /// <param name="SharesHeld">The number of shares held.</param>
        public ZacksInstitutionalHoldingHistoricalSummary(DateTime? AsOfDate = default(DateTime?), decimal? SharesHeld = default(decimal?))
        {
            this.AsOfDate = AsOfDate;
            this.SharesHeld = SharesHeld;
        }
        
        /// <summary>
        /// The date of the institutional holding
        /// </summary>
        /// <value>The date of the institutional holding</value>
        [DataMember(Name="as_of_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AsOfDate { get; set; }

        /// <summary>
        /// The number of shares held
        /// </summary>
        /// <value>The number of shares held</value>
        [DataMember(Name="shares_held", EmitDefaultValue=false)]
        public decimal? SharesHeld { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksInstitutionalHoldingHistoricalSummary {\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  SharesHeld: ").Append(SharesHeld).Append("\n");
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
            return this.Equals(input as ZacksInstitutionalHoldingHistoricalSummary);
        }

        /// <summary>
        /// Returns true if ZacksInstitutionalHoldingHistoricalSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksInstitutionalHoldingHistoricalSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksInstitutionalHoldingHistoricalSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.SharesHeld == input.SharesHeld ||
                    (this.SharesHeld != null &&
                    this.SharesHeld.Equals(input.SharesHeld))
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
                if (this.AsOfDate != null)
                    hashCode = hashCode * 59 + this.AsOfDate.GetHashCode();
                if (this.SharesHeld != null)
                    hashCode = hashCode * 59 + this.SharesHeld.GetHashCode();
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

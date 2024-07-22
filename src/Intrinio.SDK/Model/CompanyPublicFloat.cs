

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
    /// A public float data point.
    /// </summary>
    [DataContract]
    public partial class CompanyPublicFloat :  IEquatable<CompanyPublicFloat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyPublicFloat" /> class.
        /// </summary>
        /// <param name="Date">The date of the public float..</param>
        /// <param name="FilingDate">The filing date of the public float..</param>
        /// <param name="PublicFloatValue">The dollar value for company float..</param>
        /// <param name="PublicFloatShares">The public shares for the company..</param>
        public CompanyPublicFloat(DateTime? Date = default(DateTime?), DateTime? FilingDate = default(DateTime?), decimal? PublicFloatValue = default(decimal?), decimal? PublicFloatShares = default(decimal?))
        {
            this.Date = Date;
            this.FilingDate = FilingDate;
            this.PublicFloatValue = PublicFloatValue;
            this.PublicFloatShares = PublicFloatShares;
        }
        
        /// <summary>
        /// The date of the public float.
        /// </summary>
        /// <value>The date of the public float.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The filing date of the public float.
        /// </summary>
        /// <value>The filing date of the public float.</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FilingDate { get; set; }

        /// <summary>
        /// The dollar value for company float.
        /// </summary>
        /// <value>The dollar value for company float.</value>
        [DataMember(Name="public_float_value", EmitDefaultValue=false)]
        public decimal? PublicFloatValue { get; set; }

        /// <summary>
        /// The public shares for the company.
        /// </summary>
        /// <value>The public shares for the company.</value>
        [DataMember(Name="public_float_shares", EmitDefaultValue=false)]
        public decimal? PublicFloatShares { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyPublicFloat {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
            sb.Append("  PublicFloatValue: ").Append(PublicFloatValue).Append("\n");
            sb.Append("  PublicFloatShares: ").Append(PublicFloatShares).Append("\n");
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
            return this.Equals(input as CompanyPublicFloat);
        }

        /// <summary>
        /// Returns true if CompanyPublicFloat instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyPublicFloat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyPublicFloat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
                ) && 
                (
                    this.PublicFloatValue == input.PublicFloatValue ||
                    (this.PublicFloatValue != null &&
                    this.PublicFloatValue.Equals(input.PublicFloatValue))
                ) && 
                (
                    this.PublicFloatShares == input.PublicFloatShares ||
                    (this.PublicFloatShares != null &&
                    this.PublicFloatShares.Equals(input.PublicFloatShares))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
                if (this.PublicFloatValue != null)
                    hashCode = hashCode * 59 + this.PublicFloatValue.GetHashCode();
                if (this.PublicFloatShares != null)
                    hashCode = hashCode * 59 + this.PublicFloatShares.GetHashCode();
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

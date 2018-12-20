

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
    /// A financial statement as-reported, directly from the financial statements of the XBRL filings from the company.
    /// </summary>
    [DataContract]
    public partial class ReportedFinancial :  IEquatable<ReportedFinancial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportedFinancial" /> class.
        /// </summary>
        /// <param name="XbrlTag">XbrlTag.</param>
        /// <param name="Value">The value reported for the XBRL Tag within the scope of the Fundamental.</param>
        public ReportedFinancial(ReportedTag XbrlTag = default(ReportedTag), decimal? Value = default(decimal?))
        {
            this.XbrlTag = XbrlTag;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets XbrlTag
        /// </summary>
        [DataMember(Name="xbrl_tag", EmitDefaultValue=false)]
        public ReportedTag XbrlTag { get; set; }

        /// <summary>
        /// The value reported for the XBRL Tag within the scope of the Fundamental
        /// </summary>
        /// <value>The value reported for the XBRL Tag within the scope of the Fundamental</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportedFinancial {\n");
            sb.Append("  XbrlTag: ").Append(XbrlTag).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ReportedFinancial);
        }

        /// <summary>
        /// Returns true if ReportedFinancial instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportedFinancial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportedFinancial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XbrlTag == input.XbrlTag ||
                    (this.XbrlTag != null &&
                    this.XbrlTag.Equals(input.XbrlTag))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.XbrlTag != null)
                    hashCode = hashCode * 59 + this.XbrlTag.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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

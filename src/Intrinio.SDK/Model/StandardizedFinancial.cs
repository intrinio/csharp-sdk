

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
    /// Professional-grade historical financial data for a Company. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as-reported financial statements because of the inherent complexity of reporting standards.
    /// </summary>
    [DataContract]
    public partial class StandardizedFinancial :  IEquatable<StandardizedFinancial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedFinancial" /> class.
        /// </summary>
        /// <param name="DataTag">DataTag.</param>
        /// <param name="Value">The value for the Data Tag within the scope of the Fundamental.</param>
        public StandardizedFinancial(DataTagSummary DataTag = default(DataTagSummary), decimal? Value = default(decimal?))
        {
            this.DataTag = DataTag;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets DataTag
        /// </summary>
        [DataMember(Name="data_tag", EmitDefaultValue=false)]
        public DataTagSummary DataTag { get; set; }

        /// <summary>
        /// The value for the Data Tag within the scope of the Fundamental
        /// </summary>
        /// <value>The value for the Data Tag within the scope of the Fundamental</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardizedFinancial {\n");
            sb.Append("  DataTag: ").Append(DataTag).Append("\n");
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
            return this.Equals(input as StandardizedFinancial);
        }

        /// <summary>
        /// Returns true if StandardizedFinancial instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardizedFinancial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardizedFinancial input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataTag == input.DataTag ||
                    (this.DataTag != null &&
                    this.DataTag.Equals(input.DataTag))
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
                if (this.DataTag != null)
                    hashCode = hashCode * 59 + this.DataTag.GetHashCode();
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

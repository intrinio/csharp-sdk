

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
    /// SecurityScreenResultData
    /// </summary>
    [DataContract]
    public partial class SecurityScreenResultData :  IEquatable<SecurityScreenResultData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityScreenResultData" /> class.
        /// </summary>
        /// <param name="Tag">The data tag that was screened-for.</param>
        /// <param name="NumberValue">The numeric value for the tag.</param>
        /// <param name="TextValue">The text value for the tag.</param>
        public SecurityScreenResultData(string Tag = default(string), string NumberValue = default(string), string TextValue = default(string))
        {
            this.Tag = Tag;
            this.NumberValue = NumberValue;
            this.TextValue = TextValue;
        }
        
        /// <summary>
        /// The data tag that was screened-for
        /// </summary>
        /// <value>The data tag that was screened-for</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The numeric value for the tag
        /// </summary>
        /// <value>The numeric value for the tag</value>
        [DataMember(Name="number_value", EmitDefaultValue=false)]
        public string NumberValue { get; set; }

        /// <summary>
        /// The text value for the tag
        /// </summary>
        /// <value>The text value for the tag</value>
        [DataMember(Name="text_value", EmitDefaultValue=false)]
        public string TextValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityScreenResultData {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  NumberValue: ").Append(NumberValue).Append("\n");
            sb.Append("  TextValue: ").Append(TextValue).Append("\n");
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
            return this.Equals(input as SecurityScreenResultData);
        }

        /// <summary>
        /// Returns true if SecurityScreenResultData instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityScreenResultData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityScreenResultData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.NumberValue == input.NumberValue ||
                    (this.NumberValue != null &&
                    this.NumberValue.Equals(input.NumberValue))
                ) && 
                (
                    this.TextValue == input.TextValue ||
                    (this.TextValue != null &&
                    this.TextValue.Equals(input.TextValue))
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
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.NumberValue != null)
                    hashCode = hashCode * 59 + this.NumberValue.GetHashCode();
                if (this.TextValue != null)
                    hashCode = hashCode * 59 + this.TextValue.GetHashCode();
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



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
    /// An XBRL tag as-reported by the company on the as-reported financial statement
    /// </summary>
    [DataContract]
    public partial class ReportedTag :  IEquatable<ReportedTag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportedTag" /> class.
        /// </summary>
        /// <param name="Tag">The tag code.</param>
        /// <param name="Name">The tag name.</param>
        /// <param name="Balance">Whether the tag represents a credit or debit.</param>
        /// <param name="Unit">The unit of the tag.</param>
        /// <param name="Abstract">If true, the tag is an abstract and does not represent a nominal value.</param>
        /// <param name="Sequence">The vertical sequence of the tag when displayed in the financial statement.</param>
        /// <param name="Depth">The horizontal depth of the tag when displayed in the financial statement.</param>
        public ReportedTag(string Tag = default(string), string Name = default(string), string Balance = default(string), string Unit = default(string), bool? Abstract = default(bool?), int? Sequence = default(int?), int? Depth = default(int?))
        {
            this.Tag = Tag;
            this.Name = Name;
            this.Balance = Balance;
            this.Unit = Unit;
            this.Abstract = Abstract;
            this.Sequence = Sequence;
            this.Depth = Depth;
        }
        
        /// <summary>
        /// The tag code
        /// </summary>
        /// <value>The tag code</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The tag name
        /// </summary>
        /// <value>The tag name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the tag represents a credit or debit
        /// </summary>
        /// <value>Whether the tag represents a credit or debit</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// The unit of the tag
        /// </summary>
        /// <value>The unit of the tag</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// If true, the tag is an abstract and does not represent a nominal value
        /// </summary>
        /// <value>If true, the tag is an abstract and does not represent a nominal value</value>
        [DataMember(Name="abstract", EmitDefaultValue=false)]
        public bool? Abstract { get; set; }

        /// <summary>
        /// The vertical sequence of the tag when displayed in the financial statement
        /// </summary>
        /// <value>The vertical sequence of the tag when displayed in the financial statement</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// The horizontal depth of the tag when displayed in the financial statement
        /// </summary>
        /// <value>The horizontal depth of the tag when displayed in the financial statement</value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public int? Depth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportedTag {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Abstract: ").Append(Abstract).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
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
            return this.Equals(input as ReportedTag);
        }

        /// <summary>
        /// Returns true if ReportedTag instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportedTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportedTag input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Abstract == input.Abstract ||
                    (this.Abstract != null &&
                    this.Abstract.Equals(input.Abstract))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Abstract != null)
                    hashCode = hashCode * 59 + this.Abstract.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
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

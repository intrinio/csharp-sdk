

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
    /// A group of clauses and groups combined with a logic operator, used to screen securities
    /// </summary>
    [DataContract]
    public partial class SecurityScreenGroup :  IEquatable<SecurityScreenGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityScreenGroup" /> class.
        /// </summary>
        /// <param name="_Operator">The logic operator for the group (AND, OR, NOT).</param>
        /// <param name="Clauses">The logic clauses in the group.</param>
        /// <param name="Groups">The nested groups within the group.</param>
        public SecurityScreenGroup(string _Operator = default(string), List<SecurityScreenClause> Clauses = default(List<SecurityScreenClause>), List<SecurityScreenGroup> Groups = default(List<SecurityScreenGroup>))
        {
            this._Operator = _Operator;
            this.Clauses = Clauses;
            this.Groups = Groups;
        }
        
        /// <summary>
        /// The logic operator for the group (AND, OR, NOT)
        /// </summary>
        /// <value>The logic operator for the group (AND, OR, NOT)</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string _Operator { get; set; }

        /// <summary>
        /// The logic clauses in the group
        /// </summary>
        /// <value>The logic clauses in the group</value>
        [DataMember(Name="clauses", EmitDefaultValue=false)]
        public List<SecurityScreenClause> Clauses { get; set; }

        /// <summary>
        /// The nested groups within the group
        /// </summary>
        /// <value>The nested groups within the group</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<SecurityScreenGroup> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityScreenGroup {\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Clauses: ").Append(Clauses).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as SecurityScreenGroup);
        }

        /// <summary>
        /// Returns true if SecurityScreenGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityScreenGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityScreenGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Operator == input._Operator ||
                    (this._Operator != null &&
                    this._Operator.Equals(input._Operator))
                ) && 
                (
                    this.Clauses == input.Clauses ||
                    this.Clauses != null &&
                    this.Clauses.SequenceEqual(input.Clauses)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this._Operator != null)
                    hashCode = hashCode * 59 + this._Operator.GetHashCode();
                if (this.Clauses != null)
                    hashCode = hashCode * 59 + this.Clauses.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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

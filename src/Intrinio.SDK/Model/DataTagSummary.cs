

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
    /// DataTagSummary
    /// </summary>
    [DataContract]
    public partial class DataTagSummary :  IEquatable<DataTagSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTagSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the Data Tag.</param>
        /// <param name="Name">The readable name of the Data Tag.</param>
        /// <param name="Tag">The code-name of the Data Tag.</param>
        /// <param name="Parent">The parent Data Tag forming the statement relationship with the factor.</param>
        /// <param name="Sequence">The order in which the Data Tag appears in its logical group (such as a financial statement).</param>
        /// <param name="Factor">The operator forming the statement relationship between the child Data Tag (or Data Tags) and the parent Data Tag.</param>
        /// <param name="Balance">Whether the Data Tag represents a credit or debit.</param>
        /// <param name="Unit">The unit of the Data Tag.</param>
        public DataTagSummary(string Id = default(string), string Name = default(string), string Tag = default(string), string Parent = default(string), decimal? Sequence = default(decimal?), string Factor = default(string), string Balance = default(string), string Unit = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Tag = Tag;
            this.Parent = Parent;
            this.Sequence = Sequence;
            this.Factor = Factor;
            this.Balance = Balance;
            this.Unit = Unit;
        }
        
        /// <summary>
        /// The Intrinio ID for the Data Tag
        /// </summary>
        /// <value>The Intrinio ID for the Data Tag</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The readable name of the Data Tag
        /// </summary>
        /// <value>The readable name of the Data Tag</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The code-name of the Data Tag
        /// </summary>
        /// <value>The code-name of the Data Tag</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The parent Data Tag forming the statement relationship with the factor
        /// </summary>
        /// <value>The parent Data Tag forming the statement relationship with the factor</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }

        /// <summary>
        /// The order in which the Data Tag appears in its logical group (such as a financial statement)
        /// </summary>
        /// <value>The order in which the Data Tag appears in its logical group (such as a financial statement)</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public decimal? Sequence { get; set; }

        /// <summary>
        /// The operator forming the statement relationship between the child Data Tag (or Data Tags) and the parent Data Tag
        /// </summary>
        /// <value>The operator forming the statement relationship between the child Data Tag (or Data Tags) and the parent Data Tag</value>
        [DataMember(Name="factor", EmitDefaultValue=false)]
        public string Factor { get; set; }

        /// <summary>
        /// Whether the Data Tag represents a credit or debit
        /// </summary>
        /// <value>Whether the Data Tag represents a credit or debit</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// The unit of the Data Tag
        /// </summary>
        /// <value>The unit of the Data Tag</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataTagSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as DataTagSummary);
        }

        /// <summary>
        /// Returns true if DataTagSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTagSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTagSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Factor == input.Factor ||
                    (this.Factor != null &&
                    this.Factor.Equals(input.Factor))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Factor != null)
                    hashCode = hashCode * 59 + this.Factor.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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

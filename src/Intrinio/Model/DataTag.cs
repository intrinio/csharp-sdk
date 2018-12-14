

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// DataTag
    /// </summary>
    [DataContract]
    public partial class DataTag :  IEquatable<DataTag>, IValidatableObject
    {
        /// <summary>
        /// The format of the financial statment to which this Data Tag belongs
        /// </summary>
        /// <value>The format of the financial statment to which this Data Tag belongs</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatementTypeEnum
        {
            
            /// <summary>
            /// Enum Financial for value: "financial"
            /// </summary>
            [EnumMember(Value = "financial")]
            Financial = 1,
            
            /// <summary>
            /// Enum Industrial for value: "industrial"
            /// </summary>
            [EnumMember(Value = "industrial")]
            Industrial = 2
        }

        /// <summary>
        /// The format of the financial statment to which this Data Tag belongs
        /// </summary>
        /// <value>The format of the financial statment to which this Data Tag belongs</value>
        [DataMember(Name="statement_type", EmitDefaultValue=false)]
        public StatementTypeEnum? StatementType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTag" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the Data Tag.</param>
        /// <param name="Name">The readable name of the Data Tag.</param>
        /// <param name="Tag">The code-name of the Data Tag.</param>
        /// <param name="StatementCode">The code of the financial statement to which this Data Tag belongs.</param>
        /// <param name="StatementType">The format of the financial statment to which this Data Tag belongs.</param>
        /// <param name="Parent">The parent Data Tag forming the statement relationship with the factor.</param>
        /// <param name="Factor">The operator forming the statement relationship between the child Data Tag (or Data Tags) and the parent Data Tag.</param>
        /// <param name="Balance">Whether the Data Tag represents a credit or debit.</param>
        /// <param name="Type">The nature of the Data Tag, operating or nonoperating.</param>
        /// <param name="Unit">The unit of the Data Tag.</param>
        public DataTag(string Id = default(string), string Name = default(string), string Tag = default(string), string StatementCode = default(string), StatementTypeEnum? StatementType = default(StatementTypeEnum?), string Parent = default(string), string Factor = default(string), string Balance = default(string), string Type = default(string), string Unit = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Tag = Tag;
            this.StatementCode = StatementCode;
            this.StatementType = StatementType;
            this.Parent = Parent;
            this.Factor = Factor;
            this.Balance = Balance;
            this.Type = Type;
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
        /// The code of the financial statement to which this Data Tag belongs
        /// </summary>
        /// <value>The code of the financial statement to which this Data Tag belongs</value>
        [DataMember(Name="statement_code", EmitDefaultValue=false)]
        public string StatementCode { get; set; }


        /// <summary>
        /// The parent Data Tag forming the statement relationship with the factor
        /// </summary>
        /// <value>The parent Data Tag forming the statement relationship with the factor</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }

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
        /// The nature of the Data Tag, operating or nonoperating
        /// </summary>
        /// <value>The nature of the Data Tag, operating or nonoperating</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

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
            sb.Append("class DataTag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  StatementCode: ").Append(StatementCode).Append("\n");
            sb.Append("  StatementType: ").Append(StatementType).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Factor: ").Append(Factor).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DataTag);
        }

        /// <summary>
        /// Returns true if DataTag instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTag input)
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
                    this.StatementCode == input.StatementCode ||
                    (this.StatementCode != null &&
                    this.StatementCode.Equals(input.StatementCode))
                ) && 
                (
                    this.StatementType == input.StatementType ||
                    (this.StatementType != null &&
                    this.StatementType.Equals(input.StatementType))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.StatementCode != null)
                    hashCode = hashCode * 59 + this.StatementCode.GetHashCode();
                if (this.StatementType != null)
                    hashCode = hashCode * 59 + this.StatementType.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.Factor != null)
                    hashCode = hashCode * 59 + this.Factor.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

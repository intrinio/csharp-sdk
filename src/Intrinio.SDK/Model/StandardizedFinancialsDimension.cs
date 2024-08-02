

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
    /// An axis-member combination related to a reported XBRL fact, which denotes a facet of an XBRL dimension.
    /// </summary>
    [DataContract]
    public partial class StandardizedFinancialsDimension :  IEquatable<StandardizedFinancialsDimension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedFinancialsDimension" /> class.
        /// </summary>
        /// <param name="Dimension">The title of the dimension.</param>
        /// <param name="Value">The value of the dimension.</param>
        public StandardizedFinancialsDimension(string Dimension = default(string), string Value = default(string))
        {
            this.Dimension = Dimension;
            this.Value = Value;
        }
        
        /// <summary>
        /// The title of the dimension
        /// </summary>
        /// <value>The title of the dimension</value>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// The value of the dimension
        /// </summary>
        /// <value>The value of the dimension</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardizedFinancialsDimension {\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
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
            return this.Equals(input as StandardizedFinancialsDimension);
        }

        /// <summary>
        /// Returns true if StandardizedFinancialsDimension instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardizedFinancialsDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardizedFinancialsDimension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
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
                if (this.Dimension != null)
                    hashCode = hashCode * 59 + this.Dimension.GetHashCode();
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

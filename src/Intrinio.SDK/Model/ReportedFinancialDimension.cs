

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
    public partial class ReportedFinancialDimension :  IEquatable<ReportedFinancialDimension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportedFinancialDimension" /> class.
        /// </summary>
        /// <param name="Axis">The axis of the dimension.</param>
        /// <param name="Member">The member of the axis.</param>
        public ReportedFinancialDimension(string Axis = default(string), string Member = default(string))
        {
            this.Axis = Axis;
            this.Member = Member;
        }
        
        /// <summary>
        /// The axis of the dimension
        /// </summary>
        /// <value>The axis of the dimension</value>
        [DataMember(Name="axis", EmitDefaultValue=false)]
        public string Axis { get; set; }

        /// <summary>
        /// The member of the axis
        /// </summary>
        /// <value>The member of the axis</value>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public string Member { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportedFinancialDimension {\n");
            sb.Append("  Axis: ").Append(Axis).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
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
            return this.Equals(input as ReportedFinancialDimension);
        }

        /// <summary>
        /// Returns true if ReportedFinancialDimension instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportedFinancialDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportedFinancialDimension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Axis == input.Axis ||
                    (this.Axis != null &&
                    this.Axis.Equals(input.Axis))
                ) && 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
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
                if (this.Axis != null)
                    hashCode = hashCode * 59 + this.Axis.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
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

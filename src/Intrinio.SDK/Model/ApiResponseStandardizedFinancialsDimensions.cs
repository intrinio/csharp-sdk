

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
    /// ApiResponseStandardizedFinancialsDimensions
    /// </summary>
    [DataContract]
    public partial class ApiResponseStandardizedFinancialsDimensions :  IEquatable<ApiResponseStandardizedFinancialsDimensions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseStandardizedFinancialsDimensions" /> class.
        /// </summary>
        /// <param name="Dimensions">The combination of XBRL axis and members that defines the dimensionalization of this fact (if any).</param>
        /// <param name="DataTag">DataTag.</param>
        /// <param name="Fundamental">Fundamental.</param>
        public ApiResponseStandardizedFinancialsDimensions(List<StandardizedFinancialsDimension> Dimensions = default(List<StandardizedFinancialsDimension>), DataTagSummary DataTag = default(DataTagSummary), Fundamental Fundamental = default(Fundamental))
        {
            this.Dimensions = Dimensions;
            this.DataTag = DataTag;
            this.Fundamental = Fundamental;
        }
        
        /// <summary>
        /// The combination of XBRL axis and members that defines the dimensionalization of this fact (if any)
        /// </summary>
        /// <value>The combination of XBRL axis and members that defines the dimensionalization of this fact (if any)</value>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public List<StandardizedFinancialsDimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets DataTag
        /// </summary>
        [DataMember(Name="data_tag", EmitDefaultValue=false)]
        public DataTagSummary DataTag { get; set; }

        /// <summary>
        /// Gets or Sets Fundamental
        /// </summary>
        [DataMember(Name="fundamental", EmitDefaultValue=false)]
        public Fundamental Fundamental { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseStandardizedFinancialsDimensions {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  DataTag: ").Append(DataTag).Append("\n");
            sb.Append("  Fundamental: ").Append(Fundamental).Append("\n");
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
            return this.Equals(input as ApiResponseStandardizedFinancialsDimensions);
        }

        /// <summary>
        /// Returns true if ApiResponseStandardizedFinancialsDimensions instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseStandardizedFinancialsDimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseStandardizedFinancialsDimensions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.DataTag == input.DataTag ||
                    (this.DataTag != null &&
                    this.DataTag.Equals(input.DataTag))
                ) && 
                (
                    this.Fundamental == input.Fundamental ||
                    (this.Fundamental != null &&
                    this.Fundamental.Equals(input.Fundamental))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.DataTag != null)
                    hashCode = hashCode * 59 + this.DataTag.GetHashCode();
                if (this.Fundamental != null)
                    hashCode = hashCode * 59 + this.Fundamental.GetHashCode();
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



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
    /// ApiResponseMunicipalitiyFinancials
    /// </summary>
    [DataContract]
    public partial class ApiResponseMunicipalitiyFinancials :  IEquatable<ApiResponseMunicipalitiyFinancials>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseMunicipalitiyFinancials" /> class.
        /// </summary>
        /// <param name="Financials">Financials.</param>
        /// <param name="Municipality">Municipality.</param>
        public ApiResponseMunicipalitiyFinancials(List<MunicipalityFinancial> Financials = default(List<MunicipalityFinancial>), Municipality Municipality = default(Municipality))
        {
            this.Financials = Financials;
            this.Municipality = Municipality;
        }
        
        /// <summary>
        /// Gets or Sets Financials
        /// </summary>
        [DataMember(Name="financials", EmitDefaultValue=false)]
        public List<MunicipalityFinancial> Financials { get; set; }

        /// <summary>
        /// Gets or Sets Municipality
        /// </summary>
        [DataMember(Name="municipality", EmitDefaultValue=false)]
        public Municipality Municipality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseMunicipalitiyFinancials {\n");
            sb.Append("  Financials: ").Append(Financials).Append("\n");
            sb.Append("  Municipality: ").Append(Municipality).Append("\n");
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
            return this.Equals(input as ApiResponseMunicipalitiyFinancials);
        }

        /// <summary>
        /// Returns true if ApiResponseMunicipalitiyFinancials instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseMunicipalitiyFinancials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseMunicipalitiyFinancials input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Financials == input.Financials ||
                    this.Financials != null &&
                    this.Financials.SequenceEqual(input.Financials)
                ) && 
                (
                    this.Municipality == input.Municipality ||
                    (this.Municipality != null &&
                    this.Municipality.Equals(input.Municipality))
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
                if (this.Financials != null)
                    hashCode = hashCode * 59 + this.Financials.GetHashCode();
                if (this.Municipality != null)
                    hashCode = hashCode * 59 + this.Municipality.GetHashCode();
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

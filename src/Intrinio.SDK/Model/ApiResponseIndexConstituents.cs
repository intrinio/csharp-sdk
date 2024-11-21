

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
    /// ApiResponseIndexConstituents
    /// </summary>
    [DataContract]
    public partial class ApiResponseIndexConstituents :  IEquatable<ApiResponseIndexConstituents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseIndexConstituents" /> class.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <param name="Date">The date when an update was last received for the index constituents.</param>
        /// <param name="Constituents">Constituents.</param>
        public ApiResponseIndexConstituents(ApiResponseIndex Index = default(ApiResponseIndex), DateTime? Date = default(DateTime?), List<SecuritySummary> Constituents = default(List<SecuritySummary>))
        {
            this.Index = Index;
            this.Date = Date;
            this.Constituents = Constituents;
        }
        
        /// <summary>
        /// The index
        /// </summary>
        /// <value>The index</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public ApiResponseIndex Index { get; set; }

        /// <summary>
        /// The date when an update was last received for the index constituents
        /// </summary>
        /// <value>The date when an update was last received for the index constituents</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Constituents
        /// </summary>
        [DataMember(Name="constituents", EmitDefaultValue=false)]
        public List<SecuritySummary> Constituents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseIndexConstituents {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Constituents: ").Append(Constituents).Append("\n");
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
            return this.Equals(input as ApiResponseIndexConstituents);
        }

        /// <summary>
        /// Returns true if ApiResponseIndexConstituents instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseIndexConstituents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseIndexConstituents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Constituents == input.Constituents ||
                    this.Constituents != null &&
                    this.Constituents.SequenceEqual(input.Constituents)
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Constituents != null)
                    hashCode = hashCode * 59 + this.Constituents.GetHashCode();
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

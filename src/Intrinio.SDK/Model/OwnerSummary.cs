

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
    /// The summary of an insider and institutional owner of securities covered by Intrinio
    /// </summary>
    [DataContract]
    public partial class OwnerSummary :  IEquatable<OwnerSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerSummary" /> class.
        /// </summary>
        /// <param name="OwnerCik">The Central Index Key issued by the SEC, which is the unique identifier all owner filings.</param>
        /// <param name="OwnerName">The name of the owner.</param>
        public OwnerSummary(string OwnerCik = default(string), string OwnerName = default(string))
        {
            this.OwnerCik = OwnerCik;
            this.OwnerName = OwnerName;
        }
        
        /// <summary>
        /// The Central Index Key issued by the SEC, which is the unique identifier all owner filings
        /// </summary>
        /// <value>The Central Index Key issued by the SEC, which is the unique identifier all owner filings</value>
        [DataMember(Name="owner_cik", EmitDefaultValue=false)]
        public string OwnerCik { get; set; }

        /// <summary>
        /// The name of the owner
        /// </summary>
        /// <value>The name of the owner</value>
        [DataMember(Name="owner_name", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnerSummary {\n");
            sb.Append("  OwnerCik: ").Append(OwnerCik).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
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
            return this.Equals(input as OwnerSummary);
        }

        /// <summary>
        /// Returns true if OwnerSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnerSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnerSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerCik == input.OwnerCik ||
                    (this.OwnerCik != null &&
                    this.OwnerCik.Equals(input.OwnerCik))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
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
                if (this.OwnerCik != null)
                    hashCode = hashCode * 59 + this.OwnerCik.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
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

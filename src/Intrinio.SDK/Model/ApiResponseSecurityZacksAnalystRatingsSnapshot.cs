

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
    /// ApiResponseSecurityZacksAnalystRatingsSnapshot
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityZacksAnalystRatingsSnapshot :  IEquatable<ApiResponseSecurityZacksAnalystRatingsSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityZacksAnalystRatingsSnapshot" /> class.
        /// </summary>
        /// <param name="Snapshots">Snapshots.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        public ApiResponseSecurityZacksAnalystRatingsSnapshot(List<ZacksAnalystRatingSnapshot> Snapshots = default(List<ZacksAnalystRatingSnapshot>), SecuritySummary Security = default(SecuritySummary))
        {
            this.Snapshots = Snapshots;
            this.Security = Security;
        }
        
        /// <summary>
        /// Gets or Sets Snapshots
        /// </summary>
        [DataMember(Name="snapshots", EmitDefaultValue=false)]
        public List<ZacksAnalystRatingSnapshot> Snapshots { get; set; }

        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityZacksAnalystRatingsSnapshot {\n");
            sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityZacksAnalystRatingsSnapshot);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityZacksAnalystRatingsSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityZacksAnalystRatingsSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityZacksAnalystRatingsSnapshot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Snapshots == input.Snapshots ||
                    this.Snapshots != null &&
                    this.Snapshots.SequenceEqual(input.Snapshots)
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.Snapshots != null)
                    hashCode = hashCode * 59 + this.Snapshots.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

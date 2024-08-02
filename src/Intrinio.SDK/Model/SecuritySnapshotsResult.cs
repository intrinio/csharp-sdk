

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
    /// A security snapshot result contains all security snapshot groups corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class SecuritySnapshotsResult :  IEquatable<SecuritySnapshotsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySnapshotsResult" /> class.
        /// </summary>
        /// <param name="Snapshots">List of all the snapshot groups comprising the queried result..</param>
        public SecuritySnapshotsResult(List<SecuritySnapshotGroup> Snapshots = default(List<SecuritySnapshotGroup>))
        {
            this.Snapshots = Snapshots;
        }
        
        /// <summary>
        /// List of all the snapshot groups comprising the queried result.
        /// </summary>
        /// <value>List of all the snapshot groups comprising the queried result.</value>
        [DataMember(Name="snapshots", EmitDefaultValue=false)]
        public List<SecuritySnapshotGroup> Snapshots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySnapshotsResult {\n");
            sb.Append("  Snapshots: ").Append(Snapshots).Append("\n");
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
            return this.Equals(input as SecuritySnapshotsResult);
        }

        /// <summary>
        /// Returns true if SecuritySnapshotsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SecuritySnapshotsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecuritySnapshotsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Snapshots == input.Snapshots ||
                    this.Snapshots != null &&
                    this.Snapshots.SequenceEqual(input.Snapshots)
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

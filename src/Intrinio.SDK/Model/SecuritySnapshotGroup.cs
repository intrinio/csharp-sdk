

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
    /// A security snapshot group contains all security snapshot parts for a given point in time.
    /// </summary>
    [DataContract]
    public partial class SecuritySnapshotGroup :  IEquatable<SecuritySnapshotGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySnapshotGroup" /> class.
        /// </summary>
        /// <param name="Time">The UTC timestamp of this snapshot group..</param>
        /// <param name="Files">List of all the snapshot parts of this group..</param>
        public SecuritySnapshotGroup(DateTime? Time = default(DateTime?), List<Object> Files = default(List<Object>))
        {
            this.Time = Time;
            this.Files = Files;
        }
        
        /// <summary>
        /// The UTC timestamp of this snapshot group.
        /// </summary>
        /// <value>The UTC timestamp of this snapshot group.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// List of all the snapshot parts of this group.
        /// </summary>
        /// <value>List of all the snapshot parts of this group.</value>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<Object> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySnapshotGroup {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
            return this.Equals(input as SecuritySnapshotGroup);
        }

        /// <summary>
        /// Returns true if SecuritySnapshotGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of SecuritySnapshotGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecuritySnapshotGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(input.Files)
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
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

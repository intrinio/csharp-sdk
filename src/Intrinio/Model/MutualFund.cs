

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
    /// An investment program funded by shareholders that trades in diversified holdings and is professionally managed
    /// </summary>
    [DataContract]
    public partial class MutualFund :  IEquatable<MutualFund>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFund" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the mutual fund.</param>
        /// <param name="Name">The mutual fund&#39;s common name.</param>
        /// <param name="Cusip">The nine-character CUSIP identifier.</param>
        /// <param name="VendorId">The vendor-provided id of the mutual fund.</param>
        public MutualFund(string Id = default(string), string Name = default(string), string Cusip = default(string), string VendorId = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Cusip = Cusip;
            this.VendorId = VendorId;
        }
        
        /// <summary>
        /// The Intrinio ID of the mutual fund
        /// </summary>
        /// <value>The Intrinio ID of the mutual fund</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The mutual fund&#39;s common name
        /// </summary>
        /// <value>The mutual fund&#39;s common name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The nine-character CUSIP identifier
        /// </summary>
        /// <value>The nine-character CUSIP identifier</value>
        [DataMember(Name="cusip", EmitDefaultValue=false)]
        public string Cusip { get; set; }

        /// <summary>
        /// The vendor-provided id of the mutual fund
        /// </summary>
        /// <value>The vendor-provided id of the mutual fund</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public string VendorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MutualFund {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Cusip: ").Append(Cusip).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
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
            return this.Equals(input as MutualFund);
        }

        /// <summary>
        /// Returns true if MutualFund instances are equal
        /// </summary>
        /// <param name="input">Instance of MutualFund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MutualFund input)
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
                    this.Cusip == input.Cusip ||
                    (this.Cusip != null &&
                    this.Cusip.Equals(input.Cusip))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
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
                if (this.Cusip != null)
                    hashCode = hashCode * 59 + this.Cusip.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
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

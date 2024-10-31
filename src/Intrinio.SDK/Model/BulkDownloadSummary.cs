

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
    /// Information about bulk downloads with download links
    /// </summary>
    [DataContract]
    public partial class BulkDownloadSummary :  IEquatable<BulkDownloadSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDownloadSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the bulk download.</param>
        /// <param name="Name">The name of the bulk download.</param>
        /// <param name="Format">The file format of the bulk download.</param>
        /// <param name="DataLengthBytes">The total length of the bulk download data in bytes.</param>
        /// <param name="UpdateFrequency">The update frequency for the bulk download.</param>
        /// <param name="LastUpdated">The date on which the bulk download was last updated.</param>
        /// <param name="Links">Links to all of the files comprising the bulk download. Links expire in 24 hours..</param>
        public BulkDownloadSummary(string Id = default(string), string Name = default(string), string Format = default(string), string DataLengthBytes = default(string), string UpdateFrequency = default(string), DateTime? LastUpdated = default(DateTime?), List<BulkDownloadLinks> Links = default(List<BulkDownloadLinks>))
        {
            this.Id = Id;
            this.Name = Name;
            this.Format = Format;
            this.DataLengthBytes = DataLengthBytes;
            this.UpdateFrequency = UpdateFrequency;
            this.LastUpdated = LastUpdated;
            this.Links = Links;
        }
        
        /// <summary>
        /// The Intrinio ID of the bulk download
        /// </summary>
        /// <value>The Intrinio ID of the bulk download</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the bulk download
        /// </summary>
        /// <value>The name of the bulk download</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The file format of the bulk download
        /// </summary>
        /// <value>The file format of the bulk download</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// The total length of the bulk download data in bytes
        /// </summary>
        /// <value>The total length of the bulk download data in bytes</value>
        [DataMember(Name="data_length_bytes", EmitDefaultValue=false)]
        public string DataLengthBytes { get; set; }

        /// <summary>
        /// The update frequency for the bulk download
        /// </summary>
        /// <value>The update frequency for the bulk download</value>
        [DataMember(Name="update_frequency", EmitDefaultValue=false)]
        public string UpdateFrequency { get; set; }

        /// <summary>
        /// The date on which the bulk download was last updated
        /// </summary>
        /// <value>The date on which the bulk download was last updated</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Links to all of the files comprising the bulk download. Links expire in 24 hours.
        /// </summary>
        /// <value>Links to all of the files comprising the bulk download. Links expire in 24 hours.</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<BulkDownloadLinks> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkDownloadSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  DataLengthBytes: ").Append(DataLengthBytes).Append("\n");
            sb.Append("  UpdateFrequency: ").Append(UpdateFrequency).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as BulkDownloadSummary);
        }

        /// <summary>
        /// Returns true if BulkDownloadSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkDownloadSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkDownloadSummary input)
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
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.DataLengthBytes == input.DataLengthBytes ||
                    (this.DataLengthBytes != null &&
                    this.DataLengthBytes.Equals(input.DataLengthBytes))
                ) && 
                (
                    this.UpdateFrequency == input.UpdateFrequency ||
                    (this.UpdateFrequency != null &&
                    this.UpdateFrequency.Equals(input.UpdateFrequency))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.DataLengthBytes != null)
                    hashCode = hashCode * 59 + this.DataLengthBytes.GetHashCode();
                if (this.UpdateFrequency != null)
                    hashCode = hashCode * 59 + this.UpdateFrequency.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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

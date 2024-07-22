

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
    /// Document from which Thea answer data is sourced
    /// </summary>
    [DataContract]
    public partial class TheaSourceDocument :  IEquatable<TheaSourceDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheaSourceDocument" /> class.
        /// </summary>
        /// <param name="Id">The unique id for the Thea source document.</param>
        /// <param name="DateTime">The date at which the document was created.</param>
        /// <param name="Tags">Entity identifying tags associated with the source document.</param>
        public TheaSourceDocument(string Id = default(string), DateTime? DateTime = default(DateTime?), List<Object> Tags = default(List<Object>))
        {
            this.Id = Id;
            this.DateTime = DateTime;
            this.Tags = Tags;
        }
        
        /// <summary>
        /// The unique id for the Thea source document
        /// </summary>
        /// <value>The unique id for the Thea source document</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date at which the document was created
        /// </summary>
        /// <value>The date at which the document was created</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Entity identifying tags associated with the source document
        /// </summary>
        /// <value>Entity identifying tags associated with the source document</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TheaSourceDocument {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as TheaSourceDocument);
        }

        /// <summary>
        /// Returns true if TheaSourceDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of TheaSourceDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TheaSourceDocument input)
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
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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



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
    /// A news article about a company
    /// </summary>
    [DataContract]
    public partial class CompanyNewsSummary :  IEquatable<CompanyNewsSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyNewsSummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the news article.</param>
        /// <param name="Title">The title of the news article.</param>
        /// <param name="PublicationDate">The publication date of the news article.</param>
        /// <param name="Url">The url of the news article.</param>
        /// <param name="Summary">A summary of the news article.</param>
        public CompanyNewsSummary(string Id = default(string), string Title = default(string), DateTime? PublicationDate = default(DateTime?), string Url = default(string), string Summary = default(string))
        {
            this.Id = Id;
            this.Title = Title;
            this.PublicationDate = PublicationDate;
            this.Url = Url;
            this.Summary = Summary;
        }
        
        /// <summary>
        /// The Intrinio ID for the news article
        /// </summary>
        /// <value>The Intrinio ID for the news article</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The title of the news article
        /// </summary>
        /// <value>The title of the news article</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The publication date of the news article
        /// </summary>
        /// <value>The publication date of the news article</value>
        [DataMember(Name="publication_date", EmitDefaultValue=false)]
        public DateTime? PublicationDate { get; set; }

        /// <summary>
        /// The url of the news article
        /// </summary>
        /// <value>The url of the news article</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// A summary of the news article
        /// </summary>
        /// <value>A summary of the news article</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyNewsSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(input as CompanyNewsSummary);
        }

        /// <summary>
        /// Returns true if CompanyNewsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyNewsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyNewsSummary input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
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

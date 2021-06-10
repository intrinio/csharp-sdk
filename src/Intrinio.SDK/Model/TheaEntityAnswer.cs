

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
    /// An answer object returned by Thea in response to a query about a specific entity
    /// </summary>
    [DataContract]
    public partial class TheaEntityAnswer :  IEquatable<TheaEntityAnswer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TheaEntityAnswer" /> class.
        /// </summary>
        /// <param name="Answer">The summarized answer returned from Thea.</param>
        /// <param name="Content">The underlying content the answer was sourced from.</param>
        /// <param name="SourceDocuments">SourceDocuments.</param>
        public TheaEntityAnswer(string Answer = default(string), string Content = default(string), List<TheaSourceDocument> SourceDocuments = default(List<TheaSourceDocument>))
        {
            this.Answer = Answer;
            this.Content = Content;
            this.SourceDocuments = SourceDocuments;
        }
        
        /// <summary>
        /// The summarized answer returned from Thea
        /// </summary>
        /// <value>The summarized answer returned from Thea</value>
        [DataMember(Name="answer", EmitDefaultValue=false)]
        public string Answer { get; set; }

        /// <summary>
        /// The underlying content the answer was sourced from
        /// </summary>
        /// <value>The underlying content the answer was sourced from</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets SourceDocuments
        /// </summary>
        [DataMember(Name="source_documents", EmitDefaultValue=false)]
        public List<TheaSourceDocument> SourceDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TheaEntityAnswer {\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  SourceDocuments: ").Append(SourceDocuments).Append("\n");
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
            return this.Equals(input as TheaEntityAnswer);
        }

        /// <summary>
        /// Returns true if TheaEntityAnswer instances are equal
        /// </summary>
        /// <param name="input">Instance of TheaEntityAnswer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TheaEntityAnswer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Answer == input.Answer ||
                    (this.Answer != null &&
                    this.Answer.Equals(input.Answer))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.SourceDocuments == input.SourceDocuments ||
                    this.SourceDocuments != null &&
                    this.SourceDocuments.SequenceEqual(input.SourceDocuments)
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
                if (this.Answer != null)
                    hashCode = hashCode * 59 + this.Answer.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.SourceDocuments != null)
                    hashCode = hashCode * 59 + this.SourceDocuments.GetHashCode();
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

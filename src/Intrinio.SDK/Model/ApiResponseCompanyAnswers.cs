

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
    /// ApiResponseCompanyAnswers
    /// </summary>
    [DataContract]
    public partial class ApiResponseCompanyAnswers :  IEquatable<ApiResponseCompanyAnswers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanyAnswers" /> class.
        /// </summary>
        /// <param name="Source">The organziation the answer data was sourced from.</param>
        /// <param name="Query">The query posed to the Thea API.</param>
        /// <param name="Answers">Answers.</param>
        public ApiResponseCompanyAnswers(string Source = default(string), string Query = default(string), List<TheaEntityAnswer> Answers = default(List<TheaEntityAnswer>))
        {
            this.Source = Source;
            this.Query = Query;
            this.Answers = Answers;
        }
        
        /// <summary>
        /// The organziation the answer data was sourced from
        /// </summary>
        /// <value>The organziation the answer data was sourced from</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// The query posed to the Thea API
        /// </summary>
        /// <value>The query posed to the Thea API</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Answers
        /// </summary>
        [DataMember(Name="answers", EmitDefaultValue=false)]
        public List<TheaEntityAnswer> Answers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCompanyAnswers {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Answers: ").Append(Answers).Append("\n");
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
            return this.Equals(input as ApiResponseCompanyAnswers);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanyAnswers instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCompanyAnswers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanyAnswers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Answers == input.Answers ||
                    this.Answers != null &&
                    this.Answers.SequenceEqual(input.Answers)
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Answers != null)
                    hashCode = hashCode * 59 + this.Answers.GetHashCode();
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

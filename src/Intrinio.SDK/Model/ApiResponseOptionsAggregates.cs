

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
    /// ApiResponseOptionsAggregates
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsAggregates :  IEquatable<ApiResponseOptionsAggregates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsAggregates" /> class.
        /// </summary>
        /// <param name="Aggregates">A list of option expiration dates in descending order.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseOptionsAggregates(List<OptionsAggregate> Aggregates = default(List<OptionsAggregate>), string NextPage = default(string))
        {
            this.Aggregates = Aggregates;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// A list of option expiration dates in descending order
        /// </summary>
        /// <value>A list of option expiration dates in descending order</value>
        [DataMember(Name="aggregates", EmitDefaultValue=false)]
        public List<OptionsAggregate> Aggregates { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsAggregates {\n");
            sb.Append("  Aggregates: ").Append(Aggregates).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsAggregates);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsAggregates instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsAggregates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsAggregates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aggregates == input.Aggregates ||
                    this.Aggregates != null &&
                    this.Aggregates.SequenceEqual(input.Aggregates)
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.Aggregates != null)
                    hashCode = hashCode * 59 + this.Aggregates.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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

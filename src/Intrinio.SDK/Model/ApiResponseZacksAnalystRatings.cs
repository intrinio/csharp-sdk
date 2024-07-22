

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
    /// ApiResponseZacksAnalystRatings
    /// </summary>
    [DataContract]
    public partial class ApiResponseZacksAnalystRatings :  IEquatable<ApiResponseZacksAnalystRatings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseZacksAnalystRatings" /> class.
        /// </summary>
        /// <param name="AnalystRatings">AnalystRatings.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseZacksAnalystRatings(List<ZacksAnalystRating> AnalystRatings = default(List<ZacksAnalystRating>), string NextPage = default(string))
        {
            this.AnalystRatings = AnalystRatings;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets AnalystRatings
        /// </summary>
        [DataMember(Name="analyst_ratings", EmitDefaultValue=false)]
        public List<ZacksAnalystRating> AnalystRatings { get; set; }

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
            sb.Append("class ApiResponseZacksAnalystRatings {\n");
            sb.Append("  AnalystRatings: ").Append(AnalystRatings).Append("\n");
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
            return this.Equals(input as ApiResponseZacksAnalystRatings);
        }

        /// <summary>
        /// Returns true if ApiResponseZacksAnalystRatings instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseZacksAnalystRatings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseZacksAnalystRatings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnalystRatings == input.AnalystRatings ||
                    this.AnalystRatings != null &&
                    this.AnalystRatings.SequenceEqual(input.AnalystRatings)
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
                if (this.AnalystRatings != null)
                    hashCode = hashCode * 59 + this.AnalystRatings.GetHashCode();
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

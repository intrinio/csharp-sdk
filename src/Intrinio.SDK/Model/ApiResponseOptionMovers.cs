

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
    /// A paginated API response containing a list of top-moving options contracts based on criteria like volume, price change, or other market activity indicators.
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionMovers :  IEquatable<ApiResponseOptionMovers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionMovers" /> class.
        /// </summary>
        /// <param name="Movers">Movers.</param>
        /// <param name="NextPage">A pagination token for retrieving the next page of results, if available. Null or absent if no further pages exist..</param>
        public ApiResponseOptionMovers(List<OptionMover> Movers = default(List<OptionMover>), string NextPage = default(string))
        {
            this.Movers = Movers;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets Movers
        /// </summary>
        [DataMember(Name="movers", EmitDefaultValue=false)]
        public List<OptionMover> Movers { get; set; }

        /// <summary>
        /// A pagination token for retrieving the next page of results, if available. Null or absent if no further pages exist.
        /// </summary>
        /// <value>A pagination token for retrieving the next page of results, if available. Null or absent if no further pages exist.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionMovers {\n");
            sb.Append("  Movers: ").Append(Movers).Append("\n");
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
            return this.Equals(input as ApiResponseOptionMovers);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionMovers instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionMovers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionMovers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Movers == input.Movers ||
                    this.Movers != null &&
                    this.Movers.SequenceEqual(input.Movers)
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
                if (this.Movers != null)
                    hashCode = hashCode * 59 + this.Movers.GetHashCode();
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

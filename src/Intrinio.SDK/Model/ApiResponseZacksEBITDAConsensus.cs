

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
    /// ApiResponseZacksEBITDAConsensus
    /// </summary>
    [DataContract]
    public partial class ApiResponseZacksEBITDAConsensus :  IEquatable<ApiResponseZacksEBITDAConsensus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseZacksEBITDAConsensus" /> class.
        /// </summary>
        /// <param name="EbitdaConsensuses">Zacks target price consensuses for the latest date.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseZacksEBITDAConsensus(List<ZacksEBITDAConsensus> EbitdaConsensuses = default(List<ZacksEBITDAConsensus>), string NextPage = default(string))
        {
            this.EbitdaConsensuses = EbitdaConsensuses;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Zacks target price consensuses for the latest date
        /// </summary>
        /// <value>Zacks target price consensuses for the latest date</value>
        [DataMember(Name="ebitda_consensuses", EmitDefaultValue=false)]
        public List<ZacksEBITDAConsensus> EbitdaConsensuses { get; set; }

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
            sb.Append("class ApiResponseZacksEBITDAConsensus {\n");
            sb.Append("  EbitdaConsensuses: ").Append(EbitdaConsensuses).Append("\n");
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
            return this.Equals(input as ApiResponseZacksEBITDAConsensus);
        }

        /// <summary>
        /// Returns true if ApiResponseZacksEBITDAConsensus instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseZacksEBITDAConsensus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseZacksEBITDAConsensus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EbitdaConsensuses == input.EbitdaConsensuses ||
                    this.EbitdaConsensuses != null &&
                    this.EbitdaConsensuses.SequenceEqual(input.EbitdaConsensuses)
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
                if (this.EbitdaConsensuses != null)
                    hashCode = hashCode * 59 + this.EbitdaConsensuses.GetHashCode();
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

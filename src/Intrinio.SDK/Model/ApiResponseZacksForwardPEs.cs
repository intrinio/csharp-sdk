

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
    /// ApiResponseZacksForwardPEs
    /// </summary>
    [DataContract]
    public partial class ApiResponseZacksForwardPEs :  IEquatable<ApiResponseZacksForwardPEs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseZacksForwardPEs" /> class.
        /// </summary>
        /// <param name="ForwardPe">Zacks forward PE ratio estimates.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseZacksForwardPEs(List<ZacksForwardPE> ForwardPe = default(List<ZacksForwardPE>), string NextPage = default(string))
        {
            this.ForwardPe = ForwardPe;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Zacks forward PE ratio estimates
        /// </summary>
        /// <value>Zacks forward PE ratio estimates</value>
        [DataMember(Name="forward_pe", EmitDefaultValue=false)]
        public List<ZacksForwardPE> ForwardPe { get; set; }

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
            sb.Append("class ApiResponseZacksForwardPEs {\n");
            sb.Append("  ForwardPe: ").Append(ForwardPe).Append("\n");
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
            return this.Equals(input as ApiResponseZacksForwardPEs);
        }

        /// <summary>
        /// Returns true if ApiResponseZacksForwardPEs instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseZacksForwardPEs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseZacksForwardPEs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForwardPe == input.ForwardPe ||
                    this.ForwardPe != null &&
                    this.ForwardPe.SequenceEqual(input.ForwardPe)
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
                if (this.ForwardPe != null)
                    hashCode = hashCode * 59 + this.ForwardPe.GetHashCode();
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

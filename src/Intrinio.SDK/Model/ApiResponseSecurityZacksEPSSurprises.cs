

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
    /// ApiResponseSecurityZacksEPSSurprises
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityZacksEPSSurprises :  IEquatable<ApiResponseSecurityZacksEPSSurprises>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityZacksEPSSurprises" /> class.
        /// </summary>
        /// <param name="EpsSurprises">EpsSurprises.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseSecurityZacksEPSSurprises(List<ZacksEPSSurpriseSummary> EpsSurprises = default(List<ZacksEPSSurpriseSummary>), SecuritySummary Security = default(SecuritySummary), string NextPage = default(string))
        {
            this.EpsSurprises = EpsSurprises;
            this.Security = Security;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets EpsSurprises
        /// </summary>
        [DataMember(Name="eps_surprises", EmitDefaultValue=false)]
        public List<ZacksEPSSurpriseSummary> EpsSurprises { get; set; }

        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// The token required to request the next page of the data
        /// </summary>
        /// <value>The token required to request the next page of the data</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityZacksEPSSurprises {\n");
            sb.Append("  EpsSurprises: ").Append(EpsSurprises).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityZacksEPSSurprises);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityZacksEPSSurprises instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityZacksEPSSurprises to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityZacksEPSSurprises input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EpsSurprises == input.EpsSurprises ||
                    this.EpsSurprises != null &&
                    this.EpsSurprises.SequenceEqual(input.EpsSurprises)
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.EpsSurprises != null)
                    hashCode = hashCode * 59 + this.EpsSurprises.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

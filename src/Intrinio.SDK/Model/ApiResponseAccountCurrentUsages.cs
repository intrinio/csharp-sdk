

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
    /// ApiResponseAccountCurrentUsages
    /// </summary>
    [DataContract]
    public partial class ApiResponseAccountCurrentUsages :  IEquatable<ApiResponseAccountCurrentUsages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseAccountCurrentUsages" /> class.
        /// </summary>
        /// <param name="Usage">Usage.</param>
        /// <param name="Account">Account.</param>
        public ApiResponseAccountCurrentUsages(List<AccountCurrentUsage> Usage = default(List<AccountCurrentUsage>), ApiResponseAccountCurrentUsagesAccount Account = default(ApiResponseAccountCurrentUsagesAccount))
        {
            this.Usage = Usage;
            this.Account = Account;
        }
        
        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public List<AccountCurrentUsage> Usage { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public ApiResponseAccountCurrentUsagesAccount Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseAccountCurrentUsages {\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as ApiResponseAccountCurrentUsages);
        }

        /// <summary>
        /// Returns true if ApiResponseAccountCurrentUsages instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseAccountCurrentUsages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseAccountCurrentUsages input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Usage == input.Usage ||
                    this.Usage != null &&
                    this.Usage.SequenceEqual(input.Usage)
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
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

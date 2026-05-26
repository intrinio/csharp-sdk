

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
    /// The current websocket statuses on an account.
    /// </summary>
    [DataContract]
    public partial class ApiResponseWebsocketStatuses :  IEquatable<ApiResponseWebsocketStatuses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseWebsocketStatuses" /> class.
        /// </summary>
        /// <param name="Statuses">The websocket statuses on the account..</param>
        /// <param name="Account">Account.</param>
        public ApiResponseWebsocketStatuses(List<AccountWebsocketStatus> Statuses = default(List<AccountWebsocketStatus>), ApiResponseAccountUsagesAccount Account = default(ApiResponseAccountUsagesAccount))
        {
            this.Statuses = Statuses;
            this.Account = Account;
        }
        
        /// <summary>
        /// The websocket statuses on the account.
        /// </summary>
        /// <value>The websocket statuses on the account.</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<AccountWebsocketStatus> Statuses { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public ApiResponseAccountUsagesAccount Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseWebsocketStatuses {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
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
            return this.Equals(input as ApiResponseWebsocketStatuses);
        }

        /// <summary>
        /// Returns true if ApiResponseWebsocketStatuses instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseWebsocketStatuses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseWebsocketStatuses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
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
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
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

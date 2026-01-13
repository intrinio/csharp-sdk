

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
    /// The usage summary for a particular access code.
    /// </summary>
    [DataContract]
    public partial class AccountCurrentUsage :  IEquatable<AccountCurrentUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCurrentUsage" /> class.
        /// </summary>
        /// <param name="AccessCode">The access code..</param>
        /// <param name="Restriction">Restrictions on this access code..</param>
        /// <param name="Count">The current count of API calls using this access code for this period..</param>
        /// <param name="Limit">The limit for this access code.</param>
        /// <param name="SecondsUntilReset">The period in seconds for count reset..</param>
        /// <param name="PercentageUsed">The percentage of limit used..</param>
        public AccountCurrentUsage(string AccessCode = default(string), string Restriction = default(string), string Count = default(string), string Limit = default(string), string SecondsUntilReset = default(string), string PercentageUsed = default(string))
        {
            this.AccessCode = AccessCode;
            this.Restriction = Restriction;
            this.Count = Count;
            this.Limit = Limit;
            this.SecondsUntilReset = SecondsUntilReset;
            this.PercentageUsed = PercentageUsed;
        }
        
        /// <summary>
        /// The access code.
        /// </summary>
        /// <value>The access code.</value>
        [DataMember(Name="access_code", EmitDefaultValue=false)]
        public string AccessCode { get; set; }

        /// <summary>
        /// Restrictions on this access code.
        /// </summary>
        /// <value>Restrictions on this access code.</value>
        [DataMember(Name="restriction", EmitDefaultValue=false)]
        public string Restriction { get; set; }

        /// <summary>
        /// The current count of API calls using this access code for this period.
        /// </summary>
        /// <value>The current count of API calls using this access code for this period.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public string Count { get; set; }

        /// <summary>
        /// The limit for this access code
        /// </summary>
        /// <value>The limit for this access code</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public string Limit { get; set; }

        /// <summary>
        /// The period in seconds for count reset.
        /// </summary>
        /// <value>The period in seconds for count reset.</value>
        [DataMember(Name="seconds_until_reset", EmitDefaultValue=false)]
        public string SecondsUntilReset { get; set; }

        /// <summary>
        /// The percentage of limit used.
        /// </summary>
        /// <value>The percentage of limit used.</value>
        [DataMember(Name="percentage_used", EmitDefaultValue=false)]
        public string PercentageUsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountCurrentUsage {\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  Restriction: ").Append(Restriction).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  SecondsUntilReset: ").Append(SecondsUntilReset).Append("\n");
            sb.Append("  PercentageUsed: ").Append(PercentageUsed).Append("\n");
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
            return this.Equals(input as AccountCurrentUsage);
        }

        /// <summary>
        /// Returns true if AccountCurrentUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountCurrentUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountCurrentUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessCode == input.AccessCode ||
                    (this.AccessCode != null &&
                    this.AccessCode.Equals(input.AccessCode))
                ) && 
                (
                    this.Restriction == input.Restriction ||
                    (this.Restriction != null &&
                    this.Restriction.Equals(input.Restriction))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.SecondsUntilReset == input.SecondsUntilReset ||
                    (this.SecondsUntilReset != null &&
                    this.SecondsUntilReset.Equals(input.SecondsUntilReset))
                ) && 
                (
                    this.PercentageUsed == input.PercentageUsed ||
                    (this.PercentageUsed != null &&
                    this.PercentageUsed.Equals(input.PercentageUsed))
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
                if (this.AccessCode != null)
                    hashCode = hashCode * 59 + this.AccessCode.GetHashCode();
                if (this.Restriction != null)
                    hashCode = hashCode * 59 + this.Restriction.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SecondsUntilReset != null)
                    hashCode = hashCode * 59 + this.SecondsUntilReset.GetHashCode();
                if (this.PercentageUsed != null)
                    hashCode = hashCode * 59 + this.PercentageUsed.GetHashCode();
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



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
    /// SecurityTradingStatusSummary
    /// </summary>
    [DataContract]
    public partial class SecurityTradingStatusSummary :  IEquatable<SecurityTradingStatusSummary>, IValidatableObject
    {
        /// <summary>
        /// The trading status of the security.
        /// </summary>
        /// <value>The trading status of the security.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TradingStatusEnum
        {
            
            /// <summary>
            /// Enum Trading for value: trading
            /// </summary>
            [EnumMember(Value = "trading")]
            Trading = 1,
            
            /// <summary>
            /// Enum Quotesonly for value: quotes_only
            /// </summary>
            [EnumMember(Value = "quotes_only")]
            Quotesonly = 2,
            
            /// <summary>
            /// Enum Stopped for value: stopped
            /// </summary>
            [EnumMember(Value = "stopped")]
            Stopped = 3
        }

        /// <summary>
        /// The trading status of the security.
        /// </summary>
        /// <value>The trading status of the security.</value>
        [DataMember(Name="trading_status", EmitDefaultValue=false)]
        public TradingStatusEnum? TradingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityTradingStatusSummary" /> class.
        /// </summary>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="TradingStatus">The trading status of the security..</param>
        /// <param name="TradingStatusReason">The exchange supplied reason for its current status..</param>
        /// <param name="TradingStatusUpdatedOn">The time the exchange reported that it changed its trading status..</param>
        public SecurityTradingStatusSummary(SecuritySummary Security = default(SecuritySummary), TradingStatusEnum? TradingStatus = default(TradingStatusEnum?), string TradingStatusReason = default(string), DateTime? TradingStatusUpdatedOn = default(DateTime?))
        {
            this.Security = Security;
            this.TradingStatus = TradingStatus;
            this.TradingStatusReason = TradingStatusReason;
            this.TradingStatusUpdatedOn = TradingStatusUpdatedOn;
        }
        
        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }


        /// <summary>
        /// The exchange supplied reason for its current status.
        /// </summary>
        /// <value>The exchange supplied reason for its current status.</value>
        [DataMember(Name="trading_status_reason", EmitDefaultValue=false)]
        public string TradingStatusReason { get; set; }

        /// <summary>
        /// The time the exchange reported that it changed its trading status.
        /// </summary>
        /// <value>The time the exchange reported that it changed its trading status.</value>
        [DataMember(Name="trading_status_updated_on", EmitDefaultValue=false)]
        public DateTime? TradingStatusUpdatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityTradingStatusSummary {\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  TradingStatus: ").Append(TradingStatus).Append("\n");
            sb.Append("  TradingStatusReason: ").Append(TradingStatusReason).Append("\n");
            sb.Append("  TradingStatusUpdatedOn: ").Append(TradingStatusUpdatedOn).Append("\n");
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
            return this.Equals(input as SecurityTradingStatusSummary);
        }

        /// <summary>
        /// Returns true if SecurityTradingStatusSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityTradingStatusSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityTradingStatusSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.TradingStatus == input.TradingStatus ||
                    (this.TradingStatus != null &&
                    this.TradingStatus.Equals(input.TradingStatus))
                ) && 
                (
                    this.TradingStatusReason == input.TradingStatusReason ||
                    (this.TradingStatusReason != null &&
                    this.TradingStatusReason.Equals(input.TradingStatusReason))
                ) && 
                (
                    this.TradingStatusUpdatedOn == input.TradingStatusUpdatedOn ||
                    (this.TradingStatusUpdatedOn != null &&
                    this.TradingStatusUpdatedOn.Equals(input.TradingStatusUpdatedOn))
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
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.TradingStatus != null)
                    hashCode = hashCode * 59 + this.TradingStatus.GetHashCode();
                if (this.TradingStatusReason != null)
                    hashCode = hashCode * 59 + this.TradingStatusReason.GetHashCode();
                if (this.TradingStatusUpdatedOn != null)
                    hashCode = hashCode * 59 + this.TradingStatusUpdatedOn.GetHashCode();
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

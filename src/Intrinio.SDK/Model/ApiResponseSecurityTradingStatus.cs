

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
    /// ApiResponseSecurityTradingStatus
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityTradingStatus :  IEquatable<ApiResponseSecurityTradingStatus>, IValidatableObject
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
        /// The status of the market.
        /// </summary>
        /// <value>The status of the market.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarketStatusEnum
        {
            
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,
            
            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,
            
            /// <summary>
            /// Enum Premarket for value: premarket
            /// </summary>
            [EnumMember(Value = "premarket")]
            Premarket = 3,
            
            /// <summary>
            /// Enum Postmarket for value: postmarket
            /// </summary>
            [EnumMember(Value = "postmarket")]
            Postmarket = 4,
            
            /// <summary>
            /// Enum Closedearly for value: closed_early
            /// </summary>
            [EnumMember(Value = "closed_early")]
            Closedearly = 5
        }

        /// <summary>
        /// The status of the market.
        /// </summary>
        /// <value>The status of the market.</value>
        [DataMember(Name="market_status", EmitDefaultValue=false)]
        public MarketStatusEnum? MarketStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityTradingStatus" /> class.
        /// </summary>
        /// <param name="TradingStatus">The trading status of the security..</param>
        /// <param name="TradingStatusReason">The exchange supplied reason for its current status..</param>
        /// <param name="TradingStatusUpdatedOn">The time the exchange reported that it changed its trading status..</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="MarketStatus">The status of the market..</param>
        /// <param name="Messages">A list of messages related to the request, such as warnings or errors..</param>
        public ApiResponseSecurityTradingStatus(TradingStatusEnum? TradingStatus = default(TradingStatusEnum?), string TradingStatusReason = default(string), DateTime? TradingStatusUpdatedOn = default(DateTime?), SecuritySummary Security = default(SecuritySummary), MarketStatusEnum? MarketStatus = default(MarketStatusEnum?), List<string> Messages = default(List<string>))
        {
            this.TradingStatus = TradingStatus;
            this.TradingStatusReason = TradingStatusReason;
            this.TradingStatusUpdatedOn = TradingStatusUpdatedOn;
            this.Security = Security;
            this.MarketStatus = MarketStatus;
            this.Messages = Messages;
        }
        

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
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }


        /// <summary>
        /// A list of messages related to the request, such as warnings or errors.
        /// </summary>
        /// <value>A list of messages related to the request, such as warnings or errors.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityTradingStatus {\n");
            sb.Append("  TradingStatus: ").Append(TradingStatus).Append("\n");
            sb.Append("  TradingStatusReason: ").Append(TradingStatusReason).Append("\n");
            sb.Append("  TradingStatusUpdatedOn: ").Append(TradingStatusUpdatedOn).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  MarketStatus: ").Append(MarketStatus).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityTradingStatus);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityTradingStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityTradingStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityTradingStatus input)
        {
            if (input == null)
                return false;

            return 
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
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.MarketStatus == input.MarketStatus ||
                    (this.MarketStatus != null &&
                    this.MarketStatus.Equals(input.MarketStatus))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.TradingStatus != null)
                    hashCode = hashCode * 59 + this.TradingStatus.GetHashCode();
                if (this.TradingStatusReason != null)
                    hashCode = hashCode * 59 + this.TradingStatusReason.GetHashCode();
                if (this.TradingStatusUpdatedOn != null)
                    hashCode = hashCode * 59 + this.TradingStatusUpdatedOn.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.MarketStatus != null)
                    hashCode = hashCode * 59 + this.MarketStatus.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
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

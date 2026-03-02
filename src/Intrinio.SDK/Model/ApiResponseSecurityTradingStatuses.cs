

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
    /// ApiResponseSecurityTradingStatuses
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityTradingStatuses :  IEquatable<ApiResponseSecurityTradingStatuses>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="ApiResponseSecurityTradingStatuses" /> class.
        /// </summary>
        /// <param name="Statuses">The trading statuses of each returned security..</param>
        /// <param name="MarketStatus">The status of the market..</param>
        /// <param name="Messages">A list of messages related to the request, such as warnings or errors..</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityTradingStatuses(List<SecurityTradingStatusSummary> Statuses = default(List<SecurityTradingStatusSummary>), MarketStatusEnum? MarketStatus = default(MarketStatusEnum?), List<string> Messages = default(List<string>), string NextPage = default(string))
        {
            this.Statuses = Statuses;
            this.MarketStatus = MarketStatus;
            this.Messages = Messages;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The trading statuses of each returned security.
        /// </summary>
        /// <value>The trading statuses of each returned security.</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<SecurityTradingStatusSummary> Statuses { get; set; }


        /// <summary>
        /// A list of messages related to the request, such as warnings or errors.
        /// </summary>
        /// <value>A list of messages related to the request, such as warnings or errors.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

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
            sb.Append("class ApiResponseSecurityTradingStatuses {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  MarketStatus: ").Append(MarketStatus).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityTradingStatuses);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityTradingStatuses instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityTradingStatuses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityTradingStatuses input)
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
                    this.MarketStatus == input.MarketStatus ||
                    (this.MarketStatus != null &&
                    this.MarketStatus.Equals(input.MarketStatus))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
                if (this.MarketStatus != null)
                    hashCode = hashCode * 59 + this.MarketStatus.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
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

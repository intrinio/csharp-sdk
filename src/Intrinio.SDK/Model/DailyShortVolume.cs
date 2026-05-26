

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
    /// Daily short volume data for a security at a specific FINRA reporting facility. This represents off-exchange activity reported by a single market center or third-party reporting facility. 
    /// </summary>
    [DataContract]
    public partial class DailyShortVolume :  IEquatable<DailyShortVolume>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyShortVolume" /> class.
        /// </summary>
        /// <param name="SecurityId">The unique identifier of the security..</param>
        /// <param name="Symbol">The ticker symbol of the security..</param>
        /// <param name="TradeDate">The date of the reported short volume data in YYYY-MM-DD format..</param>
        /// <param name="ReportingFacilityCode">The FINRA-assigned facility code identifying which market center or reporting facility reported this short volume. Different facilities may report different short volumes for the same security on the same date..</param>
        /// <param name="TotalVolume">The total volume of shares traded at this facility. This includes both long and short sales..</param>
        /// <param name="ShortVolume">The volume of shares sold short at this facility. Short sales represent bearish positions or hedging activity..</param>
        /// <param name="ShortExemptVolume">The volume of shares sold short with exemptions (e.g., pre-borrow arrangements, market maker activities). These shorts are legally exempt from certain short sale restrictions..</param>
        /// <param name="ShortVolumeRatio">The ratio of short volume to total volume at this facility, rounded to 4 decimal places. Ranges from 0.0 to 1.0. A higher ratio indicates more short selling activity relative to overall trading volume..</param>
        public DailyShortVolume(string SecurityId = default(string), string Symbol = default(string), DateTime? TradeDate = default(DateTime?), string ReportingFacilityCode = default(string), int? TotalVolume = default(int?), int? ShortVolume = default(int?), int? ShortExemptVolume = default(int?), double? ShortVolumeRatio = default(double?))
        {
            this.SecurityId = SecurityId;
            this.Symbol = Symbol;
            this.TradeDate = TradeDate;
            this.ReportingFacilityCode = ReportingFacilityCode;
            this.TotalVolume = TotalVolume;
            this.ShortVolume = ShortVolume;
            this.ShortExemptVolume = ShortExemptVolume;
            this.ShortVolumeRatio = ShortVolumeRatio;
        }
        
        /// <summary>
        /// The unique identifier of the security.
        /// </summary>
        /// <value>The unique identifier of the security.</value>
        [DataMember(Name="security_id", EmitDefaultValue=false)]
        public string SecurityId { get; set; }

        /// <summary>
        /// The ticker symbol of the security.
        /// </summary>
        /// <value>The ticker symbol of the security.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The date of the reported short volume data in YYYY-MM-DD format.
        /// </summary>
        /// <value>The date of the reported short volume data in YYYY-MM-DD format.</value>
        [DataMember(Name="trade_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TradeDate { get; set; }

        /// <summary>
        /// The FINRA-assigned facility code identifying which market center or reporting facility reported this short volume. Different facilities may report different short volumes for the same security on the same date.
        /// </summary>
        /// <value>The FINRA-assigned facility code identifying which market center or reporting facility reported this short volume. Different facilities may report different short volumes for the same security on the same date.</value>
        [DataMember(Name="reporting_facility_code", EmitDefaultValue=false)]
        public string ReportingFacilityCode { get; set; }

        /// <summary>
        /// The total volume of shares traded at this facility. This includes both long and short sales.
        /// </summary>
        /// <value>The total volume of shares traded at this facility. This includes both long and short sales.</value>
        [DataMember(Name="total_volume", EmitDefaultValue=false)]
        public int? TotalVolume { get; set; }

        /// <summary>
        /// The volume of shares sold short at this facility. Short sales represent bearish positions or hedging activity.
        /// </summary>
        /// <value>The volume of shares sold short at this facility. Short sales represent bearish positions or hedging activity.</value>
        [DataMember(Name="short_volume", EmitDefaultValue=false)]
        public int? ShortVolume { get; set; }

        /// <summary>
        /// The volume of shares sold short with exemptions (e.g., pre-borrow arrangements, market maker activities). These shorts are legally exempt from certain short sale restrictions.
        /// </summary>
        /// <value>The volume of shares sold short with exemptions (e.g., pre-borrow arrangements, market maker activities). These shorts are legally exempt from certain short sale restrictions.</value>
        [DataMember(Name="short_exempt_volume", EmitDefaultValue=false)]
        public int? ShortExemptVolume { get; set; }

        /// <summary>
        /// The ratio of short volume to total volume at this facility, rounded to 4 decimal places. Ranges from 0.0 to 1.0. A higher ratio indicates more short selling activity relative to overall trading volume.
        /// </summary>
        /// <value>The ratio of short volume to total volume at this facility, rounded to 4 decimal places. Ranges from 0.0 to 1.0. A higher ratio indicates more short selling activity relative to overall trading volume.</value>
        [DataMember(Name="short_volume_ratio", EmitDefaultValue=false)]
        public double? ShortVolumeRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyShortVolume {\n");
            sb.Append("  SecurityId: ").Append(SecurityId).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  ReportingFacilityCode: ").Append(ReportingFacilityCode).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
            sb.Append("  ShortVolume: ").Append(ShortVolume).Append("\n");
            sb.Append("  ShortExemptVolume: ").Append(ShortExemptVolume).Append("\n");
            sb.Append("  ShortVolumeRatio: ").Append(ShortVolumeRatio).Append("\n");
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
            return this.Equals(input as DailyShortVolume);
        }

        /// <summary>
        /// Returns true if DailyShortVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyShortVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyShortVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecurityId == input.SecurityId ||
                    (this.SecurityId != null &&
                    this.SecurityId.Equals(input.SecurityId))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.TradeDate == input.TradeDate ||
                    (this.TradeDate != null &&
                    this.TradeDate.Equals(input.TradeDate))
                ) && 
                (
                    this.ReportingFacilityCode == input.ReportingFacilityCode ||
                    (this.ReportingFacilityCode != null &&
                    this.ReportingFacilityCode.Equals(input.ReportingFacilityCode))
                ) && 
                (
                    this.TotalVolume == input.TotalVolume ||
                    (this.TotalVolume != null &&
                    this.TotalVolume.Equals(input.TotalVolume))
                ) && 
                (
                    this.ShortVolume == input.ShortVolume ||
                    (this.ShortVolume != null &&
                    this.ShortVolume.Equals(input.ShortVolume))
                ) && 
                (
                    this.ShortExemptVolume == input.ShortExemptVolume ||
                    (this.ShortExemptVolume != null &&
                    this.ShortExemptVolume.Equals(input.ShortExemptVolume))
                ) && 
                (
                    this.ShortVolumeRatio == input.ShortVolumeRatio ||
                    (this.ShortVolumeRatio != null &&
                    this.ShortVolumeRatio.Equals(input.ShortVolumeRatio))
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
                if (this.SecurityId != null)
                    hashCode = hashCode * 59 + this.SecurityId.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.TradeDate != null)
                    hashCode = hashCode * 59 + this.TradeDate.GetHashCode();
                if (this.ReportingFacilityCode != null)
                    hashCode = hashCode * 59 + this.ReportingFacilityCode.GetHashCode();
                if (this.TotalVolume != null)
                    hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
                if (this.ShortVolume != null)
                    hashCode = hashCode * 59 + this.ShortVolume.GetHashCode();
                if (this.ShortExemptVolume != null)
                    hashCode = hashCode * 59 + this.ShortExemptVolume.GetHashCode();
                if (this.ShortVolumeRatio != null)
                    hashCode = hashCode * 59 + this.ShortVolumeRatio.GetHashCode();
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

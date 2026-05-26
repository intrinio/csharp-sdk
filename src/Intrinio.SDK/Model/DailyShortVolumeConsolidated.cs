

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
    /// Consolidated daily short volume data for a security across all FINRA reporting facilities. This provides a complete market-wide view of off-exchange short selling activity by aggregating data from all market centers and third-party reporting facilities.  The short volume ratio is recalculated on the aggregated totals, providing an accurate representation of the proportion of short selling relative to total trading volume across the entire off-exchange market. 
    /// </summary>
    [DataContract]
    public partial class DailyShortVolumeConsolidated :  IEquatable<DailyShortVolumeConsolidated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyShortVolumeConsolidated" /> class.
        /// </summary>
        /// <param name="SecurityId">The unique identifier of the security..</param>
        /// <param name="Symbol">The ticker symbol of the security..</param>
        /// <param name="TradeDate">The date of the reported short volume data in YYYY-MM-DD format..</param>
        /// <param name="TotalVolume">The aggregated total volume of shares traded across all FINRA reporting facilities combined. Represents the total off-exchange trading volume for the security on this date..</param>
        /// <param name="ShortVolume">The aggregated volume of shares sold short across all FINRA reporting facilities combined. Represents the total off-exchange short selling volume for the security on this date..</param>
        /// <param name="ShortExemptVolume">The aggregated volume of shares sold short with exemptions across all FINRA reporting facilities combined. Includes pre-borrow arrangements, market maker activities, and other regulated short sale exemptions..</param>
        /// <param name="ShortVolumeRatio">The ratio of aggregated short volume to aggregated total volume across all facilities, rounded to 4 decimal places. Ranges from 0.0 to 1.0.  This market-wide metric is useful for: - Comparing short selling intensity between securities - Identifying unusual short volume spikes - Tracking trends in bearish positioning - Assessing relative market sentiment toward a security .</param>
        /// <param name="Sources">The list of FINRA reporting facility codes that contributed data to this consolidated aggregate. Multiple facilities typically report on the same security daily, and their volumes are summed here..</param>
        public DailyShortVolumeConsolidated(string SecurityId = default(string), string Symbol = default(string), DateTime? TradeDate = default(DateTime?), int? TotalVolume = default(int?), int? ShortVolume = default(int?), int? ShortExemptVolume = default(int?), double? ShortVolumeRatio = default(double?), List<string> Sources = default(List<string>))
        {
            this.SecurityId = SecurityId;
            this.Symbol = Symbol;
            this.TradeDate = TradeDate;
            this.TotalVolume = TotalVolume;
            this.ShortVolume = ShortVolume;
            this.ShortExemptVolume = ShortExemptVolume;
            this.ShortVolumeRatio = ShortVolumeRatio;
            this.Sources = Sources;
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
        /// The aggregated total volume of shares traded across all FINRA reporting facilities combined. Represents the total off-exchange trading volume for the security on this date.
        /// </summary>
        /// <value>The aggregated total volume of shares traded across all FINRA reporting facilities combined. Represents the total off-exchange trading volume for the security on this date.</value>
        [DataMember(Name="total_volume", EmitDefaultValue=false)]
        public int? TotalVolume { get; set; }

        /// <summary>
        /// The aggregated volume of shares sold short across all FINRA reporting facilities combined. Represents the total off-exchange short selling volume for the security on this date.
        /// </summary>
        /// <value>The aggregated volume of shares sold short across all FINRA reporting facilities combined. Represents the total off-exchange short selling volume for the security on this date.</value>
        [DataMember(Name="short_volume", EmitDefaultValue=false)]
        public int? ShortVolume { get; set; }

        /// <summary>
        /// The aggregated volume of shares sold short with exemptions across all FINRA reporting facilities combined. Includes pre-borrow arrangements, market maker activities, and other regulated short sale exemptions.
        /// </summary>
        /// <value>The aggregated volume of shares sold short with exemptions across all FINRA reporting facilities combined. Includes pre-borrow arrangements, market maker activities, and other regulated short sale exemptions.</value>
        [DataMember(Name="short_exempt_volume", EmitDefaultValue=false)]
        public int? ShortExemptVolume { get; set; }

        /// <summary>
        /// The ratio of aggregated short volume to aggregated total volume across all facilities, rounded to 4 decimal places. Ranges from 0.0 to 1.0.  This market-wide metric is useful for: - Comparing short selling intensity between securities - Identifying unusual short volume spikes - Tracking trends in bearish positioning - Assessing relative market sentiment toward a security 
        /// </summary>
        /// <value>The ratio of aggregated short volume to aggregated total volume across all facilities, rounded to 4 decimal places. Ranges from 0.0 to 1.0.  This market-wide metric is useful for: - Comparing short selling intensity between securities - Identifying unusual short volume spikes - Tracking trends in bearish positioning - Assessing relative market sentiment toward a security </value>
        [DataMember(Name="short_volume_ratio", EmitDefaultValue=false)]
        public double? ShortVolumeRatio { get; set; }

        /// <summary>
        /// The list of FINRA reporting facility codes that contributed data to this consolidated aggregate. Multiple facilities typically report on the same security daily, and their volumes are summed here.
        /// </summary>
        /// <value>The list of FINRA reporting facility codes that contributed data to this consolidated aggregate. Multiple facilities typically report on the same security daily, and their volumes are summed here.</value>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyShortVolumeConsolidated {\n");
            sb.Append("  SecurityId: ").Append(SecurityId).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TradeDate: ").Append(TradeDate).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
            sb.Append("  ShortVolume: ").Append(ShortVolume).Append("\n");
            sb.Append("  ShortExemptVolume: ").Append(ShortExemptVolume).Append("\n");
            sb.Append("  ShortVolumeRatio: ").Append(ShortVolumeRatio).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
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
            return this.Equals(input as DailyShortVolumeConsolidated);
        }

        /// <summary>
        /// Returns true if DailyShortVolumeConsolidated instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyShortVolumeConsolidated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyShortVolumeConsolidated input)
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
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
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
                if (this.TotalVolume != null)
                    hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
                if (this.ShortVolume != null)
                    hashCode = hashCode * 59 + this.ShortVolume.GetHashCode();
                if (this.ShortExemptVolume != null)
                    hashCode = hashCode * 59 + this.ShortExemptVolume.GetHashCode();
                if (this.ShortVolumeRatio != null)
                    hashCode = hashCode * 59 + this.ShortVolumeRatio.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
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

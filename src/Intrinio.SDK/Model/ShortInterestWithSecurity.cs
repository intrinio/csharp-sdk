

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
    /// ShortInterestWithSecurity
    /// </summary>
    [DataContract]
    public partial class ShortInterestWithSecurity :  IEquatable<ShortInterestWithSecurity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortInterestWithSecurity" /> class.
        /// </summary>
        /// <param name="SettlementDate">The settlement date of the short interest record.</param>
        /// <param name="CurrentShortPosition">The current short position (shares) as of the settlement date.</param>
        /// <param name="PreviousShortPosition">The previous short position (shares) from the prior reporting period.</param>
        /// <param name="ChangePercent">The percentage change in short position from the previous reporting period.</param>
        /// <param name="DaysToCover">The estimated number of days to cover the short position based on average daily volume.</param>
        /// <param name="AverageDailyVolume">The average daily trading volume used to calculate days to cover.</param>
        /// <param name="Security">The security associated with this short interest record.</param>
        public ShortInterestWithSecurity(DateTime? SettlementDate = default(DateTime?), int? CurrentShortPosition = default(int?), int? PreviousShortPosition = default(int?), float? ChangePercent = default(float?), float? DaysToCover = default(float?), int? AverageDailyVolume = default(int?), SecuritySummary Security = default(SecuritySummary))
        {
            this.SettlementDate = SettlementDate;
            this.CurrentShortPosition = CurrentShortPosition;
            this.PreviousShortPosition = PreviousShortPosition;
            this.ChangePercent = ChangePercent;
            this.DaysToCover = DaysToCover;
            this.AverageDailyVolume = AverageDailyVolume;
            this.Security = Security;
        }
        
        /// <summary>
        /// The settlement date of the short interest record
        /// </summary>
        /// <value>The settlement date of the short interest record</value>
        [DataMember(Name="settlement_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// The current short position (shares) as of the settlement date
        /// </summary>
        /// <value>The current short position (shares) as of the settlement date</value>
        [DataMember(Name="current_short_position", EmitDefaultValue=false)]
        public int? CurrentShortPosition { get; set; }

        /// <summary>
        /// The previous short position (shares) from the prior reporting period
        /// </summary>
        /// <value>The previous short position (shares) from the prior reporting period</value>
        [DataMember(Name="previous_short_position", EmitDefaultValue=false)]
        public int? PreviousShortPosition { get; set; }

        /// <summary>
        /// The percentage change in short position from the previous reporting period
        /// </summary>
        /// <value>The percentage change in short position from the previous reporting period</value>
        [DataMember(Name="change_percent", EmitDefaultValue=false)]
        public float? ChangePercent { get; set; }

        /// <summary>
        /// The estimated number of days to cover the short position based on average daily volume
        /// </summary>
        /// <value>The estimated number of days to cover the short position based on average daily volume</value>
        [DataMember(Name="days_to_cover", EmitDefaultValue=false)]
        public float? DaysToCover { get; set; }

        /// <summary>
        /// The average daily trading volume used to calculate days to cover
        /// </summary>
        /// <value>The average daily trading volume used to calculate days to cover</value>
        [DataMember(Name="average_daily_volume", EmitDefaultValue=false)]
        public int? AverageDailyVolume { get; set; }

        /// <summary>
        /// The security associated with this short interest record
        /// </summary>
        /// <value>The security associated with this short interest record</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShortInterestWithSecurity {\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  CurrentShortPosition: ").Append(CurrentShortPosition).Append("\n");
            sb.Append("  PreviousShortPosition: ").Append(PreviousShortPosition).Append("\n");
            sb.Append("  ChangePercent: ").Append(ChangePercent).Append("\n");
            sb.Append("  DaysToCover: ").Append(DaysToCover).Append("\n");
            sb.Append("  AverageDailyVolume: ").Append(AverageDailyVolume).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as ShortInterestWithSecurity);
        }

        /// <summary>
        /// Returns true if ShortInterestWithSecurity instances are equal
        /// </summary>
        /// <param name="input">Instance of ShortInterestWithSecurity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShortInterestWithSecurity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.CurrentShortPosition == input.CurrentShortPosition ||
                    (this.CurrentShortPosition != null &&
                    this.CurrentShortPosition.Equals(input.CurrentShortPosition))
                ) && 
                (
                    this.PreviousShortPosition == input.PreviousShortPosition ||
                    (this.PreviousShortPosition != null &&
                    this.PreviousShortPosition.Equals(input.PreviousShortPosition))
                ) && 
                (
                    this.ChangePercent == input.ChangePercent ||
                    (this.ChangePercent != null &&
                    this.ChangePercent.Equals(input.ChangePercent))
                ) && 
                (
                    this.DaysToCover == input.DaysToCover ||
                    (this.DaysToCover != null &&
                    this.DaysToCover.Equals(input.DaysToCover))
                ) && 
                (
                    this.AverageDailyVolume == input.AverageDailyVolume ||
                    (this.AverageDailyVolume != null &&
                    this.AverageDailyVolume.Equals(input.AverageDailyVolume))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                if (this.CurrentShortPosition != null)
                    hashCode = hashCode * 59 + this.CurrentShortPosition.GetHashCode();
                if (this.PreviousShortPosition != null)
                    hashCode = hashCode * 59 + this.PreviousShortPosition.GetHashCode();
                if (this.ChangePercent != null)
                    hashCode = hashCode * 59 + this.ChangePercent.GetHashCode();
                if (this.DaysToCover != null)
                    hashCode = hashCode * 59 + this.DaysToCover.GetHashCode();
                if (this.AverageDailyVolume != null)
                    hashCode = hashCode * 59 + this.AverageDailyVolume.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

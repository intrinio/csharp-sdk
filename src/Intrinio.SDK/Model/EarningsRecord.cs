

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
    /// An earnings record for the identifier
    /// </summary>
    [DataContract]
    public partial class EarningsRecord :  IEquatable<EarningsRecord>, IValidatableObject
    {
        /// <summary>
        /// Indicates the time of the announcement
        /// </summary>
        /// <value>Indicates the time of the announcement</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeOfDayEnum
        {
            
            /// <summary>
            /// Enum BeforeMarket for value: "Before Market"
            /// </summary>
            [EnumMember(Value = "Before Market")]
            BeforeMarket = 1,
            
            /// <summary>
            /// Enum DuringMarket for value: "During Market"
            /// </summary>
            [EnumMember(Value = "During Market")]
            DuringMarket = 2,
            
            /// <summary>
            /// Enum AfterMarket for value: "After Market"
            /// </summary>
            [EnumMember(Value = "After Market")]
            AfterMarket = 3,
            
            /// <summary>
            /// Enum Unspecified for value: "Unspecified"
            /// </summary>
            [EnumMember(Value = "Unspecified")]
            Unspecified = 4
        }

        /// <summary>
        /// Indicates the time of the announcement
        /// </summary>
        /// <value>Indicates the time of the announcement</value>
        [DataMember(Name="time_of_day", EmitDefaultValue=false)]
        public TimeOfDayEnum? TimeOfDay { get; set; }
        /// <summary>
        /// The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting
        /// </summary>
        /// <value>The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BoardOfDirectorsMeetingTypeEnum
        {
            
            /// <summary>
            /// Enum B for value: "B"
            /// </summary>
            [EnumMember(Value = "B")]
            B = 1,
            
            /// <summary>
            /// Enum S for value: "S"
            /// </summary>
            [EnumMember(Value = "S")]
            S = 2
        }

        /// <summary>
        /// The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting
        /// </summary>
        /// <value>The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting</value>
        [DataMember(Name="board_of_directors_meeting_type", EmitDefaultValue=false)]
        public BoardOfDirectorsMeetingTypeEnum? BoardOfDirectorsMeetingType { get; set; }
        /// <summary>
        /// The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred
        /// </summary>
        /// <value>The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum V for value: "V"
            /// </summary>
            [EnumMember(Value = "V")]
            V = 1,
            
            /// <summary>
            /// Enum T for value: "T"
            /// </summary>
            [EnumMember(Value = "T")]
            T = 2,
            
            /// <summary>
            /// Enum I for value: "I"
            /// </summary>
            [EnumMember(Value = "I")]
            I = 3
        }

        /// <summary>
        /// The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred
        /// </summary>
        /// <value>The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EarningsRecord" /> class.
        /// </summary>
        /// <param name="Quarter">The letter “Q” followed by the quarter number the earnings information applies to.</param>
        /// <param name="TimeOfDay">Indicates the time of the announcement.</param>
        /// <param name="BroadcastUrl">Link for Conference Call recording.</param>
        /// <param name="TranscriptUrl">Link to the earnings release transcript.</param>
        /// <param name="TranscriptQuarter">The letter “Q” followed by the quarter number the earnings transcript applies to.</param>
        /// <param name="TranscriptFiscalYear">Fiscal year in YYYY format for the earnings transcript.</param>
        /// <param name="ConferenceCallDate">Date of the conference call.</param>
        /// <param name="ConferenceCallTime">Published time of the conference call.</param>
        /// <param name="ConferenceCallPhoneNumber">Publicly available phone number for replay conference call.</param>
        /// <param name="ConferenceCallPasscode">Passcode for replay conference call.</param>
        /// <param name="LastConfirmationDate">Date of last earnings date update by a WSH analyst.</param>
        /// <param name="BoardOfDirectorsMeetingDate">Date of Board/Shareholder Meeting.</param>
        /// <param name="BoardOfDirectorsMeetingType">The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting.</param>
        /// <param name="CompanyWebsite">Website link for the company.</param>
        /// <param name="Q1Date">Earnings Date for 1st quarter.</param>
        /// <param name="Q2Date">Earnings Date for 2nd quarter.</param>
        /// <param name="Q3Date">Earnings Date for 3rd quarter.</param>
        /// <param name="Q4Date">Earnings Date for 4th quarter.</param>
        /// <param name="Type">The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred.</param>
        /// <param name="NextEarningsDate">Next earnings date.</param>
        /// <param name="NextEarningsQuarter">The quarter of the next earnings release.</param>
        /// <param name="NextEarningsFiscalYear">The fiscal year associated with next earnings date and next earnings quarter.</param>
        /// <param name="Security">Security.</param>
        public EarningsRecord(string Quarter = default(string), TimeOfDayEnum? TimeOfDay = default(TimeOfDayEnum?), string BroadcastUrl = default(string), string TranscriptUrl = default(string), string TranscriptQuarter = default(string), string TranscriptFiscalYear = default(string), DateTime? ConferenceCallDate = default(DateTime?), string ConferenceCallTime = default(string), string ConferenceCallPhoneNumber = default(string), string ConferenceCallPasscode = default(string), DateTime? LastConfirmationDate = default(DateTime?), DateTime? BoardOfDirectorsMeetingDate = default(DateTime?), BoardOfDirectorsMeetingTypeEnum? BoardOfDirectorsMeetingType = default(BoardOfDirectorsMeetingTypeEnum?), string CompanyWebsite = default(string), DateTime? Q1Date = default(DateTime?), DateTime? Q2Date = default(DateTime?), DateTime? Q3Date = default(DateTime?), DateTime? Q4Date = default(DateTime?), TypeEnum? Type = default(TypeEnum?), DateTime? NextEarningsDate = default(DateTime?), string NextEarningsQuarter = default(string), int? NextEarningsFiscalYear = default(int?), SecuritySummary Security = default(SecuritySummary))
        {
            this.Quarter = Quarter;
            this.TimeOfDay = TimeOfDay;
            this.BroadcastUrl = BroadcastUrl;
            this.TranscriptUrl = TranscriptUrl;
            this.TranscriptQuarter = TranscriptQuarter;
            this.TranscriptFiscalYear = TranscriptFiscalYear;
            this.ConferenceCallDate = ConferenceCallDate;
            this.ConferenceCallTime = ConferenceCallTime;
            this.ConferenceCallPhoneNumber = ConferenceCallPhoneNumber;
            this.ConferenceCallPasscode = ConferenceCallPasscode;
            this.LastConfirmationDate = LastConfirmationDate;
            this.BoardOfDirectorsMeetingDate = BoardOfDirectorsMeetingDate;
            this.BoardOfDirectorsMeetingType = BoardOfDirectorsMeetingType;
            this.CompanyWebsite = CompanyWebsite;
            this.Q1Date = Q1Date;
            this.Q2Date = Q2Date;
            this.Q3Date = Q3Date;
            this.Q4Date = Q4Date;
            this.Type = Type;
            this.NextEarningsDate = NextEarningsDate;
            this.NextEarningsQuarter = NextEarningsQuarter;
            this.NextEarningsFiscalYear = NextEarningsFiscalYear;
            this.Security = Security;
        }
        
        /// <summary>
        /// The letter “Q” followed by the quarter number the earnings information applies to
        /// </summary>
        /// <value>The letter “Q” followed by the quarter number the earnings information applies to</value>
        [DataMember(Name="quarter", EmitDefaultValue=false)]
        public string Quarter { get; set; }


        /// <summary>
        /// Link for Conference Call recording
        /// </summary>
        /// <value>Link for Conference Call recording</value>
        [DataMember(Name="broadcast_url", EmitDefaultValue=false)]
        public string BroadcastUrl { get; set; }

        /// <summary>
        /// Link to the earnings release transcript
        /// </summary>
        /// <value>Link to the earnings release transcript</value>
        [DataMember(Name="transcript_url", EmitDefaultValue=false)]
        public string TranscriptUrl { get; set; }

        /// <summary>
        /// The letter “Q” followed by the quarter number the earnings transcript applies to
        /// </summary>
        /// <value>The letter “Q” followed by the quarter number the earnings transcript applies to</value>
        [DataMember(Name="transcript_quarter", EmitDefaultValue=false)]
        public string TranscriptQuarter { get; set; }

        /// <summary>
        /// Fiscal year in YYYY format for the earnings transcript
        /// </summary>
        /// <value>Fiscal year in YYYY format for the earnings transcript</value>
        [DataMember(Name="transcript_fiscal_year", EmitDefaultValue=false)]
        public string TranscriptFiscalYear { get; set; }

        /// <summary>
        /// Date of the conference call
        /// </summary>
        /// <value>Date of the conference call</value>
        [DataMember(Name="conference_call_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ConferenceCallDate { get; set; }

        /// <summary>
        /// Published time of the conference call
        /// </summary>
        /// <value>Published time of the conference call</value>
        [DataMember(Name="conference_call_time", EmitDefaultValue=false)]
        public string ConferenceCallTime { get; set; }

        /// <summary>
        /// Publicly available phone number for replay conference call
        /// </summary>
        /// <value>Publicly available phone number for replay conference call</value>
        [DataMember(Name="conference_call_phone_number", EmitDefaultValue=false)]
        public string ConferenceCallPhoneNumber { get; set; }

        /// <summary>
        /// Passcode for replay conference call
        /// </summary>
        /// <value>Passcode for replay conference call</value>
        [DataMember(Name="conference_call_passcode", EmitDefaultValue=false)]
        public string ConferenceCallPasscode { get; set; }

        /// <summary>
        /// Date of last earnings date update by a WSH analyst
        /// </summary>
        /// <value>Date of last earnings date update by a WSH analyst</value>
        [DataMember(Name="last_confirmation_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastConfirmationDate { get; set; }

        /// <summary>
        /// Date of Board/Shareholder Meeting
        /// </summary>
        /// <value>Date of Board/Shareholder Meeting</value>
        [DataMember(Name="board_of_directors_meeting_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BoardOfDirectorsMeetingDate { get; set; }


        /// <summary>
        /// Website link for the company
        /// </summary>
        /// <value>Website link for the company</value>
        [DataMember(Name="company_website", EmitDefaultValue=false)]
        public string CompanyWebsite { get; set; }

        /// <summary>
        /// Earnings Date for 1st quarter
        /// </summary>
        /// <value>Earnings Date for 1st quarter</value>
        [DataMember(Name="q1_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Q1Date { get; set; }

        /// <summary>
        /// Earnings Date for 2nd quarter
        /// </summary>
        /// <value>Earnings Date for 2nd quarter</value>
        [DataMember(Name="q2_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Q2Date { get; set; }

        /// <summary>
        /// Earnings Date for 3rd quarter
        /// </summary>
        /// <value>Earnings Date for 3rd quarter</value>
        [DataMember(Name="q3_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Q3Date { get; set; }

        /// <summary>
        /// Earnings Date for 4th quarter
        /// </summary>
        /// <value>Earnings Date for 4th quarter</value>
        [DataMember(Name="q4_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Q4Date { get; set; }


        /// <summary>
        /// Next earnings date
        /// </summary>
        /// <value>Next earnings date</value>
        [DataMember(Name="next_earnings_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? NextEarningsDate { get; set; }

        /// <summary>
        /// The quarter of the next earnings release
        /// </summary>
        /// <value>The quarter of the next earnings release</value>
        [DataMember(Name="next_earnings_quarter", EmitDefaultValue=false)]
        public string NextEarningsQuarter { get; set; }

        /// <summary>
        /// The fiscal year associated with next earnings date and next earnings quarter
        /// </summary>
        /// <value>The fiscal year associated with next earnings date and next earnings quarter</value>
        [DataMember(Name="next_earnings_fiscal_year", EmitDefaultValue=false)]
        public int? NextEarningsFiscalYear { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsRecord {\n");
            sb.Append("  Quarter: ").Append(Quarter).Append("\n");
            sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
            sb.Append("  BroadcastUrl: ").Append(BroadcastUrl).Append("\n");
            sb.Append("  TranscriptUrl: ").Append(TranscriptUrl).Append("\n");
            sb.Append("  TranscriptQuarter: ").Append(TranscriptQuarter).Append("\n");
            sb.Append("  TranscriptFiscalYear: ").Append(TranscriptFiscalYear).Append("\n");
            sb.Append("  ConferenceCallDate: ").Append(ConferenceCallDate).Append("\n");
            sb.Append("  ConferenceCallTime: ").Append(ConferenceCallTime).Append("\n");
            sb.Append("  ConferenceCallPhoneNumber: ").Append(ConferenceCallPhoneNumber).Append("\n");
            sb.Append("  ConferenceCallPasscode: ").Append(ConferenceCallPasscode).Append("\n");
            sb.Append("  LastConfirmationDate: ").Append(LastConfirmationDate).Append("\n");
            sb.Append("  BoardOfDirectorsMeetingDate: ").Append(BoardOfDirectorsMeetingDate).Append("\n");
            sb.Append("  BoardOfDirectorsMeetingType: ").Append(BoardOfDirectorsMeetingType).Append("\n");
            sb.Append("  CompanyWebsite: ").Append(CompanyWebsite).Append("\n");
            sb.Append("  Q1Date: ").Append(Q1Date).Append("\n");
            sb.Append("  Q2Date: ").Append(Q2Date).Append("\n");
            sb.Append("  Q3Date: ").Append(Q3Date).Append("\n");
            sb.Append("  Q4Date: ").Append(Q4Date).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NextEarningsDate: ").Append(NextEarningsDate).Append("\n");
            sb.Append("  NextEarningsQuarter: ").Append(NextEarningsQuarter).Append("\n");
            sb.Append("  NextEarningsFiscalYear: ").Append(NextEarningsFiscalYear).Append("\n");
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
            return this.Equals(input as EarningsRecord);
        }

        /// <summary>
        /// Returns true if EarningsRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quarter == input.Quarter ||
                    (this.Quarter != null &&
                    this.Quarter.Equals(input.Quarter))
                ) && 
                (
                    this.TimeOfDay == input.TimeOfDay ||
                    (this.TimeOfDay != null &&
                    this.TimeOfDay.Equals(input.TimeOfDay))
                ) && 
                (
                    this.BroadcastUrl == input.BroadcastUrl ||
                    (this.BroadcastUrl != null &&
                    this.BroadcastUrl.Equals(input.BroadcastUrl))
                ) && 
                (
                    this.TranscriptUrl == input.TranscriptUrl ||
                    (this.TranscriptUrl != null &&
                    this.TranscriptUrl.Equals(input.TranscriptUrl))
                ) && 
                (
                    this.TranscriptQuarter == input.TranscriptQuarter ||
                    (this.TranscriptQuarter != null &&
                    this.TranscriptQuarter.Equals(input.TranscriptQuarter))
                ) && 
                (
                    this.TranscriptFiscalYear == input.TranscriptFiscalYear ||
                    (this.TranscriptFiscalYear != null &&
                    this.TranscriptFiscalYear.Equals(input.TranscriptFiscalYear))
                ) && 
                (
                    this.ConferenceCallDate == input.ConferenceCallDate ||
                    (this.ConferenceCallDate != null &&
                    this.ConferenceCallDate.Equals(input.ConferenceCallDate))
                ) && 
                (
                    this.ConferenceCallTime == input.ConferenceCallTime ||
                    (this.ConferenceCallTime != null &&
                    this.ConferenceCallTime.Equals(input.ConferenceCallTime))
                ) && 
                (
                    this.ConferenceCallPhoneNumber == input.ConferenceCallPhoneNumber ||
                    (this.ConferenceCallPhoneNumber != null &&
                    this.ConferenceCallPhoneNumber.Equals(input.ConferenceCallPhoneNumber))
                ) && 
                (
                    this.ConferenceCallPasscode == input.ConferenceCallPasscode ||
                    (this.ConferenceCallPasscode != null &&
                    this.ConferenceCallPasscode.Equals(input.ConferenceCallPasscode))
                ) && 
                (
                    this.LastConfirmationDate == input.LastConfirmationDate ||
                    (this.LastConfirmationDate != null &&
                    this.LastConfirmationDate.Equals(input.LastConfirmationDate))
                ) && 
                (
                    this.BoardOfDirectorsMeetingDate == input.BoardOfDirectorsMeetingDate ||
                    (this.BoardOfDirectorsMeetingDate != null &&
                    this.BoardOfDirectorsMeetingDate.Equals(input.BoardOfDirectorsMeetingDate))
                ) && 
                (
                    this.BoardOfDirectorsMeetingType == input.BoardOfDirectorsMeetingType ||
                    (this.BoardOfDirectorsMeetingType != null &&
                    this.BoardOfDirectorsMeetingType.Equals(input.BoardOfDirectorsMeetingType))
                ) && 
                (
                    this.CompanyWebsite == input.CompanyWebsite ||
                    (this.CompanyWebsite != null &&
                    this.CompanyWebsite.Equals(input.CompanyWebsite))
                ) && 
                (
                    this.Q1Date == input.Q1Date ||
                    (this.Q1Date != null &&
                    this.Q1Date.Equals(input.Q1Date))
                ) && 
                (
                    this.Q2Date == input.Q2Date ||
                    (this.Q2Date != null &&
                    this.Q2Date.Equals(input.Q2Date))
                ) && 
                (
                    this.Q3Date == input.Q3Date ||
                    (this.Q3Date != null &&
                    this.Q3Date.Equals(input.Q3Date))
                ) && 
                (
                    this.Q4Date == input.Q4Date ||
                    (this.Q4Date != null &&
                    this.Q4Date.Equals(input.Q4Date))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NextEarningsDate == input.NextEarningsDate ||
                    (this.NextEarningsDate != null &&
                    this.NextEarningsDate.Equals(input.NextEarningsDate))
                ) && 
                (
                    this.NextEarningsQuarter == input.NextEarningsQuarter ||
                    (this.NextEarningsQuarter != null &&
                    this.NextEarningsQuarter.Equals(input.NextEarningsQuarter))
                ) && 
                (
                    this.NextEarningsFiscalYear == input.NextEarningsFiscalYear ||
                    (this.NextEarningsFiscalYear != null &&
                    this.NextEarningsFiscalYear.Equals(input.NextEarningsFiscalYear))
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
                if (this.Quarter != null)
                    hashCode = hashCode * 59 + this.Quarter.GetHashCode();
                if (this.TimeOfDay != null)
                    hashCode = hashCode * 59 + this.TimeOfDay.GetHashCode();
                if (this.BroadcastUrl != null)
                    hashCode = hashCode * 59 + this.BroadcastUrl.GetHashCode();
                if (this.TranscriptUrl != null)
                    hashCode = hashCode * 59 + this.TranscriptUrl.GetHashCode();
                if (this.TranscriptQuarter != null)
                    hashCode = hashCode * 59 + this.TranscriptQuarter.GetHashCode();
                if (this.TranscriptFiscalYear != null)
                    hashCode = hashCode * 59 + this.TranscriptFiscalYear.GetHashCode();
                if (this.ConferenceCallDate != null)
                    hashCode = hashCode * 59 + this.ConferenceCallDate.GetHashCode();
                if (this.ConferenceCallTime != null)
                    hashCode = hashCode * 59 + this.ConferenceCallTime.GetHashCode();
                if (this.ConferenceCallPhoneNumber != null)
                    hashCode = hashCode * 59 + this.ConferenceCallPhoneNumber.GetHashCode();
                if (this.ConferenceCallPasscode != null)
                    hashCode = hashCode * 59 + this.ConferenceCallPasscode.GetHashCode();
                if (this.LastConfirmationDate != null)
                    hashCode = hashCode * 59 + this.LastConfirmationDate.GetHashCode();
                if (this.BoardOfDirectorsMeetingDate != null)
                    hashCode = hashCode * 59 + this.BoardOfDirectorsMeetingDate.GetHashCode();
                if (this.BoardOfDirectorsMeetingType != null)
                    hashCode = hashCode * 59 + this.BoardOfDirectorsMeetingType.GetHashCode();
                if (this.CompanyWebsite != null)
                    hashCode = hashCode * 59 + this.CompanyWebsite.GetHashCode();
                if (this.Q1Date != null)
                    hashCode = hashCode * 59 + this.Q1Date.GetHashCode();
                if (this.Q2Date != null)
                    hashCode = hashCode * 59 + this.Q2Date.GetHashCode();
                if (this.Q3Date != null)
                    hashCode = hashCode * 59 + this.Q3Date.GetHashCode();
                if (this.Q4Date != null)
                    hashCode = hashCode * 59 + this.Q4Date.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NextEarningsDate != null)
                    hashCode = hashCode * 59 + this.NextEarningsDate.GetHashCode();
                if (this.NextEarningsQuarter != null)
                    hashCode = hashCode * 59 + this.NextEarningsQuarter.GetHashCode();
                if (this.NextEarningsFiscalYear != null)
                    hashCode = hashCode * 59 + this.NextEarningsFiscalYear.GetHashCode();
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

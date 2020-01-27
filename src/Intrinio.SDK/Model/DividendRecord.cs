

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
    /// A dividend record for the identifier
    /// </summary>
    [DataContract]
    public partial class DividendRecord :  IEquatable<DividendRecord>, IValidatableObject
    {
        /// <summary>
        /// Status of the dividend
        /// </summary>
        /// <value>Status of the dividend</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum P for value: P
            /// </summary>
            [EnumMember(Value = "P")]
            P = 1,
            
            /// <summary>
            /// Enum X for value: X
            /// </summary>
            [EnumMember(Value = "X")]
            X = 2,
            
            /// <summary>
            /// Enum S for value: S
            /// </summary>
            [EnumMember(Value = "S")]
            S = 3,
            
            /// <summary>
            /// Enum R for value: R
            /// </summary>
            [EnumMember(Value = "R")]
            R = 4
        }

        /// <summary>
        /// Status of the dividend
        /// </summary>
        /// <value>Status of the dividend</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DividendRecord" /> class.
        /// </summary>
        /// <param name="ExDividend">Amount of dividend in US dollars.</param>
        /// <param name="Currency">The 3-digit currency code the dividend amount was reported in.</param>
        /// <param name="AnnouncementDate">Date dividend was announced.</param>
        /// <param name="RecordDate">Date before which holders-of-record will receive the dividend.</param>
        /// <param name="PayDate">Date the divdiend was paid.</param>
        /// <param name="Frequency">Identifies payment frequency of announced dividend.</param>
        /// <param name="Status">Status of the dividend.</param>
        /// <param name="ForwardYield">The forward dividend yield.</param>
        /// <param name="ForwardRate">The forward dividend rate.</param>
        /// <param name="LastExDividendDate">The last reported day the stock starts trading without the value of its next dividend payment.</param>
        /// <param name="Security">Security.</param>
        public DividendRecord(decimal? ExDividend = default(decimal?), string Currency = default(string), DateTime? AnnouncementDate = default(DateTime?), DateTime? RecordDate = default(DateTime?), DateTime? PayDate = default(DateTime?), string Frequency = default(string), StatusEnum? Status = default(StatusEnum?), decimal? ForwardYield = default(decimal?), decimal? ForwardRate = default(decimal?), DateTime? LastExDividendDate = default(DateTime?), SecuritySummary Security = default(SecuritySummary))
        {
            this.ExDividend = ExDividend;
            this.Currency = Currency;
            this.AnnouncementDate = AnnouncementDate;
            this.RecordDate = RecordDate;
            this.PayDate = PayDate;
            this.Frequency = Frequency;
            this.Status = Status;
            this.ForwardYield = ForwardYield;
            this.ForwardRate = ForwardRate;
            this.LastExDividendDate = LastExDividendDate;
            this.Security = Security;
        }
        
        /// <summary>
        /// Amount of dividend in US dollars
        /// </summary>
        /// <value>Amount of dividend in US dollars</value>
        [DataMember(Name="ex_dividend", EmitDefaultValue=false)]
        public decimal? ExDividend { get; set; }

        /// <summary>
        /// The 3-digit currency code the dividend amount was reported in
        /// </summary>
        /// <value>The 3-digit currency code the dividend amount was reported in</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Date dividend was announced
        /// </summary>
        /// <value>Date dividend was announced</value>
        [DataMember(Name="announcement_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AnnouncementDate { get; set; }

        /// <summary>
        /// Date before which holders-of-record will receive the dividend
        /// </summary>
        /// <value>Date before which holders-of-record will receive the dividend</value>
        [DataMember(Name="record_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? RecordDate { get; set; }

        /// <summary>
        /// Date the divdiend was paid
        /// </summary>
        /// <value>Date the divdiend was paid</value>
        [DataMember(Name="pay_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PayDate { get; set; }

        /// <summary>
        /// Identifies payment frequency of announced dividend
        /// </summary>
        /// <value>Identifies payment frequency of announced dividend</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public string Frequency { get; set; }


        /// <summary>
        /// The forward dividend yield
        /// </summary>
        /// <value>The forward dividend yield</value>
        [DataMember(Name="forward_yield", EmitDefaultValue=false)]
        public decimal? ForwardYield { get; set; }

        /// <summary>
        /// The forward dividend rate
        /// </summary>
        /// <value>The forward dividend rate</value>
        [DataMember(Name="forward_rate", EmitDefaultValue=false)]
        public decimal? ForwardRate { get; set; }

        /// <summary>
        /// The last reported day the stock starts trading without the value of its next dividend payment
        /// </summary>
        /// <value>The last reported day the stock starts trading without the value of its next dividend payment</value>
        [DataMember(Name="last_ex_dividend_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastExDividendDate { get; set; }

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
            sb.Append("class DividendRecord {\n");
            sb.Append("  ExDividend: ").Append(ExDividend).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PayDate: ").Append(PayDate).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ForwardYield: ").Append(ForwardYield).Append("\n");
            sb.Append("  ForwardRate: ").Append(ForwardRate).Append("\n");
            sb.Append("  LastExDividendDate: ").Append(LastExDividendDate).Append("\n");
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
            return this.Equals(input as DividendRecord);
        }

        /// <summary>
        /// Returns true if DividendRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of DividendRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DividendRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExDividend == input.ExDividend ||
                    (this.ExDividend != null &&
                    this.ExDividend.Equals(input.ExDividend))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AnnouncementDate == input.AnnouncementDate ||
                    (this.AnnouncementDate != null &&
                    this.AnnouncementDate.Equals(input.AnnouncementDate))
                ) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
                ) && 
                (
                    this.PayDate == input.PayDate ||
                    (this.PayDate != null &&
                    this.PayDate.Equals(input.PayDate))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ForwardYield == input.ForwardYield ||
                    (this.ForwardYield != null &&
                    this.ForwardYield.Equals(input.ForwardYield))
                ) && 
                (
                    this.ForwardRate == input.ForwardRate ||
                    (this.ForwardRate != null &&
                    this.ForwardRate.Equals(input.ForwardRate))
                ) && 
                (
                    this.LastExDividendDate == input.LastExDividendDate ||
                    (this.LastExDividendDate != null &&
                    this.LastExDividendDate.Equals(input.LastExDividendDate))
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
                if (this.ExDividend != null)
                    hashCode = hashCode * 59 + this.ExDividend.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.AnnouncementDate != null)
                    hashCode = hashCode * 59 + this.AnnouncementDate.GetHashCode();
                if (this.RecordDate != null)
                    hashCode = hashCode * 59 + this.RecordDate.GetHashCode();
                if (this.PayDate != null)
                    hashCode = hashCode * 59 + this.PayDate.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ForwardYield != null)
                    hashCode = hashCode * 59 + this.ForwardYield.GetHashCode();
                if (this.ForwardRate != null)
                    hashCode = hashCode * 59 + this.ForwardRate.GetHashCode();
                if (this.LastExDividendDate != null)
                    hashCode = hashCode * 59 + this.LastExDividendDate.GetHashCode();
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

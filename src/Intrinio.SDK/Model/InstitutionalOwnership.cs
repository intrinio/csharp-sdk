

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
    /// The amount of a company&#39;s available stock owned by mutual or pension funds, insurance companies, investment firms, private foundations, endowments or other large entities that manage funds on behalf of others.
    /// </summary>
    [DataContract]
    public partial class InstitutionalOwnership :  IEquatable<InstitutionalOwnership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionalOwnership" /> class.
        /// </summary>
        /// <param name="OwnerCik">The Central Index Key issued by the SEC, which is the unique identifier all owner filings.</param>
        /// <param name="OwnerName">The name of the institutional owner.</param>
        /// <param name="PeriodEnded">The date of the latest 13-F filing on record with the SEC..</param>
        /// <param name="Value">The market value in amount of dollars of the holding in the listed security.</param>
        /// <param name="Amount">The number of shares held in the listed security.</param>
        /// <param name="SoleVotingAuthority">The number of shares where the insitutional holder has sole voting authority.</param>
        /// <param name="SharedVotingAuthority">The number of shares where the insitutional holder has shared voting authority.</param>
        /// <param name="NoVotingAuthority">The number of shares where the insitutional holder has no voting authority.</param>
        /// <param name="PreviousAmount">The prior quarter number of shares held by the owner.</param>
        /// <param name="AmountChange">The change in number of shares held from the prior quarter.</param>
        /// <param name="AmountPercentChange">The percentage change in the number of shares held from the prior quarter.</param>
        public InstitutionalOwnership(string OwnerCik = default(string), string OwnerName = default(string), DateTime? PeriodEnded = default(DateTime?), decimal? Value = default(decimal?), decimal? Amount = default(decimal?), decimal? SoleVotingAuthority = default(decimal?), decimal? SharedVotingAuthority = default(decimal?), decimal? NoVotingAuthority = default(decimal?), decimal? PreviousAmount = default(decimal?), decimal? AmountChange = default(decimal?), decimal? AmountPercentChange = default(decimal?))
        {
            this.OwnerCik = OwnerCik;
            this.OwnerName = OwnerName;
            this.PeriodEnded = PeriodEnded;
            this.Value = Value;
            this.Amount = Amount;
            this.SoleVotingAuthority = SoleVotingAuthority;
            this.SharedVotingAuthority = SharedVotingAuthority;
            this.NoVotingAuthority = NoVotingAuthority;
            this.PreviousAmount = PreviousAmount;
            this.AmountChange = AmountChange;
            this.AmountPercentChange = AmountPercentChange;
        }
        
        /// <summary>
        /// The Central Index Key issued by the SEC, which is the unique identifier all owner filings
        /// </summary>
        /// <value>The Central Index Key issued by the SEC, which is the unique identifier all owner filings</value>
        [DataMember(Name="owner_cik", EmitDefaultValue=false)]
        public string OwnerCik { get; set; }

        /// <summary>
        /// The name of the institutional owner
        /// </summary>
        /// <value>The name of the institutional owner</value>
        [DataMember(Name="owner_name", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// The date of the latest 13-F filing on record with the SEC.
        /// </summary>
        /// <value>The date of the latest 13-F filing on record with the SEC.</value>
        [DataMember(Name="period_ended", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PeriodEnded { get; set; }

        /// <summary>
        /// The market value in amount of dollars of the holding in the listed security
        /// </summary>
        /// <value>The market value in amount of dollars of the holding in the listed security</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The number of shares held in the listed security
        /// </summary>
        /// <value>The number of shares held in the listed security</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The number of shares where the insitutional holder has sole voting authority
        /// </summary>
        /// <value>The number of shares where the insitutional holder has sole voting authority</value>
        [DataMember(Name="sole_voting_authority", EmitDefaultValue=false)]
        public decimal? SoleVotingAuthority { get; set; }

        /// <summary>
        /// The number of shares where the insitutional holder has shared voting authority
        /// </summary>
        /// <value>The number of shares where the insitutional holder has shared voting authority</value>
        [DataMember(Name="shared_voting_authority", EmitDefaultValue=false)]
        public decimal? SharedVotingAuthority { get; set; }

        /// <summary>
        /// The number of shares where the insitutional holder has no voting authority
        /// </summary>
        /// <value>The number of shares where the insitutional holder has no voting authority</value>
        [DataMember(Name="no_voting_authority", EmitDefaultValue=false)]
        public decimal? NoVotingAuthority { get; set; }

        /// <summary>
        /// The prior quarter number of shares held by the owner
        /// </summary>
        /// <value>The prior quarter number of shares held by the owner</value>
        [DataMember(Name="previous_amount", EmitDefaultValue=false)]
        public decimal? PreviousAmount { get; set; }

        /// <summary>
        /// The change in number of shares held from the prior quarter
        /// </summary>
        /// <value>The change in number of shares held from the prior quarter</value>
        [DataMember(Name="amount_change", EmitDefaultValue=false)]
        public decimal? AmountChange { get; set; }

        /// <summary>
        /// The percentage change in the number of shares held from the prior quarter
        /// </summary>
        /// <value>The percentage change in the number of shares held from the prior quarter</value>
        [DataMember(Name="amount_percent_change", EmitDefaultValue=false)]
        public decimal? AmountPercentChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstitutionalOwnership {\n");
            sb.Append("  OwnerCik: ").Append(OwnerCik).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PeriodEnded: ").Append(PeriodEnded).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SoleVotingAuthority: ").Append(SoleVotingAuthority).Append("\n");
            sb.Append("  SharedVotingAuthority: ").Append(SharedVotingAuthority).Append("\n");
            sb.Append("  NoVotingAuthority: ").Append(NoVotingAuthority).Append("\n");
            sb.Append("  PreviousAmount: ").Append(PreviousAmount).Append("\n");
            sb.Append("  AmountChange: ").Append(AmountChange).Append("\n");
            sb.Append("  AmountPercentChange: ").Append(AmountPercentChange).Append("\n");
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
            return this.Equals(input as InstitutionalOwnership);
        }

        /// <summary>
        /// Returns true if InstitutionalOwnership instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionalOwnership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionalOwnership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerCik == input.OwnerCik ||
                    (this.OwnerCik != null &&
                    this.OwnerCik.Equals(input.OwnerCik))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.PeriodEnded == input.PeriodEnded ||
                    (this.PeriodEnded != null &&
                    this.PeriodEnded.Equals(input.PeriodEnded))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.SoleVotingAuthority == input.SoleVotingAuthority ||
                    (this.SoleVotingAuthority != null &&
                    this.SoleVotingAuthority.Equals(input.SoleVotingAuthority))
                ) && 
                (
                    this.SharedVotingAuthority == input.SharedVotingAuthority ||
                    (this.SharedVotingAuthority != null &&
                    this.SharedVotingAuthority.Equals(input.SharedVotingAuthority))
                ) && 
                (
                    this.NoVotingAuthority == input.NoVotingAuthority ||
                    (this.NoVotingAuthority != null &&
                    this.NoVotingAuthority.Equals(input.NoVotingAuthority))
                ) && 
                (
                    this.PreviousAmount == input.PreviousAmount ||
                    (this.PreviousAmount != null &&
                    this.PreviousAmount.Equals(input.PreviousAmount))
                ) && 
                (
                    this.AmountChange == input.AmountChange ||
                    (this.AmountChange != null &&
                    this.AmountChange.Equals(input.AmountChange))
                ) && 
                (
                    this.AmountPercentChange == input.AmountPercentChange ||
                    (this.AmountPercentChange != null &&
                    this.AmountPercentChange.Equals(input.AmountPercentChange))
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
                if (this.OwnerCik != null)
                    hashCode = hashCode * 59 + this.OwnerCik.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.PeriodEnded != null)
                    hashCode = hashCode * 59 + this.PeriodEnded.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.SoleVotingAuthority != null)
                    hashCode = hashCode * 59 + this.SoleVotingAuthority.GetHashCode();
                if (this.SharedVotingAuthority != null)
                    hashCode = hashCode * 59 + this.SharedVotingAuthority.GetHashCode();
                if (this.NoVotingAuthority != null)
                    hashCode = hashCode * 59 + this.NoVotingAuthority.GetHashCode();
                if (this.PreviousAmount != null)
                    hashCode = hashCode * 59 + this.PreviousAmount.GetHashCode();
                if (this.AmountChange != null)
                    hashCode = hashCode * 59 + this.AmountChange.GetHashCode();
                if (this.AmountPercentChange != null)
                    hashCode = hashCode * 59 + this.AmountPercentChange.GetHashCode();
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



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
    /// Returns a list of all ownership interests and the value of their interests sourced from Zacks.
    /// </summary>
    [DataContract]
    public partial class ZacksInstitutionalHolding :  IEquatable<ZacksInstitutionalHolding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksInstitutionalHolding" /> class.
        /// </summary>
        /// <param name="Company">Company.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="AsOfDate">Quarter end date listed in the most recent 13F report filed by the institution.</param>
        /// <param name="SharesHeld">Number of shares of the stock listed.</param>
        /// <param name="SharedHeldPercent">Percent of shares outstanding held of the stock by the institution listed.</param>
        /// <param name="SharesChange">Change in shares of the stock held by the institution listed.</param>
        /// <param name="SharesChangePercent">Percentage change in shares of the stock held by the institution listed.</param>
        /// <param name="MarketValue">Market value of shares outstanding held of the stock listed.</param>
        /// <param name="MarketValueChange">Change in market value shares of the stock listed.</param>
        /// <param name="LastSecFilingType">The report type of the latest SEC filing.</param>
        /// <param name="LastSecFilingDate">The date of the latest SEC filing.</param>
        /// <param name="LastSecFilingShares">The.</param>
        /// <param name="HistoricalHoldings">HistoricalHoldings.</param>
        public ZacksInstitutionalHolding(ZacksInstitutionalHoldingCompanySummary Company = default(ZacksInstitutionalHoldingCompanySummary), ZacksInstitutionalHoldingOwnerSummary Owner = default(ZacksInstitutionalHoldingOwnerSummary), DateTime? AsOfDate = default(DateTime?), decimal? SharesHeld = default(decimal?), decimal? SharedHeldPercent = default(decimal?), decimal? SharesChange = default(decimal?), decimal? SharesChangePercent = default(decimal?), decimal? MarketValue = default(decimal?), decimal? MarketValueChange = default(decimal?), string LastSecFilingType = default(string), DateTime? LastSecFilingDate = default(DateTime?), decimal? LastSecFilingShares = default(decimal?), List<ZacksInstitutionalHoldingHistoricalSummary> HistoricalHoldings = default(List<ZacksInstitutionalHoldingHistoricalSummary>))
        {
            this.Company = Company;
            this.Owner = Owner;
            this.AsOfDate = AsOfDate;
            this.SharesHeld = SharesHeld;
            this.SharedHeldPercent = SharedHeldPercent;
            this.SharesChange = SharesChange;
            this.SharesChangePercent = SharesChangePercent;
            this.MarketValue = MarketValue;
            this.MarketValueChange = MarketValueChange;
            this.LastSecFilingType = LastSecFilingType;
            this.LastSecFilingDate = LastSecFilingDate;
            this.LastSecFilingShares = LastSecFilingShares;
            this.HistoricalHoldings = HistoricalHoldings;
        }
        
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public ZacksInstitutionalHoldingCompanySummary Company { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public ZacksInstitutionalHoldingOwnerSummary Owner { get; set; }

        /// <summary>
        /// Quarter end date listed in the most recent 13F report filed by the institution
        /// </summary>
        /// <value>Quarter end date listed in the most recent 13F report filed by the institution</value>
        [DataMember(Name="as_of_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? AsOfDate { get; set; }

        /// <summary>
        /// Number of shares of the stock listed
        /// </summary>
        /// <value>Number of shares of the stock listed</value>
        [DataMember(Name="shares_held", EmitDefaultValue=false)]
        public decimal? SharesHeld { get; set; }

        /// <summary>
        /// Percent of shares outstanding held of the stock by the institution listed
        /// </summary>
        /// <value>Percent of shares outstanding held of the stock by the institution listed</value>
        [DataMember(Name="shared_held_percent", EmitDefaultValue=false)]
        public decimal? SharedHeldPercent { get; set; }

        /// <summary>
        /// Change in shares of the stock held by the institution listed
        /// </summary>
        /// <value>Change in shares of the stock held by the institution listed</value>
        [DataMember(Name="shares_change", EmitDefaultValue=false)]
        public decimal? SharesChange { get; set; }

        /// <summary>
        /// Percentage change in shares of the stock held by the institution listed
        /// </summary>
        /// <value>Percentage change in shares of the stock held by the institution listed</value>
        [DataMember(Name="shares_change_percent", EmitDefaultValue=false)]
        public decimal? SharesChangePercent { get; set; }

        /// <summary>
        /// Market value of shares outstanding held of the stock listed
        /// </summary>
        /// <value>Market value of shares outstanding held of the stock listed</value>
        [DataMember(Name="market_value", EmitDefaultValue=false)]
        public decimal? MarketValue { get; set; }

        /// <summary>
        /// Change in market value shares of the stock listed
        /// </summary>
        /// <value>Change in market value shares of the stock listed</value>
        [DataMember(Name="market_value_change", EmitDefaultValue=false)]
        public decimal? MarketValueChange { get; set; }

        /// <summary>
        /// The report type of the latest SEC filing
        /// </summary>
        /// <value>The report type of the latest SEC filing</value>
        [DataMember(Name="last_sec_filing_type", EmitDefaultValue=false)]
        public string LastSecFilingType { get; set; }

        /// <summary>
        /// The date of the latest SEC filing
        /// </summary>
        /// <value>The date of the latest SEC filing</value>
        [DataMember(Name="last_sec_filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastSecFilingDate { get; set; }

        /// <summary>
        /// The
        /// </summary>
        /// <value>The</value>
        [DataMember(Name="last_sec_filing_shares", EmitDefaultValue=false)]
        public decimal? LastSecFilingShares { get; set; }

        /// <summary>
        /// Gets or Sets HistoricalHoldings
        /// </summary>
        [DataMember(Name="historical_holdings", EmitDefaultValue=false)]
        public List<ZacksInstitutionalHoldingHistoricalSummary> HistoricalHoldings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksInstitutionalHolding {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  SharesHeld: ").Append(SharesHeld).Append("\n");
            sb.Append("  SharedHeldPercent: ").Append(SharedHeldPercent).Append("\n");
            sb.Append("  SharesChange: ").Append(SharesChange).Append("\n");
            sb.Append("  SharesChangePercent: ").Append(SharesChangePercent).Append("\n");
            sb.Append("  MarketValue: ").Append(MarketValue).Append("\n");
            sb.Append("  MarketValueChange: ").Append(MarketValueChange).Append("\n");
            sb.Append("  LastSecFilingType: ").Append(LastSecFilingType).Append("\n");
            sb.Append("  LastSecFilingDate: ").Append(LastSecFilingDate).Append("\n");
            sb.Append("  LastSecFilingShares: ").Append(LastSecFilingShares).Append("\n");
            sb.Append("  HistoricalHoldings: ").Append(HistoricalHoldings).Append("\n");
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
            return this.Equals(input as ZacksInstitutionalHolding);
        }

        /// <summary>
        /// Returns true if ZacksInstitutionalHolding instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksInstitutionalHolding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksInstitutionalHolding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.SharesHeld == input.SharesHeld ||
                    (this.SharesHeld != null &&
                    this.SharesHeld.Equals(input.SharesHeld))
                ) && 
                (
                    this.SharedHeldPercent == input.SharedHeldPercent ||
                    (this.SharedHeldPercent != null &&
                    this.SharedHeldPercent.Equals(input.SharedHeldPercent))
                ) && 
                (
                    this.SharesChange == input.SharesChange ||
                    (this.SharesChange != null &&
                    this.SharesChange.Equals(input.SharesChange))
                ) && 
                (
                    this.SharesChangePercent == input.SharesChangePercent ||
                    (this.SharesChangePercent != null &&
                    this.SharesChangePercent.Equals(input.SharesChangePercent))
                ) && 
                (
                    this.MarketValue == input.MarketValue ||
                    (this.MarketValue != null &&
                    this.MarketValue.Equals(input.MarketValue))
                ) && 
                (
                    this.MarketValueChange == input.MarketValueChange ||
                    (this.MarketValueChange != null &&
                    this.MarketValueChange.Equals(input.MarketValueChange))
                ) && 
                (
                    this.LastSecFilingType == input.LastSecFilingType ||
                    (this.LastSecFilingType != null &&
                    this.LastSecFilingType.Equals(input.LastSecFilingType))
                ) && 
                (
                    this.LastSecFilingDate == input.LastSecFilingDate ||
                    (this.LastSecFilingDate != null &&
                    this.LastSecFilingDate.Equals(input.LastSecFilingDate))
                ) && 
                (
                    this.LastSecFilingShares == input.LastSecFilingShares ||
                    (this.LastSecFilingShares != null &&
                    this.LastSecFilingShares.Equals(input.LastSecFilingShares))
                ) && 
                (
                    this.HistoricalHoldings == input.HistoricalHoldings ||
                    this.HistoricalHoldings != null &&
                    this.HistoricalHoldings.SequenceEqual(input.HistoricalHoldings)
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.AsOfDate != null)
                    hashCode = hashCode * 59 + this.AsOfDate.GetHashCode();
                if (this.SharesHeld != null)
                    hashCode = hashCode * 59 + this.SharesHeld.GetHashCode();
                if (this.SharedHeldPercent != null)
                    hashCode = hashCode * 59 + this.SharedHeldPercent.GetHashCode();
                if (this.SharesChange != null)
                    hashCode = hashCode * 59 + this.SharesChange.GetHashCode();
                if (this.SharesChangePercent != null)
                    hashCode = hashCode * 59 + this.SharesChangePercent.GetHashCode();
                if (this.MarketValue != null)
                    hashCode = hashCode * 59 + this.MarketValue.GetHashCode();
                if (this.MarketValueChange != null)
                    hashCode = hashCode * 59 + this.MarketValueChange.GetHashCode();
                if (this.LastSecFilingType != null)
                    hashCode = hashCode * 59 + this.LastSecFilingType.GetHashCode();
                if (this.LastSecFilingDate != null)
                    hashCode = hashCode * 59 + this.LastSecFilingDate.GetHashCode();
                if (this.LastSecFilingShares != null)
                    hashCode = hashCode * 59 + this.LastSecFilingShares.GetHashCode();
                if (this.HistoricalHoldings != null)
                    hashCode = hashCode * 59 + this.HistoricalHoldings.GetHashCode();
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

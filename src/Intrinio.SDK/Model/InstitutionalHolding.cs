

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
    /// A single institutional holding for an owner.
    /// </summary>
    [DataContract]
    public partial class InstitutionalHolding :  IEquatable<InstitutionalHolding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionalHolding" /> class.
        /// </summary>
        /// <param name="Cusip">The CUSIP number for the security report by the Institutional Owner.</param>
        /// <param name="Ticker">The ticker symbol for the security.</param>
        /// <param name="SecurityName">The name of the security.</param>
        /// <param name="SecurityType">The type of the security.</param>
        /// <param name="TitleOfClass">The class of stock held.</param>
        /// <param name="StockExchange">The stock exchange where the security is traded.</param>
        /// <param name="FilingDate">The date when the filing was submitted to the SEC by the company.</param>
        /// <param name="Value">The market value in amount of dollars of the holding in the listed security.</param>
        /// <param name="Amount">The number of shares held in the listed security.</param>
        /// <param name="Type">Shares.</param>
        /// <param name="InvestmentDiscretion">Segregate the holdings of securities of a class according to the nature of the investment discretion held by the Manager..</param>
        /// <param name="OtherManager">A code for other managerial authority of the securities listed.</param>
        /// <param name="SoleVotingAuthority">The number of shares where the insitutional holder has sole voting authority.</param>
        /// <param name="SharedVotingAuthority">The number of shares where the insitutional holder has shared voting authority.</param>
        /// <param name="NoVotingAuthority">The number of shares where the insitutional holder has no voting authority.</param>
        public InstitutionalHolding(string Cusip = default(string), string Ticker = default(string), string SecurityName = default(string), string SecurityType = default(string), string TitleOfClass = default(string), string StockExchange = default(string), DateTime? FilingDate = default(DateTime?), decimal? Value = default(decimal?), decimal? Amount = default(decimal?), string Type = default(string), string InvestmentDiscretion = default(string), string OtherManager = default(string), decimal? SoleVotingAuthority = default(decimal?), decimal? SharedVotingAuthority = default(decimal?), decimal? NoVotingAuthority = default(decimal?))
        {
            this.Cusip = Cusip;
            this.Ticker = Ticker;
            this.SecurityName = SecurityName;
            this.SecurityType = SecurityType;
            this.TitleOfClass = TitleOfClass;
            this.StockExchange = StockExchange;
            this.FilingDate = FilingDate;
            this.Value = Value;
            this.Amount = Amount;
            this.Type = Type;
            this.InvestmentDiscretion = InvestmentDiscretion;
            this.OtherManager = OtherManager;
            this.SoleVotingAuthority = SoleVotingAuthority;
            this.SharedVotingAuthority = SharedVotingAuthority;
            this.NoVotingAuthority = NoVotingAuthority;
        }
        
        /// <summary>
        /// The CUSIP number for the security report by the Institutional Owner
        /// </summary>
        /// <value>The CUSIP number for the security report by the Institutional Owner</value>
        [DataMember(Name="cusip", EmitDefaultValue=false)]
        public string Cusip { get; set; }

        /// <summary>
        /// The ticker symbol for the security
        /// </summary>
        /// <value>The ticker symbol for the security</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The name of the security
        /// </summary>
        /// <value>The name of the security</value>
        [DataMember(Name="security_name", EmitDefaultValue=false)]
        public string SecurityName { get; set; }

        /// <summary>
        /// The type of the security
        /// </summary>
        /// <value>The type of the security</value>
        [DataMember(Name="security_type", EmitDefaultValue=false)]
        public string SecurityType { get; set; }

        /// <summary>
        /// The class of stock held
        /// </summary>
        /// <value>The class of stock held</value>
        [DataMember(Name="title_of_class", EmitDefaultValue=false)]
        public string TitleOfClass { get; set; }

        /// <summary>
        /// The stock exchange where the security is traded
        /// </summary>
        /// <value>The stock exchange where the security is traded</value>
        [DataMember(Name="stock_exchange", EmitDefaultValue=false)]
        public string StockExchange { get; set; }

        /// <summary>
        /// The date when the filing was submitted to the SEC by the company
        /// </summary>
        /// <value>The date when the filing was submitted to the SEC by the company</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FilingDate { get; set; }

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
        /// Shares
        /// </summary>
        /// <value>Shares</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Segregate the holdings of securities of a class according to the nature of the investment discretion held by the Manager.
        /// </summary>
        /// <value>Segregate the holdings of securities of a class according to the nature of the investment discretion held by the Manager.</value>
        [DataMember(Name="investment_discretion", EmitDefaultValue=false)]
        public string InvestmentDiscretion { get; set; }

        /// <summary>
        /// A code for other managerial authority of the securities listed
        /// </summary>
        /// <value>A code for other managerial authority of the securities listed</value>
        [DataMember(Name="other_manager", EmitDefaultValue=false)]
        public string OtherManager { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstitutionalHolding {\n");
            sb.Append("  Cusip: ").Append(Cusip).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  SecurityName: ").Append(SecurityName).Append("\n");
            sb.Append("  SecurityType: ").Append(SecurityType).Append("\n");
            sb.Append("  TitleOfClass: ").Append(TitleOfClass).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InvestmentDiscretion: ").Append(InvestmentDiscretion).Append("\n");
            sb.Append("  OtherManager: ").Append(OtherManager).Append("\n");
            sb.Append("  SoleVotingAuthority: ").Append(SoleVotingAuthority).Append("\n");
            sb.Append("  SharedVotingAuthority: ").Append(SharedVotingAuthority).Append("\n");
            sb.Append("  NoVotingAuthority: ").Append(NoVotingAuthority).Append("\n");
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
            return this.Equals(input as InstitutionalHolding);
        }

        /// <summary>
        /// Returns true if InstitutionalHolding instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionalHolding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionalHolding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cusip == input.Cusip ||
                    (this.Cusip != null &&
                    this.Cusip.Equals(input.Cusip))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.SecurityName == input.SecurityName ||
                    (this.SecurityName != null &&
                    this.SecurityName.Equals(input.SecurityName))
                ) && 
                (
                    this.SecurityType == input.SecurityType ||
                    (this.SecurityType != null &&
                    this.SecurityType.Equals(input.SecurityType))
                ) && 
                (
                    this.TitleOfClass == input.TitleOfClass ||
                    (this.TitleOfClass != null &&
                    this.TitleOfClass.Equals(input.TitleOfClass))
                ) && 
                (
                    this.StockExchange == input.StockExchange ||
                    (this.StockExchange != null &&
                    this.StockExchange.Equals(input.StockExchange))
                ) && 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.InvestmentDiscretion == input.InvestmentDiscretion ||
                    (this.InvestmentDiscretion != null &&
                    this.InvestmentDiscretion.Equals(input.InvestmentDiscretion))
                ) && 
                (
                    this.OtherManager == input.OtherManager ||
                    (this.OtherManager != null &&
                    this.OtherManager.Equals(input.OtherManager))
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
                if (this.Cusip != null)
                    hashCode = hashCode * 59 + this.Cusip.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.SecurityName != null)
                    hashCode = hashCode * 59 + this.SecurityName.GetHashCode();
                if (this.SecurityType != null)
                    hashCode = hashCode * 59 + this.SecurityType.GetHashCode();
                if (this.TitleOfClass != null)
                    hashCode = hashCode * 59 + this.TitleOfClass.GetHashCode();
                if (this.StockExchange != null)
                    hashCode = hashCode * 59 + this.StockExchange.GetHashCode();
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InvestmentDiscretion != null)
                    hashCode = hashCode * 59 + this.InvestmentDiscretion.GetHashCode();
                if (this.OtherManager != null)
                    hashCode = hashCode * 59 + this.OtherManager.GetHashCode();
                if (this.SoleVotingAuthority != null)
                    hashCode = hashCode * 59 + this.SoleVotingAuthority.GetHashCode();
                if (this.SharedVotingAuthority != null)
                    hashCode = hashCode * 59 + this.SharedVotingAuthority.GetHashCode();
                if (this.NoVotingAuthority != null)
                    hashCode = hashCode * 59 + this.NoVotingAuthority.GetHashCode();
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

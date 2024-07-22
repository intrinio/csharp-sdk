

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
    /// An insider transaction SEC filing and its associated transactions
    /// </summary>
    [DataContract]
    public partial class InsiderTransactionFiling :  IEquatable<InsiderTransactionFiling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsiderTransactionFiling" /> class.
        /// </summary>
        /// <param name="FilingDate">The date of the filing with the SEC made by the owner.</param>
        /// <param name="FilingUrl">The URL of the filing with the SEC.</param>
        /// <param name="IssuerTicker">The ticker of the issuing company..</param>
        /// <param name="IssuerCik">The Central Index Key (CIK) of the issuing company..</param>
        /// <param name="IssuerCompany">The name of the issuing company..</param>
        /// <param name="Transactions">The insider transactions associated with the filing.</param>
        /// <param name="Company">The company associated with the filing.</param>
        /// <param name="Owner">The owner associated with the filing.</param>
        public InsiderTransactionFiling(DateTime? FilingDate = default(DateTime?), string FilingUrl = default(string), string IssuerTicker = default(string), string IssuerCik = default(string), string IssuerCompany = default(string), List<InsiderTransaction> Transactions = default(List<InsiderTransaction>), CompanySummary Company = default(CompanySummary), OwnerSummary Owner = default(OwnerSummary))
        {
            this.FilingDate = FilingDate;
            this.FilingUrl = FilingUrl;
            this.IssuerTicker = IssuerTicker;
            this.IssuerCik = IssuerCik;
            this.IssuerCompany = IssuerCompany;
            this.Transactions = Transactions;
            this.Company = Company;
            this.Owner = Owner;
        }
        
        /// <summary>
        /// The date of the filing with the SEC made by the owner
        /// </summary>
        /// <value>The date of the filing with the SEC made by the owner</value>
        [DataMember(Name="filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FilingDate { get; set; }

        /// <summary>
        /// The URL of the filing with the SEC
        /// </summary>
        /// <value>The URL of the filing with the SEC</value>
        [DataMember(Name="filing_url", EmitDefaultValue=false)]
        public string FilingUrl { get; set; }

        /// <summary>
        /// The ticker of the issuing company.
        /// </summary>
        /// <value>The ticker of the issuing company.</value>
        [DataMember(Name="issuer_ticker", EmitDefaultValue=false)]
        public string IssuerTicker { get; set; }

        /// <summary>
        /// The Central Index Key (CIK) of the issuing company.
        /// </summary>
        /// <value>The Central Index Key (CIK) of the issuing company.</value>
        [DataMember(Name="issuer_cik", EmitDefaultValue=false)]
        public string IssuerCik { get; set; }

        /// <summary>
        /// The name of the issuing company.
        /// </summary>
        /// <value>The name of the issuing company.</value>
        [DataMember(Name="issuer_company", EmitDefaultValue=false)]
        public string IssuerCompany { get; set; }

        /// <summary>
        /// The insider transactions associated with the filing
        /// </summary>
        /// <value>The insider transactions associated with the filing</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<InsiderTransaction> Transactions { get; set; }

        /// <summary>
        /// The company associated with the filing
        /// </summary>
        /// <value>The company associated with the filing</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// The owner associated with the filing
        /// </summary>
        /// <value>The owner associated with the filing</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public OwnerSummary Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsiderTransactionFiling {\n");
            sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
            sb.Append("  FilingUrl: ").Append(FilingUrl).Append("\n");
            sb.Append("  IssuerTicker: ").Append(IssuerTicker).Append("\n");
            sb.Append("  IssuerCik: ").Append(IssuerCik).Append("\n");
            sb.Append("  IssuerCompany: ").Append(IssuerCompany).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as InsiderTransactionFiling);
        }

        /// <summary>
        /// Returns true if InsiderTransactionFiling instances are equal
        /// </summary>
        /// <param name="input">Instance of InsiderTransactionFiling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsiderTransactionFiling input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilingDate == input.FilingDate ||
                    (this.FilingDate != null &&
                    this.FilingDate.Equals(input.FilingDate))
                ) && 
                (
                    this.FilingUrl == input.FilingUrl ||
                    (this.FilingUrl != null &&
                    this.FilingUrl.Equals(input.FilingUrl))
                ) && 
                (
                    this.IssuerTicker == input.IssuerTicker ||
                    (this.IssuerTicker != null &&
                    this.IssuerTicker.Equals(input.IssuerTicker))
                ) && 
                (
                    this.IssuerCik == input.IssuerCik ||
                    (this.IssuerCik != null &&
                    this.IssuerCik.Equals(input.IssuerCik))
                ) && 
                (
                    this.IssuerCompany == input.IssuerCompany ||
                    (this.IssuerCompany != null &&
                    this.IssuerCompany.Equals(input.IssuerCompany))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.FilingDate != null)
                    hashCode = hashCode * 59 + this.FilingDate.GetHashCode();
                if (this.FilingUrl != null)
                    hashCode = hashCode * 59 + this.FilingUrl.GetHashCode();
                if (this.IssuerTicker != null)
                    hashCode = hashCode * 59 + this.IssuerTicker.GetHashCode();
                if (this.IssuerCik != null)
                    hashCode = hashCode * 59 + this.IssuerCik.GetHashCode();
                if (this.IssuerCompany != null)
                    hashCode = hashCode * 59 + this.IssuerCompany.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
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



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
        /// <param name="FilingUrl">The URL of the filing with the SEC.</param>
        /// <param name="Transactions">The insider transactions associated with the filing.</param>
        /// <param name="Company">The company associated with the filing.</param>
        /// <param name="Owner">The owner associated with the filing.</param>
        public InsiderTransactionFiling(string FilingUrl = default(string), List<InsiderTransaction> Transactions = default(List<InsiderTransaction>), CompanySummary Company = default(CompanySummary), OwnerSummary Owner = default(OwnerSummary))
        {
            this.FilingUrl = FilingUrl;
            this.Transactions = Transactions;
            this.Company = Company;
            this.Owner = Owner;
        }
        
        /// <summary>
        /// The URL of the filing with the SEC
        /// </summary>
        /// <value>The URL of the filing with the SEC</value>
        [DataMember(Name="filing_url", EmitDefaultValue=false)]
        public string FilingUrl { get; set; }

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
            sb.Append("  FilingUrl: ").Append(FilingUrl).Append("\n");
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
                    this.FilingUrl == input.FilingUrl ||
                    (this.FilingUrl != null &&
                    this.FilingUrl.Equals(input.FilingUrl))
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
                if (this.FilingUrl != null)
                    hashCode = hashCode * 59 + this.FilingUrl.GetHashCode();
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

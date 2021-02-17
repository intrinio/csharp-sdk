

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
    /// A transaction where the owner is considered an insider of that company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
    /// </summary>
    [DataContract]
    public partial class InsiderTransaction :  IEquatable<InsiderTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsiderTransaction" /> class.
        /// </summary>
        /// <param name="Director">(true/false) A boolean indicating whether or not the owner is a director in the company.</param>
        /// <param name="Officer">(true/false) A boolean indicating whether or not the owner is a officer in the company.</param>
        /// <param name="TenPercentOwner">(true/false) A boolean indicating whether or not the owner has a ten percent or greater interest in the company.</param>
        /// <param name="OtherRelation">(true/false) A boolean indicating whether or not the owner has another relationship with the company beside, direct, officer, or significant owner in the company.</param>
        /// <param name="OfficerTitle">The officer title of the owner in the company.</param>
        /// <param name="DerivativeTransaction">(true) A boolean indicating the transaction is a derivative transaction, which may or may not become common stock due to various possible exercise or conversion requirements.</param>
        /// <param name="Ticker">The ticker symbol for the company’s common stock.</param>
        /// <param name="SecurityTitle">The name of the derivative security transacted.</param>
        /// <param name="ConversionExercisePrice">The conversion or exercise price of the derivative security transacted.</param>
        /// <param name="TransactionTypeCode">A symbol representing the transaction type; P &#x3D; Purchase | S &#x3D; Sale | A  &#x3D; Award | M &#x3D; Conversion to Common | C &#x3D; Conversion | X &#x3D; Exercise of Derivative More Transaction Codes.</param>
        /// <param name="AcquisitionDispositionCode">A symbol representing whether or not the derivative securities are Acquired or Disposed; A &#x3D; Acquisition | D &#x3D; Disposition.</param>
        /// <param name="AmountOfShares">The number of derivative securities involved in the subject transaction.</param>
        /// <param name="UnderlyingSecurityTitle">The name of the underlying non-derivative security related to this derivative transaction.</param>
        /// <param name="UnderlyingShares">The number of non-derivative shares involved in the subject transaction.</param>
        /// <param name="TransactionPrice">The price of the derivative securities.</param>
        /// <param name="TotalSharesOwned">The total number of derivative securities owned following the subject transaction.</param>
        /// <param name="OwnershipTypeCode">A symbol representing the ownership of the securities transacted; D &#x3D; Direct Ownership | I &#x3D; Indirect Ownership.</param>
        /// <param name="Company">The company associated with the filing.</param>
        /// <param name="Owner">The owner associated with the filing.</param>
        public InsiderTransaction(bool? Director = default(bool?), bool? Officer = default(bool?), bool? TenPercentOwner = default(bool?), bool? OtherRelation = default(bool?), string OfficerTitle = default(string), bool? DerivativeTransaction = default(bool?), string Ticker = default(string), string SecurityTitle = default(string), decimal? ConversionExercisePrice = default(decimal?), string TransactionTypeCode = default(string), string AcquisitionDispositionCode = default(string), decimal? AmountOfShares = default(decimal?), string UnderlyingSecurityTitle = default(string), decimal? UnderlyingShares = default(decimal?), decimal? TransactionPrice = default(decimal?), decimal? TotalSharesOwned = default(decimal?), string OwnershipTypeCode = default(string), CompanySummary Company = default(CompanySummary), OwnerSummary Owner = default(OwnerSummary))
        {
            this.Director = Director;
            this.Officer = Officer;
            this.TenPercentOwner = TenPercentOwner;
            this.OtherRelation = OtherRelation;
            this.OfficerTitle = OfficerTitle;
            this.DerivativeTransaction = DerivativeTransaction;
            this.Ticker = Ticker;
            this.SecurityTitle = SecurityTitle;
            this.ConversionExercisePrice = ConversionExercisePrice;
            this.TransactionTypeCode = TransactionTypeCode;
            this.AcquisitionDispositionCode = AcquisitionDispositionCode;
            this.AmountOfShares = AmountOfShares;
            this.UnderlyingSecurityTitle = UnderlyingSecurityTitle;
            this.UnderlyingShares = UnderlyingShares;
            this.TransactionPrice = TransactionPrice;
            this.TotalSharesOwned = TotalSharesOwned;
            this.OwnershipTypeCode = OwnershipTypeCode;
            this.Company = Company;
            this.Owner = Owner;
        }
        
        /// <summary>
        /// (true/false) A boolean indicating whether or not the owner is a director in the company
        /// </summary>
        /// <value>(true/false) A boolean indicating whether or not the owner is a director in the company</value>
        [DataMember(Name="director", EmitDefaultValue=false)]
        public bool? Director { get; set; }

        /// <summary>
        /// (true/false) A boolean indicating whether or not the owner is a officer in the company
        /// </summary>
        /// <value>(true/false) A boolean indicating whether or not the owner is a officer in the company</value>
        [DataMember(Name="officer", EmitDefaultValue=false)]
        public bool? Officer { get; set; }

        /// <summary>
        /// (true/false) A boolean indicating whether or not the owner has a ten percent or greater interest in the company
        /// </summary>
        /// <value>(true/false) A boolean indicating whether or not the owner has a ten percent or greater interest in the company</value>
        [DataMember(Name="ten_percent_owner", EmitDefaultValue=false)]
        public bool? TenPercentOwner { get; set; }

        /// <summary>
        /// (true/false) A boolean indicating whether or not the owner has another relationship with the company beside, direct, officer, or significant owner in the company
        /// </summary>
        /// <value>(true/false) A boolean indicating whether or not the owner has another relationship with the company beside, direct, officer, or significant owner in the company</value>
        [DataMember(Name="other_relation", EmitDefaultValue=false)]
        public bool? OtherRelation { get; set; }

        /// <summary>
        /// The officer title of the owner in the company
        /// </summary>
        /// <value>The officer title of the owner in the company</value>
        [DataMember(Name="officer_title", EmitDefaultValue=false)]
        public string OfficerTitle { get; set; }

        /// <summary>
        /// (true) A boolean indicating the transaction is a derivative transaction, which may or may not become common stock due to various possible exercise or conversion requirements
        /// </summary>
        /// <value>(true) A boolean indicating the transaction is a derivative transaction, which may or may not become common stock due to various possible exercise or conversion requirements</value>
        [DataMember(Name="derivative_transaction", EmitDefaultValue=false)]
        public bool? DerivativeTransaction { get; set; }

        /// <summary>
        /// The ticker symbol for the company’s common stock
        /// </summary>
        /// <value>The ticker symbol for the company’s common stock</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The name of the derivative security transacted
        /// </summary>
        /// <value>The name of the derivative security transacted</value>
        [DataMember(Name="security_title", EmitDefaultValue=false)]
        public string SecurityTitle { get; set; }

        /// <summary>
        /// The conversion or exercise price of the derivative security transacted
        /// </summary>
        /// <value>The conversion or exercise price of the derivative security transacted</value>
        [DataMember(Name="conversion_exercise_price", EmitDefaultValue=false)]
        public decimal? ConversionExercisePrice { get; set; }

        /// <summary>
        /// A symbol representing the transaction type; P &#x3D; Purchase | S &#x3D; Sale | A  &#x3D; Award | M &#x3D; Conversion to Common | C &#x3D; Conversion | X &#x3D; Exercise of Derivative More Transaction Codes
        /// </summary>
        /// <value>A symbol representing the transaction type; P &#x3D; Purchase | S &#x3D; Sale | A  &#x3D; Award | M &#x3D; Conversion to Common | C &#x3D; Conversion | X &#x3D; Exercise of Derivative More Transaction Codes</value>
        [DataMember(Name="transaction_type_code", EmitDefaultValue=false)]
        public string TransactionTypeCode { get; set; }

        /// <summary>
        /// A symbol representing whether or not the derivative securities are Acquired or Disposed; A &#x3D; Acquisition | D &#x3D; Disposition
        /// </summary>
        /// <value>A symbol representing whether or not the derivative securities are Acquired or Disposed; A &#x3D; Acquisition | D &#x3D; Disposition</value>
        [DataMember(Name="acquisition_disposition_code", EmitDefaultValue=false)]
        public string AcquisitionDispositionCode { get; set; }

        /// <summary>
        /// The number of derivative securities involved in the subject transaction
        /// </summary>
        /// <value>The number of derivative securities involved in the subject transaction</value>
        [DataMember(Name="amount_of_shares", EmitDefaultValue=false)]
        public decimal? AmountOfShares { get; set; }

        /// <summary>
        /// The name of the underlying non-derivative security related to this derivative transaction
        /// </summary>
        /// <value>The name of the underlying non-derivative security related to this derivative transaction</value>
        [DataMember(Name="underlying_security_title", EmitDefaultValue=false)]
        public string UnderlyingSecurityTitle { get; set; }

        /// <summary>
        /// The number of non-derivative shares involved in the subject transaction
        /// </summary>
        /// <value>The number of non-derivative shares involved in the subject transaction</value>
        [DataMember(Name="underlying_shares", EmitDefaultValue=false)]
        public decimal? UnderlyingShares { get; set; }

        /// <summary>
        /// The price of the derivative securities
        /// </summary>
        /// <value>The price of the derivative securities</value>
        [DataMember(Name="transaction_price", EmitDefaultValue=false)]
        public decimal? TransactionPrice { get; set; }

        /// <summary>
        /// The total number of derivative securities owned following the subject transaction
        /// </summary>
        /// <value>The total number of derivative securities owned following the subject transaction</value>
        [DataMember(Name="total_shares_owned", EmitDefaultValue=false)]
        public decimal? TotalSharesOwned { get; set; }

        /// <summary>
        /// A symbol representing the ownership of the securities transacted; D &#x3D; Direct Ownership | I &#x3D; Indirect Ownership
        /// </summary>
        /// <value>A symbol representing the ownership of the securities transacted; D &#x3D; Direct Ownership | I &#x3D; Indirect Ownership</value>
        [DataMember(Name="ownership_type_code", EmitDefaultValue=false)]
        public string OwnershipTypeCode { get; set; }

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
            sb.Append("class InsiderTransaction {\n");
            sb.Append("  Director: ").Append(Director).Append("\n");
            sb.Append("  Officer: ").Append(Officer).Append("\n");
            sb.Append("  TenPercentOwner: ").Append(TenPercentOwner).Append("\n");
            sb.Append("  OtherRelation: ").Append(OtherRelation).Append("\n");
            sb.Append("  OfficerTitle: ").Append(OfficerTitle).Append("\n");
            sb.Append("  DerivativeTransaction: ").Append(DerivativeTransaction).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  SecurityTitle: ").Append(SecurityTitle).Append("\n");
            sb.Append("  ConversionExercisePrice: ").Append(ConversionExercisePrice).Append("\n");
            sb.Append("  TransactionTypeCode: ").Append(TransactionTypeCode).Append("\n");
            sb.Append("  AcquisitionDispositionCode: ").Append(AcquisitionDispositionCode).Append("\n");
            sb.Append("  AmountOfShares: ").Append(AmountOfShares).Append("\n");
            sb.Append("  UnderlyingSecurityTitle: ").Append(UnderlyingSecurityTitle).Append("\n");
            sb.Append("  UnderlyingShares: ").Append(UnderlyingShares).Append("\n");
            sb.Append("  TransactionPrice: ").Append(TransactionPrice).Append("\n");
            sb.Append("  TotalSharesOwned: ").Append(TotalSharesOwned).Append("\n");
            sb.Append("  OwnershipTypeCode: ").Append(OwnershipTypeCode).Append("\n");
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
            return this.Equals(input as InsiderTransaction);
        }

        /// <summary>
        /// Returns true if InsiderTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of InsiderTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsiderTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Director == input.Director ||
                    (this.Director != null &&
                    this.Director.Equals(input.Director))
                ) && 
                (
                    this.Officer == input.Officer ||
                    (this.Officer != null &&
                    this.Officer.Equals(input.Officer))
                ) && 
                (
                    this.TenPercentOwner == input.TenPercentOwner ||
                    (this.TenPercentOwner != null &&
                    this.TenPercentOwner.Equals(input.TenPercentOwner))
                ) && 
                (
                    this.OtherRelation == input.OtherRelation ||
                    (this.OtherRelation != null &&
                    this.OtherRelation.Equals(input.OtherRelation))
                ) && 
                (
                    this.OfficerTitle == input.OfficerTitle ||
                    (this.OfficerTitle != null &&
                    this.OfficerTitle.Equals(input.OfficerTitle))
                ) && 
                (
                    this.DerivativeTransaction == input.DerivativeTransaction ||
                    (this.DerivativeTransaction != null &&
                    this.DerivativeTransaction.Equals(input.DerivativeTransaction))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.SecurityTitle == input.SecurityTitle ||
                    (this.SecurityTitle != null &&
                    this.SecurityTitle.Equals(input.SecurityTitle))
                ) && 
                (
                    this.ConversionExercisePrice == input.ConversionExercisePrice ||
                    (this.ConversionExercisePrice != null &&
                    this.ConversionExercisePrice.Equals(input.ConversionExercisePrice))
                ) && 
                (
                    this.TransactionTypeCode == input.TransactionTypeCode ||
                    (this.TransactionTypeCode != null &&
                    this.TransactionTypeCode.Equals(input.TransactionTypeCode))
                ) && 
                (
                    this.AcquisitionDispositionCode == input.AcquisitionDispositionCode ||
                    (this.AcquisitionDispositionCode != null &&
                    this.AcquisitionDispositionCode.Equals(input.AcquisitionDispositionCode))
                ) && 
                (
                    this.AmountOfShares == input.AmountOfShares ||
                    (this.AmountOfShares != null &&
                    this.AmountOfShares.Equals(input.AmountOfShares))
                ) && 
                (
                    this.UnderlyingSecurityTitle == input.UnderlyingSecurityTitle ||
                    (this.UnderlyingSecurityTitle != null &&
                    this.UnderlyingSecurityTitle.Equals(input.UnderlyingSecurityTitle))
                ) && 
                (
                    this.UnderlyingShares == input.UnderlyingShares ||
                    (this.UnderlyingShares != null &&
                    this.UnderlyingShares.Equals(input.UnderlyingShares))
                ) && 
                (
                    this.TransactionPrice == input.TransactionPrice ||
                    (this.TransactionPrice != null &&
                    this.TransactionPrice.Equals(input.TransactionPrice))
                ) && 
                (
                    this.TotalSharesOwned == input.TotalSharesOwned ||
                    (this.TotalSharesOwned != null &&
                    this.TotalSharesOwned.Equals(input.TotalSharesOwned))
                ) && 
                (
                    this.OwnershipTypeCode == input.OwnershipTypeCode ||
                    (this.OwnershipTypeCode != null &&
                    this.OwnershipTypeCode.Equals(input.OwnershipTypeCode))
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
                if (this.Director != null)
                    hashCode = hashCode * 59 + this.Director.GetHashCode();
                if (this.Officer != null)
                    hashCode = hashCode * 59 + this.Officer.GetHashCode();
                if (this.TenPercentOwner != null)
                    hashCode = hashCode * 59 + this.TenPercentOwner.GetHashCode();
                if (this.OtherRelation != null)
                    hashCode = hashCode * 59 + this.OtherRelation.GetHashCode();
                if (this.OfficerTitle != null)
                    hashCode = hashCode * 59 + this.OfficerTitle.GetHashCode();
                if (this.DerivativeTransaction != null)
                    hashCode = hashCode * 59 + this.DerivativeTransaction.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.SecurityTitle != null)
                    hashCode = hashCode * 59 + this.SecurityTitle.GetHashCode();
                if (this.ConversionExercisePrice != null)
                    hashCode = hashCode * 59 + this.ConversionExercisePrice.GetHashCode();
                if (this.TransactionTypeCode != null)
                    hashCode = hashCode * 59 + this.TransactionTypeCode.GetHashCode();
                if (this.AcquisitionDispositionCode != null)
                    hashCode = hashCode * 59 + this.AcquisitionDispositionCode.GetHashCode();
                if (this.AmountOfShares != null)
                    hashCode = hashCode * 59 + this.AmountOfShares.GetHashCode();
                if (this.UnderlyingSecurityTitle != null)
                    hashCode = hashCode * 59 + this.UnderlyingSecurityTitle.GetHashCode();
                if (this.UnderlyingShares != null)
                    hashCode = hashCode * 59 + this.UnderlyingShares.GetHashCode();
                if (this.TransactionPrice != null)
                    hashCode = hashCode * 59 + this.TransactionPrice.GetHashCode();
                if (this.TotalSharesOwned != null)
                    hashCode = hashCode * 59 + this.TotalSharesOwned.GetHashCode();
                if (this.OwnershipTypeCode != null)
                    hashCode = hashCode * 59 + this.OwnershipTypeCode.GetHashCode();
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

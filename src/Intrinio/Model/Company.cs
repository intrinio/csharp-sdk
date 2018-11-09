

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// A company that submits filings to the SEC and has a security traded primarily on a US exchange
    /// </summary>
    [DataContract]
    public partial class Company :  IEquatable<Company>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the company.</param>
        /// <param name="Ticker">The stock market ticker symbol associated with the company&#39;s common stock securities.</param>
        /// <param name="Name">The company&#39;s common name.</param>
        /// <param name="Lei">The Legal Entity Identifier (LEI) assigned to the company.</param>
        /// <param name="LegalName">The company&#39;s official legal name.</param>
        /// <param name="StockExchange">The Stock Exchange where the company&#39;s common stock is primarily traded.</param>
        /// <param name="Sic">The Standard Industrial Classification (SIC) determined by the company and filed with the SEC.</param>
        /// <param name="ShortDescription">A one or two sentence description of the company&#39;s operations.</param>
        /// <param name="LongDescription">A one paragraph description of the company&#39;s operations and other corporate actions.</param>
        /// <param name="Ceo">The Chief Executive Officer of the company.</param>
        /// <param name="CompanyUrl">The URL of the company&#39;s primary corporate website or primary internet property.</param>
        /// <param name="BusinessAddress">The company&#39;s business address.</param>
        /// <param name="MailingAddress">The mailing address reported by the company.</param>
        /// <param name="BusinessPhoneNo">The phone number reported by the company.</param>
        /// <param name="HqAddress1">The company&#39;s headquarters address - line 1.</param>
        /// <param name="HqAddress2">The company&#39;s headquarters address - line 2.</param>
        /// <param name="HqAddressCity">The company&#39;s headquarters city.</param>
        /// <param name="HqAddressPostalCode">The company&#39;s headquarters postal code.</param>
        /// <param name="EntityLegalForm">The company&#39;s legal organization form.</param>
        /// <param name="Cik">The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings.</param>
        /// <param name="LatestFilingDate">The date of the company&#39;s last filing with the SEC.</param>
        /// <param name="HqState">The state (US &amp; Canada Only) where the company headquarters are located.</param>
        /// <param name="HqCountry">The country where the company headquarters are located.</param>
        /// <param name="IncState">The state (US &amp; Canada Only) where the company is incorporated.</param>
        /// <param name="IncCountry">The country where the company is incorporated.</param>
        /// <param name="Employees">The number of employees working for the company.</param>
        /// <param name="EntityStatus">EntityStatus.</param>
        /// <param name="Sector">The company&#39;s operating sector.</param>
        /// <param name="IndustryCategory">The company&#39;s operating industry category.</param>
        /// <param name="IndustryGroup">The company&#39;s operating industry group.</param>
        /// <param name="Template">The financial statement template used by Intrinio to standardize the as reported data.</param>
        /// <param name="StandardizedActive">If true, the company has standardized and as reported fundamental data via the Intrinio API; if false, the company has as-reported data only.</param>
        public Company(string Id = default(string), string Ticker = default(string), string Name = default(string), string Lei = default(string), string LegalName = default(string), string StockExchange = default(string), string Sic = default(string), string ShortDescription = default(string), string LongDescription = default(string), string Ceo = default(string), string CompanyUrl = default(string), string BusinessAddress = default(string), string MailingAddress = default(string), string BusinessPhoneNo = default(string), string HqAddress1 = default(string), string HqAddress2 = default(string), string HqAddressCity = default(string), string HqAddressPostalCode = default(string), string EntityLegalForm = default(string), string Cik = default(string), DateTime? LatestFilingDate = default(DateTime?), string HqState = default(string), string HqCountry = default(string), string IncState = default(string), string IncCountry = default(string), int? Employees = default(int?), string EntityStatus = default(string), string Sector = default(string), string IndustryCategory = default(string), string IndustryGroup = default(string), string Template = default(string), bool? StandardizedActive = default(bool?))
        {
            this.Id = Id;
            this.Ticker = Ticker;
            this.Name = Name;
            this.Lei = Lei;
            this.LegalName = LegalName;
            this.StockExchange = StockExchange;
            this.Sic = Sic;
            this.ShortDescription = ShortDescription;
            this.LongDescription = LongDescription;
            this.Ceo = Ceo;
            this.CompanyUrl = CompanyUrl;
            this.BusinessAddress = BusinessAddress;
            this.MailingAddress = MailingAddress;
            this.BusinessPhoneNo = BusinessPhoneNo;
            this.HqAddress1 = HqAddress1;
            this.HqAddress2 = HqAddress2;
            this.HqAddressCity = HqAddressCity;
            this.HqAddressPostalCode = HqAddressPostalCode;
            this.EntityLegalForm = EntityLegalForm;
            this.Cik = Cik;
            this.LatestFilingDate = LatestFilingDate;
            this.HqState = HqState;
            this.HqCountry = HqCountry;
            this.IncState = IncState;
            this.IncCountry = IncCountry;
            this.Employees = Employees;
            this.EntityStatus = EntityStatus;
            this.Sector = Sector;
            this.IndustryCategory = IndustryCategory;
            this.IndustryGroup = IndustryGroup;
            this.Template = Template;
            this.StandardizedActive = StandardizedActive;
        }
        
        /// <summary>
        /// The Intrinio ID of the company
        /// </summary>
        /// <value>The Intrinio ID of the company</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The stock market ticker symbol associated with the company&#39;s common stock securities
        /// </summary>
        /// <value>The stock market ticker symbol associated with the company&#39;s common stock securities</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The company&#39;s common name
        /// </summary>
        /// <value>The company&#39;s common name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Legal Entity Identifier (LEI) assigned to the company
        /// </summary>
        /// <value>The Legal Entity Identifier (LEI) assigned to the company</value>
        [DataMember(Name="lei", EmitDefaultValue=false)]
        public string Lei { get; set; }

        /// <summary>
        /// The company&#39;s official legal name
        /// </summary>
        /// <value>The company&#39;s official legal name</value>
        [DataMember(Name="legal_name", EmitDefaultValue=false)]
        public string LegalName { get; set; }

        /// <summary>
        /// The Stock Exchange where the company&#39;s common stock is primarily traded
        /// </summary>
        /// <value>The Stock Exchange where the company&#39;s common stock is primarily traded</value>
        [DataMember(Name="stock_exchange", EmitDefaultValue=false)]
        public string StockExchange { get; set; }

        /// <summary>
        /// The Standard Industrial Classification (SIC) determined by the company and filed with the SEC
        /// </summary>
        /// <value>The Standard Industrial Classification (SIC) determined by the company and filed with the SEC</value>
        [DataMember(Name="sic", EmitDefaultValue=false)]
        public string Sic { get; set; }

        /// <summary>
        /// A one or two sentence description of the company&#39;s operations
        /// </summary>
        /// <value>A one or two sentence description of the company&#39;s operations</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A one paragraph description of the company&#39;s operations and other corporate actions
        /// </summary>
        /// <value>A one paragraph description of the company&#39;s operations and other corporate actions</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// The Chief Executive Officer of the company
        /// </summary>
        /// <value>The Chief Executive Officer of the company</value>
        [DataMember(Name="ceo", EmitDefaultValue=false)]
        public string Ceo { get; set; }

        /// <summary>
        /// The URL of the company&#39;s primary corporate website or primary internet property
        /// </summary>
        /// <value>The URL of the company&#39;s primary corporate website or primary internet property</value>
        [DataMember(Name="company_url", EmitDefaultValue=false)]
        public string CompanyUrl { get; set; }

        /// <summary>
        /// The company&#39;s business address
        /// </summary>
        /// <value>The company&#39;s business address</value>
        [DataMember(Name="business_address", EmitDefaultValue=false)]
        public string BusinessAddress { get; set; }

        /// <summary>
        /// The mailing address reported by the company
        /// </summary>
        /// <value>The mailing address reported by the company</value>
        [DataMember(Name="mailing_address", EmitDefaultValue=false)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// The phone number reported by the company
        /// </summary>
        /// <value>The phone number reported by the company</value>
        [DataMember(Name="business_phone_no", EmitDefaultValue=false)]
        public string BusinessPhoneNo { get; set; }

        /// <summary>
        /// The company&#39;s headquarters address - line 1
        /// </summary>
        /// <value>The company&#39;s headquarters address - line 1</value>
        [DataMember(Name="hq_address1", EmitDefaultValue=false)]
        public string HqAddress1 { get; set; }

        /// <summary>
        /// The company&#39;s headquarters address - line 2
        /// </summary>
        /// <value>The company&#39;s headquarters address - line 2</value>
        [DataMember(Name="hq_address2", EmitDefaultValue=false)]
        public string HqAddress2 { get; set; }

        /// <summary>
        /// The company&#39;s headquarters city
        /// </summary>
        /// <value>The company&#39;s headquarters city</value>
        [DataMember(Name="hq_address_city", EmitDefaultValue=false)]
        public string HqAddressCity { get; set; }

        /// <summary>
        /// The company&#39;s headquarters postal code
        /// </summary>
        /// <value>The company&#39;s headquarters postal code</value>
        [DataMember(Name="hq_address_postal_code", EmitDefaultValue=false)]
        public string HqAddressPostalCode { get; set; }

        /// <summary>
        /// The company&#39;s legal organization form
        /// </summary>
        /// <value>The company&#39;s legal organization form</value>
        [DataMember(Name="entity_legal_form", EmitDefaultValue=false)]
        public string EntityLegalForm { get; set; }

        /// <summary>
        /// The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings
        /// </summary>
        /// <value>The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings</value>
        [DataMember(Name="cik", EmitDefaultValue=false)]
        public string Cik { get; set; }

        /// <summary>
        /// The date of the company&#39;s last filing with the SEC
        /// </summary>
        /// <value>The date of the company&#39;s last filing with the SEC</value>
        [DataMember(Name="latest_filing_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LatestFilingDate { get; set; }

        /// <summary>
        /// The state (US &amp; Canada Only) where the company headquarters are located
        /// </summary>
        /// <value>The state (US &amp; Canada Only) where the company headquarters are located</value>
        [DataMember(Name="hq_state", EmitDefaultValue=false)]
        public string HqState { get; set; }

        /// <summary>
        /// The country where the company headquarters are located
        /// </summary>
        /// <value>The country where the company headquarters are located</value>
        [DataMember(Name="hq_country", EmitDefaultValue=false)]
        public string HqCountry { get; set; }

        /// <summary>
        /// The state (US &amp; Canada Only) where the company is incorporated
        /// </summary>
        /// <value>The state (US &amp; Canada Only) where the company is incorporated</value>
        [DataMember(Name="inc_state", EmitDefaultValue=false)]
        public string IncState { get; set; }

        /// <summary>
        /// The country where the company is incorporated
        /// </summary>
        /// <value>The country where the company is incorporated</value>
        [DataMember(Name="inc_country", EmitDefaultValue=false)]
        public string IncCountry { get; set; }

        /// <summary>
        /// The number of employees working for the company
        /// </summary>
        /// <value>The number of employees working for the company</value>
        [DataMember(Name="employees", EmitDefaultValue=false)]
        public int? Employees { get; set; }

        /// <summary>
        /// Gets or Sets EntityStatus
        /// </summary>
        [DataMember(Name="entity_status", EmitDefaultValue=false)]
        public string EntityStatus { get; set; }

        /// <summary>
        /// The company&#39;s operating sector
        /// </summary>
        /// <value>The company&#39;s operating sector</value>
        [DataMember(Name="sector", EmitDefaultValue=false)]
        public string Sector { get; set; }

        /// <summary>
        /// The company&#39;s operating industry category
        /// </summary>
        /// <value>The company&#39;s operating industry category</value>
        [DataMember(Name="industry_category", EmitDefaultValue=false)]
        public string IndustryCategory { get; set; }

        /// <summary>
        /// The company&#39;s operating industry group
        /// </summary>
        /// <value>The company&#39;s operating industry group</value>
        [DataMember(Name="industry_group", EmitDefaultValue=false)]
        public string IndustryGroup { get; set; }

        /// <summary>
        /// The financial statement template used by Intrinio to standardize the as reported data
        /// </summary>
        /// <value>The financial statement template used by Intrinio to standardize the as reported data</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// If true, the company has standardized and as reported fundamental data via the Intrinio API; if false, the company has as-reported data only
        /// </summary>
        /// <value>If true, the company has standardized and as reported fundamental data via the Intrinio API; if false, the company has as-reported data only</value>
        [DataMember(Name="standardized_active", EmitDefaultValue=false)]
        public bool? StandardizedActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Lei: ").Append(Lei).Append("\n");
            sb.Append("  LegalName: ").Append(LegalName).Append("\n");
            sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
            sb.Append("  Sic: ").Append(Sic).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  Ceo: ").Append(Ceo).Append("\n");
            sb.Append("  CompanyUrl: ").Append(CompanyUrl).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  BusinessPhoneNo: ").Append(BusinessPhoneNo).Append("\n");
            sb.Append("  HqAddress1: ").Append(HqAddress1).Append("\n");
            sb.Append("  HqAddress2: ").Append(HqAddress2).Append("\n");
            sb.Append("  HqAddressCity: ").Append(HqAddressCity).Append("\n");
            sb.Append("  HqAddressPostalCode: ").Append(HqAddressPostalCode).Append("\n");
            sb.Append("  EntityLegalForm: ").Append(EntityLegalForm).Append("\n");
            sb.Append("  Cik: ").Append(Cik).Append("\n");
            sb.Append("  LatestFilingDate: ").Append(LatestFilingDate).Append("\n");
            sb.Append("  HqState: ").Append(HqState).Append("\n");
            sb.Append("  HqCountry: ").Append(HqCountry).Append("\n");
            sb.Append("  IncState: ").Append(IncState).Append("\n");
            sb.Append("  IncCountry: ").Append(IncCountry).Append("\n");
            sb.Append("  Employees: ").Append(Employees).Append("\n");
            sb.Append("  EntityStatus: ").Append(EntityStatus).Append("\n");
            sb.Append("  Sector: ").Append(Sector).Append("\n");
            sb.Append("  IndustryCategory: ").Append(IndustryCategory).Append("\n");
            sb.Append("  IndustryGroup: ").Append(IndustryGroup).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  StandardizedActive: ").Append(StandardizedActive).Append("\n");
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
            return this.Equals(input as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="input">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Lei == input.Lei ||
                    (this.Lei != null &&
                    this.Lei.Equals(input.Lei))
                ) && 
                (
                    this.LegalName == input.LegalName ||
                    (this.LegalName != null &&
                    this.LegalName.Equals(input.LegalName))
                ) && 
                (
                    this.StockExchange == input.StockExchange ||
                    (this.StockExchange != null &&
                    this.StockExchange.Equals(input.StockExchange))
                ) && 
                (
                    this.Sic == input.Sic ||
                    (this.Sic != null &&
                    this.Sic.Equals(input.Sic))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
                ) && 
                (
                    this.Ceo == input.Ceo ||
                    (this.Ceo != null &&
                    this.Ceo.Equals(input.Ceo))
                ) && 
                (
                    this.CompanyUrl == input.CompanyUrl ||
                    (this.CompanyUrl != null &&
                    this.CompanyUrl.Equals(input.CompanyUrl))
                ) && 
                (
                    this.BusinessAddress == input.BusinessAddress ||
                    (this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(input.BusinessAddress))
                ) && 
                (
                    this.MailingAddress == input.MailingAddress ||
                    (this.MailingAddress != null &&
                    this.MailingAddress.Equals(input.MailingAddress))
                ) && 
                (
                    this.BusinessPhoneNo == input.BusinessPhoneNo ||
                    (this.BusinessPhoneNo != null &&
                    this.BusinessPhoneNo.Equals(input.BusinessPhoneNo))
                ) && 
                (
                    this.HqAddress1 == input.HqAddress1 ||
                    (this.HqAddress1 != null &&
                    this.HqAddress1.Equals(input.HqAddress1))
                ) && 
                (
                    this.HqAddress2 == input.HqAddress2 ||
                    (this.HqAddress2 != null &&
                    this.HqAddress2.Equals(input.HqAddress2))
                ) && 
                (
                    this.HqAddressCity == input.HqAddressCity ||
                    (this.HqAddressCity != null &&
                    this.HqAddressCity.Equals(input.HqAddressCity))
                ) && 
                (
                    this.HqAddressPostalCode == input.HqAddressPostalCode ||
                    (this.HqAddressPostalCode != null &&
                    this.HqAddressPostalCode.Equals(input.HqAddressPostalCode))
                ) && 
                (
                    this.EntityLegalForm == input.EntityLegalForm ||
                    (this.EntityLegalForm != null &&
                    this.EntityLegalForm.Equals(input.EntityLegalForm))
                ) && 
                (
                    this.Cik == input.Cik ||
                    (this.Cik != null &&
                    this.Cik.Equals(input.Cik))
                ) && 
                (
                    this.LatestFilingDate == input.LatestFilingDate ||
                    (this.LatestFilingDate != null &&
                    this.LatestFilingDate.Equals(input.LatestFilingDate))
                ) && 
                (
                    this.HqState == input.HqState ||
                    (this.HqState != null &&
                    this.HqState.Equals(input.HqState))
                ) && 
                (
                    this.HqCountry == input.HqCountry ||
                    (this.HqCountry != null &&
                    this.HqCountry.Equals(input.HqCountry))
                ) && 
                (
                    this.IncState == input.IncState ||
                    (this.IncState != null &&
                    this.IncState.Equals(input.IncState))
                ) && 
                (
                    this.IncCountry == input.IncCountry ||
                    (this.IncCountry != null &&
                    this.IncCountry.Equals(input.IncCountry))
                ) && 
                (
                    this.Employees == input.Employees ||
                    (this.Employees != null &&
                    this.Employees.Equals(input.Employees))
                ) && 
                (
                    this.EntityStatus == input.EntityStatus ||
                    (this.EntityStatus != null &&
                    this.EntityStatus.Equals(input.EntityStatus))
                ) && 
                (
                    this.Sector == input.Sector ||
                    (this.Sector != null &&
                    this.Sector.Equals(input.Sector))
                ) && 
                (
                    this.IndustryCategory == input.IndustryCategory ||
                    (this.IndustryCategory != null &&
                    this.IndustryCategory.Equals(input.IndustryCategory))
                ) && 
                (
                    this.IndustryGroup == input.IndustryGroup ||
                    (this.IndustryGroup != null &&
                    this.IndustryGroup.Equals(input.IndustryGroup))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.StandardizedActive == input.StandardizedActive ||
                    (this.StandardizedActive != null &&
                    this.StandardizedActive.Equals(input.StandardizedActive))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Lei != null)
                    hashCode = hashCode * 59 + this.Lei.GetHashCode();
                if (this.LegalName != null)
                    hashCode = hashCode * 59 + this.LegalName.GetHashCode();
                if (this.StockExchange != null)
                    hashCode = hashCode * 59 + this.StockExchange.GetHashCode();
                if (this.Sic != null)
                    hashCode = hashCode * 59 + this.Sic.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.Ceo != null)
                    hashCode = hashCode * 59 + this.Ceo.GetHashCode();
                if (this.CompanyUrl != null)
                    hashCode = hashCode * 59 + this.CompanyUrl.GetHashCode();
                if (this.BusinessAddress != null)
                    hashCode = hashCode * 59 + this.BusinessAddress.GetHashCode();
                if (this.MailingAddress != null)
                    hashCode = hashCode * 59 + this.MailingAddress.GetHashCode();
                if (this.BusinessPhoneNo != null)
                    hashCode = hashCode * 59 + this.BusinessPhoneNo.GetHashCode();
                if (this.HqAddress1 != null)
                    hashCode = hashCode * 59 + this.HqAddress1.GetHashCode();
                if (this.HqAddress2 != null)
                    hashCode = hashCode * 59 + this.HqAddress2.GetHashCode();
                if (this.HqAddressCity != null)
                    hashCode = hashCode * 59 + this.HqAddressCity.GetHashCode();
                if (this.HqAddressPostalCode != null)
                    hashCode = hashCode * 59 + this.HqAddressPostalCode.GetHashCode();
                if (this.EntityLegalForm != null)
                    hashCode = hashCode * 59 + this.EntityLegalForm.GetHashCode();
                if (this.Cik != null)
                    hashCode = hashCode * 59 + this.Cik.GetHashCode();
                if (this.LatestFilingDate != null)
                    hashCode = hashCode * 59 + this.LatestFilingDate.GetHashCode();
                if (this.HqState != null)
                    hashCode = hashCode * 59 + this.HqState.GetHashCode();
                if (this.HqCountry != null)
                    hashCode = hashCode * 59 + this.HqCountry.GetHashCode();
                if (this.IncState != null)
                    hashCode = hashCode * 59 + this.IncState.GetHashCode();
                if (this.IncCountry != null)
                    hashCode = hashCode * 59 + this.IncCountry.GetHashCode();
                if (this.Employees != null)
                    hashCode = hashCode * 59 + this.Employees.GetHashCode();
                if (this.EntityStatus != null)
                    hashCode = hashCode * 59 + this.EntityStatus.GetHashCode();
                if (this.Sector != null)
                    hashCode = hashCode * 59 + this.Sector.GetHashCode();
                if (this.IndustryCategory != null)
                    hashCode = hashCode * 59 + this.IndustryCategory.GetHashCode();
                if (this.IndustryGroup != null)
                    hashCode = hashCode * 59 + this.IndustryGroup.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.StandardizedActive != null)
                    hashCode = hashCode * 59 + this.StandardizedActive.GetHashCode();
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

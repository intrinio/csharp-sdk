

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
    /// Insider and institutional owners of securities covered by Intrinio
    /// </summary>
    [DataContract]
    public partial class Owner :  IEquatable<Owner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Owner" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the Owner.</param>
        /// <param name="CompanyId">The Intrinio ID for the company for which the Security is issued.</param>
        /// <param name="OwnerCik">The Central Index Key issued by the SEC, which is the unique identifier all owner filings.</param>
        /// <param name="Name">The name of the owner.</param>
        /// <param name="State">The state in which the owner is located.</param>
        /// <param name="StateInc">The state in which the owner is incorporated.</param>
        /// <param name="CountryInc">The country in which the owner is incorporated.</param>
        /// <param name="BusinessAddress">The owner&#39;s business address.</param>
        /// <param name="BusinessPhoneNo">The owner&#39;s business phone number.</param>
        /// <param name="MailingAddress">The owner&#39;s mailing address.</param>
        /// <param name="Institutional">A boolean to include only insider owners who have filed forms 3, 4, or 5 with the SEC.</param>
        /// <param name="UpdatedOn">The date and time when the data was last updated..</param>
        /// <param name="CreatedOn">The date and time when the data was created.</param>
        public Owner(string Id = default(string), string CompanyId = default(string), string OwnerCik = default(string), string Name = default(string), string State = default(string), string StateInc = default(string), string CountryInc = default(string), string BusinessAddress = default(string), string BusinessPhoneNo = default(string), string MailingAddress = default(string), bool? Institutional = default(bool?), DateTime? UpdatedOn = default(DateTime?), DateTime? CreatedOn = default(DateTime?))
        {
            this.Id = Id;
            this.CompanyId = CompanyId;
            this.OwnerCik = OwnerCik;
            this.Name = Name;
            this.State = State;
            this.StateInc = StateInc;
            this.CountryInc = CountryInc;
            this.BusinessAddress = BusinessAddress;
            this.BusinessPhoneNo = BusinessPhoneNo;
            this.MailingAddress = MailingAddress;
            this.Institutional = Institutional;
            this.UpdatedOn = UpdatedOn;
            this.CreatedOn = CreatedOn;
        }
        
        /// <summary>
        /// The Intrinio ID for the Owner
        /// </summary>
        /// <value>The Intrinio ID for the Owner</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The Intrinio ID for the company for which the Security is issued
        /// </summary>
        /// <value>The Intrinio ID for the company for which the Security is issued</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The Central Index Key issued by the SEC, which is the unique identifier all owner filings
        /// </summary>
        /// <value>The Central Index Key issued by the SEC, which is the unique identifier all owner filings</value>
        [DataMember(Name="owner_cik", EmitDefaultValue=false)]
        public string OwnerCik { get; set; }

        /// <summary>
        /// The name of the owner
        /// </summary>
        /// <value>The name of the owner</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The state in which the owner is located
        /// </summary>
        /// <value>The state in which the owner is located</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The state in which the owner is incorporated
        /// </summary>
        /// <value>The state in which the owner is incorporated</value>
        [DataMember(Name="state_inc", EmitDefaultValue=false)]
        public string StateInc { get; set; }

        /// <summary>
        /// The country in which the owner is incorporated
        /// </summary>
        /// <value>The country in which the owner is incorporated</value>
        [DataMember(Name="country_inc", EmitDefaultValue=false)]
        public string CountryInc { get; set; }

        /// <summary>
        /// The owner&#39;s business address
        /// </summary>
        /// <value>The owner&#39;s business address</value>
        [DataMember(Name="business_address", EmitDefaultValue=false)]
        public string BusinessAddress { get; set; }

        /// <summary>
        /// The owner&#39;s business phone number
        /// </summary>
        /// <value>The owner&#39;s business phone number</value>
        [DataMember(Name="business_phone_no", EmitDefaultValue=false)]
        public string BusinessPhoneNo { get; set; }

        /// <summary>
        /// The owner&#39;s mailing address
        /// </summary>
        /// <value>The owner&#39;s mailing address</value>
        [DataMember(Name="mailing_address", EmitDefaultValue=false)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// A boolean to include only insider owners who have filed forms 3, 4, or 5 with the SEC
        /// </summary>
        /// <value>A boolean to include only insider owners who have filed forms 3, 4, or 5 with the SEC</value>
        [DataMember(Name="institutional", EmitDefaultValue=false)]
        public bool? Institutional { get; set; }

        /// <summary>
        /// The date and time when the data was last updated.
        /// </summary>
        /// <value>The date and time when the data was last updated.</value>
        [DataMember(Name="updated_on", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// The date and time when the data was created
        /// </summary>
        /// <value>The date and time when the data was created</value>
        [DataMember(Name="created_on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Owner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  OwnerCik: ").Append(OwnerCik).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateInc: ").Append(StateInc).Append("\n");
            sb.Append("  CountryInc: ").Append(CountryInc).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            sb.Append("  BusinessPhoneNo: ").Append(BusinessPhoneNo).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  Institutional: ").Append(Institutional).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
            return this.Equals(input as Owner);
        }

        /// <summary>
        /// Returns true if Owner instances are equal
        /// </summary>
        /// <param name="input">Instance of Owner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Owner input)
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
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.OwnerCik == input.OwnerCik ||
                    (this.OwnerCik != null &&
                    this.OwnerCik.Equals(input.OwnerCik))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateInc == input.StateInc ||
                    (this.StateInc != null &&
                    this.StateInc.Equals(input.StateInc))
                ) && 
                (
                    this.CountryInc == input.CountryInc ||
                    (this.CountryInc != null &&
                    this.CountryInc.Equals(input.CountryInc))
                ) && 
                (
                    this.BusinessAddress == input.BusinessAddress ||
                    (this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(input.BusinessAddress))
                ) && 
                (
                    this.BusinessPhoneNo == input.BusinessPhoneNo ||
                    (this.BusinessPhoneNo != null &&
                    this.BusinessPhoneNo.Equals(input.BusinessPhoneNo))
                ) && 
                (
                    this.MailingAddress == input.MailingAddress ||
                    (this.MailingAddress != null &&
                    this.MailingAddress.Equals(input.MailingAddress))
                ) && 
                (
                    this.Institutional == input.Institutional ||
                    (this.Institutional != null &&
                    this.Institutional.Equals(input.Institutional))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
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
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.OwnerCik != null)
                    hashCode = hashCode * 59 + this.OwnerCik.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateInc != null)
                    hashCode = hashCode * 59 + this.StateInc.GetHashCode();
                if (this.CountryInc != null)
                    hashCode = hashCode * 59 + this.CountryInc.GetHashCode();
                if (this.BusinessAddress != null)
                    hashCode = hashCode * 59 + this.BusinessAddress.GetHashCode();
                if (this.BusinessPhoneNo != null)
                    hashCode = hashCode * 59 + this.BusinessPhoneNo.GetHashCode();
                if (this.MailingAddress != null)
                    hashCode = hashCode * 59 + this.MailingAddress.GetHashCode();
                if (this.Institutional != null)
                    hashCode = hashCode * 59 + this.Institutional.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
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

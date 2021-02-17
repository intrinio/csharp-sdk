

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
    /// ApiResponseCompanyInsiderTransactionFilings
    /// </summary>
    [DataContract]
    public partial class ApiResponseCompanyInsiderTransactionFilings :  IEquatable<ApiResponseCompanyInsiderTransactionFilings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseCompanyInsiderTransactionFilings" /> class.
        /// </summary>
        /// <param name="TransactionFilings">TransactionFilings.</param>
        /// <param name="Company">The company associated with the transaction filing.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseCompanyInsiderTransactionFilings(List<InsiderTransactionFiling> TransactionFilings = default(List<InsiderTransactionFiling>), CompanySummary Company = default(CompanySummary), string NextPage = default(string))
        {
            this.TransactionFilings = TransactionFilings;
            this.Company = Company;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets TransactionFilings
        /// </summary>
        [DataMember(Name="transaction_filings", EmitDefaultValue=false)]
        public List<InsiderTransactionFiling> TransactionFilings { get; set; }

        /// <summary>
        /// The company associated with the transaction filing
        /// </summary>
        /// <value>The company associated with the transaction filing</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanySummary Company { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseCompanyInsiderTransactionFilings {\n");
            sb.Append("  TransactionFilings: ").Append(TransactionFilings).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ApiResponseCompanyInsiderTransactionFilings);
        }

        /// <summary>
        /// Returns true if ApiResponseCompanyInsiderTransactionFilings instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseCompanyInsiderTransactionFilings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseCompanyInsiderTransactionFilings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionFilings == input.TransactionFilings ||
                    this.TransactionFilings != null &&
                    this.TransactionFilings.SequenceEqual(input.TransactionFilings)
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.TransactionFilings != null)
                    hashCode = hashCode * 59 + this.TransactionFilings.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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

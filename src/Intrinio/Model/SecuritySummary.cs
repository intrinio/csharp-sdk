

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
    /// The summary of a financial instrument representing shares of ownership in a publicly-traded company
    /// </summary>
    [DataContract]
    public partial class SecuritySummary :  IEquatable<SecuritySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for Security.</param>
        /// <param name="CompanyId">The Intrinio ID for the Company for which the Security is issued.</param>
        /// <param name="Ticker">The common/local ticker of the Security.</param>
        /// <param name="CompositeTicker">The country-composite ticker of the Security.</param>
        /// <param name="Figi">The OpenFIGI identifier.</param>
        /// <param name="Name">The name of the Security.</param>
        public SecuritySummary(string Id = default(string), string CompanyId = default(string), string Ticker = default(string), string CompositeTicker = default(string), string Figi = default(string), string Name = default(string))
        {
            this.Id = Id;
            this.CompanyId = CompanyId;
            this.Ticker = Ticker;
            this.CompositeTicker = CompositeTicker;
            this.Figi = Figi;
            this.Name = Name;
        }
        
        /// <summary>
        /// The Intrinio ID for Security
        /// </summary>
        /// <value>The Intrinio ID for Security</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The Intrinio ID for the Company for which the Security is issued
        /// </summary>
        /// <value>The Intrinio ID for the Company for which the Security is issued</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// The common/local ticker of the Security
        /// </summary>
        /// <value>The common/local ticker of the Security</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The country-composite ticker of the Security
        /// </summary>
        /// <value>The country-composite ticker of the Security</value>
        [DataMember(Name="composite_ticker", EmitDefaultValue=false)]
        public string CompositeTicker { get; set; }

        /// <summary>
        /// The OpenFIGI identifier
        /// </summary>
        /// <value>The OpenFIGI identifier</value>
        [DataMember(Name="figi", EmitDefaultValue=false)]
        public string Figi { get; set; }

        /// <summary>
        /// The name of the Security
        /// </summary>
        /// <value>The name of the Security</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  CompositeTicker: ").Append(CompositeTicker).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as SecuritySummary);
        }

        /// <summary>
        /// Returns true if SecuritySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of SecuritySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecuritySummary input)
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
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.CompositeTicker == input.CompositeTicker ||
                    (this.CompositeTicker != null &&
                    this.CompositeTicker.Equals(input.CompositeTicker))
                ) && 
                (
                    this.Figi == input.Figi ||
                    (this.Figi != null &&
                    this.Figi.Equals(input.Figi))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.CompositeTicker != null)
                    hashCode = hashCode * 59 + this.CompositeTicker.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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

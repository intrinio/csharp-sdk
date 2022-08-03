

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
    /// ESGCompanySummary
    /// </summary>
    [DataContract]
    public partial class ESGCompanySummary :  IEquatable<ESGCompanySummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ESGCompanySummary" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID of the company..</param>
        /// <param name="Name">The company’s common name..</param>
        /// <param name="Ticker">The stock market ticker symbol associated with the company’s common stock security..</param>
        /// <param name="Isin">The company&#39;s common securities identification 12-digit alphanumeric code..</param>
        /// <param name="PrimaryIndustry">The primary industry associated with the company based on their main revenue generating operations..</param>
        /// <param name="Country">The country in which the company&#39;s headquarters or primary place of business is located..</param>
        public ESGCompanySummary(string Id = default(string), string Name = default(string), string Ticker = default(string), string Isin = default(string), string PrimaryIndustry = default(string), string Country = default(string))
        {
            this.Id = Id;
            this.Name = Name;
            this.Ticker = Ticker;
            this.Isin = Isin;
            this.PrimaryIndustry = PrimaryIndustry;
            this.Country = Country;
        }
        
        /// <summary>
        /// The Intrinio ID of the company.
        /// </summary>
        /// <value>The Intrinio ID of the company.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The company’s common name.
        /// </summary>
        /// <value>The company’s common name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The stock market ticker symbol associated with the company’s common stock security.
        /// </summary>
        /// <value>The stock market ticker symbol associated with the company’s common stock security.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The company&#39;s common securities identification 12-digit alphanumeric code.
        /// </summary>
        /// <value>The company&#39;s common securities identification 12-digit alphanumeric code.</value>
        [DataMember(Name="isin", EmitDefaultValue=false)]
        public string Isin { get; set; }

        /// <summary>
        /// The primary industry associated with the company based on their main revenue generating operations.
        /// </summary>
        /// <value>The primary industry associated with the company based on their main revenue generating operations.</value>
        [DataMember(Name="primary_industry", EmitDefaultValue=false)]
        public string PrimaryIndustry { get; set; }

        /// <summary>
        /// The country in which the company&#39;s headquarters or primary place of business is located.
        /// </summary>
        /// <value>The country in which the company&#39;s headquarters or primary place of business is located.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ESGCompanySummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Isin: ").Append(Isin).Append("\n");
            sb.Append("  PrimaryIndustry: ").Append(PrimaryIndustry).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as ESGCompanySummary);
        }

        /// <summary>
        /// Returns true if ESGCompanySummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ESGCompanySummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESGCompanySummary input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Isin == input.Isin ||
                    (this.Isin != null &&
                    this.Isin.Equals(input.Isin))
                ) && 
                (
                    this.PrimaryIndustry == input.PrimaryIndustry ||
                    (this.PrimaryIndustry != null &&
                    this.PrimaryIndustry.Equals(input.PrimaryIndustry))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Isin != null)
                    hashCode = hashCode * 59 + this.Isin.GetHashCode();
                if (this.PrimaryIndustry != null)
                    hashCode = hashCode * 59 + this.PrimaryIndustry.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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

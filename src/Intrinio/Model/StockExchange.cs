

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
    /// An organized and regulated financial market in which securities are bought and sold.
    /// </summary>
    [DataContract]
    public partial class StockExchange :  IEquatable<StockExchange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchange" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the Stock Exchange.</param>
        /// <param name="Name">The name of the exchange.</param>
        /// <param name="Mic">The Market Identifier Code (MIC) of the exchange.</param>
        /// <param name="Acronym">The acronym of the exchange&#39;s name.</param>
        /// <param name="City">The city in which the exchange is located.</param>
        /// <param name="Country">The country in which the exchange is located.</param>
        /// <param name="CountryCode">The 2-digit code of the exchange&#39;s country.</param>
        /// <param name="Website">The website of the exchange.</param>
        /// <param name="FirstStockPriceDate">The earliest date for which Intrinio has stock prices for the exchange.</param>
        /// <param name="LastStockPriceDate">The latest date for which Intrinio has stock prices for the exchange.</param>
        public StockExchange(string Id = default(string), string Name = default(string), string Mic = default(string), string Acronym = default(string), string City = default(string), string Country = default(string), string CountryCode = default(string), string Website = default(string), DateTime? FirstStockPriceDate = default(DateTime?), DateTime? LastStockPriceDate = default(DateTime?))
        {
            this.Id = Id;
            this.Name = Name;
            this.Mic = Mic;
            this.Acronym = Acronym;
            this.City = City;
            this.Country = Country;
            this.CountryCode = CountryCode;
            this.Website = Website;
            this.FirstStockPriceDate = FirstStockPriceDate;
            this.LastStockPriceDate = LastStockPriceDate;
        }
        
        /// <summary>
        /// The Intrinio ID for the Stock Exchange
        /// </summary>
        /// <value>The Intrinio ID for the Stock Exchange</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the exchange
        /// </summary>
        /// <value>The name of the exchange</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Market Identifier Code (MIC) of the exchange
        /// </summary>
        /// <value>The Market Identifier Code (MIC) of the exchange</value>
        [DataMember(Name="mic", EmitDefaultValue=false)]
        public string Mic { get; set; }

        /// <summary>
        /// The acronym of the exchange&#39;s name
        /// </summary>
        /// <value>The acronym of the exchange&#39;s name</value>
        [DataMember(Name="acronym", EmitDefaultValue=false)]
        public string Acronym { get; set; }

        /// <summary>
        /// The city in which the exchange is located
        /// </summary>
        /// <value>The city in which the exchange is located</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The country in which the exchange is located
        /// </summary>
        /// <value>The country in which the exchange is located</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The 2-digit code of the exchange&#39;s country
        /// </summary>
        /// <value>The 2-digit code of the exchange&#39;s country</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The website of the exchange
        /// </summary>
        /// <value>The website of the exchange</value>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }

        /// <summary>
        /// The earliest date for which Intrinio has stock prices for the exchange
        /// </summary>
        /// <value>The earliest date for which Intrinio has stock prices for the exchange</value>
        [DataMember(Name="first_stock_price_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FirstStockPriceDate { get; set; }

        /// <summary>
        /// The latest date for which Intrinio has stock prices for the exchange
        /// </summary>
        /// <value>The latest date for which Intrinio has stock prices for the exchange</value>
        [DataMember(Name="last_stock_price_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastStockPriceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockExchange {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mic: ").Append(Mic).Append("\n");
            sb.Append("  Acronym: ").Append(Acronym).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  FirstStockPriceDate: ").Append(FirstStockPriceDate).Append("\n");
            sb.Append("  LastStockPriceDate: ").Append(LastStockPriceDate).Append("\n");
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
            return this.Equals(input as StockExchange);
        }

        /// <summary>
        /// Returns true if StockExchange instances are equal
        /// </summary>
        /// <param name="input">Instance of StockExchange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockExchange input)
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
                    this.Mic == input.Mic ||
                    (this.Mic != null &&
                    this.Mic.Equals(input.Mic))
                ) && 
                (
                    this.Acronym == input.Acronym ||
                    (this.Acronym != null &&
                    this.Acronym.Equals(input.Acronym))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.FirstStockPriceDate == input.FirstStockPriceDate ||
                    (this.FirstStockPriceDate != null &&
                    this.FirstStockPriceDate.Equals(input.FirstStockPriceDate))
                ) && 
                (
                    this.LastStockPriceDate == input.LastStockPriceDate ||
                    (this.LastStockPriceDate != null &&
                    this.LastStockPriceDate.Equals(input.LastStockPriceDate))
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
                if (this.Mic != null)
                    hashCode = hashCode * 59 + this.Mic.GetHashCode();
                if (this.Acronym != null)
                    hashCode = hashCode * 59 + this.Acronym.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.FirstStockPriceDate != null)
                    hashCode = hashCode * 59 + this.FirstStockPriceDate.GetHashCode();
                if (this.LastStockPriceDate != null)
                    hashCode = hashCode * 59 + this.LastStockPriceDate.GetHashCode();
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

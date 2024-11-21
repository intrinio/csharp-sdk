

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
    /// A security ticker name history.
    /// </summary>
    [DataContract]
    public partial class SecurityHistory :  IEquatable<SecurityHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityHistory" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for the Security.</param>
        /// <param name="Ticker">The common ticker.</param>
        /// <param name="Name">The name of the Security.</param>
        /// <param name="SecurityCode">A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;).</param>
        /// <param name="Figi">The exchange-level OpenFIGI identifier.</param>
        /// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
        /// <param name="FirstPriceDate">The date of the first recorded stock price.</param>
        /// <param name="LastPriceDate">The date of the last recorded stock price (or the most recent trading day).</param>
        public SecurityHistory(string Id = default(string), string Ticker = default(string), string Name = default(string), string SecurityCode = default(string), string Figi = default(string), string CompositeFigi = default(string), DateTime? FirstPriceDate = default(DateTime?), DateTime? LastPriceDate = default(DateTime?))
        {
            this.Id = Id;
            this.Ticker = Ticker;
            this.Name = Name;
            this.SecurityCode = SecurityCode;
            this.Figi = Figi;
            this.CompositeFigi = CompositeFigi;
            this.FirstPriceDate = FirstPriceDate;
            this.LastPriceDate = LastPriceDate;
        }
        
        /// <summary>
        /// The Intrinio ID for the Security
        /// </summary>
        /// <value>The Intrinio ID for the Security</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The common ticker
        /// </summary>
        /// <value>The common ticker</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The name of the Security
        /// </summary>
        /// <value>The name of the Security</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)
        /// </summary>
        /// <value>A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;)</value>
        [DataMember(Name="security_code", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// The exchange-level OpenFIGI identifier
        /// </summary>
        /// <value>The exchange-level OpenFIGI identifier</value>
        [DataMember(Name="figi", EmitDefaultValue=false)]
        public string Figi { get; set; }

        /// <summary>
        /// The country-composite OpenFIGI identifier
        /// </summary>
        /// <value>The country-composite OpenFIGI identifier</value>
        [DataMember(Name="composite_figi", EmitDefaultValue=false)]
        public string CompositeFigi { get; set; }

        /// <summary>
        /// The date of the first recorded stock price
        /// </summary>
        /// <value>The date of the first recorded stock price</value>
        [DataMember(Name="first_price_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? FirstPriceDate { get; set; }

        /// <summary>
        /// The date of the last recorded stock price (or the most recent trading day)
        /// </summary>
        /// <value>The date of the last recorded stock price (or the most recent trading day)</value>
        [DataMember(Name="last_price_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastPriceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityHistory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  Figi: ").Append(Figi).Append("\n");
            sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
            sb.Append("  FirstPriceDate: ").Append(FirstPriceDate).Append("\n");
            sb.Append("  LastPriceDate: ").Append(LastPriceDate).Append("\n");
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
            return this.Equals(input as SecurityHistory);
        }

        /// <summary>
        /// Returns true if SecurityHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityHistory input)
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
                    this.SecurityCode == input.SecurityCode ||
                    (this.SecurityCode != null &&
                    this.SecurityCode.Equals(input.SecurityCode))
                ) && 
                (
                    this.Figi == input.Figi ||
                    (this.Figi != null &&
                    this.Figi.Equals(input.Figi))
                ) && 
                (
                    this.CompositeFigi == input.CompositeFigi ||
                    (this.CompositeFigi != null &&
                    this.CompositeFigi.Equals(input.CompositeFigi))
                ) && 
                (
                    this.FirstPriceDate == input.FirstPriceDate ||
                    (this.FirstPriceDate != null &&
                    this.FirstPriceDate.Equals(input.FirstPriceDate))
                ) && 
                (
                    this.LastPriceDate == input.LastPriceDate ||
                    (this.LastPriceDate != null &&
                    this.LastPriceDate.Equals(input.LastPriceDate))
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
                if (this.SecurityCode != null)
                    hashCode = hashCode * 59 + this.SecurityCode.GetHashCode();
                if (this.Figi != null)
                    hashCode = hashCode * 59 + this.Figi.GetHashCode();
                if (this.CompositeFigi != null)
                    hashCode = hashCode * 59 + this.CompositeFigi.GetHashCode();
                if (this.FirstPriceDate != null)
                    hashCode = hashCode * 59 + this.FirstPriceDate.GetHashCode();
                if (this.LastPriceDate != null)
                    hashCode = hashCode * 59 + this.LastPriceDate.GetHashCode();
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



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
    /// ApiResponseSecurityIntradayPrices
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityIntradayPrices :  IEquatable<ApiResponseSecurityIntradayPrices>, IValidatableObject
    {
        /// <summary>
        /// The source of the data
        /// </summary>
        /// <value>The source of the data</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Iex for value: "iex"
            /// </summary>
            [EnumMember(Value = "iex")]
            Iex = 1,
            
            /// <summary>
            /// Enum Bats for value: "bats"
            /// </summary>
            [EnumMember(Value = "bats")]
            Bats = 2
        }

        /// <summary>
        /// The source of the data
        /// </summary>
        /// <value>The source of the data</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityIntradayPrices" /> class.
        /// </summary>
        /// <param name="IntradayPrices">The intraday stock prices for the Security.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="Source">The source of the data.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityIntradayPrices(List<IntradayStockPrice> IntradayPrices = default(List<IntradayStockPrice>), SecuritySummary Security = default(SecuritySummary), SourceEnum? Source = default(SourceEnum?), string NextPage = default(string))
        {
            this.IntradayPrices = IntradayPrices;
            this.Security = Security;
            this.Source = Source;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The intraday stock prices for the Security
        /// </summary>
        /// <value>The intraday stock prices for the Security</value>
        [DataMember(Name="intraday_prices", EmitDefaultValue=false)]
        public List<IntradayStockPrice> IntradayPrices { get; set; }

        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }


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
            sb.Append("class ApiResponseSecurityIntradayPrices {\n");
            sb.Append("  IntradayPrices: ").Append(IntradayPrices).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityIntradayPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityIntradayPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityIntradayPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityIntradayPrices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IntradayPrices == input.IntradayPrices ||
                    this.IntradayPrices != null &&
                    this.IntradayPrices.SequenceEqual(input.IntradayPrices)
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.IntradayPrices != null)
                    hashCode = hashCode * 59 + this.IntradayPrices.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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

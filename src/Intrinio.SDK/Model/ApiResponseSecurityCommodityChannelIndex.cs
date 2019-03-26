

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
    /// The Commodity Channel Index calculations for the Stock Prices of the given Security
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityCommodityChannelIndex :  IEquatable<ApiResponseSecurityCommodityChannelIndex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityCommodityChannelIndex" /> class.
        /// </summary>
        /// <param name="Technicals">Technicals.</param>
        /// <param name="Indicator">The name and symbol of the technical indicator.</param>
        /// <param name="Security">The Security of the Stock Price.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseSecurityCommodityChannelIndex(List<CommodityChannelIndexTechnicalValue> Technicals = default(List<CommodityChannelIndexTechnicalValue>), TechnicalIndicator Indicator = default(TechnicalIndicator), SecuritySummary Security = default(SecuritySummary), string NextPage = default(string))
        {
            this.Technicals = Technicals;
            this.Indicator = Indicator;
            this.Security = Security;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets Technicals
        /// </summary>
        [DataMember(Name="technicals", EmitDefaultValue=false)]
        public List<CommodityChannelIndexTechnicalValue> Technicals { get; set; }

        /// <summary>
        /// The name and symbol of the technical indicator
        /// </summary>
        /// <value>The name and symbol of the technical indicator</value>
        [DataMember(Name="indicator", EmitDefaultValue=false)]
        public TechnicalIndicator Indicator { get; set; }

        /// <summary>
        /// The Security of the Stock Price
        /// </summary>
        /// <value>The Security of the Stock Price</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// The token required to request the next page of the data
        /// </summary>
        /// <value>The token required to request the next page of the data</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecurityCommodityChannelIndex {\n");
            sb.Append("  Technicals: ").Append(Technicals).Append("\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityCommodityChannelIndex);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityCommodityChannelIndex instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityCommodityChannelIndex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityCommodityChannelIndex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Technicals == input.Technicals ||
                    this.Technicals != null &&
                    this.Technicals.SequenceEqual(input.Technicals)
                ) && 
                (
                    this.Indicator == input.Indicator ||
                    (this.Indicator != null &&
                    this.Indicator.Equals(input.Indicator))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.Technicals != null)
                    hashCode = hashCode * 59 + this.Technicals.GetHashCode();
                if (this.Indicator != null)
                    hashCode = hashCode * 59 + this.Indicator.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

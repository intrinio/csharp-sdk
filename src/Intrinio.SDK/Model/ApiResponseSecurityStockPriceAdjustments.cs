

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
    /// ApiResponseSecurityStockPriceAdjustments
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityStockPriceAdjustments :  IEquatable<ApiResponseSecurityStockPriceAdjustments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityStockPriceAdjustments" /> class.
        /// </summary>
        /// <param name="StockPriceAdjustments">The stock price adjustments for the Security.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityStockPriceAdjustments(List<StockPriceAdjustmentSummary> StockPriceAdjustments = default(List<StockPriceAdjustmentSummary>), SecuritySummary Security = default(SecuritySummary), string NextPage = default(string))
        {
            this.StockPriceAdjustments = StockPriceAdjustments;
            this.Security = Security;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// The stock price adjustments for the Security
        /// </summary>
        /// <value>The stock price adjustments for the Security</value>
        [DataMember(Name="stock_price_adjustments", EmitDefaultValue=false)]
        public List<StockPriceAdjustmentSummary> StockPriceAdjustments { get; set; }

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
            sb.Append("class ApiResponseSecurityStockPriceAdjustments {\n");
            sb.Append("  StockPriceAdjustments: ").Append(StockPriceAdjustments).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityStockPriceAdjustments);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityStockPriceAdjustments instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityStockPriceAdjustments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityStockPriceAdjustments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StockPriceAdjustments == input.StockPriceAdjustments ||
                    this.StockPriceAdjustments != null &&
                    this.StockPriceAdjustments.SequenceEqual(input.StockPriceAdjustments)
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
                if (this.StockPriceAdjustments != null)
                    hashCode = hashCode * 59 + this.StockPriceAdjustments.GetHashCode();
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

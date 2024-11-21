

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
    /// ApiResponseOptionsPricesByTickerEod
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsPricesByTickerEod :  IEquatable<ApiResponseOptionsPricesByTickerEod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsPricesByTickerEod" /> class.
        /// </summary>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        /// <param name="Prices">The contracts pricing for this security..</param>
        public ApiResponseOptionsPricesByTickerEod(string NextPage = default(string), List<OptionsPriceEod> Prices = default(List<OptionsPriceEod>))
        {
            this.NextPage = NextPage;
            this.Prices = Prices;
        }
        
        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// The contracts pricing for this security.
        /// </summary>
        /// <value>The contracts pricing for this security.</value>
        [DataMember(Name="prices", EmitDefaultValue=false)]
        public List<OptionsPriceEod> Prices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsPricesByTickerEod {\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsPricesByTickerEod);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsPricesByTickerEod instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsPricesByTickerEod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsPricesByTickerEod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
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
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.Prices != null)
                    hashCode = hashCode * 59 + this.Prices.GetHashCode();
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

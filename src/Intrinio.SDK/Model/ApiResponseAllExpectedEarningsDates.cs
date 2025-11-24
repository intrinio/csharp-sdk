

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
    /// ApiResponseAllExpectedEarningsDates
    /// </summary>
    [DataContract]
    public partial class ApiResponseAllExpectedEarningsDates :  IEquatable<ApiResponseAllExpectedEarningsDates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseAllExpectedEarningsDates" /> class.
        /// </summary>
        /// <param name="ExpectedEarningsDates">ExpectedEarningsDates.</param>
        /// <param name="NextPage">The token for the next page of results.</param>
        public ApiResponseAllExpectedEarningsDates(List<EarningsDateEstimateWithCompany> ExpectedEarningsDates = default(List<EarningsDateEstimateWithCompany>), string NextPage = default(string))
        {
            this.ExpectedEarningsDates = ExpectedEarningsDates;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets ExpectedEarningsDates
        /// </summary>
        [DataMember(Name="expected_earnings_dates", EmitDefaultValue=false)]
        public List<EarningsDateEstimateWithCompany> ExpectedEarningsDates { get; set; }

        /// <summary>
        /// The token for the next page of results
        /// </summary>
        /// <value>The token for the next page of results</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseAllExpectedEarningsDates {\n");
            sb.Append("  ExpectedEarningsDates: ").Append(ExpectedEarningsDates).Append("\n");
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
            return this.Equals(input as ApiResponseAllExpectedEarningsDates);
        }

        /// <summary>
        /// Returns true if ApiResponseAllExpectedEarningsDates instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseAllExpectedEarningsDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseAllExpectedEarningsDates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpectedEarningsDates == input.ExpectedEarningsDates ||
                    this.ExpectedEarningsDates != null &&
                    this.ExpectedEarningsDates.SequenceEqual(input.ExpectedEarningsDates)
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
                if (this.ExpectedEarningsDates != null)
                    hashCode = hashCode * 59 + this.ExpectedEarningsDates.GetHashCode();
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

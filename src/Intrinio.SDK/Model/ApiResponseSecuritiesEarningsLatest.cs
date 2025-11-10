

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
    /// ApiResponseSecuritiesEarningsLatest
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecuritiesEarningsLatest :  IEquatable<ApiResponseSecuritiesEarningsLatest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecuritiesEarningsLatest" /> class.
        /// </summary>
        /// <param name="EarningsRecords">EarningsRecords.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecuritiesEarningsLatest(List<EarningsRecord> EarningsRecords = default(List<EarningsRecord>), string NextPage = default(string))
        {
            this.EarningsRecords = EarningsRecords;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets EarningsRecords
        /// </summary>
        [DataMember(Name="earnings_records", EmitDefaultValue=false)]
        public List<EarningsRecord> EarningsRecords { get; set; }

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
            sb.Append("class ApiResponseSecuritiesEarningsLatest {\n");
            sb.Append("  EarningsRecords: ").Append(EarningsRecords).Append("\n");
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
            return this.Equals(input as ApiResponseSecuritiesEarningsLatest);
        }

        /// <summary>
        /// Returns true if ApiResponseSecuritiesEarningsLatest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecuritiesEarningsLatest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecuritiesEarningsLatest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsRecords == input.EarningsRecords ||
                    this.EarningsRecords != null &&
                    this.EarningsRecords.SequenceEqual(input.EarningsRecords)
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
                if (this.EarningsRecords != null)
                    hashCode = hashCode * 59 + this.EarningsRecords.GetHashCode();
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

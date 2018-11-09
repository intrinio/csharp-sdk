

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
    /// ApiResponseHistoricalData
    /// </summary>
    [DataContract]
    public partial class ApiResponseHistoricalData :  IEquatable<ApiResponseHistoricalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseHistoricalData" /> class.
        /// </summary>
        /// <param name="HistoricalData">HistoricalData.</param>
        /// <param name="NextPage">The token required to request the next page of the data.</param>
        public ApiResponseHistoricalData(List<HistoricalData> HistoricalData = default(List<HistoricalData>), string NextPage = default(string))
        {
            this.HistoricalData = HistoricalData;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets HistoricalData
        /// </summary>
        [DataMember(Name="historical_data", EmitDefaultValue=false)]
        public List<HistoricalData> HistoricalData { get; set; }

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
            sb.Append("class ApiResponseHistoricalData {\n");
            sb.Append("  HistoricalData: ").Append(HistoricalData).Append("\n");
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
            return this.Equals(input as ApiResponseHistoricalData);
        }

        /// <summary>
        /// Returns true if ApiResponseHistoricalData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseHistoricalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseHistoricalData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoricalData == input.HistoricalData ||
                    this.HistoricalData != null &&
                    this.HistoricalData.SequenceEqual(input.HistoricalData)
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
                if (this.HistoricalData != null)
                    hashCode = hashCode * 59 + this.HistoricalData.GetHashCode();
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

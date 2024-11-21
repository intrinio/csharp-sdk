

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
    /// ApiResponseSICIndexHistoricalData
    /// </summary>
    [DataContract]
    public partial class ApiResponseSICIndexHistoricalData :  IEquatable<ApiResponseSICIndexHistoricalData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSICIndexHistoricalData" /> class.
        /// </summary>
        /// <param name="HistoricalData">HistoricalData.</param>
        /// <param name="Index">Index.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSICIndexHistoricalData(List<HistoricalData> HistoricalData = default(List<HistoricalData>), SICIndex Index = default(SICIndex), string NextPage = default(string))
        {
            this.HistoricalData = HistoricalData;
            this.Index = Index;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets HistoricalData
        /// </summary>
        [DataMember(Name="historical_data", EmitDefaultValue=false)]
        public List<HistoricalData> HistoricalData { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public SICIndex Index { get; set; }

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
            sb.Append("class ApiResponseSICIndexHistoricalData {\n");
            sb.Append("  HistoricalData: ").Append(HistoricalData).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return this.Equals(input as ApiResponseSICIndexHistoricalData);
        }

        /// <summary>
        /// Returns true if ApiResponseSICIndexHistoricalData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSICIndexHistoricalData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSICIndexHistoricalData input)
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
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
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



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
    /// ApiResponseSecuritiesDailyShortVolume
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecuritiesDailyShortVolume :  IEquatable<ApiResponseSecuritiesDailyShortVolume>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecuritiesDailyShortVolume" /> class.
        /// </summary>
        /// <param name="DailyShortVolume">DailyShortVolume.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecuritiesDailyShortVolume(List<DailyShortVolume> DailyShortVolume = default(List<DailyShortVolume>), string NextPage = default(string))
        {
            this.DailyShortVolume = DailyShortVolume;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Gets or Sets DailyShortVolume
        /// </summary>
        [DataMember(Name="daily_short_volume", EmitDefaultValue=false)]
        public List<DailyShortVolume> DailyShortVolume { get; set; }

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
            sb.Append("class ApiResponseSecuritiesDailyShortVolume {\n");
            sb.Append("  DailyShortVolume: ").Append(DailyShortVolume).Append("\n");
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
            return this.Equals(input as ApiResponseSecuritiesDailyShortVolume);
        }

        /// <summary>
        /// Returns true if ApiResponseSecuritiesDailyShortVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecuritiesDailyShortVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecuritiesDailyShortVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DailyShortVolume == input.DailyShortVolume ||
                    this.DailyShortVolume != null &&
                    this.DailyShortVolume.SequenceEqual(input.DailyShortVolume)
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
                if (this.DailyShortVolume != null)
                    hashCode = hashCode * 59 + this.DailyShortVolume.GetHashCode();
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

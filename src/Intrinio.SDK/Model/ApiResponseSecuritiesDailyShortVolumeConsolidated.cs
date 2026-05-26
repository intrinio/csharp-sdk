

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
    /// ApiResponseSecuritiesDailyShortVolumeConsolidated
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecuritiesDailyShortVolumeConsolidated :  IEquatable<ApiResponseSecuritiesDailyShortVolumeConsolidated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecuritiesDailyShortVolumeConsolidated" /> class.
        /// </summary>
        /// <param name="DailyShortVolume">DailyShortVolume.</param>
        public ApiResponseSecuritiesDailyShortVolumeConsolidated(List<DailyShortVolumeConsolidated> DailyShortVolume = default(List<DailyShortVolumeConsolidated>))
        {
            this.DailyShortVolume = DailyShortVolume;
        }
        
        /// <summary>
        /// Gets or Sets DailyShortVolume
        /// </summary>
        [DataMember(Name="daily_short_volume", EmitDefaultValue=false)]
        public List<DailyShortVolumeConsolidated> DailyShortVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseSecuritiesDailyShortVolumeConsolidated {\n");
            sb.Append("  DailyShortVolume: ").Append(DailyShortVolume).Append("\n");
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
            return this.Equals(input as ApiResponseSecuritiesDailyShortVolumeConsolidated);
        }

        /// <summary>
        /// Returns true if ApiResponseSecuritiesDailyShortVolumeConsolidated instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecuritiesDailyShortVolumeConsolidated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecuritiesDailyShortVolumeConsolidated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DailyShortVolume == input.DailyShortVolume ||
                    this.DailyShortVolume != null &&
                    this.DailyShortVolume.SequenceEqual(input.DailyShortVolume)
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

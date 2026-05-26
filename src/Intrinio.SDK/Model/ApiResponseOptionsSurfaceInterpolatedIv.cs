

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
    /// ApiResponseOptionsSurfaceInterpolatedIv
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsSurfaceInterpolatedIv :  IEquatable<ApiResponseOptionsSurfaceInterpolatedIv>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsSurfaceInterpolatedIv" /> class.
        /// </summary>
        /// <param name="ImpliedVolatility">The interpolated implied volatility for the given strike and expiration, calculated from the smoothed volatility surface..</param>
        public ApiResponseOptionsSurfaceInterpolatedIv(decimal? ImpliedVolatility = default(decimal?))
        {
            this.ImpliedVolatility = ImpliedVolatility;
        }
        
        /// <summary>
        /// The interpolated implied volatility for the given strike and expiration, calculated from the smoothed volatility surface.
        /// </summary>
        /// <value>The interpolated implied volatility for the given strike and expiration, calculated from the smoothed volatility surface.</value>
        [DataMember(Name="implied_volatility", EmitDefaultValue=false)]
        public decimal? ImpliedVolatility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsSurfaceInterpolatedIv {\n");
            sb.Append("  ImpliedVolatility: ").Append(ImpliedVolatility).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsSurfaceInterpolatedIv);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsSurfaceInterpolatedIv instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsSurfaceInterpolatedIv to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsSurfaceInterpolatedIv input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImpliedVolatility == input.ImpliedVolatility ||
                    (this.ImpliedVolatility != null &&
                    this.ImpliedVolatility.Equals(input.ImpliedVolatility))
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
                if (this.ImpliedVolatility != null)
                    hashCode = hashCode * 59 + this.ImpliedVolatility.GetHashCode();
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

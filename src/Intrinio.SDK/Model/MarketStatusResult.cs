

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
    /// Returns the open status of NYSE.
    /// </summary>
    [DataContract]
    public partial class MarketStatusResult :  IEquatable<MarketStatusResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketStatusResult" /> class.
        /// </summary>
        /// <param name="Timestamp">The UTC timestamp..</param>
        /// <param name="IsOpen">Whether the market is open or not..</param>
        public MarketStatusResult(DateTime? Timestamp = default(DateTime?), bool? IsOpen = default(bool?))
        {
            this.Timestamp = Timestamp;
            this.IsOpen = IsOpen;
        }
        
        /// <summary>
        /// The UTC timestamp.
        /// </summary>
        /// <value>The UTC timestamp.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Whether the market is open or not.
        /// </summary>
        /// <value>Whether the market is open or not.</value>
        [DataMember(Name="is_open", EmitDefaultValue=false)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketStatusResult {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  IsOpen: ").Append(IsOpen).Append("\n");
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
            return this.Equals(input as MarketStatusResult);
        }

        /// <summary>
        /// Returns true if MarketStatusResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketStatusResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.IsOpen == input.IsOpen ||
                    (this.IsOpen != null &&
                    this.IsOpen.Equals(input.IsOpen))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.IsOpen != null)
                    hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
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

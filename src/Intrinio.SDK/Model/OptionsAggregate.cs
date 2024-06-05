

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
    /// Total aggregated open interest and volume for the ticker
    /// </summary>
    [DataContract]
    public partial class OptionsAggregate :  IEquatable<OptionsAggregate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsAggregate" /> class.
        /// </summary>
        /// <param name="Ticker">The ticker symbol of the Security for the Option..</param>
        /// <param name="TotalOpenInterest">Total open interest for the ticker.</param>
        /// <param name="TotalVolume">Total volume for the ticker.</param>
        public OptionsAggregate(string Ticker = default(string), decimal? TotalOpenInterest = default(decimal?), decimal? TotalVolume = default(decimal?))
        {
            this.Ticker = Ticker;
            this.TotalOpenInterest = TotalOpenInterest;
            this.TotalVolume = TotalVolume;
        }
        
        /// <summary>
        /// The ticker symbol of the Security for the Option.
        /// </summary>
        /// <value>The ticker symbol of the Security for the Option.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// Total open interest for the ticker
        /// </summary>
        /// <value>Total open interest for the ticker</value>
        [DataMember(Name="total_open_interest", EmitDefaultValue=false)]
        public decimal? TotalOpenInterest { get; set; }

        /// <summary>
        /// Total volume for the ticker
        /// </summary>
        /// <value>Total volume for the ticker</value>
        [DataMember(Name="total_volume", EmitDefaultValue=false)]
        public decimal? TotalVolume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsAggregate {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  TotalOpenInterest: ").Append(TotalOpenInterest).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
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
            return this.Equals(input as OptionsAggregate);
        }

        /// <summary>
        /// Returns true if OptionsAggregate instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsAggregate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsAggregate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.TotalOpenInterest == input.TotalOpenInterest ||
                    (this.TotalOpenInterest != null &&
                    this.TotalOpenInterest.Equals(input.TotalOpenInterest))
                ) && 
                (
                    this.TotalVolume == input.TotalVolume ||
                    (this.TotalVolume != null &&
                    this.TotalVolume.Equals(input.TotalVolume))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.TotalOpenInterest != null)
                    hashCode = hashCode * 59 + this.TotalOpenInterest.GetHashCode();
                if (this.TotalVolume != null)
                    hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
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

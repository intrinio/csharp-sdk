

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
    /// An realtime option chain contains an options contract and corresponding price data for that contract on a given date.
    /// </summary>
    [DataContract]
    public partial class OptionChainEod :  IEquatable<OptionChainEod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionChainEod" /> class.
        /// </summary>
        /// <param name="Option">Option.</param>
        /// <param name="Prices">Prices.</param>
        public OptionChainEod(OptionEod Option = default(OptionEod), OptionPriceEod Prices = default(OptionPriceEod))
        {
            this.Option = Option;
            this.Prices = Prices;
        }
        
        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public OptionEod Option { get; set; }

        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [DataMember(Name="prices", EmitDefaultValue=false)]
        public OptionPriceEod Prices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionChainEod {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(input as OptionChainEod);
        }

        /// <summary>
        /// Returns true if OptionChainEod instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionChainEod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionChainEod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
                ) && 
                (
                    this.Prices == input.Prices ||
                    (this.Prices != null &&
                    this.Prices.Equals(input.Prices))
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
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
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

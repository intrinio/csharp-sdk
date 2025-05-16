

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
    /// Realtime stats such as greeks and implied volatility for a specific options contract.
    /// </summary>
    [DataContract]
    public partial class OptionSyntheticGreeksRealtime :  IEquatable<OptionSyntheticGreeksRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionSyntheticGreeksRealtime" /> class.
        /// </summary>
        /// <param name="ImpliedVolatility">The implied volatility of the contract calculated using the Black-Scholes Model..</param>
        /// <param name="Delta">Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price..</param>
        /// <param name="Gamma">Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price..</param>
        /// <param name="Theta">Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay..</param>
        /// <param name="Vega">Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility..</param>
        /// <param name="SyntheticPrice">The derived synthetic price of the contract..</param>
        public OptionSyntheticGreeksRealtime(decimal? ImpliedVolatility = default(decimal?), decimal? Delta = default(decimal?), decimal? Gamma = default(decimal?), decimal? Theta = default(decimal?), decimal? Vega = default(decimal?), decimal? SyntheticPrice = default(decimal?))
        {
            this.ImpliedVolatility = ImpliedVolatility;
            this.Delta = Delta;
            this.Gamma = Gamma;
            this.Theta = Theta;
            this.Vega = Vega;
            this.SyntheticPrice = SyntheticPrice;
        }
        
        /// <summary>
        /// The implied volatility of the contract calculated using the Black-Scholes Model.
        /// </summary>
        /// <value>The implied volatility of the contract calculated using the Black-Scholes Model.</value>
        [DataMember(Name="implied_volatility", EmitDefaultValue=false)]
        public decimal? ImpliedVolatility { get; set; }

        /// <summary>
        /// Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price.
        /// </summary>
        /// <value>Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price.</value>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public decimal? Delta { get; set; }

        /// <summary>
        /// Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price.
        /// </summary>
        /// <value>Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price.</value>
        [DataMember(Name="gamma", EmitDefaultValue=false)]
        public decimal? Gamma { get; set; }

        /// <summary>
        /// Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay.
        /// </summary>
        /// <value>Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay.</value>
        [DataMember(Name="theta", EmitDefaultValue=false)]
        public decimal? Theta { get; set; }

        /// <summary>
        /// Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility.
        /// </summary>
        /// <value>Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility.</value>
        [DataMember(Name="vega", EmitDefaultValue=false)]
        public decimal? Vega { get; set; }

        /// <summary>
        /// The derived synthetic price of the contract.
        /// </summary>
        /// <value>The derived synthetic price of the contract.</value>
        [DataMember(Name="synthetic_price", EmitDefaultValue=false)]
        public decimal? SyntheticPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionSyntheticGreeksRealtime {\n");
            sb.Append("  ImpliedVolatility: ").Append(ImpliedVolatility).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  Gamma: ").Append(Gamma).Append("\n");
            sb.Append("  Theta: ").Append(Theta).Append("\n");
            sb.Append("  Vega: ").Append(Vega).Append("\n");
            sb.Append("  SyntheticPrice: ").Append(SyntheticPrice).Append("\n");
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
            return this.Equals(input as OptionSyntheticGreeksRealtime);
        }

        /// <summary>
        /// Returns true if OptionSyntheticGreeksRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionSyntheticGreeksRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionSyntheticGreeksRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImpliedVolatility == input.ImpliedVolatility ||
                    (this.ImpliedVolatility != null &&
                    this.ImpliedVolatility.Equals(input.ImpliedVolatility))
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.Gamma == input.Gamma ||
                    (this.Gamma != null &&
                    this.Gamma.Equals(input.Gamma))
                ) && 
                (
                    this.Theta == input.Theta ||
                    (this.Theta != null &&
                    this.Theta.Equals(input.Theta))
                ) && 
                (
                    this.Vega == input.Vega ||
                    (this.Vega != null &&
                    this.Vega.Equals(input.Vega))
                ) && 
                (
                    this.SyntheticPrice == input.SyntheticPrice ||
                    (this.SyntheticPrice != null &&
                    this.SyntheticPrice.Equals(input.SyntheticPrice))
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
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.Gamma != null)
                    hashCode = hashCode * 59 + this.Gamma.GetHashCode();
                if (this.Theta != null)
                    hashCode = hashCode * 59 + this.Theta.GetHashCode();
                if (this.Vega != null)
                    hashCode = hashCode * 59 + this.Vega.GetHashCode();
                if (this.SyntheticPrice != null)
                    hashCode = hashCode * 59 + this.SyntheticPrice.GetHashCode();
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

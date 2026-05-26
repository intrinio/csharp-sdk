

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
    public partial class OptionSurfaceDatum :  IEquatable<OptionSurfaceDatum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionSurfaceDatum" /> class.
        /// </summary>
        /// <param name="StrikePrice">The actual strike price.  Present when the requesting surface type is raw..</param>
        /// <param name="UnixTimestamp">The expiration DateTime.  Present when the requesting surface type is raw..</param>
        /// <param name="ForwardNaturalLogMoneyness">The natural logarithm of forward moneyness, calculated as ln(F / K), where F is the forward underlying price adjusted for risk-free rate and dividend yield over time to expiration, and K is the option strike. Present when the requesting surface type is something other than raw..</param>
        /// <param name="SquareRootTau">The square root of tau, where tau is the option’s time to expiration in years using a 365.25-day year basis. Present when the requesting surface type is something other than raw..</param>
        /// <param name="ImpliedVolatility">The implied volatility of the contract calculated using the Black-Scholes Model, and smoothed if the requesting surface type was logarithmic_smoothed. Always present..</param>
        public OptionSurfaceDatum(decimal? StrikePrice = default(decimal?), decimal? UnixTimestamp = default(decimal?), decimal? ForwardNaturalLogMoneyness = default(decimal?), decimal? SquareRootTau = default(decimal?), decimal? ImpliedVolatility = default(decimal?))
        {
            this.StrikePrice = StrikePrice;
            this.UnixTimestamp = UnixTimestamp;
            this.ForwardNaturalLogMoneyness = ForwardNaturalLogMoneyness;
            this.SquareRootTau = SquareRootTau;
            this.ImpliedVolatility = ImpliedVolatility;
        }
        
        /// <summary>
        /// The actual strike price.  Present when the requesting surface type is raw.
        /// </summary>
        /// <value>The actual strike price.  Present when the requesting surface type is raw.</value>
        [DataMember(Name="strike_price", EmitDefaultValue=false)]
        public decimal? StrikePrice { get; set; }

        /// <summary>
        /// The expiration DateTime.  Present when the requesting surface type is raw.
        /// </summary>
        /// <value>The expiration DateTime.  Present when the requesting surface type is raw.</value>
        [DataMember(Name="unix_timestamp", EmitDefaultValue=false)]
        public decimal? UnixTimestamp { get; set; }

        /// <summary>
        /// The natural logarithm of forward moneyness, calculated as ln(F / K), where F is the forward underlying price adjusted for risk-free rate and dividend yield over time to expiration, and K is the option strike. Present when the requesting surface type is something other than raw.
        /// </summary>
        /// <value>The natural logarithm of forward moneyness, calculated as ln(F / K), where F is the forward underlying price adjusted for risk-free rate and dividend yield over time to expiration, and K is the option strike. Present when the requesting surface type is something other than raw.</value>
        [DataMember(Name="forward_natural_log_moneyness", EmitDefaultValue=false)]
        public decimal? ForwardNaturalLogMoneyness { get; set; }

        /// <summary>
        /// The square root of tau, where tau is the option’s time to expiration in years using a 365.25-day year basis. Present when the requesting surface type is something other than raw.
        /// </summary>
        /// <value>The square root of tau, where tau is the option’s time to expiration in years using a 365.25-day year basis. Present when the requesting surface type is something other than raw.</value>
        [DataMember(Name="square_root_tau", EmitDefaultValue=false)]
        public decimal? SquareRootTau { get; set; }

        /// <summary>
        /// The implied volatility of the contract calculated using the Black-Scholes Model, and smoothed if the requesting surface type was logarithmic_smoothed. Always present.
        /// </summary>
        /// <value>The implied volatility of the contract calculated using the Black-Scholes Model, and smoothed if the requesting surface type was logarithmic_smoothed. Always present.</value>
        [DataMember(Name="implied_volatility", EmitDefaultValue=false)]
        public decimal? ImpliedVolatility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionSurfaceDatum {\n");
            sb.Append("  StrikePrice: ").Append(StrikePrice).Append("\n");
            sb.Append("  UnixTimestamp: ").Append(UnixTimestamp).Append("\n");
            sb.Append("  ForwardNaturalLogMoneyness: ").Append(ForwardNaturalLogMoneyness).Append("\n");
            sb.Append("  SquareRootTau: ").Append(SquareRootTau).Append("\n");
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
            return this.Equals(input as OptionSurfaceDatum);
        }

        /// <summary>
        /// Returns true if OptionSurfaceDatum instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionSurfaceDatum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionSurfaceDatum input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StrikePrice == input.StrikePrice ||
                    (this.StrikePrice != null &&
                    this.StrikePrice.Equals(input.StrikePrice))
                ) && 
                (
                    this.UnixTimestamp == input.UnixTimestamp ||
                    (this.UnixTimestamp != null &&
                    this.UnixTimestamp.Equals(input.UnixTimestamp))
                ) && 
                (
                    this.ForwardNaturalLogMoneyness == input.ForwardNaturalLogMoneyness ||
                    (this.ForwardNaturalLogMoneyness != null &&
                    this.ForwardNaturalLogMoneyness.Equals(input.ForwardNaturalLogMoneyness))
                ) && 
                (
                    this.SquareRootTau == input.SquareRootTau ||
                    (this.SquareRootTau != null &&
                    this.SquareRootTau.Equals(input.SquareRootTau))
                ) && 
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
                if (this.StrikePrice != null)
                    hashCode = hashCode * 59 + this.StrikePrice.GetHashCode();
                if (this.UnixTimestamp != null)
                    hashCode = hashCode * 59 + this.UnixTimestamp.GetHashCode();
                if (this.ForwardNaturalLogMoneyness != null)
                    hashCode = hashCode * 59 + this.ForwardNaturalLogMoneyness.GetHashCode();
                if (this.SquareRootTau != null)
                    hashCode = hashCode * 59 + this.SquareRootTau.GetHashCode();
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

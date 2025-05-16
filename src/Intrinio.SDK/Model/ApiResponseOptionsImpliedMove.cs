

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
    /// ApiResponseOptionsImpliedMove
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsImpliedMove :  IEquatable<ApiResponseOptionsImpliedMove>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsImpliedMove" /> class.
        /// </summary>
        /// <param name="ImpliedMove">The data pertaining to the implied move..</param>
        /// <param name="Messages">Any messages or warnings about the data.</param>
        /// <param name="UnderlyingPrice">The price of the underlying instrument..</param>
        /// <param name="Expiration">The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised..</param>
        /// <param name="AtmStrike">The at-the-money strike price for the implied move calculation..</param>
        /// <param name="StraddlePrice">The straddle price for the implied move calculation..</param>
        /// <param name="Symbol">The symbol for the underlying instrument..</param>
        public ApiResponseOptionsImpliedMove(OptionImpliedMoveData ImpliedMove = default(OptionImpliedMoveData), List<string> Messages = default(List<string>), decimal? UnderlyingPrice = default(decimal?), string Expiration = default(string), decimal? AtmStrike = default(decimal?), decimal? StraddlePrice = default(decimal?), string Symbol = default(string))
        {
            this.ImpliedMove = ImpliedMove;
            this.Messages = Messages;
            this.UnderlyingPrice = UnderlyingPrice;
            this.Expiration = Expiration;
            this.AtmStrike = AtmStrike;
            this.StraddlePrice = StraddlePrice;
            this.Symbol = Symbol;
        }
        
        /// <summary>
        /// The data pertaining to the implied move.
        /// </summary>
        /// <value>The data pertaining to the implied move.</value>
        [DataMember(Name="implied_move", EmitDefaultValue=false)]
        public OptionImpliedMoveData ImpliedMove { get; set; }

        /// <summary>
        /// Any messages or warnings about the data
        /// </summary>
        /// <value>Any messages or warnings about the data</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// The price of the underlying instrument.
        /// </summary>
        /// <value>The price of the underlying instrument.</value>
        [DataMember(Name="underlying_price", EmitDefaultValue=false)]
        public decimal? UnderlyingPrice { get; set; }

        /// <summary>
        /// The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised.
        /// </summary>
        /// <value>The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised.</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// The at-the-money strike price for the implied move calculation.
        /// </summary>
        /// <value>The at-the-money strike price for the implied move calculation.</value>
        [DataMember(Name="atm_strike", EmitDefaultValue=false)]
        public decimal? AtmStrike { get; set; }

        /// <summary>
        /// The straddle price for the implied move calculation.
        /// </summary>
        /// <value>The straddle price for the implied move calculation.</value>
        [DataMember(Name="straddle_price", EmitDefaultValue=false)]
        public decimal? StraddlePrice { get; set; }

        /// <summary>
        /// The symbol for the underlying instrument.
        /// </summary>
        /// <value>The symbol for the underlying instrument.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsImpliedMove {\n");
            sb.Append("  ImpliedMove: ").Append(ImpliedMove).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  UnderlyingPrice: ").Append(UnderlyingPrice).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  AtmStrike: ").Append(AtmStrike).Append("\n");
            sb.Append("  StraddlePrice: ").Append(StraddlePrice).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsImpliedMove);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsImpliedMove instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsImpliedMove to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsImpliedMove input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImpliedMove == input.ImpliedMove ||
                    (this.ImpliedMove != null &&
                    this.ImpliedMove.Equals(input.ImpliedMove))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.UnderlyingPrice == input.UnderlyingPrice ||
                    (this.UnderlyingPrice != null &&
                    this.UnderlyingPrice.Equals(input.UnderlyingPrice))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.AtmStrike == input.AtmStrike ||
                    (this.AtmStrike != null &&
                    this.AtmStrike.Equals(input.AtmStrike))
                ) && 
                (
                    this.StraddlePrice == input.StraddlePrice ||
                    (this.StraddlePrice != null &&
                    this.StraddlePrice.Equals(input.StraddlePrice))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
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
                if (this.ImpliedMove != null)
                    hashCode = hashCode * 59 + this.ImpliedMove.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.UnderlyingPrice != null)
                    hashCode = hashCode * 59 + this.UnderlyingPrice.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.AtmStrike != null)
                    hashCode = hashCode * 59 + this.AtmStrike.GetHashCode();
                if (this.StraddlePrice != null)
                    hashCode = hashCode * 59 + this.StraddlePrice.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
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

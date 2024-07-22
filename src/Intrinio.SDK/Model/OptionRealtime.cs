

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
    /// An option contract gives the buyer of a contract the right to buy or sell a particular asset at a later date at an agreed upon price.
    /// </summary>
    [DataContract]
    public partial class OptionRealtime :  IEquatable<OptionRealtime>, IValidatableObject
    {
        /// <summary>
        /// The type of Option (put or call).
        /// </summary>
        /// <value>The type of Option (put or call).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Put for value: put
            /// </summary>
            [EnumMember(Value = "put")]
            Put = 1,
            
            /// <summary>
            /// Enum Call for value: call
            /// </summary>
            [EnumMember(Value = "call")]
            Call = 2
        }

        /// <summary>
        /// The type of Option (put or call).
        /// </summary>
        /// <value>The type of Option (put or call).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionRealtime" /> class.
        /// </summary>
        /// <param name="Code">The Intrinio Code for the Option..</param>
        /// <param name="Ticker">The ticker symbol of the Security for the Option..</param>
        /// <param name="Expiration">The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised..</param>
        /// <param name="Strike">The strike price is the fixed price at which a derivative can be exercised, and refers to the price of the derivative’s underlying asset.  In a call option, the strike price is the price at which the option holder can purchase the underlying security.  For a put option, the strike price is the price at which the option holder can sell the underlying security..</param>
        /// <param name="Type">The type of Option (put or call)..</param>
        public OptionRealtime(string Code = default(string), string Ticker = default(string), DateTime? Expiration = default(DateTime?), decimal? Strike = default(decimal?), TypeEnum? Type = default(TypeEnum?))
        {
            this.Code = Code;
            this.Ticker = Ticker;
            this.Expiration = Expiration;
            this.Strike = Strike;
            this.Type = Type;
        }
        
        /// <summary>
        /// The Intrinio Code for the Option.
        /// </summary>
        /// <value>The Intrinio Code for the Option.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ticker symbol of the Security for the Option.
        /// </summary>
        /// <value>The ticker symbol of the Security for the Option.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised.
        /// </summary>
        /// <value>The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised.</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// The strike price is the fixed price at which a derivative can be exercised, and refers to the price of the derivative’s underlying asset.  In a call option, the strike price is the price at which the option holder can purchase the underlying security.  For a put option, the strike price is the price at which the option holder can sell the underlying security.
        /// </summary>
        /// <value>The strike price is the fixed price at which a derivative can be exercised, and refers to the price of the derivative’s underlying asset.  In a call option, the strike price is the price at which the option holder can purchase the underlying security.  For a put option, the strike price is the price at which the option holder can sell the underlying security.</value>
        [DataMember(Name="strike", EmitDefaultValue=false)]
        public decimal? Strike { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionRealtime {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as OptionRealtime);
        }

        /// <summary>
        /// Returns true if OptionRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Expiration == input.Expiration ||
                    (this.Expiration != null &&
                    this.Expiration.Equals(input.Expiration))
                ) && 
                (
                    this.Strike == input.Strike ||
                    (this.Strike != null &&
                    this.Strike.Equals(input.Strike))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Expiration != null)
                    hashCode = hashCode * 59 + this.Expiration.GetHashCode();
                if (this.Strike != null)
                    hashCode = hashCode * 59 + this.Strike.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

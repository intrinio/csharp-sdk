

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
    /// A large market order that is broken into a collection of smaller orders to take advantage of all contracts and prices offered across all exchanges.
    /// </summary>
    [DataContract]
    public partial class OptionUnusualTrade :  IEquatable<OptionUnusualTrade>, IValidatableObject
    {
        /// <summary>
        /// The type of Option (put or call)
        /// </summary>
        /// <value>The type of Option (put or call)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContractTypeEnum
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
        /// The type of Option (put or call)
        /// </summary>
        /// <value>The type of Option (put or call)</value>
        [DataMember(Name="contract_type", EmitDefaultValue=false)]
        public ContractTypeEnum? ContractType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionUnusualTrade" /> class.
        /// </summary>
        /// <param name="Symbol">The underlying option security symbol for the trade.</param>
        /// <param name="Timestamp">The UTC timestamp of order placement.</param>
        /// <param name="Type">The type of unusual trade.</param>
        /// <param name="TotalValue">The aggregated value of all option contract premiums included in the trade.</param>
        /// <param name="ContractType">The type of Option (put or call).</param>
        /// <param name="ContractExpiration">The expiration date for the options contract.</param>
        /// <param name="ContractStrike">The strike price of the option contract.</param>
        public OptionUnusualTrade(string Symbol = default(string), DateTime? Timestamp = default(DateTime?), string Type = default(string), decimal? TotalValue = default(decimal?), ContractTypeEnum? ContractType = default(ContractTypeEnum?), DateTime? ContractExpiration = default(DateTime?), decimal? ContractStrike = default(decimal?))
        {
            this.Symbol = Symbol;
            this.Timestamp = Timestamp;
            this.Type = Type;
            this.TotalValue = TotalValue;
            this.ContractType = ContractType;
            this.ContractExpiration = ContractExpiration;
            this.ContractStrike = ContractStrike;
        }
        
        /// <summary>
        /// The underlying option security symbol for the trade
        /// </summary>
        /// <value>The underlying option security symbol for the trade</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The UTC timestamp of order placement
        /// </summary>
        /// <value>The UTC timestamp of order placement</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The type of unusual trade
        /// </summary>
        /// <value>The type of unusual trade</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The aggregated value of all option contract premiums included in the trade
        /// </summary>
        /// <value>The aggregated value of all option contract premiums included in the trade</value>
        [DataMember(Name="total_value", EmitDefaultValue=false)]
        public decimal? TotalValue { get; set; }


        /// <summary>
        /// The expiration date for the options contract
        /// </summary>
        /// <value>The expiration date for the options contract</value>
        [DataMember(Name="contract_expiration", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ContractExpiration { get; set; }

        /// <summary>
        /// The strike price of the option contract
        /// </summary>
        /// <value>The strike price of the option contract</value>
        [DataMember(Name="contract_strike", EmitDefaultValue=false)]
        public decimal? ContractStrike { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionUnusualTrade {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TotalValue: ").Append(TotalValue).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  ContractExpiration: ").Append(ContractExpiration).Append("\n");
            sb.Append("  ContractStrike: ").Append(ContractStrike).Append("\n");
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
            return this.Equals(input as OptionUnusualTrade);
        }

        /// <summary>
        /// Returns true if OptionUnusualTrade instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionUnusualTrade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionUnusualTrade input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TotalValue == input.TotalValue ||
                    (this.TotalValue != null &&
                    this.TotalValue.Equals(input.TotalValue))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.ContractExpiration == input.ContractExpiration ||
                    (this.ContractExpiration != null &&
                    this.ContractExpiration.Equals(input.ContractExpiration))
                ) && 
                (
                    this.ContractStrike == input.ContractStrike ||
                    (this.ContractStrike != null &&
                    this.ContractStrike.Equals(input.ContractStrike))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TotalValue != null)
                    hashCode = hashCode * 59 + this.TotalValue.GetHashCode();
                if (this.ContractType != null)
                    hashCode = hashCode * 59 + this.ContractType.GetHashCode();
                if (this.ContractExpiration != null)
                    hashCode = hashCode * 59 + this.ContractExpiration.GetHashCode();
                if (this.ContractStrike != null)
                    hashCode = hashCode * 59 + this.ContractStrike.GetHashCode();
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

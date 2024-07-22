

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
    /// Returns detailed information and classifications on exchange traded funds sourced from Zacks.
    /// </summary>
    [DataContract]
    public partial class ZacksETFHolding :  IEquatable<ZacksETFHolding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksETFHolding" /> class.
        /// </summary>
        /// <param name="EtfTicker">The ETF&#39;s common ticker.</param>
        /// <param name="EtfName">The ETF&#39;s name.</param>
        /// <param name="HoldingSymbol">The holding&#39;s common ticker.</param>
        /// <param name="HoldingName">The holding&#39;s name.</param>
        /// <param name="DateOfHolding">The date of the holding.</param>
        /// <param name="Shares">The number of shares.</param>
        /// <param name="Weight">The weight of the holding.</param>
        public ZacksETFHolding(string EtfTicker = default(string), string EtfName = default(string), string HoldingSymbol = default(string), string HoldingName = default(string), DateTime? DateOfHolding = default(DateTime?), decimal? Shares = default(decimal?), decimal? Weight = default(decimal?))
        {
            this.EtfTicker = EtfTicker;
            this.EtfName = EtfName;
            this.HoldingSymbol = HoldingSymbol;
            this.HoldingName = HoldingName;
            this.DateOfHolding = DateOfHolding;
            this.Shares = Shares;
            this.Weight = Weight;
        }
        
        /// <summary>
        /// The ETF&#39;s common ticker
        /// </summary>
        /// <value>The ETF&#39;s common ticker</value>
        [DataMember(Name="etf_ticker", EmitDefaultValue=false)]
        public string EtfTicker { get; set; }

        /// <summary>
        /// The ETF&#39;s name
        /// </summary>
        /// <value>The ETF&#39;s name</value>
        [DataMember(Name="etf_name", EmitDefaultValue=false)]
        public string EtfName { get; set; }

        /// <summary>
        /// The holding&#39;s common ticker
        /// </summary>
        /// <value>The holding&#39;s common ticker</value>
        [DataMember(Name="holding_symbol", EmitDefaultValue=false)]
        public string HoldingSymbol { get; set; }

        /// <summary>
        /// The holding&#39;s name
        /// </summary>
        /// <value>The holding&#39;s name</value>
        [DataMember(Name="holding_name", EmitDefaultValue=false)]
        public string HoldingName { get; set; }

        /// <summary>
        /// The date of the holding
        /// </summary>
        /// <value>The date of the holding</value>
        [DataMember(Name="date_of_holding", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateOfHolding { get; set; }

        /// <summary>
        /// The number of shares
        /// </summary>
        /// <value>The number of shares</value>
        [DataMember(Name="shares", EmitDefaultValue=false)]
        public decimal? Shares { get; set; }

        /// <summary>
        /// The weight of the holding
        /// </summary>
        /// <value>The weight of the holding</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksETFHolding {\n");
            sb.Append("  EtfTicker: ").Append(EtfTicker).Append("\n");
            sb.Append("  EtfName: ").Append(EtfName).Append("\n");
            sb.Append("  HoldingSymbol: ").Append(HoldingSymbol).Append("\n");
            sb.Append("  HoldingName: ").Append(HoldingName).Append("\n");
            sb.Append("  DateOfHolding: ").Append(DateOfHolding).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as ZacksETFHolding);
        }

        /// <summary>
        /// Returns true if ZacksETFHolding instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksETFHolding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksETFHolding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EtfTicker == input.EtfTicker ||
                    (this.EtfTicker != null &&
                    this.EtfTicker.Equals(input.EtfTicker))
                ) && 
                (
                    this.EtfName == input.EtfName ||
                    (this.EtfName != null &&
                    this.EtfName.Equals(input.EtfName))
                ) && 
                (
                    this.HoldingSymbol == input.HoldingSymbol ||
                    (this.HoldingSymbol != null &&
                    this.HoldingSymbol.Equals(input.HoldingSymbol))
                ) && 
                (
                    this.HoldingName == input.HoldingName ||
                    (this.HoldingName != null &&
                    this.HoldingName.Equals(input.HoldingName))
                ) && 
                (
                    this.DateOfHolding == input.DateOfHolding ||
                    (this.DateOfHolding != null &&
                    this.DateOfHolding.Equals(input.DateOfHolding))
                ) && 
                (
                    this.Shares == input.Shares ||
                    (this.Shares != null &&
                    this.Shares.Equals(input.Shares))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.EtfTicker != null)
                    hashCode = hashCode * 59 + this.EtfTicker.GetHashCode();
                if (this.EtfName != null)
                    hashCode = hashCode * 59 + this.EtfName.GetHashCode();
                if (this.HoldingSymbol != null)
                    hashCode = hashCode * 59 + this.HoldingSymbol.GetHashCode();
                if (this.HoldingName != null)
                    hashCode = hashCode * 59 + this.HoldingName.GetHashCode();
                if (this.DateOfHolding != null)
                    hashCode = hashCode * 59 + this.DateOfHolding.GetHashCode();
                if (this.Shares != null)
                    hashCode = hashCode * 59 + this.Shares.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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



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
    /// The summary of a company that submits filings to the SEC and has a security traded primarily on a US exchange
    /// </summary>
    [DataContract]
    public partial class CompanySharesOutstanding :  IEquatable<CompanySharesOutstanding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanySharesOutstanding" /> class.
        /// </summary>
        /// <param name="XbrlAxis">The xbrl concept axis member reported to the SEC..</param>
        /// <param name="XbrlMember">Provides information about the class of stock as reported in XBRL.</param>
        /// <param name="TitleOfSecurity">The description of the security type.</param>
        /// <param name="TradingSymbol">The symbol under which the security is traded in the exchange.</param>
        /// <param name="SecurityExchangeName">The name of the secuirty exchange.</param>
        /// <param name="SharesOutstanding">The amount of stock currently held by all shareholders.</param>
        public CompanySharesOutstanding(string XbrlAxis = default(string), string XbrlMember = default(string), string TitleOfSecurity = default(string), string TradingSymbol = default(string), string SecurityExchangeName = default(string), decimal? SharesOutstanding = default(decimal?))
        {
            this.XbrlAxis = XbrlAxis;
            this.XbrlMember = XbrlMember;
            this.TitleOfSecurity = TitleOfSecurity;
            this.TradingSymbol = TradingSymbol;
            this.SecurityExchangeName = SecurityExchangeName;
            this.SharesOutstanding = SharesOutstanding;
        }
        
        /// <summary>
        /// The xbrl concept axis member reported to the SEC.
        /// </summary>
        /// <value>The xbrl concept axis member reported to the SEC.</value>
        [DataMember(Name="xbrl_axis", EmitDefaultValue=false)]
        public string XbrlAxis { get; set; }

        /// <summary>
        /// Provides information about the class of stock as reported in XBRL
        /// </summary>
        /// <value>Provides information about the class of stock as reported in XBRL</value>
        [DataMember(Name="xbrl_member", EmitDefaultValue=false)]
        public string XbrlMember { get; set; }

        /// <summary>
        /// The description of the security type
        /// </summary>
        /// <value>The description of the security type</value>
        [DataMember(Name="title_of_security", EmitDefaultValue=false)]
        public string TitleOfSecurity { get; set; }

        /// <summary>
        /// The symbol under which the security is traded in the exchange
        /// </summary>
        /// <value>The symbol under which the security is traded in the exchange</value>
        [DataMember(Name="trading_symbol", EmitDefaultValue=false)]
        public string TradingSymbol { get; set; }

        /// <summary>
        /// The name of the secuirty exchange
        /// </summary>
        /// <value>The name of the secuirty exchange</value>
        [DataMember(Name="security_exchange_name", EmitDefaultValue=false)]
        public string SecurityExchangeName { get; set; }

        /// <summary>
        /// The amount of stock currently held by all shareholders
        /// </summary>
        /// <value>The amount of stock currently held by all shareholders</value>
        [DataMember(Name="shares_outstanding", EmitDefaultValue=false)]
        public decimal? SharesOutstanding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanySharesOutstanding {\n");
            sb.Append("  XbrlAxis: ").Append(XbrlAxis).Append("\n");
            sb.Append("  XbrlMember: ").Append(XbrlMember).Append("\n");
            sb.Append("  TitleOfSecurity: ").Append(TitleOfSecurity).Append("\n");
            sb.Append("  TradingSymbol: ").Append(TradingSymbol).Append("\n");
            sb.Append("  SecurityExchangeName: ").Append(SecurityExchangeName).Append("\n");
            sb.Append("  SharesOutstanding: ").Append(SharesOutstanding).Append("\n");
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
            return this.Equals(input as CompanySharesOutstanding);
        }

        /// <summary>
        /// Returns true if CompanySharesOutstanding instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanySharesOutstanding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanySharesOutstanding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XbrlAxis == input.XbrlAxis ||
                    (this.XbrlAxis != null &&
                    this.XbrlAxis.Equals(input.XbrlAxis))
                ) && 
                (
                    this.XbrlMember == input.XbrlMember ||
                    (this.XbrlMember != null &&
                    this.XbrlMember.Equals(input.XbrlMember))
                ) && 
                (
                    this.TitleOfSecurity == input.TitleOfSecurity ||
                    (this.TitleOfSecurity != null &&
                    this.TitleOfSecurity.Equals(input.TitleOfSecurity))
                ) && 
                (
                    this.TradingSymbol == input.TradingSymbol ||
                    (this.TradingSymbol != null &&
                    this.TradingSymbol.Equals(input.TradingSymbol))
                ) && 
                (
                    this.SecurityExchangeName == input.SecurityExchangeName ||
                    (this.SecurityExchangeName != null &&
                    this.SecurityExchangeName.Equals(input.SecurityExchangeName))
                ) && 
                (
                    this.SharesOutstanding == input.SharesOutstanding ||
                    (this.SharesOutstanding != null &&
                    this.SharesOutstanding.Equals(input.SharesOutstanding))
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
                if (this.XbrlAxis != null)
                    hashCode = hashCode * 59 + this.XbrlAxis.GetHashCode();
                if (this.XbrlMember != null)
                    hashCode = hashCode * 59 + this.XbrlMember.GetHashCode();
                if (this.TitleOfSecurity != null)
                    hashCode = hashCode * 59 + this.TitleOfSecurity.GetHashCode();
                if (this.TradingSymbol != null)
                    hashCode = hashCode * 59 + this.TradingSymbol.GetHashCode();
                if (this.SecurityExchangeName != null)
                    hashCode = hashCode * 59 + this.SecurityExchangeName.GetHashCode();
                if (this.SharesOutstanding != null)
                    hashCode = hashCode * 59 + this.SharesOutstanding.GetHashCode();
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

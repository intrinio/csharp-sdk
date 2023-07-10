

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
    /// An security trades result contains all trades corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class SecurityTradesResult :  IEquatable<SecurityTradesResult>, IValidatableObject
    {
        /// <summary>
        /// The source of the trades.
        /// </summary>
        /// <value>The source of the trades.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Iex for value: iex
            /// </summary>
            [EnumMember(Value = "iex")]
            Iex = 1,
            
            /// <summary>
            /// Enum Utpdelayed for value: utp_delayed
            /// </summary>
            [EnumMember(Value = "utp_delayed")]
            Utpdelayed = 2,
            
            /// <summary>
            /// Enum Ctaadelayed for value: cta_a_delayed
            /// </summary>
            [EnumMember(Value = "cta_a_delayed")]
            Ctaadelayed = 3,
            
            /// <summary>
            /// Enum Ctabdelayed for value: cta_b_delayed
            /// </summary>
            [EnumMember(Value = "cta_b_delayed")]
            Ctabdelayed = 4,
            
            /// <summary>
            /// Enum Otcdelayed for value: otc_delayed
            /// </summary>
            [EnumMember(Value = "otc_delayed")]
            Otcdelayed = 5,
            
            /// <summary>
            /// Enum Nasdaqbasic for value: nasdaq_basic
            /// </summary>
            [EnumMember(Value = "nasdaq_basic")]
            Nasdaqbasic = 6
        }

        /// <summary>
        /// The source of the trades.
        /// </summary>
        /// <value>The source of the trades.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityTradesResult" /> class.
        /// </summary>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        /// <param name="Source">The source of the trades..</param>
        /// <param name="Trades">Array of all the trades in this page of the result..</param>
        public SecurityTradesResult(string NextPage = default(string), SourceEnum? Source = default(SourceEnum?), List<SecurityTrades> Trades = default(List<SecurityTrades>))
        {
            this.NextPage = NextPage;
            this.Source = Source;
            this.Trades = Trades;
        }
        
        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }


        /// <summary>
        /// Array of all the trades in this page of the result.
        /// </summary>
        /// <value>Array of all the trades in this page of the result.</value>
        [DataMember(Name="trades", EmitDefaultValue=false)]
        public List<SecurityTrades> Trades { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityTradesResult {\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Trades: ").Append(Trades).Append("\n");
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
            return this.Equals(input as SecurityTradesResult);
        }

        /// <summary>
        /// Returns true if SecurityTradesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityTradesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityTradesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Trades == input.Trades ||
                    this.Trades != null &&
                    this.Trades.SequenceEqual(input.Trades)
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
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Trades != null)
                    hashCode = hashCode * 59 + this.Trades.GetHashCode();
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

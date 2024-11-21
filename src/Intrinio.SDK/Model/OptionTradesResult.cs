

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
    /// An option trades result contains all trades corresponding to the provided query.
    /// </summary>
    [DataContract]
    public partial class OptionTradesResult :  IEquatable<OptionTradesResult>, IValidatableObject
    {
        /// <summary>
        /// The source of the trades.
        /// </summary>
        /// <value>The source of the trades.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Realtime for value: realtime
            /// </summary>
            [EnumMember(Value = "realtime")]
            Realtime = 1,
            
            /// <summary>
            /// Enum Delayed for value: delayed
            /// </summary>
            [EnumMember(Value = "delayed")]
            Delayed = 2
        }

        /// <summary>
        /// The source of the trades.
        /// </summary>
        /// <value>The source of the trades.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionTradesResult" /> class.
        /// </summary>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        /// <param name="Source">The source of the trades..</param>
        /// <param name="Trades">Array of all the trades in this page of the result..</param>
        public OptionTradesResult(string NextPage = default(string), SourceEnum? Source = default(SourceEnum?), List<OptionTrades> Trades = default(List<OptionTrades>))
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
        public List<OptionTrades> Trades { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionTradesResult {\n");
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
            return this.Equals(input as OptionTradesResult);
        }

        /// <summary>
        /// Returns true if OptionTradesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionTradesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionTradesResult input)
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

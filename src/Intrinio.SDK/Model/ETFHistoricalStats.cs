

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
    /// Historical daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and volatility
    /// </summary>
    [DataContract]
    public partial class ETFHistoricalStats :  IEquatable<ETFHistoricalStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFHistoricalStats" /> class.
        /// </summary>
        /// <param name="Messages">A list of messages related to the request, such as warnings or errors..</param>
        /// <param name="Etf">A brief summary of the ETF it which these stats refer.  Not included when returning historical stats..</param>
        /// <param name="Stats">The historical stats for the ETF.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ETFHistoricalStats(List<string> Messages = default(List<string>), ETFSummary Etf = default(ETFSummary), List<ETFStats> Stats = default(List<ETFStats>), string NextPage = default(string))
        {
            this.Messages = Messages;
            this.Etf = Etf;
            this.Stats = Stats;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// A list of messages related to the request, such as warnings or errors.
        /// </summary>
        /// <value>A list of messages related to the request, such as warnings or errors.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// A brief summary of the ETF it which these stats refer.  Not included when returning historical stats.
        /// </summary>
        /// <value>A brief summary of the ETF it which these stats refer.  Not included when returning historical stats.</value>
        [DataMember(Name="etf", EmitDefaultValue=false)]
        public ETFSummary Etf { get; set; }

        /// <summary>
        /// The historical stats for the ETF
        /// </summary>
        /// <value>The historical stats for the ETF</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public List<ETFStats> Stats { get; set; }

        /// <summary>
        /// The token required to request the next page of the data. If null, no further results are available.
        /// </summary>
        /// <value>The token required to request the next page of the data. If null, no further results are available.</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFHistoricalStats {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Etf: ").Append(Etf).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
            return this.Equals(input as ETFHistoricalStats);
        }

        /// <summary>
        /// Returns true if ETFHistoricalStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFHistoricalStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFHistoricalStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Etf == input.Etf ||
                    (this.Etf != null &&
                    this.Etf.Equals(input.Etf))
                ) && 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    this.Stats.SequenceEqual(input.Stats)
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
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
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Etf != null)
                    hashCode = hashCode * 59 + this.Etf.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
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

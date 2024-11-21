

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
    /// An option price contains price information for a specific options contract.
    /// </summary>
    [DataContract]
    public partial class OptionPriceRealtime :  IEquatable<OptionPriceRealtime>, IValidatableObject
    {
        /// <summary>
        /// The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;European\&quot;)
        /// </summary>
        /// <value>The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;European\&quot;)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExerciseStyleEnum
        {
            
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,
            
            /// <summary>
            /// Enum E for value: E
            /// </summary>
            [EnumMember(Value = "E")]
            E = 2
        }

        /// <summary>
        /// The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;European\&quot;)
        /// </summary>
        /// <value>The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;European\&quot;)</value>
        [DataMember(Name="exercise_style", EmitDefaultValue=false)]
        public ExerciseStyleEnum? ExerciseStyle { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionPriceRealtime" /> class.
        /// </summary>
        /// <param name="Last">The price of the last trade.</param>
        /// <param name="LastSize">The size of the last trade.</param>
        /// <param name="LastTimestamp">The time of the last trade.</param>
        /// <param name="Volume">The cumulative volume of this options contract that traded that day..</param>
        /// <param name="Ask">The price of the top ask order.</param>
        /// <param name="AskSize">The size of the top ask order.</param>
        /// <param name="AskTimestamp">The timestamp of the top ask order.</param>
        /// <param name="Bid">The price of the top bid order.</param>
        /// <param name="BidSize">The size of the top bid order.</param>
        /// <param name="BidTimestamp">The time of the top bid order.</param>
        /// <param name="OpenInterest">The total number of this options contract that are still open..</param>
        /// <param name="ExerciseStyle">The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;European\&quot;).</param>
        public OptionPriceRealtime(decimal? Last = default(decimal?), int? LastSize = default(int?), DateTime? LastTimestamp = default(DateTime?), int? Volume = default(int?), decimal? Ask = default(decimal?), int? AskSize = default(int?), DateTime? AskTimestamp = default(DateTime?), decimal? Bid = default(decimal?), int? BidSize = default(int?), DateTime? BidTimestamp = default(DateTime?), int? OpenInterest = default(int?), ExerciseStyleEnum? ExerciseStyle = default(ExerciseStyleEnum?))
        {
            this.Last = Last;
            this.LastSize = LastSize;
            this.LastTimestamp = LastTimestamp;
            this.Volume = Volume;
            this.Ask = Ask;
            this.AskSize = AskSize;
            this.AskTimestamp = AskTimestamp;
            this.Bid = Bid;
            this.BidSize = BidSize;
            this.BidTimestamp = BidTimestamp;
            this.OpenInterest = OpenInterest;
            this.ExerciseStyle = ExerciseStyle;
        }
        
        /// <summary>
        /// The price of the last trade
        /// </summary>
        /// <value>The price of the last trade</value>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public decimal? Last { get; set; }

        /// <summary>
        /// The size of the last trade
        /// </summary>
        /// <value>The size of the last trade</value>
        [DataMember(Name="last_size", EmitDefaultValue=false)]
        public int? LastSize { get; set; }

        /// <summary>
        /// The time of the last trade
        /// </summary>
        /// <value>The time of the last trade</value>
        [DataMember(Name="last_timestamp", EmitDefaultValue=false)]
        public DateTime? LastTimestamp { get; set; }

        /// <summary>
        /// The cumulative volume of this options contract that traded that day.
        /// </summary>
        /// <value>The cumulative volume of this options contract that traded that day.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public int? Volume { get; set; }

        /// <summary>
        /// The price of the top ask order
        /// </summary>
        /// <value>The price of the top ask order</value>
        [DataMember(Name="ask", EmitDefaultValue=false)]
        public decimal? Ask { get; set; }

        /// <summary>
        /// The size of the top ask order
        /// </summary>
        /// <value>The size of the top ask order</value>
        [DataMember(Name="ask_size", EmitDefaultValue=false)]
        public int? AskSize { get; set; }

        /// <summary>
        /// The timestamp of the top ask order
        /// </summary>
        /// <value>The timestamp of the top ask order</value>
        [DataMember(Name="ask_timestamp", EmitDefaultValue=false)]
        public DateTime? AskTimestamp { get; set; }

        /// <summary>
        /// The price of the top bid order
        /// </summary>
        /// <value>The price of the top bid order</value>
        [DataMember(Name="bid", EmitDefaultValue=false)]
        public decimal? Bid { get; set; }

        /// <summary>
        /// The size of the top bid order
        /// </summary>
        /// <value>The size of the top bid order</value>
        [DataMember(Name="bid_size", EmitDefaultValue=false)]
        public int? BidSize { get; set; }

        /// <summary>
        /// The time of the top bid order
        /// </summary>
        /// <value>The time of the top bid order</value>
        [DataMember(Name="bid_timestamp", EmitDefaultValue=false)]
        public DateTime? BidTimestamp { get; set; }

        /// <summary>
        /// The total number of this options contract that are still open.
        /// </summary>
        /// <value>The total number of this options contract that are still open.</value>
        [DataMember(Name="open_interest", EmitDefaultValue=false)]
        public int? OpenInterest { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionPriceRealtime {\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  LastSize: ").Append(LastSize).Append("\n");
            sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Ask: ").Append(Ask).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("  AskTimestamp: ").Append(AskTimestamp).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  BidTimestamp: ").Append(BidTimestamp).Append("\n");
            sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
            sb.Append("  ExerciseStyle: ").Append(ExerciseStyle).Append("\n");
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
            return this.Equals(input as OptionPriceRealtime);
        }

        /// <summary>
        /// Returns true if OptionPriceRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionPriceRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionPriceRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.LastSize == input.LastSize ||
                    (this.LastSize != null &&
                    this.LastSize.Equals(input.LastSize))
                ) && 
                (
                    this.LastTimestamp == input.LastTimestamp ||
                    (this.LastTimestamp != null &&
                    this.LastTimestamp.Equals(input.LastTimestamp))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Ask == input.Ask ||
                    (this.Ask != null &&
                    this.Ask.Equals(input.Ask))
                ) && 
                (
                    this.AskSize == input.AskSize ||
                    (this.AskSize != null &&
                    this.AskSize.Equals(input.AskSize))
                ) && 
                (
                    this.AskTimestamp == input.AskTimestamp ||
                    (this.AskTimestamp != null &&
                    this.AskTimestamp.Equals(input.AskTimestamp))
                ) && 
                (
                    this.Bid == input.Bid ||
                    (this.Bid != null &&
                    this.Bid.Equals(input.Bid))
                ) && 
                (
                    this.BidSize == input.BidSize ||
                    (this.BidSize != null &&
                    this.BidSize.Equals(input.BidSize))
                ) && 
                (
                    this.BidTimestamp == input.BidTimestamp ||
                    (this.BidTimestamp != null &&
                    this.BidTimestamp.Equals(input.BidTimestamp))
                ) && 
                (
                    this.OpenInterest == input.OpenInterest ||
                    (this.OpenInterest != null &&
                    this.OpenInterest.Equals(input.OpenInterest))
                ) && 
                (
                    this.ExerciseStyle == input.ExerciseStyle ||
                    (this.ExerciseStyle != null &&
                    this.ExerciseStyle.Equals(input.ExerciseStyle))
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
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.LastSize != null)
                    hashCode = hashCode * 59 + this.LastSize.GetHashCode();
                if (this.LastTimestamp != null)
                    hashCode = hashCode * 59 + this.LastTimestamp.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Ask != null)
                    hashCode = hashCode * 59 + this.Ask.GetHashCode();
                if (this.AskSize != null)
                    hashCode = hashCode * 59 + this.AskSize.GetHashCode();
                if (this.AskTimestamp != null)
                    hashCode = hashCode * 59 + this.AskTimestamp.GetHashCode();
                if (this.Bid != null)
                    hashCode = hashCode * 59 + this.Bid.GetHashCode();
                if (this.BidSize != null)
                    hashCode = hashCode * 59 + this.BidSize.GetHashCode();
                if (this.BidTimestamp != null)
                    hashCode = hashCode * 59 + this.BidTimestamp.GetHashCode();
                if (this.OpenInterest != null)
                    hashCode = hashCode * 59 + this.OpenInterest.GetHashCode();
                if (this.ExerciseStyle != null)
                    hashCode = hashCode * 59 + this.ExerciseStyle.GetHashCode();
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

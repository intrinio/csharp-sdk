

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
    /// A Forex Price
    /// </summary>
    [DataContract]
    public partial class ForexPrice :  IEquatable<ForexPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForexPrice" /> class.
        /// </summary>
        /// <param name="OccurredAt">The timestamp of the beginning of the timeframe. The open prices would be at this time, while close prices would be at this time plus the timeframe..</param>
        /// <param name="OpenBid">Open bid.</param>
        /// <param name="HighBid">High bid.</param>
        /// <param name="LowBid">Low bid.</param>
        /// <param name="CloseBid">Close bid.</param>
        /// <param name="OpenAsk">Open ask.</param>
        /// <param name="HighAsk">High ask.</param>
        /// <param name="LowAsk">Low ask.</param>
        /// <param name="CloseAsk">Close ask.</param>
        /// <param name="TotalTicks">Total ticks.</param>
        public ForexPrice(string OccurredAt = default(string), float? OpenBid = default(float?), float? HighBid = default(float?), float? LowBid = default(float?), float? CloseBid = default(float?), float? OpenAsk = default(float?), float? HighAsk = default(float?), float? LowAsk = default(float?), float? CloseAsk = default(float?), int? TotalTicks = default(int?))
        {
            this.OccurredAt = OccurredAt;
            this.OpenBid = OpenBid;
            this.HighBid = HighBid;
            this.LowBid = LowBid;
            this.CloseBid = CloseBid;
            this.OpenAsk = OpenAsk;
            this.HighAsk = HighAsk;
            this.LowAsk = LowAsk;
            this.CloseAsk = CloseAsk;
            this.TotalTicks = TotalTicks;
        }
        
        /// <summary>
        /// The timestamp of the beginning of the timeframe. The open prices would be at this time, while close prices would be at this time plus the timeframe.
        /// </summary>
        /// <value>The timestamp of the beginning of the timeframe. The open prices would be at this time, while close prices would be at this time plus the timeframe.</value>
        [DataMember(Name="occurred_at", EmitDefaultValue=false)]
        public string OccurredAt { get; set; }

        /// <summary>
        /// Open bid
        /// </summary>
        /// <value>Open bid</value>
        [DataMember(Name="open_bid", EmitDefaultValue=false)]
        public float? OpenBid { get; set; }

        /// <summary>
        /// High bid
        /// </summary>
        /// <value>High bid</value>
        [DataMember(Name="high_bid", EmitDefaultValue=false)]
        public float? HighBid { get; set; }

        /// <summary>
        /// Low bid
        /// </summary>
        /// <value>Low bid</value>
        [DataMember(Name="low_bid", EmitDefaultValue=false)]
        public float? LowBid { get; set; }

        /// <summary>
        /// Close bid
        /// </summary>
        /// <value>Close bid</value>
        [DataMember(Name="close_bid", EmitDefaultValue=false)]
        public float? CloseBid { get; set; }

        /// <summary>
        /// Open ask
        /// </summary>
        /// <value>Open ask</value>
        [DataMember(Name="open_ask", EmitDefaultValue=false)]
        public float? OpenAsk { get; set; }

        /// <summary>
        /// High ask
        /// </summary>
        /// <value>High ask</value>
        [DataMember(Name="high_ask", EmitDefaultValue=false)]
        public float? HighAsk { get; set; }

        /// <summary>
        /// Low ask
        /// </summary>
        /// <value>Low ask</value>
        [DataMember(Name="low_ask", EmitDefaultValue=false)]
        public float? LowAsk { get; set; }

        /// <summary>
        /// Close ask
        /// </summary>
        /// <value>Close ask</value>
        [DataMember(Name="close_ask", EmitDefaultValue=false)]
        public float? CloseAsk { get; set; }

        /// <summary>
        /// Total ticks
        /// </summary>
        /// <value>Total ticks</value>
        [DataMember(Name="total_ticks", EmitDefaultValue=false)]
        public int? TotalTicks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForexPrice {\n");
            sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
            sb.Append("  OpenBid: ").Append(OpenBid).Append("\n");
            sb.Append("  HighBid: ").Append(HighBid).Append("\n");
            sb.Append("  LowBid: ").Append(LowBid).Append("\n");
            sb.Append("  CloseBid: ").Append(CloseBid).Append("\n");
            sb.Append("  OpenAsk: ").Append(OpenAsk).Append("\n");
            sb.Append("  HighAsk: ").Append(HighAsk).Append("\n");
            sb.Append("  LowAsk: ").Append(LowAsk).Append("\n");
            sb.Append("  CloseAsk: ").Append(CloseAsk).Append("\n");
            sb.Append("  TotalTicks: ").Append(TotalTicks).Append("\n");
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
            return this.Equals(input as ForexPrice);
        }

        /// <summary>
        /// Returns true if ForexPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of ForexPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForexPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OccurredAt == input.OccurredAt ||
                    (this.OccurredAt != null &&
                    this.OccurredAt.Equals(input.OccurredAt))
                ) && 
                (
                    this.OpenBid == input.OpenBid ||
                    (this.OpenBid != null &&
                    this.OpenBid.Equals(input.OpenBid))
                ) && 
                (
                    this.HighBid == input.HighBid ||
                    (this.HighBid != null &&
                    this.HighBid.Equals(input.HighBid))
                ) && 
                (
                    this.LowBid == input.LowBid ||
                    (this.LowBid != null &&
                    this.LowBid.Equals(input.LowBid))
                ) && 
                (
                    this.CloseBid == input.CloseBid ||
                    (this.CloseBid != null &&
                    this.CloseBid.Equals(input.CloseBid))
                ) && 
                (
                    this.OpenAsk == input.OpenAsk ||
                    (this.OpenAsk != null &&
                    this.OpenAsk.Equals(input.OpenAsk))
                ) && 
                (
                    this.HighAsk == input.HighAsk ||
                    (this.HighAsk != null &&
                    this.HighAsk.Equals(input.HighAsk))
                ) && 
                (
                    this.LowAsk == input.LowAsk ||
                    (this.LowAsk != null &&
                    this.LowAsk.Equals(input.LowAsk))
                ) && 
                (
                    this.CloseAsk == input.CloseAsk ||
                    (this.CloseAsk != null &&
                    this.CloseAsk.Equals(input.CloseAsk))
                ) && 
                (
                    this.TotalTicks == input.TotalTicks ||
                    (this.TotalTicks != null &&
                    this.TotalTicks.Equals(input.TotalTicks))
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
                if (this.OccurredAt != null)
                    hashCode = hashCode * 59 + this.OccurredAt.GetHashCode();
                if (this.OpenBid != null)
                    hashCode = hashCode * 59 + this.OpenBid.GetHashCode();
                if (this.HighBid != null)
                    hashCode = hashCode * 59 + this.HighBid.GetHashCode();
                if (this.LowBid != null)
                    hashCode = hashCode * 59 + this.LowBid.GetHashCode();
                if (this.CloseBid != null)
                    hashCode = hashCode * 59 + this.CloseBid.GetHashCode();
                if (this.OpenAsk != null)
                    hashCode = hashCode * 59 + this.OpenAsk.GetHashCode();
                if (this.HighAsk != null)
                    hashCode = hashCode * 59 + this.HighAsk.GetHashCode();
                if (this.LowAsk != null)
                    hashCode = hashCode * 59 + this.LowAsk.GetHashCode();
                if (this.CloseAsk != null)
                    hashCode = hashCode * 59 + this.CloseAsk.GetHashCode();
                if (this.TotalTicks != null)
                    hashCode = hashCode * 59 + this.TotalTicks.GetHashCode();
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

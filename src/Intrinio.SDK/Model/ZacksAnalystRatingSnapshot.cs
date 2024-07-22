

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
    /// A snapshot of ratings data compared with previous timeframes. This includes mean percentiles for comparing one security to the universe of securities covered by Zacks analyst ratings, at a specific point in time.
    /// </summary>
    [DataContract]
    public partial class ZacksAnalystRatingSnapshot :  IEquatable<ZacksAnalystRatingSnapshot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksAnalystRatingSnapshot" /> class.
        /// </summary>
        /// <param name="Type">The snapshot type, signifying the age of the ratings data from the snapshot date..</param>
        /// <param name="SnapshotDate">The date of the snapshot, when data was recorded..</param>
        /// <param name="RatingDate">The date of the latest rating for the snapshot timeframe. This is the effective date of the ratings data..</param>
        /// <param name="Mean">The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell)..</param>
        /// <param name="Percentile">The percentile of the mean, derived by comparing to all securities rated by analysts as of the rating date, ranging 0.0 (strong buy) to 1.0 (strong sell)..</param>
        /// <param name="StrongBuys">The number of analysts recommending Strong Buy..</param>
        /// <param name="Buys">The number of analysts recommending Buy..</param>
        /// <param name="Holds">The number of analysts recommending Hold..</param>
        /// <param name="Sells">The number of analysts recommending Sell..</param>
        /// <param name="StrongSells">The number of analysts recommending Strong Sell..</param>
        /// <param name="Total">The total number of analysts recommendations..</param>
        public ZacksAnalystRatingSnapshot(string Type = default(string), DateTime? SnapshotDate = default(DateTime?), DateTime? RatingDate = default(DateTime?), decimal? Mean = default(decimal?), decimal? Percentile = default(decimal?), int? StrongBuys = default(int?), int? Buys = default(int?), int? Holds = default(int?), int? Sells = default(int?), int? StrongSells = default(int?), int? Total = default(int?))
        {
            this.Type = Type;
            this.SnapshotDate = SnapshotDate;
            this.RatingDate = RatingDate;
            this.Mean = Mean;
            this.Percentile = Percentile;
            this.StrongBuys = StrongBuys;
            this.Buys = Buys;
            this.Holds = Holds;
            this.Sells = Sells;
            this.StrongSells = StrongSells;
            this.Total = Total;
        }
        
        /// <summary>
        /// The snapshot type, signifying the age of the ratings data from the snapshot date.
        /// </summary>
        /// <value>The snapshot type, signifying the age of the ratings data from the snapshot date.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The date of the snapshot, when data was recorded.
        /// </summary>
        /// <value>The date of the snapshot, when data was recorded.</value>
        [DataMember(Name="snapshot_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? SnapshotDate { get; set; }

        /// <summary>
        /// The date of the latest rating for the snapshot timeframe. This is the effective date of the ratings data.
        /// </summary>
        /// <value>The date of the latest rating for the snapshot timeframe. This is the effective date of the ratings data.</value>
        [DataMember(Name="rating_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? RatingDate { get; set; }

        /// <summary>
        /// The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell).
        /// </summary>
        /// <value>The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell).</value>
        [DataMember(Name="mean", EmitDefaultValue=false)]
        public decimal? Mean { get; set; }

        /// <summary>
        /// The percentile of the mean, derived by comparing to all securities rated by analysts as of the rating date, ranging 0.0 (strong buy) to 1.0 (strong sell).
        /// </summary>
        /// <value>The percentile of the mean, derived by comparing to all securities rated by analysts as of the rating date, ranging 0.0 (strong buy) to 1.0 (strong sell).</value>
        [DataMember(Name="percentile", EmitDefaultValue=false)]
        public decimal? Percentile { get; set; }

        /// <summary>
        /// The number of analysts recommending Strong Buy.
        /// </summary>
        /// <value>The number of analysts recommending Strong Buy.</value>
        [DataMember(Name="strong_buys", EmitDefaultValue=false)]
        public int? StrongBuys { get; set; }

        /// <summary>
        /// The number of analysts recommending Buy.
        /// </summary>
        /// <value>The number of analysts recommending Buy.</value>
        [DataMember(Name="buys", EmitDefaultValue=false)]
        public int? Buys { get; set; }

        /// <summary>
        /// The number of analysts recommending Hold.
        /// </summary>
        /// <value>The number of analysts recommending Hold.</value>
        [DataMember(Name="holds", EmitDefaultValue=false)]
        public int? Holds { get; set; }

        /// <summary>
        /// The number of analysts recommending Sell.
        /// </summary>
        /// <value>The number of analysts recommending Sell.</value>
        [DataMember(Name="sells", EmitDefaultValue=false)]
        public int? Sells { get; set; }

        /// <summary>
        /// The number of analysts recommending Strong Sell.
        /// </summary>
        /// <value>The number of analysts recommending Strong Sell.</value>
        [DataMember(Name="strong_sells", EmitDefaultValue=false)]
        public int? StrongSells { get; set; }

        /// <summary>
        /// The total number of analysts recommendations.
        /// </summary>
        /// <value>The total number of analysts recommendations.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksAnalystRatingSnapshot {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SnapshotDate: ").Append(SnapshotDate).Append("\n");
            sb.Append("  RatingDate: ").Append(RatingDate).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Percentile: ").Append(Percentile).Append("\n");
            sb.Append("  StrongBuys: ").Append(StrongBuys).Append("\n");
            sb.Append("  Buys: ").Append(Buys).Append("\n");
            sb.Append("  Holds: ").Append(Holds).Append("\n");
            sb.Append("  Sells: ").Append(Sells).Append("\n");
            sb.Append("  StrongSells: ").Append(StrongSells).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as ZacksAnalystRatingSnapshot);
        }

        /// <summary>
        /// Returns true if ZacksAnalystRatingSnapshot instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksAnalystRatingSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksAnalystRatingSnapshot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SnapshotDate == input.SnapshotDate ||
                    (this.SnapshotDate != null &&
                    this.SnapshotDate.Equals(input.SnapshotDate))
                ) && 
                (
                    this.RatingDate == input.RatingDate ||
                    (this.RatingDate != null &&
                    this.RatingDate.Equals(input.RatingDate))
                ) && 
                (
                    this.Mean == input.Mean ||
                    (this.Mean != null &&
                    this.Mean.Equals(input.Mean))
                ) && 
                (
                    this.Percentile == input.Percentile ||
                    (this.Percentile != null &&
                    this.Percentile.Equals(input.Percentile))
                ) && 
                (
                    this.StrongBuys == input.StrongBuys ||
                    (this.StrongBuys != null &&
                    this.StrongBuys.Equals(input.StrongBuys))
                ) && 
                (
                    this.Buys == input.Buys ||
                    (this.Buys != null &&
                    this.Buys.Equals(input.Buys))
                ) && 
                (
                    this.Holds == input.Holds ||
                    (this.Holds != null &&
                    this.Holds.Equals(input.Holds))
                ) && 
                (
                    this.Sells == input.Sells ||
                    (this.Sells != null &&
                    this.Sells.Equals(input.Sells))
                ) && 
                (
                    this.StrongSells == input.StrongSells ||
                    (this.StrongSells != null &&
                    this.StrongSells.Equals(input.StrongSells))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SnapshotDate != null)
                    hashCode = hashCode * 59 + this.SnapshotDate.GetHashCode();
                if (this.RatingDate != null)
                    hashCode = hashCode * 59 + this.RatingDate.GetHashCode();
                if (this.Mean != null)
                    hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.Percentile != null)
                    hashCode = hashCode * 59 + this.Percentile.GetHashCode();
                if (this.StrongBuys != null)
                    hashCode = hashCode * 59 + this.StrongBuys.GetHashCode();
                if (this.Buys != null)
                    hashCode = hashCode * 59 + this.Buys.GetHashCode();
                if (this.Holds != null)
                    hashCode = hashCode * 59 + this.Holds.GetHashCode();
                if (this.Sells != null)
                    hashCode = hashCode * 59 + this.Sells.GetHashCode();
                if (this.StrongSells != null)
                    hashCode = hashCode * 59 + this.StrongSells.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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



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
    /// Provides analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low
    /// </summary>
    [DataContract]
    public partial class ETFAnalytics :  IEquatable<ETFAnalytics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFAnalytics" /> class.
        /// </summary>
        /// <param name="FiftyTwoWeekHigh">Highest trading price for the security in the preceding 52 weeks.</param>
        /// <param name="FiftyTwoWeekLow">Lowest trading price for the security in the preceding 52 weeks.</param>
        /// <param name="VolumeTraded">The total quantity of shares traded on the latest trading day.</param>
        /// <param name="AverageDailyVolumeOneMonth">The average quantity of shares traded per day for the last month.</param>
        /// <param name="AverageDailyVolumeThreeMonth">The average quantity of shares traded per day for the last three months.</param>
        /// <param name="AverageDailyVolumeSixMonth">The average quantity of shares traded per day for the last six months.</param>
        /// <param name="MarketCap">The market capitalization for the Exchange Traded Fund (ETF).</param>
        /// <param name="SharesOutstanding">The number of shares outstanding for the Exchange Traded Fund (ETF).</param>
        /// <param name="Etf">Etf.</param>
        public ETFAnalytics(decimal? FiftyTwoWeekHigh = default(decimal?), decimal? FiftyTwoWeekLow = default(decimal?), decimal? VolumeTraded = default(decimal?), decimal? AverageDailyVolumeOneMonth = default(decimal?), decimal? AverageDailyVolumeThreeMonth = default(decimal?), decimal? AverageDailyVolumeSixMonth = default(decimal?), decimal? MarketCap = default(decimal?), decimal? SharesOutstanding = default(decimal?), ETFSummary Etf = default(ETFSummary))
        {
            this.FiftyTwoWeekHigh = FiftyTwoWeekHigh;
            this.FiftyTwoWeekLow = FiftyTwoWeekLow;
            this.VolumeTraded = VolumeTraded;
            this.AverageDailyVolumeOneMonth = AverageDailyVolumeOneMonth;
            this.AverageDailyVolumeThreeMonth = AverageDailyVolumeThreeMonth;
            this.AverageDailyVolumeSixMonth = AverageDailyVolumeSixMonth;
            this.MarketCap = MarketCap;
            this.SharesOutstanding = SharesOutstanding;
            this.Etf = Etf;
        }
        
        /// <summary>
        /// Highest trading price for the security in the preceding 52 weeks
        /// </summary>
        /// <value>Highest trading price for the security in the preceding 52 weeks</value>
        [DataMember(Name="fifty_two_week_high", EmitDefaultValue=false)]
        public decimal? FiftyTwoWeekHigh { get; set; }

        /// <summary>
        /// Lowest trading price for the security in the preceding 52 weeks
        /// </summary>
        /// <value>Lowest trading price for the security in the preceding 52 weeks</value>
        [DataMember(Name="fifty_two_week_low", EmitDefaultValue=false)]
        public decimal? FiftyTwoWeekLow { get; set; }

        /// <summary>
        /// The total quantity of shares traded on the latest trading day
        /// </summary>
        /// <value>The total quantity of shares traded on the latest trading day</value>
        [DataMember(Name="volume_traded", EmitDefaultValue=false)]
        public decimal? VolumeTraded { get; set; }

        /// <summary>
        /// The average quantity of shares traded per day for the last month
        /// </summary>
        /// <value>The average quantity of shares traded per day for the last month</value>
        [DataMember(Name="average_daily_volume_one_month", EmitDefaultValue=false)]
        public decimal? AverageDailyVolumeOneMonth { get; set; }

        /// <summary>
        /// The average quantity of shares traded per day for the last three months
        /// </summary>
        /// <value>The average quantity of shares traded per day for the last three months</value>
        [DataMember(Name="average_daily_volume_three_month", EmitDefaultValue=false)]
        public decimal? AverageDailyVolumeThreeMonth { get; set; }

        /// <summary>
        /// The average quantity of shares traded per day for the last six months
        /// </summary>
        /// <value>The average quantity of shares traded per day for the last six months</value>
        [DataMember(Name="average_daily_volume_six_month", EmitDefaultValue=false)]
        public decimal? AverageDailyVolumeSixMonth { get; set; }

        /// <summary>
        /// The market capitalization for the Exchange Traded Fund (ETF)
        /// </summary>
        /// <value>The market capitalization for the Exchange Traded Fund (ETF)</value>
        [DataMember(Name="market_cap", EmitDefaultValue=false)]
        public decimal? MarketCap { get; set; }

        /// <summary>
        /// The number of shares outstanding for the Exchange Traded Fund (ETF)
        /// </summary>
        /// <value>The number of shares outstanding for the Exchange Traded Fund (ETF)</value>
        [DataMember(Name="shares_outstanding", EmitDefaultValue=false)]
        public decimal? SharesOutstanding { get; set; }

        /// <summary>
        /// Gets or Sets Etf
        /// </summary>
        [DataMember(Name="etf", EmitDefaultValue=false)]
        public ETFSummary Etf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFAnalytics {\n");
            sb.Append("  FiftyTwoWeekHigh: ").Append(FiftyTwoWeekHigh).Append("\n");
            sb.Append("  FiftyTwoWeekLow: ").Append(FiftyTwoWeekLow).Append("\n");
            sb.Append("  VolumeTraded: ").Append(VolumeTraded).Append("\n");
            sb.Append("  AverageDailyVolumeOneMonth: ").Append(AverageDailyVolumeOneMonth).Append("\n");
            sb.Append("  AverageDailyVolumeThreeMonth: ").Append(AverageDailyVolumeThreeMonth).Append("\n");
            sb.Append("  AverageDailyVolumeSixMonth: ").Append(AverageDailyVolumeSixMonth).Append("\n");
            sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
            sb.Append("  SharesOutstanding: ").Append(SharesOutstanding).Append("\n");
            sb.Append("  Etf: ").Append(Etf).Append("\n");
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
            return this.Equals(input as ETFAnalytics);
        }

        /// <summary>
        /// Returns true if ETFAnalytics instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFAnalytics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFAnalytics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FiftyTwoWeekHigh == input.FiftyTwoWeekHigh ||
                    (this.FiftyTwoWeekHigh != null &&
                    this.FiftyTwoWeekHigh.Equals(input.FiftyTwoWeekHigh))
                ) && 
                (
                    this.FiftyTwoWeekLow == input.FiftyTwoWeekLow ||
                    (this.FiftyTwoWeekLow != null &&
                    this.FiftyTwoWeekLow.Equals(input.FiftyTwoWeekLow))
                ) && 
                (
                    this.VolumeTraded == input.VolumeTraded ||
                    (this.VolumeTraded != null &&
                    this.VolumeTraded.Equals(input.VolumeTraded))
                ) && 
                (
                    this.AverageDailyVolumeOneMonth == input.AverageDailyVolumeOneMonth ||
                    (this.AverageDailyVolumeOneMonth != null &&
                    this.AverageDailyVolumeOneMonth.Equals(input.AverageDailyVolumeOneMonth))
                ) && 
                (
                    this.AverageDailyVolumeThreeMonth == input.AverageDailyVolumeThreeMonth ||
                    (this.AverageDailyVolumeThreeMonth != null &&
                    this.AverageDailyVolumeThreeMonth.Equals(input.AverageDailyVolumeThreeMonth))
                ) && 
                (
                    this.AverageDailyVolumeSixMonth == input.AverageDailyVolumeSixMonth ||
                    (this.AverageDailyVolumeSixMonth != null &&
                    this.AverageDailyVolumeSixMonth.Equals(input.AverageDailyVolumeSixMonth))
                ) && 
                (
                    this.MarketCap == input.MarketCap ||
                    (this.MarketCap != null &&
                    this.MarketCap.Equals(input.MarketCap))
                ) && 
                (
                    this.SharesOutstanding == input.SharesOutstanding ||
                    (this.SharesOutstanding != null &&
                    this.SharesOutstanding.Equals(input.SharesOutstanding))
                ) && 
                (
                    this.Etf == input.Etf ||
                    (this.Etf != null &&
                    this.Etf.Equals(input.Etf))
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
                if (this.FiftyTwoWeekHigh != null)
                    hashCode = hashCode * 59 + this.FiftyTwoWeekHigh.GetHashCode();
                if (this.FiftyTwoWeekLow != null)
                    hashCode = hashCode * 59 + this.FiftyTwoWeekLow.GetHashCode();
                if (this.VolumeTraded != null)
                    hashCode = hashCode * 59 + this.VolumeTraded.GetHashCode();
                if (this.AverageDailyVolumeOneMonth != null)
                    hashCode = hashCode * 59 + this.AverageDailyVolumeOneMonth.GetHashCode();
                if (this.AverageDailyVolumeThreeMonth != null)
                    hashCode = hashCode * 59 + this.AverageDailyVolumeThreeMonth.GetHashCode();
                if (this.AverageDailyVolumeSixMonth != null)
                    hashCode = hashCode * 59 + this.AverageDailyVolumeSixMonth.GetHashCode();
                if (this.MarketCap != null)
                    hashCode = hashCode * 59 + this.MarketCap.GetHashCode();
                if (this.SharesOutstanding != null)
                    hashCode = hashCode * 59 + this.SharesOutstanding.GetHashCode();
                if (this.Etf != null)
                    hashCode = hashCode * 59 + this.Etf.GetHashCode();
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

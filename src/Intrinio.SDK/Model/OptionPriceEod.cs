

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
    public partial class OptionPriceEod :  IEquatable<OptionPriceEod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionPriceEod" /> class.
        /// </summary>
        /// <param name="Date">The date of the price, in the format YYYY-MM-DD.</param>
        /// <param name="Close">The closing price of the options contract..</param>
        /// <param name="CloseBid">The closing bid price of the options contract..</param>
        /// <param name="CloseAsk">The closing ask price of the options contract..</param>
        /// <param name="Volume">The cumulative volume of this options contract that traded that day..</param>
        /// <param name="Open">The price at the beginning of the period.</param>
        /// <param name="OpenAsk">The ask at the beginning of the period.</param>
        /// <param name="OpenBid">The bid at the beginning of the period.</param>
        /// <param name="OpenInterest">The total number of this options contract that are still open..</param>
        /// <param name="High">The highest price over the span of the period.</param>
        /// <param name="Low">The highest price over the span of the period.</param>
        /// <param name="Mark">The mid price between the latest bid and ask spread.</param>
        /// <param name="AskHigh">The highest ask over the span of the period.</param>
        /// <param name="AskLow">The lowest ask over the span of the period.</param>
        /// <param name="BidHigh">The highest bid over the span of the period.</param>
        /// <param name="BidLow">The lowest bid over the span of the period.</param>
        /// <param name="ImpliedVolatility">The implied volatility of the contract calculated using the Black-Scholes Model..</param>
        /// <param name="Delta">Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price..</param>
        /// <param name="Gamma">Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price..</param>
        /// <param name="Theta">Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay..</param>
        /// <param name="Vega">Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility..</param>
        /// <param name="CloseTime">The time of the last trade before close..</param>
        /// <param name="CloseSize">The size of the last trade before close..</param>
        /// <param name="CloseBidTime">The time of the last bid before close..</param>
        /// <param name="CloseBidSize">The size of the last bid before close..</param>
        /// <param name="CloseAskTime">The time of the last ask before close..</param>
        /// <param name="CloseAskSize">The size of the last ask before close..</param>
        /// <param name="ExerciseStyle">The exercise style..</param>
        public OptionPriceEod(string Date = default(string), decimal? Close = default(decimal?), decimal? CloseBid = default(decimal?), decimal? CloseAsk = default(decimal?), int? Volume = default(int?), decimal? Open = default(decimal?), decimal? OpenAsk = default(decimal?), decimal? OpenBid = default(decimal?), int? OpenInterest = default(int?), decimal? High = default(decimal?), decimal? Low = default(decimal?), decimal? Mark = default(decimal?), decimal? AskHigh = default(decimal?), decimal? AskLow = default(decimal?), decimal? BidHigh = default(decimal?), decimal? BidLow = default(decimal?), decimal? ImpliedVolatility = default(decimal?), decimal? Delta = default(decimal?), decimal? Gamma = default(decimal?), decimal? Theta = default(decimal?), decimal? Vega = default(decimal?), DateTime? CloseTime = default(DateTime?), int? CloseSize = default(int?), DateTime? CloseBidTime = default(DateTime?), int? CloseBidSize = default(int?), DateTime? CloseAskTime = default(DateTime?), int? CloseAskSize = default(int?), string ExerciseStyle = default(string))
        {
            this.Date = Date;
            this.Close = Close;
            this.CloseBid = CloseBid;
            this.CloseAsk = CloseAsk;
            this.Volume = Volume;
            this.Open = Open;
            this.OpenAsk = OpenAsk;
            this.OpenBid = OpenBid;
            this.OpenInterest = OpenInterest;
            this.High = High;
            this.Low = Low;
            this.Mark = Mark;
            this.AskHigh = AskHigh;
            this.AskLow = AskLow;
            this.BidHigh = BidHigh;
            this.BidLow = BidLow;
            this.ImpliedVolatility = ImpliedVolatility;
            this.Delta = Delta;
            this.Gamma = Gamma;
            this.Theta = Theta;
            this.Vega = Vega;
            this.CloseTime = CloseTime;
            this.CloseSize = CloseSize;
            this.CloseBidTime = CloseBidTime;
            this.CloseBidSize = CloseBidSize;
            this.CloseAskTime = CloseAskTime;
            this.CloseAskSize = CloseAskSize;
            this.ExerciseStyle = ExerciseStyle;
        }
        
        /// <summary>
        /// The date of the price, in the format YYYY-MM-DD
        /// </summary>
        /// <value>The date of the price, in the format YYYY-MM-DD</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// The closing price of the options contract.
        /// </summary>
        /// <value>The closing price of the options contract.</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The closing bid price of the options contract.
        /// </summary>
        /// <value>The closing bid price of the options contract.</value>
        [DataMember(Name="close_bid", EmitDefaultValue=false)]
        public decimal? CloseBid { get; set; }

        /// <summary>
        /// The closing ask price of the options contract.
        /// </summary>
        /// <value>The closing ask price of the options contract.</value>
        [DataMember(Name="close_ask", EmitDefaultValue=false)]
        public decimal? CloseAsk { get; set; }

        /// <summary>
        /// The cumulative volume of this options contract that traded that day.
        /// </summary>
        /// <value>The cumulative volume of this options contract that traded that day.</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public int? Volume { get; set; }

        /// <summary>
        /// The price at the beginning of the period
        /// </summary>
        /// <value>The price at the beginning of the period</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The ask at the beginning of the period
        /// </summary>
        /// <value>The ask at the beginning of the period</value>
        [DataMember(Name="open_ask", EmitDefaultValue=false)]
        public decimal? OpenAsk { get; set; }

        /// <summary>
        /// The bid at the beginning of the period
        /// </summary>
        /// <value>The bid at the beginning of the period</value>
        [DataMember(Name="open_bid", EmitDefaultValue=false)]
        public decimal? OpenBid { get; set; }

        /// <summary>
        /// The total number of this options contract that are still open.
        /// </summary>
        /// <value>The total number of this options contract that are still open.</value>
        [DataMember(Name="open_interest", EmitDefaultValue=false)]
        public int? OpenInterest { get; set; }

        /// <summary>
        /// The highest price over the span of the period
        /// </summary>
        /// <value>The highest price over the span of the period</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The highest price over the span of the period
        /// </summary>
        /// <value>The highest price over the span of the period</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The mid price between the latest bid and ask spread
        /// </summary>
        /// <value>The mid price between the latest bid and ask spread</value>
        [DataMember(Name="mark", EmitDefaultValue=false)]
        public decimal? Mark { get; set; }

        /// <summary>
        /// The highest ask over the span of the period
        /// </summary>
        /// <value>The highest ask over the span of the period</value>
        [DataMember(Name="ask_high", EmitDefaultValue=false)]
        public decimal? AskHigh { get; set; }

        /// <summary>
        /// The lowest ask over the span of the period
        /// </summary>
        /// <value>The lowest ask over the span of the period</value>
        [DataMember(Name="ask_low", EmitDefaultValue=false)]
        public decimal? AskLow { get; set; }

        /// <summary>
        /// The highest bid over the span of the period
        /// </summary>
        /// <value>The highest bid over the span of the period</value>
        [DataMember(Name="bid_high", EmitDefaultValue=false)]
        public decimal? BidHigh { get; set; }

        /// <summary>
        /// The lowest bid over the span of the period
        /// </summary>
        /// <value>The lowest bid over the span of the period</value>
        [DataMember(Name="bid_low", EmitDefaultValue=false)]
        public decimal? BidLow { get; set; }

        /// <summary>
        /// The implied volatility of the contract calculated using the Black-Scholes Model.
        /// </summary>
        /// <value>The implied volatility of the contract calculated using the Black-Scholes Model.</value>
        [DataMember(Name="implied_volatility", EmitDefaultValue=false)]
        public decimal? ImpliedVolatility { get; set; }

        /// <summary>
        /// Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price.
        /// </summary>
        /// <value>Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price.</value>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public decimal? Delta { get; set; }

        /// <summary>
        /// Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price.
        /// </summary>
        /// <value>Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price.</value>
        [DataMember(Name="gamma", EmitDefaultValue=false)]
        public decimal? Gamma { get; set; }

        /// <summary>
        /// Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay.
        /// </summary>
        /// <value>Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay.</value>
        [DataMember(Name="theta", EmitDefaultValue=false)]
        public decimal? Theta { get; set; }

        /// <summary>
        /// Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility.
        /// </summary>
        /// <value>Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility.</value>
        [DataMember(Name="vega", EmitDefaultValue=false)]
        public decimal? Vega { get; set; }

        /// <summary>
        /// The time of the last trade before close.
        /// </summary>
        /// <value>The time of the last trade before close.</value>
        [DataMember(Name="close_time", EmitDefaultValue=false)]
        public DateTime? CloseTime { get; set; }

        /// <summary>
        /// The size of the last trade before close.
        /// </summary>
        /// <value>The size of the last trade before close.</value>
        [DataMember(Name="close_size", EmitDefaultValue=false)]
        public int? CloseSize { get; set; }

        /// <summary>
        /// The time of the last bid before close.
        /// </summary>
        /// <value>The time of the last bid before close.</value>
        [DataMember(Name="close_bid_time", EmitDefaultValue=false)]
        public DateTime? CloseBidTime { get; set; }

        /// <summary>
        /// The size of the last bid before close.
        /// </summary>
        /// <value>The size of the last bid before close.</value>
        [DataMember(Name="close_bid_size", EmitDefaultValue=false)]
        public int? CloseBidSize { get; set; }

        /// <summary>
        /// The time of the last ask before close.
        /// </summary>
        /// <value>The time of the last ask before close.</value>
        [DataMember(Name="close_ask_time", EmitDefaultValue=false)]
        public DateTime? CloseAskTime { get; set; }

        /// <summary>
        /// The size of the last ask before close.
        /// </summary>
        /// <value>The size of the last ask before close.</value>
        [DataMember(Name="close_ask_size", EmitDefaultValue=false)]
        public int? CloseAskSize { get; set; }

        /// <summary>
        /// The exercise style.
        /// </summary>
        /// <value>The exercise style.</value>
        [DataMember(Name="exercise_style", EmitDefaultValue=false)]
        public string ExerciseStyle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionPriceEod {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  CloseBid: ").Append(CloseBid).Append("\n");
            sb.Append("  CloseAsk: ").Append(CloseAsk).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  OpenAsk: ").Append(OpenAsk).Append("\n");
            sb.Append("  OpenBid: ").Append(OpenBid).Append("\n");
            sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Mark: ").Append(Mark).Append("\n");
            sb.Append("  AskHigh: ").Append(AskHigh).Append("\n");
            sb.Append("  AskLow: ").Append(AskLow).Append("\n");
            sb.Append("  BidHigh: ").Append(BidHigh).Append("\n");
            sb.Append("  BidLow: ").Append(BidLow).Append("\n");
            sb.Append("  ImpliedVolatility: ").Append(ImpliedVolatility).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  Gamma: ").Append(Gamma).Append("\n");
            sb.Append("  Theta: ").Append(Theta).Append("\n");
            sb.Append("  Vega: ").Append(Vega).Append("\n");
            sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
            sb.Append("  CloseSize: ").Append(CloseSize).Append("\n");
            sb.Append("  CloseBidTime: ").Append(CloseBidTime).Append("\n");
            sb.Append("  CloseBidSize: ").Append(CloseBidSize).Append("\n");
            sb.Append("  CloseAskTime: ").Append(CloseAskTime).Append("\n");
            sb.Append("  CloseAskSize: ").Append(CloseAskSize).Append("\n");
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
            return this.Equals(input as OptionPriceEod);
        }

        /// <summary>
        /// Returns true if OptionPriceEod instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionPriceEod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionPriceEod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) && 
                (
                    this.CloseBid == input.CloseBid ||
                    (this.CloseBid != null &&
                    this.CloseBid.Equals(input.CloseBid))
                ) && 
                (
                    this.CloseAsk == input.CloseAsk ||
                    (this.CloseAsk != null &&
                    this.CloseAsk.Equals(input.CloseAsk))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.OpenAsk == input.OpenAsk ||
                    (this.OpenAsk != null &&
                    this.OpenAsk.Equals(input.OpenAsk))
                ) && 
                (
                    this.OpenBid == input.OpenBid ||
                    (this.OpenBid != null &&
                    this.OpenBid.Equals(input.OpenBid))
                ) && 
                (
                    this.OpenInterest == input.OpenInterest ||
                    (this.OpenInterest != null &&
                    this.OpenInterest.Equals(input.OpenInterest))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.Mark == input.Mark ||
                    (this.Mark != null &&
                    this.Mark.Equals(input.Mark))
                ) && 
                (
                    this.AskHigh == input.AskHigh ||
                    (this.AskHigh != null &&
                    this.AskHigh.Equals(input.AskHigh))
                ) && 
                (
                    this.AskLow == input.AskLow ||
                    (this.AskLow != null &&
                    this.AskLow.Equals(input.AskLow))
                ) && 
                (
                    this.BidHigh == input.BidHigh ||
                    (this.BidHigh != null &&
                    this.BidHigh.Equals(input.BidHigh))
                ) && 
                (
                    this.BidLow == input.BidLow ||
                    (this.BidLow != null &&
                    this.BidLow.Equals(input.BidLow))
                ) && 
                (
                    this.ImpliedVolatility == input.ImpliedVolatility ||
                    (this.ImpliedVolatility != null &&
                    this.ImpliedVolatility.Equals(input.ImpliedVolatility))
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.Gamma == input.Gamma ||
                    (this.Gamma != null &&
                    this.Gamma.Equals(input.Gamma))
                ) && 
                (
                    this.Theta == input.Theta ||
                    (this.Theta != null &&
                    this.Theta.Equals(input.Theta))
                ) && 
                (
                    this.Vega == input.Vega ||
                    (this.Vega != null &&
                    this.Vega.Equals(input.Vega))
                ) && 
                (
                    this.CloseTime == input.CloseTime ||
                    (this.CloseTime != null &&
                    this.CloseTime.Equals(input.CloseTime))
                ) && 
                (
                    this.CloseSize == input.CloseSize ||
                    (this.CloseSize != null &&
                    this.CloseSize.Equals(input.CloseSize))
                ) && 
                (
                    this.CloseBidTime == input.CloseBidTime ||
                    (this.CloseBidTime != null &&
                    this.CloseBidTime.Equals(input.CloseBidTime))
                ) && 
                (
                    this.CloseBidSize == input.CloseBidSize ||
                    (this.CloseBidSize != null &&
                    this.CloseBidSize.Equals(input.CloseBidSize))
                ) && 
                (
                    this.CloseAskTime == input.CloseAskTime ||
                    (this.CloseAskTime != null &&
                    this.CloseAskTime.Equals(input.CloseAskTime))
                ) && 
                (
                    this.CloseAskSize == input.CloseAskSize ||
                    (this.CloseAskSize != null &&
                    this.CloseAskSize.Equals(input.CloseAskSize))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.CloseBid != null)
                    hashCode = hashCode * 59 + this.CloseBid.GetHashCode();
                if (this.CloseAsk != null)
                    hashCode = hashCode * 59 + this.CloseAsk.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.OpenAsk != null)
                    hashCode = hashCode * 59 + this.OpenAsk.GetHashCode();
                if (this.OpenBid != null)
                    hashCode = hashCode * 59 + this.OpenBid.GetHashCode();
                if (this.OpenInterest != null)
                    hashCode = hashCode * 59 + this.OpenInterest.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Mark != null)
                    hashCode = hashCode * 59 + this.Mark.GetHashCode();
                if (this.AskHigh != null)
                    hashCode = hashCode * 59 + this.AskHigh.GetHashCode();
                if (this.AskLow != null)
                    hashCode = hashCode * 59 + this.AskLow.GetHashCode();
                if (this.BidHigh != null)
                    hashCode = hashCode * 59 + this.BidHigh.GetHashCode();
                if (this.BidLow != null)
                    hashCode = hashCode * 59 + this.BidLow.GetHashCode();
                if (this.ImpliedVolatility != null)
                    hashCode = hashCode * 59 + this.ImpliedVolatility.GetHashCode();
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.Gamma != null)
                    hashCode = hashCode * 59 + this.Gamma.GetHashCode();
                if (this.Theta != null)
                    hashCode = hashCode * 59 + this.Theta.GetHashCode();
                if (this.Vega != null)
                    hashCode = hashCode * 59 + this.Vega.GetHashCode();
                if (this.CloseTime != null)
                    hashCode = hashCode * 59 + this.CloseTime.GetHashCode();
                if (this.CloseSize != null)
                    hashCode = hashCode * 59 + this.CloseSize.GetHashCode();
                if (this.CloseBidTime != null)
                    hashCode = hashCode * 59 + this.CloseBidTime.GetHashCode();
                if (this.CloseBidSize != null)
                    hashCode = hashCode * 59 + this.CloseBidSize.GetHashCode();
                if (this.CloseAskTime != null)
                    hashCode = hashCode * 59 + this.CloseAskTime.GetHashCode();
                if (this.CloseAskSize != null)
                    hashCode = hashCode * 59 + this.CloseAskSize.GetHashCode();
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

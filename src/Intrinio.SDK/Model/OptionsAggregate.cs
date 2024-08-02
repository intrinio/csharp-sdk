

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
    /// Total aggregated open interest and volume for the ticker
    /// </summary>
    [DataContract]
    public partial class OptionsAggregate :  IEquatable<OptionsAggregate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsAggregate" /> class.
        /// </summary>
        /// <param name="Ticker">The ticker symbol of the Security for the Option..</param>
        /// <param name="Date">The date of the data..</param>
        /// <param name="TotalOpenInterest">Total open interest for the ticker.</param>
        /// <param name="TotalVolume">Total volume for the ticker.</param>
        /// <param name="TotalPutVolume">Total put volume for the ticker.</param>
        /// <param name="TotalCallVolume">Total call volume for the ticker.</param>
        /// <param name="PutCallVolumeRatio">Total put volume to total call volume ratio for the ticker.</param>
        /// <param name="ContractCount">Total number of active contracts for the ticker.</param>
        public OptionsAggregate(string Ticker = default(string), string Date = default(string), long? TotalOpenInterest = default(long?), long? TotalVolume = default(long?), long? TotalPutVolume = default(long?), long? TotalCallVolume = default(long?), double? PutCallVolumeRatio = default(double?), int? ContractCount = default(int?))
        {
            this.Ticker = Ticker;
            this.Date = Date;
            this.TotalOpenInterest = TotalOpenInterest;
            this.TotalVolume = TotalVolume;
            this.TotalPutVolume = TotalPutVolume;
            this.TotalCallVolume = TotalCallVolume;
            this.PutCallVolumeRatio = PutCallVolumeRatio;
            this.ContractCount = ContractCount;
        }
        
        /// <summary>
        /// The ticker symbol of the Security for the Option.
        /// </summary>
        /// <value>The ticker symbol of the Security for the Option.</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The date of the data.
        /// </summary>
        /// <value>The date of the data.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Total open interest for the ticker
        /// </summary>
        /// <value>Total open interest for the ticker</value>
        [DataMember(Name="total_open_interest", EmitDefaultValue=false)]
        public long? TotalOpenInterest { get; set; }

        /// <summary>
        /// Total volume for the ticker
        /// </summary>
        /// <value>Total volume for the ticker</value>
        [DataMember(Name="total_volume", EmitDefaultValue=false)]
        public long? TotalVolume { get; set; }

        /// <summary>
        /// Total put volume for the ticker
        /// </summary>
        /// <value>Total put volume for the ticker</value>
        [DataMember(Name="total_put_volume", EmitDefaultValue=false)]
        public long? TotalPutVolume { get; set; }

        /// <summary>
        /// Total call volume for the ticker
        /// </summary>
        /// <value>Total call volume for the ticker</value>
        [DataMember(Name="total_call_volume", EmitDefaultValue=false)]
        public long? TotalCallVolume { get; set; }

        /// <summary>
        /// Total put volume to total call volume ratio for the ticker
        /// </summary>
        /// <value>Total put volume to total call volume ratio for the ticker</value>
        [DataMember(Name="put_call_volume_ratio", EmitDefaultValue=false)]
        public double? PutCallVolumeRatio { get; set; }

        /// <summary>
        /// Total number of active contracts for the ticker
        /// </summary>
        /// <value>Total number of active contracts for the ticker</value>
        [DataMember(Name="contract_count", EmitDefaultValue=false)]
        public int? ContractCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsAggregate {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  TotalOpenInterest: ").Append(TotalOpenInterest).Append("\n");
            sb.Append("  TotalVolume: ").Append(TotalVolume).Append("\n");
            sb.Append("  TotalPutVolume: ").Append(TotalPutVolume).Append("\n");
            sb.Append("  TotalCallVolume: ").Append(TotalCallVolume).Append("\n");
            sb.Append("  PutCallVolumeRatio: ").Append(PutCallVolumeRatio).Append("\n");
            sb.Append("  ContractCount: ").Append(ContractCount).Append("\n");
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
            return this.Equals(input as OptionsAggregate);
        }

        /// <summary>
        /// Returns true if OptionsAggregate instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsAggregate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsAggregate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.TotalOpenInterest == input.TotalOpenInterest ||
                    (this.TotalOpenInterest != null &&
                    this.TotalOpenInterest.Equals(input.TotalOpenInterest))
                ) && 
                (
                    this.TotalVolume == input.TotalVolume ||
                    (this.TotalVolume != null &&
                    this.TotalVolume.Equals(input.TotalVolume))
                ) && 
                (
                    this.TotalPutVolume == input.TotalPutVolume ||
                    (this.TotalPutVolume != null &&
                    this.TotalPutVolume.Equals(input.TotalPutVolume))
                ) && 
                (
                    this.TotalCallVolume == input.TotalCallVolume ||
                    (this.TotalCallVolume != null &&
                    this.TotalCallVolume.Equals(input.TotalCallVolume))
                ) && 
                (
                    this.PutCallVolumeRatio == input.PutCallVolumeRatio ||
                    (this.PutCallVolumeRatio != null &&
                    this.PutCallVolumeRatio.Equals(input.PutCallVolumeRatio))
                ) && 
                (
                    this.ContractCount == input.ContractCount ||
                    (this.ContractCount != null &&
                    this.ContractCount.Equals(input.ContractCount))
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
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.TotalOpenInterest != null)
                    hashCode = hashCode * 59 + this.TotalOpenInterest.GetHashCode();
                if (this.TotalVolume != null)
                    hashCode = hashCode * 59 + this.TotalVolume.GetHashCode();
                if (this.TotalPutVolume != null)
                    hashCode = hashCode * 59 + this.TotalPutVolume.GetHashCode();
                if (this.TotalCallVolume != null)
                    hashCode = hashCode * 59 + this.TotalCallVolume.GetHashCode();
                if (this.PutCallVolumeRatio != null)
                    hashCode = hashCode * 59 + this.PutCallVolumeRatio.GetHashCode();
                if (this.ContractCount != null)
                    hashCode = hashCode * 59 + this.ContractCount.GetHashCode();
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

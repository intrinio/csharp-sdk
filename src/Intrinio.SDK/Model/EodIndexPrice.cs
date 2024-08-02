

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
    /// The end of day price of an index.
    /// </summary>
    [DataContract]
    public partial class EodIndexPrice :  IEquatable<EodIndexPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EodIndexPrice" /> class.
        /// </summary>
        /// <param name="Index">The index.</param>
        /// <param name="Close">The close price.</param>
        /// <param name="Open">The open price.</param>
        /// <param name="High">The high price.</param>
        /// <param name="Low">The low price.</param>
        /// <param name="Volume">The volume.</param>
        /// <param name="Date">The date of the pricing data..</param>
        public EodIndexPrice(ApiResponseIndex Index = default(ApiResponseIndex), decimal? Close = default(decimal?), decimal? Open = default(decimal?), decimal? High = default(decimal?), decimal? Low = default(decimal?), int? Volume = default(int?), DateTime? Date = default(DateTime?))
        {
            this.Index = Index;
            this.Close = Close;
            this.Open = Open;
            this.High = High;
            this.Low = Low;
            this.Volume = Volume;
            this.Date = Date;
        }
        
        /// <summary>
        /// The index
        /// </summary>
        /// <value>The index</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public ApiResponseIndex Index { get; set; }

        /// <summary>
        /// The close price
        /// </summary>
        /// <value>The close price</value>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public decimal? Close { get; set; }

        /// <summary>
        /// The open price
        /// </summary>
        /// <value>The open price</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public decimal? Open { get; set; }

        /// <summary>
        /// The high price
        /// </summary>
        /// <value>The high price</value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public decimal? High { get; set; }

        /// <summary>
        /// The low price
        /// </summary>
        /// <value>The low price</value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public decimal? Low { get; set; }

        /// <summary>
        /// The volume
        /// </summary>
        /// <value>The volume</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public int? Volume { get; set; }

        /// <summary>
        /// The date of the pricing data.
        /// </summary>
        /// <value>The date of the pricing data.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EodIndexPrice {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as EodIndexPrice);
        }

        /// <summary>
        /// Returns true if EodIndexPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of EodIndexPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EodIndexPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
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
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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

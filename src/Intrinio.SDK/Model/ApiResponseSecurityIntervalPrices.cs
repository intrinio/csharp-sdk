

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
    /// ApiResponseSecurityIntervalPrices
    /// </summary>
    [DataContract]
    public partial class ApiResponseSecurityIntervalPrices :  IEquatable<ApiResponseSecurityIntervalPrices>, IValidatableObject
    {
        /// <summary>
        /// The source of the data
        /// </summary>
        /// <value>The source of the data</value>
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
            Delayed = 2,
            
            /// <summary>
            /// Enum Nasdaqbasic for value: nasdaq_basic
            /// </summary>
            [EnumMember(Value = "nasdaq_basic")]
            Nasdaqbasic = 3,
            
            /// <summary>
            /// Enum Nasdaqbasicfiltered for value: nasdaq_basic_filtered
            /// </summary>
            [EnumMember(Value = "nasdaq_basic_filtered")]
            Nasdaqbasicfiltered = 4,
            
            /// <summary>
            /// Enum Nasdaqbasiclastsale for value: nasdaq_basic_last_sale
            /// </summary>
            [EnumMember(Value = "nasdaq_basic_last_sale")]
            Nasdaqbasiclastsale = 5,
            
            /// <summary>
            /// Enum Cboeone for value: cboe_one
            /// </summary>
            [EnumMember(Value = "cboe_one")]
            Cboeone = 6,
            
            /// <summary>
            /// Enum Equitiesedge for value: equities_edge
            /// </summary>
            [EnumMember(Value = "equities_edge")]
            Equitiesedge = 7
        }

        /// <summary>
        /// The source of the data
        /// </summary>
        /// <value>The source of the data</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseSecurityIntervalPrices" /> class.
        /// </summary>
        /// <param name="Intervals">Open, close, high, low, volume, average price, and change ratio for a particular interval.</param>
        /// <param name="Security">The Security resolved from the given identifier.</param>
        /// <param name="Source">The source of the data.</param>
        /// <param name="NextPage">The token required to request the next page of the data. If null, no further results are available..</param>
        public ApiResponseSecurityIntervalPrices(List<StockPriceInterval> Intervals = default(List<StockPriceInterval>), SecuritySummary Security = default(SecuritySummary), SourceEnum? Source = default(SourceEnum?), string NextPage = default(string))
        {
            this.Intervals = Intervals;
            this.Security = Security;
            this.Source = Source;
            this.NextPage = NextPage;
        }
        
        /// <summary>
        /// Open, close, high, low, volume, average price, and change ratio for a particular interval
        /// </summary>
        /// <value>Open, close, high, low, volume, average price, and change ratio for a particular interval</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<StockPriceInterval> Intervals { get; set; }

        /// <summary>
        /// The Security resolved from the given identifier
        /// </summary>
        /// <value>The Security resolved from the given identifier</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }


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
            sb.Append("class ApiResponseSecurityIntervalPrices {\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as ApiResponseSecurityIntervalPrices);
        }

        /// <summary>
        /// Returns true if ApiResponseSecurityIntervalPrices instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseSecurityIntervalPrices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseSecurityIntervalPrices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Intervals == input.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(input.Intervals)
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Intervals != null)
                    hashCode = hashCode * 59 + this.Intervals.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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

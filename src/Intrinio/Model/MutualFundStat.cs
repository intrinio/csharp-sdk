

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
using SwaggerDateConverter = Intrinio.Client.SwaggerDateConverter;

namespace Intrinio.Model
{
    /// <summary>
    /// The stats collection of a mutual fund on a given date.
    /// </summary>
    [DataContract]
    public partial class MutualFundStat :  IEquatable<MutualFundStat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFundStat" /> class.
        /// </summary>
        /// <param name="Date">The calendar date that the stats collection represents.</param>
        /// <param name="NetAssets">The dollar amount of net assets managed by the fund.</param>
        /// <param name="NetAssetValue">The value of the mutual fund that is reached by deducting the fund&#39;s liabilities from the market value of all of its shares and then dividing by the number of issued shares.</param>
        public MutualFundStat(DateTime? Date = default(DateTime?), decimal? NetAssets = default(decimal?), decimal? NetAssetValue = default(decimal?))
        {
            this.Date = Date;
            this.NetAssets = NetAssets;
            this.NetAssetValue = NetAssetValue;
        }
        
        /// <summary>
        /// The calendar date that the stats collection represents
        /// </summary>
        /// <value>The calendar date that the stats collection represents</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The dollar amount of net assets managed by the fund
        /// </summary>
        /// <value>The dollar amount of net assets managed by the fund</value>
        [DataMember(Name="net_assets", EmitDefaultValue=false)]
        public decimal? NetAssets { get; set; }

        /// <summary>
        /// The value of the mutual fund that is reached by deducting the fund&#39;s liabilities from the market value of all of its shares and then dividing by the number of issued shares
        /// </summary>
        /// <value>The value of the mutual fund that is reached by deducting the fund&#39;s liabilities from the market value of all of its shares and then dividing by the number of issued shares</value>
        [DataMember(Name="net_asset_value", EmitDefaultValue=false)]
        public decimal? NetAssetValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MutualFundStat {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  NetAssets: ").Append(NetAssets).Append("\n");
            sb.Append("  NetAssetValue: ").Append(NetAssetValue).Append("\n");
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
            return this.Equals(input as MutualFundStat);
        }

        /// <summary>
        /// Returns true if MutualFundStat instances are equal
        /// </summary>
        /// <param name="input">Instance of MutualFundStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MutualFundStat input)
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
                    this.NetAssets == input.NetAssets ||
                    (this.NetAssets != null &&
                    this.NetAssets.Equals(input.NetAssets))
                ) && 
                (
                    this.NetAssetValue == input.NetAssetValue ||
                    (this.NetAssetValue != null &&
                    this.NetAssetValue.Equals(input.NetAssetValue))
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
                if (this.NetAssets != null)
                    hashCode = hashCode * 59 + this.NetAssets.GetHashCode();
                if (this.NetAssetValue != null)
                    hashCode = hashCode * 59 + this.NetAssetValue.GetHashCode();
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

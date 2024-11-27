

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
    /// A beta value for a security.
    /// </summary>
    [DataContract]
    public partial class Beta :  IEquatable<Beta>, IValidatableObject
    {
        /// <summary>
        /// Type of period for this beta value.
        /// </summary>
        /// <value>Type of period for this beta value.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodTypeEnum
        {
            
            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 1,
            
            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 2
        }

        /// <summary>
        /// Type of period for this beta value.
        /// </summary>
        /// <value>Type of period for this beta value.</value>
        [DataMember(Name="period_type", EmitDefaultValue=false)]
        public PeriodTypeEnum? PeriodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Beta" /> class.
        /// </summary>
        /// <param name="PeriodType">Type of period for this beta value..</param>
        /// <param name="OneYearBeta">The one year beta value for this security..</param>
        /// <param name="ThreeYearBeta">The three year beta value for this security..</param>
        /// <param name="FiveYearBeta">The five year beta value for this security..</param>
        /// <param name="SevenYearBeta">The seven year beta value for this security..</param>
        /// <param name="TenYearBeta">The ten year beta value for this security..</param>
        /// <param name="Security">The Security..</param>
        public Beta(PeriodTypeEnum? PeriodType = default(PeriodTypeEnum?), decimal? OneYearBeta = default(decimal?), decimal? ThreeYearBeta = default(decimal?), decimal? FiveYearBeta = default(decimal?), decimal? SevenYearBeta = default(decimal?), decimal? TenYearBeta = default(decimal?), SecuritySummary Security = default(SecuritySummary))
        {
            this.PeriodType = PeriodType;
            this.OneYearBeta = OneYearBeta;
            this.ThreeYearBeta = ThreeYearBeta;
            this.FiveYearBeta = FiveYearBeta;
            this.SevenYearBeta = SevenYearBeta;
            this.TenYearBeta = TenYearBeta;
            this.Security = Security;
        }
        

        /// <summary>
        /// The one year beta value for this security.
        /// </summary>
        /// <value>The one year beta value for this security.</value>
        [DataMember(Name="one_year_beta", EmitDefaultValue=false)]
        public decimal? OneYearBeta { get; set; }

        /// <summary>
        /// The three year beta value for this security.
        /// </summary>
        /// <value>The three year beta value for this security.</value>
        [DataMember(Name="three_year_beta", EmitDefaultValue=false)]
        public decimal? ThreeYearBeta { get; set; }

        /// <summary>
        /// The five year beta value for this security.
        /// </summary>
        /// <value>The five year beta value for this security.</value>
        [DataMember(Name="five_year_beta", EmitDefaultValue=false)]
        public decimal? FiveYearBeta { get; set; }

        /// <summary>
        /// The seven year beta value for this security.
        /// </summary>
        /// <value>The seven year beta value for this security.</value>
        [DataMember(Name="seven_year_beta", EmitDefaultValue=false)]
        public decimal? SevenYearBeta { get; set; }

        /// <summary>
        /// The ten year beta value for this security.
        /// </summary>
        /// <value>The ten year beta value for this security.</value>
        [DataMember(Name="ten_year_beta", EmitDefaultValue=false)]
        public decimal? TenYearBeta { get; set; }

        /// <summary>
        /// The Security.
        /// </summary>
        /// <value>The Security.</value>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public SecuritySummary Security { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Beta {\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  OneYearBeta: ").Append(OneYearBeta).Append("\n");
            sb.Append("  ThreeYearBeta: ").Append(ThreeYearBeta).Append("\n");
            sb.Append("  FiveYearBeta: ").Append(FiveYearBeta).Append("\n");
            sb.Append("  SevenYearBeta: ").Append(SevenYearBeta).Append("\n");
            sb.Append("  TenYearBeta: ").Append(TenYearBeta).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
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
            return this.Equals(input as Beta);
        }

        /// <summary>
        /// Returns true if Beta instances are equal
        /// </summary>
        /// <param name="input">Instance of Beta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Beta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.OneYearBeta == input.OneYearBeta ||
                    (this.OneYearBeta != null &&
                    this.OneYearBeta.Equals(input.OneYearBeta))
                ) && 
                (
                    this.ThreeYearBeta == input.ThreeYearBeta ||
                    (this.ThreeYearBeta != null &&
                    this.ThreeYearBeta.Equals(input.ThreeYearBeta))
                ) && 
                (
                    this.FiveYearBeta == input.FiveYearBeta ||
                    (this.FiveYearBeta != null &&
                    this.FiveYearBeta.Equals(input.FiveYearBeta))
                ) && 
                (
                    this.SevenYearBeta == input.SevenYearBeta ||
                    (this.SevenYearBeta != null &&
                    this.SevenYearBeta.Equals(input.SevenYearBeta))
                ) && 
                (
                    this.TenYearBeta == input.TenYearBeta ||
                    (this.TenYearBeta != null &&
                    this.TenYearBeta.Equals(input.TenYearBeta))
                ) && 
                (
                    this.Security == input.Security ||
                    (this.Security != null &&
                    this.Security.Equals(input.Security))
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
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.OneYearBeta != null)
                    hashCode = hashCode * 59 + this.OneYearBeta.GetHashCode();
                if (this.ThreeYearBeta != null)
                    hashCode = hashCode * 59 + this.ThreeYearBeta.GetHashCode();
                if (this.FiveYearBeta != null)
                    hashCode = hashCode * 59 + this.FiveYearBeta.GetHashCode();
                if (this.SevenYearBeta != null)
                    hashCode = hashCode * 59 + this.SevenYearBeta.GetHashCode();
                if (this.TenYearBeta != null)
                    hashCode = hashCode * 59 + this.TenYearBeta.GetHashCode();
                if (this.Security != null)
                    hashCode = hashCode * 59 + this.Security.GetHashCode();
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

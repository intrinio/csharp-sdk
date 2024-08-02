

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
    /// Zacks Forward PE Estimates
    /// </summary>
    [DataContract]
    public partial class ZacksForwardPE :  IEquatable<ZacksForwardPE>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksForwardPE" /> class.
        /// </summary>
        /// <param name="Ticker">The Zacks common exchange ticker.</param>
        /// <param name="CompanyName">The company name.</param>
        /// <param name="ForwardPeYear1">The forward PE estimate for the first year.</param>
        /// <param name="ForwardPeYear2">The forward PE estimate for the second year.</param>
        /// <param name="ForwardPeYear3">The forward PE estimate for the third year.</param>
        /// <param name="ForwardPeYear4">The forward PE estimate for the fourth year.</param>
        /// <param name="ForwardPeYear5">The forward PE estimate for the fifth year.</param>
        /// <param name="ForwardPegRatioYear1">The forward PEG ratio for the first year.</param>
        /// <param name="LastTtmEps">Trailing twelve months earnings per share.</param>
        public ZacksForwardPE(string Ticker = default(string), string CompanyName = default(string), decimal? ForwardPeYear1 = default(decimal?), decimal? ForwardPeYear2 = default(decimal?), decimal? ForwardPeYear3 = default(decimal?), decimal? ForwardPeYear4 = default(decimal?), decimal? ForwardPeYear5 = default(decimal?), decimal? ForwardPegRatioYear1 = default(decimal?), decimal? LastTtmEps = default(decimal?))
        {
            this.Ticker = Ticker;
            this.CompanyName = CompanyName;
            this.ForwardPeYear1 = ForwardPeYear1;
            this.ForwardPeYear2 = ForwardPeYear2;
            this.ForwardPeYear3 = ForwardPeYear3;
            this.ForwardPeYear4 = ForwardPeYear4;
            this.ForwardPeYear5 = ForwardPeYear5;
            this.ForwardPegRatioYear1 = ForwardPegRatioYear1;
            this.LastTtmEps = LastTtmEps;
        }
        
        /// <summary>
        /// The Zacks common exchange ticker
        /// </summary>
        /// <value>The Zacks common exchange ticker</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The company name
        /// </summary>
        /// <value>The company name</value>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The forward PE estimate for the first year
        /// </summary>
        /// <value>The forward PE estimate for the first year</value>
        [DataMember(Name="forward_pe_year1", EmitDefaultValue=false)]
        public decimal? ForwardPeYear1 { get; set; }

        /// <summary>
        /// The forward PE estimate for the second year
        /// </summary>
        /// <value>The forward PE estimate for the second year</value>
        [DataMember(Name="forward_pe_year2", EmitDefaultValue=false)]
        public decimal? ForwardPeYear2 { get; set; }

        /// <summary>
        /// The forward PE estimate for the third year
        /// </summary>
        /// <value>The forward PE estimate for the third year</value>
        [DataMember(Name="forward_pe_year3", EmitDefaultValue=false)]
        public decimal? ForwardPeYear3 { get; set; }

        /// <summary>
        /// The forward PE estimate for the fourth year
        /// </summary>
        /// <value>The forward PE estimate for the fourth year</value>
        [DataMember(Name="forward_pe_year4", EmitDefaultValue=false)]
        public decimal? ForwardPeYear4 { get; set; }

        /// <summary>
        /// The forward PE estimate for the fifth year
        /// </summary>
        /// <value>The forward PE estimate for the fifth year</value>
        [DataMember(Name="forward_pe_year5", EmitDefaultValue=false)]
        public decimal? ForwardPeYear5 { get; set; }

        /// <summary>
        /// The forward PEG ratio for the first year
        /// </summary>
        /// <value>The forward PEG ratio for the first year</value>
        [DataMember(Name="forward_peg_ratio_year1", EmitDefaultValue=false)]
        public decimal? ForwardPegRatioYear1 { get; set; }

        /// <summary>
        /// Trailing twelve months earnings per share
        /// </summary>
        /// <value>Trailing twelve months earnings per share</value>
        [DataMember(Name="last_ttm_eps", EmitDefaultValue=false)]
        public decimal? LastTtmEps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksForwardPE {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  ForwardPeYear1: ").Append(ForwardPeYear1).Append("\n");
            sb.Append("  ForwardPeYear2: ").Append(ForwardPeYear2).Append("\n");
            sb.Append("  ForwardPeYear3: ").Append(ForwardPeYear3).Append("\n");
            sb.Append("  ForwardPeYear4: ").Append(ForwardPeYear4).Append("\n");
            sb.Append("  ForwardPeYear5: ").Append(ForwardPeYear5).Append("\n");
            sb.Append("  ForwardPegRatioYear1: ").Append(ForwardPegRatioYear1).Append("\n");
            sb.Append("  LastTtmEps: ").Append(LastTtmEps).Append("\n");
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
            return this.Equals(input as ZacksForwardPE);
        }

        /// <summary>
        /// Returns true if ZacksForwardPE instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksForwardPE to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksForwardPE input)
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
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.ForwardPeYear1 == input.ForwardPeYear1 ||
                    (this.ForwardPeYear1 != null &&
                    this.ForwardPeYear1.Equals(input.ForwardPeYear1))
                ) && 
                (
                    this.ForwardPeYear2 == input.ForwardPeYear2 ||
                    (this.ForwardPeYear2 != null &&
                    this.ForwardPeYear2.Equals(input.ForwardPeYear2))
                ) && 
                (
                    this.ForwardPeYear3 == input.ForwardPeYear3 ||
                    (this.ForwardPeYear3 != null &&
                    this.ForwardPeYear3.Equals(input.ForwardPeYear3))
                ) && 
                (
                    this.ForwardPeYear4 == input.ForwardPeYear4 ||
                    (this.ForwardPeYear4 != null &&
                    this.ForwardPeYear4.Equals(input.ForwardPeYear4))
                ) && 
                (
                    this.ForwardPeYear5 == input.ForwardPeYear5 ||
                    (this.ForwardPeYear5 != null &&
                    this.ForwardPeYear5.Equals(input.ForwardPeYear5))
                ) && 
                (
                    this.ForwardPegRatioYear1 == input.ForwardPegRatioYear1 ||
                    (this.ForwardPegRatioYear1 != null &&
                    this.ForwardPegRatioYear1.Equals(input.ForwardPegRatioYear1))
                ) && 
                (
                    this.LastTtmEps == input.LastTtmEps ||
                    (this.LastTtmEps != null &&
                    this.LastTtmEps.Equals(input.LastTtmEps))
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
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.ForwardPeYear1 != null)
                    hashCode = hashCode * 59 + this.ForwardPeYear1.GetHashCode();
                if (this.ForwardPeYear2 != null)
                    hashCode = hashCode * 59 + this.ForwardPeYear2.GetHashCode();
                if (this.ForwardPeYear3 != null)
                    hashCode = hashCode * 59 + this.ForwardPeYear3.GetHashCode();
                if (this.ForwardPeYear4 != null)
                    hashCode = hashCode * 59 + this.ForwardPeYear4.GetHashCode();
                if (this.ForwardPeYear5 != null)
                    hashCode = hashCode * 59 + this.ForwardPeYear5.GetHashCode();
                if (this.ForwardPegRatioYear1 != null)
                    hashCode = hashCode * 59 + this.ForwardPegRatioYear1.GetHashCode();
                if (this.LastTtmEps != null)
                    hashCode = hashCode * 59 + this.LastTtmEps.GetHashCode();
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

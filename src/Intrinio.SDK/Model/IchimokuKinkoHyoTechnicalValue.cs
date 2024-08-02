

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
    /// The date_time, chikou_span, kijun_sen, senkou_span_a, senkou_span_b, and tenkan_sen values of a Ichimoku Kinko Hyo technical indicator calculation
    /// </summary>
    [DataContract]
    public partial class IchimokuKinkoHyoTechnicalValue :  IEquatable<IchimokuKinkoHyoTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IchimokuKinkoHyoTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="ChikouSpan">The Chikou Span (Lagging Span) value of the Ichimoku Kinko Hyo calculation.</param>
        /// <param name="KijunSen">The Kijun-sen (Base Line) value of the Ichimoku Kinko Hyo calculation.</param>
        /// <param name="SenkouSpanA">The Senkou Span A (Leading Span A) value of the Ichimoku Kinko Hyo calculation.</param>
        /// <param name="SenkouSpanB">The Senkou Span B (Leading Span B) value of the Ichimoku Kinko Hyo calculation.</param>
        /// <param name="TenkanSen">The Tenskan-sen (Conversion Line) value of the Ichimoku Kinko Hyo calculation.</param>
        public IchimokuKinkoHyoTechnicalValue(DateTime? DateTime = default(DateTime?), float? ChikouSpan = default(float?), float? KijunSen = default(float?), float? SenkouSpanA = default(float?), float? SenkouSpanB = default(float?), float? TenkanSen = default(float?))
        {
            this.DateTime = DateTime;
            this.ChikouSpan = ChikouSpan;
            this.KijunSen = KijunSen;
            this.SenkouSpanA = SenkouSpanA;
            this.SenkouSpanB = SenkouSpanB;
            this.TenkanSen = TenkanSen;
        }
        
        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Chikou Span (Lagging Span) value of the Ichimoku Kinko Hyo calculation
        /// </summary>
        /// <value>The Chikou Span (Lagging Span) value of the Ichimoku Kinko Hyo calculation</value>
        [DataMember(Name="chikou_span", EmitDefaultValue=false)]
        public float? ChikouSpan { get; set; }

        /// <summary>
        /// The Kijun-sen (Base Line) value of the Ichimoku Kinko Hyo calculation
        /// </summary>
        /// <value>The Kijun-sen (Base Line) value of the Ichimoku Kinko Hyo calculation</value>
        [DataMember(Name="kijun_sen", EmitDefaultValue=false)]
        public float? KijunSen { get; set; }

        /// <summary>
        /// The Senkou Span A (Leading Span A) value of the Ichimoku Kinko Hyo calculation
        /// </summary>
        /// <value>The Senkou Span A (Leading Span A) value of the Ichimoku Kinko Hyo calculation</value>
        [DataMember(Name="senkou_span_a", EmitDefaultValue=false)]
        public float? SenkouSpanA { get; set; }

        /// <summary>
        /// The Senkou Span B (Leading Span B) value of the Ichimoku Kinko Hyo calculation
        /// </summary>
        /// <value>The Senkou Span B (Leading Span B) value of the Ichimoku Kinko Hyo calculation</value>
        [DataMember(Name="senkou_span_b", EmitDefaultValue=false)]
        public float? SenkouSpanB { get; set; }

        /// <summary>
        /// The Tenskan-sen (Conversion Line) value of the Ichimoku Kinko Hyo calculation
        /// </summary>
        /// <value>The Tenskan-sen (Conversion Line) value of the Ichimoku Kinko Hyo calculation</value>
        [DataMember(Name="tenkan_sen", EmitDefaultValue=false)]
        public float? TenkanSen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IchimokuKinkoHyoTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  ChikouSpan: ").Append(ChikouSpan).Append("\n");
            sb.Append("  KijunSen: ").Append(KijunSen).Append("\n");
            sb.Append("  SenkouSpanA: ").Append(SenkouSpanA).Append("\n");
            sb.Append("  SenkouSpanB: ").Append(SenkouSpanB).Append("\n");
            sb.Append("  TenkanSen: ").Append(TenkanSen).Append("\n");
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
            return this.Equals(input as IchimokuKinkoHyoTechnicalValue);
        }

        /// <summary>
        /// Returns true if IchimokuKinkoHyoTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of IchimokuKinkoHyoTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IchimokuKinkoHyoTechnicalValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.ChikouSpan == input.ChikouSpan ||
                    (this.ChikouSpan != null &&
                    this.ChikouSpan.Equals(input.ChikouSpan))
                ) && 
                (
                    this.KijunSen == input.KijunSen ||
                    (this.KijunSen != null &&
                    this.KijunSen.Equals(input.KijunSen))
                ) && 
                (
                    this.SenkouSpanA == input.SenkouSpanA ||
                    (this.SenkouSpanA != null &&
                    this.SenkouSpanA.Equals(input.SenkouSpanA))
                ) && 
                (
                    this.SenkouSpanB == input.SenkouSpanB ||
                    (this.SenkouSpanB != null &&
                    this.SenkouSpanB.Equals(input.SenkouSpanB))
                ) && 
                (
                    this.TenkanSen == input.TenkanSen ||
                    (this.TenkanSen != null &&
                    this.TenkanSen.Equals(input.TenkanSen))
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
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.ChikouSpan != null)
                    hashCode = hashCode * 59 + this.ChikouSpan.GetHashCode();
                if (this.KijunSen != null)
                    hashCode = hashCode * 59 + this.KijunSen.GetHashCode();
                if (this.SenkouSpanA != null)
                    hashCode = hashCode * 59 + this.SenkouSpanA.GetHashCode();
                if (this.SenkouSpanB != null)
                    hashCode = hashCode * 59 + this.SenkouSpanB.GetHashCode();
                if (this.TenkanSen != null)
                    hashCode = hashCode * 59 + this.TenkanSen.GetHashCode();
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

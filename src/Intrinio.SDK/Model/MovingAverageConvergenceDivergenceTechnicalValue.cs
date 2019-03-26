

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
    /// The date_time, macd_histogram, macd_line, and signal_line values of a Moving Average Convergence Divergence technical indicator calculation
    /// </summary>
    [DataContract]
    public partial class MovingAverageConvergenceDivergenceTechnicalValue :  IEquatable<MovingAverageConvergenceDivergenceTechnicalValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovingAverageConvergenceDivergenceTechnicalValue" /> class.
        /// </summary>
        /// <param name="DateTime">The date_time of the observation.</param>
        /// <param name="MacdHistogram">The histogram value of the Moving Average Convergence Divergence calculation.</param>
        /// <param name="MacdLine">The line value of the Moving Average Convergence Divergence calculation.</param>
        /// <param name="SignalLine">The signal line value of the Moving Average Convergence Divergence calculation.</param>
        public MovingAverageConvergenceDivergenceTechnicalValue(DateTime? DateTime = default(DateTime?), float? MacdHistogram = default(float?), float? MacdLine = default(float?), float? SignalLine = default(float?))
        {
            this.DateTime = DateTime;
            this.MacdHistogram = MacdHistogram;
            this.MacdLine = MacdLine;
            this.SignalLine = SignalLine;
        }
        
        /// <summary>
        /// The date_time of the observation
        /// </summary>
        /// <value>The date_time of the observation</value>
        [DataMember(Name="date_time", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The histogram value of the Moving Average Convergence Divergence calculation
        /// </summary>
        /// <value>The histogram value of the Moving Average Convergence Divergence calculation</value>
        [DataMember(Name="macd_histogram", EmitDefaultValue=false)]
        public float? MacdHistogram { get; set; }

        /// <summary>
        /// The line value of the Moving Average Convergence Divergence calculation
        /// </summary>
        /// <value>The line value of the Moving Average Convergence Divergence calculation</value>
        [DataMember(Name="macd_line", EmitDefaultValue=false)]
        public float? MacdLine { get; set; }

        /// <summary>
        /// The signal line value of the Moving Average Convergence Divergence calculation
        /// </summary>
        /// <value>The signal line value of the Moving Average Convergence Divergence calculation</value>
        [DataMember(Name="signal_line", EmitDefaultValue=false)]
        public float? SignalLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovingAverageConvergenceDivergenceTechnicalValue {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  MacdHistogram: ").Append(MacdHistogram).Append("\n");
            sb.Append("  MacdLine: ").Append(MacdLine).Append("\n");
            sb.Append("  SignalLine: ").Append(SignalLine).Append("\n");
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
            return this.Equals(input as MovingAverageConvergenceDivergenceTechnicalValue);
        }

        /// <summary>
        /// Returns true if MovingAverageConvergenceDivergenceTechnicalValue instances are equal
        /// </summary>
        /// <param name="input">Instance of MovingAverageConvergenceDivergenceTechnicalValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovingAverageConvergenceDivergenceTechnicalValue input)
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
                    this.MacdHistogram == input.MacdHistogram ||
                    (this.MacdHistogram != null &&
                    this.MacdHistogram.Equals(input.MacdHistogram))
                ) && 
                (
                    this.MacdLine == input.MacdLine ||
                    (this.MacdLine != null &&
                    this.MacdLine.Equals(input.MacdLine))
                ) && 
                (
                    this.SignalLine == input.SignalLine ||
                    (this.SignalLine != null &&
                    this.SignalLine.Equals(input.SignalLine))
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
                if (this.MacdHistogram != null)
                    hashCode = hashCode * 59 + this.MacdHistogram.GetHashCode();
                if (this.MacdLine != null)
                    hashCode = hashCode * 59 + this.MacdLine.GetHashCode();
                if (this.SignalLine != null)
                    hashCode = hashCode * 59 + this.SignalLine.GetHashCode();
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



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
    /// ApiResponseOptionsGreekContractRealtime
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsGreekContractRealtime :  IEquatable<ApiResponseOptionsGreekContractRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsGreekContractRealtime" /> class.
        /// </summary>
        /// <param name="Messages">Any messages or warnings about the data.</param>
        /// <param name="Option">Option.</param>
        /// <param name="Greeks">Greeks.</param>
        public ApiResponseOptionsGreekContractRealtime(List<string> Messages = default(List<string>), Option Option = default(Option), OptionSyntheticGreeksRealtime Greeks = default(OptionSyntheticGreeksRealtime))
        {
            this.Messages = Messages;
            this.Option = Option;
            this.Greeks = Greeks;
        }
        
        /// <summary>
        /// Any messages or warnings about the data
        /// </summary>
        /// <value>Any messages or warnings about the data</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public Option Option { get; set; }

        /// <summary>
        /// Gets or Sets Greeks
        /// </summary>
        [DataMember(Name="greeks", EmitDefaultValue=false)]
        public OptionSyntheticGreeksRealtime Greeks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsGreekContractRealtime {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  Greeks: ").Append(Greeks).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsGreekContractRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsGreekContractRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsGreekContractRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsGreekContractRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
                ) && 
                (
                    this.Greeks == input.Greeks ||
                    (this.Greeks != null &&
                    this.Greeks.Equals(input.Greeks))
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
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                if (this.Greeks != null)
                    hashCode = hashCode * 59 + this.Greeks.GetHashCode();
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



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
    /// ApiResponseOptionPricesRealtime
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionPricesRealtime :  IEquatable<ApiResponseOptionPricesRealtime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionPricesRealtime" /> class.
        /// </summary>
        /// <param name="Price">Price.</param>
        /// <param name="Option">Option.</param>
        public ApiResponseOptionPricesRealtime(Object Price = default(Object), OptionRealtime Option = default(OptionRealtime))
        {
            this.Price = Price;
            this.Option = Option;
        }
        
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public Object Price { get; set; }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public OptionRealtime Option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionPricesRealtime {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(input as ApiResponseOptionPricesRealtime);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionPricesRealtime instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionPricesRealtime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionPricesRealtime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
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

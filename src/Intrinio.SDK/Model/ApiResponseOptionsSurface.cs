

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
    /// ApiResponseOptionsSurface
    /// </summary>
    [DataContract]
    public partial class ApiResponseOptionsSurface :  IEquatable<ApiResponseOptionsSurface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponseOptionsSurface" /> class.
        /// </summary>
        /// <param name="UpdatedOn">The date and time when the surface surface data was last updated..</param>
        /// <param name="Vertices">A list of data points for the options volatility surface..</param>
        /// <param name="Faces">A list of triangular faces for the options volatility surface..</param>
        public ApiResponseOptionsSurface(DateTime? UpdatedOn = default(DateTime?), List<OptionSurfaceDatum> Vertices = default(List<OptionSurfaceDatum>), List<OptionSurfaceFace> Faces = default(List<OptionSurfaceFace>))
        {
            this.UpdatedOn = UpdatedOn;
            this.Vertices = Vertices;
            this.Faces = Faces;
        }
        
        /// <summary>
        /// The date and time when the surface surface data was last updated.
        /// </summary>
        /// <value>The date and time when the surface surface data was last updated.</value>
        [DataMember(Name="updated_on", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// A list of data points for the options volatility surface.
        /// </summary>
        /// <value>A list of data points for the options volatility surface.</value>
        [DataMember(Name="vertices", EmitDefaultValue=false)]
        public List<OptionSurfaceDatum> Vertices { get; set; }

        /// <summary>
        /// A list of triangular faces for the options volatility surface.
        /// </summary>
        /// <value>A list of triangular faces for the options volatility surface.</value>
        [DataMember(Name="faces", EmitDefaultValue=false)]
        public List<OptionSurfaceFace> Faces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiResponseOptionsSurface {\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Vertices: ").Append(Vertices).Append("\n");
            sb.Append("  Faces: ").Append(Faces).Append("\n");
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
            return this.Equals(input as ApiResponseOptionsSurface);
        }

        /// <summary>
        /// Returns true if ApiResponseOptionsSurface instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiResponseOptionsSurface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiResponseOptionsSurface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.Vertices == input.Vertices ||
                    this.Vertices != null &&
                    this.Vertices.SequenceEqual(input.Vertices)
                ) && 
                (
                    this.Faces == input.Faces ||
                    this.Faces != null &&
                    this.Faces.SequenceEqual(input.Faces)
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
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.Vertices != null)
                    hashCode = hashCode * 59 + this.Vertices.GetHashCode();
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
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

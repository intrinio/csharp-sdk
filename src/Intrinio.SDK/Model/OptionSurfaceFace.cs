

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
    /// A triangular face in the options volatility surface.
    /// </summary>
    [DataContract]
    public partial class OptionSurfaceFace :  IEquatable<OptionSurfaceFace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionSurfaceFace" /> class.
        /// </summary>
        /// <param name="VertexA">The index of vertex A in the vertices array..</param>
        /// <param name="VertexB">The index of vertex B in the vertices array..</param>
        /// <param name="VertexC">The index of vertex B in the vertices array..</param>
        public OptionSurfaceFace(int? VertexA = default(int?), int? VertexB = default(int?), int? VertexC = default(int?))
        {
            this.VertexA = VertexA;
            this.VertexB = VertexB;
            this.VertexC = VertexC;
        }
        
        /// <summary>
        /// The index of vertex A in the vertices array.
        /// </summary>
        /// <value>The index of vertex A in the vertices array.</value>
        [DataMember(Name="vertex_a", EmitDefaultValue=false)]
        public int? VertexA { get; set; }

        /// <summary>
        /// The index of vertex B in the vertices array.
        /// </summary>
        /// <value>The index of vertex B in the vertices array.</value>
        [DataMember(Name="vertex_b", EmitDefaultValue=false)]
        public int? VertexB { get; set; }

        /// <summary>
        /// The index of vertex B in the vertices array.
        /// </summary>
        /// <value>The index of vertex B in the vertices array.</value>
        [DataMember(Name="vertex_c", EmitDefaultValue=false)]
        public int? VertexC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionSurfaceFace {\n");
            sb.Append("  VertexA: ").Append(VertexA).Append("\n");
            sb.Append("  VertexB: ").Append(VertexB).Append("\n");
            sb.Append("  VertexC: ").Append(VertexC).Append("\n");
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
            return this.Equals(input as OptionSurfaceFace);
        }

        /// <summary>
        /// Returns true if OptionSurfaceFace instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionSurfaceFace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionSurfaceFace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VertexA == input.VertexA ||
                    (this.VertexA != null &&
                    this.VertexA.Equals(input.VertexA))
                ) && 
                (
                    this.VertexB == input.VertexB ||
                    (this.VertexB != null &&
                    this.VertexB.Equals(input.VertexB))
                ) && 
                (
                    this.VertexC == input.VertexC ||
                    (this.VertexC != null &&
                    this.VertexC.Equals(input.VertexC))
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
                if (this.VertexA != null)
                    hashCode = hashCode * 59 + this.VertexA.GetHashCode();
                if (this.VertexB != null)
                    hashCode = hashCode * 59 + this.VertexB.GetHashCode();
                if (this.VertexC != null)
                    hashCode = hashCode * 59 + this.VertexC.GetHashCode();
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



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
    /// Latest NAV and flows data for all ETFs, sorted by month-end assets
    /// </summary>
    [DataContract]
    public partial class ETFNavFlowsAll :  IEquatable<ETFNavFlowsAll>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ETFNavFlowsAll" /> class.
        /// </summary>
        /// <param name="NavFlows">Array of latest NAV flows data objects for all ETFs.</param>
        /// <param name="NextPage">The token required to request the next page of results.</param>
        /// <param name="Messages">Any messages, warnings, or additional information about the data.</param>
        public ETFNavFlowsAll(List<Object> NavFlows = default(List<Object>), string NextPage = default(string), List<string> Messages = default(List<string>))
        {
            this.NavFlows = NavFlows;
            this.NextPage = NextPage;
            this.Messages = Messages;
        }
        
        /// <summary>
        /// Array of latest NAV flows data objects for all ETFs
        /// </summary>
        /// <value>Array of latest NAV flows data objects for all ETFs</value>
        [DataMember(Name="nav_flows", EmitDefaultValue=false)]
        public List<Object> NavFlows { get; set; }

        /// <summary>
        /// The token required to request the next page of results
        /// </summary>
        /// <value>The token required to request the next page of results</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// Any messages, warnings, or additional information about the data
        /// </summary>
        /// <value>Any messages, warnings, or additional information about the data</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ETFNavFlowsAll {\n");
            sb.Append("  NavFlows: ").Append(NavFlows).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(input as ETFNavFlowsAll);
        }

        /// <summary>
        /// Returns true if ETFNavFlowsAll instances are equal
        /// </summary>
        /// <param name="input">Instance of ETFNavFlowsAll to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ETFNavFlowsAll input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NavFlows == input.NavFlows ||
                    this.NavFlows != null &&
                    this.NavFlows.SequenceEqual(input.NavFlows)
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
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
                if (this.NavFlows != null)
                    hashCode = hashCode * 59 + this.NavFlows.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
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

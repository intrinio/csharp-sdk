

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
    /// A local Municipality
    /// </summary>
    [DataContract]
    public partial class Municipality :  IEquatable<Municipality>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Municipality" /> class.
        /// </summary>
        /// <param name="Id">The Intrinio ID for Municipality.</param>
        /// <param name="CensusId">The ID for the census.</param>
        /// <param name="GovernmentName">The government name of the Municipality.</param>
        /// <param name="GovernmentType">The type of government of the Municipality.</param>
        /// <param name="PrimaryContactType">The primary contact type of the Municipality.</param>
        /// <param name="Address1">The first line of the address.</param>
        /// <param name="Address2">The second line of the address (i.e. suite number).</param>
        /// <param name="City">The city in which the Municipality is located in.</param>
        /// <param name="State">The state in which the Municipality is located in.</param>
        /// <param name="Zip">The zip code in which the Municipality is located in.</param>
        /// <param name="WebSite">The web site of the Municipality.</param>
        /// <param name="Population">The population of the Municipality.</param>
        /// <param name="PopulationAsOfYear">The year from which the population of the Municipality was measured.</param>
        /// <param name="Enrollment">The enrollment of the Municipality.</param>
        /// <param name="EnrollmentAsOfYear">The year from which the enrollment of the Municipality was measured.</param>
        /// <param name="AreaName">The name of the area of the Municipality.</param>
        /// <param name="AreaType">The type of area of the Municipality.</param>
        /// <param name="Latitude">The latitude of the location of the Municipality.</param>
        /// <param name="Longitude">The longitude of the location of the Municipality.</param>
        public Municipality(string Id = default(string), decimal? CensusId = default(decimal?), string GovernmentName = default(string), string GovernmentType = default(string), string PrimaryContactType = default(string), string Address1 = default(string), string Address2 = default(string), string City = default(string), string State = default(string), string Zip = default(string), string WebSite = default(string), decimal? Population = default(decimal?), decimal? PopulationAsOfYear = default(decimal?), decimal? Enrollment = default(decimal?), decimal? EnrollmentAsOfYear = default(decimal?), string AreaName = default(string), string AreaType = default(string), float? Latitude = default(float?), float? Longitude = default(float?))
        {
            this.Id = Id;
            this.CensusId = CensusId;
            this.GovernmentName = GovernmentName;
            this.GovernmentType = GovernmentType;
            this.PrimaryContactType = PrimaryContactType;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.WebSite = WebSite;
            this.Population = Population;
            this.PopulationAsOfYear = PopulationAsOfYear;
            this.Enrollment = Enrollment;
            this.EnrollmentAsOfYear = EnrollmentAsOfYear;
            this.AreaName = AreaName;
            this.AreaType = AreaType;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
        
        /// <summary>
        /// The Intrinio ID for Municipality
        /// </summary>
        /// <value>The Intrinio ID for Municipality</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The ID for the census
        /// </summary>
        /// <value>The ID for the census</value>
        [DataMember(Name="census_id", EmitDefaultValue=false)]
        public decimal? CensusId { get; set; }

        /// <summary>
        /// The government name of the Municipality
        /// </summary>
        /// <value>The government name of the Municipality</value>
        [DataMember(Name="government_name", EmitDefaultValue=false)]
        public string GovernmentName { get; set; }

        /// <summary>
        /// The type of government of the Municipality
        /// </summary>
        /// <value>The type of government of the Municipality</value>
        [DataMember(Name="government_type", EmitDefaultValue=false)]
        public string GovernmentType { get; set; }

        /// <summary>
        /// The primary contact type of the Municipality
        /// </summary>
        /// <value>The primary contact type of the Municipality</value>
        [DataMember(Name="primary_contact_type", EmitDefaultValue=false)]
        public string PrimaryContactType { get; set; }

        /// <summary>
        /// The first line of the address
        /// </summary>
        /// <value>The first line of the address</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address (i.e. suite number)
        /// </summary>
        /// <value>The second line of the address (i.e. suite number)</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// The city in which the Municipality is located in
        /// </summary>
        /// <value>The city in which the Municipality is located in</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The state in which the Municipality is located in
        /// </summary>
        /// <value>The state in which the Municipality is located in</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The zip code in which the Municipality is located in
        /// </summary>
        /// <value>The zip code in which the Municipality is located in</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// The web site of the Municipality
        /// </summary>
        /// <value>The web site of the Municipality</value>
        [DataMember(Name="web_site", EmitDefaultValue=false)]
        public string WebSite { get; set; }

        /// <summary>
        /// The population of the Municipality
        /// </summary>
        /// <value>The population of the Municipality</value>
        [DataMember(Name="population", EmitDefaultValue=false)]
        public decimal? Population { get; set; }

        /// <summary>
        /// The year from which the population of the Municipality was measured
        /// </summary>
        /// <value>The year from which the population of the Municipality was measured</value>
        [DataMember(Name="population_as_of_year", EmitDefaultValue=false)]
        public decimal? PopulationAsOfYear { get; set; }

        /// <summary>
        /// The enrollment of the Municipality
        /// </summary>
        /// <value>The enrollment of the Municipality</value>
        [DataMember(Name="enrollment", EmitDefaultValue=false)]
        public decimal? Enrollment { get; set; }

        /// <summary>
        /// The year from which the enrollment of the Municipality was measured
        /// </summary>
        /// <value>The year from which the enrollment of the Municipality was measured</value>
        [DataMember(Name="enrollment_as_of_year", EmitDefaultValue=false)]
        public decimal? EnrollmentAsOfYear { get; set; }

        /// <summary>
        /// The name of the area of the Municipality
        /// </summary>
        /// <value>The name of the area of the Municipality</value>
        [DataMember(Name="area_name", EmitDefaultValue=false)]
        public string AreaName { get; set; }

        /// <summary>
        /// The type of area of the Municipality
        /// </summary>
        /// <value>The type of area of the Municipality</value>
        [DataMember(Name="area_type", EmitDefaultValue=false)]
        public string AreaType { get; set; }

        /// <summary>
        /// The latitude of the location of the Municipality
        /// </summary>
        /// <value>The latitude of the location of the Municipality</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public float? Latitude { get; set; }

        /// <summary>
        /// The longitude of the location of the Municipality
        /// </summary>
        /// <value>The longitude of the location of the Municipality</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public float? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Municipality {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CensusId: ").Append(CensusId).Append("\n");
            sb.Append("  GovernmentName: ").Append(GovernmentName).Append("\n");
            sb.Append("  GovernmentType: ").Append(GovernmentType).Append("\n");
            sb.Append("  PrimaryContactType: ").Append(PrimaryContactType).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
            sb.Append("  Population: ").Append(Population).Append("\n");
            sb.Append("  PopulationAsOfYear: ").Append(PopulationAsOfYear).Append("\n");
            sb.Append("  Enrollment: ").Append(Enrollment).Append("\n");
            sb.Append("  EnrollmentAsOfYear: ").Append(EnrollmentAsOfYear).Append("\n");
            sb.Append("  AreaName: ").Append(AreaName).Append("\n");
            sb.Append("  AreaType: ").Append(AreaType).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as Municipality);
        }

        /// <summary>
        /// Returns true if Municipality instances are equal
        /// </summary>
        /// <param name="input">Instance of Municipality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Municipality input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CensusId == input.CensusId ||
                    (this.CensusId != null &&
                    this.CensusId.Equals(input.CensusId))
                ) && 
                (
                    this.GovernmentName == input.GovernmentName ||
                    (this.GovernmentName != null &&
                    this.GovernmentName.Equals(input.GovernmentName))
                ) && 
                (
                    this.GovernmentType == input.GovernmentType ||
                    (this.GovernmentType != null &&
                    this.GovernmentType.Equals(input.GovernmentType))
                ) && 
                (
                    this.PrimaryContactType == input.PrimaryContactType ||
                    (this.PrimaryContactType != null &&
                    this.PrimaryContactType.Equals(input.PrimaryContactType))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
                ) && 
                (
                    this.Population == input.Population ||
                    (this.Population != null &&
                    this.Population.Equals(input.Population))
                ) && 
                (
                    this.PopulationAsOfYear == input.PopulationAsOfYear ||
                    (this.PopulationAsOfYear != null &&
                    this.PopulationAsOfYear.Equals(input.PopulationAsOfYear))
                ) && 
                (
                    this.Enrollment == input.Enrollment ||
                    (this.Enrollment != null &&
                    this.Enrollment.Equals(input.Enrollment))
                ) && 
                (
                    this.EnrollmentAsOfYear == input.EnrollmentAsOfYear ||
                    (this.EnrollmentAsOfYear != null &&
                    this.EnrollmentAsOfYear.Equals(input.EnrollmentAsOfYear))
                ) && 
                (
                    this.AreaName == input.AreaName ||
                    (this.AreaName != null &&
                    this.AreaName.Equals(input.AreaName))
                ) && 
                (
                    this.AreaType == input.AreaType ||
                    (this.AreaType != null &&
                    this.AreaType.Equals(input.AreaType))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CensusId != null)
                    hashCode = hashCode * 59 + this.CensusId.GetHashCode();
                if (this.GovernmentName != null)
                    hashCode = hashCode * 59 + this.GovernmentName.GetHashCode();
                if (this.GovernmentType != null)
                    hashCode = hashCode * 59 + this.GovernmentType.GetHashCode();
                if (this.PrimaryContactType != null)
                    hashCode = hashCode * 59 + this.PrimaryContactType.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.WebSite != null)
                    hashCode = hashCode * 59 + this.WebSite.GetHashCode();
                if (this.Population != null)
                    hashCode = hashCode * 59 + this.Population.GetHashCode();
                if (this.PopulationAsOfYear != null)
                    hashCode = hashCode * 59 + this.PopulationAsOfYear.GetHashCode();
                if (this.Enrollment != null)
                    hashCode = hashCode * 59 + this.Enrollment.GetHashCode();
                if (this.EnrollmentAsOfYear != null)
                    hashCode = hashCode * 59 + this.EnrollmentAsOfYear.GetHashCode();
                if (this.AreaName != null)
                    hashCode = hashCode * 59 + this.AreaName.GetHashCode();
                if (this.AreaType != null)
                    hashCode = hashCode * 59 + this.AreaType.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
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

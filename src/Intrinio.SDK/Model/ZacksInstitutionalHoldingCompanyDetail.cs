

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
    /// Returns a list of companies with its shares and positions sourced from Zacks.
    /// </summary>
    [DataContract]
    public partial class ZacksInstitutionalHoldingCompanyDetail :  IEquatable<ZacksInstitutionalHoldingCompanyDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksInstitutionalHoldingCompanyDetail" /> class.
        /// </summary>
        /// <param name="Ticker">The Zacks common exchange ticker.</param>
        /// <param name="Name">The company name of the stock listed.</param>
        /// <param name="Exchange">Exhange where the stock is traded whose shares are held by the institution.</param>
        /// <param name="SharesOutstanding">The number of shares shares outstanding for the stock.</param>
        /// <param name="LastClosePrice">The last close price of the stock listed.</param>
        /// <param name="LastCloseDate">Last closing price of the stock listed.</param>
        /// <param name="InstitutionalSharesHeldPercent">Percentage of shares outstanding held by institutions in the stock listed.</param>
        /// <param name="InstitutionalSharesBuy">Number of shares bought by institutions in the stock listed.</param>
        /// <param name="InstitutionalSharesSell">Number of shares sold by institutions in the stock listed.</param>
        /// <param name="InstitutionalPositionsIncrease">Number of institutions who increased their shares held in the stock listed.</param>
        /// <param name="InstitutionalPositionsDecrease">Number of institutions who decrease their shares held in the stock listed.</param>
        /// <param name="InstitutionalPositionsUnchanged">Number of institutions who did not change their shares held in the stock listed.</param>
        /// <param name="InstitutionalPositionsTotal">Total number of institutions who hold shares in the stock listed.</param>
        public ZacksInstitutionalHoldingCompanyDetail(string Ticker = default(string), string Name = default(string), string Exchange = default(string), decimal? SharesOutstanding = default(decimal?), decimal? LastClosePrice = default(decimal?), DateTime? LastCloseDate = default(DateTime?), decimal? InstitutionalSharesHeldPercent = default(decimal?), decimal? InstitutionalSharesBuy = default(decimal?), decimal? InstitutionalSharesSell = default(decimal?), decimal? InstitutionalPositionsIncrease = default(decimal?), decimal? InstitutionalPositionsDecrease = default(decimal?), decimal? InstitutionalPositionsUnchanged = default(decimal?), decimal? InstitutionalPositionsTotal = default(decimal?))
        {
            this.Ticker = Ticker;
            this.Name = Name;
            this.Exchange = Exchange;
            this.SharesOutstanding = SharesOutstanding;
            this.LastClosePrice = LastClosePrice;
            this.LastCloseDate = LastCloseDate;
            this.InstitutionalSharesHeldPercent = InstitutionalSharesHeldPercent;
            this.InstitutionalSharesBuy = InstitutionalSharesBuy;
            this.InstitutionalSharesSell = InstitutionalSharesSell;
            this.InstitutionalPositionsIncrease = InstitutionalPositionsIncrease;
            this.InstitutionalPositionsDecrease = InstitutionalPositionsDecrease;
            this.InstitutionalPositionsUnchanged = InstitutionalPositionsUnchanged;
            this.InstitutionalPositionsTotal = InstitutionalPositionsTotal;
        }
        
        /// <summary>
        /// The Zacks common exchange ticker
        /// </summary>
        /// <value>The Zacks common exchange ticker</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// The company name of the stock listed
        /// </summary>
        /// <value>The company name of the stock listed</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Exhange where the stock is traded whose shares are held by the institution
        /// </summary>
        /// <value>Exhange where the stock is traded whose shares are held by the institution</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// The number of shares shares outstanding for the stock
        /// </summary>
        /// <value>The number of shares shares outstanding for the stock</value>
        [DataMember(Name="shares_outstanding", EmitDefaultValue=false)]
        public decimal? SharesOutstanding { get; set; }

        /// <summary>
        /// The last close price of the stock listed
        /// </summary>
        /// <value>The last close price of the stock listed</value>
        [DataMember(Name="last_close_price", EmitDefaultValue=false)]
        public decimal? LastClosePrice { get; set; }

        /// <summary>
        /// Last closing price of the stock listed
        /// </summary>
        /// <value>Last closing price of the stock listed</value>
        [DataMember(Name="last_close_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastCloseDate { get; set; }

        /// <summary>
        /// Percentage of shares outstanding held by institutions in the stock listed
        /// </summary>
        /// <value>Percentage of shares outstanding held by institutions in the stock listed</value>
        [DataMember(Name="institutional_shares_held_percent", EmitDefaultValue=false)]
        public decimal? InstitutionalSharesHeldPercent { get; set; }

        /// <summary>
        /// Number of shares bought by institutions in the stock listed
        /// </summary>
        /// <value>Number of shares bought by institutions in the stock listed</value>
        [DataMember(Name="institutional_shares_buy", EmitDefaultValue=false)]
        public decimal? InstitutionalSharesBuy { get; set; }

        /// <summary>
        /// Number of shares sold by institutions in the stock listed
        /// </summary>
        /// <value>Number of shares sold by institutions in the stock listed</value>
        [DataMember(Name="institutional_shares_sell", EmitDefaultValue=false)]
        public decimal? InstitutionalSharesSell { get; set; }

        /// <summary>
        /// Number of institutions who increased their shares held in the stock listed
        /// </summary>
        /// <value>Number of institutions who increased their shares held in the stock listed</value>
        [DataMember(Name="institutional_positions_increase", EmitDefaultValue=false)]
        public decimal? InstitutionalPositionsIncrease { get; set; }

        /// <summary>
        /// Number of institutions who decrease their shares held in the stock listed
        /// </summary>
        /// <value>Number of institutions who decrease their shares held in the stock listed</value>
        [DataMember(Name="institutional_positions_decrease", EmitDefaultValue=false)]
        public decimal? InstitutionalPositionsDecrease { get; set; }

        /// <summary>
        /// Number of institutions who did not change their shares held in the stock listed
        /// </summary>
        /// <value>Number of institutions who did not change their shares held in the stock listed</value>
        [DataMember(Name="institutional_positions_unchanged", EmitDefaultValue=false)]
        public decimal? InstitutionalPositionsUnchanged { get; set; }

        /// <summary>
        /// Total number of institutions who hold shares in the stock listed
        /// </summary>
        /// <value>Total number of institutions who hold shares in the stock listed</value>
        [DataMember(Name="institutional_positions_total", EmitDefaultValue=false)]
        public decimal? InstitutionalPositionsTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksInstitutionalHoldingCompanyDetail {\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  SharesOutstanding: ").Append(SharesOutstanding).Append("\n");
            sb.Append("  LastClosePrice: ").Append(LastClosePrice).Append("\n");
            sb.Append("  LastCloseDate: ").Append(LastCloseDate).Append("\n");
            sb.Append("  InstitutionalSharesHeldPercent: ").Append(InstitutionalSharesHeldPercent).Append("\n");
            sb.Append("  InstitutionalSharesBuy: ").Append(InstitutionalSharesBuy).Append("\n");
            sb.Append("  InstitutionalSharesSell: ").Append(InstitutionalSharesSell).Append("\n");
            sb.Append("  InstitutionalPositionsIncrease: ").Append(InstitutionalPositionsIncrease).Append("\n");
            sb.Append("  InstitutionalPositionsDecrease: ").Append(InstitutionalPositionsDecrease).Append("\n");
            sb.Append("  InstitutionalPositionsUnchanged: ").Append(InstitutionalPositionsUnchanged).Append("\n");
            sb.Append("  InstitutionalPositionsTotal: ").Append(InstitutionalPositionsTotal).Append("\n");
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
            return this.Equals(input as ZacksInstitutionalHoldingCompanyDetail);
        }

        /// <summary>
        /// Returns true if ZacksInstitutionalHoldingCompanyDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksInstitutionalHoldingCompanyDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksInstitutionalHoldingCompanyDetail input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.SharesOutstanding == input.SharesOutstanding ||
                    (this.SharesOutstanding != null &&
                    this.SharesOutstanding.Equals(input.SharesOutstanding))
                ) && 
                (
                    this.LastClosePrice == input.LastClosePrice ||
                    (this.LastClosePrice != null &&
                    this.LastClosePrice.Equals(input.LastClosePrice))
                ) && 
                (
                    this.LastCloseDate == input.LastCloseDate ||
                    (this.LastCloseDate != null &&
                    this.LastCloseDate.Equals(input.LastCloseDate))
                ) && 
                (
                    this.InstitutionalSharesHeldPercent == input.InstitutionalSharesHeldPercent ||
                    (this.InstitutionalSharesHeldPercent != null &&
                    this.InstitutionalSharesHeldPercent.Equals(input.InstitutionalSharesHeldPercent))
                ) && 
                (
                    this.InstitutionalSharesBuy == input.InstitutionalSharesBuy ||
                    (this.InstitutionalSharesBuy != null &&
                    this.InstitutionalSharesBuy.Equals(input.InstitutionalSharesBuy))
                ) && 
                (
                    this.InstitutionalSharesSell == input.InstitutionalSharesSell ||
                    (this.InstitutionalSharesSell != null &&
                    this.InstitutionalSharesSell.Equals(input.InstitutionalSharesSell))
                ) && 
                (
                    this.InstitutionalPositionsIncrease == input.InstitutionalPositionsIncrease ||
                    (this.InstitutionalPositionsIncrease != null &&
                    this.InstitutionalPositionsIncrease.Equals(input.InstitutionalPositionsIncrease))
                ) && 
                (
                    this.InstitutionalPositionsDecrease == input.InstitutionalPositionsDecrease ||
                    (this.InstitutionalPositionsDecrease != null &&
                    this.InstitutionalPositionsDecrease.Equals(input.InstitutionalPositionsDecrease))
                ) && 
                (
                    this.InstitutionalPositionsUnchanged == input.InstitutionalPositionsUnchanged ||
                    (this.InstitutionalPositionsUnchanged != null &&
                    this.InstitutionalPositionsUnchanged.Equals(input.InstitutionalPositionsUnchanged))
                ) && 
                (
                    this.InstitutionalPositionsTotal == input.InstitutionalPositionsTotal ||
                    (this.InstitutionalPositionsTotal != null &&
                    this.InstitutionalPositionsTotal.Equals(input.InstitutionalPositionsTotal))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.SharesOutstanding != null)
                    hashCode = hashCode * 59 + this.SharesOutstanding.GetHashCode();
                if (this.LastClosePrice != null)
                    hashCode = hashCode * 59 + this.LastClosePrice.GetHashCode();
                if (this.LastCloseDate != null)
                    hashCode = hashCode * 59 + this.LastCloseDate.GetHashCode();
                if (this.InstitutionalSharesHeldPercent != null)
                    hashCode = hashCode * 59 + this.InstitutionalSharesHeldPercent.GetHashCode();
                if (this.InstitutionalSharesBuy != null)
                    hashCode = hashCode * 59 + this.InstitutionalSharesBuy.GetHashCode();
                if (this.InstitutionalSharesSell != null)
                    hashCode = hashCode * 59 + this.InstitutionalSharesSell.GetHashCode();
                if (this.InstitutionalPositionsIncrease != null)
                    hashCode = hashCode * 59 + this.InstitutionalPositionsIncrease.GetHashCode();
                if (this.InstitutionalPositionsDecrease != null)
                    hashCode = hashCode * 59 + this.InstitutionalPositionsDecrease.GetHashCode();
                if (this.InstitutionalPositionsUnchanged != null)
                    hashCode = hashCode * 59 + this.InstitutionalPositionsUnchanged.GetHashCode();
                if (this.InstitutionalPositionsTotal != null)
                    hashCode = hashCode * 59 + this.InstitutionalPositionsTotal.GetHashCode();
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

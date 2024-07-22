

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
    /// Returns a list of institutional owners and the value of their interests sourced from Zacks.
    /// </summary>
    [DataContract]
    public partial class ZacksInstitutionalHoldingOwnerDetail :  IEquatable<ZacksInstitutionalHoldingOwnerDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZacksInstitutionalHoldingOwnerDetail" /> class.
        /// </summary>
        /// <param name="Name">The owner&#39;s name.</param>
        /// <param name="Cik">The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings.</param>
        /// <param name="Address">The owner&#39;s address.</param>
        /// <param name="CityState">The owner&#39;s city and state (City, ST).</param>
        /// <param name="LocationCode">The owner&#39;s location code. (&#39;D&#39; &#x3D; Domestic, &#39;C&#39; &#x3D; Canadian, &#39;F&#39; &#x3D; Foreign).</param>
        /// <param name="PhoneNumber">The owner&#39;s phone number.</param>
        /// <param name="PostalCode">The owner&#39;s postal code.</param>
        /// <param name="Url">The owner&#39;s website url.</param>
        /// <param name="InvestmentStyle">The owner&#39;s investment style (&#39;I&#39; &#x3D; Income, &#39;V&#39; &#x3D; Value, &#39;G&#39; &#x3D; Growth, &#39;B&#39; &#x3D;  Growth at a Reasonable Price, &#39;A&#39; &#x3D; Aggressive Growth, &#39;P&#39; &#x3D; Passive/Index, &#39;D&#39; &#x3D; Deep Value).</param>
        /// <param name="NumberOfHoldings">Count of equity holdings only, doesn&#39;t include bonds or other funds held.</param>
        /// <param name="TotalHoldingsValue">Market value of equity holdings in 1,000s. Sum of shares held times last close price..</param>
        /// <param name="PortfolioTurnoverPercent">Annual portfolio turnover in terms of percentage of total value..</param>
        /// <param name="IsFund">If &#39;Y&#39;, the owner is a fund? (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No).</param>
        /// <param name="FundTicker">Fund ticker if the institution is a fund.</param>
        /// <param name="HasFundManager">Does the fund have a manager. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No).</param>
        /// <param name="FundManagerCity">The fund manager&#39;s city.</param>
        /// <param name="FundManagerName">The fund manager&#39;s name.</param>
        /// <param name="FundManagerState">The fund manager&#39;s state.</param>
        /// <param name="Files13f">If &#39;Y&#39;, the company files the SEC 13F report. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No).</param>
        /// <param name="IsEtf">If &#39;Y&#39;, the owner is an ETF. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No).</param>
        /// <param name="LastUpdatedOn">The the last updated date.</param>
        public ZacksInstitutionalHoldingOwnerDetail(string Name = default(string), string Cik = default(string), string Address = default(string), string CityState = default(string), string LocationCode = default(string), string PhoneNumber = default(string), string PostalCode = default(string), string Url = default(string), string InvestmentStyle = default(string), decimal? NumberOfHoldings = default(decimal?), decimal? TotalHoldingsValue = default(decimal?), decimal? PortfolioTurnoverPercent = default(decimal?), string IsFund = default(string), string FundTicker = default(string), string HasFundManager = default(string), string FundManagerCity = default(string), string FundManagerName = default(string), string FundManagerState = default(string), string Files13f = default(string), string IsEtf = default(string), DateTime? LastUpdatedOn = default(DateTime?))
        {
            this.Name = Name;
            this.Cik = Cik;
            this.Address = Address;
            this.CityState = CityState;
            this.LocationCode = LocationCode;
            this.PhoneNumber = PhoneNumber;
            this.PostalCode = PostalCode;
            this.Url = Url;
            this.InvestmentStyle = InvestmentStyle;
            this.NumberOfHoldings = NumberOfHoldings;
            this.TotalHoldingsValue = TotalHoldingsValue;
            this.PortfolioTurnoverPercent = PortfolioTurnoverPercent;
            this.IsFund = IsFund;
            this.FundTicker = FundTicker;
            this.HasFundManager = HasFundManager;
            this.FundManagerCity = FundManagerCity;
            this.FundManagerName = FundManagerName;
            this.FundManagerState = FundManagerState;
            this.Files13f = Files13f;
            this.IsEtf = IsEtf;
            this.LastUpdatedOn = LastUpdatedOn;
        }
        
        /// <summary>
        /// The owner&#39;s name
        /// </summary>
        /// <value>The owner&#39;s name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings
        /// </summary>
        /// <value>The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings</value>
        [DataMember(Name="cik", EmitDefaultValue=false)]
        public string Cik { get; set; }

        /// <summary>
        /// The owner&#39;s address
        /// </summary>
        /// <value>The owner&#39;s address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The owner&#39;s city and state (City, ST)
        /// </summary>
        /// <value>The owner&#39;s city and state (City, ST)</value>
        [DataMember(Name="city_state", EmitDefaultValue=false)]
        public string CityState { get; set; }

        /// <summary>
        /// The owner&#39;s location code. (&#39;D&#39; &#x3D; Domestic, &#39;C&#39; &#x3D; Canadian, &#39;F&#39; &#x3D; Foreign)
        /// </summary>
        /// <value>The owner&#39;s location code. (&#39;D&#39; &#x3D; Domestic, &#39;C&#39; &#x3D; Canadian, &#39;F&#39; &#x3D; Foreign)</value>
        [DataMember(Name="location_code", EmitDefaultValue=false)]
        public string LocationCode { get; set; }

        /// <summary>
        /// The owner&#39;s phone number
        /// </summary>
        /// <value>The owner&#39;s phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The owner&#39;s postal code
        /// </summary>
        /// <value>The owner&#39;s postal code</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The owner&#39;s website url
        /// </summary>
        /// <value>The owner&#39;s website url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// The owner&#39;s investment style (&#39;I&#39; &#x3D; Income, &#39;V&#39; &#x3D; Value, &#39;G&#39; &#x3D; Growth, &#39;B&#39; &#x3D;  Growth at a Reasonable Price, &#39;A&#39; &#x3D; Aggressive Growth, &#39;P&#39; &#x3D; Passive/Index, &#39;D&#39; &#x3D; Deep Value)
        /// </summary>
        /// <value>The owner&#39;s investment style (&#39;I&#39; &#x3D; Income, &#39;V&#39; &#x3D; Value, &#39;G&#39; &#x3D; Growth, &#39;B&#39; &#x3D;  Growth at a Reasonable Price, &#39;A&#39; &#x3D; Aggressive Growth, &#39;P&#39; &#x3D; Passive/Index, &#39;D&#39; &#x3D; Deep Value)</value>
        [DataMember(Name="investment_style", EmitDefaultValue=false)]
        public string InvestmentStyle { get; set; }

        /// <summary>
        /// Count of equity holdings only, doesn&#39;t include bonds or other funds held
        /// </summary>
        /// <value>Count of equity holdings only, doesn&#39;t include bonds or other funds held</value>
        [DataMember(Name="number_of_holdings", EmitDefaultValue=false)]
        public decimal? NumberOfHoldings { get; set; }

        /// <summary>
        /// Market value of equity holdings in 1,000s. Sum of shares held times last close price.
        /// </summary>
        /// <value>Market value of equity holdings in 1,000s. Sum of shares held times last close price.</value>
        [DataMember(Name="total_holdings_value", EmitDefaultValue=false)]
        public decimal? TotalHoldingsValue { get; set; }

        /// <summary>
        /// Annual portfolio turnover in terms of percentage of total value.
        /// </summary>
        /// <value>Annual portfolio turnover in terms of percentage of total value.</value>
        [DataMember(Name="portfolio_turnover_percent", EmitDefaultValue=false)]
        public decimal? PortfolioTurnoverPercent { get; set; }

        /// <summary>
        /// If &#39;Y&#39;, the owner is a fund? (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)
        /// </summary>
        /// <value>If &#39;Y&#39;, the owner is a fund? (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)</value>
        [DataMember(Name="is_fund", EmitDefaultValue=false)]
        public string IsFund { get; set; }

        /// <summary>
        /// Fund ticker if the institution is a fund
        /// </summary>
        /// <value>Fund ticker if the institution is a fund</value>
        [DataMember(Name="fund_ticker", EmitDefaultValue=false)]
        public string FundTicker { get; set; }

        /// <summary>
        /// Does the fund have a manager. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)
        /// </summary>
        /// <value>Does the fund have a manager. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)</value>
        [DataMember(Name="has_fund_manager", EmitDefaultValue=false)]
        public string HasFundManager { get; set; }

        /// <summary>
        /// The fund manager&#39;s city
        /// </summary>
        /// <value>The fund manager&#39;s city</value>
        [DataMember(Name="fund_manager_city", EmitDefaultValue=false)]
        public string FundManagerCity { get; set; }

        /// <summary>
        /// The fund manager&#39;s name
        /// </summary>
        /// <value>The fund manager&#39;s name</value>
        [DataMember(Name="fund_manager_name", EmitDefaultValue=false)]
        public string FundManagerName { get; set; }

        /// <summary>
        /// The fund manager&#39;s state
        /// </summary>
        /// <value>The fund manager&#39;s state</value>
        [DataMember(Name="fund_manager_state", EmitDefaultValue=false)]
        public string FundManagerState { get; set; }

        /// <summary>
        /// If &#39;Y&#39;, the company files the SEC 13F report. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)
        /// </summary>
        /// <value>If &#39;Y&#39;, the company files the SEC 13F report. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)</value>
        [DataMember(Name="files_13f", EmitDefaultValue=false)]
        public string Files13f { get; set; }

        /// <summary>
        /// If &#39;Y&#39;, the owner is an ETF. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)
        /// </summary>
        /// <value>If &#39;Y&#39;, the owner is an ETF. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No)</value>
        [DataMember(Name="is_etf", EmitDefaultValue=false)]
        public string IsEtf { get; set; }

        /// <summary>
        /// The the last updated date
        /// </summary>
        /// <value>The the last updated date</value>
        [DataMember(Name="last_updated_on", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastUpdatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZacksInstitutionalHoldingOwnerDetail {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Cik: ").Append(Cik).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CityState: ").Append(CityState).Append("\n");
            sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  InvestmentStyle: ").Append(InvestmentStyle).Append("\n");
            sb.Append("  NumberOfHoldings: ").Append(NumberOfHoldings).Append("\n");
            sb.Append("  TotalHoldingsValue: ").Append(TotalHoldingsValue).Append("\n");
            sb.Append("  PortfolioTurnoverPercent: ").Append(PortfolioTurnoverPercent).Append("\n");
            sb.Append("  IsFund: ").Append(IsFund).Append("\n");
            sb.Append("  FundTicker: ").Append(FundTicker).Append("\n");
            sb.Append("  HasFundManager: ").Append(HasFundManager).Append("\n");
            sb.Append("  FundManagerCity: ").Append(FundManagerCity).Append("\n");
            sb.Append("  FundManagerName: ").Append(FundManagerName).Append("\n");
            sb.Append("  FundManagerState: ").Append(FundManagerState).Append("\n");
            sb.Append("  Files13f: ").Append(Files13f).Append("\n");
            sb.Append("  IsEtf: ").Append(IsEtf).Append("\n");
            sb.Append("  LastUpdatedOn: ").Append(LastUpdatedOn).Append("\n");
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
            return this.Equals(input as ZacksInstitutionalHoldingOwnerDetail);
        }

        /// <summary>
        /// Returns true if ZacksInstitutionalHoldingOwnerDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ZacksInstitutionalHoldingOwnerDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZacksInstitutionalHoldingOwnerDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Cik == input.Cik ||
                    (this.Cik != null &&
                    this.Cik.Equals(input.Cik))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CityState == input.CityState ||
                    (this.CityState != null &&
                    this.CityState.Equals(input.CityState))
                ) && 
                (
                    this.LocationCode == input.LocationCode ||
                    (this.LocationCode != null &&
                    this.LocationCode.Equals(input.LocationCode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.InvestmentStyle == input.InvestmentStyle ||
                    (this.InvestmentStyle != null &&
                    this.InvestmentStyle.Equals(input.InvestmentStyle))
                ) && 
                (
                    this.NumberOfHoldings == input.NumberOfHoldings ||
                    (this.NumberOfHoldings != null &&
                    this.NumberOfHoldings.Equals(input.NumberOfHoldings))
                ) && 
                (
                    this.TotalHoldingsValue == input.TotalHoldingsValue ||
                    (this.TotalHoldingsValue != null &&
                    this.TotalHoldingsValue.Equals(input.TotalHoldingsValue))
                ) && 
                (
                    this.PortfolioTurnoverPercent == input.PortfolioTurnoverPercent ||
                    (this.PortfolioTurnoverPercent != null &&
                    this.PortfolioTurnoverPercent.Equals(input.PortfolioTurnoverPercent))
                ) && 
                (
                    this.IsFund == input.IsFund ||
                    (this.IsFund != null &&
                    this.IsFund.Equals(input.IsFund))
                ) && 
                (
                    this.FundTicker == input.FundTicker ||
                    (this.FundTicker != null &&
                    this.FundTicker.Equals(input.FundTicker))
                ) && 
                (
                    this.HasFundManager == input.HasFundManager ||
                    (this.HasFundManager != null &&
                    this.HasFundManager.Equals(input.HasFundManager))
                ) && 
                (
                    this.FundManagerCity == input.FundManagerCity ||
                    (this.FundManagerCity != null &&
                    this.FundManagerCity.Equals(input.FundManagerCity))
                ) && 
                (
                    this.FundManagerName == input.FundManagerName ||
                    (this.FundManagerName != null &&
                    this.FundManagerName.Equals(input.FundManagerName))
                ) && 
                (
                    this.FundManagerState == input.FundManagerState ||
                    (this.FundManagerState != null &&
                    this.FundManagerState.Equals(input.FundManagerState))
                ) && 
                (
                    this.Files13f == input.Files13f ||
                    (this.Files13f != null &&
                    this.Files13f.Equals(input.Files13f))
                ) && 
                (
                    this.IsEtf == input.IsEtf ||
                    (this.IsEtf != null &&
                    this.IsEtf.Equals(input.IsEtf))
                ) && 
                (
                    this.LastUpdatedOn == input.LastUpdatedOn ||
                    (this.LastUpdatedOn != null &&
                    this.LastUpdatedOn.Equals(input.LastUpdatedOn))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Cik != null)
                    hashCode = hashCode * 59 + this.Cik.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.CityState != null)
                    hashCode = hashCode * 59 + this.CityState.GetHashCode();
                if (this.LocationCode != null)
                    hashCode = hashCode * 59 + this.LocationCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.InvestmentStyle != null)
                    hashCode = hashCode * 59 + this.InvestmentStyle.GetHashCode();
                if (this.NumberOfHoldings != null)
                    hashCode = hashCode * 59 + this.NumberOfHoldings.GetHashCode();
                if (this.TotalHoldingsValue != null)
                    hashCode = hashCode * 59 + this.TotalHoldingsValue.GetHashCode();
                if (this.PortfolioTurnoverPercent != null)
                    hashCode = hashCode * 59 + this.PortfolioTurnoverPercent.GetHashCode();
                if (this.IsFund != null)
                    hashCode = hashCode * 59 + this.IsFund.GetHashCode();
                if (this.FundTicker != null)
                    hashCode = hashCode * 59 + this.FundTicker.GetHashCode();
                if (this.HasFundManager != null)
                    hashCode = hashCode * 59 + this.HasFundManager.GetHashCode();
                if (this.FundManagerCity != null)
                    hashCode = hashCode * 59 + this.FundManagerCity.GetHashCode();
                if (this.FundManagerName != null)
                    hashCode = hashCode * 59 + this.FundManagerName.GetHashCode();
                if (this.FundManagerState != null)
                    hashCode = hashCode * 59 + this.FundManagerState.GetHashCode();
                if (this.Files13f != null)
                    hashCode = hashCode * 59 + this.Files13f.GetHashCode();
                if (this.IsEtf != null)
                    hashCode = hashCode * 59 + this.IsEtf.GetHashCode();
                if (this.LastUpdatedOn != null)
                    hashCode = hashCode * 59 + this.LastUpdatedOn.GetHashCode();
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

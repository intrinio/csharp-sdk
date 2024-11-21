[//]: # (CLASS:Intrinio.SDK.Model.ZacksInstitutionalHoldingOwnerDetail)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ZacksInstitutionalHoldingOwnerDetail
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Name** | string | The owner&#39;s name &nbsp;
**Cik** | string | The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings &nbsp;
**Address** | string | The owner&#39;s address &nbsp;
**CityState** | string | The owner&#39;s city and state (City, ST) &nbsp;
**LocationCode** | string | The owner&#39;s location code. (&#39;D&#39; &#x3D; Domestic, &#39;C&#39; &#x3D; Canadian, &#39;F&#39; &#x3D; Foreign) &nbsp;
**PhoneNumber** | string | The owner&#39;s phone number &nbsp;
**PostalCode** | string | The owner&#39;s postal code &nbsp;
**Url** | string | The owner&#39;s website url &nbsp;
**InvestmentStyle** | string | The owner&#39;s investment style (&#39;I&#39; &#x3D; Income, &#39;V&#39; &#x3D; Value, &#39;G&#39; &#x3D; Growth, &#39;B&#39; &#x3D;  Growth at a Reasonable Price, &#39;A&#39; &#x3D; Aggressive Growth, &#39;P&#39; &#x3D; Passive/Index, &#39;D&#39; &#x3D; Deep Value) &nbsp;
**NumberOfHoldings** | decimal? | Count of equity holdings only, doesn&#39;t include bonds or other funds held &nbsp;
**TotalHoldingsValue** | decimal? | Market value of equity holdings in 1,000s. Sum of shares held times last close price. &nbsp;
**PortfolioTurnoverPercent** | decimal? | Annual portfolio turnover in terms of percentage of total value. &nbsp;
**IsFund** | string | If &#39;Y&#39;, the owner is a fund? (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No) &nbsp;
**FundTicker** | string | Fund ticker if the institution is a fund &nbsp;
**HasFundManager** | string | Does the fund have a manager. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No) &nbsp;
**FundManagerCity** | string | The fund manager&#39;s city &nbsp;
**FundManagerName** | string | The fund manager&#39;s name &nbsp;
**FundManagerState** | string | The fund manager&#39;s state &nbsp;
**Files13f** | string | If &#39;Y&#39;, the company files the SEC 13F report. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No) &nbsp;
**IsEtf** | string | If &#39;Y&#39;, the owner is an ETF. (&#39;Y&#39; &#x3D; Yes, &#39;N&#39; &#x3D; No) &nbsp;
**LastUpdatedOn** | DateTime? | The the last updated date &nbsp;

[//]: # (END_DEFINITION)



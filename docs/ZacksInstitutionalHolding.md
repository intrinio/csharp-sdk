[//]: # (CLASS:Intrinio.SDK.Model.ZacksInstitutionalHolding)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ZacksInstitutionalHolding
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Company** | [**ZacksInstitutionalHoldingCompanySummary**](ZacksInstitutionalHoldingCompanySummary.md) |  &nbsp;
**Owner** | [**ZacksInstitutionalHoldingOwnerSummary**](ZacksInstitutionalHoldingOwnerSummary.md) |  &nbsp;
**AsOfDate** | DateTime? | Quarter end date listed in the most recent 13F report filed by the institution &nbsp;
**SharesHeld** | decimal? | Number of shares of the stock listed &nbsp;
**SharedHeldPercent** | decimal? | Percent of shares outstanding held of the stock by the institution listed &nbsp;
**SharesChange** | decimal? | Change in shares of the stock held by the institution listed &nbsp;
**SharesChangePercent** | decimal? | Percentage change in shares of the stock held by the institution listed &nbsp;
**MarketValue** | decimal? | Market value of shares outstanding held of the stock listed &nbsp;
**MarketValueChange** | decimal? | Change in market value shares of the stock listed &nbsp;
**LastSecFilingType** | string | The report type of the latest SEC filing &nbsp;
**LastSecFilingDate** | DateTime? | The date of the latest SEC filing &nbsp;
**LastSecFilingShares** | decimal? | The &nbsp;
**HistoricalHoldings** | [**List&lt;ZacksInstitutionalHoldingHistoricalSummary&gt;**](ZacksInstitutionalHoldingHistoricalSummary.md) |  &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ZacksInstitutionalHoldingCompanySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ZacksInstitutionalHoldingOwnerSummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ZacksInstitutionalHoldingHistoricalSummary)



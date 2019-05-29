[//]: # (CLASS:Intrinio.SDK.Model.ZacksSalesSurpriseSummary)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ZacksSalesSurpriseSummary
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID for the record &nbsp;
**FiscalYear** | decimal? | The company’s fiscal year for the reported period &nbsp;
**FiscalQuarter** | string | The company’s fiscal quarter for the reported period &nbsp;
**CalendarYear** | decimal? | The closest calendar year for the company’s fiscal year &nbsp;
**CalendarQuarter** | string | The closest calendar quarter for the company’s fiscal year &nbsp;
**ActualReportedDate** | DateTime? | The actual report date for the earnings release &nbsp;
**ActualReportedTime** | string | The actual report time for the earnings release &nbsp;
**ActualReportedCode** | string | The code cooresponding to the earnings release  BTO &#x3D; BEFORE THE OPEN | DTM &#x3D; DURING THE MARKET | AMC &#x3D; AFTER MARKET CLOSE &nbsp;
**ActualReportedDesc** | string | The description for the type of earnings release &nbsp;
**LastRevDate** | DateTime? | The last revision date for the analyst estimates &nbsp;
**SalesActual** | decimal? | The actual Non-GAAP sales figure released by the company, interpreted by Zacks. &nbsp;
**SalesActualZacksAdj** | decimal? | The adjustments Zacks made to get to Non-GAAP sales to reconcile with GAAP sales. &nbsp;
**SalesActualGaap** | decimal? | The actual GAAP sales figured released by the company &nbsp;
**SalesMeanEstimate** | decimal? | The pre-earnings release mean sales estimate for the company sales_count_estimate; the pre-earnings release number of estimates by analysts &nbsp;
**SalesAmountDiff** | decimal? | The sales surprise amount difference &nbsp;
**SalesPercentDiff** | decimal? | The sales surprise percent difference &nbsp;
**SalesStdDevEstimate** | decimal? | The pre-earnings release standard deviation of sales estimates &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security of the Zacks Sales Surprise &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



[//]: # (CLASS:Intrinio.SDK.Model.ZacksEPSSurpriseSummary)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ZacksEPSSurpriseSummary
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
**EpsActual** | decimal? | The actual Non-GAAP EPS figure released by the company, interpreted by Zacks. &nbsp;
**EpsActualZacksAdj** | decimal? | The adjustments Zacks made to get to Non-GAAP EPS to reconcile with GAAP EPS. &nbsp;
**EpsMeanEstimate** | decimal? | The pre-earnings release mean EPS estimate for the company &nbsp;
**EpsAmountDiff** | decimal? | The EPS surprise amount difference &nbsp;
**EpsPercentDiff** | decimal? | The EPS surprise percent difference &nbsp;
**EpsCountEstimate** | decimal? | The pre-earnings release number of estimates by analysts &nbsp;
**EpsStdDevEstimate** | decimal? | The pre-earnings release standard deviation of EPS estimates &nbsp;

[//]: # (END_DEFINITION)



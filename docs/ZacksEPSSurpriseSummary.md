## Intrinio.SDK.Model.ZacksEPSSurpriseSummary
### Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Intrinio ID for the record | [optional] 
**FiscalYear** | **decimal?** | The company’s fiscal year for the reported period | [optional] 
**FiscalQuarter** | **string** | The company’s fiscal quarter for the reported period | [optional] 
**CalendarYear** | **decimal?** | The closest calendar year for the company’s fiscal year | [optional] 
**CalendarQuarter** | **string** | The closest calendar quarter for the company’s fiscal year | [optional] 
**ActualReportedDate** | **DateTime?** | The actual report date for the earnings release | [optional] 
**ActualReportedTime** | **string** | The actual report time for the earnings release | [optional] 
**ActualReportedCode** | **string** | The code cooresponding to the earnings release  BTO &#x3D; BEFORE THE OPEN | DTM &#x3D; DURING THE MARKET | AMC &#x3D; AFTER MARKET CLOSE | [optional] 
**ActualReportedDesc** | **string** | The description for the type of earnings release | [optional] 
**EpsActual** | **decimal?** | The actual Non-GAAP EPS figure released by the company, interpreted by Zacks. | [optional] 
**EpsActualZacksAdj** | **decimal?** | The adjustments Zacks made to get to Non-GAAP EPS to reconcile with GAAP EPS. | [optional] 
**EpsMeanEstimate** | **decimal?** | The pre-earnings release mean EPS estimate for the company | [optional] 
**EpsAmountDiff** | **decimal?** | The EPS surprise amount difference | [optional] 
**EpsPercentDiff** | **decimal?** | The EPS surprise percent difference | [optional] 
**EpsCountEstimate** | **decimal?** | The pre-earnings release number of estimates by analysts | [optional] 
**EpsStdDevEstimate** | **decimal?** | The pre-earnings release standard deviation of EPS estimates | [optional] 


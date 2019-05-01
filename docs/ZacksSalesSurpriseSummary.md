# Intrinio.SDK.Model.ZacksSalesSurpriseSummary
## Properties

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
**LastRevDate** | **DateTime?** | The last revision date for the analyst estimates | [optional] 
**SalesActual** | **decimal?** | The actual Non-GAAP sales figure released by the company, interpreted by Zacks. | [optional] 
**SalesActualZacksAdj** | **decimal?** | The adjustments Zacks made to get to Non-GAAP sales to reconcile with GAAP sales. | [optional] 
**SalesActualGaap** | **decimal?** | The actual GAAP sales figured released by the company | [optional] 
**SalesMeanEstimate** | **decimal?** | The pre-earnings release mean sales estimate for the company sales_count_estimate; the pre-earnings release number of estimates by analysts | [optional] 
**SalesAmountDiff** | **decimal?** | The sales surprise amount difference | [optional] 
**SalesPercentDiff** | **decimal?** | The sales surprise percent difference | [optional] 
**SalesStdDevEstimate** | **decimal?** | The pre-earnings release standard deviation of sales estimates | [optional] 
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security of the Zacks Sales Surprise | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


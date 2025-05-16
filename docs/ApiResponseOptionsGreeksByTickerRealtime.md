[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseOptionsGreeksByTickerRealtime)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseOptionsGreeksByTickerRealtime
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security resolved from the given identifier &nbsp;
**NextPage** | string | The token required to request the next page of the data. If null, no further results are available. &nbsp;
**Messages** | List&lt;string&gt; | Any messages or warnings about the data &nbsp;
**Contracts** | [**List&lt;ApiResponseOptionsGreekContractRealtime&gt;**](ApiResponseOptionsGreekContractRealtime.md) | The options greeks data for this security &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ApiResponseOptionsGreekContractRealtime)



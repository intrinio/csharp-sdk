[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseSecurityTradingStatus)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseSecurityTradingStatus
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**TradingStatus** | string | The trading status of the security. &nbsp;
**TradingStatusReason** | string | The exchange supplied reason for its current status. &nbsp;
**TradingStatusUpdatedOn** | DateTime? | The time the exchange reported that it changed its trading status. &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security resolved from the given identifier &nbsp;
**MarketStatus** | string | The status of the market. &nbsp;
**Messages** | List&lt;string&gt; | A list of messages related to the request, such as warnings or errors. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



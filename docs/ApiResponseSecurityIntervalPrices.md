[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseSecurityIntervalPrices)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseSecurityIntervalPrices
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Intervals** | [**List&lt;StockPriceInterval&gt;**](StockPriceInterval.md) | Open, close, high, low, volume, average price, and change ratio for a particular interval &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security resolved from the given identifier &nbsp;
**Source** | string | The source of the data &nbsp;
**NextPage** | string | The token required to request the next page of the data. If null, no further results are available. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.StockPriceInterval)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



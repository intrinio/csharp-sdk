[//]: # (CLASS:Intrinio.SDK.Model.ETFHistoricalStats)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ETFHistoricalStats
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Messages** | List&lt;string&gt; | A list of messages related to the request, such as warnings or errors. &nbsp;
**Etf** | [**ETFSummary**](ETFSummary.md) | A brief summary of the ETF it which these stats refer.  Not included when returning historical stats. &nbsp;
**Stats** | [**List&lt;ETFStats&gt;**](ETFStats.md) | The historical stats for the ETF &nbsp;
**NextPage** | string | The token required to request the next page of the data. If null, no further results are available. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ETFSummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ETFStats)



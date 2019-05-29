[//]: # (CLASS:Intrinio.SDK.Model.ZacksAnalystRating)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ZacksAnalystRating
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID for the record &nbsp;
**Date** | DateTime? | The date of the Zacks Analyst Rating. &nbsp;
**Mean** | decimal? | The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell). &nbsp;
**StrongBuys** | int? | The number of analysts recommending Strong Buy. &nbsp;
**Buys** | int? | The number of analysts recommending Buy. &nbsp;
**Holds** | int? | The number of analysts recommending Hold. &nbsp;
**Sells** | int? | The number of analysts recommending Sell. &nbsp;
**StrongSells** | int? | The number of analysts recommending Strong Sell. &nbsp;
**Total** | int? | The total number of analyst recommendations. &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security of the Zacks Analyst Rating &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



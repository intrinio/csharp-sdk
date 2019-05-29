[//]: # (CLASS:Intrinio.SDK.Model.ZacksAnalystRatingSnapshot)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ZacksAnalystRatingSnapshot
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Type** | string | The snapshot type, signifying the age of the ratings data from the snapshot date. &nbsp;
**SnapshotDate** | DateTime? | The date of the snapshot, when data was recorded. &nbsp;
**RatingDate** | DateTime? | The date of the latest rating for the snapshot timeframe. This is the effective date of the ratings data. &nbsp;
**Mean** | decimal? | The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell). &nbsp;
**Percentile** | decimal? | The percentile of the mean, derived by comparing to all securities rated by analysts as of the rating date, ranging 0.0 (strong buy) to 1.0 (strong sell). &nbsp;
**StrongBuys** | int? | The number of analysts recommending Strong Buy. &nbsp;
**Buys** | int? | The number of analysts recommending Buy. &nbsp;
**Holds** | int? | The number of analysts recommending Hold. &nbsp;
**Sells** | int? | The number of analysts recommending Sell. &nbsp;
**StrongSells** | int? | The number of analysts recommending Strong Sell. &nbsp;
**Total** | int? | The total number of analysts recommendations. &nbsp;

[//]: # (END_DEFINITION)



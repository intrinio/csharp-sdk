### Intrinio.SDK.Model.ZacksAnalystRatingSnapshot
#### Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The snapshot type, signifying the age of the ratings data from the snapshot date. | [optional] 
**SnapshotDate** | **DateTime?** | The date of the snapshot, when data was recorded. | [optional] 
**RatingDate** | **DateTime?** | The date of the latest rating for the snapshot timeframe. This is the effective date of the ratings data. | [optional] 
**Mean** | **decimal?** | The mean (average) weighing of analyst recommendations, from 1 (strong buy) to 5 (strong sell). | [optional] 
**Percentile** | **decimal?** | The percentile of the mean, derived by comparing to all securities rated by analysts as of the rating date, ranging 0.0 (strong buy) to 1.0 (strong sell). | [optional] 
**StrongBuys** | **int?** | The number of analysts recommending Strong Buy. | [optional] 
**Buys** | **int?** | The number of analysts recommending Buy. | [optional] 
**Holds** | **int?** | The number of analysts recommending Hold. | [optional] 
**Sells** | **int?** | The number of analysts recommending Sell. | [optional] 
**StrongSells** | **int?** | The number of analysts recommending Strong Sell. | [optional] 
**Total** | **int?** | The total number of analysts recommendations. | [optional] 


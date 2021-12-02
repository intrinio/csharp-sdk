[//]: # (CLASS:Intrinio.SDK.Model.OptionUnusualTrade)

[//]: # (KIND:object)

### Intrinio.SDK.Model.OptionUnusualTrade
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Symbol** | string | The underlying option security symbol for the trade &nbsp;
**Timestamp** | DateTime? | The UTC timestamp of order placement &nbsp;
**Type** | string | The type of unusual trade &nbsp;
**TotalValue** | decimal? | The aggregated value of all option contract premiums included in the trade\\ &nbsp;
**TotalSize** | decimal? | The total number of contracts involved in a single transaction &nbsp;
**AveragePrice** | decimal? | The average premium paid per option contract &nbsp;
**Contract** | string | The option contract symbol &nbsp;
**AskAtExecution** | decimal? | Ask price at execution &nbsp;
**BidAtExecution** | decimal? | Bid price at execution &nbsp;
**Sentiment** | string | Bullish, Bearish, or Neutral Sentiment is estimated based on whether the trade was executed at the bid, ask, or mark price. &nbsp;
**UnderlyingPriceAtExecution** | decimal? | Price of the underlying security at execution of trade &nbsp;

[//]: # (END_DEFINITION)



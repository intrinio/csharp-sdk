[//]: # (CLASS:Intrinio.SDK.Model.StockPriceAdjustmentSummary)

[//]: # (KIND:object)

### Intrinio.SDK.Model.StockPriceAdjustmentSummary
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Date** | DateTime? | The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date. &nbsp;
**Factor** | decimal? | The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices. &nbsp;
**Dividend** | decimal? | The dividend amount, if a dividend was paid. &nbsp;
**DividendCurrency** | string | The currency of the dividend, if known. &nbsp;
**SplitRatio** | decimal? | The ratio of the stock split, if a stock split occurred. &nbsp;

[//]: # (END_DEFINITION)



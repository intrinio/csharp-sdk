[//]: # (CLASS:Intrinio.SDK.Model.StockPriceSummary)

[//]: # (KIND:object)

### Intrinio.SDK.Model.StockPriceSummary
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Date** | DateTime? | The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc) &nbsp;
**Intraperiod** | bool? | If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period &nbsp;
**Frequency** | string | The type of period that the stock price represents &nbsp;
**Open** | decimal? | The price at the beginning of the period &nbsp;
**High** | decimal? | The highest price over the span of the period &nbsp;
**Low** | decimal? | The lowest price over the span of the period &nbsp;
**Close** | decimal? | The price at the end of the period &nbsp;
**Volume** | decimal? | The number of shares exchanged during the period &nbsp;
**AdjOpen** | decimal? | The price at the beginning of the period, adjusted for splits and dividends &nbsp;
**AdjHigh** | decimal? | The highest price over the span of the period, adjusted for splits and dividends &nbsp;
**AdjLow** | decimal? | The lowest price over the span of the period, adjusted for splits and dividends &nbsp;
**AdjClose** | decimal? | The price at the end of the period, adjusted for splits and dividends &nbsp;
**AdjVolume** | decimal? | The number of shares exchanged during the period, adjusted for splits and dividends &nbsp;
**Factor** | decimal? | The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices. &nbsp;
**SplitRatio** | decimal? | The ratio of the stock split, if a stock split occurred. &nbsp;
**Dividend** | decimal? | The dividend amount, if a dividend was paid. &nbsp;
**Change** | decimal? | The difference in price from the last price for this frequency &nbsp;
**PercentChange** | decimal? | The percent difference in price from the last price for this frequency &nbsp;
**FiftyTwoWeekHigh** | decimal? | The 52 week high price (daily only) &nbsp;
**FiftyTwoWeekLow** | decimal? | The 52 week low price (daily only) &nbsp;

[//]: # (END_DEFINITION)



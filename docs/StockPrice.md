[//]: # (CLASS:Intrinio.SDK.Model.StockPrice)

[//]: # (KIND:object)

### Intrinio.SDK.Model.StockPrice
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
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security of the stock price &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



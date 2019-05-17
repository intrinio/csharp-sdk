### Intrinio.SDK.Model.StockPriceSummary
#### Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | The calendar date that the stock price represents. For non-daily stock prices, this represents the last day in the period (end of the week, month, quarter, year, etc) | [optional] 
**Intraperiod** | **bool?** | If true, the stock price represents an unfinished period (be it day, week, quarter, month, or year), meaning that the close price is the latest price available, not the official close price for the period | [optional] 
**Frequency** | **string** | The type of period that the stock price represents | [optional] 
**Open** | **decimal?** | The price at the beginning of the period | [optional] 
**High** | **decimal?** | The highest price over the span of the period | [optional] 
**Low** | **decimal?** | The lowest price over the span of the period | [optional] 
**Close** | **decimal?** | The price at the end of the period | [optional] 
**Volume** | **decimal?** | The number of shares exchanged during the period | [optional] 
**AdjOpen** | **decimal?** | The price at the beginning of the period, adjusted for splits and dividends | [optional] 
**AdjHigh** | **decimal?** | The highest price over the span of the period, adjusted for splits and dividends | [optional] 
**AdjLow** | **decimal?** | The lowest price over the span of the period, adjusted for splits and dividends | [optional] 
**AdjClose** | **decimal?** | The price at the end of the period, adjusted for splits and dividends | [optional] 
**AdjVolume** | **decimal?** | The number of shares exchanged during the period, adjusted for splits and dividends | [optional] 


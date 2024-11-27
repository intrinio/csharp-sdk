[//]: # (CLASS:Intrinio.SDK.Model.StockPriceInterval)

[//]: # (KIND:object)

### Intrinio.SDK.Model.StockPriceInterval
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Time** | DateTime? | The timestamp that represents the start of the interval span. &nbsp;
**Open** | decimal? | The first traded price during the period &nbsp;
**Close** | decimal? | The last traded price during the period &nbsp;
**High** | decimal? | The highest price over the span of the period &nbsp;
**Low** | decimal? | The lowest price over the span of the period &nbsp;
**Volume** | decimal? | The number of shares exchanged during the period &nbsp;
**CloseTime** | DateTime? | The timestamp that represents the end of the interval span. &nbsp;
**Interval** | string | The size of the interval. &nbsp;
**Average** | decimal? | The average trade price of an individual stock during the interval. &nbsp;
**Change** | decimal? | The change ratio from open to close.  ((Close - Open)/Open). &nbsp;
**BidHigh** | decimal? | The highest bid price from the interval. &nbsp;
**BidLow** | decimal? | The lowest bid price from the interval. &nbsp;
**BidClose** | decimal? | The last bid price from the interval. &nbsp;
**BidOpen** | decimal? | The first bid price from the interval. &nbsp;
**BidFirstTime** | DateTime? | The timestamp that represents the first bid time from the interval span. &nbsp;
**BidLastTime** | DateTime? | The timestamp that represents the last bid time from the interval span. &nbsp;
**BidChangePercent** | decimal? | The ratio of the close to open bid difference, in percent. &nbsp;
**AskHigh** | decimal? | The highest ask price from the interval. &nbsp;
**AskLow** | decimal? | The lowest ask price from the interval. &nbsp;
**AskClose** | decimal? | The last ask price from the interval. &nbsp;
**AskOpen** | decimal? | The first ask price from the interval. &nbsp;
**AskFirstTime** | DateTime? | The timestamp that represents the first ask time from the interval span. &nbsp;
**AskLastTime** | DateTime? | The timestamp that represents the last ask time from the interval span. &nbsp;
**AskChangePercent** | decimal? | The ratio of the close to open ask difference, in percent. &nbsp;
**TradeCount** | decimal? | The number of qualified trades executed during the period &nbsp;

[//]: # (END_DEFINITION)



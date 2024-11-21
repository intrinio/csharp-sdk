[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseSecurityQuote)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseSecurityQuote
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Security** | [**SecuritySummary**](SecuritySummary.md) | The Security of the stock quote &nbsp;
**Last** | decimal? | The price of the latest trade &nbsp;
**LastTime** | DateTime? | The date and time when the last trade occurred. &nbsp;
**Source** | string | The source of the pricing data. &nbsp;
**Open** | decimal? | The open price from the latest day of trading. &nbsp;
**High** | decimal? | The highest price from the latest day of trading. &nbsp;
**Low** | decimal? | The lowest price from the latest day of trading. &nbsp;
**ExchangeVolume** | decimal? | The volume of the security from the source. &nbsp;
**MarketVolume** | decimal? | The volume of the security for the entire market. &nbsp;
**EodFiftyTwoWeekHigh** | decimal? | The 52 week high price. &nbsp;
**EodFiftyTwoWeekLow** | decimal? | The 52 week low price. &nbsp;
**Marketcap** | decimal? | The current market cap. &nbsp;
**Pricetoearnings** | decimal? | The current price to earnings. &nbsp;
**PreviousClose** | decimal? | The previous close price. &nbsp;
**PreviousCloseDate** | DateTime? | The date of the previous close. &nbsp;
**Change** | decimal? | The difference in last price from the last close price &nbsp;
**ChangePercent** | decimal? | The percent difference in last price from the last close price &nbsp;
**AdjClose5DaysAgo** | decimal? | The adjusted close price 5 days ago. &nbsp;
**AdjClose30DaysAgo** | decimal? | The adjusted close price 30 days ago. &nbsp;
**AdjClose90DaysAgo** | decimal? | The adjusted close price 90 days ago. &nbsp;
**AdjClose180DaysAgo** | decimal? | The adjusted close price 180 days ago. &nbsp;
**AdjClose365DaysAgo** | decimal? | The adjusted close price 365 days ago. &nbsp;
**AdjClose730DaysAgo** | decimal? | The adjusted close price 730 days ago. &nbsp;
**AdjClose1825DaysAgo** | decimal? | The adjusted close price 1825 days ago. &nbsp;
**AdjCloseYearToDate** | decimal? | The adjusted close price at the start of the calendar year. &nbsp;
**ChangePercent5Days** | decimal? | The percent change from the adjusted price 5 days ago to now. &nbsp;
**ChangePercent30Days** | decimal? | The percent change from the adjusted price 30 days ago to now. &nbsp;
**ChangePercent90Days** | decimal? | The percent change from the adjusted price 90 days ago to now. &nbsp;
**ChangePercent180Days** | decimal? | The percent change from the adjusted price 180 days ago to now. &nbsp;
**ChangePercent365Days** | decimal? | The percent change from the adjusted price 365 days ago to now. &nbsp;
**ChangePercent730DaysAgo** | decimal? | The percent change from the adjusted price 730 days ago to now. &nbsp;
**ChangePercent1825Days** | decimal? | The percent change from the adjusted price 1825 days ago to now. &nbsp;
**ChangePercentYearToDate** | decimal? | The percent change from the adjusted price since the start of the calendar year to now. &nbsp;
**ExtendedHoursLast** | decimal? | The price of the latest trade in pre and post market trading.  Might be null during normal trading &nbsp;
**ExtendedHoursChange** | decimal? | The difference in extended_hours_last price from most recent official close price &nbsp;
**ExtendedHoursChangePercent** | decimal? | The percent difference in extended_hours_last from the most recent official close price &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



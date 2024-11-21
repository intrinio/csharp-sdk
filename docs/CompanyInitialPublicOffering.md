[//]: # (CLASS:Intrinio.SDK.Model.CompanyInitialPublicOffering)

[//]: # (KIND:object)

### Intrinio.SDK.Model.CompanyInitialPublicOffering
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID for the IPO &nbsp;
**Ticker** | string | The ticker under which the Company will be traded after the IPO takes place &nbsp;
**Date** | DateTime? | The date of the IPO, when the stock first trades on a major exchange &nbsp;
**Status** | string | The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place &nbsp;
**Exchange** | string | The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE or NASDAQ &nbsp;
**OfferAmount** | decimal? | The total dollar amount of shares offered in the IPO. Typically this is share price * share count &nbsp;
**SharePrice** | decimal? | The price per share at which the IPO was offered &nbsp;
**SharePriceLowest** | decimal? | The expected lowest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs) &nbsp;
**SharePriceHighest** | decimal? | The expected highest price per share at which the IPO will be offered. Before an IPO is priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs) &nbsp;
**ShareCount** | decimal? | The number of shares offered in the IPO &nbsp;
**ShareCountLowest** | decimal? | The expected lowest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs) &nbsp;
**ShareCountHighest** | decimal? | The expected highest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs) &nbsp;
**AnnouncementUrl** | string | The URL to the company&#39;s announcement of the IPO &nbsp;
**SecReportUrl** | string | The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be filed before an IPO takes place. &nbsp;
**OpenPrice** | decimal? | The opening price at the beginning of the first trading day (only available for priced IPOs) &nbsp;
**ClosePrice** | decimal? | The closing price at the end of the first trading day (only available for priced IPOs) &nbsp;
**Volume** | decimal? | The volume at the end of the first trading day (only available for priced IPOs) &nbsp;
**DayChange** | decimal? | The percentage change between the open price and the close price on the first trading day (only available for priced IPOs) &nbsp;
**WeekChange** | decimal? | The percentage change between the open price on the first trading day and the close price approximately a week after the first trading day (only available for priced IPOs) &nbsp;
**MonthChange** | decimal? | The percentage change between the open price on the first trading day and the close price approximately a month after the first trading day (only available for priced IPOs) &nbsp;
**Company** | [**CompanySummary**](CompanySummary.md) | The Company that is going public via the IPO &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) | The primary Security for the Company that is going public via the IPO &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CompanySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



[//]: # (CLASS:Intrinio.SDK.Model.EarningsDateEstimateWithCompany)

[//]: # (KIND:object)

### Intrinio.SDK.Model.EarningsDateEstimateWithCompany
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**FiscalYear** | int? | The fiscal year for the earnings report &nbsp;
**FiscalPeriod** | string | The fiscal period for the earnings report (Q1, Q2, Q3, Q4, or FY) &nbsp;
**ExpectedDate** | DateTime? | The expected date of the earnings announcement &nbsp;
**Expected8kAt** | DateTime? | The expected timestamp when the 8-K filing will be available &nbsp;
**HistoricallyEarliest** | string | The earliest date (MM-DD format) this company has historically announced earnings for this fiscal period &nbsp;
**HistoricallyLatest** | string | The latest date (MM-DD format) this company has historically announced earnings for this fiscal period &nbsp;
**ConfidenceIntervals** | [**Dictionary&lt;string, EarningsDateEstimateConfidenceIntervals&gt;**](EarningsDateEstimateConfidenceIntervals.md) | Confidence intervals for the expected date, sorted by confidence level (descending) &nbsp;
**CompanyId** | string | The Intrinio ID for the company &nbsp;
**Ticker** | string | The ticker symbol of the company &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.EarningsDateEstimateConfidenceIntervals)



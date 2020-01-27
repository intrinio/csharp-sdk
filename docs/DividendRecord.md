[//]: # (CLASS:Intrinio.SDK.Model.DividendRecord)

[//]: # (KIND:object)

### Intrinio.SDK.Model.DividendRecord
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**ExDividend** | decimal? | Amount of dividend in US dollars &nbsp;
**Currency** | string | The 3-digit currency code the dividend amount was reported in &nbsp;
**AnnouncementDate** | DateTime? | Date dividend was announced &nbsp;
**RecordDate** | DateTime? | Date before which holders-of-record will receive the dividend &nbsp;
**PayDate** | DateTime? | Date the divdiend was paid &nbsp;
**Frequency** | string | Identifies payment frequency of announced dividend &nbsp;
**Status** | string | Status of the dividend &nbsp;
**ForwardYield** | decimal? | The forward dividend yield &nbsp;
**ForwardRate** | decimal? | The forward dividend rate &nbsp;
**LastExDividendDate** | DateTime? | The last reported day the stock starts trading without the value of its next dividend payment &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) |  &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



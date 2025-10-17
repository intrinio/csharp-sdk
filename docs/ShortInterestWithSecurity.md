[//]: # (CLASS:Intrinio.SDK.Model.ShortInterestWithSecurity)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ShortInterestWithSecurity
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**SettlementDate** | DateTime? | The settlement date of the short interest record &nbsp;
**CurrentShortPosition** | int? | The current short position (shares) as of the settlement date &nbsp;
**PreviousShortPosition** | int? | The previous short position (shares) from the prior reporting period &nbsp;
**ChangePercent** | float? | The percentage change in short position from the previous reporting period &nbsp;
**DaysToCover** | float? | The estimated number of days to cover the short position based on average daily volume &nbsp;
**AverageDailyVolume** | int? | The average daily trading volume used to calculate days to cover &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) | The security associated with this short interest record &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



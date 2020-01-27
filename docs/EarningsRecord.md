[//]: # (CLASS:Intrinio.SDK.Model.EarningsRecord)

[//]: # (KIND:object)

### Intrinio.SDK.Model.EarningsRecord
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Quarter** | string | The letter “Q” followed by the quarter number the earnings information applies to &nbsp;
**TimeOfDay** | string | Indicates the time of the announcement &nbsp;
**BroadcastUrl** | string | Link for Conference Call recording &nbsp;
**TranscriptUrl** | string | Link to the earnings release transcript &nbsp;
**TranscriptQuarter** | string | The letter “Q” followed by the quarter number the earnings transcript applies to &nbsp;
**TranscriptFiscalYear** | string | Fiscal year in YYYY format for the earnings transcript &nbsp;
**ConferenceCallDate** | DateTime? | Date of the conference call &nbsp;
**ConferenceCallTime** | string | Published time of the conference call &nbsp;
**ConferenceCallPhoneNumber** | string | Publicly available phone number for replay conference call &nbsp;
**ConferenceCallPasscode** | string | Passcode for replay conference call &nbsp;
**LastConfirmationDate** | DateTime? | Date of last earnings date update by a WSH analyst &nbsp;
**BoardOfDirectorsMeetingDate** | DateTime? | Date of Board/Shareholder Meeting &nbsp;
**BoardOfDirectorsMeetingType** | string | The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting &nbsp;
**CompanyWebsite** | string | Website link for the company &nbsp;
**Q1Date** | DateTime? | Earnings Date for 1st quarter &nbsp;
**Q2Date** | DateTime? | Earnings Date for 2nd quarter &nbsp;
**Q3Date** | DateTime? | Earnings Date for 3rd quarter &nbsp;
**Q4Date** | DateTime? | Earnings Date for 4th quarter &nbsp;
**Type** | string | The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred &nbsp;
**NextEarningsDate** | DateTime? | Next earnings date &nbsp;
**NextEarningsQuarter** | string | The quarter of the next earnings release &nbsp;
**NextEarningsFiscalYear** | int? | The fiscal year associated with next earnings date and next earnings quarter &nbsp;
**PreliminaryEarningsDate** | DateTime? | The release date of a preliminary earnings report &nbsp;
**Security** | [**SecuritySummary**](SecuritySummary.md) |  &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



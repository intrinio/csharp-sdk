# Intrinio.SDK.Model.EarningsRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quarter** | **string** | The letter “Q” followed by the quarter number the earnings information applies to | [optional] 
**TimeOfDay** | **string** | Indicates the time of the announcement | [optional] 
**BroadcastUrl** | **string** | Link for Conference Call recording | [optional] 
**TranscriptUrl** | **string** | Link to the earnings release transcript | [optional] 
**TranscriptQuarter** | **string** | The letter “Q” followed by the quarter number the earnings transcript applies to | [optional] 
**TranscriptFiscalYear** | **string** | Fiscal year in YYYY format for the earnings transcript | [optional] 
**ConferenceCallDate** | **DateTime?** | Date of the conference call | [optional] 
**ConferenceCallTime** | **string** | Published time of the conference call | [optional] 
**ConferenceCallPhoneNumber** | **string** | Publicly available phone number for replay conference call | [optional] 
**ConferenceCallPasscode** | **string** | Passcode for replay conference call | [optional] 
**LastConfirmationDate** | **DateTime?** | Date of last earnings date update by a WSH analyst | [optional] 
**BoardOfDirectorsMeetingDate** | **DateTime?** | Date of Board/Shareholder Meeting | [optional] 
**BoardOfDirectorsMeetingType** | **string** | The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a Shareholder meeting | [optional] 
**CompanyWebsite** | **string** | Website link for the company | [optional] 
**Q1Date** | **DateTime?** | Earnings Date for 1st quarter | [optional] 
**Q2Date** | **DateTime?** | Earnings Date for 2nd quarter | [optional] 
**Q3Date** | **DateTime?** | Earnings Date for 3rd quarter | [optional] 
**Q4Date** | **DateTime?** | Earnings Date for 4th quarter | [optional] 
**Type** | **string** | The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot; indicates that the date is forecased or Inferred | [optional] 
**NextEarningsDate** | **DateTime?** | Next earnings date | [optional] 
**NextEarningsQuarter** | **string** | The quarter of the next earnings release | [optional] 
**NextEarningsFiscalYear** | **int?** | The fiscal year associated with next earnings date and next earnings quarter | [optional] 
**Security** | [**SecuritySummary**](SecuritySummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


[//]: # (CLASS:Intrinio.SDK.Model.DailyShortVolumeConsolidated)

[//]: # (KIND:object)

### Intrinio.SDK.Model.DailyShortVolumeConsolidated
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**SecurityId** | string | The unique identifier of the security. &nbsp;
**Symbol** | string | The ticker symbol of the security. &nbsp;
**TradeDate** | DateTime? | The date of the reported short volume data in YYYY-MM-DD format. &nbsp;
**TotalVolume** | int? | The aggregated total volume of shares traded across all FINRA reporting facilities combined. Represents the total off-exchange trading volume for the security on this date. &nbsp;
**ShortVolume** | int? | The aggregated volume of shares sold short across all FINRA reporting facilities combined. Represents the total off-exchange short selling volume for the security on this date. &nbsp;
**ShortExemptVolume** | int? | The aggregated volume of shares sold short with exemptions across all FINRA reporting facilities combined. Includes pre-borrow arrangements, market maker activities, and other regulated short sale exemptions. &nbsp;
**ShortVolumeRatio** | double? | The ratio of aggregated short volume to aggregated total volume across all facilities, rounded to 4 decimal places. Ranges from 0.0 to 1.0.  This market-wide metric is useful for: - Comparing short selling intensity between securities - Identifying unusual short volume spikes - Tracking trends in bearish positioning - Assessing relative market sentiment toward a security  &nbsp;
**Sources** | List&lt;string&gt; | The list of FINRA reporting facility codes that contributed data to this consolidated aggregate. Multiple facilities typically report on the same security daily, and their volumes are summed here. &nbsp;

[//]: # (END_DEFINITION)



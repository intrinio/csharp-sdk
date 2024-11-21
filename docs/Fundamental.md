[//]: # (CLASS:Intrinio.SDK.Model.Fundamental)

[//]: # (KIND:object)

### Intrinio.SDK.Model.Fundamental
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID of the Fundamental &nbsp;
**StatementCode** | string | The code of the financial statement that the Fundamental represents &nbsp;
**FiscalYear** | decimal? | The fiscal year &nbsp;
**FiscalPeriod** | string | The fiscal period &nbsp;
**Type** | string | The type of Fundamental &nbsp;
**StartDate** | DateTime? | The period start date &nbsp;
**EndDate** | DateTime? | The period start date &nbsp;
**FilingDate** | DateTime? | The date and time when the Fundamental was filed with the SEC &nbsp;
**IsLatest** | bool? | Is this the latest fundamental available based on the company&#39;s most recent filings? Use the Lookup Fundamental endpoint to find the latest fundamental (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/web_api/lookup_fundamental_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;) &nbsp;
**Company** | [**CompanySummary**](CompanySummary.md) | The Company that the Fundamental was belongs to &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CompanySummary)



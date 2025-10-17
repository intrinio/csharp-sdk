[//]: # (CLASS:Intrinio.SDK.Model.CompanyNewsSummary)

[//]: # (KIND:object)

### Intrinio.SDK.Model.CompanyNewsSummary
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID for the news article &nbsp;
**Title** | string | The title of the news article &nbsp;
**PublicationDate** | DateTime? | The publication date of the news article &nbsp;
**Companies** | [**List&lt;CompanySummary&gt;**](CompanySummary.md) | The Companies to which the new article pertains &nbsp;
**Securities** | [**List&lt;SecuritySummary&gt;**](SecuritySummary.md) | The Securities to which the new article pertains &nbsp;
**Url** | string | The url of the news article &nbsp;
**Summary** | string | A summary of the news article &nbsp;
**Source** | string | The news source. &nbsp;
**Topics** | [**List&lt;NewsTopic&gt;**](NewsTopic.md) |  &nbsp;
**Copyright** | string | The copyright of the news article &nbsp;
**Language** | string | The language code of the news article &nbsp;
**WordCount** | int? | The word count of the news article &nbsp;
**Spam** | bool? | Whether the news article is marked as spam or not &nbsp;
**BusinessRelevance** | decimal? | How strongly correlated the news article is to the business &nbsp;
**ArticleSentiment** | string | The news sentiment. &nbsp;
**ArticleSentimentConfidence** | decimal? | The confidence score of the sentiment rating &nbsp;
**Issuer** | string | The issuer of the story. &nbsp;
**IssuerName** | string | The issuer of the story. &nbsp;
**IssuerCompany** | [**CompanySummary**](CompanySummary.md) | The company that issued the story. &nbsp;
**IssuerSecurity** | [**SecuritySummary**](SecuritySummary.md) | The security that issued the story. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CompanySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.NewsTopic)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CompanySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.SecuritySummary)



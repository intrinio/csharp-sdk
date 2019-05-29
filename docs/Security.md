[//]: # (CLASS:Intrinio.SDK.Model.Security)

[//]: # (KIND:object)

### Intrinio.SDK.Model.Security
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Id** | string | The Intrinio ID for the Security &nbsp;
**CompanyId** | string | The Intrinio ID for the company for which the Security is issued &nbsp;
**Name** | string | The name of the Security &nbsp;
**Type** | string | The Security&#39;s type &nbsp;
**Code** | string | A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;) &nbsp;
**ShareClass** | string | The Security&#39;s share class (if applicable) &nbsp;
**Currency** | string | The currency in which the Security is traded on the exchange &nbsp;
**RoundLotSize** | decimal? | The normal unit of trading &nbsp;
**Ticker** | string | The common ticker &nbsp;
**ExchangeTicker** | string | The exchange-level ticker &nbsp;
**CompositeTicker** | string | The country-composite ticker &nbsp;
**AlternateTickers** | List&lt;string&gt; | Alternate formats of the common ticker &nbsp;
**Figi** | string | The exchange-level OpenFIGI identifier &nbsp;
**Cik** | string | Central Index Key issued by the SEC, which is the unique identifier for all owner filings &nbsp;
**CompositeFigi** | string | The country-composite OpenFIGI identifier &nbsp;
**ShareClassFigi** | string | The global-composite OpenFIGI identifier &nbsp;
**FigiUniqueid** | string | The OpenFIGI unique ID &nbsp;
**Active** | bool? | If true, the Security is active and has been recently traded &nbsp;
**Etf** | bool? | If true, this Security is an ETF &nbsp;
**Delisted** | bool? | If true, the Security is no longer traded on the exchange &nbsp;
**PrimaryListing** | bool? | If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange &nbsp;
**PrimarySecurity** | bool? | If true, the Security is considered by Intrinio to be the primary Security for its company &nbsp;
**FirstStockPrice** | DateTime? | The date of the first recorded stock price &nbsp;
**LastStockPrice** | DateTime? | The date of the last recorded stock price (or the most recent trading day) &nbsp;
**LastStockPriceAdjustment** | DateTime? | The date of the last stock price adjustment (dividend, split, etc) &nbsp;
**LastCorporateAction** | DateTime? | The date of the last corporate action &nbsp;
**PreviousTickers** | List&lt;string&gt; | Previous tickers used by this security &nbsp;
**ListingExchangeMic** | string | The MIC code of the exchange on which this security primarily trades &nbsp;

[//]: # (END_DEFINITION)



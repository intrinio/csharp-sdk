# Intrinio.SDK.Model.Security
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The Intrinio ID for the Security | [optional] 
**CompanyId** | **string** | The Intrinio ID for the company for which the Security is issued | [optional] 
**Name** | **string** | The name of the Security | [optional] 
**Type** | **string** | The Security&#39;s type | [optional] 
**Code** | **string** | A 2-3 digit code classifying the Security | [optional] 
**ShareClass** | **string** | The Security&#39;s share class (if applicable) | [optional] 
**Currency** | **string** | The currency in which the Security is traded on the exchange | [optional] 
**RoundLotSize** | **decimal?** | The normal unit of trading | [optional] 
**Ticker** | **string** | The common ticker | [optional] 
**ExchangeTicker** | **string** | The exchange-level ticker | [optional] 
**CompositeTicker** | **string** | The country-composite ticker | [optional] 
**AlternateTickers** | **List&lt;string&gt;** | Alternate formats of the common ticker | [optional] 
**Figi** | **string** | The exchange-level OpenFIGI identifier | [optional] 
**Cik** | **string** | Central Index Key issued by the SEC, which is the unique identifier for all owner filings | [optional] 
**CompositeFigi** | **string** | The country-composite OpenFIGI identifier | [optional] 
**ShareClassFigi** | **string** | The global-composite OpenFIGI identifier | [optional] 
**FigiUniqueid** | **string** | The OpenFIGI unique ID | [optional] 
**Active** | **bool?** | If true, the Security is active and has been recently traded | [optional] 
**Etf** | **bool?** | If true, this Security is an ETF | [optional] 
**Delisted** | **bool?** | If true, the Security is no longer traded on the exchange | [optional] 
**PrimaryListing** | **bool?** | If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange | [optional] 
**PrimarySecurity** | **bool?** | If true, the Security is considered by Intrinio to be the primary Security for its company | [optional] 
**FirstStockPrice** | **DateTime?** | The date of the first recorded stock price | [optional] 
**LastStockPrice** | **DateTime?** | The date of the last recorded stock price (or the most recent trading day) | [optional] 
**LastStockPriceAdjustment** | **DateTime?** | The date of the last stock price adjustment (dividend, split, etc) | [optional] 
**LastCorporateAction** | **DateTime?** | The date of the last corporate action | [optional] 
**PreviousTickers** | **List&lt;string&gt;** | Previous tickers used by this security | [optional] 
**ListingExchangeMic** | **string** | The MIC code of the exchange on which this security primarily trades | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


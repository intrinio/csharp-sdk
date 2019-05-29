[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseCryptoBook)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseCryptoBook
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Bids** | [**List&lt;CryptoBookEntry&gt;**](CryptoBookEntry.md) | The bid prices and their respective sizes, in descending order of price. &nbsp;
**Asks** | [**List&lt;CryptoBookEntry&gt;**](CryptoBookEntry.md) | The ask prices and their respective sizes, in ascending order of price. &nbsp;
**Pair** | [**CryptoPairSummary**](CryptoPairSummary.md) |  &nbsp;
**Exchange** | [**CryptoExchangeSummary**](CryptoExchangeSummary.md) |  &nbsp;
**LastUpdated** | string | The UTC timestamp of when the order book was last updated. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CryptoBookEntry)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CryptoBookEntry)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CryptoPairSummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CryptoExchangeSummary)



### Intrinio.SDK.Model.ApiResponseCryptoBook
#### Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bids** | [**List&lt;CryptoBookEntry&gt;**](CryptoBookEntry.md) | The bid prices and their respective sizes, in descending order of price. | [optional] 
**Asks** | [**List&lt;CryptoBookEntry&gt;**](CryptoBookEntry.md) | The ask prices and their respective sizes, in ascending order of price. | [optional] 
**Pair** | [**CryptoPairSummary**](CryptoPairSummary.md) |  | [optional] 
**Exchange** | [**CryptoExchangeSummary**](CryptoExchangeSummary.md) |  | [optional] 
**LastUpdated** | **string** | The UTC timestamp of when the order book was last updated. | [optional] 


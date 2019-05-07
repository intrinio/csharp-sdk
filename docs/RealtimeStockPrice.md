## Intrinio.SDK.Model.RealtimeStockPrice
### Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastPrice** | **decimal?** | The price of the last trade. | [optional] 
**LastTime** | **DateTime?** | The date and time when the last trade occurred. | [optional] 
**BidPrice** | **decimal?** | The price of the top bid order. | [optional] 
**BidSize** | **decimal?** | The size of the top bid order. | [optional] 
**AskPrice** | **decimal?** | The price of the top ask order. | [optional] 
**AskSize** | **decimal?** | The size of the top ask order. | [optional] 
**OpenPrice** | **decimal?** | The price at the open of the trading day. | [optional] 
**HighPrice** | **decimal?** | The high price for the trading day. | [optional] 
**LowPrice** | **decimal?** | The low price for the trading day. | [optional] 
**ExchangeVolume** | **decimal?** | The number of shares exchanged during the trading day on the exchange. | [optional] 
**MarketVolume** | **decimal?** | The number of shares exchanged during the trading day for the whole market. | [optional] 
**UpdatedOn** | **DateTime?** | The date and time when the data was last updated. | [optional] 
**Source** | **string** | The source of the data. | [optional] 
**Security** | [**RealtimeStockPriceSecurity**](RealtimeStockPriceSecurity.md) |  | [optional] 


# Intrinio.SDK.Model.StockPriceAdjustmentSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | The date on which the adjustment occurred. The adjustment should be applied to all stock prices before this date. | [optional] 
**Factor** | **decimal?** | The factor by which to multiply stock prices before this date, in order to calculate historically-adjusted stock prices. | [optional] 
**Dividend** | **decimal?** | The dividend amount, if a dividend was paid. | [optional] 
**DividendCurrency** | **string** | The currency of the dividend, if known. | [optional] 
**SplitRatio** | **decimal?** | The ratio of the stock split, if a stock split occurred. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


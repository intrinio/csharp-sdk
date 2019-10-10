[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseCryptoChaikinMoneyFlow)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseCryptoChaikinMoneyFlow
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Technicals** | [**List&lt;ChaikinMoneyFlowTechnicalValue&gt;**](ChaikinMoneyFlowTechnicalValue.md) |  &nbsp;
**Indicator** | [**TechnicalIndicator**](TechnicalIndicator.md) | The name and symbol of the technical indicator &nbsp;
**Pair** | [**CryptoPairSummary**](CryptoPairSummary.md) |  &nbsp;
**Exchange** | [**CryptoExchangeSummary**](CryptoExchangeSummary.md) |  &nbsp;
**Timeframe** | string | The time interval for the crypto currency prices &nbsp;
**NextPage** | string | The token required to request the next page of the data. If null, no further results are available. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.ChaikinMoneyFlowTechnicalValue)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.TechnicalIndicator)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CryptoPairSummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CryptoExchangeSummary)



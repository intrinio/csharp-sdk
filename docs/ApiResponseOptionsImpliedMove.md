[//]: # (CLASS:Intrinio.SDK.Model.ApiResponseOptionsImpliedMove)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ApiResponseOptionsImpliedMove
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**ImpliedMove** | [**OptionImpliedMoveData**](OptionImpliedMoveData.md) | The data pertaining to the implied move. &nbsp;
**Messages** | List&lt;string&gt; | Any messages or warnings about the data &nbsp;
**UnderlyingPrice** | decimal? | The price of the underlying instrument. &nbsp;
**Expiration** | string | The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised. &nbsp;
**AtmStrike** | decimal? | The at-the-money strike price for the implied move calculation. &nbsp;
**StraddlePrice** | decimal? | The straddle price for the implied move calculation. &nbsp;
**Symbol** | string | The symbol for the underlying instrument. &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.OptionImpliedMoveData)



[//]: # (CLASS:Intrinio.SDK.Model.OptionPriceEod)

[//]: # (KIND:object)

### Intrinio.SDK.Model.OptionPriceEod
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Date** | string | The date of the price, in the format YYYY-MM-DD &nbsp;
**Close** | decimal? | The closing price of the options contract. &nbsp;
**CloseBid** | decimal? | The closing bid price of the options contract. &nbsp;
**CloseAsk** | decimal? | The closing ask price of the options contract. &nbsp;
**Volume** | int? | The cumulative volume of this options contract that traded that day. &nbsp;
**Open** | decimal? | The price at the beginning of the period &nbsp;
**OpenAsk** | decimal? | The ask at the beginning of the period &nbsp;
**OpenBid** | decimal? | The bid at the beginning of the period &nbsp;
**OpenInterest** | int? | The total number of this options contract that are still open. &nbsp;
**High** | decimal? | The highest price over the span of the period &nbsp;
**Low** | decimal? | The highest price over the span of the period &nbsp;
**Mark** | decimal? | The mid price between the latest bid and ask spread &nbsp;
**AskHigh** | decimal? | The highest ask over the span of the period &nbsp;
**AskLow** | decimal? | The lowest ask over the span of the period &nbsp;
**BidHigh** | decimal? | The highest bid over the span of the period &nbsp;
**BidLow** | Object | The lowest bid over the span of the period &nbsp;
**ImpliedVolatility** | decimal? | The implied volatility of the contract calculated using the Black-Scholes Model. &nbsp;
**Delta** | decimal? | Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s price. &nbsp;
**Gamma** | decimal? | Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price. &nbsp;
**Theta** | decimal? | Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an option&#39;s time decay. &nbsp;
**Vega** | decimal? | Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility. &nbsp;

[//]: # (END_DEFINITION)



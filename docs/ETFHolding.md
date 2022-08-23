[//]: # (CLASS:Intrinio.SDK.Model.ETFHolding)

[//]: # (KIND:object)

### Intrinio.SDK.Model.ETFHolding
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**AsOfDate** | DateTime? | The date on which the holding and their weights correspond &nbsp;
**Name** | string | The common name for the holding &nbsp;
**Ticker** | string | The common exchange ticker for the holding &nbsp;
**Type** | string | The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;EQUI&#39;, Options &#x3D; &#39;OPTN&#39;) &nbsp;
**CompositeFigi** | string | DEPRECATED &nbsp;
**ShareClassFigi** | string | The OpenFIGI symbol for the holding &nbsp;
**Isin** | string | International Securities Identification Number (ISIN) for the holding &nbsp;
**Ric** | string | Reuters Instrument Code (RIC) for the holding &nbsp;
**Sedol** | string | Stock Exchange Daily Official List (SEDOL) for the holding &nbsp;
**Face** | decimal? | Face value of the debt security, if available &nbsp;
**Coupon** | decimal? | Coupon rate of the debt security, if available &nbsp;
**MarketValueHeld** | decimal? | The market value of this holding in the ETF as of the &#x60;as_of_date&#x60; &nbsp;
**NotionalValue** | decimal? | Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN) &nbsp;
**Maturity** | DateTime? | Maturity date for the debt security, if available &nbsp;
**QuantityHeld** | decimal? | Number of units of the security held if available &nbsp;
**Weighting** | decimal? | Fraction of the funds market value held &nbsp;
**QuantityUnits** | decimal? | The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;, &#39;contracts&#39;) &nbsp;
**QuantityPerShare** | decimal? | Number of units of the security held per units of shares outstanding of the Exchange Traded Fund (ETF), if available &nbsp;
**ContractExpiryDate** | DateTime? | Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN) &nbsp;

[//]: # (END_DEFINITION)



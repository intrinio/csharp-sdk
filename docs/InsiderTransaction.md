[//]: # (CLASS:Intrinio.SDK.Model.InsiderTransaction)

[//]: # (KIND:object)

### Intrinio.SDK.Model.InsiderTransaction
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Director** | bool? | (true/false) A boolean indicating whether or not the owner is a director in the company &nbsp;
**Officer** | bool? | (true/false) A boolean indicating whether or not the owner is a officer in the company &nbsp;
**TenPercentOwner** | bool? | (true/false) A boolean indicating whether or not the owner has a ten percent or greater interest in the company &nbsp;
**OtherRelation** | bool? | (true/false) A boolean indicating whether or not the owner has another relationship with the company beside, direct, officer, or significant owner in the company &nbsp;
**OfficerTitle** | string | The officer title of the owner in the company &nbsp;
**DerivativeTransaction** | bool? | (true) A boolean indicating the transaction is a derivative transaction, which may or may not become common stock due to various possible exercise or conversion requirements &nbsp;
**Ticker** | string | The ticker symbol for the company’s common stock &nbsp;
**SecurityTitle** | string | The name of the derivative security transacted &nbsp;
**ConversionExercisePrice** | decimal? | The conversion or exercise price of the derivative security transacted &nbsp;
**TransactionTypeCode** | string | A symbol representing the transaction type; P &#x3D; Purchase | S &#x3D; Sale | A  &#x3D; Award | M &#x3D; Conversion to Common | C &#x3D; Conversion | X &#x3D; Exercise of Derivative More Transaction Codes &nbsp;
**AcquisitionDispositionCode** | string | A symbol representing whether or not the derivative securities are Acquired or Disposed; A &#x3D; Acquisition | D &#x3D; Disposition &nbsp;
**AmountOfShares** | decimal? | The number of derivative securities involved in the subject transaction &nbsp;
**UnderlyingSecurityTitle** | string | The name of the underlying non-derivative security related to this derivative transaction &nbsp;
**UnderlyingShares** | decimal? | The number of non-derivative shares involved in the subject transaction &nbsp;
**TransactionPrice** | decimal? | The price of the derivative securities &nbsp;
**TotalSharesOwned** | decimal? | The total number of derivative securities owned following the subject transaction &nbsp;
**OwnershipTypeCode** | string | A symbol representing the ownership of the securities transacted; D &#x3D; Direct Ownership | I &#x3D; Indirect Ownership &nbsp;
**Company** | [**CompanySummary**](CompanySummary.md) | The company associated with the filing &nbsp;
**Owner** | [**OwnerSummary**](OwnerSummary.md) | The owner associated with the filing &nbsp;

[//]: # (END_DEFINITION)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.CompanySummary)


[//]: # (CONTAINED_CLASS:Intrinio.SDK.Model.OwnerSummary)



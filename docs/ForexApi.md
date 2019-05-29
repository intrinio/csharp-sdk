# Intrinio.SDK.Api.ForexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetForexCurrencies**](ForexApi.md#getforexcurrencies) | **GET** /forex/currencies | Forex Currencies
[**GetForexPairs**](ForexApi.md#getforexpairs) | **GET** /forex/pairs | Forex Currency Pairs
[**GetForexPrices**](ForexApi.md#getforexprices) | **GET** /forex/prices/{pair}/{timeframe} | Forex Currency Prices



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ForexApi)

[//]: # (METHOD:GetForexCurrencies)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseForexCurrencies)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseForexCurrencies.md)

[//]: # (OPERATION:GetForexCurrencies_v2)

[//]: # (ENDPOINT:/forex/currencies)

[//]: # (DOCUMENT_LINK:ForexApi.md#getforexcurrencies)

<a name="getforexcurrencies"></a>
## **GetForexCurrencies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetForexCurrencies_v2)

[//]: # (START_OVERVIEW)

> ApiResponseForexCurrencies GetForexCurrencies ()

#### Forex Currencies

Returns a list of forex currencies for which prices are available.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetForexCurrenciesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var forexApi = new ForexApi();

      try
      {
        ApiResponseForexCurrencies result = forexApi.GetForexCurrencies();
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling ForexApi.GetForexCurrencies: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)

This endpoint does not need any parameter.
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseForexCurrencies**](ApiResponseForexCurrencies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ForexApi)

[//]: # (METHOD:GetForexPairs)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseForexPairs)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseForexPairs.md)

[//]: # (OPERATION:GetForexPairs_v2)

[//]: # (ENDPOINT:/forex/pairs)

[//]: # (DOCUMENT_LINK:ForexApi.md#getforexpairs)

<a name="getforexpairs"></a>
## **GetForexPairs**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetForexPairs_v2)

[//]: # (START_OVERVIEW)

> ApiResponseForexPairs GetForexPairs ()

#### Forex Currency Pairs

Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetForexPairsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var forexApi = new ForexApi();

      try
      {
        ApiResponseForexPairs result = forexApi.GetForexPairs();
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling ForexApi.GetForexPairs: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)

This endpoint does not need any parameter.
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseForexPairs**](ApiResponseForexPairs.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ForexApi)

[//]: # (METHOD:GetForexPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseForexPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseForexPrices.md)

[//]: # (OPERATION:GetForexPrices_v2)

[//]: # (ENDPOINT:/forex/prices/{pair}/{timeframe})

[//]: # (DOCUMENT_LINK:ForexApi.md#getforexprices)

<a name="getforexprices"></a>
## **GetForexPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetForexPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseForexPrices GetForexPrices (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)

#### Forex Currency Prices

Provides a list of forex price quotes for a given forex currency pair and timeframe.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetForexPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var forexApi = new ForexApi();
      var pair = "EURUSD";  // string | The Forex Currency Pair code
      var timeframe = "D1";  // string | The time interval for the quotes
      var timezone = "UTC";  // string | Returns trading times in this timezone (optional)  (default to UTC)
      var startDate = "";  // DateTime? | Return Forex Prices on or after this date (optional) 
      var startTime = "";  // string | Return Forex Prices at or after this time (24-hour) (optional) 
      var endDate = "";  // DateTime? | Return Forex Prices on or before this date (optional) 
      var endTime = "";  // string | Return Forex Prices at or before this time (24-hour) (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseForexPrices result = forexApi.GetForexPrices(pair, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling ForexApi.GetForexPrices: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | string| The Forex Currency Pair code |  &nbsp;
 **timeframe** | string| The time interval for the quotes |  &nbsp;
 **timezone** | string| Returns trading times in this timezone | [optional] [default to UTC] &nbsp;
 **startDate** | DateTime?| Return Forex Prices on or after this date | [optional]  &nbsp;
 **startTime** | string| Return Forex Prices at or after this time (24-hour) | [optional]  &nbsp;
 **endDate** | DateTime?| Return Forex Prices on or before this date | [optional]  &nbsp;
 **endTime** | string| Return Forex Prices at or before this time (24-hour) | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseForexPrices**](ApiResponseForexPrices.md)

[//]: # (END_OPERATION)


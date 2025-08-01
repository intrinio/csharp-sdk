# Intrinio.SDK.Api.StockExchangeApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllStockExchanges**](StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | All Stock Exchanges
[**GetStockExchangeBetas**](StockExchangeApi.md#getstockexchangebetas) | **GET** /stock_exchanges/{identifier}/betas | Security Betas
[**GetStockExchangeById**](StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Lookup Stock Exchange
[**GetStockExchangeGainers**](StockExchangeApi.md#getstockexchangegainers) | **GET** /stock_exchanges/{identifier}/gainers | Top Gainers by Exchange
[**GetStockExchangeLosers**](StockExchangeApi.md#getstockexchangelosers) | **GET** /stock_exchanges/{identifier}/losers | Top Losers by Exchange
[**GetStockExchangePriceAdjustments**](StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Stock Price Adjustments by Exchange
[**GetStockExchangePriceAdjustmentsDividends**](StockExchangeApi.md#getstockexchangepriceadjustmentsdividends) | **GET** /stock_exchanges/{identifier}/prices/adjustments/dividends | Dividends by date for exchange
[**GetStockExchangePriceAdjustmentsSplits**](StockExchangeApi.md#getstockexchangepriceadjustmentssplits) | **GET** /stock_exchanges/{identifier}/prices/adjustments/splits | Splits by date for exchange
[**GetStockExchangePrices**](StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Stock Prices by Exchange
[**GetStockExchangeQuote**](StockExchangeApi.md#getstockexchangequote) | **GET** /stock_exchanges/{identifier}/quote | Realtime Quote Prices by Exchange
[**GetStockExchangeRealtimePrices**](StockExchangeApi.md#getstockexchangerealtimeprices) | **GET** /stock_exchanges/{identifier}/prices/realtime | Realtime Stock Prices by Exchange
[**GetStockExchangeSecurities**](StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Securities by Exchange



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetAllStockExchanges)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchanges)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchanges.md)

[//]: # (OPERATION:GetAllStockExchanges_v2)

[//]: # (ENDPOINT:/stock_exchanges)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getallstockexchanges)

<a name="getallstockexchanges"></a>
## **GetAllStockExchanges**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllStockExchanges_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchanges GetAllStockExchanges (string city = null, string country = null, string countryCode = null, int? pageSize = null)

#### All Stock Exchanges

Returns all Stock Exchanges matching the specified parameters

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetAllStockExchangesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string city = "New York";
      string country = "UNITED STATES OF AMERICA";
      string countryCode = "US";
      int? pageSize = 100;
      
      ApiResponseStockExchanges result = stockExchangeApi.GetAllStockExchanges(city, country, countryCode, pageSize);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **city** | string| Filter by city | [optional]  &nbsp;
 **country** | string| Filter by country | [optional]  &nbsp;
 **countryCode** | string| Filter by ISO country code | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchanges**](ApiResponseStockExchanges.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeBetas)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeBetas)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeBetas.md)

[//]: # (OPERATION:GetStockExchangeBetas_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/betas)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangebetas)

<a name="getstockexchangebetas"></a>
## **GetStockExchangeBetas**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeBetas_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeBetas GetStockExchangeBetas (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null)

#### Security Betas

Returns security beta data in the Stock Exchange with the given `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeBetasExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      string type = null;
      var date = new Object();
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockExchangeBetas result = stockExchangeApi.GetStockExchangeBetas(identifier, type, date, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **type** | string| Only of the given type | [optional] [default to weekly] &nbsp;
 **date** | [**Object**](Object.md)| Return data for this period end date. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeBetas**](ApiResponseStockExchangeBetas.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.StockExchange)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:StockExchange.md)

[//]: # (OPERATION:GetStockExchangeById_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier})

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangebyid)

<a name="getstockexchangebyid"></a>
## **GetStockExchangeById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeById_v2)

[//]: # (START_OVERVIEW)

> StockExchange GetStockExchangeById (string identifier)

#### Lookup Stock Exchange

Returns the Stock Exchange with the given `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      
      StockExchange result = stockExchangeApi.GetStockExchangeById(identifier);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**StockExchange**](StockExchange.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeGainers)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeMovers)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeMovers.md)

[//]: # (OPERATION:GetStockExchangeGainers_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/gainers)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangegainers)

<a name="getstockexchangegainers"></a>
## **GetStockExchangeGainers**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeGainers_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeMovers GetStockExchangeGainers (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)

#### Top Gainers by Exchange

Returns securities with the highest gain percent change traded on the chosen stock exchange.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeGainersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      decimal? minPrice = 8.14;
      int? pageSize = 100;
      string source = "delayed_sip";
      
      ApiResponseStockExchangeMovers result = stockExchangeApi.GetStockExchangeGainers(identifier, minPrice, pageSize, source);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **minPrice** | decimal?| The minimum price filter | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **source** | string| Return the realtime price from the specified source instead of the most recent. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeMovers**](ApiResponseStockExchangeMovers.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeLosers)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeMovers)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeMovers.md)

[//]: # (OPERATION:GetStockExchangeLosers_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/losers)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangelosers)

<a name="getstockexchangelosers"></a>
## **GetStockExchangeLosers**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeLosers_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeMovers GetStockExchangeLosers (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)

#### Top Losers by Exchange

Returns securities with the highest loss percent change traded on the chosen stock exchange.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeLosersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      decimal? minPrice = 8.14;
      int? pageSize = 100;
      string source = "delayed_sip";
      
      ApiResponseStockExchangeMovers result = stockExchangeApi.GetStockExchangeLosers(identifier, minPrice, pageSize, source);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **minPrice** | decimal?| The minimum price filter | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **source** | string| Return the realtime price from the specified source instead of the most recent. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeMovers**](ApiResponseStockExchangeMovers.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangePriceAdjustments)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeStockPriceAdjustments)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeStockPriceAdjustments.md)

[//]: # (OPERATION:GetStockExchangePriceAdjustments_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/prices/adjustments)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangepriceadjustments)

<a name="getstockexchangepriceadjustments"></a>
## **GetStockExchangePriceAdjustments**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangePriceAdjustments_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)

#### Stock Price Adjustments by Exchange

Returns stock price adjustments for the Stock Exchange with the given `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangePriceAdjustmentsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      DateTime? date = DateTime.Parse("2018-08-14");
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockExchangeStockPriceAdjustments result = stockExchangeApi.GetStockExchangePriceAdjustments(identifier, date, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **date** | DateTime?| The date for which to return price adjustments | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeStockPriceAdjustments**](ApiResponseStockExchangeStockPriceAdjustments.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangePriceAdjustmentsDividends)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeStockPriceAdjustments)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeStockPriceAdjustments.md)

[//]: # (OPERATION:GetStockExchangePriceAdjustmentsDividends_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/prices/adjustments/dividends)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangepriceadjustmentsdividends)

<a name="getstockexchangepriceadjustmentsdividends"></a>
## **GetStockExchangePriceAdjustmentsDividends**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangePriceAdjustmentsDividends_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustmentsDividends (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)

#### Dividends by date for exchange

Returns dividend adjustments for the Stock Exchange with the given `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangePriceAdjustmentsDividendsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      DateTime? date = DateTime.Parse("2025-06-01");
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockExchangeStockPriceAdjustments result = stockExchangeApi.GetStockExchangePriceAdjustmentsDividends(identifier, date, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **date** | DateTime?| The date for which to return dividends | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeStockPriceAdjustments**](ApiResponseStockExchangeStockPriceAdjustments.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangePriceAdjustmentsSplits)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeStockPriceAdjustments)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeStockPriceAdjustments.md)

[//]: # (OPERATION:GetStockExchangePriceAdjustmentsSplits_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/prices/adjustments/splits)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangepriceadjustmentssplits)

<a name="getstockexchangepriceadjustmentssplits"></a>
## **GetStockExchangePriceAdjustmentsSplits**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangePriceAdjustmentsSplits_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustmentsSplits (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)

#### Splits by date for exchange

Returns split adjustments for the Stock Exchange with the given `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangePriceAdjustmentsSplitsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      DateTime? date = DateTime.Parse("2025-06-01");
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockExchangeStockPriceAdjustments result = stockExchangeApi.GetStockExchangePriceAdjustmentsSplits(identifier, date, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **date** | DateTime?| The date for which to return splits | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeStockPriceAdjustments**](ApiResponseStockExchangeStockPriceAdjustments.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangePrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeStockPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeStockPrices.md)

[//]: # (OPERATION:GetStockExchangePrices_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/prices)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangeprices)

<a name="getstockexchangeprices"></a>
## **GetStockExchangePrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangePrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeStockPrices GetStockExchangePrices (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null)

#### Stock Prices by Exchange

Returns end-of-day stock prices for Securities on the Stock Exchange with `identifier` and on the `price_date` (or the latest date that prices are available)

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangePricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      DateTime? date = DateTime.Parse("2018-08-14");
      DateTime? startDate = DateTime.Parse("2020-08-14");
      DateTime? endDate = DateTime.Parse("2022-08-14");
      int? pageSize = 100;
      string nextPage = null;
      var tickers = new List<string>();
      string nextPage2 = "";
      
      ApiResponseStockExchangeStockPrices result = stockExchangeApi.GetStockExchangePrices(identifier, date, startDate, endDate, pageSize, nextPage, tickers, nextPage2);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **date** | DateTime?| The date for which to return prices. May not be used with the start_date and end_date parameters. | [optional]  &nbsp;
 **startDate** | DateTime?| The start of the date range you&#39;re querying. May not be used with date parameter. | [optional]  &nbsp;
 **endDate** | DateTime?| The end of the date range you&#39;re querying. May not be used with date parameter. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **tickers** | [**List&lt;string&gt;**](string.md)| The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. | [optional]  &nbsp;
 **nextPage2** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeStockPrices**](ApiResponseStockExchangeStockPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeQuote)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeQuote)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeQuote.md)

[//]: # (OPERATION:GetStockExchangeQuote_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/quote)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangequote)

<a name="getstockexchangequote"></a>
## **GetStockExchangeQuote**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeQuote_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeQuote GetStockExchangeQuote (string identifier, List<string> tickers, string source = null, bool? activeOnly = null)

#### Realtime Quote Prices by Exchange

Returns many popular metrics for securities from a given exchange 'identifier' from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeQuoteExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      var tickers = new List<string>();
      string source = "delayed_sip";
      bool? activeOnly = null;
      
      ApiResponseStockExchangeQuote result = stockExchangeApi.GetStockExchangeQuote(identifier, tickers, source, activeOnly);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **tickers** | [**List&lt;string&gt;**](string.md)| The comma-delimited list of ticker symbols to return quotes for. |  &nbsp;
 **source** | string| Return the realtime price from the specified source instead of the most recent. | [optional]  &nbsp;
 **activeOnly** | bool?| Returns prices only from the most recent trading day. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeQuote**](ApiResponseStockExchangeQuote.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeRealtimePrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeRealtimeStockPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeRealtimeStockPrices.md)

[//]: # (OPERATION:GetStockExchangeRealtimePrices_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/prices/realtime)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangerealtimeprices)

<a name="getstockexchangerealtimeprices"></a>
## **GetStockExchangeRealtimePrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeRealtimePrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)

#### Realtime Stock Prices by Exchange

Returns realtime stock prices for the Stock Exchange with the given `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeRealtimePricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      List<string> source = "iex,delayed_sip";
      bool? activeOnly = null;
      bool? tradedToday = null;
      int? pageSize = 100;
      var tickers = new List<string>();
      string nextPage = null;
      
      ApiResponseStockExchangeRealtimeStockPrices result = stockExchangeApi.GetStockExchangeRealtimePrices(identifier, source, activeOnly, tradedToday, pageSize, tickers, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **source** | List&lt;string&gt;| Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. | [optional]  &nbsp;
 **activeOnly** | bool?| Returns prices only from the most recent trading day. | [optional]  &nbsp;
 **tradedToday** | bool?| Returns prices only from securities which have traded on the most recent trading day. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **tickers** | [**List&lt;string&gt;**](string.md)| The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeRealtimeStockPrices**](ApiResponseStockExchangeRealtimeStockPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.StockExchangeApi)

[//]: # (METHOD:GetStockExchangeSecurities)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeSecurities)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeSecurities.md)

[//]: # (OPERATION:GetStockExchangeSecurities_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/securities)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangesecurities)

<a name="getstockexchangesecurities"></a>
## **GetStockExchangeSecurities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockExchangeSecurities_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeSecurities GetStockExchangeSecurities (string identifier, int? pageSize = null, string nextPage = null)

#### Securities by Exchange

Returns Securities traded on the Stock Exchange with `identifier`

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetStockExchangeSecuritiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var stockExchangeApi = new StockExchangeApi();
      
      string identifier = "USCOMP";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockExchangeSecurities result = stockExchangeApi.GetStockExchangeSecurities(identifier, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeSecurities**](ApiResponseStockExchangeSecurities.md)

[//]: # (END_OPERATION)


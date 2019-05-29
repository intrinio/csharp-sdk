# Intrinio.SDK.Api.StockExchangeApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllStockExchanges**](StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | All Stock Exchanges
[**GetStockExchangeById**](StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Lookup Stock Exchange
[**GetStockExchangePriceAdjustments**](StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Stock Price Adjustments by Exchange
[**GetStockExchangePrices**](StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Stock Prices by Exchange
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllStockExchanges_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetAllStockExchangesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var stockExchangeApi = new StockExchangeApi();
      var city = city_example;  // string | Filter by city (optional) 
      var country = "CHINA";  // string | Filter by country (optional) 
      var countryCode = countryCode_example;  // string | Filter by ISO country code (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

      try
      {
        ApiResponseStockExchanges result = stockExchangeApi.GetAllStockExchanges(city, country, countryCode, pageSize);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling StockExchangeApi.GetAllStockExchanges: " + e.Message );
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

[//]: # (METHOD:GetStockExchangeById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.StockExchange)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:StockExchange.md)

[//]: # (OPERATION:GetStockExchangeById_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier})

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangebyid)

<a name="getstockexchangebyid"></a>
## **GetStockExchangeById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetStockExchangeById_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetStockExchangeByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var stockExchangeApi = new StockExchangeApi();
      var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)

      try
      {
        StockExchange result = stockExchangeApi.GetStockExchangeById(identifier);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeById: " + e.Message );
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
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**StockExchange**](StockExchange.md)

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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetStockExchangePriceAdjustments_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetStockExchangePriceAdjustmentsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var stockExchangeApi = new StockExchangeApi();
      var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
      var date = "2018-08-14";  // DateTime? | The date for which to return price adjustments (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseStockExchangeStockPriceAdjustments result = stockExchangeApi.GetStockExchangePriceAdjustments(identifier, date, pageSize, nextPage);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling StockExchangeApi.GetStockExchangePriceAdjustments: " + e.Message );
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

[//]: # (METHOD:GetStockExchangePrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockExchangeStockPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockExchangeStockPrices.md)

[//]: # (OPERATION:GetStockExchangePrices_v2)

[//]: # (ENDPOINT:/stock_exchanges/{identifier}/prices)

[//]: # (DOCUMENT_LINK:StockExchangeApi.md#getstockexchangeprices)

<a name="getstockexchangeprices"></a>
## **GetStockExchangePrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetStockExchangePrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeStockPrices GetStockExchangePrices (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)

#### Stock Prices by Exchange

Returns end-of-day stock prices for Securities on the Stock Exchange with `identifier` and on the `price_date` (or the latest date that prices are available)

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
  public class GetStockExchangePricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var stockExchangeApi = new StockExchangeApi();
      var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
      var date = "2018-08-14";  // DateTime? | The date for which to return prices (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseStockExchangeStockPrices result = stockExchangeApi.GetStockExchangePrices(identifier, date, pageSize, nextPage);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling StockExchangeApi.GetStockExchangePrices: " + e.Message );
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
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **date** | DateTime?| The date for which to return prices | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeStockPrices**](ApiResponseStockExchangeStockPrices.md)

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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetStockExchangeRealtimePrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, string source = null, int? pageSize = null, string nextPage = null)

#### Realtime Stock Prices by Exchange

Returns realtime stock prices for the Stock Exchange with the given `identifier`

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
  public class GetStockExchangeRealtimePricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var stockExchangeApi = new StockExchangeApi();
      var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
      var source = "";  // string | Return realtime prices from the specified data source (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseStockExchangeRealtimeStockPrices result = stockExchangeApi.GetStockExchangeRealtimePrices(identifier, source, pageSize, nextPage);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeRealtimePrices: " + e.Message );
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
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **source** | string| Return realtime prices from the specified data source | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetStockExchangeSecurities_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetStockExchangeSecuritiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var stockExchangeApi = new StockExchangeApi();
      var identifier = "USCOMP";  // string | A Stock Exchange identifier (MIC or Intrinio ID)
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseStockExchangeSecurities result = stockExchangeApi.GetStockExchangeSecurities(identifier, pageSize, nextPage);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeSecurities: " + e.Message );
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
 **identifier** | string| A Stock Exchange identifier (MIC or Intrinio ID) |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockExchangeSecurities**](ApiResponseStockExchangeSecurities.md)

[//]: # (END_OPERATION)


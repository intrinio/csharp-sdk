# Intrinio.Api.StockExchangeApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterStockExchanges**](StockExchangeApi.md#filterstockexchanges) | **GET** /stock_exchanges/filter | Filter Stock Exchanges
[**GetAllStockExchanges**](StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | Get All Stock Exchanges
[**GetStockExchangeById**](StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Get Stock Exchange by ID
[**GetStockExchangePriceAdjustments**](StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Get Stock Price Adjustments by Exchange
[**GetStockExchangePrices**](StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Get Stock Prices by Exchange
[**GetStockExchangeSecurities**](StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Get Securities by Exchange


<a name="filterstockexchanges"></a>
# **FilterStockExchanges**
> InlineResponse20028 FilterStockExchanges (string city = null, string country = null, string countryCode = null)

Filter Stock Exchanges

Return Stock Exchanges matching the given filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class FilterStockExchangesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var city = city_example;  // string | Filter by city (optional) 
            var country = country_example;  // string | Filter by country (optional) 
            var countryCode = countryCode_example;  // string | Filter by ISO country code (optional) 

            try
            {
                InlineResponse20028 result = stockExchangeApi.FilterStockExchanges(city, country, countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.FilterStockExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **city** | **string**| Filter by city | [optional] 
 **country** | **string**| Filter by country | [optional] 
 **countryCode** | **string**| Filter by ISO country code | [optional] 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

<a name="getallstockexchanges"></a>
# **GetAllStockExchanges**
> InlineResponse20028 GetAllStockExchanges ()

Get All Stock Exchanges

Return All Stock Exchanges

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllStockExchangesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();

            try
            {
                InlineResponse20028 result = stockExchangeApi.GetAllStockExchanges();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetAllStockExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

<a name="getstockexchangebyid"></a>
# **GetStockExchangeById**
> StockExchange GetStockExchangeById (string identifier)

Get Stock Exchange by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockExchangeByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = identifier_example;  // string | A Stock Exchange identifier (MIC or Intrinio ID)

            try
            {
                StockExchange result = stockExchangeApi.GetStockExchangeById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 

### Return type

[**StockExchange**](StockExchange.md)

<a name="getstockexchangepriceadjustments"></a>
# **GetStockExchangePriceAdjustments**
> InlineResponse20030 GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, string nextPage = null)

Get Stock Price Adjustments by Exchange

Return stock price adjustments for the Stock Exchange with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockExchangePriceAdjustmentsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = identifier_example;  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var date = 2013-10-20;  // DateTime? | The date for which to return price adjustments (optional) 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                InlineResponse20030 result = stockExchangeApi.GetStockExchangePriceAdjustments(identifier, date, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangePriceAdjustments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **date** | **DateTime?**| The date for which to return price adjustments | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

<a name="getstockexchangeprices"></a>
# **GetStockExchangePrices**
> InlineResponse20029 GetStockExchangePrices (string identifier, DateTime? date = null, string nextPage = null)

Get Stock Prices by Exchange

Return daily Stock Prices for Securities on the Stock Exchange with `identifier` and on the `price_date` (or the latest date that prices are available)

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockExchangePricesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = identifier_example;  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var date = 2013-10-20;  // DateTime? | The date for which to return prices (optional) 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                InlineResponse20029 result = stockExchangeApi.GetStockExchangePrices(identifier, date, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangePrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **date** | **DateTime?**| The date for which to return prices | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

<a name="getstockexchangesecurities"></a>
# **GetStockExchangeSecurities**
> InlineResponse20031 GetStockExchangeSecurities (string identifier, string nextPage = null)

Get Securities by Exchange

Return Securities traded on the Stock Exchange with `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStockExchangeSecuritiesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var stockExchangeApi = new StockExchangeApi();
            var identifier = identifier_example;  // string | A Stock Exchange identifier (MIC or Intrinio ID)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                InlineResponse20031 result = stockExchangeApi.GetStockExchangeSecurities(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StockExchangeApi.GetStockExchangeSecurities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Stock Exchange identifier (MIC or Intrinio ID) | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**InlineResponse20031**](InlineResponse20031.md)


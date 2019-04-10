# Intrinio.SDK.Api.CryptoApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCryptoBookAsks**](CryptoApi.md#getcryptobookasks) | **GET** /crypto/book/asks | Crypto Book Asks
[**GetCryptoBookBids**](CryptoApi.md#getcryptobookbids) | **GET** /crypto/book/bids | Crypto Book Bids
[**GetCryptoBookSummary**](CryptoApi.md#getcryptobooksummary) | **GET** /crypto/book | Crypto Book Summary
[**GetCryptoCurrencies**](CryptoApi.md#getcryptocurrencies) | **GET** /crypto/currencies | Crypto Currencies
[**GetCryptoExchanges**](CryptoApi.md#getcryptoexchanges) | **GET** /crypto/exchanges | Crypto Exchanges
[**GetCryptoPairs**](CryptoApi.md#getcryptopairs) | **GET** /crypto/pairs | Crypto Pairs
[**GetCryptoPrices**](CryptoApi.md#getcryptoprices) | **GET** /crypto/prices | Crypto Prices
[**GetCryptoSnapshot**](CryptoApi.md#getcryptosnapshot) | **GET** /crypto/snapshot | Crypto Snapshot
[**GetCryptoStats**](CryptoApi.md#getcryptostats) | **GET** /crypto/stats | Crypto Stats


<a name="getcryptobookasks"></a>
# **GetCryptoBookAsks**
> ApiResponseCryptoBookAsks GetCryptoBookAsks (string pair = null, string exchange = null, string currency = null)

Crypto Book Asks

Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoBookAsksExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var pair = "btcusd";  // string | Return the order book asks for the given Crypto Currency Pair. (optional) 
            var exchange = "gemini";  // string | Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Return the order book asks for the given Crypto Currency. (optional) 

            try
            {
                ApiResponseCryptoBookAsks result = cryptoApi.GetCryptoBookAsks(pair, exchange, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoBookAsks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | **string**| Return the order book asks for the given Crypto Currency Pair. | [optional] 
 **exchange** | **string**| Return the order book asks for a Crypto Currency on the given Crypto Exchange. | [optional] 
 **currency** | **string**| Return the order book asks for the given Crypto Currency. | [optional] 

### Return type

[**ApiResponseCryptoBookAsks**](ApiResponseCryptoBookAsks.md)

<a name="getcryptobookbids"></a>
# **GetCryptoBookBids**
> ApiResponseCryptoBookBids GetCryptoBookBids (string pair = null, string exchange = null, string currency = null)

Crypto Book Bids

Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoBookBidsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var pair = "btcusd";  // string | Return the order book bids for the given Crypto Currency Pair. (optional) 
            var exchange = "gemini";  // string | Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Return the order book bids for the given Crypto Currency. (optional) 

            try
            {
                ApiResponseCryptoBookBids result = cryptoApi.GetCryptoBookBids(pair, exchange, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoBookBids: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | **string**| Return the order book bids for the given Crypto Currency Pair. | [optional] 
 **exchange** | **string**| Return the order book bids for a Crypto Currency on the given Crypto Exchange. | [optional] 
 **currency** | **string**| Return the order book bids for the given Crypto Currency. | [optional] 

### Return type

[**ApiResponseCryptoBookBids**](ApiResponseCryptoBookBids.md)

<a name="getcryptobooksummary"></a>
# **GetCryptoBookSummary**
> ApiResponseCryptoBook GetCryptoBookSummary (int? levels = null, string pair = null, string exchange = null, string currency = null)

Crypto Book Summary

Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoBookSummaryExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var levels = 50;  // int? | The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional) 
            var pair = "btcusd";  // string | Return the order book summary for the given Crypto Currency Pair. (optional) 
            var exchange = "gemini";  // string | Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Return the order book summary for the given Crypto Currency. (optional) 

            try
            {
                ApiResponseCryptoBook result = cryptoApi.GetCryptoBookSummary(levels, pair, exchange, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoBookSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **levels** | **int?**| The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. | [optional] 
 **pair** | **string**| Return the order book summary for the given Crypto Currency Pair. | [optional] 
 **exchange** | **string**| Return the order book summary for a Crypto Currency on the given Crypto Exchange. | [optional] 
 **currency** | **string**| Return the order book summary for the given Crypto Currency. | [optional] 

### Return type

[**ApiResponseCryptoBook**](ApiResponseCryptoBook.md)

<a name="getcryptocurrencies"></a>
# **GetCryptoCurrencies**
> ApiResponseCryptoCurrencies GetCryptoCurrencies (string exchange = null)

Crypto Currencies

Returns a list of Crypto Currencies for which prices are available.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoCurrenciesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var exchange = "gemini";  // string | Returns Crypto Currencies traded on the given Crypto Exchange. (optional) 

            try
            {
                ApiResponseCryptoCurrencies result = cryptoApi.GetCryptoCurrencies(exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoCurrencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| Returns Crypto Currencies traded on the given Crypto Exchange. | [optional] 

### Return type

[**ApiResponseCryptoCurrencies**](ApiResponseCryptoCurrencies.md)

<a name="getcryptoexchanges"></a>
# **GetCryptoExchanges**
> ApiResponseCryptoExchanges GetCryptoExchanges (string pair = null)

Crypto Exchanges

Returns a list of Crypto Exchanges for which prices are available.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoExchangesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var pair = "btcusd";  // string | Returns Crypto Currencies traded on the given Crypto Exchange. (optional) 

            try
            {
                ApiResponseCryptoExchanges result = cryptoApi.GetCryptoExchanges(pair);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoExchanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | **string**| Returns Crypto Currencies traded on the given Crypto Exchange. | [optional] 

### Return type

[**ApiResponseCryptoExchanges**](ApiResponseCryptoExchanges.md)

<a name="getcryptopairs"></a>
# **GetCryptoPairs**
> ApiResponseCryptoPairs GetCryptoPairs (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null)

Crypto Pairs

Returns a list of Crypto Currency Pairs for which data is available.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoPairsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var exchange = "gemini";  // string | Return pairs traded on the given Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Return pairs with one side being the given Crypto Currency. (optional) 
            var pageSize = 100;  // int? | An integer greater than or equal to 1 for specifying the number of results on each page. (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCryptoPairs result = cryptoApi.GetCryptoPairs(exchange, currency, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoPairs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| Return pairs traded on the given Crypto Exchange. | [optional] 
 **currency** | **string**| Return pairs with one side being the given Crypto Currency. | [optional] 
 **pageSize** | **int?**| An integer greater than or equal to 1 for specifying the number of results on each page. | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCryptoPairs**](ApiResponseCryptoPairs.md)

<a name="getcryptoprices"></a>
# **GetCryptoPrices**
> ApiResponseCryptoPrices GetCryptoPrices (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)

Crypto Prices

Returns a list of available Crypto Currency Prices.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoPricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var timeframe = "h1";  // string | The time interval for the prices.
            var pair = "btcusd";  // string | Return prices for the given Crypto Currency Pair. (optional) 
            var exchange = "gemini";  // string | Return prices for a Crypto Currency on the given Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Return prices for the given Crypto Currency. (optional) 
            var timezone = "UTC";  // string | Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional)  (default to UTC)
            var startDate = "2018-01-01";  // string | Return Crypto Prices on or after this date. (optional) 
            var startTime = "14:20:00";  // string | Return Crypto Prices at or after this time (24-hour). (optional) 
            var endDate = "2019-01-01";  // string | Return Crypto Prices on or before this date. (optional) 
            var endTime = "21:01:21";  // string | Return Crypto Prices at or before this time (24-hour). (optional) 
            var pageSize = 100;  // int? | An integer greater than or equal to 1 for specifying the number of results on each page. (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCryptoPrices result = cryptoApi.GetCryptoPrices(timeframe, pair, exchange, currency, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoPrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeframe** | **string**| The time interval for the prices. | 
 **pair** | **string**| Return prices for the given Crypto Currency Pair. | [optional] 
 **exchange** | **string**| Return prices for a Crypto Currency on the given Crypto Exchange. | [optional] 
 **currency** | **string**| Return prices for the given Crypto Currency. | [optional] 
 **timezone** | **string**| Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. | [optional] [default to UTC]
 **startDate** | **string**| Return Crypto Prices on or after this date. | [optional] 
 **startTime** | **string**| Return Crypto Prices at or after this time (24-hour). | [optional] 
 **endDate** | **string**| Return Crypto Prices on or before this date. | [optional] 
 **endTime** | **string**| Return Crypto Prices at or before this time (24-hour). | [optional] 
 **pageSize** | **int?**| An integer greater than or equal to 1 for specifying the number of results on each page. | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCryptoPrices**](ApiResponseCryptoPrices.md)

<a name="getcryptosnapshot"></a>
# **GetCryptoSnapshot**
> ApiResponseCryptoSnapshot GetCryptoSnapshot (string pair = null, string exchange = null, string currency = null)

Crypto Snapshot

Returns a market snapshot over that last 24 hours for the given currency pair and exchange.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoSnapshotExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var pair = "btcusd";  // string | Return the snapshot for the given Crypto Currency Pair. (optional) 
            var exchange = "gemini";  // string | Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Return the snapshot for the given Crypto Currency. (optional) 

            try
            {
                ApiResponseCryptoSnapshot result = cryptoApi.GetCryptoSnapshot(pair, exchange, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoSnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pair** | **string**| Return the snapshot for the given Crypto Currency Pair. | [optional] 
 **exchange** | **string**| Return the snapshot for a Crypto Currency on the given Crypto Exchange. | [optional] 
 **currency** | **string**| Return the snapshot for the given Crypto Currency. | [optional] 

### Return type

[**ApiResponseCryptoSnapshot**](ApiResponseCryptoSnapshot.md)

<a name="getcryptostats"></a>
# **GetCryptoStats**
> ApiResponseCryptoStats GetCryptoStats (string exchange = null, string currency = null)

Crypto Stats

Returns available stats on Crypto Currencies.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetCryptoStatsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var cryptoApi = new CryptoApi();
            var exchange = "gemini";  // string | Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional) 
            var currency = "BTC";  // string | Returns stats for the specified Crypto Currency. (optional) 

            try
            {
                ApiResponseCryptoStats result = cryptoApi.GetCryptoStats(exchange, currency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CryptoApi.GetCryptoStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exchange** | **string**| Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. | [optional] 
 **currency** | **string**| Returns stats for the specified Crypto Currency. | [optional] 

### Return type

[**ApiResponseCryptoStats**](ApiResponseCryptoStats.md)


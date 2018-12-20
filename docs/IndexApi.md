# Intrinio.SDK.Api.IndexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEconomicIndices**](IndexApi.md#getalleconomicindices) | **GET** /indices/economic | Get All Economic Indices
[**GetAllSicIndices**](IndexApi.md#getallsicindices) | **GET** /indices/sic | Get All SIC Indices
[**GetAllStockMarketIndices**](IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | Get All Stock Market Indices
[**GetEconomicIndexById**](IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Get an Economic Index by ID
[**GetEconomicIndexDataPointNumber**](IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Get Economic Index Data Point (Number)
[**GetEconomicIndexDataPointText**](IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Get Economic Index Data Point (Text)
[**GetEconomicIndexHistoricalData**](IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Get Economic Index Historical Data
[**GetSicIndexById**](IndexApi.md#getsicindexbyid) | **GET** /indices/sic/{identifier} | Get an SIC Index by ID
[**GetSicIndexDataPointNumber**](IndexApi.md#getsicindexdatapointnumber) | **GET** /indices/sic/{identifier}/data_point/{tag}/number | Get SIC Index Data Point (Number)
[**GetSicIndexDataPointText**](IndexApi.md#getsicindexdatapointtext) | **GET** /indices/sic/{identifier}/data_point/{tag}/text | Get SIC Index Data Point (Text)
[**GetSicIndexHistoricalData**](IndexApi.md#getsicindexhistoricaldata) | **GET** /indices/sic/{identifier}/historical_data/{tag} | Get SIC Index Historical Data
[**GetStockMarketIndexById**](IndexApi.md#getstockmarketindexbyid) | **GET** /indices/stock_market/{identifier} | Get a Stock Market Index by ID
[**GetStockMarketIndexDataPointNumber**](IndexApi.md#getstockmarketindexdatapointnumber) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/number | Get Stock Market Index Data Point (Number)
[**GetStockMarketIndexDataPointText**](IndexApi.md#getstockmarketindexdatapointtext) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/text | Get Stock Market Index Data Point (Text)
[**GetStockMarketIndexHistoricalData**](IndexApi.md#getstockmarketindexhistoricaldata) | **GET** /indices/stock_market/{identifier}/historical_data/{tag} | Get Stock Market Index Historical Data
[**SearchEconomicIndices**](IndexApi.md#searcheconomicindices) | **GET** /indices/economic/search | Search Economic Indices
[**SearchSicIndices**](IndexApi.md#searchsicindices) | **GET** /indices/sic/search | Search SIC Indices
[**SearchStockMarketsIndices**](IndexApi.md#searchstockmarketsindices) | **GET** /indices/stock_market/search | Search Stock Market Indices


<a name="getalleconomicindices"></a>
# **GetAllEconomicIndices**
> ApiResponseEconomicIndices GetAllEconomicIndices (string nextPage = null)

Get All Economic Indices

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllEconomicIndicesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseEconomicIndices result = indexApi.GetAllEconomicIndices(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetAllEconomicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseEconomicIndices**](ApiResponseEconomicIndices.md)

<a name="getallsicindices"></a>
# **GetAllSicIndices**
> ApiResponseSICIndices GetAllSicIndices (string nextPage = null)

Get All SIC Indices

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllSicIndicesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSICIndices result = indexApi.GetAllSicIndices(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetAllSicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSICIndices**](ApiResponseSICIndices.md)

<a name="getallstockmarketindices"></a>
# **GetAllStockMarketIndices**
> ApiResponseStockMarketIndices GetAllStockMarketIndices (string nextPage = null)

Get All Stock Market Indices

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllStockMarketIndicesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockMarketIndices result = indexApi.GetAllStockMarketIndices(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetAllStockMarketIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockMarketIndices**](ApiResponseStockMarketIndices.md)

<a name="geteconomicindexbyid"></a>
# **GetEconomicIndexById**
> EconomicIndex GetEconomicIndexById (string identifier)

Get an Economic Index by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetEconomicIndexByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)

            try
            {
                EconomicIndex result = indexApi.GetEconomicIndexById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 

### Return type

[**EconomicIndex**](EconomicIndex.md)

<a name="geteconomicindexdatapointnumber"></a>
# **GetEconomicIndexDataPointNumber**
> decimal? GetEconomicIndexDataPointNumber (string identifier, string tag)

Get Economic Index Data Point (Number)

Returns a numeric value for the given `tag` for the Economic Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetEconomicIndexDataPointNumberExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name

            try
            {
                decimal? result = indexApi.GetEconomicIndexDataPointNumber(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**decimal?**

<a name="geteconomicindexdatapointtext"></a>
# **GetEconomicIndexDataPointText**
> string GetEconomicIndexDataPointText (string identifier, string tag)

Get Economic Index Data Point (Text)

Returns a text value for the given `tag` for the Economic Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetEconomicIndexDataPointTextExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name

            try
            {
                string result = indexApi.GetEconomicIndexDataPointText(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**string**

<a name="geteconomicindexhistoricaldata"></a>
# **GetEconomicIndexHistoricalData**
> ApiResponseEconomicIndexHistoricalData GetEconomicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Economic Index Historical Data

Returns historical values for the given `tag` and the Economic Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetEconomicIndexHistoricalDataExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseEconomicIndexHistoricalData result = indexApi.GetEconomicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetEconomicIndexHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseEconomicIndexHistoricalData**](ApiResponseEconomicIndexHistoricalData.md)

<a name="getsicindexbyid"></a>
# **GetSicIndexById**
> SICIndex GetSicIndexById (string identifier)

Get an SIC Index by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSicIndexByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)

            try
            {
                SICIndex result = indexApi.GetSicIndexById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 

### Return type

[**SICIndex**](SICIndex.md)

<a name="getsicindexdatapointnumber"></a>
# **GetSicIndexDataPointNumber**
> decimal? GetSicIndexDataPointNumber (string identifier, string tag)

Get SIC Index Data Point (Number)

Returns a numeric value for the given `tag` for the SIC Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSicIndexDataPointNumberExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name

            try
            {
                decimal? result = indexApi.GetSicIndexDataPointNumber(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**decimal?**

<a name="getsicindexdatapointtext"></a>
# **GetSicIndexDataPointText**
> string GetSicIndexDataPointText (string identifier, string tag)

Get SIC Index Data Point (Text)

Returns a text value for the given `tag` for the SIC Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSicIndexDataPointTextExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name

            try
            {
                string result = indexApi.GetSicIndexDataPointText(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**string**

<a name="getsicindexhistoricaldata"></a>
# **GetSicIndexHistoricalData**
> ApiResponseSICIndexHistoricalData GetSicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get SIC Index Historical Data

Returns historical values for the given `tag` and the SIC Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSicIndexHistoricalDataExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "marketcap";  // string | An Intrinio data tag ID or code-name
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSICIndexHistoricalData result = indexApi.GetSicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetSicIndexHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSICIndexHistoricalData**](ApiResponseSICIndexHistoricalData.md)

<a name="getstockmarketindexbyid"></a>
# **GetStockMarketIndexById**
> StockMarketIndex GetStockMarketIndexById (string identifier)

Get a Stock Market Index by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockMarketIndexByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)

            try
            {
                StockMarketIndex result = indexApi.GetStockMarketIndexById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 

### Return type

[**StockMarketIndex**](StockMarketIndex.md)

<a name="getstockmarketindexdatapointnumber"></a>
# **GetStockMarketIndexDataPointNumber**
> decimal? GetStockMarketIndexDataPointNumber (string identifier, string tag)

Get Stock Market Index Data Point (Number)

Returns a numeric value for the given `tag` for the Stock Market Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockMarketIndexDataPointNumberExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name

            try
            {
                decimal? result = indexApi.GetStockMarketIndexDataPointNumber(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**decimal?**

<a name="getstockmarketindexdatapointtext"></a>
# **GetStockMarketIndexDataPointText**
> string GetStockMarketIndexDataPointText (string identifier, string tag)

Get Stock Market Index Data Point (Text)

Returns a text value for the given `tag` for the Stock Market Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockMarketIndexDataPointTextExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name

            try
            {
                string result = indexApi.GetStockMarketIndexDataPointText(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**string**

<a name="getstockmarketindexhistoricaldata"></a>
# **GetStockMarketIndexHistoricalData**
> ApiResponseStockMarketIndexHistoricalData GetStockMarketIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Stock Market Index Historical Data

Returns historical values for the given `tag` and the Stock Market Index with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetStockMarketIndexHistoricalDataExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)
            var tag = "level";  // string | An Intrinio data tag ID or code-name
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockMarketIndexHistoricalData result = indexApi.GetStockMarketIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.GetStockMarketIndexHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| An Index Identifier (symbol, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockMarketIndexHistoricalData**](ApiResponseStockMarketIndexHistoricalData.md)

<a name="searcheconomicindices"></a>
# **SearchEconomicIndices**
> ApiResponseEconomicIndices SearchEconomicIndices (string query)

Search Economic Indices

Searches for indices using the text in `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class SearchEconomicIndicesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var query = "GDP";  // string | Search query

            try
            {
                ApiResponseEconomicIndices result = indexApi.SearchEconomicIndices(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.SearchEconomicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search query | 

### Return type

[**ApiResponseEconomicIndices**](ApiResponseEconomicIndices.md)

<a name="searchsicindices"></a>
# **SearchSicIndices**
> ApiResponseSICIndices SearchSicIndices (string query)

Search SIC Indices

Searches for indices using the text in `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class SearchSicIndicesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var query = "agriculture";  // string | Search query

            try
            {
                ApiResponseSICIndices result = indexApi.SearchSicIndices(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.SearchSicIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search query | 

### Return type

[**ApiResponseSICIndices**](ApiResponseSICIndices.md)

<a name="searchstockmarketsindices"></a>
# **SearchStockMarketsIndices**
> ApiResponseStockMarketIndices SearchStockMarketsIndices (string query)

Search Stock Market Indices

Searches for indices using the text in `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class SearchStockMarketsIndicesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var indexApi = new IndexApi();
            var query = "dow";  // string | Search query

            try
            {
                ApiResponseStockMarketIndices result = indexApi.SearchStockMarketsIndices(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndexApi.SearchStockMarketsIndices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search query | 

### Return type

[**ApiResponseStockMarketIndices**](ApiResponseStockMarketIndices.md)


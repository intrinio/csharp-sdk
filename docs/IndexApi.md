# Intrinio.SDK.Api.IndexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEconomicIndices**](IndexApi.md#getalleconomicindices) | **GET** /indices/economic | All Economic Indices
[**GetAllSicIndices**](IndexApi.md#getallsicindices) | **GET** /indices/sic | All SIC Indices
[**GetAllStockMarketIndices**](IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | All Stock Market Indices
[**GetEconomicIndexById**](IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Lookup Economic Index
[**GetEconomicIndexDataPointNumber**](IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Data Point (Number) for an Economic Index
[**GetEconomicIndexDataPointText**](IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Data Point (Text) for an Economic Index
[**GetEconomicIndexHistoricalData**](IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Historical Data for an Economic Index
[**GetSicIndexById**](IndexApi.md#getsicindexbyid) | **GET** /indices/sic/{identifier} | Lookup SIC Index
[**GetSicIndexDataPointNumber**](IndexApi.md#getsicindexdatapointnumber) | **GET** /indices/sic/{identifier}/data_point/{tag}/number | Data Point (Number) for an SIC Index
[**GetSicIndexDataPointText**](IndexApi.md#getsicindexdatapointtext) | **GET** /indices/sic/{identifier}/data_point/{tag}/text | Data Point (Text) for an SIC Index
[**GetSicIndexHistoricalData**](IndexApi.md#getsicindexhistoricaldata) | **GET** /indices/sic/{identifier}/historical_data/{tag} | Historical Data for an SIC Index
[**GetStockMarketIndexById**](IndexApi.md#getstockmarketindexbyid) | **GET** /indices/stock_market/{identifier} | Lookup Stock Market Index
[**GetStockMarketIndexDataPointNumber**](IndexApi.md#getstockmarketindexdatapointnumber) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/number | Data Point (Number) for Stock Market Index
[**GetStockMarketIndexDataPointText**](IndexApi.md#getstockmarketindexdatapointtext) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/text | Data Point (Text) for Stock Market Index
[**GetStockMarketIndexHistoricalData**](IndexApi.md#getstockmarketindexhistoricaldata) | **GET** /indices/stock_market/{identifier}/historical_data/{tag} | Historical Data for Stock Market Index
[**SearchEconomicIndices**](IndexApi.md#searcheconomicindices) | **GET** /indices/economic/search | Search Economic Indices
[**SearchSicIndices**](IndexApi.md#searchsicindices) | **GET** /indices/sic/search | Search SIC Indices
[**SearchStockMarketsIndices**](IndexApi.md#searchstockmarketsindices) | **GET** /indices/stock_market/search | Search Stock Market Indices


<a name="getalleconomicindices"></a>
# **GetAllEconomicIndices**
> ApiResponseEconomicIndices GetAllEconomicIndices (int? pageSize = null, string nextPage = null)

All Economic Indices

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseEconomicIndices result = indexApi.GetAllEconomicIndices(pageSize, nextPage);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseEconomicIndices**](ApiResponseEconomicIndices.md)

<a name="getallsicindices"></a>
# **GetAllSicIndices**
> ApiResponseSICIndices GetAllSicIndices (int? pageSize = null, string nextPage = null)

All SIC Indices

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSICIndices result = indexApi.GetAllSicIndices(pageSize, nextPage);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSICIndices**](ApiResponseSICIndices.md)

<a name="getallstockmarketindices"></a>
# **GetAllStockMarketIndices**
> ApiResponseStockMarketIndices GetAllStockMarketIndices (int? pageSize = null, string nextPage = null)

All Stock Market Indices

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockMarketIndices result = indexApi.GetAllStockMarketIndices(pageSize, nextPage);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockMarketIndices**](ApiResponseStockMarketIndices.md)

<a name="geteconomicindexbyid"></a>
# **GetEconomicIndexById**
> EconomicIndex GetEconomicIndexById (string identifier)

Lookup Economic Index

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

Data Point (Number) for an Economic Index

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
            var tag = "level";  // string | An Intrinio data tag <a href='https://data.intrinio.com/data-tags/economic'>reference</a>

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
 **tag** | **string**| An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;reference&lt;/a&gt; | 

### Return type

**decimal?**

<a name="geteconomicindexdatapointtext"></a>
# **GetEconomicIndexDataPointText**
> string GetEconomicIndexDataPointText (string identifier, string tag)

Data Point (Text) for an Economic Index

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
> ApiResponseEconomicIndexHistoricalData GetEconomicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

Historical Data for an Economic Index

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
            var tag = "level";  // string | An Intrinio data tag <a href='https://data.intrinio.com/data-tags/economic'>reference</a>
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseEconomicIndexHistoricalData result = indexApi.GetEconomicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **tag** | **string**| An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;reference&lt;/a&gt; | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseEconomicIndexHistoricalData**](ApiResponseEconomicIndexHistoricalData.md)

<a name="getsicindexbyid"></a>
# **GetSicIndexById**
> SICIndex GetSicIndexById (string identifier)

Lookup SIC Index

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

Data Point (Number) for an SIC Index

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

Data Point (Text) for an SIC Index

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
> ApiResponseSICIndexHistoricalData GetSicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

Historical Data for an SIC Index

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
            var endDate = "";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSICIndexHistoricalData result = indexApi.GetSicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSICIndexHistoricalData**](ApiResponseSICIndexHistoricalData.md)

<a name="getstockmarketindexbyid"></a>
# **GetStockMarketIndexById**
> StockMarketIndex GetStockMarketIndexById (string identifier)

Lookup Stock Market Index

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

Data Point (Number) for Stock Market Index

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

Data Point (Text) for Stock Market Index

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
> ApiResponseStockMarketIndexHistoricalData GetStockMarketIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

Historical Data for Stock Market Index

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
            var endDate = "";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseStockMarketIndexHistoricalData result = indexApi.GetStockMarketIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseStockMarketIndexHistoricalData**](ApiResponseStockMarketIndexHistoricalData.md)

<a name="searcheconomicindices"></a>
# **SearchEconomicIndices**
> ApiResponseEconomicIndicesSearch SearchEconomicIndices (string query, int? pageSize = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseEconomicIndicesSearch result = indexApi.SearchEconomicIndices(query, pageSize);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseEconomicIndicesSearch**](ApiResponseEconomicIndicesSearch.md)

<a name="searchsicindices"></a>
# **SearchSicIndices**
> ApiResponseSICIndicesSearch SearchSicIndices (string query, int? pageSize = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseSICIndicesSearch result = indexApi.SearchSicIndices(query, pageSize);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseSICIndicesSearch**](ApiResponseSICIndicesSearch.md)

<a name="searchstockmarketsindices"></a>
# **SearchStockMarketsIndices**
> ApiResponseStockMarketIndicesSearch SearchStockMarketsIndices (string query, int? pageSize = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseStockMarketIndicesSearch result = indexApi.SearchStockMarketsIndices(query, pageSize);
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseStockMarketIndicesSearch**](ApiResponseStockMarketIndicesSearch.md)


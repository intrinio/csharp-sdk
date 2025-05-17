# Intrinio.SDK.Api.IndexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEconomicIndices**](IndexApi.md#getalleconomicindices) | **GET** /indices/economic | All Economic Indices
[**GetAllEodIndexPrices**](IndexApi.md#getalleodindexprices) | **GET** /indices/prices/eod | All End of Day Index Prices
[**GetAllIndexSummaries**](IndexApi.md#getallindexsummaries) | **GET** /indices | All Index Summaries
[**GetAllRealtimeIndexPrices**](IndexApi.md#getallrealtimeindexprices) | **GET** /indices/prices/realtime | All Realtime Index Prices
[**GetAllSicIndices**](IndexApi.md#getallsicindices) | **GET** /indices/sic | All SIC Indices
[**GetAllStockMarketIndices**](IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | All Stock Market Indices
[**GetEconomicIndexById**](IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Lookup Economic Index
[**GetEconomicIndexDataPointNumber**](IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Data Point (Number) for an Economic Index
[**GetEconomicIndexDataPointText**](IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Data Point (Text) for an Economic Index
[**GetEconomicIndexHistoricalData**](IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Historical Data for an Economic Index
[**GetEodIndexPriceById**](IndexApi.md#geteodindexpricebyid) | **GET** /indices/{identifier}/eod | End of Day Index Prices By Identifier
[**GetIndexConstituentsById**](IndexApi.md#getindexconstituentsbyid) | **GET** /indices/{identifier}/constituents | Index Constituents By Index Identifier
[**GetIndexIntervals**](IndexApi.md#getindexintervals) | **GET** /indices/{identifier}/intervals | Index Intervals
[**GetIndexSummaryById**](IndexApi.md#getindexsummarybyid) | **GET** /indices/{identifier} | Index Summary By Identifier
[**GetRealtimeIndexPriceById**](IndexApi.md#getrealtimeindexpricebyid) | **GET** /indices/{identifier}/realtime | Realtime Index Price By Identifier
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



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllEconomicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEconomicIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEconomicIndices.md)

[//]: # (OPERATION:GetAllEconomicIndices_v2)

[//]: # (ENDPOINT:/indices/economic)

[//]: # (DOCUMENT_LINK:IndexApi.md#getalleconomicindices)

<a name="getalleconomicindices"></a>
## **GetAllEconomicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllEconomicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEconomicIndices GetAllEconomicIndices (int? pageSize = null, string nextPage = null)

#### All Economic Indices

Returns a list of reference data on more than 200,000 economic indices from the Federal Reserve Economic Data (FRED) database.

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
  public class GetAllEconomicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseEconomicIndices result = indexApi.GetAllEconomicIndices(pageSize, nextPage);
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEconomicIndices**](ApiResponseEconomicIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllEodIndexPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEodIndexPricesAll)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEodIndexPricesAll.md)

[//]: # (OPERATION:GetAllEodIndexPrices_v2)

[//]: # (ENDPOINT:/indices/prices/eod)

[//]: # (DOCUMENT_LINK:IndexApi.md#getalleodindexprices)

<a name="getalleodindexprices"></a>
## **GetAllEodIndexPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllEodIndexPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEodIndexPricesAll GetAllEodIndexPrices (int? pageSize = null, DateTime? startDate = null, DateTime? endDate = null)

#### All End of Day Index Prices


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
  public class GetAllEodIndexPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      int? pageSize = 100;
      DateTime? startDate = null;
      DateTime? endDate = null;
      
      ApiResponseEodIndexPricesAll result = indexApi.GetAllEodIndexPrices(pageSize, startDate, endDate);
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **startDate** | DateTime?| Limit prices to those on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Limit prices to those on or before this date | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEodIndexPricesAll**](ApiResponseEodIndexPricesAll.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllIndexSummaries)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseIndices.md)

[//]: # (OPERATION:GetAllIndexSummaries_v2)

[//]: # (ENDPOINT:/indices)

[//]: # (DOCUMENT_LINK:IndexApi.md#getallindexsummaries)

<a name="getallindexsummaries"></a>
## **GetAllIndexSummaries**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllIndexSummaries_v2)

[//]: # (START_OVERVIEW)

> ApiResponseIndices GetAllIndexSummaries (int? pageSize = null)

#### All Index Summaries


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
  public class GetAllIndexSummariesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      int? pageSize = 100;
      
      ApiResponseIndices result = indexApi.GetAllIndexSummaries(pageSize);
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseIndices**](ApiResponseIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllRealtimeIndexPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseRealtimeIndexPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseRealtimeIndexPrices.md)

[//]: # (OPERATION:GetAllRealtimeIndexPrices_v2)

[//]: # (ENDPOINT:/indices/prices/realtime)

[//]: # (DOCUMENT_LINK:IndexApi.md#getallrealtimeindexprices)

<a name="getallrealtimeindexprices"></a>
## **GetAllRealtimeIndexPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllRealtimeIndexPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseRealtimeIndexPrices GetAllRealtimeIndexPrices (int? pageSize = null)

#### All Realtime Index Prices


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
  public class GetAllRealtimeIndexPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      int? pageSize = 100;
      
      ApiResponseRealtimeIndexPrices result = indexApi.GetAllRealtimeIndexPrices(pageSize);
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseRealtimeIndexPrices**](ApiResponseRealtimeIndexPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllSicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSICIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSICIndices.md)

[//]: # (OPERATION:GetAllSicIndices_v2)

[//]: # (ENDPOINT:/indices/sic)

[//]: # (DOCUMENT_LINK:IndexApi.md#getallsicindices)

<a name="getallsicindices"></a>
## **GetAllSicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllSicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSICIndices GetAllSicIndices (int? pageSize = null, string nextPage = null)

#### All SIC Indices


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
  public class GetAllSicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSICIndices result = indexApi.GetAllSicIndices(pageSize, nextPage);
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSICIndices**](ApiResponseSICIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllStockMarketIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockMarketIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockMarketIndices.md)

[//]: # (OPERATION:GetAllStockMarketIndices_v2)

[//]: # (ENDPOINT:/indices/stock_market)

[//]: # (DOCUMENT_LINK:IndexApi.md#getallstockmarketindices)

<a name="getallstockmarketindices"></a>
## **GetAllStockMarketIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllStockMarketIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockMarketIndices GetAllStockMarketIndices (int? pageSize = null, string nextPage = null)

#### All Stock Market Indices


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
  public class GetAllStockMarketIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockMarketIndices result = indexApi.GetAllStockMarketIndices(pageSize, nextPage);
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockMarketIndices**](ApiResponseStockMarketIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.EconomicIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:EconomicIndex.md)

[//]: # (OPERATION:GetEconomicIndexById_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexbyid)

<a name="geteconomicindexbyid"></a>
## **GetEconomicIndexById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexById_v2)

[//]: # (START_OVERVIEW)

> EconomicIndex GetEconomicIndexById (string identifier)

#### Lookup Economic Index

Returns reference data for a specified Federal Reserve Economic Data (FRED) series ID.

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
  public class GetEconomicIndexByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$GDP";
      
      EconomicIndex result = indexApi.GetEconomicIndexById(identifier);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**EconomicIndex**](EconomicIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetEconomicIndexDataPointNumber_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexdatapointnumber)

<a name="geteconomicindexdatapointnumber"></a>
## **GetEconomicIndexDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetEconomicIndexDataPointNumber (string identifier, string tag)

#### Data Point (Number) for an Economic Index

Returns latest data for a specified Federal Reserve Economic Data (FRED) ID.

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
  public class GetEconomicIndexDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$GDP";
      string tag = "level";
      
      decimal? result = indexApi.GetEconomicIndexDataPointNumber(identifier, tag);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;reference&lt;/a&gt; |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetEconomicIndexDataPointText_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexdatapointtext)

<a name="geteconomicindexdatapointtext"></a>
## **GetEconomicIndexDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetEconomicIndexDataPointText (string identifier, string tag)

#### Data Point (Text) for an Economic Index

Returns a text value for the given `tag` for the Economic Index with the given `identifier`

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
  public class GetEconomicIndexDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$GDP";
      string tag = "level";
      
      string result = indexApi.GetEconomicIndexDataPointText(identifier, tag);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEconomicIndexHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEconomicIndexHistoricalData.md)

[//]: # (OPERATION:GetEconomicIndexHistoricalData_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexhistoricaldata)

<a name="geteconomicindexhistoricaldata"></a>
## **GetEconomicIndexHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEconomicIndexHistoricalData GetEconomicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for an Economic Index

Returns historical data for a specified Federal Reserve Economic Data (FRED) ID over a period of time.

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
  public class GetEconomicIndexHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$GDP";
      string tag = "level";
      string type = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = null;
      string sortOrder = "desc";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseEconomicIndexHistoricalData result = indexApi.GetEconomicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;reference&lt;/a&gt; |  &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEconomicIndexHistoricalData**](ApiResponseEconomicIndexHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEodIndexPriceById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEodIndexPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEodIndexPrices.md)

[//]: # (OPERATION:GetEodIndexPriceById_v2)

[//]: # (ENDPOINT:/indices/{identifier}/eod)

[//]: # (DOCUMENT_LINK:IndexApi.md#geteodindexpricebyid)

<a name="geteodindexpricebyid"></a>
## **GetEodIndexPriceById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEodIndexPriceById_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEodIndexPrices GetEodIndexPriceById (string identifier, int? pageSize = null, DateTime? startDate = null, DateTime? endDate = null)

#### End of Day Index Prices By Identifier


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
  public class GetEodIndexPriceByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "SPX";
      int? pageSize = 100;
      DateTime? startDate = null;
      DateTime? endDate = null;
      
      ApiResponseEodIndexPrices result = indexApi.GetEodIndexPriceById(identifier, pageSize, startDate, endDate);
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
 **identifier** | string| The index symbol |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **startDate** | DateTime?| Limit prices to those on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Limit prices to those on or before this date | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEodIndexPrices**](ApiResponseEodIndexPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetIndexConstituentsById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseIndexConstituents)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseIndexConstituents.md)

[//]: # (OPERATION:GetIndexConstituentsById_v2)

[//]: # (ENDPOINT:/indices/{identifier}/constituents)

[//]: # (DOCUMENT_LINK:IndexApi.md#getindexconstituentsbyid)

<a name="getindexconstituentsbyid"></a>
## **GetIndexConstituentsById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetIndexConstituentsById_v2)

[//]: # (START_OVERVIEW)

> ApiResponseIndexConstituents GetIndexConstituentsById (string identifier)

#### Index Constituents By Index Identifier


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
  public class GetIndexConstituentsByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "DJI";
      
      ApiResponseIndexConstituents result = indexApi.GetIndexConstituentsById(identifier);
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
 **identifier** | string| The index symbol |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseIndexConstituents**](ApiResponseIndexConstituents.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetIndexIntervals)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseIndexIntervals)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseIndexIntervals.md)

[//]: # (OPERATION:GetIndexIntervals_v2)

[//]: # (ENDPOINT:/indices/{identifier}/intervals)

[//]: # (DOCUMENT_LINK:IndexApi.md#getindexintervals)

<a name="getindexintervals"></a>
## **GetIndexIntervals**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetIndexIntervals_v2)

[//]: # (START_OVERVIEW)

> ApiResponseIndexIntervals GetIndexIntervals (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null)

#### Index Intervals

Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.

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
  public class GetIndexIntervalsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "SPX";
      string intervalSize = "15m";
      DateTime? startDate = DateTime.Parse("2023-01-01");
      string startTime = 33300;
      DateTime? endDate = DateTime.Parse("2023-02-01");
      string endTime = 33300;
      string timezone = "UTC";
      int? pageSize = 100;
      
      ApiResponseIndexIntervals result = indexApi.GetIndexIntervals(identifier, intervalSize, startDate, startTime, endDate, endTime, timezone, pageSize);
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
 **identifier** | string| The index identifier |  &nbsp;
 **intervalSize** | string| The interval size to return in minutes (m) or hour (h). | [default to 5m] &nbsp;
 **startDate** | DateTime?| Return intervals starting at the specified date | [optional]  &nbsp;
 **startTime** | string| Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) | [optional]  &nbsp;
 **endDate** | DateTime?| Return intervals stopping at the specified date | [optional]  &nbsp;
 **endTime** | string| Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) | [optional]  &nbsp;
 **timezone** | string| Interprets the input times in this time zone, as well as returns times in this timezone. | [optional] [default to UTC] &nbsp;
 **pageSize** | int?| The number of results to return per page. | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseIndexIntervals**](ApiResponseIndexIntervals.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetIndexSummaryById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseIndex.md)

[//]: # (OPERATION:GetIndexSummaryById_v2)

[//]: # (ENDPOINT:/indices/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#getindexsummarybyid)

<a name="getindexsummarybyid"></a>
## **GetIndexSummaryById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetIndexSummaryById_v2)

[//]: # (START_OVERVIEW)

> ApiResponseIndex GetIndexSummaryById (string identifier)

#### Index Summary By Identifier


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
  public class GetIndexSummaryByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "SPX";
      
      ApiResponseIndex result = indexApi.GetIndexSummaryById(identifier);
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
 **identifier** | string| The index symbol |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseIndex**](ApiResponseIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetRealtimeIndexPriceById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.RealtimeIndexPrice)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:RealtimeIndexPrice.md)

[//]: # (OPERATION:GetRealtimeIndexPriceById_v2)

[//]: # (ENDPOINT:/indices/{identifier}/realtime)

[//]: # (DOCUMENT_LINK:IndexApi.md#getrealtimeindexpricebyid)

<a name="getrealtimeindexpricebyid"></a>
## **GetRealtimeIndexPriceById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetRealtimeIndexPriceById_v2)

[//]: # (START_OVERVIEW)

> RealtimeIndexPrice GetRealtimeIndexPriceById (string identifier)

#### Realtime Index Price By Identifier

Returns the realtime price for an index.

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
  public class GetRealtimeIndexPriceByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "SPX";
      
      RealtimeIndexPrice result = indexApi.GetRealtimeIndexPriceById(identifier);
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
 **identifier** | string| The index symbol |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**RealtimeIndexPrice**](RealtimeIndexPrice.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.SICIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:SICIndex.md)

[//]: # (OPERATION:GetSicIndexById_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexbyid)

<a name="getsicindexbyid"></a>
## **GetSicIndexById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexById_v2)

[//]: # (START_OVERVIEW)

> SICIndex GetSicIndexById (string identifier)

#### Lookup SIC Index


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
  public class GetSicIndexByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$SIC.2911";
      
      SICIndex result = indexApi.GetSicIndexById(identifier);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**SICIndex**](SICIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetSicIndexDataPointNumber_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexdatapointnumber)

<a name="getsicindexdatapointnumber"></a>
## **GetSicIndexDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetSicIndexDataPointNumber (string identifier, string tag)

#### Data Point (Number) for an SIC Index

Returns a numeric value for the given `tag` for the SIC Index with the given `identifier`

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
  public class GetSicIndexDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$SIC.2911";
      string tag = "marketcap";
      
      decimal? result = indexApi.GetSicIndexDataPointNumber(identifier, tag);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetSicIndexDataPointText_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexdatapointtext)

<a name="getsicindexdatapointtext"></a>
## **GetSicIndexDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetSicIndexDataPointText (string identifier, string tag)

#### Data Point (Text) for an SIC Index

Returns a text value for the given `tag` for the SIC Index with the given `identifier`

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
  public class GetSicIndexDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$SIC.2911";
      string tag = "marketcap";
      
      string result = indexApi.GetSicIndexDataPointText(identifier, tag);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSICIndexHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSICIndexHistoricalData.md)

[//]: # (OPERATION:GetSicIndexHistoricalData_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexhistoricaldata)

<a name="getsicindexhistoricaldata"></a>
## **GetSicIndexHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSICIndexHistoricalData GetSicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for an SIC Index

Returns historical values for the given `tag` and the SIC Index with the given `identifier`

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
  public class GetSicIndexHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$SIC.1";
      string tag = "marketcap";
      string type = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = null;
      string sortOrder = "desc";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSICIndexHistoricalData result = indexApi.GetSicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSICIndexHistoricalData**](ApiResponseSICIndexHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.StockMarketIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:StockMarketIndex.md)

[//]: # (OPERATION:GetStockMarketIndexById_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexbyid)

<a name="getstockmarketindexbyid"></a>
## **GetStockMarketIndexById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexById_v2)

[//]: # (START_OVERVIEW)

> StockMarketIndex GetStockMarketIndexById (string identifier)

#### Lookup Stock Market Index


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
  public class GetStockMarketIndexByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$DJI";
      
      StockMarketIndex result = indexApi.GetStockMarketIndexById(identifier);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**StockMarketIndex**](StockMarketIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetStockMarketIndexDataPointNumber_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexdatapointnumber)

<a name="getstockmarketindexdatapointnumber"></a>
## **GetStockMarketIndexDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetStockMarketIndexDataPointNumber (string identifier, string tag)

#### Data Point (Number) for Stock Market Index

Returns a numeric value for the given `tag` for the Stock Market Index with the given `identifier`

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
  public class GetStockMarketIndexDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$DJI";
      string tag = "level";
      
      decimal? result = indexApi.GetStockMarketIndexDataPointNumber(identifier, tag);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetStockMarketIndexDataPointText_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexdatapointtext)

<a name="getstockmarketindexdatapointtext"></a>
## **GetStockMarketIndexDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetStockMarketIndexDataPointText (string identifier, string tag)

#### Data Point (Text) for Stock Market Index

Returns a text value for the given `tag` for the Stock Market Index with the given `identifier`

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
  public class GetStockMarketIndexDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$DJI";
      string tag = "level";
      
      string result = indexApi.GetStockMarketIndexDataPointText(identifier, tag);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockMarketIndexHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockMarketIndexHistoricalData.md)

[//]: # (OPERATION:GetStockMarketIndexHistoricalData_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexhistoricaldata)

<a name="getstockmarketindexhistoricaldata"></a>
## **GetStockMarketIndexHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockMarketIndexHistoricalData GetStockMarketIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for Stock Market Index

Returns historical values for the given `tag` and the Stock Market Index with the given `identifier`

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
  public class GetStockMarketIndexHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string identifier = "$DJI";
      string tag = "level";
      string type = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = null;
      string sortOrder = "desc";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseStockMarketIndexHistoricalData result = indexApi.GetStockMarketIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockMarketIndexHistoricalData**](ApiResponseStockMarketIndexHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:SearchEconomicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEconomicIndicesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEconomicIndicesSearch.md)

[//]: # (OPERATION:SearchEconomicIndices_v2)

[//]: # (ENDPOINT:/indices/economic/search)

[//]: # (DOCUMENT_LINK:IndexApi.md#searcheconomicindices)

<a name="searcheconomicindices"></a>
## **SearchEconomicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchEconomicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEconomicIndicesSearch SearchEconomicIndices (string query, int? pageSize = null)

#### Search Economic Indices

Search the Federal Reserve Economic Data (FRED) database and return a list of economic indices matching the text query parameter passed through.

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
  public class SearchEconomicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string query = "GDP";
      int? pageSize = 100;
      
      ApiResponseEconomicIndicesSearch result = indexApi.SearchEconomicIndices(query, pageSize);
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
 **query** | string| Search query |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEconomicIndicesSearch**](ApiResponseEconomicIndicesSearch.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:SearchSicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSICIndicesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSICIndicesSearch.md)

[//]: # (OPERATION:SearchSicIndices_v2)

[//]: # (ENDPOINT:/indices/sic/search)

[//]: # (DOCUMENT_LINK:IndexApi.md#searchsicindices)

<a name="searchsicindices"></a>
## **SearchSicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchSicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSICIndicesSearch SearchSicIndices (string query, int? pageSize = null)

#### Search SIC Indices

Searches for indices using the text in `query`

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
  public class SearchSicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string query = "agriculture";
      int? pageSize = 100;
      
      ApiResponseSICIndicesSearch result = indexApi.SearchSicIndices(query, pageSize);
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
 **query** | string| Search query |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSICIndicesSearch**](ApiResponseSICIndicesSearch.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:SearchStockMarketsIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockMarketIndicesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockMarketIndicesSearch.md)

[//]: # (OPERATION:SearchStockMarketsIndices_v2)

[//]: # (ENDPOINT:/indices/stock_market/search)

[//]: # (DOCUMENT_LINK:IndexApi.md#searchstockmarketsindices)

<a name="searchstockmarketsindices"></a>
## **SearchStockMarketsIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchStockMarketsIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockMarketIndicesSearch SearchStockMarketsIndices (string query, int? pageSize = null)

#### Search Stock Market Indices

Searches for indices using the text in `query`

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
  public class SearchStockMarketsIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var indexApi = new IndexApi();
      
      string query = "dow";
      int? pageSize = 100;
      
      ApiResponseStockMarketIndicesSearch result = indexApi.SearchStockMarketsIndices(query, pageSize);
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
 **query** | string| Search query |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockMarketIndicesSearch**](ApiResponseStockMarketIndicesSearch.md)

[//]: # (END_OPERATION)


# Intrinio.SDK.Api.ETFsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEtfs**](ETFsApi.md#getalletfs) | **GET** /etfs | All ETFs
[**GetEtf**](ETFsApi.md#getetf) | **GET** /etfs/{identifier} | Lookup ETF
[**GetEtfAnalytics**](ETFsApi.md#getetfanalytics) | **GET** /etfs/{identifier}/analytics | ETF Analytics
[**GetEtfHoldings**](ETFsApi.md#getetfholdings) | **GET** /etfs/{identifier}/holdings | ETF Holdings
[**GetEtfStats**](ETFsApi.md#getetfstats) | **GET** /etfs/{identifier}/stats | Exchange Traded Fund (ETF) stats
[**SearchEtfs**](ETFsApi.md#searchetfs) | **GET** /etfs/search | Search ETFs



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ETFsApi)

[//]: # (METHOD:GetAllEtfs)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseETFs)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseETFs.md)

[//]: # (OPERATION:GetAllEtfs_v2)

[//]: # (ENDPOINT:/etfs)

[//]: # (DOCUMENT_LINK:ETFsApi.md#getalletfs)

<a name="getalletfs"></a>
## **GetAllEtfs**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllEtfs_v2)

[//]: # (START_OVERVIEW)

> ApiResponseETFs GetAllEtfs (string exchange = null, int? pageSize = null, string nextPage = null)

#### All ETFs

Returns a list of Exchange Traded Funds (ETFs) sourced from FirstBridge

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
  public class GetAllEtfsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eTFsApi = new ETFsApi();
      
      string exchange = "XNAS";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseETFs result = eTFsApi.GetAllEtfs(exchange, pageSize, nextPage);
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
 **exchange** | string|  | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseETFs**](ApiResponseETFs.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ETFsApi)

[//]: # (METHOD:GetEtf)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ETF)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ETF.md)

[//]: # (OPERATION:GetEtf_v2)

[//]: # (ENDPOINT:/etfs/{identifier})

[//]: # (DOCUMENT_LINK:ETFsApi.md#getetf)

<a name="getetf"></a>
## **GetEtf**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEtf_v2)

[//]: # (START_OVERVIEW)

> ETF GetEtf (string identifier)

#### Lookup ETF

Returns the Exchange Traded Fund (ETF) with the given identifier

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
  public class GetEtfExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eTFsApi = new ETFsApi();
      
      string identifier = "SPY";
      
      ETF result = eTFsApi.GetEtf(identifier);
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
 **identifier** | string| An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ETF**](ETF.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ETFsApi)

[//]: # (METHOD:GetEtfAnalytics)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ETFAnalytics)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ETFAnalytics.md)

[//]: # (OPERATION:GetEtfAnalytics_v2)

[//]: # (ENDPOINT:/etfs/{identifier}/analytics)

[//]: # (DOCUMENT_LINK:ETFsApi.md#getetfanalytics)

<a name="getetfanalytics"></a>
## **GetEtfAnalytics**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEtfAnalytics_v2)

[//]: # (START_OVERVIEW)

> ETFAnalytics GetEtfAnalytics (string identifier)

#### ETF Analytics

Returns analytics for the Exchange Traded Fund (ETF) including volume, market cap, 52 week high, and 52 week low

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
  public class GetEtfAnalyticsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eTFsApi = new ETFsApi();
      
      string identifier = "SPY";
      
      ETFAnalytics result = eTFsApi.GetEtfAnalytics(identifier);
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
 **identifier** | string| An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ETFAnalytics**](ETFAnalytics.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ETFsApi)

[//]: # (METHOD:GetEtfHoldings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseETFHoldings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseETFHoldings.md)

[//]: # (OPERATION:GetEtfHoldings_v2)

[//]: # (ENDPOINT:/etfs/{identifier}/holdings)

[//]: # (DOCUMENT_LINK:ETFsApi.md#getetfholdings)

<a name="getetfholdings"></a>
## **GetEtfHoldings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEtfHoldings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseETFHoldings GetEtfHoldings (string identifier, int? pageSize = null, string nextPage = null)

#### ETF Holdings

Returns the holdings sorted by weight descending and the Exchange Traded Fund (ETF) summary

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
  public class GetEtfHoldingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eTFsApi = new ETFsApi();
      
      string identifier = "SPY";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseETFHoldings result = eTFsApi.GetEtfHoldings(identifier, pageSize, nextPage);
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
 **identifier** | string| An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID) |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseETFHoldings**](ApiResponseETFHoldings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ETFsApi)

[//]: # (METHOD:GetEtfStats)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ETFStats)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ETFStats.md)

[//]: # (OPERATION:GetEtfStats_v2)

[//]: # (ENDPOINT:/etfs/{identifier}/stats)

[//]: # (DOCUMENT_LINK:ETFsApi.md#getetfstats)

<a name="getetfstats"></a>
## **GetEtfStats**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEtfStats_v2)

[//]: # (START_OVERVIEW)

> ETFStats GetEtfStats (string identifier)

#### Exchange Traded Fund (ETF) stats

Returns daily stats for the Exchange Traded Fund (ETF) including net asset value, beta vs spy, returns, and volatility

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
  public class GetEtfStatsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eTFsApi = new ETFsApi();
      
      string identifier = "SPY";
      
      ETFStats result = eTFsApi.GetEtfStats(identifier);
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
 **identifier** | string| An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ETFStats**](ETFStats.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ETFsApi)

[//]: # (METHOD:SearchEtfs)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseETFs)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseETFs.md)

[//]: # (OPERATION:SearchEtfs_v2)

[//]: # (ENDPOINT:/etfs/search)

[//]: # (DOCUMENT_LINK:ETFsApi.md#searchetfs)

<a name="searchetfs"></a>
## **SearchEtfs**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchEtfs_v2)

[//]: # (START_OVERVIEW)

> ApiResponseETFs SearchEtfs (string query)

#### Search ETFs

Searches for Exchange Traded Funds (ETFs) matching the text `query`

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
  public class SearchEtfsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eTFsApi = new ETFsApi();
      
      string query = "iShares";
      
      ApiResponseETFs result = eTFsApi.SearchEtfs(query);
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
 **query** | string|  |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseETFs**](ApiResponseETFs.md)

[//]: # (END_OPERATION)


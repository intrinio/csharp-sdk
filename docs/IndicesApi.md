# Intrinio.SDK.Api.IndicesApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIndexIntervals**](IndicesApi.md#getindexintervals) | **GET** /indices/{identifier}/intervals | Index Intervals



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndicesApi)

[//]: # (METHOD:GetIndexIntervals)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseIndexIntervals)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseIndexIntervals.md)

[//]: # (OPERATION:GetIndexIntervals_v2)

[//]: # (ENDPOINT:/indices/{identifier}/intervals)

[//]: # (DOCUMENT_LINK:IndicesApi.md#getindexintervals)

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
      
      var indicesApi = new IndicesApi();
      
      string identifier = "SPX";
      string intervalSize = "15m";
      DateTime? startDate = DateTime.Parse("2023-01-01");
      string startTime = 33300;
      DateTime? endDate = DateTime.Parse("2023-02-01");
      string endTime = 33300;
      string timezone = "UTC";
      int? pageSize = 100;
      
      ApiResponseIndexIntervals result = indicesApi.GetIndexIntervals(identifier, intervalSize, startDate, startTime, endDate, endTime, timezone, pageSize);
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


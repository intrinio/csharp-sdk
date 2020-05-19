# Intrinio.SDK.Api.HistoricalDataApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricalData**](HistoricalDataApi.md#gethistoricaldata) | **GET** /historical_data/{identifier}/{tag} | Historical Data



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.HistoricalDataApi)

[//]: # (METHOD:GetHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseHistoricalData.md)

[//]: # (OPERATION:GetHistoricalData_v2)

[//]: # (ENDPOINT:/historical_data/{identifier}/{tag})

[//]: # (DOCUMENT_LINK:HistoricalDataApi.md#gethistoricaldata)

<a name="gethistoricaldata"></a>
## **GetHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseHistoricalData GetHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data

$$v2_historical_data_description$$

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
  public class GetHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var historicalDataApi = new HistoricalDataApi();
      var identifier = "$$v2_historical_data_identifier_default$$";  // string | $$v2_historical_data_identifier_description$$
      var tag = "$$v2_historical_data_item_default$$";  // string | $$v2_historical_data_item_description$$
      var frequency = "daily";  // string | Return historical data in the given frequency (optional)  (default to daily)
      var type = "";  // string | Filter by type, when applicable (optional) 
      var startDate = DateTime.Parse("2015-01-01");  // DateTime? | Get historical data on or after this date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Get historical date on or before this date (optional) 
      var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseHistoricalData result = historicalDataApi.GetHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling HistoricalDataApi.GetHistoricalData: " + e.Message );
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
 **identifier** | string| $$v2_historical_data_identifier_description$$ |  &nbsp;
 **tag** | string| $$v2_historical_data_item_description$$ |  &nbsp;
 **frequency** | string| Return historical data in the given frequency | [optional] [default to daily] &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical date on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseHistoricalData**](ApiResponseHistoricalData.md)

[//]: # (END_OPERATION)


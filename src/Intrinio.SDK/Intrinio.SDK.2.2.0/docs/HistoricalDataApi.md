# Intrinio.SDK.Api.HistoricalDataApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricalData**](HistoricalDataApi.md#gethistoricaldata) | **GET** /historical_data/{identifier}/{tag} | Historical Data


<a name="gethistoricaldata"></a>
# **GetHistoricalData**
> ApiResponseHistoricalData GetHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null, string nextPage = null)

Historical Data

$$v2_historical_data_description$$

### Example
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
            var startDate = "2015-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Get historical date on or before this date (optional) 
            var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseHistoricalData result = historicalDataApi.GetHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoricalDataApi.GetHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| $$v2_historical_data_identifier_description$$ | 
 **tag** | **string**| $$v2_historical_data_item_description$$ | 
 **frequency** | **string**| Return historical data in the given frequency | [optional] [default to daily]
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical date on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseHistoricalData**](ApiResponseHistoricalData.md)


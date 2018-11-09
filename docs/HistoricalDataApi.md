# Intrinio.Api.HistoricalDataApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHistoricalData**](HistoricalDataApi.md#gethistoricaldata) | **GET** /historical_data/{identifier}/{tag} | Get Historical Data


<a name="gethistoricaldata"></a>
# **GetHistoricalData**
> InlineResponse20013 GetHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Historical Data

Returns historical values for the given `tag` and the entity represented by the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var historicalDataApi = new HistoricalDataApi();
            var identifier = identifier_example;  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)
            var tag = tag_example;  // string | An Intrinio data tag ID or code-name
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical date on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                InlineResponse20013 result = historicalDataApi.GetHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
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
 **identifier** | **string**| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code-name | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical date on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)


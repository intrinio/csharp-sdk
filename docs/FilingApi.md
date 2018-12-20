# Intrinio.SDK.Api.FilingApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterFilings**](FilingApi.md#filterfilings) | **GET** /filings/filter | Filter Filings
[**GetAllFilings**](FilingApi.md#getallfilings) | **GET** /filings | Get All Filings
[**GetFilingById**](FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Get a Filing by ID


<a name="filterfilings"></a>
# **FilterFilings**
> ApiResponseFilings FilterFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

Filter Filings

Returns filings that match the specified filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class FilterFilingsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var company = "AAPL";  // string | Filings for the given `company` identifier (ticker, CIK, LEI, Intrinio ID)
            var reportType = "";  // string | Filter by report type (optional) 
            var startDate = "2015-01-01";  // DateTime? | Filed on or after the given date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Filed before or after the given date (optional) 
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilings result = filingApi.FilterFilings(company, reportType, startDate, endDate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.FilterFilings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) | 
 **reportType** | **string**| Filter by report type | [optional] 
 **startDate** | **DateTime?**| Filed on or after the given date | [optional] 
 **endDate** | **DateTime?**| Filed before or after the given date | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilings**](ApiResponseFilings.md)

<a name="getallfilings"></a>
# **GetAllFilings**
> ApiResponseFilings GetAllFilings (string nextPage = null)

Get All Filings

Returns all filings

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllFilingsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilings result = filingApi.GetAllFilings(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetAllFilings: " + e.Message );
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

[**ApiResponseFilings**](ApiResponseFilings.md)

<a name="getfilingbyid"></a>
# **GetFilingById**
> Filing GetFilingById (string id)

Get a Filing by ID

Return the filing with the given ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetFilingByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var id = "fil_7Kn2P6";  // string | The Intrinio ID of the Filing

            try
            {
                Filing result = filingApi.GetFilingById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetFilingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID of the Filing | 

### Return type

[**Filing**](Filing.md)


# Intrinio.Api.FilingApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterFilings**](FilingApi.md#filterfilings) | **GET** /filings/filter | Filter Filings
[**GetAllFilings**](FilingApi.md#getallfilings) | **GET** /filings | Get All Filings
[**GetFilingById**](FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Get a Filing by ID


<a name="filterfilings"></a>
# **FilterFilings**
> List<Filing> FilterFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

Filter Filings

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class FilterFilingsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var company = company_example;  // string | Filings for the given `company` identifier (ticker, CIK, LEI, Intrinio ID)
            var reportType = reportType_example;  // string | Filter by report type (optional) 
            var startDate = 2013-10-20;  // DateTime? | Filed on or after the given date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Filed before or after the given date (optional) 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;Filing&gt; result = filingApi.FilterFilings(company, reportType, startDate, endDate, nextPage);
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

[**List<Filing>**](Filing.md)

<a name="getallfilings"></a>
# **GetAllFilings**
> List<Filing> GetAllFilings (string nextPage = null)

Get All Filings

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllFilingsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;Filing&gt; result = filingApi.GetAllFilings(nextPage);
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

[**List<Filing>**](Filing.md)

<a name="getfilingbyid"></a>
# **GetFilingById**
> Filing GetFilingById (string id)

Get a Filing by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetFilingByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var id = id_example;  // string | The Intrinio ID of the Filing

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


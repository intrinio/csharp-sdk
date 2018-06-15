# Intrinio.Api.MutualFundApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllMutualFunds**](MutualFundApi.md#getallmutualfunds) | **GET** /mutual_funds | Get All Mutual Funds
[**GetMutualFundById**](MutualFundApi.md#getmutualfundbyid) | **GET** /mutual_funds/{identifier} | Get a Mutual Fund by ID
[**GetMutualFundStats**](MutualFundApi.md#getmutualfundstats) | **GET** /mutual_funds/{identifier}/stats | Get Stats for a Mutual Fund
[**SearchMutualFunds**](MutualFundApi.md#searchmutualfunds) | **GET** /mutual_funds/search | Search Mutual Funds


<a name="getallmutualfunds"></a>
# **GetAllMutualFunds**
> List<MutualFund> GetAllMutualFunds (string nextPage = null)

Get All Mutual Funds

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllMutualFundsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var mutualFundApi = new MutualFundApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;MutualFund&gt; result = mutualFundApi.GetAllMutualFunds(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MutualFundApi.GetAllMutualFunds: " + e.Message );
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

[**List<MutualFund>**](MutualFund.md)

<a name="getmutualfundbyid"></a>
# **GetMutualFundById**
> MutualFund GetMutualFundById (string identifier)

Get a Mutual Fund by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetMutualFundByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var mutualFundApi = new MutualFundApi();
            var identifier = identifier_example;  // string | A Mutual Fund identifier (CUSIP, Intrinio ID)

            try
            {
                MutualFund result = mutualFundApi.GetMutualFundById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MutualFundApi.GetMutualFundById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Mutual Fund identifier (CUSIP, Intrinio ID) | 

### Return type

[**MutualFund**](MutualFund.md)

<a name="getmutualfundstats"></a>
# **GetMutualFundStats**
> List<MutualFundStat> GetMutualFundStats (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

Get Stats for a Mutual Fund

Returns stats for the  Mutual Fund with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetMutualFundStatsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var mutualFundApi = new MutualFundApi();
            var identifier = identifier_example;  // string | A Mutual Fund identifier (CUSIP, Intrinio ID)
            var startDate = 2013-10-20;  // DateTime? | Return stats on or after the date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Return stats on or before the date (optional) 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;MutualFundStat&gt; result = mutualFundApi.GetMutualFundStats(identifier, startDate, endDate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MutualFundApi.GetMutualFundStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Mutual Fund identifier (CUSIP, Intrinio ID) | 
 **startDate** | **DateTime?**| Return stats on or after the date | [optional] 
 **endDate** | **DateTime?**| Return stats on or before the date | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<MutualFundStat>**](MutualFundStat.md)

<a name="searchmutualfunds"></a>
# **SearchMutualFunds**
> List<MutualFund> SearchMutualFunds (string query, string nextPage = null)

Search Mutual Funds

Searches for Mutual Funds matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchMutualFundsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var mutualFundApi = new MutualFundApi();
            var query = query_example;  // string | 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;MutualFund&gt; result = mutualFundApi.SearchMutualFunds(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MutualFundApi.SearchMutualFunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<MutualFund>**](MutualFund.md)


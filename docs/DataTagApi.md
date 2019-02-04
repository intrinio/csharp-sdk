# Intrinio.SDK.Api.DataTagApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllDataTags**](DataTagApi.md#getalldatatags) | **GET** /data_tags | All Data Tags
[**GetDataTagById**](DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Lookup Data Tag
[**SearchDataTags**](DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags


<a name="getalldatatags"></a>
# **GetAllDataTags**
> ApiResponseDataTags GetAllDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, decimal? pageSize = null, string nextPage = null)

All Data Tags

Returns all Data Tags. Returns Data Tags matching parameters when specified.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllDataTagsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var tag = "";  // string | Tag (optional) 
            var type = "";  // string | Type (optional) 
            var parent = "";  // string | ID of tag parent (optional) 
            var statementCode = "income_statement";  // string | Statement Code (optional) 
            var fsTemplate = "";  // string | Template (optional)  (default to industrial)
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseDataTags result = dataTagApi.GetAllDataTags(tag, type, parent, statementCode, fsTemplate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTagApi.GetAllDataTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| Tag | [optional] 
 **type** | **string**| Type | [optional] 
 **parent** | **string**| ID of tag parent | [optional] 
 **statementCode** | **string**| Statement Code | [optional] 
 **fsTemplate** | **string**| Template | [optional] [default to industrial]
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseDataTags**](ApiResponseDataTags.md)

<a name="getdatatagbyid"></a>
# **GetDataTagById**
> DataTag GetDataTagById (string identifier)

Lookup Data Tag

Returns the Data Tag with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetDataTagByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var identifier = "marketcap";  // string | The Intrinio ID or the code-name of the Data Tag

            try
            {
                DataTag result = dataTagApi.GetDataTagById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTagApi.GetDataTagById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID or the code-name of the Data Tag | 

### Return type

[**DataTag**](DataTag.md)

<a name="searchdatatags"></a>
# **SearchDataTags**
> ApiResponseDataTagsSearch SearchDataTags (string query, decimal? pageSize = null)

Search Data Tags

Searches for Data Tags matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class SearchDataTagsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var query = "revenue";  // string | 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseDataTagsSearch result = dataTagApi.SearchDataTags(query, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTagApi.SearchDataTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  | 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseDataTagsSearch**](ApiResponseDataTagsSearch.md)


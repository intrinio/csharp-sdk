# Intrinio.Api.DataTagApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterDataTags**](DataTagApi.md#filterdatatags) | **GET** /data_tags/filter | Filter Data Tags
[**GetAllDataTags**](DataTagApi.md#getalldatatags) | **GET** /data_tags | Get All Data Tags
[**GetDataTagById**](DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Get a Data Tag by ID
[**SearchDataTags**](DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags


<a name="filterdatatags"></a>
# **FilterDataTags**
> InlineResponse2008 FilterDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)

Filter Data Tags

Returns Data Tags that match the given filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class FilterDataTagsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var tag = tag_example;  // string | Tag (optional) 
            var type = type_example;  // string | Type (optional) 
            var parent = parent_example;  // string | ID of tag parent (optional) 
            var statementCode = statementCode_example;  // string | Statement Code (optional) 
            var fsTemplate = fsTemplate_example;  // string | Template (optional)  (default to industrial)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                InlineResponse2008 result = dataTagApi.FilterDataTags(tag, type, parent, statementCode, fsTemplate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataTagApi.FilterDataTags: " + e.Message );
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
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

<a name="getalldatatags"></a>
# **GetAllDataTags**
> InlineResponse2008 GetAllDataTags (string nextPage = null)

Get All Data Tags

Returns All Data Tags

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllDataTagsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                InlineResponse2008 result = dataTagApi.GetAllDataTags(nextPage);
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
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

<a name="getdatatagbyid"></a>
# **GetDataTagById**
> DataTag GetDataTagById (string identifier)

Get a Data Tag by ID

Returns a Data Tag with the specified `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetDataTagByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var identifier = identifier_example;  // string | The Intrinio ID or the code-name of the Data Tag

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
> InlineResponse2009 SearchDataTags (string query)

Search Data Tags

Searches for Data Tags matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchDataTagsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var query = query_example;  // string | 

            try
            {
                InlineResponse2009 result = dataTagApi.SearchDataTags(query);
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

### Return type

[**InlineResponse2009**](InlineResponse2009.md)


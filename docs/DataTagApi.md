# Intrinio.SDK.Api.DataTagApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllDataTags**](DataTagApi.md#getalldatatags) | **GET** /data_tags | All Data Tags
[**GetDataTagById**](DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Lookup Data Tag
[**SearchDataTags**](DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.DataTagApi)

[//]: # (METHOD:GetAllDataTags)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelApiResponseDataTags)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseDataTags.md)

[//]: # (OPERATION:GetAllDataTags_v2)

[//]: # (ENDPOINT:/data_tags)

[//]: # (DOCUMENT_LINK:DataTagApi.md#getalldatatags)

<a name="getalldatatags"></a>
## **GetAllDataTags**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllDataTags_v2)

[//]: # (START_OVERVIEW)

> ApiResponseDataTags GetAllDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null)

#### All Data Tags

Returns all Data Tags. Returns Data Tags matching parameters when specified.

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| Tag | [optional]  &nbsp;
 **type** | **string**| Type | [optional]  &nbsp;
 **parent** | **string**| ID of tag parent | [optional]  &nbsp;
 **statementCode** | **string**| Statement Code | [optional]  &nbsp;
 **fsTemplate** | **string**| Template | [optional] [default to industrial] &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseDataTags**](ApiResponseDataTags.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.DataTagApi)

[//]: # (METHOD:GetDataTagById)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelDataTag)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:DataTag.md)

[//]: # (OPERATION:GetDataTagById_v2)

[//]: # (ENDPOINT:/data_tags/{identifier})

[//]: # (DOCUMENT_LINK:DataTagApi.md#getdatatagbyid)

<a name="getdatatagbyid"></a>
## **GetDataTagById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetDataTagById_v2)

[//]: # (START_OVERVIEW)

> DataTag GetDataTagById (string identifier)

#### Lookup Data Tag

Returns the Data Tag with the given `identifier`

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

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID or the code-name of the Data Tag |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**DataTag**](DataTag.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.DataTagApi)

[//]: # (METHOD:SearchDataTags)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelApiResponseDataTagsSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseDataTagsSearch.md)

[//]: # (OPERATION:SearchDataTags_v2)

[//]: # (ENDPOINT:/data_tags/search)

[//]: # (DOCUMENT_LINK:DataTagApi.md#searchdatatags)

<a name="searchdatatags"></a>
## **SearchDataTags**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/SearchDataTags_v2)

[//]: # (START_OVERVIEW)

> ApiResponseDataTagsSearch SearchDataTags (string query, int? pageSize = null)

#### Search Data Tags

Searches for Data Tags matching the text `query`

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
    public class SearchDataTagsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataTagApi = new DataTagApi();
            var query = "revenue";  // string | 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

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

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  |  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseDataTagsSearch**](ApiResponseDataTagsSearch.md)

[//]: # (END_OPERATION)


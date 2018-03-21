# Intrinio.Api.StandardizedTagApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterStandardizedTags**](StandardizedTagApi.md#filterstandardizedtags) | **GET** /standardized_tags/filter | Filter Standardized Tags
[**GetAllStandardizedTags**](StandardizedTagApi.md#getallstandardizedtags) | **GET** /standardized_tags | Get All Standardized Tags
[**GetStandardizedTagById**](StandardizedTagApi.md#getstandardizedtagbyid) | **GET** /standardized_tags/{tag_id} | Get a Standardized Tag by ID
[**GetStandardizedTagDataPointNumber**](StandardizedTagApi.md#getstandardizedtagdatapointnumber) | **GET** /standardized_tags/{id}/data_point/{identifier}/number | Get Data Point (Number) for The Standardized Tag
[**GetStandardizedTagDataPointText**](StandardizedTagApi.md#getstandardizedtagdatapointtext) | **GET** /standardized_tags/{id}/data_point/{identifier}/text | Get Data Point (Text) for the Standardized Tag
[**GetStandardizedTagHistoricalData**](StandardizedTagApi.md#getstandardizedtaghistoricaldata) | **GET** /standardized_tags/{id}/historical_data/{identifier} | Get Historical Data for the Standardized Tag
[**SearchStandardizedTags**](StandardizedTagApi.md#searchstandardizedtags) | **GET** /standardized_tags/search | Search Standardized Tags


<a name="filterstandardizedtags"></a>
# **FilterStandardizedTags**
> List<StandardizedTag> FilterStandardizedTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)

Filter Standardized Tags

Returns Standarized Tags that match the given filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class FilterStandardizedTagsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var tag = tag_example;  // string | Tag (optional) 
            var type = type_example;  // string | Type (optional) 
            var parent = parent_example;  // string | ID of tag parent (optional) 
            var statementCode = statementCode_example;  // string | Statement Code (optional) 
            var fsTemplate = fsTemplate_example;  // string | Template (optional)  (default to industrial)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;StandardizedTag&gt; result = standardizedTagApi.FilterStandardizedTags(tag, type, parent, statementCode, fsTemplate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.FilterStandardizedTags: " + e.Message );
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

[**List<StandardizedTag>**](StandardizedTag.md)

<a name="getallstandardizedtags"></a>
# **GetAllStandardizedTags**
> List<StandardizedTag> GetAllStandardizedTags (string nextPage = null)

Get All Standardized Tags

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllStandardizedTagsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;StandardizedTag&gt; result = standardizedTagApi.GetAllStandardizedTags(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.GetAllStandardizedTags: " + e.Message );
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

[**List<StandardizedTag>**](StandardizedTag.md)

<a name="getstandardizedtagbyid"></a>
# **GetStandardizedTagById**
> StandardizedTag GetStandardizedTagById (string tagId)

Get a Standardized Tag by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStandardizedTagByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var tagId = tagId_example;  // string | The Intrinio ID for the tag

            try
            {
                StandardizedTag result = standardizedTagApi.GetStandardizedTagById(tagId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.GetStandardizedTagById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagId** | **string**| The Intrinio ID for the tag | 

### Return type

[**StandardizedTag**](StandardizedTag.md)

<a name="getstandardizedtagdatapointnumber"></a>
# **GetStandardizedTagDataPointNumber**
> DataPointNumber GetStandardizedTagDataPointNumber (string id, string identifier)

Get Data Point (Number) for The Standardized Tag

Returns a numeric data point for the Standardized Tag and entity `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStandardizedTagDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var id = id_example;  // string | The Intrinio Standardized Tag ID or its tag
            var identifier = identifier_example;  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)

            try
            {
                DataPointNumber result = standardizedTagApi.GetStandardizedTagDataPointNumber(id, identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.GetStandardizedTagDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio Standardized Tag ID or its tag | 
 **identifier** | **string**| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="getstandardizedtagdatapointtext"></a>
# **GetStandardizedTagDataPointText**
> DataPointText GetStandardizedTagDataPointText (string id, string identifier)

Get Data Point (Text) for the Standardized Tag

Returns a text data point for the Standardized Tag and entity `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStandardizedTagDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var id = id_example;  // string | The Intrinio Standardized Tag ID or its tag
            var identifier = identifier_example;  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)

            try
            {
                DataPointText result = standardizedTagApi.GetStandardizedTagDataPointText(id, identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.GetStandardizedTagDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio Standardized Tag ID or its tag | 
 **identifier** | **string**| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) | 

### Return type

[**DataPointText**](DataPointText.md)

<a name="getstandardizedtaghistoricaldata"></a>
# **GetStandardizedTagHistoricalData**
> List<HistoricalData> GetStandardizedTagHistoricalData (string id, string identifier, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Historical Data for the Standardized Tag

Returns historical values for the Standardized Tag and the Entity represented by the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetStandardizedTagHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var id = id_example;  // string | The Intrinio Standardized Tag ID or its tag
            var identifier = identifier_example;  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical date on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;HistoricalData&gt; result = standardizedTagApi.GetStandardizedTagHistoricalData(id, identifier, type, startDate, endDate, sortOrder, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.GetStandardizedTagHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio Standardized Tag ID or its tag | 
 **identifier** | **string**| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical date on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<HistoricalData>**](HistoricalData.md)

<a name="searchstandardizedtags"></a>
# **SearchStandardizedTags**
> List<StandardizedTag> SearchStandardizedTags (string query, string nextPage = null)

Search Standardized Tags

Searches for Standardized Tags matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchStandardizedTagsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var standardizedTagApi = new StandardizedTagApi();
            var query = query_example;  // string | 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;StandardizedTag&gt; result = standardizedTagApi.SearchStandardizedTags(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StandardizedTagApi.SearchStandardizedTags: " + e.Message );
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

[**List<StandardizedTag>**](StandardizedTag.md)


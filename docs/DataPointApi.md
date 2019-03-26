# Intrinio.SDK.Api.DataPointApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataPointNumber**](DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{tag}/number | Data Point (Number)
[**GetDataPointText**](DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{tag}/text | Data Point (Text)


<a name="getdatapointnumber"></a>
# **GetDataPointNumber**
> decimal? GetDataPointNumber (string identifier, string tag)

Data Point (Number)

$$v2_data_point_number_description$$

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetDataPointNumberExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataPointApi = new DataPointApi();
            var identifier = "$$v2_data_point_identifier_default$$";  // string | $$v2_data_point_identifier_description$$
            var tag = "$$v2_data_point_item_number_default$$";  // string | $$v2_data_point_item_description$$

            try
            {
                decimal? result = dataPointApi.GetDataPointNumber(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPointApi.GetDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| $$v2_data_point_identifier_description$$ | 
 **tag** | **string**| $$v2_data_point_item_description$$ | 

### Return type

**decimal?**

<a name="getdatapointtext"></a>
# **GetDataPointText**
> string GetDataPointText (string identifier, string tag)

Data Point (Text)

$$v2_data_point_text_description$$

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetDataPointTextExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var dataPointApi = new DataPointApi();
            var identifier = "$$v2_data_point_identifier_default$$";  // string | $$v2_data_point_identifier_description$$
            var tag = "$$v2_data_point_item_text_default$$";  // string | $$v2_data_point_item_description$$

            try
            {
                string result = dataPointApi.GetDataPointText(identifier, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataPointApi.GetDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| $$v2_data_point_identifier_description$$ | 
 **tag** | **string**| $$v2_data_point_item_description$$ | 

### Return type

**string**


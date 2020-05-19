# Intrinio.SDK.Api.DataPointApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataPointNumber**](DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{tag}/number | Data Point (Number)
[**GetDataPointText**](DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{tag}/text | Data Point (Text)



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.DataPointApi)

[//]: # (METHOD:GetDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetDataPointNumber_v2)

[//]: # (ENDPOINT:/data_point/{identifier}/{tag}/number)

[//]: # (DOCUMENT_LINK:DataPointApi.md#getdatapointnumber)

<a name="getdatapointnumber"></a>
## **GetDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetDataPointNumber (string identifier, string tag)

#### Data Point (Number)

$$v2_data_point_number_description$$

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling DataPointApi.GetDataPointNumber: " + e.Message );
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
 **identifier** | string| $$v2_data_point_identifier_description$$ |  &nbsp;
 **tag** | string| $$v2_data_point_item_description$$ |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.DataPointApi)

[//]: # (METHOD:GetDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetDataPointText_v2)

[//]: # (ENDPOINT:/data_point/{identifier}/{tag}/text)

[//]: # (DOCUMENT_LINK:DataPointApi.md#getdatapointtext)

<a name="getdatapointtext"></a>
## **GetDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetDataPointText (string identifier, string tag)

#### Data Point (Text)

$$v2_data_point_text_description$$

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling DataPointApi.GetDataPointText: " + e.Message );
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
 **identifier** | string| $$v2_data_point_identifier_description$$ |  &nbsp;
 **tag** | string| $$v2_data_point_item_description$$ |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


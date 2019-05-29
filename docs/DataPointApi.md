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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetDataPointNumber (string identifier, string tag)

#### Data Point (Number)

Returns a numeric value for the given `tag` and the entity with the given `identifier`

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
      var identifier = "AAPL";  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)
      var tag = "marketcap";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)

      try
      {
        decimal? result = dataPointApi.GetDataPointNumber(identifier, tag);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling DataPointApi.GetDataPointNumber: " + e.Message );
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
 **identifier** | string| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetDataPointText (string identifier, string tag)

#### Data Point (Text)

Returns a text value for the given `tag` for the Security with the given `identifier`

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
      var identifier = "AAPL";  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)
      var tag = "ceo";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)

      try
      {
        string result = dataPointApi.GetDataPointText(identifier, tag);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling DataPointApi.GetDataPointText: " + e.Message );
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
 **identifier** | string| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


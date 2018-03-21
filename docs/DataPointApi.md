# Intrinio.Api.DataPointApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataPointNumber**](DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{item}/number | Get a Data Point (Number)
[**GetDataPointText**](DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{item}/text | Get a Data Point (Text)


<a name="getdatapointnumber"></a>
# **GetDataPointNumber**
> DataPointNumber GetDataPointNumber (string identifier, string item)

Get a Data Point (Number)

Returns a numeric value for the given `item` and the entity with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var dataPointApi = new DataPointApi();
            var identifier = identifier_example;  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointNumber result = dataPointApi.GetDataPointNumber(identifier, item);
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
 **identifier** | **string**| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="getdatapointtext"></a>
# **GetDataPointText**
> DataPointText GetDataPointText (string identifier, string item)

Get a Data Point (Text)

Returns a text value for the given `item` and the entity with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var dataPointApi = new DataPointApi();
            var identifier = identifier_example;  // string | An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointText result = dataPointApi.GetDataPointText(identifier, item);
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
 **identifier** | **string**| An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointText**](DataPointText.md)


# Intrinio.SDK.Api.ESGApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEsgCompanies**](ESGApi.md#getesgcompanies) | **GET** /esg/companies | ESG Companies
[**GetEsgCompanyRatings**](ESGApi.md#getesgcompanyratings) | **GET** /esg/{identifier} | ESG Company Ratings History
[**GetEsgLatest**](ESGApi.md#getesglatest) | **GET** /esg | ESG Latest



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ESGApi)

[//]: # (METHOD:GetEsgCompanies)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseESGCompanies)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseESGCompanies.md)

[//]: # (OPERATION:GetEsgCompanies_v2)

[//]: # (ENDPOINT:/esg/companies)

[//]: # (DOCUMENT_LINK:ESGApi.md#getesgcompanies)

<a name="getesgcompanies"></a>
## **GetEsgCompanies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEsgCompanies_v2)

[//]: # (START_OVERVIEW)

> ApiResponseESGCompanies GetEsgCompanies (string country = null, int? pageSize = null, string nextPage = null)

#### ESG Companies


[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetEsgCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eSGApi = new ESGApi();
      
      string country = "USA";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseESGCompanies result = eSGApi.GetEsgCompanies(country, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | string|  | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseESGCompanies**](ApiResponseESGCompanies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ESGApi)

[//]: # (METHOD:GetEsgCompanyRatings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseESGCompanyRatingHistory)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseESGCompanyRatingHistory.md)

[//]: # (OPERATION:GetEsgCompanyRatings_v2)

[//]: # (ENDPOINT:/esg/{identifier})

[//]: # (DOCUMENT_LINK:ESGApi.md#getesgcompanyratings)

<a name="getesgcompanyratings"></a>
## **GetEsgCompanyRatings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEsgCompanyRatings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseESGCompanyRatingHistory GetEsgCompanyRatings (string identifier, int? pageSize = null, string nextPage = null)

#### ESG Company Ratings History


[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetEsgCompanyRatingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eSGApi = new ESGApi();
      
      string identifier = "AAPL";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseESGCompanyRatingHistory result = eSGApi.GetEsgCompanyRatings(identifier, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| ISIN, Intrinio ID, or Ticker |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseESGCompanyRatingHistory**](ApiResponseESGCompanyRatingHistory.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ESGApi)

[//]: # (METHOD:GetEsgLatest)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseESGLatest)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseESGLatest.md)

[//]: # (OPERATION:GetEsgLatest_v2)

[//]: # (ENDPOINT:/esg)

[//]: # (DOCUMENT_LINK:ESGApi.md#getesglatest)

<a name="getesglatest"></a>
## **GetEsgLatest**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEsgLatest_v2)

[//]: # (START_OVERVIEW)

> ApiResponseESGLatest GetEsgLatest (string country = null, string country2 = null, int? pageSize = null, string nextPage = null)

#### ESG Latest


[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetEsgLatestExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eSGApi = new ESGApi();
      
      string country = "USA";
      string country2 = "USA";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseESGLatest result = eSGApi.GetEsgLatest(country, country2, pageSize, nextPage);
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | string|  | [optional]  &nbsp;
 **country2** | string|  | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseESGLatest**](ApiResponseESGLatest.md)

[//]: # (END_OPERATION)


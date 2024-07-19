# Intrinio.SDK.Api.ESGApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEsgCompanies**](ESGApi.md#getesgcompanies) | **GET** /esg/companies | ESG Companies
[**GetEsgCompanyComprehensiveRatings**](ESGApi.md#getesgcompanycomprehensiveratings) | **GET** /esg/{identifier}/comprehensive | ESG Company Comprehensive Ratings History
[**GetEsgCompanyRatings**](ESGApi.md#getesgcompanyratings) | **GET** /esg/{identifier} | ESG Company Ratings History
[**GetEsgLatest**](ESGApi.md#getesglatest) | **GET** /esg | ESG Latest
[**GetEsgLatestComprehensive**](ESGApi.md#getesglatestcomprehensive) | **GET** /esg/comprehensive | ESG Latest Comprehensive



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

> ApiResponseESGCompanies GetEsgCompanies (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null)

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
      
      string country = "Canada";
      string industry = "Retail";
      string ticker = "SHOP";
      int? pageSize = 100;
      string nextPage = "~null";
      
      ApiResponseESGCompanies result = eSGApi.GetEsgCompanies(country, industry, ticker, pageSize, nextPage);
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
 **industry** | string|  | [optional]  &nbsp;
 **ticker** | string|  | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseESGCompanies**](ApiResponseESGCompanies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ESGApi)

[//]: # (METHOD:GetEsgCompanyComprehensiveRatings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseESGCompanyComprehensiveRatingHistory)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseESGCompanyComprehensiveRatingHistory.md)

[//]: # (OPERATION:GetEsgCompanyComprehensiveRatings_v2)

[//]: # (ENDPOINT:/esg/{identifier}/comprehensive)

[//]: # (DOCUMENT_LINK:ESGApi.md#getesgcompanycomprehensiveratings)

<a name="getesgcompanycomprehensiveratings"></a>
## **GetEsgCompanyComprehensiveRatings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEsgCompanyComprehensiveRatings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseESGCompanyComprehensiveRatingHistory GetEsgCompanyComprehensiveRatings (string identifier, int? pageSize = null, string nextPage = null)

#### ESG Company Comprehensive Ratings History


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
  public class GetEsgCompanyComprehensiveRatingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eSGApi = new ESGApi();
      
      string identifier = "AAPL";
      int? pageSize = 100;
      string nextPage = "~null";
      
      ApiResponseESGCompanyComprehensiveRatingHistory result = eSGApi.GetEsgCompanyComprehensiveRatings(identifier, pageSize, nextPage);
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

[**ApiResponseESGCompanyComprehensiveRatingHistory**](ApiResponseESGCompanyComprehensiveRatingHistory.md)

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
      string nextPage = "~null";
      
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

> ApiResponseESGLatest GetEsgLatest (string country = null, int? pageSize = null, string nextPage = null)

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
      int? pageSize = 100;
      string nextPage = "~null";
      
      ApiResponseESGLatest result = eSGApi.GetEsgLatest(country, pageSize, nextPage);
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

[**ApiResponseESGLatest**](ApiResponseESGLatest.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ESGApi)

[//]: # (METHOD:GetEsgLatestComprehensive)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseESGLatestComprehensive)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseESGLatestComprehensive.md)

[//]: # (OPERATION:GetEsgLatestComprehensive_v2)

[//]: # (ENDPOINT:/esg/comprehensive)

[//]: # (DOCUMENT_LINK:ESGApi.md#getesglatestcomprehensive)

<a name="getesglatestcomprehensive"></a>
## **GetEsgLatestComprehensive**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEsgLatestComprehensive_v2)

[//]: # (START_OVERVIEW)

> ApiResponseESGLatestComprehensive GetEsgLatestComprehensive (string country = null, int? pageSize = null, string nextPage = null)

#### ESG Latest Comprehensive


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
  public class GetEsgLatestComprehensiveExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var eSGApi = new ESGApi();
      
      string country = "USA";
      int? pageSize = 100;
      string nextPage = "~null";
      
      ApiResponseESGLatestComprehensive result = eSGApi.GetEsgLatestComprehensive(country, pageSize, nextPage);
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

[**ApiResponseESGLatestComprehensive**](ApiResponseESGLatestComprehensive.md)

[//]: # (END_OPERATION)


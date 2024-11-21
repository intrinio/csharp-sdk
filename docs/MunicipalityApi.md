# Intrinio.SDK.Api.MunicipalityApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllMunicipalities**](MunicipalityApi.md#getallmunicipalities) | **GET** /municipalities | All Municipalities
[**GetMunicipalityById**](MunicipalityApi.md#getmunicipalitybyid) | **GET** /municipalities/{id} | Municipality by ID
[**GetMunicipalityFinancials**](MunicipalityApi.md#getmunicipalityfinancials) | **GET** /municipalities/{id}/financials | Financials for a Municipality



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.MunicipalityApi)

[//]: # (METHOD:GetAllMunicipalities)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseMunicipalities)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseMunicipalities.md)

[//]: # (OPERATION:GetAllMunicipalities_v2)

[//]: # (ENDPOINT:/municipalities)

[//]: # (DOCUMENT_LINK:MunicipalityApi.md#getallmunicipalities)

<a name="getallmunicipalities"></a>
## **GetAllMunicipalities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllMunicipalities_v2)

[//]: # (START_OVERVIEW)

> ApiResponseMunicipalities GetAllMunicipalities (bool? hasFinancials = null, string governmentName = null, string governmentType = null, string areaName = null, string areaType = null, string city = null, string state = null, decimal? zipcode = null, decimal? populationGreaterThan = null, decimal? populationLessThan = null, decimal? enrollmentGreaterThan = null, decimal? enrollmentLessThan = null, string nextPage = null)

#### All Municipalities

Returns all Municipalities. When parameters are specified, returns matching municipalities.

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
  public class GetAllMunicipalitiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var municipalityApi = new MunicipalityApi();
      
      bool? hasFinancials = null;
      string governmentName = null;
      string governmentType = null;
      string areaName = null;
      string areaType = null;
      string city = null;
      string state = null;
      decimal? zipcode = null;
      decimal? populationGreaterThan = null;
      decimal? populationLessThan = null;
      decimal? enrollmentGreaterThan = null;
      decimal? enrollmentLessThan = null;
      string nextPage = null;
      
      ApiResponseMunicipalities result = municipalityApi.GetAllMunicipalities(hasFinancials, governmentName, governmentType, areaName, areaType, city, state, zipcode, populationGreaterThan, populationLessThan, enrollmentGreaterThan, enrollmentLessThan, nextPage);
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
 **hasFinancials** | bool?| Return municipalities with financials | [optional]  &nbsp;
 **governmentName** | string| Return municipalities with a government name matching the given query | [optional]  &nbsp;
 **governmentType** | string| Return municipalities with the given government type | [optional]  &nbsp;
 **areaName** | string| Return municipalities with an area name matching the given query | [optional]  &nbsp;
 **areaType** | string| Return municipalities with the given area type | [optional]  &nbsp;
 **city** | string| Return municipalities in the given city | [optional]  &nbsp;
 **state** | string| Return municipalities in the given state | [optional]  &nbsp;
 **zipcode** | decimal?| Return municipalities in the given zipcode | [optional]  &nbsp;
 **populationGreaterThan** | decimal?| Return municipalities with a population greater than the given number | [optional]  &nbsp;
 **populationLessThan** | decimal?| Return municipalities with a population less than the given number | [optional]  &nbsp;
 **enrollmentGreaterThan** | decimal?| Return municipalities with an enrollment greater than the given number | [optional]  &nbsp;
 **enrollmentLessThan** | decimal?| Return municipalities with an enrollment less than the given number | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseMunicipalities**](ApiResponseMunicipalities.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.MunicipalityApi)

[//]: # (METHOD:GetMunicipalityById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Municipality)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Municipality.md)

[//]: # (OPERATION:GetMunicipalityById_v2)

[//]: # (ENDPOINT:/municipalities/{id})

[//]: # (DOCUMENT_LINK:MunicipalityApi.md#getmunicipalitybyid)

<a name="getmunicipalitybyid"></a>
## **GetMunicipalityById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetMunicipalityById_v2)

[//]: # (START_OVERVIEW)

> Municipality GetMunicipalityById (string id)

#### Municipality by ID

Returns the Municipality with the given ID

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
  public class GetMunicipalityByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var municipalityApi = new MunicipalityApi();
      
      string id = "mun_Xn7x4z";
      
      Municipality result = municipalityApi.GetMunicipalityById(id);
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
 **id** | string| An Intrinio ID of a Municipality |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Municipality**](Municipality.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.MunicipalityApi)

[//]: # (METHOD:GetMunicipalityFinancials)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseMunicipalitiyFinancials)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseMunicipalitiyFinancials.md)

[//]: # (OPERATION:GetMunicipalityFinancials_v2)

[//]: # (ENDPOINT:/municipalities/{id}/financials)

[//]: # (DOCUMENT_LINK:MunicipalityApi.md#getmunicipalityfinancials)

<a name="getmunicipalityfinancials"></a>
## **GetMunicipalityFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetMunicipalityFinancials_v2)

[//]: # (START_OVERVIEW)

> ApiResponseMunicipalitiyFinancials GetMunicipalityFinancials (string id, decimal? fiscalYear = null)

#### Financials for a Municipality

Returns financial statement data for the Municipality with the given ID

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
  public class GetMunicipalityFinancialsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var municipalityApi = new MunicipalityApi();
      
      string id = "mun_Xn7x4z";
      decimal? fiscalYear = 2017;
      
      ApiResponseMunicipalitiyFinancials result = municipalityApi.GetMunicipalityFinancials(id, fiscalYear);
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
 **id** | string| An Intrinio ID of a Municipality |  &nbsp;
 **fiscalYear** | decimal?| Return financials for the given fiscal year | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseMunicipalitiyFinancials**](ApiResponseMunicipalitiyFinancials.md)

[//]: # (END_OPERATION)


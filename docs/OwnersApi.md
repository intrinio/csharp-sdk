# Intrinio.SDK.Api.OwnersApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllOwners**](OwnersApi.md#getallowners) | **GET** /owners | All Owners
[**GetOwnerById**](OwnersApi.md#getownerbyid) | **GET** /owners/{identifier} | Owner by ID
[**InsiderTransactionFilingsByOwner**](OwnersApi.md#insidertransactionfilingsbyowner) | **GET** /owners/{identifier}/insider_transaction_filings | Insider Transaction Filings by Owner
[**InstitutionalHoldingsByOwner**](OwnersApi.md#institutionalholdingsbyowner) | **GET** /owners/{identifier}/institutional_holdings | Institutional Holdings by Owner
[**SearchOwners**](OwnersApi.md#searchowners) | **GET** /owners/search | Search Owners



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OwnersApi)

[//]: # (METHOD:GetAllOwners)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOwners)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOwners.md)

[//]: # (OPERATION:GetAllOwners_v2)

[//]: # (ENDPOINT:/owners)

[//]: # (DOCUMENT_LINK:OwnersApi.md#getallowners)

<a name="getallowners"></a>
## **GetAllOwners**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllOwners_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOwners GetAllOwners (bool? institutional = null, int? pageSize = null, string nextPage = null)

#### All Owners

Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.

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
  public class GetAllOwnersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var ownersApi = new OwnersApi();
      
      bool? institutional = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseOwners result = ownersApi.GetAllOwners(institutional, pageSize, nextPage);
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
 **institutional** | bool?| Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOwners**](ApiResponseOwners.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OwnersApi)

[//]: # (METHOD:GetOwnerById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Owner)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Owner.md)

[//]: # (OPERATION:GetOwnerById_v2)

[//]: # (ENDPOINT:/owners/{identifier})

[//]: # (DOCUMENT_LINK:OwnersApi.md#getownerbyid)

<a name="getownerbyid"></a>
## **GetOwnerById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOwnerById_v2)

[//]: # (START_OVERVIEW)

> Owner GetOwnerById (string identifier)

#### Owner by ID

Returns the Owner with the given ID

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
  public class GetOwnerByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var ownersApi = new OwnersApi();
      
      string identifier = "0000001800";
      
      Owner result = ownersApi.GetOwnerById(identifier);
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
 **identifier** | string| An Intrinio ID or CIK of an Owner |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Owner**](Owner.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OwnersApi)

[//]: # (METHOD:InsiderTransactionFilingsByOwner)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOwnerInsiderTransactionFilings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOwnerInsiderTransactionFilings.md)

[//]: # (OPERATION:InsiderTransactionFilingsByOwner_v2)

[//]: # (ENDPOINT:/owners/{identifier}/insider_transaction_filings)

[//]: # (DOCUMENT_LINK:OwnersApi.md#insidertransactionfilingsbyowner)

<a name="insidertransactionfilingsbyowner"></a>
## **InsiderTransactionFilingsByOwner**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/InsiderTransactionFilingsByOwner_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOwnerInsiderTransactionFilings InsiderTransactionFilingsByOwner (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

#### Insider Transaction Filings by Owner

Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.

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
  public class InsiderTransactionFilingsByOwnerExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var ownersApi = new OwnersApi();
      
      string identifier = "0001494730";
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = DateTime.Parse("2019-01-01");
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseOwnerInsiderTransactionFilings result = ownersApi.InsiderTransactionFilingsByOwner(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under. |  &nbsp;
 **startDate** | DateTime?| Return Owner&#39;s insider transaction filings on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Return Owner&#39;s insider transaction filings on or before this date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOwnerInsiderTransactionFilings**](ApiResponseOwnerInsiderTransactionFilings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OwnersApi)

[//]: # (METHOD:InstitutionalHoldingsByOwner)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOwnerInstitutionalHoldings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOwnerInstitutionalHoldings.md)

[//]: # (OPERATION:InstitutionalHoldingsByOwner_v2)

[//]: # (ENDPOINT:/owners/{identifier}/institutional_holdings)

[//]: # (DOCUMENT_LINK:OwnersApi.md#institutionalholdingsbyowner)

<a name="institutionalholdingsbyowner"></a>
## **InstitutionalHoldingsByOwner**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/InstitutionalHoldingsByOwner_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOwnerInstitutionalHoldings InstitutionalHoldingsByOwner (string identifier, int? pageSize = null, Object asOfDate = null, string nextPage = null)

#### Institutional Holdings by Owner

Returns a list of all ownership interests and the value of their interests by a single institutional owner.

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
  public class InstitutionalHoldingsByOwnerExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var ownersApi = new OwnersApi();
      
      string identifier = 430692;
      int? pageSize = 100;
      var asOfDate = new Object();
      string nextPage = null;
      
      ApiResponseOwnerInstitutionalHoldings result = ownersApi.InstitutionalHoldingsByOwner(identifier, pageSize, asOfDate, nextPage);
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
 **identifier** | string| The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under. |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **asOfDate** | [**Object**](Object.md)| Return only holdings filed before this date. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOwnerInstitutionalHoldings**](ApiResponseOwnerInstitutionalHoldings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OwnersApi)

[//]: # (METHOD:SearchOwners)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOwners)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOwners.md)

[//]: # (OPERATION:SearchOwners_v2)

[//]: # (ENDPOINT:/owners/search)

[//]: # (DOCUMENT_LINK:OwnersApi.md#searchowners)

<a name="searchowners"></a>
## **SearchOwners**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchOwners_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOwners SearchOwners (string query, bool? institutional = null, int? pageSize = null, string nextPage = null)

#### Search Owners

Searches for Owners matching the text `query`

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
  public class SearchOwnersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var ownersApi = new OwnersApi();
      
      string query = "Cook";
      bool? institutional = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseOwners result = ownersApi.SearchOwners(query, institutional, pageSize, nextPage);
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
 **query** | string|  |  &nbsp;
 **institutional** | bool?| Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOwners**](ApiResponseOwners.md)

[//]: # (END_OPERATION)


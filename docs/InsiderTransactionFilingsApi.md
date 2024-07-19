# Intrinio.SDK.Api.InsiderTransactionFilingsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllInsiderTransactionFilings**](InsiderTransactionFilingsApi.md#getallinsidertransactionfilings) | **GET** /insider_transaction_filings | All Insider Transactions Filings



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.InsiderTransactionFilingsApi)

[//]: # (METHOD:GetAllInsiderTransactionFilings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOwnerInsiderTransactionFilings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOwnerInsiderTransactionFilings.md)

[//]: # (OPERATION:GetAllInsiderTransactionFilings_v2)

[//]: # (ENDPOINT:/insider_transaction_filings)

[//]: # (DOCUMENT_LINK:InsiderTransactionFilingsApi.md#getallinsidertransactionfilings)

<a name="getallinsidertransactionfilings"></a>
## **GetAllInsiderTransactionFilings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllInsiderTransactionFilings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOwnerInsiderTransactionFilings GetAllInsiderTransactionFilings (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null)

#### All Insider Transactions Filings

Returns all insider transactions filings fitting the optional supplied start and end date.

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
  public class GetAllInsiderTransactionFilingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var insiderTransactionFilingsApi = new InsiderTransactionFilingsApi();
      
      DateTime? startDate = "2015-01-01";
      DateTime? endDate = "~null";
      int? pageSize = 100;
      string sortBy = "updated_on";
      string nextPage = "~null";
      
      ApiResponseOwnerInsiderTransactionFilings result = insiderTransactionFilingsApi.GetAllInsiderTransactionFilings(startDate, endDate, pageSize, sortBy, nextPage);
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
 **startDate** | DateTime?| Filed on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Filed before or after the given date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **sortBy** | string| The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOwnerInsiderTransactionFilings**](ApiResponseOwnerInsiderTransactionFilings.md)

[//]: # (END_OPERATION)


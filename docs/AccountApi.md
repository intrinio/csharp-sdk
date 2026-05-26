# Intrinio.SDK.Api.AccountApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccountCurrentUsage**](AccountApi.md#getaccountcurrentusage) | **GET** /account/current_usage | Account Current Usage
[**GetAccountWebsocketStatuses**](AccountApi.md#getaccountwebsocketstatuses) | **GET** /account/websocket_statuses | Account Websocket Statuses



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.AccountApi)

[//]: # (METHOD:GetAccountCurrentUsage)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseAccountUsages)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseAccountUsages.md)

[//]: # (OPERATION:GetAccountCurrentUsage_v2)

[//]: # (ENDPOINT:/account/current_usage)

[//]: # (DOCUMENT_LINK:AccountApi.md#getaccountcurrentusage)

<a name="getaccountcurrentusage"></a>
## **GetAccountCurrentUsage**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAccountCurrentUsage_v2)

[//]: # (START_OVERVIEW)

> ApiResponseAccountUsages GetAccountCurrentUsage ()

#### Account Current Usage

Returns a list of all access codes available with their current usage.

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
  public class GetAccountCurrentUsageExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var accountApi = new AccountApi();
      
      
      ApiResponseAccountUsages result = accountApi.GetAccountCurrentUsage();
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)

This endpoint does not need any parameter.
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseAccountUsages**](ApiResponseAccountUsages.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.AccountApi)

[//]: # (METHOD:GetAccountWebsocketStatuses)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseWebsocketStatuses)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseWebsocketStatuses.md)

[//]: # (OPERATION:GetAccountWebsocketStatuses_v2)

[//]: # (ENDPOINT:/account/websocket_statuses)

[//]: # (DOCUMENT_LINK:AccountApi.md#getaccountwebsocketstatuses)

<a name="getaccountwebsocketstatuses"></a>
## **GetAccountWebsocketStatuses**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAccountWebsocketStatuses_v2)

[//]: # (START_OVERVIEW)

> ApiResponseWebsocketStatuses GetAccountWebsocketStatuses ()

#### Account Websocket Statuses

Returns a list of all websocket statuses for the account.

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
  public class GetAccountWebsocketStatusesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var accountApi = new AccountApi();
      
      
      ApiResponseWebsocketStatuses result = accountApi.GetAccountWebsocketStatuses();
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)

This endpoint does not need any parameter.
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseWebsocketStatuses**](ApiResponseWebsocketStatuses.md)

[//]: # (END_OPERATION)


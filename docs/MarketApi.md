# Intrinio.SDK.Api.MarketApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketStatus**](MarketApi.md#getmarketstatus) | **GET** /market/status | Market Status



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.MarketApi)

[//]: # (METHOD:GetMarketStatus)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.MarketStatusResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:MarketStatusResult.md)

[//]: # (OPERATION:GetMarketStatus_v2)

[//]: # (ENDPOINT:/market/status)

[//]: # (DOCUMENT_LINK:MarketApi.md#getmarketstatus)

<a name="getmarketstatus"></a>
## **GetMarketStatus**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetMarketStatus_v2)

[//]: # (START_OVERVIEW)

> MarketStatusResult GetMarketStatus ()

#### Market Status

Returns the market status.

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
  public class GetMarketStatusExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var marketApi = new MarketApi();
      
      
      MarketStatusResult result = marketApi.GetMarketStatus();
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

[**MarketStatusResult**](MarketStatusResult.md)

[//]: # (END_OPERATION)


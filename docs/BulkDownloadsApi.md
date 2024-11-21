# Intrinio.SDK.Api.BulkDownloadsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBulkDownloadLinks**](BulkDownloadsApi.md#getbulkdownloadlinks) | **GET** /bulk_downloads/links | All Links



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.BulkDownloadsApi)

[//]: # (METHOD:GetBulkDownloadLinks)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseBulkDownloadLinks)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseBulkDownloadLinks.md)

[//]: # (OPERATION:GetBulkDownloadLinks_v2)

[//]: # (ENDPOINT:/bulk_downloads/links)

[//]: # (DOCUMENT_LINK:BulkDownloadsApi.md#getbulkdownloadlinks)

<a name="getbulkdownloadlinks"></a>
## **GetBulkDownloadLinks**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetBulkDownloadLinks_v2)

[//]: # (START_OVERVIEW)

> ApiResponseBulkDownloadLinks GetBulkDownloadLinks ()

#### All Links

Returns all active bulk downloads for your account with links to download.

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
  public class GetBulkDownloadLinksExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var bulkDownloadsApi = new BulkDownloadsApi();
      
      
      ApiResponseBulkDownloadLinks result = bulkDownloadsApi.GetBulkDownloadLinks();
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

[**ApiResponseBulkDownloadLinks**](ApiResponseBulkDownloadLinks.md)

[//]: # (END_OPERATION)


# Intrinio.SDK.Api.FilingApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllFilings**](FilingApi.md#getallfilings) | **GET** /filings | All Filings
[**GetAllNotes**](FilingApi.md#getallnotes) | **GET** /filings/notes | All Filing Notes
[**GetFilingById**](FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
[**GetFilingFundamentals**](FilingApi.md#getfilingfundamentals) | **GET** /filings/{identifier}/fundamentals | All Fundamentals by Filing
[**GetFilingHtml**](FilingApi.md#getfilinghtml) | **GET** /filings/{identifier}/html | Filing Html
[**GetFilingText**](FilingApi.md#getfilingtext) | **GET** /filings/{identifier}/text | Filing Text
[**GetNote**](FilingApi.md#getnote) | **GET** /filings/notes/{identifier} | Filing Note by ID
[**GetNoteHtml**](FilingApi.md#getnotehtml) | **GET** /filings/notes/{identifier}/html | Filing Note HTML
[**GetNoteText**](FilingApi.md#getnotetext) | **GET** /filings/notes/{identifier}/text | Filing Note Text
[**SearchNotes**](FilingApi.md#searchnotes) | **GET** /filings/notes/search | Search Filing Notes



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetAllFilings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseFilings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseFilings.md)

[//]: # (OPERATION:GetAllFilings_v2)

[//]: # (ENDPOINT:/filings)

[//]: # (DOCUMENT_LINK:FilingApi.md#getallfilings)

<a name="getallfilings"></a>
## **GetAllFilings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllFilings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseFilings GetAllFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null)

#### All Filings

Returns all Filings. Returns Filings matching parameters when supplied.

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
  public class GetAllFilingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string company = "AAPL";

      string reportType = "";

      DateTime? startDate = DateTime.Parse("2015-01-01");

      DateTime? endDate = null;

      string industryCategory = "";

      string industryGroup = "";

      int? pageSize = 100;

      string nextPage = "";

      
      ApiResponseFilings result = filingApi.GetAllFilings(company, reportType, startDate, endDate, industryCategory, industryGroup, pageSize, nextPage);
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
 **company** | string| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **reportType** | string| Filter by report type. Separate values with commas to return multiple The filing &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report types&lt;/a&gt;. | [optional]  &nbsp;
 **startDate** | DateTime?| Filed on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Filed before or after the given date | [optional]  &nbsp;
 **industryCategory** | string| Return companies in the given industry category | [optional]  &nbsp;
 **industryGroup** | string| Return companies in the given industry group | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseFilings**](ApiResponseFilings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetAllNotes)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseFilingNotes)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseFilingNotes.md)

[//]: # (OPERATION:GetAllNotes_v2)

[//]: # (ENDPOINT:/filings/notes)

[//]: # (DOCUMENT_LINK:FilingApi.md#getallnotes)

<a name="getallnotes"></a>
## **GetAllNotes**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllNotes_v2)

[//]: # (START_OVERVIEW)

> ApiResponseFilingNotes GetAllNotes (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null)

#### All Filing Notes

Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.

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
  public class GetAllNotesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string company = "AAPL";

      string reportType = "10-Q";

      DateTime? filingStartDate = null;

      DateTime? filingEndDate = null;

      DateTime? periodEndedStartDate = null;

      DateTime? periodEndedEndDate = null;

      int? pageSize = 100;

      string nextPage = "";

      
      ApiResponseFilingNotes result = filingApi.GetAllNotes(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, pageSize, nextPage);
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
 **company** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | [optional]  &nbsp;
 **reportType** | string| Notes contained in filings that match the given &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt; | [optional]  &nbsp;
 **filingStartDate** | DateTime?| Limit search to filings on or after this date | [optional]  &nbsp;
 **filingEndDate** | DateTime?| Limit search to filings on or before this date | [optional]  &nbsp;
 **periodEndedStartDate** | DateTime?| Limit search to filings with a period end date on or after this date | [optional]  &nbsp;
 **periodEndedEndDate** | DateTime?| Limit search to filings with a period end date on or before this date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseFilingNotes**](ApiResponseFilingNotes.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetFilingById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Filing)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Filing.md)

[//]: # (OPERATION:GetFilingById_v2)

[//]: # (ENDPOINT:/filings/{id})

[//]: # (DOCUMENT_LINK:FilingApi.md#getfilingbyid)

<a name="getfilingbyid"></a>
## **GetFilingById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFilingById_v2)

[//]: # (START_OVERVIEW)

> Filing GetFilingById (string id)

#### Lookup Filing

Returns the Filing with the given `identifier`

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
  public class GetFilingByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string id = "fil_7Kn2P6";

      
      Filing result = filingApi.GetFilingById(id);
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
 **id** | string| The Intrinio ID of the Filing |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Filing**](Filing.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetFilingFundamentals)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseFilingFundamentals)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseFilingFundamentals.md)

[//]: # (OPERATION:GetFilingFundamentals_v2)

[//]: # (ENDPOINT:/filings/{identifier}/fundamentals)

[//]: # (DOCUMENT_LINK:FilingApi.md#getfilingfundamentals)

<a name="getfilingfundamentals"></a>
## **GetFilingFundamentals**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFilingFundamentals_v2)

[//]: # (START_OVERVIEW)

> ApiResponseFilingFundamentals GetFilingFundamentals (string identifier, string statementCode = null, string type = null, int? fiscalYear = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

#### All Fundamentals by Filing

Returns all Fundamentals for the SEC Filing with the given `identifier`. Returns Fundamentals matching parameters when supplied.

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
  public class GetFilingFundamentalsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string identifier = "fil_B73xBG";

      string statementCode = "";

      string type = "";

      int? fiscalYear = null;

      string fiscalPeriod = "";

      DateTime? startDate = null;

      DateTime? endDate = null;

      string nextPage = "";

      
      ApiResponseFilingFundamentals result = filingApi.GetFilingFundamentals(identifier, statementCode, type, fiscalYear, fiscalPeriod, startDate, endDate, nextPage);
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
 **identifier** | string| A Filing identifier |  &nbsp;
 **statementCode** | string| Filters fundamentals by statement code | [optional]  &nbsp;
 **type** | string| Filters fundamentals by type | [optional]  &nbsp;
 **fiscalYear** | int?| Filters fundamentals by fiscal year | [optional]  &nbsp;
 **fiscalPeriod** | string| Filters fundamentals by fiscal period | [optional]  &nbsp;
 **startDate** | DateTime?| Returns fundamentals on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Returns fundamentals on or before the given date | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseFilingFundamentals**](ApiResponseFilingFundamentals.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetFilingHtml)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetFilingHtml_v2)

[//]: # (ENDPOINT:/filings/{identifier}/html)

[//]: # (DOCUMENT_LINK:FilingApi.md#getfilinghtml)

<a name="getfilinghtml"></a>
## **GetFilingHtml**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFilingHtml_v2)

[//]: # (START_OVERVIEW)

> string GetFilingHtml (string identifier)

#### Filing Html


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
  public class GetFilingHtmlExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string identifier = "fil_B73xBG";

      
      string result = filingApi.GetFilingHtml(identifier);
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
 **identifier** | string| A Filing identifier |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetFilingText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetFilingText_v2)

[//]: # (ENDPOINT:/filings/{identifier}/text)

[//]: # (DOCUMENT_LINK:FilingApi.md#getfilingtext)

<a name="getfilingtext"></a>
## **GetFilingText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFilingText_v2)

[//]: # (START_OVERVIEW)

> string GetFilingText (string identifier)

#### Filing Text


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
  public class GetFilingTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string identifier = "fil_B73xBG";

      
      string result = filingApi.GetFilingText(identifier);
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
 **identifier** | string| A Filing identifier |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetNote)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.FilingNote)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:FilingNote.md)

[//]: # (OPERATION:GetNote_v2)

[//]: # (ENDPOINT:/filings/notes/{identifier})

[//]: # (DOCUMENT_LINK:FilingApi.md#getnote)

<a name="getnote"></a>
## **GetNote**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetNote_v2)

[//]: # (START_OVERVIEW)

> FilingNote GetNote (string identifier, string contentFormat = null)

#### Filing Note by ID


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
  public class GetNoteExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string identifier = "xbn_ydK3QL";

      string contentFormat = "text";

      
      FilingNote result = filingApi.GetNote(identifier, contentFormat);
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
 **identifier** | string| The Intrinio ID of the filing note |  &nbsp;
 **contentFormat** | string| Returns content in html (as filed) or plain text | [optional] [default to text] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**FilingNote**](FilingNote.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetNoteHtml)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetNoteHtml_v2)

[//]: # (ENDPOINT:/filings/notes/{identifier}/html)

[//]: # (DOCUMENT_LINK:FilingApi.md#getnotehtml)

<a name="getnotehtml"></a>
## **GetNoteHtml**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetNoteHtml_v2)

[//]: # (START_OVERVIEW)

> string GetNoteHtml (string identifier)

#### Filing Note HTML


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
  public class GetNoteHtmlExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string identifier = "xbn_ydK3QL";

      
      string result = filingApi.GetNoteHtml(identifier);
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
 **identifier** | string| The Intrinio ID of the filing note |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:GetNoteText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetNoteText_v2)

[//]: # (ENDPOINT:/filings/notes/{identifier}/text)

[//]: # (DOCUMENT_LINK:FilingApi.md#getnotetext)

<a name="getnotetext"></a>
## **GetNoteText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetNoteText_v2)

[//]: # (START_OVERVIEW)

> string GetNoteText (string identifier)

#### Filing Note Text


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
  public class GetNoteTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string identifier = "xbn_ydK3QL";

      
      string result = filingApi.GetNoteText(identifier);
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
 **identifier** | string| The Intrinio ID of the filing note |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FilingApi)

[//]: # (METHOD:SearchNotes)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseFilingNotesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseFilingNotesSearch.md)

[//]: # (OPERATION:SearchNotes_v2)

[//]: # (ENDPOINT:/filings/notes/search)

[//]: # (DOCUMENT_LINK:FilingApi.md#searchnotes)

<a name="searchnotes"></a>
## **SearchNotes**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchNotes_v2)

[//]: # (START_OVERVIEW)

> ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null)

#### Search Filing Notes

Searches for Filing Notes using the `query`

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
  public class SearchNotesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      
      var filingApi = new FilingApi();
      
      string query = "inflation";

      DateTime? filingStartDate = DateTime.Parse("2018-07-15");

      DateTime? filingEndDate = DateTime.Parse("2018-11-30");

      int? pageSize = 100;

      
      ApiResponseFilingNotesSearch result = filingApi.SearchNotes(query, filingStartDate, filingEndDate, pageSize);
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
 **query** | string| Search for notes that contain all or parts of this text |  &nbsp;
 **filingStartDate** | DateTime?| Limit search to filings on or after this date | [optional]  &nbsp;
 **filingEndDate** | DateTime?| Limit search to filings on or before this date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseFilingNotesSearch**](ApiResponseFilingNotesSearch.md)

[//]: # (END_OPERATION)


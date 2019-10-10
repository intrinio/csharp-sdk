# Intrinio.SDK.Api.FilingApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllFilings**](FilingApi.md#getallfilings) | **GET** /filings | All Filings
[**GetAllNotes**](FilingApi.md#getallnotes) | **GET** /filings/notes | All Filing Notes
[**GetFilingById**](FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
[**GetFilingFundamentals**](FilingApi.md#getfilingfundamentals) | **GET** /filings/{identifier}/fundamentals | All Fundamentals by Filing
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

> ApiResponseFilings GetAllFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

#### All Filings

Returns all Filings. Returns Filings matching parameters when supplied.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetAllFilingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var company = "AAPL";  // string | Filings for the given `company` identifier (ticker, CIK, LEI, Intrinio ID)
      var reportType = "";  // string | Filter by report type. Separate values with commas to return multiple The filing <a href=\"https://docs.intrinio.com/documentation/sec_filing_report_types\" target=\"_blank\">report types</a>. (optional) 
      var startDate = DateTime.Parse("2015-01-01");  // DateTime? | Filed on or after the given date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Filed before or after the given date (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseFilings result = filingApi.GetAllFilings(company, reportType, startDate, endDate, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetAllFilings: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetAllNotesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var company = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional) 
      var reportType = "10-Q";  // string | Notes contained in filings that match the given <a href=\"https://docs.intrinio.com/documentation/sec_filing_report_types\" target=\"_blank\">report type</a> (optional) 
      var filingStartDate = DateTime.Now;  // DateTime? | Limit search to filings on or after this date (optional) 
      var filingEndDate = DateTime.Now;  // DateTime? | Limit search to filings on or before this date (optional) 
      var periodEndedStartDate = DateTime.Now;  // DateTime? | Limit search to filings with a period end date on or after this date (optional) 
      var periodEndedEndDate = DateTime.Now;  // DateTime? | Limit search to filings with a period end date on or before this date (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseFilingNotes result = filingApi.GetAllNotes(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetAllNotes: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetFilingByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var id = "fil_7Kn2P6";  // string | The Intrinio ID of the Filing

      try
      {
        Filing result = filingApi.GetFilingById(id);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetFilingById: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetFilingFundamentalsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var identifier = "fil_B73xBG";  // string | A Filing identifier
      var statementCode = "";  // string | Filters fundamentals by statement code (optional) 
      var type = "";  // string | Filters fundamentals by type (optional) 
      var fiscalYear = "";  // int? | Filters fundamentals by fiscal year (optional) 
      var fiscalPeriod = "";  // string | Filters fundamentals by fiscal period (optional) 
      var startDate = DateTime.Now;  // DateTime? | Returns fundamentals on or after the given date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Returns fundamentals on or before the given date (optional) 
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseFilingFundamentals result = filingApi.GetFilingFundamentals(identifier, statementCode, type, fiscalYear, fiscalPeriod, startDate, endDate, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetFilingFundamentals: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetNoteExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var identifier = "xbn_ydK3QL";  // string | The Intrinio ID of the filing note
      var contentFormat = "text";  // string | Returns content in html (as filed) or plain text (optional)  (default to text)

      try
      {
        FilingNote result = filingApi.GetNote(identifier, contentFormat);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetNote: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetNoteHtmlExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var identifier = "xbn_ydK3QL";  // string | The Intrinio ID of the filing note

      try
      {
        string result = filingApi.GetNoteHtml(identifier);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetNoteHtml: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetNoteTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var identifier = "xbn_ydK3QL";  // string | The Intrinio ID of the filing note

      try
      {
        string result = filingApi.GetNoteText(identifier);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.GetNoteText: " + e.Message );
      }
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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class SearchNotesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var filingApi = new FilingApi();
      var query = "inflation";  // string | Search for notes that contain all or parts of this text
      var filingStartDate = DateTime.Parse("2018-07-15");  // DateTime? | Limit search to filings on or after this date (optional) 
      var filingEndDate = DateTime.Parse("2018-11-30");  // DateTime? | Limit search to filings on or before this date (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

      try
      {
        ApiResponseFilingNotesSearch result = filingApi.SearchNotes(query, filingStartDate, filingEndDate, pageSize);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FilingApi.SearchNotes: " + e.Message );
      }
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


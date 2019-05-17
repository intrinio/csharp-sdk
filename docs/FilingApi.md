# Intrinio.SDK.Api.FilingApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllFilings**](FilingApi.md#getallfilings) | **GET** /filings | All Filings
[**GetAllNotes**](FilingApi.md#getallnotes) | **GET** /filings/notes | All Filing Notes
[**GetFilingById**](FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllFilings_v2)

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
            var reportType = "";  // string | Filter by report type (optional) 
            var startDate = "2015-01-01";  // DateTime? | Filed on or after the given date (optional) 
            var endDate = "";  // DateTime? | Filed before or after the given date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilings result = filingApi.GetAllFilings(company, reportType, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetAllFilings: " + e.Message );
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
 **company** | **string**| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **reportType** | **string**| Filter by report type | [optional]  &nbsp;
 **startDate** | **DateTime?**| Filed on or after the given date | [optional]  &nbsp;
 **endDate** | **DateTime?**| Filed before or after the given date | [optional]  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional]  &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllNotes_v2)

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
            var reportType = "10-Q";  // string | Notes contained in filings that match the given report type (optional) 
            var filingStartDate = "2018-07-15";  // DateTime? | Limit search to filings on or after this date (optional) 
            var filingEndDate = "2018-11-15";  // DateTime? | Limit search to filings on or before this date (optional) 
            var periodEndedStartDate = "2018-07-15";  // DateTime? | Limit search to filings with a period end date on or after this date (optional) 
            var periodEndedEndDate = "2018-11-15";  // DateTime? | Limit search to filings with a period end date on or before this date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilingNotes result = filingApi.GetAllNotes(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetAllNotes: " + e.Message );
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
 **company** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | [optional]  &nbsp;
 **reportType** | **string**| Notes contained in filings that match the given report type | [optional]  &nbsp;
 **filingStartDate** | **DateTime?**| Limit search to filings on or after this date | [optional]  &nbsp;
 **filingEndDate** | **DateTime?**| Limit search to filings on or before this date | [optional]  &nbsp;
 **periodEndedStartDate** | **DateTime?**| Limit search to filings with a period end date on or after this date | [optional]  &nbsp;
 **periodEndedEndDate** | **DateTime?**| Limit search to filings with a period end date on or before this date | [optional]  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional]  &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetFilingById_v2)

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
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetFilingById: " + e.Message );
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
 **id** | **string**| The Intrinio ID of the Filing |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Filing**](Filing.md)

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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetNote_v2)

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
            var identifier = "xbn_3fghz";  // string | The Intrinio ID of the filing note
            var contentFormat = "text";  // string | Returns content in html (as filed) or plain text (optional)  (default to text)

            try
            {
                FilingNote result = filingApi.GetNote(identifier, contentFormat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetNote: " + e.Message );
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
 **identifier** | **string**| The Intrinio ID of the filing note |  &nbsp;
 **contentFormat** | **string**| Returns content in html (as filed) or plain text | [optional] [default to text] &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetNoteHtml_v2)

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
            var identifier = "xbn_3fghz";  // string | The Intrinio ID of the filing note

            try
            {
                string result = filingApi.GetNoteHtml(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetNoteHtml: " + e.Message );
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
 **identifier** | **string**| The Intrinio ID of the filing note |  &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetNoteText_v2)

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
            var identifier = "xbn_3fghz";  // string | The Intrinio ID of the filing note

            try
            {
                string result = filingApi.GetNoteText(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.GetNoteText: " + e.Message );
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
 **identifier** | **string**| The Intrinio ID of the filing note |  &nbsp;
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

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/SearchNotes_v2)

[//]: # (START_OVERVIEW)

> ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null)

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
            var filingStartDate = "2018-07-15";  // DateTime? | Limit search to filings on or after this date (optional) 
            var filingEndDate = "2018-11-30";  // DateTime? | Limit search to filings on or before this date (optional) 
            var pageSize = 50;  // int? | The number of results to return (optional)  (default to 100)
            var pageSize2 = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseFilingNotesSearch result = filingApi.SearchNotes(query, filingStartDate, filingEndDate, pageSize, pageSize2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.SearchNotes: " + e.Message );
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
 **query** | **string**| Search for notes that contain all or parts of this text |  &nbsp;
 **filingStartDate** | **DateTime?**| Limit search to filings on or after this date | [optional]  &nbsp;
 **filingEndDate** | **DateTime?**| Limit search to filings on or before this date | [optional]  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
 **pageSize2** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseFilingNotesSearch**](ApiResponseFilingNotesSearch.md)

[//]: # (END_OPERATION)


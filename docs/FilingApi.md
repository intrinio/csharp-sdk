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



[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings)

[//]: # (DOC_LINK:FilingApi.md#getallfilings)

<a name="getallfilings"></a>
# **GetAllFilings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllFilings_v2)

> ApiResponseFilings GetAllFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

All Filings

Returns all Filings. Returns Filings matching parameters when supplied.

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) | 
 **reportType** | **string**| Filter by report type | [optional] 
 **startDate** | **DateTime?**| Filed on or after the given date | [optional] 
 **endDate** | **DateTime?**| Filed before or after the given date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilings**](ApiResponseFilings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings/notes)

[//]: # (DOC_LINK:FilingApi.md#getallnotes)

<a name="getallnotes"></a>
# **GetAllNotes**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllNotes_v2)

> ApiResponseFilingNotes GetAllNotes (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null)

All Filing Notes

Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | [optional] 
 **reportType** | **string**| Notes contained in filings that match the given report type | [optional] 
 **filingStartDate** | **DateTime?**| Limit search to filings on or after this date | [optional] 
 **filingEndDate** | **DateTime?**| Limit search to filings on or before this date | [optional] 
 **periodEndedStartDate** | **DateTime?**| Limit search to filings with a period end date on or after this date | [optional] 
 **periodEndedEndDate** | **DateTime?**| Limit search to filings with a period end date on or before this date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilingNotes**](ApiResponseFilingNotes.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings/{id})

[//]: # (DOC_LINK:FilingApi.md#getfilingbyid)

<a name="getfilingbyid"></a>
# **GetFilingById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetFilingById_v2)

> Filing GetFilingById (string id)

Lookup Filing

Returns the Filing with the given `identifier`

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID of the Filing | 

### Return type

[**Filing**](Filing.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings/notes/{identifier})

[//]: # (DOC_LINK:FilingApi.md#getnote)

<a name="getnote"></a>
# **GetNote**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetNote_v2)

> FilingNote GetNote (string identifier, string contentFormat = null)

Filing Note by ID

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID of the filing note | 
 **contentFormat** | **string**| Returns content in html (as filed) or plain text | [optional] [default to text]

### Return type

[**FilingNote**](FilingNote.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings/notes/{identifier}/html)

[//]: # (DOC_LINK:FilingApi.md#getnotehtml)

<a name="getnotehtml"></a>
# **GetNoteHtml**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetNoteHtml_v2)

> string GetNoteHtml (string identifier)

Filing Note HTML

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID of the filing note | 

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings/notes/{identifier}/text)

[//]: # (DOC_LINK:FilingApi.md#getnotetext)

<a name="getnotetext"></a>
# **GetNoteText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetNoteText_v2)

> string GetNoteText (string identifier)

Filing Note Text

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID of the filing note | 

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/filings/notes/search)

[//]: # (DOC_LINK:FilingApi.md#searchnotes)

<a name="searchnotes"></a>
# **SearchNotes**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/SearchNotes_v2)

> ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null)

Search Filing Notes

Searches for Filing Notes using the `query`

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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search for notes that contain all or parts of this text | 
 **filingStartDate** | **DateTime?**| Limit search to filings on or after this date | [optional] 
 **filingEndDate** | **DateTime?**| Limit search to filings on or before this date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **pageSize2** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseFilingNotesSearch**](ApiResponseFilingNotesSearch.md)

[//]: # (END_OPERATION)


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


<a name="getallfilings"></a>
# **GetAllFilings**
> ApiResponseFilings GetAllFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, decimal? pageSize = null, string nextPage = null)

All Filings

Returns all Filings. Returns Filings matching parameters when supplied.

### Example
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
            var endDate = "2019-01-01";  // DateTime? | Filed before or after the given date (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) | 
 **reportType** | **string**| Filter by report type | [optional] 
 **startDate** | **DateTime?**| Filed on or after the given date | [optional] 
 **endDate** | **DateTime?**| Filed before or after the given date | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilings**](ApiResponseFilings.md)

<a name="getallnotes"></a>
# **GetAllNotes**
> ApiResponseFilingNotes GetAllNotes (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, decimal? pageSize = null, string nextPage = null)

All Filing Notes

Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.

### Example
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
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | [optional] 
 **reportType** | **string**| Notes contained in filings that match the given report type | [optional] 
 **filingStartDate** | **DateTime?**| Limit search to filings on or after this date | [optional] 
 **filingEndDate** | **DateTime?**| Limit search to filings on or before this date | [optional] 
 **periodEndedStartDate** | **DateTime?**| Limit search to filings with a period end date on or after this date | [optional] 
 **periodEndedEndDate** | **DateTime?**| Limit search to filings with a period end date on or before this date | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilingNotes**](ApiResponseFilingNotes.md)

<a name="getfilingbyid"></a>
# **GetFilingById**
> Filing GetFilingById (string id)

Lookup Filing

Returns the Filing with the given `identifier`

### Example
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID of the Filing | 

### Return type

[**Filing**](Filing.md)

<a name="getnote"></a>
# **GetNote**
> FilingNote GetNote (string identifier, string contentFormat = null)

Filing Note by ID

### Example
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID of the filing note | 
 **contentFormat** | **string**| Returns content in html (as filed) or plain text | [optional] [default to text]

### Return type

[**FilingNote**](FilingNote.md)

<a name="getnotehtml"></a>
# **GetNoteHtml**
> string GetNoteHtml (string identifier)

Filing Note HTML

### Example
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID of the filing note | 

### Return type

**string**

<a name="getnotetext"></a>
# **GetNoteText**
> string GetNoteText (string identifier)

Filing Note Text

### Example
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID of the filing note | 

### Return type

**string**

<a name="searchnotes"></a>
# **SearchNotes**
> ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, decimal? pageSize = null, decimal? pageSize2 = null)

Search Filing Notes

Searches for Filing Notes using the `query`

### Example
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
            var pageSize = 50;  // decimal? | The number of results to return (optional)  (default to 100)
            var pageSize2 = 100;  // decimal? | The number of results to return (optional)  (default to 100)

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search for notes that contain all or parts of this text | 
 **filingStartDate** | **DateTime?**| Limit search to filings on or after this date | [optional] 
 **filingEndDate** | **DateTime?**| Limit search to filings on or before this date | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **pageSize2** | **decimal?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseFilingNotesSearch**](ApiResponseFilingNotesSearch.md)


# Intrinio.SDK.Api.FilingApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterFilings**](FilingApi.md#filterfilings) | **GET** /filings/filter | Filter Filings
[**FilterNotes**](FilingApi.md#filternotes) | **GET** /filings/notes/filter | Filter SEC filing notes
[**GetAllFilings**](FilingApi.md#getallfilings) | **GET** /filings | All Filings
[**GetAllNotes**](FilingApi.md#getallnotes) | **GET** /filings/notes | Get All SEC filing notes
[**GetFilingById**](FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
[**GetNote**](FilingApi.md#getnote) | **GET** /filings/notes/{identifier} | Get an SEC filing note by ID
[**GetNoteHtml**](FilingApi.md#getnotehtml) | **GET** /filings/notes/{identifier}/html | Returns the content of an SEC filing note as originally filed
[**GetNoteText**](FilingApi.md#getnotetext) | **GET** /filings/notes/{identifier}/text | Returns the content of an SEC filing note stripped of HTML
[**SearchNotes**](FilingApi.md#searchnotes) | **GET** /filings/notes/search | Search Filing Notes


<a name="filterfilings"></a>
# **FilterFilings**
> ApiResponseFilings FilterFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

Filter Filings

Returns Filings that match the specified filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class FilterFilingsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var filingApi = new FilingApi();
            var company = "AAPL";  // string | Filings for the given `company` identifier (ticker, CIK, LEI, Intrinio ID)
            var reportType = "";  // string | Filter by report type (optional) 
            var startDate = "2015-01-01";  // DateTime? | Filed on or after the given date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Filed before or after the given date (optional) 
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilings result = filingApi.FilterFilings(company, reportType, startDate, endDate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.FilterFilings: " + e.Message );
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
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilings**](ApiResponseFilings.md)

<a name="filternotes"></a>
# **FilterNotes**
> ApiResponseFilingNotes FilterNotes (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, string nextPage = null)

Filter SEC filing notes

Returns SEC filing notes matching the supplied criteria

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class FilterNotesExample
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
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilingNotes result = filingApi.FilterNotes(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FilingApi.FilterNotes: " + e.Message );
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
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilingNotes**](ApiResponseFilingNotes.md)

<a name="getallfilings"></a>
# **GetAllFilings**
> ApiResponseFilings GetAllFilings (string nextPage = null)

All Filings

Returns all Filings

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
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilings result = filingApi.GetAllFilings(nextPage);
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
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseFilings**](ApiResponseFilings.md)

<a name="getallnotes"></a>
# **GetAllNotes**
> ApiResponseFilingNotes GetAllNotes (string nextPage = null)

Get All SEC filing notes

Return All notes from SEC Filings, most-recent first

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
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseFilingNotes result = filingApi.GetAllNotes(nextPage);
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

Get an SEC filing note by ID

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

Returns the content of an SEC filing note as originally filed

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

Returns the content of an SEC filing note stripped of HTML

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
> ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, decimal? pageSize = null)

Search Filing Notes

Searches SEC filing notes using the text in `query`

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

            try
            {
                ApiResponseFilingNotesSearch result = filingApi.SearchNotes(query, filingStartDate, filingEndDate, pageSize);
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

### Return type

[**ApiResponseFilingNotesSearch**](ApiResponseFilingNotesSearch.md)


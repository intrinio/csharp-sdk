# Intrinio.Api.CompanyApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterCompanies**](CompanyApi.md#filtercompanies) | **GET** /companies/filter | Filter Companies
[**FilterCompanyFundamentals**](CompanyApi.md#filtercompanyfundamentals) | **GET** /companies/{identifier}/fundamentals/filter | Filter Fundamentals for a Company
[**GetAllCompanies**](CompanyApi.md#getallcompanies) | **GET** /companies | Get All Companies
[**GetAllCompanyFilings**](CompanyApi.md#getallcompanyfilings) | **GET** /companies/{identifier}/filings | Filings
[**GetAllCompanyFundamentals**](CompanyApi.md#getallcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | Get All Fundamentals for a Company
[**GetCompany**](CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Get a Company by ID
[**GetCompanyDataPointNumber**](CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{item}/number | Get Company Data Point (Number)
[**GetCompanyDataPointText**](CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{item}/text | Get Company Data Point (Text)
[**GetCompanyHistoricalData**](CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{item} | Get Company Historical Data
[**GetNews**](CompanyApi.md#getnews) | **GET** /companies/{identifier}/news | News
[**LookupCompanyFundamental**](CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup a Fundamental for a Company
[**SearchCompanies**](CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies


<a name="filtercompanies"></a>
# **FilterCompanies**
> List<CompanySummary> FilterCompanies (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null)

Filter Companies

Returns Companies matching the specified filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class FilterCompaniesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var lastFilingDate = 2013-10-20;  // DateTime? | Last filing date (optional) 
            var sic = sic_example;  // string | Standard Industrial Classification code (optional) 
            var template = template_example;  // string | Template (optional) 
            var sector = sector_example;  // string | Industry sector (optional) 
            var industryCategory = industryCategory_example;  // string | Industry category (optional) 
            var industryGroup = industryGroup_example;  // string | Industry group (optional) 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;CompanySummary&gt; result = companyApi.FilterCompanies(lastFilingDate, sic, template, sector, industryCategory, industryGroup, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.FilterCompanies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastFilingDate** | **DateTime?**| Last filing date | [optional] 
 **sic** | **string**| Standard Industrial Classification code | [optional] 
 **template** | **string**| Template | [optional] 
 **sector** | **string**| Industry sector | [optional] 
 **industryCategory** | **string**| Industry category | [optional] 
 **industryGroup** | **string**| Industry group | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<CompanySummary>**](CompanySummary.md)

<a name="filtercompanyfundamentals"></a>
# **FilterCompanyFundamentals**
> List<Fundamental> FilterCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

Filter Fundamentals for a Company

Returns Fundamentals for the Company with the given `identifier` and matching the specified filters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class FilterCompanyFundamentalsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var filedAfter = 2013-10-20;  // DateTime? | Filed on or after this date (optional) 
            var filedBefore = 2013-10-20;  // DateTime? | Filed on or before this date (optional) 
            var reportedOnly = true;  // bool? | Only as-reported fundamentals (optional) 
            var fiscalYear = 56;  // int? | Only for the given fiscal year (optional) 
            var statementCode = statementCode_example;  // string | Only of the given statement code (optional) 
            var type = type_example;  // string | Only of the given type (optional) 
            var startDate = 2013-10-20;  // DateTime? | Only on or after the given date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Only on or after the given date (optional) 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;Fundamental&gt; result = companyApi.FilterCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.FilterCompanyFundamentals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **filedAfter** | **DateTime?**| Filed on or after this date | [optional] 
 **filedBefore** | **DateTime?**| Filed on or before this date | [optional] 
 **reportedOnly** | **bool?**| Only as-reported fundamentals | [optional] 
 **fiscalYear** | **int?**| Only for the given fiscal year | [optional] 
 **statementCode** | **string**| Only of the given statement code | [optional] 
 **type** | **string**| Only of the given type | [optional] 
 **startDate** | **DateTime?**| Only on or after the given date | [optional] 
 **endDate** | **DateTime?**| Only on or after the given date | [optional] 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<Fundamental>**](Fundamental.md)

<a name="getallcompanies"></a>
# **GetAllCompanies**
> List<CompanySummary> GetAllCompanies (string nextPage = null)

Get All Companies

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllCompaniesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;CompanySummary&gt; result = companyApi.GetAllCompanies(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetAllCompanies: " + e.Message );
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

[**List<CompanySummary>**](CompanySummary.md)

<a name="getallcompanyfilings"></a>
# **GetAllCompanyFilings**
> List<FilingSummary> GetAllCompanyFilings (string identifier, string nextPage = null)

Filings

Returns a complete list of SEC filings for the Company with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllCompanyFilingsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;FilingSummary&gt; result = companyApi.GetAllCompanyFilings(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetAllCompanyFilings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<FilingSummary>**](FilingSummary.md)

<a name="getallcompanyfundamentals"></a>
# **GetAllCompanyFundamentals**
> List<Fundamental> GetAllCompanyFundamentals (string identifier, string nextPage = null)

Get All Fundamentals for a Company

Returns all Fundamentals for the Company with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllCompanyFundamentalsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;Fundamental&gt; result = companyApi.GetAllCompanyFundamentals(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetAllCompanyFundamentals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<Fundamental>**](Fundamental.md)

<a name="getcompany"></a>
# **GetCompany**
> Company GetCompany (string identifier)

Get a Company by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetCompanyExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)

            try
            {
                Company result = companyApi.GetCompany(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 

### Return type

[**Company**](Company.md)

<a name="getcompanydatapointnumber"></a>
# **GetCompanyDataPointNumber**
> DataPointNumber GetCompanyDataPointNumber (string identifier, string item)

Get Company Data Point (Number)

Returns a numeric value for the given `item` for the Company with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetCompanyDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag

            try
            {
                DataPointNumber result = companyApi.GetCompanyDataPointNumber(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanyDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="getcompanydatapointtext"></a>
# **GetCompanyDataPointText**
> DataPointText GetCompanyDataPointText (string identifier, string item)

Get Company Data Point (Text)

Returns a text value for the given `item` for the Company with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetCompanyDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag

            try
            {
                DataPointText result = companyApi.GetCompanyDataPointText(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanyDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag | 

### Return type

[**DataPointText**](DataPointText.md)

<a name="getcompanyhistoricaldata"></a>
# **GetCompanyHistoricalData**
> List<HistoricalData> GetCompanyHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Company Historical Data

Returns historical values for the given `item` and the Company with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetCompanyHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var item = item_example;  // string | Item
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;HistoricalData&gt; result = companyApi.GetCompanyHistoricalData(identifier, item, type, startDate, endDate, sortOrder, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanyHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **item** | **string**| Item | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<HistoricalData>**](HistoricalData.md)

<a name="getnews"></a>
# **GetNews**
> List<CompanyNews> GetNews (string identifier, string nextPage = null)

News

Returns news for the Company with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetNewsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;CompanyNews&gt; result = companyApi.GetNews(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetNews: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<CompanyNews>**](CompanyNews.md)

<a name="lookupcompanyfundamental"></a>
# **LookupCompanyFundamental**
> List<Fundamental> LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)

Lookup a Fundamental for a Company

Returns the Fundamental for the Company with the given `identifier` and with the given parameters

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class LookupCompanyFundamentalExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var statementCode = statementCode_example;  // string | The statement code
            var fiscalPeriod = fiscalPeriod_example;  // string | The fiscal period
            var fiscalYear = 56;  // int? | The fiscal year

            try
            {
                List&lt;Fundamental&gt; result = companyApi.LookupCompanyFundamental(identifier, statementCode, fiscalPeriod, fiscalYear);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.LookupCompanyFundamental: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **statementCode** | **string**| The statement code | 
 **fiscalPeriod** | **string**| The fiscal period | 
 **fiscalYear** | **int?**| The fiscal year | 

### Return type

[**List<Fundamental>**](Fundamental.md)

<a name="searchcompanies"></a>
# **SearchCompanies**
> List<CompanySummary> SearchCompanies (string query, string nextPage = null)

Search Companies

Searches for Companies matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchCompaniesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var query = query_example;  // string | Search parameters
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;CompanySummary&gt; result = companyApi.SearchCompanies(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.SearchCompanies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search parameters | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<CompanySummary>**](CompanySummary.md)


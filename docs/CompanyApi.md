# Intrinio.Api.CompanyApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterCompanies**](CompanyApi.md#filtercompanies) | **GET** /companies/filter | Filter Companies
[**FilterCompanyFundamentals**](CompanyApi.md#filtercompanyfundamentals) | **GET** /companies/{identifier}/fundamentals/filter | Filter Fundamentals for a Company
[**GetAllCompanies**](CompanyApi.md#getallcompanies) | **GET** /companies | Get All Companies
[**GetAllCompanyNews**](CompanyApi.md#getallcompanynews) | **GET** /companies/news | Get All Company News
[**GetCompany**](CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Get a Company by ID
[**GetCompanyDataPointNumber**](CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{tag}/number | Get Company Data Point (Number)
[**GetCompanyDataPointText**](CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{tag}/text | Get Company Data Point (Text)
[**GetCompanyFilings**](CompanyApi.md#getcompanyfilings) | **GET** /companies/{identifier}/filings | Get Filings for a Company
[**GetCompanyFundamentals**](CompanyApi.md#getcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | Get All Fundamentals for a Company
[**GetCompanyHistoricalData**](CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{tag} | Get Company Historical Data
[**GetCompanyNews**](CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | Get News for a Company
[**GetCompanySecurities**](CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | Get Securities by Company
[**LookupCompanyFundamental**](CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup a Fundamental for a Company
[**SearchCompanies**](CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies


<a name="filtercompanies"></a>
# **FilterCompanies**
> ApiResponseCompanies FilterCompanies (DateTime? lastFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, string nextPage = null)

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var lastFilingDate = 2013-10-20;  // DateTime? | Last filing date (optional) 
            var sic = sic_example;  // string | Standard Industrial Classification code (optional) 
            var template = template_example;  // string | Template (optional) 
            var sector = sector_example;  // string | Industry sector (optional) 
            var industryCategory = industryCategory_example;  // string | Industry category (optional) 
            var industryGroup = industryGroup_example;  // string | Industry group (optional) 
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanies result = companyApi.FilterCompanies(lastFilingDate, sic, template, sector, industryCategory, industryGroup, nextPage);
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

[**ApiResponseCompanies**](ApiResponseCompanies.md)

<a name="filtercompanyfundamentals"></a>
# **FilterCompanyFundamentals**
> ApiResponseCompanyFundamentals FilterCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

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
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyFundamentals result = companyApi.FilterCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, nextPage);
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

[**ApiResponseCompanyFundamentals**](ApiResponseCompanyFundamentals.md)

<a name="getallcompanies"></a>
# **GetAllCompanies**
> ApiResponseCompanies GetAllCompanies (string nextPage = null)

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanies result = companyApi.GetAllCompanies(nextPage);
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

[**ApiResponseCompanies**](ApiResponseCompanies.md)

<a name="getallcompanynews"></a>
# **GetAllCompanyNews**
> ApiResponseNews GetAllCompanyNews (string nextPage = null)

Get All Company News

Returns all news for all companies

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllCompanyNewsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseNews result = companyApi.GetAllCompanyNews(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetAllCompanyNews: " + e.Message );
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

[**ApiResponseNews**](ApiResponseNews.md)

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

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
> decimal? GetCompanyDataPointNumber (string identifier, string tag)

Get Company Data Point (Number)

Returns a numeric value for the given `tag` for the Company with the given `identifier`

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var tag = tag_example;  // string | An Intrinio data tag

            try
            {
                decimal? result = companyApi.GetCompanyDataPointNumber(identifier, tag);
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
 **tag** | **string**| An Intrinio data tag | 

### Return type

**decimal?**

<a name="getcompanydatapointtext"></a>
# **GetCompanyDataPointText**
> string GetCompanyDataPointText (string identifier, string tag)

Get Company Data Point (Text)

Returns a text value for the given `tag` for the Company with the given `identifier`

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var tag = tag_example;  // string | An Intrinio data tag

            try
            {
                string result = companyApi.GetCompanyDataPointText(identifier, tag);
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
 **tag** | **string**| An Intrinio data tag | 

### Return type

**string**

<a name="getcompanyfilings"></a>
# **GetCompanyFilings**
> ApiResponseCompanyFilings GetCompanyFilings (string identifier, string nextPage = null)

Get Filings for a Company

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
    public class GetCompanyFilingsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyFilings result = companyApi.GetCompanyFilings(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanyFilings: " + e.Message );
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

[**ApiResponseCompanyFilings**](ApiResponseCompanyFilings.md)

<a name="getcompanyfundamentals"></a>
# **GetCompanyFundamentals**
> ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, string nextPage = null)

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
    public class GetCompanyFundamentalsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyFundamentals result = companyApi.GetCompanyFundamentals(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanyFundamentals: " + e.Message );
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

[**ApiResponseCompanyFundamentals**](ApiResponseCompanyFundamentals.md)

<a name="getcompanyhistoricaldata"></a>
# **GetCompanyHistoricalData**
> ApiResponseCompanyHistoricalData GetCompanyHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Company Historical Data

Returns historical values for the given `tag` and the Company with the given `identifier`

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var tag = tag_example;  // string | Item
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyHistoricalData result = companyApi.GetCompanyHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
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
 **tag** | **string**| Item | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanyHistoricalData**](ApiResponseCompanyHistoricalData.md)

<a name="getcompanynews"></a>
# **GetCompanyNews**
> ApiResponseCompanyNews GetCompanyNews (string identifier, string nextPage = null)

Get News for a Company

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
    public class GetCompanyNewsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyNews result = companyApi.GetCompanyNews(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanyNews: " + e.Message );
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

[**ApiResponseCompanyNews**](ApiResponseCompanyNews.md)

<a name="getcompanysecurities"></a>
# **GetCompanySecurities**
> ApiResponseCompanySecurities GetCompanySecurities (string identifier, string nextPage = null)

Get Securities by Company

Return Securities for the Company with `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetCompanySecuritiesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanySecurities result = companyApi.GetCompanySecurities(identifier, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.GetCompanySecurities: " + e.Message );
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

[**ApiResponseCompanySecurities**](ApiResponseCompanySecurities.md)

<a name="lookupcompanyfundamental"></a>
# **LookupCompanyFundamental**
> Fundamental LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var statementCode = statementCode_example;  // string | The statement code
            var fiscalPeriod = fiscalPeriod_example;  // string | The fiscal period
            var fiscalYear = 56;  // int? | The fiscal year

            try
            {
                Fundamental result = companyApi.LookupCompanyFundamental(identifier, statementCode, fiscalPeriod, fiscalYear);
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

[**Fundamental**](Fundamental.md)

<a name="searchcompanies"></a>
# **SearchCompanies**
> ApiResponseCompanies SearchCompanies (string query)

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
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var query = query_example;  // string | Search parameters

            try
            {
                ApiResponseCompanies result = companyApi.SearchCompanies(query);
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

### Return type

[**ApiResponseCompanies**](ApiResponseCompanies.md)


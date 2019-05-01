# Intrinio.SDK.Api.CompanyApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllCompanies**](CompanyApi.md#getallcompanies) | **GET** /companies | All Companies
[**GetAllCompanyNews**](CompanyApi.md#getallcompanynews) | **GET** /companies/news | All News
[**GetCompany**](CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Lookup Company
[**GetCompanyDataPointNumber**](CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{tag}/number | Data Point (Number) for Company
[**GetCompanyDataPointText**](CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{tag}/text | Data Point (Text) for Company
[**GetCompanyFilings**](CompanyApi.md#getcompanyfilings) | **GET** /companies/{identifier}/filings | All Filings by Company
[**GetCompanyFundamentals**](CompanyApi.md#getcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | All Fundamentals by Company
[**GetCompanyHistoricalData**](CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{tag} | Historical Data for Company
[**GetCompanyNews**](CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | All News by Company
[**GetCompanySecurities**](CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | All Securities by Company
[**LookupCompanyFundamental**](CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental by Company
[**SearchCompanies**](CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies



[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies)

[//]: # (DOC_LINK:CompanyApi.md#getallcompanies)

<a name="getallcompanies"></a>
# **GetAllCompanies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllCompanies_v2)

> ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null)

All Companies

Returns all Companies. When parameters are specified, returns matching companies.

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
    public class GetAllCompaniesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var latestFilingDate = "";  // DateTime? | Last filing date (optional) 
            var sic = "";  // string | Standard Industrial Classification code (optional) 
            var template = "";  // string | Template (optional) 
            var sector = "";  // string | Industry sector (optional) 
            var industryCategory = "";  // string | Industry category (optional) 
            var industryGroup = "";  // string | Industry group (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanies result = companyApi.GetAllCompanies(latestFilingDate, sic, template, sector, industryCategory, industryGroup, pageSize, nextPage);
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latestFilingDate** | **DateTime?**| Last filing date | [optional] 
 **sic** | **string**| Standard Industrial Classification code | [optional] 
 **template** | **string**| Template | [optional] 
 **sector** | **string**| Industry sector | [optional] 
 **industryCategory** | **string**| Industry category | [optional] 
 **industryGroup** | **string**| Industry group | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanies**](ApiResponseCompanies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/news)

[//]: # (DOC_LINK:CompanyApi.md#getallcompanynews)

<a name="getallcompanynews"></a>
# **GetAllCompanyNews**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetAllCompanyNews_v2)

> ApiResponseNews GetAllCompanyNews (int? pageSize = null, string nextPage = null)

All News

Returns all News for all Companies

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
    public class GetAllCompanyNewsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseNews result = companyApi.GetAllCompanyNews(pageSize, nextPage);
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseNews**](ApiResponseNews.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier})

[//]: # (DOC_LINK:CompanyApi.md#getcompany)

<a name="getcompany"></a>
# **GetCompany**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompany_v2)

> Company GetCompany (string identifier)

Lookup Company

Returns the Company with the given `identifier`

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
    public class GetCompanyExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)

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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 

### Return type

[**Company**](Company.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/data_point/{tag}/number)

[//]: # (DOC_LINK:CompanyApi.md#getcompanydatapointnumber)

<a name="getcompanydatapointnumber"></a>
# **GetCompanyDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanyDataPointNumber_v2)

> decimal? GetCompanyDataPointNumber (string identifier, string tag)

Data Point (Number) for Company

Returns a numeric value for the given `tag` for the Company with the given `identifier`

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
    public class GetCompanyDataPointNumberExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var tag = "marketcap";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)

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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) | 

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/data_point/{tag}/text)

[//]: # (DOC_LINK:CompanyApi.md#getcompanydatapointtext)

<a name="getcompanydatapointtext"></a>
# **GetCompanyDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanyDataPointText_v2)

> string GetCompanyDataPointText (string identifier, string tag)

Data Point (Text) for Company

Returns a text value for the given `tag` for the Company with the given `identifier`

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
    public class GetCompanyDataPointTextExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var tag = "ceo";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)

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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) | 

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/filings)

[//]: # (DOC_LINK:CompanyApi.md#getcompanyfilings)

<a name="getcompanyfilings"></a>
# **GetCompanyFilings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanyFilings_v2)

> ApiResponseCompanyFilings GetCompanyFilings (string identifier, int? pageSize = null, string nextPage = null)

All Filings by Company

Returns a complete list of SEC filings for the Company with the given `identifier`

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
    public class GetCompanyFilingsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyFilings result = companyApi.GetCompanyFilings(identifier, pageSize, nextPage);
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanyFilings**](ApiResponseCompanyFilings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/fundamentals)

[//]: # (DOC_LINK:CompanyApi.md#getcompanyfundamentals)

<a name="getcompanyfundamentals"></a>
# **GetCompanyFundamentals**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanyFundamentals_v2)

> ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

All Fundamentals by Company

Returns all Fundamentals for the Company with the given `identifier`. Returns Fundamentals matching parameters when supplied.

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
    public class GetCompanyFundamentalsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var filedAfter = "";  // DateTime? | Filed on or after this date (optional) 
            var filedBefore = "";  // DateTime? | Filed on or before this date (optional) 
            var reportedOnly = false;  // bool? | Only as-reported fundamentals (optional) 
            var fiscalYear = "";  // int? | Only for the given fiscal year (optional) 
            var statementCode = "";  // string | Only of the given statement code (optional) 
            var type = "";  // string | Only of the given type (optional) 
            var startDate = "";  // DateTime? | Only on or after the given date (optional) 
            var endDate = "";  // DateTime? | Only on or before the given date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyFundamentals result = companyApi.GetCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, pageSize, nextPage);
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

[//]: # (END_CODE_EXAMPLE)

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
 **endDate** | **DateTime?**| Only on or before the given date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanyFundamentals**](ApiResponseCompanyFundamentals.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/historical_data/{tag})

[//]: # (DOC_LINK:CompanyApi.md#getcompanyhistoricaldata)

<a name="getcompanyhistoricaldata"></a>
# **GetCompanyHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanyHistoricalData_v2)

> ApiResponseCompanyHistoricalData GetCompanyHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

Historical Data for Company

Returns historical values for the given `tag` and the Company with the given `identifier`

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
    public class GetCompanyHistoricalDataExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var tag = "marketcap";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)
            var frequency = "daily";  // string | Return historical data in the given frequency (optional)  (default to daily)
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "";  // DateTime? | Get historical data on or before this date (optional) 
            var sortOrder = "";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyHistoricalData result = companyApi.GetCompanyHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **tag** | **string**| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) | 
 **frequency** | **string**| Return historical data in the given frequency | [optional] [default to daily]
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical data on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanyHistoricalData**](ApiResponseCompanyHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/news)

[//]: # (DOC_LINK:CompanyApi.md#getcompanynews)

<a name="getcompanynews"></a>
# **GetCompanyNews**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanyNews_v2)

> ApiResponseCompanyNews GetCompanyNews (string identifier, int? pageSize = null, string nextPage = null)

All News by Company

Returns news for the Company with the given `identifier`

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
    public class GetCompanyNewsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseCompanyNews result = companyApi.GetCompanyNews(identifier, pageSize, nextPage);
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanyNews**](ApiResponseCompanyNews.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/securities)

[//]: # (DOC_LINK:CompanyApi.md#getcompanysecurities)

<a name="getcompanysecurities"></a>
# **GetCompanySecurities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetCompanySecurities_v2)

> ApiResponseCompanySecurities GetCompanySecurities (string identifier, string nextPage = null)

All Securities by Company

Returns Securities for the Company with the given `identifier`

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
    public class GetCompanySecuritiesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseCompanySecurities**](ApiResponseCompanySecurities.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period})

[//]: # (DOC_LINK:CompanyApi.md#lookupcompanyfundamental)

<a name="lookupcompanyfundamental"></a>
# **LookupCompanyFundamental**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/LookupCompanyFundamental_v2)

> Fundamental LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)

Lookup Fundamental by Company

Returns the Fundamental for the Company with the given `identifier` and with the given parameters

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
    public class LookupCompanyFundamentalExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var statementCode = "income_statement";  // string | The statement code
            var fiscalPeriod = "FY";  // string | The fiscal period
            var fiscalYear = 2017;  // int? | The fiscal year

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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **statementCode** | **string**| The statement code | 
 **fiscalPeriod** | **string**| The fiscal period | 
 **fiscalYear** | **int?**| The fiscal year | 

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/companies/search)

[//]: # (DOC_LINK:CompanyApi.md#searchcompanies)

<a name="searchcompanies"></a>
# **SearchCompanies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/SearchCompanies_v2)

> ApiResponseCompaniesSearch SearchCompanies (string query, int? pageSize = null)

Search Companies

Searches for Companies matching the text `query`

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
    public class SearchCompaniesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            var query = "Apple";  // string | Search parameters
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseCompaniesSearch result = companyApi.SearchCompanies(query, pageSize);
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

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| Search parameters | 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseCompaniesSearch**](ApiResponseCompaniesSearch.md)

[//]: # (END_OPERATION)


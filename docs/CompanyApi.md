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
[**GetCompanyIpos**](CompanyApi.md#getcompanyipos) | **GET** /companies/ipos | IPOs
[**GetCompanyNews**](CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | All News by Company
[**GetCompanySecurities**](CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | All Securities by Company
[**LookupCompanyFundamental**](CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental by Company
[**SearchCompanies**](CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetAllCompanies)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanies)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanies.md)

[//]: # (OPERATION:GetAllCompanies_v2)

[//]: # (ENDPOINT:/companies)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getallcompanies)

<a name="getallcompanies"></a>
## **GetAllCompanies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllCompanies_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, int? pageSize = null, string nextPage = null)

#### All Companies

Returns all Companies. When parameters are specified, returns matching companies.

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
  public class GetAllCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var companyApi = new CompanyApi();
      var latestFilingDate = DateTime.Now;  // DateTime? | Last filing date (optional) 
      var sic = "";  // string | Return companies with the given Standard Industrial Classification code (optional) 
      var template = "";  // string | Return companies with the given financial statement template (optional) 
      var sector = "";  // string | Return companies in the given industry sector (optional) 
      var industryCategory = "";  // string | Return companies in the given industry category (optional) 
      var industryGroup = "";  // string | Return companies in the given industry group (optional) 
      var hasFundamentals = true;  // bool? | Return only companies that have fundamentals when true (optional) 
      var hasStockPrices = true;  // bool? | Return only companies that have stock prices when true (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseCompanies result = companyApi.GetAllCompanies(latestFilingDate, sic, template, sector, industryCategory, industryGroup, hasFundamentals, hasStockPrices, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetAllCompanies: " + e.Message );
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
 **latestFilingDate** | DateTime?| Last filing date | [optional]  &nbsp;
 **sic** | string| Return companies with the given Standard Industrial Classification code | [optional]  &nbsp;
 **template** | string| Return companies with the given financial statement template | [optional]  &nbsp;
 **sector** | string| Return companies in the given industry sector | [optional]  &nbsp;
 **industryCategory** | string| Return companies in the given industry category | [optional]  &nbsp;
 **industryGroup** | string| Return companies in the given industry group | [optional]  &nbsp;
 **hasFundamentals** | bool?| Return only companies that have fundamentals when true | [optional]  &nbsp;
 **hasStockPrices** | bool?| Return only companies that have stock prices when true | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanies**](ApiResponseCompanies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetAllCompanyNews)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseNews)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseNews.md)

[//]: # (OPERATION:GetAllCompanyNews_v2)

[//]: # (ENDPOINT:/companies/news)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getallcompanynews)

<a name="getallcompanynews"></a>
## **GetAllCompanyNews**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllCompanyNews_v2)

[//]: # (START_OVERVIEW)

> ApiResponseNews GetAllCompanyNews (int? pageSize = null, string nextPage = null)

#### All News

Returns all News for all Companies

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetAllCompanyNews: " + e.Message );
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseNews**](ApiResponseNews.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompany)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Company)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Company.md)

[//]: # (OPERATION:GetCompany_v2)

[//]: # (ENDPOINT:/companies/{identifier})

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompany)

<a name="getcompany"></a>
## **GetCompany**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompany_v2)

[//]: # (START_OVERVIEW)

> Company GetCompany (string identifier)

#### Lookup Company

Returns the Company with the given `identifier`

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompany: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Company**](Company.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetCompanyDataPointNumber_v2)

[//]: # (ENDPOINT:/companies/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanydatapointnumber)

<a name="getcompanydatapointnumber"></a>
## **GetCompanyDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetCompanyDataPointNumber (string identifier, string tag)

#### Data Point (Number) for Company

Returns a numeric value for the given `tag` for the Company with the given `identifier`

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyDataPointNumber: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetCompanyDataPointText_v2)

[//]: # (ENDPOINT:/companies/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanydatapointtext)

<a name="getcompanydatapointtext"></a>
## **GetCompanyDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetCompanyDataPointText (string identifier, string tag)

#### Data Point (Text) for Company

Returns a text value for the given `tag` for the Company with the given `identifier`

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyDataPointText: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyFilings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyFilings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyFilings.md)

[//]: # (OPERATION:GetCompanyFilings_v2)

[//]: # (ENDPOINT:/companies/{identifier}/filings)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanyfilings)

<a name="getcompanyfilings"></a>
## **GetCompanyFilings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyFilings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

#### All Filings by Company

Returns a complete list of SEC filings for the Company with the given `identifier`

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
  public class GetCompanyFilingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var companyApi = new CompanyApi();
      var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
      var reportType = "";  // string | Filter by <a href=\"https://docs.intrinio.com/documentation/sec_filing_report_types\" target=\"_blank\">report type</a>. Separate values with commas to return multiple report types. (optional) 
      var startDate = DateTime.Parse("2015-01-01");  // DateTime? | Filed on or after the given date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Filed before or after the given date (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseCompanyFilings result = companyApi.GetCompanyFilings(identifier, reportType, startDate, endDate, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyFilings: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **reportType** | string| Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. | [optional]  &nbsp;
 **startDate** | DateTime?| Filed on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Filed before or after the given date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyFilings**](ApiResponseCompanyFilings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyFundamentals)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyFundamentals)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyFundamentals.md)

[//]: # (OPERATION:GetCompanyFundamentals_v2)

[//]: # (ENDPOINT:/companies/{identifier}/fundamentals)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanyfundamentals)

<a name="getcompanyfundamentals"></a>
## **GetCompanyFundamentals**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyFundamentals_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

#### All Fundamentals by Company

Returns all Fundamentals for the Company with the given `identifier`. Returns Fundamentals matching parameters when supplied.

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
  public class GetCompanyFundamentalsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var companyApi = new CompanyApi();
      var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
      var filedAfter = DateTime.Now;  // DateTime? | Filed on or after this date (optional) 
      var filedBefore = DateTime.Now;  // DateTime? | Filed on or before this date (optional) 
      var reportedOnly = false;  // bool? | Only as-reported fundamentals (optional) 
      var fiscalYear = "";  // int? | Only for the given fiscal year (optional) 
      var statementCode = "";  // string | Only of the given statement code (optional) 
      var type = "";  // string | Only of the given type (optional) 
      var startDate = DateTime.Now;  // DateTime? | Only on or after the given date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Only on or before the given date (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseCompanyFundamentals result = companyApi.GetCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyFundamentals: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **filedAfter** | DateTime?| Filed on or after this date | [optional]  &nbsp;
 **filedBefore** | DateTime?| Filed on or before this date | [optional]  &nbsp;
 **reportedOnly** | bool?| Only as-reported fundamentals | [optional]  &nbsp;
 **fiscalYear** | int?| Only for the given fiscal year | [optional]  &nbsp;
 **statementCode** | string| Only of the given statement code | [optional]  &nbsp;
 **type** | string| Only of the given type | [optional]  &nbsp;
 **startDate** | DateTime?| Only on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Only on or before the given date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyFundamentals**](ApiResponseCompanyFundamentals.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyHistoricalData.md)

[//]: # (OPERATION:GetCompanyHistoricalData_v2)

[//]: # (ENDPOINT:/companies/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanyhistoricaldata)

<a name="getcompanyhistoricaldata"></a>
## **GetCompanyHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyHistoricalData GetCompanyHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for Company

Returns historical values for the given `tag` and the Company with the given `identifier`

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
  public class GetCompanyHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var companyApi = new CompanyApi();
      var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
      var tag = "marketcap";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)
      var frequency = "daily";  // string | Return historical data in the given frequency (optional)  (default to daily)
      var type = "";  // string | Return historical data for given fiscal period type (optional) 
      var startDate = DateTime.Parse("2018-01-01");  // DateTime? | Return historical data on or after this date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Return historical data on or before this date (optional) 
      var sortOrder = "";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseCompanyHistoricalData result = companyApi.GetCompanyHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyHistoricalData: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
 **frequency** | string| Return historical data in the given frequency | [optional] [default to daily] &nbsp;
 **type** | string| Return historical data for given fiscal period type | [optional]  &nbsp;
 **startDate** | DateTime?| Return historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Return historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyHistoricalData**](ApiResponseCompanyHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyIpos)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseInitialPublicOfferings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseInitialPublicOfferings.md)

[//]: # (OPERATION:GetCompanyIpos_v2)

[//]: # (ENDPOINT:/companies/ipos)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanyipos)

<a name="getcompanyipos"></a>
## **GetCompanyIpos**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyIpos_v2)

[//]: # (START_OVERVIEW)

> ApiResponseInitialPublicOfferings GetCompanyIpos (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null)

#### IPOs

Returns initial public offerings (IPOs). An IPO is a public offering of private company stock. The act of \"going public\" is initiated by an IPO, at which point the company's stock trades on a major stock exchange (such as NYSE or NASDAQ). Intrinio covers all upcoming and recent IPOs for US exchanges.

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
  public class GetCompanyIposExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var companyApi = new CompanyApi();
      var ticker = "";  // string | Return IPOs with the given ticker (typically the IPO for the company) (optional) 
      var status = "";  // string | Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occured and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional) 
      var startDate = DateTime.Now;  // DateTime? | Return IPOs on or after the given date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Return IPOs on or before the given date (optional) 
      var offerAmountGreaterThan = "";  // int? | Return IPOs with an offer dollar amount greater than the given amount (optional) 
      var offerAmountLessThan = "";  // int? | Return IPOs with an offer dollar amount less than the given amount (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseInitialPublicOfferings result = companyApi.GetCompanyIpos(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyIpos: " + e.Message );
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
 **ticker** | string| Return IPOs with the given ticker (typically the IPO for the company) | [optional]  &nbsp;
 **status** | string| Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occured and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand | [optional]  &nbsp;
 **startDate** | DateTime?| Return IPOs on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Return IPOs on or before the given date | [optional]  &nbsp;
 **offerAmountGreaterThan** | int?| Return IPOs with an offer dollar amount greater than the given amount | [optional]  &nbsp;
 **offerAmountLessThan** | int?| Return IPOs with an offer dollar amount less than the given amount | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseInitialPublicOfferings**](ApiResponseInitialPublicOfferings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyNews)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyNews)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyNews.md)

[//]: # (OPERATION:GetCompanyNews_v2)

[//]: # (ENDPOINT:/companies/{identifier}/news)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanynews)

<a name="getcompanynews"></a>
## **GetCompanyNews**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyNews_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyNews GetCompanyNews (string identifier, int? pageSize = null, string nextPage = null)

#### All News by Company

Returns news for the Company with the given `identifier`

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanyNews: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyNews**](ApiResponseCompanyNews.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanySecurities)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanySecurities)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanySecurities.md)

[//]: # (OPERATION:GetCompanySecurities_v2)

[//]: # (ENDPOINT:/companies/{identifier}/securities)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanysecurities)

<a name="getcompanysecurities"></a>
## **GetCompanySecurities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanySecurities_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanySecurities GetCompanySecurities (string identifier, string nextPage = null)

#### All Securities by Company

Returns Securities for the Company with the given `identifier`

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.GetCompanySecurities: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanySecurities**](ApiResponseCompanySecurities.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:LookupCompanyFundamental)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Fundamental)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Fundamental.md)

[//]: # (OPERATION:LookupCompanyFundamental_v2)

[//]: # (ENDPOINT:/companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period})

[//]: # (DOCUMENT_LINK:CompanyApi.md#lookupcompanyfundamental)

<a name="lookupcompanyfundamental"></a>
## **LookupCompanyFundamental**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/LookupCompanyFundamental_v2)

[//]: # (START_OVERVIEW)

> Fundamental LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)

#### Lookup Fundamental by Company

Returns the Fundamental for the Company with the given `identifier` and with the given parameters

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.LookupCompanyFundamental: " + e.Message );
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **statementCode** | string| The statement code |  &nbsp;
 **fiscalPeriod** | string| The fiscal period |  &nbsp;
 **fiscalYear** | int?| The fiscal year |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:SearchCompanies)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompaniesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompaniesSearch.md)

[//]: # (OPERATION:SearchCompanies_v2)

[//]: # (ENDPOINT:/companies/search)

[//]: # (DOCUMENT_LINK:CompanyApi.md#searchcompanies)

<a name="searchcompanies"></a>
## **SearchCompanies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchCompanies_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompaniesSearch SearchCompanies (string query, int? pageSize = null)

#### Search Companies

Searches for Companies matching the text `query`

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
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling CompanyApi.SearchCompanies: " + e.Message );
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
 **query** | string| Search parameters |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompaniesSearch**](ApiResponseCompaniesSearch.md)

[//]: # (END_OPERATION)


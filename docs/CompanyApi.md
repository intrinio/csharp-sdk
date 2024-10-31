# Intrinio.SDK.Api.CompanyApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllCompanies**](CompanyApi.md#getallcompanies) | **GET** /companies | All Companies
[**GetAllCompaniesDailyMetrics**](CompanyApi.md#getallcompaniesdailymetrics) | **GET** /companies/daily_metrics | All Companies daily metrics
[**GetAllCompanyNews**](CompanyApi.md#getallcompanynews) | **GET** /companies/news | All News
[**GetCompany**](CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Lookup Company
[**GetCompanyAnswers**](CompanyApi.md#getcompanyanswers) | **GET** /companies/{identifier}/answers | Company Answers
[**GetCompanyDailyMetrics**](CompanyApi.md#getcompanydailymetrics) | **GET** /companies/{identifier}/daily_metrics | Company metrics by Company
[**GetCompanyDataPointNumber**](CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{tag}/number | Data Point (Number) for Company
[**GetCompanyDataPointText**](CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{tag}/text | Data Point (Text) for Company
[**GetCompanyFilings**](CompanyApi.md#getcompanyfilings) | **GET** /companies/{identifier}/filings | All Filings by Company
[**GetCompanyFundamentals**](CompanyApi.md#getcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | All Fundamentals by Company
[**GetCompanyHistoricalData**](CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{tag} | Historical Data for Company
[**GetCompanyIpos**](CompanyApi.md#getcompanyipos) | **GET** /companies/ipos | IPOs
[**GetCompanyNews**](CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | All News by Company
[**GetCompanyNewsBody**](CompanyApi.md#getcompanynewsbody) | **GET** /companies/news/body | News Article Body
[**GetCompanyPublicFloat**](CompanyApi.md#getcompanypublicfloat) | **GET** /companies/{identifier}/public_float | Get Company&#39;s public float
[**GetCompanySecurities**](CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | All Securities by Company
[**InsiderTransactionFilingsByCompany**](CompanyApi.md#insidertransactionfilingsbycompany) | **GET** /companies/{identifier}/insider_transaction_filings | Insider Transaction Filings by Company
[**LatestInsiderTransactionFilingByCompany**](CompanyApi.md#latestinsidertransactionfilingbycompany) | **GET** /companies/{identifier}/insider_transaction_filings/latest | Latest Insider Transaction Filing by Company
[**LookupCompanyFundamental**](CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental by Company
[**RecognizeCompany**](CompanyApi.md#recognizecompany) | **GET** /companies/recognize | Recognize Company
[**SearchCompanies**](CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies
[**SharesOutstandingByCompany**](CompanyApi.md#sharesoutstandingbycompany) | **GET** /companies/{identifier}/shares_outstanding | Shares Outstanding by Company



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

> ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)

#### All Companies

Returns all Companies. When parameters are specified, returns matching companies.

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
  public class GetAllCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      DateTime? latestFilingDate = null;
      string sic = null;
      string template = null;
      string sector = null;
      string industryCategory = null;
      string industryGroup = null;
      bool? hasFundamentals = true;
      bool? hasStockPrices = true;
      bool? theaEnabled = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseCompanies result = companyApi.GetAllCompanies(latestFilingDate, sic, template, sector, industryCategory, industryGroup, hasFundamentals, hasStockPrices, theaEnabled, pageSize, nextPage);
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
 **latestFilingDate** | DateTime?| Return companies whose latest 10-Q or 10-K was filed on or after this date | [optional]  &nbsp;
 **sic** | string| Return companies with the given Standard Industrial Classification code | [optional]  &nbsp;
 **template** | string| Return companies with the given financial statement template | [optional]  &nbsp;
 **sector** | string| Return companies in the given industry sector | [optional]  &nbsp;
 **industryCategory** | string| Return companies in the given industry category | [optional]  &nbsp;
 **industryGroup** | string| Return companies in the given industry group | [optional]  &nbsp;
 **hasFundamentals** | bool?| Return only companies that have fundamentals when true | [optional]  &nbsp;
 **hasStockPrices** | bool?| Return only companies that have stock prices when true | [optional]  &nbsp;
 **theaEnabled** | bool?| Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanies**](ApiResponseCompanies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetAllCompaniesDailyMetrics)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyDailyMetrics)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyDailyMetrics.md)

[//]: # (OPERATION:GetAllCompaniesDailyMetrics_v2)

[//]: # (ENDPOINT:/companies/daily_metrics)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getallcompaniesdailymetrics)

<a name="getallcompaniesdailymetrics"></a>
## **GetAllCompaniesDailyMetrics**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllCompaniesDailyMetrics_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyDailyMetrics GetAllCompaniesDailyMetrics (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)

#### All Companies daily metrics

Returns the company metrics for a date.

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
  public class GetAllCompaniesDailyMetricsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      DateTime? onDate = 2013-10-20;
      int? pageSize = 100;
      string nextPage = null;
      string nextPage2 = "";
      
      ApiResponseCompanyDailyMetrics result = companyApi.GetAllCompaniesDailyMetrics(onDate, pageSize, nextPage, nextPage2);
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
 **onDate** | DateTime?| Date of the metric | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **nextPage2** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyDailyMetrics**](ApiResponseCompanyDailyMetrics.md)

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

> ApiResponseNews GetAllCompanyNews (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)

#### All News

Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.

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
  public class GetAllCompanyNewsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string specificSource = null;
      int? pageSize = 100;
      string sentiment = null;
      string topic = null;
      string company = "AAPL";
      string security = "AAPL";
      DateTime? startDate = null;
      DateTime? endDate = null;
      string language = null;
      int? wordCountGreaterThan = null;
      int? wordCountLessThan = null;
      bool? isSpam = null;
      decimal? businessRelevanceGreaterThan = null;
      decimal? businessRelevanceLessThan = null;
      string nextPage = null;
      
      ApiResponseNews result = companyApi.GetAllCompanyNews(specificSource, pageSize, sentiment, topic, company, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
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
 **specificSource** | string| Only news from this source. Defaults to highest available if not present. | [optional]  &nbsp;
 **pageSize** | int?| The maximum number of results to return. | [optional] [default to 100] &nbsp;
 **sentiment** | string| Filter by sentiment.  Unsupported for yahoo source. | [optional]  &nbsp;
 **topic** | string| Filter by topic.  Unsupported for yahoo source. | [optional]  &nbsp;
 **company** | string| Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) | [optional]  &nbsp;
 **security** | string| Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. | [optional]  &nbsp;
 **startDate** | DateTime?| Limit news stories to those on or after this date. Defaults to yesterday if unspecified. | [optional]  &nbsp;
 **endDate** | DateTime?| Limit news stories to those on or before this date. | [optional]  &nbsp;
 **language** | string| Filter by language.  Unsupported for yahoo source. | [optional]  &nbsp;
 **wordCountGreaterThan** | int?| News stories will have a word count greater than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **wordCountLessThan** | int?| News stories will have a word count less than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **isSpam** | bool?| Filter whether it is marked as spam or not.  Unsupported for yahoo source. | [optional]  &nbsp;
 **businessRelevanceGreaterThan** | decimal?| News stories will have a business relevance score more than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **businessRelevanceLessThan** | decimal?| News stories will have a business relevance score less than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
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

Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.

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
  public class GetCompanyExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      
      Company result = companyApi.GetCompany(identifier);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Company**](Company.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyAnswers)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyAnswers)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyAnswers.md)

[//]: # (OPERATION:GetCompanyAnswers_v2)

[//]: # (ENDPOINT:/companies/{identifier}/answers)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanyanswers)

<a name="getcompanyanswers"></a>
## **GetCompanyAnswers**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyAnswers_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyAnswers GetCompanyAnswers (string identifier, string query)

#### Company Answers

Returns answers for a question about the Company with the given `identifier`

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
  public class GetCompanyAnswersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string query = "What do they believe in?";
      
      ApiResponseCompanyAnswers result = companyApi.GetCompanyAnswers(identifier, query);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **query** | string| The query to ask the Thea API |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyAnswers**](ApiResponseCompanyAnswers.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyDailyMetrics)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyDailyMetrics)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyDailyMetrics.md)

[//]: # (OPERATION:GetCompanyDailyMetrics_v2)

[//]: # (ENDPOINT:/companies/{identifier}/daily_metrics)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanydailymetrics)

<a name="getcompanydailymetrics"></a>
## **GetCompanyDailyMetrics**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyDailyMetrics_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyDailyMetrics GetCompanyDailyMetrics (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)

#### Company metrics by Company

Returns the latest company metrics.

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
  public class GetCompanyDailyMetricsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      DateTime? onDate = 2013-10-20;
      int? pageSize = 100;
      string nextPage = null;
      string nextPage2 = "";
      
      ApiResponseCompanyDailyMetrics result = companyApi.GetCompanyDailyMetrics(identifier, onDate, pageSize, nextPage, nextPage2);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **onDate** | DateTime?| Date of the metric | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **nextPage2** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyDailyMetrics**](ApiResponseCompanyDailyMetrics.md)

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

Returns latest value for calculations, metrics, and financial data points for a company.

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
  public class GetCompanyDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string tag = "marketcap";
      
      decimal? result = companyApi.GetCompanyDataPointNumber(identifier, tag);
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

Returns latest value for metadata items for a company.

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
  public class GetCompanyDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string tag = "ceo";
      
      string result = companyApi.GetCompanyDataPointText(identifier, tag);
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

> ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)

#### All Filings by Company

Returns a complete list of SEC filings for the Company with the given `identifier`

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
  public class GetCompanyFilingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string reportType = null;
      DateTime? startDate = DateTime.Parse("2015-01-01");
      DateTime? endDate = null;
      bool? theaEnabled = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseCompanyFilings result = companyApi.GetCompanyFilings(identifier, reportType, startDate, endDate, theaEnabled, pageSize, nextPage);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **reportType** | string| Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. | [optional]  &nbsp;
 **startDate** | DateTime?| Filed on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Filed before or after the given date | [optional]  &nbsp;
 **theaEnabled** | bool?| Return filings that have been read by our Thea NLP and are ready for our answers endpoint | [optional]  &nbsp;
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

> ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null)

#### All Fundamentals by Company

Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.

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
  public class GetCompanyFundamentalsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      DateTime? filedAfter = null;
      DateTime? filedBefore = null;
      bool? reportedOnly = false;
      int? fiscalYear = null;
      string statementCode = null;
      string type = null;
      DateTime? startDate = null;
      DateTime? endDate = null;
      DateTime? updatedAfter = DateTime.Parse("2022-12-01");
      DateTime? updatedBefore = DateTime.Parse("2022-12-01");
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseCompanyFundamentals result = companyApi.GetCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, updatedAfter, updatedBefore, pageSize, nextPage);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **filedAfter** | DateTime?| Filed on or after this date | [optional]  &nbsp;
 **filedBefore** | DateTime?| Filed on or before this date | [optional]  &nbsp;
 **reportedOnly** | bool?| Only as-reported fundamentals | [optional]  &nbsp;
 **fiscalYear** | int?| Only for the given fiscal year | [optional]  &nbsp;
 **statementCode** | string| Only of the given statement code | [optional]  &nbsp;
 **type** | string| Only of the given type | [optional]  &nbsp;
 **startDate** | DateTime?| Only on or after the given date | [optional]  &nbsp;
 **endDate** | DateTime?| Only on or before the given date | [optional]  &nbsp;
 **updatedAfter** | DateTime?| Only include fundamentals where it was updated after this date. | [optional]  &nbsp;
 **updatedBefore** | DateTime?| Only include fundamentals where it was updated before this date. | [optional]  &nbsp;
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
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class GetCompanyHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string tag = "marketcap";
      string frequency = "daily";
      string type = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = null;
      string sortOrder = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseCompanyHistoricalData result = companyApi.GetCompanyHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
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

Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.

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
  public class GetCompanyIposExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string ticker = "UBER";
      string status = null;
      DateTime? startDate = null;
      DateTime? endDate = null;
      int? offerAmountGreaterThan = null;
      int? offerAmountLessThan = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseInitialPublicOfferings result = companyApi.GetCompanyIpos(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
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
 **ticker** | string| Return IPOs with the given ticker (typically the IPO for the company) | [optional]  &nbsp;
 **status** | string| Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand | [optional]  &nbsp;
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

> ApiResponseCompanyNews GetCompanyNews (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)

#### All News by Company

Returns the latest and historical news article links, headlines and summaries for a specified US traded company.

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
  public class GetCompanyNewsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string specificSource = null;
      int? pageSize = 100;
      string sentiment = null;
      string topic = null;
      string security = "AAPL";
      DateTime? startDate = null;
      DateTime? endDate = null;
      string language = null;
      int? wordCountGreaterThan = null;
      int? wordCountLessThan = null;
      bool? isSpam = null;
      decimal? businessRelevanceGreaterThan = null;
      decimal? businessRelevanceLessThan = null;
      string nextPage = null;
      
      ApiResponseCompanyNews result = companyApi.GetCompanyNews(identifier, specificSource, pageSize, sentiment, topic, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **specificSource** | string| Only news from this source. Defaults to highest available if not present. | [optional]  &nbsp;
 **pageSize** | int?| The maximum number of results to return | [optional] [default to 100] &nbsp;
 **sentiment** | string| Filter by sentiment.  Unsupported for yahoo source. | [optional]  &nbsp;
 **topic** | string| Filter by topic.  Unsupported for yahoo source. | [optional]  &nbsp;
 **security** | string| Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. | [optional]  &nbsp;
 **startDate** | DateTime?| Limit news stories to those on or after this date. Defaults to yesterday if unspecified. | [optional]  &nbsp;
 **endDate** | DateTime?| Limit news stories to those on or before this date | [optional]  &nbsp;
 **language** | string| Filter by language.  Unsupported for yahoo source. | [optional]  &nbsp;
 **wordCountGreaterThan** | int?| News stories will have a word count greater than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **wordCountLessThan** | int?| News stories will have a word count less than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **isSpam** | bool?| Filter whether it is marked as spam or not.  Unsupported for yahoo source. | [optional]  &nbsp;
 **businessRelevanceGreaterThan** | decimal?| News stories will have a business relevance score more than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **businessRelevanceLessThan** | decimal?| News stories will have a business relevance score less than this value.  Unsupported for yahoo source. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyNews**](ApiResponseCompanyNews.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyNewsBody)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyNewsBody)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyNewsBody.md)

[//]: # (OPERATION:GetCompanyNewsBody_v2)

[//]: # (ENDPOINT:/companies/news/body)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanynewsbody)

<a name="getcompanynewsbody"></a>
## **GetCompanyNewsBody**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyNewsBody_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyNewsBody GetCompanyNewsBody (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null)

#### News Article Body

Returns the body of a news article.  This endpoint requires additional authorization beyond basic news access. Please see a representative for details.

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
  public class GetCompanyNewsBodyExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string newsStoryId = "new_aBcDef";
      DateTime? publicationDate = null;
      string specificSource = null;
      string nextPage = null;
      
      ApiResponseCompanyNewsBody result = companyApi.GetCompanyNewsBody(newsStoryId, publicationDate, specificSource, nextPage);
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
 **newsStoryId** | string| The identifier of the news story. |  &nbsp;
 **publicationDate** | DateTime?| The DateTime of the story. |  &nbsp;
 **specificSource** | string| Only news from this source. Defaults to highest available if not present. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyNewsBody**](ApiResponseCompanyNewsBody.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:GetCompanyPublicFloat)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyPublicFloatResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyPublicFloatResult.md)

[//]: # (OPERATION:GetCompanyPublicFloat_v2)

[//]: # (ENDPOINT:/companies/{identifier}/public_float)

[//]: # (DOCUMENT_LINK:CompanyApi.md#getcompanypublicfloat)

<a name="getcompanypublicfloat"></a>
## **GetCompanyPublicFloat**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetCompanyPublicFloat_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyPublicFloatResult GetCompanyPublicFloat (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null)

#### Get Company's public float

Returns a list of public float data tied to a given company identifier.

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
  public class GetCompanyPublicFloatExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      DateTime? floatDateGreaterThan = null;
      DateTime? floatDateLessThan = null;
      string nextPage = null;
      string nextPage2 = "";
      
      ApiResponseCompanyPublicFloatResult result = companyApi.GetCompanyPublicFloat(identifier, floatDateGreaterThan, floatDateLessThan, nextPage, nextPage2);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **floatDateGreaterThan** | DateTime?| The lower-bound date for the data being requested. | [optional]  &nbsp;
 **floatDateLessThan** | DateTime?| The upper-bound date for the data being requested. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **nextPage2** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyPublicFloatResult**](ApiResponseCompanyPublicFloatResult.md)

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

Returns a list of underlying securities with associated reference data tied to a given company identifier.

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
  public class GetCompanySecuritiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string nextPage = null;
      
      ApiResponseCompanySecurities result = companyApi.GetCompanySecurities(identifier, nextPage);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanySecurities**](ApiResponseCompanySecurities.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:InsiderTransactionFilingsByCompany)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseInsiderTransactionFilings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseInsiderTransactionFilings.md)

[//]: # (OPERATION:InsiderTransactionFilingsByCompany_v2)

[//]: # (ENDPOINT:/companies/{identifier}/insider_transaction_filings)

[//]: # (DOCUMENT_LINK:CompanyApi.md#insidertransactionfilingsbycompany)

<a name="insidertransactionfilingsbycompany"></a>
## **InsiderTransactionFilingsByCompany**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/InsiderTransactionFilingsByCompany_v2)

[//]: # (START_OVERVIEW)

> ApiResponseInsiderTransactionFilings InsiderTransactionFilingsByCompany (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null)

#### Insider Transaction Filings by Company

Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.

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
  public class InsiderTransactionFilingsByCompanyExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = DateTime.Parse("2019-01-01");
      string ownershipType = "D";
      string nextPage = null;
      int? pageSize = 100;
      string sortBy = "updated_on";
      string nextPage2 = "";
      
      ApiResponseInsiderTransactionFilings result = companyApi.InsiderTransactionFilingsByCompany(identifier, startDate, endDate, ownershipType, nextPage, pageSize, sortBy, nextPage2);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **startDate** | DateTime?| Return Company&#39;s insider transaction filings on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Return Company&#39;s insider transaction filings on or before this date | [optional]  &nbsp;
 **ownershipType** | string| The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 1000] &nbsp;
 **sortBy** | string| The field to sort by.  Default is &#39;filing_date&#39;. | [optional]  &nbsp;
 **nextPage2** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseInsiderTransactionFilings**](ApiResponseInsiderTransactionFilings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:LatestInsiderTransactionFilingByCompany)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.InsiderTransactionFiling)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:InsiderTransactionFiling.md)

[//]: # (OPERATION:LatestInsiderTransactionFilingByCompany_v2)

[//]: # (ENDPOINT:/companies/{identifier}/insider_transaction_filings/latest)

[//]: # (DOCUMENT_LINK:CompanyApi.md#latestinsidertransactionfilingbycompany)

<a name="latestinsidertransactionfilingbycompany"></a>
## **LatestInsiderTransactionFilingByCompany**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/LatestInsiderTransactionFilingByCompany_v2)

[//]: # (START_OVERVIEW)

> InsiderTransactionFiling LatestInsiderTransactionFilingByCompany (string identifier, string nextPage = null)

#### Latest Insider Transaction Filing by Company

Returns the latest insider transaction filing for a company.

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
  public class LatestInsiderTransactionFilingByCompanyExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string nextPage = null;
      
      InsiderTransactionFiling result = companyApi.LatestInsiderTransactionFilingByCompany(identifier, nextPage);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**InsiderTransactionFiling**](InsiderTransactionFiling.md)

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
using System.Collections;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Newtonsoft.Json;

namespace Example
{
  public class LookupCompanyFundamentalExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      string statementCode = "income_statement";
      string fiscalPeriod = "FY";
      int? fiscalYear = 2017;
      
      Fundamental result = companyApi.LookupCompanyFundamental(identifier, statementCode, fiscalPeriod, fiscalYear);
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

[//]: # (METHOD:RecognizeCompany)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanyRecognize)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanyRecognize.md)

[//]: # (OPERATION:RecognizeCompany_v2)

[//]: # (ENDPOINT:/companies/recognize)

[//]: # (DOCUMENT_LINK:CompanyApi.md#recognizecompany)

<a name="recognizecompany"></a>
## **RecognizeCompany**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/RecognizeCompany_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanyRecognize RecognizeCompany (string text)

#### Recognize Company

Returns a list of companies recognized by the Thea API in the given `text` query string parameter.

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
  public class RecognizeCompanyExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string text = "Apple";
      
      ApiResponseCompanyRecognize result = companyApi.RecognizeCompany(text);
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
 **text** | string| The text sent to the Thea API to analyze |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanyRecognize**](ApiResponseCompanyRecognize.md)

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

> ApiResponseCompaniesSearch SearchCompanies (string query, bool? active = null, string mode = null, int? pageSize = null)

#### Search Companies

Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.

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
  public class SearchCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string query = "Apple";
      bool? active = true;
      string mode = null;
      int? pageSize = 100;
      
      ApiResponseCompaniesSearch result = companyApi.SearchCompanies(query, active, mode, pageSize);
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
 **query** | string| Search parameters |  &nbsp;
 **active** | bool?| When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. | [optional]  &nbsp;
 **mode** | string| When set, changes search mode to the specified mode. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompaniesSearch**](ApiResponseCompaniesSearch.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.CompanyApi)

[//]: # (METHOD:SharesOutstandingByCompany)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseCompanySharesOutstanding)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseCompanySharesOutstanding.md)

[//]: # (OPERATION:SharesOutstandingByCompany_v2)

[//]: # (ENDPOINT:/companies/{identifier}/shares_outstanding)

[//]: # (DOCUMENT_LINK:CompanyApi.md#sharesoutstandingbycompany)

<a name="sharesoutstandingbycompany"></a>
## **SharesOutstandingByCompany**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SharesOutstandingByCompany_v2)

[//]: # (START_OVERVIEW)

> ApiResponseCompanySharesOutstanding SharesOutstandingByCompany (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null)

#### Shares Outstanding by Company

Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.

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
  public class SharesOutstandingByCompanyExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      
      string identifier = "AAPL";
      DateTime? endDateGreaterThan = null;
      DateTime? endDateLessThan = null;
      
      ApiResponseCompanySharesOutstanding result = companyApi.SharesOutstandingByCompany(identifier, endDateGreaterThan, endDateLessThan);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **endDateGreaterThan** | DateTime?| Returns shares outstanding after this date. | [optional]  &nbsp;
 **endDateLessThan** | DateTime?| Returns shares outstanding before this date. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseCompanySharesOutstanding**](ApiResponseCompanySharesOutstanding.md)

[//]: # (END_OPERATION)


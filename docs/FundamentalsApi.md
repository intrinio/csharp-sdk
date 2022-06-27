# Intrinio.SDK.Api.FundamentalsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilterFundamental**](FundamentalsApi.md#filterfundamental) | **GET** /fundamentals | Filter Fundamental
[**GetFundamentalById**](FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Fundamental by ID
[**GetFundamentalReportedFinancials**](FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Reported Financials
[**GetFundamentalStandardizedFinancials**](FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Standardized Financials
[**GetFundamentalStandardizedFinancialsDimensions**](FundamentalsApi.md#getfundamentalstandardizedfinancialsdimensions) | **GET** /fundamentals/{id}/standardized_financials/dimensions/{tag} | Standardized Financials Dimensions
[**LookupFundamental**](FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:FilterFundamental)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Fundamental)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Fundamental.md)

[//]: # (OPERATION:FilterFundamental_v2)

[//]: # (ENDPOINT:/fundamentals)

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#filterfundamental)

<a name="filterfundamental"></a>
## **FilterFundamental**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/FilterFundamental_v2)

[//]: # (START_OVERVIEW)

> Fundamental FilterFundamental (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)

#### Filter Fundamental

Returns fundamentals that meet the set of filters specified in parameters.

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
  public class FilterFundamentalExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var fundamentalsApi = new FundamentalsApi();
      
      DateTime? filedAfter = DateTime.Parse("2022-01-01");
      DateTime? filedBefore = DateTime.Parse("2022-12-01");
      bool? reportedOnly = false;
      int? fiscalYear = 2017;
      string statementCode = null;
      string type = false;
      string fiscalPeriod = "FY";
      DateTime? startDate = DateTime.Parse("2022-01-01");
      DateTime? endDate = DateTime.Parse("2022-12-01");
      string nextPage = null;
      
      Fundamental result = fundamentalsApi.FilterFundamental(filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, fiscalPeriod, startDate, endDate, nextPage);
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
 **filedAfter** | DateTime?| Only include fundamentals that were filed on or after this date. | [optional]  &nbsp;
 **filedBefore** | DateTime?| Only include fundamentals that were filed on or before this date. | [optional]  &nbsp;
 **reportedOnly** | bool?| Only as-reported fundamentals | [optional]  &nbsp;
 **fiscalYear** | int?| Only for the given fiscal year | [optional]  &nbsp;
 **statementCode** | string| Only of the given statement code | [optional]  &nbsp;
 **type** | string| Only of the given type | [optional]  &nbsp;
 **fiscalPeriod** | string| The fiscal period | [optional]  &nbsp;
 **startDate** | DateTime?| Only include fundamentals where covered period is on or after this date. | [optional]  &nbsp;
 **endDate** | DateTime?| Only include fundamentals where covered period is on or before this date. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Fundamental)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Fundamental.md)

[//]: # (OPERATION:GetFundamentalById_v2)

[//]: # (ENDPOINT:/fundamentals/{id})

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalbyid)

<a name="getfundamentalbyid"></a>
## **GetFundamentalById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalById_v2)

[//]: # (START_OVERVIEW)

> Fundamental GetFundamentalById (string id)

#### Fundamental by ID

Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.

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
  public class GetFundamentalByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var fundamentalsApi = new FundamentalsApi();
      
      string id = "fun_ge9LlE";
      
      Fundamental result = fundamentalsApi.GetFundamentalById(id);
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
 **id** | string| The Intrinio ID for the Fundamental |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalReportedFinancials)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseReportedFinancials)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseReportedFinancials.md)

[//]: # (OPERATION:GetFundamentalReportedFinancials_v2)

[//]: # (ENDPOINT:/fundamentals/{id}/reported_financials)

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalreportedfinancials)

<a name="getfundamentalreportedfinancials"></a>
## **GetFundamentalReportedFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalReportedFinancials_v2)

[//]: # (START_OVERVIEW)

> ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id)

#### Reported Financials

Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.

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
  public class GetFundamentalReportedFinancialsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var fundamentalsApi = new FundamentalsApi();
      
      string id = "AAPL-income_statement-2018-Q1";
      
      ApiResponseReportedFinancials result = fundamentalsApi.GetFundamentalReportedFinancials(id);
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
 **id** | string| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseReportedFinancials**](ApiResponseReportedFinancials.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalStandardizedFinancials)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStandardizedFinancials)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStandardizedFinancials.md)

[//]: # (OPERATION:GetFundamentalStandardizedFinancials_v2)

[//]: # (ENDPOINT:/fundamentals/{id}/standardized_financials)

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalstandardizedfinancials)

<a name="getfundamentalstandardizedfinancials"></a>
## **GetFundamentalStandardizedFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalStandardizedFinancials_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id)

#### Standardized Financials

Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.

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
  public class GetFundamentalStandardizedFinancialsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var fundamentalsApi = new FundamentalsApi();
      
      string id = "AAPL-income_statement-2018-Q1";
      
      ApiResponseStandardizedFinancials result = fundamentalsApi.GetFundamentalStandardizedFinancials(id);
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
 **id** | string| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStandardizedFinancials**](ApiResponseStandardizedFinancials.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalStandardizedFinancialsDimensions)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStandardizedFinancialsDimensions)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStandardizedFinancialsDimensions.md)

[//]: # (OPERATION:GetFundamentalStandardizedFinancialsDimensions_v2)

[//]: # (ENDPOINT:/fundamentals/{id}/standardized_financials/dimensions/{tag})

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalstandardizedfinancialsdimensions)

<a name="getfundamentalstandardizedfinancialsdimensions"></a>
## **GetFundamentalStandardizedFinancialsDimensions**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalStandardizedFinancialsDimensions_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStandardizedFinancialsDimensions GetFundamentalStandardizedFinancialsDimensions (string id, string tag)

#### Standardized Financials Dimensions

Returns as reported dimensionality of a data tag

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
  public class GetFundamentalStandardizedFinancialsDimensionsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var fundamentalsApi = new FundamentalsApi();
      
      string id = "AAPL-income_statement-2020-FY";
      string tag = "ceo";
      
      ApiResponseStandardizedFinancialsDimensions result = fundamentalsApi.GetFundamentalStandardizedFinancialsDimensions(id, tag);
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
 **id** | string| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStandardizedFinancialsDimensions**](ApiResponseStandardizedFinancialsDimensions.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:LookupFundamental)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Fundamental)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Fundamental.md)

[//]: # (OPERATION:LookupFundamental_v2)

[//]: # (ENDPOINT:/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period})

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#lookupfundamental)

<a name="lookupfundamental"></a>
## **LookupFundamental**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/LookupFundamental_v2)

[//]: # (START_OVERVIEW)

> Fundamental LookupFundamental (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)

#### Lookup Fundamental

Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.

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
  public class LookupFundamentalExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var fundamentalsApi = new FundamentalsApi();
      
      string identifier = "AAPL";
      string statementCode = "income_statement";
      int? fiscalYear = 2017;
      string fiscalPeriod = "FY";
      
      Fundamental result = fundamentalsApi.LookupFundamental(identifier, statementCode, fiscalYear, fiscalPeriod);
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
 **fiscalYear** | int?| The fiscal year |  &nbsp;
 **fiscalPeriod** | string| The fiscal period |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


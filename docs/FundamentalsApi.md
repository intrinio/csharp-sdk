# Intrinio.SDK.Api.FundamentalsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFundamentalById**](FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Fundamental by ID
[**GetFundamentalReportedFinancials**](FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Reported Financials
[**GetFundamentalStandardizedFinancials**](FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Standardized Financials
[**LookupFundamental**](FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental



[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/fundamentals/{id})

[//]: # (DOC_LINK:FundamentalsApi.md#getfundamentalbyid)

<a name="getfundamentalbyid"></a>
# **GetFundamentalById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetFundamentalById_v2)

> Fundamental GetFundamentalById (string id)

Fundamental by ID

Returns detailed fundamental data for the given `id`.

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
    public class GetFundamentalByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var id = "fun_ge9LlE";  // string | The Intrinio ID for the Fundamental

            try
            {
                Fundamental result = fundamentalsApi.GetFundamentalById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundamentalsApi.GetFundamentalById: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID for the Fundamental | 

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/fundamentals/{id}/reported_financials)

[//]: # (DOC_LINK:FundamentalsApi.md#getfundamentalreportedfinancials)

<a name="getfundamentalreportedfinancials"></a>
# **GetFundamentalReportedFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetFundamentalReportedFinancials_v2)

> ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id)

Reported Financials

Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company

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
    public class GetFundamentalReportedFinancialsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var id = "AAPL-income_statement-2018-Q1";  // string | The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental

            try
            {
                ApiResponseReportedFinancials result = fundamentalsApi.GetFundamentalReportedFinancials(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundamentalsApi.GetFundamentalReportedFinancials: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental | 

### Return type

[**ApiResponseReportedFinancials**](ApiResponseReportedFinancials.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/fundamentals/{id}/standardized_financials)

[//]: # (DOC_LINK:FundamentalsApi.md#getfundamentalstandardizedfinancials)

<a name="getfundamentalstandardizedfinancials"></a>
# **GetFundamentalStandardizedFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetFundamentalStandardizedFinancials_v2)

> ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id)

Standardized Financials

Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.

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
    public class GetFundamentalStandardizedFinancialsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var id = "AAPL-income_statement-2018-Q1";  // string | The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental

            try
            {
                ApiResponseStandardizedFinancials result = fundamentalsApi.GetFundamentalStandardizedFinancials(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundamentalsApi.GetFundamentalStandardizedFinancials: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental | 

### Return type

[**ApiResponseStandardizedFinancials**](ApiResponseStandardizedFinancials.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period})

[//]: # (DOC_LINK:FundamentalsApi.md#lookupfundamental)

<a name="lookupfundamental"></a>
# **LookupFundamental**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/LookupFundamental_v2)

> Fundamental LookupFundamental (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)

Lookup Fundamental

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
    public class LookupFundamentalExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var statementCode = "income_statement";  // string | The statement code
            var fiscalYear = 2017;  // int? | The fiscal year
            var fiscalPeriod = "FY";  // string | The fiscal period

            try
            {
                Fundamental result = fundamentalsApi.LookupFundamental(identifier, statementCode, fiscalYear, fiscalPeriod);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundamentalsApi.LookupFundamental: " + e.Message );
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
 **fiscalYear** | **int?**| The fiscal year | 
 **fiscalPeriod** | **string**| The fiscal period | 

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


# Intrinio.Api.FundamentalsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFundamentalById**](FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Get a Fundamental by ID
[**GetFundamentalReportedFinancials**](FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Get Reported Financials for a Fundamental
[**GetFundamentalStandardizedFinancials**](FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Get Standardized Financials for a Fundamental
[**LookupFundamental**](FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup a Fundamental


<a name="getfundamentalbyid"></a>
# **GetFundamentalById**
> Fundamental GetFundamentalById (string id)

Get a Fundamental by ID

Retrieves detailed fundamental data for the given `fundamental_id`.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetFundamentalByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var id = id_example;  // string | The Intrinio ID for the Fundamental

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID for the Fundamental | 

### Return type

[**Fundamental**](Fundamental.md)

<a name="getfundamentalreportedfinancials"></a>
# **GetFundamentalReportedFinancials**
> InlineResponse20011 GetFundamentalReportedFinancials (string id)

Get Reported Financials for a Fundamental

Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetFundamentalReportedFinancialsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var id = id_example;  // string | The Intrinio ID for the Fundamental

            try
            {
                InlineResponse20011 result = fundamentalsApi.GetFundamentalReportedFinancials(id);
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID for the Fundamental | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

<a name="getfundamentalstandardizedfinancials"></a>
# **GetFundamentalStandardizedFinancials**
> InlineResponse20012 GetFundamentalStandardizedFinancials (string id)

Get Standardized Financials for a Fundamental

Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetFundamentalStandardizedFinancialsExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var id = id_example;  // string | The Intrinio ID for the Fundamental

            try
            {
                InlineResponse20012 result = fundamentalsApi.GetFundamentalStandardizedFinancials(id);
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The Intrinio ID for the Fundamental | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

<a name="lookupfundamental"></a>
# **LookupFundamental**
> List<Fundamental> LookupFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)

Lookup a Fundamental

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
    public class LookupFundamentalExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var fundamentalsApi = new FundamentalsApi();
            var identifier = identifier_example;  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
            var statementCode = statementCode_example;  // string | The statement code
            var fiscalPeriod = fiscalPeriod_example;  // string | The fiscal period
            var fiscalYear = 56;  // int? | The fiscal year

            try
            {
                List&lt;Fundamental&gt; result = fundamentalsApi.LookupFundamental(identifier, statementCode, fiscalPeriod, fiscalYear);
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | 
 **statementCode** | **string**| The statement code | 
 **fiscalPeriod** | **string**| The fiscal period | 
 **fiscalYear** | **int?**| The fiscal year | 

### Return type

[**List<Fundamental>**](Fundamental.md)


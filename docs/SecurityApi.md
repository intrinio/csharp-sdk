# Intrinio.Api.SecurityApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSecurities**](SecurityApi.md#getallsecurities) | **GET** /securities | Get All Securiites
[**GetSecurityById**](SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Get a Security by ID
[**GetSecurityDataPointNumber**](SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{item}/number | Get Security Data Point (Number)
[**GetSecurityDataPointText**](SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{item}/text | Get Security Data Point (Text)
[**GetSecurityHistoricalData**](SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{item} | Get Security Historical Data
[**GetSecurityStockPrices**](SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Get Stock Prices for Security
[**ScreenSecurities**](SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
[**SearchSecurities**](SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities


<a name="getallsecurities"></a>
# **GetAllSecurities**
> List<SecuritySummary> GetAllSecurities (string nextPage = null)

Get All Securiites

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetAllSecuritiesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;SecuritySummary&gt; result = securityApi.GetAllSecurities(nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetAllSecurities: " + e.Message );
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

[**List<SecuritySummary>**](SecuritySummary.md)

<a name="getsecuritybyid"></a>
# **GetSecurityById**
> Security GetSecurityById (string identifier)

Get a Security by ID

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSecurityByIdExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = identifier_example;  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)

            try
            {
                Security result = securityApi.GetSecurityById(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 

### Return type

[**Security**](Security.md)

<a name="getsecuritydatapointnumber"></a>
# **GetSecurityDataPointNumber**
> DataPointNumber GetSecurityDataPointNumber (string identifier, string item)

Get Security Data Point (Number)

Returns a numeric value for the given `item` for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSecurityDataPointNumberExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = identifier_example;  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointNumber result = securityApi.GetSecurityDataPointNumber(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityDataPointNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointNumber**](DataPointNumber.md)

<a name="getsecuritydatapointtext"></a>
# **GetSecurityDataPointText**
> DataPointText GetSecurityDataPointText (string identifier, string item)

Get Security Data Point (Text)

Returns a text value for the given `item` for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSecurityDataPointTextExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = identifier_example;  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item

            try
            {
                DataPointText result = securityApi.GetSecurityDataPointText(identifier, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityDataPointText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 

### Return type

[**DataPointText**](DataPointText.md)

<a name="getsecurityhistoricaldata"></a>
# **GetSecurityHistoricalData**
> List<HistoricalData> GetSecurityHistoricalData (string identifier, string item, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)

Get Security Historical Data

Returns historical values for the given `item` and the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSecurityHistoricalDataExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = identifier_example;  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var item = item_example;  // string | An Intrinio data tag or other item
            var type = type_example;  // string | Filter by type, when applicable (optional) 
            var startDate = 2013-10-20;  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Get historical date on or before this date (optional) 
            var sortOrder = sortOrder_example;  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;HistoricalData&gt; result = securityApi.GetSecurityHistoricalData(identifier, item, type, startDate, endDate, sortOrder, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityHistoricalData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **item** | **string**| An Intrinio data tag or other item | 
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical date on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<HistoricalData>**](HistoricalData.md)

<a name="getsecuritystockprices"></a>
# **GetSecurityStockPrices**
> List<StockPriceSummary> GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)

Get Stock Prices for Security

Return stock prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class GetSecurityStockPricesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = identifier_example;  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = 2013-10-20;  // DateTime? | Return prices on or after the date (optional) 
            var endDate = 2013-10-20;  // DateTime? | Return prices on or beore the date (optional) 
            var frequency = frequency_example;  // string | Return stock prices in the given frequency (optional)  (default to daily)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;StockPriceSummary&gt; result = securityApi.GetSecurityStockPrices(identifier, startDate, endDate, frequency, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityStockPrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **DateTime?**| Return prices on or after the date | [optional] 
 **endDate** | **DateTime?**| Return prices on or beore the date | [optional] 
 **frequency** | **string**| Return stock prices in the given frequency | [optional] [default to daily]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<StockPriceSummary>**](StockPriceSummary.md)

<a name="screensecurities"></a>
# **ScreenSecurities**
> List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null, string nextPage = null)

Screen Securities

Screen securities using complex logic

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class ScreenSecuritiesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var logic = new SecurityScreenGroup(); // SecurityScreenGroup | The logic to screen with, consisting of operators, clauses, and nested groups (optional) 
            var orderColumn = orderColumn_example;  // string | Results returned sorted by this column (optional) 
            var orderDirection = orderDirection_example;  // string | Sort order to use with the order_column (optional)  (default to asc)
            var primaryOnly = true;  // bool? | Return only primary securities (optional)  (default to false)
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;SecurityScreenResult&gt; result = securityApi.ScreenSecurities(logic, orderColumn, orderDirection, primaryOnly, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.ScreenSecurities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logic** | [**SecurityScreenGroup**](SecurityScreenGroup.md)| The logic to screen with, consisting of operators, clauses, and nested groups | [optional] 
 **orderColumn** | **string**| Results returned sorted by this column | [optional] 
 **orderDirection** | **string**| Sort order to use with the order_column | [optional] [default to asc]
 **primaryOnly** | **bool?**| Return only primary securities | [optional] [default to false]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<SecurityScreenResult>**](SecurityScreenResult.md)

<a name="searchsecurities"></a>
# **SearchSecurities**
> List<SecuritySummary> SearchSecurities (string query, string nextPage = null)

Search Securities

Searches for Securities matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class SearchSecuritiesExample
    {
        public void main()
        {
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var query = query_example;  // string | 
            var nextPage = nextPage_example;  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                List&lt;SecuritySummary&gt; result = securityApi.SearchSecurities(query, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SearchSecurities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**|  | 
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**List<SecuritySummary>**](SecuritySummary.md)


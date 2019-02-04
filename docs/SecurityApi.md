# Intrinio.SDK.Api.SecurityApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSecurities**](SecurityApi.md#getallsecurities) | **GET** /securities | All Securities
[**GetSecurityById**](SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Lookup Security
[**GetSecurityDataPointNumber**](SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{tag}/number | Data Point (Number) for Security
[**GetSecurityDataPointText**](SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{tag}/text | Data Point (Text) for Security
[**GetSecurityHistoricalData**](SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{tag} | Historical Data for Security
[**GetSecurityIntradayPrices**](SecurityApi.md#getsecurityintradayprices) | **GET** /securities/{identifier}/prices/intraday | Intraday Stock Prices for Security
[**GetSecurityLatestDividendRecord**](SecurityApi.md#getsecuritylatestdividendrecord) | **GET** /securities/{identifier}/dividends/latest | Lastest Dividend Record for Security
[**GetSecurityLatestEarningsRecord**](SecurityApi.md#getsecuritylatestearningsrecord) | **GET** /securities/{identifier}/earnings/latest | Lastest Earnings Record for Security
[**GetSecurityRealtimePrice**](SecurityApi.md#getsecurityrealtimeprice) | **GET** /securities/{identifier}/prices/realtime | Realtime Stock Price for Security
[**GetSecurityStockPriceAdjustments**](SecurityApi.md#getsecuritystockpriceadjustments) | **GET** /securities/{identifier}/prices/adjustments | Stock Price Adjustments by Security
[**GetSecurityStockPrices**](SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Stock Prices by Security
[**ScreenSecurities**](SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
[**SearchSecurities**](SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities


<a name="getallsecurities"></a>
# **GetAllSecurities**
> ApiResponseSecurities GetAllSecurities (decimal? pageSize = null, string nextPage = null)

All Securities

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetAllSecuritiesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurities result = securityApi.GetAllSecurities(pageSize, nextPage);
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
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurities**](ApiResponseSecurities.md)

<a name="getsecuritybyid"></a>
# **GetSecurityById**
> Security GetSecurityById (string identifier)

Lookup Security

Returns the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityByIdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)

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
> decimal? GetSecurityDataPointNumber (string identifier, string tag)

Data Point (Number) for Security

Returns a numeric value for the given `tag` for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityDataPointNumberExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var tag = "52_week_high";  // string | An Intrinio data tag ID or code-name

            try
            {
                decimal? result = securityApi.GetSecurityDataPointNumber(identifier, tag);
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
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**decimal?**

<a name="getsecuritydatapointtext"></a>
# **GetSecurityDataPointText**
> string GetSecurityDataPointText (string identifier, string tag)

Data Point (Text) for Security

Returns a text value for the given `tag` for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityDataPointTextExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var tag = "figi";  // string | An Intrinio data tag ID or code-name

            try
            {
                string result = securityApi.GetSecurityDataPointText(identifier, tag);
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
 **tag** | **string**| An Intrinio data tag ID or code-name | 

### Return type

**string**

<a name="getsecurityhistoricaldata"></a>
# **GetSecurityHistoricalData**
> ApiResponseSecurityHistoricalData GetSecurityHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, decimal? pageSize = null, string nextPage = null)

Historical Data for Security

Returns historical values for the given `tag` and the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityHistoricalDataExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var tag = "volume";  // string | An Intrinio data tag ID or code-name
            var frequency = "daily";  // string | Return historical data in the given frequency (optional)  (default to daily)
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Get historical date on or before this date (optional) 
            var sortOrder = "";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityHistoricalData result = securityApi.GetSecurityHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **tag** | **string**| An Intrinio data tag ID or code-name | 
 **frequency** | **string**| Return historical data in the given frequency | [optional] [default to daily]
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical date on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityHistoricalData**](ApiResponseSecurityHistoricalData.md)

<a name="getsecurityintradayprices"></a>
# **GetSecurityIntradayPrices**
> ApiResponseSecurityIntradayPrices GetSecurityIntradayPrices (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null)

Intraday Stock Prices for Security

Return intraday stock prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityIntradayPricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var source = "";  // string | Return intraday prices from the specified data source (optional) 
            var startDate = "2018-01-01";  // DateTime? | Return intraday prices starting at the specified date (optional) 
            var startTime = 4200;  // string | Return intraday prices starting at the specified time on the `start_date` (timezone is UTC) (optional) 
            var endDate = "2018-01-01";  // DateTime? | Return intraday prices stopping at the specified date (optional) 
            var endTime = 4200;  // string | Return intraday prices stopping at the specified time on the `end_date` (timezone is UTC) (optional) 

            try
            {
                ApiResponseSecurityIntradayPrices result = securityApi.GetSecurityIntradayPrices(identifier, source, startDate, startTime, endDate, endTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityIntradayPrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **source** | **string**| Return intraday prices from the specified data source | [optional] 
 **startDate** | **DateTime?**| Return intraday prices starting at the specified date | [optional] 
 **startTime** | **string**| Return intraday prices starting at the specified time on the &#x60;start_date&#x60; (timezone is UTC) | [optional] 
 **endDate** | **DateTime?**| Return intraday prices stopping at the specified date | [optional] 
 **endTime** | **string**| Return intraday prices stopping at the specified time on the &#x60;end_date&#x60; (timezone is UTC) | [optional] 

### Return type

[**ApiResponseSecurityIntradayPrices**](ApiResponseSecurityIntradayPrices.md)

<a name="getsecuritylatestdividendrecord"></a>
# **GetSecurityLatestDividendRecord**
> DividendRecord GetSecurityLatestDividendRecord (string identifier)

Lastest Dividend Record for Security

Returns the latest available dividend information for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityLatestDividendRecordExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)

            try
            {
                DividendRecord result = securityApi.GetSecurityLatestDividendRecord(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityLatestDividendRecord: " + e.Message );
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

[**DividendRecord**](DividendRecord.md)

<a name="getsecuritylatestearningsrecord"></a>
# **GetSecurityLatestEarningsRecord**
> EarningsRecord GetSecurityLatestEarningsRecord (string identifier)

Lastest Earnings Record for Security

Returns latest available earnings information for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityLatestEarningsRecordExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)

            try
            {
                EarningsRecord result = securityApi.GetSecurityLatestEarningsRecord(identifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityLatestEarningsRecord: " + e.Message );
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

[**EarningsRecord**](EarningsRecord.md)

<a name="getsecurityrealtimeprice"></a>
# **GetSecurityRealtimePrice**
> RealtimeStockPrice GetSecurityRealtimePrice (string identifier, string source = null)

Realtime Stock Price for Security

Return the realtime stock price for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityRealtimePriceExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var source = "";  // string | Return the realtime price from the specified data source (optional) 

            try
            {
                RealtimeStockPrice result = securityApi.GetSecurityRealtimePrice(identifier, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityRealtimePrice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **source** | **string**| Return the realtime price from the specified data source | [optional] 

### Return type

[**RealtimeStockPrice**](RealtimeStockPrice.md)

<a name="getsecuritystockpriceadjustments"></a>
# **GetSecurityStockPriceAdjustments**
> ApiResponseSecurityStockPriceAdjustments GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, decimal? pageSize = null, string nextPage = null)

Stock Price Adjustments by Security

Returns stock price adjustments for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityStockPriceAdjustmentsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // DateTime? | Return price adjustments on or after the date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Return price adjustments on or before the date (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityStockPriceAdjustments result = securityApi.GetSecurityStockPriceAdjustments(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityStockPriceAdjustments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **DateTime?**| Return price adjustments on or after the date | [optional] 
 **endDate** | **DateTime?**| Return price adjustments on or before the date | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityStockPriceAdjustments**](ApiResponseSecurityStockPriceAdjustments.md)

<a name="getsecuritystockprices"></a>
# **GetSecurityStockPrices**
> ApiResponseSecurityStockPrices GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, decimal? pageSize = null, string nextPage = null)

Stock Prices by Security

Return end-of-day stock prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityStockPricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // DateTime? | Return prices on or after the date (optional) 
            var endDate = "2019-01-01";  // DateTime? | Return prices on or before the date (optional) 
            var frequency = "daily";  // string | Return stock prices in the given frequency (optional)  (default to daily)
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityStockPrices result = securityApi.GetSecurityStockPrices(identifier, startDate, endDate, frequency, pageSize, nextPage);
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
 **endDate** | **DateTime?**| Return prices on or before the date | [optional] 
 **frequency** | **string**| Return stock prices in the given frequency | [optional] [default to daily]
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityStockPrices**](ApiResponseSecurityStockPrices.md)

<a name="screensecurities"></a>
# **ScreenSecurities**
> List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null, decimal? pageSize = null)

Screen Securities

Screen Securities using complex logic

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class ScreenSecuritiesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var logic = new SecurityScreenGroup(); // SecurityScreenGroup | The logic to screen with, consisting of operators, clauses, and nested groups.<br/> See <a href=\"/documentation/screener_v2\" target=\"_blank\">screener documentation</a> for details on how to construct conditions. (optional) 
            var orderColumn = orderColumn_example;  // string | Results returned sorted by this column (optional) 
            var orderDirection = orderDirection_example;  // string | Sort order to use with the order_column (optional)  (default to asc)
            var primaryOnly = true;  // bool? | Return only primary securities (optional)  (default to false)
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)

            try
            {
                List&lt;SecurityScreenResult&gt; result = securityApi.ScreenSecurities(logic, orderColumn, orderDirection, primaryOnly, pageSize);
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
 **logic** | [**SecurityScreenGroup**](SecurityScreenGroup.md)| The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. | [optional] 
 **orderColumn** | **string**| Results returned sorted by this column | [optional] 
 **orderDirection** | **string**| Sort order to use with the order_column | [optional] [default to asc]
 **primaryOnly** | **bool?**| Return only primary securities | [optional] [default to false]
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]

### Return type

[**List<SecurityScreenResult>**](SecurityScreenResult.md)

<a name="searchsecurities"></a>
# **SearchSecurities**
> ApiResponseSecuritiesSearch SearchSecurities (string query, decimal? pageSize = null)

Search Securities

Searches for Securities matching the text `query`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class SearchSecuritiesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var query = "Apple";  // string | 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseSecuritiesSearch result = securityApi.SearchSecurities(query, pageSize);
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
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseSecuritiesSearch**](ApiResponseSecuritiesSearch.md)


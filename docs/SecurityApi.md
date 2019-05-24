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
[**GetSecurityPriceTechnicalsAdi**](SecurityApi.md#getsecuritypricetechnicalsadi) | **GET** /securities/{identifier}/prices/technicals/adi | Accumulation/Distribution Index
[**GetSecurityPriceTechnicalsAdtv**](SecurityApi.md#getsecuritypricetechnicalsadtv) | **GET** /securities/{identifier}/prices/technicals/adtv | Average Daily Trading Volume
[**GetSecurityPriceTechnicalsAdx**](SecurityApi.md#getsecuritypricetechnicalsadx) | **GET** /securities/{identifier}/prices/technicals/adx | Average Directional Index
[**GetSecurityPriceTechnicalsAo**](SecurityApi.md#getsecuritypricetechnicalsao) | **GET** /securities/{identifier}/prices/technicals/ao | Awesome Oscillator
[**GetSecurityPriceTechnicalsAtr**](SecurityApi.md#getsecuritypricetechnicalsatr) | **GET** /securities/{identifier}/prices/technicals/atr | Average True Range
[**GetSecurityPriceTechnicalsBb**](SecurityApi.md#getsecuritypricetechnicalsbb) | **GET** /securities/{identifier}/prices/technicals/bb | Bollinger Bands
[**GetSecurityPriceTechnicalsCci**](SecurityApi.md#getsecuritypricetechnicalscci) | **GET** /securities/{identifier}/prices/technicals/cci | Commodity Channel Index
[**GetSecurityPriceTechnicalsCmf**](SecurityApi.md#getsecuritypricetechnicalscmf) | **GET** /securities/{identifier}/prices/technicals/cmf | Chaikin Money Flow
[**GetSecurityPriceTechnicalsDc**](SecurityApi.md#getsecuritypricetechnicalsdc) | **GET** /securities/{identifier}/prices/technicals/dc | Donchian Channel
[**GetSecurityPriceTechnicalsDpo**](SecurityApi.md#getsecuritypricetechnicalsdpo) | **GET** /securities/{identifier}/prices/technicals/dpo | Detrended Price Oscillator
[**GetSecurityPriceTechnicalsEom**](SecurityApi.md#getsecuritypricetechnicalseom) | **GET** /securities/{identifier}/prices/technicals/eom | Ease of Movement
[**GetSecurityPriceTechnicalsFi**](SecurityApi.md#getsecuritypricetechnicalsfi) | **GET** /securities/{identifier}/prices/technicals/fi | Force Index
[**GetSecurityPriceTechnicalsIchimoku**](SecurityApi.md#getsecuritypricetechnicalsichimoku) | **GET** /securities/{identifier}/prices/technicals/ichimoku | Ichimoku Kinko Hyo
[**GetSecurityPriceTechnicalsKc**](SecurityApi.md#getsecuritypricetechnicalskc) | **GET** /securities/{identifier}/prices/technicals/kc | Keltner Channel
[**GetSecurityPriceTechnicalsKst**](SecurityApi.md#getsecuritypricetechnicalskst) | **GET** /securities/{identifier}/prices/technicals/kst | Know Sure Thing
[**GetSecurityPriceTechnicalsMacd**](SecurityApi.md#getsecuritypricetechnicalsmacd) | **GET** /securities/{identifier}/prices/technicals/macd | Moving Average Convergence Divergence
[**GetSecurityPriceTechnicalsMfi**](SecurityApi.md#getsecuritypricetechnicalsmfi) | **GET** /securities/{identifier}/prices/technicals/mfi | Money Flow Index
[**GetSecurityPriceTechnicalsMi**](SecurityApi.md#getsecuritypricetechnicalsmi) | **GET** /securities/{identifier}/prices/technicals/mi | Mass Index
[**GetSecurityPriceTechnicalsNvi**](SecurityApi.md#getsecuritypricetechnicalsnvi) | **GET** /securities/{identifier}/prices/technicals/nvi | Negative Volume Index
[**GetSecurityPriceTechnicalsObv**](SecurityApi.md#getsecuritypricetechnicalsobv) | **GET** /securities/{identifier}/prices/technicals/obv | On-balance Volume
[**GetSecurityPriceTechnicalsObvMean**](SecurityApi.md#getsecuritypricetechnicalsobvmean) | **GET** /securities/{identifier}/prices/technicals/obv_mean | On-balance Volume Mean
[**GetSecurityPriceTechnicalsRsi**](SecurityApi.md#getsecuritypricetechnicalsrsi) | **GET** /securities/{identifier}/prices/technicals/rsi | Relative Strength Index
[**GetSecurityPriceTechnicalsSma**](SecurityApi.md#getsecuritypricetechnicalssma) | **GET** /securities/{identifier}/prices/technicals/sma | Simple Moving Average
[**GetSecurityPriceTechnicalsSr**](SecurityApi.md#getsecuritypricetechnicalssr) | **GET** /securities/{identifier}/prices/technicals/sr | Stochastic Oscillator
[**GetSecurityPriceTechnicalsTrix**](SecurityApi.md#getsecuritypricetechnicalstrix) | **GET** /securities/{identifier}/prices/technicals/trix | Triple Exponential Average
[**GetSecurityPriceTechnicalsTsi**](SecurityApi.md#getsecuritypricetechnicalstsi) | **GET** /securities/{identifier}/prices/technicals/tsi | True Strength Index
[**GetSecurityPriceTechnicalsUo**](SecurityApi.md#getsecuritypricetechnicalsuo) | **GET** /securities/{identifier}/prices/technicals/uo | Ultimate Oscillator
[**GetSecurityPriceTechnicalsVi**](SecurityApi.md#getsecuritypricetechnicalsvi) | **GET** /securities/{identifier}/prices/technicals/vi | Vortex Indicator
[**GetSecurityPriceTechnicalsVpt**](SecurityApi.md#getsecuritypricetechnicalsvpt) | **GET** /securities/{identifier}/prices/technicals/vpt | Volume-price Trend
[**GetSecurityPriceTechnicalsVwap**](SecurityApi.md#getsecuritypricetechnicalsvwap) | **GET** /securities/{identifier}/prices/technicals/vwap | Volume Weighted Average Price
[**GetSecurityPriceTechnicalsWr**](SecurityApi.md#getsecuritypricetechnicalswr) | **GET** /securities/{identifier}/prices/technicals/wr | Williams %R
[**GetSecurityRealtimePrice**](SecurityApi.md#getsecurityrealtimeprice) | **GET** /securities/{identifier}/prices/realtime | Realtime Stock Price for Security
[**GetSecurityStockPriceAdjustments**](SecurityApi.md#getsecuritystockpriceadjustments) | **GET** /securities/{identifier}/prices/adjustments | Stock Price Adjustments by Security
[**GetSecurityStockPrices**](SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Stock Prices by Security
[**GetSecurityZacksAnalystRatings**](SecurityApi.md#getsecurityzacksanalystratings) | **GET** /securities/{identifier}/zacks/analyst_ratings | Zacks Analyst Ratings
[**GetSecurityZacksAnalystRatingsSnapshot**](SecurityApi.md#getsecurityzacksanalystratingssnapshot) | **GET** /securities/{identifier}/zacks/analyst_ratings/snapshot | Zacks Analyst Ratings Snapshot
[**GetSecurityZacksEpsSurprises**](SecurityApi.md#getsecurityzacksepssurprises) | **GET** /securities/{identifier}/zacks/eps_surprises | Zacks EPS Surprises for Security
[**GetSecurityZacksSalesSurprises**](SecurityApi.md#getsecurityzackssalessurprises) | **GET** /securities/{identifier}/zacks/sales_surprises | Zacks Sales Surprises for Security
[**ScreenSecurities**](SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
[**SearchSecurities**](SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities


<a name="getallsecurities"></a>
# **GetAllSecurities**
> ApiResponseSecurities GetAllSecurities (int? pageSize = null, string nextPage = null)

All Securities

Returns all Securities to which you have access.

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
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
            var tag = "close_price";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)

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
 **tag** | **string**| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) | 

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
> ApiResponseSecurityHistoricalData GetSecurityHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

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
            var tag = "adj_close_price";  // string | An Intrinio data tag ID or code (<a href='https://data.intrinio.com/data-tags'>reference</a>)
            var frequency = "daily";  // string | Return historical data in the given frequency (optional)  (default to daily)
            var type = "";  // string | Filter by type, when applicable (optional) 
            var startDate = "2018-01-01";  // DateTime? | Get historical data on or after this date (optional) 
            var endDate = "";  // DateTime? | Get historical date on or before this date (optional) 
            var sortOrder = "";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
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
 **tag** | **string**| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) | 
 **frequency** | **string**| Return historical data in the given frequency | [optional] [default to daily]
 **type** | **string**| Filter by type, when applicable | [optional] 
 **startDate** | **DateTime?**| Get historical data on or after this date | [optional] 
 **endDate** | **DateTime?**| Get historical date on or before this date | [optional] 
 **sortOrder** | **string**| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc]
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
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

<a name="getsecuritypricetechnicalsadi"></a>
# **GetSecurityPriceTechnicalsAdi**
> ApiResponseSecurityAccumulationDistributionIndex GetSecurityPriceTechnicalsAdi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Accumulation/Distribution Index

Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAdiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAccumulationDistributionIndex result = securityApi.GetSecurityPriceTechnicalsAdi(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsAdi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAccumulationDistributionIndex**](ApiResponseSecurityAccumulationDistributionIndex.md)

<a name="getsecuritypricetechnicalsadtv"></a>
# **GetSecurityPriceTechnicalsAdtv**
> ApiResponseSecurityAverageDailyTradingVolume GetSecurityPriceTechnicalsAdtv (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Average Daily Trading Volume

Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAdtvExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 22;  // int? | The number of observations, per period, to calculate Average Daily Trading Volume (optional)  (default to 22)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAverageDailyTradingVolume result = securityApi.GetSecurityPriceTechnicalsAdtv(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsAdtv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Average Daily Trading Volume | [optional] [default to 22]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAverageDailyTradingVolume**](ApiResponseSecurityAverageDailyTradingVolume.md)

<a name="getsecuritypricetechnicalsadx"></a>
# **GetSecurityPriceTechnicalsAdx**
> ApiResponseSecurityAverageDirectionalIndex GetSecurityPriceTechnicalsAdx (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Average Directional Index

Returns the Average Directional Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAdxExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Average Directional Index (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAverageDirectionalIndex result = securityApi.GetSecurityPriceTechnicalsAdx(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsAdx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Average Directional Index | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAverageDirectionalIndex**](ApiResponseSecurityAverageDirectionalIndex.md)

<a name="getsecuritypricetechnicalsao"></a>
# **GetSecurityPriceTechnicalsAo**
> ApiResponseSecurityAwesomeOscillator GetSecurityPriceTechnicalsAo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Awesome Oscillator

Returns the Awesome Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAoExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var shortPeriod = 5;  // int? | The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional)  (default to 5)
            var longPeriod = 34;  // int? | The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional)  (default to 34)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAwesomeOscillator result = securityApi.GetSecurityPriceTechnicalsAo(identifier, shortPeriod, longPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsAo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **shortPeriod** | **int?**| The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator | [optional] [default to 5]
 **longPeriod** | **int?**| The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator | [optional] [default to 34]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAwesomeOscillator**](ApiResponseSecurityAwesomeOscillator.md)

<a name="getsecuritypricetechnicalsatr"></a>
# **GetSecurityPriceTechnicalsAtr**
> ApiResponseSecurityAverageTrueRange GetSecurityPriceTechnicalsAtr (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Average True Range

Returns the Average True Range values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsAtrExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Average True Range (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityAverageTrueRange result = securityApi.GetSecurityPriceTechnicalsAtr(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsAtr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Average True Range | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityAverageTrueRange**](ApiResponseSecurityAverageTrueRange.md)

<a name="getsecuritypricetechnicalsbb"></a>
# **GetSecurityPriceTechnicalsBb**
> ApiResponseSecurityBollingerBands GetSecurityPriceTechnicalsBb (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Bollinger Bands

Returns the Bollinger Bands values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsBbExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Bollinger Bands (optional)  (default to 20)
            var standardDeviations = 2.0;  // float? | The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional)  (default to 2.0)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Bollinger Bands (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityBollingerBands result = securityApi.GetSecurityPriceTechnicalsBb(identifier, period, standardDeviations, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsBb: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Bollinger Bands | [optional] [default to 20]
 **standardDeviations** | **float?**| The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands | [optional] [default to 2.0]
 **priceKey** | **string**| The Stock Price field to use when calculating Bollinger Bands | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityBollingerBands**](ApiResponseSecurityBollingerBands.md)

<a name="getsecuritypricetechnicalscci"></a>
# **GetSecurityPriceTechnicalsCci**
> ApiResponseSecurityCommodityChannelIndex GetSecurityPriceTechnicalsCci (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Commodity Channel Index

Returns the Commodity Channel Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsCciExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Commodity Channel Index (optional)  (default to 20)
            var constant = 0.015;  // float? | The number of observations, per period, to calculate Commodity Channel Index (optional)  (default to 0.015)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityCommodityChannelIndex result = securityApi.GetSecurityPriceTechnicalsCci(identifier, period, constant, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsCci: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Commodity Channel Index | [optional] [default to 20]
 **constant** | **float?**| The number of observations, per period, to calculate Commodity Channel Index | [optional] [default to 0.015]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityCommodityChannelIndex**](ApiResponseSecurityCommodityChannelIndex.md)

<a name="getsecuritypricetechnicalscmf"></a>
# **GetSecurityPriceTechnicalsCmf**
> ApiResponseSecurityChaikinMoneyFlow GetSecurityPriceTechnicalsCmf (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Chaikin Money Flow

Returns the Chaikin Money Flow values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsCmfExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Chaikin Money Flow (optional)  (default to 20)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityChaikinMoneyFlow result = securityApi.GetSecurityPriceTechnicalsCmf(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsCmf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Chaikin Money Flow | [optional] [default to 20]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityChaikinMoneyFlow**](ApiResponseSecurityChaikinMoneyFlow.md)

<a name="getsecuritypricetechnicalsdc"></a>
# **GetSecurityPriceTechnicalsDc**
> ApiResponseSecurityDonchianChannel GetSecurityPriceTechnicalsDc (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Donchian Channel

Returns the Donchian Channel values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsDcExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Donchian Channel (optional)  (default to 20)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Donchian Channel (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityDonchianChannel result = securityApi.GetSecurityPriceTechnicalsDc(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsDc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Donchian Channel | [optional] [default to 20]
 **priceKey** | **string**| The Stock Price field to use when calculating Donchian Channel | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityDonchianChannel**](ApiResponseSecurityDonchianChannel.md)

<a name="getsecuritypricetechnicalsdpo"></a>
# **GetSecurityPriceTechnicalsDpo**
> ApiResponseSecurityDetrendedPriceOscillator GetSecurityPriceTechnicalsDpo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Detrended Price Oscillator

Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsDpoExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Detrended Price Oscillator (optional)  (default to 20)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Detrended Price Oscillator (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityDetrendedPriceOscillator result = securityApi.GetSecurityPriceTechnicalsDpo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsDpo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Detrended Price Oscillator | [optional] [default to 20]
 **priceKey** | **string**| The Stock Price field to use when calculating Detrended Price Oscillator | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityDetrendedPriceOscillator**](ApiResponseSecurityDetrendedPriceOscillator.md)

<a name="getsecuritypricetechnicalseom"></a>
# **GetSecurityPriceTechnicalsEom**
> ApiResponseSecurityEaseOfMovement GetSecurityPriceTechnicalsEom (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Ease of Movement

Returns the Ease of Movement values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsEomExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Ease of Movement (optional)  (default to 20)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityEaseOfMovement result = securityApi.GetSecurityPriceTechnicalsEom(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsEom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Ease of Movement | [optional] [default to 20]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityEaseOfMovement**](ApiResponseSecurityEaseOfMovement.md)

<a name="getsecuritypricetechnicalsfi"></a>
# **GetSecurityPriceTechnicalsFi**
> ApiResponseSecurityForceIndex GetSecurityPriceTechnicalsFi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Force Index

Returns the Force Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsFiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityForceIndex result = securityApi.GetSecurityPriceTechnicalsFi(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsFi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityForceIndex**](ApiResponseSecurityForceIndex.md)

<a name="getsecuritypricetechnicalsichimoku"></a>
# **GetSecurityPriceTechnicalsIchimoku**
> ApiResponseSecurityIchimokuKinkoHyo GetSecurityPriceTechnicalsIchimoku (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Ichimoku Kinko Hyo

Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsIchimokuExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var lowPeriod = 9;  // int? | The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional)  (default to 9)
            var mediumPeriod = 26;  // int? | The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional)  (default to 26)
            var highPeriod = 52;  // int? | The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional)  (default to 52)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityIchimokuKinkoHyo result = securityApi.GetSecurityPriceTechnicalsIchimoku(identifier, lowPeriod, mediumPeriod, highPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsIchimoku: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **lowPeriod** | **int?**| The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo | [optional] [default to 9]
 **mediumPeriod** | **int?**| The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo | [optional] [default to 26]
 **highPeriod** | **int?**| The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo | [optional] [default to 52]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityIchimokuKinkoHyo**](ApiResponseSecurityIchimokuKinkoHyo.md)

<a name="getsecuritypricetechnicalskc"></a>
# **GetSecurityPriceTechnicalsKc**
> ApiResponseSecurityKeltnerChannel GetSecurityPriceTechnicalsKc (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Keltner Channel

Returns the Keltner Channel values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsKcExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 10;  // int? | The number of observations, per period, to calculate Kelter Channel (optional)  (default to 10)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityKeltnerChannel result = securityApi.GetSecurityPriceTechnicalsKc(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsKc: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Kelter Channel | [optional] [default to 10]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityKeltnerChannel**](ApiResponseSecurityKeltnerChannel.md)

<a name="getsecuritypricetechnicalskst"></a>
# **GetSecurityPriceTechnicalsKst**
> ApiResponseSecurityKnowSureThing GetSecurityPriceTechnicalsKst (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Know Sure Thing

Returns the Know Sure Thing values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsKstExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var roc1 = 10;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional)  (default to 10)
            var roc2 = 15;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional)  (default to 15)
            var roc3 = 20;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional)  (default to 20)
            var roc4 = 30;  // int? | The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional)  (default to 30)
            var sma1 = 10;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional)  (default to 10)
            var sma2 = 10;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional)  (default to 10)
            var sma3 = 10;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional)  (default to 10)
            var sma4 = 15;  // int? | The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional)  (default to 15)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Know Sure Thing (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityKnowSureThing result = securityApi.GetSecurityPriceTechnicalsKst(identifier, roc1, roc2, roc3, roc4, sma1, sma2, sma3, sma4, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsKst: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **roc1** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA1 | [optional] [default to 10]
 **roc2** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA2 | [optional] [default to 15]
 **roc3** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA3 | [optional] [default to 20]
 **roc4** | **int?**| The number of observations, per period, to calculate the rate-of-change for RCMA4 | [optional] [default to 30]
 **sma1** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 | [optional] [default to 10]
 **sma2** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 | [optional] [default to 10]
 **sma3** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 | [optional] [default to 10]
 **sma4** | **int?**| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 | [optional] [default to 15]
 **priceKey** | **string**| The Stock Price field to use when calculating Know Sure Thing | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityKnowSureThing**](ApiResponseSecurityKnowSureThing.md)

<a name="getsecuritypricetechnicalsmacd"></a>
# **GetSecurityPriceTechnicalsMacd**
> ApiResponseSecurityMovingAverageConvergenceDivergence GetSecurityPriceTechnicalsMacd (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Moving Average Convergence Divergence

Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsMacdExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var fastPeriod = 12;  // int? | The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional)  (default to 12)
            var slowPeriod = 26;  // int? | The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional)  (default to 26)
            var signalPeriod = 9;  // int? | The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional)  (default to 9)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Moving Average Convergence Divergence (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityMovingAverageConvergenceDivergence result = securityApi.GetSecurityPriceTechnicalsMacd(identifier, fastPeriod, slowPeriod, signalPeriod, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsMacd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **fastPeriod** | **int?**| The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence | [optional] [default to 12]
 **slowPeriod** | **int?**| The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence | [optional] [default to 26]
 **signalPeriod** | **int?**| The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence | [optional] [default to 9]
 **priceKey** | **string**| The Stock Price field to use when calculating Moving Average Convergence Divergence | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityMovingAverageConvergenceDivergence**](ApiResponseSecurityMovingAverageConvergenceDivergence.md)

<a name="getsecuritypricetechnicalsmfi"></a>
# **GetSecurityPriceTechnicalsMfi**
> ApiResponseSecurityMoneyFlowIndex GetSecurityPriceTechnicalsMfi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Money Flow Index

Returns the Money Flow Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsMfiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Money Flow Index (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityMoneyFlowIndex result = securityApi.GetSecurityPriceTechnicalsMfi(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsMfi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Money Flow Index | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityMoneyFlowIndex**](ApiResponseSecurityMoneyFlowIndex.md)

<a name="getsecuritypricetechnicalsmi"></a>
# **GetSecurityPriceTechnicalsMi**
> ApiResponseSecurityMassIndex GetSecurityPriceTechnicalsMi (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Mass Index

Returns the Mass Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsMiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var emaPeriod = 9;  // int? | The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional)  (default to 9)
            var sumPeriod = 25;  // int? | The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional)  (default to 25)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityMassIndex result = securityApi.GetSecurityPriceTechnicalsMi(identifier, emaPeriod, sumPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsMi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **emaPeriod** | **int?**| The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index | [optional] [default to 9]
 **sumPeriod** | **int?**| The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index | [optional] [default to 25]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityMassIndex**](ApiResponseSecurityMassIndex.md)

<a name="getsecuritypricetechnicalsnvi"></a>
# **GetSecurityPriceTechnicalsNvi**
> ApiResponseSecurityNegativeVolumeIndex GetSecurityPriceTechnicalsNvi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Negative Volume Index

Returns the Negative Volume Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsNviExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityNegativeVolumeIndex result = securityApi.GetSecurityPriceTechnicalsNvi(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsNvi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityNegativeVolumeIndex**](ApiResponseSecurityNegativeVolumeIndex.md)

<a name="getsecuritypricetechnicalsobv"></a>
# **GetSecurityPriceTechnicalsObv**
> ApiResponseSecurityOnBalanceVolume GetSecurityPriceTechnicalsObv (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

On-balance Volume

Returns the On-balance Volume values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsObvExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityOnBalanceVolume result = securityApi.GetSecurityPriceTechnicalsObv(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsObv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityOnBalanceVolume**](ApiResponseSecurityOnBalanceVolume.md)

<a name="getsecuritypricetechnicalsobvmean"></a>
# **GetSecurityPriceTechnicalsObvMean**
> ApiResponseSecurityOnBalanceVolumeMean GetSecurityPriceTechnicalsObvMean (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

On-balance Volume Mean

Returns the On-balance Volume Mean values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsObvMeanExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 10;  // int? | The number of observations, per period, to calculate On-balance Volume Mean (optional)  (default to 10)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityOnBalanceVolumeMean result = securityApi.GetSecurityPriceTechnicalsObvMean(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsObvMean: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate On-balance Volume Mean | [optional] [default to 10]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityOnBalanceVolumeMean**](ApiResponseSecurityOnBalanceVolumeMean.md)

<a name="getsecuritypricetechnicalsrsi"></a>
# **GetSecurityPriceTechnicalsRsi**
> ApiResponseSecurityRelativeStrengthIndex GetSecurityPriceTechnicalsRsi (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Relative Strength Index

Returns the Relative Strength Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsRsiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Relative Strength Index (optional)  (default to 14)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Relative Strength Index (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityRelativeStrengthIndex result = securityApi.GetSecurityPriceTechnicalsRsi(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsRsi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Relative Strength Index | [optional] [default to 14]
 **priceKey** | **string**| The Stock Price field to use when calculating Relative Strength Index | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityRelativeStrengthIndex**](ApiResponseSecurityRelativeStrengthIndex.md)

<a name="getsecuritypricetechnicalssma"></a>
# **GetSecurityPriceTechnicalsSma**
> ApiResponseSecuritySimpleMovingAverage GetSecurityPriceTechnicalsSma (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Simple Moving Average

Returns the Simple Moving Average values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsSmaExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 20;  // int? | The number of observations, per period, to calculate Simple Moving Average (optional)  (default to 20)
            var priceKey = "close";  // string | The Stock Price field to use when calculating Simple Moving Average (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecuritySimpleMovingAverage result = securityApi.GetSecurityPriceTechnicalsSma(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsSma: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Simple Moving Average | [optional] [default to 20]
 **priceKey** | **string**| The Stock Price field to use when calculating Simple Moving Average | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecuritySimpleMovingAverage**](ApiResponseSecuritySimpleMovingAverage.md)

<a name="getsecuritypricetechnicalssr"></a>
# **GetSecurityPriceTechnicalsSr**
> ApiResponseSecurityStochasticOscillator GetSecurityPriceTechnicalsSr (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Stochastic Oscillator

Returns the Stochastic Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsSrExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate %K of Stochastic Oscillator (optional)  (default to 14)
            var signalPeriod = 3;  // int? | The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional)  (default to 3)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityStochasticOscillator result = securityApi.GetSecurityPriceTechnicalsSr(identifier, period, signalPeriod, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsSr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate %K of Stochastic Oscillator | [optional] [default to 14]
 **signalPeriod** | **int?**| The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator | [optional] [default to 3]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityStochasticOscillator**](ApiResponseSecurityStochasticOscillator.md)

<a name="getsecuritypricetechnicalstrix"></a>
# **GetSecurityPriceTechnicalsTrix**
> ApiResponseSecurityTripleExponentialAverage GetSecurityPriceTechnicalsTrix (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Triple Exponential Average

Returns the Simple Moving Average values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsTrixExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 15;  // int? | The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional)  (default to 15)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityTripleExponentialAverage result = securityApi.GetSecurityPriceTechnicalsTrix(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsTrix: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average | [optional] [default to 15]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityTripleExponentialAverage**](ApiResponseSecurityTripleExponentialAverage.md)

<a name="getsecuritypricetechnicalstsi"></a>
# **GetSecurityPriceTechnicalsTsi**
> ApiResponseSecurityTrueStrengthIndex GetSecurityPriceTechnicalsTsi (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

True Strength Index

Returns the True Strength Index values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsTsiExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var lowPeriod = 13;  // int? | The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional)  (default to 13)
            var highPeriod = 25;  // int? | The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional)  (default to 25)
            var priceKey = "close";  // string | The Stock Price field to use when calculating True Strength Index (optional)  (default to close)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityTrueStrengthIndex result = securityApi.GetSecurityPriceTechnicalsTsi(identifier, lowPeriod, highPeriod, priceKey, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsTsi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **lowPeriod** | **int?**| The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index | [optional] [default to 13]
 **highPeriod** | **int?**| The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index | [optional] [default to 25]
 **priceKey** | **string**| The Stock Price field to use when calculating True Strength Index | [optional] [default to close]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityTrueStrengthIndex**](ApiResponseSecurityTrueStrengthIndex.md)

<a name="getsecuritypricetechnicalsuo"></a>
# **GetSecurityPriceTechnicalsUo**
> ApiResponseSecurityUltimateOscillator GetSecurityPriceTechnicalsUo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Ultimate Oscillator

Returns the Ultimate Oscillator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsUoExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var shortPeriod = 7;  // int? | The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional)  (default to 7)
            var mediumPeriod = 14;  // int? | The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional)  (default to 14)
            var longPeriod = 28;  // int? | The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional)  (default to 28)
            var shortWeight = 4.0;  // float? | The weight of short Buying Pressure average for Ultimate Oscillator (optional)  (default to 4.0)
            var mediumWeight = 2.0;  // float? | The weight of medium Buying Pressure average for Ultimate Oscillator (optional)  (default to 2.0)
            var longWeight = 1.0;  // float? | The weight of long Buying Pressure average for Ultimate Oscillator (optional)  (default to 1.0)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityUltimateOscillator result = securityApi.GetSecurityPriceTechnicalsUo(identifier, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsUo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **shortPeriod** | **int?**| The number of observations, per period, to calculate the short period for Ultimate Oscillator | [optional] [default to 7]
 **mediumPeriod** | **int?**| The number of observations, per period, to calculate the medium period for Ultimate Oscillator | [optional] [default to 14]
 **longPeriod** | **int?**| The number of observations, per period, to calculate the long period for Ultimate Oscillator | [optional] [default to 28]
 **shortWeight** | **float?**| The weight of short Buying Pressure average for Ultimate Oscillator | [optional] [default to 4.0]
 **mediumWeight** | **float?**| The weight of medium Buying Pressure average for Ultimate Oscillator | [optional] [default to 2.0]
 **longWeight** | **float?**| The weight of long Buying Pressure average for Ultimate Oscillator | [optional] [default to 1.0]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityUltimateOscillator**](ApiResponseSecurityUltimateOscillator.md)

<a name="getsecuritypricetechnicalsvi"></a>
# **GetSecurityPriceTechnicalsVi**
> ApiResponseSecurityVortexIndicator GetSecurityPriceTechnicalsVi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Vortex Indicator

Returns the Vortex Indicator values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsViExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to calculate Vortex Indicator (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityVortexIndicator result = securityApi.GetSecurityPriceTechnicalsVi(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsVi: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to calculate Vortex Indicator | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityVortexIndicator**](ApiResponseSecurityVortexIndicator.md)

<a name="getsecuritypricetechnicalsvpt"></a>
# **GetSecurityPriceTechnicalsVpt**
> ApiResponseSecurityVolumePriceTrend GetSecurityPriceTechnicalsVpt (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Volume-price Trend

Returns the Volume-price Trend values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsVptExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityVolumePriceTrend result = securityApi.GetSecurityPriceTechnicalsVpt(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsVpt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityVolumePriceTrend**](ApiResponseSecurityVolumePriceTrend.md)

<a name="getsecuritypricetechnicalsvwap"></a>
# **GetSecurityPriceTechnicalsVwap**
> ApiResponseSecurityVolumeWeightedAveragePrice GetSecurityPriceTechnicalsVwap (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

Volume Weighted Average Price

Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsVwapExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityVolumeWeightedAveragePrice result = securityApi.GetSecurityPriceTechnicalsVwap(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsVwap: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityVolumeWeightedAveragePrice**](ApiResponseSecurityVolumeWeightedAveragePrice.md)

<a name="getsecuritypricetechnicalswr"></a>
# **GetSecurityPriceTechnicalsWr**
> ApiResponseSecurityWilliamsR GetSecurityPriceTechnicalsWr (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)

Williams %R

Returns the Williams %R values of Stock Prices for the Security with the given `identifier`

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityPriceTechnicalsWrExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var period = 14;  // int? | The number of observations, per period, to look-back when calculating Williams %R (optional)  (default to 14)
            var startDate = "2018-01-01";  // string | Return technical indicator values on or after the date (optional) 
            var endDate = "2019-01-01";  // string | Return technical indicator values on or before the date (optional) 
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityWilliamsR result = securityApi.GetSecurityPriceTechnicalsWr(identifier, period, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityPriceTechnicalsWr: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **period** | **int?**| The number of observations, per period, to look-back when calculating Williams %R | [optional] [default to 14]
 **startDate** | **string**| Return technical indicator values on or after the date | [optional] 
 **endDate** | **string**| Return technical indicator values on or before the date | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityWilliamsR**](ApiResponseSecurityWilliamsR.md)

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
> ApiResponseSecurityStockPriceAdjustments GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityStockPriceAdjustments**](ApiResponseSecurityStockPriceAdjustments.md)

<a name="getsecuritystockprices"></a>
# **GetSecurityStockPrices**
> ApiResponseSecurityStockPrices GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, int? pageSize = null, string nextPage = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityStockPrices**](ApiResponseSecurityStockPrices.md)

<a name="getsecurityzacksanalystratings"></a>
# **GetSecurityZacksAnalystRatings**
> ApiResponseSecurityZacksAnalystRatings GetSecurityZacksAnalystRatings (string identifier, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null)

Zacks Analyst Ratings

Returns buy, sell, and hold recommendations from analysts at brokerages for the Security with the given `identifier`. Zack’s storied research team aggregates and validates the ratings from professional analysts.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityZacksAnalystRatingsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var startDate = "";  // string | Limit ratings to those on or after this date (optional) 
            var endDate = "";  // string | Limit ratings to those on or before this date (optional) 
            var meanGreater = "";  // decimal? | Return only records with a mean (average) higher than this value (optional) 
            var meanLess = "";  // decimal? | Return only records with a mean (average) lower than this value (optional) 
            var strongBuysGreater = "";  // int? | Return only records with more than this many Strong Buy recommendations (optional) 
            var strongBuysLess = "";  // int? | Return only records with fewer than this many Strong Buy recommendations (optional) 
            var buysGreater = "";  // int? | Return only records with more than this many Buy recommendations (optional) 
            var buysLess = "";  // int? | Return only records with fewer than this many Buy recommendations (optional) 
            var holdsGreater = "";  // int? | Return only records with more than this many Hold recommendations (optional) 
            var holdsLess = "";  // int? | Return only records with fewer than this many Hold recommendations (optional) 
            var sellsGreater = "";  // int? | Return only records with more than this many Sell recommendations (optional) 
            var sellsLess = "";  // int? | Return only records with fewer than this many Sell recommendations (optional) 
            var strongSellsGreater = "";  // int? | Return only records with more than this many Strong Sell recommendations (optional) 
            var strongSellsLess = "";  // int? | Return only records with fewer than this many Strong Sell recommendations (optional) 
            var totalGreater = "";  // int? | Return only records with more than this many recommendations, regardless of type (optional) 
            var totalLess = "";  // int? | Return only records with fewer than this many recommendations, regardless of type (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseSecurityZacksAnalystRatings result = securityApi.GetSecurityZacksAnalystRatings(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityZacksAnalystRatings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **startDate** | **string**| Limit ratings to those on or after this date | [optional] 
 **endDate** | **string**| Limit ratings to those on or before this date | [optional] 
 **meanGreater** | **decimal?**| Return only records with a mean (average) higher than this value | [optional] 
 **meanLess** | **decimal?**| Return only records with a mean (average) lower than this value | [optional] 
 **strongBuysGreater** | **int?**| Return only records with more than this many Strong Buy recommendations | [optional] 
 **strongBuysLess** | **int?**| Return only records with fewer than this many Strong Buy recommendations | [optional] 
 **buysGreater** | **int?**| Return only records with more than this many Buy recommendations | [optional] 
 **buysLess** | **int?**| Return only records with fewer than this many Buy recommendations | [optional] 
 **holdsGreater** | **int?**| Return only records with more than this many Hold recommendations | [optional] 
 **holdsLess** | **int?**| Return only records with fewer than this many Hold recommendations | [optional] 
 **sellsGreater** | **int?**| Return only records with more than this many Sell recommendations | [optional] 
 **sellsLess** | **int?**| Return only records with fewer than this many Sell recommendations | [optional] 
 **strongSellsGreater** | **int?**| Return only records with more than this many Strong Sell recommendations | [optional] 
 **strongSellsLess** | **int?**| Return only records with fewer than this many Strong Sell recommendations | [optional] 
 **totalGreater** | **int?**| Return only records with more than this many recommendations, regardless of type | [optional] 
 **totalLess** | **int?**| Return only records with fewer than this many recommendations, regardless of type | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseSecurityZacksAnalystRatings**](ApiResponseSecurityZacksAnalystRatings.md)

<a name="getsecurityzacksanalystratingssnapshot"></a>
# **GetSecurityZacksAnalystRatingsSnapshot**
> ApiResponseSecurityZacksAnalystRatingsSnapshot GetSecurityZacksAnalystRatingsSnapshot (string identifier, string date = null)

Zacks Analyst Ratings Snapshot

Returns a snapshot of ratings data compared with previous timeframes for the Security with the given `identifier`. Also returns mean percentiles for comparing one security to the universe of securities covered by Zacks analyst ratings, at a specific point in time.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityZacksAnalystRatingsSnapshotExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var date = "";  // string | Lookup a historical snapshot on the given date (optional) 

            try
            {
                ApiResponseSecurityZacksAnalystRatingsSnapshot result = securityApi.GetSecurityZacksAnalystRatingsSnapshot(identifier, date);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityZacksAnalystRatingsSnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **date** | **string**| Lookup a historical snapshot on the given date | [optional] 

### Return type

[**ApiResponseSecurityZacksAnalystRatingsSnapshot**](ApiResponseSecurityZacksAnalystRatingsSnapshot.md)

<a name="getsecurityzacksepssurprises"></a>
# **GetSecurityZacksEpsSurprises**
> ApiResponseSecurityZacksEPSSurprises GetSecurityZacksEpsSurprises (string identifier, int? pageSize = null, string nextPage = null)

Zacks EPS Surprises for Security

Return Zacks EPS surprises for the Security with the given `identifier`.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityZacksEpsSurprisesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityZacksEPSSurprises result = securityApi.GetSecurityZacksEpsSurprises(identifier, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityZacksEpsSurprises: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityZacksEPSSurprises**](ApiResponseSecurityZacksEPSSurprises.md)

<a name="getsecurityzackssalessurprises"></a>
# **GetSecurityZacksSalesSurprises**
> ApiResponseSecurityZacksSalesSurprises GetSecurityZacksSalesSurprises (string identifier, int? pageSize = null, string nextPage = null)

Zacks Sales Surprises for Security

Return Zacks sales surprises for the Security with the given `identifier`.

### Example
```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetSecurityZacksSalesSurprisesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var securityApi = new SecurityApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseSecurityZacksSalesSurprises result = securityApi.GetSecurityZacksSalesSurprises(identifier, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.GetSecurityZacksSalesSurprises: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseSecurityZacksSalesSurprises**](ApiResponseSecurityZacksSalesSurprises.md)

<a name="screensecurities"></a>
# **ScreenSecurities**
> List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null, int? pageSize = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**List<SecurityScreenResult>**](SecurityScreenResult.md)

<a name="searchsecurities"></a>
# **SearchSecurities**
> ApiResponseSecuritiesSearch SearchSecurities (string query, int? pageSize = null)

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
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

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
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseSecuritiesSearch**](ApiResponseSecuritiesSearch.md)


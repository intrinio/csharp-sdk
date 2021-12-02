# Intrinio.SDK.Api.SecurityApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSecurities**](SecurityApi.md#getallsecurities) | **GET** /securities | All Securities
[**GetSecurityById**](SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Lookup Security
[**GetSecurityDataPointNumber**](SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{tag}/number | Data Point (Number) for Security
[**GetSecurityDataPointText**](SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{tag}/text | Data Point (Text) for Security
[**GetSecurityHistoricalData**](SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{tag} | Historical Data for Security
[**GetSecurityInsiderOwnership**](SecurityApi.md#getsecurityinsiderownership) | **GET** /securities/{identifier}/institutional_ownership | Institutional Ownership by Security
[**GetSecurityIntervalPrices**](SecurityApi.md#getsecurityintervalprices) | **GET** /securities/{identifier}/prices/intervals | Interval Stock Prices for Security
[**GetSecurityIntradayPrices**](SecurityApi.md#getsecurityintradayprices) | **GET** /securities/{identifier}/prices/intraday | Intraday Stock Prices for Security
[**GetSecurityLatestDividendRecord**](SecurityApi.md#getsecuritylatestdividendrecord) | **GET** /securities/{identifier}/dividends/latest | Latest Dividend Record for Security
[**GetSecurityLatestEarningsRecord**](SecurityApi.md#getsecuritylatestearningsrecord) | **GET** /securities/{identifier}/earnings/latest | Latest Earnings Record for Security
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
[**GetSecurityZacksAnalystRatings**](SecurityApi.md#getsecurityzacksanalystratings) | **GET** /securities/{identifier}/zacks/analyst_ratings | Zacks Analyst Ratings for Security
[**GetSecurityZacksAnalystRatingsSnapshot**](SecurityApi.md#getsecurityzacksanalystratingssnapshot) | **GET** /securities/{identifier}/zacks/analyst_ratings/snapshot | Zacks Analyst Ratings Snapshot
[**GetSecurityZacksEpsSurprises**](SecurityApi.md#getsecurityzacksepssurprises) | **GET** /securities/{identifier}/zacks/eps_surprises | Zacks EPS Surprises for Security
[**GetSecurityZacksSalesSurprises**](SecurityApi.md#getsecurityzackssalessurprises) | **GET** /securities/{identifier}/zacks/sales_surprises | Zacks Sales Surprises for Security
[**ScreenSecurities**](SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
[**SearchSecurities**](SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetAllSecurities)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurities)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurities.md)

[//]: # (OPERATION:GetAllSecurities_v2)

[//]: # (ENDPOINT:/securities)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getallsecurities)

<a name="getallsecurities"></a>
## **GetAllSecurities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllSecurities_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurities GetAllSecurities (bool? active = null, bool? delisted = null, string code = null, string currency = null, string ticker = null, string name = null, string compositeMic = null, string exchangeMic = null, DateTime? stockPricesAfter = null, DateTime? stockPricesBefore = null, string cik = null, string figi = null, string compositeFigi = null, string shareClassFigi = null, string figiUniqueId = null, bool? includeNonFigi = null, int? pageSize = null, bool? primaryListing = null, string nextPage = null)

#### All Securities

Returns all Securities to which you have access. When parameters are specified, returns matching Securities.

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
  public class GetAllSecuritiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      bool? active = true;
      bool? delisted = false;
      string code = null;
      string currency = null;
      string ticker = null;
      string name = null;
      string compositeMic = null;
      string exchangeMic = null;
      DateTime? stockPricesAfter = null;
      DateTime? stockPricesBefore = null;
      string cik = null;
      string figi = null;
      string compositeFigi = null;
      string shareClassFigi = null;
      string figiUniqueId = null;
      bool? includeNonFigi = false;
      int? pageSize = 100;
      bool? primaryListing = null;
      string nextPage = null;
      
      ApiResponseSecurities result = securityApi.GetAllSecurities(active, delisted, code, currency, ticker, name, compositeMic, exchangeMic, stockPricesAfter, stockPricesBefore, cik, figi, compositeFigi, shareClassFigi, figiUniqueId, includeNonFigi, pageSize, primaryListing, nextPage);
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
 **active** | bool?| When true, return securities that are active. When false, return securities that are not active. A security is considered active if it has traded or has had a corporate action in the past 30 days, and has not been merged into another security (such as due to ticker changes or corporate restructurings). | [optional]  &nbsp;
 **delisted** | bool?| When true, return securities that have been delisted from their exchange. Note that there may be a newer security for the same company that has been relisted on a differente exchange. When false, return securities that have not been delisted. | [optional]  &nbsp;
 **code** | string| Return securities classified with the given code (&lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;). | [optional]  &nbsp;
 **currency** | string| Return securities traded in the given 3-digit ISO 4217 currency code (&lt;a href&#x3D;\&quot;https://en.wikipedia.org/wiki/ISO_4217\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;). | [optional]  &nbsp;
 **ticker** | string| Return securities traded with the given ticker. Note that securities across the world (and through time) may trade with the same ticker but represent different companies. Use this in conjuction with other parameters for more specificity. | [optional]  &nbsp;
 **name** | string| Return securities with the given text in their name (not case sensitive). | [optional]  &nbsp;
 **compositeMic** | string| Return securities classified under the composite exchange with the given Market Identification Code (MIC). A composite exchange may or may not be a real exchange.  For example, the USCOMP exchange (our only composite exchange to date) is a combination of exchanges with the following MICs: ARCX, XASE, XPOR, FINR, XCIS, XNAS, XNYS, BATS.  This composite grouping is done for user convenience.  At this time, all US securities are classified under the composite exchange with MIC USCOMP.  To query for specific US exchanges, use the exchange_mic parameter below.  | [optional]  &nbsp;
 **exchangeMic** | string| The MIC code of the exchange where the security is actually traded. | [optional]  &nbsp;
 **stockPricesAfter** | DateTime?| Return securities with end-of-day stock prices on or after this date. | [optional]  &nbsp;
 **stockPricesBefore** | DateTime?| Return securities with end-of-day stock prices on or before this date. | [optional]  &nbsp;
 **cik** | string| Return securities belonging to the company with the given Central Index Key (CIK). | [optional]  &nbsp;
 **figi** | string| Return securities with the given Exchange Level FIGI (&lt;a href&#x3D;\&quot;https://www.openfigi.com/about\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;). | [optional]  &nbsp;
 **compositeFigi** | string| Return securities with the given Country Composite FIGI (&lt;a href&#x3D;\&quot;https://www.openfigi.com/about\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;). | [optional]  &nbsp;
 **shareClassFigi** | string| Return securities with the given Global Share Class FIGI (&lt;a href&#x3D;\&quot;https://www.openfigi.com/about\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;). | [optional]  &nbsp;
 **figiUniqueId** | string| Return securities with the given FIGI Unique ID (&lt;a href&#x3D;\&quot;https://www.openfigi.com/about\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a&gt;). | [optional]  &nbsp;
 **includeNonFigi** | bool?| When true, include securities that do not have a FIGI. By default, this is false. If this parameter is not specified, only securities with a FIGI are returned. | [optional] [default to false] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **primaryListing** | bool?| If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock exchange.  Returns both if omitted. | [optional]  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurities**](ApiResponseSecurities.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Security)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Security.md)

[//]: # (OPERATION:GetSecurityById_v2)

[//]: # (ENDPOINT:/securities/{identifier})

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritybyid)

<a name="getsecuritybyid"></a>
## **GetSecurityById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityById_v2)

[//]: # (START_OVERVIEW)

> Security GetSecurityById (string identifier)

#### Lookup Security

Returns the Security with the given `identifier`

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
  public class GetSecurityByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      
      Security result = securityApi.GetSecurityById(identifier);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Security**](Security.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetSecurityDataPointNumber_v2)

[//]: # (ENDPOINT:/securities/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritydatapointnumber)

<a name="getsecuritydatapointnumber"></a>
## **GetSecurityDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetSecurityDataPointNumber (string identifier, string tag)

#### Data Point (Number) for Security

Returns a numeric value for the given `tag` for the Security with the given `identifier`

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
  public class GetSecurityDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string tag = "close_price";
      
      decimal? result = securityApi.GetSecurityDataPointNumber(identifier, tag);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetSecurityDataPointText_v2)

[//]: # (ENDPOINT:/securities/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritydatapointtext)

<a name="getsecuritydatapointtext"></a>
## **GetSecurityDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetSecurityDataPointText (string identifier, string tag)

#### Data Point (Text) for Security

Returns a text value for the given `tag` for the Security with the given `identifier`

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
  public class GetSecurityDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string tag = "figi";
      
      string result = securityApi.GetSecurityDataPointText(identifier, tag);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityHistoricalData.md)

[//]: # (OPERATION:GetSecurityHistoricalData_v2)

[//]: # (ENDPOINT:/securities/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityhistoricaldata)

<a name="getsecurityhistoricaldata"></a>
## **GetSecurityHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityHistoricalData GetSecurityHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for Security

Returns historical values for the given `tag` and the Security with the given `identifier`

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
  public class GetSecurityHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string tag = "adj_close_price";
      string frequency = "daily";
      string type = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = null;
      string sortOrder = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityHistoricalData result = securityApi.GetSecurityHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;) |  &nbsp;
 **frequency** | string| Return historical data in the given frequency | [optional] [default to daily] &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical date on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityHistoricalData**](ApiResponseSecurityHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityInsiderOwnership)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityInstitutionalOwnership)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityInstitutionalOwnership.md)

[//]: # (OPERATION:GetSecurityInsiderOwnership_v2)

[//]: # (ENDPOINT:/securities/{identifier}/institutional_ownership)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityinsiderownership)

<a name="getsecurityinsiderownership"></a>
## **GetSecurityInsiderOwnership**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityInsiderOwnership_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityInstitutionalOwnership GetSecurityInsiderOwnership (string identifier)

#### Institutional Ownership by Security

Returns a list of all institutional owners of a given security.

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
  public class GetSecurityInsiderOwnershipExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      
      ApiResponseSecurityInstitutionalOwnership result = securityApi.GetSecurityInsiderOwnership(identifier);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityInstitutionalOwnership**](ApiResponseSecurityInstitutionalOwnership.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityIntervalPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityIntervalPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityIntervalPrices.md)

[//]: # (OPERATION:GetSecurityIntervalPrices_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/intervals)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityintervalprices)

<a name="getsecurityintervalprices"></a>
## **GetSecurityIntervalPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityIntervalPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityIntervalPrices GetSecurityIntervalPrices (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, string intervalSize = null, int? pageSize = null, string nextPage = null)

#### Interval Stock Prices for Security

Return Open, High, Low, Close, and Volume for a particular interval for the Security with the given `identifier`

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
  public class GetSecurityIntervalPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string source = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      string startTime = null;
      DateTime? endDate = DateTime.Parse("2019-01-01");
      string endTime = null;
      string timezone = "UTC";
      string intervalSize = "1d";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityIntervalPrices result = securityApi.GetSecurityIntervalPrices(identifier, source, startDate, startTime, endDate, endTime, timezone, intervalSize, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **source** | string| Return intervals from the specified data source | [optional]  &nbsp;
 **startDate** | DateTime?| Return intervals starting at the specified date | [optional]  &nbsp;
 **startTime** | string| Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm&#39; format, UTC timezone) | [optional]  &nbsp;
 **endDate** | DateTime?| Return intervals stopping at the specified date | [optional]  &nbsp;
 **endTime** | string| Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm&#39; format, UTC timezone) | [optional]  &nbsp;
 **timezone** | string| Returns trading times in this timezone | [optional] [default to UTC] &nbsp;
 **intervalSize** | string| The interval for which to return stock prices | [optional] [default to 1d] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityIntervalPrices**](ApiResponseSecurityIntervalPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityIntradayPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityIntradayPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityIntradayPrices.md)

[//]: # (OPERATION:GetSecurityIntradayPrices_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/intraday)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityintradayprices)

<a name="getsecurityintradayprices"></a>
## **GetSecurityIntradayPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityIntradayPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityIntradayPrices GetSecurityIntradayPrices (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)

#### Intraday Stock Prices for Security

Return intraday stock prices for the Security with the given `identifier`

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
  public class GetSecurityIntradayPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string source = null;
      DateTime? startDate = DateTime.Parse("2018-01-01");
      string startTime = null;
      DateTime? endDate = DateTime.Parse("2019-01-01");
      string endTime = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityIntradayPrices result = securityApi.GetSecurityIntradayPrices(identifier, source, startDate, startTime, endDate, endTime, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **source** | string| Return intraday prices from the specified data source | [optional]  &nbsp;
 **startDate** | DateTime?| Return intraday prices starting at the specified date | [optional]  &nbsp;
 **startTime** | string| Return intraday prices starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm&#39; format, UTC timezone) | [optional]  &nbsp;
 **endDate** | DateTime?| Return intraday prices stopping at the specified date | [optional]  &nbsp;
 **endTime** | string| Return intraday prices stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm&#39; format, UTC timezone) | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityIntradayPrices**](ApiResponseSecurityIntradayPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityLatestDividendRecord)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.DividendRecord)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:DividendRecord.md)

[//]: # (OPERATION:GetSecurityLatestDividendRecord_v2)

[//]: # (ENDPOINT:/securities/{identifier}/dividends/latest)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritylatestdividendrecord)

<a name="getsecuritylatestdividendrecord"></a>
## **GetSecurityLatestDividendRecord**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityLatestDividendRecord_v2)

[//]: # (START_OVERVIEW)

> DividendRecord GetSecurityLatestDividendRecord (string identifier)

#### Latest Dividend Record for Security

Returns the latest available dividend information for the Security with the given `identifier`

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
  public class GetSecurityLatestDividendRecordExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      
      DividendRecord result = securityApi.GetSecurityLatestDividendRecord(identifier);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**DividendRecord**](DividendRecord.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityLatestEarningsRecord)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.EarningsRecord)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:EarningsRecord.md)

[//]: # (OPERATION:GetSecurityLatestEarningsRecord_v2)

[//]: # (ENDPOINT:/securities/{identifier}/earnings/latest)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritylatestearningsrecord)

<a name="getsecuritylatestearningsrecord"></a>
## **GetSecurityLatestEarningsRecord**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityLatestEarningsRecord_v2)

[//]: # (START_OVERVIEW)

> EarningsRecord GetSecurityLatestEarningsRecord (string identifier)

#### Latest Earnings Record for Security

Returns latest available earnings information for the Security with the given `identifier`

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
  public class GetSecurityLatestEarningsRecordExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      
      EarningsRecord result = securityApi.GetSecurityLatestEarningsRecord(identifier);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**EarningsRecord**](EarningsRecord.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsAdi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityAccumulationDistributionIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityAccumulationDistributionIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsAdi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/adi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsadi)

<a name="getsecuritypricetechnicalsadi"></a>
## **GetSecurityPriceTechnicalsAdi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsAdi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityAccumulationDistributionIndex GetSecurityPriceTechnicalsAdi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Accumulation/Distribution Index

Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsAdiExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityAccumulationDistributionIndex result = securityApi.GetSecurityPriceTechnicalsAdi(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityAccumulationDistributionIndex**](ApiResponseSecurityAccumulationDistributionIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsAdtv)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityAverageDailyTradingVolume)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityAverageDailyTradingVolume.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsAdtv_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/adtv)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsadtv)

<a name="getsecuritypricetechnicalsadtv"></a>
## **GetSecurityPriceTechnicalsAdtv**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsAdtv_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityAverageDailyTradingVolume GetSecurityPriceTechnicalsAdtv (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Average Daily Trading Volume

Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsAdtvExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 22;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityAverageDailyTradingVolume result = securityApi.GetSecurityPriceTechnicalsAdtv(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Average Daily Trading Volume | [optional] [default to 22] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityAverageDailyTradingVolume**](ApiResponseSecurityAverageDailyTradingVolume.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsAdx)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityAverageDirectionalIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityAverageDirectionalIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsAdx_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/adx)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsadx)

<a name="getsecuritypricetechnicalsadx"></a>
## **GetSecurityPriceTechnicalsAdx**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsAdx_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityAverageDirectionalIndex GetSecurityPriceTechnicalsAdx (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Average Directional Index

Returns the Average Directional Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsAdxExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityAverageDirectionalIndex result = securityApi.GetSecurityPriceTechnicalsAdx(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Average Directional Index | [optional] [default to 14] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityAverageDirectionalIndex**](ApiResponseSecurityAverageDirectionalIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsAo)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityAwesomeOscillator)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityAwesomeOscillator.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsAo_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/ao)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsao)

<a name="getsecuritypricetechnicalsao"></a>
## **GetSecurityPriceTechnicalsAo**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsAo_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityAwesomeOscillator GetSecurityPriceTechnicalsAo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Awesome Oscillator

Returns the Awesome Oscillator values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsAoExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? shortPeriod = 5;
      int? longPeriod = 34;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityAwesomeOscillator result = securityApi.GetSecurityPriceTechnicalsAo(identifier, shortPeriod, longPeriod, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **shortPeriod** | int?| The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator | [optional] [default to 5] &nbsp;
 **longPeriod** | int?| The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator | [optional] [default to 34] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityAwesomeOscillator**](ApiResponseSecurityAwesomeOscillator.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsAtr)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityAverageTrueRange)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityAverageTrueRange.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsAtr_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/atr)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsatr)

<a name="getsecuritypricetechnicalsatr"></a>
## **GetSecurityPriceTechnicalsAtr**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsAtr_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityAverageTrueRange GetSecurityPriceTechnicalsAtr (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Average True Range

Returns the Average True Range values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsAtrExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityAverageTrueRange result = securityApi.GetSecurityPriceTechnicalsAtr(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Average True Range | [optional] [default to 14] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityAverageTrueRange**](ApiResponseSecurityAverageTrueRange.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsBb)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityBollingerBands)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityBollingerBands.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsBb_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/bb)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsbb)

<a name="getsecuritypricetechnicalsbb"></a>
## **GetSecurityPriceTechnicalsBb**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsBb_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityBollingerBands GetSecurityPriceTechnicalsBb (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Bollinger Bands

Returns the Bollinger Bands values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsBbExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      float? standardDeviations = 2.0f;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityBollingerBands result = securityApi.GetSecurityPriceTechnicalsBb(identifier, period, standardDeviations, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Bollinger Bands | [optional] [default to 20] &nbsp;
 **standardDeviations** | float?| The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands | [optional] [default to 2.0] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Bollinger Bands | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityBollingerBands**](ApiResponseSecurityBollingerBands.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsCci)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityCommodityChannelIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityCommodityChannelIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsCci_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/cci)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalscci)

<a name="getsecuritypricetechnicalscci"></a>
## **GetSecurityPriceTechnicalsCci**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsCci_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityCommodityChannelIndex GetSecurityPriceTechnicalsCci (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Commodity Channel Index

Returns the Commodity Channel Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsCciExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      float? constant = 0.015f;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityCommodityChannelIndex result = securityApi.GetSecurityPriceTechnicalsCci(identifier, period, constant, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Commodity Channel Index | [optional] [default to 20] &nbsp;
 **constant** | float?| The number of observations, per period, to calculate Commodity Channel Index | [optional] [default to 0.015] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityCommodityChannelIndex**](ApiResponseSecurityCommodityChannelIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsCmf)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityChaikinMoneyFlow)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityChaikinMoneyFlow.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsCmf_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/cmf)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalscmf)

<a name="getsecuritypricetechnicalscmf"></a>
## **GetSecurityPriceTechnicalsCmf**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsCmf_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityChaikinMoneyFlow GetSecurityPriceTechnicalsCmf (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Chaikin Money Flow

Returns the Chaikin Money Flow values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsCmfExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityChaikinMoneyFlow result = securityApi.GetSecurityPriceTechnicalsCmf(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Chaikin Money Flow | [optional] [default to 20] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityChaikinMoneyFlow**](ApiResponseSecurityChaikinMoneyFlow.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsDc)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityDonchianChannel)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityDonchianChannel.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsDc_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/dc)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsdc)

<a name="getsecuritypricetechnicalsdc"></a>
## **GetSecurityPriceTechnicalsDc**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsDc_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityDonchianChannel GetSecurityPriceTechnicalsDc (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Donchian Channel

Returns the Donchian Channel values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsDcExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityDonchianChannel result = securityApi.GetSecurityPriceTechnicalsDc(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Donchian Channel | [optional] [default to 20] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Donchian Channel | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityDonchianChannel**](ApiResponseSecurityDonchianChannel.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsDpo)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityDetrendedPriceOscillator)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityDetrendedPriceOscillator.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsDpo_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/dpo)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsdpo)

<a name="getsecuritypricetechnicalsdpo"></a>
## **GetSecurityPriceTechnicalsDpo**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsDpo_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityDetrendedPriceOscillator GetSecurityPriceTechnicalsDpo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Detrended Price Oscillator

Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsDpoExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityDetrendedPriceOscillator result = securityApi.GetSecurityPriceTechnicalsDpo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Detrended Price Oscillator | [optional] [default to 20] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Detrended Price Oscillator | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityDetrendedPriceOscillator**](ApiResponseSecurityDetrendedPriceOscillator.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsEom)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityEaseOfMovement)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityEaseOfMovement.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsEom_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/eom)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalseom)

<a name="getsecuritypricetechnicalseom"></a>
## **GetSecurityPriceTechnicalsEom**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsEom_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityEaseOfMovement GetSecurityPriceTechnicalsEom (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Ease of Movement

Returns the Ease of Movement values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsEomExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityEaseOfMovement result = securityApi.GetSecurityPriceTechnicalsEom(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Ease of Movement | [optional] [default to 20] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityEaseOfMovement**](ApiResponseSecurityEaseOfMovement.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsFi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityForceIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityForceIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsFi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/fi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsfi)

<a name="getsecuritypricetechnicalsfi"></a>
## **GetSecurityPriceTechnicalsFi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsFi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityForceIndex GetSecurityPriceTechnicalsFi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Force Index

Returns the Force Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsFiExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityForceIndex result = securityApi.GetSecurityPriceTechnicalsFi(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityForceIndex**](ApiResponseSecurityForceIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsIchimoku)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityIchimokuKinkoHyo)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityIchimokuKinkoHyo.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsIchimoku_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/ichimoku)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsichimoku)

<a name="getsecuritypricetechnicalsichimoku"></a>
## **GetSecurityPriceTechnicalsIchimoku**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsIchimoku_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityIchimokuKinkoHyo GetSecurityPriceTechnicalsIchimoku (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Ichimoku Kinko Hyo

Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsIchimokuExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? lowPeriod = 9;
      int? mediumPeriod = 26;
      int? highPeriod = 52;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityIchimokuKinkoHyo result = securityApi.GetSecurityPriceTechnicalsIchimoku(identifier, lowPeriod, mediumPeriod, highPeriod, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **lowPeriod** | int?| The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo | [optional] [default to 9] &nbsp;
 **mediumPeriod** | int?| The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo | [optional] [default to 26] &nbsp;
 **highPeriod** | int?| The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo | [optional] [default to 52] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityIchimokuKinkoHyo**](ApiResponseSecurityIchimokuKinkoHyo.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsKc)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityKeltnerChannel)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityKeltnerChannel.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsKc_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/kc)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalskc)

<a name="getsecuritypricetechnicalskc"></a>
## **GetSecurityPriceTechnicalsKc**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsKc_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityKeltnerChannel GetSecurityPriceTechnicalsKc (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Keltner Channel

Returns the Keltner Channel values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsKcExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 10;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityKeltnerChannel result = securityApi.GetSecurityPriceTechnicalsKc(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Kelter Channel | [optional] [default to 10] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityKeltnerChannel**](ApiResponseSecurityKeltnerChannel.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsKst)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityKnowSureThing)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityKnowSureThing.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsKst_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/kst)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalskst)

<a name="getsecuritypricetechnicalskst"></a>
## **GetSecurityPriceTechnicalsKst**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsKst_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityKnowSureThing GetSecurityPriceTechnicalsKst (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Know Sure Thing

Returns the Know Sure Thing values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsKstExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? roc1 = 10;
      int? roc2 = 15;
      int? roc3 = 20;
      int? roc4 = 30;
      int? sma1 = 10;
      int? sma2 = 10;
      int? sma3 = 10;
      int? sma4 = 15;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityKnowSureThing result = securityApi.GetSecurityPriceTechnicalsKst(identifier, roc1, roc2, roc3, roc4, sma1, sma2, sma3, sma4, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **roc1** | int?| The number of observations, per period, to calculate the rate-of-change for RCMA1 | [optional] [default to 10] &nbsp;
 **roc2** | int?| The number of observations, per period, to calculate the rate-of-change for RCMA2 | [optional] [default to 15] &nbsp;
 **roc3** | int?| The number of observations, per period, to calculate the rate-of-change for RCMA3 | [optional] [default to 20] &nbsp;
 **roc4** | int?| The number of observations, per period, to calculate the rate-of-change for RCMA4 | [optional] [default to 30] &nbsp;
 **sma1** | int?| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 | [optional] [default to 10] &nbsp;
 **sma2** | int?| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 | [optional] [default to 10] &nbsp;
 **sma3** | int?| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 | [optional] [default to 10] &nbsp;
 **sma4** | int?| The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 | [optional] [default to 15] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Know Sure Thing | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityKnowSureThing**](ApiResponseSecurityKnowSureThing.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsMacd)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityMovingAverageConvergenceDivergence)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityMovingAverageConvergenceDivergence.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsMacd_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/macd)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsmacd)

<a name="getsecuritypricetechnicalsmacd"></a>
## **GetSecurityPriceTechnicalsMacd**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsMacd_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityMovingAverageConvergenceDivergence GetSecurityPriceTechnicalsMacd (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Moving Average Convergence Divergence

Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsMacdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? fastPeriod = 12;
      int? slowPeriod = 26;
      int? signalPeriod = 9;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityMovingAverageConvergenceDivergence result = securityApi.GetSecurityPriceTechnicalsMacd(identifier, fastPeriod, slowPeriod, signalPeriod, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **fastPeriod** | int?| The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence | [optional] [default to 12] &nbsp;
 **slowPeriod** | int?| The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence | [optional] [default to 26] &nbsp;
 **signalPeriod** | int?| The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence | [optional] [default to 9] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Moving Average Convergence Divergence | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityMovingAverageConvergenceDivergence**](ApiResponseSecurityMovingAverageConvergenceDivergence.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsMfi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityMoneyFlowIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityMoneyFlowIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsMfi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/mfi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsmfi)

<a name="getsecuritypricetechnicalsmfi"></a>
## **GetSecurityPriceTechnicalsMfi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsMfi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityMoneyFlowIndex GetSecurityPriceTechnicalsMfi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Money Flow Index

Returns the Money Flow Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsMfiExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityMoneyFlowIndex result = securityApi.GetSecurityPriceTechnicalsMfi(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Money Flow Index | [optional] [default to 14] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityMoneyFlowIndex**](ApiResponseSecurityMoneyFlowIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsMi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityMassIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityMassIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsMi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/mi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsmi)

<a name="getsecuritypricetechnicalsmi"></a>
## **GetSecurityPriceTechnicalsMi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsMi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityMassIndex GetSecurityPriceTechnicalsMi (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Mass Index

Returns the Mass Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsMiExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? emaPeriod = 9;
      int? sumPeriod = 25;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityMassIndex result = securityApi.GetSecurityPriceTechnicalsMi(identifier, emaPeriod, sumPeriod, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **emaPeriod** | int?| The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index | [optional] [default to 9] &nbsp;
 **sumPeriod** | int?| The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index | [optional] [default to 25] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityMassIndex**](ApiResponseSecurityMassIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsNvi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityNegativeVolumeIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityNegativeVolumeIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsNvi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/nvi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsnvi)

<a name="getsecuritypricetechnicalsnvi"></a>
## **GetSecurityPriceTechnicalsNvi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsNvi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityNegativeVolumeIndex GetSecurityPriceTechnicalsNvi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Negative Volume Index

Returns the Negative Volume Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsNviExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityNegativeVolumeIndex result = securityApi.GetSecurityPriceTechnicalsNvi(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityNegativeVolumeIndex**](ApiResponseSecurityNegativeVolumeIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsObv)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityOnBalanceVolume)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityOnBalanceVolume.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsObv_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/obv)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsobv)

<a name="getsecuritypricetechnicalsobv"></a>
## **GetSecurityPriceTechnicalsObv**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsObv_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityOnBalanceVolume GetSecurityPriceTechnicalsObv (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### On-balance Volume

Returns the On-balance Volume values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsObvExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityOnBalanceVolume result = securityApi.GetSecurityPriceTechnicalsObv(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityOnBalanceVolume**](ApiResponseSecurityOnBalanceVolume.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsObvMean)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityOnBalanceVolumeMean)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityOnBalanceVolumeMean.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsObvMean_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/obv_mean)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsobvmean)

<a name="getsecuritypricetechnicalsobvmean"></a>
## **GetSecurityPriceTechnicalsObvMean**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsObvMean_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityOnBalanceVolumeMean GetSecurityPriceTechnicalsObvMean (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### On-balance Volume Mean

Returns the On-balance Volume Mean values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsObvMeanExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 10;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityOnBalanceVolumeMean result = securityApi.GetSecurityPriceTechnicalsObvMean(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate On-balance Volume Mean | [optional] [default to 10] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityOnBalanceVolumeMean**](ApiResponseSecurityOnBalanceVolumeMean.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsRsi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityRelativeStrengthIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityRelativeStrengthIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsRsi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/rsi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsrsi)

<a name="getsecuritypricetechnicalsrsi"></a>
## **GetSecurityPriceTechnicalsRsi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsRsi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityRelativeStrengthIndex GetSecurityPriceTechnicalsRsi (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Relative Strength Index

Returns the Relative Strength Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsRsiExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityRelativeStrengthIndex result = securityApi.GetSecurityPriceTechnicalsRsi(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Relative Strength Index | [optional] [default to 14] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Relative Strength Index | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityRelativeStrengthIndex**](ApiResponseSecurityRelativeStrengthIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsSma)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecuritySimpleMovingAverage)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecuritySimpleMovingAverage.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsSma_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/sma)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalssma)

<a name="getsecuritypricetechnicalssma"></a>
## **GetSecurityPriceTechnicalsSma**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsSma_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecuritySimpleMovingAverage GetSecurityPriceTechnicalsSma (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Simple Moving Average

Returns the Simple Moving Average values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsSmaExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 20;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecuritySimpleMovingAverage result = securityApi.GetSecurityPriceTechnicalsSma(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Simple Moving Average | [optional] [default to 20] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating Simple Moving Average | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecuritySimpleMovingAverage**](ApiResponseSecuritySimpleMovingAverage.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsSr)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityStochasticOscillator)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityStochasticOscillator.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsSr_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/sr)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalssr)

<a name="getsecuritypricetechnicalssr"></a>
## **GetSecurityPriceTechnicalsSr**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsSr_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityStochasticOscillator GetSecurityPriceTechnicalsSr (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Stochastic Oscillator

Returns the Stochastic Oscillator values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsSrExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      int? signalPeriod = 3;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityStochasticOscillator result = securityApi.GetSecurityPriceTechnicalsSr(identifier, period, signalPeriod, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate %K of Stochastic Oscillator | [optional] [default to 14] &nbsp;
 **signalPeriod** | int?| The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator | [optional] [default to 3] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityStochasticOscillator**](ApiResponseSecurityStochasticOscillator.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsTrix)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityTripleExponentialAverage)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityTripleExponentialAverage.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsTrix_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/trix)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalstrix)

<a name="getsecuritypricetechnicalstrix"></a>
## **GetSecurityPriceTechnicalsTrix**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsTrix_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityTripleExponentialAverage GetSecurityPriceTechnicalsTrix (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Triple Exponential Average

Returns the Simple Moving Average values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsTrixExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 15;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityTripleExponentialAverage result = securityApi.GetSecurityPriceTechnicalsTrix(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average | [optional] [default to 15] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityTripleExponentialAverage**](ApiResponseSecurityTripleExponentialAverage.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsTsi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityTrueStrengthIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityTrueStrengthIndex.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsTsi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/tsi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalstsi)

<a name="getsecuritypricetechnicalstsi"></a>
## **GetSecurityPriceTechnicalsTsi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsTsi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityTrueStrengthIndex GetSecurityPriceTechnicalsTsi (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### True Strength Index

Returns the True Strength Index values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsTsiExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? lowPeriod = 13;
      int? highPeriod = 25;
      string priceKey = "close";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityTrueStrengthIndex result = securityApi.GetSecurityPriceTechnicalsTsi(identifier, lowPeriod, highPeriod, priceKey, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **lowPeriod** | int?| The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index | [optional] [default to 13] &nbsp;
 **highPeriod** | int?| The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index | [optional] [default to 25] &nbsp;
 **priceKey** | string| The Stock Price field to use when calculating True Strength Index | [optional] [default to close] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityTrueStrengthIndex**](ApiResponseSecurityTrueStrengthIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsUo)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityUltimateOscillator)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityUltimateOscillator.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsUo_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/uo)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsuo)

<a name="getsecuritypricetechnicalsuo"></a>
## **GetSecurityPriceTechnicalsUo**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsUo_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityUltimateOscillator GetSecurityPriceTechnicalsUo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Ultimate Oscillator

Returns the Ultimate Oscillator values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsUoExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? shortPeriod = 7;
      int? mediumPeriod = 14;
      int? longPeriod = 28;
      float? shortWeight = 4.0f;
      float? mediumWeight = 2.0f;
      float? longWeight = 1.0f;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityUltimateOscillator result = securityApi.GetSecurityPriceTechnicalsUo(identifier, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **shortPeriod** | int?| The number of observations, per period, to calculate the short period for Ultimate Oscillator | [optional] [default to 7] &nbsp;
 **mediumPeriod** | int?| The number of observations, per period, to calculate the medium period for Ultimate Oscillator | [optional] [default to 14] &nbsp;
 **longPeriod** | int?| The number of observations, per period, to calculate the long period for Ultimate Oscillator | [optional] [default to 28] &nbsp;
 **shortWeight** | float?| The weight of short Buying Pressure average for Ultimate Oscillator | [optional] [default to 4.0] &nbsp;
 **mediumWeight** | float?| The weight of medium Buying Pressure average for Ultimate Oscillator | [optional] [default to 2.0] &nbsp;
 **longWeight** | float?| The weight of long Buying Pressure average for Ultimate Oscillator | [optional] [default to 1.0] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityUltimateOscillator**](ApiResponseSecurityUltimateOscillator.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsVi)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityVortexIndicator)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityVortexIndicator.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsVi_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/vi)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsvi)

<a name="getsecuritypricetechnicalsvi"></a>
## **GetSecurityPriceTechnicalsVi**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsVi_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityVortexIndicator GetSecurityPriceTechnicalsVi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Vortex Indicator

Returns the Vortex Indicator values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsViExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityVortexIndicator result = securityApi.GetSecurityPriceTechnicalsVi(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to calculate Vortex Indicator | [optional] [default to 14] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityVortexIndicator**](ApiResponseSecurityVortexIndicator.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsVpt)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityVolumePriceTrend)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityVolumePriceTrend.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsVpt_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/vpt)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsvpt)

<a name="getsecuritypricetechnicalsvpt"></a>
## **GetSecurityPriceTechnicalsVpt**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsVpt_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityVolumePriceTrend GetSecurityPriceTechnicalsVpt (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Volume-price Trend

Returns the Volume-price Trend values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsVptExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityVolumePriceTrend result = securityApi.GetSecurityPriceTechnicalsVpt(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityVolumePriceTrend**](ApiResponseSecurityVolumePriceTrend.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsVwap)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityVolumeWeightedAveragePrice)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityVolumeWeightedAveragePrice.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsVwap_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/vwap)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalsvwap)

<a name="getsecuritypricetechnicalsvwap"></a>
## **GetSecurityPriceTechnicalsVwap**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsVwap_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityVolumeWeightedAveragePrice GetSecurityPriceTechnicalsVwap (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Volume Weighted Average Price

Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsVwapExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityVolumeWeightedAveragePrice result = securityApi.GetSecurityPriceTechnicalsVwap(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityVolumeWeightedAveragePrice**](ApiResponseSecurityVolumeWeightedAveragePrice.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityPriceTechnicalsWr)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityWilliamsR)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityWilliamsR.md)

[//]: # (OPERATION:GetSecurityPriceTechnicalsWr_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/technicals/wr)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritypricetechnicalswr)

<a name="getsecuritypricetechnicalswr"></a>
## **GetSecurityPriceTechnicalsWr**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityPriceTechnicalsWr_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityWilliamsR GetSecurityPriceTechnicalsWr (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)

#### Williams %R

Returns the Williams %R values of Stock Prices for the Security with the given `identifier`

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
  public class GetSecurityPriceTechnicalsWrExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? period = 14;
      string startDate = "2018-01-01";
      string endDate = "2019-01-01";
      decimal? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityWilliamsR result = securityApi.GetSecurityPriceTechnicalsWr(identifier, period, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **period** | int?| The number of observations, per period, to look-back when calculating Williams %R | [optional] [default to 14] &nbsp;
 **startDate** | string| Return technical indicator values on or after the date | [optional]  &nbsp;
 **endDate** | string| Return technical indicator values on or before the date | [optional]  &nbsp;
 **pageSize** | decimal?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityWilliamsR**](ApiResponseSecurityWilliamsR.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityRealtimePrice)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.RealtimeStockPrice)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:RealtimeStockPrice.md)

[//]: # (OPERATION:GetSecurityRealtimePrice_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/realtime)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityrealtimeprice)

<a name="getsecurityrealtimeprice"></a>
## **GetSecurityRealtimePrice**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityRealtimePrice_v2)

[//]: # (START_OVERVIEW)

> RealtimeStockPrice GetSecurityRealtimePrice (string identifier, string source = null)

#### Realtime Stock Price for Security

Return the realtime stock price for the Security with the given `identifier`

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
  public class GetSecurityRealtimePriceExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string source = "bats";
      
      RealtimeStockPrice result = securityApi.GetSecurityRealtimePrice(identifier, source);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **source** | string| Return the realtime price from the specified data source. If no source is specified, the best source available is used. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**RealtimeStockPrice**](RealtimeStockPrice.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityStockPriceAdjustments)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityStockPriceAdjustments)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityStockPriceAdjustments.md)

[//]: # (OPERATION:GetSecurityStockPriceAdjustments_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices/adjustments)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritystockpriceadjustments)

<a name="getsecuritystockpriceadjustments"></a>
## **GetSecurityStockPriceAdjustments**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityStockPriceAdjustments_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityStockPriceAdjustments GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)

#### Stock Price Adjustments by Security

Returns stock price adjustments for the Security with the given `identifier`

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
  public class GetSecurityStockPriceAdjustmentsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = DateTime.Parse("2019-01-01");
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityStockPriceAdjustments result = securityApi.GetSecurityStockPriceAdjustments(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | DateTime?| Return price adjustments on or after the date | [optional]  &nbsp;
 **endDate** | DateTime?| Return price adjustments on or before the date | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityStockPriceAdjustments**](ApiResponseSecurityStockPriceAdjustments.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityStockPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityStockPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityStockPrices.md)

[//]: # (OPERATION:GetSecurityStockPrices_v2)

[//]: # (ENDPOINT:/securities/{identifier}/prices)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecuritystockprices)

<a name="getsecuritystockprices"></a>
## **GetSecurityStockPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityStockPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityStockPrices GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, int? pageSize = null, string nextPage = null)

#### Stock Prices by Security

Return end-of-day stock prices for the Security with the given `identifier`

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
  public class GetSecurityStockPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      DateTime? startDate = DateTime.Parse("2018-01-01");
      DateTime? endDate = DateTime.Parse("2019-01-01");
      string frequency = "daily";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityStockPrices result = securityApi.GetSecurityStockPrices(identifier, startDate, endDate, frequency, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | DateTime?| Return prices on or after the date | [optional]  &nbsp;
 **endDate** | DateTime?| Return prices on or before the date | [optional]  &nbsp;
 **frequency** | string| Return stock prices in the given frequency | [optional] [default to daily] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityStockPrices**](ApiResponseSecurityStockPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityZacksAnalystRatings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityZacksAnalystRatings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityZacksAnalystRatings.md)

[//]: # (OPERATION:GetSecurityZacksAnalystRatings_v2)

[//]: # (ENDPOINT:/securities/{identifier}/zacks/analyst_ratings)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityzacksanalystratings)

<a name="getsecurityzacksanalystratings"></a>
## **GetSecurityZacksAnalystRatings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityZacksAnalystRatings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityZacksAnalystRatings GetSecurityZacksAnalystRatings (string identifier, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null)

#### Zacks Analyst Ratings for Security

Returns buy, sell, and hold recommendations from analysts at brokerages for the Security with the given `identifier`. Zack’s storied research team aggregates and validates the ratings from professional analysts.

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
  public class GetSecurityZacksAnalystRatingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string startDate = null;
      string endDate = null;
      decimal? meanGreater = null;
      decimal? meanLess = null;
      int? strongBuysGreater = null;
      int? strongBuysLess = null;
      int? buysGreater = null;
      int? buysLess = null;
      int? holdsGreater = null;
      int? holdsLess = null;
      int? sellsGreater = null;
      int? sellsLess = null;
      int? strongSellsGreater = null;
      int? strongSellsLess = null;
      int? totalGreater = null;
      int? totalLess = null;
      int? pageSize = 100;
      
      ApiResponseSecurityZacksAnalystRatings result = securityApi.GetSecurityZacksAnalystRatings(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **startDate** | string| Limit ratings to those on or after this date | [optional]  &nbsp;
 **endDate** | string| Limit ratings to those on or before this date | [optional]  &nbsp;
 **meanGreater** | decimal?| Return only records with a mean (average) higher than this value | [optional]  &nbsp;
 **meanLess** | decimal?| Return only records with a mean (average) lower than this value | [optional]  &nbsp;
 **strongBuysGreater** | int?| Return only records with more than this many Strong Buy recommendations | [optional]  &nbsp;
 **strongBuysLess** | int?| Return only records with fewer than this many Strong Buy recommendations | [optional]  &nbsp;
 **buysGreater** | int?| Return only records with more than this many Buy recommendations | [optional]  &nbsp;
 **buysLess** | int?| Return only records with fewer than this many Buy recommendations | [optional]  &nbsp;
 **holdsGreater** | int?| Return only records with more than this many Hold recommendations | [optional]  &nbsp;
 **holdsLess** | int?| Return only records with fewer than this many Hold recommendations | [optional]  &nbsp;
 **sellsGreater** | int?| Return only records with more than this many Sell recommendations | [optional]  &nbsp;
 **sellsLess** | int?| Return only records with fewer than this many Sell recommendations | [optional]  &nbsp;
 **strongSellsGreater** | int?| Return only records with more than this many Strong Sell recommendations | [optional]  &nbsp;
 **strongSellsLess** | int?| Return only records with fewer than this many Strong Sell recommendations | [optional]  &nbsp;
 **totalGreater** | int?| Return only records with more than this many recommendations, regardless of type | [optional]  &nbsp;
 **totalLess** | int?| Return only records with fewer than this many recommendations, regardless of type | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityZacksAnalystRatings**](ApiResponseSecurityZacksAnalystRatings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityZacksAnalystRatingsSnapshot)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityZacksAnalystRatingsSnapshot)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityZacksAnalystRatingsSnapshot.md)

[//]: # (OPERATION:GetSecurityZacksAnalystRatingsSnapshot_v2)

[//]: # (ENDPOINT:/securities/{identifier}/zacks/analyst_ratings/snapshot)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityzacksanalystratingssnapshot)

<a name="getsecurityzacksanalystratingssnapshot"></a>
## **GetSecurityZacksAnalystRatingsSnapshot**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityZacksAnalystRatingsSnapshot_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityZacksAnalystRatingsSnapshot GetSecurityZacksAnalystRatingsSnapshot (string identifier, string date = null)

#### Zacks Analyst Ratings Snapshot

This database offers current and historical consensus analyst recommendation snapshots for over 5,000 US and Canadian listed companies.

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
  public class GetSecurityZacksAnalystRatingsSnapshotExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      string date = null;
      
      ApiResponseSecurityZacksAnalystRatingsSnapshot result = securityApi.GetSecurityZacksAnalystRatingsSnapshot(identifier, date);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **date** | string| Lookup a historical snapshot on the given date | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityZacksAnalystRatingsSnapshot**](ApiResponseSecurityZacksAnalystRatingsSnapshot.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityZacksEpsSurprises)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityZacksEPSSurprises)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityZacksEPSSurprises.md)

[//]: # (OPERATION:GetSecurityZacksEpsSurprises_v2)

[//]: # (ENDPOINT:/securities/{identifier}/zacks/eps_surprises)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityzacksepssurprises)

<a name="getsecurityzacksepssurprises"></a>
## **GetSecurityZacksEpsSurprises**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityZacksEpsSurprises_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityZacksEPSSurprises GetSecurityZacksEpsSurprises (string identifier, int? pageSize = null, string nextPage = null)

#### Zacks EPS Surprises for Security

Returns historical estimated and actual earnings, guidance, and announcement dates for a specified symbol.

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
  public class GetSecurityZacksEpsSurprisesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityZacksEPSSurprises result = securityApi.GetSecurityZacksEpsSurprises(identifier, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityZacksEPSSurprises**](ApiResponseSecurityZacksEPSSurprises.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:GetSecurityZacksSalesSurprises)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecurityZacksSalesSurprises)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecurityZacksSalesSurprises.md)

[//]: # (OPERATION:GetSecurityZacksSalesSurprises_v2)

[//]: # (ENDPOINT:/securities/{identifier}/zacks/sales_surprises)

[//]: # (DOCUMENT_LINK:SecurityApi.md#getsecurityzackssalessurprises)

<a name="getsecurityzackssalessurprises"></a>
## **GetSecurityZacksSalesSurprises**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSecurityZacksSalesSurprises_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecurityZacksSalesSurprises GetSecurityZacksSalesSurprises (string identifier, int? pageSize = null, string nextPage = null)

#### Zacks Sales Surprises for Security

This database returns historical estimated and actual sales, guidance, and announcement dates for a specified US or Canadian company.

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
  public class GetSecurityZacksSalesSurprisesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string identifier = "AAPL";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseSecurityZacksSalesSurprises result = securityApi.GetSecurityZacksSalesSurprises(identifier, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecurityZacksSalesSurprises**](ApiResponseSecurityZacksSalesSurprises.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:ScreenSecurities)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.List<SecurityScreenResult>)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:SecurityScreenResult.md)

[//]: # (OPERATION:ScreenSecurities_v2)

[//]: # (ENDPOINT:/securities/screen)

[//]: # (DOCUMENT_LINK:SecurityApi.md#screensecurities)

<a name="screensecurities"></a>
## **ScreenSecurities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/ScreenSecurities_v2)

[//]: # (START_OVERVIEW)

> List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null, int? pageSize = null)

#### Screen Securities

Screen Securities using complex logic. Use POST only. See <a href=\"https://docs.intrinio.com/documentation/screener_v2\" target=\"_blank\">screener documentation</a> for details on how to construct conditions.

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
  public class ScreenSecuritiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      var logic = new SecurityScreenGroup();
            
      var orderColumn = "marketcap";
      var orderDirection = "asc";
      var primaryOnly = false;
      var pageSize = 100;

      logic.Operator = "AND";

      var clauseOne = new SecurityScreenClause();
      clauseOne.Field = "marketcap";
      clauseOne.Operator = SecurityScreenClause.OperatorEnum.Gt;
      clauseOne.Value = "100000000";

      var clauseTwo = new SecurityScreenClause();
      clauseTwo.Field = "beta";
      clauseTwo.Operator = SecurityScreenClause.OperatorEnum.Lt;
      clauseTwo.Value = "5";

      List<SecurityScreenClause> clauses = new List<SecurityScreenClause>();
      clauses.Add(clauseOne);
      clauses.Add(clauseTwo);

      logic.Clauses = clauses;
      
      List<SecurityScreenResult> result = securityApi.ScreenSecurities(logic, orderColumn, orderDirection, primaryOnly, pageSize);
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
 **logic** | [**SecurityScreenGroup**](SecurityScreenGroup.md)| The logic to screen with, consisting of operators, clauses, and nested groups. &lt;/br&gt; See &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. | [optional]  &nbsp;
 **orderColumn** | string| Results returned sorted by this column | [optional]  &nbsp;
 **orderDirection** | string| Sort order to use with the order_column | [optional] [default to asc] &nbsp;
 **primaryOnly** | bool?| Return only primary securities | [optional] [default to false] &nbsp;
 **pageSize** | int?| The number of results to return. Maximum for this endpoint is 50000. | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**List<SecurityScreenResult>**](SecurityScreenResult.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.SecurityApi)

[//]: # (METHOD:SearchSecurities)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSecuritiesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSecuritiesSearch.md)

[//]: # (OPERATION:SearchSecurities_v2)

[//]: # (ENDPOINT:/securities/search)

[//]: # (DOCUMENT_LINK:SecurityApi.md#searchsecurities)

<a name="searchsecurities"></a>
## **SearchSecurities**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchSecurities_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSecuritiesSearch SearchSecurities (string query, int? pageSize = null)

#### Search Securities

Searches for Securities matching the text `query`

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
  public class SearchSecuritiesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var securityApi = new SecurityApi();
      
      string query = "Apple";
      int? pageSize = 100;
      
      ApiResponseSecuritiesSearch result = securityApi.SearchSecurities(query, pageSize);
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
 **query** | string|  |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSecuritiesSearch**](ApiResponseSecuritiesSearch.md)

[//]: # (END_OPERATION)


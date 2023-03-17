# Intrinio.SDK.Api.OptionsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllOptionsTickers**](OptionsApi.md#getalloptionstickers) | **GET** /options/tickers | Options Tickers
[**GetOptionExpirationsRealtime**](OptionsApi.md#getoptionexpirationsrealtime) | **GET** /options/expirations/{symbol}/realtime | Option Expirations Realtime
[**GetOptionStrikesRealtime**](OptionsApi.md#getoptionstrikesrealtime) | **GET** /options/strikes/{symbol}/{strike}/realtime | Option Strikes Realtime
[**GetOptions**](OptionsApi.md#getoptions) | **GET** /options/{symbol} | Options
[**GetOptionsBySymbolRealtime**](OptionsApi.md#getoptionsbysymbolrealtime) | **GET** /options/{symbol}/realtime | Options by Symbol Realtime
[**GetOptionsChain**](OptionsApi.md#getoptionschain) | **GET** /options/chain/{symbol}/{expiration} | Options Chain
[**GetOptionsChainEod**](OptionsApi.md#getoptionschaineod) | **GET** /options/chain/{symbol}/{expiration}/eod | Options Chain EOD
[**GetOptionsChainRealtime**](OptionsApi.md#getoptionschainrealtime) | **GET** /options/chain/{symbol}/{expiration}/realtime | Options Chain Realtime
[**GetOptionsExpirations**](OptionsApi.md#getoptionsexpirations) | **GET** /options/expirations/{symbol} | Options Expirations
[**GetOptionsIntervalByContract**](OptionsApi.md#getoptionsintervalbycontract) | **GET** /options/interval/{identifier} | Options Intervals By Contract
[**GetOptionsIntervalMovers**](OptionsApi.md#getoptionsintervalmovers) | **GET** /options/interval/movers | Options Intervals Movers
[**GetOptionsIntervalMoversChange**](OptionsApi.md#getoptionsintervalmoverschange) | **GET** /options/interval/movers/change | Options Intervals Movers By Change
[**GetOptionsIntervalMoversVolume**](OptionsApi.md#getoptionsintervalmoversvolume) | **GET** /options/interval/movers/volume | Options Intervals Movers By Volume
[**GetOptionsPrices**](OptionsApi.md#getoptionsprices) | **GET** /options/prices/{identifier} | Option Prices
[**GetOptionsPricesBatchRealtime**](OptionsApi.md#getoptionspricesbatchrealtime) | **POST** /options/prices/realtime/batch | Option Prices Batch Realtime
[**GetOptionsPricesEod**](OptionsApi.md#getoptionspriceseod) | **GET** /options/prices/{identifier}/eod | Option Prices EOD
[**GetOptionsPricesRealtime**](OptionsApi.md#getoptionspricesrealtime) | **GET** /options/prices/{identifier}/realtime | Option Prices Realtime
[**GetOptionsSnapshots**](OptionsApi.md#getoptionssnapshots) | **GET** /options/snapshots | Option Prices Realtime Snapshot
[**GetOptionsStatsRealtime**](OptionsApi.md#getoptionsstatsrealtime) | **GET** /options/prices/{identifier}/realtime/stats | Option Stats Realtime
[**GetUnusualActivity**](OptionsApi.md#getunusualactivity) | **GET** /options/unusual_activity/{symbol} | Options Unusual Activity
[**GetUnusualActivityIntraday**](OptionsApi.md#getunusualactivityintraday) | **GET** /options/unusual_activity/{symbol}/intraday | Options Unusual Activity Intraday
[**GetUnusualActivityUniversal**](OptionsApi.md#getunusualactivityuniversal) | **GET** /options/unusual_activity | Options Unusual Activity Universal
[**GetUnusualActivityUniversalIntraday**](OptionsApi.md#getunusualactivityuniversalintraday) | **GET** /options/unusual_activity/intraday | Options Unusual Activity Universal Intraday



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetAllOptionsTickers)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsTickers)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsTickers.md)

[//]: # (OPERATION:GetAllOptionsTickers_v2)

[//]: # (ENDPOINT:/options/tickers)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getalloptionstickers)

<a name="getalloptionstickers"></a>
## **GetAllOptionsTickers**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllOptionsTickers_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsTickers GetAllOptionsTickers ()

#### Options Tickers

Returns all tickers that have existing options contracts.

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
  public class GetAllOptionsTickersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      
      ApiResponseOptionsTickers result = optionsApi.GetAllOptionsTickers();
      Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)

This endpoint does not need any parameter.
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsTickers**](ApiResponseOptionsTickers.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionExpirationsRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsExpirations)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsExpirations.md)

[//]: # (OPERATION:GetOptionExpirationsRealtime_v2)

[//]: # (ENDPOINT:/options/expirations/{symbol}/realtime)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionexpirationsrealtime)

<a name="getoptionexpirationsrealtime"></a>
## **GetOptionExpirationsRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionExpirationsRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsExpirations GetOptionExpirationsRealtime (string symbol, string after = null, string before = null, string source = null)

#### Option Expirations Realtime

Returns a list of all current and upcoming expiration dates for a particular symbol.

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
  public class GetOptionExpirationsRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "MSFT";
      string after = "2022-01-01";
      string before = "2023-04-01";
      string source = null;
      
      ApiResponseOptionsExpirations result = optionsApi.GetOptionExpirationsRealtime(symbol, after, before, source);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **after** | string| Return option contract expiration dates after this date. | [optional]  &nbsp;
 **before** | string| Return option contract expiration dates before this date. | [optional]  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsExpirations**](ApiResponseOptionsExpirations.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionStrikesRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsChainRealtime)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsChainRealtime.md)

[//]: # (OPERATION:GetOptionStrikesRealtime_v2)

[//]: # (ENDPOINT:/options/strikes/{symbol}/{strike}/realtime)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionstrikesrealtime)

<a name="getoptionstrikesrealtime"></a>
## **GetOptionStrikesRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionStrikesRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsChainRealtime GetOptionStrikesRealtime (string symbol, decimal? strike)

#### Option Strikes Realtime

Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.

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
  public class GetOptionStrikesRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "MSFT";
      decimal? strike = 95;
      
      ApiResponseOptionsChainRealtime result = optionsApi.GetOptionStrikesRealtime(symbol, strike);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **strike** | decimal?| The strike price of the option contract. This will return options contracts with strike price equal to this price. |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsChainRealtime**](ApiResponseOptionsChainRealtime.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptions)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptions)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptions.md)

[//]: # (OPERATION:GetOptions_v2)

[//]: # (ENDPOINT:/options/{symbol})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptions)

<a name="getoptions"></a>
## **GetOptions**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptions_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptions GetOptions (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)

#### Options

Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.

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
  public class GetOptionsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "AAPL";
      string type = "put";
      decimal? strike = 170;
      decimal? strikeGreaterThan = 150;
      decimal? strikeLessThan = 190;
      string expiration = "2019-03-01";
      string expirationAfter = "2019-01-01";
      string expirationBefore = "2019-12-31";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseOptions result = optionsApi.GetOptions(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **type** | string| The option contract type. | [optional]  &nbsp;
 **strike** | decimal?| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **expiration** | string| The expiration date of the option contract. This will return options contracts with expiration dates on this date. | [optional]  &nbsp;
 **expirationAfter** | string| The expiration date of the option contract. This will return options contracts with expiration dates after this date. | [optional]  &nbsp;
 **expirationBefore** | string| The expiration date of the option contract. This will return options contracts with expiration dates before this date. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptions**](ApiResponseOptions.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsBySymbolRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsRealtime)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsRealtime.md)

[//]: # (OPERATION:GetOptionsBySymbolRealtime_v2)

[//]: # (ENDPOINT:/options/{symbol}/realtime)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsbysymbolrealtime)

<a name="getoptionsbysymbolrealtime"></a>
## **GetOptionsBySymbolRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsBySymbolRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsRealtime GetOptionsBySymbolRealtime (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null)

#### Options by Symbol Realtime

Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.

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
  public class GetOptionsBySymbolRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "AAPL";
      string type = "put";
      decimal? strike = 170;
      decimal? strikeGreaterThan = 150;
      decimal? strikeLessThan = 190;
      string expiration = "2022-04-16";
      string expirationAfter = "2022-01-01";
      string expirationBefore = "2023-12-31";
      string source = null;
      
      ApiResponseOptionsRealtime result = optionsApi.GetOptionsBySymbolRealtime(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, source);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **type** | string| The option contract type. | [optional]  &nbsp;
 **strike** | decimal?| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **expiration** | string| The expiration date of the option contract. This will return options contracts with expiration dates on this date. | [optional]  &nbsp;
 **expirationAfter** | string| The expiration date of the option contract. This will return options contracts with expiration dates after this date. | [optional]  &nbsp;
 **expirationBefore** | string| The expiration date of the option contract. This will return options contracts with expiration dates before this date. | [optional]  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsRealtime**](ApiResponseOptionsRealtime.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsChain)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsChain)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsChain.md)

[//]: # (OPERATION:GetOptionsChain_v2)

[//]: # (ENDPOINT:/options/chain/{symbol}/{expiration})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionschain)

<a name="getoptionschain"></a>
## **GetOptionsChain**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsChain_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)

#### Options Chain

Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.

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
  public class GetOptionsChainExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "MSFT";
      string expiration = "2019-04-05";
      DateTime? date = null;
      string type = null;
      decimal? strike = null;
      decimal? strikeGreaterThan = null;
      decimal? strikeLessThan = null;
      string moneyness = null;
      int? pageSize = null;
      
      ApiResponseOptionsChain result = optionsApi.GetOptionsChain(symbol, expiration, date, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **expiration** | string| The expiration date of the options contract |  &nbsp;
 **date** | DateTime?| The date of the option price. Returns option prices on this date. | [optional]  &nbsp;
 **type** | string| The option contract type. | [optional]  &nbsp;
 **strike** | decimal?| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **moneyness** | string| The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsChain**](ApiResponseOptionsChain.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsChainEod)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsChainEod)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsChainEod.md)

[//]: # (OPERATION:GetOptionsChainEod_v2)

[//]: # (ENDPOINT:/options/chain/{symbol}/{expiration}/eod)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionschaineod)

<a name="getoptionschaineod"></a>
## **GetOptionsChainEod**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsChainEod_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsChainEod GetOptionsChainEod (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null)

#### Options Chain EOD

Returns all EOD options contracts and their prices for the given symbol and expiration date.

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
  public class GetOptionsChainEodExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "AAPL";
      string expiration = "2023-01-20";
      string type = null;
      decimal? strike = null;
      decimal? strikeGreaterThan = null;
      decimal? strikeLessThan = null;
      DateTime? date = null;
      
      ApiResponseOptionsChainEod result = optionsApi.GetOptionsChainEod(symbol, expiration, type, strike, strikeGreaterThan, strikeLessThan, date);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **expiration** | string| The expiration date of the options contract |  &nbsp;
 **type** | string| The option contract type. | [optional]  &nbsp;
 **strike** | decimal?| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **date** | DateTime?| The the date to retrieve prices for | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsChainEod**](ApiResponseOptionsChainEod.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsChainRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsChainRealtime)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsChainRealtime.md)

[//]: # (OPERATION:GetOptionsChainRealtime_v2)

[//]: # (ENDPOINT:/options/chain/{symbol}/{expiration}/realtime)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionschainrealtime)

<a name="getoptionschainrealtime"></a>
## **GetOptionsChainRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsChainRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsChainRealtime GetOptionsChainRealtime (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null)

#### Options Chain Realtime

Returns a list of the latest National Best Bid & Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.

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
  public class GetOptionsChainRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "MSFT";
      string expiration = "2023-01-20";
      string source = null;
      string type = null;
      decimal? strike = null;
      decimal? strikeGreaterThan = null;
      decimal? strikeLessThan = null;
      decimal? volumeGreaterThan = null;
      decimal? volumeLessThan = null;
      decimal? openInterestGreaterThan = null;
      decimal? openInterestLessThan = null;
      string moneyness = null;
      
      ApiResponseOptionsChainRealtime result = optionsApi.GetOptionsChainRealtime(symbol, expiration, source, type, strike, strikeGreaterThan, strikeLessThan, volumeGreaterThan, volumeLessThan, openInterestGreaterThan, openInterestLessThan, moneyness);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **expiration** | string| The expiration date of the options contract |  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
 **type** | string| The option contract type. | [optional]  &nbsp;
 **strike** | decimal?| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | decimal?| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **volumeGreaterThan** | decimal?| The volume of the option contract. This will return options contracts with volumes greater than this amount. | [optional]  &nbsp;
 **volumeLessThan** | decimal?| The volume of the option contract. This will return options contracts with volumes less than this amout. | [optional]  &nbsp;
 **openInterestGreaterThan** | decimal?| The open interest of the option contract. This will return options contracts with open interest greater than this amount. | [optional]  &nbsp;
 **openInterestLessThan** | decimal?| The open interest of the option contract. This will return options contracts with open interest less than this amount. | [optional]  &nbsp;
 **moneyness** | string| The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsChainRealtime**](ApiResponseOptionsChainRealtime.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsExpirations)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsExpirations)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsExpirations.md)

[//]: # (OPERATION:GetOptionsExpirations_v2)

[//]: # (ENDPOINT:/options/expirations/{symbol})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsexpirations)

<a name="getoptionsexpirations"></a>
## **GetOptionsExpirations**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsExpirations_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsExpirations GetOptionsExpirations (string symbol, string after = null, string before = null)

#### Options Expirations

Returns a list of all current and upcoming option contract expiration dates for a particular symbol.

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
  public class GetOptionsExpirationsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "MSFT";
      string after = "2019-01-01";
      string before = "2019-12-31";
      
      ApiResponseOptionsExpirations result = optionsApi.GetOptionsExpirations(symbol, after, before);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **after** | string| Return option contract expiration dates after this date. | [optional]  &nbsp;
 **before** | string| Return option contract expiration dates before this date. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsExpirations**](ApiResponseOptionsExpirations.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsIntervalByContract)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.OptionIntervalsResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:OptionIntervalsResult.md)

[//]: # (OPERATION:GetOptionsIntervalByContract_v2)

[//]: # (ENDPOINT:/options/interval/{identifier})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsintervalbycontract)

<a name="getoptionsintervalbycontract"></a>
## **GetOptionsIntervalByContract**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsIntervalByContract_v2)

[//]: # (START_OVERVIEW)

> OptionIntervalsResult GetOptionsIntervalByContract (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null)

#### Options Intervals By Contract

Returns a list of interval data points for a contract.

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
  public class GetOptionsIntervalByContractExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string identifier = "SPY___230103P00380000";
      string intervalSize = "5m";
      string source = null;
      int? pageSize = 100;
      DateTime? endTime = null;
      
      OptionIntervalsResult result = optionsApi.GetOptionsIntervalByContract(identifier, intervalSize, source, pageSize, endTime);
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
 **identifier** | string| The Intrinio ID or code of the options contract to request intervals for. |  &nbsp;
 **intervalSize** | string| The time length of the interval. |  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **endTime** | DateTime?| The inclusive UTC date and time the intervals end at. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**OptionIntervalsResult**](OptionIntervalsResult.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsIntervalMovers)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.OptionIntervalsMoversResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:OptionIntervalsMoversResult.md)

[//]: # (OPERATION:GetOptionsIntervalMovers_v2)

[//]: # (ENDPOINT:/options/interval/movers)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsintervalmovers)

<a name="getoptionsintervalmovers"></a>
## **GetOptionsIntervalMovers**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsIntervalMovers_v2)

[//]: # (START_OVERVIEW)

> OptionIntervalsMoversResult GetOptionsIntervalMovers (string source = null, DateTime? openTime = null)

#### Options Intervals Movers

Returns a list of intervals for the biggest movers over the last hour interval.

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
  public class GetOptionsIntervalMoversExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string source = null;
      DateTime? openTime = null;
      
      OptionIntervalsMoversResult result = optionsApi.GetOptionsIntervalMovers(source, openTime);
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
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
 **openTime** | DateTime?| The inclusive UTC date and time the interval opens at. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**OptionIntervalsMoversResult**](OptionIntervalsMoversResult.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsIntervalMoversChange)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.OptionIntervalsMoversResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:OptionIntervalsMoversResult.md)

[//]: # (OPERATION:GetOptionsIntervalMoversChange_v2)

[//]: # (ENDPOINT:/options/interval/movers/change)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsintervalmoverschange)

<a name="getoptionsintervalmoverschange"></a>
## **GetOptionsIntervalMoversChange**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsIntervalMoversChange_v2)

[//]: # (START_OVERVIEW)

> OptionIntervalsMoversResult GetOptionsIntervalMoversChange (string source = null, DateTime? openTime = null)

#### Options Intervals Movers By Change

Returns a list of intervals for the biggest movers by change over the last hour interval.

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
  public class GetOptionsIntervalMoversChangeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string source = null;
      DateTime? openTime = null;
      
      OptionIntervalsMoversResult result = optionsApi.GetOptionsIntervalMoversChange(source, openTime);
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
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
 **openTime** | DateTime?| The inclusive UTC date and time the interval opens at. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**OptionIntervalsMoversResult**](OptionIntervalsMoversResult.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsIntervalMoversVolume)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.OptionIntervalsMoversResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:OptionIntervalsMoversResult.md)

[//]: # (OPERATION:GetOptionsIntervalMoversVolume_v2)

[//]: # (ENDPOINT:/options/interval/movers/volume)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsintervalmoversvolume)

<a name="getoptionsintervalmoversvolume"></a>
## **GetOptionsIntervalMoversVolume**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsIntervalMoversVolume_v2)

[//]: # (START_OVERVIEW)

> OptionIntervalsMoversResult GetOptionsIntervalMoversVolume (string source = null, DateTime? openTime = null)

#### Options Intervals Movers By Volume

Returns a list of intervals for the biggest movers by volume over the last hour interval.

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
  public class GetOptionsIntervalMoversVolumeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string source = null;
      DateTime? openTime = null;
      
      OptionIntervalsMoversResult result = optionsApi.GetOptionsIntervalMoversVolume(source, openTime);
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
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
 **openTime** | DateTime?| The inclusive UTC date and time the interval opens at. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**OptionIntervalsMoversResult**](OptionIntervalsMoversResult.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionPrices.md)

[//]: # (OPERATION:GetOptionsPrices_v2)

[//]: # (ENDPOINT:/options/prices/{identifier})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsprices)

<a name="getoptionsprices"></a>
## **GetOptionsPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsPrices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionPrices GetOptionsPrices (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)

#### Option Prices

Returns all price data from inception to expiration for a particular contract.

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
  public class GetOptionsPricesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string identifier = "MSFT190405C00118000";
      string startDate = "2019-01-01";
      string endDate = "2019-12-31";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseOptionPrices result = optionsApi.GetOptionsPrices(identifier, startDate, endDate, pageSize, nextPage);
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
 **identifier** | string| The Intrinio ID or code of the options contract to request prices for. |  &nbsp;
 **startDate** | string| Return option contract prices on or after this date. | [optional]  &nbsp;
 **endDate** | string| Return option contract prices on or before this date. | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionPrices**](ApiResponseOptionPrices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsPricesBatchRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsPricesBatchRealtime)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsPricesBatchRealtime.md)

[//]: # (OPERATION:GetOptionsPricesBatchRealtime_v2)

[//]: # (ENDPOINT:/options/prices/realtime/batch)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionspricesbatchrealtime)

<a name="getoptionspricesbatchrealtime"></a>
## **GetOptionsPricesBatchRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsPricesBatchRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsPricesBatchRealtime GetOptionsPricesBatchRealtime (OptionContractsList body, string source = null)

#### Option Prices Batch Realtime

Returns a list of latest price data for up to 250 option contracts per request.

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
  public class GetOptionsPricesBatchRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string source = null;
      
      var body = new OptionContractsList();
      body.Contracts = new List<string>(new string[] { "A220121P00055000", "A220121P00057500", "A220121P00060000" });
      ApiResponseOptionsPricesBatchRealtime result = optionsApi.GetOptionsPricesBatchRealtime(body, source);
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
 **body** | [**OptionContractsList**](OptionContractsList.md)| The contract symbols for which to return options prices for. |  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsPricesBatchRealtime**](ApiResponseOptionsPricesBatchRealtime.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsPricesEod)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsPricesEod)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsPricesEod.md)

[//]: # (OPERATION:GetOptionsPricesEod_v2)

[//]: # (ENDPOINT:/options/prices/{identifier}/eod)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionspriceseod)

<a name="getoptionspriceseod"></a>
## **GetOptionsPricesEod**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsPricesEod_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsPricesEod GetOptionsPricesEod (string identifier)

#### Option Prices EOD

Returns all option prices for a given option contract identifier.

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
  public class GetOptionsPricesEodExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string identifier = "AAPL230616P00190000";
      
      ApiResponseOptionsPricesEod result = optionsApi.GetOptionsPricesEod(identifier);
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
 **identifier** | string| The Intrinio ID or code of the options contract to request prices for. |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsPricesEod**](ApiResponseOptionsPricesEod.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsPricesRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsPriceRealtime)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsPriceRealtime.md)

[//]: # (OPERATION:GetOptionsPricesRealtime_v2)

[//]: # (ENDPOINT:/options/prices/{identifier}/realtime)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionspricesrealtime)

<a name="getoptionspricesrealtime"></a>
## **GetOptionsPricesRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsPricesRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsPriceRealtime GetOptionsPricesRealtime (string identifier, string source = null)

#### Option Prices Realtime

Returns all option prices for a given option contract identifier.

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
  public class GetOptionsPricesRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string identifier = "AAPL230120C00090000";
      string source = null;
      
      ApiResponseOptionsPriceRealtime result = optionsApi.GetOptionsPricesRealtime(identifier, source);
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
 **identifier** | string| The Intrinio ID or code of the options contract to request prices for. |  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsPriceRealtime**](ApiResponseOptionsPriceRealtime.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsSnapshots)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.OptionSnapshotsResult)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:OptionSnapshotsResult.md)

[//]: # (OPERATION:GetOptionsSnapshots_v2)

[//]: # (ENDPOINT:/options/snapshots)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionssnapshots)

<a name="getoptionssnapshots"></a>
## **GetOptionsSnapshots**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsSnapshots_v2)

[//]: # (START_OVERVIEW)

> OptionSnapshotsResult GetOptionsSnapshots (string source = null, DateTime? atDatetime = null)

#### Option Prices Realtime Snapshot

Returns all options snapshots for the queried interval with links to download.

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
  public class GetOptionsSnapshotsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string source = null;
      DateTime? atDatetime = null;
      
      OptionSnapshotsResult result = optionsApi.GetOptionsSnapshots(source, atDatetime);
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
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
 **atDatetime** | DateTime?| The UTC date and time (with url-encoded spaces) the snapshot will cover. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**OptionSnapshotsResult**](OptionSnapshotsResult.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsStatsRealtime)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsStatsRealtime)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsStatsRealtime.md)

[//]: # (OPERATION:GetOptionsStatsRealtime_v2)

[//]: # (ENDPOINT:/options/prices/{identifier}/realtime/stats)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsstatsrealtime)

<a name="getoptionsstatsrealtime"></a>
## **GetOptionsStatsRealtime**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetOptionsStatsRealtime_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsStatsRealtime GetOptionsStatsRealtime (string identifier, string source = null)

#### Option Stats Realtime

Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.

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
  public class GetOptionsStatsRealtimeExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string identifier = "AAPL230120C00090000";
      string source = null;
      
      ApiResponseOptionsStatsRealtime result = optionsApi.GetOptionsStatsRealtime(identifier, source);
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
 **identifier** | string| The Intrinio ID or code of the options contract to request prices for. |  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsStatsRealtime**](ApiResponseOptionsStatsRealtime.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetUnusualActivity)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsUnusualActivity)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsUnusualActivity.md)

[//]: # (OPERATION:GetUnusualActivity_v2)

[//]: # (ENDPOINT:/options/unusual_activity/{symbol})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getunusualactivity)

<a name="getunusualactivity"></a>
## **GetUnusualActivity**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetUnusualActivity_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsUnusualActivity GetUnusualActivity (string symbol, string source = null)

#### Options Unusual Activity

Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.

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
  public class GetUnusualActivityExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "AAPL";
      string source = null;
      
      ApiResponseOptionsUnusualActivity result = optionsApi.GetUnusualActivity(symbol, source);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsUnusualActivity**](ApiResponseOptionsUnusualActivity.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetUnusualActivityIntraday)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsUnusualActivity)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsUnusualActivity.md)

[//]: # (OPERATION:GetUnusualActivityIntraday_v2)

[//]: # (ENDPOINT:/options/unusual_activity/{symbol}/intraday)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getunusualactivityintraday)

<a name="getunusualactivityintraday"></a>
## **GetUnusualActivityIntraday**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetUnusualActivityIntraday_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsUnusualActivity GetUnusualActivityIntraday (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)

#### Options Unusual Activity Intraday

Returns unusual trades for a given identifier within the query parameters.

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
  public class GetUnusualActivityIntradayExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string symbol = "AAPL";
      string nextPage = null;
      int? pageSize = 100;
      string activityType = null;
      string sentiment = null;
      DateTime? startDate = DateTime.Parse("2022-02-01");
      DateTime? endDate = DateTime.Parse("2022-02-03");
      var minimumTotalValue = new Object();
      var maximumTotalValue = new Object();
      
      ApiResponseOptionsUnusualActivity result = optionsApi.GetUnusualActivityIntraday(symbol, nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
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
 **symbol** | string| The option symbol, corresponding to the underlying security. |  &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 1000] &nbsp;
 **activityType** | string| The unusual activity type to query for. | [optional]  &nbsp;
 **sentiment** | string| The sentiment type to query for. | [optional]  &nbsp;
 **startDate** | DateTime?| Return unusual activity on or after this date. | [optional]  &nbsp;
 **endDate** | DateTime?| Return unusual activity on or before this date. | [optional]  &nbsp;
 **minimumTotalValue** | [**Object**](Object.md)| The inclusive minimum total value for the unusual activity. | [optional]  &nbsp;
 **maximumTotalValue** | [**Object**](Object.md)| The inclusive maximum total value for the unusual activity. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsUnusualActivity**](ApiResponseOptionsUnusualActivity.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetUnusualActivityUniversal)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsUnusualActivity)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsUnusualActivity.md)

[//]: # (OPERATION:GetUnusualActivityUniversal_v2)

[//]: # (ENDPOINT:/options/unusual_activity)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getunusualactivityuniversal)

<a name="getunusualactivityuniversal"></a>
## **GetUnusualActivityUniversal**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetUnusualActivityUniversal_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsUnusualActivity GetUnusualActivityUniversal (string source = null)

#### Options Unusual Activity Universal

Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.

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
  public class GetUnusualActivityUniversalExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string source = null;
      
      ApiResponseOptionsUnusualActivity result = optionsApi.GetUnusualActivityUniversal(source);
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
 **source** | string| Realtime or 15-minute delayed contracts. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsUnusualActivity**](ApiResponseOptionsUnusualActivity.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetUnusualActivityUniversalIntraday)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseOptionsUnusualActivity)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsUnusualActivity.md)

[//]: # (OPERATION:GetUnusualActivityUniversalIntraday_v2)

[//]: # (ENDPOINT:/options/unusual_activity/intraday)

[//]: # (DOCUMENT_LINK:OptionsApi.md#getunusualactivityuniversalintraday)

<a name="getunusualactivityuniversalintraday"></a>
## **GetUnusualActivityUniversalIntraday**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetUnusualActivityUniversalIntraday_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsUnusualActivity GetUnusualActivityUniversalIntraday (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)

#### Options Unusual Activity Universal Intraday

Returns unusual trades for all underlying security symbols within the query parameters.

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
  public class GetUnusualActivityUniversalIntradayExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var optionsApi = new OptionsApi();
      
      string nextPage = null;
      int? pageSize = 100;
      string activityType = null;
      string sentiment = null;
      DateTime? startDate = DateTime.Parse("2022-02-01");
      DateTime? endDate = DateTime.Parse("2022-02-03");
      var minimumTotalValue = new Object();
      var maximumTotalValue = new Object();
      
      ApiResponseOptionsUnusualActivity result = optionsApi.GetUnusualActivityUniversalIntraday(nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
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
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 1000] &nbsp;
 **activityType** | string| The unusual activity type to query for. | [optional]  &nbsp;
 **sentiment** | string| The sentiment type to query for. | [optional]  &nbsp;
 **startDate** | DateTime?| Return unusual activity on or after this date. | [optional]  &nbsp;
 **endDate** | DateTime?| Return unusual activity on or before this date. | [optional]  &nbsp;
 **minimumTotalValue** | [**Object**](Object.md)| The inclusive minimum total value for the unusual activity. | [optional]  &nbsp;
 **maximumTotalValue** | [**Object**](Object.md)| The inclusive maximum total value for the unusual activity. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsUnusualActivity**](ApiResponseOptionsUnusualActivity.md)

[//]: # (END_OPERATION)


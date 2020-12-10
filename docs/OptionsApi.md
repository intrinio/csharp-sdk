# Intrinio.SDK.Api.OptionsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOptions**](OptionsApi.md#getoptions) | **GET** /options/{symbol} | Options
[**GetOptionsChain**](OptionsApi.md#getoptionschain) | **GET** /options/chain/{symbol}/{expiration} | Options Chain
[**GetOptionsChainRealtime**](OptionsApi.md#getoptionschainrealtime) | **GET** /options/chain/{symbol}/{expiration}/realtime | Options Chain Realtime
[**GetOptionsExpirations**](OptionsApi.md#getoptionsexpirations) | **GET** /options/expirations/{symbol} | Options Expirations
[**GetOptionsPrices**](OptionsApi.md#getoptionsprices) | **GET** /options/prices/{identifier} | Option Prices
[**GetOptionsPricesRealtime**](OptionsApi.md#getoptionspricesrealtime) | **GET** /options/prices/{identifier}/realtime | Option Prices Realtime
[**GetOptionsStatsRealtime**](OptionsApi.md#getoptionsstatsrealtime) | **GET** /options/prices/{identifier}/realtime/stats | Option Stats Realtime



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

Returns the master list of option contracts for a given symbol.

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

Returns all options contracts and their prices for the given symbol and expiration date.

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

Returns all realtime options contracts and their prices for the given symbol and expiration date.

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

Returns all option contract expiration dates for a given symbol.

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

Returns all option stats (greeks and implied volatility) and factors used to calculate them, for a given option contract identifier.

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


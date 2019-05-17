# Intrinio.SDK.Api.OptionsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOptions**](OptionsApi.md#getoptions) | **GET** /options/{symbol} | Options
[**GetOptionsChain**](OptionsApi.md#getoptionschain) | **GET** /options/chain/{symbol}/{expiration} | Options Chain
[**GetOptionsExpirations**](OptionsApi.md#getoptionsexpirations) | **GET** /options/expirations/{symbol} | Options Expirations
[**GetOptionsPrices**](OptionsApi.md#getoptionsprices) | **GET** /options/prices/{identifier} | Option Prices



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptions)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelApiResponseOptions)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptions.md)

[//]: # (OPERATION:GetOptions_v2)

[//]: # (ENDPOINT:/options/{symbol})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptions)

<a name="getoptions"></a>
## **GetOptions**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetOptions_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var optionsApi = new OptionsApi();
            var symbol = "MSFT";  // string | The option symbol, corresponding to the underlying security.
            var type = "put";  // string | The option contract type. (optional) 
            var strike = 170.0;  // decimal? | The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional) 
            var strikeGreaterThan = 190.0;  // decimal? | The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional) 
            var strikeLessThan = 150.0;  // decimal? | The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional) 
            var expiration = "2019-03-01";  // string | The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional) 
            var expirationAfter = "2019-01-01";  // string | The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional) 
            var expirationBefore = "2019-12-31";  // string | The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseOptions result = optionsApi.GetOptions(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptions: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The option symbol, corresponding to the underlying security. |  &nbsp;
 **type** | **string**| The option contract type. | [optional]  &nbsp;
 **strike** | **decimal?**| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **expiration** | **string**| The expiration date of the option contract. This will return options contracts with expiration dates on this date. | [optional]  &nbsp;
 **expirationAfter** | **string**| The expiration date of the option contract. This will return options contracts with expiration dates after this date. | [optional]  &nbsp;
 **expirationBefore** | **string**| The expiration date of the option contract. This will return options contracts with expiration dates before this date. | [optional]  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptions**](ApiResponseOptions.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsChain)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelApiResponseOptionsChain)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsChain.md)

[//]: # (OPERATION:GetOptionsChain_v2)

[//]: # (ENDPOINT:/options/chain/{symbol}/{expiration})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionschain)

<a name="getoptionschain"></a>
## **GetOptionsChain**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetOptionsChain_v2)

[//]: # (START_OVERVIEW)

> ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)

#### Options Chain

Returns all options contracts and their prices for the given symbol and expiration date.

[//]: # (END_OVERVIEW)

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
    public class GetOptionsChainExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var optionsApi = new OptionsApi();
            var symbol = "MSFT";  // string | The option symbol, corresponding to the underlying security.
            var expiration = "2019-03-06";  // string | The expiration date of the options contract
            var type = "put";  // string | The option contract type. (optional) 
            var strike = 170.0;  // decimal? | The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional) 
            var strikeGreaterThan = 190.0;  // decimal? | The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional) 
            var strikeLessThan = 150.0;  // decimal? | The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional) 
            var moneyness = "in_the_money";  // string | The moneyness of the options contracts to return. 'all' will return all options contracts. 'in_the_money' will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). 'out_of_they_money' will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). 'near_the_money' will return options contracts that are $0.50 or less away from being in the money. (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

            try
            {
                ApiResponseOptionsChain result = optionsApi.GetOptionsChain(symbol, expiration, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsChain: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The option symbol, corresponding to the underlying security. |  &nbsp;
 **expiration** | **string**| The expiration date of the options contract |  &nbsp;
 **type** | **string**| The option contract type. | [optional]  &nbsp;
 **strike** | **decimal?**| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional]  &nbsp;
 **strikeGreaterThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional]  &nbsp;
 **strikeLessThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional]  &nbsp;
 **moneyness** | **string**| The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. | [optional]  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsChain**](ApiResponseOptionsChain.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsExpirations)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelApiResponseOptionsExpirations)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionsExpirations.md)

[//]: # (OPERATION:GetOptionsExpirations_v2)

[//]: # (ENDPOINT:/options/expirations/{symbol})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsexpirations)

<a name="getoptionsexpirations"></a>
## **GetOptionsExpirations**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetOptionsExpirations_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetOptionsExpirationsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var optionsApi = new OptionsApi();
            var symbol = "MSFT";  // string | The option symbol, corresponding to the underlying security.
            var after = "2019-01-01";  // string | Return option contract expiration dates after this date. (optional) 
            var before = "2019-12-31";  // string | Return option contract expiration dates before this date. (optional) 

            try
            {
                ApiResponseOptionsExpirations result = optionsApi.GetOptionsExpirations(symbol, after, before);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsExpirations: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The option symbol, corresponding to the underlying security. |  &nbsp;
 **after** | **string**| Return option contract expiration dates after this date. | [optional]  &nbsp;
 **before** | **string**| Return option contract expiration dates before this date. | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionsExpirations**](ApiResponseOptionsExpirations.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.OptionsApi)

[//]: # (METHOD:GetOptionsPrices)

[//]: # (RETURN_TYPE:Intrinio.SDK.ModelApiResponseOptionPrices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseOptionPrices.md)

[//]: # (OPERATION:GetOptionsPrices_v2)

[//]: # (ENDPOINT:/options/prices/{identifier})

[//]: # (DOCUMENT_LINK:OptionsApi.md#getoptionsprices)

<a name="getoptionsprices"></a>
## **GetOptionsPrices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetOptionsPrices_v2)

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
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class GetOptionsPricesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var optionsApi = new OptionsApi();
            var identifier = null;  // string | The Intrinio ID or code of the options contract to request prices for.
            var startDate = "2019-01-01";  // string | Return option contract prices on or after this date. (optional) 
            var endDate = "2019-12-31";  // string | Return option contract prices on or before this date. (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseOptionPrices result = optionsApi.GetOptionsPrices(identifier, startDate, endDate, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptionsApi.GetOptionsPrices: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID or code of the options contract to request prices for. |  &nbsp;
 **startDate** | **string**| Return option contract prices on or after this date. | [optional]  &nbsp;
 **endDate** | **string**| Return option contract prices on or before this date. | [optional]  &nbsp;
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseOptionPrices**](ApiResponseOptionPrices.md)

[//]: # (END_OPERATION)


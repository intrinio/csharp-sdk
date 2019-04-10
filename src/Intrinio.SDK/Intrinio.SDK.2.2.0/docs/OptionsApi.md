# Intrinio.SDK.Api.OptionsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOptions**](OptionsApi.md#getoptions) | **GET** /options/{symbol} | Options
[**GetOptionsChain**](OptionsApi.md#getoptionschain) | **GET** /options/chain/{symbol}/{expiration} | Options Chain
[**GetOptionsExpirations**](OptionsApi.md#getoptionsexpirations) | **GET** /options/expirations/{symbol} | Options Expirations
[**GetOptionsPrices**](OptionsApi.md#getoptionsprices) | **GET** /options/prices/{identifier} | Option Prices


<a name="getoptions"></a>
# **GetOptions**
> ApiResponseOptions GetOptions (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, decimal? pageSize = null, string nextPage = null)

Options

Returns the master list of option contracts for a given symbol.

### Example
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
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The option symbol, corresponding to the underlying security. | 
 **type** | **string**| The option contract type. | [optional] 
 **strike** | **decimal?**| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional] 
 **strikeGreaterThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional] 
 **strikeLessThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional] 
 **expiration** | **string**| The expiration date of the option contract. This will return options contracts with expiration dates on this date. | [optional] 
 **expirationAfter** | **string**| The expiration date of the option contract. This will return options contracts with expiration dates after this date. | [optional] 
 **expirationBefore** | **string**| The expiration date of the option contract. This will return options contracts with expiration dates before this date. | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseOptions**](ApiResponseOptions.md)

<a name="getoptionschain"></a>
# **GetOptionsChain**
> ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, decimal? pageSize = null)

Options Chain

Returns all options contracts and their prices for the given symbol and expiration date.

### Example
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
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The option symbol, corresponding to the underlying security. | 
 **expiration** | **string**| The expiration date of the options contract | 
 **type** | **string**| The option contract type. | [optional] 
 **strike** | **decimal?**| The strike price of the option contract. This will return options contracts with strike price equal to this price. | [optional] 
 **strikeGreaterThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices greater than this price. | [optional] 
 **strikeLessThan** | **decimal?**| The strike price of the option contract. This will return options contracts with strike prices less than this price. | [optional] 
 **moneyness** | **string**| The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]

### Return type

[**ApiResponseOptionsChain**](ApiResponseOptionsChain.md)

<a name="getoptionsexpirations"></a>
# **GetOptionsExpirations**
> ApiResponseOptionsExpirations GetOptionsExpirations (string symbol, string after = null, string before = null)

Options Expirations

Returns all option contract expiration dates for a given symbol.

### Example
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**| The option symbol, corresponding to the underlying security. | 
 **after** | **string**| Return option contract expiration dates after this date. | [optional] 
 **before** | **string**| Return option contract expiration dates before this date. | [optional] 

### Return type

[**ApiResponseOptionsExpirations**](ApiResponseOptionsExpirations.md)

<a name="getoptionsprices"></a>
# **GetOptionsPrices**
> ApiResponseOptionPrices GetOptionsPrices (string identifier, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)

Option Prices

Returns all option prices for a given option contract identifier.

### Example
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
            var pageSize = 100;  // decimal? | The number of results to return (optional)  (default to 100)
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The Intrinio ID or code of the options contract to request prices for. | 
 **startDate** | **string**| Return option contract prices on or after this date. | [optional] 
 **endDate** | **string**| Return option contract prices on or before this date. | [optional] 
 **pageSize** | **decimal?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseOptionPrices**](ApiResponseOptionPrices.md)


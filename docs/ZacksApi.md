# Intrinio.SDK.Api.ZacksApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetZacksAnalystRatings**](ZacksApi.md#getzacksanalystratings) | **GET** /zacks/analyst_ratings | Zacks Analyst Ratings
[**GetZacksEpsSurprises**](ZacksApi.md#getzacksepssurprises) | **GET** /zacks/eps_surprises | Zacks EPS Surprises
[**GetZacksSalesSurprises**](ZacksApi.md#getzackssalessurprises) | **GET** /zacks/sales_surprises | Zacks Sales Surprises



[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/zacks/analyst_ratings)

[//]: # (DOC_LINK:ZacksApi.md#getzacksanalystratings)

<a name="getzacksanalystratings"></a>
# **GetZacksAnalystRatings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetZacksAnalystRatings_v2)

> ApiResponseZacksAnalystRatings GetZacksAnalystRatings (string identifier = null, string startDate = null, string endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)

Zacks Analyst Ratings

Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.

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
    public class GetZacksAnalystRatingsExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var zacksApi = new ZacksApi();
            var identifier = "AAPL";  // string | A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional) 
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
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseZacksAnalystRatings result = zacksApi.GetZacksAnalystRatings(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZacksApi.GetZacksAnalystRatings: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | [optional] 
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
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseZacksAnalystRatings**](ApiResponseZacksAnalystRatings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/zacks/eps_surprises)

[//]: # (DOC_LINK:ZacksApi.md#getzacksepssurprises)

<a name="getzacksepssurprises"></a>
# **GetZacksEpsSurprises**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetZacksEpsSurprises_v2)

> ApiResponseZacksEPSSurprises GetZacksEpsSurprises (string startDate = null, string endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)

Zacks EPS Surprises

Returns Zacks eps surprise data for all Securities.

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
    public class GetZacksEpsSurprisesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var zacksApi = new ZacksApi();
            var startDate = "";  // string | Limit EPS surprises to those on or after this date (optional) 
            var endDate = "";  // string | Limit EPS surprises to those on or before this date (optional) 
            var epsActualGreater = "";  // decimal? | Return only records with an actual EPS higher than this value (optional) 
            var epsActualLess = "";  // decimal? | Return only records with an actual EPS lower than this value (optional) 
            var epsMeanEstimateGreater = "";  // decimal? | Return only records with an EPS mean estimate greater than this value (optional) 
            var epsMeanEstimateLess = "";  // decimal? | Return only records with an EPS mean estimate lower than this value (optional) 
            var epsAmountDiffGreater = "";  // decimal? | Return only records with an EPS amount difference greater than this value (optional) 
            var epsAmountDiffLess = "";  // decimal? | Return only records with an EPS amount difference less than this value (optional) 
            var epsPercentDiffGreater = "";  // decimal? | Return only records with an EPS percent difference greater than this value (optional) 
            var epsPercentDiffLess = "";  // decimal? | Return only records with an EPS percent difference less than this value (optional) 
            var epsCountEstimateGreater = "";  // decimal? | Return only records with an EPS count estimate greater than this value (optional) 
            var epsCountEstimateLess = "";  // decimal? | Return only records with an EPS count estimate less than this value (optional) 
            var epsStdDevEstimateGreater = "";  // decimal? | Return only records with an EPS standard deviation greater than this value (optional) 
            var epsStdDevEstimateLess = "";  // decimal? | Return only records with an EPS standard deviation less than this value (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseZacksEPSSurprises result = zacksApi.GetZacksEpsSurprises(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZacksApi.GetZacksEpsSurprises: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Limit EPS surprises to those on or after this date | [optional] 
 **endDate** | **string**| Limit EPS surprises to those on or before this date | [optional] 
 **epsActualGreater** | **decimal?**| Return only records with an actual EPS higher than this value | [optional] 
 **epsActualLess** | **decimal?**| Return only records with an actual EPS lower than this value | [optional] 
 **epsMeanEstimateGreater** | **decimal?**| Return only records with an EPS mean estimate greater than this value | [optional] 
 **epsMeanEstimateLess** | **decimal?**| Return only records with an EPS mean estimate lower than this value | [optional] 
 **epsAmountDiffGreater** | **decimal?**| Return only records with an EPS amount difference greater than this value | [optional] 
 **epsAmountDiffLess** | **decimal?**| Return only records with an EPS amount difference less than this value | [optional] 
 **epsPercentDiffGreater** | **decimal?**| Return only records with an EPS percent difference greater than this value | [optional] 
 **epsPercentDiffLess** | **decimal?**| Return only records with an EPS percent difference less than this value | [optional] 
 **epsCountEstimateGreater** | **decimal?**| Return only records with an EPS count estimate greater than this value | [optional] 
 **epsCountEstimateLess** | **decimal?**| Return only records with an EPS count estimate less than this value | [optional] 
 **epsStdDevEstimateGreater** | **decimal?**| Return only records with an EPS standard deviation greater than this value | [optional] 
 **epsStdDevEstimateLess** | **decimal?**| Return only records with an EPS standard deviation less than this value | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseZacksEPSSurprises**](ApiResponseZacksEPSSurprises.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERTATION)

[//]: # (ENDPOINT:/zacks/sales_surprises)

[//]: # (DOC_LINK:ZacksApi.md#getzackssalessurprises)

<a name="getzackssalessurprises"></a>
# **GetZacksSalesSurprises**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/api_v2/GetZacksSalesSurprises_v2)

> ApiResponseZacksSalesSurprises GetZacksSalesSurprises (string startDate = null, string endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)

Zacks Sales Surprises

Returns Zacks sales surprise data for all Securities.

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
    public class GetZacksSalesSurprisesExample
    {
        public static void Main()
        {
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

            var zacksApi = new ZacksApi();
            var startDate = "";  // string | Limit sales surprises to those on or after this date (optional) 
            var endDate = "";  // string | Limit sales surprises to those on or before this date (optional) 
            var salesActualGreater = "";  // decimal? | Return only records with an actual sales higher than this value (optional) 
            var salesActualLess = "";  // decimal? | Return only records with an actual sales lower than this value (optional) 
            var salesMeanEstimateGreater = "";  // decimal? | Return only records with a sales mean estimate greater than this value (optional) 
            var salesMeanEstimateLess = "";  // decimal? | Return only records with a sales mean estimate lower than this value (optional) 
            var salesAmountDiffGreater = "";  // decimal? | Return only records with a sales amount difference greater than this value (optional) 
            var salesAmountDiffLess = "";  // decimal? | Return only records with a sales amount difference less than this value (optional) 
            var salesPercentDiffGreater = "";  // decimal? | Return only records with a sales percent difference greater than this value (optional) 
            var salesPercentDiffLess = "";  // decimal? | Return only records with a sales percent difference less than this value (optional) 
            var salesCountEstimateGreater = "";  // decimal? | Return only records with a sales count estimate greater than this value (optional) 
            var salesCountEstimateLess = "";  // decimal? | Return only records with a sales count estimate less than this value (optional) 
            var salesStdDevEstimateGreater = "";  // decimal? | Return only records with a sales standard deviation greater than this value (optional) 
            var salesStdDevEstimateLess = "";  // decimal? | Return only records with a sales standard deviation less than this value (optional) 
            var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
            var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

            try
            {
                ApiResponseZacksSalesSurprises result = zacksApi.GetZacksSalesSurprises(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZacksApi.GetZacksSalesSurprises: " + e.Message );
            }
        }
    }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Limit sales surprises to those on or after this date | [optional] 
 **endDate** | **string**| Limit sales surprises to those on or before this date | [optional] 
 **salesActualGreater** | **decimal?**| Return only records with an actual sales higher than this value | [optional] 
 **salesActualLess** | **decimal?**| Return only records with an actual sales lower than this value | [optional] 
 **salesMeanEstimateGreater** | **decimal?**| Return only records with a sales mean estimate greater than this value | [optional] 
 **salesMeanEstimateLess** | **decimal?**| Return only records with a sales mean estimate lower than this value | [optional] 
 **salesAmountDiffGreater** | **decimal?**| Return only records with a sales amount difference greater than this value | [optional] 
 **salesAmountDiffLess** | **decimal?**| Return only records with a sales amount difference less than this value | [optional] 
 **salesPercentDiffGreater** | **decimal?**| Return only records with a sales percent difference greater than this value | [optional] 
 **salesPercentDiffLess** | **decimal?**| Return only records with a sales percent difference less than this value | [optional] 
 **salesCountEstimateGreater** | **decimal?**| Return only records with a sales count estimate greater than this value | [optional] 
 **salesCountEstimateLess** | **decimal?**| Return only records with a sales count estimate less than this value | [optional] 
 **salesStdDevEstimateGreater** | **decimal?**| Return only records with a sales standard deviation greater than this value | [optional] 
 **salesStdDevEstimateLess** | **decimal?**| Return only records with a sales standard deviation less than this value | [optional] 
 **pageSize** | **int?**| The number of results to return | [optional] [default to 100]
 **nextPage** | **string**| Gets the next page of data from a previous API call | [optional] 

### Return type

[**ApiResponseZacksSalesSurprises**](ApiResponseZacksSalesSurprises.md)

[//]: # (END_OPERATION)


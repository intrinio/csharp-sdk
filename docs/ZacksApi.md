# Intrinio.SDK.Api.ZacksApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetZacksAnalystRatings**](ZacksApi.md#getzacksanalystratings) | **GET** /zacks/analyst_ratings | Zacks Analyst Ratings
[**GetZacksEpsEstimates**](ZacksApi.md#getzacksepsestimates) | **GET** /zacks/eps_estimates | Zacks EPS Estimates
[**GetZacksEpsGrowthRates**](ZacksApi.md#getzacksepsgrowthrates) | **GET** /zacks/eps_growth_rates | Zacks EPS Growth Rates
[**GetZacksEpsSurprises**](ZacksApi.md#getzacksepssurprises) | **GET** /zacks/eps_surprises | Zacks EPS Surprises
[**GetZacksEtfHoldings**](ZacksApi.md#getzacksetfholdings) | **GET** /zacks/etf_holdings | Zacks ETF Holdings
[**GetZacksInstitutionalHoldingCompanies**](ZacksApi.md#getzacksinstitutionalholdingcompanies) | **GET** /zacks/institutional_holdings/companies | Zacks Institutional Holding Companies
[**GetZacksInstitutionalHoldingOwners**](ZacksApi.md#getzacksinstitutionalholdingowners) | **GET** /zacks/institutional_holdings/owners | Zacks Institutional Holding Owners
[**GetZacksInstitutionalHoldings**](ZacksApi.md#getzacksinstitutionalholdings) | **GET** /zacks/institutional_holdings | Zacks Institutional Holdings
[**GetZacksLongTermGrowthRates**](ZacksApi.md#getzackslongtermgrowthrates) | **GET** /zacks/long_term_growth_rates | Zacks Long Term Growth Rates
[**GetZacksSalesSurprises**](ZacksApi.md#getzackssalessurprises) | **GET** /zacks/sales_surprises | Zacks Sales Surprises
[**GetZacksTargetPriceConsensuses**](ZacksApi.md#getzackstargetpriceconsensuses) | **GET** /zacks/target_price_consensuses | Zacks Target Price Consensuses



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksAnalystRatings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksAnalystRatings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksAnalystRatings.md)

[//]: # (OPERATION:GetZacksAnalystRatings_v2)

[//]: # (ENDPOINT:/zacks/analyst_ratings)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksanalystratings)

<a name="getzacksanalystratings"></a>
## **GetZacksAnalystRatings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksAnalystRatings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksAnalystRatings GetZacksAnalystRatings (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null, string nextPage = null)

#### Zacks Analyst Ratings

Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.

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
  public class GetZacksAnalystRatingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string identifier = "AAPL";
      DateTime? startDate = null;
      DateTime? endDate = null;
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
      string nextPage = null;
      
      ApiResponseZacksAnalystRatings result = zacksApi.GetZacksAnalystRatings(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | [optional]  &nbsp;
 **startDate** | DateTime?| Limit ratings to those on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Limit ratings to those on or before this date | [optional]  &nbsp;
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
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksAnalystRatings**](ApiResponseZacksAnalystRatings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksEpsEstimates)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksEPSEstimates)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksEPSEstimates.md)

[//]: # (OPERATION:GetZacksEpsEstimates_v2)

[//]: # (ENDPOINT:/zacks/eps_estimates)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksepsestimates)

<a name="getzacksepsestimates"></a>
## **GetZacksEpsEstimates**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksEpsEstimates_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksEPSEstimates GetZacksEpsEstimates (string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)

#### Zacks EPS Estimates

Returns Zacks consensus earnings-per-share (EPS) data for all Companies.

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
  public class GetZacksEpsEstimatesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string identifier = "AAPL";
      DateTime? startDate = null;
      DateTime? endDate = null;
      int? fiscalYear = null;
      string fiscalPeriod = null;
      int? calendarYear = null;
      string calendarPeriod = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksEPSEstimates result = zacksApi.GetZacksEpsEstimates(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, pageSize, nextPage);
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
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) | [optional]  &nbsp;
 **startDate** | DateTime?| Limit EPS estimates to those on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Limit EPS estimates to those on or before this date | [optional]  &nbsp;
 **fiscalYear** | int?| Only for the given fiscal year | [optional]  &nbsp;
 **fiscalPeriod** | string| The fiscal period | [optional]  &nbsp;
 **calendarYear** | int?| Only for the given calendar year | [optional]  &nbsp;
 **calendarPeriod** | string| The calendar period | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksEPSEstimates**](ApiResponseZacksEPSEstimates.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksEpsGrowthRates)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksEPSGrowthRates)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksEPSGrowthRates.md)

[//]: # (OPERATION:GetZacksEpsGrowthRates_v2)

[//]: # (ENDPOINT:/zacks/eps_growth_rates)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksepsgrowthrates)

<a name="getzacksepsgrowthrates"></a>
## **GetZacksEpsGrowthRates**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksEpsGrowthRates_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksEPSGrowthRates GetZacksEpsGrowthRates (string company = null, string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)

#### Zacks EPS Growth Rates

Returns the latest Zacks EPS growth rates

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
  public class GetZacksEpsGrowthRatesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string company = "AAPL";
      string industryGroupName = null;
      string industryGroupNumber = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksEPSGrowthRates result = zacksApi.GetZacksEpsGrowthRates(company, industryGroupName, industryGroupNumber, pageSize, nextPage);
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
 **company** | string| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) | [optional]  &nbsp;
 **industryGroupName** | string| Return only growth rates for companies in the given Zacks industry group name | [optional]  &nbsp;
 **industryGroupNumber** | string| Return only growth rates for companies in the given Zacks industry group number | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksEPSGrowthRates**](ApiResponseZacksEPSGrowthRates.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksEpsSurprises)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksEPSSurprises)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksEPSSurprises.md)

[//]: # (OPERATION:GetZacksEpsSurprises_v2)

[//]: # (ENDPOINT:/zacks/eps_surprises)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksepssurprises)

<a name="getzacksepssurprises"></a>
## **GetZacksEpsSurprises**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksEpsSurprises_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksEPSSurprises GetZacksEpsSurprises (DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)

#### Zacks EPS Surprises

Returns Zacks eps surprise data for all Securities.

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
  public class GetZacksEpsSurprisesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      DateTime? startDate = null;
      DateTime? endDate = null;
      decimal? epsActualGreater = null;
      decimal? epsActualLess = null;
      decimal? epsMeanEstimateGreater = null;
      decimal? epsMeanEstimateLess = null;
      decimal? epsAmountDiffGreater = null;
      decimal? epsAmountDiffLess = null;
      decimal? epsPercentDiffGreater = null;
      decimal? epsPercentDiffLess = null;
      decimal? epsCountEstimateGreater = null;
      decimal? epsCountEstimateLess = null;
      decimal? epsStdDevEstimateGreater = null;
      decimal? epsStdDevEstimateLess = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksEPSSurprises result = zacksApi.GetZacksEpsSurprises(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
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
 **startDate** | DateTime?| Limit EPS surprises to those on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Limit EPS surprises to those on or before this date | [optional]  &nbsp;
 **epsActualGreater** | decimal?| Return only records with an actual EPS higher than this value | [optional]  &nbsp;
 **epsActualLess** | decimal?| Return only records with an actual EPS lower than this value | [optional]  &nbsp;
 **epsMeanEstimateGreater** | decimal?| Return only records with an EPS mean estimate greater than this value | [optional]  &nbsp;
 **epsMeanEstimateLess** | decimal?| Return only records with an EPS mean estimate lower than this value | [optional]  &nbsp;
 **epsAmountDiffGreater** | decimal?| Return only records with an EPS amount difference greater than this value | [optional]  &nbsp;
 **epsAmountDiffLess** | decimal?| Return only records with an EPS amount difference less than this value | [optional]  &nbsp;
 **epsPercentDiffGreater** | decimal?| Return only records with an EPS percent difference greater than this value | [optional]  &nbsp;
 **epsPercentDiffLess** | decimal?| Return only records with an EPS percent difference less than this value | [optional]  &nbsp;
 **epsCountEstimateGreater** | decimal?| Return only records with an EPS count estimate greater than this value | [optional]  &nbsp;
 **epsCountEstimateLess** | decimal?| Return only records with an EPS count estimate less than this value | [optional]  &nbsp;
 **epsStdDevEstimateGreater** | decimal?| Return only records with an EPS standard deviation greater than this value | [optional]  &nbsp;
 **epsStdDevEstimateLess** | decimal?| Return only records with an EPS standard deviation less than this value | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksEPSSurprises**](ApiResponseZacksEPSSurprises.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksEtfHoldings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksETFHoldings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksETFHoldings.md)

[//]: # (OPERATION:GetZacksEtfHoldings_v2)

[//]: # (ENDPOINT:/zacks/etf_holdings)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksetfholdings)

<a name="getzacksetfholdings"></a>
## **GetZacksEtfHoldings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksEtfHoldings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksETFHoldings GetZacksEtfHoldings (string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null)

#### Zacks ETF Holdings

Returns Zacks ETF holdings data

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
  public class GetZacksEtfHoldingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string etfTicker = "SPY";
      string holdingSymbol = "AAPL";
      decimal? weightGreater = null;
      decimal? weightLess = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksETFHoldings result = zacksApi.GetZacksEtfHoldings(etfTicker, holdingSymbol, weightGreater, weightLess, pageSize, nextPage);
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
 **etfTicker** | string| Return holdings of the ETF with the given ticker | [optional]  &nbsp;
 **holdingSymbol** | string| Return holdings where the instrument being held has the given trading symbol | [optional]  &nbsp;
 **weightGreater** | decimal?| Return on the holdings with a weight greater than | [optional]  &nbsp;
 **weightLess** | decimal?| Return on the holdings with a weight less than | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksETFHoldings**](ApiResponseZacksETFHoldings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksInstitutionalHoldingCompanies)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksInstitutionalHoldingCompanies)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksInstitutionalHoldingCompanies.md)

[//]: # (OPERATION:GetZacksInstitutionalHoldingCompanies_v2)

[//]: # (ENDPOINT:/zacks/institutional_holdings/companies)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksinstitutionalholdingcompanies)

<a name="getzacksinstitutionalholdingcompanies"></a>
## **GetZacksInstitutionalHoldingCompanies**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksInstitutionalHoldingCompanies_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksInstitutionalHoldingCompanies GetZacksInstitutionalHoldingCompanies (string ticker = null, int? pageSize = null, string nextPage = null)

#### Zacks Institutional Holding Companies

Returns Zacks institutional holding companies data

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
  public class GetZacksInstitutionalHoldingCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string ticker = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksInstitutionalHoldingCompanies result = zacksApi.GetZacksInstitutionalHoldingCompanies(ticker, pageSize, nextPage);
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
 **ticker** | string| Return companies with the given ticker | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksInstitutionalHoldingCompanies**](ApiResponseZacksInstitutionalHoldingCompanies.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksInstitutionalHoldingOwners)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksInstitutionalHoldingOwners)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksInstitutionalHoldingOwners.md)

[//]: # (OPERATION:GetZacksInstitutionalHoldingOwners_v2)

[//]: # (ENDPOINT:/zacks/institutional_holdings/owners)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksinstitutionalholdingowners)

<a name="getzacksinstitutionalholdingowners"></a>
## **GetZacksInstitutionalHoldingOwners**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksInstitutionalHoldingOwners_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksInstitutionalHoldingOwners GetZacksInstitutionalHoldingOwners (string cik = null, int? pageSize = null, string nextPage = null)

#### Zacks Institutional Holding Owners

Returns Zacks institutional holding owners data

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
  public class GetZacksInstitutionalHoldingOwnersExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string cik = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksInstitutionalHoldingOwners result = zacksApi.GetZacksInstitutionalHoldingOwners(cik, pageSize, nextPage);
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
 **cik** | string| Return owners with the given Central Index Key (CIK) | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksInstitutionalHoldingOwners**](ApiResponseZacksInstitutionalHoldingOwners.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksInstitutionalHoldings)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksInstitutionalHoldings)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksInstitutionalHoldings.md)

[//]: # (OPERATION:GetZacksInstitutionalHoldings_v2)

[//]: # (ENDPOINT:/zacks/institutional_holdings)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzacksinstitutionalholdings)

<a name="getzacksinstitutionalholdings"></a>
## **GetZacksInstitutionalHoldings**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksInstitutionalHoldings_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksInstitutionalHoldings GetZacksInstitutionalHoldings (string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)

#### Zacks Institutional Holdings

Returns Zacks institutional holdings data

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
  public class GetZacksInstitutionalHoldingsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string ticker = null;
      string ownerCik = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksInstitutionalHoldings result = zacksApi.GetZacksInstitutionalHoldings(ticker, ownerCik, pageSize, nextPage);
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
 **ticker** | string| Return holdings where the company being held has the given ticker | [optional]  &nbsp;
 **ownerCik** | string| Return holdings where the owner/holder has the given Central Index Key (CIK) | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksInstitutionalHoldings**](ApiResponseZacksInstitutionalHoldings.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksLongTermGrowthRates)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksLongTermGrowthRates)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksLongTermGrowthRates.md)

[//]: # (OPERATION:GetZacksLongTermGrowthRates_v2)

[//]: # (ENDPOINT:/zacks/long_term_growth_rates)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzackslongtermgrowthrates)

<a name="getzackslongtermgrowthrates"></a>
## **GetZacksLongTermGrowthRates**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksLongTermGrowthRates_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksLongTermGrowthRates GetZacksLongTermGrowthRates (string identifier = null, int? pageSize = null, string nextPage = null)

#### Zacks Long Term Growth Rates

Returns the latest Zacks long term growth rates

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
  public class GetZacksLongTermGrowthRatesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string identifier = "AAPL";
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksLongTermGrowthRates result = zacksApi.GetZacksLongTermGrowthRates(identifier, pageSize, nextPage);
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
 **identifier** | string| A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksLongTermGrowthRates**](ApiResponseZacksLongTermGrowthRates.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksSalesSurprises)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksSalesSurprises)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksSalesSurprises.md)

[//]: # (OPERATION:GetZacksSalesSurprises_v2)

[//]: # (ENDPOINT:/zacks/sales_surprises)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzackssalessurprises)

<a name="getzackssalessurprises"></a>
## **GetZacksSalesSurprises**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksSalesSurprises_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksSalesSurprises GetZacksSalesSurprises (DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)

#### Zacks Sales Surprises

Returns Zacks sales surprise data for all Securities.

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
  public class GetZacksSalesSurprisesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      DateTime? startDate = null;
      DateTime? endDate = null;
      decimal? salesActualGreater = null;
      decimal? salesActualLess = null;
      decimal? salesMeanEstimateGreater = null;
      decimal? salesMeanEstimateLess = null;
      decimal? salesAmountDiffGreater = null;
      decimal? salesAmountDiffLess = null;
      decimal? salesPercentDiffGreater = null;
      decimal? salesPercentDiffLess = null;
      decimal? salesCountEstimateGreater = null;
      decimal? salesCountEstimateLess = null;
      decimal? salesStdDevEstimateGreater = null;
      decimal? salesStdDevEstimateLess = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksSalesSurprises result = zacksApi.GetZacksSalesSurprises(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
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
 **startDate** | DateTime?| Limit sales surprises to those on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Limit sales surprises to those on or before this date | [optional]  &nbsp;
 **salesActualGreater** | decimal?| Return only records with an actual sales higher than this value | [optional]  &nbsp;
 **salesActualLess** | decimal?| Return only records with an actual sales lower than this value | [optional]  &nbsp;
 **salesMeanEstimateGreater** | decimal?| Return only records with a sales mean estimate greater than this value | [optional]  &nbsp;
 **salesMeanEstimateLess** | decimal?| Return only records with a sales mean estimate lower than this value | [optional]  &nbsp;
 **salesAmountDiffGreater** | decimal?| Return only records with a sales amount difference greater than this value | [optional]  &nbsp;
 **salesAmountDiffLess** | decimal?| Return only records with a sales amount difference less than this value | [optional]  &nbsp;
 **salesPercentDiffGreater** | decimal?| Return only records with a sales percent difference greater than this value | [optional]  &nbsp;
 **salesPercentDiffLess** | decimal?| Return only records with a sales percent difference less than this value | [optional]  &nbsp;
 **salesCountEstimateGreater** | decimal?| Return only records with a sales count estimate greater than this value | [optional]  &nbsp;
 **salesCountEstimateLess** | decimal?| Return only records with a sales count estimate less than this value | [optional]  &nbsp;
 **salesStdDevEstimateGreater** | decimal?| Return only records with a sales standard deviation greater than this value | [optional]  &nbsp;
 **salesStdDevEstimateLess** | decimal?| Return only records with a sales standard deviation less than this value | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksSalesSurprises**](ApiResponseZacksSalesSurprises.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.ZacksApi)

[//]: # (METHOD:GetZacksTargetPriceConsensuses)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseZacksTargetPriceConsensuses)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseZacksTargetPriceConsensuses.md)

[//]: # (OPERATION:GetZacksTargetPriceConsensuses_v2)

[//]: # (ENDPOINT:/zacks/target_price_consensuses)

[//]: # (DOCUMENT_LINK:ZacksApi.md#getzackstargetpriceconsensuses)

<a name="getzackstargetpriceconsensuses"></a>
## **GetZacksTargetPriceConsensuses**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetZacksTargetPriceConsensuses_v2)

[//]: # (START_OVERVIEW)

> ApiResponseZacksTargetPriceConsensuses GetZacksTargetPriceConsensuses (string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)

#### Zacks Target Price Consensuses

Returns the latest Zacks target price consensus data

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
  public class GetZacksTargetPriceConsensusesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var zacksApi = new ZacksApi();
      
      string identifier = "AAPL";
      string industryGroupNumber = null;
      int? pageSize = 100;
      string nextPage = null;
      
      ApiResponseZacksTargetPriceConsensuses result = zacksApi.GetZacksTargetPriceConsensuses(identifier, industryGroupNumber, pageSize, nextPage);
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
 **identifier** | string| Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) | [optional]  &nbsp;
 **industryGroupNumber** | string| Return only growth rates for companies in the given Zacks industry group number | [optional]  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseZacksTargetPriceConsensuses**](ApiResponseZacksTargetPriceConsensuses.md)

[//]: # (END_OPERATION)


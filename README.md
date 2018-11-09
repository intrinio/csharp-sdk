# Intrinio C# SDK

WARNING: THIS IS IS A BETA - DO NOT USE IN PRODUCTION.

To request a beta access key, [sign up here](https://intrinio.com/api-v2-beta).

Welcome to the Intrinio API! Through our Marketplace, we offer a wide selection of financial data feeds sourced by our own proprietary processes as well as from many data vendors. The primary application of the Intrinio API is for use in third-party applications and integrations or for end-users utilizing the Excel add-in and Google Sheets add-on. The Intrinio API uses HTTPS verbs and a RESTful endpoint structure, which makes it easy to request data from Intrinio. Responses are delivered in JSON format. If you need additional help in using the API, go to our home page (https://intrinio.com) and click on the chat icon in the lower right corner.

- API version: 2.0.2
- Package version: 0.9.1


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```


<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Windows] `build.bat`

**NOTE**: Mac is not supported, yet.

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Intrinio.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Intrinio.Api;
using Intrinio.Client;
using Intrinio.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");

            var companyApi = new CompanyApi();
            String nextPage = null;

            try
            {
                ApiResponseCompanies response = companyApi.GetAllCompanies(nextPage);
                response.Companies.ForEach(delegate (CompanySummary company)
                {
                    Console.WriteLine(company.Ticker + " - " + company.Name);
                });
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.FilterCompanies: " + e.Message );
            }
            
            Console.ReadLine();
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-v2.intrinio.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CompanyApi* | [**FilterCompanies**](docs/CompanyApi.md#filtercompanies) | **GET** /companies/filter | Filter Companies
*CompanyApi* | [**FilterCompanyFundamentals**](docs/CompanyApi.md#filtercompanyfundamentals) | **GET** /companies/{identifier}/fundamentals/filter | Filter Fundamentals for a Company
*CompanyApi* | [**GetAllCompanies**](docs/CompanyApi.md#getallcompanies) | **GET** /companies | Get All Companies
*CompanyApi* | [**GetAllCompanyNews**](docs/CompanyApi.md#getallcompanynews) | **GET** /companies/news | Get All Company News
*CompanyApi* | [**GetCompany**](docs/CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Get a Company by ID
*CompanyApi* | [**GetCompanyDataPointNumber**](docs/CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{tag}/number | Get Company Data Point (Number)
*CompanyApi* | [**GetCompanyDataPointText**](docs/CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{tag}/text | Get Company Data Point (Text)
*CompanyApi* | [**GetCompanyFilings**](docs/CompanyApi.md#getcompanyfilings) | **GET** /companies/{identifier}/filings | Get Filings for a Company
*CompanyApi* | [**GetCompanyFundamentals**](docs/CompanyApi.md#getcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | Get All Fundamentals for a Company
*CompanyApi* | [**GetCompanyHistoricalData**](docs/CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{tag} | Get Company Historical Data
*CompanyApi* | [**GetCompanyNews**](docs/CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | Get News for a Company
*CompanyApi* | [**GetCompanySecurities**](docs/CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | Get Securities by Company
*CompanyApi* | [**LookupCompanyFundamental**](docs/CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup a Fundamental for a Company
*CompanyApi* | [**SearchCompanies**](docs/CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies
*DataPointApi* | [**GetDataPointNumber**](docs/DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{tag}/number | Get a Data Point (Number)
*DataPointApi* | [**GetDataPointText**](docs/DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{tag}/text | Get a Data Point (Text)
*DataTagApi* | [**FilterDataTags**](docs/DataTagApi.md#filterdatatags) | **GET** /data_tags/filter | Filter Data Tags
*DataTagApi* | [**GetAllDataTags**](docs/DataTagApi.md#getalldatatags) | **GET** /data_tags | Get All Data Tags
*DataTagApi* | [**GetDataTagById**](docs/DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Get a Data Tag by ID
*DataTagApi* | [**SearchDataTags**](docs/DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags
*FilingApi* | [**FilterFilings**](docs/FilingApi.md#filterfilings) | **GET** /filings/filter | Filter Filings
*FilingApi* | [**GetAllFilings**](docs/FilingApi.md#getallfilings) | **GET** /filings | Get All Filings
*FilingApi* | [**GetFilingById**](docs/FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Get a Filing by ID
*FundamentalsApi* | [**GetFundamentalById**](docs/FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Get a Fundamental by ID
*FundamentalsApi* | [**GetFundamentalReportedFinancials**](docs/FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Get Reported Financials for a Fundamental
*FundamentalsApi* | [**GetFundamentalStandardizedFinancials**](docs/FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Get Standardized Financials for a Fundamental
*FundamentalsApi* | [**LookupFundamental**](docs/FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup a Fundamental
*HistoricalDataApi* | [**GetHistoricalData**](docs/HistoricalDataApi.md#gethistoricaldata) | **GET** /historical_data/{identifier}/{tag} | Get Historical Data
*IndexApi* | [**GetAllEconomicIndices**](docs/IndexApi.md#getalleconomicindices) | **GET** /indices/economic | Get All Economic Indices
*IndexApi* | [**GetAllSicIndices**](docs/IndexApi.md#getallsicindices) | **GET** /indices/sic | Get All SIC Indices
*IndexApi* | [**GetAllStockMarketIndices**](docs/IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | Get All Stock Market Indices
*IndexApi* | [**GetEconomicIndexById**](docs/IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Get an Economic Index by ID
*IndexApi* | [**GetEconomicIndexDataPointNumber**](docs/IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Get Economic Index Data Point (Number)
*IndexApi* | [**GetEconomicIndexDataPointText**](docs/IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Get Economic Index Data Point (Text)
*IndexApi* | [**GetEconomicIndexHistoricalData**](docs/IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Get Economic Index Historical Data
*IndexApi* | [**GetSicIndexById**](docs/IndexApi.md#getsicindexbyid) | **GET** /indices/sic/{identifier} | Get an SIC Index by ID
*IndexApi* | [**GetSicIndexDataPointNumber**](docs/IndexApi.md#getsicindexdatapointnumber) | **GET** /indices/sic/{identifier}/data_point/{tag}/number | Get SIC Index Data Point (Number)
*IndexApi* | [**GetSicIndexDataPointText**](docs/IndexApi.md#getsicindexdatapointtext) | **GET** /indices/sic/{identifier}/data_point/{tag}/text | Get SIC Index Data Point (Text)
*IndexApi* | [**GetSicIndexHistoricalData**](docs/IndexApi.md#getsicindexhistoricaldata) | **GET** /indices/sic/{identifier}/historical_data/{tag} | Get SIC Index Historical Data
*IndexApi* | [**GetStockMarketIndexById**](docs/IndexApi.md#getstockmarketindexbyid) | **GET** /indices/stock_market/{identifier} | Get a Stock Market Index by ID
*IndexApi* | [**GetStockMarketIndexDataPointNumber**](docs/IndexApi.md#getstockmarketindexdatapointnumber) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/number | Get Stock Market Index Data Point (Number)
*IndexApi* | [**GetStockMarketIndexDataPointText**](docs/IndexApi.md#getstockmarketindexdatapointtext) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/text | Get Stock Market Index Data Point (Text)
*IndexApi* | [**GetStockMarketIndexHistoricalData**](docs/IndexApi.md#getstockmarketindexhistoricaldata) | **GET** /indices/stock_market/{identifier}/historical_data/{tag} | Get Stock Market Index Historical Data
*IndexApi* | [**SearchEconomicIndices**](docs/IndexApi.md#searcheconomicindices) | **GET** /indices/economic/search | Search Economic Indices
*IndexApi* | [**SearchSicIndices**](docs/IndexApi.md#searchsicindices) | **GET** /indices/sic/search | Search SIC Indices
*IndexApi* | [**SearchStockMarketsIndices**](docs/IndexApi.md#searchstockmarketsindices) | **GET** /indices/stock_market/search | Search Stock Market Indices
*SecurityApi* | [**GetAllSecurities**](docs/SecurityApi.md#getallsecurities) | **GET** /securities | Get All Securiites
*SecurityApi* | [**GetSecurityById**](docs/SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Get a Security by ID
*SecurityApi* | [**GetSecurityDataPointNumber**](docs/SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{tag}/number | Get Security Data Point (Number)
*SecurityApi* | [**GetSecurityDataPointText**](docs/SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{tag}/text | Get Security Data Point (Text)
*SecurityApi* | [**GetSecurityHistoricalData**](docs/SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{tag} | Get Security Historical Data
*SecurityApi* | [**GetSecurityStockPriceAdjustments**](docs/SecurityApi.md#getsecuritystockpriceadjustments) | **GET** /securities/{identifier}/prices/adjustments | Get Stock Price Adjustments for Security
*SecurityApi* | [**GetSecurityStockPrices**](docs/SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Get Stock Prices for Security
*SecurityApi* | [**ScreenSecurities**](docs/SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
*SecurityApi* | [**SearchSecurities**](docs/SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities
*StockExchangeApi* | [**FilterStockExchanges**](docs/StockExchangeApi.md#filterstockexchanges) | **GET** /stock_exchanges/filter | Filter Stock Exchanges
*StockExchangeApi* | [**GetAllStockExchanges**](docs/StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | Get All Stock Exchanges
*StockExchangeApi* | [**GetStockExchangeById**](docs/StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Get Stock Exchange by ID
*StockExchangeApi* | [**GetStockExchangePriceAdjustments**](docs/StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Get Stock Price Adjustments by Exchange
*StockExchangeApi* | [**GetStockExchangePrices**](docs/StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Get Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeSecurities**](docs/StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Get Securities by Exchange


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiResponseCompanies](docs/ApiResponseCompanies.md)
 - [Model.ApiResponseCompanyFilings](docs/ApiResponseCompanyFilings.md)
 - [Model.ApiResponseCompanyFundamentals](docs/ApiResponseCompanyFundamentals.md)
 - [Model.ApiResponseCompanyHistoricalData](docs/ApiResponseCompanyHistoricalData.md)
 - [Model.ApiResponseCompanyNews](docs/ApiResponseCompanyNews.md)
 - [Model.ApiResponseCompanySecurities](docs/ApiResponseCompanySecurities.md)
 - [Model.ApiResponseDataTags](docs/ApiResponseDataTags.md)
 - [Model.ApiResponseEconomicIndexHistoricalData](docs/ApiResponseEconomicIndexHistoricalData.md)
 - [Model.ApiResponseEconomicIndices](docs/ApiResponseEconomicIndices.md)
 - [Model.ApiResponseFilings](docs/ApiResponseFilings.md)
 - [Model.ApiResponseHistoricalData](docs/ApiResponseHistoricalData.md)
 - [Model.ApiResponseNews](docs/ApiResponseNews.md)
 - [Model.ApiResponseReportedFinancials](docs/ApiResponseReportedFinancials.md)
 - [Model.ApiResponseSICIndexHistoricalData](docs/ApiResponseSICIndexHistoricalData.md)
 - [Model.ApiResponseSICIndices](docs/ApiResponseSICIndices.md)
 - [Model.ApiResponseSecurities](docs/ApiResponseSecurities.md)
 - [Model.ApiResponseSecurityHistoricalData](docs/ApiResponseSecurityHistoricalData.md)
 - [Model.ApiResponseSecurityStockPriceAdjustments](docs/ApiResponseSecurityStockPriceAdjustments.md)
 - [Model.ApiResponseSecurityStockPrices](docs/ApiResponseSecurityStockPrices.md)
 - [Model.ApiResponseStandardizedFinancials](docs/ApiResponseStandardizedFinancials.md)
 - [Model.ApiResponseStockExchangeSecurities](docs/ApiResponseStockExchangeSecurities.md)
 - [Model.ApiResponseStockExchangeStockPriceAdjustments](docs/ApiResponseStockExchangeStockPriceAdjustments.md)
 - [Model.ApiResponseStockExchangeStockPrices](docs/ApiResponseStockExchangeStockPrices.md)
 - [Model.ApiResponseStockMarketIndexHistoricalData](docs/ApiResponseStockMarketIndexHistoricalData.md)
 - [Model.ApiResponseStockMarketIndices](docs/ApiResponseStockMarketIndices.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyFiling](docs/CompanyFiling.md)
 - [Model.CompanyNews](docs/CompanyNews.md)
 - [Model.CompanyNewsSummary](docs/CompanyNewsSummary.md)
 - [Model.CompanySummary](docs/CompanySummary.md)
 - [Model.DataPointNumber](docs/DataPointNumber.md)
 - [Model.DataPointText](docs/DataPointText.md)
 - [Model.DataTag](docs/DataTag.md)
 - [Model.DataTagSummary](docs/DataTagSummary.md)
 - [Model.EconomicIndex](docs/EconomicIndex.md)
 - [Model.EconomicIndexSummary](docs/EconomicIndexSummary.md)
 - [Model.Filing](docs/Filing.md)
 - [Model.FilingSummary](docs/FilingSummary.md)
 - [Model.Fundamental](docs/Fundamental.md)
 - [Model.FundamentalSummary](docs/FundamentalSummary.md)
 - [Model.HistoricalData](docs/HistoricalData.md)
 - [Model.ReportedFinancial](docs/ReportedFinancial.md)
 - [Model.ReportedTag](docs/ReportedTag.md)
 - [Model.SICIndex](docs/SICIndex.md)
 - [Model.Security](docs/Security.md)
 - [Model.SecurityScreenClause](docs/SecurityScreenClause.md)
 - [Model.SecurityScreenGroup](docs/SecurityScreenGroup.md)
 - [Model.SecurityScreenResult](docs/SecurityScreenResult.md)
 - [Model.SecurityScreenResultData](docs/SecurityScreenResultData.md)
 - [Model.SecuritySummary](docs/SecuritySummary.md)
 - [Model.StandardizedFinancial](docs/StandardizedFinancial.md)
 - [Model.StockExchange](docs/StockExchange.md)
 - [Model.StockMarketIndex](docs/StockMarketIndex.md)
 - [Model.StockMarketIndexSummary](docs/StockMarketIndexSummary.md)
 - [Model.StockPrice](docs/StockPrice.md)
 - [Model.StockPriceAdjustment](docs/StockPriceAdjustment.md)
 - [Model.StockPriceAdjustmentSummary](docs/StockPriceAdjustmentSummary.md)
 - [Model.StockPriceSummary](docs/StockPriceSummary.md)


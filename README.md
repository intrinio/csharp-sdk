# Intrinio C# SDK

To get an API key, [sign up here](https://intrinio.com/).

Welcome to the Intrinio API! Through our Financial Data Marketplace, we offer a wide selection of financial data feed APIs sourced by our own proprietary processes as well as from many data vendors. For a complete API request / response reference please view the [Intrinio API documentation](https://intrinio.com/documentation/api_v2). If you need additional help in using the API, please visit the [Intrinio website](https://intrinio.com) and click on the chat icon in the lower right corner.

- API version: 2.2.0
- Package version: 2.1.0


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="installation"></a>
## Installation
Use NuGet to include the client DLL in your project.

```
Install-Package Intrinio.SDK
```

Alternatively, you can download the required DLLs from the [Releases page](https://github.com/intrinio/csharp-sdk/releases).

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


<a name="installation manual build"></a>
## Installation Manual Build
Run the following command to generate the DLL
- [Windows] `build.bat`


Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Intrinio.SDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## SDK Code Examples

Code examples for Intrinio SDKs are available at https://github.com/intrinio/sdk-code-samples

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
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
*CompanyApi* | [**GetAllCompanies**](docs/CompanyApi.md#getallcompanies) | **GET** /companies | All Companies
*CompanyApi* | [**GetAllCompanyNews**](docs/CompanyApi.md#getallcompanynews) | **GET** /companies/news | All News
*CompanyApi* | [**GetCompany**](docs/CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Lookup Company
*CompanyApi* | [**GetCompanyDataPointNumber**](docs/CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{tag}/number | Data Point (Number) for Company
*CompanyApi* | [**GetCompanyDataPointText**](docs/CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{tag}/text | Data Point (Text) for Company
*CompanyApi* | [**GetCompanyFilings**](docs/CompanyApi.md#getcompanyfilings) | **GET** /companies/{identifier}/filings | All Filings by Company
*CompanyApi* | [**GetCompanyFundamentals**](docs/CompanyApi.md#getcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | All Fundamentals by Company
*CompanyApi* | [**GetCompanyHistoricalData**](docs/CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{tag} | Historical Data for Company
*CompanyApi* | [**GetCompanyNews**](docs/CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | All News by Company
*CompanyApi* | [**GetCompanySecurities**](docs/CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | All Securities by Company
*CompanyApi* | [**LookupCompanyFundamental**](docs/CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental by Company
*CompanyApi* | [**SearchCompanies**](docs/CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies
*DataPointApi* | [**GetDataPointNumber**](docs/DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{tag}/number | Data Point (Number)
*DataPointApi* | [**GetDataPointText**](docs/DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{tag}/text | Data Point (Text)
*DataTagApi* | [**GetAllDataTags**](docs/DataTagApi.md#getalldatatags) | **GET** /data_tags | All Data Tags
*DataTagApi* | [**GetDataTagById**](docs/DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Lookup Data Tag
*DataTagApi* | [**SearchDataTags**](docs/DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags
*FilingApi* | [**GetAllFilings**](docs/FilingApi.md#getallfilings) | **GET** /filings | All Filings
*FilingApi* | [**GetAllNotes**](docs/FilingApi.md#getallnotes) | **GET** /filings/notes | All Filing Notes
*FilingApi* | [**GetFilingById**](docs/FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
*FilingApi* | [**GetNote**](docs/FilingApi.md#getnote) | **GET** /filings/notes/{identifier} | Filing Note by ID
*FilingApi* | [**GetNoteHtml**](docs/FilingApi.md#getnotehtml) | **GET** /filings/notes/{identifier}/html | Filing Note HTML
*FilingApi* | [**GetNoteText**](docs/FilingApi.md#getnotetext) | **GET** /filings/notes/{identifier}/text | Filing Note Text
*FilingApi* | [**SearchNotes**](docs/FilingApi.md#searchnotes) | **GET** /filings/notes/search | Search Filing Notes
*ForexApi* | [**GetForexCurrencies**](docs/ForexApi.md#getforexcurrencies) | **GET** /forex/currencies | Forex Currencies
*ForexApi* | [**GetForexPairs**](docs/ForexApi.md#getforexpairs) | **GET** /forex/pairs | Forex Currency Pairs
*ForexApi* | [**GetForexPrices**](docs/ForexApi.md#getforexprices) | **GET** /forex/prices/{pair}/{timeframe} | Forex Currency Prices
*FundamentalsApi* | [**GetFundamentalById**](docs/FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Fundamental by ID
*FundamentalsApi* | [**GetFundamentalReportedFinancials**](docs/FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Reported Financials
*FundamentalsApi* | [**GetFundamentalStandardizedFinancials**](docs/FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Standardized Financials
*FundamentalsApi* | [**LookupFundamental**](docs/FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental
*HistoricalDataApi* | [**GetHistoricalData**](docs/HistoricalDataApi.md#gethistoricaldata) | **GET** /historical_data/{identifier}/{tag} | Historical Data
*IndexApi* | [**GetAllEconomicIndices**](docs/IndexApi.md#getalleconomicindices) | **GET** /indices/economic | All Economic Indices
*IndexApi* | [**GetAllSicIndices**](docs/IndexApi.md#getallsicindices) | **GET** /indices/sic | All SIC Indices
*IndexApi* | [**GetAllStockMarketIndices**](docs/IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | All Stock Market Indices
*IndexApi* | [**GetEconomicIndexById**](docs/IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Lookup Economic Index
*IndexApi* | [**GetEconomicIndexDataPointNumber**](docs/IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Data Point (Number) for an Economic Index
*IndexApi* | [**GetEconomicIndexDataPointText**](docs/IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Data Point (Text) for an Economic Index
*IndexApi* | [**GetEconomicIndexHistoricalData**](docs/IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Historical Data for an Economic Index
*IndexApi* | [**GetSicIndexById**](docs/IndexApi.md#getsicindexbyid) | **GET** /indices/sic/{identifier} | Lookup SIC Index
*IndexApi* | [**GetSicIndexDataPointNumber**](docs/IndexApi.md#getsicindexdatapointnumber) | **GET** /indices/sic/{identifier}/data_point/{tag}/number | Data Point (Number) for an SIC Index
*IndexApi* | [**GetSicIndexDataPointText**](docs/IndexApi.md#getsicindexdatapointtext) | **GET** /indices/sic/{identifier}/data_point/{tag}/text | Data Point (Text) for an SIC Index
*IndexApi* | [**GetSicIndexHistoricalData**](docs/IndexApi.md#getsicindexhistoricaldata) | **GET** /indices/sic/{identifier}/historical_data/{tag} | Historical Data for an SIC Index
*IndexApi* | [**GetStockMarketIndexById**](docs/IndexApi.md#getstockmarketindexbyid) | **GET** /indices/stock_market/{identifier} | Lookup Stock Market Index
*IndexApi* | [**GetStockMarketIndexDataPointNumber**](docs/IndexApi.md#getstockmarketindexdatapointnumber) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/number | Data Point (Number) for Stock Market Index
*IndexApi* | [**GetStockMarketIndexDataPointText**](docs/IndexApi.md#getstockmarketindexdatapointtext) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/text | Data Point (Text) for Stock Market Index
*IndexApi* | [**GetStockMarketIndexHistoricalData**](docs/IndexApi.md#getstockmarketindexhistoricaldata) | **GET** /indices/stock_market/{identifier}/historical_data/{tag} | Historical Data for Stock Market Index
*IndexApi* | [**SearchEconomicIndices**](docs/IndexApi.md#searcheconomicindices) | **GET** /indices/economic/search | Search Economic Indices
*IndexApi* | [**SearchSicIndices**](docs/IndexApi.md#searchsicindices) | **GET** /indices/sic/search | Search SIC Indices
*IndexApi* | [**SearchStockMarketsIndices**](docs/IndexApi.md#searchstockmarketsindices) | **GET** /indices/stock_market/search | Search Stock Market Indices
*MunicipalityApi* | [**GetAllMunicipalities**](docs/MunicipalityApi.md#getallmunicipalities) | **GET** /municipalities | All Municipalities
*MunicipalityApi* | [**GetMunicipalityById**](docs/MunicipalityApi.md#getmunicipalitybyid) | **GET** /municipalities/{id} | Municipality by ID
*MunicipalityApi* | [**GetMunicipalityFinancials**](docs/MunicipalityApi.md#getmunicipalityfinancials) | **GET** /municipalities/{id}/financials | Financials for a Municipality
*SecurityApi* | [**GetAllSecurities**](docs/SecurityApi.md#getallsecurities) | **GET** /securities | All Securities
*SecurityApi* | [**GetSecurityById**](docs/SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Lookup Security
*SecurityApi* | [**GetSecurityDataPointNumber**](docs/SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{tag}/number | Data Point (Number) for Security
*SecurityApi* | [**GetSecurityDataPointText**](docs/SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{tag}/text | Data Point (Text) for Security
*SecurityApi* | [**GetSecurityHistoricalData**](docs/SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{tag} | Historical Data for Security
*SecurityApi* | [**GetSecurityIntradayPrices**](docs/SecurityApi.md#getsecurityintradayprices) | **GET** /securities/{identifier}/prices/intraday | Intraday Stock Prices for Security
*SecurityApi* | [**GetSecurityLatestDividendRecord**](docs/SecurityApi.md#getsecuritylatestdividendrecord) | **GET** /securities/{identifier}/dividends/latest | Lastest Dividend Record for Security
*SecurityApi* | [**GetSecurityLatestEarningsRecord**](docs/SecurityApi.md#getsecuritylatestearningsrecord) | **GET** /securities/{identifier}/earnings/latest | Lastest Earnings Record for Security
*SecurityApi* | [**GetSecurityRealtimePrice**](docs/SecurityApi.md#getsecurityrealtimeprice) | **GET** /securities/{identifier}/prices/realtime | Realtime Stock Price for Security
*SecurityApi* | [**GetSecurityStockPriceAdjustments**](docs/SecurityApi.md#getsecuritystockpriceadjustments) | **GET** /securities/{identifier}/prices/adjustments | Stock Price Adjustments by Security
*SecurityApi* | [**GetSecurityStockPrices**](docs/SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Stock Prices by Security
*SecurityApi* | [**ScreenSecurities**](docs/SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
*SecurityApi* | [**SearchSecurities**](docs/SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities
*StockExchangeApi* | [**GetAllStockExchanges**](docs/StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | All Stock Exchanges
*StockExchangeApi* | [**GetStockExchangeById**](docs/StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Lookup Stock Exchange
*StockExchangeApi* | [**GetStockExchangePriceAdjustments**](docs/StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Stock Price Adjustments by Exchange
*StockExchangeApi* | [**GetStockExchangePrices**](docs/StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeRealtimePrices**](docs/StockExchangeApi.md#getstockexchangerealtimeprices) | **GET** /stock_exchanges/{identifier}/prices/realtime | Realtime Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeSecurities**](docs/StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Securities by Exchange


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiResponseCompanies](docs/ApiResponseCompanies.md)
 - [Model.ApiResponseCompaniesSearch](docs/ApiResponseCompaniesSearch.md)
 - [Model.ApiResponseCompanyFilings](docs/ApiResponseCompanyFilings.md)
 - [Model.ApiResponseCompanyFundamentals](docs/ApiResponseCompanyFundamentals.md)
 - [Model.ApiResponseCompanyHistoricalData](docs/ApiResponseCompanyHistoricalData.md)
 - [Model.ApiResponseCompanyNews](docs/ApiResponseCompanyNews.md)
 - [Model.ApiResponseCompanySecurities](docs/ApiResponseCompanySecurities.md)
 - [Model.ApiResponseDataTags](docs/ApiResponseDataTags.md)
 - [Model.ApiResponseDataTagsSearch](docs/ApiResponseDataTagsSearch.md)
 - [Model.ApiResponseEconomicIndexHistoricalData](docs/ApiResponseEconomicIndexHistoricalData.md)
 - [Model.ApiResponseEconomicIndices](docs/ApiResponseEconomicIndices.md)
 - [Model.ApiResponseEconomicIndicesSearch](docs/ApiResponseEconomicIndicesSearch.md)
 - [Model.ApiResponseFilingNotes](docs/ApiResponseFilingNotes.md)
 - [Model.ApiResponseFilingNotesSearch](docs/ApiResponseFilingNotesSearch.md)
 - [Model.ApiResponseFilings](docs/ApiResponseFilings.md)
 - [Model.ApiResponseForexCurrencies](docs/ApiResponseForexCurrencies.md)
 - [Model.ApiResponseForexPairs](docs/ApiResponseForexPairs.md)
 - [Model.ApiResponseForexPrices](docs/ApiResponseForexPrices.md)
 - [Model.ApiResponseHistoricalData](docs/ApiResponseHistoricalData.md)
 - [Model.ApiResponseMunicipalities](docs/ApiResponseMunicipalities.md)
 - [Model.ApiResponseMunicipalitiyFinancials](docs/ApiResponseMunicipalitiyFinancials.md)
 - [Model.ApiResponseNews](docs/ApiResponseNews.md)
 - [Model.ApiResponseReportedFinancials](docs/ApiResponseReportedFinancials.md)
 - [Model.ApiResponseSICIndexHistoricalData](docs/ApiResponseSICIndexHistoricalData.md)
 - [Model.ApiResponseSICIndices](docs/ApiResponseSICIndices.md)
 - [Model.ApiResponseSICIndicesSearch](docs/ApiResponseSICIndicesSearch.md)
 - [Model.ApiResponseSecurities](docs/ApiResponseSecurities.md)
 - [Model.ApiResponseSecuritiesSearch](docs/ApiResponseSecuritiesSearch.md)
 - [Model.ApiResponseSecurityHistoricalData](docs/ApiResponseSecurityHistoricalData.md)
 - [Model.ApiResponseSecurityIntradayPrices](docs/ApiResponseSecurityIntradayPrices.md)
 - [Model.ApiResponseSecurityStockPriceAdjustments](docs/ApiResponseSecurityStockPriceAdjustments.md)
 - [Model.ApiResponseSecurityStockPrices](docs/ApiResponseSecurityStockPrices.md)
 - [Model.ApiResponseStandardizedFinancials](docs/ApiResponseStandardizedFinancials.md)
 - [Model.ApiResponseStockExchangeRealtimeStockPrices](docs/ApiResponseStockExchangeRealtimeStockPrices.md)
 - [Model.ApiResponseStockExchangeSecurities](docs/ApiResponseStockExchangeSecurities.md)
 - [Model.ApiResponseStockExchangeStockPriceAdjustments](docs/ApiResponseStockExchangeStockPriceAdjustments.md)
 - [Model.ApiResponseStockExchangeStockPrices](docs/ApiResponseStockExchangeStockPrices.md)
 - [Model.ApiResponseStockExchanges](docs/ApiResponseStockExchanges.md)
 - [Model.ApiResponseStockMarketIndexHistoricalData](docs/ApiResponseStockMarketIndexHistoricalData.md)
 - [Model.ApiResponseStockMarketIndices](docs/ApiResponseStockMarketIndices.md)
 - [Model.ApiResponseStockMarketIndicesSearch](docs/ApiResponseStockMarketIndicesSearch.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyFiling](docs/CompanyFiling.md)
 - [Model.CompanyNews](docs/CompanyNews.md)
 - [Model.CompanyNewsSummary](docs/CompanyNewsSummary.md)
 - [Model.CompanySummary](docs/CompanySummary.md)
 - [Model.DataTag](docs/DataTag.md)
 - [Model.DataTagSummary](docs/DataTagSummary.md)
 - [Model.DividendRecord](docs/DividendRecord.md)
 - [Model.EarningsRecord](docs/EarningsRecord.md)
 - [Model.EconomicIndex](docs/EconomicIndex.md)
 - [Model.EconomicIndexSummary](docs/EconomicIndexSummary.md)
 - [Model.Filing](docs/Filing.md)
 - [Model.FilingNote](docs/FilingNote.md)
 - [Model.FilingNoteFiling](docs/FilingNoteFiling.md)
 - [Model.FilingNoteSummary](docs/FilingNoteSummary.md)
 - [Model.FilingSummary](docs/FilingSummary.md)
 - [Model.ForexCurrency](docs/ForexCurrency.md)
 - [Model.ForexPair](docs/ForexPair.md)
 - [Model.ForexPrice](docs/ForexPrice.md)
 - [Model.Fundamental](docs/Fundamental.md)
 - [Model.FundamentalSummary](docs/FundamentalSummary.md)
 - [Model.HistoricalData](docs/HistoricalData.md)
 - [Model.IntradayStockPrice](docs/IntradayStockPrice.md)
 - [Model.Municipality](docs/Municipality.md)
 - [Model.MunicipalityFinancial](docs/MunicipalityFinancial.md)
 - [Model.RealtimeStockPrice](docs/RealtimeStockPrice.md)
 - [Model.RealtimeStockPriceSecurity](docs/RealtimeStockPriceSecurity.md)
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


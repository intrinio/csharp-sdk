# Intrinio C# SDK

To get an API key, [sign up here](https://intrinio.com/).

Welcome to the Intrinio API! Through our Financial Data Marketplace, we offer a wide selection of financial data feed APIs sourced by our own proprietary processes as well as from many data vendors. For a complete API request / response reference please view the [Intrinio API documentation](https://docs.intrinio.com/documentation/api_v2). If you need additional help in using the API, please visit the [Intrinio website](https://intrinio.com) and click on the chat icon in the lower right corner.

- API version: 2.112.0
- Package version: 7.20.0


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET >=8.0

<a name="installation"></a>
## Installation
Use NuGet to include the client DLL in your project.

```
Install-Package Intrinio.SDK
```

Alternatively, you can download the required DLLs from the [Releases page](https://github.com/intrinio/csharp-sdk/releases).

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 2.0.1 or later
- [Polly](https://www.nuget.org/packages/Polly) - 8.4.1 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package Polly
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
  public class GetAllCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
      Configuration.Default.AllowRetries = true;
      
      var companyApi = new CompanyApi();
      var latestFilingDate = "";  // DateTime? | Last filing date (optional) 
      var sic = "";  // string | Standard Industrial Classification code (optional) 
      var template = "";  // string | Template (optional) 
      var sector = "";  // string | Industry sector (optional) 
      var industryCategory = "";  // string | Industry category (optional) 
      var industryGroup = "";  // string | Industry group (optional) 
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseCompanies result = companyApi.GetAllCompanies(latestFilingDate, sic, template, sector, industryCategory, industryGroup, pageSize, nextPage);
        Debug.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Debug.Print("Exception when calling CompanyApi.GetAllCompanies: " + e.Message );
      }
    }
  }
}
```

## Retries

By default, automatic retries are enabled for the C# SDK. Retries can be enabled/disabled by setting `AllowRetries` on the default configuration to `true`/`false` as seen in the code example above.

If set to `true`, all calls to the API will attempt a successful completion up to 5 times with exponential backoff before failing. If set to `false`, calls to the API will attempt one successful call.

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

Complete documentation for the Intrinio C# SDK is available on the Intrinio website.

[View Intrinio C# SDK Documentation](https://docs.intrinio.com/documentation/csharp)

A listing of classes and methods is also provided below:

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BulkDownloadsApi* | [**GetBulkDownloadLinks**](docs/BulkDownloadsApi.md#getbulkdownloadlinks) | **GET** /bulk_downloads/links | All Links
*CompanyApi* | [**GetAllCompanies**](docs/CompanyApi.md#getallcompanies) | **GET** /companies | All Companies
*CompanyApi* | [**GetAllCompaniesDailyMetrics**](docs/CompanyApi.md#getallcompaniesdailymetrics) | **GET** /companies/daily_metrics | All Companies daily metrics
*CompanyApi* | [**GetAllCompanyNews**](docs/CompanyApi.md#getallcompanynews) | **GET** /companies/news | All News
*CompanyApi* | [**GetCompany**](docs/CompanyApi.md#getcompany) | **GET** /companies/{identifier} | Lookup Company
*CompanyApi* | [**GetCompanyAnswers**](docs/CompanyApi.md#getcompanyanswers) | **GET** /companies/{identifier}/answers | Company Answers
*CompanyApi* | [**GetCompanyDailyMetrics**](docs/CompanyApi.md#getcompanydailymetrics) | **GET** /companies/{identifier}/daily_metrics | Company metrics by Company
*CompanyApi* | [**GetCompanyDataPointNumber**](docs/CompanyApi.md#getcompanydatapointnumber) | **GET** /companies/{identifier}/data_point/{tag}/number | Data Point (Number) for Company
*CompanyApi* | [**GetCompanyDataPointText**](docs/CompanyApi.md#getcompanydatapointtext) | **GET** /companies/{identifier}/data_point/{tag}/text | Data Point (Text) for Company
*CompanyApi* | [**GetCompanyFilings**](docs/CompanyApi.md#getcompanyfilings) | **GET** /companies/{identifier}/filings | All Filings by Company
*CompanyApi* | [**GetCompanyFundamentals**](docs/CompanyApi.md#getcompanyfundamentals) | **GET** /companies/{identifier}/fundamentals | All Fundamentals by Company
*CompanyApi* | [**GetCompanyHistoricalData**](docs/CompanyApi.md#getcompanyhistoricaldata) | **GET** /companies/{identifier}/historical_data/{tag} | Historical Data for Company
*CompanyApi* | [**GetCompanyIpos**](docs/CompanyApi.md#getcompanyipos) | **GET** /companies/ipos | IPOs
*CompanyApi* | [**GetCompanyNews**](docs/CompanyApi.md#getcompanynews) | **GET** /companies/{identifier}/news | All News by Company
*CompanyApi* | [**GetCompanyNewsBody**](docs/CompanyApi.md#getcompanynewsbody) | **GET** /companies/news/body | News Article Body
*CompanyApi* | [**GetCompanyPublicFloat**](docs/CompanyApi.md#getcompanypublicfloat) | **GET** /companies/{identifier}/public_float | Get Company's public float
*CompanyApi* | [**GetCompanySecurities**](docs/CompanyApi.md#getcompanysecurities) | **GET** /companies/{identifier}/securities | All Securities by Company
*CompanyApi* | [**InsiderTransactionFilingsByCompany**](docs/CompanyApi.md#insidertransactionfilingsbycompany) | **GET** /companies/{identifier}/insider_transaction_filings | Insider Transaction Filings by Company
*CompanyApi* | [**LatestInsiderTransactionFilingByCompany**](docs/CompanyApi.md#latestinsidertransactionfilingbycompany) | **GET** /companies/{identifier}/insider_transaction_filings/latest | Latest Insider Transaction Filing by Company
*CompanyApi* | [**LookupCompanyFundamental**](docs/CompanyApi.md#lookupcompanyfundamental) | **GET** /companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental by Company
*CompanyApi* | [**RecognizeCompany**](docs/CompanyApi.md#recognizecompany) | **GET** /companies/recognize | Recognize Company
*CompanyApi* | [**SearchCompanies**](docs/CompanyApi.md#searchcompanies) | **GET** /companies/search | Search Companies
*CompanyApi* | [**SharesOutstandingByCompany**](docs/CompanyApi.md#sharesoutstandingbycompany) | **GET** /companies/{identifier}/shares_outstanding | Shares Outstanding by Company
*DataPointApi* | [**GetDataPointNumber**](docs/DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{tag}/number | Data Point (Number)
*DataPointApi* | [**GetDataPointText**](docs/DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{tag}/text | Data Point (Text)
*DataTagApi* | [**GetAllDataTags**](docs/DataTagApi.md#getalldatatags) | **GET** /data_tags | All Data Tags
*DataTagApi* | [**GetDataTagById**](docs/DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Lookup Data Tag
*DataTagApi* | [**SearchDataTags**](docs/DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags
*ESGApi* | [**GetEsgCompanies**](docs/ESGApi.md#getesgcompanies) | **GET** /esg/companies | ESG Companies
*ESGApi* | [**GetEsgCompanyComprehensiveRatings**](docs/ESGApi.md#getesgcompanycomprehensiveratings) | **GET** /esg/{identifier}/comprehensive | ESG Company Comprehensive Ratings History
*ESGApi* | [**GetEsgCompanyRatings**](docs/ESGApi.md#getesgcompanyratings) | **GET** /esg/{identifier} | ESG Company Ratings History
*ESGApi* | [**GetEsgLatest**](docs/ESGApi.md#getesglatest) | **GET** /esg | ESG Latest
*ESGApi* | [**GetEsgLatestComprehensive**](docs/ESGApi.md#getesglatestcomprehensive) | **GET** /esg/comprehensive | ESG Latest Comprehensive
*ETFsApi* | [**GetAllEtfs**](docs/ETFsApi.md#getalletfs) | **GET** /etfs | All ETFs
*ETFsApi* | [**GetEtf**](docs/ETFsApi.md#getetf) | **GET** /etfs/{identifier} | Lookup ETF
*ETFsApi* | [**GetEtfAnalytics**](docs/ETFsApi.md#getetfanalytics) | **GET** /etfs/{identifier}/analytics | ETF Analytics
*ETFsApi* | [**GetEtfHistoricalStats**](docs/ETFsApi.md#getetfhistoricalstats) | **GET** /etfs/{identifier}/historical_stats | Exchange Traded Fund (ETF) Historical Stats
*ETFsApi* | [**GetEtfHoldings**](docs/ETFsApi.md#getetfholdings) | **GET** /etfs/{identifier}/holdings | ETF Holdings
*ETFsApi* | [**GetEtfStats**](docs/ETFsApi.md#getetfstats) | **GET** /etfs/{identifier}/stats | Exchange Traded Fund (ETF) Stats
*ETFsApi* | [**SearchEtfs**](docs/ETFsApi.md#searchetfs) | **GET** /etfs/search | Search ETFs
*FilingApi* | [**GetAllFilings**](docs/FilingApi.md#getallfilings) | **GET** /filings | All Filings
*FilingApi* | [**GetAllNotes**](docs/FilingApi.md#getallnotes) | **GET** /filings/notes | All Filing Notes
*FilingApi* | [**GetFilingAnswers**](docs/FilingApi.md#getfilinganswers) | **GET** /filings/{identifier}/answers | Filing Answers
*FilingApi* | [**GetFilingById**](docs/FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
*FilingApi* | [**GetFilingFundamentals**](docs/FilingApi.md#getfilingfundamentals) | **GET** /filings/{identifier}/fundamentals | All Fundamentals by Filing
*FilingApi* | [**GetFilingHtml**](docs/FilingApi.md#getfilinghtml) | **GET** /filings/{identifier}/html | Filing Html
*FilingApi* | [**GetFilingText**](docs/FilingApi.md#getfilingtext) | **GET** /filings/{identifier}/text | Filing Text
*FilingApi* | [**GetNote**](docs/FilingApi.md#getnote) | **GET** /filings/notes/{identifier} | Filing Note by ID
*FilingApi* | [**GetNoteHtml**](docs/FilingApi.md#getnotehtml) | **GET** /filings/notes/{identifier}/html | Filing Note HTML
*FilingApi* | [**GetNoteText**](docs/FilingApi.md#getnotetext) | **GET** /filings/notes/{identifier}/text | Filing Note Text
*FilingApi* | [**SearchNotes**](docs/FilingApi.md#searchnotes) | **GET** /filings/notes/search | Search Filing Notes
*ForexApi* | [**GetForexCurrencies**](docs/ForexApi.md#getforexcurrencies) | **GET** /forex/currencies | Forex Currencies
*ForexApi* | [**GetForexPairs**](docs/ForexApi.md#getforexpairs) | **GET** /forex/pairs | Forex Currency Pairs
*ForexApi* | [**GetForexPrices**](docs/ForexApi.md#getforexprices) | **GET** /forex/prices/{pair}/{timeframe} | Forex Currency Prices
*FundamentalsApi* | [**FilterFundamental**](docs/FundamentalsApi.md#filterfundamental) | **GET** /fundamentals | Filter Fundamental
*FundamentalsApi* | [**GetFundamentalById**](docs/FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Fundamental by ID
*FundamentalsApi* | [**GetFundamentalReportedFinancials**](docs/FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Reported Financials
*FundamentalsApi* | [**GetFundamentalStandardizedFinancials**](docs/FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Standardized Financials
*FundamentalsApi* | [**GetFundamentalStandardizedFinancialsDimensions**](docs/FundamentalsApi.md#getfundamentalstandardizedfinancialsdimensions) | **GET** /fundamentals/{id}/standardized_financials/dimensions/{tag} | Standardized Financials Dimensions
*FundamentalsApi* | [**LookupFundamental**](docs/FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental
*HistoricalDataApi* | [**GetHistoricalData**](docs/HistoricalDataApi.md#gethistoricaldata) | **GET** /historical_data/{identifier}/{tag} | Historical Data
*IndexApi* | [**GetAllEconomicIndices**](docs/IndexApi.md#getalleconomicindices) | **GET** /indices/economic | All Economic Indices
*IndexApi* | [**GetAllEodIndexPrices**](docs/IndexApi.md#getalleodindexprices) | **GET** /indices/prices/eod | All End of Day Index Prices
*IndexApi* | [**GetAllIndexSummaries**](docs/IndexApi.md#getallindexsummaries) | **GET** /indices | All Index Summaries
*IndexApi* | [**GetAllRealtimeIndexPrices**](docs/IndexApi.md#getallrealtimeindexprices) | **GET** /indices/prices/realtime | All Realtime Index Prices
*IndexApi* | [**GetAllSicIndices**](docs/IndexApi.md#getallsicindices) | **GET** /indices/sic | All SIC Indices
*IndexApi* | [**GetAllStockMarketIndices**](docs/IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | All Stock Market Indices
*IndexApi* | [**GetEconomicIndexById**](docs/IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Lookup Economic Index
*IndexApi* | [**GetEconomicIndexDataPointNumber**](docs/IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Data Point (Number) for an Economic Index
*IndexApi* | [**GetEconomicIndexDataPointText**](docs/IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Data Point (Text) for an Economic Index
*IndexApi* | [**GetEconomicIndexHistoricalData**](docs/IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Historical Data for an Economic Index
*IndexApi* | [**GetEodIndexPriceById**](docs/IndexApi.md#geteodindexpricebyid) | **GET** /indices/{identifier}/eod | End of Day Index Prices By Identifier
*IndexApi* | [**GetIndexConstituentsById**](docs/IndexApi.md#getindexconstituentsbyid) | **GET** /indices/{identifier}/constituents | Index Constituents By Index Identifier
*IndexApi* | [**GetIndexIntervals**](docs/IndexApi.md#getindexintervals) | **GET** /indices/{identifier}/intervals | Index Intervals
*IndexApi* | [**GetIndexSummaryById**](docs/IndexApi.md#getindexsummarybyid) | **GET** /indices/{identifier} | Index Summary By Identifier
*IndexApi* | [**GetRealtimeIndexPriceById**](docs/IndexApi.md#getrealtimeindexpricebyid) | **GET** /indices/{identifier}/realtime | Realtime Index Price By Identifier
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
*InsiderTransactionFilingsApi* | [**GetAllInsiderTransactionFilings**](docs/InsiderTransactionFilingsApi.md#getallinsidertransactionfilings) | **GET** /insider_transaction_filings | All Insider Transactions Filings
*MarketApi* | [**GetMarketStatus**](docs/MarketApi.md#getmarketstatus) | **GET** /market/status | Market Status
*MunicipalityApi* | [**GetAllMunicipalities**](docs/MunicipalityApi.md#getallmunicipalities) | **GET** /municipalities | All Municipalities
*MunicipalityApi* | [**GetMunicipalityById**](docs/MunicipalityApi.md#getmunicipalitybyid) | **GET** /municipalities/{id} | Municipality by ID
*MunicipalityApi* | [**GetMunicipalityFinancials**](docs/MunicipalityApi.md#getmunicipalityfinancials) | **GET** /municipalities/{id}/financials | Financials for a Municipality
*OptionsApi* | [**GetAllOptionsTickers**](docs/OptionsApi.md#getalloptionstickers) | **GET** /options/tickers | Options Tickers
*OptionsApi* | [**GetOptionAggregates**](docs/OptionsApi.md#getoptionaggregates) | **GET** /options/aggregates | Total open interest and volume aggregated by ticker
*OptionsApi* | [**GetOptionExpirationsRealtime**](docs/OptionsApi.md#getoptionexpirationsrealtime) | **GET** /options/expirations/{symbol}/realtime | Options Expirations
*OptionsApi* | [**GetOptionStrikesRealtime**](docs/OptionsApi.md#getoptionstrikesrealtime) | **GET** /options/strikes/{symbol}/{strike}/realtime | Option Strikes Realtime
*OptionsApi* | [**GetOptionTrades**](docs/OptionsApi.md#getoptiontrades) | **GET** /options/trades | Option Trades
*OptionsApi* | [**GetOptionTradesByContract**](docs/OptionsApi.md#getoptiontradesbycontract) | **GET** /options/{identifier}/trades | Option Trades By Contract
*OptionsApi* | [**GetOptions**](docs/OptionsApi.md#getoptions) | **GET** /options/{symbol} | Options
*OptionsApi* | [**GetOptionsBySymbolRealtime**](docs/OptionsApi.md#getoptionsbysymbolrealtime) | **GET** /options/{symbol}/realtime | Options by Symbol Realtime
*OptionsApi* | [**GetOptionsChain**](docs/OptionsApi.md#getoptionschain) | **GET** /options/chain/{symbol}/{expiration} | Options Chain
*OptionsApi* | [**GetOptionsChainEod**](docs/OptionsApi.md#getoptionschaineod) | **GET** /options/chain/{symbol}/{expiration}/eod | Options Chain EOD
*OptionsApi* | [**GetOptionsChainRealtime**](docs/OptionsApi.md#getoptionschainrealtime) | **GET** /options/chain/{symbol}/{expiration}/realtime | Options Chain Realtime
*OptionsApi* | [**GetOptionsExpirations**](docs/OptionsApi.md#getoptionsexpirations) | **GET** /options/expirations/{symbol} | Options Expirations
*OptionsApi* | [**GetOptionsExpirationsEod**](docs/OptionsApi.md#getoptionsexpirationseod) | **GET** /options/expirations/{symbol}/eod | Options Expirations
*OptionsApi* | [**GetOptionsGreeksByContract**](docs/OptionsApi.md#getoptionsgreeksbycontract) | **GET** /options/greeks/{contract}/realtime | Option Greeks & Derived Price by Contract
*OptionsApi* | [**GetOptionsGreeksByTicker**](docs/OptionsApi.md#getoptionsgreeksbyticker) | **GET** /options/greeks/by_ticker/{identifier}/realtime | Options Realtime Greeks & Derived Price by Ticker
*OptionsApi* | [**GetOptionsImpliedMoveBySymbol**](docs/OptionsApi.md#getoptionsimpliedmovebysymbol) | **GET** /options/implied_move/{symbol}/{expiration_date} | Options Implied Move By Symbol
*OptionsApi* | [**GetOptionsIntervalByContract**](docs/OptionsApi.md#getoptionsintervalbycontract) | **GET** /options/interval/{identifier} | Options Intervals By Contract
*OptionsApi* | [**GetOptionsIntervalMovers**](docs/OptionsApi.md#getoptionsintervalmovers) | **GET** /options/interval/movers | Options Intervals Movers
*OptionsApi* | [**GetOptionsIntervalMoversChange**](docs/OptionsApi.md#getoptionsintervalmoverschange) | **GET** /options/interval/movers/change | Options Intervals Movers By Change
*OptionsApi* | [**GetOptionsIntervalMoversVolume**](docs/OptionsApi.md#getoptionsintervalmoversvolume) | **GET** /options/interval/movers/volume | Options Intervals Movers By Volume
*OptionsApi* | [**GetOptionsPrices**](docs/OptionsApi.md#getoptionsprices) | **GET** /options/prices/{identifier} | Option Prices
*OptionsApi* | [**GetOptionsPricesBatchRealtime**](docs/OptionsApi.md#getoptionspricesbatchrealtime) | **POST** /options/prices/realtime/batch | Option Prices Batch Realtime
*OptionsApi* | [**GetOptionsPricesEod**](docs/OptionsApi.md#getoptionspriceseod) | **GET** /options/prices/{identifier}/eod | Option Prices EOD
*OptionsApi* | [**GetOptionsPricesEodByTicker**](docs/OptionsApi.md#getoptionspriceseodbyticker) | **GET** /options/prices/by_ticker/{symbol}/eod | Option Prices End of Day By Ticker
*OptionsApi* | [**GetOptionsPricesRealtime**](docs/OptionsApi.md#getoptionspricesrealtime) | **GET** /options/prices/{identifier}/realtime | Option Prices Realtime
*OptionsApi* | [**GetOptionsPricesRealtimeByTicker**](docs/OptionsApi.md#getoptionspricesrealtimebyticker) | **GET** /options/prices/by_ticker/{symbol}/realtime | Option Prices Realtime By Ticker
*OptionsApi* | [**GetOptionsSnapshots**](docs/OptionsApi.md#getoptionssnapshots) | **GET** /options/snapshots | Option Prices Realtime Snapshot
*OptionsApi* | [**GetOptionsStatsRealtime**](docs/OptionsApi.md#getoptionsstatsrealtime) | **GET** /options/prices/{identifier}/realtime/stats | Option Stats Realtime
*OptionsApi* | [**GetUnusualActivity**](docs/OptionsApi.md#getunusualactivity) | **GET** /options/unusual_activity/{symbol} | Options Unusual Activity
*OptionsApi* | [**GetUnusualActivityIntraday**](docs/OptionsApi.md#getunusualactivityintraday) | **GET** /options/unusual_activity/{symbol}/intraday | Options Unusual Activity Intraday
*OptionsApi* | [**GetUnusualActivityUniversal**](docs/OptionsApi.md#getunusualactivityuniversal) | **GET** /options/unusual_activity | Options Unusual Activity Universal
*OptionsApi* | [**GetUnusualActivityUniversalIntraday**](docs/OptionsApi.md#getunusualactivityuniversalintraday) | **GET** /options/unusual_activity/intraday | Options Unusual Activity Universal Intraday
*OwnersApi* | [**GetAllOwners**](docs/OwnersApi.md#getallowners) | **GET** /owners | All Owners
*OwnersApi* | [**GetOwnerById**](docs/OwnersApi.md#getownerbyid) | **GET** /owners/{identifier} | Owner by ID
*OwnersApi* | [**InsiderTransactionFilingsByOwner**](docs/OwnersApi.md#insidertransactionfilingsbyowner) | **GET** /owners/{identifier}/insider_transaction_filings | Insider Transaction Filings by Owner
*OwnersApi* | [**InstitutionalHoldingsByOwner**](docs/OwnersApi.md#institutionalholdingsbyowner) | **GET** /owners/{identifier}/institutional_holdings | Institutional Holdings by Owner
*OwnersApi* | [**SearchOwners**](docs/OwnersApi.md#searchowners) | **GET** /owners/search | Search Owners
*SecurityApi* | [**GetAllSecurities**](docs/SecurityApi.md#getallsecurities) | **GET** /securities | All Securities
*SecurityApi* | [**GetSecuritiesLatestDividendRecords**](docs/SecurityApi.md#getsecuritieslatestdividendrecords) | **GET** /securities/dividends/latest | Latest Dividend Records for All Securities
*SecurityApi* | [**GetSecuritiesLatestEarningsRecords**](docs/SecurityApi.md#getsecuritieslatestearningsrecords) | **GET** /securities/earnings/latest | Latest Earnings Records for All Securities
*SecurityApi* | [**GetSecuritiesShortInterest**](docs/SecurityApi.md#getsecuritiesshortinterest) | **GET** /securities/short_interest | Latest Short Interest
*SecurityApi* | [**GetSecurityById**](docs/SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Lookup Security
*SecurityApi* | [**GetSecurityDataPointNumber**](docs/SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{tag}/number | Data Point (Number) for Security
*SecurityApi* | [**GetSecurityDataPointText**](docs/SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{tag}/text | Data Point (Text) for Security
*SecurityApi* | [**GetSecurityHistoricalData**](docs/SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{tag} | Historical Data for Security
*SecurityApi* | [**GetSecurityHistoryByIdentifier**](docs/SecurityApi.md#getsecurityhistorybyidentifier) | **GET** /securities/history-by-identifier/{identifier} | Security History By Identifier
*SecurityApi* | [**GetSecurityHistoryByTicker**](docs/SecurityApi.md#getsecurityhistorybyticker) | **GET** /securities/history-by-ticker/{ticker} | Security History By Ticker
*SecurityApi* | [**GetSecurityInsiderOwnership**](docs/SecurityApi.md#getsecurityinsiderownership) | **GET** /securities/{identifier}/institutional_ownership | Institutional Ownership by Security
*SecurityApi* | [**GetSecurityIntervalMovers**](docs/SecurityApi.md#getsecurityintervalmovers) | **GET** /securities/market_movers | Security Intervals Movers
*SecurityApi* | [**GetSecurityIntervalMoversChange**](docs/SecurityApi.md#getsecurityintervalmoverschange) | **GET** /securities/market_movers/change | Security Intervals Movers By Change
*SecurityApi* | [**GetSecurityIntervalMoversVolume**](docs/SecurityApi.md#getsecurityintervalmoversvolume) | **GET** /securities/market_movers/volume | Security Intervals Movers By Volume
*SecurityApi* | [**GetSecurityIntervalPrices**](docs/SecurityApi.md#getsecurityintervalprices) | **GET** /securities/{identifier}/prices/intervals | Interval Stock Prices for Security
*SecurityApi* | [**GetSecurityLatestDividendRecord**](docs/SecurityApi.md#getsecuritylatestdividendrecord) | **GET** /securities/{identifier}/dividends/latest | Latest Dividend Record for Security
*SecurityApi* | [**GetSecurityLatestEarningsRecord**](docs/SecurityApi.md#getsecuritylatestearningsrecord) | **GET** /securities/{identifier}/earnings/latest | Latest Earnings Record for Security
*SecurityApi* | [**GetSecurityPriceTechnicalsAdi**](docs/SecurityApi.md#getsecuritypricetechnicalsadi) | **GET** /securities/{identifier}/prices/technicals/adi | Accumulation/Distribution Index
*SecurityApi* | [**GetSecurityPriceTechnicalsAdtv**](docs/SecurityApi.md#getsecuritypricetechnicalsadtv) | **GET** /securities/{identifier}/prices/technicals/adtv | Average Daily Trading Volume
*SecurityApi* | [**GetSecurityPriceTechnicalsAdx**](docs/SecurityApi.md#getsecuritypricetechnicalsadx) | **GET** /securities/{identifier}/prices/technicals/adx | Average Directional Index
*SecurityApi* | [**GetSecurityPriceTechnicalsAo**](docs/SecurityApi.md#getsecuritypricetechnicalsao) | **GET** /securities/{identifier}/prices/technicals/ao | Awesome Oscillator
*SecurityApi* | [**GetSecurityPriceTechnicalsAtr**](docs/SecurityApi.md#getsecuritypricetechnicalsatr) | **GET** /securities/{identifier}/prices/technicals/atr | Average True Range
*SecurityApi* | [**GetSecurityPriceTechnicalsBb**](docs/SecurityApi.md#getsecuritypricetechnicalsbb) | **GET** /securities/{identifier}/prices/technicals/bb | Bollinger Bands
*SecurityApi* | [**GetSecurityPriceTechnicalsCci**](docs/SecurityApi.md#getsecuritypricetechnicalscci) | **GET** /securities/{identifier}/prices/technicals/cci | Commodity Channel Index
*SecurityApi* | [**GetSecurityPriceTechnicalsCmf**](docs/SecurityApi.md#getsecuritypricetechnicalscmf) | **GET** /securities/{identifier}/prices/technicals/cmf | Chaikin Money Flow
*SecurityApi* | [**GetSecurityPriceTechnicalsDc**](docs/SecurityApi.md#getsecuritypricetechnicalsdc) | **GET** /securities/{identifier}/prices/technicals/dc | Donchian Channel
*SecurityApi* | [**GetSecurityPriceTechnicalsDpo**](docs/SecurityApi.md#getsecuritypricetechnicalsdpo) | **GET** /securities/{identifier}/prices/technicals/dpo | Detrended Price Oscillator
*SecurityApi* | [**GetSecurityPriceTechnicalsEom**](docs/SecurityApi.md#getsecuritypricetechnicalseom) | **GET** /securities/{identifier}/prices/technicals/eom | Ease of Movement
*SecurityApi* | [**GetSecurityPriceTechnicalsFi**](docs/SecurityApi.md#getsecuritypricetechnicalsfi) | **GET** /securities/{identifier}/prices/technicals/fi | Force Index
*SecurityApi* | [**GetSecurityPriceTechnicalsIchimoku**](docs/SecurityApi.md#getsecuritypricetechnicalsichimoku) | **GET** /securities/{identifier}/prices/technicals/ichimoku | Ichimoku Kinko Hyo
*SecurityApi* | [**GetSecurityPriceTechnicalsKc**](docs/SecurityApi.md#getsecuritypricetechnicalskc) | **GET** /securities/{identifier}/prices/technicals/kc | Keltner Channel
*SecurityApi* | [**GetSecurityPriceTechnicalsKst**](docs/SecurityApi.md#getsecuritypricetechnicalskst) | **GET** /securities/{identifier}/prices/technicals/kst | Know Sure Thing
*SecurityApi* | [**GetSecurityPriceTechnicalsMacd**](docs/SecurityApi.md#getsecuritypricetechnicalsmacd) | **GET** /securities/{identifier}/prices/technicals/macd | Moving Average Convergence Divergence
*SecurityApi* | [**GetSecurityPriceTechnicalsMfi**](docs/SecurityApi.md#getsecuritypricetechnicalsmfi) | **GET** /securities/{identifier}/prices/technicals/mfi | Money Flow Index
*SecurityApi* | [**GetSecurityPriceTechnicalsMi**](docs/SecurityApi.md#getsecuritypricetechnicalsmi) | **GET** /securities/{identifier}/prices/technicals/mi | Mass Index
*SecurityApi* | [**GetSecurityPriceTechnicalsNvi**](docs/SecurityApi.md#getsecuritypricetechnicalsnvi) | **GET** /securities/{identifier}/prices/technicals/nvi | Negative Volume Index
*SecurityApi* | [**GetSecurityPriceTechnicalsObv**](docs/SecurityApi.md#getsecuritypricetechnicalsobv) | **GET** /securities/{identifier}/prices/technicals/obv | On-balance Volume
*SecurityApi* | [**GetSecurityPriceTechnicalsObvMean**](docs/SecurityApi.md#getsecuritypricetechnicalsobvmean) | **GET** /securities/{identifier}/prices/technicals/obv_mean | On-balance Volume Mean
*SecurityApi* | [**GetSecurityPriceTechnicalsRsi**](docs/SecurityApi.md#getsecuritypricetechnicalsrsi) | **GET** /securities/{identifier}/prices/technicals/rsi | Relative Strength Index
*SecurityApi* | [**GetSecurityPriceTechnicalsSma**](docs/SecurityApi.md#getsecuritypricetechnicalssma) | **GET** /securities/{identifier}/prices/technicals/sma | Simple Moving Average
*SecurityApi* | [**GetSecurityPriceTechnicalsSr**](docs/SecurityApi.md#getsecuritypricetechnicalssr) | **GET** /securities/{identifier}/prices/technicals/sr | Stochastic Oscillator
*SecurityApi* | [**GetSecurityPriceTechnicalsTrix**](docs/SecurityApi.md#getsecuritypricetechnicalstrix) | **GET** /securities/{identifier}/prices/technicals/trix | Triple Exponential Average
*SecurityApi* | [**GetSecurityPriceTechnicalsTsi**](docs/SecurityApi.md#getsecuritypricetechnicalstsi) | **GET** /securities/{identifier}/prices/technicals/tsi | True Strength Index
*SecurityApi* | [**GetSecurityPriceTechnicalsUo**](docs/SecurityApi.md#getsecuritypricetechnicalsuo) | **GET** /securities/{identifier}/prices/technicals/uo | Ultimate Oscillator
*SecurityApi* | [**GetSecurityPriceTechnicalsVi**](docs/SecurityApi.md#getsecuritypricetechnicalsvi) | **GET** /securities/{identifier}/prices/technicals/vi | Vortex Indicator
*SecurityApi* | [**GetSecurityPriceTechnicalsVpt**](docs/SecurityApi.md#getsecuritypricetechnicalsvpt) | **GET** /securities/{identifier}/prices/technicals/vpt | Volume-price Trend
*SecurityApi* | [**GetSecurityPriceTechnicalsVwap**](docs/SecurityApi.md#getsecuritypricetechnicalsvwap) | **GET** /securities/{identifier}/prices/technicals/vwap | Volume Weighted Average Price
*SecurityApi* | [**GetSecurityPriceTechnicalsWr**](docs/SecurityApi.md#getsecuritypricetechnicalswr) | **GET** /securities/{identifier}/prices/technicals/wr | Williams %R
*SecurityApi* | [**GetSecurityQuote**](docs/SecurityApi.md#getsecurityquote) | **GET** /securities/{identifier}/quote | Quote for a Security
*SecurityApi* | [**GetSecurityRealtimePrice**](docs/SecurityApi.md#getsecurityrealtimeprice) | **GET** /securities/{identifier}/prices/realtime | Realtime Stock Price for Security
*SecurityApi* | [**GetSecurityReplayFile**](docs/SecurityApi.md#getsecurityreplayfile) | **GET** /securities/replay | Security Replay File
*SecurityApi* | [**GetSecurityShortInterest**](docs/SecurityApi.md#getsecurityshortinterest) | **GET** /securities/{identifier}/short_interest | Short Interest by Security
*SecurityApi* | [**GetSecuritySnapshots**](docs/SecurityApi.md#getsecuritysnapshots) | **GET** /securities/snapshots | Realtime Stock Prices Snapshot
*SecurityApi* | [**GetSecurityStockPriceAdjustments**](docs/SecurityApi.md#getsecuritystockpriceadjustments) | **GET** /securities/{identifier}/prices/adjustments | Stock Price Adjustments by Security
*SecurityApi* | [**GetSecurityStockPriceAdjustmentsDividends**](docs/SecurityApi.md#getsecuritystockpriceadjustmentsdividends) | **GET** /securities/{identifier}/prices/adjustments/dividends | Dividends by Security
*SecurityApi* | [**GetSecurityStockPriceAdjustmentsSplits**](docs/SecurityApi.md#getsecuritystockpriceadjustmentssplits) | **GET** /securities/{identifier}/prices/adjustments/splits | Splits by Security
*SecurityApi* | [**GetSecurityStockPrices**](docs/SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Stock Prices by Security
*SecurityApi* | [**GetSecurityTrades**](docs/SecurityApi.md#getsecuritytrades) | **GET** /securities/trades | Security Trades
*SecurityApi* | [**GetSecurityTradesBySymbol**](docs/SecurityApi.md#getsecuritytradesbysymbol) | **GET** /securities/{identifier}/trades | Security Trades By Symbol
*SecurityApi* | [**GetSecurityZacksAnalystRatings**](docs/SecurityApi.md#getsecurityzacksanalystratings) | **GET** /securities/{identifier}/zacks/analyst_ratings | Zacks Analyst Ratings for Security
*SecurityApi* | [**GetSecurityZacksAnalystRatingsSnapshot**](docs/SecurityApi.md#getsecurityzacksanalystratingssnapshot) | **GET** /securities/{identifier}/zacks/analyst_ratings/snapshot | Zacks Analyst Ratings Snapshot
*SecurityApi* | [**GetSecurityZacksEpsSurprises**](docs/SecurityApi.md#getsecurityzacksepssurprises) | **GET** /securities/{identifier}/zacks/eps_surprises | Zacks EPS Surprises for Security
*SecurityApi* | [**GetSecurityZacksSalesSurprises**](docs/SecurityApi.md#getsecurityzackssalessurprises) | **GET** /securities/{identifier}/zacks/sales_surprises | Zacks Sales Surprises for Security
*SecurityApi* | [**ScreenSecurities**](docs/SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
*SecurityApi* | [**SearchSecurities**](docs/SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities
*StockExchangeApi* | [**GetAllStockExchanges**](docs/StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | All Stock Exchanges
*StockExchangeApi* | [**GetStockExchangeBetas**](docs/StockExchangeApi.md#getstockexchangebetas) | **GET** /stock_exchanges/{identifier}/betas | Security Betas
*StockExchangeApi* | [**GetStockExchangeById**](docs/StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Lookup Stock Exchange
*StockExchangeApi* | [**GetStockExchangeGainers**](docs/StockExchangeApi.md#getstockexchangegainers) | **GET** /stock_exchanges/{identifier}/gainers | Top Gainers by Exchange
*StockExchangeApi* | [**GetStockExchangeLosers**](docs/StockExchangeApi.md#getstockexchangelosers) | **GET** /stock_exchanges/{identifier}/losers | Top Losers by Exchange
*StockExchangeApi* | [**GetStockExchangePriceAdjustments**](docs/StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Stock Price Adjustments by Exchange
*StockExchangeApi* | [**GetStockExchangePriceAdjustmentsDividends**](docs/StockExchangeApi.md#getstockexchangepriceadjustmentsdividends) | **GET** /stock_exchanges/{identifier}/prices/adjustments/dividends | Dividends by date for exchange
*StockExchangeApi* | [**GetStockExchangePriceAdjustmentsSplits**](docs/StockExchangeApi.md#getstockexchangepriceadjustmentssplits) | **GET** /stock_exchanges/{identifier}/prices/adjustments/splits | Splits by date for exchange
*StockExchangeApi* | [**GetStockExchangePrices**](docs/StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeQuote**](docs/StockExchangeApi.md#getstockexchangequote) | **GET** /stock_exchanges/{identifier}/quote | Realtime Quote Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeRealtimePrices**](docs/StockExchangeApi.md#getstockexchangerealtimeprices) | **GET** /stock_exchanges/{identifier}/prices/realtime | Realtime Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeSecurities**](docs/StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Securities by Exchange
*TechnicalApi* | [**GetSecurityPriceTechnicalsAdi**](docs/TechnicalApi.md#getsecuritypricetechnicalsadi) | **GET** /securities/{identifier}/prices/technicals/adi | Accumulation/Distribution Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsAdtv**](docs/TechnicalApi.md#getsecuritypricetechnicalsadtv) | **GET** /securities/{identifier}/prices/technicals/adtv | Average Daily Trading Volume
*TechnicalApi* | [**GetSecurityPriceTechnicalsAdx**](docs/TechnicalApi.md#getsecuritypricetechnicalsadx) | **GET** /securities/{identifier}/prices/technicals/adx | Average Directional Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsAo**](docs/TechnicalApi.md#getsecuritypricetechnicalsao) | **GET** /securities/{identifier}/prices/technicals/ao | Awesome Oscillator
*TechnicalApi* | [**GetSecurityPriceTechnicalsAtr**](docs/TechnicalApi.md#getsecuritypricetechnicalsatr) | **GET** /securities/{identifier}/prices/technicals/atr | Average True Range
*TechnicalApi* | [**GetSecurityPriceTechnicalsBb**](docs/TechnicalApi.md#getsecuritypricetechnicalsbb) | **GET** /securities/{identifier}/prices/technicals/bb | Bollinger Bands
*TechnicalApi* | [**GetSecurityPriceTechnicalsCci**](docs/TechnicalApi.md#getsecuritypricetechnicalscci) | **GET** /securities/{identifier}/prices/technicals/cci | Commodity Channel Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsCmf**](docs/TechnicalApi.md#getsecuritypricetechnicalscmf) | **GET** /securities/{identifier}/prices/technicals/cmf | Chaikin Money Flow
*TechnicalApi* | [**GetSecurityPriceTechnicalsDc**](docs/TechnicalApi.md#getsecuritypricetechnicalsdc) | **GET** /securities/{identifier}/prices/technicals/dc | Donchian Channel
*TechnicalApi* | [**GetSecurityPriceTechnicalsDpo**](docs/TechnicalApi.md#getsecuritypricetechnicalsdpo) | **GET** /securities/{identifier}/prices/technicals/dpo | Detrended Price Oscillator
*TechnicalApi* | [**GetSecurityPriceTechnicalsEom**](docs/TechnicalApi.md#getsecuritypricetechnicalseom) | **GET** /securities/{identifier}/prices/technicals/eom | Ease of Movement
*TechnicalApi* | [**GetSecurityPriceTechnicalsFi**](docs/TechnicalApi.md#getsecuritypricetechnicalsfi) | **GET** /securities/{identifier}/prices/technicals/fi | Force Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsIchimoku**](docs/TechnicalApi.md#getsecuritypricetechnicalsichimoku) | **GET** /securities/{identifier}/prices/technicals/ichimoku | Ichimoku Kinko Hyo
*TechnicalApi* | [**GetSecurityPriceTechnicalsKc**](docs/TechnicalApi.md#getsecuritypricetechnicalskc) | **GET** /securities/{identifier}/prices/technicals/kc | Keltner Channel
*TechnicalApi* | [**GetSecurityPriceTechnicalsKst**](docs/TechnicalApi.md#getsecuritypricetechnicalskst) | **GET** /securities/{identifier}/prices/technicals/kst | Know Sure Thing
*TechnicalApi* | [**GetSecurityPriceTechnicalsMacd**](docs/TechnicalApi.md#getsecuritypricetechnicalsmacd) | **GET** /securities/{identifier}/prices/technicals/macd | Moving Average Convergence Divergence
*TechnicalApi* | [**GetSecurityPriceTechnicalsMfi**](docs/TechnicalApi.md#getsecuritypricetechnicalsmfi) | **GET** /securities/{identifier}/prices/technicals/mfi | Money Flow Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsMi**](docs/TechnicalApi.md#getsecuritypricetechnicalsmi) | **GET** /securities/{identifier}/prices/technicals/mi | Mass Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsNvi**](docs/TechnicalApi.md#getsecuritypricetechnicalsnvi) | **GET** /securities/{identifier}/prices/technicals/nvi | Negative Volume Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsObv**](docs/TechnicalApi.md#getsecuritypricetechnicalsobv) | **GET** /securities/{identifier}/prices/technicals/obv | On-balance Volume
*TechnicalApi* | [**GetSecurityPriceTechnicalsObvMean**](docs/TechnicalApi.md#getsecuritypricetechnicalsobvmean) | **GET** /securities/{identifier}/prices/technicals/obv_mean | On-balance Volume Mean
*TechnicalApi* | [**GetSecurityPriceTechnicalsRsi**](docs/TechnicalApi.md#getsecuritypricetechnicalsrsi) | **GET** /securities/{identifier}/prices/technicals/rsi | Relative Strength Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsSma**](docs/TechnicalApi.md#getsecuritypricetechnicalssma) | **GET** /securities/{identifier}/prices/technicals/sma | Simple Moving Average
*TechnicalApi* | [**GetSecurityPriceTechnicalsSr**](docs/TechnicalApi.md#getsecuritypricetechnicalssr) | **GET** /securities/{identifier}/prices/technicals/sr | Stochastic Oscillator
*TechnicalApi* | [**GetSecurityPriceTechnicalsTrix**](docs/TechnicalApi.md#getsecuritypricetechnicalstrix) | **GET** /securities/{identifier}/prices/technicals/trix | Triple Exponential Average
*TechnicalApi* | [**GetSecurityPriceTechnicalsTsi**](docs/TechnicalApi.md#getsecuritypricetechnicalstsi) | **GET** /securities/{identifier}/prices/technicals/tsi | True Strength Index
*TechnicalApi* | [**GetSecurityPriceTechnicalsUo**](docs/TechnicalApi.md#getsecuritypricetechnicalsuo) | **GET** /securities/{identifier}/prices/technicals/uo | Ultimate Oscillator
*TechnicalApi* | [**GetSecurityPriceTechnicalsVi**](docs/TechnicalApi.md#getsecuritypricetechnicalsvi) | **GET** /securities/{identifier}/prices/technicals/vi | Vortex Indicator
*TechnicalApi* | [**GetSecurityPriceTechnicalsVpt**](docs/TechnicalApi.md#getsecuritypricetechnicalsvpt) | **GET** /securities/{identifier}/prices/technicals/vpt | Volume-price Trend
*TechnicalApi* | [**GetSecurityPriceTechnicalsVwap**](docs/TechnicalApi.md#getsecuritypricetechnicalsvwap) | **GET** /securities/{identifier}/prices/technicals/vwap | Volume Weighted Average Price
*TechnicalApi* | [**GetSecurityPriceTechnicalsWr**](docs/TechnicalApi.md#getsecuritypricetechnicalswr) | **GET** /securities/{identifier}/prices/technicals/wr | Williams %R
*ZacksApi* | [**GetZacksAnalystRatings**](docs/ZacksApi.md#getzacksanalystratings) | **GET** /zacks/analyst_ratings | Zacks Analyst Ratings
*ZacksApi* | [**GetZacksEbitdaConsensus**](docs/ZacksApi.md#getzacksebitdaconsensus) | **GET** /zacks/ebitda_consensus | Zacks EBITDA Consensus
*ZacksApi* | [**GetZacksEpsEstimates**](docs/ZacksApi.md#getzacksepsestimates) | **GET** /zacks/eps_estimates | Zacks EPS Estimates
*ZacksApi* | [**GetZacksEpsGrowthRates**](docs/ZacksApi.md#getzacksepsgrowthrates) | **GET** /zacks/eps_growth_rates | Zacks EPS Growth Rates
*ZacksApi* | [**GetZacksEpsSurprises**](docs/ZacksApi.md#getzacksepssurprises) | **GET** /zacks/eps_surprises | Zacks EPS Surprises
*ZacksApi* | [**GetZacksEtfHoldings**](docs/ZacksApi.md#getzacksetfholdings) | **GET** /zacks/etf_holdings | Zacks ETF Holdings
*ZacksApi* | [**GetZacksForwardPe**](docs/ZacksApi.md#getzacksforwardpe) | **GET** /zacks/forward_pe | Zacks Forward PE Estimates
*ZacksApi* | [**GetZacksForwardPeByIdentifier**](docs/ZacksApi.md#getzacksforwardpebyidentifier) | **GET** /zacks/forward_pe/{identifier} | Zacks Forward PE by identifer
*ZacksApi* | [**GetZacksInstitutionalHoldingCompanies**](docs/ZacksApi.md#getzacksinstitutionalholdingcompanies) | **GET** /zacks/institutional_holdings/companies | Zacks Institutional Holding Companies
*ZacksApi* | [**GetZacksInstitutionalHoldingOwners**](docs/ZacksApi.md#getzacksinstitutionalholdingowners) | **GET** /zacks/institutional_holdings/owners | Zacks Institutional Holding Owners
*ZacksApi* | [**GetZacksInstitutionalHoldings**](docs/ZacksApi.md#getzacksinstitutionalholdings) | **GET** /zacks/institutional_holdings | Zacks Institutional Holdings
*ZacksApi* | [**GetZacksLongTermGrowthRates**](docs/ZacksApi.md#getzackslongtermgrowthrates) | **GET** /zacks/long_term_growth_rates | Zacks Long Term Growth Rates
*ZacksApi* | [**GetZacksSalesEstimates**](docs/ZacksApi.md#getzackssalesestimates) | **GET** /zacks/sales_estimates | Zacks Sales Estimates
*ZacksApi* | [**GetZacksSalesSurprises**](docs/ZacksApi.md#getzackssalessurprises) | **GET** /zacks/sales_surprises | Zacks Sales Surprises
*ZacksApi* | [**GetZacksTargetPriceConsensuses**](docs/ZacksApi.md#getzackstargetpriceconsensuses) | **GET** /zacks/target_price_consensuses | Zacks Target Price Consensuses


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccumulationDistributionIndexTechnicalValue](docs/AccumulationDistributionIndexTechnicalValue.md)
 - [Model.ApiResponseBulkDownloadLinks](docs/ApiResponseBulkDownloadLinks.md)
 - [Model.ApiResponseCompanies](docs/ApiResponseCompanies.md)
 - [Model.ApiResponseCompaniesSearch](docs/ApiResponseCompaniesSearch.md)
 - [Model.ApiResponseCompanyAnswers](docs/ApiResponseCompanyAnswers.md)
 - [Model.ApiResponseCompanyDailyMetrics](docs/ApiResponseCompanyDailyMetrics.md)
 - [Model.ApiResponseCompanyFilings](docs/ApiResponseCompanyFilings.md)
 - [Model.ApiResponseCompanyFundamentals](docs/ApiResponseCompanyFundamentals.md)
 - [Model.ApiResponseCompanyHistoricalData](docs/ApiResponseCompanyHistoricalData.md)
 - [Model.ApiResponseCompanyInsiderTransactionFilings](docs/ApiResponseCompanyInsiderTransactionFilings.md)
 - [Model.ApiResponseCompanyNews](docs/ApiResponseCompanyNews.md)
 - [Model.ApiResponseCompanyNewsBody](docs/ApiResponseCompanyNewsBody.md)
 - [Model.ApiResponseCompanyPublicFloatResult](docs/ApiResponseCompanyPublicFloatResult.md)
 - [Model.ApiResponseCompanyRecognize](docs/ApiResponseCompanyRecognize.md)
 - [Model.ApiResponseCompanySecurities](docs/ApiResponseCompanySecurities.md)
 - [Model.ApiResponseCompanySharesOutstanding](docs/ApiResponseCompanySharesOutstanding.md)
 - [Model.ApiResponseDataTags](docs/ApiResponseDataTags.md)
 - [Model.ApiResponseDataTagsSearch](docs/ApiResponseDataTagsSearch.md)
 - [Model.ApiResponseESGCompanies](docs/ApiResponseESGCompanies.md)
 - [Model.ApiResponseESGCompanyComprehensiveRatingHistory](docs/ApiResponseESGCompanyComprehensiveRatingHistory.md)
 - [Model.ApiResponseESGCompanyRatingHistory](docs/ApiResponseESGCompanyRatingHistory.md)
 - [Model.ApiResponseESGLatest](docs/ApiResponseESGLatest.md)
 - [Model.ApiResponseESGLatestComprehensive](docs/ApiResponseESGLatestComprehensive.md)
 - [Model.ApiResponseETFHoldings](docs/ApiResponseETFHoldings.md)
 - [Model.ApiResponseETFs](docs/ApiResponseETFs.md)
 - [Model.ApiResponseEconomicIndexHistoricalData](docs/ApiResponseEconomicIndexHistoricalData.md)
 - [Model.ApiResponseEconomicIndices](docs/ApiResponseEconomicIndices.md)
 - [Model.ApiResponseEconomicIndicesSearch](docs/ApiResponseEconomicIndicesSearch.md)
 - [Model.ApiResponseEodIndexPrices](docs/ApiResponseEodIndexPrices.md)
 - [Model.ApiResponseEodIndexPricesAll](docs/ApiResponseEodIndexPricesAll.md)
 - [Model.ApiResponseFilingAnswers](docs/ApiResponseFilingAnswers.md)
 - [Model.ApiResponseFilingFundamentals](docs/ApiResponseFilingFundamentals.md)
 - [Model.ApiResponseFilingNotes](docs/ApiResponseFilingNotes.md)
 - [Model.ApiResponseFilingNotesSearch](docs/ApiResponseFilingNotesSearch.md)
 - [Model.ApiResponseFilings](docs/ApiResponseFilings.md)
 - [Model.ApiResponseForexCurrencies](docs/ApiResponseForexCurrencies.md)
 - [Model.ApiResponseForexPairs](docs/ApiResponseForexPairs.md)
 - [Model.ApiResponseForexPrices](docs/ApiResponseForexPrices.md)
 - [Model.ApiResponseHistoricalData](docs/ApiResponseHistoricalData.md)
 - [Model.ApiResponseIndex](docs/ApiResponseIndex.md)
 - [Model.ApiResponseIndexConstituents](docs/ApiResponseIndexConstituents.md)
 - [Model.ApiResponseIndexIntervals](docs/ApiResponseIndexIntervals.md)
 - [Model.ApiResponseIndices](docs/ApiResponseIndices.md)
 - [Model.ApiResponseInitialPublicOfferings](docs/ApiResponseInitialPublicOfferings.md)
 - [Model.ApiResponseInsiderTransactionFilings](docs/ApiResponseInsiderTransactionFilings.md)
 - [Model.ApiResponseMunicipalities](docs/ApiResponseMunicipalities.md)
 - [Model.ApiResponseMunicipalitiyFinancials](docs/ApiResponseMunicipalitiyFinancials.md)
 - [Model.ApiResponseNews](docs/ApiResponseNews.md)
 - [Model.ApiResponseOptionPrices](docs/ApiResponseOptionPrices.md)
 - [Model.ApiResponseOptions](docs/ApiResponseOptions.md)
 - [Model.ApiResponseOptionsAggregates](docs/ApiResponseOptionsAggregates.md)
 - [Model.ApiResponseOptionsChain](docs/ApiResponseOptionsChain.md)
 - [Model.ApiResponseOptionsChainEod](docs/ApiResponseOptionsChainEod.md)
 - [Model.ApiResponseOptionsChainRealtime](docs/ApiResponseOptionsChainRealtime.md)
 - [Model.ApiResponseOptionsExpirations](docs/ApiResponseOptionsExpirations.md)
 - [Model.ApiResponseOptionsGreekContractRealtime](docs/ApiResponseOptionsGreekContractRealtime.md)
 - [Model.ApiResponseOptionsGreeksByTickerRealtime](docs/ApiResponseOptionsGreeksByTickerRealtime.md)
 - [Model.ApiResponseOptionsImpliedMove](docs/ApiResponseOptionsImpliedMove.md)
 - [Model.ApiResponseOptionsPriceRealtime](docs/ApiResponseOptionsPriceRealtime.md)
 - [Model.ApiResponseOptionsPricesBatchRealtime](docs/ApiResponseOptionsPricesBatchRealtime.md)
 - [Model.ApiResponseOptionsPricesByTickerEod](docs/ApiResponseOptionsPricesByTickerEod.md)
 - [Model.ApiResponseOptionsPricesByTickerRealtime](docs/ApiResponseOptionsPricesByTickerRealtime.md)
 - [Model.ApiResponseOptionsPricesEod](docs/ApiResponseOptionsPricesEod.md)
 - [Model.ApiResponseOptionsRealtime](docs/ApiResponseOptionsRealtime.md)
 - [Model.ApiResponseOptionsStatsRealtime](docs/ApiResponseOptionsStatsRealtime.md)
 - [Model.ApiResponseOptionsTickers](docs/ApiResponseOptionsTickers.md)
 - [Model.ApiResponseOptionsUnusualActivity](docs/ApiResponseOptionsUnusualActivity.md)
 - [Model.ApiResponseOwnerInsiderTransactionFilings](docs/ApiResponseOwnerInsiderTransactionFilings.md)
 - [Model.ApiResponseOwnerInstitutionalHoldings](docs/ApiResponseOwnerInstitutionalHoldings.md)
 - [Model.ApiResponseOwners](docs/ApiResponseOwners.md)
 - [Model.ApiResponseRealtimeIndexPrices](docs/ApiResponseRealtimeIndexPrices.md)
 - [Model.ApiResponseReportedFinancials](docs/ApiResponseReportedFinancials.md)
 - [Model.ApiResponseSICIndexHistoricalData](docs/ApiResponseSICIndexHistoricalData.md)
 - [Model.ApiResponseSICIndices](docs/ApiResponseSICIndices.md)
 - [Model.ApiResponseSICIndicesSearch](docs/ApiResponseSICIndicesSearch.md)
 - [Model.ApiResponseSecurities](docs/ApiResponseSecurities.md)
 - [Model.ApiResponseSecuritiesDividendLatest](docs/ApiResponseSecuritiesDividendLatest.md)
 - [Model.ApiResponseSecuritiesEarningsLatest](docs/ApiResponseSecuritiesEarningsLatest.md)
 - [Model.ApiResponseSecuritiesSearch](docs/ApiResponseSecuritiesSearch.md)
 - [Model.ApiResponseSecuritiesShortInterest](docs/ApiResponseSecuritiesShortInterest.md)
 - [Model.ApiResponseSecurityAccumulationDistributionIndex](docs/ApiResponseSecurityAccumulationDistributionIndex.md)
 - [Model.ApiResponseSecurityAverageDailyTradingVolume](docs/ApiResponseSecurityAverageDailyTradingVolume.md)
 - [Model.ApiResponseSecurityAverageDirectionalIndex](docs/ApiResponseSecurityAverageDirectionalIndex.md)
 - [Model.ApiResponseSecurityAverageTrueRange](docs/ApiResponseSecurityAverageTrueRange.md)
 - [Model.ApiResponseSecurityAwesomeOscillator](docs/ApiResponseSecurityAwesomeOscillator.md)
 - [Model.ApiResponseSecurityBollingerBands](docs/ApiResponseSecurityBollingerBands.md)
 - [Model.ApiResponseSecurityChaikinMoneyFlow](docs/ApiResponseSecurityChaikinMoneyFlow.md)
 - [Model.ApiResponseSecurityCommodityChannelIndex](docs/ApiResponseSecurityCommodityChannelIndex.md)
 - [Model.ApiResponseSecurityDetrendedPriceOscillator](docs/ApiResponseSecurityDetrendedPriceOscillator.md)
 - [Model.ApiResponseSecurityDonchianChannel](docs/ApiResponseSecurityDonchianChannel.md)
 - [Model.ApiResponseSecurityEaseOfMovement](docs/ApiResponseSecurityEaseOfMovement.md)
 - [Model.ApiResponseSecurityForceIndex](docs/ApiResponseSecurityForceIndex.md)
 - [Model.ApiResponseSecurityHistoricalData](docs/ApiResponseSecurityHistoricalData.md)
 - [Model.ApiResponseSecurityIchimokuKinkoHyo](docs/ApiResponseSecurityIchimokuKinkoHyo.md)
 - [Model.ApiResponseSecurityInstitutionalOwnership](docs/ApiResponseSecurityInstitutionalOwnership.md)
 - [Model.ApiResponseSecurityIntervalPrices](docs/ApiResponseSecurityIntervalPrices.md)
 - [Model.ApiResponseSecurityKeltnerChannel](docs/ApiResponseSecurityKeltnerChannel.md)
 - [Model.ApiResponseSecurityKnowSureThing](docs/ApiResponseSecurityKnowSureThing.md)
 - [Model.ApiResponseSecurityMassIndex](docs/ApiResponseSecurityMassIndex.md)
 - [Model.ApiResponseSecurityMoneyFlowIndex](docs/ApiResponseSecurityMoneyFlowIndex.md)
 - [Model.ApiResponseSecurityMovingAverageConvergenceDivergence](docs/ApiResponseSecurityMovingAverageConvergenceDivergence.md)
 - [Model.ApiResponseSecurityNegativeVolumeIndex](docs/ApiResponseSecurityNegativeVolumeIndex.md)
 - [Model.ApiResponseSecurityOnBalanceVolume](docs/ApiResponseSecurityOnBalanceVolume.md)
 - [Model.ApiResponseSecurityOnBalanceVolumeMean](docs/ApiResponseSecurityOnBalanceVolumeMean.md)
 - [Model.ApiResponseSecurityQuote](docs/ApiResponseSecurityQuote.md)
 - [Model.ApiResponseSecurityRelativeStrengthIndex](docs/ApiResponseSecurityRelativeStrengthIndex.md)
 - [Model.ApiResponseSecurityShortInterest](docs/ApiResponseSecurityShortInterest.md)
 - [Model.ApiResponseSecuritySimpleMovingAverage](docs/ApiResponseSecuritySimpleMovingAverage.md)
 - [Model.ApiResponseSecurityStochasticOscillator](docs/ApiResponseSecurityStochasticOscillator.md)
 - [Model.ApiResponseSecurityStockPriceAdjustments](docs/ApiResponseSecurityStockPriceAdjustments.md)
 - [Model.ApiResponseSecurityStockPrices](docs/ApiResponseSecurityStockPrices.md)
 - [Model.ApiResponseSecurityTripleExponentialAverage](docs/ApiResponseSecurityTripleExponentialAverage.md)
 - [Model.ApiResponseSecurityTrueStrengthIndex](docs/ApiResponseSecurityTrueStrengthIndex.md)
 - [Model.ApiResponseSecurityUltimateOscillator](docs/ApiResponseSecurityUltimateOscillator.md)
 - [Model.ApiResponseSecurityVolumePriceTrend](docs/ApiResponseSecurityVolumePriceTrend.md)
 - [Model.ApiResponseSecurityVolumeWeightedAveragePrice](docs/ApiResponseSecurityVolumeWeightedAveragePrice.md)
 - [Model.ApiResponseSecurityVortexIndicator](docs/ApiResponseSecurityVortexIndicator.md)
 - [Model.ApiResponseSecurityWilliamsR](docs/ApiResponseSecurityWilliamsR.md)
 - [Model.ApiResponseSecurityZacksAnalystRatings](docs/ApiResponseSecurityZacksAnalystRatings.md)
 - [Model.ApiResponseSecurityZacksAnalystRatingsSnapshot](docs/ApiResponseSecurityZacksAnalystRatingsSnapshot.md)
 - [Model.ApiResponseSecurityZacksEPSSurprises](docs/ApiResponseSecurityZacksEPSSurprises.md)
 - [Model.ApiResponseSecurityZacksSalesSurprises](docs/ApiResponseSecurityZacksSalesSurprises.md)
 - [Model.ApiResponseStandardizedFinancials](docs/ApiResponseStandardizedFinancials.md)
 - [Model.ApiResponseStandardizedFinancialsDimensions](docs/ApiResponseStandardizedFinancialsDimensions.md)
 - [Model.ApiResponseStockExchangeBetas](docs/ApiResponseStockExchangeBetas.md)
 - [Model.ApiResponseStockExchangeMovers](docs/ApiResponseStockExchangeMovers.md)
 - [Model.ApiResponseStockExchangeQuote](docs/ApiResponseStockExchangeQuote.md)
 - [Model.ApiResponseStockExchangeRealtimeStockPrices](docs/ApiResponseStockExchangeRealtimeStockPrices.md)
 - [Model.ApiResponseStockExchangeSecurities](docs/ApiResponseStockExchangeSecurities.md)
 - [Model.ApiResponseStockExchangeStockPriceAdjustments](docs/ApiResponseStockExchangeStockPriceAdjustments.md)
 - [Model.ApiResponseStockExchangeStockPrices](docs/ApiResponseStockExchangeStockPrices.md)
 - [Model.ApiResponseStockExchanges](docs/ApiResponseStockExchanges.md)
 - [Model.ApiResponseStockMarketIndexHistoricalData](docs/ApiResponseStockMarketIndexHistoricalData.md)
 - [Model.ApiResponseStockMarketIndices](docs/ApiResponseStockMarketIndices.md)
 - [Model.ApiResponseStockMarketIndicesSearch](docs/ApiResponseStockMarketIndicesSearch.md)
 - [Model.ApiResponseZacksAnalystRatings](docs/ApiResponseZacksAnalystRatings.md)
 - [Model.ApiResponseZacksEBITDAConsensus](docs/ApiResponseZacksEBITDAConsensus.md)
 - [Model.ApiResponseZacksEPSEstimates](docs/ApiResponseZacksEPSEstimates.md)
 - [Model.ApiResponseZacksEPSGrowthRates](docs/ApiResponseZacksEPSGrowthRates.md)
 - [Model.ApiResponseZacksEPSSurprises](docs/ApiResponseZacksEPSSurprises.md)
 - [Model.ApiResponseZacksETFHoldings](docs/ApiResponseZacksETFHoldings.md)
 - [Model.ApiResponseZacksForwardPEs](docs/ApiResponseZacksForwardPEs.md)
 - [Model.ApiResponseZacksInstitutionalHoldingCompanies](docs/ApiResponseZacksInstitutionalHoldingCompanies.md)
 - [Model.ApiResponseZacksInstitutionalHoldingOwners](docs/ApiResponseZacksInstitutionalHoldingOwners.md)
 - [Model.ApiResponseZacksInstitutionalHoldings](docs/ApiResponseZacksInstitutionalHoldings.md)
 - [Model.ApiResponseZacksLongTermGrowthRates](docs/ApiResponseZacksLongTermGrowthRates.md)
 - [Model.ApiResponseZacksSalesEstimates](docs/ApiResponseZacksSalesEstimates.md)
 - [Model.ApiResponseZacksSalesSurprises](docs/ApiResponseZacksSalesSurprises.md)
 - [Model.ApiResponseZacksTargetPriceConsensuses](docs/ApiResponseZacksTargetPriceConsensuses.md)
 - [Model.AverageDailyTradingVolumeTechnicalValue](docs/AverageDailyTradingVolumeTechnicalValue.md)
 - [Model.AverageDirectionalIndexTechnicalValue](docs/AverageDirectionalIndexTechnicalValue.md)
 - [Model.AverageTrueRangeTechnicalValue](docs/AverageTrueRangeTechnicalValue.md)
 - [Model.AwesomeOscillatorTechnicalValue](docs/AwesomeOscillatorTechnicalValue.md)
 - [Model.Beta](docs/Beta.md)
 - [Model.BollingerBandsTechnicalValue](docs/BollingerBandsTechnicalValue.md)
 - [Model.BulkDownloadLinks](docs/BulkDownloadLinks.md)
 - [Model.BulkDownloadSummary](docs/BulkDownloadSummary.md)
 - [Model.ChaikinMoneyFlowTechnicalValue](docs/ChaikinMoneyFlowTechnicalValue.md)
 - [Model.CommodityChannelIndexTechnicalValue](docs/CommodityChannelIndexTechnicalValue.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyDailyMetric](docs/CompanyDailyMetric.md)
 - [Model.CompanyFiling](docs/CompanyFiling.md)
 - [Model.CompanyInitialPublicOffering](docs/CompanyInitialPublicOffering.md)
 - [Model.CompanyNews](docs/CompanyNews.md)
 - [Model.CompanyNewsSummary](docs/CompanyNewsSummary.md)
 - [Model.CompanyPublicFloat](docs/CompanyPublicFloat.md)
 - [Model.CompanySharesOutstanding](docs/CompanySharesOutstanding.md)
 - [Model.CompanySummary](docs/CompanySummary.md)
 - [Model.DataTag](docs/DataTag.md)
 - [Model.DataTagSummary](docs/DataTagSummary.md)
 - [Model.DetrendedPriceOscillatorTechnicalValue](docs/DetrendedPriceOscillatorTechnicalValue.md)
 - [Model.DividendRecord](docs/DividendRecord.md)
 - [Model.DonchianChannelTechnicalValue](docs/DonchianChannelTechnicalValue.md)
 - [Model.ESGCompanySummary](docs/ESGCompanySummary.md)
 - [Model.ESGComprehensiveRating](docs/ESGComprehensiveRating.md)
 - [Model.ESGComprehensiveRatingWithCompany](docs/ESGComprehensiveRatingWithCompany.md)
 - [Model.ESGRating](docs/ESGRating.md)
 - [Model.ESGRatingWithCompany](docs/ESGRatingWithCompany.md)
 - [Model.ETF](docs/ETF.md)
 - [Model.ETFAnalytics](docs/ETFAnalytics.md)
 - [Model.ETFHistoricalStats](docs/ETFHistoricalStats.md)
 - [Model.ETFHolding](docs/ETFHolding.md)
 - [Model.ETFStats](docs/ETFStats.md)
 - [Model.ETFSummary](docs/ETFSummary.md)
 - [Model.EarningsRecord](docs/EarningsRecord.md)
 - [Model.EaseOfMovementTechnicalValue](docs/EaseOfMovementTechnicalValue.md)
 - [Model.EconomicIndex](docs/EconomicIndex.md)
 - [Model.EconomicIndexSummary](docs/EconomicIndexSummary.md)
 - [Model.EodIndexPrice](docs/EodIndexPrice.md)
 - [Model.EodIndexPriceSummary](docs/EodIndexPriceSummary.md)
 - [Model.Filing](docs/Filing.md)
 - [Model.FilingNote](docs/FilingNote.md)
 - [Model.FilingNoteFiling](docs/FilingNoteFiling.md)
 - [Model.FilingNoteSummary](docs/FilingNoteSummary.md)
 - [Model.FilingSummary](docs/FilingSummary.md)
 - [Model.ForceIndexTechnicalValue](docs/ForceIndexTechnicalValue.md)
 - [Model.ForexCurrency](docs/ForexCurrency.md)
 - [Model.ForexPair](docs/ForexPair.md)
 - [Model.ForexPrice](docs/ForexPrice.md)
 - [Model.Fundamental](docs/Fundamental.md)
 - [Model.FundamentalSummary](docs/FundamentalSummary.md)
 - [Model.HistoricalData](docs/HistoricalData.md)
 - [Model.IchimokuKinkoHyoTechnicalValue](docs/IchimokuKinkoHyoTechnicalValue.md)
 - [Model.IndexInterval](docs/IndexInterval.md)
 - [Model.InsiderTransaction](docs/InsiderTransaction.md)
 - [Model.InsiderTransactionFiling](docs/InsiderTransactionFiling.md)
 - [Model.InstitutionalHolding](docs/InstitutionalHolding.md)
 - [Model.InstitutionalOwnership](docs/InstitutionalOwnership.md)
 - [Model.KeltnerChannelTechnicalValue](docs/KeltnerChannelTechnicalValue.md)
 - [Model.KnowSureThingTechnicalValue](docs/KnowSureThingTechnicalValue.md)
 - [Model.MarketStatusResult](docs/MarketStatusResult.md)
 - [Model.MassIndexTechnicalValue](docs/MassIndexTechnicalValue.md)
 - [Model.MoneyFlowIndexTechnicalValue](docs/MoneyFlowIndexTechnicalValue.md)
 - [Model.MovingAverageConvergenceDivergenceTechnicalValue](docs/MovingAverageConvergenceDivergenceTechnicalValue.md)
 - [Model.Municipality](docs/Municipality.md)
 - [Model.MunicipalityFinancial](docs/MunicipalityFinancial.md)
 - [Model.NegativeVolumeIndexTechnicalValue](docs/NegativeVolumeIndexTechnicalValue.md)
 - [Model.NewsTopic](docs/NewsTopic.md)
 - [Model.OnBalanceVolumeMeanTechnicalValue](docs/OnBalanceVolumeMeanTechnicalValue.md)
 - [Model.OnBalanceVolumeTechnicalValue](docs/OnBalanceVolumeTechnicalValue.md)
 - [Model.Option](docs/Option.md)
 - [Model.OptionChain](docs/OptionChain.md)
 - [Model.OptionChainEod](docs/OptionChainEod.md)
 - [Model.OptionChainRealtime](docs/OptionChainRealtime.md)
 - [Model.OptionContractsList](docs/OptionContractsList.md)
 - [Model.OptionEod](docs/OptionEod.md)
 - [Model.OptionFactorsRealtime](docs/OptionFactorsRealtime.md)
 - [Model.OptionImpliedMoveData](docs/OptionImpliedMoveData.md)
 - [Model.OptionInterval](docs/OptionInterval.md)
 - [Model.OptionIntervalMover](docs/OptionIntervalMover.md)
 - [Model.OptionIntervalsMoversResult](docs/OptionIntervalsMoversResult.md)
 - [Model.OptionIntervalsResult](docs/OptionIntervalsResult.md)
 - [Model.OptionPrice](docs/OptionPrice.md)
 - [Model.OptionPriceBatchRealtime](docs/OptionPriceBatchRealtime.md)
 - [Model.OptionPriceEod](docs/OptionPriceEod.md)
 - [Model.OptionPriceRealtime](docs/OptionPriceRealtime.md)
 - [Model.OptionPriceRealtimeExtended](docs/OptionPriceRealtimeExtended.md)
 - [Model.OptionRealtime](docs/OptionRealtime.md)
 - [Model.OptionSnapshotGroup](docs/OptionSnapshotGroup.md)
 - [Model.OptionSnapshotsResult](docs/OptionSnapshotsResult.md)
 - [Model.OptionStatsRealtime](docs/OptionStatsRealtime.md)
 - [Model.OptionSyntheticGreeksRealtime](docs/OptionSyntheticGreeksRealtime.md)
 - [Model.OptionTrades](docs/OptionTrades.md)
 - [Model.OptionTradesResult](docs/OptionTradesResult.md)
 - [Model.OptionUnusualTrade](docs/OptionUnusualTrade.md)
 - [Model.OptionsAggregate](docs/OptionsAggregate.md)
 - [Model.OptionsPriceEod](docs/OptionsPriceEod.md)
 - [Model.Owner](docs/Owner.md)
 - [Model.OwnerSummary](docs/OwnerSummary.md)
 - [Model.RealtimeIndexPrice](docs/RealtimeIndexPrice.md)
 - [Model.RealtimeIndexPriceIndex](docs/RealtimeIndexPriceIndex.md)
 - [Model.RealtimeStockPrice](docs/RealtimeStockPrice.md)
 - [Model.RealtimeStockPriceSecurity](docs/RealtimeStockPriceSecurity.md)
 - [Model.RelativeStrengthIndexTechnicalValue](docs/RelativeStrengthIndexTechnicalValue.md)
 - [Model.ReportedFinancial](docs/ReportedFinancial.md)
 - [Model.ReportedFinancialDimension](docs/ReportedFinancialDimension.md)
 - [Model.ReportedTag](docs/ReportedTag.md)
 - [Model.SICIndex](docs/SICIndex.md)
 - [Model.Security](docs/Security.md)
 - [Model.SecurityHistory](docs/SecurityHistory.md)
 - [Model.SecurityHistoryListResult](docs/SecurityHistoryListResult.md)
 - [Model.SecurityIntervalMover](docs/SecurityIntervalMover.md)
 - [Model.SecurityIntervalsMoversResult](docs/SecurityIntervalsMoversResult.md)
 - [Model.SecurityReplayFileResult](docs/SecurityReplayFileResult.md)
 - [Model.SecurityScreenClause](docs/SecurityScreenClause.md)
 - [Model.SecurityScreenGroup](docs/SecurityScreenGroup.md)
 - [Model.SecurityScreenResult](docs/SecurityScreenResult.md)
 - [Model.SecurityScreenResultData](docs/SecurityScreenResultData.md)
 - [Model.SecuritySnapshotGroup](docs/SecuritySnapshotGroup.md)
 - [Model.SecuritySnapshotsResult](docs/SecuritySnapshotsResult.md)
 - [Model.SecuritySummary](docs/SecuritySummary.md)
 - [Model.SecurityTrades](docs/SecurityTrades.md)
 - [Model.SecurityTradesResult](docs/SecurityTradesResult.md)
 - [Model.ShortInterest](docs/ShortInterest.md)
 - [Model.ShortInterestWithSecurity](docs/ShortInterestWithSecurity.md)
 - [Model.SimpleMovingAverageTechnicalValue](docs/SimpleMovingAverageTechnicalValue.md)
 - [Model.StandardizedFinancial](docs/StandardizedFinancial.md)
 - [Model.StandardizedFinancialsDimension](docs/StandardizedFinancialsDimension.md)
 - [Model.StochasticOscillatorTechnicalValue](docs/StochasticOscillatorTechnicalValue.md)
 - [Model.StockExchange](docs/StockExchange.md)
 - [Model.StockExchangeMover](docs/StockExchangeMover.md)
 - [Model.StockMarketIndex](docs/StockMarketIndex.md)
 - [Model.StockMarketIndexSummary](docs/StockMarketIndexSummary.md)
 - [Model.StockPrice](docs/StockPrice.md)
 - [Model.StockPriceAdjustment](docs/StockPriceAdjustment.md)
 - [Model.StockPriceAdjustmentSummary](docs/StockPriceAdjustmentSummary.md)
 - [Model.StockPriceInterval](docs/StockPriceInterval.md)
 - [Model.StockPriceSummary](docs/StockPriceSummary.md)
 - [Model.TechnicalIndicator](docs/TechnicalIndicator.md)
 - [Model.TheaEntityAnswer](docs/TheaEntityAnswer.md)
 - [Model.TheaSourceDocument](docs/TheaSourceDocument.md)
 - [Model.TripleExponentialAverageTechnicalValue](docs/TripleExponentialAverageTechnicalValue.md)
 - [Model.TrueStrengthIndexTechnicalValue](docs/TrueStrengthIndexTechnicalValue.md)
 - [Model.UltimateOscillatorTechnicalValue](docs/UltimateOscillatorTechnicalValue.md)
 - [Model.VolumePriceTrendTechnicalValue](docs/VolumePriceTrendTechnicalValue.md)
 - [Model.VolumeWeightedAveragePriceValue](docs/VolumeWeightedAveragePriceValue.md)
 - [Model.VortexIndicatorTechnicalValue](docs/VortexIndicatorTechnicalValue.md)
 - [Model.WilliamsRTechnicalValue](docs/WilliamsRTechnicalValue.md)
 - [Model.ZacksAnalystRating](docs/ZacksAnalystRating.md)
 - [Model.ZacksAnalystRatingSnapshot](docs/ZacksAnalystRatingSnapshot.md)
 - [Model.ZacksAnalystRatingSummary](docs/ZacksAnalystRatingSummary.md)
 - [Model.ZacksEBITDAConsensus](docs/ZacksEBITDAConsensus.md)
 - [Model.ZacksEPSEstimate](docs/ZacksEPSEstimate.md)
 - [Model.ZacksEPSGrowthRate](docs/ZacksEPSGrowthRate.md)
 - [Model.ZacksEPSSurprise](docs/ZacksEPSSurprise.md)
 - [Model.ZacksEPSSurpriseSummary](docs/ZacksEPSSurpriseSummary.md)
 - [Model.ZacksETFHolding](docs/ZacksETFHolding.md)
 - [Model.ZacksForwardPE](docs/ZacksForwardPE.md)
 - [Model.ZacksInstitutionalHolding](docs/ZacksInstitutionalHolding.md)
 - [Model.ZacksInstitutionalHoldingCompanyDetail](docs/ZacksInstitutionalHoldingCompanyDetail.md)
 - [Model.ZacksInstitutionalHoldingCompanySummary](docs/ZacksInstitutionalHoldingCompanySummary.md)
 - [Model.ZacksInstitutionalHoldingHistoricalSummary](docs/ZacksInstitutionalHoldingHistoricalSummary.md)
 - [Model.ZacksInstitutionalHoldingOwnerDetail](docs/ZacksInstitutionalHoldingOwnerDetail.md)
 - [Model.ZacksInstitutionalHoldingOwnerSummary](docs/ZacksInstitutionalHoldingOwnerSummary.md)
 - [Model.ZacksLongTermGrowthRate](docs/ZacksLongTermGrowthRate.md)
 - [Model.ZacksSalesEstimate](docs/ZacksSalesEstimate.md)
 - [Model.ZacksSalesSurprise](docs/ZacksSalesSurprise.md)
 - [Model.ZacksSalesSurpriseSummary](docs/ZacksSalesSurpriseSummary.md)
 - [Model.ZacksTargetPriceConsensus](docs/ZacksTargetPriceConsensus.md)


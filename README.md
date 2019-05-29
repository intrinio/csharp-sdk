# Intrinio C# SDK

To get an API key, [sign up here](https://intrinio.com/).

Welcome to the Intrinio API! Through our Financial Data Marketplace, we offer a wide selection of financial data feed APIs sourced by our own proprietary processes as well as from many data vendors. For a complete API request / response reference please view the [Intrinio API documentation](https://intrinio.com/documentation/api_v2). If you need additional help in using the API, please visit the [Intrinio website](https://intrinio.com) and click on the chat icon in the lower right corner.

- API version: 2.7.0
- Package version: 3.1.0


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
  public class GetAllCompaniesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "OmJiN2MyNjU4ZDFjMmFlMTc2M2ZmNjJjM2U5NWQ0NmVh");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

Complete documentation for the Intrinio C# SDK is available on the Intrinio website.

[View Intrinio C# SDK Documentation](https://docs.intrinio.com/documentation/api_v2/csharp)

A listing of classes and methods is also provided below:

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
*CryptoApi* | [**GetCryptoBookAsks**](docs/CryptoApi.md#getcryptobookasks) | **GET** /crypto/book/asks | Crypto Book Asks
*CryptoApi* | [**GetCryptoBookBids**](docs/CryptoApi.md#getcryptobookbids) | **GET** /crypto/book/bids | Crypto Book Bids
*CryptoApi* | [**GetCryptoBookSummary**](docs/CryptoApi.md#getcryptobooksummary) | **GET** /crypto/book | Crypto Book Summary
*CryptoApi* | [**GetCryptoCurrencies**](docs/CryptoApi.md#getcryptocurrencies) | **GET** /crypto/currencies | Crypto Currencies
*CryptoApi* | [**GetCryptoExchanges**](docs/CryptoApi.md#getcryptoexchanges) | **GET** /crypto/exchanges | Crypto Exchanges
*CryptoApi* | [**GetCryptoPairs**](docs/CryptoApi.md#getcryptopairs) | **GET** /crypto/pairs | Crypto Pairs
*CryptoApi* | [**GetCryptoPriceTechnicalsAdi**](docs/CryptoApi.md#getcryptopricetechnicalsadi) | **GET** /crypto/prices/technicals/adi | Accumulation/Distribution Index
*CryptoApi* | [**GetCryptoPriceTechnicalsAdtv**](docs/CryptoApi.md#getcryptopricetechnicalsadtv) | **GET** /crypto/prices/technicals/adtv | Average Daily Trading Volume
*CryptoApi* | [**GetCryptoPriceTechnicalsAdx**](docs/CryptoApi.md#getcryptopricetechnicalsadx) | **GET** /crypto/prices/technicals/adx | Average Directional Index
*CryptoApi* | [**GetCryptoPriceTechnicalsAo**](docs/CryptoApi.md#getcryptopricetechnicalsao) | **GET** /crypto/prices/technicals/ao | Awesome Oscillator
*CryptoApi* | [**GetCryptoPriceTechnicalsAtr**](docs/CryptoApi.md#getcryptopricetechnicalsatr) | **GET** /crypto/prices/technicals/atr | Average True Range
*CryptoApi* | [**GetCryptoPriceTechnicalsBb**](docs/CryptoApi.md#getcryptopricetechnicalsbb) | **GET** /crypto/prices/technicals/bb | Bollinger Bands
*CryptoApi* | [**GetCryptoPriceTechnicalsCci**](docs/CryptoApi.md#getcryptopricetechnicalscci) | **GET** /crypto/prices/technicals/cci | Commodity Channel Index
*CryptoApi* | [**GetCryptoPriceTechnicalsCmf**](docs/CryptoApi.md#getcryptopricetechnicalscmf) | **GET** /crypto/prices/technicals/cmf | Chaikin Money Flow
*CryptoApi* | [**GetCryptoPriceTechnicalsDc**](docs/CryptoApi.md#getcryptopricetechnicalsdc) | **GET** /crypto/prices/technicals/dc | Donchian Channel
*CryptoApi* | [**GetCryptoPriceTechnicalsDpo**](docs/CryptoApi.md#getcryptopricetechnicalsdpo) | **GET** /crypto/prices/technicals/dpo | Detrended Price Oscillator
*CryptoApi* | [**GetCryptoPriceTechnicalsEom**](docs/CryptoApi.md#getcryptopricetechnicalseom) | **GET** /crypto/prices/technicals/eom | Ease of Movement
*CryptoApi* | [**GetCryptoPriceTechnicalsFi**](docs/CryptoApi.md#getcryptopricetechnicalsfi) | **GET** /crypto/prices/technicals/fi | Force Index
*CryptoApi* | [**GetCryptoPriceTechnicalsIchimoku**](docs/CryptoApi.md#getcryptopricetechnicalsichimoku) | **GET** /crypto/prices/technicals/ichimoku | Ichimoku Kinko Hyo
*CryptoApi* | [**GetCryptoPriceTechnicalsKc**](docs/CryptoApi.md#getcryptopricetechnicalskc) | **GET** /crypto/prices/technicals/kc | Keltner Channel
*CryptoApi* | [**GetCryptoPriceTechnicalsKst**](docs/CryptoApi.md#getcryptopricetechnicalskst) | **GET** /crypto/prices/technicals/kst | Know Sure Thing
*CryptoApi* | [**GetCryptoPriceTechnicalsMacd**](docs/CryptoApi.md#getcryptopricetechnicalsmacd) | **GET** /crypto/prices/technicals/macd | Moving Average Convergence Divergence
*CryptoApi* | [**GetCryptoPriceTechnicalsMfi**](docs/CryptoApi.md#getcryptopricetechnicalsmfi) | **GET** /crypto/prices/technicals/mfi | Money Flow Index
*CryptoApi* | [**GetCryptoPriceTechnicalsMi**](docs/CryptoApi.md#getcryptopricetechnicalsmi) | **GET** /crypto/prices/technicals/mi | Mass Index
*CryptoApi* | [**GetCryptoPriceTechnicalsNvi**](docs/CryptoApi.md#getcryptopricetechnicalsnvi) | **GET** /crypto/prices/technicals/nvi | Negative Volume Index
*CryptoApi* | [**GetCryptoPriceTechnicalsObv**](docs/CryptoApi.md#getcryptopricetechnicalsobv) | **GET** /crypto/prices/technicals/obv | On-balance Volume
*CryptoApi* | [**GetCryptoPriceTechnicalsObvMean**](docs/CryptoApi.md#getcryptopricetechnicalsobvmean) | **GET** /crypto/prices/technicals/obv_mean | On-balance Volume Mean
*CryptoApi* | [**GetCryptoPriceTechnicalsRsi**](docs/CryptoApi.md#getcryptopricetechnicalsrsi) | **GET** /crypto/prices/technicals/rsi | Relative Strength Index
*CryptoApi* | [**GetCryptoPriceTechnicalsSma**](docs/CryptoApi.md#getcryptopricetechnicalssma) | **GET** /crypto/prices/technicals/sma | Simple Moving Average
*CryptoApi* | [**GetCryptoPriceTechnicalsSr**](docs/CryptoApi.md#getcryptopricetechnicalssr) | **GET** /crypto/prices/technicals/sr | Stochastic Oscillator
*CryptoApi* | [**GetCryptoPriceTechnicalsTrix**](docs/CryptoApi.md#getcryptopricetechnicalstrix) | **GET** /crypto/prices/technicals/trix | Triple Exponential Average
*CryptoApi* | [**GetCryptoPriceTechnicalsTsi**](docs/CryptoApi.md#getcryptopricetechnicalstsi) | **GET** /crypto/prices/technicals/tsi | True Strength Index
*CryptoApi* | [**GetCryptoPriceTechnicalsUo**](docs/CryptoApi.md#getcryptopricetechnicalsuo) | **GET** /crypto/prices/technicals/uo | Ultimate Oscillator
*CryptoApi* | [**GetCryptoPriceTechnicalsVi**](docs/CryptoApi.md#getcryptopricetechnicalsvi) | **GET** /crypto/prices/technicals/vi | Vortex Indicator
*CryptoApi* | [**GetCryptoPriceTechnicalsVpt**](docs/CryptoApi.md#getcryptopricetechnicalsvpt) | **GET** /crypto/prices/technicals/vpt | Volume-price Trend
*CryptoApi* | [**GetCryptoPriceTechnicalsVwap**](docs/CryptoApi.md#getcryptopricetechnicalsvwap) | **GET** /crypto/prices/technicals/vwap | Volume Weighted Average Price
*CryptoApi* | [**GetCryptoPriceTechnicalsWr**](docs/CryptoApi.md#getcryptopricetechnicalswr) | **GET** /crypto/prices/technicals/wr | Williams %R
*CryptoApi* | [**GetCryptoPrices**](docs/CryptoApi.md#getcryptoprices) | **GET** /crypto/prices | Crypto Prices
*CryptoApi* | [**GetCryptoSnapshot**](docs/CryptoApi.md#getcryptosnapshot) | **GET** /crypto/snapshot | Crypto Snapshot
*CryptoApi* | [**GetCryptoStats**](docs/CryptoApi.md#getcryptostats) | **GET** /crypto/stats | Crypto Stats
*DataPointApi* | [**GetDataPointNumber**](docs/DataPointApi.md#getdatapointnumber) | **GET** /data_point/{identifier}/{tag}/number | Data Point (Number)
*DataPointApi* | [**GetDataPointText**](docs/DataPointApi.md#getdatapointtext) | **GET** /data_point/{identifier}/{tag}/text | Data Point (Text)
*DataTagApi* | [**GetAllDataTags**](docs/DataTagApi.md#getalldatatags) | **GET** /data_tags | All Data Tags
*DataTagApi* | [**GetDataTagById**](docs/DataTagApi.md#getdatatagbyid) | **GET** /data_tags/{identifier} | Lookup Data Tag
*DataTagApi* | [**SearchDataTags**](docs/DataTagApi.md#searchdatatags) | **GET** /data_tags/search | Search Data Tags
*FilingApi* | [**GetAllFilings**](docs/FilingApi.md#getallfilings) | **GET** /filings | All Filings
*FilingApi* | [**GetAllNotes**](docs/FilingApi.md#getallnotes) | **GET** /filings/notes | All Filing Notes
*FilingApi* | [**GetFilingById**](docs/FilingApi.md#getfilingbyid) | **GET** /filings/{id} | Lookup Filing
*FilingApi* | [**GetFilingFundamentals**](docs/FilingApi.md#getfilingfundamentals) | **GET** /filings/{identifier}/fundamentals | All Fundamentals by Filing
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
*OptionsApi* | [**GetOptions**](docs/OptionsApi.md#getoptions) | **GET** /options/{symbol} | Options
*OptionsApi* | [**GetOptionsChain**](docs/OptionsApi.md#getoptionschain) | **GET** /options/chain/{symbol}/{expiration} | Options Chain
*OptionsApi* | [**GetOptionsExpirations**](docs/OptionsApi.md#getoptionsexpirations) | **GET** /options/expirations/{symbol} | Options Expirations
*OptionsApi* | [**GetOptionsPrices**](docs/OptionsApi.md#getoptionsprices) | **GET** /options/prices/{identifier} | Option Prices
*SecurityApi* | [**GetAllSecurities**](docs/SecurityApi.md#getallsecurities) | **GET** /securities | All Securities
*SecurityApi* | [**GetSecurityById**](docs/SecurityApi.md#getsecuritybyid) | **GET** /securities/{identifier} | Lookup Security
*SecurityApi* | [**GetSecurityDataPointNumber**](docs/SecurityApi.md#getsecuritydatapointnumber) | **GET** /securities/{identifier}/data_point/{tag}/number | Data Point (Number) for Security
*SecurityApi* | [**GetSecurityDataPointText**](docs/SecurityApi.md#getsecuritydatapointtext) | **GET** /securities/{identifier}/data_point/{tag}/text | Data Point (Text) for Security
*SecurityApi* | [**GetSecurityHistoricalData**](docs/SecurityApi.md#getsecurityhistoricaldata) | **GET** /securities/{identifier}/historical_data/{tag} | Historical Data for Security
*SecurityApi* | [**GetSecurityIntradayPrices**](docs/SecurityApi.md#getsecurityintradayprices) | **GET** /securities/{identifier}/prices/intraday | Intraday Stock Prices for Security
*SecurityApi* | [**GetSecurityLatestDividendRecord**](docs/SecurityApi.md#getsecuritylatestdividendrecord) | **GET** /securities/{identifier}/dividends/latest | Lastest Dividend Record for Security
*SecurityApi* | [**GetSecurityLatestEarningsRecord**](docs/SecurityApi.md#getsecuritylatestearningsrecord) | **GET** /securities/{identifier}/earnings/latest | Lastest Earnings Record for Security
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
*SecurityApi* | [**GetSecurityRealtimePrice**](docs/SecurityApi.md#getsecurityrealtimeprice) | **GET** /securities/{identifier}/prices/realtime | Realtime Stock Price for Security
*SecurityApi* | [**GetSecurityStockPriceAdjustments**](docs/SecurityApi.md#getsecuritystockpriceadjustments) | **GET** /securities/{identifier}/prices/adjustments | Stock Price Adjustments by Security
*SecurityApi* | [**GetSecurityStockPrices**](docs/SecurityApi.md#getsecuritystockprices) | **GET** /securities/{identifier}/prices | Stock Prices by Security
*SecurityApi* | [**GetSecurityZacksAnalystRatings**](docs/SecurityApi.md#getsecurityzacksanalystratings) | **GET** /securities/{identifier}/zacks/analyst_ratings | Zacks Analyst Ratings
*SecurityApi* | [**GetSecurityZacksAnalystRatingsSnapshot**](docs/SecurityApi.md#getsecurityzacksanalystratingssnapshot) | **GET** /securities/{identifier}/zacks/analyst_ratings/snapshot | Zacks Analyst Ratings Snapshot
*SecurityApi* | [**GetSecurityZacksEpsSurprises**](docs/SecurityApi.md#getsecurityzacksepssurprises) | **GET** /securities/{identifier}/zacks/eps_surprises | Zacks EPS Surprises for Security
*SecurityApi* | [**GetSecurityZacksSalesSurprises**](docs/SecurityApi.md#getsecurityzackssalessurprises) | **GET** /securities/{identifier}/zacks/sales_surprises | Zacks Sales Surprises for Security
*SecurityApi* | [**ScreenSecurities**](docs/SecurityApi.md#screensecurities) | **POST** /securities/screen | Screen Securities
*SecurityApi* | [**SearchSecurities**](docs/SecurityApi.md#searchsecurities) | **GET** /securities/search | Search Securities
*StockExchangeApi* | [**GetAllStockExchanges**](docs/StockExchangeApi.md#getallstockexchanges) | **GET** /stock_exchanges | All Stock Exchanges
*StockExchangeApi* | [**GetStockExchangeById**](docs/StockExchangeApi.md#getstockexchangebyid) | **GET** /stock_exchanges/{identifier} | Lookup Stock Exchange
*StockExchangeApi* | [**GetStockExchangePriceAdjustments**](docs/StockExchangeApi.md#getstockexchangepriceadjustments) | **GET** /stock_exchanges/{identifier}/prices/adjustments | Stock Price Adjustments by Exchange
*StockExchangeApi* | [**GetStockExchangePrices**](docs/StockExchangeApi.md#getstockexchangeprices) | **GET** /stock_exchanges/{identifier}/prices | Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeRealtimePrices**](docs/StockExchangeApi.md#getstockexchangerealtimeprices) | **GET** /stock_exchanges/{identifier}/prices/realtime | Realtime Stock Prices by Exchange
*StockExchangeApi* | [**GetStockExchangeSecurities**](docs/StockExchangeApi.md#getstockexchangesecurities) | **GET** /stock_exchanges/{identifier}/securities | Securities by Exchange
*TechnicalApi* | [**GetCryptoPriceTechnicalsAdi**](docs/TechnicalApi.md#getcryptopricetechnicalsadi) | **GET** /crypto/prices/technicals/adi | Accumulation/Distribution Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsAdtv**](docs/TechnicalApi.md#getcryptopricetechnicalsadtv) | **GET** /crypto/prices/technicals/adtv | Average Daily Trading Volume
*TechnicalApi* | [**GetCryptoPriceTechnicalsAdx**](docs/TechnicalApi.md#getcryptopricetechnicalsadx) | **GET** /crypto/prices/technicals/adx | Average Directional Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsAo**](docs/TechnicalApi.md#getcryptopricetechnicalsao) | **GET** /crypto/prices/technicals/ao | Awesome Oscillator
*TechnicalApi* | [**GetCryptoPriceTechnicalsAtr**](docs/TechnicalApi.md#getcryptopricetechnicalsatr) | **GET** /crypto/prices/technicals/atr | Average True Range
*TechnicalApi* | [**GetCryptoPriceTechnicalsBb**](docs/TechnicalApi.md#getcryptopricetechnicalsbb) | **GET** /crypto/prices/technicals/bb | Bollinger Bands
*TechnicalApi* | [**GetCryptoPriceTechnicalsCci**](docs/TechnicalApi.md#getcryptopricetechnicalscci) | **GET** /crypto/prices/technicals/cci | Commodity Channel Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsCmf**](docs/TechnicalApi.md#getcryptopricetechnicalscmf) | **GET** /crypto/prices/technicals/cmf | Chaikin Money Flow
*TechnicalApi* | [**GetCryptoPriceTechnicalsDc**](docs/TechnicalApi.md#getcryptopricetechnicalsdc) | **GET** /crypto/prices/technicals/dc | Donchian Channel
*TechnicalApi* | [**GetCryptoPriceTechnicalsDpo**](docs/TechnicalApi.md#getcryptopricetechnicalsdpo) | **GET** /crypto/prices/technicals/dpo | Detrended Price Oscillator
*TechnicalApi* | [**GetCryptoPriceTechnicalsEom**](docs/TechnicalApi.md#getcryptopricetechnicalseom) | **GET** /crypto/prices/technicals/eom | Ease of Movement
*TechnicalApi* | [**GetCryptoPriceTechnicalsFi**](docs/TechnicalApi.md#getcryptopricetechnicalsfi) | **GET** /crypto/prices/technicals/fi | Force Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsIchimoku**](docs/TechnicalApi.md#getcryptopricetechnicalsichimoku) | **GET** /crypto/prices/technicals/ichimoku | Ichimoku Kinko Hyo
*TechnicalApi* | [**GetCryptoPriceTechnicalsKc**](docs/TechnicalApi.md#getcryptopricetechnicalskc) | **GET** /crypto/prices/technicals/kc | Keltner Channel
*TechnicalApi* | [**GetCryptoPriceTechnicalsKst**](docs/TechnicalApi.md#getcryptopricetechnicalskst) | **GET** /crypto/prices/technicals/kst | Know Sure Thing
*TechnicalApi* | [**GetCryptoPriceTechnicalsMacd**](docs/TechnicalApi.md#getcryptopricetechnicalsmacd) | **GET** /crypto/prices/technicals/macd | Moving Average Convergence Divergence
*TechnicalApi* | [**GetCryptoPriceTechnicalsMfi**](docs/TechnicalApi.md#getcryptopricetechnicalsmfi) | **GET** /crypto/prices/technicals/mfi | Money Flow Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsMi**](docs/TechnicalApi.md#getcryptopricetechnicalsmi) | **GET** /crypto/prices/technicals/mi | Mass Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsNvi**](docs/TechnicalApi.md#getcryptopricetechnicalsnvi) | **GET** /crypto/prices/technicals/nvi | Negative Volume Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsObv**](docs/TechnicalApi.md#getcryptopricetechnicalsobv) | **GET** /crypto/prices/technicals/obv | On-balance Volume
*TechnicalApi* | [**GetCryptoPriceTechnicalsObvMean**](docs/TechnicalApi.md#getcryptopricetechnicalsobvmean) | **GET** /crypto/prices/technicals/obv_mean | On-balance Volume Mean
*TechnicalApi* | [**GetCryptoPriceTechnicalsRsi**](docs/TechnicalApi.md#getcryptopricetechnicalsrsi) | **GET** /crypto/prices/technicals/rsi | Relative Strength Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsSma**](docs/TechnicalApi.md#getcryptopricetechnicalssma) | **GET** /crypto/prices/technicals/sma | Simple Moving Average
*TechnicalApi* | [**GetCryptoPriceTechnicalsSr**](docs/TechnicalApi.md#getcryptopricetechnicalssr) | **GET** /crypto/prices/technicals/sr | Stochastic Oscillator
*TechnicalApi* | [**GetCryptoPriceTechnicalsTrix**](docs/TechnicalApi.md#getcryptopricetechnicalstrix) | **GET** /crypto/prices/technicals/trix | Triple Exponential Average
*TechnicalApi* | [**GetCryptoPriceTechnicalsTsi**](docs/TechnicalApi.md#getcryptopricetechnicalstsi) | **GET** /crypto/prices/technicals/tsi | True Strength Index
*TechnicalApi* | [**GetCryptoPriceTechnicalsUo**](docs/TechnicalApi.md#getcryptopricetechnicalsuo) | **GET** /crypto/prices/technicals/uo | Ultimate Oscillator
*TechnicalApi* | [**GetCryptoPriceTechnicalsVi**](docs/TechnicalApi.md#getcryptopricetechnicalsvi) | **GET** /crypto/prices/technicals/vi | Vortex Indicator
*TechnicalApi* | [**GetCryptoPriceTechnicalsVpt**](docs/TechnicalApi.md#getcryptopricetechnicalsvpt) | **GET** /crypto/prices/technicals/vpt | Volume-price Trend
*TechnicalApi* | [**GetCryptoPriceTechnicalsVwap**](docs/TechnicalApi.md#getcryptopricetechnicalsvwap) | **GET** /crypto/prices/technicals/vwap | Volume Weighted Average Price
*TechnicalApi* | [**GetCryptoPriceTechnicalsWr**](docs/TechnicalApi.md#getcryptopricetechnicalswr) | **GET** /crypto/prices/technicals/wr | Williams %R
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
*ZacksApi* | [**GetZacksEpsSurprises**](docs/ZacksApi.md#getzacksepssurprises) | **GET** /zacks/eps_surprises | Zacks EPS Surprises
*ZacksApi* | [**GetZacksSalesSurprises**](docs/ZacksApi.md#getzackssalessurprises) | **GET** /zacks/sales_surprises | Zacks Sales Surprises


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccumulationDistributionIndexTechnicalValue](docs/AccumulationDistributionIndexTechnicalValue.md)
 - [Model.ApiResponseCompanies](docs/ApiResponseCompanies.md)
 - [Model.ApiResponseCompaniesSearch](docs/ApiResponseCompaniesSearch.md)
 - [Model.ApiResponseCompanyFilings](docs/ApiResponseCompanyFilings.md)
 - [Model.ApiResponseCompanyFundamentals](docs/ApiResponseCompanyFundamentals.md)
 - [Model.ApiResponseCompanyHistoricalData](docs/ApiResponseCompanyHistoricalData.md)
 - [Model.ApiResponseCompanyNews](docs/ApiResponseCompanyNews.md)
 - [Model.ApiResponseCompanySecurities](docs/ApiResponseCompanySecurities.md)
 - [Model.ApiResponseCryptoAccumulationDistributionIndex](docs/ApiResponseCryptoAccumulationDistributionIndex.md)
 - [Model.ApiResponseCryptoAverageDailyTradingVolume](docs/ApiResponseCryptoAverageDailyTradingVolume.md)
 - [Model.ApiResponseCryptoAverageDirectionalIndex](docs/ApiResponseCryptoAverageDirectionalIndex.md)
 - [Model.ApiResponseCryptoAverageTrueRange](docs/ApiResponseCryptoAverageTrueRange.md)
 - [Model.ApiResponseCryptoAwesomeOscillator](docs/ApiResponseCryptoAwesomeOscillator.md)
 - [Model.ApiResponseCryptoBollingerBands](docs/ApiResponseCryptoBollingerBands.md)
 - [Model.ApiResponseCryptoBook](docs/ApiResponseCryptoBook.md)
 - [Model.ApiResponseCryptoBookAsks](docs/ApiResponseCryptoBookAsks.md)
 - [Model.ApiResponseCryptoBookBids](docs/ApiResponseCryptoBookBids.md)
 - [Model.ApiResponseCryptoChaikinMoneyFlow](docs/ApiResponseCryptoChaikinMoneyFlow.md)
 - [Model.ApiResponseCryptoCommodityChannelIndex](docs/ApiResponseCryptoCommodityChannelIndex.md)
 - [Model.ApiResponseCryptoCurrencies](docs/ApiResponseCryptoCurrencies.md)
 - [Model.ApiResponseCryptoDetrendedPriceOscillator](docs/ApiResponseCryptoDetrendedPriceOscillator.md)
 - [Model.ApiResponseCryptoDonchianChannel](docs/ApiResponseCryptoDonchianChannel.md)
 - [Model.ApiResponseCryptoEaseOfMovement](docs/ApiResponseCryptoEaseOfMovement.md)
 - [Model.ApiResponseCryptoExchanges](docs/ApiResponseCryptoExchanges.md)
 - [Model.ApiResponseCryptoForceIndex](docs/ApiResponseCryptoForceIndex.md)
 - [Model.ApiResponseCryptoIchimokuKinkoHyo](docs/ApiResponseCryptoIchimokuKinkoHyo.md)
 - [Model.ApiResponseCryptoKeltnerChannel](docs/ApiResponseCryptoKeltnerChannel.md)
 - [Model.ApiResponseCryptoKnowSureThing](docs/ApiResponseCryptoKnowSureThing.md)
 - [Model.ApiResponseCryptoMassIndex](docs/ApiResponseCryptoMassIndex.md)
 - [Model.ApiResponseCryptoMoneyFlowIndex](docs/ApiResponseCryptoMoneyFlowIndex.md)
 - [Model.ApiResponseCryptoMovingAverageConvergenceDivergence](docs/ApiResponseCryptoMovingAverageConvergenceDivergence.md)
 - [Model.ApiResponseCryptoNegativeVolumeIndex](docs/ApiResponseCryptoNegativeVolumeIndex.md)
 - [Model.ApiResponseCryptoOnBalanceVolume](docs/ApiResponseCryptoOnBalanceVolume.md)
 - [Model.ApiResponseCryptoOnBalanceVolumeMean](docs/ApiResponseCryptoOnBalanceVolumeMean.md)
 - [Model.ApiResponseCryptoPairs](docs/ApiResponseCryptoPairs.md)
 - [Model.ApiResponseCryptoPrices](docs/ApiResponseCryptoPrices.md)
 - [Model.ApiResponseCryptoRelativeStrengthIndex](docs/ApiResponseCryptoRelativeStrengthIndex.md)
 - [Model.ApiResponseCryptoSimpleMovingAverage](docs/ApiResponseCryptoSimpleMovingAverage.md)
 - [Model.ApiResponseCryptoSnapshot](docs/ApiResponseCryptoSnapshot.md)
 - [Model.ApiResponseCryptoStats](docs/ApiResponseCryptoStats.md)
 - [Model.ApiResponseCryptoStochasticOscillator](docs/ApiResponseCryptoStochasticOscillator.md)
 - [Model.ApiResponseCryptoTripleExponentialAverage](docs/ApiResponseCryptoTripleExponentialAverage.md)
 - [Model.ApiResponseCryptoTrueStrengthIndex](docs/ApiResponseCryptoTrueStrengthIndex.md)
 - [Model.ApiResponseCryptoUltimateOscillator](docs/ApiResponseCryptoUltimateOscillator.md)
 - [Model.ApiResponseCryptoVolumePriceTrend](docs/ApiResponseCryptoVolumePriceTrend.md)
 - [Model.ApiResponseCryptoVolumeWeightedAveragePrice](docs/ApiResponseCryptoVolumeWeightedAveragePrice.md)
 - [Model.ApiResponseCryptoVortexIndicator](docs/ApiResponseCryptoVortexIndicator.md)
 - [Model.ApiResponseCryptoWilliamsR](docs/ApiResponseCryptoWilliamsR.md)
 - [Model.ApiResponseDataTags](docs/ApiResponseDataTags.md)
 - [Model.ApiResponseDataTagsSearch](docs/ApiResponseDataTagsSearch.md)
 - [Model.ApiResponseEconomicIndexHistoricalData](docs/ApiResponseEconomicIndexHistoricalData.md)
 - [Model.ApiResponseEconomicIndices](docs/ApiResponseEconomicIndices.md)
 - [Model.ApiResponseEconomicIndicesSearch](docs/ApiResponseEconomicIndicesSearch.md)
 - [Model.ApiResponseFilingFundamentals](docs/ApiResponseFilingFundamentals.md)
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
 - [Model.ApiResponseOptionPrices](docs/ApiResponseOptionPrices.md)
 - [Model.ApiResponseOptions](docs/ApiResponseOptions.md)
 - [Model.ApiResponseOptionsChain](docs/ApiResponseOptionsChain.md)
 - [Model.ApiResponseOptionsExpirations](docs/ApiResponseOptionsExpirations.md)
 - [Model.ApiResponseReportedFinancials](docs/ApiResponseReportedFinancials.md)
 - [Model.ApiResponseSICIndexHistoricalData](docs/ApiResponseSICIndexHistoricalData.md)
 - [Model.ApiResponseSICIndices](docs/ApiResponseSICIndices.md)
 - [Model.ApiResponseSICIndicesSearch](docs/ApiResponseSICIndicesSearch.md)
 - [Model.ApiResponseSecurities](docs/ApiResponseSecurities.md)
 - [Model.ApiResponseSecuritiesSearch](docs/ApiResponseSecuritiesSearch.md)
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
 - [Model.ApiResponseSecurityIntradayPrices](docs/ApiResponseSecurityIntradayPrices.md)
 - [Model.ApiResponseSecurityKeltnerChannel](docs/ApiResponseSecurityKeltnerChannel.md)
 - [Model.ApiResponseSecurityKnowSureThing](docs/ApiResponseSecurityKnowSureThing.md)
 - [Model.ApiResponseSecurityMassIndex](docs/ApiResponseSecurityMassIndex.md)
 - [Model.ApiResponseSecurityMoneyFlowIndex](docs/ApiResponseSecurityMoneyFlowIndex.md)
 - [Model.ApiResponseSecurityMovingAverageConvergenceDivergence](docs/ApiResponseSecurityMovingAverageConvergenceDivergence.md)
 - [Model.ApiResponseSecurityNegativeVolumeIndex](docs/ApiResponseSecurityNegativeVolumeIndex.md)
 - [Model.ApiResponseSecurityOnBalanceVolume](docs/ApiResponseSecurityOnBalanceVolume.md)
 - [Model.ApiResponseSecurityOnBalanceVolumeMean](docs/ApiResponseSecurityOnBalanceVolumeMean.md)
 - [Model.ApiResponseSecurityRelativeStrengthIndex](docs/ApiResponseSecurityRelativeStrengthIndex.md)
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
 - [Model.ApiResponseStockExchangeRealtimeStockPrices](docs/ApiResponseStockExchangeRealtimeStockPrices.md)
 - [Model.ApiResponseStockExchangeSecurities](docs/ApiResponseStockExchangeSecurities.md)
 - [Model.ApiResponseStockExchangeStockPriceAdjustments](docs/ApiResponseStockExchangeStockPriceAdjustments.md)
 - [Model.ApiResponseStockExchangeStockPrices](docs/ApiResponseStockExchangeStockPrices.md)
 - [Model.ApiResponseStockExchanges](docs/ApiResponseStockExchanges.md)
 - [Model.ApiResponseStockMarketIndexHistoricalData](docs/ApiResponseStockMarketIndexHistoricalData.md)
 - [Model.ApiResponseStockMarketIndices](docs/ApiResponseStockMarketIndices.md)
 - [Model.ApiResponseStockMarketIndicesSearch](docs/ApiResponseStockMarketIndicesSearch.md)
 - [Model.ApiResponseZacksAnalystRatings](docs/ApiResponseZacksAnalystRatings.md)
 - [Model.ApiResponseZacksEPSSurprises](docs/ApiResponseZacksEPSSurprises.md)
 - [Model.ApiResponseZacksSalesSurprises](docs/ApiResponseZacksSalesSurprises.md)
 - [Model.AverageDailyTradingVolumeTechnicalValue](docs/AverageDailyTradingVolumeTechnicalValue.md)
 - [Model.AverageDirectionalIndexTechnicalValue](docs/AverageDirectionalIndexTechnicalValue.md)
 - [Model.AverageTrueRangeTechnicalValue](docs/AverageTrueRangeTechnicalValue.md)
 - [Model.AwesomeOscillatorTechnicalValue](docs/AwesomeOscillatorTechnicalValue.md)
 - [Model.BollingerBandsTechnicalValue](docs/BollingerBandsTechnicalValue.md)
 - [Model.ChaikinMoneyFlowTechnicalValue](docs/ChaikinMoneyFlowTechnicalValue.md)
 - [Model.CommodityChannelIndexTechnicalValue](docs/CommodityChannelIndexTechnicalValue.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyFiling](docs/CompanyFiling.md)
 - [Model.CompanyNews](docs/CompanyNews.md)
 - [Model.CompanyNewsSummary](docs/CompanyNewsSummary.md)
 - [Model.CompanySummary](docs/CompanySummary.md)
 - [Model.CryptoAsk](docs/CryptoAsk.md)
 - [Model.CryptoBid](docs/CryptoBid.md)
 - [Model.CryptoBookEntry](docs/CryptoBookEntry.md)
 - [Model.CryptoCurrency](docs/CryptoCurrency.md)
 - [Model.CryptoExchange](docs/CryptoExchange.md)
 - [Model.CryptoExchangeSummary](docs/CryptoExchangeSummary.md)
 - [Model.CryptoPair](docs/CryptoPair.md)
 - [Model.CryptoPairSummary](docs/CryptoPairSummary.md)
 - [Model.CryptoPrice](docs/CryptoPrice.md)
 - [Model.CryptoSnapshot](docs/CryptoSnapshot.md)
 - [Model.CryptoStat](docs/CryptoStat.md)
 - [Model.DataTag](docs/DataTag.md)
 - [Model.DataTagSummary](docs/DataTagSummary.md)
 - [Model.DetrendedPriceOscillatorTechnicalValue](docs/DetrendedPriceOscillatorTechnicalValue.md)
 - [Model.DividendRecord](docs/DividendRecord.md)
 - [Model.DonchianChannelTechnicalValue](docs/DonchianChannelTechnicalValue.md)
 - [Model.EarningsRecord](docs/EarningsRecord.md)
 - [Model.EaseOfMovementTechnicalValue](docs/EaseOfMovementTechnicalValue.md)
 - [Model.EconomicIndex](docs/EconomicIndex.md)
 - [Model.EconomicIndexSummary](docs/EconomicIndexSummary.md)
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
 - [Model.IntradayStockPrice](docs/IntradayStockPrice.md)
 - [Model.KeltnerChannelTechnicalValue](docs/KeltnerChannelTechnicalValue.md)
 - [Model.KnowSureThingTechnicalValue](docs/KnowSureThingTechnicalValue.md)
 - [Model.MassIndexTechnicalValue](docs/MassIndexTechnicalValue.md)
 - [Model.MoneyFlowIndexTechnicalValue](docs/MoneyFlowIndexTechnicalValue.md)
 - [Model.MovingAverageConvergenceDivergenceTechnicalValue](docs/MovingAverageConvergenceDivergenceTechnicalValue.md)
 - [Model.Municipality](docs/Municipality.md)
 - [Model.MunicipalityFinancial](docs/MunicipalityFinancial.md)
 - [Model.NegativeVolumeIndexTechnicalValue](docs/NegativeVolumeIndexTechnicalValue.md)
 - [Model.OnBalanceVolumeMeanTechnicalValue](docs/OnBalanceVolumeMeanTechnicalValue.md)
 - [Model.OnBalanceVolumeTechnicalValue](docs/OnBalanceVolumeTechnicalValue.md)
 - [Model.Option](docs/Option.md)
 - [Model.OptionChain](docs/OptionChain.md)
 - [Model.OptionPrice](docs/OptionPrice.md)
 - [Model.RealtimeStockPrice](docs/RealtimeStockPrice.md)
 - [Model.RealtimeStockPriceSecurity](docs/RealtimeStockPriceSecurity.md)
 - [Model.RelativeStrengthIndexTechnicalValue](docs/RelativeStrengthIndexTechnicalValue.md)
 - [Model.ReportedFinancial](docs/ReportedFinancial.md)
 - [Model.ReportedFinancialDimension](docs/ReportedFinancialDimension.md)
 - [Model.ReportedTag](docs/ReportedTag.md)
 - [Model.SICIndex](docs/SICIndex.md)
 - [Model.Security](docs/Security.md)
 - [Model.SecurityScreenClause](docs/SecurityScreenClause.md)
 - [Model.SecurityScreenGroup](docs/SecurityScreenGroup.md)
 - [Model.SecurityScreenResult](docs/SecurityScreenResult.md)
 - [Model.SecurityScreenResultData](docs/SecurityScreenResultData.md)
 - [Model.SecuritySummary](docs/SecuritySummary.md)
 - [Model.SimpleMovingAverageTechnicalValue](docs/SimpleMovingAverageTechnicalValue.md)
 - [Model.StandardizedFinancial](docs/StandardizedFinancial.md)
 - [Model.StochasticOscillatorTechnicalValue](docs/StochasticOscillatorTechnicalValue.md)
 - [Model.StockExchange](docs/StockExchange.md)
 - [Model.StockMarketIndex](docs/StockMarketIndex.md)
 - [Model.StockMarketIndexSummary](docs/StockMarketIndexSummary.md)
 - [Model.StockPrice](docs/StockPrice.md)
 - [Model.StockPriceAdjustment](docs/StockPriceAdjustment.md)
 - [Model.StockPriceAdjustmentSummary](docs/StockPriceAdjustmentSummary.md)
 - [Model.StockPriceSummary](docs/StockPriceSummary.md)
 - [Model.TechnicalIndicator](docs/TechnicalIndicator.md)
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
 - [Model.ZacksEPSSurprise](docs/ZacksEPSSurprise.md)
 - [Model.ZacksEPSSurpriseSummary](docs/ZacksEPSSurpriseSummary.md)
 - [Model.ZacksSalesSurprise](docs/ZacksSalesSurprise.md)
 - [Model.ZacksSalesSurpriseSummary](docs/ZacksSalesSurpriseSummary.md)


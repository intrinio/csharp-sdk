

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Intrinio.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStockExchangeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Returns all Stock Exchanges matching the specified parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseStockExchanges</returns>
        ApiResponseStockExchanges GetAllStockExchanges (string city = null, string country = null, string countryCode = null, int? pageSize = null);

        /// <summary>
        /// All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Returns all Stock Exchanges matching the specified parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseStockExchanges</returns>
        ApiResponse<ApiResponseStockExchanges> GetAllStockExchangesWithHttpInfo (string city = null, string country = null, string countryCode = null, int? pageSize = null);
        /// <summary>
        /// Security Betas
        /// </summary>
        /// <remarks>
        /// Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeBetas</returns>
        ApiResponseStockExchangeBetas GetStockExchangeBetas (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Security Betas
        /// </summary>
        /// <remarks>
        /// Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeBetas</returns>
        ApiResponse<ApiResponseStockExchangeBetas> GetStockExchangeBetasWithHttpInfo (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup Stock Exchange
        /// </summary>
        /// <remarks>
        /// Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>StockExchange</returns>
        StockExchange GetStockExchangeById (string identifier);

        /// <summary>
        /// Lookup Stock Exchange
        /// </summary>
        /// <remarks>
        /// Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>ApiResponse of StockExchange</returns>
        ApiResponse<StockExchange> GetStockExchangeByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Top Gainers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponseStockExchangeMovers</returns>
        ApiResponseStockExchangeMovers GetStockExchangeGainers (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);

        /// <summary>
        /// Top Gainers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeMovers</returns>
        ApiResponse<ApiResponseStockExchangeMovers> GetStockExchangeGainersWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);
        /// <summary>
        /// Top Losers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponseStockExchangeMovers</returns>
        ApiResponseStockExchangeMovers GetStockExchangeLosers (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);

        /// <summary>
        /// Top Losers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeMovers</returns>
        ApiResponse<ApiResponseStockExchangeMovers> GetStockExchangeLosersWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);
        /// <summary>
        /// Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
        ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
        ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Dividends by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
        ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustmentsDividends (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Dividends by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
        ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsDividendsWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Splits by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
        ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustmentsSplits (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Splits by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
        ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsSplitsWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPrices</returns>
        ApiResponseStockExchangeStockPrices GetStockExchangePrices (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null);

        /// <summary>
        /// Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPrices</returns>
        ApiResponse<ApiResponseStockExchangeStockPrices> GetStockExchangePricesWithHttpInfo (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null);
        /// <summary>
        /// Realtime Quote Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>ApiResponseStockExchangeQuote</returns>
        ApiResponseStockExchangeQuote GetStockExchangeQuote (string identifier, List<string> tickers, string source = null, bool? activeOnly = null);

        /// <summary>
        /// Realtime Quote Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeQuote</returns>
        ApiResponse<ApiResponseStockExchangeQuote> GetStockExchangeQuoteWithHttpInfo (string identifier, List<string> tickers, string source = null, bool? activeOnly = null);
        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeRealtimeStockPrices</returns>
        ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);

        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeRealtimeStockPrices</returns>
        ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);
        /// <summary>
        /// Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeSecurities</returns>
        ApiResponseStockExchangeSecurities GetStockExchangeSecurities (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeSecurities</returns>
        ApiResponse<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Returns all Stock Exchanges matching the specified parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseStockExchanges</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchanges> GetAllStockExchangesAsync (string city = null, string country = null, string countryCode = null, int? pageSize = null);

        /// <summary>
        /// All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Returns all Stock Exchanges matching the specified parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchanges)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchanges>> GetAllStockExchangesAsyncWithHttpInfo (string city = null, string country = null, string countryCode = null, int? pageSize = null);
        /// <summary>
        /// Security Betas
        /// </summary>
        /// <remarks>
        /// Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeBetas</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeBetas> GetStockExchangeBetasAsync (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Security Betas
        /// </summary>
        /// <remarks>
        /// Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeBetas)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeBetas>> GetStockExchangeBetasAsyncWithHttpInfo (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup Stock Exchange
        /// </summary>
        /// <remarks>
        /// Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of StockExchange</returns>
        System.Threading.Tasks.Task<StockExchange> GetStockExchangeByIdAsync (string identifier);

        /// <summary>
        /// Lookup Stock Exchange
        /// </summary>
        /// <remarks>
        /// Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of ApiResponse (StockExchange)</returns>
        System.Threading.Tasks.Task<ApiResponse<StockExchange>> GetStockExchangeByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Top Gainers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeMovers</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeMovers> GetStockExchangeGainersAsync (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);

        /// <summary>
        /// Top Gainers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeMovers)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeMovers>> GetStockExchangeGainersAsyncWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);
        /// <summary>
        /// Top Losers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeMovers</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeMovers> GetStockExchangeLosersAsync (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);

        /// <summary>
        /// Top Losers by Exchange
        /// </summary>
        /// <remarks>
        /// Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeMovers)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeMovers>> GetStockExchangeLosersAsyncWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null);
        /// <summary>
        /// Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsAsync (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>> GetStockExchangePriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Dividends by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsDividendsAsync (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Dividends by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>> GetStockExchangePriceAdjustmentsDividendsAsyncWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Splits by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsSplitsAsync (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Splits by date for exchange
        /// </summary>
        /// <remarks>
        /// Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>> GetStockExchangePriceAdjustmentsSplitsAsyncWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPrices</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeStockPrices> GetStockExchangePricesAsync (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null);

        /// <summary>
        /// Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPrices>> GetStockExchangePricesAsyncWithHttpInfo (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null);
        /// <summary>
        /// Realtime Quote Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeQuote</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeQuote> GetStockExchangeQuoteAsync (string identifier, List<string> tickers, string source = null, bool? activeOnly = null);

        /// <summary>
        /// Realtime Quote Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeQuote)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeQuote>> GetStockExchangeQuoteAsyncWithHttpInfo (string identifier, List<string> tickers, string source = null, bool? activeOnly = null);
        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeRealtimeStockPrices</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesAsync (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);

        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeRealtimeStockPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>> GetStockExchangeRealtimePricesAsyncWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);
        /// <summary>
        /// Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeSecurities</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesAsync (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeSecurities)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeSecurities>> GetStockExchangeSecuritiesAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StockExchangeApi : IStockExchangeApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchangeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StockExchangeApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchangeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StockExchangeApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Intrinio.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
        
        private static bool ValidateTimeParam(string time) {
          string validTimePattern = @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$";
            Regex validTimeRegex = new Regex(validTimePattern);
            bool invalidTime = !(validTimeRegex.IsMatch(time));
          
          if (invalidTime)
            throw new ArgumentException("Time must be in the format 'hh:mm'");
          else
              return true;
        }

        /// <summary>
        /// All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseStockExchanges</returns>
        public ApiResponseStockExchanges GetAllStockExchanges (string city = null, string country = null, string countryCode = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseStockExchanges> localVarResponse = GetAllStockExchangesWithHttpInfo(city, country, countryCode, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseStockExchanges</returns>
        
        public ApiResponse< ApiResponseStockExchanges > GetAllStockExchangesWithHttpInfo (string city = null, string country = null, string countryCode = null, int? pageSize = null)
        {

            var localVarPath = "/stock_exchanges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (city != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "city", city)); // query parameter
            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
            if (countryCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code", countryCode)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllStockExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchanges>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchanges) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchanges)));
        }

        /// <summary>
        /// All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseStockExchanges</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchanges> GetAllStockExchangesAsync (string city = null, string country = null, string countryCode = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseStockExchanges> localVarResponse = await GetAllStockExchangesAsyncWithHttpInfo(city, country, countryCode, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Stock Exchanges Returns all Stock Exchanges matching the specified parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchanges)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchanges>> GetAllStockExchangesAsyncWithHttpInfo (string city = null, string country = null, string countryCode = null, int? pageSize = null)
        {

            var localVarPath = "/stock_exchanges";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (city != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "city", city)); // query parameter
            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
            if (countryCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code", countryCode)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllStockExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchanges>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchanges) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchanges)));
        }

        /// <summary>
        /// Security Betas Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeBetas</returns>
        public ApiResponseStockExchangeBetas GetStockExchangeBetas (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeBetas> localVarResponse = GetStockExchangeBetasWithHttpInfo(identifier, type, date, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Security Betas Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeBetas</returns>
        
        public ApiResponse< ApiResponseStockExchangeBetas > GetStockExchangeBetasWithHttpInfo (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeBetas");

            var localVarPath = "/stock_exchanges/{identifier}/betas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeBetas", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeBetas>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeBetas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeBetas)));
        }

        /// <summary>
        /// Security Betas Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeBetas</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeBetas> GetStockExchangeBetasAsync (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeBetas> localVarResponse = await GetStockExchangeBetasAsyncWithHttpInfo(identifier, type, date, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Security Betas Returns security beta data in the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="type">Only of the given type (optional, default to weekly)</param>
        /// <param name="date">Return data for this period end date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeBetas)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeBetas>> GetStockExchangeBetasAsyncWithHttpInfo (string identifier, string type = null, Object date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeBetas");

            var localVarPath = "/stock_exchanges/{identifier}/betas";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeBetas", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeBetas>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeBetas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeBetas)));
        }

        /// <summary>
        /// Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>StockExchange</returns>
        public StockExchange GetStockExchangeById (string identifier)
        {
             ApiResponse<StockExchange> localVarResponse = GetStockExchangeByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>ApiResponse of StockExchange</returns>
        
        public ApiResponse< StockExchange > GetStockExchangeByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeById");

            var localVarPath = "/stock_exchanges/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StockExchange>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (StockExchange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockExchange)));
        }

        /// <summary>
        /// Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of StockExchange</returns>
        public async System.Threading.Tasks.Task<StockExchange> GetStockExchangeByIdAsync (string identifier)
        {
             ApiResponse<StockExchange> localVarResponse = await GetStockExchangeByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Stock Exchange Returns the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of ApiResponse (StockExchange)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StockExchange>> GetStockExchangeByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeById");

            var localVarPath = "/stock_exchanges/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StockExchange>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (StockExchange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockExchange)));
        }

        /// <summary>
        /// Top Gainers by Exchange Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponseStockExchangeMovers</returns>
        public ApiResponseStockExchangeMovers GetStockExchangeGainers (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
             ApiResponse<ApiResponseStockExchangeMovers> localVarResponse = GetStockExchangeGainersWithHttpInfo(identifier, minPrice, pageSize, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Top Gainers by Exchange Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeMovers</returns>
        
        public ApiResponse< ApiResponseStockExchangeMovers > GetStockExchangeGainersWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeGainers");

            var localVarPath = "/stock_exchanges/{identifier}/gainers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (minPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_price", minPrice)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeGainers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeMovers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeMovers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeMovers)));
        }

        /// <summary>
        /// Top Gainers by Exchange Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeMovers</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeMovers> GetStockExchangeGainersAsync (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
             ApiResponse<ApiResponseStockExchangeMovers> localVarResponse = await GetStockExchangeGainersAsyncWithHttpInfo(identifier, minPrice, pageSize, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Top Gainers by Exchange Returns securities with the highest gain percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeMovers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeMovers>> GetStockExchangeGainersAsyncWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeGainers");

            var localVarPath = "/stock_exchanges/{identifier}/gainers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (minPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_price", minPrice)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeGainers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeMovers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeMovers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeMovers)));
        }

        /// <summary>
        /// Top Losers by Exchange Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponseStockExchangeMovers</returns>
        public ApiResponseStockExchangeMovers GetStockExchangeLosers (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
             ApiResponse<ApiResponseStockExchangeMovers> localVarResponse = GetStockExchangeLosersWithHttpInfo(identifier, minPrice, pageSize, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Top Losers by Exchange Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeMovers</returns>
        
        public ApiResponse< ApiResponseStockExchangeMovers > GetStockExchangeLosersWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeLosers");

            var localVarPath = "/stock_exchanges/{identifier}/losers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (minPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_price", minPrice)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeLosers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeMovers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeMovers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeMovers)));
        }

        /// <summary>
        /// Top Losers by Exchange Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeMovers</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeMovers> GetStockExchangeLosersAsync (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
             ApiResponse<ApiResponseStockExchangeMovers> localVarResponse = await GetStockExchangeLosersAsyncWithHttpInfo(identifier, minPrice, pageSize, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Top Losers by Exchange Returns securities with the highest loss percent change traded on the chosen stock exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="minPrice">The minimum price filter (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeMovers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeMovers>> GetStockExchangeLosersAsyncWithHttpInfo (string identifier, decimal? minPrice = null, int? pageSize = null, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeLosers");

            var localVarPath = "/stock_exchanges/{identifier}/losers";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (minPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_price", minPrice)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeLosers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeMovers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeMovers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeMovers)));
        }

        /// <summary>
        /// Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
        public ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> localVarResponse = GetStockExchangePriceAdjustmentsWithHttpInfo(identifier, date, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
        
        public ApiResponse< ApiResponseStockExchangeStockPriceAdjustments > GetStockExchangePriceAdjustmentsWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustments");

            var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPriceAdjustments)));
        }

        /// <summary>
        /// Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsAsync (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> localVarResponse = await GetStockExchangePriceAdjustmentsAsyncWithHttpInfo(identifier, date, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stock Price Adjustments by Exchange Returns stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>> GetStockExchangePriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustments");

            var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPriceAdjustments)));
        }

        /// <summary>
        /// Dividends by date for exchange Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
        public ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustmentsDividends (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> localVarResponse = GetStockExchangePriceAdjustmentsDividendsWithHttpInfo(identifier, date, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Dividends by date for exchange Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
        
        public ApiResponse< ApiResponseStockExchangeStockPriceAdjustments > GetStockExchangePriceAdjustmentsDividendsWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustmentsDividends");

            var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments/dividends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustmentsDividends", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPriceAdjustments)));
        }

        /// <summary>
        /// Dividends by date for exchange Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsDividendsAsync (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> localVarResponse = await GetStockExchangePriceAdjustmentsDividendsAsyncWithHttpInfo(identifier, date, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Dividends by date for exchange Returns dividend adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return dividends (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>> GetStockExchangePriceAdjustmentsDividendsAsyncWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustmentsDividends");

            var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments/dividends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustmentsDividends", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPriceAdjustments)));
        }

        /// <summary>
        /// Splits by date for exchange Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPriceAdjustments</returns>
        public ApiResponseStockExchangeStockPriceAdjustments GetStockExchangePriceAdjustmentsSplits (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> localVarResponse = GetStockExchangePriceAdjustmentsSplitsWithHttpInfo(identifier, date, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Splits by date for exchange Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPriceAdjustments</returns>
        
        public ApiResponse< ApiResponseStockExchangeStockPriceAdjustments > GetStockExchangePriceAdjustmentsSplitsWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustmentsSplits");

            var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments/splits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustmentsSplits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPriceAdjustments)));
        }

        /// <summary>
        /// Splits by date for exchange Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPriceAdjustments</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeStockPriceAdjustments> GetStockExchangePriceAdjustmentsSplitsAsync (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPriceAdjustments> localVarResponse = await GetStockExchangePriceAdjustmentsSplitsAsyncWithHttpInfo(identifier, date, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Splits by date for exchange Returns split adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return splits (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPriceAdjustments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>> GetStockExchangePriceAdjustmentsSplitsAsyncWithHttpInfo (string identifier, DateTime? date = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePriceAdjustmentsSplits");

            var localVarPath = "/stock_exchanges/{identifier}/prices/adjustments/splits";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustmentsSplits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPriceAdjustments)));
        }

        /// <summary>
        /// Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeStockPrices</returns>
        public ApiResponseStockExchangeStockPrices GetStockExchangePrices (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPrices> localVarResponse = GetStockExchangePricesWithHttpInfo(identifier, date, startDate, endDate, pageSize, nextPage, tickers, nextPage2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPrices</returns>
        
        public ApiResponse< ApiResponseStockExchangeStockPrices > GetStockExchangePricesWithHttpInfo (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePrices");

            var localVarPath = "/stock_exchanges/{identifier}/prices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (tickers != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "tickers", tickers)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPrices)));
        }

        /// <summary>
        /// Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeStockPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeStockPrices> GetStockExchangePricesAsync (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseStockExchangeStockPrices> localVarResponse = await GetStockExchangePricesAsyncWithHttpInfo(identifier, date, startDate, endDate, pageSize, nextPage, tickers, nextPage2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter down to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPrices>> GetStockExchangePricesAsyncWithHttpInfo (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangePrices");

            var localVarPath = "/stock_exchanges/{identifier}/prices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (tickers != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "tickers", tickers)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeStockPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeStockPrices)));
        }

        /// <summary>
        /// Realtime Quote Prices by Exchange Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>ApiResponseStockExchangeQuote</returns>
        public ApiResponseStockExchangeQuote GetStockExchangeQuote (string identifier, List<string> tickers, string source = null, bool? activeOnly = null)
        {
             ApiResponse<ApiResponseStockExchangeQuote> localVarResponse = GetStockExchangeQuoteWithHttpInfo(identifier, tickers, source, activeOnly);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realtime Quote Prices by Exchange Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeQuote</returns>
        
        public ApiResponse< ApiResponseStockExchangeQuote > GetStockExchangeQuoteWithHttpInfo (string identifier, List<string> tickers, string source = null, bool? activeOnly = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeQuote");
            // verify the required parameter 'tickers' is set
            if (tickers == null)
                throw new ApiException(400, "Missing required parameter 'tickers' when calling StockExchangeApi->GetStockExchangeQuote");

            var localVarPath = "/stock_exchanges/{identifier}/quote";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (activeOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active_only", activeOnly)); // query parameter
            if (tickers != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "tickers", tickers)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeQuote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeQuote>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeQuote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeQuote)));
        }

        /// <summary>
        /// Realtime Quote Prices by Exchange Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeQuote</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeQuote> GetStockExchangeQuoteAsync (string identifier, List<string> tickers, string source = null, bool? activeOnly = null)
        {
             ApiResponse<ApiResponseStockExchangeQuote> localVarResponse = await GetStockExchangeQuoteAsyncWithHttpInfo(identifier, tickers, source, activeOnly);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realtime Quote Prices by Exchange Returns many popular metrics for securities from a given exchange &#39;identifier&#39; from multiple products conveniently in one API. Realtime stock price data requires at least one realtime product subscription (IEX, NASDAQ Basic, and/or Delayed SIP).  If you are subscribed to multiple realtime stock price products, the api will return the most recent realtime stock price. Previous close price and percent change fields require both an EoD US Stock Price subscription and a realtime stock price subscription. Market_cap, price_to_earnings, and dividendyield data fields require a fundamentals subscription.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to return quotes for.</param>
        /// <param name="source">Return the realtime price from the specified source instead of the most recent. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeQuote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeQuote>> GetStockExchangeQuoteAsyncWithHttpInfo (string identifier, List<string> tickers, string source = null, bool? activeOnly = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeQuote");
            // verify the required parameter 'tickers' is set
            if (tickers == null)
                throw new ApiException(400, "Missing required parameter 'tickers' when calling StockExchangeApi->GetStockExchangeQuote");

            var localVarPath = "/stock_exchanges/{identifier}/quote";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (activeOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active_only", activeOnly)); // query parameter
            if (tickers != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "tickers", tickers)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeQuote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeQuote>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeQuote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeQuote)));
        }

        /// <summary>
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeRealtimeStockPrices</returns>
        public ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> localVarResponse = GetStockExchangeRealtimePricesWithHttpInfo(identifier, source, activeOnly, tradedToday, pageSize, tickers, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeRealtimeStockPrices</returns>
        
        public ApiResponse< ApiResponseStockExchangeRealtimeStockPrices > GetStockExchangeRealtimePricesWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeRealtimePrices");

            var localVarPath = "/stock_exchanges/{identifier}/prices/realtime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "source", source)); // query parameter
            if (activeOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active_only", activeOnly)); // query parameter
            if (tradedToday != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "traded_today", tradedToday)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (tickers != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "tickers", tickers)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeRealtimePrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeRealtimeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeRealtimeStockPrices)));
        }

        /// <summary>
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeRealtimeStockPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesAsync (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> localVarResponse = await GetStockExchangeRealtimePricesAsyncWithHttpInfo(identifier, source, activeOnly, tradedToday, pageSize, tickers, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified comma-delimited data sources. If no source is specified, all sources available to user are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="tradedToday">Returns prices only from securities which have traded on the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The comma-delimited list of ticker symbols to filter to. If not provided, the entire stock exchange is returned. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeRealtimeStockPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>> GetStockExchangeRealtimePricesAsyncWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, bool? tradedToday = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeRealtimePrices");

            var localVarPath = "/stock_exchanges/{identifier}/prices/realtime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "source", source)); // query parameter
            if (activeOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active_only", activeOnly)); // query parameter
            if (tradedToday != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "traded_today", tradedToday)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (tickers != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("csv", "tickers", tickers)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeRealtimePrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeRealtimeStockPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeRealtimeStockPrices)));
        }

        /// <summary>
        /// Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeSecurities</returns>
        public ApiResponseStockExchangeSecurities GetStockExchangeSecurities (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeSecurities> localVarResponse = GetStockExchangeSecuritiesWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeSecurities</returns>
        
        public ApiResponse< ApiResponseStockExchangeSecurities > GetStockExchangeSecuritiesWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeSecurities");

            var localVarPath = "/stock_exchanges/{identifier}/securities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeSecurities>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeSecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeSecurities)));
        }

        /// <summary>
        /// Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeSecurities</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeSecurities> GetStockExchangeSecuritiesAsync (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeSecurities> localVarResponse = await GetStockExchangeSecuritiesAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Securities by Exchange Returns Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeSecurities)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeSecurities>> GetStockExchangeSecuritiesAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling StockExchangeApi->GetStockExchangeSecurities");

            var localVarPath = "/stock_exchanges/{identifier}/securities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStockExchangeSecurities>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStockExchangeSecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStockExchangeSecurities)));
        }

    }
}

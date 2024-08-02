

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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeStockPrices</returns>
        ApiResponse<ApiResponseStockExchangeStockPrices> GetStockExchangePricesWithHttpInfo (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null);
        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeRealtimeStockPrices</returns>
        ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);

        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeRealtimeStockPrices</returns>
        ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);
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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeStockPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeStockPrices>> GetStockExchangePricesAsyncWithHttpInfo (string identifier, DateTime? date = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null, List<string> tickers = null, string nextPage2 = null);
        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeRealtimeStockPrices</returns>
        System.Threading.Tasks.Task<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesAsync (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);

        /// <summary>
        /// Realtime Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeRealtimeStockPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>> GetStockExchangeRealtimePricesAsyncWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null);
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
        /// Stock Prices by Exchange Returns end-of-day stock prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices. May not be used with the start_date and end_date parameters. (optional)</param>
        /// <param name="startDate">The start of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="endDate">The end of the date range you&#39;re querying. May not be used with date parameter. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
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
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
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
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseStockExchangeRealtimeStockPrices</returns>
        public ApiResponseStockExchangeRealtimeStockPrices GetStockExchangeRealtimePrices (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> localVarResponse = GetStockExchangeRealtimePricesWithHttpInfo(identifier, source, activeOnly, pageSize, tickers, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseStockExchangeRealtimeStockPrices</returns>
        
        public ApiResponse< ApiResponseStockExchangeRealtimeStockPrices > GetStockExchangeRealtimePricesWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
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
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseStockExchangeRealtimeStockPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseStockExchangeRealtimeStockPrices> GetStockExchangeRealtimePricesAsync (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
        {
             ApiResponse<ApiResponseStockExchangeRealtimeStockPrices> localVarResponse = await GetStockExchangeRealtimePricesAsyncWithHttpInfo(identifier, source, activeOnly, pageSize, tickers, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realtime Stock Prices by Exchange Returns realtime stock prices for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="source">Return realtime prices from the specified data source. If no source is specified, all sources are used. (optional)</param>
        /// <param name="activeOnly">Returns prices only from the most recent trading day. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="tickers">The list of ticker symbols to filter to. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseStockExchangeRealtimeStockPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStockExchangeRealtimeStockPrices>> GetStockExchangeRealtimePricesAsyncWithHttpInfo (string identifier, List<string> source = null, bool? activeOnly = null, int? pageSize = null, List<string> tickers = null, string nextPage = null)
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

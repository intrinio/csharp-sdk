

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Intrinio.Client;
using Intrinio.Model;

namespace Intrinio.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStockExchangeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Filter Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return Stock Exchanges matching the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 FilterStockExchanges (string city = null, string country = null, string countryCode = null);

        /// <summary>
        /// Filter Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return Stock Exchanges matching the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>ApiResponse of InlineResponse20028</returns>
        ApiResponse<InlineResponse20028> FilterStockExchangesWithHttpInfo (string city = null, string country = null, string countryCode = null);
        /// <summary>
        /// Get All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return All Stock Exchanges
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 GetAllStockExchanges ();

        /// <summary>
        /// Get All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return All Stock Exchanges
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse20028</returns>
        ApiResponse<InlineResponse20028> GetAllStockExchangesWithHttpInfo ();
        /// <summary>
        /// Get Stock Exchange by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>StockExchange</returns>
        StockExchange GetStockExchangeById (string identifier);

        /// <summary>
        /// Get Stock Exchange by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>ApiResponse of StockExchange</returns>
        ApiResponse<StockExchange> GetStockExchangeByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Get Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, string nextPage = null);

        /// <summary>
        /// Get Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20030</returns>
        ApiResponse<InlineResponse20030> GetStockExchangePriceAdjustmentsWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null);
        /// <summary>
        /// Get Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 GetStockExchangePrices (string identifier, DateTime? date = null, string nextPage = null);

        /// <summary>
        /// Get Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20029</returns>
        ApiResponse<InlineResponse20029> GetStockExchangePricesWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null);
        /// <summary>
        /// Get Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 GetStockExchangeSecurities (string identifier, string nextPage = null);

        /// <summary>
        /// Get Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20031</returns>
        ApiResponse<InlineResponse20031> GetStockExchangeSecuritiesWithHttpInfo (string identifier, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Filter Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return Stock Exchanges matching the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>Task of InlineResponse20028</returns>
        System.Threading.Tasks.Task<InlineResponse20028> FilterStockExchangesAsync (string city = null, string country = null, string countryCode = null);

        /// <summary>
        /// Filter Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return Stock Exchanges matching the given filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20028)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20028>> FilterStockExchangesAsyncWithHttpInfo (string city = null, string country = null, string countryCode = null);
        /// <summary>
        /// Get All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return All Stock Exchanges
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse20028</returns>
        System.Threading.Tasks.Task<InlineResponse20028> GetAllStockExchangesAsync ();

        /// <summary>
        /// Get All Stock Exchanges
        /// </summary>
        /// <remarks>
        /// Return All Stock Exchanges
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse20028)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20028>> GetAllStockExchangesAsyncWithHttpInfo ();
        /// <summary>
        /// Get Stock Exchange by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of StockExchange</returns>
        System.Threading.Tasks.Task<StockExchange> GetStockExchangeByIdAsync (string identifier);

        /// <summary>
        /// Get Stock Exchange by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of ApiResponse (StockExchange)</returns>
        System.Threading.Tasks.Task<ApiResponse<StockExchange>> GetStockExchangeByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20030</returns>
        System.Threading.Tasks.Task<InlineResponse20030> GetStockExchangePriceAdjustmentsAsync (string identifier, DateTime? date = null, string nextPage = null);

        /// <summary>
        /// Get Stock Price Adjustments by Exchange
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20030)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20030>> GetStockExchangePriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null);
        /// <summary>
        /// Get Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20029</returns>
        System.Threading.Tasks.Task<InlineResponse20029> GetStockExchangePricesAsync (string identifier, DateTime? date = null, string nextPage = null);

        /// <summary>
        /// Get Stock Prices by Exchange
        /// </summary>
        /// <remarks>
        /// Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> GetStockExchangePricesAsyncWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null);
        /// <summary>
        /// Get Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20031</returns>
        System.Threading.Tasks.Task<InlineResponse20031> GetStockExchangeSecuritiesAsync (string identifier, string nextPage = null);

        /// <summary>
        /// Get Securities by Exchange
        /// </summary>
        /// <remarks>
        /// Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20031)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20031>> GetStockExchangeSecuritiesAsyncWithHttpInfo (string identifier, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StockExchangeApi : IStockExchangeApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockExchangeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StockExchangeApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
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

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        public Intrinio.Client.ExceptionFactory ExceptionFactory
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

        /// <summary>
        /// Filter Stock Exchanges Return Stock Exchanges matching the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>InlineResponse20028</returns>
        public InlineResponse20028 FilterStockExchanges (string city = null, string country = null, string countryCode = null)
        {
             ApiResponse<InlineResponse20028> localVarResponse = FilterStockExchangesWithHttpInfo(city, country, countryCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Stock Exchanges Return Stock Exchanges matching the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>ApiResponse of InlineResponse20028</returns>
        public ApiResponse< InlineResponse20028 > FilterStockExchangesWithHttpInfo (string city = null, string country = null, string countryCode = null)
        {

            var localVarPath = "/stock_exchanges/filter";
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

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterStockExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20028>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20028) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20028)));
        }

        /// <summary>
        /// Filter Stock Exchanges Return Stock Exchanges matching the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>Task of InlineResponse20028</returns>
        public async System.Threading.Tasks.Task<InlineResponse20028> FilterStockExchangesAsync (string city = null, string country = null, string countryCode = null)
        {
             ApiResponse<InlineResponse20028> localVarResponse = await FilterStockExchangesAsyncWithHttpInfo(city, country, countryCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Stock Exchanges Return Stock Exchanges matching the given filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="city">Filter by city (optional)</param>
        /// <param name="country">Filter by country (optional)</param>
        /// <param name="countryCode">Filter by ISO country code (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20028)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20028>> FilterStockExchangesAsyncWithHttpInfo (string city = null, string country = null, string countryCode = null)
        {

            var localVarPath = "/stock_exchanges/filter";
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

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterStockExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20028>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20028) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20028)));
        }

        /// <summary>
        /// Get All Stock Exchanges Return All Stock Exchanges
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse20028</returns>
        public InlineResponse20028 GetAllStockExchanges ()
        {
             ApiResponse<InlineResponse20028> localVarResponse = GetAllStockExchangesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Stock Exchanges Return All Stock Exchanges
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse20028</returns>
        public ApiResponse< InlineResponse20028 > GetAllStockExchangesWithHttpInfo ()
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


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllStockExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20028>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20028) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20028)));
        }

        /// <summary>
        /// Get All Stock Exchanges Return All Stock Exchanges
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse20028</returns>
        public async System.Threading.Tasks.Task<InlineResponse20028> GetAllStockExchangesAsync ()
        {
             ApiResponse<InlineResponse20028> localVarResponse = await GetAllStockExchangesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Stock Exchanges Return All Stock Exchanges
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse20028)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20028>> GetAllStockExchangesAsyncWithHttpInfo ()
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


            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllStockExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20028>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20028) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20028)));
        }

        /// <summary>
        /// Get Stock Exchange by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>StockExchange</returns>
        public StockExchange GetStockExchangeById (string identifier)
        {
             ApiResponse<StockExchange> localVarResponse = GetStockExchangeByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Exchange by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
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
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StockExchange>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StockExchange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockExchange)));
        }

        /// <summary>
        /// Get Stock Exchange by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <returns>Task of StockExchange</returns>
        public async System.Threading.Tasks.Task<StockExchange> GetStockExchangeByIdAsync (string identifier)
        {
             ApiResponse<StockExchange> localVarResponse = await GetStockExchangeByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Exchange by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
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
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StockExchange>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StockExchange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StockExchange)));
        }

        /// <summary>
        /// Get Stock Price Adjustments by Exchange Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20030</returns>
        public InlineResponse20030 GetStockExchangePriceAdjustments (string identifier, DateTime? date = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20030> localVarResponse = GetStockExchangePriceAdjustmentsWithHttpInfo(identifier, date, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Price Adjustments by Exchange Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20030</returns>
        public ApiResponse< InlineResponse20030 > GetStockExchangePriceAdjustmentsWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null)
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20030>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20030) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20030)));
        }

        /// <summary>
        /// Get Stock Price Adjustments by Exchange Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20030</returns>
        public async System.Threading.Tasks.Task<InlineResponse20030> GetStockExchangePriceAdjustmentsAsync (string identifier, DateTime? date = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20030> localVarResponse = await GetStockExchangePriceAdjustmentsAsyncWithHttpInfo(identifier, date, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Price Adjustments by Exchange Return stock price adjustments for the Stock Exchange with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return price adjustments (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20030)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20030>> GetStockExchangePriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null)
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20030>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20030) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20030)));
        }

        /// <summary>
        /// Get Stock Prices by Exchange Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20029</returns>
        public InlineResponse20029 GetStockExchangePrices (string identifier, DateTime? date = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20029> localVarResponse = GetStockExchangePricesWithHttpInfo(identifier, date, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Prices by Exchange Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20029</returns>
        public ApiResponse< InlineResponse20029 > GetStockExchangePricesWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null)
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20029>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20029)));
        }

        /// <summary>
        /// Get Stock Prices by Exchange Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20029</returns>
        public async System.Threading.Tasks.Task<InlineResponse20029> GetStockExchangePricesAsync (string identifier, DateTime? date = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20029> localVarResponse = await GetStockExchangePricesAsyncWithHttpInfo(identifier, date, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Prices by Exchange Return daily Stock Prices for Securities on the Stock Exchange with &#x60;identifier&#x60; and on the &#x60;price_date&#x60; (or the latest date that prices are available)
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="date">The date for which to return prices (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20029)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20029>> GetStockExchangePricesAsyncWithHttpInfo (string identifier, DateTime? date = null, string nextPage = null)
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangePrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20029>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20029) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20029)));
        }

        /// <summary>
        /// Get Securities by Exchange Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20031</returns>
        public InlineResponse20031 GetStockExchangeSecurities (string identifier, string nextPage = null)
        {
             ApiResponse<InlineResponse20031> localVarResponse = GetStockExchangeSecuritiesWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Securities by Exchange Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20031</returns>
        public ApiResponse< InlineResponse20031 > GetStockExchangeSecuritiesWithHttpInfo (string identifier, string nextPage = null)
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20031>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20031) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20031)));
        }

        /// <summary>
        /// Get Securities by Exchange Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20031</returns>
        public async System.Threading.Tasks.Task<InlineResponse20031> GetStockExchangeSecuritiesAsync (string identifier, string nextPage = null)
        {
             ApiResponse<InlineResponse20031> localVarResponse = await GetStockExchangeSecuritiesAsyncWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Securities by Exchange Return Securities traded on the Stock Exchange with &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Stock Exchange identifier (MIC or Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20031)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20031>> GetStockExchangeSecuritiesAsyncWithHttpInfo (string identifier, string nextPage = null)
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }
            // authentication (HttpHeaderApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = Configuration.GetApiKeyWithPrefix("api-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStockExchangeSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20031>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20031) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20031)));
        }

    }
}

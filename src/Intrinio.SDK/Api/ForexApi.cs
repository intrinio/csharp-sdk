

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
    public interface IForexApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Forex Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of forex currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponseForexCurrencies</returns>
        ApiResponseForexCurrencies GetForexCurrencies ();

        /// <summary>
        /// Forex Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of forex currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiResponseForexCurrencies</returns>
        ApiResponse<ApiResponseForexCurrencies> GetForexCurrenciesWithHttpInfo ();
        /// <summary>
        /// Forex Currency Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponseForexPairs</returns>
        ApiResponseForexPairs GetForexPairs ();

        /// <summary>
        /// Forex Currency Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiResponseForexPairs</returns>
        ApiResponse<ApiResponseForexPairs> GetForexPairsWithHttpInfo ();
        /// <summary>
        /// Forex Currency Prices
        /// </summary>
        /// <remarks>
        /// Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseForexPrices</returns>
        ApiResponseForexPrices GetForexPrices (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Forex Currency Prices
        /// </summary>
        /// <remarks>
        /// Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseForexPrices</returns>
        ApiResponse<ApiResponseForexPrices> GetForexPricesWithHttpInfo (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Forex Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of forex currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponseForexCurrencies</returns>
        System.Threading.Tasks.Task<ApiResponseForexCurrencies> GetForexCurrenciesAsync ();

        /// <summary>
        /// Forex Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of forex currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiResponseForexCurrencies)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseForexCurrencies>> GetForexCurrenciesAsyncWithHttpInfo ();
        /// <summary>
        /// Forex Currency Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponseForexPairs</returns>
        System.Threading.Tasks.Task<ApiResponseForexPairs> GetForexPairsAsync ();

        /// <summary>
        /// Forex Currency Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiResponseForexPairs)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseForexPairs>> GetForexPairsAsyncWithHttpInfo ();
        /// <summary>
        /// Forex Currency Prices
        /// </summary>
        /// <remarks>
        /// Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseForexPrices</returns>
        System.Threading.Tasks.Task<ApiResponseForexPrices> GetForexPricesAsync (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Forex Currency Prices
        /// </summary>
        /// <remarks>
        /// Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseForexPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseForexPrices>> GetForexPricesAsyncWithHttpInfo (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ForexApi : IForexApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForexApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ForexApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForexApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ForexApi(Configuration configuration = null)
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

        /// <summary>
        /// Forex Currencies Returns a list of forex currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponseForexCurrencies</returns>
        public ApiResponseForexCurrencies GetForexCurrencies ()
        {
             ApiResponse<ApiResponseForexCurrencies> localVarResponse = GetForexCurrenciesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Forex Currencies Returns a list of forex currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiResponseForexCurrencies</returns>
        
        
        public ApiResponse< ApiResponseForexCurrencies > GetForexCurrenciesWithHttpInfo ()
        {

            var localVarPath = "/forex/currencies";
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

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetForexCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseForexCurrencies>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseForexCurrencies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseForexCurrencies)));
        }

        /// <summary>
        /// Forex Currencies Returns a list of forex currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponseForexCurrencies</returns>
        public async System.Threading.Tasks.Task<ApiResponseForexCurrencies> GetForexCurrenciesAsync ()
        {
             ApiResponse<ApiResponseForexCurrencies> localVarResponse = await GetForexCurrenciesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Forex Currencies Returns a list of forex currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiResponseForexCurrencies)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseForexCurrencies>> GetForexCurrenciesAsyncWithHttpInfo ()
        {

            var localVarPath = "/forex/currencies";
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

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetForexCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseForexCurrencies>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseForexCurrencies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseForexCurrencies)));
        }

        /// <summary>
        /// Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponseForexPairs</returns>
        public ApiResponseForexPairs GetForexPairs ()
        {
             ApiResponse<ApiResponseForexPairs> localVarResponse = GetForexPairsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ApiResponseForexPairs</returns>
        
        
        public ApiResponse< ApiResponseForexPairs > GetForexPairsWithHttpInfo ()
        {

            var localVarPath = "/forex/pairs";
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

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetForexPairs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseForexPairs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseForexPairs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseForexPairs)));
        }

        /// <summary>
        /// Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponseForexPairs</returns>
        public async System.Threading.Tasks.Task<ApiResponseForexPairs> GetForexPairsAsync ()
        {
             ApiResponse<ApiResponseForexPairs> localVarResponse = await GetForexPairsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Forex Currency Pairs Returns a list of currency pairs used to request foreign exchange (forex) market price data. The currency that is used as the reference is called quote currency and the currency that is quoted in relation is called the base currency. For example, in the pair code “EURGBP” with a price of 0.88, one Euro (base currency) can be exchanged for 0.88 British Pounds (quote currency).
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ApiResponseForexPairs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseForexPairs>> GetForexPairsAsyncWithHttpInfo ()
        {

            var localVarPath = "/forex/pairs";
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

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetForexPairs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseForexPairs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseForexPairs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseForexPairs)));
        }

        /// <summary>
        /// Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseForexPrices</returns>
        public ApiResponseForexPrices GetForexPrices (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseForexPrices> localVarResponse = GetForexPricesWithHttpInfo(pair, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseForexPrices</returns>
        
        private static bool validateTimeParam(string time) {
          string validTimePattern = @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$";
      		Regex validTimeRegex = new Regex(validTimePattern);
      		bool invalidTime = !(validTimeRegex.IsMatch(time));
          
          if (invalidTime)
            throw new ArgumentException("Time must be in the format 'hh:mm'");
          else
      		  return true;
        }
        
        public ApiResponse< ApiResponseForexPrices > GetForexPricesWithHttpInfo (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'pair' is set
            if (pair == null)
                throw new ApiException(400, "Missing required parameter 'pair' when calling ForexApi->GetForexPrices");
            // verify the required parameter 'timeframe' is set
            if (timeframe == null)
                throw new ApiException(400, "Missing required parameter 'timeframe' when calling ForexApi->GetForexPrices");

            var localVarPath = "/forex/prices/{pair}/{timeframe}";
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
            
            if (startTime != null && startDate != null) {
              if (validateTimeParam(startTime)) {
                var startTimeSpan = TimeSpan.Parse(startTime);
                startDate = startDate.Value.Add(startTimeSpan);
              }
            }
              
            if (endTime != null && endDate != null) {
              if (validateTimeParam(endTime)) {
                var endTimeSpan = TimeSpan.Parse(endTime);
                endDate = endDate.Value.Add(endTimeSpan);
              }  
            }
            
            if (pair != null) localVarPathParams.Add("pair", Configuration.ApiClient.ParameterToString(pair)); // path parameter
            if (timeframe != null) localVarPathParams.Add("timeframe", Configuration.ApiClient.ParameterToString(timeframe)); // path parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
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
                Exception exception = ExceptionFactory("GetForexPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseForexPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseForexPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseForexPrices)));
        }

        /// <summary>
        /// Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseForexPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseForexPrices> GetForexPricesAsync (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseForexPrices> localVarResponse = await GetForexPricesAsyncWithHttpInfo(pair, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Forex Currency Prices Provides a list of forex price quotes for a given forex currency pair and timeframe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">The Forex Currency Pair code</param>
        /// <param name="timeframe">The time interval for the quotes</param>
        /// <param name="timezone">Returns trading times in this timezone (optional, default to UTC)</param>
        /// <param name="startDate">Return Forex Prices on or after this date (optional)</param>
        /// <param name="startTime">Return Forex Prices at or after this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="endDate">Return Forex Prices on or before this date (optional)</param>
        /// <param name="endTime">Return Forex Prices at or before this time (24-hour in &#39;hh:mm&#39; format, UTC timezone) (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseForexPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseForexPrices>> GetForexPricesAsyncWithHttpInfo (string pair, string timeframe, string timezone = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'pair' is set
            if (pair == null)
                throw new ApiException(400, "Missing required parameter 'pair' when calling ForexApi->GetForexPrices");
            // verify the required parameter 'timeframe' is set
            if (timeframe == null)
                throw new ApiException(400, "Missing required parameter 'timeframe' when calling ForexApi->GetForexPrices");

            var localVarPath = "/forex/prices/{pair}/{timeframe}";
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
              
            if (startTime != null && startDate != null) {
              if (validateTimeParam(startTime)) {
                var startTimeSpan = TimeSpan.Parse(startTime);
                startDate = startDate.Value.Add(startTimeSpan);
              }
            }
              
            if (endTime != null && endDate != null) {
              if (validateTimeParam(endTime)) {
                var endTimeSpan = TimeSpan.Parse(endTime);
                endDate = endDate.Value.Add(endTimeSpan);
              }  
            }

            if (pair != null) localVarPathParams.Add("pair", Configuration.ApiClient.ParameterToString(pair)); // path parameter
            if (timeframe != null) localVarPathParams.Add("timeframe", Configuration.ApiClient.ParameterToString(timeframe)); // path parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
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
                Exception exception = ExceptionFactory("GetForexPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseForexPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseForexPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseForexPrices)));
        }

    }
}

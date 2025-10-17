

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
    public interface IETFsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All ETFs
        /// </summary>
        /// <remarks>
        /// Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseETFs</returns>
        ApiResponseETFs GetAllEtfs (string exchange = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All ETFs
        /// </summary>
        /// <remarks>
        /// Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseETFs</returns>
        ApiResponse<ApiResponseETFs> GetAllEtfsWithHttpInfo (string exchange = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup ETF
        /// </summary>
        /// <remarks>
        /// Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ETF</returns>
        ETF GetEtf (string identifier);

        /// <summary>
        /// Lookup ETF
        /// </summary>
        /// <remarks>
        /// Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ApiResponse of ETF</returns>
        ApiResponse<ETF> GetEtfWithHttpInfo (string identifier);
        /// <summary>
        /// ETF Analytics
        /// </summary>
        /// <remarks>
        /// Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ETFAnalytics</returns>
        ETFAnalytics GetEtfAnalytics (string identifier);

        /// <summary>
        /// ETF Analytics
        /// </summary>
        /// <remarks>
        /// Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ApiResponse of ETFAnalytics</returns>
        ApiResponse<ETFAnalytics> GetEtfAnalyticsWithHttpInfo (string identifier);
        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>ETFHistoricalStats</returns>
        ETFHistoricalStats GetEtfHistoricalStats (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null);

        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>ApiResponse of ETFHistoricalStats</returns>
        ApiResponse<ETFHistoricalStats> GetEtfHistoricalStatsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null);
        /// <summary>
        /// ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseETFHoldings</returns>
        ApiResponseETFHoldings GetEtfHoldings (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseETFHoldings</returns>
        ApiResponse<ApiResponseETFHoldings> GetEtfHoldingsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Exchange Traded Fund (ETF) Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ETFStats</returns>
        ETFStats GetEtfStats (string identifier);

        /// <summary>
        /// Exchange Traded Fund (ETF) Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ApiResponse of ETFStats</returns>
        ApiResponse<ETFStats> GetEtfStatsWithHttpInfo (string identifier);
        /// <summary>
        /// Search ETFs
        /// </summary>
        /// <remarks>
        /// Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>ApiResponseETFs</returns>
        ApiResponseETFs SearchEtfs (string query, string mode = null);

        /// <summary>
        /// Search ETFs
        /// </summary>
        /// <remarks>
        /// Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>ApiResponse of ApiResponseETFs</returns>
        ApiResponse<ApiResponseETFs> SearchEtfsWithHttpInfo (string query, string mode = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All ETFs
        /// </summary>
        /// <remarks>
        /// Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseETFs</returns>
        System.Threading.Tasks.Task<ApiResponseETFs> GetAllEtfsAsync (string exchange = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All ETFs
        /// </summary>
        /// <remarks>
        /// Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseETFs>> GetAllEtfsAsyncWithHttpInfo (string exchange = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup ETF
        /// </summary>
        /// <remarks>
        /// Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ETF</returns>
        System.Threading.Tasks.Task<ETF> GetEtfAsync (string identifier);

        /// <summary>
        /// Lookup ETF
        /// </summary>
        /// <remarks>
        /// Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (ETF)</returns>
        System.Threading.Tasks.Task<ApiResponse<ETF>> GetEtfAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// ETF Analytics
        /// </summary>
        /// <remarks>
        /// Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ETFAnalytics</returns>
        System.Threading.Tasks.Task<ETFAnalytics> GetEtfAnalyticsAsync (string identifier);

        /// <summary>
        /// ETF Analytics
        /// </summary>
        /// <remarks>
        /// Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (ETFAnalytics)</returns>
        System.Threading.Tasks.Task<ApiResponse<ETFAnalytics>> GetEtfAnalyticsAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ETFHistoricalStats</returns>
        System.Threading.Tasks.Task<ETFHistoricalStats> GetEtfHistoricalStatsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null);

        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ETFHistoricalStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<ETFHistoricalStats>> GetEtfHistoricalStatsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null);
        /// <summary>
        /// ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseETFHoldings</returns>
        System.Threading.Tasks.Task<ApiResponseETFHoldings> GetEtfHoldingsAsync (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ETF Holdings
        /// </summary>
        /// <remarks>
        /// Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseETFHoldings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseETFHoldings>> GetEtfHoldingsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Exchange Traded Fund (ETF) Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ETFStats</returns>
        System.Threading.Tasks.Task<ETFStats> GetEtfStatsAsync (string identifier);

        /// <summary>
        /// Exchange Traded Fund (ETF) Stats
        /// </summary>
        /// <remarks>
        /// Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (ETFStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<ETFStats>> GetEtfStatsAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Search ETFs
        /// </summary>
        /// <remarks>
        /// Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>Task of ApiResponseETFs</returns>
        System.Threading.Tasks.Task<ApiResponseETFs> SearchEtfsAsync (string query, string mode = null);

        /// <summary>
        /// Search ETFs
        /// </summary>
        /// <remarks>
        /// Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseETFs>> SearchEtfsAsyncWithHttpInfo (string query, string mode = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ETFsApi : IETFsApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ETFsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ETFsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ETFsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ETFsApi(Configuration configuration = null)
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
        /// All ETFs Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseETFs</returns>
        public ApiResponseETFs GetAllEtfs (string exchange = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseETFs> localVarResponse = GetAllEtfsWithHttpInfo(exchange, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All ETFs Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseETFs</returns>
        
        public ApiResponse< ApiResponseETFs > GetAllEtfsWithHttpInfo (string exchange = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/etfs";
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
            
            
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllEtfs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
        }

        /// <summary>
        /// All ETFs Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseETFs</returns>
        public async System.Threading.Tasks.Task<ApiResponseETFs> GetAllEtfsAsync (string exchange = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseETFs> localVarResponse = await GetAllEtfsAsyncWithHttpInfo(exchange, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All ETFs Returns a list of all currently listed ETFs, with relevant identification information including the ETF Name, Ticker, FIGI Ticker, and Exchange MIC for further usage with our ETF Metadata, Holdings, Stats, and Analytics offerings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseETFs>> GetAllEtfsAsyncWithHttpInfo (string exchange = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/etfs";
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
              

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllEtfs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
        }

        /// <summary>
        /// Lookup ETF Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ETF</returns>
        public ETF GetEtf (string identifier)
        {
             ApiResponse<ETF> localVarResponse = GetEtfWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup ETF Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ApiResponse of ETF</returns>
        
        public ApiResponse< ETF > GetEtfWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtf");

            var localVarPath = "/etfs/{identifier}";
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
                Exception exception = ExceptionFactory("GetEtf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETF>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETF) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETF)));
        }

        /// <summary>
        /// Lookup ETF Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ETF</returns>
        public async System.Threading.Tasks.Task<ETF> GetEtfAsync (string identifier)
        {
             ApiResponse<ETF> localVarResponse = await GetEtfAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup ETF Returns classifications and reference data which consists of ~90 columns that give detailed information about an ETF. These granular details include asset class, expense ratio, index name, index weighting scheme, smart beta type and specific investment objectives.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (ETF)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ETF>> GetEtfAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtf");

            var localVarPath = "/etfs/{identifier}";
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
                Exception exception = ExceptionFactory("GetEtf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETF>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETF) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETF)));
        }

        /// <summary>
        /// ETF Analytics Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ETFAnalytics</returns>
        public ETFAnalytics GetEtfAnalytics (string identifier)
        {
             ApiResponse<ETFAnalytics> localVarResponse = GetEtfAnalyticsWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ETF Analytics Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ApiResponse of ETFAnalytics</returns>
        
        public ApiResponse< ETFAnalytics > GetEtfAnalyticsWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfAnalytics");

            var localVarPath = "/etfs/{identifier}/analytics";
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
                Exception exception = ExceptionFactory("GetEtfAnalytics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETFAnalytics>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETFAnalytics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFAnalytics)));
        }

        /// <summary>
        /// ETF Analytics Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ETFAnalytics</returns>
        public async System.Threading.Tasks.Task<ETFAnalytics> GetEtfAnalyticsAsync (string identifier)
        {
             ApiResponse<ETFAnalytics> localVarResponse = await GetEtfAnalyticsAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ETF Analytics Returns latest market analytics for a specified US ETF, including volume, trailing volume, market cap, 52 week high, and 52 week low.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (ETFAnalytics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ETFAnalytics>> GetEtfAnalyticsAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfAnalytics");

            var localVarPath = "/etfs/{identifier}/analytics";
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
                Exception exception = ExceptionFactory("GetEtfAnalytics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETFAnalytics>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETFAnalytics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFAnalytics)));
        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>ETFHistoricalStats</returns>
        public ETFHistoricalStats GetEtfHistoricalStats (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null)
        {
             ApiResponse<ETFHistoricalStats> localVarResponse = GetEtfHistoricalStatsWithHttpInfo(identifier, startDate, endDate, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>ApiResponse of ETFHistoricalStats</returns>
        
        public ApiResponse< ETFHistoricalStats > GetEtfHistoricalStatsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfHistoricalStats");

            var localVarPath = "/etfs/{identifier}/historical_stats";
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
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
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
                Exception exception = ExceptionFactory("GetEtfHistoricalStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETFHistoricalStats>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETFHistoricalStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFHistoricalStats)));
        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ETFHistoricalStats</returns>
        public async System.Threading.Tasks.Task<ETFHistoricalStats> GetEtfHistoricalStatsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null)
        {
             ApiResponse<ETFHistoricalStats> localVarResponse = await GetEtfHistoricalStatsAsyncWithHttpInfo(identifier, startDate, endDate, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Historical Stats Returns comprehensive key US ETF historical performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="startDate">The start date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="endDate">The end date for the historical stats data in YYYY-MM-DD format. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ETFHistoricalStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ETFHistoricalStats>> GetEtfHistoricalStatsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfHistoricalStats");

            var localVarPath = "/etfs/{identifier}/historical_stats";
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
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
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
                Exception exception = ExceptionFactory("GetEtfHistoricalStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETFHistoricalStats>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETFHistoricalStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFHistoricalStats)));
        }

        /// <summary>
        /// ETF Holdings Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseETFHoldings</returns>
        public ApiResponseETFHoldings GetEtfHoldings (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseETFHoldings> localVarResponse = GetEtfHoldingsWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ETF Holdings Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseETFHoldings</returns>
        
        public ApiResponse< ApiResponseETFHoldings > GetEtfHoldingsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfHoldings");

            var localVarPath = "/etfs/{identifier}/holdings";
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
                Exception exception = ExceptionFactory("GetEtfHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseETFHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFHoldings)));
        }

        /// <summary>
        /// ETF Holdings Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseETFHoldings</returns>
        public async System.Threading.Tasks.Task<ApiResponseETFHoldings> GetEtfHoldingsAsync (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseETFHoldings> localVarResponse = await GetEtfHoldingsAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ETF Holdings Returns holdings data that details all the constituent securities in each ETF with names, identifiers, and the weights for each security providing granular level transparency.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseETFHoldings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseETFHoldings>> GetEtfHoldingsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfHoldings");

            var localVarPath = "/etfs/{identifier}/holdings";
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
                Exception exception = ExceptionFactory("GetEtfHoldings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseETFHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFHoldings)));
        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Stats Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ETFStats</returns>
        public ETFStats GetEtfStats (string identifier)
        {
             ApiResponse<ETFStats> localVarResponse = GetEtfStatsWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Stats Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>ApiResponse of ETFStats</returns>
        
        public ApiResponse< ETFStats > GetEtfStatsWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfStats");

            var localVarPath = "/etfs/{identifier}/stats";
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
                Exception exception = ExceptionFactory("GetEtfStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETFStats>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETFStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFStats)));
        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Stats Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ETFStats</returns>
        public async System.Threading.Tasks.Task<ETFStats> GetEtfStatsAsync (string identifier)
        {
             ApiResponse<ETFStats> localVarResponse = await GetEtfStatsAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exchange Traded Fund (ETF) Stats Returns comprehensive key US ETF performance statistics, including prices, NAVs, flows, returns, and much more for both trailing and calendar year periods.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An ETF identifier (Ticker, Figi Ticker, ISIN, RIC, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (ETFStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ETFStats>> GetEtfStatsAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ETFsApi->GetEtfStats");

            var localVarPath = "/etfs/{identifier}/stats";
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
                Exception exception = ExceptionFactory("GetEtfStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ETFStats>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ETFStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ETFStats)));
        }

        /// <summary>
        /// Search ETFs Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>ApiResponseETFs</returns>
        public ApiResponseETFs SearchEtfs (string query, string mode = null)
        {
             ApiResponse<ApiResponseETFs> localVarResponse = SearchEtfsWithHttpInfo(query, mode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search ETFs Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>ApiResponse of ApiResponseETFs</returns>
        
        public ApiResponse< ApiResponseETFs > SearchEtfsWithHttpInfo (string query, string mode = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling ETFsApi->SearchEtfs");

            var localVarPath = "/etfs/search";
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
            
            
            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (mode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mode", mode)); // query parameter

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
                Exception exception = ExceptionFactory("SearchEtfs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
        }

        /// <summary>
        /// Search ETFs Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>Task of ApiResponseETFs</returns>
        public async System.Threading.Tasks.Task<ApiResponseETFs> SearchEtfsAsync (string query, string mode = null)
        {
             ApiResponse<ApiResponseETFs> localVarResponse = await SearchEtfsAsyncWithHttpInfo(query, mode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search ETFs Accepts a string of keyword combinations, and searches across the ETF name and ticker and returns a list of ETFs with related keywords.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="mode">When set, changes search mode to the specified mode. Paging is not available in rank_order. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseETFs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseETFs>> SearchEtfsAsyncWithHttpInfo (string query, string mode = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling ETFsApi->SearchEtfs");

            var localVarPath = "/etfs/search";
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
              

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter
            if (mode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mode", mode)); // query parameter

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
                Exception exception = ExceptionFactory("SearchEtfs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseETFs>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseETFs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseETFs)));
        }

    }
}

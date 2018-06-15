

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
    public interface IMutualFundApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get All Mutual Funds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;MutualFund&gt;</returns>
        List<MutualFund> GetAllMutualFunds (string nextPage = null);

        /// <summary>
        /// Get All Mutual Funds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;MutualFund&gt;</returns>
        ApiResponse<List<MutualFund>> GetAllMutualFundsWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Mutual Fund by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>MutualFund</returns>
        MutualFund GetMutualFundById (string identifier);

        /// <summary>
        /// Get a Mutual Fund by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of MutualFund</returns>
        ApiResponse<MutualFund> GetMutualFundByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Get Stats for a Mutual Fund
        /// </summary>
        /// <remarks>
        /// Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;MutualFundStat&gt;</returns>
        List<MutualFundStat> GetMutualFundStats (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Get Stats for a Mutual Fund
        /// </summary>
        /// <remarks>
        /// Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;MutualFundStat&gt;</returns>
        ApiResponse<List<MutualFundStat>> GetMutualFundStatsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Search Mutual Funds
        /// </summary>
        /// <remarks>
        /// Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;MutualFund&gt;</returns>
        List<MutualFund> SearchMutualFunds (string query, string nextPage = null);

        /// <summary>
        /// Search Mutual Funds
        /// </summary>
        /// <remarks>
        /// Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;MutualFund&gt;</returns>
        ApiResponse<List<MutualFund>> SearchMutualFundsWithHttpInfo (string query, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get All Mutual Funds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;MutualFund&gt;</returns>
        System.Threading.Tasks.Task<List<MutualFund>> GetAllMutualFundsAsync (string nextPage = null);

        /// <summary>
        /// Get All Mutual Funds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;MutualFund&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MutualFund>>> GetAllMutualFundsAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Mutual Fund by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>Task of MutualFund</returns>
        System.Threading.Tasks.Task<MutualFund> GetMutualFundByIdAsync (string identifier);

        /// <summary>
        /// Get a Mutual Fund by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (MutualFund)</returns>
        System.Threading.Tasks.Task<ApiResponse<MutualFund>> GetMutualFundByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get Stats for a Mutual Fund
        /// </summary>
        /// <remarks>
        /// Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;MutualFundStat&gt;</returns>
        System.Threading.Tasks.Task<List<MutualFundStat>> GetMutualFundStatsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Get Stats for a Mutual Fund
        /// </summary>
        /// <remarks>
        /// Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;MutualFundStat&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MutualFundStat>>> GetMutualFundStatsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Search Mutual Funds
        /// </summary>
        /// <remarks>
        /// Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;MutualFund&gt;</returns>
        System.Threading.Tasks.Task<List<MutualFund>> SearchMutualFundsAsync (string query, string nextPage = null);

        /// <summary>
        /// Search Mutual Funds
        /// </summary>
        /// <remarks>
        /// Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;MutualFund&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<MutualFund>>> SearchMutualFundsAsyncWithHttpInfo (string query, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MutualFundApi : IMutualFundApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MutualFundApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MutualFundApi(Configuration configuration = null)
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
        /// Get All Mutual Funds 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;MutualFund&gt;</returns>
        public List<MutualFund> GetAllMutualFunds (string nextPage = null)
        {
             ApiResponse<List<MutualFund>> localVarResponse = GetAllMutualFundsWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Mutual Funds 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;MutualFund&gt;</returns>
        public ApiResponse< List<MutualFund> > GetAllMutualFundsWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/mutual_funds";
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

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllMutualFunds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MutualFund>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MutualFund>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MutualFund>)));
        }

        /// <summary>
        /// Get All Mutual Funds 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;MutualFund&gt;</returns>
        public async System.Threading.Tasks.Task<List<MutualFund>> GetAllMutualFundsAsync (string nextPage = null)
        {
             ApiResponse<List<MutualFund>> localVarResponse = await GetAllMutualFundsAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Mutual Funds 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;MutualFund&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<MutualFund>>> GetAllMutualFundsAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/mutual_funds";
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

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllMutualFunds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MutualFund>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MutualFund>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MutualFund>)));
        }

        /// <summary>
        /// Get a Mutual Fund by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>MutualFund</returns>
        public MutualFund GetMutualFundById (string identifier)
        {
             ApiResponse<MutualFund> localVarResponse = GetMutualFundByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Mutual Fund by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of MutualFund</returns>
        public ApiResponse< MutualFund > GetMutualFundByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling MutualFundApi->GetMutualFundById");

            var localVarPath = "/mutual_funds/{identifier}";
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
                Exception exception = ExceptionFactory("GetMutualFundById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MutualFund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MutualFund) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MutualFund)));
        }

        /// <summary>
        /// Get a Mutual Fund by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>Task of MutualFund</returns>
        public async System.Threading.Tasks.Task<MutualFund> GetMutualFundByIdAsync (string identifier)
        {
             ApiResponse<MutualFund> localVarResponse = await GetMutualFundByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Mutual Fund by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (MutualFund)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MutualFund>> GetMutualFundByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling MutualFundApi->GetMutualFundById");

            var localVarPath = "/mutual_funds/{identifier}";
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
                Exception exception = ExceptionFactory("GetMutualFundById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MutualFund>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MutualFund) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MutualFund)));
        }

        /// <summary>
        /// Get Stats for a Mutual Fund Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;MutualFundStat&gt;</returns>
        public List<MutualFundStat> GetMutualFundStats (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<List<MutualFundStat>> localVarResponse = GetMutualFundStatsWithHttpInfo(identifier, startDate, endDate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stats for a Mutual Fund Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;MutualFundStat&gt;</returns>
        public ApiResponse< List<MutualFundStat> > GetMutualFundStatsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling MutualFundApi->GetMutualFundStats");

            var localVarPath = "/mutual_funds/{identifier}/stats";
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("GetMutualFundStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MutualFundStat>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MutualFundStat>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MutualFundStat>)));
        }

        /// <summary>
        /// Get Stats for a Mutual Fund Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;MutualFundStat&gt;</returns>
        public async System.Threading.Tasks.Task<List<MutualFundStat>> GetMutualFundStatsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<List<MutualFundStat>> localVarResponse = await GetMutualFundStatsAsyncWithHttpInfo(identifier, startDate, endDate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stats for a Mutual Fund Returns stats for the  Mutual Fund with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Mutual Fund identifier (CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return stats on or after the date (optional)</param>
        /// <param name="endDate">Return stats on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;MutualFundStat&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<MutualFundStat>>> GetMutualFundStatsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling MutualFundApi->GetMutualFundStats");

            var localVarPath = "/mutual_funds/{identifier}/stats";
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("GetMutualFundStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MutualFundStat>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MutualFundStat>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MutualFundStat>)));
        }

        /// <summary>
        /// Search Mutual Funds Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>List&lt;MutualFund&gt;</returns>
        public List<MutualFund> SearchMutualFunds (string query, string nextPage = null)
        {
             ApiResponse<List<MutualFund>> localVarResponse = SearchMutualFundsWithHttpInfo(query, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Mutual Funds Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of List&lt;MutualFund&gt;</returns>
        public ApiResponse< List<MutualFund> > SearchMutualFundsWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling MutualFundApi->SearchMutualFunds");

            var localVarPath = "/mutual_funds/search";
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("SearchMutualFunds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MutualFund>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MutualFund>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MutualFund>)));
        }

        /// <summary>
        /// Search Mutual Funds Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of List&lt;MutualFund&gt;</returns>
        public async System.Threading.Tasks.Task<List<MutualFund>> SearchMutualFundsAsync (string query, string nextPage = null)
        {
             ApiResponse<List<MutualFund>> localVarResponse = await SearchMutualFundsAsyncWithHttpInfo(query, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Mutual Funds Searches for Mutual Funds matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;MutualFund&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<MutualFund>>> SearchMutualFundsAsyncWithHttpInfo (string query, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling MutualFundApi->SearchMutualFunds");

            var localVarPath = "/mutual_funds/search";
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
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("SearchMutualFunds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<MutualFund>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<MutualFund>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<MutualFund>)));
        }

    }
}

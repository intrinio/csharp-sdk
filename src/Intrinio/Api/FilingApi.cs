

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
    public interface IFilingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Filter Filings
        /// </summary>
        /// <remarks>
        /// Returns filings that match the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilings</returns>
        ApiResponseFilings FilterFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Filter Filings
        /// </summary>
        /// <remarks>
        /// Returns filings that match the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilings</returns>
        ApiResponse<ApiResponseFilings> FilterFilingsWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Get All Filings
        /// </summary>
        /// <remarks>
        /// Returns all filings
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilings</returns>
        ApiResponseFilings GetAllFilings (string nextPage = null);

        /// <summary>
        /// Get All Filings
        /// </summary>
        /// <remarks>
        /// Returns all filings
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilings</returns>
        ApiResponse<ApiResponseFilings> GetAllFilingsWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Filing by ID
        /// </summary>
        /// <remarks>
        /// Return the filing with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Filing</returns>
        Filing GetFilingById (string id);

        /// <summary>
        /// Get a Filing by ID
        /// </summary>
        /// <remarks>
        /// Return the filing with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>ApiResponse of Filing</returns>
        ApiResponse<Filing> GetFilingByIdWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Filter Filings
        /// </summary>
        /// <remarks>
        /// Returns filings that match the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilings</returns>
        System.Threading.Tasks.Task<ApiResponseFilings> FilterFilingsAsync (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Filter Filings
        /// </summary>
        /// <remarks>
        /// Returns filings that match the specified filters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseFilings>> FilterFilingsAsyncWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Get All Filings
        /// </summary>
        /// <remarks>
        /// Returns all filings
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilings</returns>
        System.Threading.Tasks.Task<ApiResponseFilings> GetAllFilingsAsync (string nextPage = null);

        /// <summary>
        /// Get All Filings
        /// </summary>
        /// <remarks>
        /// Returns all filings
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseFilings>> GetAllFilingsAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Filing by ID
        /// </summary>
        /// <remarks>
        /// Return the filing with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of Filing</returns>
        System.Threading.Tasks.Task<Filing> GetFilingByIdAsync (string id);

        /// <summary>
        /// Get a Filing by ID
        /// </summary>
        /// <remarks>
        /// Return the filing with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of ApiResponse (Filing)</returns>
        System.Threading.Tasks.Task<ApiResponse<Filing>> GetFilingByIdAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FilingApi : IFilingApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FilingApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FilingApi(Configuration configuration = null)
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
        /// Filter Filings Returns filings that match the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilings</returns>
        public ApiResponseFilings FilterFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseFilings> localVarResponse = FilterFilingsWithHttpInfo(company, reportType, startDate, endDate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Filings Returns filings that match the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilings</returns>
        public ApiResponse< ApiResponseFilings > FilterFilingsWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'company' is set
            if (company == null)
                throw new ApiException(400, "Missing required parameter 'company' when calling FilingApi->FilterFilings");

            var localVarPath = "/filings/filter";
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

            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (reportType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "report_type", reportType)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilings)));
        }

        /// <summary>
        /// Filter Filings Returns filings that match the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseFilings> FilterFilingsAsync (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseFilings> localVarResponse = await FilterFilingsAsyncWithHttpInfo(company, reportType, startDate, endDate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Filings Returns filings that match the specified filters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseFilings>> FilterFilingsAsyncWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'company' is set
            if (company == null)
                throw new ApiException(400, "Missing required parameter 'company' when calling FilingApi->FilterFilings");

            var localVarPath = "/filings/filter";
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

            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (reportType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "report_type", reportType)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FilterFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilings)));
        }

        /// <summary>
        /// Get All Filings Returns all filings
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilings</returns>
        public ApiResponseFilings GetAllFilings (string nextPage = null)
        {
             ApiResponse<ApiResponseFilings> localVarResponse = GetAllFilingsWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Filings Returns all filings
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilings</returns>
        public ApiResponse< ApiResponseFilings > GetAllFilingsWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/filings";
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

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilings)));
        }

        /// <summary>
        /// Get All Filings Returns all filings
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseFilings> GetAllFilingsAsync (string nextPage = null)
        {
             ApiResponse<ApiResponseFilings> localVarResponse = await GetAllFilingsAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Filings Returns all filings
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseFilings>> GetAllFilingsAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/filings";
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

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilings)));
        }

        /// <summary>
        /// Get a Filing by ID Return the filing with the given ID
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Filing</returns>
        public Filing GetFilingById (string id)
        {
             ApiResponse<Filing> localVarResponse = GetFilingByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Filing by ID Return the filing with the given ID
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>ApiResponse of Filing</returns>
        public ApiResponse< Filing > GetFilingByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FilingApi->GetFilingById");

            var localVarPath = "/filings/{id}";
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

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFilingById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Filing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Filing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Filing)));
        }

        /// <summary>
        /// Get a Filing by ID Return the filing with the given ID
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of Filing</returns>
        public async System.Threading.Tasks.Task<Filing> GetFilingByIdAsync (string id)
        {
             ApiResponse<Filing> localVarResponse = await GetFilingByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Filing by ID Return the filing with the given ID
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of ApiResponse (Filing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Filing>> GetFilingByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FilingApi->GetFilingById");

            var localVarPath = "/filings/{id}";
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

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFilingById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Filing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Filing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Filing)));
        }

    }
}

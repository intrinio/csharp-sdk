

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
    public interface IInsiderTransactionFilingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Insider Transactions Filings
        /// </summary>
        /// <remarks>
        /// Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwnerInsiderTransactionFilings</returns>
        ApiResponseOwnerInsiderTransactionFilings GetAllInsiderTransactionFilings (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null);

        /// <summary>
        /// All Insider Transactions Filings
        /// </summary>
        /// <remarks>
        /// Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwnerInsiderTransactionFilings</returns>
        ApiResponse<ApiResponseOwnerInsiderTransactionFilings> GetAllInsiderTransactionFilingsWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Insider Transactions Filings
        /// </summary>
        /// <remarks>
        /// Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwnerInsiderTransactionFilings</returns>
        System.Threading.Tasks.Task<ApiResponseOwnerInsiderTransactionFilings> GetAllInsiderTransactionFilingsAsync (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null);

        /// <summary>
        /// All Insider Transactions Filings
        /// </summary>
        /// <remarks>
        /// Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwnerInsiderTransactionFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOwnerInsiderTransactionFilings>> GetAllInsiderTransactionFilingsAsyncWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InsiderTransactionFilingsApi : IInsiderTransactionFilingsApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InsiderTransactionFilingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InsiderTransactionFilingsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsiderTransactionFilingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InsiderTransactionFilingsApi(Configuration configuration = null)
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
        /// All Insider Transactions Filings Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwnerInsiderTransactionFilings</returns>
        public ApiResponseOwnerInsiderTransactionFilings GetAllInsiderTransactionFilings (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwnerInsiderTransactionFilings> localVarResponse = GetAllInsiderTransactionFilingsWithHttpInfo(startDate, endDate, pageSize, sortBy, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Insider Transactions Filings Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwnerInsiderTransactionFilings</returns>
        
        public ApiResponse< ApiResponseOwnerInsiderTransactionFilings > GetAllInsiderTransactionFilingsWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null)
        {

            var localVarPath = "/insider_transaction_filings";
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
            
            
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_by", sortBy)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllInsiderTransactionFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwnerInsiderTransactionFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwnerInsiderTransactionFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwnerInsiderTransactionFilings)));
        }

        /// <summary>
        /// All Insider Transactions Filings Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwnerInsiderTransactionFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseOwnerInsiderTransactionFilings> GetAllInsiderTransactionFilingsAsync (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwnerInsiderTransactionFilings> localVarResponse = await GetAllInsiderTransactionFilingsAsyncWithHttpInfo(startDate, endDate, pageSize, sortBy, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Insider Transactions Filings Returns all insider transactions filings fitting the optional supplied start and end date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;.  Valid values are - &#39;filing_date&#39;, &#39;updated_on&#39;. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwnerInsiderTransactionFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOwnerInsiderTransactionFilings>> GetAllInsiderTransactionFilingsAsyncWithHttpInfo (DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string sortBy = null, string nextPage = null)
        {

            var localVarPath = "/insider_transaction_filings";
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
              

            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_by", sortBy)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllInsiderTransactionFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwnerInsiderTransactionFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwnerInsiderTransactionFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwnerInsiderTransactionFilings)));
        }

    }
}

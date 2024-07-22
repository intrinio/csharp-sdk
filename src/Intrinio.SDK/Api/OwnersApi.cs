

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
    public interface IOwnersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Owners
        /// </summary>
        /// <remarks>
        /// Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwners</returns>
        ApiResponseOwners GetAllOwners (bool? institutional = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Owners
        /// </summary>
        /// <remarks>
        /// Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwners</returns>
        ApiResponse<ApiResponseOwners> GetAllOwnersWithHttpInfo (bool? institutional = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Owner by ID
        /// </summary>
        /// <remarks>
        /// Returns the Owner with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>Owner</returns>
        Owner GetOwnerById (string identifier);

        /// <summary>
        /// Owner by ID
        /// </summary>
        /// <remarks>
        /// Returns the Owner with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>ApiResponse of Owner</returns>
        ApiResponse<Owner> GetOwnerByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Insider Transaction Filings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwnerInsiderTransactionFilings</returns>
        ApiResponseOwnerInsiderTransactionFilings InsiderTransactionFilingsByOwner (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Insider Transaction Filings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwnerInsiderTransactionFilings</returns>
        ApiResponse<ApiResponseOwnerInsiderTransactionFilings> InsiderTransactionFilingsByOwnerWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Institutional Holdings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwnerInstitutionalHoldings</returns>
        ApiResponseOwnerInstitutionalHoldings InstitutionalHoldingsByOwner (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null);

        /// <summary>
        /// Institutional Holdings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwnerInstitutionalHoldings</returns>
        ApiResponse<ApiResponseOwnerInstitutionalHoldings> InstitutionalHoldingsByOwnerWithHttpInfo (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null);
        /// <summary>
        /// Search Owners
        /// </summary>
        /// <remarks>
        /// Searches for Owners matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwners</returns>
        ApiResponseOwners SearchOwners (string query, bool? institutional = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Search Owners
        /// </summary>
        /// <remarks>
        /// Searches for Owners matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwners</returns>
        ApiResponse<ApiResponseOwners> SearchOwnersWithHttpInfo (string query, bool? institutional = null, int? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Owners
        /// </summary>
        /// <remarks>
        /// Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwners</returns>
        System.Threading.Tasks.Task<ApiResponseOwners> GetAllOwnersAsync (bool? institutional = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Owners
        /// </summary>
        /// <remarks>
        /// Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwners)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOwners>> GetAllOwnersAsyncWithHttpInfo (bool? institutional = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Owner by ID
        /// </summary>
        /// <remarks>
        /// Returns the Owner with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>Task of Owner</returns>
        System.Threading.Tasks.Task<Owner> GetOwnerByIdAsync (string identifier);

        /// <summary>
        /// Owner by ID
        /// </summary>
        /// <remarks>
        /// Returns the Owner with the given ID
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>Task of ApiResponse (Owner)</returns>
        System.Threading.Tasks.Task<ApiResponse<Owner>> GetOwnerByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Insider Transaction Filings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwnerInsiderTransactionFilings</returns>
        System.Threading.Tasks.Task<ApiResponseOwnerInsiderTransactionFilings> InsiderTransactionFilingsByOwnerAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Insider Transaction Filings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwnerInsiderTransactionFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOwnerInsiderTransactionFilings>> InsiderTransactionFilingsByOwnerAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Institutional Holdings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwnerInstitutionalHoldings</returns>
        System.Threading.Tasks.Task<ApiResponseOwnerInstitutionalHoldings> InstitutionalHoldingsByOwnerAsync (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null);

        /// <summary>
        /// Institutional Holdings by Owner
        /// </summary>
        /// <remarks>
        /// Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwnerInstitutionalHoldings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOwnerInstitutionalHoldings>> InstitutionalHoldingsByOwnerAsyncWithHttpInfo (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null);
        /// <summary>
        /// Search Owners
        /// </summary>
        /// <remarks>
        /// Searches for Owners matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwners</returns>
        System.Threading.Tasks.Task<ApiResponseOwners> SearchOwnersAsync (string query, bool? institutional = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Search Owners
        /// </summary>
        /// <remarks>
        /// Searches for Owners matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwners)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOwners>> SearchOwnersAsyncWithHttpInfo (string query, bool? institutional = null, int? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OwnersApi : IOwnersApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OwnersApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OwnersApi(Configuration configuration = null)
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
        /// All Owners Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwners</returns>
        public ApiResponseOwners GetAllOwners (bool? institutional = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwners> localVarResponse = GetAllOwnersWithHttpInfo(institutional, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Owners Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwners</returns>
        
        
        public ApiResponse< ApiResponseOwners > GetAllOwnersWithHttpInfo (bool? institutional = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/owners";
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
            
            
            if (institutional != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "institutional", institutional)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllOwners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwners>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwners) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwners)));
        }

        /// <summary>
        /// All Owners Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwners</returns>
        public async System.Threading.Tasks.Task<ApiResponseOwners> GetAllOwnersAsync (bool? institutional = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwners> localVarResponse = await GetAllOwnersAsyncWithHttpInfo(institutional, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Owners Returns all owners and information for all insider and institutional owners of securities covered by Intrinio.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwners)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOwners>> GetAllOwnersAsyncWithHttpInfo (bool? institutional = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/owners";
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
              

            if (institutional != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "institutional", institutional)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllOwners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwners>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwners) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwners)));
        }

        /// <summary>
        /// Owner by ID Returns the Owner with the given ID
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>Owner</returns>
        public Owner GetOwnerById (string identifier)
        {
             ApiResponse<Owner> localVarResponse = GetOwnerByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Owner by ID Returns the Owner with the given ID
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>ApiResponse of Owner</returns>
        
        
        public ApiResponse< Owner > GetOwnerByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OwnersApi->GetOwnerById");

            var localVarPath = "/owners/{identifier}";
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
                Exception exception = ExceptionFactory("GetOwnerById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Owner>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Owner) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Owner)));
        }

        /// <summary>
        /// Owner by ID Returns the Owner with the given ID
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>Task of Owner</returns>
        public async System.Threading.Tasks.Task<Owner> GetOwnerByIdAsync (string identifier)
        {
             ApiResponse<Owner> localVarResponse = await GetOwnerByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Owner by ID Returns the Owner with the given ID
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An Intrinio ID or CIK of an Owner</param>
        /// <returns>Task of ApiResponse (Owner)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Owner>> GetOwnerByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OwnersApi->GetOwnerById");

            var localVarPath = "/owners/{identifier}";
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
                Exception exception = ExceptionFactory("GetOwnerById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Owner>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Owner) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Owner)));
        }

        /// <summary>
        /// Insider Transaction Filings by Owner Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwnerInsiderTransactionFilings</returns>
        public ApiResponseOwnerInsiderTransactionFilings InsiderTransactionFilingsByOwner (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwnerInsiderTransactionFilings> localVarResponse = InsiderTransactionFilingsByOwnerWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insider Transaction Filings by Owner Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwnerInsiderTransactionFilings</returns>
        
        
        public ApiResponse< ApiResponseOwnerInsiderTransactionFilings > InsiderTransactionFilingsByOwnerWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OwnersApi->InsiderTransactionFilingsByOwner");

            var localVarPath = "/owners/{identifier}/insider_transaction_filings";
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
                Exception exception = ExceptionFactory("InsiderTransactionFilingsByOwner", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwnerInsiderTransactionFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwnerInsiderTransactionFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwnerInsiderTransactionFilings)));
        }

        /// <summary>
        /// Insider Transaction Filings by Owner Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwnerInsiderTransactionFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseOwnerInsiderTransactionFilings> InsiderTransactionFilingsByOwnerAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwnerInsiderTransactionFilings> localVarResponse = await InsiderTransactionFilingsByOwnerAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insider Transaction Filings by Owner Returns a list of all insider transaction filings by an owner in as many companies as the owner may be considered an insider. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="startDate">Return Owner&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Owner&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwnerInsiderTransactionFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOwnerInsiderTransactionFilings>> InsiderTransactionFilingsByOwnerAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OwnersApi->InsiderTransactionFilingsByOwner");

            var localVarPath = "/owners/{identifier}/insider_transaction_filings";
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
                Exception exception = ExceptionFactory("InsiderTransactionFilingsByOwner", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwnerInsiderTransactionFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwnerInsiderTransactionFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwnerInsiderTransactionFilings)));
        }

        /// <summary>
        /// Institutional Holdings by Owner Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwnerInstitutionalHoldings</returns>
        public ApiResponseOwnerInstitutionalHoldings InstitutionalHoldingsByOwner (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwnerInstitutionalHoldings> localVarResponse = InstitutionalHoldingsByOwnerWithHttpInfo(identifier, pageSize, asOfDate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Institutional Holdings by Owner Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwnerInstitutionalHoldings</returns>
        
        
        public ApiResponse< ApiResponseOwnerInstitutionalHoldings > InstitutionalHoldingsByOwnerWithHttpInfo (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OwnersApi->InstitutionalHoldingsByOwner");

            var localVarPath = "/owners/{identifier}/institutional_holdings";
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
            if (asOfDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "as_of_date", asOfDate)); // query parameter
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
                Exception exception = ExceptionFactory("InstitutionalHoldingsByOwner", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwnerInstitutionalHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwnerInstitutionalHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwnerInstitutionalHoldings)));
        }

        /// <summary>
        /// Institutional Holdings by Owner Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwnerInstitutionalHoldings</returns>
        public async System.Threading.Tasks.Task<ApiResponseOwnerInstitutionalHoldings> InstitutionalHoldingsByOwnerAsync (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwnerInstitutionalHoldings> localVarResponse = await InstitutionalHoldingsByOwnerAsyncWithHttpInfo(identifier, pageSize, asOfDate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Institutional Holdings by Owner Returns a list of all ownership interests and the value of their interests by a single institutional owner.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Central Index Key issued by the SEC, which is the unique identifier all owner filings are issued under.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="asOfDate">Return only holdings filed before this date. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwnerInstitutionalHoldings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOwnerInstitutionalHoldings>> InstitutionalHoldingsByOwnerAsyncWithHttpInfo (string identifier, int? pageSize = null, DateTime? asOfDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OwnersApi->InstitutionalHoldingsByOwner");

            var localVarPath = "/owners/{identifier}/institutional_holdings";
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
            if (asOfDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "as_of_date", asOfDate)); // query parameter
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
                Exception exception = ExceptionFactory("InstitutionalHoldingsByOwner", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwnerInstitutionalHoldings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwnerInstitutionalHoldings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwnerInstitutionalHoldings)));
        }

        /// <summary>
        /// Search Owners Searches for Owners matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOwners</returns>
        public ApiResponseOwners SearchOwners (string query, bool? institutional = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwners> localVarResponse = SearchOwnersWithHttpInfo(query, institutional, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Owners Searches for Owners matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOwners</returns>
        
        
        public ApiResponse< ApiResponseOwners > SearchOwnersWithHttpInfo (string query, bool? institutional = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling OwnersApi->SearchOwners");

            var localVarPath = "/owners/search";
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
            if (institutional != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "institutional", institutional)); // query parameter
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
                Exception exception = ExceptionFactory("SearchOwners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwners>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwners) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwners)));
        }

        /// <summary>
        /// Search Owners Searches for Owners matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOwners</returns>
        public async System.Threading.Tasks.Task<ApiResponseOwners> SearchOwnersAsync (string query, bool? institutional = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOwners> localVarResponse = await SearchOwnersAsyncWithHttpInfo(query, institutional, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Owners Searches for Owners matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="institutional">Returns insider owners who have filed forms 3, 4, or 5 with the SEC only. Possible values are true, false, or omit for both. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOwners)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOwners>> SearchOwnersAsyncWithHttpInfo (string query, bool? institutional = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling OwnersApi->SearchOwners");

            var localVarPath = "/owners/search";
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
            if (institutional != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "institutional", institutional)); // query parameter
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
                Exception exception = ExceptionFactory("SearchOwners", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOwners>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOwners) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOwners)));
        }

    }
}



using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Intrinio.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataTagApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Filter Data Tags
        /// </summary>
        /// <remarks>
        /// Returns Data Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseDataTags</returns>
        ApiResponseDataTags FilterDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);

        /// <summary>
        /// Filter Data Tags
        /// </summary>
        /// <remarks>
        /// Returns Data Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        ApiResponse<ApiResponseDataTags> FilterDataTagsWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);
        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns All Data Tags
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseDataTags</returns>
        ApiResponseDataTags GetAllDataTags (string nextPage = null);

        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns All Data Tags
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        ApiResponse<ApiResponseDataTags> GetAllDataTagsWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Lookup Data Tag
        /// </summary>
        /// <remarks>
        /// Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>DataTag</returns>
        DataTag GetDataTagById (string identifier);

        /// <summary>
        /// Lookup Data Tag
        /// </summary>
        /// <remarks>
        /// Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>ApiResponse of DataTag</returns>
        ApiResponse<DataTag> GetDataTagByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Search Data Tags
        /// </summary>
        /// <remarks>
        /// Searches for Data Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponseDataTags</returns>
        ApiResponseDataTags SearchDataTags (string query);

        /// <summary>
        /// Search Data Tags
        /// </summary>
        /// <remarks>
        /// Searches for Data Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        ApiResponse<ApiResponseDataTags> SearchDataTagsWithHttpInfo (string query);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Filter Data Tags
        /// </summary>
        /// <remarks>
        /// Returns Data Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseDataTags</returns>
        System.Threading.Tasks.Task<ApiResponseDataTags> FilterDataTagsAsync (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);

        /// <summary>
        /// Filter Data Tags
        /// </summary>
        /// <remarks>
        /// Returns Data Tags that match the given filters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> FilterDataTagsAsyncWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null);
        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns All Data Tags
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseDataTags</returns>
        System.Threading.Tasks.Task<ApiResponseDataTags> GetAllDataTagsAsync (string nextPage = null);

        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns All Data Tags
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> GetAllDataTagsAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Lookup Data Tag
        /// </summary>
        /// <remarks>
        /// Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>Task of DataTag</returns>
        System.Threading.Tasks.Task<DataTag> GetDataTagByIdAsync (string identifier);

        /// <summary>
        /// Lookup Data Tag
        /// </summary>
        /// <remarks>
        /// Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>Task of ApiResponse (DataTag)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataTag>> GetDataTagByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Search Data Tags
        /// </summary>
        /// <remarks>
        /// Searches for Data Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponseDataTags</returns>
        System.Threading.Tasks.Task<ApiResponseDataTags> SearchDataTagsAsync (string query);

        /// <summary>
        /// Search Data Tags
        /// </summary>
        /// <remarks>
        /// Searches for Data Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> SearchDataTagsAsyncWithHttpInfo (string query);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataTagApi : IDataTagApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTagApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataTagApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTagApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataTagApi(Configuration configuration = null)
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
        /// Filter Data Tags Returns Data Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseDataTags</returns>
        public ApiResponseDataTags FilterDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = FilterDataTagsWithHttpInfo(tag, type, parent, statementCode, fsTemplate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Data Tags Returns Data Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        public ApiResponse< ApiResponseDataTags > FilterDataTagsWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {

            var localVarPath = "/data_tags/filter";
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

            if (tag != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (parent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent", parent)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (fsTemplate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fs_template", fsTemplate)); // query parameter
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
                Exception exception = ExceptionFactory("FilterDataTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseDataTags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTags)));
        }

        /// <summary>
        /// Filter Data Tags Returns Data Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseDataTags</returns>
        public async System.Threading.Tasks.Task<ApiResponseDataTags> FilterDataTagsAsync (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = await FilterDataTagsAsyncWithHttpInfo(tag, type, parent, statementCode, fsTemplate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Data Tags Returns Data Tags that match the given filters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> FilterDataTagsAsyncWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, string nextPage = null)
        {

            var localVarPath = "/data_tags/filter";
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

            if (tag != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (parent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent", parent)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (fsTemplate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fs_template", fsTemplate)); // query parameter
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
                Exception exception = ExceptionFactory("FilterDataTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseDataTags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTags)));
        }

        /// <summary>
        /// All Data Tags Returns All Data Tags
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseDataTags</returns>
        public ApiResponseDataTags GetAllDataTags (string nextPage = null)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = GetAllDataTagsWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Data Tags Returns All Data Tags
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        public ApiResponse< ApiResponseDataTags > GetAllDataTagsWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/data_tags";
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
                Exception exception = ExceptionFactory("GetAllDataTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseDataTags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTags)));
        }

        /// <summary>
        /// All Data Tags Returns All Data Tags
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseDataTags</returns>
        public async System.Threading.Tasks.Task<ApiResponseDataTags> GetAllDataTagsAsync (string nextPage = null)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = await GetAllDataTagsAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Data Tags Returns All Data Tags
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> GetAllDataTagsAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/data_tags";
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
                Exception exception = ExceptionFactory("GetAllDataTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseDataTags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTags)));
        }

        /// <summary>
        /// Lookup Data Tag Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>DataTag</returns>
        public DataTag GetDataTagById (string identifier)
        {
             ApiResponse<DataTag> localVarResponse = GetDataTagByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Data Tag Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>ApiResponse of DataTag</returns>
        public ApiResponse< DataTag > GetDataTagByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataTagApi->GetDataTagById");

            var localVarPath = "/data_tags/{identifier}";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDataTagById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataTag)));
        }

        /// <summary>
        /// Lookup Data Tag Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>Task of DataTag</returns>
        public async System.Threading.Tasks.Task<DataTag> GetDataTagByIdAsync (string identifier)
        {
             ApiResponse<DataTag> localVarResponse = await GetDataTagByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Data Tag Returns the Data Tag with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or the code-name of the Data Tag</param>
        /// <returns>Task of ApiResponse (DataTag)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataTag>> GetDataTagByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataTagApi->GetDataTagById");

            var localVarPath = "/data_tags/{identifier}";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDataTagById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataTag>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataTag) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataTag)));
        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponseDataTags</returns>
        public ApiResponseDataTags SearchDataTags (string query)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = SearchDataTagsWithHttpInfo(query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        public ApiResponse< ApiResponseDataTags > SearchDataTagsWithHttpInfo (string query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling DataTagApi->SearchDataTags");

            var localVarPath = "/data_tags/search";
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
                Exception exception = ExceptionFactory("SearchDataTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseDataTags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTags)));
        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponseDataTags</returns>
        public async System.Threading.Tasks.Task<ApiResponseDataTags> SearchDataTagsAsync (string query)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = await SearchDataTagsAsyncWithHttpInfo(query);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> SearchDataTagsAsyncWithHttpInfo (string query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling DataTagApi->SearchDataTags");

            var localVarPath = "/data_tags/search";
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
                Exception exception = ExceptionFactory("SearchDataTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseDataTags>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTags) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTags)));
        }

    }
}

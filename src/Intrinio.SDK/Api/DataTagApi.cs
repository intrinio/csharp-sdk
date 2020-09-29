

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
    public interface IDataTagApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseDataTags</returns>
        ApiResponseDataTags GetAllDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        ApiResponse<ApiResponseDataTags> GetAllDataTagsWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null);
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
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseDataTagsSearch</returns>
        ApiResponseDataTagsSearch SearchDataTags (string query, int? pageSize = null);

        /// <summary>
        /// Search Data Tags
        /// </summary>
        /// <remarks>
        /// Searches for Data Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseDataTagsSearch</returns>
        ApiResponse<ApiResponseDataTagsSearch> SearchDataTagsWithHttpInfo (string query, int? pageSize = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseDataTags</returns>
        System.Threading.Tasks.Task<ApiResponseDataTags> GetAllDataTagsAsync (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Data Tags
        /// </summary>
        /// <remarks>
        /// Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> GetAllDataTagsAsyncWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null);
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
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseDataTagsSearch</returns>
        System.Threading.Tasks.Task<ApiResponseDataTagsSearch> SearchDataTagsAsync (string query, int? pageSize = null);

        /// <summary>
        /// Search Data Tags
        /// </summary>
        /// <remarks>
        /// Searches for Data Tags matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTagsSearch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTagsSearch>> SearchDataTagsAsyncWithHttpInfo (string query, int? pageSize = null);
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
        /// All Data Tags Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseDataTags</returns>
        public ApiResponseDataTags GetAllDataTags (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = GetAllDataTagsWithHttpInfo(tag, type, parent, statementCode, fsTemplate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Data Tags Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseDataTags</returns>
        
        
        public ApiResponse< ApiResponseDataTags > GetAllDataTagsWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null)
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
            
            
            if (tag != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (parent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent", parent)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (fsTemplate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fs_template", fsTemplate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
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
        /// All Data Tags Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseDataTags</returns>
        public async System.Threading.Tasks.Task<ApiResponseDataTags> GetAllDataTagsAsync (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseDataTags> localVarResponse = await GetAllDataTagsAsyncWithHttpInfo(tag, type, parent, statementCode, fsTemplate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Data Tags Returns all Data Tags. Returns Data Tags matching parameters when specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Tag (optional)</param>
        /// <param name="type">Type (optional)</param>
        /// <param name="parent">ID of tag parent (optional)</param>
        /// <param name="statementCode">Statement Code (optional)</param>
        /// <param name="fsTemplate">Template (optional, default to industrial)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTags)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTags>> GetAllDataTagsAsyncWithHttpInfo (string tag = null, string type = null, string parent = null, string statementCode = null, string fsTemplate = null, int? pageSize = null, string nextPage = null)
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
              

            if (tag != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "tag", tag)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (parent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "parent", parent)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (fsTemplate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fs_template", fsTemplate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
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
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseDataTagsSearch</returns>
        public ApiResponseDataTagsSearch SearchDataTags (string query, int? pageSize = null)
        {
             ApiResponse<ApiResponseDataTagsSearch> localVarResponse = SearchDataTagsWithHttpInfo(query, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseDataTagsSearch</returns>
        
        
        public ApiResponse< ApiResponseDataTagsSearch > SearchDataTagsWithHttpInfo (string query, int? pageSize = null)
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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

            return new ApiResponse<ApiResponseDataTagsSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTagsSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTagsSearch)));
        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseDataTagsSearch</returns>
        public async System.Threading.Tasks.Task<ApiResponseDataTagsSearch> SearchDataTagsAsync (string query, int? pageSize = null)
        {
             ApiResponse<ApiResponseDataTagsSearch> localVarResponse = await SearchDataTagsAsyncWithHttpInfo(query, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Data Tags Searches for Data Tags matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseDataTagsSearch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseDataTagsSearch>> SearchDataTagsAsyncWithHttpInfo (string query, int? pageSize = null)
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter

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

            return new ApiResponse<ApiResponseDataTagsSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseDataTagsSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseDataTagsSearch)));
        }

    }
}



using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataPointApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>decimal?</returns>
        decimal? GetDataPointNumber (string identifier, string tag);

        /// <summary>
        /// Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of decimal?</returns>
        ApiResponse<decimal?> GetDataPointNumberWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>string</returns>
        string GetDataPointText (string identifier, string tag);

        /// <summary>
        /// Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetDataPointTextWithHttpInfo (string identifier, string tag);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of decimal?</returns>
        System.Threading.Tasks.Task<decimal?> GetDataPointNumberAsync (string identifier, string tag);

        /// <summary>
        /// Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (decimal?)</returns>
        System.Threading.Tasks.Task<ApiResponse<decimal?>> GetDataPointNumberAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetDataPointTextAsync (string identifier, string tag);

        /// <summary>
        /// Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetDataPointTextAsyncWithHttpInfo (string identifier, string tag);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataPointApi : IDataPointApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataPointApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataPointApi(Configuration configuration = null)
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
        /// Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>decimal?</returns>
        public decimal? GetDataPointNumber (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = GetDataPointNumberWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of decimal?</returns>
        
        
        public ApiResponse< decimal? > GetDataPointNumberWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling DataPointApi->GetDataPointNumber");

            var localVarPath = "/data_point/{identifier}/{tag}/number";
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
                "text/plain; charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of decimal?</returns>
        public async System.Threading.Tasks.Task<decimal?> GetDataPointNumberAsync (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = await GetDataPointNumberAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; and the entity with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (decimal?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<decimal?>> GetDataPointNumberAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling DataPointApi->GetDataPointNumber");

            var localVarPath = "/data_point/{identifier}/{tag}/number";
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
                "text/plain; charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>string</returns>
        public string GetDataPointText (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = GetDataPointTextWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of string</returns>
        
        
        public ApiResponse< string > GetDataPointTextWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling DataPointApi->GetDataPointText");

            var localVarPath = "/data_point/{identifier}/{tag}/text";
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
                "text/plain; charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            
            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetDataPointTextAsync (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = await GetDataPointTextAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN, CUSIP, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetDataPointTextAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling DataPointApi->GetDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling DataPointApi->GetDataPointText");

            var localVarPath = "/data_point/{identifier}/{tag}/text";
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
                "text/plain; charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
              

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}

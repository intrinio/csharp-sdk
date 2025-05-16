

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
    public interface IIndicesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Index Intervals
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>ApiResponseIndexIntervals</returns>
        ApiResponseIndexIntervals GetIndexIntervals (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null);

        /// <summary>
        /// Index Intervals
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseIndexIntervals</returns>
        ApiResponse<ApiResponseIndexIntervals> GetIndexIntervalsWithHttpInfo (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Index Intervals
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ApiResponseIndexIntervals</returns>
        System.Threading.Tasks.Task<ApiResponseIndexIntervals> GetIndexIntervalsAsync (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null);

        /// <summary>
        /// Index Intervals
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseIndexIntervals)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseIndexIntervals>> GetIndexIntervalsAsyncWithHttpInfo (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IndicesApi : IIndicesApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IndicesApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IndicesApi(Configuration configuration = null)
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
        /// Index Intervals Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>ApiResponseIndexIntervals</returns>
        public ApiResponseIndexIntervals GetIndexIntervals (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseIndexIntervals> localVarResponse = GetIndexIntervalsWithHttpInfo(identifier, intervalSize, startDate, startTime, endDate, endTime, timezone, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Index Intervals Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseIndexIntervals</returns>
        
        public ApiResponse< ApiResponseIndexIntervals > GetIndexIntervalsWithHttpInfo (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndicesApi->GetIndexIntervals");
            // verify the required parameter 'intervalSize' is set
            if (intervalSize == null)
                throw new ApiException(400, "Missing required parameter 'intervalSize' when calling IndicesApi->GetIndexIntervals");

            var localVarPath = "/indices/{identifier}/intervals";
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
            if (intervalSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval_size", intervalSize)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
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
                Exception exception = ExceptionFactory("GetIndexIntervals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseIndexIntervals>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseIndexIntervals) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseIndexIntervals)));
        }

        /// <summary>
        /// Index Intervals Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ApiResponseIndexIntervals</returns>
        public async System.Threading.Tasks.Task<ApiResponseIndexIntervals> GetIndexIntervalsAsync (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseIndexIntervals> localVarResponse = await GetIndexIntervalsAsyncWithHttpInfo(identifier, intervalSize, startDate, startTime, endDate, endTime, timezone, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Index Intervals Returns a list of interval data points for a specified index, including open, close, high, low, volume, and average price. Intervals are available in 60-minute, 30-minute, 15-minute, 10-minute, 5-minute, and 1-minute increments.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The index identifier</param>
        /// <param name="intervalSize">The interval size to return in minutes (m) or hour (h).</param>
        /// <param name="startDate">Return intervals starting at the specified date (optional)</param>
        /// <param name="startTime">Return intervals starting at the specified time on the &#x60;start_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="endDate">Return intervals stopping at the specified date (optional)</param>
        /// <param name="endTime">Return intervals stopping at the specified time on the &#x60;end_date&#x60; (24-hour in &#39;hh:mm:ss&#39; format) (optional)</param>
        /// <param name="timezone">Interprets the input times in this time zone, as well as returns times in this timezone. (optional, default to UTC)</param>
        /// <param name="pageSize">The number of results to return per page. (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseIndexIntervals)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseIndexIntervals>> GetIndexIntervalsAsyncWithHttpInfo (string identifier, string intervalSize, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling IndicesApi->GetIndexIntervals");
            // verify the required parameter 'intervalSize' is set
            if (intervalSize == null)
                throw new ApiException(400, "Missing required parameter 'intervalSize' when calling IndicesApi->GetIndexIntervals");

            var localVarPath = "/indices/{identifier}/intervals";
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
            if (intervalSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "interval_size", intervalSize)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
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
                Exception exception = ExceptionFactory("GetIndexIntervals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseIndexIntervals>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseIndexIntervals) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseIndexIntervals)));
        }

    }
}

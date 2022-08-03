

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
    public interface IESGApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ESG Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGCompanies</returns>
        ApiResponseESGCompanies GetEsgCompanies (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGCompanies</returns>
        ApiResponse<ApiResponseESGCompanies> GetEsgCompaniesWithHttpInfo (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Company Comprehensive Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGCompanyComprehensiveRatingHistory</returns>
        ApiResponseESGCompanyComprehensiveRatingHistory GetEsgCompanyComprehensiveRatings (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Company Comprehensive Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGCompanyComprehensiveRatingHistory</returns>
        ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory> GetEsgCompanyComprehensiveRatingsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Company Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGCompanyRatingHistory</returns>
        ApiResponseESGCompanyRatingHistory GetEsgCompanyRatings (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Company Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGCompanyRatingHistory</returns>
        ApiResponse<ApiResponseESGCompanyRatingHistory> GetEsgCompanyRatingsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Latest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGLatest</returns>
        ApiResponseESGLatest GetEsgLatest (string country = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Latest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGLatest</returns>
        ApiResponse<ApiResponseESGLatest> GetEsgLatestWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Latest Comprehensive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGLatestComprehensive</returns>
        ApiResponseESGLatestComprehensive GetEsgLatestComprehensive (string country = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Latest Comprehensive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGLatestComprehensive</returns>
        ApiResponse<ApiResponseESGLatestComprehensive> GetEsgLatestComprehensiveWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// ESG Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGCompanies</returns>
        System.Threading.Tasks.Task<ApiResponseESGCompanies> GetEsgCompaniesAsync (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Companies
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGCompanies)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseESGCompanies>> GetEsgCompaniesAsyncWithHttpInfo (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Company Comprehensive Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGCompanyComprehensiveRatingHistory</returns>
        System.Threading.Tasks.Task<ApiResponseESGCompanyComprehensiveRatingHistory> GetEsgCompanyComprehensiveRatingsAsync (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Company Comprehensive Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGCompanyComprehensiveRatingHistory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory>> GetEsgCompanyComprehensiveRatingsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Company Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGCompanyRatingHistory</returns>
        System.Threading.Tasks.Task<ApiResponseESGCompanyRatingHistory> GetEsgCompanyRatingsAsync (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Company Ratings History
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGCompanyRatingHistory)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseESGCompanyRatingHistory>> GetEsgCompanyRatingsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Latest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGLatest</returns>
        System.Threading.Tasks.Task<ApiResponseESGLatest> GetEsgLatestAsync (string country = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Latest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGLatest)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseESGLatest>> GetEsgLatestAsyncWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// ESG Latest Comprehensive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGLatestComprehensive</returns>
        System.Threading.Tasks.Task<ApiResponseESGLatestComprehensive> GetEsgLatestComprehensiveAsync (string country = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// ESG Latest Comprehensive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGLatestComprehensive)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseESGLatestComprehensive>> GetEsgLatestComprehensiveAsyncWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ESGApi : IESGApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ESGApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ESGApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ESGApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ESGApi(Configuration configuration = null)
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
        /// ESG Companies 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGCompanies</returns>
        public ApiResponseESGCompanies GetEsgCompanies (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGCompanies> localVarResponse = GetEsgCompaniesWithHttpInfo(country, industry, ticker, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ESG Companies 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGCompanies</returns>
        
        
        public ApiResponse< ApiResponseESGCompanies > GetEsgCompaniesWithHttpInfo (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/esg/companies";
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
            
            
            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
            if (industry != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry", industry)); // query parameter
            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
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
                Exception exception = ExceptionFactory("GetEsgCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGCompanies>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGCompanies)));
        }

        /// <summary>
        /// ESG Companies 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGCompanies</returns>
        public async System.Threading.Tasks.Task<ApiResponseESGCompanies> GetEsgCompaniesAsync (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGCompanies> localVarResponse = await GetEsgCompaniesAsyncWithHttpInfo(country, industry, ticker, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ESG Companies 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="industry"> (optional)</param>
        /// <param name="ticker"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGCompanies)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseESGCompanies>> GetEsgCompaniesAsyncWithHttpInfo (string country = null, string industry = null, string ticker = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/esg/companies";
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
              

            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
            if (industry != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry", industry)); // query parameter
            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
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
                Exception exception = ExceptionFactory("GetEsgCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGCompanies>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGCompanies)));
        }

        /// <summary>
        /// ESG Company Comprehensive Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGCompanyComprehensiveRatingHistory</returns>
        public ApiResponseESGCompanyComprehensiveRatingHistory GetEsgCompanyComprehensiveRatings (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory> localVarResponse = GetEsgCompanyComprehensiveRatingsWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ESG Company Comprehensive Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGCompanyComprehensiveRatingHistory</returns>
        
        
        public ApiResponse< ApiResponseESGCompanyComprehensiveRatingHistory > GetEsgCompanyComprehensiveRatingsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ESGApi->GetEsgCompanyComprehensiveRatings");

            var localVarPath = "/esg/{identifier}/comprehensive";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEsgCompanyComprehensiveRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGCompanyComprehensiveRatingHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGCompanyComprehensiveRatingHistory)));
        }

        /// <summary>
        /// ESG Company Comprehensive Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGCompanyComprehensiveRatingHistory</returns>
        public async System.Threading.Tasks.Task<ApiResponseESGCompanyComprehensiveRatingHistory> GetEsgCompanyComprehensiveRatingsAsync (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory> localVarResponse = await GetEsgCompanyComprehensiveRatingsAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ESG Company Comprehensive Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGCompanyComprehensiveRatingHistory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory>> GetEsgCompanyComprehensiveRatingsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ESGApi->GetEsgCompanyComprehensiveRatings");

            var localVarPath = "/esg/{identifier}/comprehensive";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEsgCompanyComprehensiveRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGCompanyComprehensiveRatingHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGCompanyComprehensiveRatingHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGCompanyComprehensiveRatingHistory)));
        }

        /// <summary>
        /// ESG Company Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGCompanyRatingHistory</returns>
        public ApiResponseESGCompanyRatingHistory GetEsgCompanyRatings (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGCompanyRatingHistory> localVarResponse = GetEsgCompanyRatingsWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ESG Company Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGCompanyRatingHistory</returns>
        
        
        public ApiResponse< ApiResponseESGCompanyRatingHistory > GetEsgCompanyRatingsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ESGApi->GetEsgCompanyRatings");

            var localVarPath = "/esg/{identifier}";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEsgCompanyRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGCompanyRatingHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGCompanyRatingHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGCompanyRatingHistory)));
        }

        /// <summary>
        /// ESG Company Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGCompanyRatingHistory</returns>
        public async System.Threading.Tasks.Task<ApiResponseESGCompanyRatingHistory> GetEsgCompanyRatingsAsync (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGCompanyRatingHistory> localVarResponse = await GetEsgCompanyRatingsAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ESG Company Ratings History 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">ISIN, Intrinio ID, or Ticker</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGCompanyRatingHistory)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseESGCompanyRatingHistory>> GetEsgCompanyRatingsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ESGApi->GetEsgCompanyRatings");

            var localVarPath = "/esg/{identifier}";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEsgCompanyRatings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGCompanyRatingHistory>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGCompanyRatingHistory) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGCompanyRatingHistory)));
        }

        /// <summary>
        /// ESG Latest 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGLatest</returns>
        public ApiResponseESGLatest GetEsgLatest (string country = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGLatest> localVarResponse = GetEsgLatestWithHttpInfo(country, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ESG Latest 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGLatest</returns>
        
        
        public ApiResponse< ApiResponseESGLatest > GetEsgLatestWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/esg";
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
            
            
            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
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
                Exception exception = ExceptionFactory("GetEsgLatest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGLatest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGLatest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGLatest)));
        }

        /// <summary>
        /// ESG Latest 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGLatest</returns>
        public async System.Threading.Tasks.Task<ApiResponseESGLatest> GetEsgLatestAsync (string country = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGLatest> localVarResponse = await GetEsgLatestAsyncWithHttpInfo(country, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ESG Latest 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGLatest)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseESGLatest>> GetEsgLatestAsyncWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/esg";
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
              

            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
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
                Exception exception = ExceptionFactory("GetEsgLatest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGLatest>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGLatest) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGLatest)));
        }

        /// <summary>
        /// ESG Latest Comprehensive 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseESGLatestComprehensive</returns>
        public ApiResponseESGLatestComprehensive GetEsgLatestComprehensive (string country = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGLatestComprehensive> localVarResponse = GetEsgLatestComprehensiveWithHttpInfo(country, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ESG Latest Comprehensive 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseESGLatestComprehensive</returns>
        
        
        public ApiResponse< ApiResponseESGLatestComprehensive > GetEsgLatestComprehensiveWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/esg/comprehensive";
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
            
            
            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
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
                Exception exception = ExceptionFactory("GetEsgLatestComprehensive", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGLatestComprehensive>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGLatestComprehensive) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGLatestComprehensive)));
        }

        /// <summary>
        /// ESG Latest Comprehensive 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseESGLatestComprehensive</returns>
        public async System.Threading.Tasks.Task<ApiResponseESGLatestComprehensive> GetEsgLatestComprehensiveAsync (string country = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseESGLatestComprehensive> localVarResponse = await GetEsgLatestComprehensiveAsyncWithHttpInfo(country, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ESG Latest Comprehensive 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"> (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseESGLatestComprehensive)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseESGLatestComprehensive>> GetEsgLatestComprehensiveAsyncWithHttpInfo (string country = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/esg/comprehensive";
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
              

            if (country != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country", country)); // query parameter
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
                Exception exception = ExceptionFactory("GetEsgLatestComprehensive", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseESGLatestComprehensive>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseESGLatestComprehensive) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseESGLatestComprehensive)));
        }

    }
}

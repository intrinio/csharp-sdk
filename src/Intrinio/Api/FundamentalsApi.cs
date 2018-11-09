

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
    public interface IFundamentalsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Fundamental</returns>
        Fundamental GetFundamentalById (string id);

        /// <summary>
        /// Get a Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of Fundamental</returns>
        ApiResponse<Fundamental> GetFundamentalByIdWithHttpInfo (string id);
        /// <summary>
        /// Get Reported Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponseReportedFinancials</returns>
        ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id);

        /// <summary>
        /// Get Reported Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of ApiResponseReportedFinancials</returns>
        ApiResponse<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsWithHttpInfo (string id);
        /// <summary>
        /// Get Standardized Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponseStandardizedFinancials</returns>
        ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id);

        /// <summary>
        /// Get Standardized Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of ApiResponseStandardizedFinancials</returns>
        ApiResponse<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsWithHttpInfo (string id);
        /// <summary>
        /// Lookup a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        List<Fundamental> LookupFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);

        /// <summary>
        /// Lookup a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        ApiResponse<List<Fundamental>> LookupFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of Fundamental</returns>
        System.Threading.Tasks.Task<Fundamental> GetFundamentalByIdAsync (string id);

        /// <summary>
        /// Get a Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        System.Threading.Tasks.Task<ApiResponse<Fundamental>> GetFundamentalByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get Reported Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponseReportedFinancials</returns>
        System.Threading.Tasks.Task<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsAsync (string id);

        /// <summary>
        /// Get Reported Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (ApiResponseReportedFinancials)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseReportedFinancials>> GetFundamentalReportedFinancialsAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get Standardized Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponseStandardizedFinancials</returns>
        System.Threading.Tasks.Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsAsync (string id);

        /// <summary>
        /// Get Standardized Financials for a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (ApiResponseStandardizedFinancials)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStandardizedFinancials>> GetFundamentalStandardizedFinancialsAsyncWithHttpInfo (string id);
        /// <summary>
        /// Lookup a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        System.Threading.Tasks.Task<List<Fundamental>> LookupFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);

        /// <summary>
        /// Lookup a Fundamental
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> LookupFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FundamentalsApi : IFundamentalsApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FundamentalsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FundamentalsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundamentalsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FundamentalsApi(Configuration configuration = null)
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
        /// Get a Fundamental by ID Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Fundamental</returns>
        public Fundamental GetFundamentalById (string id)
        {
             ApiResponse<Fundamental> localVarResponse = GetFundamentalByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Fundamental by ID Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of Fundamental</returns>
        public ApiResponse< Fundamental > GetFundamentalByIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalById");

            var localVarPath = "/fundamentals/{id}";
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
                Exception exception = ExceptionFactory("GetFundamentalById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Get a Fundamental by ID Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of Fundamental</returns>
        public async System.Threading.Tasks.Task<Fundamental> GetFundamentalByIdAsync (string id)
        {
             ApiResponse<Fundamental> localVarResponse = await GetFundamentalByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Fundamental by ID Retrieves detailed fundamental data for the given &#x60;fundamental_id&#x60;.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Fundamental>> GetFundamentalByIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalById");

            var localVarPath = "/fundamentals/{id}";
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
                Exception exception = ExceptionFactory("GetFundamentalById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Get Reported Financials for a Fundamental Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponseReportedFinancials</returns>
        public ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id)
        {
             ApiResponse<ApiResponseReportedFinancials> localVarResponse = GetFundamentalReportedFinancialsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Reported Financials for a Fundamental Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of ApiResponseReportedFinancials</returns>
        public ApiResponse< ApiResponseReportedFinancials > GetFundamentalReportedFinancialsWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalReportedFinancials");

            var localVarPath = "/fundamentals/{id}/reported_financials";
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
                Exception exception = ExceptionFactory("GetFundamentalReportedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseReportedFinancials>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseReportedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseReportedFinancials)));
        }

        /// <summary>
        /// Get Reported Financials for a Fundamental Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponseReportedFinancials</returns>
        public async System.Threading.Tasks.Task<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsAsync (string id)
        {
             ApiResponse<ApiResponseReportedFinancials> localVarResponse = await GetFundamentalReportedFinancialsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Reported Financials for a Fundamental Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (ApiResponseReportedFinancials)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseReportedFinancials>> GetFundamentalReportedFinancialsAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalReportedFinancials");

            var localVarPath = "/fundamentals/{id}/reported_financials";
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
                Exception exception = ExceptionFactory("GetFundamentalReportedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseReportedFinancials>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseReportedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseReportedFinancials)));
        }

        /// <summary>
        /// Get Standardized Financials for a Fundamental Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponseStandardizedFinancials</returns>
        public ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id)
        {
             ApiResponse<ApiResponseStandardizedFinancials> localVarResponse = GetFundamentalStandardizedFinancialsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Standardized Financials for a Fundamental Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of ApiResponseStandardizedFinancials</returns>
        public ApiResponse< ApiResponseStandardizedFinancials > GetFundamentalStandardizedFinancialsWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalStandardizedFinancials");

            var localVarPath = "/fundamentals/{id}/standardized_financials";
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
                Exception exception = ExceptionFactory("GetFundamentalStandardizedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStandardizedFinancials>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseStandardizedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStandardizedFinancials)));
        }

        /// <summary>
        /// Get Standardized Financials for a Fundamental Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponseStandardizedFinancials</returns>
        public async System.Threading.Tasks.Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsAsync (string id)
        {
             ApiResponse<ApiResponseStandardizedFinancials> localVarResponse = await GetFundamentalStandardizedFinancialsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Standardized Financials for a Fundamental Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies fundamentals. For example, it is possible to compare total revenues between two companies as of a certain point in time, or within a single company across multiple time periods. This is not possible using the as reported financial statements because of the inherent complexity of reporting standards.
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (ApiResponseStandardizedFinancials)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStandardizedFinancials>> GetFundamentalStandardizedFinancialsAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalStandardizedFinancials");

            var localVarPath = "/fundamentals/{id}/standardized_financials";
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
                Exception exception = ExceptionFactory("GetFundamentalStandardizedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStandardizedFinancials>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseStandardizedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStandardizedFinancials)));
        }

        /// <summary>
        /// Lookup a Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>List&lt;Fundamental&gt;</returns>
        public List<Fundamental> LookupFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
             ApiResponse<List<Fundamental>> localVarResponse = LookupFundamentalWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup a Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>ApiResponse of List&lt;Fundamental&gt;</returns>
        public ApiResponse< List<Fundamental> > LookupFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling FundamentalsApi->LookupFundamental");

            var localVarPath = "/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period}";
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
            if (statementCode != null) localVarPathParams.Add("statement_code", Configuration.ApiClient.ParameterToString(statementCode)); // path parameter
            if (fiscalPeriod != null) localVarPathParams.Add("fiscal_period", Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter
            if (fiscalYear != null) localVarPathParams.Add("fiscal_year", Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter

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
                Exception exception = ExceptionFactory("LookupFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

        /// <summary>
        /// Lookup a Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of List&lt;Fundamental&gt;</returns>
        public async System.Threading.Tasks.Task<List<Fundamental>> LookupFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
             ApiResponse<List<Fundamental>> localVarResponse = await LookupFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup a Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of ApiResponse (List&lt;Fundamental&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Fundamental>>> LookupFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling FundamentalsApi->LookupFundamental");

            var localVarPath = "/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period}";
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
            if (statementCode != null) localVarPathParams.Add("statement_code", Configuration.ApiClient.ParameterToString(statementCode)); // path parameter
            if (fiscalPeriod != null) localVarPathParams.Add("fiscal_period", Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter
            if (fiscalYear != null) localVarPathParams.Add("fiscal_year", Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter

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
                Exception exception = ExceptionFactory("LookupFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Fundamental>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Fundamental>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Fundamental>)));
        }

    }
}

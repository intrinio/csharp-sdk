

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
    public interface IFilingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Filings
        /// </summary>
        /// <remarks>
        /// Returns all Filings. Returns Filings matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilings</returns>
        ApiResponseFilings GetAllFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filings
        /// </summary>
        /// <remarks>
        /// Returns all Filings. Returns Filings matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilings</returns>
        ApiResponse<ApiResponseFilings> GetAllFilingsWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Filing Notes
        /// </summary>
        /// <remarks>
        /// Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilingNotes</returns>
        ApiResponseFilingNotes GetAllNotes (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filing Notes
        /// </summary>
        /// <remarks>
        /// Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilingNotes</returns>
        ApiResponse<ApiResponseFilingNotes> GetAllNotesWithHttpInfo (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup Filing
        /// </summary>
        /// <remarks>
        /// Returns the Filing with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Filing</returns>
        Filing GetFilingById (string id);

        /// <summary>
        /// Lookup Filing
        /// </summary>
        /// <remarks>
        /// Returns the Filing with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>ApiResponse of Filing</returns>
        ApiResponse<Filing> GetFilingByIdWithHttpInfo (string id);
        /// <summary>
        /// Filing Note by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>FilingNote</returns>
        FilingNote GetNote (string identifier, string contentFormat = null);

        /// <summary>
        /// Filing Note by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>ApiResponse of FilingNote</returns>
        ApiResponse<FilingNote> GetNoteWithHttpInfo (string identifier, string contentFormat = null);
        /// <summary>
        /// Filing Note HTML
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>string</returns>
        string GetNoteHtml (string identifier);

        /// <summary>
        /// Filing Note HTML
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetNoteHtmlWithHttpInfo (string identifier);
        /// <summary>
        /// Filing Note Text
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>string</returns>
        string GetNoteText (string identifier);

        /// <summary>
        /// Filing Note Text
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetNoteTextWithHttpInfo (string identifier);
        /// <summary>
        /// Search Filing Notes
        /// </summary>
        /// <remarks>
        /// Searches for Filing Notes using the &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseFilingNotesSearch</returns>
        ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null);

        /// <summary>
        /// Search Filing Notes
        /// </summary>
        /// <remarks>
        /// Searches for Filing Notes using the &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseFilingNotesSearch</returns>
        ApiResponse<ApiResponseFilingNotesSearch> SearchNotesWithHttpInfo (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Filings
        /// </summary>
        /// <remarks>
        /// Returns all Filings. Returns Filings matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilings</returns>
        System.Threading.Tasks.Task<ApiResponseFilings> GetAllFilingsAsync (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filings
        /// </summary>
        /// <remarks>
        /// Returns all Filings. Returns Filings matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseFilings>> GetAllFilingsAsyncWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Filing Notes
        /// </summary>
        /// <remarks>
        /// Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilingNotes</returns>
        System.Threading.Tasks.Task<ApiResponseFilingNotes> GetAllNotesAsync (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filing Notes
        /// </summary>
        /// <remarks>
        /// Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilingNotes)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseFilingNotes>> GetAllNotesAsyncWithHttpInfo (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup Filing
        /// </summary>
        /// <remarks>
        /// Returns the Filing with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of Filing</returns>
        System.Threading.Tasks.Task<Filing> GetFilingByIdAsync (string id);

        /// <summary>
        /// Lookup Filing
        /// </summary>
        /// <remarks>
        /// Returns the Filing with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of ApiResponse (Filing)</returns>
        System.Threading.Tasks.Task<ApiResponse<Filing>> GetFilingByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Filing Note by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>Task of FilingNote</returns>
        System.Threading.Tasks.Task<FilingNote> GetNoteAsync (string identifier, string contentFormat = null);

        /// <summary>
        /// Filing Note by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>Task of ApiResponse (FilingNote)</returns>
        System.Threading.Tasks.Task<ApiResponse<FilingNote>> GetNoteAsyncWithHttpInfo (string identifier, string contentFormat = null);
        /// <summary>
        /// Filing Note HTML
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetNoteHtmlAsync (string identifier);

        /// <summary>
        /// Filing Note HTML
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetNoteHtmlAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Filing Note Text
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetNoteTextAsync (string identifier);

        /// <summary>
        /// Filing Note Text
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetNoteTextAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Search Filing Notes
        /// </summary>
        /// <remarks>
        /// Searches for Filing Notes using the &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseFilingNotesSearch</returns>
        System.Threading.Tasks.Task<ApiResponseFilingNotesSearch> SearchNotesAsync (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null);

        /// <summary>
        /// Search Filing Notes
        /// </summary>
        /// <remarks>
        /// Searches for Filing Notes using the &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilingNotesSearch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseFilingNotesSearch>> SearchNotesAsyncWithHttpInfo (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FilingApi : IFilingApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FilingApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
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
        /// All Filings Returns all Filings. Returns Filings matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilings</returns>
        public ApiResponseFilings GetAllFilings (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseFilings> localVarResponse = GetAllFilingsWithHttpInfo(company, reportType, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Filings Returns all Filings. Returns Filings matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilings</returns>
        public ApiResponse< ApiResponseFilings > GetAllFilingsWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'company' is set
            if (company == null)
                throw new ApiException(400, "Missing required parameter 'company' when calling FilingApi->GetAllFilings");

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

            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (reportType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "report_type", reportType)); // query parameter
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
        /// All Filings Returns all Filings. Returns Filings matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseFilings> GetAllFilingsAsync (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseFilings> localVarResponse = await GetAllFilingsAsyncWithHttpInfo(company, reportType, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Filings Returns all Filings. Returns Filings matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by report type. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseFilings>> GetAllFilingsAsyncWithHttpInfo (string company, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'company' is set
            if (company == null)
                throw new ApiException(400, "Missing required parameter 'company' when calling FilingApi->GetAllFilings");

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

            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (reportType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "report_type", reportType)); // query parameter
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
        /// All Filing Notes Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseFilingNotes</returns>
        public ApiResponseFilingNotes GetAllNotes (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseFilingNotes> localVarResponse = GetAllNotesWithHttpInfo(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Filing Notes Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseFilingNotes</returns>
        public ApiResponse< ApiResponseFilingNotes > GetAllNotesWithHttpInfo (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/filings/notes";
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
            if (filingStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_start_date", filingStartDate)); // query parameter
            if (filingEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_end_date", filingEndDate)); // query parameter
            if (periodEndedStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period_ended_start_date", periodEndedStartDate)); // query parameter
            if (periodEndedEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period_ended_end_date", periodEndedEndDate)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllNotes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilingNotes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilingNotes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilingNotes)));
        }

        /// <summary>
        /// All Filing Notes Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseFilingNotes</returns>
        public async System.Threading.Tasks.Task<ApiResponseFilingNotes> GetAllNotesAsync (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseFilingNotes> localVarResponse = await GetAllNotesAsyncWithHttpInfo(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Filing Notes Return all Notes from all Filings, most-recent first. Returns notes matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="company">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="reportType">Notes contained in filings that match the given report type (optional)</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="periodEndedStartDate">Limit search to filings with a period end date on or after this date (optional)</param>
        /// <param name="periodEndedEndDate">Limit search to filings with a period end date on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilingNotes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseFilingNotes>> GetAllNotesAsyncWithHttpInfo (string company = null, string reportType = null, DateTime? filingStartDate = null, DateTime? filingEndDate = null, DateTime? periodEndedStartDate = null, DateTime? periodEndedEndDate = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/filings/notes";
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
            if (filingStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_start_date", filingStartDate)); // query parameter
            if (filingEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_end_date", filingEndDate)); // query parameter
            if (periodEndedStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period_ended_start_date", periodEndedStartDate)); // query parameter
            if (periodEndedEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period_ended_end_date", periodEndedEndDate)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllNotes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilingNotes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilingNotes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilingNotes)));
        }

        /// <summary>
        /// Lookup Filing Returns the Filing with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Filing</returns>
        public Filing GetFilingById (string id)
        {
             ApiResponse<Filing> localVarResponse = GetFilingByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Filing Returns the Filing with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Lookup Filing Returns the Filing with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID of the Filing</param>
        /// <returns>Task of Filing</returns>
        public async System.Threading.Tasks.Task<Filing> GetFilingByIdAsync (string id)
        {
             ApiResponse<Filing> localVarResponse = await GetFilingByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Filing Returns the Filing with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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

        /// <summary>
        /// Filing Note by ID 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>FilingNote</returns>
        public FilingNote GetNote (string identifier, string contentFormat = null)
        {
             ApiResponse<FilingNote> localVarResponse = GetNoteWithHttpInfo(identifier, contentFormat);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filing Note by ID 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>ApiResponse of FilingNote</returns>
        public ApiResponse< FilingNote > GetNoteWithHttpInfo (string identifier, string contentFormat = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FilingApi->GetNote");

            var localVarPath = "/filings/notes/{identifier}";
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
            if (contentFormat != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "content_format", contentFormat)); // query parameter

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
                Exception exception = ExceptionFactory("GetNote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FilingNote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilingNote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilingNote)));
        }

        /// <summary>
        /// Filing Note by ID 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>Task of FilingNote</returns>
        public async System.Threading.Tasks.Task<FilingNote> GetNoteAsync (string identifier, string contentFormat = null)
        {
             ApiResponse<FilingNote> localVarResponse = await GetNoteAsyncWithHttpInfo(identifier, contentFormat);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filing Note by ID 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <param name="contentFormat">Returns content in html (as filed) or plain text (optional, default to text)</param>
        /// <returns>Task of ApiResponse (FilingNote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FilingNote>> GetNoteAsyncWithHttpInfo (string identifier, string contentFormat = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FilingApi->GetNote");

            var localVarPath = "/filings/notes/{identifier}";
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
            if (contentFormat != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "content_format", contentFormat)); // query parameter

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
                Exception exception = ExceptionFactory("GetNote", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FilingNote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FilingNote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilingNote)));
        }

        /// <summary>
        /// Filing Note HTML 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>string</returns>
        public string GetNoteHtml (string identifier)
        {
             ApiResponse<string> localVarResponse = GetNoteHtmlWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filing Note HTML 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetNoteHtmlWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FilingApi->GetNoteHtml");

            var localVarPath = "/filings/notes/{identifier}/html";
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
                Exception exception = ExceptionFactory("GetNoteHtml", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Filing Note HTML 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetNoteHtmlAsync (string identifier)
        {
             ApiResponse<string> localVarResponse = await GetNoteHtmlAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filing Note HTML 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetNoteHtmlAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FilingApi->GetNoteHtml");

            var localVarPath = "/filings/notes/{identifier}/html";
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
                Exception exception = ExceptionFactory("GetNoteHtml", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Filing Note Text 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>string</returns>
        public string GetNoteText (string identifier)
        {
             ApiResponse<string> localVarResponse = GetNoteTextWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filing Note Text 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetNoteTextWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FilingApi->GetNoteText");

            var localVarPath = "/filings/notes/{identifier}/text";
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
                Exception exception = ExceptionFactory("GetNoteText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Filing Note Text 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetNoteTextAsync (string identifier)
        {
             ApiResponse<string> localVarResponse = await GetNoteTextAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filing Note Text 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID of the filing note</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetNoteTextAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FilingApi->GetNoteText");

            var localVarPath = "/filings/notes/{identifier}/text";
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
                Exception exception = ExceptionFactory("GetNoteText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Search Filing Notes Searches for Filing Notes using the &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseFilingNotesSearch</returns>
        public ApiResponseFilingNotesSearch SearchNotes (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null)
        {
             ApiResponse<ApiResponseFilingNotesSearch> localVarResponse = SearchNotesWithHttpInfo(query, filingStartDate, filingEndDate, pageSize, pageSize2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Filing Notes Searches for Filing Notes using the &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseFilingNotesSearch</returns>
        public ApiResponse< ApiResponseFilingNotesSearch > SearchNotesWithHttpInfo (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling FilingApi->SearchNotes");

            var localVarPath = "/filings/notes/search";
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
            if (filingStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_start_date", filingStartDate)); // query parameter
            if (filingEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_end_date", filingEndDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (pageSize2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize2)); // query parameter

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
                Exception exception = ExceptionFactory("SearchNotes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilingNotesSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilingNotesSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilingNotesSearch)));
        }

        /// <summary>
        /// Search Filing Notes Searches for Filing Notes using the &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseFilingNotesSearch</returns>
        public async System.Threading.Tasks.Task<ApiResponseFilingNotesSearch> SearchNotesAsync (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null)
        {
             ApiResponse<ApiResponseFilingNotesSearch> localVarResponse = await SearchNotesAsyncWithHttpInfo(query, filingStartDate, filingEndDate, pageSize, pageSize2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Filing Notes Searches for Filing Notes using the &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search for notes that contain all or parts of this text</param>
        /// <param name="filingStartDate">Limit search to filings on or after this date (optional)</param>
        /// <param name="filingEndDate">Limit search to filings on or before this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="pageSize2">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseFilingNotesSearch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseFilingNotesSearch>> SearchNotesAsyncWithHttpInfo (string query, DateTime? filingStartDate = null, DateTime? filingEndDate = null, int? pageSize = null, int? pageSize2 = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling FilingApi->SearchNotes");

            var localVarPath = "/filings/notes/search";
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
            if (filingStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_start_date", filingStartDate)); // query parameter
            if (filingEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filing_end_date", filingEndDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (pageSize2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize2)); // query parameter

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
                Exception exception = ExceptionFactory("SearchNotes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseFilingNotesSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseFilingNotesSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseFilingNotesSearch)));
        }

    }
}

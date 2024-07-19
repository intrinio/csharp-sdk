

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
    public interface IFundamentalsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Filter Fundamental
        /// </summary>
        /// <remarks>
        /// Returns fundamentals that meet the set of filters specified in parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Fundamental</returns>
        Fundamental FilterFundamental (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null);

        /// <summary>
        /// Filter Fundamental
        /// </summary>
        /// <remarks>
        /// Returns fundamentals that meet the set of filters specified in parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of Fundamental</returns>
        ApiResponse<Fundamental> FilterFundamentalWithHttpInfo (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null);
        /// <summary>
        /// Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Fundamental</returns>
        Fundamental GetFundamentalById (string id);

        /// <summary>
        /// Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>ApiResponse of Fundamental</returns>
        ApiResponse<Fundamental> GetFundamentalByIdWithHttpInfo (string id);
        /// <summary>
        /// Reported Financials
        /// </summary>
        /// <remarks>
        /// Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>ApiResponseReportedFinancials</returns>
        ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id);

        /// <summary>
        /// Reported Financials
        /// </summary>
        /// <remarks>
        /// Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>ApiResponse of ApiResponseReportedFinancials</returns>
        ApiResponse<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsWithHttpInfo (string id);
        /// <summary>
        /// Standardized Financials
        /// </summary>
        /// <remarks>
        /// Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>ApiResponseStandardizedFinancials</returns>
        ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id);

        /// <summary>
        /// Standardized Financials
        /// </summary>
        /// <remarks>
        /// Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>ApiResponse of ApiResponseStandardizedFinancials</returns>
        ApiResponse<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsWithHttpInfo (string id);
        /// <summary>
        /// Standardized Financials Dimensions
        /// </summary>
        /// <remarks>
        /// Returns as reported dimensionality of a data tag
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponseStandardizedFinancialsDimensions</returns>
        ApiResponseStandardizedFinancialsDimensions GetFundamentalStandardizedFinancialsDimensions (string id, string tag);

        /// <summary>
        /// Standardized Financials Dimensions
        /// </summary>
        /// <remarks>
        /// Returns as reported dimensionality of a data tag
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of ApiResponseStandardizedFinancialsDimensions</returns>
        ApiResponse<ApiResponseStandardizedFinancialsDimensions> GetFundamentalStandardizedFinancialsDimensionsWithHttpInfo (string id, string tag);
        /// <summary>
        /// Lookup Fundamental
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>Fundamental</returns>
        Fundamental LookupFundamental (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod);

        /// <summary>
        /// Lookup Fundamental
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>ApiResponse of Fundamental</returns>
        ApiResponse<Fundamental> LookupFundamentalWithHttpInfo (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Filter Fundamental
        /// </summary>
        /// <remarks>
        /// Returns fundamentals that meet the set of filters specified in parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of Fundamental</returns>
        System.Threading.Tasks.Task<Fundamental> FilterFundamentalAsync (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null);

        /// <summary>
        /// Filter Fundamental
        /// </summary>
        /// <remarks>
        /// Returns fundamentals that meet the set of filters specified in parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        System.Threading.Tasks.Task<ApiResponse<Fundamental>> FilterFundamentalAsyncWithHttpInfo (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null);
        /// <summary>
        /// Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of Fundamental</returns>
        System.Threading.Tasks.Task<Fundamental> GetFundamentalByIdAsync (string id);

        /// <summary>
        /// Fundamental by ID
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        System.Threading.Tasks.Task<ApiResponse<Fundamental>> GetFundamentalByIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Reported Financials
        /// </summary>
        /// <remarks>
        /// Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>Task of ApiResponseReportedFinancials</returns>
        System.Threading.Tasks.Task<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsAsync (string id);

        /// <summary>
        /// Reported Financials
        /// </summary>
        /// <remarks>
        /// Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>Task of ApiResponse (ApiResponseReportedFinancials)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseReportedFinancials>> GetFundamentalReportedFinancialsAsyncWithHttpInfo (string id);
        /// <summary>
        /// Standardized Financials
        /// </summary>
        /// <remarks>
        /// Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>Task of ApiResponseStandardizedFinancials</returns>
        System.Threading.Tasks.Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsAsync (string id);

        /// <summary>
        /// Standardized Financials
        /// </summary>
        /// <remarks>
        /// Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>Task of ApiResponse (ApiResponseStandardizedFinancials)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStandardizedFinancials>> GetFundamentalStandardizedFinancialsAsyncWithHttpInfo (string id);
        /// <summary>
        /// Standardized Financials Dimensions
        /// </summary>
        /// <remarks>
        /// Returns as reported dimensionality of a data tag
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponseStandardizedFinancialsDimensions</returns>
        System.Threading.Tasks.Task<ApiResponseStandardizedFinancialsDimensions> GetFundamentalStandardizedFinancialsDimensionsAsync (string id, string tag);

        /// <summary>
        /// Standardized Financials Dimensions
        /// </summary>
        /// <remarks>
        /// Returns as reported dimensionality of a data tag
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (ApiResponseStandardizedFinancialsDimensions)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseStandardizedFinancialsDimensions>> GetFundamentalStandardizedFinancialsDimensionsAsyncWithHttpInfo (string id, string tag);
        /// <summary>
        /// Lookup Fundamental
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>Task of Fundamental</returns>
        System.Threading.Tasks.Task<Fundamental> LookupFundamentalAsync (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod);

        /// <summary>
        /// Lookup Fundamental
        /// </summary>
        /// <remarks>
        /// Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        System.Threading.Tasks.Task<ApiResponse<Fundamental>> LookupFundamentalAsyncWithHttpInfo (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FundamentalsApi : IFundamentalsApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FundamentalsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FundamentalsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
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
        /// Filter Fundamental Returns fundamentals that meet the set of filters specified in parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Fundamental</returns>
        public Fundamental FilterFundamental (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null)
        {
             ApiResponse<Fundamental> localVarResponse = FilterFundamentalWithHttpInfo(filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, fiscalPeriod, startDate, endDate, updatedAfter, updatedBefore, template, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Filter Fundamental Returns fundamentals that meet the set of filters specified in parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of Fundamental</returns>
        
        
        public ApiResponse< Fundamental > FilterFundamentalWithHttpInfo (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null)
        {

            var localVarPath = "/fundamentals";
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
            
            
            if (filedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_after", filedAfter)); // query parameter
            if (filedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_before", filedBefore)); // query parameter
            if (reportedOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reported_only", reportedOnly)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (fiscalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period", fiscalPeriod)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (updatedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_after", updatedAfter)); // query parameter
            if (updatedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_before", updatedBefore)); // query parameter
            if (template != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "template", template)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("FilterFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Filter Fundamental Returns fundamentals that meet the set of filters specified in parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of Fundamental</returns>
        public async System.Threading.Tasks.Task<Fundamental> FilterFundamentalAsync (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null)
        {
             ApiResponse<Fundamental> localVarResponse = await FilterFundamentalAsyncWithHttpInfo(filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, fiscalPeriod, startDate, endDate, updatedAfter, updatedBefore, template, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Filter Fundamental Returns fundamentals that meet the set of filters specified in parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filedAfter">Only include fundamentals that were filed on or after this date. (optional)</param>
        /// <param name="filedBefore">Only include fundamentals that were filed on or before this date. (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fiscalPeriod">The fiscal period (optional)</param>
        /// <param name="startDate">Only include fundamentals where covered period is on or after this date. (optional)</param>
        /// <param name="endDate">Only include fundamentals where covered period is on or before this date. (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="template">The financial statement template used by Intrinio to standardize the as reported data (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Fundamental>> FilterFundamentalAsyncWithHttpInfo (DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fiscalPeriod = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, string template = null, string nextPage = null)
        {

            var localVarPath = "/fundamentals";
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
              

            if (filedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_after", filedAfter)); // query parameter
            if (filedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_before", filedBefore)); // query parameter
            if (reportedOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reported_only", reportedOnly)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (fiscalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period", fiscalPeriod)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (updatedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_after", updatedAfter)); // query parameter
            if (updatedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_before", updatedBefore)); // query parameter
            if (template != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "template", template)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

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
                Exception exception = ExceptionFactory("FilterFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Fundamental by ID Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Fundamental</returns>
        public Fundamental GetFundamentalById (string id)
        {
             ApiResponse<Fundamental> localVarResponse = GetFundamentalByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Fundamental by ID Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFundamentalById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Fundamental by ID Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID for the Fundamental</param>
        /// <returns>Task of Fundamental</returns>
        public async System.Threading.Tasks.Task<Fundamental> GetFundamentalByIdAsync (string id)
        {
             ApiResponse<Fundamental> localVarResponse = await GetFundamentalByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Fundamental by ID Returns a specific fundamental associated with a particular unique fundamental ID. Useful for pulling reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFundamentalById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Reported Financials Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>ApiResponseReportedFinancials</returns>
        public ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id)
        {
             ApiResponse<ApiResponseReportedFinancials> localVarResponse = GetFundamentalReportedFinancialsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Reported Financials Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFundamentalReportedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseReportedFinancials>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseReportedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseReportedFinancials)));
        }

        /// <summary>
        /// Reported Financials Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>Task of ApiResponseReportedFinancials</returns>
        public async System.Threading.Tasks.Task<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsAsync (string id)
        {
             ApiResponse<ApiResponseReportedFinancials> localVarResponse = await GetFundamentalReportedFinancialsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Reported Financials Returns as-reported financial statement data for income statement, balance sheet, and cash flow statement. Data for income statement and cash flow statement is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFundamentalReportedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseReportedFinancials>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseReportedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseReportedFinancials)));
        }

        /// <summary>
        /// Standardized Financials Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>ApiResponseStandardizedFinancials</returns>
        public ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id)
        {
             ApiResponse<ApiResponseStandardizedFinancials> localVarResponse = GetFundamentalStandardizedFinancialsWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Standardized Financials Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFundamentalStandardizedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStandardizedFinancials>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStandardizedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStandardizedFinancials)));
        }

        /// <summary>
        /// Standardized Financials Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <returns>Task of ApiResponseStandardizedFinancials</returns>
        public async System.Threading.Tasks.Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsAsync (string id)
        {
             ApiResponse<ApiResponseStandardizedFinancials> localVarResponse = await GetFundamentalStandardizedFinancialsAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Standardized Financials Returns standardized financial statement data for income statement, balance sheet, cash flow statement and over 100 associated calculations for a given company. Data for income statement, cash flow statement, and calculations is available on a FY, QTR (Q1, Q2, Q3, Q4), TTM (Q1TTM, Q2TTM, Q3TTM), and YTD (Q2YTD, Q3YTD) basis. Data for the balance sheet is available on a FY or QTR (Q1, Q2, Q3, Q4) basis only due its point-in-time nature.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFundamentalStandardizedFinancials", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStandardizedFinancials>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStandardizedFinancials) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStandardizedFinancials)));
        }

        /// <summary>
        /// Standardized Financials Dimensions Returns as reported dimensionality of a data tag
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponseStandardizedFinancialsDimensions</returns>
        public ApiResponseStandardizedFinancialsDimensions GetFundamentalStandardizedFinancialsDimensions (string id, string tag)
        {
             ApiResponse<ApiResponseStandardizedFinancialsDimensions> localVarResponse = GetFundamentalStandardizedFinancialsDimensionsWithHttpInfo(id, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Standardized Financials Dimensions Returns as reported dimensionality of a data tag
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of ApiResponseStandardizedFinancialsDimensions</returns>
        
        
        public ApiResponse< ApiResponseStandardizedFinancialsDimensions > GetFundamentalStandardizedFinancialsDimensionsWithHttpInfo (string id, string tag)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalStandardizedFinancialsDimensions");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling FundamentalsApi->GetFundamentalStandardizedFinancialsDimensions");

            var localVarPath = "/fundamentals/{id}/standardized_financials/dimensions/{tag}";
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
                Exception exception = ExceptionFactory("GetFundamentalStandardizedFinancialsDimensions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStandardizedFinancialsDimensions>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStandardizedFinancialsDimensions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStandardizedFinancialsDimensions)));
        }

        /// <summary>
        /// Standardized Financials Dimensions Returns as reported dimensionality of a data tag
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponseStandardizedFinancialsDimensions</returns>
        public async System.Threading.Tasks.Task<ApiResponseStandardizedFinancialsDimensions> GetFundamentalStandardizedFinancialsDimensionsAsync (string id, string tag)
        {
             ApiResponse<ApiResponseStandardizedFinancialsDimensions> localVarResponse = await GetFundamentalStandardizedFinancialsDimensionsAsyncWithHttpInfo(id, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Standardized Financials Dimensions Returns as reported dimensionality of a data tag
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (ApiResponseStandardizedFinancialsDimensions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseStandardizedFinancialsDimensions>> GetFundamentalStandardizedFinancialsDimensionsAsyncWithHttpInfo (string id, string tag)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalStandardizedFinancialsDimensions");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling FundamentalsApi->GetFundamentalStandardizedFinancialsDimensions");

            var localVarPath = "/fundamentals/{id}/standardized_financials/dimensions/{tag}";
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
                Exception exception = ExceptionFactory("GetFundamentalStandardizedFinancialsDimensions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseStandardizedFinancialsDimensions>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseStandardizedFinancialsDimensions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseStandardizedFinancialsDimensions)));
        }

        /// <summary>
        /// Lookup Fundamental Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>Fundamental</returns>
        public Fundamental LookupFundamental (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)
        {
             ApiResponse<Fundamental> localVarResponse = LookupFundamentalWithHttpInfo(identifier, statementCode, fiscalYear, fiscalPeriod);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Fundamental Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>ApiResponse of Fundamental</returns>
        
        
        public ApiResponse< Fundamental > LookupFundamentalWithHttpInfo (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling FundamentalsApi->LookupFundamental");

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
            if (fiscalYear != null) localVarPathParams.Add("fiscal_year", Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter
            if (fiscalPeriod != null) localVarPathParams.Add("fiscal_period", Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter

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
                Exception exception = ExceptionFactory("LookupFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Lookup Fundamental Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>Task of Fundamental</returns>
        public async System.Threading.Tasks.Task<Fundamental> LookupFundamentalAsync (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)
        {
             ApiResponse<Fundamental> localVarResponse = await LookupFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalYear, fiscalPeriod);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Fundamental Returns a specific fundamental with unique fundamental ID associated with a particular company, year, period and statement. Useful for pulling the unique fundamental ID and reference data for a specific fundamental.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Fundamental>> LookupFundamentalAsyncWithHttpInfo (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling FundamentalsApi->LookupFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling FundamentalsApi->LookupFundamental");

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
            if (fiscalYear != null) localVarPathParams.Add("fiscal_year", Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter
            if (fiscalPeriod != null) localVarPathParams.Add("fiscal_period", Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter

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
                Exception exception = ExceptionFactory("LookupFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

    }
}

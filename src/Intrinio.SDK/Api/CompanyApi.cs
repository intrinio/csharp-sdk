

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
    public interface ICompanyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanies</returns>
        ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanies</returns>
        ApiResponse<ApiResponseCompanies> GetAllCompaniesWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns all News for all Companies
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseNews</returns>
        ApiResponseNews GetAllCompanyNews (int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns all News for all Companies
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseNews</returns>
        ApiResponse<ApiResponseNews> GetAllCompanyNewsWithHttpInfo (int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Company</returns>
        Company GetCompany (string identifier);

        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of Company</returns>
        ApiResponse<Company> GetCompanyWithHttpInfo (string identifier);
        /// <summary>
        /// Data Point (Number) for Company
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>decimal?</returns>
        decimal? GetCompanyDataPointNumber (string identifier, string tag);

        /// <summary>
        /// Data Point (Number) for Company
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of decimal?</returns>
        ApiResponse<decimal?> GetCompanyDataPointNumberWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Data Point (Text) for Company
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>string</returns>
        string GetCompanyDataPointText (string identifier, string tag);

        /// <summary>
        /// Data Point (Text) for Company
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetCompanyDataPointTextWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// All Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFilings</returns>
        ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFilings</returns>
        ApiResponse<ApiResponseCompanyFilings> GetCompanyFilingsWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFundamentals</returns>
        ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFundamentals</returns>
        ApiResponse<ApiResponseCompanyFundamentals> GetCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Historical Data for Company
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyHistoricalData</returns>
        ApiResponseCompanyHistoricalData GetCompanyHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Historical Data for Company
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyHistoricalData</returns>
        ApiResponse<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyNews</returns>
        ApiResponseCompanyNews GetCompanyNews (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyNews</returns>
        ApiResponse<ApiResponseCompanyNews> GetCompanyNewsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Securities by Company
        /// </summary>
        /// <remarks>
        /// Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanySecurities</returns>
        ApiResponseCompanySecurities GetCompanySecurities (string identifier, string nextPage = null);

        /// <summary>
        /// All Securities by Company
        /// </summary>
        /// <remarks>
        /// Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanySecurities</returns>
        ApiResponse<ApiResponseCompanySecurities> GetCompanySecuritiesWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Lookup Fundamental by Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Fundamental</returns>
        Fundamental LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);

        /// <summary>
        /// Lookup Fundamental by Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>ApiResponse of Fundamental</returns>
        ApiResponse<Fundamental> LookupCompanyFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);
        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseCompaniesSearch</returns>
        ApiResponseCompaniesSearch SearchCompanies (string query, int? pageSize = null);

        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseCompaniesSearch</returns>
        ApiResponse<ApiResponseCompaniesSearch> SearchCompaniesWithHttpInfo (string query, int? pageSize = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanies</returns>
        System.Threading.Tasks.Task<ApiResponseCompanies> GetAllCompaniesAsync (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanies)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanies>> GetAllCompaniesAsyncWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns all News for all Companies
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseNews</returns>
        System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns all News for all Companies
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseNews)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseNews>> GetAllCompanyNewsAsyncWithHttpInfo (int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of Company</returns>
        System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier);

        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Company)</returns>
        System.Threading.Tasks.Task<ApiResponse<Company>> GetCompanyAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Data Point (Number) for Company
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of decimal?</returns>
        System.Threading.Tasks.Task<decimal?> GetCompanyDataPointNumberAsync (string identifier, string tag);

        /// <summary>
        /// Data Point (Number) for Company
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (decimal?)</returns>
        System.Threading.Tasks.Task<ApiResponse<decimal?>> GetCompanyDataPointNumberAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Data Point (Text) for Company
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetCompanyDataPointTextAsync (string identifier, string tag);

        /// <summary>
        /// Data Point (Text) for Company
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetCompanyDataPointTextAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// All Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFilings</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFilings>> GetCompanyFilingsAsyncWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFundamentals</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFundamentals)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFundamentals>> GetCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Historical Data for Company
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyHistoricalData</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Historical Data for Company
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyHistoricalData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyHistoricalData>> GetCompanyHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyNews</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns news for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyNews)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNews>> GetCompanyNewsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Securities by Company
        /// </summary>
        /// <remarks>
        /// Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanySecurities</returns>
        System.Threading.Tasks.Task<ApiResponseCompanySecurities> GetCompanySecuritiesAsync (string identifier, string nextPage = null);

        /// <summary>
        /// All Securities by Company
        /// </summary>
        /// <remarks>
        /// Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanySecurities)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanySecurities>> GetCompanySecuritiesAsyncWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Lookup Fundamental by Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of Fundamental</returns>
        System.Threading.Tasks.Task<Fundamental> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);

        /// <summary>
        /// Lookup Fundamental by Company
        /// </summary>
        /// <remarks>
        /// Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        System.Threading.Tasks.Task<ApiResponse<Fundamental>> LookupCompanyFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear);
        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseCompaniesSearch</returns>
        System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, int? pageSize = null);

        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Searches for Companies matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompaniesSearch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompaniesSearch>> SearchCompaniesAsyncWithHttpInfo (string query, int? pageSize = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompanyApi : ICompanyApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompanyApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompanyApi(Configuration configuration = null)
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
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanies</returns>
        public ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanies> localVarResponse = GetAllCompaniesWithHttpInfo(latestFilingDate, sic, template, sector, industryCategory, industryGroup, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanies</returns>
        public ApiResponse< ApiResponseCompanies > GetAllCompaniesWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/companies";
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

            if (latestFilingDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "latest_filing_date", latestFilingDate)); // query parameter
            if (sic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sic", sic)); // query parameter
            if (template != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "template", template)); // query parameter
            if (sector != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sector", sector)); // query parameter
            if (industryCategory != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_category", industryCategory)); // query parameter
            if (industryGroup != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group", industryGroup)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanies>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanies)));
        }

        /// <summary>
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanies</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanies> GetAllCompaniesAsync (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanies> localVarResponse = await GetAllCompaniesAsyncWithHttpInfo(latestFilingDate, sic, template, sector, industryCategory, industryGroup, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Last filing date (optional)</param>
        /// <param name="sic">Standard Industrial Classification code (optional)</param>
        /// <param name="template">Template (optional)</param>
        /// <param name="sector">Industry sector (optional)</param>
        /// <param name="industryCategory">Industry category (optional)</param>
        /// <param name="industryGroup">Industry group (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanies)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanies>> GetAllCompaniesAsyncWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/companies";
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

            if (latestFilingDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "latest_filing_date", latestFilingDate)); // query parameter
            if (sic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sic", sic)); // query parameter
            if (template != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "template", template)); // query parameter
            if (sector != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sector", sector)); // query parameter
            if (industryCategory != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_category", industryCategory)); // query parameter
            if (industryGroup != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group", industryGroup)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanies>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanies)));
        }

        /// <summary>
        /// All News Returns all News for all Companies
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseNews</returns>
        public ApiResponseNews GetAllCompanyNews (int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseNews> localVarResponse = GetAllCompanyNewsWithHttpInfo(pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All News Returns all News for all Companies
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseNews</returns>
        public ApiResponse< ApiResponseNews > GetAllCompanyNewsWithHttpInfo (int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/companies/news";
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
                Exception exception = ExceptionFactory("GetAllCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseNews>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseNews)));
        }

        /// <summary>
        /// All News Returns all News for all Companies
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseNews</returns>
        public async System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseNews> localVarResponse = await GetAllCompanyNewsAsyncWithHttpInfo(pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All News Returns all News for all Companies
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseNews)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseNews>> GetAllCompanyNewsAsyncWithHttpInfo (int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/companies/news";
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
                Exception exception = ExceptionFactory("GetAllCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseNews>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseNews)));
        }

        /// <summary>
        /// Lookup Company Returns the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Company</returns>
        public Company GetCompany (string identifier)
        {
             ApiResponse<Company> localVarResponse = GetCompanyWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Company Returns the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of Company</returns>
        public ApiResponse< Company > GetCompanyWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompany");

            var localVarPath = "/companies/{identifier}";
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
                Exception exception = ExceptionFactory("GetCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Company>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Company) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Company)));
        }

        /// <summary>
        /// Lookup Company Returns the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of Company</returns>
        public async System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier)
        {
             ApiResponse<Company> localVarResponse = await GetCompanyAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Company Returns the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Company)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Company>> GetCompanyAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompany");

            var localVarPath = "/companies/{identifier}";
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
                Exception exception = ExceptionFactory("GetCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Company>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Company) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Company)));
        }

        /// <summary>
        /// Data Point (Number) for Company Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>decimal?</returns>
        public decimal? GetCompanyDataPointNumber (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = GetCompanyDataPointNumberWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Data Point (Number) for Company Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of decimal?</returns>
        public ApiResponse< decimal? > GetCompanyDataPointNumberWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling CompanyApi->GetCompanyDataPointNumber");

            var localVarPath = "/companies/{identifier}/data_point/{tag}/number";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Number) for Company Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of decimal?</returns>
        public async System.Threading.Tasks.Task<decimal?> GetCompanyDataPointNumberAsync (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = await GetCompanyDataPointNumberAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Data Point (Number) for Company Returns a numeric value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (decimal?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<decimal?>> GetCompanyDataPointNumberAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling CompanyApi->GetCompanyDataPointNumber");

            var localVarPath = "/companies/{identifier}/data_point/{tag}/number";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Text) for Company Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>string</returns>
        public string GetCompanyDataPointText (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = GetCompanyDataPointTextWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Data Point (Text) for Company Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetCompanyDataPointTextWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling CompanyApi->GetCompanyDataPointText");

            var localVarPath = "/companies/{identifier}/data_point/{tag}/text";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Data Point (Text) for Company Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetCompanyDataPointTextAsync (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = await GetCompanyDataPointTextAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Data Point (Text) for Company Returns a text value for the given &#x60;tag&#x60; for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetCompanyDataPointTextAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling CompanyApi->GetCompanyDataPointText");

            var localVarPath = "/companies/{identifier}/data_point/{tag}/text";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFilings</returns>
        public ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFilings> localVarResponse = GetCompanyFilingsWithHttpInfo(identifier, reportType, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFilings</returns>
        public ApiResponse< ApiResponseCompanyFilings > GetCompanyFilingsWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyFilings");

            var localVarPath = "/companies/{identifier}/filings";
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
                Exception exception = ExceptionFactory("GetCompanyFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFilings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFilings)));
        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFilings> localVarResponse = await GetCompanyFilingsAsyncWithHttpInfo(identifier, reportType, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFilings>> GetCompanyFilingsAsyncWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyFilings");

            var localVarPath = "/companies/{identifier}/filings";
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
                Exception exception = ExceptionFactory("GetCompanyFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFilings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFilings)));
        }

        /// <summary>
        /// All Fundamentals by Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFundamentals</returns>
        public ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFundamentals> localVarResponse = GetCompanyFundamentalsWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Fundamentals by Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFundamentals</returns>
        public ApiResponse< ApiResponseCompanyFundamentals > GetCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyFundamentals");

            var localVarPath = "/companies/{identifier}/fundamentals";
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
            if (filedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_after", filedAfter)); // query parameter
            if (filedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_before", filedBefore)); // query parameter
            if (reportedOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reported_only", reportedOnly)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFundamentals>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyFundamentals) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFundamentals)));
        }

        /// <summary>
        /// All Fundamentals by Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFundamentals</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFundamentals> localVarResponse = await GetCompanyFundamentalsAsyncWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Fundamentals by Company Returns all Fundamentals for the Company with the given &#x60;identifier&#x60;. Returns Fundamentals matching parameters when supplied.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFundamentals)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFundamentals>> GetCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyFundamentals");

            var localVarPath = "/companies/{identifier}/fundamentals";
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
            if (filedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_after", filedAfter)); // query parameter
            if (filedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filed_before", filedBefore)); // query parameter
            if (reportedOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "reported_only", reportedOnly)); // query parameter
            if (fiscalYear != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
            if (statementCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "statement_code", statementCode)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFundamentals>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyFundamentals) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFundamentals)));
        }

        /// <summary>
        /// Historical Data for Company Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyHistoricalData</returns>
        public ApiResponseCompanyHistoricalData GetCompanyHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyHistoricalData> localVarResponse = GetCompanyHistoricalDataWithHttpInfo(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Historical Data for Company Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyHistoricalData</returns>
        public ApiResponse< ApiResponseCompanyHistoricalData > GetCompanyHistoricalDataWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyHistoricalData");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling CompanyApi->GetCompanyHistoricalData");

            var localVarPath = "/companies/{identifier}/historical_data/{tag}";
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
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
            if (frequency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyHistoricalData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyHistoricalData)));
        }

        /// <summary>
        /// Historical Data for Company Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyHistoricalData</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyHistoricalData> localVarResponse = await GetCompanyHistoricalDataAsyncWithHttpInfo(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Historical Data for Company Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyHistoricalData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyHistoricalData>> GetCompanyHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyHistoricalData");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling CompanyApi->GetCompanyHistoricalData");

            var localVarPath = "/companies/{identifier}/historical_data/{tag}";
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
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
            if (frequency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyHistoricalData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyHistoricalData)));
        }

        /// <summary>
        /// All News by Company Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyNews</returns>
        public ApiResponseCompanyNews GetCompanyNews (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNews> localVarResponse = GetCompanyNewsWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All News by Company Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyNews</returns>
        public ApiResponse< ApiResponseCompanyNews > GetCompanyNewsWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyNews");

            var localVarPath = "/companies/{identifier}/news";
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
                Exception exception = ExceptionFactory("GetCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyNews>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyNews)));
        }

        /// <summary>
        /// All News by Company Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyNews</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNews> localVarResponse = await GetCompanyNewsAsyncWithHttpInfo(identifier, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All News by Company Returns news for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyNews)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNews>> GetCompanyNewsAsyncWithHttpInfo (string identifier, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyNews");

            var localVarPath = "/companies/{identifier}/news";
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
                Exception exception = ExceptionFactory("GetCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyNews>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanyNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyNews)));
        }

        /// <summary>
        /// All Securities by Company Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanySecurities</returns>
        public ApiResponseCompanySecurities GetCompanySecurities (string identifier, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanySecurities> localVarResponse = GetCompanySecuritiesWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Securities by Company Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanySecurities</returns>
        public ApiResponse< ApiResponseCompanySecurities > GetCompanySecuritiesWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanySecurities");

            var localVarPath = "/companies/{identifier}/securities";
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
                Exception exception = ExceptionFactory("GetCompanySecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanySecurities>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanySecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanySecurities)));
        }

        /// <summary>
        /// All Securities by Company Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanySecurities</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanySecurities> GetCompanySecuritiesAsync (string identifier, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanySecurities> localVarResponse = await GetCompanySecuritiesAsyncWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Securities by Company Returns Securities for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanySecurities)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanySecurities>> GetCompanySecuritiesAsyncWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanySecurities");

            var localVarPath = "/companies/{identifier}/securities";
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
                Exception exception = ExceptionFactory("GetCompanySecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanySecurities>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompanySecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanySecurities)));
        }

        /// <summary>
        /// Lookup Fundamental by Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Fundamental</returns>
        public Fundamental LookupCompanyFundamental (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
             ApiResponse<Fundamental> localVarResponse = LookupCompanyFundamentalWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Fundamental by Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>ApiResponse of Fundamental</returns>
        public ApiResponse< Fundamental > LookupCompanyFundamentalWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling CompanyApi->LookupCompanyFundamental");

            var localVarPath = "/companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period}";
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
                Exception exception = ExceptionFactory("LookupCompanyFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Lookup Fundamental by Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of Fundamental</returns>
        public async System.Threading.Tasks.Task<Fundamental> LookupCompanyFundamentalAsync (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
             ApiResponse<Fundamental> localVarResponse = await LookupCompanyFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalPeriod, fiscalYear);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Fundamental by Company Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given parameters
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="statementCode">The statement code</param>
        /// <param name="fiscalPeriod">The fiscal period</param>
        /// <param name="fiscalYear">The fiscal year</param>
        /// <returns>Task of ApiResponse (Fundamental)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Fundamental>> LookupCompanyFundamentalAsyncWithHttpInfo (string identifier, string statementCode, string fiscalPeriod, int? fiscalYear)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'statementCode' is set
            if (statementCode == null)
                throw new ApiException(400, "Missing required parameter 'statementCode' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalPeriod' is set
            if (fiscalPeriod == null)
                throw new ApiException(400, "Missing required parameter 'fiscalPeriod' when calling CompanyApi->LookupCompanyFundamental");
            // verify the required parameter 'fiscalYear' is set
            if (fiscalYear == null)
                throw new ApiException(400, "Missing required parameter 'fiscalYear' when calling CompanyApi->LookupCompanyFundamental");

            var localVarPath = "/companies/{identifier}/fundamentals/lookup/{statement_code}/{fiscal_year}/{fiscal_period}";
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
                Exception exception = ExceptionFactory("LookupCompanyFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseCompaniesSearch</returns>
        public ApiResponseCompaniesSearch SearchCompanies (string query, int? pageSize = null)
        {
             ApiResponse<ApiResponseCompaniesSearch> localVarResponse = SearchCompaniesWithHttpInfo(query, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseCompaniesSearch</returns>
        public ApiResponse< ApiResponseCompaniesSearch > SearchCompaniesWithHttpInfo (string query, int? pageSize = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling CompanyApi->SearchCompanies");

            var localVarPath = "/companies/search";
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
                Exception exception = ExceptionFactory("SearchCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompaniesSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompaniesSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompaniesSearch)));
        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseCompaniesSearch</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, int? pageSize = null)
        {
             ApiResponse<ApiResponseCompaniesSearch> localVarResponse = await SearchCompaniesAsyncWithHttpInfo(query, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Companies Searches for Companies matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompaniesSearch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompaniesSearch>> SearchCompaniesAsyncWithHttpInfo (string query, int? pageSize = null)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling CompanyApi->SearchCompanies");

            var localVarPath = "/companies/search";
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
                Exception exception = ExceptionFactory("SearchCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompaniesSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCompaniesSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompaniesSearch)));
        }

    }
}

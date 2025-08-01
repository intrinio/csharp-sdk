

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
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanies</returns>
        ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanies</returns>
        ApiResponse<ApiResponseCompanies> GetAllCompaniesWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Companies daily metrics
        /// </summary>
        /// <remarks>
        /// Returns the company metrics for a date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyDailyMetrics</returns>
        ApiResponseCompanyDailyMetrics GetAllCompaniesDailyMetrics (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);

        /// <summary>
        /// All Companies daily metrics
        /// </summary>
        /// <remarks>
        /// Returns the company metrics for a date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyDailyMetrics</returns>
        ApiResponse<ApiResponseCompanyDailyMetrics> GetAllCompaniesDailyMetricsWithHttpInfo (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);
        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseNews</returns>
        ApiResponseNews GetAllCompanyNews (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);

        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseNews</returns>
        ApiResponse<ApiResponseNews> GetAllCompanyNewsWithHttpInfo (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);
        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Company</returns>
        Company GetCompany (string identifier);

        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>ApiResponse of Company</returns>
        ApiResponse<Company> GetCompanyWithHttpInfo (string identifier);
        /// <summary>
        /// Company Answers
        /// </summary>
        /// <remarks>
        /// Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>ApiResponseCompanyAnswers</returns>
        ApiResponseCompanyAnswers GetCompanyAnswers (string identifier, string query);

        /// <summary>
        /// Company Answers
        /// </summary>
        /// <remarks>
        /// Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>ApiResponse of ApiResponseCompanyAnswers</returns>
        ApiResponse<ApiResponseCompanyAnswers> GetCompanyAnswersWithHttpInfo (string identifier, string query);
        /// <summary>
        /// Company metrics by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest company metrics.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyDailyMetrics</returns>
        ApiResponseCompanyDailyMetrics GetCompanyDailyMetrics (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);

        /// <summary>
        /// Company metrics by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest company metrics.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyDailyMetrics</returns>
        ApiResponse<ApiResponseCompanyDailyMetrics> GetCompanyDailyMetricsWithHttpInfo (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);
        /// <summary>
        /// Data Point (Number) for Company
        /// </summary>
        /// <remarks>
        /// Returns latest value for calculations, metrics, and financial data points for a company.
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
        /// Returns latest value for calculations, metrics, and financial data points for a company.
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
        /// Returns latest value for metadata items for a company.
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
        /// Returns latest value for metadata items for a company.
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
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFilings</returns>
        ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFilings</returns>
        ApiResponse<ApiResponseCompanyFilings> GetCompanyFilingsWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFundamentals</returns>
        ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFundamentals</returns>
        ApiResponse<ApiResponseCompanyFundamentals> GetCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null);
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
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
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
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyHistoricalData</returns>
        ApiResponse<ApiResponseCompanyHistoricalData> GetCompanyHistoricalDataWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// IPOs
        /// </summary>
        /// <remarks>
        /// Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseInitialPublicOfferings</returns>
        ApiResponseInitialPublicOfferings GetCompanyIpos (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// IPOs
        /// </summary>
        /// <remarks>
        /// Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseInitialPublicOfferings</returns>
        ApiResponse<ApiResponseInitialPublicOfferings> GetCompanyIposWithHttpInfo (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyNews</returns>
        ApiResponseCompanyNews GetCompanyNews (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);

        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyNews</returns>
        ApiResponse<ApiResponseCompanyNews> GetCompanyNewsWithHttpInfo (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);
        /// <summary>
        /// News Article Body
        /// </summary>
        /// <remarks>
        /// Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyNewsBody</returns>
        ApiResponseCompanyNewsBody GetCompanyNewsBody (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null);

        /// <summary>
        /// News Article Body
        /// </summary>
        /// <remarks>
        /// Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyNewsBody</returns>
        ApiResponse<ApiResponseCompanyNewsBody> GetCompanyNewsBodyWithHttpInfo (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null);
        /// <summary>
        /// Get Company&#39;s public float
        /// </summary>
        /// <remarks>
        /// Returns a list of public float data tied to a given company identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyPublicFloatResult</returns>
        ApiResponseCompanyPublicFloatResult GetCompanyPublicFloat (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null);

        /// <summary>
        /// Get Company&#39;s public float
        /// </summary>
        /// <remarks>
        /// Returns a list of public float data tied to a given company identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyPublicFloatResult</returns>
        ApiResponse<ApiResponseCompanyPublicFloatResult> GetCompanyPublicFloatWithHttpInfo (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null);
        /// <summary>
        /// All Securities by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of underlying securities with associated reference data tied to a given company identifier.
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
        /// Returns a list of underlying securities with associated reference data tied to a given company identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanySecurities</returns>
        ApiResponse<ApiResponseCompanySecurities> GetCompanySecuritiesWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Insider Transaction Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseInsiderTransactionFilings</returns>
        ApiResponseInsiderTransactionFilings InsiderTransactionFilingsByCompany (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null);

        /// <summary>
        /// Insider Transaction Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseInsiderTransactionFilings</returns>
        ApiResponse<ApiResponseInsiderTransactionFilings> InsiderTransactionFilingsByCompanyWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null);
        /// <summary>
        /// Latest Insider Transaction Filing by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest insider transaction filing for a company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InsiderTransactionFiling</returns>
        InsiderTransactionFiling LatestInsiderTransactionFilingByCompany (string identifier, string nextPage = null);

        /// <summary>
        /// Latest Insider Transaction Filing by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest insider transaction filing for a company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InsiderTransactionFiling</returns>
        ApiResponse<InsiderTransactionFiling> LatestInsiderTransactionFilingByCompanyWithHttpInfo (string identifier, string nextPage = null);
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
        /// Recognize Company
        /// </summary>
        /// <remarks>
        /// Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>ApiResponseCompanyRecognize</returns>
        ApiResponseCompanyRecognize RecognizeCompany (string text);

        /// <summary>
        /// Recognize Company
        /// </summary>
        /// <remarks>
        /// Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>ApiResponse of ApiResponseCompanyRecognize</returns>
        ApiResponse<ApiResponseCompanyRecognize> RecognizeCompanyWithHttpInfo (string text);
        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseCompaniesSearch</returns>
        ApiResponseCompaniesSearch SearchCompanies (string query, bool? active = null, string mode = null, int? pageSize = null);

        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseCompaniesSearch</returns>
        ApiResponse<ApiResponseCompaniesSearch> SearchCompaniesWithHttpInfo (string query, bool? active = null, string mode = null, int? pageSize = null);
        /// <summary>
        /// Shares Outstanding by Company
        /// </summary>
        /// <remarks>
        /// Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>ApiResponseCompanySharesOutstanding</returns>
        ApiResponseCompanySharesOutstanding SharesOutstandingByCompany (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null);

        /// <summary>
        /// Shares Outstanding by Company
        /// </summary>
        /// <remarks>
        /// Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanySharesOutstanding</returns>
        ApiResponse<ApiResponseCompanySharesOutstanding> SharesOutstandingByCompanyWithHttpInfo (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanies</returns>
        System.Threading.Tasks.Task<ApiResponseCompanies> GetAllCompaniesAsync (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Companies
        /// </summary>
        /// <remarks>
        /// Returns all Companies. When parameters are specified, returns matching companies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanies)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanies>> GetAllCompaniesAsyncWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Companies daily metrics
        /// </summary>
        /// <remarks>
        /// Returns the company metrics for a date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyDailyMetrics</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyDailyMetrics> GetAllCompaniesDailyMetricsAsync (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);

        /// <summary>
        /// All Companies daily metrics
        /// </summary>
        /// <remarks>
        /// Returns the company metrics for a date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyDailyMetrics)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyDailyMetrics>> GetAllCompaniesDailyMetricsAsyncWithHttpInfo (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);
        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseNews</returns>
        System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);

        /// <summary>
        /// All News
        /// </summary>
        /// <remarks>
        /// Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseNews)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseNews>> GetAllCompanyNewsAsyncWithHttpInfo (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);
        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of Company</returns>
        System.Threading.Tasks.Task<Company> GetCompanyAsync (string identifier);

        /// <summary>
        /// Lookup Company
        /// </summary>
        /// <remarks>
        /// Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Company)</returns>
        System.Threading.Tasks.Task<ApiResponse<Company>> GetCompanyAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Company Answers
        /// </summary>
        /// <remarks>
        /// Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>Task of ApiResponseCompanyAnswers</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyAnswers> GetCompanyAnswersAsync (string identifier, string query);

        /// <summary>
        /// Company Answers
        /// </summary>
        /// <remarks>
        /// Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyAnswers)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyAnswers>> GetCompanyAnswersAsyncWithHttpInfo (string identifier, string query);
        /// <summary>
        /// Company metrics by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest company metrics.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyDailyMetrics</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyDailyMetrics> GetCompanyDailyMetricsAsync (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);

        /// <summary>
        /// Company metrics by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest company metrics.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyDailyMetrics)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyDailyMetrics>> GetCompanyDailyMetricsAsyncWithHttpInfo (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null);
        /// <summary>
        /// Data Point (Number) for Company
        /// </summary>
        /// <remarks>
        /// Returns latest value for calculations, metrics, and financial data points for a company.
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
        /// Returns latest value for calculations, metrics, and financial data points for a company.
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
        /// Returns latest value for metadata items for a company.
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
        /// Returns latest value for metadata items for a company.
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
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFilings</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFilings>> GetCompanyFilingsAsyncWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFundamentals</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// All Fundamentals by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFundamentals)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFundamentals>> GetCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null);
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
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
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
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyHistoricalData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyHistoricalData>> GetCompanyHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// IPOs
        /// </summary>
        /// <remarks>
        /// Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseInitialPublicOfferings</returns>
        System.Threading.Tasks.Task<ApiResponseInitialPublicOfferings> GetCompanyIposAsync (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// IPOs
        /// </summary>
        /// <remarks>
        /// Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseInitialPublicOfferings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseInitialPublicOfferings>> GetCompanyIposAsyncWithHttpInfo (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyNews</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);

        /// <summary>
        /// All News by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyNews)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNews>> GetCompanyNewsAsyncWithHttpInfo (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null);
        /// <summary>
        /// News Article Body
        /// </summary>
        /// <remarks>
        /// Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyNewsBody</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyNewsBody> GetCompanyNewsBodyAsync (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null);

        /// <summary>
        /// News Article Body
        /// </summary>
        /// <remarks>
        /// Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyNewsBody)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNewsBody>> GetCompanyNewsBodyAsyncWithHttpInfo (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null);
        /// <summary>
        /// Get Company&#39;s public float
        /// </summary>
        /// <remarks>
        /// Returns a list of public float data tied to a given company identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyPublicFloatResult</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyPublicFloatResult> GetCompanyPublicFloatAsync (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null);

        /// <summary>
        /// Get Company&#39;s public float
        /// </summary>
        /// <remarks>
        /// Returns a list of public float data tied to a given company identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyPublicFloatResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyPublicFloatResult>> GetCompanyPublicFloatAsyncWithHttpInfo (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null);
        /// <summary>
        /// All Securities by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of underlying securities with associated reference data tied to a given company identifier.
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
        /// Returns a list of underlying securities with associated reference data tied to a given company identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanySecurities)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanySecurities>> GetCompanySecuritiesAsyncWithHttpInfo (string identifier, string nextPage = null);
        /// <summary>
        /// Insider Transaction Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseInsiderTransactionFilings</returns>
        System.Threading.Tasks.Task<ApiResponseInsiderTransactionFilings> InsiderTransactionFilingsByCompanyAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null);

        /// <summary>
        /// Insider Transaction Filings by Company
        /// </summary>
        /// <remarks>
        /// Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseInsiderTransactionFilings)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseInsiderTransactionFilings>> InsiderTransactionFilingsByCompanyAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null);
        /// <summary>
        /// Latest Insider Transaction Filing by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest insider transaction filing for a company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InsiderTransactionFiling</returns>
        System.Threading.Tasks.Task<InsiderTransactionFiling> LatestInsiderTransactionFilingByCompanyAsync (string identifier, string nextPage = null);

        /// <summary>
        /// Latest Insider Transaction Filing by Company
        /// </summary>
        /// <remarks>
        /// Returns the latest insider transaction filing for a company.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InsiderTransactionFiling)</returns>
        System.Threading.Tasks.Task<ApiResponse<InsiderTransactionFiling>> LatestInsiderTransactionFilingByCompanyAsyncWithHttpInfo (string identifier, string nextPage = null);
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
        /// Recognize Company
        /// </summary>
        /// <remarks>
        /// Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>Task of ApiResponseCompanyRecognize</returns>
        System.Threading.Tasks.Task<ApiResponseCompanyRecognize> RecognizeCompanyAsync (string text);

        /// <summary>
        /// Recognize Company
        /// </summary>
        /// <remarks>
        /// Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyRecognize)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyRecognize>> RecognizeCompanyAsyncWithHttpInfo (string text);
        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseCompaniesSearch</returns>
        System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, bool? active = null, string mode = null, int? pageSize = null);

        /// <summary>
        /// Search Companies
        /// </summary>
        /// <remarks>
        /// Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompaniesSearch)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompaniesSearch>> SearchCompaniesAsyncWithHttpInfo (string query, bool? active = null, string mode = null, int? pageSize = null);
        /// <summary>
        /// Shares Outstanding by Company
        /// </summary>
        /// <remarks>
        /// Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>Task of ApiResponseCompanySharesOutstanding</returns>
        System.Threading.Tasks.Task<ApiResponseCompanySharesOutstanding> SharesOutstandingByCompanyAsync (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null);

        /// <summary>
        /// Shares Outstanding by Company
        /// </summary>
        /// <remarks>
        /// Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanySharesOutstanding)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanySharesOutstanding>> SharesOutstandingByCompanyAsyncWithHttpInfo (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null);
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
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanies</returns>
        public ApiResponseCompanies GetAllCompanies (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanies> localVarResponse = GetAllCompaniesWithHttpInfo(latestFilingDate, sic, template, sector, industryCategory, industryGroup, hasFundamentals, hasStockPrices, theaEnabled, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanies</returns>
        
        public ApiResponse< ApiResponseCompanies > GetAllCompaniesWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
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
            if (hasFundamentals != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "has_fundamentals", hasFundamentals)); // query parameter
            if (hasStockPrices != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "has_stock_prices", hasStockPrices)); // query parameter
            if (theaEnabled != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "thea_enabled", theaEnabled)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanies>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanies)));
        }

        /// <summary>
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanies</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanies> GetAllCompaniesAsync (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanies> localVarResponse = await GetAllCompaniesAsyncWithHttpInfo(latestFilingDate, sic, template, sector, industryCategory, industryGroup, hasFundamentals, hasStockPrices, theaEnabled, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Companies Returns all Companies. When parameters are specified, returns matching companies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latestFilingDate">Return companies whose latest 10-Q or 10-K was filed on or after this date (optional)</param>
        /// <param name="sic">Return companies with the given Standard Industrial Classification code (optional)</param>
        /// <param name="template">Return companies with the given financial statement template (optional)</param>
        /// <param name="sector">Return companies in the given industry sector (optional)</param>
        /// <param name="industryCategory">Return companies in the given industry category (optional)</param>
        /// <param name="industryGroup">Return companies in the given industry group (optional)</param>
        /// <param name="hasFundamentals">Return only companies that have fundamentals when true (optional)</param>
        /// <param name="hasStockPrices">Return only companies that have stock prices when true (optional)</param>
        /// <param name="theaEnabled">Return companies whose have been read by our Thea NLP and are ready for our company answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanies)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanies>> GetAllCompaniesAsyncWithHttpInfo (DateTime? latestFilingDate = null, string sic = null, string template = null, string sector = null, string industryCategory = null, string industryGroup = null, bool? hasFundamentals = null, bool? hasStockPrices = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
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
            if (hasFundamentals != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "has_fundamentals", hasFundamentals)); // query parameter
            if (hasStockPrices != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "has_stock_prices", hasStockPrices)); // query parameter
            if (theaEnabled != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "thea_enabled", theaEnabled)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanies>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanies)));
        }

        /// <summary>
        /// All Companies daily metrics Returns the company metrics for a date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyDailyMetrics</returns>
        public ApiResponseCompanyDailyMetrics GetAllCompaniesDailyMetrics (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseCompanyDailyMetrics> localVarResponse = GetAllCompaniesDailyMetricsWithHttpInfo(onDate, pageSize, nextPage, nextPage2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Companies daily metrics Returns the company metrics for a date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyDailyMetrics</returns>
        
        public ApiResponse< ApiResponseCompanyDailyMetrics > GetAllCompaniesDailyMetricsWithHttpInfo (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {

            var localVarPath = "/companies/daily_metrics";
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
            
            
            if (onDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "on_date", onDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllCompaniesDailyMetrics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyDailyMetrics>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyDailyMetrics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyDailyMetrics)));
        }

        /// <summary>
        /// All Companies daily metrics Returns the company metrics for a date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyDailyMetrics</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyDailyMetrics> GetAllCompaniesDailyMetricsAsync (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseCompanyDailyMetrics> localVarResponse = await GetAllCompaniesDailyMetricsAsyncWithHttpInfo(onDate, pageSize, nextPage, nextPage2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Companies daily metrics Returns the company metrics for a date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyDailyMetrics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyDailyMetrics>> GetAllCompaniesDailyMetricsAsyncWithHttpInfo (DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {

            var localVarPath = "/companies/daily_metrics";
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
              

            if (onDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "on_date", onDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllCompaniesDailyMetrics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyDailyMetrics>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyDailyMetrics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyDailyMetrics)));
        }

        /// <summary>
        /// All News Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseNews</returns>
        public ApiResponseNews GetAllCompanyNews (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
        {
             ApiResponse<ApiResponseNews> localVarResponse = GetAllCompanyNewsWithHttpInfo(specificSource, pageSize, sentiment, topic, company, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All News Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseNews</returns>
        
        public ApiResponse< ApiResponseNews > GetAllCompanyNewsWithHttpInfo (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
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
            
            
            if (specificSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "specific_source", specificSource)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (topic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "topic", topic)); // query parameter
            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (security != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "security", security)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (language != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (wordCountGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_greater_than", wordCountGreaterThan)); // query parameter
            if (wordCountLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_less_than", wordCountLessThan)); // query parameter
            if (isSpam != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_spam", isSpam)); // query parameter
            if (businessRelevanceGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_greater_than", businessRelevanceGreaterThan)); // query parameter
            if (businessRelevanceLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_less_than", businessRelevanceLessThan)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseNews>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseNews)));
        }

        /// <summary>
        /// All News Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseNews</returns>
        public async System.Threading.Tasks.Task<ApiResponseNews> GetAllCompanyNewsAsync (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
        {
             ApiResponse<ApiResponseNews> localVarResponse = await GetAllCompanyNewsAsyncWithHttpInfo(specificSource, pageSize, sentiment, topic, company, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All News Returns the latest news article links, headlines and summaries for all US traded companies allowing you to keep a pulse on companies and their business operations.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return. (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="company">Filter by &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date. (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseNews)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseNews>> GetAllCompanyNewsAsyncWithHttpInfo (string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string company = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
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
              

            if (specificSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "specific_source", specificSource)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (topic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "topic", topic)); // query parameter
            if (company != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
            if (security != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "security", security)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (language != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (wordCountGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_greater_than", wordCountGreaterThan)); // query parameter
            if (wordCountLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_less_than", wordCountLessThan)); // query parameter
            if (isSpam != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_spam", isSpam)); // query parameter
            if (businessRelevanceGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_greater_than", businessRelevanceGreaterThan)); // query parameter
            if (businessRelevanceLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_less_than", businessRelevanceLessThan)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseNews>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseNews)));
        }

        /// <summary>
        /// Lookup Company Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
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
        /// Lookup Company Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Company>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Company) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Company)));
        }

        /// <summary>
        /// Lookup Company Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
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
        /// Lookup Company Returns company reference and metadata such as tickers, CIK, and a unique company identifier, as well as company metadata such as business description, employee count, and company URL.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Company>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Company) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Company)));
        }

        /// <summary>
        /// Company Answers Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>ApiResponseCompanyAnswers</returns>
        public ApiResponseCompanyAnswers GetCompanyAnswers (string identifier, string query)
        {
             ApiResponse<ApiResponseCompanyAnswers> localVarResponse = GetCompanyAnswersWithHttpInfo(identifier, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Company Answers Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>ApiResponse of ApiResponseCompanyAnswers</returns>
        
        public ApiResponse< ApiResponseCompanyAnswers > GetCompanyAnswersWithHttpInfo (string identifier, string query)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyAnswers");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling CompanyApi->GetCompanyAnswers");

            var localVarPath = "/companies/{identifier}/answers";
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
            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

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
                Exception exception = ExceptionFactory("GetCompanyAnswers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyAnswers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyAnswers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyAnswers)));
        }

        /// <summary>
        /// Company Answers Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>Task of ApiResponseCompanyAnswers</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyAnswers> GetCompanyAnswersAsync (string identifier, string query)
        {
             ApiResponse<ApiResponseCompanyAnswers> localVarResponse = await GetCompanyAnswersAsyncWithHttpInfo(identifier, query);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Company Answers Returns answers for a question about the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="query">The query to ask the Thea API</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyAnswers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyAnswers>> GetCompanyAnswersAsyncWithHttpInfo (string identifier, string query)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyAnswers");
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling CompanyApi->GetCompanyAnswers");

            var localVarPath = "/companies/{identifier}/answers";
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
            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

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
                Exception exception = ExceptionFactory("GetCompanyAnswers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyAnswers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyAnswers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyAnswers)));
        }

        /// <summary>
        /// Company metrics by Company Returns the latest company metrics.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyDailyMetrics</returns>
        public ApiResponseCompanyDailyMetrics GetCompanyDailyMetrics (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseCompanyDailyMetrics> localVarResponse = GetCompanyDailyMetricsWithHttpInfo(identifier, onDate, pageSize, nextPage, nextPage2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Company metrics by Company Returns the latest company metrics.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyDailyMetrics</returns>
        
        public ApiResponse< ApiResponseCompanyDailyMetrics > GetCompanyDailyMetricsWithHttpInfo (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDailyMetrics");

            var localVarPath = "/companies/{identifier}/daily_metrics";
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
            if (onDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "on_date", onDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("GetCompanyDailyMetrics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyDailyMetrics>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyDailyMetrics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyDailyMetrics)));
        }

        /// <summary>
        /// Company metrics by Company Returns the latest company metrics.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyDailyMetrics</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyDailyMetrics> GetCompanyDailyMetricsAsync (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseCompanyDailyMetrics> localVarResponse = await GetCompanyDailyMetricsAsyncWithHttpInfo(identifier, onDate, pageSize, nextPage, nextPage2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Company metrics by Company Returns the latest company metrics.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="onDate">Date of the metric (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyDailyMetrics)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyDailyMetrics>> GetCompanyDailyMetricsAsyncWithHttpInfo (string identifier, DateTime? onDate = null, int? pageSize = null, string nextPage = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyDailyMetrics");

            var localVarPath = "/companies/{identifier}/daily_metrics";
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
            if (onDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "on_date", onDate)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("GetCompanyDailyMetrics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyDailyMetrics>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyDailyMetrics) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyDailyMetrics)));
        }

        /// <summary>
        /// Data Point (Number) for Company Returns latest value for calculations, metrics, and financial data points for a company.
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
        /// Data Point (Number) for Company Returns latest value for calculations, metrics, and financial data points for a company.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Number) for Company Returns latest value for calculations, metrics, and financial data points for a company.
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
        /// Data Point (Number) for Company Returns latest value for calculations, metrics, and financial data points for a company.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Text) for Company Returns latest value for metadata items for a company.
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
        /// Data Point (Text) for Company Returns latest value for metadata items for a company.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Data Point (Text) for Company Returns latest value for metadata items for a company.
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
        /// Data Point (Text) for Company Returns latest value for metadata items for a company.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFilings</returns>
        public ApiResponseCompanyFilings GetCompanyFilings (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFilings> localVarResponse = GetCompanyFilingsWithHttpInfo(identifier, reportType, startDate, endDate, theaEnabled, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFilings</returns>
        
        public ApiResponse< ApiResponseCompanyFilings > GetCompanyFilingsWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
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
            if (theaEnabled != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "thea_enabled", theaEnabled)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFilings)));
        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyFilings> GetCompanyFilingsAsync (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFilings> localVarResponse = await GetCompanyFilingsAsyncWithHttpInfo(identifier, reportType, startDate, endDate, theaEnabled, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Filings by Company Returns a complete list of SEC filings for the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="reportType">Filter by &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;. Separate values with commas to return multiple report types. (optional)</param>
        /// <param name="startDate">Filed on or after the given date (optional)</param>
        /// <param name="endDate">Filed before or after the given date (optional)</param>
        /// <param name="theaEnabled">Return filings that have been read by our Thea NLP and are ready for our answers endpoint (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFilings>> GetCompanyFilingsAsyncWithHttpInfo (string identifier, string reportType = null, DateTime? startDate = null, DateTime? endDate = null, bool? theaEnabled = null, int? pageSize = null, string nextPage = null)
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
            if (theaEnabled != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "thea_enabled", theaEnabled)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyFilings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFilings)));
        }

        /// <summary>
        /// All Fundamentals by Company Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyFundamentals</returns>
        public ApiResponseCompanyFundamentals GetCompanyFundamentals (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFundamentals> localVarResponse = GetCompanyFundamentalsWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, fundamentalType, startDate, endDate, updatedAfter, latestOnly, updatedBefore, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Fundamentals by Company Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyFundamentals</returns>
        
        public ApiResponse< ApiResponseCompanyFundamentals > GetCompanyFundamentalsWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null)
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
            if (fundamentalType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fundamental_type", fundamentalType)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (updatedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_after", updatedAfter)); // query parameter
            if (latestOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "latest_only", latestOnly)); // query parameter
            if (updatedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_before", updatedBefore)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFundamentals>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyFundamentals) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFundamentals)));
        }

        /// <summary>
        /// All Fundamentals by Company Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyFundamentals</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyFundamentals> GetCompanyFundamentalsAsync (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyFundamentals> localVarResponse = await GetCompanyFundamentalsAsyncWithHttpInfo(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, fundamentalType, startDate, endDate, updatedAfter, latestOnly, updatedBefore, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Fundamentals by Company Returns a list of fundamentals with unique fundamental IDs associated with a particular company. Useful to obtain all historical and/or latest fundamental IDs for a given company to then use to loop through and pull all fundamental data available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="filedAfter">Filed on or after this date (optional)</param>
        /// <param name="filedBefore">Filed on or before this date (optional)</param>
        /// <param name="reportedOnly">Only as-reported fundamentals (optional)</param>
        /// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
        /// <param name="statementCode">Only of the given statement code (optional)</param>
        /// <param name="type">Only of the given type (optional)</param>
        /// <param name="fundamentalType">Only of the given fundamental type (optional)</param>
        /// <param name="startDate">Only on or after the given date (optional)</param>
        /// <param name="endDate">Only on or before the given date (optional)</param>
        /// <param name="updatedAfter">Only include fundamentals where it was updated after this date. (optional)</param>
        /// <param name="latestOnly">Only the most-recently reported fundamental for the period (optional)</param>
        /// <param name="updatedBefore">Only include fundamentals where it was updated before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyFundamentals)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyFundamentals>> GetCompanyFundamentalsAsyncWithHttpInfo (string identifier, DateTime? filedAfter = null, DateTime? filedBefore = null, bool? reportedOnly = null, int? fiscalYear = null, string statementCode = null, string type = null, string fundamentalType = null, DateTime? startDate = null, DateTime? endDate = null, DateTime? updatedAfter = null, bool? latestOnly = null, DateTime? updatedBefore = null, int? pageSize = null, string nextPage = null)
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
            if (fundamentalType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fundamental_type", fundamentalType)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (updatedAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_after", updatedAfter)); // query parameter
            if (latestOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "latest_only", latestOnly)); // query parameter
            if (updatedBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_before", updatedBefore)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyFundamentals", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyFundamentals>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyFundamentals) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyFundamentals)));
        }

        /// <summary>
        /// Historical Data for Company Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
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
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyHistoricalData>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyHistoricalData)));
        }

        /// <summary>
        /// Historical Data for Company Returns historical values for the given &#x60;tag&#x60; and the Company with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;reference&lt;/a&gt;)</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
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
        /// <param name="type">Return historical data for given fiscal period type (optional)</param>
        /// <param name="startDate">Return historical data on or after this date (optional)</param>
        /// <param name="endDate">Return historical data on or before this date (optional)</param>
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanyHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyHistoricalData>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyHistoricalData)));
        }

        /// <summary>
        /// IPOs Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseInitialPublicOfferings</returns>
        public ApiResponseInitialPublicOfferings GetCompanyIpos (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseInitialPublicOfferings> localVarResponse = GetCompanyIposWithHttpInfo(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// IPOs Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseInitialPublicOfferings</returns>
        
        public ApiResponse< ApiResponseInitialPublicOfferings > GetCompanyIposWithHttpInfo (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/companies/ipos";
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
            
            
            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
            if (status != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (offerAmountGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offer_amount_greater_than", offerAmountGreaterThan)); // query parameter
            if (offerAmountLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offer_amount_less_than", offerAmountLessThan)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyIpos", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseInitialPublicOfferings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseInitialPublicOfferings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseInitialPublicOfferings)));
        }

        /// <summary>
        /// IPOs Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseInitialPublicOfferings</returns>
        public async System.Threading.Tasks.Task<ApiResponseInitialPublicOfferings> GetCompanyIposAsync (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseInitialPublicOfferings> localVarResponse = await GetCompanyIposAsyncWithHttpInfo(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// IPOs Returns a list of historical, current, and upcoming initial public offerings (IPOs) across the major US Exchanges. Includes relevant information such as the IPO status, the offer amount, the total share count and target share price.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ticker">Return IPOs with the given ticker (typically the IPO for the company) (optional)</param>
        /// <param name="status">Return IPOs with the given status. Upcoming IPOs are scheduled to occur in the future. Priced IPOs have occurred and the company should be trading publicly. Withdrawn IPOs were planned to occurr but were withdrawn beforehand (optional)</param>
        /// <param name="startDate">Return IPOs on or after the given date (optional)</param>
        /// <param name="endDate">Return IPOs on or before the given date (optional)</param>
        /// <param name="offerAmountGreaterThan">Return IPOs with an offer dollar amount greater than the given amount (optional)</param>
        /// <param name="offerAmountLessThan">Return IPOs with an offer dollar amount less than the given amount (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseInitialPublicOfferings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseInitialPublicOfferings>> GetCompanyIposAsyncWithHttpInfo (string ticker = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, int? offerAmountGreaterThan = null, int? offerAmountLessThan = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/companies/ipos";
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
              

            if (ticker != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
            if (status != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (offerAmountGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offer_amount_greater_than", offerAmountGreaterThan)); // query parameter
            if (offerAmountLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offer_amount_less_than", offerAmountLessThan)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyIpos", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseInitialPublicOfferings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseInitialPublicOfferings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseInitialPublicOfferings)));
        }

        /// <summary>
        /// All News by Company Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyNews</returns>
        public ApiResponseCompanyNews GetCompanyNews (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNews> localVarResponse = GetCompanyNewsWithHttpInfo(identifier, specificSource, pageSize, sentiment, topic, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All News by Company Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyNews</returns>
        
        public ApiResponse< ApiResponseCompanyNews > GetCompanyNewsWithHttpInfo (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
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
            if (specificSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "specific_source", specificSource)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (topic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "topic", topic)); // query parameter
            if (security != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "security", security)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (language != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (wordCountGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_greater_than", wordCountGreaterThan)); // query parameter
            if (wordCountLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_less_than", wordCountLessThan)); // query parameter
            if (isSpam != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_spam", isSpam)); // query parameter
            if (businessRelevanceGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_greater_than", businessRelevanceGreaterThan)); // query parameter
            if (businessRelevanceLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_less_than", businessRelevanceLessThan)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyNews>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyNews)));
        }

        /// <summary>
        /// All News by Company Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyNews</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyNews> GetCompanyNewsAsync (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNews> localVarResponse = await GetCompanyNewsAsyncWithHttpInfo(identifier, specificSource, pageSize, sentiment, topic, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All News by Company Returns the latest and historical news article links, headlines and summaries for a specified US traded company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="pageSize">The maximum number of results to return (optional, default to 100)</param>
        /// <param name="sentiment">Filter by sentiment.  Unsupported for yahoo source. (optional)</param>
        /// <param name="topic">Filter by topic.  Unsupported for yahoo source. (optional)</param>
        /// <param name="security">Filter by &#x60;security&#x60; identifier (ticker, figi, isin, cusip, Intrinio ID).  Unsupported for yahoo source. (optional)</param>
        /// <param name="startDate">Limit news stories to those on or after this date. Defaults to yesterday if unspecified. (optional)</param>
        /// <param name="endDate">Limit news stories to those on or before this date (optional)</param>
        /// <param name="language">Filter by language.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountGreaterThan">News stories will have a word count greater than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="wordCountLessThan">News stories will have a word count less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="isSpam">Filter whether it is marked as spam or not.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceGreaterThan">News stories will have a business relevance score more than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="businessRelevanceLessThan">News stories will have a business relevance score less than this value.  Unsupported for yahoo source. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyNews)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNews>> GetCompanyNewsAsyncWithHttpInfo (string identifier, string specificSource = null, int? pageSize = null, string sentiment = null, string topic = null, string security = null, DateTime? startDate = null, DateTime? endDate = null, string language = null, int? wordCountGreaterThan = null, int? wordCountLessThan = null, bool? isSpam = null, decimal? businessRelevanceGreaterThan = null, decimal? businessRelevanceLessThan = null, string nextPage = null)
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
            if (specificSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "specific_source", specificSource)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (topic != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "topic", topic)); // query parameter
            if (security != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "security", security)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (language != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (wordCountGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_greater_than", wordCountGreaterThan)); // query parameter
            if (wordCountLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "word_count_less_than", wordCountLessThan)); // query parameter
            if (isSpam != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_spam", isSpam)); // query parameter
            if (businessRelevanceGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_greater_than", businessRelevanceGreaterThan)); // query parameter
            if (businessRelevanceLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "business_relevance_less_than", businessRelevanceLessThan)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyNews", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyNews>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyNews) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyNews)));
        }

        /// <summary>
        /// News Article Body Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyNewsBody</returns>
        public ApiResponseCompanyNewsBody GetCompanyNewsBody (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNewsBody> localVarResponse = GetCompanyNewsBodyWithHttpInfo(newsStoryId, publicationDate, specificSource, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// News Article Body Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyNewsBody</returns>
        
        public ApiResponse< ApiResponseCompanyNewsBody > GetCompanyNewsBodyWithHttpInfo (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null)
        {
            // verify the required parameter 'newsStoryId' is set
            if (newsStoryId == null)
                throw new ApiException(400, "Missing required parameter 'newsStoryId' when calling CompanyApi->GetCompanyNewsBody");
            // verify the required parameter 'publicationDate' is set
            if (publicationDate == null)
                throw new ApiException(400, "Missing required parameter 'publicationDate' when calling CompanyApi->GetCompanyNewsBody");

            var localVarPath = "/companies/news/body";
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
            
            
            if (specificSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "specific_source", specificSource)); // query parameter
            if (newsStoryId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "news_story_id", newsStoryId)); // query parameter
            if (publicationDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "publication_date", publicationDate)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyNewsBody", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyNewsBody>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyNewsBody) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyNewsBody)));
        }

        /// <summary>
        /// News Article Body Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyNewsBody</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyNewsBody> GetCompanyNewsBodyAsync (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCompanyNewsBody> localVarResponse = await GetCompanyNewsBodyAsyncWithHttpInfo(newsStoryId, publicationDate, specificSource, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// News Article Body Returns the body of a news article for moody sources.  This endpoint requires additional authorization beyond basic news access and is for your internal use only - no display. Please see a representative for details.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newsStoryId">The identifier of the news story.</param>
        /// <param name="publicationDate">The DateTime of the story.</param>
        /// <param name="specificSource">Only news from this source. Defaults to highest available if not present. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyNewsBody)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyNewsBody>> GetCompanyNewsBodyAsyncWithHttpInfo (string newsStoryId, DateTime? publicationDate, string specificSource = null, string nextPage = null)
        {
            // verify the required parameter 'newsStoryId' is set
            if (newsStoryId == null)
                throw new ApiException(400, "Missing required parameter 'newsStoryId' when calling CompanyApi->GetCompanyNewsBody");
            // verify the required parameter 'publicationDate' is set
            if (publicationDate == null)
                throw new ApiException(400, "Missing required parameter 'publicationDate' when calling CompanyApi->GetCompanyNewsBody");

            var localVarPath = "/companies/news/body";
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
              

            if (specificSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "specific_source", specificSource)); // query parameter
            if (newsStoryId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "news_story_id", newsStoryId)); // query parameter
            if (publicationDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "publication_date", publicationDate)); // query parameter
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
                Exception exception = ExceptionFactory("GetCompanyNewsBody", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyNewsBody>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyNewsBody) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyNewsBody)));
        }

        /// <summary>
        /// Get Company&#39;s public float Returns a list of public float data tied to a given company identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCompanyPublicFloatResult</returns>
        public ApiResponseCompanyPublicFloatResult GetCompanyPublicFloat (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseCompanyPublicFloatResult> localVarResponse = GetCompanyPublicFloatWithHttpInfo(identifier, floatDateGreaterThan, floatDateLessThan, nextPage, nextPage2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Company&#39;s public float Returns a list of public float data tied to a given company identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanyPublicFloatResult</returns>
        
        public ApiResponse< ApiResponseCompanyPublicFloatResult > GetCompanyPublicFloatWithHttpInfo (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyPublicFloat");

            var localVarPath = "/companies/{identifier}/public_float";
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
            if (floatDateGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "float_date_greater_than", floatDateGreaterThan)); // query parameter
            if (floatDateLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "float_date_less_than", floatDateLessThan)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("GetCompanyPublicFloat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyPublicFloatResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyPublicFloatResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyPublicFloatResult)));
        }

        /// <summary>
        /// Get Company&#39;s public float Returns a list of public float data tied to a given company identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCompanyPublicFloatResult</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyPublicFloatResult> GetCompanyPublicFloatAsync (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseCompanyPublicFloatResult> localVarResponse = await GetCompanyPublicFloatAsyncWithHttpInfo(identifier, floatDateGreaterThan, floatDateLessThan, nextPage, nextPage2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Company&#39;s public float Returns a list of public float data tied to a given company identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="floatDateGreaterThan">The lower-bound date for the data being requested. (optional)</param>
        /// <param name="floatDateLessThan">The upper-bound date for the data being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyPublicFloatResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyPublicFloatResult>> GetCompanyPublicFloatAsyncWithHttpInfo (string identifier, DateTime? floatDateGreaterThan = null, DateTime? floatDateLessThan = null, string nextPage = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->GetCompanyPublicFloat");

            var localVarPath = "/companies/{identifier}/public_float";
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
            if (floatDateGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "float_date_greater_than", floatDateGreaterThan)); // query parameter
            if (floatDateLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "float_date_less_than", floatDateLessThan)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("GetCompanyPublicFloat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyPublicFloatResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyPublicFloatResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyPublicFloatResult)));
        }

        /// <summary>
        /// All Securities by Company Returns a list of underlying securities with associated reference data tied to a given company identifier.
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
        /// All Securities by Company Returns a list of underlying securities with associated reference data tied to a given company identifier.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanySecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanySecurities>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanySecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanySecurities)));
        }

        /// <summary>
        /// All Securities by Company Returns a list of underlying securities with associated reference data tied to a given company identifier.
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
        /// All Securities by Company Returns a list of underlying securities with associated reference data tied to a given company identifier.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCompanySecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanySecurities>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanySecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanySecurities)));
        }

        /// <summary>
        /// Insider Transaction Filings by Company Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseInsiderTransactionFilings</returns>
        public ApiResponseInsiderTransactionFilings InsiderTransactionFilingsByCompany (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseInsiderTransactionFilings> localVarResponse = InsiderTransactionFilingsByCompanyWithHttpInfo(identifier, startDate, endDate, ownershipType, nextPage, pageSize, sortBy, nextPage2);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Insider Transaction Filings by Company Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseInsiderTransactionFilings</returns>
        
        public ApiResponse< ApiResponseInsiderTransactionFilings > InsiderTransactionFilingsByCompanyWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->InsiderTransactionFilingsByCompany");

            var localVarPath = "/companies/{identifier}/insider_transaction_filings";
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
            if (ownershipType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ownership_type", ownershipType)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_by", sortBy)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("InsiderTransactionFilingsByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseInsiderTransactionFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseInsiderTransactionFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseInsiderTransactionFilings)));
        }

        /// <summary>
        /// Insider Transaction Filings by Company Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseInsiderTransactionFilings</returns>
        public async System.Threading.Tasks.Task<ApiResponseInsiderTransactionFilings> InsiderTransactionFilingsByCompanyAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null)
        {
             ApiResponse<ApiResponseInsiderTransactionFilings> localVarResponse = await InsiderTransactionFilingsByCompanyAsyncWithHttpInfo(identifier, startDate, endDate, ownershipType, nextPage, pageSize, sortBy, nextPage2);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Insider Transaction Filings by Company Returns a list of all insider transaction filings in a company. Criteria for being an insider include being a director, officer, or 10%+ owner in the company. Transactions are detailed for both non-derivative and derivative transactions by the insider.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="startDate">Return Company&#39;s insider transaction filings on or after this date (optional)</param>
        /// <param name="endDate">Return Company&#39;s insider transaction filings on or before this date (optional)</param>
        /// <param name="ownershipType">The type of ownership to return transaction filings for. &#39;D&#39; is for direct transactions. &#39;I&#39; is for indirect transactions. Omit for both types. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="sortBy">The field to sort by.  Default is &#39;filing_date&#39;. (optional)</param>
        /// <param name="nextPage2">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseInsiderTransactionFilings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseInsiderTransactionFilings>> InsiderTransactionFilingsByCompanyAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string ownershipType = null, string nextPage = null, int? pageSize = null, string sortBy = null, string nextPage2 = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->InsiderTransactionFilingsByCompany");

            var localVarPath = "/companies/{identifier}/insider_transaction_filings";
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
            if (ownershipType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ownership_type", ownershipType)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_by", sortBy)); // query parameter
            if (nextPage2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage2)); // query parameter

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
                Exception exception = ExceptionFactory("InsiderTransactionFilingsByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseInsiderTransactionFilings>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseInsiderTransactionFilings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseInsiderTransactionFilings)));
        }

        /// <summary>
        /// Latest Insider Transaction Filing by Company Returns the latest insider transaction filing for a company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InsiderTransactionFiling</returns>
        public InsiderTransactionFiling LatestInsiderTransactionFilingByCompany (string identifier, string nextPage = null)
        {
             ApiResponse<InsiderTransactionFiling> localVarResponse = LatestInsiderTransactionFilingByCompanyWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Latest Insider Transaction Filing by Company Returns the latest insider transaction filing for a company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InsiderTransactionFiling</returns>
        
        public ApiResponse< InsiderTransactionFiling > LatestInsiderTransactionFilingByCompanyWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->LatestInsiderTransactionFilingByCompany");

            var localVarPath = "/companies/{identifier}/insider_transaction_filings/latest";
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LatestInsiderTransactionFilingByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InsiderTransactionFiling>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (InsiderTransactionFiling) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InsiderTransactionFiling)));
        }

        /// <summary>
        /// Latest Insider Transaction Filing by Company Returns the latest insider transaction filing for a company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InsiderTransactionFiling</returns>
        public async System.Threading.Tasks.Task<InsiderTransactionFiling> LatestInsiderTransactionFilingByCompanyAsync (string identifier, string nextPage = null)
        {
             ApiResponse<InsiderTransactionFiling> localVarResponse = await LatestInsiderTransactionFilingByCompanyAsyncWithHttpInfo(identifier, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Latest Insider Transaction Filing by Company Returns the latest insider transaction filing for a company.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InsiderTransactionFiling)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InsiderTransactionFiling>> LatestInsiderTransactionFilingByCompanyAsyncWithHttpInfo (string identifier, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->LatestInsiderTransactionFilingByCompany");

            var localVarPath = "/companies/{identifier}/insider_transaction_filings/latest";
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LatestInsiderTransactionFilingByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InsiderTransactionFiling>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (InsiderTransactionFiling) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InsiderTransactionFiling)));
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LookupCompanyFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LookupCompanyFundamental", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Fundamental>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
        }

        /// <summary>
        /// Recognize Company Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>ApiResponseCompanyRecognize</returns>
        public ApiResponseCompanyRecognize RecognizeCompany (string text)
        {
             ApiResponse<ApiResponseCompanyRecognize> localVarResponse = RecognizeCompanyWithHttpInfo(text);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Recognize Company Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>ApiResponse of ApiResponseCompanyRecognize</returns>
        
        public ApiResponse< ApiResponseCompanyRecognize > RecognizeCompanyWithHttpInfo (string text)
        {
            // verify the required parameter 'text' is set
            if (text == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling CompanyApi->RecognizeCompany");

            var localVarPath = "/companies/recognize";
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
            
            
            if (text != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "text", text)); // query parameter

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
                Exception exception = ExceptionFactory("RecognizeCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyRecognize>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyRecognize) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyRecognize)));
        }

        /// <summary>
        /// Recognize Company Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>Task of ApiResponseCompanyRecognize</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanyRecognize> RecognizeCompanyAsync (string text)
        {
             ApiResponse<ApiResponseCompanyRecognize> localVarResponse = await RecognizeCompanyAsyncWithHttpInfo(text);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Recognize Company Returns a list of companies recognized by the Thea API in the given &#x60;text&#x60; query string parameter.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">The text sent to the Thea API to analyze</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanyRecognize)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanyRecognize>> RecognizeCompanyAsyncWithHttpInfo (string text)
        {
            // verify the required parameter 'text' is set
            if (text == null)
                throw new ApiException(400, "Missing required parameter 'text' when calling CompanyApi->RecognizeCompany");

            var localVarPath = "/companies/recognize";
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
              

            if (text != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "text", text)); // query parameter

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
                Exception exception = ExceptionFactory("RecognizeCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanyRecognize>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanyRecognize) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanyRecognize)));
        }

        /// <summary>
        /// Search Companies Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseCompaniesSearch</returns>
        public ApiResponseCompaniesSearch SearchCompanies (string query, bool? active = null, string mode = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseCompaniesSearch> localVarResponse = SearchCompaniesWithHttpInfo(query, active, mode, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Companies Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseCompaniesSearch</returns>
        
        public ApiResponse< ApiResponseCompaniesSearch > SearchCompaniesWithHttpInfo (string query, bool? active = null, string mode = null, int? pageSize = null)
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
            if (active != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active", active)); // query parameter
            if (mode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mode", mode)); // query parameter
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
                Exception exception = ExceptionFactory("SearchCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompaniesSearch>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompaniesSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompaniesSearch)));
        }

        /// <summary>
        /// Search Companies Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseCompaniesSearch</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompaniesSearch> SearchCompaniesAsync (string query, bool? active = null, string mode = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseCompaniesSearch> localVarResponse = await SearchCompaniesAsyncWithHttpInfo(query, active, mode, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Companies Search the companies database and return a list of companies matching the text query parameter passed through. Query parameter searches across the company ticker and name.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">Search parameters</param>
        /// <param name="active">When true, return companies that are actively traded (having stock prices within the past 14 days). When false, return companies that are not actively traded or never have been traded. Not setting this value returns all. Not used when mode is set. (optional)</param>
        /// <param name="mode">When set, changes search mode to the specified mode. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompaniesSearch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompaniesSearch>> SearchCompaniesAsyncWithHttpInfo (string query, bool? active = null, string mode = null, int? pageSize = null)
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
            if (active != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "active", active)); // query parameter
            if (mode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "mode", mode)); // query parameter
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
                Exception exception = ExceptionFactory("SearchCompanies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompaniesSearch>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompaniesSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompaniesSearch)));
        }

        /// <summary>
        /// Shares Outstanding by Company Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>ApiResponseCompanySharesOutstanding</returns>
        public ApiResponseCompanySharesOutstanding SharesOutstandingByCompany (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null)
        {
             ApiResponse<ApiResponseCompanySharesOutstanding> localVarResponse = SharesOutstandingByCompanyWithHttpInfo(identifier, endDateGreaterThan, endDateLessThan);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Shares Outstanding by Company Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCompanySharesOutstanding</returns>
        
        public ApiResponse< ApiResponseCompanySharesOutstanding > SharesOutstandingByCompanyWithHttpInfo (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->SharesOutstandingByCompany");

            var localVarPath = "/companies/{identifier}/shares_outstanding";
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
            if (endDateGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_greater_than", endDateGreaterThan)); // query parameter
            if (endDateLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_less_than", endDateLessThan)); // query parameter

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
                Exception exception = ExceptionFactory("SharesOutstandingByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanySharesOutstanding>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanySharesOutstanding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanySharesOutstanding)));
        }

        /// <summary>
        /// Shares Outstanding by Company Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>Task of ApiResponseCompanySharesOutstanding</returns>
        public async System.Threading.Tasks.Task<ApiResponseCompanySharesOutstanding> SharesOutstandingByCompanyAsync (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null)
        {
             ApiResponse<ApiResponseCompanySharesOutstanding> localVarResponse = await SharesOutstandingByCompanyAsyncWithHttpInfo(identifier, endDateGreaterThan, endDateLessThan);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Shares Outstanding by Company Returns the shares outstanding reported on the front cover of the SEC 10-K and 10-Q filings.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
        /// <param name="endDateGreaterThan">Returns shares outstanding after this date. (optional)</param>
        /// <param name="endDateLessThan">Returns shares outstanding before this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCompanySharesOutstanding)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCompanySharesOutstanding>> SharesOutstandingByCompanyAsyncWithHttpInfo (string identifier, DateTime? endDateGreaterThan = null, DateTime? endDateLessThan = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling CompanyApi->SharesOutstandingByCompany");

            var localVarPath = "/companies/{identifier}/shares_outstanding";
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
            if (endDateGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_greater_than", endDateGreaterThan)); // query parameter
            if (endDateLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_less_than", endDateLessThan)); // query parameter

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
                Exception exception = ExceptionFactory("SharesOutstandingByCompany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCompanySharesOutstanding>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseCompanySharesOutstanding) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCompanySharesOutstanding)));
        }

    }
}

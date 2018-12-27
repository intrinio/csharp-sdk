

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
    public interface ISecurityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// All Securities
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurities</returns>
        ApiResponseSecurities GetAllSecurities (string nextPage = null);

        /// <summary>
        /// All Securities
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurities</returns>
        ApiResponse<ApiResponseSecurities> GetAllSecuritiesWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Lookup Security
        /// </summary>
        /// <remarks>
        /// Returns the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Security</returns>
        Security GetSecurityById (string identifier);

        /// <summary>
        /// Lookup Security
        /// </summary>
        /// <remarks>
        /// Returns the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of Security</returns>
        ApiResponse<Security> GetSecurityByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Data Point (Number) for Security
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>decimal?</returns>
        decimal? GetSecurityDataPointNumber (string identifier, string tag);

        /// <summary>
        /// Data Point (Number) for Security
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of decimal?</returns>
        ApiResponse<decimal?> GetSecurityDataPointNumberWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Data Point (Text) for Security
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>string</returns>
        string GetSecurityDataPointText (string identifier, string tag);

        /// <summary>
        /// Data Point (Text) for Security
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetSecurityDataPointTextWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Historical Data for Security
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityHistoricalData</returns>
        ApiResponseSecurityHistoricalData GetSecurityHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Historical Data for Security
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityHistoricalData</returns>
        ApiResponse<ApiResponseSecurityHistoricalData> GetSecurityHistoricalDataWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// Lastest Dividend Record for Security
        /// </summary>
        /// <remarks>
        /// Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>DividendRecord</returns>
        DividendRecord GetSecurityLatestDividendRecord (string identifier);

        /// <summary>
        /// Lastest Dividend Record for Security
        /// </summary>
        /// <remarks>
        /// Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of DividendRecord</returns>
        ApiResponse<DividendRecord> GetSecurityLatestDividendRecordWithHttpInfo (string identifier);
        /// <summary>
        /// Lastest Earnings Record for Security
        /// </summary>
        /// <remarks>
        /// Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>EarningsRecord</returns>
        EarningsRecord GetSecurityLatestEarningsRecord (string identifier);

        /// <summary>
        /// Lastest Earnings Record for Security
        /// </summary>
        /// <remarks>
        /// Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of EarningsRecord</returns>
        ApiResponse<EarningsRecord> GetSecurityLatestEarningsRecordWithHttpInfo (string identifier);
        /// <summary>
        /// Realtime Stock Price for Security
        /// </summary>
        /// <remarks>
        /// Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>RealtimeStockPrice</returns>
        RealtimeStockPrice GetSecurityRealtimePrice (string identifier, string source = null);

        /// <summary>
        /// Realtime Stock Price for Security
        /// </summary>
        /// <remarks>
        /// Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>ApiResponse of RealtimeStockPrice</returns>
        ApiResponse<RealtimeStockPrice> GetSecurityRealtimePriceWithHttpInfo (string identifier, string source = null);
        /// <summary>
        /// Stock Price Adjustments by Security
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityStockPriceAdjustments</returns>
        ApiResponseSecurityStockPriceAdjustments GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Stock Price Adjustments by Security
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityStockPriceAdjustments</returns>
        ApiResponse<ApiResponseSecurityStockPriceAdjustments> GetSecurityStockPriceAdjustmentsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Stock Prices by Security
        /// </summary>
        /// <remarks>
        /// Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityStockPrices</returns>
        ApiResponseSecurityStockPrices GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);

        /// <summary>
        /// Stock Prices by Security
        /// </summary>
        /// <remarks>
        /// Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityStockPrices</returns>
        ApiResponse<ApiResponseSecurityStockPrices> GetSecurityStockPricesWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);
        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen Securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>List&lt;SecurityScreenResult&gt;</returns>
        List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);

        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen Securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;SecurityScreenResult&gt;</returns>
        ApiResponse<List<SecurityScreenResult>> ScreenSecuritiesWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);
        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponseSecurities</returns>
        ApiResponseSecurities SearchSecurities (string query);

        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponse of ApiResponseSecurities</returns>
        ApiResponse<ApiResponseSecurities> SearchSecuritiesWithHttpInfo (string query);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// All Securities
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurities</returns>
        System.Threading.Tasks.Task<ApiResponseSecurities> GetAllSecuritiesAsync (string nextPage = null);

        /// <summary>
        /// All Securities
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurities)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurities>> GetAllSecuritiesAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Lookup Security
        /// </summary>
        /// <remarks>
        /// Returns the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of Security</returns>
        System.Threading.Tasks.Task<Security> GetSecurityByIdAsync (string identifier);

        /// <summary>
        /// Lookup Security
        /// </summary>
        /// <remarks>
        /// Returns the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Security)</returns>
        System.Threading.Tasks.Task<ApiResponse<Security>> GetSecurityByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Data Point (Number) for Security
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of decimal?</returns>
        System.Threading.Tasks.Task<decimal?> GetSecurityDataPointNumberAsync (string identifier, string tag);

        /// <summary>
        /// Data Point (Number) for Security
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (decimal?)</returns>
        System.Threading.Tasks.Task<ApiResponse<decimal?>> GetSecurityDataPointNumberAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Data Point (Text) for Security
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetSecurityDataPointTextAsync (string identifier, string tag);

        /// <summary>
        /// Data Point (Text) for Security
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetSecurityDataPointTextAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Historical Data for Security
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityHistoricalData</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityHistoricalData> GetSecurityHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Historical Data for Security
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityHistoricalData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityHistoricalData>> GetSecurityHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// Lastest Dividend Record for Security
        /// </summary>
        /// <remarks>
        /// Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of DividendRecord</returns>
        System.Threading.Tasks.Task<DividendRecord> GetSecurityLatestDividendRecordAsync (string identifier);

        /// <summary>
        /// Lastest Dividend Record for Security
        /// </summary>
        /// <remarks>
        /// Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (DividendRecord)</returns>
        System.Threading.Tasks.Task<ApiResponse<DividendRecord>> GetSecurityLatestDividendRecordAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Lastest Earnings Record for Security
        /// </summary>
        /// <remarks>
        /// Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of EarningsRecord</returns>
        System.Threading.Tasks.Task<EarningsRecord> GetSecurityLatestEarningsRecordAsync (string identifier);

        /// <summary>
        /// Lastest Earnings Record for Security
        /// </summary>
        /// <remarks>
        /// Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (EarningsRecord)</returns>
        System.Threading.Tasks.Task<ApiResponse<EarningsRecord>> GetSecurityLatestEarningsRecordAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Realtime Stock Price for Security
        /// </summary>
        /// <remarks>
        /// Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>Task of RealtimeStockPrice</returns>
        System.Threading.Tasks.Task<RealtimeStockPrice> GetSecurityRealtimePriceAsync (string identifier, string source = null);

        /// <summary>
        /// Realtime Stock Price for Security
        /// </summary>
        /// <remarks>
        /// Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>Task of ApiResponse (RealtimeStockPrice)</returns>
        System.Threading.Tasks.Task<ApiResponse<RealtimeStockPrice>> GetSecurityRealtimePriceAsyncWithHttpInfo (string identifier, string source = null);
        /// <summary>
        /// Stock Price Adjustments by Security
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityStockPriceAdjustments</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityStockPriceAdjustments> GetSecurityStockPriceAdjustmentsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Stock Price Adjustments by Security
        /// </summary>
        /// <remarks>
        /// Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityStockPriceAdjustments)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityStockPriceAdjustments>> GetSecurityStockPriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Stock Prices by Security
        /// </summary>
        /// <remarks>
        /// Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityStockPrices</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityStockPrices> GetSecurityStockPricesAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);

        /// <summary>
        /// Stock Prices by Security
        /// </summary>
        /// <remarks>
        /// Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityStockPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityStockPrices>> GetSecurityStockPricesAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);
        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen Securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of List&lt;SecurityScreenResult&gt;</returns>
        System.Threading.Tasks.Task<List<SecurityScreenResult>> ScreenSecuritiesAsync (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);

        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen Securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of ApiResponse (List&lt;SecurityScreenResult&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SecurityScreenResult>>> ScreenSecuritiesAsyncWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);
        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponseSecurities</returns>
        System.Threading.Tasks.Task<ApiResponseSecurities> SearchSecuritiesAsync (string query);

        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (ApiResponseSecurities)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurities>> SearchSecuritiesAsyncWithHttpInfo (string query);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SecurityApi : ISecurityApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SecurityApi(Configuration configuration = null)
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
        /// All Securities 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurities</returns>
        public ApiResponseSecurities GetAllSecurities (string nextPage = null)
        {
             ApiResponse<ApiResponseSecurities> localVarResponse = GetAllSecuritiesWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All Securities 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurities</returns>
        public ApiResponse< ApiResponseSecurities > GetAllSecuritiesWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/securities";
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
                Exception exception = ExceptionFactory("GetAllSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurities>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurities)));
        }

        /// <summary>
        /// All Securities 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurities</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurities> GetAllSecuritiesAsync (string nextPage = null)
        {
             ApiResponse<ApiResponseSecurities> localVarResponse = await GetAllSecuritiesAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All Securities 
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurities)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurities>> GetAllSecuritiesAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/securities";
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
                Exception exception = ExceptionFactory("GetAllSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurities>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurities)));
        }

        /// <summary>
        /// Lookup Security Returns the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Security</returns>
        public Security GetSecurityById (string identifier)
        {
             ApiResponse<Security> localVarResponse = GetSecurityByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup Security Returns the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of Security</returns>
        public ApiResponse< Security > GetSecurityByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityById");

            var localVarPath = "/securities/{identifier}";
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
                Exception exception = ExceptionFactory("GetSecurityById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Security>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Security) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Security)));
        }

        /// <summary>
        /// Lookup Security Returns the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of Security</returns>
        public async System.Threading.Tasks.Task<Security> GetSecurityByIdAsync (string identifier)
        {
             ApiResponse<Security> localVarResponse = await GetSecurityByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup Security Returns the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Security)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Security>> GetSecurityByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityById");

            var localVarPath = "/securities/{identifier}";
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
                Exception exception = ExceptionFactory("GetSecurityById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Security>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Security) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Security)));
        }

        /// <summary>
        /// Data Point (Number) for Security Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>decimal?</returns>
        public decimal? GetSecurityDataPointNumber (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = GetSecurityDataPointNumberWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Data Point (Number) for Security Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of decimal?</returns>
        public ApiResponse< decimal? > GetSecurityDataPointNumberWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointNumber");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/number";
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
                Exception exception = ExceptionFactory("GetSecurityDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Number) for Security Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of decimal?</returns>
        public async System.Threading.Tasks.Task<decimal?> GetSecurityDataPointNumberAsync (string identifier, string tag)
        {
             ApiResponse<decimal?> localVarResponse = await GetSecurityDataPointNumberAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Data Point (Number) for Security Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (decimal?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<decimal?>> GetSecurityDataPointNumberAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointNumber");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/number";
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
                Exception exception = ExceptionFactory("GetSecurityDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<decimal?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (decimal?) Configuration.ApiClient.Deserialize(localVarResponse, typeof(decimal?)));
        }

        /// <summary>
        /// Data Point (Text) for Security Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>string</returns>
        public string GetSecurityDataPointText (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = GetSecurityDataPointTextWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Data Point (Text) for Security Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetSecurityDataPointTextWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointText");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/text";
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
                Exception exception = ExceptionFactory("GetSecurityDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Data Point (Text) for Security Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetSecurityDataPointTextAsync (string identifier, string tag)
        {
             ApiResponse<string> localVarResponse = await GetSecurityDataPointTextAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Data Point (Text) for Security Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetSecurityDataPointTextAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointText");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/text";
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
                Exception exception = ExceptionFactory("GetSecurityDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Historical Data for Security Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityHistoricalData</returns>
        public ApiResponseSecurityHistoricalData GetSecurityHistoricalData (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityHistoricalData> localVarResponse = GetSecurityHistoricalDataWithHttpInfo(identifier, tag, frequency, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Historical Data for Security Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityHistoricalData</returns>
        public ApiResponse< ApiResponseSecurityHistoricalData > GetSecurityHistoricalDataWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityHistoricalData");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityHistoricalData");

            var localVarPath = "/securities/{identifier}/historical_data/{tag}";
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
                Exception exception = ExceptionFactory("GetSecurityHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityHistoricalData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityHistoricalData)));
        }

        /// <summary>
        /// Historical Data for Security Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityHistoricalData</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityHistoricalData> GetSecurityHistoricalDataAsync (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityHistoricalData> localVarResponse = await GetSecurityHistoricalDataAsyncWithHttpInfo(identifier, tag, frequency, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Historical Data for Security Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityHistoricalData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityHistoricalData>> GetSecurityHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityHistoricalData");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityHistoricalData");

            var localVarPath = "/securities/{identifier}/historical_data/{tag}";
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
                Exception exception = ExceptionFactory("GetSecurityHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityHistoricalData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityHistoricalData)));
        }

        /// <summary>
        /// Lastest Dividend Record for Security Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>DividendRecord</returns>
        public DividendRecord GetSecurityLatestDividendRecord (string identifier)
        {
             ApiResponse<DividendRecord> localVarResponse = GetSecurityLatestDividendRecordWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lastest Dividend Record for Security Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of DividendRecord</returns>
        public ApiResponse< DividendRecord > GetSecurityLatestDividendRecordWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityLatestDividendRecord");

            var localVarPath = "/securities/{identifier}/dividends/latest";
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
                Exception exception = ExceptionFactory("GetSecurityLatestDividendRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DividendRecord>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividendRecord) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividendRecord)));
        }

        /// <summary>
        /// Lastest Dividend Record for Security Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of DividendRecord</returns>
        public async System.Threading.Tasks.Task<DividendRecord> GetSecurityLatestDividendRecordAsync (string identifier)
        {
             ApiResponse<DividendRecord> localVarResponse = await GetSecurityLatestDividendRecordAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lastest Dividend Record for Security Returns the latest available dividend information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (DividendRecord)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DividendRecord>> GetSecurityLatestDividendRecordAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityLatestDividendRecord");

            var localVarPath = "/securities/{identifier}/dividends/latest";
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
                Exception exception = ExceptionFactory("GetSecurityLatestDividendRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DividendRecord>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DividendRecord) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DividendRecord)));
        }

        /// <summary>
        /// Lastest Earnings Record for Security Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>EarningsRecord</returns>
        public EarningsRecord GetSecurityLatestEarningsRecord (string identifier)
        {
             ApiResponse<EarningsRecord> localVarResponse = GetSecurityLatestEarningsRecordWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lastest Earnings Record for Security Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of EarningsRecord</returns>
        public ApiResponse< EarningsRecord > GetSecurityLatestEarningsRecordWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityLatestEarningsRecord");

            var localVarPath = "/securities/{identifier}/earnings/latest";
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
                Exception exception = ExceptionFactory("GetSecurityLatestEarningsRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EarningsRecord>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EarningsRecord) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EarningsRecord)));
        }

        /// <summary>
        /// Lastest Earnings Record for Security Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of EarningsRecord</returns>
        public async System.Threading.Tasks.Task<EarningsRecord> GetSecurityLatestEarningsRecordAsync (string identifier)
        {
             ApiResponse<EarningsRecord> localVarResponse = await GetSecurityLatestEarningsRecordAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lastest Earnings Record for Security Returns latest available earnings information for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (EarningsRecord)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EarningsRecord>> GetSecurityLatestEarningsRecordAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityLatestEarningsRecord");

            var localVarPath = "/securities/{identifier}/earnings/latest";
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
                Exception exception = ExceptionFactory("GetSecurityLatestEarningsRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EarningsRecord>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EarningsRecord) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EarningsRecord)));
        }

        /// <summary>
        /// Realtime Stock Price for Security Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>RealtimeStockPrice</returns>
        public RealtimeStockPrice GetSecurityRealtimePrice (string identifier, string source = null)
        {
             ApiResponse<RealtimeStockPrice> localVarResponse = GetSecurityRealtimePriceWithHttpInfo(identifier, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realtime Stock Price for Security Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>ApiResponse of RealtimeStockPrice</returns>
        public ApiResponse< RealtimeStockPrice > GetSecurityRealtimePriceWithHttpInfo (string identifier, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityRealtimePrice");

            var localVarPath = "/securities/{identifier}/prices/realtime";
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
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

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
                Exception exception = ExceptionFactory("GetSecurityRealtimePrice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RealtimeStockPrice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RealtimeStockPrice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RealtimeStockPrice)));
        }

        /// <summary>
        /// Realtime Stock Price for Security Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>Task of RealtimeStockPrice</returns>
        public async System.Threading.Tasks.Task<RealtimeStockPrice> GetSecurityRealtimePriceAsync (string identifier, string source = null)
        {
             ApiResponse<RealtimeStockPrice> localVarResponse = await GetSecurityRealtimePriceAsyncWithHttpInfo(identifier, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realtime Stock Price for Security Return the realtime stock price for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="source">Return the realtime price from the specified data source (optional)</param>
        /// <returns>Task of ApiResponse (RealtimeStockPrice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RealtimeStockPrice>> GetSecurityRealtimePriceAsyncWithHttpInfo (string identifier, string source = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityRealtimePrice");

            var localVarPath = "/securities/{identifier}/prices/realtime";
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
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

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
                Exception exception = ExceptionFactory("GetSecurityRealtimePrice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RealtimeStockPrice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RealtimeStockPrice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RealtimeStockPrice)));
        }

        /// <summary>
        /// Stock Price Adjustments by Security Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityStockPriceAdjustments</returns>
        public ApiResponseSecurityStockPriceAdjustments GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityStockPriceAdjustments> localVarResponse = GetSecurityStockPriceAdjustmentsWithHttpInfo(identifier, startDate, endDate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stock Price Adjustments by Security Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityStockPriceAdjustments</returns>
        public ApiResponse< ApiResponseSecurityStockPriceAdjustments > GetSecurityStockPriceAdjustmentsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPriceAdjustments");

            var localVarPath = "/securities/{identifier}/prices/adjustments";
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
                Exception exception = ExceptionFactory("GetSecurityStockPriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStockPriceAdjustments)));
        }

        /// <summary>
        /// Stock Price Adjustments by Security Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityStockPriceAdjustments</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityStockPriceAdjustments> GetSecurityStockPriceAdjustmentsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityStockPriceAdjustments> localVarResponse = await GetSecurityStockPriceAdjustmentsAsyncWithHttpInfo(identifier, startDate, endDate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stock Price Adjustments by Security Returns stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityStockPriceAdjustments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityStockPriceAdjustments>> GetSecurityStockPriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPriceAdjustments");

            var localVarPath = "/securities/{identifier}/prices/adjustments";
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
                Exception exception = ExceptionFactory("GetSecurityStockPriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStockPriceAdjustments>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityStockPriceAdjustments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStockPriceAdjustments)));
        }

        /// <summary>
        /// Stock Prices by Security Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityStockPrices</returns>
        public ApiResponseSecurityStockPrices GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityStockPrices> localVarResponse = GetSecurityStockPricesWithHttpInfo(identifier, startDate, endDate, frequency, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stock Prices by Security Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityStockPrices</returns>
        public ApiResponse< ApiResponseSecurityStockPrices > GetSecurityStockPricesWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPrices");

            var localVarPath = "/securities/{identifier}/prices";
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
            if (frequency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityStockPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStockPrices>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityStockPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStockPrices)));
        }

        /// <summary>
        /// Stock Prices by Security Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityStockPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityStockPrices> GetSecurityStockPricesAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityStockPrices> localVarResponse = await GetSecurityStockPricesAsyncWithHttpInfo(identifier, startDate, endDate, frequency, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stock Prices by Security Return end-of-day stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityStockPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityStockPrices>> GetSecurityStockPricesAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPrices");

            var localVarPath = "/securities/{identifier}/prices";
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
            if (frequency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityStockPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStockPrices>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityStockPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStockPrices)));
        }

        /// <summary>
        /// Screen Securities Screen Securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>List&lt;SecurityScreenResult&gt;</returns>
        public List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {
             ApiResponse<List<SecurityScreenResult>> localVarResponse = ScreenSecuritiesWithHttpInfo(logic, orderColumn, orderDirection, primaryOnly);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Screen Securities Screen Securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;SecurityScreenResult&gt;</returns>
        public ApiResponse< List<SecurityScreenResult> > ScreenSecuritiesWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {

            var localVarPath = "/securities/screen";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (orderColumn != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_column", orderColumn)); // query parameter
            if (orderDirection != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_direction", orderDirection)); // query parameter
            if (primaryOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "primary_only", primaryOnly)); // query parameter
            if (logic != null && logic.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logic); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logic; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScreenSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityScreenResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityScreenResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityScreenResult>)));
        }

        /// <summary>
        /// Screen Securities Screen Securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of List&lt;SecurityScreenResult&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityScreenResult>> ScreenSecuritiesAsync (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {
             ApiResponse<List<SecurityScreenResult>> localVarResponse = await ScreenSecuritiesAsyncWithHttpInfo(logic, orderColumn, orderDirection, primaryOnly);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Screen Securities Screen Securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups.&lt;br/&gt; See &lt;a href&#x3D;\&quot;/documentation/screener_v2\&quot; target&#x3D;\&quot;_blank\&quot;&gt;screener documentation&lt;/a&gt; for details on how to construct conditions. (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of ApiResponse (List&lt;SecurityScreenResult&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SecurityScreenResult>>> ScreenSecuritiesAsyncWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {

            var localVarPath = "/securities/screen";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (orderColumn != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_column", orderColumn)); // query parameter
            if (orderDirection != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_direction", orderDirection)); // query parameter
            if (primaryOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "primary_only", primaryOnly)); // query parameter
            if (logic != null && logic.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logic); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logic; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScreenSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityScreenResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityScreenResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityScreenResult>)));
        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponseSecurities</returns>
        public ApiResponseSecurities SearchSecurities (string query)
        {
             ApiResponse<ApiResponseSecurities> localVarResponse = SearchSecuritiesWithHttpInfo(query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponse of ApiResponseSecurities</returns>
        public ApiResponse< ApiResponseSecurities > SearchSecuritiesWithHttpInfo (string query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SecurityApi->SearchSecurities");

            var localVarPath = "/securities/search";
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
                Exception exception = ExceptionFactory("SearchSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurities>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurities)));
        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponseSecurities</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurities> SearchSecuritiesAsync (string query)
        {
             ApiResponse<ApiResponseSecurities> localVarResponse = await SearchSecuritiesAsyncWithHttpInfo(query);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (ApiResponseSecurities)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurities>> SearchSecuritiesAsyncWithHttpInfo (string query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SecurityApi->SearchSecurities");

            var localVarPath = "/securities/search";
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
                Exception exception = ExceptionFactory("SearchSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurities>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurities) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurities)));
        }

    }
}

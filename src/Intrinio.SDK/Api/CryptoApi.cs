

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
    public interface ICryptoApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Crypto Book Asks
        /// </summary>
        /// <remarks>
        /// Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoBookAsks</returns>
        ApiResponseCryptoBookAsks GetCryptoBookAsks (string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Book Asks
        /// </summary>
        /// <remarks>
        /// Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoBookAsks</returns>
        ApiResponse<ApiResponseCryptoBookAsks> GetCryptoBookAsksWithHttpInfo (string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Book Bids
        /// </summary>
        /// <remarks>
        /// Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoBookBids</returns>
        ApiResponseCryptoBookBids GetCryptoBookBids (string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Book Bids
        /// </summary>
        /// <remarks>
        /// Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoBookBids</returns>
        ApiResponse<ApiResponseCryptoBookBids> GetCryptoBookBidsWithHttpInfo (string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Book Summary
        /// </summary>
        /// <remarks>
        /// Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoBook</returns>
        ApiResponseCryptoBook GetCryptoBookSummary (int? levels = null, string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Book Summary
        /// </summary>
        /// <remarks>
        /// Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoBook</returns>
        ApiResponse<ApiResponseCryptoBook> GetCryptoBookSummaryWithHttpInfo (int? levels = null, string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponseCryptoCurrencies</returns>
        ApiResponseCryptoCurrencies GetCryptoCurrencies (string exchange = null);

        /// <summary>
        /// Crypto Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoCurrencies</returns>
        ApiResponse<ApiResponseCryptoCurrencies> GetCryptoCurrenciesWithHttpInfo (string exchange = null);
        /// <summary>
        /// Crypto Exchanges
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Exchanges for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponseCryptoExchanges</returns>
        ApiResponseCryptoExchanges GetCryptoExchanges (string pair = null);

        /// <summary>
        /// Crypto Exchanges
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Exchanges for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoExchanges</returns>
        ApiResponse<ApiResponseCryptoExchanges> GetCryptoExchangesWithHttpInfo (string pair = null);
        /// <summary>
        /// Crypto Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currency Pairs for which data is available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCryptoPairs</returns>
        ApiResponseCryptoPairs GetCryptoPairs (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Crypto Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currency Pairs for which data is available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoPairs</returns>
        ApiResponse<ApiResponseCryptoPairs> GetCryptoPairsWithHttpInfo (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Crypto Prices
        /// </summary>
        /// <remarks>
        /// Returns a list of available Crypto Currency Prices.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCryptoPrices</returns>
        ApiResponseCryptoPrices GetCryptoPrices (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Crypto Prices
        /// </summary>
        /// <remarks>
        /// Returns a list of available Crypto Currency Prices.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoPrices</returns>
        ApiResponse<ApiResponseCryptoPrices> GetCryptoPricesWithHttpInfo (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Crypto Snapshot
        /// </summary>
        /// <remarks>
        /// Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoSnapshot</returns>
        ApiResponseCryptoSnapshot GetCryptoSnapshot (string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Snapshot
        /// </summary>
        /// <remarks>
        /// Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoSnapshot</returns>
        ApiResponse<ApiResponseCryptoSnapshot> GetCryptoSnapshotWithHttpInfo (string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Stats
        /// </summary>
        /// <remarks>
        /// Returns available stats on Crypto Currencies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoStats</returns>
        ApiResponseCryptoStats GetCryptoStats (string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Stats
        /// </summary>
        /// <remarks>
        /// Returns available stats on Crypto Currencies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoStats</returns>
        ApiResponse<ApiResponseCryptoStats> GetCryptoStatsWithHttpInfo (string exchange = null, string currency = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Crypto Book Asks
        /// </summary>
        /// <remarks>
        /// Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoBookAsks</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoBookAsks> GetCryptoBookAsksAsync (string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Book Asks
        /// </summary>
        /// <remarks>
        /// Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoBookAsks)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoBookAsks>> GetCryptoBookAsksAsyncWithHttpInfo (string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Book Bids
        /// </summary>
        /// <remarks>
        /// Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoBookBids</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoBookBids> GetCryptoBookBidsAsync (string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Book Bids
        /// </summary>
        /// <remarks>
        /// Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoBookBids)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoBookBids>> GetCryptoBookBidsAsyncWithHttpInfo (string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Book Summary
        /// </summary>
        /// <remarks>
        /// Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoBook</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoBook> GetCryptoBookSummaryAsync (int? levels = null, string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Book Summary
        /// </summary>
        /// <remarks>
        /// Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoBook)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoBook>> GetCryptoBookSummaryAsyncWithHttpInfo (int? levels = null, string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponseCryptoCurrencies</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoCurrencies> GetCryptoCurrenciesAsync (string exchange = null);

        /// <summary>
        /// Crypto Currencies
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currencies for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoCurrencies)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoCurrencies>> GetCryptoCurrenciesAsyncWithHttpInfo (string exchange = null);
        /// <summary>
        /// Crypto Exchanges
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Exchanges for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponseCryptoExchanges</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoExchanges> GetCryptoExchangesAsync (string pair = null);

        /// <summary>
        /// Crypto Exchanges
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Exchanges for which prices are available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoExchanges)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoExchanges>> GetCryptoExchangesAsyncWithHttpInfo (string pair = null);
        /// <summary>
        /// Crypto Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currency Pairs for which data is available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCryptoPairs</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoPairs> GetCryptoPairsAsync (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Crypto Pairs
        /// </summary>
        /// <remarks>
        /// Returns a list of Crypto Currency Pairs for which data is available.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoPairs)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoPairs>> GetCryptoPairsAsyncWithHttpInfo (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Crypto Prices
        /// </summary>
        /// <remarks>
        /// Returns a list of available Crypto Currency Prices.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCryptoPrices</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoPrices> GetCryptoPricesAsync (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Crypto Prices
        /// </summary>
        /// <remarks>
        /// Returns a list of available Crypto Currency Prices.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoPrices>> GetCryptoPricesAsyncWithHttpInfo (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Crypto Snapshot
        /// </summary>
        /// <remarks>
        /// Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoSnapshot</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoSnapshot> GetCryptoSnapshotAsync (string pair = null, string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Snapshot
        /// </summary>
        /// <remarks>
        /// Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoSnapshot)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoSnapshot>> GetCryptoSnapshotAsyncWithHttpInfo (string pair = null, string exchange = null, string currency = null);
        /// <summary>
        /// Crypto Stats
        /// </summary>
        /// <remarks>
        /// Returns available stats on Crypto Currencies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoStats</returns>
        System.Threading.Tasks.Task<ApiResponseCryptoStats> GetCryptoStatsAsync (string exchange = null, string currency = null);

        /// <summary>
        /// Crypto Stats
        /// </summary>
        /// <remarks>
        /// Returns available stats on Crypto Currencies.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoStats)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoStats>> GetCryptoStatsAsyncWithHttpInfo (string exchange = null, string currency = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CryptoApi : ICryptoApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CryptoApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CryptoApi(Configuration configuration = null)
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
        /// Crypto Book Asks Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoBookAsks</returns>
        public ApiResponseCryptoBookAsks GetCryptoBookAsks (string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoBookAsks> localVarResponse = GetCryptoBookAsksWithHttpInfo(pair, exchange, currency);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Book Asks Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoBookAsks</returns>
        public ApiResponse< ApiResponseCryptoBookAsks > GetCryptoBookAsksWithHttpInfo (string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/book/asks";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoBookAsks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoBookAsks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoBookAsks) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoBookAsks)));
        }

        /// <summary>
        /// Crypto Book Asks Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoBookAsks</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoBookAsks> GetCryptoBookAsksAsync (string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoBookAsks> localVarResponse = await GetCryptoBookAsksAsyncWithHttpInfo(pair, exchange, currency);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Book Asks Returns the entire ask order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book asks for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book asks for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book asks for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoBookAsks)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoBookAsks>> GetCryptoBookAsksAsyncWithHttpInfo (string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/book/asks";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoBookAsks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoBookAsks>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoBookAsks) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoBookAsks)));
        }

        /// <summary>
        /// Crypto Book Bids Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoBookBids</returns>
        public ApiResponseCryptoBookBids GetCryptoBookBids (string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoBookBids> localVarResponse = GetCryptoBookBidsWithHttpInfo(pair, exchange, currency);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Book Bids Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoBookBids</returns>
        public ApiResponse< ApiResponseCryptoBookBids > GetCryptoBookBidsWithHttpInfo (string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/book/bids";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoBookBids", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoBookBids>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoBookBids) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoBookBids)));
        }

        /// <summary>
        /// Crypto Book Bids Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoBookBids</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoBookBids> GetCryptoBookBidsAsync (string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoBookBids> localVarResponse = await GetCryptoBookBidsAsyncWithHttpInfo(pair, exchange, currency);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Book Bids Returns the entire bid order book for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the order book bids for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book bids for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book bids for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoBookBids)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoBookBids>> GetCryptoBookBidsAsyncWithHttpInfo (string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/book/bids";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoBookBids", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoBookBids>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoBookBids) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoBookBids)));
        }

        /// <summary>
        /// Crypto Book Summary Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoBook</returns>
        public ApiResponseCryptoBook GetCryptoBookSummary (int? levels = null, string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoBook> localVarResponse = GetCryptoBookSummaryWithHttpInfo(levels, pair, exchange, currency);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Book Summary Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoBook</returns>
        public ApiResponse< ApiResponseCryptoBook > GetCryptoBookSummaryWithHttpInfo (int? levels = null, string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/book";
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

            if (levels != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "levels", levels)); // query parameter
            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoBookSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoBook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoBook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoBook)));
        }

        /// <summary>
        /// Crypto Book Summary Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoBook</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoBook> GetCryptoBookSummaryAsync (int? levels = null, string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoBook> localVarResponse = await GetCryptoBookSummaryAsyncWithHttpInfo(levels, pair, exchange, currency);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Book Summary Returns the order book summary (bid/ask prices and size) for a given Crypto Currency Pair and Crypto Exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="levels">The number of prices/levels to return on each side. For example, the max of 50 levels will return up to 50 bid prices and 50 ask prices. (optional)</param>
        /// <param name="pair">Return the order book summary for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the order book summary for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the order book summary for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoBook)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoBook>> GetCryptoBookSummaryAsyncWithHttpInfo (int? levels = null, string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/book";
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

            if (levels != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "levels", levels)); // query parameter
            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoBookSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoBook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoBook) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoBook)));
        }

        /// <summary>
        /// Crypto Currencies Returns a list of Crypto Currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponseCryptoCurrencies</returns>
        public ApiResponseCryptoCurrencies GetCryptoCurrencies (string exchange = null)
        {
             ApiResponse<ApiResponseCryptoCurrencies> localVarResponse = GetCryptoCurrenciesWithHttpInfo(exchange);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Currencies Returns a list of Crypto Currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoCurrencies</returns>
        public ApiResponse< ApiResponseCryptoCurrencies > GetCryptoCurrenciesWithHttpInfo (string exchange = null)
        {

            var localVarPath = "/crypto/currencies";
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

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoCurrencies>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoCurrencies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoCurrencies)));
        }

        /// <summary>
        /// Crypto Currencies Returns a list of Crypto Currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponseCryptoCurrencies</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoCurrencies> GetCryptoCurrenciesAsync (string exchange = null)
        {
             ApiResponse<ApiResponseCryptoCurrencies> localVarResponse = await GetCryptoCurrenciesAsyncWithHttpInfo(exchange);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Currencies Returns a list of Crypto Currencies for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoCurrencies)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoCurrencies>> GetCryptoCurrenciesAsyncWithHttpInfo (string exchange = null)
        {

            var localVarPath = "/crypto/currencies";
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

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoCurrencies>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoCurrencies) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoCurrencies)));
        }

        /// <summary>
        /// Crypto Exchanges Returns a list of Crypto Exchanges for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponseCryptoExchanges</returns>
        public ApiResponseCryptoExchanges GetCryptoExchanges (string pair = null)
        {
             ApiResponse<ApiResponseCryptoExchanges> localVarResponse = GetCryptoExchangesWithHttpInfo(pair);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Exchanges Returns a list of Crypto Exchanges for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoExchanges</returns>
        public ApiResponse< ApiResponseCryptoExchanges > GetCryptoExchangesWithHttpInfo (string pair = null)
        {

            var localVarPath = "/crypto/exchanges";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoExchanges>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoExchanges) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoExchanges)));
        }

        /// <summary>
        /// Crypto Exchanges Returns a list of Crypto Exchanges for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponseCryptoExchanges</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoExchanges> GetCryptoExchangesAsync (string pair = null)
        {
             ApiResponse<ApiResponseCryptoExchanges> localVarResponse = await GetCryptoExchangesAsyncWithHttpInfo(pair);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Exchanges Returns a list of Crypto Exchanges for which prices are available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Returns Crypto Currencies traded on the given Crypto Exchange. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoExchanges)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoExchanges>> GetCryptoExchangesAsyncWithHttpInfo (string pair = null)
        {

            var localVarPath = "/crypto/exchanges";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoExchanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoExchanges>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoExchanges) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoExchanges)));
        }

        /// <summary>
        /// Crypto Pairs Returns a list of Crypto Currency Pairs for which data is available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCryptoPairs</returns>
        public ApiResponseCryptoPairs GetCryptoPairs (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCryptoPairs> localVarResponse = GetCryptoPairsWithHttpInfo(exchange, currency, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Pairs Returns a list of Crypto Currency Pairs for which data is available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoPairs</returns>
        public ApiResponse< ApiResponseCryptoPairs > GetCryptoPairsWithHttpInfo (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/crypto/pairs";
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

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
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
                Exception exception = ExceptionFactory("GetCryptoPairs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoPairs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoPairs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoPairs)));
        }

        /// <summary>
        /// Crypto Pairs Returns a list of Crypto Currency Pairs for which data is available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCryptoPairs</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoPairs> GetCryptoPairsAsync (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCryptoPairs> localVarResponse = await GetCryptoPairsAsyncWithHttpInfo(exchange, currency, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Pairs Returns a list of Crypto Currency Pairs for which data is available.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Return pairs traded on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return pairs with one side being the given Crypto Currency. (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoPairs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoPairs>> GetCryptoPairsAsyncWithHttpInfo (string exchange = null, string currency = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/crypto/pairs";
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

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
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
                Exception exception = ExceptionFactory("GetCryptoPairs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoPairs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoPairs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoPairs)));
        }

        /// <summary>
        /// Crypto Prices Returns a list of available Crypto Currency Prices.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseCryptoPrices</returns>
        public ApiResponseCryptoPrices GetCryptoPrices (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCryptoPrices> localVarResponse = GetCryptoPricesWithHttpInfo(timeframe, pair, exchange, currency, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Prices Returns a list of available Crypto Currency Prices.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoPrices</returns>
        public ApiResponse< ApiResponseCryptoPrices > GetCryptoPricesWithHttpInfo (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'timeframe' is set
            if (timeframe == null)
                throw new ApiException(400, "Missing required parameter 'timeframe' when calling CryptoApi->GetCryptoPrices");

            var localVarPath = "/crypto/prices";
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

            if (timeframe != null) localVarPathParams.Add("timeframe", Configuration.ApiClient.ParameterToString(timeframe)); // path parameter
            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
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
                Exception exception = ExceptionFactory("GetCryptoPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoPrices>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoPrices)));
        }

        /// <summary>
        /// Crypto Prices Returns a list of available Crypto Currency Prices.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseCryptoPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoPrices> GetCryptoPricesAsync (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseCryptoPrices> localVarResponse = await GetCryptoPricesAsyncWithHttpInfo(timeframe, pair, exchange, currency, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Prices Returns a list of available Crypto Currency Prices.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timeframe">The time interval for the prices.</param>
        /// <param name="pair">Return prices for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return prices for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return prices for the given Crypto Currency. (optional)</param>
        /// <param name="timezone">Return price date/times in this timezone, also interpret start/end date/time parameters in this timezone. (optional, default to UTC)</param>
        /// <param name="startDate">Return Crypto Prices on or after this date. (optional)</param>
        /// <param name="startTime">Return Crypto Prices at or after this time (24-hour). (optional)</param>
        /// <param name="endDate">Return Crypto Prices on or before this date. (optional)</param>
        /// <param name="endTime">Return Crypto Prices at or before this time (24-hour). (optional)</param>
        /// <param name="pageSize">An integer greater than or equal to 1 for specifying the number of results on each page. (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoPrices>> GetCryptoPricesAsyncWithHttpInfo (string timeframe, string pair = null, string exchange = null, string currency = null, string timezone = null, string startDate = null, string startTime = null, string endDate = null, string endTime = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'timeframe' is set
            if (timeframe == null)
                throw new ApiException(400, "Missing required parameter 'timeframe' when calling CryptoApi->GetCryptoPrices");

            var localVarPath = "/crypto/prices";
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

            if (timeframe != null) localVarPathParams.Add("timeframe", Configuration.ApiClient.ParameterToString(timeframe)); // path parameter
            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
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
                Exception exception = ExceptionFactory("GetCryptoPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoPrices>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoPrices)));
        }

        /// <summary>
        /// Crypto Snapshot Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoSnapshot</returns>
        public ApiResponseCryptoSnapshot GetCryptoSnapshot (string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoSnapshot> localVarResponse = GetCryptoSnapshotWithHttpInfo(pair, exchange, currency);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Snapshot Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoSnapshot</returns>
        public ApiResponse< ApiResponseCryptoSnapshot > GetCryptoSnapshotWithHttpInfo (string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/snapshot";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoSnapshot", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoSnapshot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoSnapshot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoSnapshot)));
        }

        /// <summary>
        /// Crypto Snapshot Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoSnapshot</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoSnapshot> GetCryptoSnapshotAsync (string pair = null, string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoSnapshot> localVarResponse = await GetCryptoSnapshotAsyncWithHttpInfo(pair, exchange, currency);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Snapshot Returns a market snapshot over that last 24 hours for the given currency pair and exchange.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pair">Return the snapshot for the given Crypto Currency Pair. (optional)</param>
        /// <param name="exchange">Return the snapshot for a Crypto Currency on the given Crypto Exchange. (optional)</param>
        /// <param name="currency">Return the snapshot for the given Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoSnapshot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoSnapshot>> GetCryptoSnapshotAsyncWithHttpInfo (string pair = null, string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/snapshot";
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

            if (pair != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pair", pair)); // query parameter
            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoSnapshot", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoSnapshot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoSnapshot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoSnapshot)));
        }

        /// <summary>
        /// Crypto Stats Returns available stats on Crypto Currencies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>ApiResponseCryptoStats</returns>
        public ApiResponseCryptoStats GetCryptoStats (string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoStats> localVarResponse = GetCryptoStatsWithHttpInfo(exchange, currency);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Crypto Stats Returns available stats on Crypto Currencies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>ApiResponse of ApiResponseCryptoStats</returns>
        public ApiResponse< ApiResponseCryptoStats > GetCryptoStatsWithHttpInfo (string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/stats";
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

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoStats)));
        }

        /// <summary>
        /// Crypto Stats Returns available stats on Crypto Currencies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponseCryptoStats</returns>
        public async System.Threading.Tasks.Task<ApiResponseCryptoStats> GetCryptoStatsAsync (string exchange = null, string currency = null)
        {
             ApiResponse<ApiResponseCryptoStats> localVarResponse = await GetCryptoStatsAsyncWithHttpInfo(exchange, currency);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Crypto Stats Returns available stats on Crypto Currencies.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exchange">Returns stats for Crypto Currencies that trade on the specified Crypto Exchange. (optional)</param>
        /// <param name="currency">Returns stats for the specified Crypto Currency. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseCryptoStats)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseCryptoStats>> GetCryptoStatsAsyncWithHttpInfo (string exchange = null, string currency = null)
        {

            var localVarPath = "/crypto/stats";
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

            if (exchange != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "exchange", exchange)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter

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
                Exception exception = ExceptionFactory("GetCryptoStats", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseCryptoStats>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseCryptoStats) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseCryptoStats)));
        }

    }
}

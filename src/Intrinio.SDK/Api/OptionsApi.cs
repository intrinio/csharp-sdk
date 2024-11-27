

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
    public interface IOptionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Options Tickers
        /// </summary>
        /// <remarks>
        /// Returns all tickers that have existing options contracts.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>ApiResponseOptionsTickers</returns>
        ApiResponseOptionsTickers GetAllOptionsTickers (bool? useUnderlyingSymbols = null);

        /// <summary>
        /// Options Tickers
        /// </summary>
        /// <remarks>
        /// Returns all tickers that have existing options contracts.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>ApiResponse of ApiResponseOptionsTickers</returns>
        ApiResponse<ApiResponseOptionsTickers> GetAllOptionsTickersWithHttpInfo (bool? useUnderlyingSymbols = null);
        /// <summary>
        /// Total open interest and volume aggregated by ticker
        /// </summary>
        /// <remarks>
        /// Returns total open interest and volume by ticker
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionsAggregates</returns>
        ApiResponseOptionsAggregates GetOptionAggregates (Object date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Total open interest and volume aggregated by ticker
        /// </summary>
        /// <remarks>
        /// Returns total open interest and volume by ticker
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsAggregates</returns>
        ApiResponse<ApiResponseOptionsAggregates> GetOptionAggregatesWithHttpInfo (Object date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        ApiResponseOptionsExpirations GetOptionExpirationsRealtime (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        ApiResponse<ApiResponseOptionsExpirations> GetOptionExpirationsRealtimeWithHttpInfo (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Option Strikes Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsChainRealtime</returns>
        ApiResponseOptionsChainRealtime GetOptionStrikesRealtime (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Option Strikes Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
        ApiResponse<ApiResponseOptionsChainRealtime> GetOptionStrikesRealtimeWithHttpInfo (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Option Trades
        /// </summary>
        /// <remarks>
        /// Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>OptionTradesResult</returns>
        OptionTradesResult GetOptionTrades (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null);

        /// <summary>
        /// Option Trades
        /// </summary>
        /// <remarks>
        /// Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of OptionTradesResult</returns>
        ApiResponse<OptionTradesResult> GetOptionTradesWithHttpInfo (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null);
        /// <summary>
        /// Option Trades By Contract
        /// </summary>
        /// <remarks>
        /// Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>OptionTradesResult</returns>
        OptionTradesResult GetOptionTradesByContract (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null);

        /// <summary>
        /// Option Trades By Contract
        /// </summary>
        /// <remarks>
        /// Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of OptionTradesResult</returns>
        ApiResponse<OptionTradesResult> GetOptionTradesByContractWithHttpInfo (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null);
        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptions</returns>
        ApiResponseOptions GetOptions (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptions</returns>
        ApiResponse<ApiResponseOptions> GetOptionsWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Options by Symbol Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsRealtime</returns>
        ApiResponseOptionsRealtime GetOptionsBySymbolRealtime (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options by Symbol Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsRealtime</returns>
        ApiResponse<ApiResponseOptionsRealtime> GetOptionsBySymbolRealtimeWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseOptionsChain</returns>
        ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChain</returns>
        ApiResponse<ApiResponseOptionsChain> GetOptionsChainWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);
        /// <summary>
        /// Options Chain EOD
        /// </summary>
        /// <remarks>
        /// Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsChainEod</returns>
        ApiResponseOptionsChainEod GetOptionsChainEod (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Chain EOD
        /// </summary>
        /// <remarks>
        /// Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainEod</returns>
        ApiResponse<ApiResponseOptionsChainEod> GetOptionsChainEodWithHttpInfo (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsChainRealtime</returns>
        ApiResponseOptionsChainRealtime GetOptionsChainRealtime (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
        ApiResponse<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        ApiResponseOptionsExpirations GetOptionsExpirations (string symbol, string after = null, string before = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        ApiResponse<ApiResponseOptionsExpirations> GetOptionsExpirationsWithHttpInfo (string symbol, string after = null, string before = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        ApiResponseOptionsExpirations GetOptionsExpirationsEod (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        ApiResponse<ApiResponseOptionsExpirations> GetOptionsExpirationsEodWithHttpInfo (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Intervals By Contract
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>OptionIntervalsResult</returns>
        OptionIntervalsResult GetOptionsIntervalByContract (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null);

        /// <summary>
        /// Options Intervals By Contract
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsResult</returns>
        ApiResponse<OptionIntervalsResult> GetOptionsIntervalByContractWithHttpInfo (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null);
        /// <summary>
        /// Options Intervals Movers
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>OptionIntervalsMoversResult</returns>
        OptionIntervalsMoversResult GetOptionsIntervalMovers (string source = null, DateTime? openTime = null);

        /// <summary>
        /// Options Intervals Movers
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsMoversResult</returns>
        ApiResponse<OptionIntervalsMoversResult> GetOptionsIntervalMoversWithHttpInfo (string source = null, DateTime? openTime = null);
        /// <summary>
        /// Options Intervals Movers By Change
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>OptionIntervalsMoversResult</returns>
        OptionIntervalsMoversResult GetOptionsIntervalMoversChange (string source = null, DateTime? openTime = null);

        /// <summary>
        /// Options Intervals Movers By Change
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsMoversResult</returns>
        ApiResponse<OptionIntervalsMoversResult> GetOptionsIntervalMoversChangeWithHttpInfo (string source = null, DateTime? openTime = null);
        /// <summary>
        /// Options Intervals Movers By Volume
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>OptionIntervalsMoversResult</returns>
        OptionIntervalsMoversResult GetOptionsIntervalMoversVolume (string source = null, DateTime? openTime = null);

        /// <summary>
        /// Options Intervals Movers By Volume
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsMoversResult</returns>
        ApiResponse<OptionIntervalsMoversResult> GetOptionsIntervalMoversVolumeWithHttpInfo (string source = null, DateTime? openTime = null);
        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all price data from inception to expiration for a particular contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionPrices</returns>
        ApiResponseOptionPrices GetOptionsPrices (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all price data from inception to expiration for a particular contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionPrices</returns>
        ApiResponse<ApiResponseOptionPrices> GetOptionsPricesWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Option Prices Batch Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of latest price data for up to 250 option contracts per request.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponseOptionsPricesBatchRealtime</returns>
        ApiResponseOptionsPricesBatchRealtime GetOptionsPricesBatchRealtime (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);

        /// <summary>
        /// Option Prices Batch Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of latest price data for up to 250 option contracts per request.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesBatchRealtime</returns>
        ApiResponse<ApiResponseOptionsPricesBatchRealtime> GetOptionsPricesBatchRealtimeWithHttpInfo (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);
        /// <summary>
        /// Option Prices EOD
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>ApiResponseOptionsPricesEod</returns>
        ApiResponseOptionsPricesEod GetOptionsPricesEod (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null);

        /// <summary>
        /// Option Prices EOD
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesEod</returns>
        ApiResponse<ApiResponseOptionsPricesEod> GetOptionsPricesEodWithHttpInfo (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null);
        /// <summary>
        /// Option Prices End of Day By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionsPricesByTickerEod</returns>
        ApiResponseOptionsPricesByTickerEod GetOptionsPricesEodByTicker (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null);

        /// <summary>
        /// Option Prices End of Day By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesByTickerEod</returns>
        ApiResponse<ApiResponseOptionsPricesByTickerEod> GetOptionsPricesEodByTickerWithHttpInfo (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null);
        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponseOptionsPriceRealtime</returns>
        ApiResponseOptionsPriceRealtime GetOptionsPricesRealtime (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);

        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPriceRealtime</returns>
        ApiResponse<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeWithHttpInfo (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);
        /// <summary>
        /// Option Prices Realtime By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>ApiResponseOptionsPricesByTickerRealtime</returns>
        ApiResponseOptionsPricesByTickerRealtime GetOptionsPricesRealtimeByTicker (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null);

        /// <summary>
        /// Option Prices Realtime By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesByTickerRealtime</returns>
        ApiResponse<ApiResponseOptionsPricesByTickerRealtime> GetOptionsPricesRealtimeByTickerWithHttpInfo (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null);
        /// <summary>
        /// Option Prices Realtime Snapshot
        /// </summary>
        /// <remarks>
        /// Returns all options snapshots for the queried interval with links to download.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>OptionSnapshotsResult</returns>
        OptionSnapshotsResult GetOptionsSnapshots (string source = null, DateTime? atDatetime = null);

        /// <summary>
        /// Option Prices Realtime Snapshot
        /// </summary>
        /// <remarks>
        /// Returns all options snapshots for the queried interval with links to download.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>ApiResponse of OptionSnapshotsResult</returns>
        ApiResponse<OptionSnapshotsResult> GetOptionsSnapshotsWithHttpInfo (string source = null, DateTime? atDatetime = null);
        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponseOptionsStatsRealtime</returns>
        ApiResponseOptionsStatsRealtime GetOptionsStatsRealtime (string identifier, string source = null, bool? showExtendedPrice = null);

        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsStatsRealtime</returns>
        ApiResponse<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeWithHttpInfo (string identifier, string source = null, bool? showExtendedPrice = null);
        /// <summary>
        /// Options Unusual Activity
        /// </summary>
        /// <remarks>
        /// Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        ApiResponseOptionsUnusualActivity GetUnusualActivity (string symbol, string source = null);

        /// <summary>
        /// Options Unusual Activity
        /// </summary>
        /// <remarks>
        /// Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        ApiResponse<ApiResponseOptionsUnusualActivity> GetUnusualActivityWithHttpInfo (string symbol, string source = null);
        /// <summary>
        /// Options Unusual Activity Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for a given identifier within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        ApiResponseOptionsUnusualActivity GetUnusualActivityIntraday (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);

        /// <summary>
        /// Options Unusual Activity Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for a given identifier within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        ApiResponse<ApiResponseOptionsUnusualActivity> GetUnusualActivityIntradayWithHttpInfo (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);
        /// <summary>
        /// Options Unusual Activity Universal
        /// </summary>
        /// <remarks>
        /// Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        ApiResponseOptionsUnusualActivity GetUnusualActivityUniversal (string source = null);

        /// <summary>
        /// Options Unusual Activity Universal
        /// </summary>
        /// <remarks>
        /// Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        ApiResponse<ApiResponseOptionsUnusualActivity> GetUnusualActivityUniversalWithHttpInfo (string source = null);
        /// <summary>
        /// Options Unusual Activity Universal Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for all underlying security symbols within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        ApiResponseOptionsUnusualActivity GetUnusualActivityUniversalIntraday (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);

        /// <summary>
        /// Options Unusual Activity Universal Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for all underlying security symbols within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        ApiResponse<ApiResponseOptionsUnusualActivity> GetUnusualActivityUniversalIntradayWithHttpInfo (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Options Tickers
        /// </summary>
        /// <remarks>
        /// Returns all tickers that have existing options contracts.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>Task of ApiResponseOptionsTickers</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsTickers> GetAllOptionsTickersAsync (bool? useUnderlyingSymbols = null);

        /// <summary>
        /// Options Tickers
        /// </summary>
        /// <remarks>
        /// Returns all tickers that have existing options contracts.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsTickers)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsTickers>> GetAllOptionsTickersAsyncWithHttpInfo (bool? useUnderlyingSymbols = null);
        /// <summary>
        /// Total open interest and volume aggregated by ticker
        /// </summary>
        /// <remarks>
        /// Returns total open interest and volume by ticker
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionsAggregates</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsAggregates> GetOptionAggregatesAsync (Object date = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Total open interest and volume aggregated by ticker
        /// </summary>
        /// <remarks>
        /// Returns total open interest and volume by ticker
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsAggregates)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsAggregates>> GetOptionAggregatesAsyncWithHttpInfo (Object date = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionExpirationsRealtimeAsync (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionExpirationsRealtimeAsyncWithHttpInfo (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Option Strikes Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsChainRealtime> GetOptionStrikesRealtimeAsync (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Option Strikes Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionStrikesRealtimeAsyncWithHttpInfo (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Option Trades
        /// </summary>
        /// <remarks>
        /// Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of OptionTradesResult</returns>
        System.Threading.Tasks.Task<OptionTradesResult> GetOptionTradesAsync (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null);

        /// <summary>
        /// Option Trades
        /// </summary>
        /// <remarks>
        /// Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (OptionTradesResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionTradesResult>> GetOptionTradesAsyncWithHttpInfo (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null);
        /// <summary>
        /// Option Trades By Contract
        /// </summary>
        /// <remarks>
        /// Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of OptionTradesResult</returns>
        System.Threading.Tasks.Task<OptionTradesResult> GetOptionTradesByContractAsync (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null);

        /// <summary>
        /// Option Trades By Contract
        /// </summary>
        /// <remarks>
        /// Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (OptionTradesResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionTradesResult>> GetOptionTradesByContractAsyncWithHttpInfo (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null);
        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptions</returns>
        System.Threading.Tasks.Task<ApiResponseOptions> GetOptionsAsync (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Options
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptions)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptions>> GetOptionsAsyncWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Options by Symbol Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsRealtime> GetOptionsBySymbolRealtimeAsync (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options by Symbol Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsRealtime>> GetOptionsBySymbolRealtimeAsyncWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseOptionsChain</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsChain> GetOptionsChainAsync (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);

        /// <summary>
        /// Options Chain
        /// </summary>
        /// <remarks>
        /// Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChain)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChain>> GetOptionsChainAsyncWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null);
        /// <summary>
        /// Options Chain EOD
        /// </summary>
        /// <remarks>
        /// Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainEod</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsChainEod> GetOptionsChainEodAsync (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Chain EOD
        /// </summary>
        /// <remarks>
        /// Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainEod)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainEod>> GetOptionsChainEodAsyncWithHttpInfo (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeAsync (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Chain Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionsChainRealtimeAsyncWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionsExpirationsAsync (string symbol, string after = null, string before = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsAsyncWithHttpInfo (string symbol, string after = null, string before = null);
        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionsExpirationsEodAsync (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null);

        /// <summary>
        /// Options Expirations
        /// </summary>
        /// <remarks>
        /// Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsEodAsyncWithHttpInfo (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null);
        /// <summary>
        /// Options Intervals By Contract
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>Task of OptionIntervalsResult</returns>
        System.Threading.Tasks.Task<OptionIntervalsResult> GetOptionsIntervalByContractAsync (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null);

        /// <summary>
        /// Options Intervals By Contract
        /// </summary>
        /// <remarks>
        /// Returns a list of interval data points for a contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionIntervalsResult>> GetOptionsIntervalByContractAsyncWithHttpInfo (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null);
        /// <summary>
        /// Options Intervals Movers
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of OptionIntervalsMoversResult</returns>
        System.Threading.Tasks.Task<OptionIntervalsMoversResult> GetOptionsIntervalMoversAsync (string source = null, DateTime? openTime = null);

        /// <summary>
        /// Options Intervals Movers
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsMoversResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionIntervalsMoversResult>> GetOptionsIntervalMoversAsyncWithHttpInfo (string source = null, DateTime? openTime = null);
        /// <summary>
        /// Options Intervals Movers By Change
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of OptionIntervalsMoversResult</returns>
        System.Threading.Tasks.Task<OptionIntervalsMoversResult> GetOptionsIntervalMoversChangeAsync (string source = null, DateTime? openTime = null);

        /// <summary>
        /// Options Intervals Movers By Change
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsMoversResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionIntervalsMoversResult>> GetOptionsIntervalMoversChangeAsyncWithHttpInfo (string source = null, DateTime? openTime = null);
        /// <summary>
        /// Options Intervals Movers By Volume
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of OptionIntervalsMoversResult</returns>
        System.Threading.Tasks.Task<OptionIntervalsMoversResult> GetOptionsIntervalMoversVolumeAsync (string source = null, DateTime? openTime = null);

        /// <summary>
        /// Options Intervals Movers By Volume
        /// </summary>
        /// <remarks>
        /// Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsMoversResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionIntervalsMoversResult>> GetOptionsIntervalMoversVolumeAsyncWithHttpInfo (string source = null, DateTime? openTime = null);
        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all price data from inception to expiration for a particular contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionPrices</returns>
        System.Threading.Tasks.Task<ApiResponseOptionPrices> GetOptionsPricesAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Option Prices
        /// </summary>
        /// <remarks>
        /// Returns all price data from inception to expiration for a particular contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionPrices)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionPrices>> GetOptionsPricesAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Option Prices Batch Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of latest price data for up to 250 option contracts per request.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesBatchRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsPricesBatchRealtime> GetOptionsPricesBatchRealtimeAsync (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);

        /// <summary>
        /// Option Prices Batch Realtime
        /// </summary>
        /// <remarks>
        /// Returns a list of latest price data for up to 250 option contracts per request.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesBatchRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesBatchRealtime>> GetOptionsPricesBatchRealtimeAsyncWithHttpInfo (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);
        /// <summary>
        /// Option Prices EOD
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesEod</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsPricesEod> GetOptionsPricesEodAsync (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null);

        /// <summary>
        /// Option Prices EOD
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesEod)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesEod>> GetOptionsPricesEodAsyncWithHttpInfo (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null);
        /// <summary>
        /// Option Prices End of Day By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesByTickerEod</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsPricesByTickerEod> GetOptionsPricesEodByTickerAsync (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null);

        /// <summary>
        /// Option Prices End of Day By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesByTickerEod)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesByTickerEod>> GetOptionsPricesEodByTickerAsyncWithHttpInfo (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null);
        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPriceRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeAsync (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);

        /// <summary>
        /// Option Prices Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option prices for a given option contract identifier.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPriceRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPriceRealtime>> GetOptionsPricesRealtimeAsyncWithHttpInfo (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null);
        /// <summary>
        /// Option Prices Realtime By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesByTickerRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsPricesByTickerRealtime> GetOptionsPricesRealtimeByTickerAsync (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null);

        /// <summary>
        /// Option Prices Realtime By Ticker
        /// </summary>
        /// <remarks>
        /// Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesByTickerRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesByTickerRealtime>> GetOptionsPricesRealtimeByTickerAsyncWithHttpInfo (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null);
        /// <summary>
        /// Option Prices Realtime Snapshot
        /// </summary>
        /// <remarks>
        /// Returns all options snapshots for the queried interval with links to download.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>Task of OptionSnapshotsResult</returns>
        System.Threading.Tasks.Task<OptionSnapshotsResult> GetOptionsSnapshotsAsync (string source = null, DateTime? atDatetime = null);

        /// <summary>
        /// Option Prices Realtime Snapshot
        /// </summary>
        /// <remarks>
        /// Returns all options snapshots for the queried interval with links to download.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>Task of ApiResponse (OptionSnapshotsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionSnapshotsResult>> GetOptionsSnapshotsAsyncWithHttpInfo (string source = null, DateTime? atDatetime = null);
        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponseOptionsStatsRealtime</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeAsync (string identifier, string source = null, bool? showExtendedPrice = null);

        /// <summary>
        /// Option Stats Realtime
        /// </summary>
        /// <remarks>
        /// Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsStatsRealtime)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsStatsRealtime>> GetOptionsStatsRealtimeAsyncWithHttpInfo (string identifier, string source = null, bool? showExtendedPrice = null);
        /// <summary>
        /// Options Unusual Activity
        /// </summary>
        /// <remarks>
        /// Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityAsync (string symbol, string source = null);

        /// <summary>
        /// Options Unusual Activity
        /// </summary>
        /// <remarks>
        /// Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityAsyncWithHttpInfo (string symbol, string source = null);
        /// <summary>
        /// Options Unusual Activity Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for a given identifier within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityIntradayAsync (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);

        /// <summary>
        /// Options Unusual Activity Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for a given identifier within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityIntradayAsyncWithHttpInfo (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);
        /// <summary>
        /// Options Unusual Activity Universal
        /// </summary>
        /// <remarks>
        /// Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityUniversalAsync (string source = null);

        /// <summary>
        /// Options Unusual Activity Universal
        /// </summary>
        /// <remarks>
        /// Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityUniversalAsyncWithHttpInfo (string source = null);
        /// <summary>
        /// Options Unusual Activity Universal Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for all underlying security symbols within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityUniversalIntradayAsync (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);

        /// <summary>
        /// Options Unusual Activity Universal Intraday
        /// </summary>
        /// <remarks>
        /// Returns unusual trades for all underlying security symbols within the query parameters.
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityUniversalIntradayAsyncWithHttpInfo (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OptionsApi : IOptionsApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OptionsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OptionsApi(Configuration configuration = null)
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
        /// Options Tickers Returns all tickers that have existing options contracts.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>ApiResponseOptionsTickers</returns>
        public ApiResponseOptionsTickers GetAllOptionsTickers (bool? useUnderlyingSymbols = null)
        {
             ApiResponse<ApiResponseOptionsTickers> localVarResponse = GetAllOptionsTickersWithHttpInfo(useUnderlyingSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Tickers Returns all tickers that have existing options contracts.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>ApiResponse of ApiResponseOptionsTickers</returns>
        
        public ApiResponse< ApiResponseOptionsTickers > GetAllOptionsTickersWithHttpInfo (bool? useUnderlyingSymbols = null)
        {

            var localVarPath = "/options/tickers";
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
            
            
            if (useUnderlyingSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "use_underlying_symbols", useUnderlyingSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllOptionsTickers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsTickers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsTickers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsTickers)));
        }

        /// <summary>
        /// Options Tickers Returns all tickers that have existing options contracts.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>Task of ApiResponseOptionsTickers</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsTickers> GetAllOptionsTickersAsync (bool? useUnderlyingSymbols = null)
        {
             ApiResponse<ApiResponseOptionsTickers> localVarResponse = await GetAllOptionsTickersAsyncWithHttpInfo(useUnderlyingSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Tickers Returns all tickers that have existing options contracts.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="useUnderlyingSymbols">Use underlying symbol vs contract symbol (optional, default to false)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsTickers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsTickers>> GetAllOptionsTickersAsyncWithHttpInfo (bool? useUnderlyingSymbols = null)
        {

            var localVarPath = "/options/tickers";
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
              

            if (useUnderlyingSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "use_underlying_symbols", useUnderlyingSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllOptionsTickers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsTickers>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsTickers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsTickers)));
        }

        /// <summary>
        /// Total open interest and volume aggregated by ticker Returns total open interest and volume by ticker
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionsAggregates</returns>
        public ApiResponseOptionsAggregates GetOptionAggregates (Object date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionsAggregates> localVarResponse = GetOptionAggregatesWithHttpInfo(date, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Total open interest and volume aggregated by ticker Returns total open interest and volume by ticker
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsAggregates</returns>
        
        public ApiResponse< ApiResponseOptionsAggregates > GetOptionAggregatesWithHttpInfo (Object date = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/options/aggregates";
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
            
            
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionAggregates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsAggregates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsAggregates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsAggregates)));
        }

        /// <summary>
        /// Total open interest and volume aggregated by ticker Returns total open interest and volume by ticker
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionsAggregates</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsAggregates> GetOptionAggregatesAsync (Object date = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionsAggregates> localVarResponse = await GetOptionAggregatesAsyncWithHttpInfo(date, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Total open interest and volume aggregated by ticker Returns total open interest and volume by ticker
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="date">Return aggregated data for this date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsAggregates)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsAggregates>> GetOptionAggregatesAsyncWithHttpInfo (Object date = null, int? pageSize = null, string nextPage = null)
        {

            var localVarPath = "/options/aggregates";
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
              

            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionAggregates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsAggregates>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsAggregates) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsAggregates)));
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        public ApiResponseOptionsExpirations GetOptionExpirationsRealtime (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = GetOptionExpirationsRealtimeWithHttpInfo(symbol, after, before, source, includeRelatedSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        
        public ApiResponse< ApiResponseOptionsExpirations > GetOptionExpirationsRealtimeWithHttpInfo (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionExpirationsRealtime");

            var localVarPath = "/options/expirations/{symbol}/realtime";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionExpirationsRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionExpirationsRealtimeAsync (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = await GetOptionExpirationsRealtimeAsyncWithHttpInfo(symbol, after, before, source, includeRelatedSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionExpirationsRealtimeAsyncWithHttpInfo (string symbol, string after = null, string before = null, string source = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionExpirationsRealtime");

            var localVarPath = "/options/expirations/{symbol}/realtime";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionExpirationsRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Option Strikes Realtime Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsChainRealtime</returns>
        public ApiResponseOptionsChainRealtime GetOptionStrikesRealtime (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsChainRealtime> localVarResponse = GetOptionStrikesRealtimeWithHttpInfo(symbol, strike, source, stockPriceSource, model, showExtendedPrice, includeRelatedSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Strikes Realtime Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsChainRealtime > GetOptionStrikesRealtimeWithHttpInfo (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionStrikesRealtime");
            // verify the required parameter 'strike' is set
            if (strike == null)
                throw new ApiException(400, "Missing required parameter 'strike' when calling OptionsApi->GetOptionStrikesRealtime");

            var localVarPath = "/options/strikes/{symbol}/{strike}/realtime";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (strike != null) localVarPathParams.Add("strike", Configuration.ApiClient.ParameterToString(strike)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionStrikesRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChainRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainRealtime)));
        }

        /// <summary>
        /// Option Strikes Realtime Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsChainRealtime> GetOptionStrikesRealtimeAsync (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsChainRealtime> localVarResponse = await GetOptionStrikesRealtimeAsyncWithHttpInfo(symbol, strike, source, stockPriceSource, model, showExtendedPrice, includeRelatedSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Strikes Realtime Returns a list of the latest top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all call/put contracts that match the strike and symbol specified.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price.</param>
        /// <param name="source">Realtime or delayed. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionStrikesRealtimeAsyncWithHttpInfo (string symbol, decimal? strike, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionStrikesRealtime");
            // verify the required parameter 'strike' is set
            if (strike == null)
                throw new ApiException(400, "Missing required parameter 'strike' when calling OptionsApi->GetOptionStrikesRealtime");

            var localVarPath = "/options/strikes/{symbol}/{strike}/realtime";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (strike != null) localVarPathParams.Add("strike", Configuration.ApiClient.ParameterToString(strike)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionStrikesRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChainRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainRealtime)));
        }

        /// <summary>
        /// Option Trades Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>OptionTradesResult</returns>
        public OptionTradesResult GetOptionTrades (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null)
        {
             ApiResponse<OptionTradesResult> localVarResponse = GetOptionTradesWithHttpInfo(source, startDate, startTime, endDate, endTime, timezone, pageSize, minSize, security, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Trades Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of OptionTradesResult</returns>
        
        public ApiResponse< OptionTradesResult > GetOptionTradesWithHttpInfo (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null)
        {

            var localVarPath = "/options/trades";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (minSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_size", minSize)); // query parameter
            if (security != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "security", security)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionTrades", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionTradesResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionTradesResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionTradesResult)));
        }

        /// <summary>
        /// Option Trades Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of OptionTradesResult</returns>
        public async System.Threading.Tasks.Task<OptionTradesResult> GetOptionTradesAsync (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null)
        {
             ApiResponse<OptionTradesResult> localVarResponse = await GetOptionTradesAsyncWithHttpInfo(source, startDate, startTime, endDate, endTime, timezone, pageSize, minSize, security, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Trades Returns all trades between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="security">The ticker symbol for which trades are being requested. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (OptionTradesResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionTradesResult>> GetOptionTradesAsyncWithHttpInfo (string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string security = null, string nextPage = null)
        {

            var localVarPath = "/options/trades";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (minSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_size", minSize)); // query parameter
            if (security != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "security", security)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionTrades", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionTradesResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionTradesResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionTradesResult)));
        }

        /// <summary>
        /// Option Trades By Contract Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>OptionTradesResult</returns>
        public OptionTradesResult GetOptionTradesByContract (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null)
        {
             ApiResponse<OptionTradesResult> localVarResponse = GetOptionTradesByContractWithHttpInfo(identifier, source, startDate, startTime, endDate, endTime, timezone, pageSize, minSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Trades By Contract Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of OptionTradesResult</returns>
        
        public ApiResponse< OptionTradesResult > GetOptionTradesByContractWithHttpInfo (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionTradesByContract");

            var localVarPath = "/options/{identifier}/trades";
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
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (minSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_size", minSize)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionTradesByContract", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionTradesResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionTradesResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionTradesResult)));
        }

        /// <summary>
        /// Option Trades By Contract Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of OptionTradesResult</returns>
        public async System.Threading.Tasks.Task<OptionTradesResult> GetOptionTradesByContractAsync (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null)
        {
             ApiResponse<OptionTradesResult> localVarResponse = await GetOptionTradesByContractAsyncWithHttpInfo(identifier, source, startDate, startTime, endDate, endTime, timezone, pageSize, minSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Trades By Contract Returns all trades for a contract between start time and end time, up to seven days ago for the specified source.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The option contract for which trades are being requested.</param>
        /// <param name="source">The specific source of the data being requested. (optional)</param>
        /// <param name="startDate">The start date for the data being requested. (optional)</param>
        /// <param name="startTime">The start time for the data being requested. (optional)</param>
        /// <param name="endDate">The end date for the data being requested. (optional)</param>
        /// <param name="endTime">The end time for the data being requested. (optional)</param>
        /// <param name="timezone">The timezone the start and end date/times use. (optional, default to UTC)</param>
        /// <param name="pageSize">The maximum number of results to return per page. (optional, default to 100)</param>
        /// <param name="minSize">Trades must be larger or equal to this size. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (OptionTradesResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionTradesResult>> GetOptionTradesByContractAsyncWithHttpInfo (string identifier, string source = null, DateTime? startDate = null, string startTime = null, DateTime? endDate = null, string endTime = null, string timezone = null, int? pageSize = null, int? minSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionTradesByContract");

            var localVarPath = "/options/{identifier}/trades";
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
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (startTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_time", startTime)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter
            if (timezone != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "timezone", timezone)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (minSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "min_size", minSize)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionTradesByContract", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionTradesResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionTradesResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionTradesResult)));
        }

        /// <summary>
        /// Options Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptions</returns>
        public ApiResponseOptions GetOptions (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptions> localVarResponse = GetOptionsWithHttpInfo(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptions</returns>
        
        public ApiResponse< ApiResponseOptions > GetOptionsWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptions");

            var localVarPath = "/options/{symbol}";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter
            if (expirationAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_after", expirationAfter)); // query parameter
            if (expirationBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_before", expirationBefore)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptions>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptions)));
        }

        /// <summary>
        /// Options Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptions</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptions> GetOptionsAsync (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptions> localVarResponse = await GetOptionsAsyncWithHttpInfo(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptions>> GetOptionsAsyncWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptions");

            var localVarPath = "/options/{symbol}";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter
            if (expirationAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_after", expirationAfter)); // query parameter
            if (expirationBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_before", expirationBefore)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptions>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptions)));
        }

        /// <summary>
        /// Options by Symbol Realtime Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsRealtime</returns>
        public ApiResponseOptionsRealtime GetOptionsBySymbolRealtime (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsRealtime> localVarResponse = GetOptionsBySymbolRealtimeWithHttpInfo(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, source, includeRelatedSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options by Symbol Realtime Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsRealtime > GetOptionsBySymbolRealtimeWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsBySymbolRealtime");

            var localVarPath = "/options/{symbol}/realtime";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter
            if (expirationAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_after", expirationAfter)); // query parameter
            if (expirationBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_before", expirationBefore)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsBySymbolRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsRealtime)));
        }

        /// <summary>
        /// Options by Symbol Realtime Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsRealtime> GetOptionsBySymbolRealtimeAsync (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsRealtime> localVarResponse = await GetOptionsBySymbolRealtimeAsyncWithHttpInfo(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, source, includeRelatedSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options by Symbol Realtime Returns a list of all securities that have options listed and are tradable on a US market exchange. Useful to retrieve the entire universe.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="expiration">The expiration date of the option contract. This will return options contracts with expiration dates on this date. (optional)</param>
        /// <param name="expirationAfter">The expiration date of the option contract. This will return options contracts with expiration dates after this date. (optional)</param>
        /// <param name="expirationBefore">The expiration date of the option contract. This will return options contracts with expiration dates before this date. (optional)</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsRealtime>> GetOptionsBySymbolRealtimeAsyncWithHttpInfo (string symbol, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string expiration = null, string expirationAfter = null, string expirationBefore = null, string source = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsBySymbolRealtime");

            var localVarPath = "/options/{symbol}/realtime";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (expiration != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration", expiration)); // query parameter
            if (expirationAfter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_after", expirationAfter)); // query parameter
            if (expirationBefore != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_before", expirationBefore)); // query parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsBySymbolRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsRealtime)));
        }

        /// <summary>
        /// Options Chain Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponseOptionsChain</returns>
        public ApiResponseOptionsChain GetOptionsChain (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseOptionsChain> localVarResponse = GetOptionsChainWithHttpInfo(symbol, expiration, date, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Chain Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChain</returns>
        
        public ApiResponse< ApiResponseOptionsChain > GetOptionsChainWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChain");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChain");

            var localVarPath = "/options/chain/{symbol}/{expiration}";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionsChain", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChain>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChain)));
        }

        /// <summary>
        /// Options Chain Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponseOptionsChain</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsChain> GetOptionsChainAsync (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
             ApiResponse<ApiResponseOptionsChain> localVarResponse = await GetOptionsChainAsyncWithHttpInfo(symbol, expiration, date, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Chain Returns a list of the historical end-of-day top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="date">The date of the option price. Returns option prices on this date. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChain)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChain>> GetOptionsChainAsyncWithHttpInfo (string symbol, string expiration, DateTime? date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, string moneyness = null, int? pageSize = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChain");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChain");

            var localVarPath = "/options/chain/{symbol}/{expiration}";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionsChain", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChain>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChain) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChain)));
        }

        /// <summary>
        /// Options Chain EOD Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsChainEod</returns>
        public ApiResponseOptionsChainEod GetOptionsChainEod (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsChainEod> localVarResponse = GetOptionsChainEodWithHttpInfo(symbol, expiration, type, strike, strikeGreaterThan, strikeLessThan, date, includeRelatedSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Chain EOD Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainEod</returns>
        
        public ApiResponse< ApiResponseOptionsChainEod > GetOptionsChainEodWithHttpInfo (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChainEod");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChainEod");

            var localVarPath = "/options/chain/{symbol}/{expiration}/eod";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsChainEod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainEod>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChainEod) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainEod)));
        }

        /// <summary>
        /// Options Chain EOD Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainEod</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsChainEod> GetOptionsChainEodAsync (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsChainEod> localVarResponse = await GetOptionsChainEodAsyncWithHttpInfo(symbol, expiration, type, strike, strikeGreaterThan, strikeLessThan, date, includeRelatedSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Chain EOD Returns all EOD options contracts and their prices for the given symbol and expiration date.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="date">The date to retrieve prices for (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainEod)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainEod>> GetOptionsChainEodAsyncWithHttpInfo (string symbol, string expiration, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, DateTime? date = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChainEod");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChainEod");

            var localVarPath = "/options/chain/{symbol}/{expiration}/eod";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsChainEod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainEod>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChainEod) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainEod)));
        }

        /// <summary>
        /// Options Chain Realtime Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsChainRealtime</returns>
        public ApiResponseOptionsChainRealtime GetOptionsChainRealtime (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsChainRealtime> localVarResponse = GetOptionsChainRealtimeWithHttpInfo(symbol, expiration, source, type, strike, strikeGreaterThan, strikeLessThan, volumeGreaterThan, volumeLessThan, openInterestGreaterThan, openInterestLessThan, moneyness, stockPriceSource, model, showExtendedPrice, includeRelatedSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Chain Realtime Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsChainRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsChainRealtime > GetOptionsChainRealtimeWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChainRealtime");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChainRealtime");

            var localVarPath = "/options/chain/{symbol}/{expiration}/realtime";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (volumeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_greater_than", volumeGreaterThan)); // query parameter
            if (volumeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_less_than", volumeLessThan)); // query parameter
            if (openInterestGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_greater_than", openInterestGreaterThan)); // query parameter
            if (openInterestLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_less_than", openInterestLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsChainRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChainRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainRealtime)));
        }

        /// <summary>
        /// Options Chain Realtime Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsChainRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsChainRealtime> GetOptionsChainRealtimeAsync (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsChainRealtime> localVarResponse = await GetOptionsChainRealtimeAsyncWithHttpInfo(symbol, expiration, source, type, strike, strikeGreaterThan, strikeLessThan, volumeGreaterThan, volumeLessThan, openInterestGreaterThan, openInterestLessThan, moneyness, stockPriceSource, model, showExtendedPrice, includeRelatedSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Chain Realtime Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the option chain.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="expiration">The expiration date of the options contract</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="volumeGreaterThan">The volume of the option contract. This will return options contracts with volumes greater than this amount. (optional)</param>
        /// <param name="volumeLessThan">The volume of the option contract. This will return options contracts with volumes less than this amout. (optional)</param>
        /// <param name="openInterestGreaterThan">The open interest of the option contract. This will return options contracts with open interest greater than this amount. (optional)</param>
        /// <param name="openInterestLessThan">The open interest of the option contract. This will return options contracts with open interest less than this amount. (optional)</param>
        /// <param name="moneyness">The moneyness of the options contracts to return. &#39;all&#39; will return all options contracts. &#39;in_the_money&#39; will return options contracts that are in the money (call options with strike prices below the current price, put options with strike prices above the current price). &#39;out_of_they_money&#39; will return options contracts that are out of the money (call options with strike prices above the current price, put options with strike prices below the current price). &#39;near_the_money&#39; will return options contracts that are $0.50 or less away from being in the money.  Requires subscription to realtime stock price data. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsChainRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsChainRealtime>> GetOptionsChainRealtimeAsyncWithHttpInfo (string symbol, string expiration, string source = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, decimal? volumeGreaterThan = null, decimal? volumeLessThan = null, decimal? openInterestGreaterThan = null, decimal? openInterestLessThan = null, string moneyness = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsChainRealtime");
            // verify the required parameter 'expiration' is set
            if (expiration == null)
                throw new ApiException(400, "Missing required parameter 'expiration' when calling OptionsApi->GetOptionsChainRealtime");

            var localVarPath = "/options/chain/{symbol}/{expiration}/realtime";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (expiration != null) localVarPathParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (volumeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_greater_than", volumeGreaterThan)); // query parameter
            if (volumeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "volume_less_than", volumeLessThan)); // query parameter
            if (openInterestGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_greater_than", openInterestGreaterThan)); // query parameter
            if (openInterestLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_interest_less_than", openInterestLessThan)); // query parameter
            if (moneyness != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "moneyness", moneyness)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsChainRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsChainRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsChainRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsChainRealtime)));
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        public ApiResponseOptionsExpirations GetOptionsExpirations (string symbol, string after = null, string before = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = GetOptionsExpirationsWithHttpInfo(symbol, after, before);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        
        public ApiResponse< ApiResponseOptionsExpirations > GetOptionsExpirationsWithHttpInfo (string symbol, string after = null, string before = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsExpirations");

            var localVarPath = "/options/expirations/{symbol}";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsExpirations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionsExpirationsAsync (string symbol, string after = null, string before = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = await GetOptionsExpirationsAsyncWithHttpInfo(symbol, after, before);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.  Available via a 3rd party, contact sales for a trial.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsAsyncWithHttpInfo (string symbol, string after = null, string before = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsExpirations");

            var localVarPath = "/options/expirations/{symbol}";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsExpirations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponseOptionsExpirations</returns>
        public ApiResponseOptionsExpirations GetOptionsExpirationsEod (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = GetOptionsExpirationsEodWithHttpInfo(symbol, after, before, includeRelatedSymbols);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsExpirations</returns>
        
        public ApiResponse< ApiResponseOptionsExpirations > GetOptionsExpirationsEodWithHttpInfo (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsExpirationsEod");

            var localVarPath = "/options/expirations/{symbol}/eod";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsExpirationsEod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponseOptionsExpirations</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsExpirations> GetOptionsExpirationsEodAsync (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null)
        {
             ApiResponse<ApiResponseOptionsExpirations> localVarResponse = await GetOptionsExpirationsEodAsyncWithHttpInfo(symbol, after, before, includeRelatedSymbols);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Expirations Returns a list of all current and upcoming option contract expiration dates for a particular symbol.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="after">Return option contract expiration dates after this date. (optional)</param>
        /// <param name="before">Return option contract expiration dates before this date. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsExpirations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsExpirations>> GetOptionsExpirationsEodAsyncWithHttpInfo (string symbol, string after = null, string before = null, bool? includeRelatedSymbols = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsExpirationsEod");

            var localVarPath = "/options/expirations/{symbol}/eod";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (after != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "after", after)); // query parameter
            if (before != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsExpirationsEod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsExpirations>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsExpirations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsExpirations)));
        }

        /// <summary>
        /// Options Intervals By Contract Returns a list of interval data points for a contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>OptionIntervalsResult</returns>
        public OptionIntervalsResult GetOptionsIntervalByContract (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null)
        {
             ApiResponse<OptionIntervalsResult> localVarResponse = GetOptionsIntervalByContractWithHttpInfo(identifier, intervalSize, source, pageSize, endTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Intervals By Contract Returns a list of interval data points for a contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsResult</returns>
        
        public ApiResponse< OptionIntervalsResult > GetOptionsIntervalByContractWithHttpInfo (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsIntervalByContract");
            // verify the required parameter 'intervalSize' is set
            if (intervalSize == null)
                throw new ApiException(400, "Missing required parameter 'intervalSize' when calling OptionsApi->GetOptionsIntervalByContract");

            var localVarPath = "/options/interval/{identifier}";
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
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalByContract", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsResult)));
        }

        /// <summary>
        /// Options Intervals By Contract Returns a list of interval data points for a contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>Task of OptionIntervalsResult</returns>
        public async System.Threading.Tasks.Task<OptionIntervalsResult> GetOptionsIntervalByContractAsync (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null)
        {
             ApiResponse<OptionIntervalsResult> localVarResponse = await GetOptionsIntervalByContractAsyncWithHttpInfo(identifier, intervalSize, source, pageSize, endTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Intervals By Contract Returns a list of interval data points for a contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request intervals for.</param>
        /// <param name="intervalSize">The time length of the interval.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="endTime">The inclusive UTC date and time the intervals end at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionIntervalsResult>> GetOptionsIntervalByContractAsyncWithHttpInfo (string identifier, string intervalSize, string source = null, int? pageSize = null, DateTime? endTime = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsIntervalByContract");
            // verify the required parameter 'intervalSize' is set
            if (intervalSize == null)
                throw new ApiException(400, "Missing required parameter 'intervalSize' when calling OptionsApi->GetOptionsIntervalByContract");

            var localVarPath = "/options/interval/{identifier}";
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
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (endTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_time", endTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalByContract", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsResult)));
        }

        /// <summary>
        /// Options Intervals Movers Returns a list of intervals for the biggest movers over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>OptionIntervalsMoversResult</returns>
        public OptionIntervalsMoversResult GetOptionsIntervalMovers (string source = null, DateTime? openTime = null)
        {
             ApiResponse<OptionIntervalsMoversResult> localVarResponse = GetOptionsIntervalMoversWithHttpInfo(source, openTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Intervals Movers Returns a list of intervals for the biggest movers over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsMoversResult</returns>
        
        public ApiResponse< OptionIntervalsMoversResult > GetOptionsIntervalMoversWithHttpInfo (string source = null, DateTime? openTime = null)
        {

            var localVarPath = "/options/interval/movers";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (openTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_time", openTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalMovers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsMoversResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsMoversResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsMoversResult)));
        }

        /// <summary>
        /// Options Intervals Movers Returns a list of intervals for the biggest movers over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of OptionIntervalsMoversResult</returns>
        public async System.Threading.Tasks.Task<OptionIntervalsMoversResult> GetOptionsIntervalMoversAsync (string source = null, DateTime? openTime = null)
        {
             ApiResponse<OptionIntervalsMoversResult> localVarResponse = await GetOptionsIntervalMoversAsyncWithHttpInfo(source, openTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Intervals Movers Returns a list of intervals for the biggest movers over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsMoversResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionIntervalsMoversResult>> GetOptionsIntervalMoversAsyncWithHttpInfo (string source = null, DateTime? openTime = null)
        {

            var localVarPath = "/options/interval/movers";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (openTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_time", openTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalMovers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsMoversResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsMoversResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsMoversResult)));
        }

        /// <summary>
        /// Options Intervals Movers By Change Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>OptionIntervalsMoversResult</returns>
        public OptionIntervalsMoversResult GetOptionsIntervalMoversChange (string source = null, DateTime? openTime = null)
        {
             ApiResponse<OptionIntervalsMoversResult> localVarResponse = GetOptionsIntervalMoversChangeWithHttpInfo(source, openTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Intervals Movers By Change Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsMoversResult</returns>
        
        public ApiResponse< OptionIntervalsMoversResult > GetOptionsIntervalMoversChangeWithHttpInfo (string source = null, DateTime? openTime = null)
        {

            var localVarPath = "/options/interval/movers/change";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (openTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_time", openTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalMoversChange", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsMoversResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsMoversResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsMoversResult)));
        }

        /// <summary>
        /// Options Intervals Movers By Change Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of OptionIntervalsMoversResult</returns>
        public async System.Threading.Tasks.Task<OptionIntervalsMoversResult> GetOptionsIntervalMoversChangeAsync (string source = null, DateTime? openTime = null)
        {
             ApiResponse<OptionIntervalsMoversResult> localVarResponse = await GetOptionsIntervalMoversChangeAsyncWithHttpInfo(source, openTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Intervals Movers By Change Returns a list of intervals for the biggest movers by change over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsMoversResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionIntervalsMoversResult>> GetOptionsIntervalMoversChangeAsyncWithHttpInfo (string source = null, DateTime? openTime = null)
        {

            var localVarPath = "/options/interval/movers/change";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (openTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_time", openTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalMoversChange", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsMoversResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsMoversResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsMoversResult)));
        }

        /// <summary>
        /// Options Intervals Movers By Volume Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>OptionIntervalsMoversResult</returns>
        public OptionIntervalsMoversResult GetOptionsIntervalMoversVolume (string source = null, DateTime? openTime = null)
        {
             ApiResponse<OptionIntervalsMoversResult> localVarResponse = GetOptionsIntervalMoversVolumeWithHttpInfo(source, openTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Intervals Movers By Volume Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>ApiResponse of OptionIntervalsMoversResult</returns>
        
        public ApiResponse< OptionIntervalsMoversResult > GetOptionsIntervalMoversVolumeWithHttpInfo (string source = null, DateTime? openTime = null)
        {

            var localVarPath = "/options/interval/movers/volume";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (openTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_time", openTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalMoversVolume", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsMoversResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsMoversResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsMoversResult)));
        }

        /// <summary>
        /// Options Intervals Movers By Volume Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of OptionIntervalsMoversResult</returns>
        public async System.Threading.Tasks.Task<OptionIntervalsMoversResult> GetOptionsIntervalMoversVolumeAsync (string source = null, DateTime? openTime = null)
        {
             ApiResponse<OptionIntervalsMoversResult> localVarResponse = await GetOptionsIntervalMoversVolumeAsyncWithHttpInfo(source, openTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Intervals Movers By Volume Returns a list of intervals for the biggest movers by volume over the last hour interval.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="openTime">The inclusive UTC date and time the interval opens at. (optional)</param>
        /// <returns>Task of ApiResponse (OptionIntervalsMoversResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionIntervalsMoversResult>> GetOptionsIntervalMoversVolumeAsyncWithHttpInfo (string source = null, DateTime? openTime = null)
        {

            var localVarPath = "/options/interval/movers/volume";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (openTime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "open_time", openTime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsIntervalMoversVolume", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionIntervalsMoversResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionIntervalsMoversResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionIntervalsMoversResult)));
        }

        /// <summary>
        /// Option Prices Returns all price data from inception to expiration for a particular contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionPrices</returns>
        public ApiResponseOptionPrices GetOptionsPrices (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionPrices> localVarResponse = GetOptionsPricesWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Returns all price data from inception to expiration for a particular contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionPrices</returns>
        
        public ApiResponse< ApiResponseOptionPrices > GetOptionsPricesWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPrices");

            var localVarPath = "/options/prices/{identifier}";
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
                Exception exception = ExceptionFactory("GetOptionsPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionPrices)));
        }

        /// <summary>
        /// Option Prices Returns all price data from inception to expiration for a particular contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionPrices</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionPrices> GetOptionsPricesAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionPrices> localVarResponse = await GetOptionsPricesAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Returns all price data from inception to expiration for a particular contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="startDate">Return option contract prices on or after this date. (optional)</param>
        /// <param name="endDate">Return option contract prices on or before this date. (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionPrices)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionPrices>> GetOptionsPricesAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPrices");

            var localVarPath = "/options/prices/{identifier}";
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
                Exception exception = ExceptionFactory("GetOptionsPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionPrices>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionPrices) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionPrices)));
        }

        /// <summary>
        /// Option Prices Batch Realtime Returns a list of latest price data for up to 250 option contracts per request.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponseOptionsPricesBatchRealtime</returns>
        public ApiResponseOptionsPricesBatchRealtime GetOptionsPricesBatchRealtime (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
             ApiResponse<ApiResponseOptionsPricesBatchRealtime> localVarResponse = GetOptionsPricesBatchRealtimeWithHttpInfo(body, source, showStats, stockPriceSource, model, showExtendedPrice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Batch Realtime Returns a list of latest price data for up to 250 option contracts per request.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesBatchRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsPricesBatchRealtime > GetOptionsPricesBatchRealtimeWithHttpInfo (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->GetOptionsPricesBatchRealtime");

            var localVarPath = "/options/prices/realtime/batch";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (showStats != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_stats", showStats)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsPricesBatchRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesBatchRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesBatchRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesBatchRealtime)));
        }

        /// <summary>
        /// Option Prices Batch Realtime Returns a list of latest price data for up to 250 option contracts per request.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesBatchRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsPricesBatchRealtime> GetOptionsPricesBatchRealtimeAsync (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
             ApiResponse<ApiResponseOptionsPricesBatchRealtime> localVarResponse = await GetOptionsPricesBatchRealtimeAsyncWithHttpInfo(body, source, showStats, stockPriceSource, model, showExtendedPrice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Batch Realtime Returns a list of latest price data for up to 250 option contracts per request.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">The contract symbols for which to return options prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showStats">Whether to include Greek calculations or not. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesBatchRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesBatchRealtime>> GetOptionsPricesBatchRealtimeAsyncWithHttpInfo (OptionContractsList body, string source = null, bool? showStats = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OptionsApi->GetOptionsPricesBatchRealtime");

            var localVarPath = "/options/prices/realtime/batch";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (showStats != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_stats", showStats)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOptionsPricesBatchRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesBatchRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesBatchRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesBatchRealtime)));
        }

        /// <summary>
        /// Option Prices EOD Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>ApiResponseOptionsPricesEod</returns>
        public ApiResponseOptionsPricesEod GetOptionsPricesEod (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null)
        {
             ApiResponse<ApiResponseOptionsPricesEod> localVarResponse = GetOptionsPricesEodWithHttpInfo(identifier, nextPage, startDate, endDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices EOD Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesEod</returns>
        
        public ApiResponse< ApiResponseOptionsPricesEod > GetOptionsPricesEodWithHttpInfo (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPricesEod");

            var localVarPath = "/options/prices/{identifier}/eod";
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
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsPricesEod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesEod>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesEod) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesEod)));
        }

        /// <summary>
        /// Option Prices EOD Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesEod</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsPricesEod> GetOptionsPricesEodAsync (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null)
        {
             ApiResponse<ApiResponseOptionsPricesEod> localVarResponse = await GetOptionsPricesEodAsyncWithHttpInfo(identifier, nextPage, startDate, endDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices EOD Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="startDate">The start date to retrieve prices for (optional)</param>
        /// <param name="endDate">The end date to retrieve prices for (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesEod)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesEod>> GetOptionsPricesEodAsyncWithHttpInfo (string identifier, string nextPage = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPricesEod");

            var localVarPath = "/options/prices/{identifier}/eod";
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
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsPricesEod", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesEod>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesEod) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesEod)));
        }

        /// <summary>
        /// Option Prices End of Day By Ticker Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseOptionsPricesByTickerEod</returns>
        public ApiResponseOptionsPricesByTickerEod GetOptionsPricesEodByTicker (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionsPricesByTickerEod> localVarResponse = GetOptionsPricesEodByTickerWithHttpInfo(symbol, pageSize, date, type, strike, strikeGreaterThan, strikeLessThan, includeRelatedSymbols, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices End of Day By Ticker Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesByTickerEod</returns>
        
        public ApiResponse< ApiResponseOptionsPricesByTickerEod > GetOptionsPricesEodByTickerWithHttpInfo (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsPricesEodByTicker");

            var localVarPath = "/options/prices/by_ticker/{symbol}/eod";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionsPricesEodByTicker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesByTickerEod>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesByTickerEod) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesByTickerEod)));
        }

        /// <summary>
        /// Option Prices End of Day By Ticker Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesByTickerEod</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsPricesByTickerEod> GetOptionsPricesEodByTickerAsync (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null)
        {
             ApiResponse<ApiResponseOptionsPricesByTickerEod> localVarResponse = await GetOptionsPricesEodByTickerAsyncWithHttpInfo(symbol, pageSize, date, type, strike, strikeGreaterThan, strikeLessThan, includeRelatedSymbols, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices End of Day By Ticker Returns a list of end of day pricing information for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="date">The date to get pricing data for. Defaults to today in Eastern time zone. (optional)</param>
        /// <param name="type">The option contract type. (optional)</param>
        /// <param name="strike">The strike price of the option contract. This will return options contracts with strike price equal to this price. (optional)</param>
        /// <param name="strikeGreaterThan">The strike price of the option contract. This will return options contracts with strike prices greater than this price. (optional)</param>
        /// <param name="strikeLessThan">The strike price of the option contract. This will return options contracts with strike prices less than this price. (optional)</param>
        /// <param name="includeRelatedSymbols">Include related symbols that end in a 1 or 2 because of a corporate action. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesByTickerEod)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesByTickerEod>> GetOptionsPricesEodByTickerAsyncWithHttpInfo (string symbol, int? pageSize = null, Object date = null, string type = null, decimal? strike = null, decimal? strikeGreaterThan = null, decimal? strikeLessThan = null, bool? includeRelatedSymbols = null, string nextPage = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsPricesEodByTicker");

            var localVarPath = "/options/prices/by_ticker/{symbol}/eod";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (date != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "date", date)); // query parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (strike != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike", strike)); // query parameter
            if (strikeGreaterThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_greater_than", strikeGreaterThan)); // query parameter
            if (strikeLessThan != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "strike_less_than", strikeLessThan)); // query parameter
            if (includeRelatedSymbols != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "include_related_symbols", includeRelatedSymbols)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionsPricesEodByTicker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesByTickerEod>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesByTickerEod) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesByTickerEod)));
        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponseOptionsPriceRealtime</returns>
        public ApiResponseOptionsPriceRealtime GetOptionsPricesRealtime (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
             ApiResponse<ApiResponseOptionsPriceRealtime> localVarResponse = GetOptionsPricesRealtimeWithHttpInfo(identifier, source, stockPriceSource, model, showExtendedPrice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPriceRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsPriceRealtime > GetOptionsPricesRealtimeWithHttpInfo (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPricesRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime";
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
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsPricesRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPriceRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPriceRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPriceRealtime)));
        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPriceRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsPriceRealtime> GetOptionsPricesRealtimeAsync (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
             ApiResponse<ApiResponseOptionsPriceRealtime> localVarResponse = await GetOptionsPricesRealtimeAsyncWithHttpInfo(identifier, source, stockPriceSource, model, showExtendedPrice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Realtime Returns all option prices for a given option contract identifier.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPriceRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPriceRealtime>> GetOptionsPricesRealtimeAsyncWithHttpInfo (string identifier, string source = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsPricesRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime";
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
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsPricesRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPriceRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPriceRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPriceRealtime)));
        }

        /// <summary>
        /// Option Prices Realtime By Ticker Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>ApiResponseOptionsPricesByTickerRealtime</returns>
        public ApiResponseOptionsPricesByTickerRealtime GetOptionsPricesRealtimeByTicker (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null)
        {
             ApiResponse<ApiResponseOptionsPricesByTickerRealtime> localVarResponse = GetOptionsPricesRealtimeByTickerWithHttpInfo(symbol, source, ivMode, nextPage, pageSize, stockPriceSource, model, showExtendedPrice, expirationStartDate, expirationEndDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Realtime By Ticker Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsPricesByTickerRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsPricesByTickerRealtime > GetOptionsPricesRealtimeByTickerWithHttpInfo (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsPricesRealtimeByTicker");

            var localVarPath = "/options/prices/by_ticker/{symbol}/realtime";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (ivMode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "iv_mode", ivMode)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (expirationStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_start_date", expirationStartDate)); // query parameter
            if (expirationEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_end_date", expirationEndDate)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsPricesRealtimeByTicker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesByTickerRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesByTickerRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesByTickerRealtime)));
        }

        /// <summary>
        /// Option Prices Realtime By Ticker Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>Task of ApiResponseOptionsPricesByTickerRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsPricesByTickerRealtime> GetOptionsPricesRealtimeByTickerAsync (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null)
        {
             ApiResponse<ApiResponseOptionsPricesByTickerRealtime> localVarResponse = await GetOptionsPricesRealtimeByTickerAsyncWithHttpInfo(symbol, source, ivMode, nextPage, pageSize, stockPriceSource, model, showExtendedPrice, expirationStartDate, expirationEndDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Realtime By Ticker Returns a list of the latest National Best Bid &amp; Offer (NBBO) top of the order book size and premium (bid / ask), the latest trade size and premium as well as the greeks and implied volatility for all option contracts currently associated with the ticker.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The equities ticker symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="ivMode">Change the mode for the implied volatility calculation to out of the money. (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 250)</param>
        /// <param name="stockPriceSource">Source for underlying price for calculating Greeks. (optional)</param>
        /// <param name="model">Model for calculating Greek values. Default is black_scholes. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <param name="expirationStartDate">Filter out contracts that expire before this date. (optional)</param>
        /// <param name="expirationEndDate">Filter out contracts that expire after this date. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsPricesByTickerRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsPricesByTickerRealtime>> GetOptionsPricesRealtimeByTickerAsyncWithHttpInfo (string symbol, string source = null, string ivMode = null, string nextPage = null, int? pageSize = null, string stockPriceSource = null, string model = null, bool? showExtendedPrice = null, Object expirationStartDate = null, Object expirationEndDate = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetOptionsPricesRealtimeByTicker");

            var localVarPath = "/options/prices/by_ticker/{symbol}/realtime";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (ivMode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "iv_mode", ivMode)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (stockPriceSource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "stock_price_source", stockPriceSource)); // query parameter
            if (model != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "model", model)); // query parameter
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter
            if (expirationStartDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_start_date", expirationStartDate)); // query parameter
            if (expirationEndDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "expiration_end_date", expirationEndDate)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsPricesRealtimeByTicker", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsPricesByTickerRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsPricesByTickerRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsPricesByTickerRealtime)));
        }

        /// <summary>
        /// Option Prices Realtime Snapshot Returns all options snapshots for the queried interval with links to download.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>OptionSnapshotsResult</returns>
        public OptionSnapshotsResult GetOptionsSnapshots (string source = null, DateTime? atDatetime = null)
        {
             ApiResponse<OptionSnapshotsResult> localVarResponse = GetOptionsSnapshotsWithHttpInfo(source, atDatetime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Prices Realtime Snapshot Returns all options snapshots for the queried interval with links to download.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>ApiResponse of OptionSnapshotsResult</returns>
        
        public ApiResponse< OptionSnapshotsResult > GetOptionsSnapshotsWithHttpInfo (string source = null, DateTime? atDatetime = null)
        {

            var localVarPath = "/options/snapshots";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (atDatetime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "at_datetime", atDatetime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsSnapshots", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionSnapshotsResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionSnapshotsResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionSnapshotsResult)));
        }

        /// <summary>
        /// Option Prices Realtime Snapshot Returns all options snapshots for the queried interval with links to download.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>Task of OptionSnapshotsResult</returns>
        public async System.Threading.Tasks.Task<OptionSnapshotsResult> GetOptionsSnapshotsAsync (string source = null, DateTime? atDatetime = null)
        {
             ApiResponse<OptionSnapshotsResult> localVarResponse = await GetOptionsSnapshotsAsyncWithHttpInfo(source, atDatetime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Prices Realtime Snapshot Returns all options snapshots for the queried interval with links to download.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="atDatetime">The UTC date and time (with url-encoded spaces) the snapshot will cover. (optional)</param>
        /// <returns>Task of ApiResponse (OptionSnapshotsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionSnapshotsResult>> GetOptionsSnapshotsAsyncWithHttpInfo (string source = null, DateTime? atDatetime = null)
        {

            var localVarPath = "/options/snapshots";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter
            if (atDatetime != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "at_datetime", atDatetime)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsSnapshots", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionSnapshotsResult>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (OptionSnapshotsResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionSnapshotsResult)));
        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponseOptionsStatsRealtime</returns>
        public ApiResponseOptionsStatsRealtime GetOptionsStatsRealtime (string identifier, string source = null, bool? showExtendedPrice = null)
        {
             ApiResponse<ApiResponseOptionsStatsRealtime> localVarResponse = GetOptionsStatsRealtimeWithHttpInfo(identifier, source, showExtendedPrice);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsStatsRealtime</returns>
        
        public ApiResponse< ApiResponseOptionsStatsRealtime > GetOptionsStatsRealtimeWithHttpInfo (string identifier, string source = null, bool? showExtendedPrice = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsStatsRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime/stats";
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
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsStatsRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsStatsRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsStatsRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsStatsRealtime)));
        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponseOptionsStatsRealtime</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsStatsRealtime> GetOptionsStatsRealtimeAsync (string identifier, string source = null, bool? showExtendedPrice = null)
        {
             ApiResponse<ApiResponseOptionsStatsRealtime> localVarResponse = await GetOptionsStatsRealtimeAsyncWithHttpInfo(identifier, source, showExtendedPrice);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Option Stats Realtime Returns all option stats (greeks and implied volatility) as well as the underlying factors used to calculate them, for a particular option contract.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">The Intrinio ID or code of the options contract to request prices for.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <param name="showExtendedPrice">Whether to include open close high low type fields. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsStatsRealtime)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsStatsRealtime>> GetOptionsStatsRealtimeAsyncWithHttpInfo (string identifier, string source = null, bool? showExtendedPrice = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling OptionsApi->GetOptionsStatsRealtime");

            var localVarPath = "/options/prices/{identifier}/realtime/stats";
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
            if (showExtendedPrice != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "show_extended_price", showExtendedPrice)); // query parameter

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
                Exception exception = ExceptionFactory("GetOptionsStatsRealtime", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsStatsRealtime>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsStatsRealtime) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsStatsRealtime)));
        }

        /// <summary>
        /// Options Unusual Activity Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        public ApiResponseOptionsUnusualActivity GetUnusualActivity (string symbol, string source = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = GetUnusualActivityWithHttpInfo(symbol, source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Unusual Activity Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        
        public ApiResponse< ApiResponseOptionsUnusualActivity > GetUnusualActivityWithHttpInfo (string symbol, string source = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetUnusualActivity");

            var localVarPath = "/options/unusual_activity/{symbol}";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivity", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityAsync (string symbol, string source = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = await GetUnusualActivityAsyncWithHttpInfo(symbol, source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Unusual Activity Returns unusual options activity for a particular company across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityAsyncWithHttpInfo (string symbol, string source = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetUnusualActivity");

            var localVarPath = "/options/unusual_activity/{symbol}";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivity", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Intraday Returns unusual trades for a given identifier within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        public ApiResponseOptionsUnusualActivity GetUnusualActivityIntraday (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = GetUnusualActivityIntradayWithHttpInfo(symbol, nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Unusual Activity Intraday Returns unusual trades for a given identifier within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        
        public ApiResponse< ApiResponseOptionsUnusualActivity > GetUnusualActivityIntradayWithHttpInfo (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetUnusualActivityIntraday");

            var localVarPath = "/options/unusual_activity/{symbol}/intraday";
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
            
            
            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (activityType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "activity_type", activityType)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (minimumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "minimum_total_value", minimumTotalValue)); // query parameter
            if (maximumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "maximum_total_value", maximumTotalValue)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivityIntraday", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Intraday Returns unusual trades for a given identifier within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityIntradayAsync (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = await GetUnusualActivityIntradayAsyncWithHttpInfo(symbol, nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Unusual Activity Intraday Returns unusual trades for a given identifier within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">The option symbol, corresponding to the underlying security.</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityIntradayAsyncWithHttpInfo (string symbol, string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {
            // verify the required parameter 'symbol' is set
            if (symbol == null)
                throw new ApiException(400, "Missing required parameter 'symbol' when calling OptionsApi->GetUnusualActivityIntraday");

            var localVarPath = "/options/unusual_activity/{symbol}/intraday";
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
              

            if (symbol != null) localVarPathParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // path parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (activityType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "activity_type", activityType)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (minimumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "minimum_total_value", minimumTotalValue)); // query parameter
            if (maximumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "maximum_total_value", maximumTotalValue)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivityIntraday", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Universal Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        public ApiResponseOptionsUnusualActivity GetUnusualActivityUniversal (string source = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = GetUnusualActivityUniversalWithHttpInfo(source);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Unusual Activity Universal Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        
        public ApiResponse< ApiResponseOptionsUnusualActivity > GetUnusualActivityUniversalWithHttpInfo (string source = null)
        {

            var localVarPath = "/options/unusual_activity";
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
            
            
            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivityUniversal", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Universal Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityUniversalAsync (string source = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = await GetUnusualActivityUniversalAsyncWithHttpInfo(source);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Unusual Activity Universal Returns the latest unusual options activity across all US companies with across all option chains. Unusual options activity includes large trades, sweeps, and block trades.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="source">Realtime or 15-minute delayed contracts. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityUniversalAsyncWithHttpInfo (string source = null)
        {

            var localVarPath = "/options/unusual_activity";
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
              

            if (source != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "source", source)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivityUniversal", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Universal Intraday Returns unusual trades for all underlying security symbols within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponseOptionsUnusualActivity</returns>
        public ApiResponseOptionsUnusualActivity GetUnusualActivityUniversalIntraday (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = GetUnusualActivityUniversalIntradayWithHttpInfo(nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Options Unusual Activity Universal Intraday Returns unusual trades for all underlying security symbols within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>ApiResponse of ApiResponseOptionsUnusualActivity</returns>
        
        public ApiResponse< ApiResponseOptionsUnusualActivity > GetUnusualActivityUniversalIntradayWithHttpInfo (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {

            var localVarPath = "/options/unusual_activity/intraday";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (activityType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "activity_type", activityType)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (minimumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "minimum_total_value", minimumTotalValue)); // query parameter
            if (maximumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "maximum_total_value", maximumTotalValue)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivityUniversalIntraday", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

        /// <summary>
        /// Options Unusual Activity Universal Intraday Returns unusual trades for all underlying security symbols within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponseOptionsUnusualActivity</returns>
        public async System.Threading.Tasks.Task<ApiResponseOptionsUnusualActivity> GetUnusualActivityUniversalIntradayAsync (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {
             ApiResponse<ApiResponseOptionsUnusualActivity> localVarResponse = await GetUnusualActivityUniversalIntradayAsyncWithHttpInfo(nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Options Unusual Activity Universal Intraday Returns unusual trades for all underlying security symbols within the query parameters.
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 1000)</param>
        /// <param name="activityType">The unusual activity type to query for. (optional)</param>
        /// <param name="sentiment">The sentiment type to query for. (optional)</param>
        /// <param name="startDate">Return unusual activity on or after this date. (optional)</param>
        /// <param name="endDate">Return unusual activity on or before this date. (optional)</param>
        /// <param name="minimumTotalValue">The inclusive minimum total value for the unusual activity. (optional)</param>
        /// <param name="maximumTotalValue">The inclusive maximum total value for the unusual activity. (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseOptionsUnusualActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseOptionsUnusualActivity>> GetUnusualActivityUniversalIntradayAsyncWithHttpInfo (string nextPage = null, int? pageSize = null, string activityType = null, string sentiment = null, DateTime? startDate = null, DateTime? endDate = null, Object minimumTotalValue = null, Object maximumTotalValue = null)
        {

            var localVarPath = "/options/unusual_activity/intraday";
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
            if (pageSize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
            if (activityType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "activity_type", activityType)); // query parameter
            if (sentiment != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sentiment", sentiment)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (minimumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "minimum_total_value", minimumTotalValue)); // query parameter
            if (maximumTotalValue != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "maximum_total_value", maximumTotalValue)); // query parameter

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
                Exception exception = ExceptionFactory("GetUnusualActivityUniversalIntraday", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseOptionsUnusualActivity>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseOptionsUnusualActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseOptionsUnusualActivity)));
        }

    }
}

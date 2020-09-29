

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
    public interface ITechnicalApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Accumulation/Distribution Index
        /// </summary>
        /// <remarks>
        /// Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAccumulationDistributionIndex</returns>
        ApiResponseSecurityAccumulationDistributionIndex GetSecurityPriceTechnicalsAdi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Accumulation/Distribution Index
        /// </summary>
        /// <remarks>
        /// Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAccumulationDistributionIndex</returns>
        ApiResponse<ApiResponseSecurityAccumulationDistributionIndex> GetSecurityPriceTechnicalsAdiWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Average Daily Trading Volume
        /// </summary>
        /// <remarks>
        /// Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAverageDailyTradingVolume</returns>
        ApiResponseSecurityAverageDailyTradingVolume GetSecurityPriceTechnicalsAdtv (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Average Daily Trading Volume
        /// </summary>
        /// <remarks>
        /// Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAverageDailyTradingVolume</returns>
        ApiResponse<ApiResponseSecurityAverageDailyTradingVolume> GetSecurityPriceTechnicalsAdtvWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Average Directional Index
        /// </summary>
        /// <remarks>
        /// Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAverageDirectionalIndex</returns>
        ApiResponseSecurityAverageDirectionalIndex GetSecurityPriceTechnicalsAdx (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Average Directional Index
        /// </summary>
        /// <remarks>
        /// Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAverageDirectionalIndex</returns>
        ApiResponse<ApiResponseSecurityAverageDirectionalIndex> GetSecurityPriceTechnicalsAdxWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Awesome Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAwesomeOscillator</returns>
        ApiResponseSecurityAwesomeOscillator GetSecurityPriceTechnicalsAo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Awesome Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAwesomeOscillator</returns>
        ApiResponse<ApiResponseSecurityAwesomeOscillator> GetSecurityPriceTechnicalsAoWithHttpInfo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Average True Range
        /// </summary>
        /// <remarks>
        /// Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAverageTrueRange</returns>
        ApiResponseSecurityAverageTrueRange GetSecurityPriceTechnicalsAtr (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Average True Range
        /// </summary>
        /// <remarks>
        /// Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAverageTrueRange</returns>
        ApiResponse<ApiResponseSecurityAverageTrueRange> GetSecurityPriceTechnicalsAtrWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Bollinger Bands
        /// </summary>
        /// <remarks>
        /// Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityBollingerBands</returns>
        ApiResponseSecurityBollingerBands GetSecurityPriceTechnicalsBb (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Bollinger Bands
        /// </summary>
        /// <remarks>
        /// Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityBollingerBands</returns>
        ApiResponse<ApiResponseSecurityBollingerBands> GetSecurityPriceTechnicalsBbWithHttpInfo (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Commodity Channel Index
        /// </summary>
        /// <remarks>
        /// Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityCommodityChannelIndex</returns>
        ApiResponseSecurityCommodityChannelIndex GetSecurityPriceTechnicalsCci (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Commodity Channel Index
        /// </summary>
        /// <remarks>
        /// Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityCommodityChannelIndex</returns>
        ApiResponse<ApiResponseSecurityCommodityChannelIndex> GetSecurityPriceTechnicalsCciWithHttpInfo (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Chaikin Money Flow
        /// </summary>
        /// <remarks>
        /// Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityChaikinMoneyFlow</returns>
        ApiResponseSecurityChaikinMoneyFlow GetSecurityPriceTechnicalsCmf (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Chaikin Money Flow
        /// </summary>
        /// <remarks>
        /// Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityChaikinMoneyFlow</returns>
        ApiResponse<ApiResponseSecurityChaikinMoneyFlow> GetSecurityPriceTechnicalsCmfWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Donchian Channel
        /// </summary>
        /// <remarks>
        /// Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityDonchianChannel</returns>
        ApiResponseSecurityDonchianChannel GetSecurityPriceTechnicalsDc (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Donchian Channel
        /// </summary>
        /// <remarks>
        /// Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityDonchianChannel</returns>
        ApiResponse<ApiResponseSecurityDonchianChannel> GetSecurityPriceTechnicalsDcWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Detrended Price Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityDetrendedPriceOscillator</returns>
        ApiResponseSecurityDetrendedPriceOscillator GetSecurityPriceTechnicalsDpo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Detrended Price Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityDetrendedPriceOscillator</returns>
        ApiResponse<ApiResponseSecurityDetrendedPriceOscillator> GetSecurityPriceTechnicalsDpoWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Ease of Movement
        /// </summary>
        /// <remarks>
        /// Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityEaseOfMovement</returns>
        ApiResponseSecurityEaseOfMovement GetSecurityPriceTechnicalsEom (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Ease of Movement
        /// </summary>
        /// <remarks>
        /// Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityEaseOfMovement</returns>
        ApiResponse<ApiResponseSecurityEaseOfMovement> GetSecurityPriceTechnicalsEomWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Force Index
        /// </summary>
        /// <remarks>
        /// Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityForceIndex</returns>
        ApiResponseSecurityForceIndex GetSecurityPriceTechnicalsFi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Force Index
        /// </summary>
        /// <remarks>
        /// Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityForceIndex</returns>
        ApiResponse<ApiResponseSecurityForceIndex> GetSecurityPriceTechnicalsFiWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Ichimoku Kinko Hyo
        /// </summary>
        /// <remarks>
        /// Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityIchimokuKinkoHyo</returns>
        ApiResponseSecurityIchimokuKinkoHyo GetSecurityPriceTechnicalsIchimoku (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Ichimoku Kinko Hyo
        /// </summary>
        /// <remarks>
        /// Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityIchimokuKinkoHyo</returns>
        ApiResponse<ApiResponseSecurityIchimokuKinkoHyo> GetSecurityPriceTechnicalsIchimokuWithHttpInfo (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Keltner Channel
        /// </summary>
        /// <remarks>
        /// Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityKeltnerChannel</returns>
        ApiResponseSecurityKeltnerChannel GetSecurityPriceTechnicalsKc (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Keltner Channel
        /// </summary>
        /// <remarks>
        /// Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityKeltnerChannel</returns>
        ApiResponse<ApiResponseSecurityKeltnerChannel> GetSecurityPriceTechnicalsKcWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Know Sure Thing
        /// </summary>
        /// <remarks>
        /// Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityKnowSureThing</returns>
        ApiResponseSecurityKnowSureThing GetSecurityPriceTechnicalsKst (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Know Sure Thing
        /// </summary>
        /// <remarks>
        /// Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityKnowSureThing</returns>
        ApiResponse<ApiResponseSecurityKnowSureThing> GetSecurityPriceTechnicalsKstWithHttpInfo (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Moving Average Convergence Divergence
        /// </summary>
        /// <remarks>
        /// Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
        ApiResponseSecurityMovingAverageConvergenceDivergence GetSecurityPriceTechnicalsMacd (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Moving Average Convergence Divergence
        /// </summary>
        /// <remarks>
        /// Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
        ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence> GetSecurityPriceTechnicalsMacdWithHttpInfo (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Money Flow Index
        /// </summary>
        /// <remarks>
        /// Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityMoneyFlowIndex</returns>
        ApiResponseSecurityMoneyFlowIndex GetSecurityPriceTechnicalsMfi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Money Flow Index
        /// </summary>
        /// <remarks>
        /// Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityMoneyFlowIndex</returns>
        ApiResponse<ApiResponseSecurityMoneyFlowIndex> GetSecurityPriceTechnicalsMfiWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Mass Index
        /// </summary>
        /// <remarks>
        /// Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityMassIndex</returns>
        ApiResponseSecurityMassIndex GetSecurityPriceTechnicalsMi (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Mass Index
        /// </summary>
        /// <remarks>
        /// Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityMassIndex</returns>
        ApiResponse<ApiResponseSecurityMassIndex> GetSecurityPriceTechnicalsMiWithHttpInfo (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Negative Volume Index
        /// </summary>
        /// <remarks>
        /// Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityNegativeVolumeIndex</returns>
        ApiResponseSecurityNegativeVolumeIndex GetSecurityPriceTechnicalsNvi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Negative Volume Index
        /// </summary>
        /// <remarks>
        /// Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityNegativeVolumeIndex</returns>
        ApiResponse<ApiResponseSecurityNegativeVolumeIndex> GetSecurityPriceTechnicalsNviWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// On-balance Volume
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityOnBalanceVolume</returns>
        ApiResponseSecurityOnBalanceVolume GetSecurityPriceTechnicalsObv (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// On-balance Volume
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityOnBalanceVolume</returns>
        ApiResponse<ApiResponseSecurityOnBalanceVolume> GetSecurityPriceTechnicalsObvWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// On-balance Volume Mean
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityOnBalanceVolumeMean</returns>
        ApiResponseSecurityOnBalanceVolumeMean GetSecurityPriceTechnicalsObvMean (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// On-balance Volume Mean
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityOnBalanceVolumeMean</returns>
        ApiResponse<ApiResponseSecurityOnBalanceVolumeMean> GetSecurityPriceTechnicalsObvMeanWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Relative Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityRelativeStrengthIndex</returns>
        ApiResponseSecurityRelativeStrengthIndex GetSecurityPriceTechnicalsRsi (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Relative Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityRelativeStrengthIndex</returns>
        ApiResponse<ApiResponseSecurityRelativeStrengthIndex> GetSecurityPriceTechnicalsRsiWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Simple Moving Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecuritySimpleMovingAverage</returns>
        ApiResponseSecuritySimpleMovingAverage GetSecurityPriceTechnicalsSma (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Simple Moving Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecuritySimpleMovingAverage</returns>
        ApiResponse<ApiResponseSecuritySimpleMovingAverage> GetSecurityPriceTechnicalsSmaWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Stochastic Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityStochasticOscillator</returns>
        ApiResponseSecurityStochasticOscillator GetSecurityPriceTechnicalsSr (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Stochastic Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityStochasticOscillator</returns>
        ApiResponse<ApiResponseSecurityStochasticOscillator> GetSecurityPriceTechnicalsSrWithHttpInfo (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Triple Exponential Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityTripleExponentialAverage</returns>
        ApiResponseSecurityTripleExponentialAverage GetSecurityPriceTechnicalsTrix (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Triple Exponential Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityTripleExponentialAverage</returns>
        ApiResponse<ApiResponseSecurityTripleExponentialAverage> GetSecurityPriceTechnicalsTrixWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// True Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityTrueStrengthIndex</returns>
        ApiResponseSecurityTrueStrengthIndex GetSecurityPriceTechnicalsTsi (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// True Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityTrueStrengthIndex</returns>
        ApiResponse<ApiResponseSecurityTrueStrengthIndex> GetSecurityPriceTechnicalsTsiWithHttpInfo (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Ultimate Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityUltimateOscillator</returns>
        ApiResponseSecurityUltimateOscillator GetSecurityPriceTechnicalsUo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Ultimate Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityUltimateOscillator</returns>
        ApiResponse<ApiResponseSecurityUltimateOscillator> GetSecurityPriceTechnicalsUoWithHttpInfo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Vortex Indicator
        /// </summary>
        /// <remarks>
        /// Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityVortexIndicator</returns>
        ApiResponseSecurityVortexIndicator GetSecurityPriceTechnicalsVi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Vortex Indicator
        /// </summary>
        /// <remarks>
        /// Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityVortexIndicator</returns>
        ApiResponse<ApiResponseSecurityVortexIndicator> GetSecurityPriceTechnicalsViWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Volume-price Trend
        /// </summary>
        /// <remarks>
        /// Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityVolumePriceTrend</returns>
        ApiResponseSecurityVolumePriceTrend GetSecurityPriceTechnicalsVpt (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Volume-price Trend
        /// </summary>
        /// <remarks>
        /// Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityVolumePriceTrend</returns>
        ApiResponse<ApiResponseSecurityVolumePriceTrend> GetSecurityPriceTechnicalsVptWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Volume Weighted Average Price
        /// </summary>
        /// <remarks>
        /// Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityVolumeWeightedAveragePrice</returns>
        ApiResponseSecurityVolumeWeightedAveragePrice GetSecurityPriceTechnicalsVwap (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Volume Weighted Average Price
        /// </summary>
        /// <remarks>
        /// Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityVolumeWeightedAveragePrice</returns>
        ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice> GetSecurityPriceTechnicalsVwapWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Williams %R
        /// </summary>
        /// <remarks>
        /// Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityWilliamsR</returns>
        ApiResponseSecurityWilliamsR GetSecurityPriceTechnicalsWr (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null);

        /// <summary>
        /// Williams %R
        /// </summary>
        /// <remarks>
        /// Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityWilliamsR</returns>
        ApiResponse<ApiResponseSecurityWilliamsR> GetSecurityPriceTechnicalsWrWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Accumulation/Distribution Index
        /// </summary>
        /// <remarks>
        /// Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAccumulationDistributionIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityAccumulationDistributionIndex> GetSecurityPriceTechnicalsAdiAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Accumulation/Distribution Index
        /// </summary>
        /// <remarks>
        /// Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAccumulationDistributionIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>> GetSecurityPriceTechnicalsAdiAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Average Daily Trading Volume
        /// </summary>
        /// <remarks>
        /// Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAverageDailyTradingVolume</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityAverageDailyTradingVolume> GetSecurityPriceTechnicalsAdtvAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Average Daily Trading Volume
        /// </summary>
        /// <remarks>
        /// Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAverageDailyTradingVolume)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>> GetSecurityPriceTechnicalsAdtvAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Average Directional Index
        /// </summary>
        /// <remarks>
        /// Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAverageDirectionalIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityAverageDirectionalIndex> GetSecurityPriceTechnicalsAdxAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Average Directional Index
        /// </summary>
        /// <remarks>
        /// Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAverageDirectionalIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAverageDirectionalIndex>> GetSecurityPriceTechnicalsAdxAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Awesome Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAwesomeOscillator</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityAwesomeOscillator> GetSecurityPriceTechnicalsAoAsync (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Awesome Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAwesomeOscillator)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAwesomeOscillator>> GetSecurityPriceTechnicalsAoAsyncWithHttpInfo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Average True Range
        /// </summary>
        /// <remarks>
        /// Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAverageTrueRange</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityAverageTrueRange> GetSecurityPriceTechnicalsAtrAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Average True Range
        /// </summary>
        /// <remarks>
        /// Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAverageTrueRange)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAverageTrueRange>> GetSecurityPriceTechnicalsAtrAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Bollinger Bands
        /// </summary>
        /// <remarks>
        /// Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityBollingerBands</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityBollingerBands> GetSecurityPriceTechnicalsBbAsync (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Bollinger Bands
        /// </summary>
        /// <remarks>
        /// Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityBollingerBands)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityBollingerBands>> GetSecurityPriceTechnicalsBbAsyncWithHttpInfo (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Commodity Channel Index
        /// </summary>
        /// <remarks>
        /// Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityCommodityChannelIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityCommodityChannelIndex> GetSecurityPriceTechnicalsCciAsync (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Commodity Channel Index
        /// </summary>
        /// <remarks>
        /// Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityCommodityChannelIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityCommodityChannelIndex>> GetSecurityPriceTechnicalsCciAsyncWithHttpInfo (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Chaikin Money Flow
        /// </summary>
        /// <remarks>
        /// Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityChaikinMoneyFlow</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityChaikinMoneyFlow> GetSecurityPriceTechnicalsCmfAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Chaikin Money Flow
        /// </summary>
        /// <remarks>
        /// Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityChaikinMoneyFlow)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityChaikinMoneyFlow>> GetSecurityPriceTechnicalsCmfAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Donchian Channel
        /// </summary>
        /// <remarks>
        /// Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityDonchianChannel</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityDonchianChannel> GetSecurityPriceTechnicalsDcAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Donchian Channel
        /// </summary>
        /// <remarks>
        /// Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityDonchianChannel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityDonchianChannel>> GetSecurityPriceTechnicalsDcAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Detrended Price Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityDetrendedPriceOscillator</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityDetrendedPriceOscillator> GetSecurityPriceTechnicalsDpoAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Detrended Price Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityDetrendedPriceOscillator)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>> GetSecurityPriceTechnicalsDpoAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Ease of Movement
        /// </summary>
        /// <remarks>
        /// Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityEaseOfMovement</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityEaseOfMovement> GetSecurityPriceTechnicalsEomAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Ease of Movement
        /// </summary>
        /// <remarks>
        /// Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityEaseOfMovement)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityEaseOfMovement>> GetSecurityPriceTechnicalsEomAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Force Index
        /// </summary>
        /// <remarks>
        /// Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityForceIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityForceIndex> GetSecurityPriceTechnicalsFiAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Force Index
        /// </summary>
        /// <remarks>
        /// Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityForceIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityForceIndex>> GetSecurityPriceTechnicalsFiAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Ichimoku Kinko Hyo
        /// </summary>
        /// <remarks>
        /// Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityIchimokuKinkoHyo</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityIchimokuKinkoHyo> GetSecurityPriceTechnicalsIchimokuAsync (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Ichimoku Kinko Hyo
        /// </summary>
        /// <remarks>
        /// Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityIchimokuKinkoHyo)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>> GetSecurityPriceTechnicalsIchimokuAsyncWithHttpInfo (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Keltner Channel
        /// </summary>
        /// <remarks>
        /// Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityKeltnerChannel</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityKeltnerChannel> GetSecurityPriceTechnicalsKcAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Keltner Channel
        /// </summary>
        /// <remarks>
        /// Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityKeltnerChannel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityKeltnerChannel>> GetSecurityPriceTechnicalsKcAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Know Sure Thing
        /// </summary>
        /// <remarks>
        /// Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityKnowSureThing</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityKnowSureThing> GetSecurityPriceTechnicalsKstAsync (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Know Sure Thing
        /// </summary>
        /// <remarks>
        /// Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityKnowSureThing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityKnowSureThing>> GetSecurityPriceTechnicalsKstAsyncWithHttpInfo (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Moving Average Convergence Divergence
        /// </summary>
        /// <remarks>
        /// Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityMovingAverageConvergenceDivergence> GetSecurityPriceTechnicalsMacdAsync (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Moving Average Convergence Divergence
        /// </summary>
        /// <remarks>
        /// Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityMovingAverageConvergenceDivergence)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>> GetSecurityPriceTechnicalsMacdAsyncWithHttpInfo (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Money Flow Index
        /// </summary>
        /// <remarks>
        /// Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityMoneyFlowIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityMoneyFlowIndex> GetSecurityPriceTechnicalsMfiAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Money Flow Index
        /// </summary>
        /// <remarks>
        /// Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityMoneyFlowIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityMoneyFlowIndex>> GetSecurityPriceTechnicalsMfiAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Mass Index
        /// </summary>
        /// <remarks>
        /// Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityMassIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityMassIndex> GetSecurityPriceTechnicalsMiAsync (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Mass Index
        /// </summary>
        /// <remarks>
        /// Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityMassIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityMassIndex>> GetSecurityPriceTechnicalsMiAsyncWithHttpInfo (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Negative Volume Index
        /// </summary>
        /// <remarks>
        /// Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityNegativeVolumeIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityNegativeVolumeIndex> GetSecurityPriceTechnicalsNviAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Negative Volume Index
        /// </summary>
        /// <remarks>
        /// Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityNegativeVolumeIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityNegativeVolumeIndex>> GetSecurityPriceTechnicalsNviAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// On-balance Volume
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityOnBalanceVolume</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityOnBalanceVolume> GetSecurityPriceTechnicalsObvAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// On-balance Volume
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityOnBalanceVolume)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityOnBalanceVolume>> GetSecurityPriceTechnicalsObvAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// On-balance Volume Mean
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityOnBalanceVolumeMean</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityOnBalanceVolumeMean> GetSecurityPriceTechnicalsObvMeanAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// On-balance Volume Mean
        /// </summary>
        /// <remarks>
        /// Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityOnBalanceVolumeMean)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>> GetSecurityPriceTechnicalsObvMeanAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Relative Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityRelativeStrengthIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityRelativeStrengthIndex> GetSecurityPriceTechnicalsRsiAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Relative Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityRelativeStrengthIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityRelativeStrengthIndex>> GetSecurityPriceTechnicalsRsiAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Simple Moving Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecuritySimpleMovingAverage</returns>
        System.Threading.Tasks.Task<ApiResponseSecuritySimpleMovingAverage> GetSecurityPriceTechnicalsSmaAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Simple Moving Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecuritySimpleMovingAverage)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecuritySimpleMovingAverage>> GetSecurityPriceTechnicalsSmaAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Stochastic Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityStochasticOscillator</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityStochasticOscillator> GetSecurityPriceTechnicalsSrAsync (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Stochastic Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityStochasticOscillator)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityStochasticOscillator>> GetSecurityPriceTechnicalsSrAsyncWithHttpInfo (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Triple Exponential Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityTripleExponentialAverage</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityTripleExponentialAverage> GetSecurityPriceTechnicalsTrixAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Triple Exponential Average
        /// </summary>
        /// <remarks>
        /// Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityTripleExponentialAverage)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityTripleExponentialAverage>> GetSecurityPriceTechnicalsTrixAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// True Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityTrueStrengthIndex</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityTrueStrengthIndex> GetSecurityPriceTechnicalsTsiAsync (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// True Strength Index
        /// </summary>
        /// <remarks>
        /// Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityTrueStrengthIndex)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityTrueStrengthIndex>> GetSecurityPriceTechnicalsTsiAsyncWithHttpInfo (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Ultimate Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityUltimateOscillator</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityUltimateOscillator> GetSecurityPriceTechnicalsUoAsync (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Ultimate Oscillator
        /// </summary>
        /// <remarks>
        /// Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityUltimateOscillator)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityUltimateOscillator>> GetSecurityPriceTechnicalsUoAsyncWithHttpInfo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Vortex Indicator
        /// </summary>
        /// <remarks>
        /// Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityVortexIndicator</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityVortexIndicator> GetSecurityPriceTechnicalsViAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Vortex Indicator
        /// </summary>
        /// <remarks>
        /// Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityVortexIndicator)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityVortexIndicator>> GetSecurityPriceTechnicalsViAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Volume-price Trend
        /// </summary>
        /// <remarks>
        /// Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityVolumePriceTrend</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityVolumePriceTrend> GetSecurityPriceTechnicalsVptAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Volume-price Trend
        /// </summary>
        /// <remarks>
        /// Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityVolumePriceTrend)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityVolumePriceTrend>> GetSecurityPriceTechnicalsVptAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Volume Weighted Average Price
        /// </summary>
        /// <remarks>
        /// Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityVolumeWeightedAveragePrice</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityVolumeWeightedAveragePrice> GetSecurityPriceTechnicalsVwapAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

        /// <summary>
        /// Volume Weighted Average Price
        /// </summary>
        /// <remarks>
        /// Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityVolumeWeightedAveragePrice)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>> GetSecurityPriceTechnicalsVwapAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);
        /// <summary>
        /// Williams %R
        /// </summary>
        /// <remarks>
        /// Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityWilliamsR</returns>
        System.Threading.Tasks.Task<ApiResponseSecurityWilliamsR> GetSecurityPriceTechnicalsWrAsync (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null);

        /// <summary>
        /// Williams %R
        /// </summary>
        /// <remarks>
        /// Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityWilliamsR)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityWilliamsR>> GetSecurityPriceTechnicalsWrAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TechnicalApi : ITechnicalApi
    {
        private Intrinio.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TechnicalApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TechnicalApi(Configuration configuration = null)
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
        /// Accumulation/Distribution Index Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAccumulationDistributionIndex</returns>
        public ApiResponseSecurityAccumulationDistributionIndex GetSecurityPriceTechnicalsAdi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAccumulationDistributionIndex> localVarResponse = GetSecurityPriceTechnicalsAdiWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Accumulation/Distribution Index Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAccumulationDistributionIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityAccumulationDistributionIndex > GetSecurityPriceTechnicalsAdiWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAdi");

            var localVarPath = "/securities/{identifier}/prices/technicals/adi";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAccumulationDistributionIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAccumulationDistributionIndex)));
        }

        /// <summary>
        /// Accumulation/Distribution Index Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAccumulationDistributionIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityAccumulationDistributionIndex> GetSecurityPriceTechnicalsAdiAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAccumulationDistributionIndex> localVarResponse = await GetSecurityPriceTechnicalsAdiAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Accumulation/Distribution Index Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAccumulationDistributionIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>> GetSecurityPriceTechnicalsAdiAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAdi");

            var localVarPath = "/securities/{identifier}/prices/technicals/adi";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAccumulationDistributionIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAccumulationDistributionIndex)));
        }

        /// <summary>
        /// Average Daily Trading Volume Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAverageDailyTradingVolume</returns>
        public ApiResponseSecurityAverageDailyTradingVolume GetSecurityPriceTechnicalsAdtv (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAverageDailyTradingVolume> localVarResponse = GetSecurityPriceTechnicalsAdtvWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average Daily Trading Volume Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAverageDailyTradingVolume</returns>
        
        
        public ApiResponse< ApiResponseSecurityAverageDailyTradingVolume > GetSecurityPriceTechnicalsAdtvWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAdtv");

            var localVarPath = "/securities/{identifier}/prices/technicals/adtv";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdtv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAverageDailyTradingVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDailyTradingVolume)));
        }

        /// <summary>
        /// Average Daily Trading Volume Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAverageDailyTradingVolume</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityAverageDailyTradingVolume> GetSecurityPriceTechnicalsAdtvAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAverageDailyTradingVolume> localVarResponse = await GetSecurityPriceTechnicalsAdtvAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average Daily Trading Volume Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Daily Trading Volume (optional, default to 22)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAverageDailyTradingVolume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>> GetSecurityPriceTechnicalsAdtvAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAdtv");

            var localVarPath = "/securities/{identifier}/prices/technicals/adtv";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdtv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAverageDailyTradingVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDailyTradingVolume)));
        }

        /// <summary>
        /// Average Directional Index Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAverageDirectionalIndex</returns>
        public ApiResponseSecurityAverageDirectionalIndex GetSecurityPriceTechnicalsAdx (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAverageDirectionalIndex> localVarResponse = GetSecurityPriceTechnicalsAdxWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average Directional Index Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAverageDirectionalIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityAverageDirectionalIndex > GetSecurityPriceTechnicalsAdxWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAdx");

            var localVarPath = "/securities/{identifier}/prices/technicals/adx";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDirectionalIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAverageDirectionalIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDirectionalIndex)));
        }

        /// <summary>
        /// Average Directional Index Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAverageDirectionalIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityAverageDirectionalIndex> GetSecurityPriceTechnicalsAdxAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAverageDirectionalIndex> localVarResponse = await GetSecurityPriceTechnicalsAdxAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average Directional Index Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average Directional Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAverageDirectionalIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAverageDirectionalIndex>> GetSecurityPriceTechnicalsAdxAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAdx");

            var localVarPath = "/securities/{identifier}/prices/technicals/adx";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDirectionalIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAverageDirectionalIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDirectionalIndex)));
        }

        /// <summary>
        /// Awesome Oscillator Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAwesomeOscillator</returns>
        public ApiResponseSecurityAwesomeOscillator GetSecurityPriceTechnicalsAo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAwesomeOscillator> localVarResponse = GetSecurityPriceTechnicalsAoWithHttpInfo(identifier, shortPeriod, longPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Awesome Oscillator Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAwesomeOscillator</returns>
        
        
        public ApiResponse< ApiResponseSecurityAwesomeOscillator > GetSecurityPriceTechnicalsAoWithHttpInfo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAo");

            var localVarPath = "/securities/{identifier}/prices/technicals/ao";
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
            if (shortPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "short_period", shortPeriod)); // query parameter
            if (longPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "long_period", longPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAwesomeOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAwesomeOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAwesomeOscillator)));
        }

        /// <summary>
        /// Awesome Oscillator Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAwesomeOscillator</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityAwesomeOscillator> GetSecurityPriceTechnicalsAoAsync (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAwesomeOscillator> localVarResponse = await GetSecurityPriceTechnicalsAoAsyncWithHttpInfo(identifier, shortPeriod, longPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Awesome Oscillator Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate short period Simple Moving Average of the Awesome Oscillator (optional, default to 5)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate long period Simple Moving Average of the Awesome Oscillator (optional, default to 34)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAwesomeOscillator)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAwesomeOscillator>> GetSecurityPriceTechnicalsAoAsyncWithHttpInfo (string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAo");

            var localVarPath = "/securities/{identifier}/prices/technicals/ao";
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
            if (shortPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "short_period", shortPeriod)); // query parameter
            if (longPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "long_period", longPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAwesomeOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAwesomeOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAwesomeOscillator)));
        }

        /// <summary>
        /// Average True Range Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityAverageTrueRange</returns>
        public ApiResponseSecurityAverageTrueRange GetSecurityPriceTechnicalsAtr (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAverageTrueRange> localVarResponse = GetSecurityPriceTechnicalsAtrWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average True Range Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityAverageTrueRange</returns>
        
        
        public ApiResponse< ApiResponseSecurityAverageTrueRange > GetSecurityPriceTechnicalsAtrWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAtr");

            var localVarPath = "/securities/{identifier}/prices/technicals/atr";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAtr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageTrueRange>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAverageTrueRange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageTrueRange)));
        }

        /// <summary>
        /// Average True Range Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityAverageTrueRange</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityAverageTrueRange> GetSecurityPriceTechnicalsAtrAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityAverageTrueRange> localVarResponse = await GetSecurityPriceTechnicalsAtrAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average True Range Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityAverageTrueRange)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityAverageTrueRange>> GetSecurityPriceTechnicalsAtrAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsAtr");

            var localVarPath = "/securities/{identifier}/prices/technicals/atr";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAtr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageTrueRange>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityAverageTrueRange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageTrueRange)));
        }

        /// <summary>
        /// Bollinger Bands Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityBollingerBands</returns>
        public ApiResponseSecurityBollingerBands GetSecurityPriceTechnicalsBb (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityBollingerBands> localVarResponse = GetSecurityPriceTechnicalsBbWithHttpInfo(identifier, period, standardDeviations, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bollinger Bands Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityBollingerBands</returns>
        
        
        public ApiResponse< ApiResponseSecurityBollingerBands > GetSecurityPriceTechnicalsBbWithHttpInfo (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsBb");

            var localVarPath = "/securities/{identifier}/prices/technicals/bb";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (standardDeviations != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "standard_deviations", standardDeviations)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsBb", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityBollingerBands>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityBollingerBands) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityBollingerBands)));
        }

        /// <summary>
        /// Bollinger Bands Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityBollingerBands</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityBollingerBands> GetSecurityPriceTechnicalsBbAsync (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityBollingerBands> localVarResponse = await GetSecurityPriceTechnicalsBbAsyncWithHttpInfo(identifier, period, standardDeviations, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bollinger Bands Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
        /// <param name="standardDeviations">The number of standard deviations to calculate the upper and lower bands of the Bollinger Bands (optional, default to 2.0)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityBollingerBands)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityBollingerBands>> GetSecurityPriceTechnicalsBbAsyncWithHttpInfo (string identifier, int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsBb");

            var localVarPath = "/securities/{identifier}/prices/technicals/bb";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (standardDeviations != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "standard_deviations", standardDeviations)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsBb", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityBollingerBands>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityBollingerBands) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityBollingerBands)));
        }

        /// <summary>
        /// Commodity Channel Index Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityCommodityChannelIndex</returns>
        public ApiResponseSecurityCommodityChannelIndex GetSecurityPriceTechnicalsCci (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityCommodityChannelIndex> localVarResponse = GetSecurityPriceTechnicalsCciWithHttpInfo(identifier, period, constant, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Commodity Channel Index Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityCommodityChannelIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityCommodityChannelIndex > GetSecurityPriceTechnicalsCciWithHttpInfo (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsCci");

            var localVarPath = "/securities/{identifier}/prices/technicals/cci";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (constant != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "constant", constant)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCci", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityCommodityChannelIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityCommodityChannelIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityCommodityChannelIndex)));
        }

        /// <summary>
        /// Commodity Channel Index Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityCommodityChannelIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityCommodityChannelIndex> GetSecurityPriceTechnicalsCciAsync (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityCommodityChannelIndex> localVarResponse = await GetSecurityPriceTechnicalsCciAsyncWithHttpInfo(identifier, period, constant, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Commodity Channel Index Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 20)</param>
        /// <param name="constant">The number of observations, per period, to calculate Commodity Channel Index (optional, default to 0.015)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityCommodityChannelIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityCommodityChannelIndex>> GetSecurityPriceTechnicalsCciAsyncWithHttpInfo (string identifier, int? period = null, float? constant = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsCci");

            var localVarPath = "/securities/{identifier}/prices/technicals/cci";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (constant != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "constant", constant)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCci", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityCommodityChannelIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityCommodityChannelIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityCommodityChannelIndex)));
        }

        /// <summary>
        /// Chaikin Money Flow Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityChaikinMoneyFlow</returns>
        public ApiResponseSecurityChaikinMoneyFlow GetSecurityPriceTechnicalsCmf (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityChaikinMoneyFlow> localVarResponse = GetSecurityPriceTechnicalsCmfWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Chaikin Money Flow Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityChaikinMoneyFlow</returns>
        
        
        public ApiResponse< ApiResponseSecurityChaikinMoneyFlow > GetSecurityPriceTechnicalsCmfWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsCmf");

            var localVarPath = "/securities/{identifier}/prices/technicals/cmf";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCmf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityChaikinMoneyFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityChaikinMoneyFlow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityChaikinMoneyFlow)));
        }

        /// <summary>
        /// Chaikin Money Flow Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityChaikinMoneyFlow</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityChaikinMoneyFlow> GetSecurityPriceTechnicalsCmfAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityChaikinMoneyFlow> localVarResponse = await GetSecurityPriceTechnicalsCmfAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Chaikin Money Flow Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityChaikinMoneyFlow)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityChaikinMoneyFlow>> GetSecurityPriceTechnicalsCmfAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsCmf");

            var localVarPath = "/securities/{identifier}/prices/technicals/cmf";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCmf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityChaikinMoneyFlow>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityChaikinMoneyFlow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityChaikinMoneyFlow)));
        }

        /// <summary>
        /// Donchian Channel Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityDonchianChannel</returns>
        public ApiResponseSecurityDonchianChannel GetSecurityPriceTechnicalsDc (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityDonchianChannel> localVarResponse = GetSecurityPriceTechnicalsDcWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Donchian Channel Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityDonchianChannel</returns>
        
        
        public ApiResponse< ApiResponseSecurityDonchianChannel > GetSecurityPriceTechnicalsDcWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsDc");

            var localVarPath = "/securities/{identifier}/prices/technicals/dc";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDonchianChannel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityDonchianChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDonchianChannel)));
        }

        /// <summary>
        /// Donchian Channel Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityDonchianChannel</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityDonchianChannel> GetSecurityPriceTechnicalsDcAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityDonchianChannel> localVarResponse = await GetSecurityPriceTechnicalsDcAsyncWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Donchian Channel Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityDonchianChannel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityDonchianChannel>> GetSecurityPriceTechnicalsDcAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsDc");

            var localVarPath = "/securities/{identifier}/prices/technicals/dc";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDonchianChannel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityDonchianChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDonchianChannel)));
        }

        /// <summary>
        /// Detrended Price Oscillator Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityDetrendedPriceOscillator</returns>
        public ApiResponseSecurityDetrendedPriceOscillator GetSecurityPriceTechnicalsDpo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityDetrendedPriceOscillator> localVarResponse = GetSecurityPriceTechnicalsDpoWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detrended Price Oscillator Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityDetrendedPriceOscillator</returns>
        
        
        public ApiResponse< ApiResponseSecurityDetrendedPriceOscillator > GetSecurityPriceTechnicalsDpoWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsDpo");

            var localVarPath = "/securities/{identifier}/prices/technicals/dpo";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDpo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityDetrendedPriceOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDetrendedPriceOscillator)));
        }

        /// <summary>
        /// Detrended Price Oscillator Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityDetrendedPriceOscillator</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityDetrendedPriceOscillator> GetSecurityPriceTechnicalsDpoAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityDetrendedPriceOscillator> localVarResponse = await GetSecurityPriceTechnicalsDpoAsyncWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detrended Price Oscillator Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Detrended Price Oscillator (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityDetrendedPriceOscillator)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>> GetSecurityPriceTechnicalsDpoAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsDpo");

            var localVarPath = "/securities/{identifier}/prices/technicals/dpo";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDpo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityDetrendedPriceOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDetrendedPriceOscillator)));
        }

        /// <summary>
        /// Ease of Movement Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityEaseOfMovement</returns>
        public ApiResponseSecurityEaseOfMovement GetSecurityPriceTechnicalsEom (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityEaseOfMovement> localVarResponse = GetSecurityPriceTechnicalsEomWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ease of Movement Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityEaseOfMovement</returns>
        
        
        public ApiResponse< ApiResponseSecurityEaseOfMovement > GetSecurityPriceTechnicalsEomWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsEom");

            var localVarPath = "/securities/{identifier}/prices/technicals/eom";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsEom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityEaseOfMovement>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityEaseOfMovement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityEaseOfMovement)));
        }

        /// <summary>
        /// Ease of Movement Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityEaseOfMovement</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityEaseOfMovement> GetSecurityPriceTechnicalsEomAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityEaseOfMovement> localVarResponse = await GetSecurityPriceTechnicalsEomAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ease of Movement Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityEaseOfMovement)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityEaseOfMovement>> GetSecurityPriceTechnicalsEomAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsEom");

            var localVarPath = "/securities/{identifier}/prices/technicals/eom";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsEom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityEaseOfMovement>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityEaseOfMovement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityEaseOfMovement)));
        }

        /// <summary>
        /// Force Index Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityForceIndex</returns>
        public ApiResponseSecurityForceIndex GetSecurityPriceTechnicalsFi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityForceIndex> localVarResponse = GetSecurityPriceTechnicalsFiWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Force Index Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityForceIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityForceIndex > GetSecurityPriceTechnicalsFiWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsFi");

            var localVarPath = "/securities/{identifier}/prices/technicals/fi";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsFi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityForceIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityForceIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityForceIndex)));
        }

        /// <summary>
        /// Force Index Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityForceIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityForceIndex> GetSecurityPriceTechnicalsFiAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityForceIndex> localVarResponse = await GetSecurityPriceTechnicalsFiAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Force Index Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityForceIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityForceIndex>> GetSecurityPriceTechnicalsFiAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsFi");

            var localVarPath = "/securities/{identifier}/prices/technicals/fi";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsFi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityForceIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityForceIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityForceIndex)));
        }

        /// <summary>
        /// Ichimoku Kinko Hyo Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityIchimokuKinkoHyo</returns>
        public ApiResponseSecurityIchimokuKinkoHyo GetSecurityPriceTechnicalsIchimoku (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityIchimokuKinkoHyo> localVarResponse = GetSecurityPriceTechnicalsIchimokuWithHttpInfo(identifier, lowPeriod, mediumPeriod, highPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ichimoku Kinko Hyo Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityIchimokuKinkoHyo</returns>
        
        
        public ApiResponse< ApiResponseSecurityIchimokuKinkoHyo > GetSecurityPriceTechnicalsIchimokuWithHttpInfo (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsIchimoku");

            var localVarPath = "/securities/{identifier}/prices/technicals/ichimoku";
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
            if (lowPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "low_period", lowPeriod)); // query parameter
            if (mediumPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "medium_period", mediumPeriod)); // query parameter
            if (highPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "high_period", highPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsIchimoku", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityIchimokuKinkoHyo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityIchimokuKinkoHyo)));
        }

        /// <summary>
        /// Ichimoku Kinko Hyo Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityIchimokuKinkoHyo</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityIchimokuKinkoHyo> GetSecurityPriceTechnicalsIchimokuAsync (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityIchimokuKinkoHyo> localVarResponse = await GetSecurityPriceTechnicalsIchimokuAsyncWithHttpInfo(identifier, lowPeriod, mediumPeriod, highPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ichimoku Kinko Hyo Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku Kinko Hyo (optional, default to 9)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate Senkou Span B (Leading Span B) of Ichimoku Kinko Hyo (optional, default to 52)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityIchimokuKinkoHyo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>> GetSecurityPriceTechnicalsIchimokuAsyncWithHttpInfo (string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsIchimoku");

            var localVarPath = "/securities/{identifier}/prices/technicals/ichimoku";
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
            if (lowPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "low_period", lowPeriod)); // query parameter
            if (mediumPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "medium_period", mediumPeriod)); // query parameter
            if (highPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "high_period", highPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsIchimoku", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityIchimokuKinkoHyo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityIchimokuKinkoHyo)));
        }

        /// <summary>
        /// Keltner Channel Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityKeltnerChannel</returns>
        public ApiResponseSecurityKeltnerChannel GetSecurityPriceTechnicalsKc (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityKeltnerChannel> localVarResponse = GetSecurityPriceTechnicalsKcWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Keltner Channel Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityKeltnerChannel</returns>
        
        
        public ApiResponse< ApiResponseSecurityKeltnerChannel > GetSecurityPriceTechnicalsKcWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsKc");

            var localVarPath = "/securities/{identifier}/prices/technicals/kc";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKeltnerChannel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityKeltnerChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKeltnerChannel)));
        }

        /// <summary>
        /// Keltner Channel Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityKeltnerChannel</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityKeltnerChannel> GetSecurityPriceTechnicalsKcAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityKeltnerChannel> localVarResponse = await GetSecurityPriceTechnicalsKcAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Keltner Channel Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityKeltnerChannel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityKeltnerChannel>> GetSecurityPriceTechnicalsKcAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsKc");

            var localVarPath = "/securities/{identifier}/prices/technicals/kc";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKeltnerChannel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityKeltnerChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKeltnerChannel)));
        }

        /// <summary>
        /// Know Sure Thing Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityKnowSureThing</returns>
        public ApiResponseSecurityKnowSureThing GetSecurityPriceTechnicalsKst (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityKnowSureThing> localVarResponse = GetSecurityPriceTechnicalsKstWithHttpInfo(identifier, roc1, roc2, roc3, roc4, sma1, sma2, sma3, sma4, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Know Sure Thing Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityKnowSureThing</returns>
        
        
        public ApiResponse< ApiResponseSecurityKnowSureThing > GetSecurityPriceTechnicalsKstWithHttpInfo (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsKst");

            var localVarPath = "/securities/{identifier}/prices/technicals/kst";
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
            if (roc1 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc1", roc1)); // query parameter
            if (roc2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc2", roc2)); // query parameter
            if (roc3 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc3", roc3)); // query parameter
            if (roc4 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc4", roc4)); // query parameter
            if (sma1 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma1", sma1)); // query parameter
            if (sma2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma2", sma2)); // query parameter
            if (sma3 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma3", sma3)); // query parameter
            if (sma4 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma4", sma4)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKst", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKnowSureThing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityKnowSureThing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKnowSureThing)));
        }

        /// <summary>
        /// Know Sure Thing Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityKnowSureThing</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityKnowSureThing> GetSecurityPriceTechnicalsKstAsync (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityKnowSureThing> localVarResponse = await GetSecurityPriceTechnicalsKstAsyncWithHttpInfo(identifier, roc1, roc2, roc3, roc4, sma1, sma2, sma3, sma4, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Know Sure Thing Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="roc1">The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="roc2">The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default to 15)</param>
        /// <param name="roc3">The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default to 20)</param>
        /// <param name="roc4">The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default to 30)</param>
        /// <param name="sma1">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA1 (optional, default to 10)</param>
        /// <param name="sma2">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA2 (optional, default to 10)</param>
        /// <param name="sma3">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA3 (optional, default to 10)</param>
        /// <param name="sma4">The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change for RCMA4 (optional, default to 15)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityKnowSureThing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityKnowSureThing>> GetSecurityPriceTechnicalsKstAsyncWithHttpInfo (string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsKst");

            var localVarPath = "/securities/{identifier}/prices/technicals/kst";
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
            if (roc1 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc1", roc1)); // query parameter
            if (roc2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc2", roc2)); // query parameter
            if (roc3 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc3", roc3)); // query parameter
            if (roc4 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "roc4", roc4)); // query parameter
            if (sma1 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma1", sma1)); // query parameter
            if (sma2 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma2", sma2)); // query parameter
            if (sma3 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma3", sma3)); // query parameter
            if (sma4 != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sma4", sma4)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKst", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKnowSureThing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityKnowSureThing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKnowSureThing)));
        }

        /// <summary>
        /// Moving Average Convergence Divergence Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
        public ApiResponseSecurityMovingAverageConvergenceDivergence GetSecurityPriceTechnicalsMacd (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence> localVarResponse = GetSecurityPriceTechnicalsMacdWithHttpInfo(identifier, fastPeriod, slowPeriod, signalPeriod, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Moving Average Convergence Divergence Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
        
        
        public ApiResponse< ApiResponseSecurityMovingAverageConvergenceDivergence > GetSecurityPriceTechnicalsMacdWithHttpInfo (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsMacd");

            var localVarPath = "/securities/{identifier}/prices/technicals/macd";
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
            if (fastPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fast_period", fastPeriod)); // query parameter
            if (slowPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "slow_period", slowPeriod)); // query parameter
            if (signalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "signal_period", signalPeriod)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMacd", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityMovingAverageConvergenceDivergence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMovingAverageConvergenceDivergence)));
        }

        /// <summary>
        /// Moving Average Convergence Divergence Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityMovingAverageConvergenceDivergence> GetSecurityPriceTechnicalsMacdAsync (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence> localVarResponse = await GetSecurityPriceTechnicalsMacdAsyncWithHttpInfo(identifier, fastPeriod, slowPeriod, signalPeriod, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Moving Average Convergence Divergence Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="fastPeriod">The number of observations, per period, to calculate the fast moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 12)</param>
        /// <param name="slowPeriod">The number of observations, per period, to calculate the slow moving Exponential Moving Average for Moving Average Convergence Divergence (optional, default to 26)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the signal line for Moving Average Convergence Divergence (optional, default to 9)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Moving Average Convergence Divergence (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityMovingAverageConvergenceDivergence)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>> GetSecurityPriceTechnicalsMacdAsyncWithHttpInfo (string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsMacd");

            var localVarPath = "/securities/{identifier}/prices/technicals/macd";
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
            if (fastPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fast_period", fastPeriod)); // query parameter
            if (slowPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "slow_period", slowPeriod)); // query parameter
            if (signalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "signal_period", signalPeriod)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMacd", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityMovingAverageConvergenceDivergence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMovingAverageConvergenceDivergence)));
        }

        /// <summary>
        /// Money Flow Index Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityMoneyFlowIndex</returns>
        public ApiResponseSecurityMoneyFlowIndex GetSecurityPriceTechnicalsMfi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityMoneyFlowIndex> localVarResponse = GetSecurityPriceTechnicalsMfiWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Money Flow Index Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityMoneyFlowIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityMoneyFlowIndex > GetSecurityPriceTechnicalsMfiWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsMfi");

            var localVarPath = "/securities/{identifier}/prices/technicals/mfi";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMfi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMoneyFlowIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityMoneyFlowIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMoneyFlowIndex)));
        }

        /// <summary>
        /// Money Flow Index Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityMoneyFlowIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityMoneyFlowIndex> GetSecurityPriceTechnicalsMfiAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityMoneyFlowIndex> localVarResponse = await GetSecurityPriceTechnicalsMfiAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Money Flow Index Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityMoneyFlowIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityMoneyFlowIndex>> GetSecurityPriceTechnicalsMfiAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsMfi");

            var localVarPath = "/securities/{identifier}/prices/technicals/mfi";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMfi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMoneyFlowIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityMoneyFlowIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMoneyFlowIndex)));
        }

        /// <summary>
        /// Mass Index Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityMassIndex</returns>
        public ApiResponseSecurityMassIndex GetSecurityPriceTechnicalsMi (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityMassIndex> localVarResponse = GetSecurityPriceTechnicalsMiWithHttpInfo(identifier, emaPeriod, sumPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mass Index Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityMassIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityMassIndex > GetSecurityPriceTechnicalsMiWithHttpInfo (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsMi");

            var localVarPath = "/securities/{identifier}/prices/technicals/mi";
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
            if (emaPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ema_period", emaPeriod)); // query parameter
            if (sumPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sum_period", sumPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMassIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityMassIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMassIndex)));
        }

        /// <summary>
        /// Mass Index Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityMassIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityMassIndex> GetSecurityPriceTechnicalsMiAsync (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityMassIndex> localVarResponse = await GetSecurityPriceTechnicalsMiAsyncWithHttpInfo(identifier, emaPeriod, sumPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mass Index Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="emaPeriod">The number of observations, per period, to calculate the single Exponential Moving Average and the Double Exponential Moving Average for Mass Index (optional, default to 9)</param>
        /// <param name="sumPeriod">The number of observations, per period, to calculate the sum of the Exponetinal Moving Average Ratios for Mass Index (optional, default to 25)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityMassIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityMassIndex>> GetSecurityPriceTechnicalsMiAsyncWithHttpInfo (string identifier, int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsMi");

            var localVarPath = "/securities/{identifier}/prices/technicals/mi";
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
            if (emaPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "ema_period", emaPeriod)); // query parameter
            if (sumPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sum_period", sumPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMassIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityMassIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMassIndex)));
        }

        /// <summary>
        /// Negative Volume Index Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityNegativeVolumeIndex</returns>
        public ApiResponseSecurityNegativeVolumeIndex GetSecurityPriceTechnicalsNvi (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityNegativeVolumeIndex> localVarResponse = GetSecurityPriceTechnicalsNviWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Negative Volume Index Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityNegativeVolumeIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityNegativeVolumeIndex > GetSecurityPriceTechnicalsNviWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsNvi");

            var localVarPath = "/securities/{identifier}/prices/technicals/nvi";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsNvi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityNegativeVolumeIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityNegativeVolumeIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityNegativeVolumeIndex)));
        }

        /// <summary>
        /// Negative Volume Index Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityNegativeVolumeIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityNegativeVolumeIndex> GetSecurityPriceTechnicalsNviAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityNegativeVolumeIndex> localVarResponse = await GetSecurityPriceTechnicalsNviAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Negative Volume Index Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityNegativeVolumeIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityNegativeVolumeIndex>> GetSecurityPriceTechnicalsNviAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsNvi");

            var localVarPath = "/securities/{identifier}/prices/technicals/nvi";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsNvi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityNegativeVolumeIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityNegativeVolumeIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityNegativeVolumeIndex)));
        }

        /// <summary>
        /// On-balance Volume Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityOnBalanceVolume</returns>
        public ApiResponseSecurityOnBalanceVolume GetSecurityPriceTechnicalsObv (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityOnBalanceVolume> localVarResponse = GetSecurityPriceTechnicalsObvWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// On-balance Volume Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityOnBalanceVolume</returns>
        
        
        public ApiResponse< ApiResponseSecurityOnBalanceVolume > GetSecurityPriceTechnicalsObvWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsObv");

            var localVarPath = "/securities/{identifier}/prices/technicals/obv";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolume>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityOnBalanceVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolume)));
        }

        /// <summary>
        /// On-balance Volume Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityOnBalanceVolume</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityOnBalanceVolume> GetSecurityPriceTechnicalsObvAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityOnBalanceVolume> localVarResponse = await GetSecurityPriceTechnicalsObvAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// On-balance Volume Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityOnBalanceVolume)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityOnBalanceVolume>> GetSecurityPriceTechnicalsObvAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsObv");

            var localVarPath = "/securities/{identifier}/prices/technicals/obv";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolume>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityOnBalanceVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolume)));
        }

        /// <summary>
        /// On-balance Volume Mean Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityOnBalanceVolumeMean</returns>
        public ApiResponseSecurityOnBalanceVolumeMean GetSecurityPriceTechnicalsObvMean (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityOnBalanceVolumeMean> localVarResponse = GetSecurityPriceTechnicalsObvMeanWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// On-balance Volume Mean Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityOnBalanceVolumeMean</returns>
        
        
        public ApiResponse< ApiResponseSecurityOnBalanceVolumeMean > GetSecurityPriceTechnicalsObvMeanWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsObvMean");

            var localVarPath = "/securities/{identifier}/prices/technicals/obv_mean";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObvMean", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityOnBalanceVolumeMean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolumeMean)));
        }

        /// <summary>
        /// On-balance Volume Mean Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityOnBalanceVolumeMean</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityOnBalanceVolumeMean> GetSecurityPriceTechnicalsObvMeanAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityOnBalanceVolumeMean> localVarResponse = await GetSecurityPriceTechnicalsObvMeanAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// On-balance Volume Mean Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate On-balance Volume Mean (optional, default to 10)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityOnBalanceVolumeMean)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>> GetSecurityPriceTechnicalsObvMeanAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsObvMean");

            var localVarPath = "/securities/{identifier}/prices/technicals/obv_mean";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObvMean", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityOnBalanceVolumeMean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolumeMean)));
        }

        /// <summary>
        /// Relative Strength Index Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityRelativeStrengthIndex</returns>
        public ApiResponseSecurityRelativeStrengthIndex GetSecurityPriceTechnicalsRsi (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityRelativeStrengthIndex> localVarResponse = GetSecurityPriceTechnicalsRsiWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Relative Strength Index Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityRelativeStrengthIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityRelativeStrengthIndex > GetSecurityPriceTechnicalsRsiWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsRsi");

            var localVarPath = "/securities/{identifier}/prices/technicals/rsi";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsRsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityRelativeStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityRelativeStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityRelativeStrengthIndex)));
        }

        /// <summary>
        /// Relative Strength Index Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityRelativeStrengthIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityRelativeStrengthIndex> GetSecurityPriceTechnicalsRsiAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityRelativeStrengthIndex> localVarResponse = await GetSecurityPriceTechnicalsRsiAsyncWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Relative Strength Index Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Relative Strength Index (optional, default to 14)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Relative Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityRelativeStrengthIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityRelativeStrengthIndex>> GetSecurityPriceTechnicalsRsiAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsRsi");

            var localVarPath = "/securities/{identifier}/prices/technicals/rsi";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsRsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityRelativeStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityRelativeStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityRelativeStrengthIndex)));
        }

        /// <summary>
        /// Simple Moving Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecuritySimpleMovingAverage</returns>
        public ApiResponseSecuritySimpleMovingAverage GetSecurityPriceTechnicalsSma (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecuritySimpleMovingAverage> localVarResponse = GetSecurityPriceTechnicalsSmaWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Simple Moving Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecuritySimpleMovingAverage</returns>
        
        
        public ApiResponse< ApiResponseSecuritySimpleMovingAverage > GetSecurityPriceTechnicalsSmaWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsSma");

            var localVarPath = "/securities/{identifier}/prices/technicals/sma";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSma", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecuritySimpleMovingAverage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecuritySimpleMovingAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecuritySimpleMovingAverage)));
        }

        /// <summary>
        /// Simple Moving Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecuritySimpleMovingAverage</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecuritySimpleMovingAverage> GetSecurityPriceTechnicalsSmaAsync (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecuritySimpleMovingAverage> localVarResponse = await GetSecurityPriceTechnicalsSmaAsyncWithHttpInfo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Simple Moving Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Simple Moving Average (optional, default to 20)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecuritySimpleMovingAverage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecuritySimpleMovingAverage>> GetSecurityPriceTechnicalsSmaAsyncWithHttpInfo (string identifier, int? period = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsSma");

            var localVarPath = "/securities/{identifier}/prices/technicals/sma";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSma", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecuritySimpleMovingAverage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecuritySimpleMovingAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecuritySimpleMovingAverage)));
        }

        /// <summary>
        /// Stochastic Oscillator Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityStochasticOscillator</returns>
        public ApiResponseSecurityStochasticOscillator GetSecurityPriceTechnicalsSr (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityStochasticOscillator> localVarResponse = GetSecurityPriceTechnicalsSrWithHttpInfo(identifier, period, signalPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Stochastic Oscillator Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityStochasticOscillator</returns>
        
        
        public ApiResponse< ApiResponseSecurityStochasticOscillator > GetSecurityPriceTechnicalsSrWithHttpInfo (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsSr");

            var localVarPath = "/securities/{identifier}/prices/technicals/sr";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (signalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "signal_period", signalPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStochasticOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityStochasticOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStochasticOscillator)));
        }

        /// <summary>
        /// Stochastic Oscillator Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityStochasticOscillator</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityStochasticOscillator> GetSecurityPriceTechnicalsSrAsync (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityStochasticOscillator> localVarResponse = await GetSecurityPriceTechnicalsSrAsyncWithHttpInfo(identifier, period, signalPeriod, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Stochastic Oscillator Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate %K of Stochastic Oscillator (optional, default to 14)</param>
        /// <param name="signalPeriod">The number of observations, per period, to calculate the %D (the Simple Moving Average of %K) as a signal line for Stochastic Oscillator (optional, default to 3)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityStochasticOscillator)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityStochasticOscillator>> GetSecurityPriceTechnicalsSrAsyncWithHttpInfo (string identifier, int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsSr");

            var localVarPath = "/securities/{identifier}/prices/technicals/sr";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
            if (signalPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "signal_period", signalPeriod)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStochasticOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityStochasticOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStochasticOscillator)));
        }

        /// <summary>
        /// Triple Exponential Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityTripleExponentialAverage</returns>
        public ApiResponseSecurityTripleExponentialAverage GetSecurityPriceTechnicalsTrix (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityTripleExponentialAverage> localVarResponse = GetSecurityPriceTechnicalsTrixWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Triple Exponential Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityTripleExponentialAverage</returns>
        
        
        public ApiResponse< ApiResponseSecurityTripleExponentialAverage > GetSecurityPriceTechnicalsTrixWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsTrix");

            var localVarPath = "/securities/{identifier}/prices/technicals/trix";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTrix", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTripleExponentialAverage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityTripleExponentialAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTripleExponentialAverage)));
        }

        /// <summary>
        /// Triple Exponential Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityTripleExponentialAverage</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityTripleExponentialAverage> GetSecurityPriceTechnicalsTrixAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityTripleExponentialAverage> localVarResponse = await GetSecurityPriceTechnicalsTrixAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Triple Exponential Average Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Exponential Moving Average for Triple Exponential Average (optional, default to 15)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityTripleExponentialAverage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityTripleExponentialAverage>> GetSecurityPriceTechnicalsTrixAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsTrix");

            var localVarPath = "/securities/{identifier}/prices/technicals/trix";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTrix", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTripleExponentialAverage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityTripleExponentialAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTripleExponentialAverage)));
        }

        /// <summary>
        /// True Strength Index Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityTrueStrengthIndex</returns>
        public ApiResponseSecurityTrueStrengthIndex GetSecurityPriceTechnicalsTsi (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityTrueStrengthIndex> localVarResponse = GetSecurityPriceTechnicalsTsiWithHttpInfo(identifier, lowPeriod, highPeriod, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// True Strength Index Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityTrueStrengthIndex</returns>
        
        
        public ApiResponse< ApiResponseSecurityTrueStrengthIndex > GetSecurityPriceTechnicalsTsiWithHttpInfo (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsTsi");

            var localVarPath = "/securities/{identifier}/prices/technicals/tsi";
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
            if (lowPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "low_period", lowPeriod)); // query parameter
            if (highPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "high_period", highPeriod)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTrueStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityTrueStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTrueStrengthIndex)));
        }

        /// <summary>
        /// True Strength Index Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityTrueStrengthIndex</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityTrueStrengthIndex> GetSecurityPriceTechnicalsTsiAsync (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityTrueStrengthIndex> localVarResponse = await GetSecurityPriceTechnicalsTsiAsyncWithHttpInfo(identifier, lowPeriod, highPeriod, priceKey, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// True Strength Index Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="lowPeriod">The number of observations, per period, to calculate low period Exponential Moving Average for smoothing in True Strength Index (optional, default to 13)</param>
        /// <param name="highPeriod">The number of observations, per period, to calculate high period Exponential Moving Average for smoothing in True Strength Index (optional, default to 25)</param>
        /// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityTrueStrengthIndex)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityTrueStrengthIndex>> GetSecurityPriceTechnicalsTsiAsyncWithHttpInfo (string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsTsi");

            var localVarPath = "/securities/{identifier}/prices/technicals/tsi";
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
            if (lowPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "low_period", lowPeriod)); // query parameter
            if (highPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "high_period", highPeriod)); // query parameter
            if (priceKey != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "price_key", priceKey)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTrueStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityTrueStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTrueStrengthIndex)));
        }

        /// <summary>
        /// Ultimate Oscillator Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityUltimateOscillator</returns>
        public ApiResponseSecurityUltimateOscillator GetSecurityPriceTechnicalsUo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityUltimateOscillator> localVarResponse = GetSecurityPriceTechnicalsUoWithHttpInfo(identifier, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ultimate Oscillator Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityUltimateOscillator</returns>
        
        
        public ApiResponse< ApiResponseSecurityUltimateOscillator > GetSecurityPriceTechnicalsUoWithHttpInfo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsUo");

            var localVarPath = "/securities/{identifier}/prices/technicals/uo";
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
            if (shortPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "short_period", shortPeriod)); // query parameter
            if (mediumPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "medium_period", mediumPeriod)); // query parameter
            if (longPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "long_period", longPeriod)); // query parameter
            if (shortWeight != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "short_weight", shortWeight)); // query parameter
            if (mediumWeight != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "medium_weight", mediumWeight)); // query parameter
            if (longWeight != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "long_weight", longWeight)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsUo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityUltimateOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityUltimateOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityUltimateOscillator)));
        }

        /// <summary>
        /// Ultimate Oscillator Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityUltimateOscillator</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityUltimateOscillator> GetSecurityPriceTechnicalsUoAsync (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityUltimateOscillator> localVarResponse = await GetSecurityPriceTechnicalsUoAsyncWithHttpInfo(identifier, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ultimate Oscillator Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="shortPeriod">The number of observations, per period, to calculate the short period for Ultimate Oscillator (optional, default to 7)</param>
        /// <param name="mediumPeriod">The number of observations, per period, to calculate the medium period for Ultimate Oscillator (optional, default to 14)</param>
        /// <param name="longPeriod">The number of observations, per period, to calculate the long period for Ultimate Oscillator (optional, default to 28)</param>
        /// <param name="shortWeight">The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to 4.0)</param>
        /// <param name="mediumWeight">The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to 2.0)</param>
        /// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityUltimateOscillator)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityUltimateOscillator>> GetSecurityPriceTechnicalsUoAsyncWithHttpInfo (string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsUo");

            var localVarPath = "/securities/{identifier}/prices/technicals/uo";
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
            if (shortPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "short_period", shortPeriod)); // query parameter
            if (mediumPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "medium_period", mediumPeriod)); // query parameter
            if (longPeriod != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "long_period", longPeriod)); // query parameter
            if (shortWeight != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "short_weight", shortWeight)); // query parameter
            if (mediumWeight != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "medium_weight", mediumWeight)); // query parameter
            if (longWeight != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "long_weight", longWeight)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsUo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityUltimateOscillator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityUltimateOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityUltimateOscillator)));
        }

        /// <summary>
        /// Vortex Indicator Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityVortexIndicator</returns>
        public ApiResponseSecurityVortexIndicator GetSecurityPriceTechnicalsVi (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityVortexIndicator> localVarResponse = GetSecurityPriceTechnicalsViWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Vortex Indicator Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityVortexIndicator</returns>
        
        
        public ApiResponse< ApiResponseSecurityVortexIndicator > GetSecurityPriceTechnicalsViWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsVi");

            var localVarPath = "/securities/{identifier}/prices/technicals/vi";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVortexIndicator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityVortexIndicator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVortexIndicator)));
        }

        /// <summary>
        /// Vortex Indicator Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityVortexIndicator</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityVortexIndicator> GetSecurityPriceTechnicalsViAsync (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityVortexIndicator> localVarResponse = await GetSecurityPriceTechnicalsViAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Vortex Indicator Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityVortexIndicator)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityVortexIndicator>> GetSecurityPriceTechnicalsViAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsVi");

            var localVarPath = "/securities/{identifier}/prices/technicals/vi";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVortexIndicator>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityVortexIndicator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVortexIndicator)));
        }

        /// <summary>
        /// Volume-price Trend Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityVolumePriceTrend</returns>
        public ApiResponseSecurityVolumePriceTrend GetSecurityPriceTechnicalsVpt (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityVolumePriceTrend> localVarResponse = GetSecurityPriceTechnicalsVptWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Volume-price Trend Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityVolumePriceTrend</returns>
        
        
        public ApiResponse< ApiResponseSecurityVolumePriceTrend > GetSecurityPriceTechnicalsVptWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsVpt");

            var localVarPath = "/securities/{identifier}/prices/technicals/vpt";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVpt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumePriceTrend>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityVolumePriceTrend) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumePriceTrend)));
        }

        /// <summary>
        /// Volume-price Trend Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityVolumePriceTrend</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityVolumePriceTrend> GetSecurityPriceTechnicalsVptAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityVolumePriceTrend> localVarResponse = await GetSecurityPriceTechnicalsVptAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Volume-price Trend Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityVolumePriceTrend)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityVolumePriceTrend>> GetSecurityPriceTechnicalsVptAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsVpt");

            var localVarPath = "/securities/{identifier}/prices/technicals/vpt";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVpt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumePriceTrend>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityVolumePriceTrend) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumePriceTrend)));
        }

        /// <summary>
        /// Volume Weighted Average Price Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityVolumeWeightedAveragePrice</returns>
        public ApiResponseSecurityVolumeWeightedAveragePrice GetSecurityPriceTechnicalsVwap (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice> localVarResponse = GetSecurityPriceTechnicalsVwapWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Volume Weighted Average Price Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityVolumeWeightedAveragePrice</returns>
        
        
        public ApiResponse< ApiResponseSecurityVolumeWeightedAveragePrice > GetSecurityPriceTechnicalsVwapWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsVwap");

            var localVarPath = "/securities/{identifier}/prices/technicals/vwap";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVwap", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityVolumeWeightedAveragePrice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumeWeightedAveragePrice)));
        }

        /// <summary>
        /// Volume Weighted Average Price Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityVolumeWeightedAveragePrice</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityVolumeWeightedAveragePrice> GetSecurityPriceTechnicalsVwapAsync (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice> localVarResponse = await GetSecurityPriceTechnicalsVwapAsyncWithHttpInfo(identifier, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Volume Weighted Average Price Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityVolumeWeightedAveragePrice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>> GetSecurityPriceTechnicalsVwapAsyncWithHttpInfo (string identifier, string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsVwap");

            var localVarPath = "/securities/{identifier}/prices/technicals/vwap";
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
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVwap", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityVolumeWeightedAveragePrice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumeWeightedAveragePrice)));
        }

        /// <summary>
        /// Williams %R Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponseSecurityWilliamsR</returns>
        public ApiResponseSecurityWilliamsR GetSecurityPriceTechnicalsWr (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityWilliamsR> localVarResponse = GetSecurityPriceTechnicalsWrWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Williams %R Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of ApiResponseSecurityWilliamsR</returns>
        
        
        public ApiResponse< ApiResponseSecurityWilliamsR > GetSecurityPriceTechnicalsWrWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsWr");

            var localVarPath = "/securities/{identifier}/prices/technicals/wr";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsWr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityWilliamsR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityWilliamsR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityWilliamsR)));
        }

        /// <summary>
        /// Williams %R Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponseSecurityWilliamsR</returns>
        public async System.Threading.Tasks.Task<ApiResponseSecurityWilliamsR> GetSecurityPriceTechnicalsWrAsync (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)
        {
             ApiResponse<ApiResponseSecurityWilliamsR> localVarResponse = await GetSecurityPriceTechnicalsWrAsyncWithHttpInfo(identifier, period, startDate, endDate, pageSize, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Williams %R Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="period">The number of observations, per period, to look-back when calculating Williams %R (optional, default to 14)</param>
        /// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
        /// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
        /// <param name="pageSize">The number of results to return (optional, default to 100)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponseSecurityWilliamsR)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseSecurityWilliamsR>> GetSecurityPriceTechnicalsWrAsyncWithHttpInfo (string identifier, int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling TechnicalApi->GetSecurityPriceTechnicalsWr");

            var localVarPath = "/securities/{identifier}/prices/technicals/wr";
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
            if (period != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "period", period)); // query parameter
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
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsWr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityWilliamsR>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponseSecurityWilliamsR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityWilliamsR)));
        }

    }
}



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
        /// The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
        /// The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
        /// Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
        /// Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
        /// The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
        /// The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
        /// The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
        /// The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
        /// The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
        /// The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
        /// Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
        /// Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
        /// The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
        /// The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
        /// The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
        /// The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
        /// The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
        /// The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
        /// The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
        /// The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
        /// The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
        /// The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
        /// The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
        /// The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
        /// The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
        /// The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
        /// The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
        /// The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
        /// The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
        /// The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
        /// Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
        /// Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
        /// The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
        /// The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
        /// The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
        /// The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
        /// The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
        /// The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
        /// On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
        /// Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
        /// A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
        /// A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
        /// The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
        /// The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
        /// The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
        /// The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
        /// The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
        /// The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
        /// The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
        /// The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
        /// The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
        /// The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
        /// The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
        /// The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
        /// Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
        /// Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
        /// Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
        /// Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
        /// The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
        /// The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
        /// Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
        /// Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
        /// The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
        /// The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
        /// The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
        /// The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
        /// The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
        /// The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
        /// Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
        /// Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
        /// The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
        /// The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
        /// The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
        /// The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
        /// The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
        /// The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
        /// The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
        /// The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
        /// The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
        /// The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
        /// The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
        /// The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
        /// The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
        /// The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
        /// The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
        /// The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
        /// The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
        /// The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
        /// Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
        /// Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
        /// The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
        /// The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
        /// The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
        /// The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
        /// The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
        /// The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
        /// On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
        /// Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
        /// A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
        /// A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
        /// The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
        /// The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
        /// The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
        /// The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
        /// The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
        /// The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
        /// The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
        /// The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
        /// The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
        /// The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
        /// The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
        /// The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
        /// Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
        /// Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
        /// Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
        /// Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
        /// Accumulation/Distribution Index The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
        /// Accumulation/Distribution Index The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAccumulationDistributionIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAccumulationDistributionIndex)));
        }

        /// <summary>
        /// Accumulation/Distribution Index The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
        /// Accumulation/Distribution Index The Accumulation / Distribution Indicator is a volume-based technical indicator which uses the relationship between the stock&#x60;s price and volume flow to determine the underlying trend of a stock, up, down, or sideways trend of a stock.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAccumulationDistributionIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAccumulationDistributionIndex)));
        }

        /// <summary>
        /// Average Daily Trading Volume Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
        /// Average Daily Trading Volume Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdtv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAverageDailyTradingVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDailyTradingVolume)));
        }

        /// <summary>
        /// Average Daily Trading Volume Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
        /// Average Daily Trading Volume Average Daily Trading Volume is the average number of shares traded over a given period, usually between 20 to 30 trading days.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdtv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAverageDailyTradingVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDailyTradingVolume)));
        }

        /// <summary>
        /// Average Directional Index The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
        /// Average Directional Index The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDirectionalIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAverageDirectionalIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDirectionalIndex)));
        }

        /// <summary>
        /// Average Directional Index The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
        /// Average Directional Index The Average Directional Index indicator is often used to identify decreasing or increasing price momentum for an underlying security, it is composed of a total of three indicators, the current trendline (adx), a positive directional indicator (di_pos), and a negative directional indicator (di_neg).
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAdx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageDirectionalIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAverageDirectionalIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageDirectionalIndex)));
        }

        /// <summary>
        /// Awesome Oscillator The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
        /// Awesome Oscillator The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAwesomeOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAwesomeOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAwesomeOscillator)));
        }

        /// <summary>
        /// Awesome Oscillator The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
        /// Awesome Oscillator The Awesome Oscillator (ao) is a momentum indicator and is calculated by taking the difference between the latest 5 period simple moving average and the 34 period simple moving average. Rather than using the closing price like other indicators, the Awesome Oscillator uses the latest period&#x60;s midpoint value (period_high - period_low / 2). The Awesome Oscillator is useful in identifying and trading, zero-line crossovers, twin-peaks trading, and bullish/bearish saucers - Awesome Oscillator is often aggregated with additional technical indicators.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAwesomeOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAwesomeOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAwesomeOscillator)));
        }

        /// <summary>
        /// Average True Range The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
        /// Average True Range The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAtr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageTrueRange>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAverageTrueRange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageTrueRange)));
        }

        /// <summary>
        /// Average True Range The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
        /// Average True Range The Average True Range (ATR) is a non-directional market volatility indicator often used to generate stop-out or entry indications. An increasing or expanding ATR typically indicates higher volatility, and a decreasing ATR indicates sideways price action and lower volatility.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsAtr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityAverageTrueRange>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityAverageTrueRange) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityAverageTrueRange)));
        }

        /// <summary>
        /// Bollinger Bands Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
        /// Bollinger Bands Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsBb", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityBollingerBands>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityBollingerBands) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityBollingerBands)));
        }

        /// <summary>
        /// Bollinger Bands Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
        /// Bollinger Bands Bollinger Bands can be a useful technical analysis tool for generating oversold or overbought indicators. Bollinger Bands are composed of three lines, a simple moving average (middle band) and an upper and lower band – the upper and lower bands are typically 2 standard deviations +/- from a 20-day simple moving average, but can be modified. Traders typically consider an underlying security to be overbought as the underlying&#x60;s price moves towards the upper band and oversold as the underlying price moves towards the lower band.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsBb", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityBollingerBands>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityBollingerBands) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityBollingerBands)));
        }

        /// <summary>
        /// Commodity Channel Index The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
        /// Commodity Channel Index The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCci", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityCommodityChannelIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityCommodityChannelIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityCommodityChannelIndex)));
        }

        /// <summary>
        /// Commodity Channel Index The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
        /// Commodity Channel Index The Commodity Channel Index (CCI) is a technical indicator used to generate buy and sell signals by indicating periods of strength and weakness in the market. CCI signals that fall below -100 are often perceived as weakness in the underlying price movement and CCI signals that rise above 100 indicate strength behind the underlying price movement.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCci", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityCommodityChannelIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityCommodityChannelIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityCommodityChannelIndex)));
        }

        /// <summary>
        /// Chaikin Money Flow The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
        /// Chaikin Money Flow The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCmf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityChaikinMoneyFlow>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityChaikinMoneyFlow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityChaikinMoneyFlow)));
        }

        /// <summary>
        /// Chaikin Money Flow The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
        /// Chaikin Money Flow The Chaikin Money Flow (CMF) utilizes exponential moving averages as an indicator to monitor the flow of money and momentum. The CMF indicator oscillates around a midrange 0-line and ranges between 100 and -100.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsCmf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityChaikinMoneyFlow>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityChaikinMoneyFlow) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityChaikinMoneyFlow)));
        }

        /// <summary>
        /// Donchian Channel The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
        /// Donchian Channel The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDonchianChannel>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityDonchianChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDonchianChannel)));
        }

        /// <summary>
        /// Donchian Channel The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
        /// Donchian Channel The Donchian Channel consists of an Upper Bound (upper_bound) and Lower Bound (lower_bound) that track the recent highs and lows and is often used to signal entry and exit points for a position. As the price of the underlying symbol increases the Upper Bound raises, if the price becomes range bound the Upper Bound will remain flat and if the price begins to decrease, the Upper Bound will fall (and vice-versa for the Lower Bound).
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDonchianChannel>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityDonchianChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDonchianChannel)));
        }

        /// <summary>
        /// Detrended Price Oscillator The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
        /// Detrended Price Oscillator The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDpo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityDetrendedPriceOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDetrendedPriceOscillator)));
        }

        /// <summary>
        /// Detrended Price Oscillator The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
        /// Detrended Price Oscillator The Detrended Price Oscillator (DPO) signals the peaks and troughs of the underlying symbol’s price for a set period of time and is often used by traders to estimate future peaks and troughs using this as guidance to enter or exit a position.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsDpo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityDetrendedPriceOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityDetrendedPriceOscillator)));
        }

        /// <summary>
        /// Ease of Movement The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
        /// Ease of Movement The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsEom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityEaseOfMovement>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityEaseOfMovement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityEaseOfMovement)));
        }

        /// <summary>
        /// Ease of Movement The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
        /// Ease of Movement The Ease of Movement (EOM) is a volume based oscillator that fluctuates around a midrange 0-line into positive and negative values. Positive values indicate that the underlying symbol&#x60;s price is rising with relative ease and negative value indicates the underlying symbol&#x60;s price is failing with relative ease.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsEom", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityEaseOfMovement>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityEaseOfMovement) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityEaseOfMovement)));
        }

        /// <summary>
        /// Force Index The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
        /// Force Index The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsFi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityForceIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityForceIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityForceIndex)));
        }

        /// <summary>
        /// Force Index The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
        /// Force Index The Force Index (FI) is an oscillator that takes into account the intensity of an underlying symbol&#x60;s price movement and its corresponding volume. It is used to confirm price breakouts and signal underlying trends.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsFi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityForceIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityForceIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityForceIndex)));
        }

        /// <summary>
        /// Ichimoku Kinko Hyo The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
        /// Ichimoku Kinko Hyo The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsIchimoku", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityIchimokuKinkoHyo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityIchimokuKinkoHyo)));
        }

        /// <summary>
        /// Ichimoku Kinko Hyo The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
        /// Ichimoku Kinko Hyo The Ichimoku Kinko Hyo was designed to be an all-in-one trading indicator that could help traders determine momentum, support, and resistance.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsIchimoku", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityIchimokuKinkoHyo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityIchimokuKinkoHyo)));
        }

        /// <summary>
        /// Keltner Channel The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
        /// Keltner Channel The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKeltnerChannel>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityKeltnerChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKeltnerChannel)));
        }

        /// <summary>
        /// Keltner Channel The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
        /// Keltner Channel The Keltner Channel is a volatility based signal, with upper, middle, and lower bands. It is often used at market open, when the largest moves tend to occur. In general, traders tend to buy if the price breaks up above the upper band or sell short if the price drops below the lower band.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKc", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKeltnerChannel>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityKeltnerChannel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKeltnerChannel)));
        }

        /// <summary>
        /// Know Sure Thing The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
        /// Know Sure Thing The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKst", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKnowSureThing>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityKnowSureThing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKnowSureThing)));
        }

        /// <summary>
        /// Know Sure Thing The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
        /// Know Sure Thing The Know Sure Thing indicator (KST) is a momentum based oscillator that is calculated by measuring the momentum of four separate price cycles. KST fluctuates above and below a zero line and is used to identify overbought and oversold conditions, and is often used with additional indicators to boost signal strength.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsKst", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityKnowSureThing>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityKnowSureThing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityKnowSureThing)));
        }

        /// <summary>
        /// Moving Average Convergence Divergence Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
        /// Moving Average Convergence Divergence Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMacd", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityMovingAverageConvergenceDivergence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMovingAverageConvergenceDivergence)));
        }

        /// <summary>
        /// Moving Average Convergence Divergence Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
        /// Moving Average Convergence Divergence Moving average convergence divergence (MACD) is a trend-following momentum oscillator that consists of three indicators: (1) a 12 period short-term exponential moving average (EMA) a 26 period long-term EMA and a 9 period EMA signal line. Traders using MACD often look for signal line crossovers, centerline crossovers, and EMA divergences to indicate the momentum and underlying trend of a security&#x60;s price.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMacd", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityMovingAverageConvergenceDivergence) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMovingAverageConvergenceDivergence)));
        }

        /// <summary>
        /// Money Flow Index The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
        /// Money Flow Index The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMfi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMoneyFlowIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityMoneyFlowIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMoneyFlowIndex)));
        }

        /// <summary>
        /// Money Flow Index The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
        /// Money Flow Index The Money Flow Index (MFI) is a technical oscillator that incorporates both price and volume, moving between 0 and 100. Traders often consider a MFI above 80 as overbought conditions and below 20 as oversold conditions.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMfi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMoneyFlowIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityMoneyFlowIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMoneyFlowIndex)));
        }

        /// <summary>
        /// Mass Index The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
        /// Mass Index The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMassIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityMassIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMassIndex)));
        }

        /// <summary>
        /// Mass Index The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
        /// Mass Index The mass index (MI) is a technical indicator used by traders to predict trend reversals. A trend reversal signal is said to occur when the 25-day MI reaches 27.0 and then falls below 26.0.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsMi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityMassIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityMassIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityMassIndex)));
        }

        /// <summary>
        /// Negative Volume Index The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
        /// Negative Volume Index The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsNvi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityNegativeVolumeIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityNegativeVolumeIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityNegativeVolumeIndex)));
        }

        /// <summary>
        /// Negative Volume Index The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
        /// Negative Volume Index The negative volume index (NVI) is often referred to as the &#x60;smart money indicator.&#x60; It works by the assumption that smart money (institutional money) is at work when volume decreases and vice versa when volume increases. NVI starts at 1000 and increases in regard to the percentage price change when volume decreases over a 255-day EMA period. Traders often use this technical indicator when researching broder markets and indices.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsNvi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityNegativeVolumeIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityNegativeVolumeIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityNegativeVolumeIndex)));
        }

        /// <summary>
        /// On-balance Volume On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance Volume On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolume>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityOnBalanceVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolume)));
        }

        /// <summary>
        /// On-balance Volume On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance Volume On-balance volume (OBV) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. When both OBV and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObv", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolume>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityOnBalanceVolume) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolume)));
        }

        /// <summary>
        /// On-balance Volume Mean On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance Volume Mean On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObvMean", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityOnBalanceVolumeMean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolumeMean)));
        }

        /// <summary>
        /// On-balance Volume Mean On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
        /// On-balance Volume Mean On-balance volume mean (OBVM) is a leading momentum indicator that uses the increase/decrease flow in volume to predict upcoming stock price changes. The difference between OBV and OBVM is that OBVM takes the mean average of a provided period.  When both OBVM and a security&#x60;s price are making higher highs, it is presumed the upward trend is likely to continue and vice versa.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsObvMean", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityOnBalanceVolumeMean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityOnBalanceVolumeMean)));
        }

        /// <summary>
        /// Relative Strength Index Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
        /// Relative Strength Index Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsRsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityRelativeStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityRelativeStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityRelativeStrengthIndex)));
        }

        /// <summary>
        /// Relative Strength Index Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
        /// Relative Strength Index Relative strength index (RSI) is a momentum oscillator that ranges between 0 and 100. Traders believe that an RSI value over 70 indicates that a security is overbought and an RSI under 30 indicates that a security is oversold.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsRsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityRelativeStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityRelativeStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityRelativeStrengthIndex)));
        }

        /// <summary>
        /// Simple Moving Average A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
        /// Simple Moving Average A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSma", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecuritySimpleMovingAverage>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecuritySimpleMovingAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecuritySimpleMovingAverage)));
        }

        /// <summary>
        /// Simple Moving Average A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
        /// Simple Moving Average A simple moving average (SMA) adds recent prices for a specified period and divides the total by that same number of periods. SMA is typically used to indicate whether a security is in an uptrend or downtrend and can also be combined with a long-term moving average to improve the signal&#x60;s abilities.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSma", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecuritySimpleMovingAverage>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecuritySimpleMovingAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecuritySimpleMovingAverage)));
        }

        /// <summary>
        /// Stochastic Oscillator The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
        /// Stochastic Oscillator The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStochasticOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityStochasticOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStochasticOscillator)));
        }

        /// <summary>
        /// Stochastic Oscillator The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
        /// Stochastic Oscillator The Stochastic Oscillator (SO) is a range-bound momentum indicator that ranges from 0 to 100 and follows the velocity of the momentum itself, not the underlying price or volume. When SO is above 80 it indicates that a security is trading at the high end of its period&#x60;s high-low range and vice versa if the reading is below 20.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsSr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityStochasticOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityStochasticOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityStochasticOscillator)));
        }

        /// <summary>
        /// Triple Exponential Average The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
        /// Triple Exponential Average The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTrix", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTripleExponentialAverage>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityTripleExponentialAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTripleExponentialAverage)));
        }

        /// <summary>
        /// Triple Exponential Average The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
        /// Triple Exponential Average The Triple Exponential Average (TEA) is a momentum indicator used to identify when a security is oversold and overbought. By exponentially smoothing out the underlying security&#x60;s moving average, the TEA  filters out insignificant price movements. A positive TEA is often believed to indicate momentum is increasing and a negative TEA indicates that momentum is decreasing.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTrix", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTripleExponentialAverage>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityTripleExponentialAverage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTripleExponentialAverage)));
        }

        /// <summary>
        /// True Strength Index The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
        /// True Strength Index The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTrueStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityTrueStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTrueStrengthIndex)));
        }

        /// <summary>
        /// True Strength Index The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
        /// True Strength Index The True Strength Index (TSI) is a momentum oscillator used to identify building trends and trend reversals, typically by signalling overbought and oversold conditions. TSI fluctuates between positive and negative values, and traders typically combine its signal with other momentum oscillators to increase its strength. When TSI crosses the signal line into positive territory it is presumed to be an entrance opportunity and vice versa when the TSI crosses into negative territory.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsTsi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityTrueStrengthIndex>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityTrueStrengthIndex) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityTrueStrengthIndex)));
        }

        /// <summary>
        /// Ultimate Oscillator The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
        /// Ultimate Oscillator The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsUo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityUltimateOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityUltimateOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityUltimateOscillator)));
        }

        /// <summary>
        /// Ultimate Oscillator The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
        /// Ultimate Oscillator The Ultimate Oscillator (UO) is a range bound technical indicator that moves between 0 and 100 and is calculated with 3 timeframes, typically 7, 14, and 28 day periods. When UO&#x60;s value is above 70 a security is categorized as overbought and when UO&#x60;s value is below 30 a security is categorized as oversold.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsUo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityUltimateOscillator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityUltimateOscillator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityUltimateOscillator)));
        }

        /// <summary>
        /// Vortex Indicator The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
        /// Vortex Indicator The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVortexIndicator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityVortexIndicator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVortexIndicator)));
        }

        /// <summary>
        /// Vortex Indicator The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
        /// Vortex Indicator The Vortex Indicator (VI) is composed of an uptrend line (VI+) and a downtrend line (VI-). When VI+ crosses VI- from below it typically indicates an entry into a given security. When VI- crosses VI+ from below it typically triggers an exit and that the current trend is reversing course.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVi", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVortexIndicator>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityVortexIndicator) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVortexIndicator)));
        }

        /// <summary>
        /// Volume-price Trend The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
        /// Volume-price Trend The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVpt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumePriceTrend>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityVolumePriceTrend) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumePriceTrend)));
        }

        /// <summary>
        /// Volume-price Trend The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
        /// Volume-price Trend The volume price trend (VPT) is a technical indicator that uses price &amp; volume to determine whether a trend is established. Typically, when a security is trending upwards, there is more volume on positive days than negative ones, and as a result VPT should be increasing on these days as well. However, if VPT fails to increase past its previous high during an outbreak, this is suggested to indicate the rally is losing strength.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVpt", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumePriceTrend>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityVolumePriceTrend) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumePriceTrend)));
        }

        /// <summary>
        /// Volume Weighted Average Price Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
        /// Volume Weighted Average Price Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVwap", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityVolumeWeightedAveragePrice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumeWeightedAveragePrice)));
        }

        /// <summary>
        /// Volume Weighted Average Price Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
        /// Volume Weighted Average Price Volume Weighted Average Price (VWAP) is a lagging technical indicator that is used in combination with a security&#x60;s price. When the underlying price rises above its VWAP, it is often interpreted as a bullish signal, and vice versa in the opposite direction.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsVwap", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityVolumeWeightedAveragePrice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityVolumeWeightedAveragePrice)));
        }

        /// <summary>
        /// Williams %R Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
        /// Williams %R Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsWr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityWilliamsR>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityWilliamsR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityWilliamsR)));
        }

        /// <summary>
        /// Williams %R Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
        /// Williams %R Williams %R is a momentum indicator used to determine overbought and oversold environments for a security and fluctuates between 0 and -100. When Williams %R is above -20 the security is considered to be overbought and when Williams %R is under -80 the security is considered to be oversold.
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
            RestResponse localVarResponse = (RestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                RestSharp.Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityPriceTechnicalsWr", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseSecurityWilliamsR>(localVarStatusCode,
                localVarResponse.Headers.Select(x => new KeyValuePair<string, string>(x.Name, x.Value.ToString())).ToList(),
                (ApiResponseSecurityWilliamsR) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseSecurityWilliamsR)));
        }

    }
}

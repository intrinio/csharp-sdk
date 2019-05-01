

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Intrinio.SDK.Client;
using Intrinio.SDK.Api;
using Intrinio.SDK.Model;

namespace Intrinio.SDK.Test
{
    /// <summary>
    ///  Class for testing CryptoApi
    /// </summary>
    [TestFixture]
    public class CryptoApiTests
    {
        private CryptoApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CryptoApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CryptoApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CryptoApi
            //Assert.IsInstanceOfType(typeof(CryptoApi), instance, "instance is a CryptoApi");
        }

        
        /// <summary>
        /// Test GetCryptoBookAsks
        /// </summary>
        [Test]
        public void GetCryptoBookAsksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //var response = instance.GetCryptoBookAsks(pair, exchange, currency);
            //Assert.IsInstanceOf<ApiResponseCryptoBookAsks> (response, "response is ApiResponseCryptoBookAsks");
        }
        
        /// <summary>
        /// Test GetCryptoBookBids
        /// </summary>
        [Test]
        public void GetCryptoBookBidsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //var response = instance.GetCryptoBookBids(pair, exchange, currency);
            //Assert.IsInstanceOf<ApiResponseCryptoBookBids> (response, "response is ApiResponseCryptoBookBids");
        }
        
        /// <summary>
        /// Test GetCryptoBookSummary
        /// </summary>
        [Test]
        public void GetCryptoBookSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? levels = null;
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //var response = instance.GetCryptoBookSummary(levels, pair, exchange, currency);
            //Assert.IsInstanceOf<ApiResponseCryptoBook> (response, "response is ApiResponseCryptoBook");
        }
        
        /// <summary>
        /// Test GetCryptoCurrencies
        /// </summary>
        [Test]
        public void GetCryptoCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //var response = instance.GetCryptoCurrencies(exchange);
            //Assert.IsInstanceOf<ApiResponseCryptoCurrencies> (response, "response is ApiResponseCryptoCurrencies");
        }
        
        /// <summary>
        /// Test GetCryptoExchanges
        /// </summary>
        [Test]
        public void GetCryptoExchangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //var response = instance.GetCryptoExchanges(pair);
            //Assert.IsInstanceOf<ApiResponseCryptoExchanges> (response, "response is ApiResponseCryptoExchanges");
        }
        
        /// <summary>
        /// Test GetCryptoPairs
        /// </summary>
        [Test]
        public void GetCryptoPairsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //string currency = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPairs(exchange, currency, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoPairs> (response, "response is ApiResponseCryptoPairs");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsAdi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsAdiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsAdi(pair, exchange, currency, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoAccumulationDistributionIndex> (response, "response is ApiResponseCryptoAccumulationDistributionIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsAdtv
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsAdtvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsAdtv(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoAverageDailyTradingVolume> (response, "response is ApiResponseCryptoAverageDailyTradingVolume");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsAdx
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsAdxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsAdx(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoAverageDirectionalIndex> (response, "response is ApiResponseCryptoAverageDirectionalIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsAo
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsAoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? shortPeriod = null;
            //int? longPeriod = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsAo(pair, exchange, currency, shortPeriod, longPeriod, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoAwesomeOscillator> (response, "response is ApiResponseCryptoAwesomeOscillator");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsAtr
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsAtrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsAtr(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoAverageTrueRange> (response, "response is ApiResponseCryptoAverageTrueRange");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsBb
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsBbTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //float? standardDeviations = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsBb(pair, exchange, currency, period, standardDeviations, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoBollingerBands> (response, "response is ApiResponseCryptoBollingerBands");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsCci
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsCciTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //float? constant = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsCci(pair, exchange, currency, period, constant, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoCommodityChannelIndex> (response, "response is ApiResponseCryptoCommodityChannelIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsCmf
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsCmfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsCmf(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoChaikinMoneyFlow> (response, "response is ApiResponseCryptoChaikinMoneyFlow");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsDc
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsDcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsDc(pair, exchange, currency, period, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoDonchianChannel> (response, "response is ApiResponseCryptoDonchianChannel");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsDpo
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsDpoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsDpo(pair, exchange, currency, period, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoDetrendedPriceOscillator> (response, "response is ApiResponseCryptoDetrendedPriceOscillator");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsEom
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsEomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsEom(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoEaseOfMovement> (response, "response is ApiResponseCryptoEaseOfMovement");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsFi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsFiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsFi(pair, exchange, currency, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoForceIndex> (response, "response is ApiResponseCryptoForceIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsIchimoku
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsIchimokuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? lowPeriod = null;
            //int? mediumPeriod = null;
            //int? highPeriod = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsIchimoku(pair, exchange, currency, lowPeriod, mediumPeriod, highPeriod, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoIchimokuKinkoHyo> (response, "response is ApiResponseCryptoIchimokuKinkoHyo");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsKc
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsKcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsKc(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoKeltnerChannel> (response, "response is ApiResponseCryptoKeltnerChannel");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsKst
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsKstTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? roc1 = null;
            //int? roc2 = null;
            //int? roc3 = null;
            //int? roc4 = null;
            //int? sma1 = null;
            //int? sma2 = null;
            //int? sma3 = null;
            //int? sma4 = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsKst(pair, exchange, currency, roc1, roc2, roc3, roc4, sma1, sma2, sma3, sma4, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoKnowSureThing> (response, "response is ApiResponseCryptoKnowSureThing");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsMacd
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsMacdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? fastPeriod = null;
            //int? slowPeriod = null;
            //int? signalPeriod = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsMacd(pair, exchange, currency, fastPeriod, slowPeriod, signalPeriod, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoMovingAverageConvergenceDivergence> (response, "response is ApiResponseCryptoMovingAverageConvergenceDivergence");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsMfi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsMfiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsMfi(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoMoneyFlowIndex> (response, "response is ApiResponseCryptoMoneyFlowIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsMi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsMiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? emaPeriod = null;
            //int? sumPeriod = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsMi(pair, exchange, currency, emaPeriod, sumPeriod, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoMassIndex> (response, "response is ApiResponseCryptoMassIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsNvi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsNviTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsNvi(pair, exchange, currency, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoNegativeVolumeIndex> (response, "response is ApiResponseCryptoNegativeVolumeIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsObv
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsObvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsObv(pair, exchange, currency, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoOnBalanceVolume> (response, "response is ApiResponseCryptoOnBalanceVolume");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsObvMean
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsObvMeanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsObvMean(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoOnBalanceVolumeMean> (response, "response is ApiResponseCryptoOnBalanceVolumeMean");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsRsi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsRsiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsRsi(pair, exchange, currency, period, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoRelativeStrengthIndex> (response, "response is ApiResponseCryptoRelativeStrengthIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsSma
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsSmaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsSma(pair, exchange, currency, period, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoSimpleMovingAverage> (response, "response is ApiResponseCryptoSimpleMovingAverage");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsSr
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsSrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //int? signalPeriod = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsSr(pair, exchange, currency, period, signalPeriod, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoStochasticOscillator> (response, "response is ApiResponseCryptoStochasticOscillator");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsTrix
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsTrixTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsTrix(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoTripleExponentialAverage> (response, "response is ApiResponseCryptoTripleExponentialAverage");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsTsi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsTsiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? lowPeriod = null;
            //int? highPeriod = null;
            //string priceKey = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsTsi(pair, exchange, currency, lowPeriod, highPeriod, priceKey, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoTrueStrengthIndex> (response, "response is ApiResponseCryptoTrueStrengthIndex");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsUo
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsUoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? shortPeriod = null;
            //int? mediumPeriod = null;
            //int? longPeriod = null;
            //float? shortWeight = null;
            //float? mediumWeight = null;
            //float? longWeight = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsUo(pair, exchange, currency, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoUltimateOscillator> (response, "response is ApiResponseCryptoUltimateOscillator");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsVi
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsViTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsVi(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoVortexIndicator> (response, "response is ApiResponseCryptoVortexIndicator");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsVpt
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsVptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsVpt(pair, exchange, currency, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoVolumePriceTrend> (response, "response is ApiResponseCryptoVolumePriceTrend");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsVwap
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsVwapTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsVwap(pair, exchange, currency, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoVolumeWeightedAveragePrice> (response, "response is ApiResponseCryptoVolumeWeightedAveragePrice");
        }
        
        /// <summary>
        /// Test GetCryptoPriceTechnicalsWr
        /// </summary>
        [Test]
        public void GetCryptoPriceTechnicalsWrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //int? period = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPriceTechnicalsWr(pair, exchange, currency, period, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoWilliamsR> (response, "response is ApiResponseCryptoWilliamsR");
        }
        
        /// <summary>
        /// Test GetCryptoPrices
        /// </summary>
        [Test]
        public void GetCryptoPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeframe = null;
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCryptoPrices(timeframe, pair, exchange, currency, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCryptoPrices> (response, "response is ApiResponseCryptoPrices");
        }
        
        /// <summary>
        /// Test GetCryptoSnapshot
        /// </summary>
        [Test]
        public void GetCryptoSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string exchange = null;
            //string currency = null;
            //var response = instance.GetCryptoSnapshot(pair, exchange, currency);
            //Assert.IsInstanceOf<ApiResponseCryptoSnapshot> (response, "response is ApiResponseCryptoSnapshot");
        }
        
        /// <summary>
        /// Test GetCryptoStats
        /// </summary>
        [Test]
        public void GetCryptoStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //string currency = null;
            //var response = instance.GetCryptoStats(exchange, currency);
            //Assert.IsInstanceOf<ApiResponseCryptoStats> (response, "response is ApiResponseCryptoStats");
        }
        
    }

}

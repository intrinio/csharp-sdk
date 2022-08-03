

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
    ///  Class for testing SecurityApi
    /// </summary>
    [TestFixture]
    public class SecurityApiTests
    {
        private SecurityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecurityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecurityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecurityApi
            //Assert.IsInstanceOfType(typeof(SecurityApi), instance, "instance is a SecurityApi");
        }

        
        /// <summary>
        /// Test GetAllSecurities
        /// </summary>
        [Test]
        public void GetAllSecuritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? active = null;
            //bool? delisted = null;
            //string code = null;
            //string currency = null;
            //string ticker = null;
            //string name = null;
            //string compositeMic = null;
            //string exchangeMic = null;
            //DateTime? stockPricesAfter = null;
            //DateTime? stockPricesBefore = null;
            //string cik = null;
            //string figi = null;
            //string compositeFigi = null;
            //string shareClassFigi = null;
            //string figiUniqueId = null;
            //bool? includeNonFigi = null;
            //int? pageSize = null;
            //bool? primaryListing = null;
            //string nextPage = null;
            //var response = instance.GetAllSecurities(active, delisted, code, currency, ticker, name, compositeMic, exchangeMic, stockPricesAfter, stockPricesBefore, cik, figi, compositeFigi, shareClassFigi, figiUniqueId, includeNonFigi, pageSize, primaryListing, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurities> (response, "response is ApiResponseSecurities");
        }
        
        /// <summary>
        /// Test GetSecurityById
        /// </summary>
        [Test]
        public void GetSecurityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetSecurityById(identifier);
            //Assert.IsInstanceOf<Security> (response, "response is Security");
        }
        
        /// <summary>
        /// Test GetSecurityDataPointNumber
        /// </summary>
        [Test]
        public void GetSecurityDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetSecurityDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test GetSecurityDataPointText
        /// </summary>
        [Test]
        public void GetSecurityDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetSecurityDataPointText(identifier, tag);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetSecurityHistoricalData
        /// </summary>
        [Test]
        public void GetSecurityHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //string frequency = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityHistoricalData> (response, "response is ApiResponseSecurityHistoricalData");
        }
        
        /// <summary>
        /// Test GetSecurityInsiderOwnership
        /// </summary>
        [Test]
        public void GetSecurityInsiderOwnershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetSecurityInsiderOwnership(identifier);
            //Assert.IsInstanceOf<ApiResponseSecurityInstitutionalOwnership> (response, "response is ApiResponseSecurityInstitutionalOwnership");
        }
        
        /// <summary>
        /// Test GetSecurityIntervalPrices
        /// </summary>
        [Test]
        public void GetSecurityIntervalPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //string timezone = null;
            //string intervalSize = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityIntervalPrices(identifier, source, startDate, startTime, endDate, endTime, timezone, intervalSize, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityIntervalPrices> (response, "response is ApiResponseSecurityIntervalPrices");
        }
        
        /// <summary>
        /// Test GetSecurityIntradayPrices
        /// </summary>
        [Test]
        public void GetSecurityIntradayPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityIntradayPrices(identifier, source, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityIntradayPrices> (response, "response is ApiResponseSecurityIntradayPrices");
        }
        
        /// <summary>
        /// Test GetSecurityLatestDividendRecord
        /// </summary>
        [Test]
        public void GetSecurityLatestDividendRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetSecurityLatestDividendRecord(identifier);
            //Assert.IsInstanceOf<DividendRecord> (response, "response is DividendRecord");
        }
        
        /// <summary>
        /// Test GetSecurityLatestEarningsRecord
        /// </summary>
        [Test]
        public void GetSecurityLatestEarningsRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetSecurityLatestEarningsRecord(identifier);
            //Assert.IsInstanceOf<EarningsRecord> (response, "response is EarningsRecord");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsAdi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsAdiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsAdi(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityAccumulationDistributionIndex> (response, "response is ApiResponseSecurityAccumulationDistributionIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsAdtv
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsAdtvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsAdtv(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityAverageDailyTradingVolume> (response, "response is ApiResponseSecurityAverageDailyTradingVolume");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsAdx
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsAdxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsAdx(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityAverageDirectionalIndex> (response, "response is ApiResponseSecurityAverageDirectionalIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsAo
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsAoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? shortPeriod = null;
            //int? longPeriod = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsAo(identifier, shortPeriod, longPeriod, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityAwesomeOscillator> (response, "response is ApiResponseSecurityAwesomeOscillator");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsAtr
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsAtrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsAtr(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityAverageTrueRange> (response, "response is ApiResponseSecurityAverageTrueRange");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsBb
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsBbTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //float? standardDeviations = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsBb(identifier, period, standardDeviations, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityBollingerBands> (response, "response is ApiResponseSecurityBollingerBands");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsCci
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsCciTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //float? constant = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsCci(identifier, period, constant, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityCommodityChannelIndex> (response, "response is ApiResponseSecurityCommodityChannelIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsCmf
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsCmfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsCmf(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityChaikinMoneyFlow> (response, "response is ApiResponseSecurityChaikinMoneyFlow");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsDc
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsDcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsDc(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityDonchianChannel> (response, "response is ApiResponseSecurityDonchianChannel");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsDpo
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsDpoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsDpo(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityDetrendedPriceOscillator> (response, "response is ApiResponseSecurityDetrendedPriceOscillator");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsEom
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsEomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsEom(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityEaseOfMovement> (response, "response is ApiResponseSecurityEaseOfMovement");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsFi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsFiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsFi(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityForceIndex> (response, "response is ApiResponseSecurityForceIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsIchimoku
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsIchimokuTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? lowPeriod = null;
            //int? mediumPeriod = null;
            //int? highPeriod = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsIchimoku(identifier, lowPeriod, mediumPeriod, highPeriod, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityIchimokuKinkoHyo> (response, "response is ApiResponseSecurityIchimokuKinkoHyo");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsKc
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsKcTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsKc(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityKeltnerChannel> (response, "response is ApiResponseSecurityKeltnerChannel");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsKst
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsKstTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? roc1 = null;
            //int? roc2 = null;
            //int? roc3 = null;
            //int? roc4 = null;
            //int? sma1 = null;
            //int? sma2 = null;
            //int? sma3 = null;
            //int? sma4 = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsKst(identifier, roc1, roc2, roc3, roc4, sma1, sma2, sma3, sma4, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityKnowSureThing> (response, "response is ApiResponseSecurityKnowSureThing");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsMacd
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsMacdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? fastPeriod = null;
            //int? slowPeriod = null;
            //int? signalPeriod = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsMacd(identifier, fastPeriod, slowPeriod, signalPeriod, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityMovingAverageConvergenceDivergence> (response, "response is ApiResponseSecurityMovingAverageConvergenceDivergence");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsMfi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsMfiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsMfi(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityMoneyFlowIndex> (response, "response is ApiResponseSecurityMoneyFlowIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsMi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsMiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? emaPeriod = null;
            //int? sumPeriod = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsMi(identifier, emaPeriod, sumPeriod, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityMassIndex> (response, "response is ApiResponseSecurityMassIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsNvi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsNviTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsNvi(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityNegativeVolumeIndex> (response, "response is ApiResponseSecurityNegativeVolumeIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsObv
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsObvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsObv(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityOnBalanceVolume> (response, "response is ApiResponseSecurityOnBalanceVolume");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsObvMean
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsObvMeanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsObvMean(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityOnBalanceVolumeMean> (response, "response is ApiResponseSecurityOnBalanceVolumeMean");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsRsi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsRsiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsRsi(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityRelativeStrengthIndex> (response, "response is ApiResponseSecurityRelativeStrengthIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsSma
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsSmaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsSma(identifier, period, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecuritySimpleMovingAverage> (response, "response is ApiResponseSecuritySimpleMovingAverage");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsSr
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsSrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //int? signalPeriod = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsSr(identifier, period, signalPeriod, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityStochasticOscillator> (response, "response is ApiResponseSecurityStochasticOscillator");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsTrix
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsTrixTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsTrix(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityTripleExponentialAverage> (response, "response is ApiResponseSecurityTripleExponentialAverage");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsTsi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsTsiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? lowPeriod = null;
            //int? highPeriod = null;
            //string priceKey = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsTsi(identifier, lowPeriod, highPeriod, priceKey, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityTrueStrengthIndex> (response, "response is ApiResponseSecurityTrueStrengthIndex");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsUo
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsUoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? shortPeriod = null;
            //int? mediumPeriod = null;
            //int? longPeriod = null;
            //float? shortWeight = null;
            //float? mediumWeight = null;
            //float? longWeight = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsUo(identifier, shortPeriod, mediumPeriod, longPeriod, shortWeight, mediumWeight, longWeight, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityUltimateOscillator> (response, "response is ApiResponseSecurityUltimateOscillator");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsVi
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsViTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsVi(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityVortexIndicator> (response, "response is ApiResponseSecurityVortexIndicator");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsVpt
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsVptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsVpt(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityVolumePriceTrend> (response, "response is ApiResponseSecurityVolumePriceTrend");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsVwap
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsVwapTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsVwap(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityVolumeWeightedAveragePrice> (response, "response is ApiResponseSecurityVolumeWeightedAveragePrice");
        }
        
        /// <summary>
        /// Test GetSecurityPriceTechnicalsWr
        /// </summary>
        [Test]
        public void GetSecurityPriceTechnicalsWrTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? period = null;
            //string startDate = null;
            //string endDate = null;
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityPriceTechnicalsWr(identifier, period, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityWilliamsR> (response, "response is ApiResponseSecurityWilliamsR");
        }
        
        /// <summary>
        /// Test GetSecurityRealtimePrice
        /// </summary>
        [Test]
        public void GetSecurityRealtimePriceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //var response = instance.GetSecurityRealtimePrice(identifier, source);
            //Assert.IsInstanceOf<RealtimeStockPrice> (response, "response is RealtimeStockPrice");
        }
        
        /// <summary>
        /// Test GetSecuritySnapshots
        /// </summary>
        [Test]
        public void GetSecuritySnapshotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? atDatetime = null;
            //var response = instance.GetSecuritySnapshots(atDatetime);
            //Assert.IsInstanceOf<SecuritySnapshotsResult> (response, "response is SecuritySnapshotsResult");
        }
        
        /// <summary>
        /// Test GetSecurityStockPriceAdjustments
        /// </summary>
        [Test]
        public void GetSecurityStockPriceAdjustmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityStockPriceAdjustments(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityStockPriceAdjustments> (response, "response is ApiResponseSecurityStockPriceAdjustments");
        }
        
        /// <summary>
        /// Test GetSecurityStockPrices
        /// </summary>
        [Test]
        public void GetSecurityStockPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string frequency = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityStockPrices(identifier, startDate, endDate, frequency, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityStockPrices> (response, "response is ApiResponseSecurityStockPrices");
        }
        
        /// <summary>
        /// Test GetSecurityZacksAnalystRatings
        /// </summary>
        [Test]
        public void GetSecurityZacksAnalystRatingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //decimal? meanGreater = null;
            //decimal? meanLess = null;
            //int? strongBuysGreater = null;
            //int? strongBuysLess = null;
            //int? buysGreater = null;
            //int? buysLess = null;
            //int? holdsGreater = null;
            //int? holdsLess = null;
            //int? sellsGreater = null;
            //int? sellsLess = null;
            //int? strongSellsGreater = null;
            //int? strongSellsLess = null;
            //int? totalGreater = null;
            //int? totalLess = null;
            //int? pageSize = null;
            //var response = instance.GetSecurityZacksAnalystRatings(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize);
            //Assert.IsInstanceOf<ApiResponseSecurityZacksAnalystRatings> (response, "response is ApiResponseSecurityZacksAnalystRatings");
        }
        
        /// <summary>
        /// Test GetSecurityZacksAnalystRatingsSnapshot
        /// </summary>
        [Test]
        public void GetSecurityZacksAnalystRatingsSnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string date = null;
            //var response = instance.GetSecurityZacksAnalystRatingsSnapshot(identifier, date);
            //Assert.IsInstanceOf<ApiResponseSecurityZacksAnalystRatingsSnapshot> (response, "response is ApiResponseSecurityZacksAnalystRatingsSnapshot");
        }
        
        /// <summary>
        /// Test GetSecurityZacksEpsSurprises
        /// </summary>
        [Test]
        public void GetSecurityZacksEpsSurprisesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityZacksEpsSurprises(identifier, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityZacksEPSSurprises> (response, "response is ApiResponseSecurityZacksEPSSurprises");
        }
        
        /// <summary>
        /// Test GetSecurityZacksSalesSurprises
        /// </summary>
        [Test]
        public void GetSecurityZacksSalesSurprisesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSecurityZacksSalesSurprises(identifier, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityZacksSalesSurprises> (response, "response is ApiResponseSecurityZacksSalesSurprises");
        }
        
        /// <summary>
        /// Test ScreenSecurities
        /// </summary>
        [Test]
        public void ScreenSecuritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityScreenGroup logic = null;
            //string orderColumn = null;
            //string orderDirection = null;
            //bool? primaryOnly = null;
            //int? pageSize = null;
            //var response = instance.ScreenSecurities(logic, orderColumn, orderDirection, primaryOnly, pageSize);
            //Assert.IsInstanceOf<List<SecurityScreenResult>> (response, "response is List<SecurityScreenResult>");
        }
        
        /// <summary>
        /// Test SearchSecurities
        /// </summary>
        [Test]
        public void SearchSecuritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //int? pageSize = null;
            //var response = instance.SearchSecurities(query, pageSize);
            //Assert.IsInstanceOf<ApiResponseSecuritiesSearch> (response, "response is ApiResponseSecuritiesSearch");
        }
        
    }

}

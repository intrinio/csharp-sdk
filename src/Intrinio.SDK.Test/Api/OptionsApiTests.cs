

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
    ///  Class for testing OptionsApi
    /// </summary>
    [TestFixture]
    public class OptionsApiTests
    {
        private OptionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OptionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OptionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OptionsApi
            //Assert.IsInstanceOfType(typeof(OptionsApi), instance, "instance is a OptionsApi");
        }

        
        /// <summary>
        /// Test GetAllOptionsTickers
        /// </summary>
        [Test]
        public void GetAllOptionsTickersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllOptionsTickers();
            //Assert.IsInstanceOf<ApiResponseOptionsTickers> (response, "response is ApiResponseOptionsTickers");
        }
        
        /// <summary>
        /// Test GetOptionExpirationsRealtime
        /// </summary>
        [Test]
        public void GetOptionExpirationsRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string after = null;
            //string before = null;
            //string source = null;
            //var response = instance.GetOptionExpirationsRealtime(symbol, after, before, source);
            //Assert.IsInstanceOf<ApiResponseOptionsExpirations> (response, "response is ApiResponseOptionsExpirations");
        }
        
        /// <summary>
        /// Test GetOptionStrikesRealtime
        /// </summary>
        [Test]
        public void GetOptionStrikesRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //decimal? strike = null;
            //var response = instance.GetOptionStrikesRealtime(symbol, strike);
            //Assert.IsInstanceOf<ApiResponseOptionsChainRealtime> (response, "response is ApiResponseOptionsChainRealtime");
        }
        
        /// <summary>
        /// Test GetOptions
        /// </summary>
        [Test]
        public void GetOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string type = null;
            //decimal? strike = null;
            //decimal? strikeGreaterThan = null;
            //decimal? strikeLessThan = null;
            //string expiration = null;
            //string expirationAfter = null;
            //string expirationBefore = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetOptions(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseOptions> (response, "response is ApiResponseOptions");
        }
        
        /// <summary>
        /// Test GetOptionsBySymbolRealtime
        /// </summary>
        [Test]
        public void GetOptionsBySymbolRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string type = null;
            //decimal? strike = null;
            //decimal? strikeGreaterThan = null;
            //decimal? strikeLessThan = null;
            //string expiration = null;
            //string expirationAfter = null;
            //string expirationBefore = null;
            //string source = null;
            //var response = instance.GetOptionsBySymbolRealtime(symbol, type, strike, strikeGreaterThan, strikeLessThan, expiration, expirationAfter, expirationBefore, source);
            //Assert.IsInstanceOf<ApiResponseOptionsRealtime> (response, "response is ApiResponseOptionsRealtime");
        }
        
        /// <summary>
        /// Test GetOptionsChain
        /// </summary>
        [Test]
        public void GetOptionsChainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string expiration = null;
            //DateTime? date = null;
            //string type = null;
            //decimal? strike = null;
            //decimal? strikeGreaterThan = null;
            //decimal? strikeLessThan = null;
            //string moneyness = null;
            //int? pageSize = null;
            //var response = instance.GetOptionsChain(symbol, expiration, date, type, strike, strikeGreaterThan, strikeLessThan, moneyness, pageSize);
            //Assert.IsInstanceOf<ApiResponseOptionsChain> (response, "response is ApiResponseOptionsChain");
        }
        
        /// <summary>
        /// Test GetOptionsChainEod
        /// </summary>
        [Test]
        public void GetOptionsChainEodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string expiration = null;
            //string type = null;
            //decimal? strike = null;
            //decimal? strikeGreaterThan = null;
            //decimal? strikeLessThan = null;
            //DateTime? date = null;
            //var response = instance.GetOptionsChainEod(symbol, expiration, type, strike, strikeGreaterThan, strikeLessThan, date);
            //Assert.IsInstanceOf<ApiResponseOptionsChainEod> (response, "response is ApiResponseOptionsChainEod");
        }
        
        /// <summary>
        /// Test GetOptionsChainRealtime
        /// </summary>
        [Test]
        public void GetOptionsChainRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string expiration = null;
            //string source = null;
            //string type = null;
            //decimal? strike = null;
            //decimal? strikeGreaterThan = null;
            //decimal? strikeLessThan = null;
            //decimal? volumeGreaterThan = null;
            //decimal? volumeLessThan = null;
            //decimal? openInterestGreaterThan = null;
            //decimal? openInterestLessThan = null;
            //string moneyness = null;
            //var response = instance.GetOptionsChainRealtime(symbol, expiration, source, type, strike, strikeGreaterThan, strikeLessThan, volumeGreaterThan, volumeLessThan, openInterestGreaterThan, openInterestLessThan, moneyness);
            //Assert.IsInstanceOf<ApiResponseOptionsChainRealtime> (response, "response is ApiResponseOptionsChainRealtime");
        }
        
        /// <summary>
        /// Test GetOptionsExpirations
        /// </summary>
        [Test]
        public void GetOptionsExpirationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string after = null;
            //string before = null;
            //var response = instance.GetOptionsExpirations(symbol, after, before);
            //Assert.IsInstanceOf<ApiResponseOptionsExpirations> (response, "response is ApiResponseOptionsExpirations");
        }
        
        /// <summary>
        /// Test GetOptionsPrices
        /// </summary>
        [Test]
        public void GetOptionsPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetOptionsPrices(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseOptionPrices> (response, "response is ApiResponseOptionPrices");
        }
        
        /// <summary>
        /// Test GetOptionsPricesBatchRealtime
        /// </summary>
        [Test]
        public void GetOptionsPricesBatchRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OptionContractsList body = null;
            //string source = null;
            //var response = instance.GetOptionsPricesBatchRealtime(body, source);
            //Assert.IsInstanceOf<ApiResponseOptionsPricesBatchRealtime> (response, "response is ApiResponseOptionsPricesBatchRealtime");
        }
        
        /// <summary>
        /// Test GetOptionsPricesEod
        /// </summary>
        [Test]
        public void GetOptionsPricesEodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetOptionsPricesEod(identifier);
            //Assert.IsInstanceOf<ApiResponseOptionsPricesEod> (response, "response is ApiResponseOptionsPricesEod");
        }
        
        /// <summary>
        /// Test GetOptionsPricesRealtime
        /// </summary>
        [Test]
        public void GetOptionsPricesRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //var response = instance.GetOptionsPricesRealtime(identifier, source);
            //Assert.IsInstanceOf<ApiResponseOptionsPriceRealtime> (response, "response is ApiResponseOptionsPriceRealtime");
        }
        
        /// <summary>
        /// Test GetOptionsStatsRealtime
        /// </summary>
        [Test]
        public void GetOptionsStatsRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //var response = instance.GetOptionsStatsRealtime(identifier, source);
            //Assert.IsInstanceOf<ApiResponseOptionsStatsRealtime> (response, "response is ApiResponseOptionsStatsRealtime");
        }
        
        /// <summary>
        /// Test GetSecuritySnapshots
        /// </summary>
        [Test]
        public void GetSecuritySnapshotsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string source = null;
            //DateTime? atDatetime = null;
            //var response = instance.GetSecuritySnapshots(source, atDatetime);
            //Assert.IsInstanceOf<OptionSnapshotsResult> (response, "response is OptionSnapshotsResult");
        }
        
        /// <summary>
        /// Test GetUnusualActivity
        /// </summary>
        [Test]
        public void GetUnusualActivityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string source = null;
            //var response = instance.GetUnusualActivity(symbol, source);
            //Assert.IsInstanceOf<ApiResponseOptionsUnusualActivity> (response, "response is ApiResponseOptionsUnusualActivity");
        }
        
        /// <summary>
        /// Test GetUnusualActivityIntraday
        /// </summary>
        [Test]
        public void GetUnusualActivityIntradayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string nextPage = null;
            //int? pageSize = null;
            //string activityType = null;
            //string sentiment = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //Object minimumTotalValue = null;
            //Object maximumTotalValue = null;
            //var response = instance.GetUnusualActivityIntraday(symbol, nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
            //Assert.IsInstanceOf<ApiResponseOptionsUnusualActivity> (response, "response is ApiResponseOptionsUnusualActivity");
        }
        
        /// <summary>
        /// Test GetUnusualActivityUniversal
        /// </summary>
        [Test]
        public void GetUnusualActivityUniversalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string source = null;
            //var response = instance.GetUnusualActivityUniversal(source);
            //Assert.IsInstanceOf<ApiResponseOptionsUnusualActivity> (response, "response is ApiResponseOptionsUnusualActivity");
        }
        
        /// <summary>
        /// Test GetUnusualActivityUniversalIntraday
        /// </summary>
        [Test]
        public void GetUnusualActivityUniversalIntradayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //int? pageSize = null;
            //string activityType = null;
            //string sentiment = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //Object minimumTotalValue = null;
            //Object maximumTotalValue = null;
            //var response = instance.GetUnusualActivityUniversalIntraday(nextPage, pageSize, activityType, sentiment, startDate, endDate, minimumTotalValue, maximumTotalValue);
            //Assert.IsInstanceOf<ApiResponseOptionsUnusualActivity> (response, "response is ApiResponseOptionsUnusualActivity");
        }
        
    }

}

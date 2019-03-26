

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
            //string startDate = null;
            //string startTime = null;
            //string endDate = null;
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

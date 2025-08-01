

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
    ///  Class for testing ETFsApi
    /// </summary>
    [TestFixture]
    public class ETFsApiTests
    {
        private ETFsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ETFsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ETFsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ETFsApi
            //Assert.IsInstanceOfType(typeof(ETFsApi), instance, "instance is a ETFsApi");
        }

        
        /// <summary>
        /// Test GetAllEtfs
        /// </summary>
        [Test]
        public void GetAllEtfsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exchange = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllEtfs(exchange, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseETFs> (response, "response is ApiResponseETFs");
        }
        
        /// <summary>
        /// Test GetEtf
        /// </summary>
        [Test]
        public void GetEtfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetEtf(identifier);
            //Assert.IsInstanceOf<ETF> (response, "response is ETF");
        }
        
        /// <summary>
        /// Test GetEtfAnalytics
        /// </summary>
        [Test]
        public void GetEtfAnalyticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetEtfAnalytics(identifier);
            //Assert.IsInstanceOf<ETFAnalytics> (response, "response is ETFAnalytics");
        }
        
        /// <summary>
        /// Test GetEtfHistoricalStats
        /// </summary>
        [Test]
        public void GetEtfHistoricalStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? pageSize = null;
            //var response = instance.GetEtfHistoricalStats(identifier, startDate, endDate, pageSize);
            //Assert.IsInstanceOf<ETFHistoricalStats> (response, "response is ETFHistoricalStats");
        }
        
        /// <summary>
        /// Test GetEtfHoldings
        /// </summary>
        [Test]
        public void GetEtfHoldingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEtfHoldings(identifier, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseETFHoldings> (response, "response is ApiResponseETFHoldings");
        }
        
        /// <summary>
        /// Test GetEtfStats
        /// </summary>
        [Test]
        public void GetEtfStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetEtfStats(identifier);
            //Assert.IsInstanceOf<ETFStats> (response, "response is ETFStats");
        }
        
        /// <summary>
        /// Test SearchEtfs
        /// </summary>
        [Test]
        public void SearchEtfsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string mode = null;
            //var response = instance.SearchEtfs(query, mode);
            //Assert.IsInstanceOf<ApiResponseETFs> (response, "response is ApiResponseETFs");
        }
        
    }

}

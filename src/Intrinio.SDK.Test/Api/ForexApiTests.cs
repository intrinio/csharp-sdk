

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
    ///  Class for testing ForexApi
    /// </summary>
    [TestFixture]
    public class ForexApiTests
    {
        private ForexApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ForexApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ForexApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ForexApi
            //Assert.IsInstanceOfType(typeof(ForexApi), instance, "instance is a ForexApi");
        }

        
        /// <summary>
        /// Test GetForexCurrencies
        /// </summary>
        [Test]
        public void GetForexCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetForexCurrencies();
            //Assert.IsInstanceOf<ApiResponseForexCurrencies> (response, "response is ApiResponseForexCurrencies");
        }
        
        /// <summary>
        /// Test GetForexPairs
        /// </summary>
        [Test]
        public void GetForexPairsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetForexPairs();
            //Assert.IsInstanceOf<ApiResponseForexPairs> (response, "response is ApiResponseForexPairs");
        }
        
        /// <summary>
        /// Test GetForexPrices
        /// </summary>
        [Test]
        public void GetForexPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pair = null;
            //string timeframe = null;
            //string timezone = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetForexPrices(pair, timeframe, timezone, startDate, startTime, endDate, endTime, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseForexPrices> (response, "response is ApiResponseForexPrices");
        }
        
    }

}

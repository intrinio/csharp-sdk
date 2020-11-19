

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
        /// Test GetOptionsPricesRealtime
        /// </summary>
        [Test]
        public void GetOptionsPricesRealtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //var response = instance.GetOptionsPricesRealtime(identifier, source);
            //Assert.IsInstanceOf<ApiResponseOptionPricesRealtime> (response, "response is ApiResponseOptionPricesRealtime");
        }
        
    }

}

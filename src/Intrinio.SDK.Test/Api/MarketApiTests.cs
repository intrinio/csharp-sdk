

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
    ///  Class for testing MarketApi
    /// </summary>
    [TestFixture]
    public class MarketApiTests
    {
        private MarketApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MarketApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MarketApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MarketApi
            //Assert.IsInstanceOfType(typeof(MarketApi), instance, "instance is a MarketApi");
        }

        
        /// <summary>
        /// Test GetMarketStatus
        /// </summary>
        [Test]
        public void GetMarketStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMarketStatus();
            //Assert.IsInstanceOf<MarketStatusResult> (response, "response is MarketStatusResult");
        }
        
    }

}



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
    ///  Class for testing StockExchangeApi
    /// </summary>
    [TestFixture]
    public class StockExchangeApiTests
    {
        private StockExchangeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StockExchangeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StockExchangeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StockExchangeApi
            //Assert.IsInstanceOfType(typeof(StockExchangeApi), instance, "instance is a StockExchangeApi");
        }

        
        /// <summary>
        /// Test FilterStockExchanges
        /// </summary>
        [Test]
        public void FilterStockExchangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string city = null;
            //string country = null;
            //string countryCode = null;
            //var response = instance.FilterStockExchanges(city, country, countryCode);
            //Assert.IsInstanceOf<ApiResponseStockExchanges> (response, "response is ApiResponseStockExchanges");
        }
        
        /// <summary>
        /// Test GetAllStockExchanges
        /// </summary>
        [Test]
        public void GetAllStockExchangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllStockExchanges();
            //Assert.IsInstanceOf<ApiResponseStockExchanges> (response, "response is ApiResponseStockExchanges");
        }
        
        /// <summary>
        /// Test GetStockExchangeById
        /// </summary>
        [Test]
        public void GetStockExchangeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetStockExchangeById(identifier);
            //Assert.IsInstanceOf<StockExchange> (response, "response is StockExchange");
        }
        
        /// <summary>
        /// Test GetStockExchangePriceAdjustments
        /// </summary>
        [Test]
        public void GetStockExchangePriceAdjustmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? date = null;
            //string nextPage = null;
            //var response = instance.GetStockExchangePriceAdjustments(identifier, date, nextPage);
            //Assert.IsInstanceOf<ApiResponseStockExchangeStockPriceAdjustments> (response, "response is ApiResponseStockExchangeStockPriceAdjustments");
        }
        
        /// <summary>
        /// Test GetStockExchangePrices
        /// </summary>
        [Test]
        public void GetStockExchangePricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? date = null;
            //string nextPage = null;
            //var response = instance.GetStockExchangePrices(identifier, date, nextPage);
            //Assert.IsInstanceOf<ApiResponseStockExchangeStockPrices> (response, "response is ApiResponseStockExchangeStockPrices");
        }
        
        /// <summary>
        /// Test GetStockExchangeRealtimePrices
        /// </summary>
        [Test]
        public void GetStockExchangeRealtimePricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string source = null;
            //string nextPage = null;
            //var response = instance.GetStockExchangeRealtimePrices(identifier, source, nextPage);
            //Assert.IsInstanceOf<ApiResponseStockExchangeRealtimeStockPrices> (response, "response is ApiResponseStockExchangeRealtimeStockPrices");
        }
        
        /// <summary>
        /// Test GetStockExchangeSecurities
        /// </summary>
        [Test]
        public void GetStockExchangeSecuritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.GetStockExchangeSecurities(identifier, nextPage);
            //Assert.IsInstanceOf<ApiResponseStockExchangeSecurities> (response, "response is ApiResponseStockExchangeSecurities");
        }
        
    }

}



using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Intrinio.Client;
using Intrinio.Api;
using Intrinio.Model;

namespace Intrinio.Test
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
            //Assert.IsInstanceOf<InlineResponse20028> (response, "response is InlineResponse20028");
        }
        
        /// <summary>
        /// Test GetAllStockExchanges
        /// </summary>
        [Test]
        public void GetAllStockExchangesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllStockExchanges();
            //Assert.IsInstanceOf<InlineResponse20028> (response, "response is InlineResponse20028");
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
            //Assert.IsInstanceOf<InlineResponse20030> (response, "response is InlineResponse20030");
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
            //Assert.IsInstanceOf<InlineResponse20029> (response, "response is InlineResponse20029");
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
            //Assert.IsInstanceOf<InlineResponse20031> (response, "response is InlineResponse20031");
        }
        
    }

}

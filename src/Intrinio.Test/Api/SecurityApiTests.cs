

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
            //string nextPage = null;
            //var response = instance.GetAllSecurities(nextPage);
            //Assert.IsInstanceOf<InlineResponse20023> (response, "response is InlineResponse20023");
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
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
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
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
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
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //string nextPage = null;
            //var response = instance.GetSecurityHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
            //Assert.IsInstanceOf<InlineResponse20025> (response, "response is InlineResponse20025");
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
            //string nextPage = null;
            //var response = instance.GetSecurityStockPriceAdjustments(identifier, startDate, endDate, nextPage);
            //Assert.IsInstanceOf<InlineResponse20027> (response, "response is InlineResponse20027");
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
            //string nextPage = null;
            //var response = instance.GetSecurityStockPrices(identifier, startDate, endDate, frequency, nextPage);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
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
            //var response = instance.ScreenSecurities(logic, orderColumn, orderDirection, primaryOnly);
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
            //var response = instance.SearchSecurities(query);
            //Assert.IsInstanceOf<InlineResponse20024> (response, "response is InlineResponse20024");
        }
        
    }

}

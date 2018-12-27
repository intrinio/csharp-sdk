

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
            //string nextPage = null;
            //var response = instance.GetAllSecurities(nextPage);
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
            //string nextPage = null;
            //var response = instance.GetSecurityHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityHistoricalData> (response, "response is ApiResponseSecurityHistoricalData");
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
            //string nextPage = null;
            //var response = instance.GetSecurityStockPrices(identifier, startDate, endDate, frequency, nextPage);
            //Assert.IsInstanceOf<ApiResponseSecurityStockPrices> (response, "response is ApiResponseSecurityStockPrices");
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
            //Assert.IsInstanceOf<ApiResponseSecurities> (response, "response is ApiResponseSecurities");
        }
        
    }

}

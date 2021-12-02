

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
    ///  Class for testing FundamentalsApi
    /// </summary>
    [TestFixture]
    public class FundamentalsApiTests
    {
        private FundamentalsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FundamentalsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FundamentalsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FundamentalsApi
            //Assert.IsInstanceOfType(typeof(FundamentalsApi), instance, "instance is a FundamentalsApi");
        }

        
        /// <summary>
        /// Test GetFundamentalById
        /// </summary>
        [Test]
        public void GetFundamentalByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFundamentalById(id);
            //Assert.IsInstanceOf<Fundamental> (response, "response is Fundamental");
        }
        
        /// <summary>
        /// Test GetFundamentalReportedFinancials
        /// </summary>
        [Test]
        public void GetFundamentalReportedFinancialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFundamentalReportedFinancials(id);
            //Assert.IsInstanceOf<ApiResponseReportedFinancials> (response, "response is ApiResponseReportedFinancials");
        }
        
        /// <summary>
        /// Test GetFundamentalStandardizedFinancials
        /// </summary>
        [Test]
        public void GetFundamentalStandardizedFinancialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFundamentalStandardizedFinancials(id);
            //Assert.IsInstanceOf<ApiResponseStandardizedFinancials> (response, "response is ApiResponseStandardizedFinancials");
        }
        
        /// <summary>
        /// Test GetFundamentalStandardizedFinancialsDimensions
        /// </summary>
        [Test]
        public void GetFundamentalStandardizedFinancialsDimensionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string tag = null;
            //var response = instance.GetFundamentalStandardizedFinancialsDimensions(id, tag);
            //Assert.IsInstanceOf<ApiResponseStandardizedFinancialsDimensions> (response, "response is ApiResponseStandardizedFinancialsDimensions");
        }
        
        /// <summary>
        /// Test LookupFundamental
        /// </summary>
        [Test]
        public void LookupFundamentalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string statementCode = null;
            //int? fiscalYear = null;
            //string fiscalPeriod = null;
            //var response = instance.LookupFundamental(identifier, statementCode, fiscalYear, fiscalPeriod);
            //Assert.IsInstanceOf<Fundamental> (response, "response is Fundamental");
        }
        
    }

}

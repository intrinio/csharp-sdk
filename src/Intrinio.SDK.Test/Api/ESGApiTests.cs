

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
    ///  Class for testing ESGApi
    /// </summary>
    [TestFixture]
    public class ESGApiTests
    {
        private ESGApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ESGApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ESGApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ESGApi
            //Assert.IsInstanceOfType(typeof(ESGApi), instance, "instance is a ESGApi");
        }

        
        /// <summary>
        /// Test GetEsgCompanies
        /// </summary>
        [Test]
        public void GetEsgCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string industry = null;
            //string ticker = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEsgCompanies(country, industry, ticker, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseESGCompanies> (response, "response is ApiResponseESGCompanies");
        }
        
        /// <summary>
        /// Test GetEsgCompanyComprehensiveRatings
        /// </summary>
        [Test]
        public void GetEsgCompanyComprehensiveRatingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEsgCompanyComprehensiveRatings(identifier, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseESGCompanyComprehensiveRatingHistory> (response, "response is ApiResponseESGCompanyComprehensiveRatingHistory");
        }
        
        /// <summary>
        /// Test GetEsgCompanyRatings
        /// </summary>
        [Test]
        public void GetEsgCompanyRatingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEsgCompanyRatings(identifier, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseESGCompanyRatingHistory> (response, "response is ApiResponseESGCompanyRatingHistory");
        }
        
        /// <summary>
        /// Test GetEsgLatest
        /// </summary>
        [Test]
        public void GetEsgLatestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEsgLatest(country, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseESGLatest> (response, "response is ApiResponseESGLatest");
        }
        
        /// <summary>
        /// Test GetEsgLatestComprehensive
        /// </summary>
        [Test]
        public void GetEsgLatestComprehensiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEsgLatestComprehensive(country, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseESGLatestComprehensive> (response, "response is ApiResponseESGLatestComprehensive");
        }
        
    }

}



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
    ///  Class for testing FilingApi
    /// </summary>
    [TestFixture]
    public class FilingApiTests
    {
        private FilingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FilingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FilingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FilingApi
            //Assert.IsInstanceOfType(typeof(FilingApi), instance, "instance is a FilingApi");
        }

        
        /// <summary>
        /// Test FilterFilings
        /// </summary>
        [Test]
        public void FilterFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string company = null;
            //string reportType = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string nextPage = null;
            //var response = instance.FilterFilings(company, reportType, startDate, endDate, nextPage);
            //Assert.IsInstanceOf<ApiResponseFilings> (response, "response is ApiResponseFilings");
        }
        
        /// <summary>
        /// Test GetAllFilings
        /// </summary>
        [Test]
        public void GetAllFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllFilings(nextPage);
            //Assert.IsInstanceOf<ApiResponseFilings> (response, "response is ApiResponseFilings");
        }
        
        /// <summary>
        /// Test GetFilingById
        /// </summary>
        [Test]
        public void GetFilingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFilingById(id);
            //Assert.IsInstanceOf<Filing> (response, "response is Filing");
        }
        
    }

}

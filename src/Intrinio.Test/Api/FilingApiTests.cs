

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
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
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
            //Assert.IsInstanceOf<InlineResponse20010> (response, "response is InlineResponse20010");
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



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
    ///  Class for testing InsiderTransactionFilingsApi
    /// </summary>
    [TestFixture]
    public class InsiderTransactionFilingsApiTests
    {
        private InsiderTransactionFilingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InsiderTransactionFilingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InsiderTransactionFilingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InsiderTransactionFilingsApi
            //Assert.IsInstanceOfType(typeof(InsiderTransactionFilingsApi), instance, "instance is a InsiderTransactionFilingsApi");
        }

        
        /// <summary>
        /// Test GetAllInsiderTransactionFilings
        /// </summary>
        [Test]
        public void GetAllInsiderTransactionFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllInsiderTransactionFilings(startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseOwnerInsiderTransactionFilings> (response, "response is ApiResponseOwnerInsiderTransactionFilings");
        }
        
    }

}

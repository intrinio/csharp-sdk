

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
    ///  Class for testing BulkDownloadsApi
    /// </summary>
    [TestFixture]
    public class BulkDownloadsApiTests
    {
        private BulkDownloadsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BulkDownloadsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BulkDownloadsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BulkDownloadsApi
            //Assert.IsInstanceOfType(typeof(BulkDownloadsApi), instance, "instance is a BulkDownloadsApi");
        }

        
        /// <summary>
        /// Test GetBulkDownloadLinks
        /// </summary>
        [Test]
        public void GetBulkDownloadLinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBulkDownloadLinks();
            //Assert.IsInstanceOf<ApiResponseBulkDownloadLinks> (response, "response is ApiResponseBulkDownloadLinks");
        }
        
    }

}

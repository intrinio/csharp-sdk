

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
    ///  Class for testing IndicesApi
    /// </summary>
    [TestFixture]
    public class IndicesApiTests
    {
        private IndicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IndicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IndicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IndicesApi
            //Assert.IsInstanceOfType(typeof(IndicesApi), instance, "instance is a IndicesApi");
        }

        
        /// <summary>
        /// Test GetIndexIntervals
        /// </summary>
        [Test]
        public void GetIndexIntervalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string intervalSize = null;
            //DateTime? startDate = null;
            //string startTime = null;
            //DateTime? endDate = null;
            //string endTime = null;
            //string timezone = null;
            //int? pageSize = null;
            //var response = instance.GetIndexIntervals(identifier, intervalSize, startDate, startTime, endDate, endTime, timezone, pageSize);
            //Assert.IsInstanceOf<ApiResponseIndexIntervals> (response, "response is ApiResponseIndexIntervals");
        }
        
    }

}

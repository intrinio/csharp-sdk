

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
    ///  Class for testing DataPointApi
    /// </summary>
    [TestFixture]
    public class DataPointApiTests
    {
        private DataPointApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataPointApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataPointApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataPointApi
            //Assert.IsInstanceOfType(typeof(DataPointApi), instance, "instance is a DataPointApi");
        }

        
        /// <summary>
        /// Test GetDataPointNumber
        /// </summary>
        [Test]
        public void GetDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
        }
        
        /// <summary>
        /// Test GetDataPointText
        /// </summary>
        [Test]
        public void GetDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetDataPointText(identifier, tag);
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
        }
        
    }

}

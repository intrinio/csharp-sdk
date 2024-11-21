

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
    ///  Class for testing DataTagApi
    /// </summary>
    [TestFixture]
    public class DataTagApiTests
    {
        private DataTagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataTagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataTagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataTagApi
            //Assert.IsInstanceOfType(typeof(DataTagApi), instance, "instance is a DataTagApi");
        }

        
        /// <summary>
        /// Test GetAllDataTags
        /// </summary>
        [Test]
        public void GetAllDataTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //string type = null;
            //string parent = null;
            //string statementCode = null;
            //string fsTemplate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllDataTags(tag, type, parent, statementCode, fsTemplate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseDataTags> (response, "response is ApiResponseDataTags");
        }
        
        /// <summary>
        /// Test GetDataTagById
        /// </summary>
        [Test]
        public void GetDataTagByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetDataTagById(identifier);
            //Assert.IsInstanceOf<DataTag> (response, "response is DataTag");
        }
        
        /// <summary>
        /// Test SearchDataTags
        /// </summary>
        [Test]
        public void SearchDataTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //int? pageSize = null;
            //var response = instance.SearchDataTags(query, pageSize);
            //Assert.IsInstanceOf<ApiResponseDataTagsSearch> (response, "response is ApiResponseDataTagsSearch");
        }
        
    }

}

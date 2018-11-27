

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
    ///  Class for testing StandardizedTagApi
    /// </summary>
    [TestFixture]
    public class StandardizedTagApiTests
    {
        private StandardizedTagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StandardizedTagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StandardizedTagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StandardizedTagApi
            //Assert.IsInstanceOfType(typeof(StandardizedTagApi), instance, "instance is a StandardizedTagApi");
        }

        
        /// <summary>
        /// Test FilterStandardizedTags
        /// </summary>
        [Test]
        public void FilterStandardizedTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tag = null;
            //string type = null;
            //string parent = null;
            //string statementCode = null;
            //string fsTemplate = null;
            //string nextPage = null;
            //var response = instance.FilterStandardizedTags(tag, type, parent, statementCode, fsTemplate, nextPage);
            //Assert.IsInstanceOf<List<StandardizedTag>> (response, "response is List<StandardizedTag>");
        }
        
        /// <summary>
        /// Test GetAllStandardizedTags
        /// </summary>
        [Test]
        public void GetAllStandardizedTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllStandardizedTags(nextPage);
            //Assert.IsInstanceOf<List<StandardizedTag>> (response, "response is List<StandardizedTag>");
        }
        
        /// <summary>
        /// Test GetStandardizedTagById
        /// </summary>
        [Test]
        public void GetStandardizedTagByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagId = null;
            //var response = instance.GetStandardizedTagById(tagId);
            //Assert.IsInstanceOf<StandardizedTag> (response, "response is StandardizedTag");
        }
        
        /// <summary>
        /// Test GetStandardizedTagDataPointNumber
        /// </summary>
        [Test]
        public void GetStandardizedTagDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string identifier = null;
            //var response = instance.GetStandardizedTagDataPointNumber(id, identifier);
            //Assert.IsInstanceOf<DataPointNumber> (response, "response is DataPointNumber");
        }
        
        /// <summary>
        /// Test GetStandardizedTagDataPointText
        /// </summary>
        [Test]
        public void GetStandardizedTagDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string identifier = null;
            //var response = instance.GetStandardizedTagDataPointText(id, identifier);
            //Assert.IsInstanceOf<DataPointText> (response, "response is DataPointText");
        }
        
        /// <summary>
        /// Test GetStandardizedTagHistoricalData
        /// </summary>
        [Test]
        public void GetStandardizedTagHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string identifier = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //string nextPage = null;
            //var response = instance.GetStandardizedTagHistoricalData(id, identifier, type, startDate, endDate, sortOrder, nextPage);
            //Assert.IsInstanceOf<List<HistoricalData>> (response, "response is List<HistoricalData>");
        }
        
        /// <summary>
        /// Test SearchStandardizedTags
        /// </summary>
        [Test]
        public void SearchStandardizedTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string nextPage = null;
            //var response = instance.SearchStandardizedTags(query, nextPage);
            //Assert.IsInstanceOf<List<StandardizedTag>> (response, "response is List<StandardizedTag>");
        }
        
    }

}

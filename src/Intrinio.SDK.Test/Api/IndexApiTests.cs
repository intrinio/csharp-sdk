

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
    ///  Class for testing IndexApi
    /// </summary>
    [TestFixture]
    public class IndexApiTests
    {
        private IndexApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IndexApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IndexApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IndexApi
            //Assert.IsInstanceOfType(typeof(IndexApi), instance, "instance is a IndexApi");
        }

        
        /// <summary>
        /// Test GetAllEconomicIndices
        /// </summary>
        [Test]
        public void GetAllEconomicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllEconomicIndices(pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseEconomicIndices> (response, "response is ApiResponseEconomicIndices");
        }
        
        /// <summary>
        /// Test GetAllSicIndices
        /// </summary>
        [Test]
        public void GetAllSicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllSicIndices(pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSICIndices> (response, "response is ApiResponseSICIndices");
        }
        
        /// <summary>
        /// Test GetAllStockMarketIndices
        /// </summary>
        [Test]
        public void GetAllStockMarketIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllStockMarketIndices(pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseStockMarketIndices> (response, "response is ApiResponseStockMarketIndices");
        }
        
        /// <summary>
        /// Test GetEconomicIndexById
        /// </summary>
        [Test]
        public void GetEconomicIndexByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetEconomicIndexById(identifier);
            //Assert.IsInstanceOf<EconomicIndex> (response, "response is EconomicIndex");
        }
        
        /// <summary>
        /// Test GetEconomicIndexDataPointNumber
        /// </summary>
        [Test]
        public void GetEconomicIndexDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetEconomicIndexDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test GetEconomicIndexDataPointText
        /// </summary>
        [Test]
        public void GetEconomicIndexDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetEconomicIndexDataPointText(identifier, tag);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetEconomicIndexHistoricalData
        /// </summary>
        [Test]
        public void GetEconomicIndexHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetEconomicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseEconomicIndexHistoricalData> (response, "response is ApiResponseEconomicIndexHistoricalData");
        }
        
        /// <summary>
        /// Test GetSicIndexById
        /// </summary>
        [Test]
        public void GetSicIndexByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetSicIndexById(identifier);
            //Assert.IsInstanceOf<SICIndex> (response, "response is SICIndex");
        }
        
        /// <summary>
        /// Test GetSicIndexDataPointNumber
        /// </summary>
        [Test]
        public void GetSicIndexDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetSicIndexDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test GetSicIndexDataPointText
        /// </summary>
        [Test]
        public void GetSicIndexDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetSicIndexDataPointText(identifier, tag);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetSicIndexHistoricalData
        /// </summary>
        [Test]
        public void GetSicIndexHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetSicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseSICIndexHistoricalData> (response, "response is ApiResponseSICIndexHistoricalData");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexById
        /// </summary>
        [Test]
        public void GetStockMarketIndexByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetStockMarketIndexById(identifier);
            //Assert.IsInstanceOf<StockMarketIndex> (response, "response is StockMarketIndex");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexDataPointNumber
        /// </summary>
        [Test]
        public void GetStockMarketIndexDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetStockMarketIndexDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexDataPointText
        /// </summary>
        [Test]
        public void GetStockMarketIndexDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetStockMarketIndexDataPointText(identifier, tag);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetStockMarketIndexHistoricalData
        /// </summary>
        [Test]
        public void GetStockMarketIndexHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //decimal? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetStockMarketIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseStockMarketIndexHistoricalData> (response, "response is ApiResponseStockMarketIndexHistoricalData");
        }
        
        /// <summary>
        /// Test SearchEconomicIndices
        /// </summary>
        [Test]
        public void SearchEconomicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //decimal? pageSize = null;
            //var response = instance.SearchEconomicIndices(query, pageSize);
            //Assert.IsInstanceOf<ApiResponseEconomicIndicesSearch> (response, "response is ApiResponseEconomicIndicesSearch");
        }
        
        /// <summary>
        /// Test SearchSicIndices
        /// </summary>
        [Test]
        public void SearchSicIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //decimal? pageSize = null;
            //var response = instance.SearchSicIndices(query, pageSize);
            //Assert.IsInstanceOf<ApiResponseSICIndicesSearch> (response, "response is ApiResponseSICIndicesSearch");
        }
        
        /// <summary>
        /// Test SearchStockMarketsIndices
        /// </summary>
        [Test]
        public void SearchStockMarketsIndicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //decimal? pageSize = null;
            //var response = instance.SearchStockMarketsIndices(query, pageSize);
            //Assert.IsInstanceOf<ApiResponseStockMarketIndicesSearch> (response, "response is ApiResponseStockMarketIndicesSearch");
        }
        
    }

}

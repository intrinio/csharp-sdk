

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
    ///  Class for testing MutualFundApi
    /// </summary>
    [TestFixture]
    public class MutualFundApiTests
    {
        private MutualFundApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MutualFundApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MutualFundApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MutualFundApi
            //Assert.IsInstanceOfType(typeof(MutualFundApi), instance, "instance is a MutualFundApi");
        }

        
        /// <summary>
        /// Test GetAllMutualFunds
        /// </summary>
        [Test]
        public void GetAllMutualFundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllMutualFunds(nextPage);
            //Assert.IsInstanceOf<List<MutualFund>> (response, "response is List<MutualFund>");
        }
        
        /// <summary>
        /// Test GetMutualFundById
        /// </summary>
        [Test]
        public void GetMutualFundByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetMutualFundById(identifier);
            //Assert.IsInstanceOf<MutualFund> (response, "response is MutualFund");
        }
        
        /// <summary>
        /// Test GetMutualFundStats
        /// </summary>
        [Test]
        public void GetMutualFundStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string nextPage = null;
            //var response = instance.GetMutualFundStats(identifier, startDate, endDate, nextPage);
            //Assert.IsInstanceOf<List<MutualFundStat>> (response, "response is List<MutualFundStat>");
        }
        
        /// <summary>
        /// Test SearchMutualFunds
        /// </summary>
        [Test]
        public void SearchMutualFundsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //string nextPage = null;
            //var response = instance.SearchMutualFunds(query, nextPage);
            //Assert.IsInstanceOf<List<MutualFund>> (response, "response is List<MutualFund>");
        }
        
    }

}

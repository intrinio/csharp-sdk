

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
    ///  Class for testing OwnersApi
    /// </summary>
    [TestFixture]
    public class OwnersApiTests
    {
        private OwnersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OwnersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OwnersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OwnersApi
            //Assert.IsInstanceOfType(typeof(OwnersApi), instance, "instance is a OwnersApi");
        }

        
        /// <summary>
        /// Test GetAllOwners
        /// </summary>
        [Test]
        public void GetAllOwnersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? institutional = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllOwners(institutional, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseOwners> (response, "response is ApiResponseOwners");
        }
        
        /// <summary>
        /// Test GetOwnerById
        /// </summary>
        [Test]
        public void GetOwnerByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetOwnerById(identifier);
            //Assert.IsInstanceOf<Owner> (response, "response is Owner");
        }
        
        /// <summary>
        /// Test InsiderTransactionFilingsByOwner
        /// </summary>
        [Test]
        public void InsiderTransactionFilingsByOwnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.InsiderTransactionFilingsByOwner(identifier, startDate, endDate, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseOwnerInsiderTransactionFilings> (response, "response is ApiResponseOwnerInsiderTransactionFilings");
        }
        
        /// <summary>
        /// Test InstitutionalHoldingsByOwner
        /// </summary>
        [Test]
        public void InstitutionalHoldingsByOwnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //Object asOfDate = null;
            //string nextPage = null;
            //var response = instance.InstitutionalHoldingsByOwner(identifier, pageSize, asOfDate, nextPage);
            //Assert.IsInstanceOf<ApiResponseOwnerInstitutionalHoldings> (response, "response is ApiResponseOwnerInstitutionalHoldings");
        }
        
        /// <summary>
        /// Test SearchOwners
        /// </summary>
        [Test]
        public void SearchOwnersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //bool? institutional = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.SearchOwners(query, institutional, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseOwners> (response, "response is ApiResponseOwners");
        }
        
    }

}

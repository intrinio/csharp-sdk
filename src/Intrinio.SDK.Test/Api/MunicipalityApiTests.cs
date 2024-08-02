

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
    ///  Class for testing MunicipalityApi
    /// </summary>
    [TestFixture]
    public class MunicipalityApiTests
    {
        private MunicipalityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MunicipalityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MunicipalityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MunicipalityApi
            //Assert.IsInstanceOfType(typeof(MunicipalityApi), instance, "instance is a MunicipalityApi");
        }

        
        /// <summary>
        /// Test GetAllMunicipalities
        /// </summary>
        [Test]
        public void GetAllMunicipalitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? hasFinancials = null;
            //string governmentName = null;
            //string governmentType = null;
            //string areaName = null;
            //string areaType = null;
            //string city = null;
            //string state = null;
            //decimal? zipcode = null;
            //decimal? populationGreaterThan = null;
            //decimal? populationLessThan = null;
            //decimal? enrollmentGreaterThan = null;
            //decimal? enrollmentLessThan = null;
            //string nextPage = null;
            //var response = instance.GetAllMunicipalities(hasFinancials, governmentName, governmentType, areaName, areaType, city, state, zipcode, populationGreaterThan, populationLessThan, enrollmentGreaterThan, enrollmentLessThan, nextPage);
            //Assert.IsInstanceOf<ApiResponseMunicipalities> (response, "response is ApiResponseMunicipalities");
        }
        
        /// <summary>
        /// Test GetMunicipalityById
        /// </summary>
        [Test]
        public void GetMunicipalityByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetMunicipalityById(id);
            //Assert.IsInstanceOf<Municipality> (response, "response is Municipality");
        }
        
        /// <summary>
        /// Test GetMunicipalityFinancials
        /// </summary>
        [Test]
        public void GetMunicipalityFinancialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //decimal? fiscalYear = null;
            //var response = instance.GetMunicipalityFinancials(id, fiscalYear);
            //Assert.IsInstanceOf<ApiResponseMunicipalitiyFinancials> (response, "response is ApiResponseMunicipalitiyFinancials");
        }
        
    }

}

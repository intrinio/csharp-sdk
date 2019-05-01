

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
    ///  Class for testing ZacksApi
    /// </summary>
    [TestFixture]
    public class ZacksApiTests
    {
        private ZacksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ZacksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ZacksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ZacksApi
            //Assert.IsInstanceOfType(typeof(ZacksApi), instance, "instance is a ZacksApi");
        }

        
        /// <summary>
        /// Test GetZacksAnalystRatings
        /// </summary>
        [Test]
        public void GetZacksAnalystRatingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string startDate = null;
            //string endDate = null;
            //decimal? meanGreater = null;
            //decimal? meanLess = null;
            //int? strongBuysGreater = null;
            //int? strongBuysLess = null;
            //int? buysGreater = null;
            //int? buysLess = null;
            //int? holdsGreater = null;
            //int? holdsLess = null;
            //int? sellsGreater = null;
            //int? sellsLess = null;
            //int? strongSellsGreater = null;
            //int? strongSellsLess = null;
            //int? totalGreater = null;
            //int? totalLess = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksAnalystRatings(identifier, startDate, endDate, meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksAnalystRatings> (response, "response is ApiResponseZacksAnalystRatings");
        }
        
        /// <summary>
        /// Test GetZacksEpsSurprises
        /// </summary>
        [Test]
        public void GetZacksEpsSurprisesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startDate = null;
            //string endDate = null;
            //decimal? epsActualGreater = null;
            //decimal? epsActualLess = null;
            //decimal? epsMeanEstimateGreater = null;
            //decimal? epsMeanEstimateLess = null;
            //decimal? epsAmountDiffGreater = null;
            //decimal? epsAmountDiffLess = null;
            //decimal? epsPercentDiffGreater = null;
            //decimal? epsPercentDiffLess = null;
            //decimal? epsCountEstimateGreater = null;
            //decimal? epsCountEstimateLess = null;
            //decimal? epsStdDevEstimateGreater = null;
            //decimal? epsStdDevEstimateLess = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksEpsSurprises(startDate, endDate, epsActualGreater, epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess, epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess, epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksEPSSurprises> (response, "response is ApiResponseZacksEPSSurprises");
        }
        
        /// <summary>
        /// Test GetZacksSalesSurprises
        /// </summary>
        [Test]
        public void GetZacksSalesSurprisesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startDate = null;
            //string endDate = null;
            //decimal? salesActualGreater = null;
            //decimal? salesActualLess = null;
            //decimal? salesMeanEstimateGreater = null;
            //decimal? salesMeanEstimateLess = null;
            //decimal? salesAmountDiffGreater = null;
            //decimal? salesAmountDiffLess = null;
            //decimal? salesPercentDiffGreater = null;
            //decimal? salesPercentDiffLess = null;
            //decimal? salesCountEstimateGreater = null;
            //decimal? salesCountEstimateLess = null;
            //decimal? salesStdDevEstimateGreater = null;
            //decimal? salesStdDevEstimateLess = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksSalesSurprises(startDate, endDate, salesActualGreater, salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater, salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater, salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksSalesSurprises> (response, "response is ApiResponseZacksSalesSurprises");
        }
        
    }

}



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
            //DateTime? startDate = null;
            //DateTime? endDate = null;
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
        /// Test GetZacksEbitdaConsensus
        /// </summary>
        [Test]
        public void GetZacksEbitdaConsensusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string type = null;
            //string nextPage = null;
            //var response = instance.GetZacksEbitdaConsensus(identifier, type, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksEBITDAConsensus> (response, "response is ApiResponseZacksEBITDAConsensus");
        }
        
        /// <summary>
        /// Test GetZacksEpsEstimates
        /// </summary>
        [Test]
        public void GetZacksEpsEstimatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? fiscalYear = null;
            //string fiscalPeriod = null;
            //int? calendarYear = null;
            //string calendarPeriod = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksEpsEstimates(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksEPSEstimates> (response, "response is ApiResponseZacksEPSEstimates");
        }
        
        /// <summary>
        /// Test GetZacksEpsGrowthRates
        /// </summary>
        [Test]
        public void GetZacksEpsGrowthRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string company = null;
            //string industryGroupName = null;
            //string industryGroupNumber = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksEpsGrowthRates(company, industryGroupName, industryGroupNumber, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksEPSGrowthRates> (response, "response is ApiResponseZacksEPSGrowthRates");
        }
        
        /// <summary>
        /// Test GetZacksEpsSurprises
        /// </summary>
        [Test]
        public void GetZacksEpsSurprisesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
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
        /// Test GetZacksEtfHoldings
        /// </summary>
        [Test]
        public void GetZacksEtfHoldingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string etfTicker = null;
            //string holdingSymbol = null;
            //decimal? weightGreater = null;
            //decimal? weightLess = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksEtfHoldings(etfTicker, holdingSymbol, weightGreater, weightLess, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksETFHoldings> (response, "response is ApiResponseZacksETFHoldings");
        }
        
        /// <summary>
        /// Test GetZacksForwardPe
        /// </summary>
        [Test]
        public void GetZacksForwardPeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetZacksForwardPe(nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksForwardPEs> (response, "response is ApiResponseZacksForwardPEs");
        }
        
        /// <summary>
        /// Test GetZacksForwardPeByIdentifier
        /// </summary>
        [Test]
        public void GetZacksForwardPeByIdentifierTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetZacksForwardPeByIdentifier(identifier);
            //Assert.IsInstanceOf<ZacksForwardPE> (response, "response is ZacksForwardPE");
        }
        
        /// <summary>
        /// Test GetZacksInstitutionalHoldingCompanies
        /// </summary>
        [Test]
        public void GetZacksInstitutionalHoldingCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticker = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksInstitutionalHoldingCompanies(ticker, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksInstitutionalHoldingCompanies> (response, "response is ApiResponseZacksInstitutionalHoldingCompanies");
        }
        
        /// <summary>
        /// Test GetZacksInstitutionalHoldingOwners
        /// </summary>
        [Test]
        public void GetZacksInstitutionalHoldingOwnersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cik = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksInstitutionalHoldingOwners(cik, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksInstitutionalHoldingOwners> (response, "response is ApiResponseZacksInstitutionalHoldingOwners");
        }
        
        /// <summary>
        /// Test GetZacksInstitutionalHoldings
        /// </summary>
        [Test]
        public void GetZacksInstitutionalHoldingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticker = null;
            //string ownerCik = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksInstitutionalHoldings(ticker, ownerCik, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksInstitutionalHoldings> (response, "response is ApiResponseZacksInstitutionalHoldings");
        }
        
        /// <summary>
        /// Test GetZacksLongTermGrowthRates
        /// </summary>
        [Test]
        public void GetZacksLongTermGrowthRatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksLongTermGrowthRates(identifier, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksLongTermGrowthRates> (response, "response is ApiResponseZacksLongTermGrowthRates");
        }
        
        /// <summary>
        /// Test GetZacksSalesEstimates
        /// </summary>
        [Test]
        public void GetZacksSalesEstimatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? fiscalYear = null;
            //string fiscalPeriod = null;
            //int? calendarYear = null;
            //string calendarPeriod = null;
            //string nextPage = null;
            //int? pageSize = null;
            //string nextPage2 = null;
            //var response = instance.GetZacksSalesEstimates(identifier, startDate, endDate, fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, nextPage, pageSize, nextPage2);
            //Assert.IsInstanceOf<ApiResponseZacksSalesEstimates> (response, "response is ApiResponseZacksSalesEstimates");
        }
        
        /// <summary>
        /// Test GetZacksSalesSurprises
        /// </summary>
        [Test]
        public void GetZacksSalesSurprisesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
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
        
        /// <summary>
        /// Test GetZacksTargetPriceConsensuses
        /// </summary>
        [Test]
        public void GetZacksTargetPriceConsensusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string industryGroupNumber = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetZacksTargetPriceConsensuses(identifier, industryGroupNumber, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseZacksTargetPriceConsensuses> (response, "response is ApiResponseZacksTargetPriceConsensuses");
        }
        
    }

}

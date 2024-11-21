

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
    ///  Class for testing CompanyApi
    /// </summary>
    [TestFixture]
    public class CompanyApiTests
    {
        private CompanyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompanyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompanyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompanyApi
            //Assert.IsInstanceOfType(typeof(CompanyApi), instance, "instance is a CompanyApi");
        }

        
        /// <summary>
        /// Test GetAllCompanies
        /// </summary>
        [Test]
        public void GetAllCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? latestFilingDate = null;
            //string sic = null;
            //string template = null;
            //string sector = null;
            //string industryCategory = null;
            //string industryGroup = null;
            //bool? hasFundamentals = null;
            //bool? hasStockPrices = null;
            //bool? theaEnabled = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetAllCompanies(latestFilingDate, sic, template, sector, industryCategory, industryGroup, hasFundamentals, hasStockPrices, theaEnabled, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanies> (response, "response is ApiResponseCompanies");
        }
        
        /// <summary>
        /// Test GetAllCompaniesDailyMetrics
        /// </summary>
        [Test]
        public void GetAllCompaniesDailyMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? onDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //string nextPage2 = null;
            //var response = instance.GetAllCompaniesDailyMetrics(onDate, pageSize, nextPage, nextPage2);
            //Assert.IsInstanceOf<ApiResponseCompanyDailyMetrics> (response, "response is ApiResponseCompanyDailyMetrics");
        }
        
        /// <summary>
        /// Test GetAllCompanyNews
        /// </summary>
        [Test]
        public void GetAllCompanyNewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string specificSource = null;
            //int? pageSize = null;
            //string sentiment = null;
            //string topic = null;
            //string company = null;
            //string security = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string language = null;
            //int? wordCountGreaterThan = null;
            //int? wordCountLessThan = null;
            //bool? isSpam = null;
            //decimal? businessRelevanceGreaterThan = null;
            //decimal? businessRelevanceLessThan = null;
            //string nextPage = null;
            //var response = instance.GetAllCompanyNews(specificSource, pageSize, sentiment, topic, company, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
            //Assert.IsInstanceOf<ApiResponseNews> (response, "response is ApiResponseNews");
        }
        
        /// <summary>
        /// Test GetCompany
        /// </summary>
        [Test]
        public void GetCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetCompany(identifier);
            //Assert.IsInstanceOf<Company> (response, "response is Company");
        }
        
        /// <summary>
        /// Test GetCompanyAnswers
        /// </summary>
        [Test]
        public void GetCompanyAnswersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string query = null;
            //var response = instance.GetCompanyAnswers(identifier, query);
            //Assert.IsInstanceOf<ApiResponseCompanyAnswers> (response, "response is ApiResponseCompanyAnswers");
        }
        
        /// <summary>
        /// Test GetCompanyDailyMetrics
        /// </summary>
        [Test]
        public void GetCompanyDailyMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? onDate = null;
            //int? pageSize = null;
            //string nextPage = null;
            //string nextPage2 = null;
            //var response = instance.GetCompanyDailyMetrics(identifier, onDate, pageSize, nextPage, nextPage2);
            //Assert.IsInstanceOf<ApiResponseCompanyDailyMetrics> (response, "response is ApiResponseCompanyDailyMetrics");
        }
        
        /// <summary>
        /// Test GetCompanyDataPointNumber
        /// </summary>
        [Test]
        public void GetCompanyDataPointNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetCompanyDataPointNumber(identifier, tag);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test GetCompanyDataPointText
        /// </summary>
        [Test]
        public void GetCompanyDataPointTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //var response = instance.GetCompanyDataPointText(identifier, tag);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetCompanyFilings
        /// </summary>
        [Test]
        public void GetCompanyFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string reportType = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //bool? theaEnabled = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCompanyFilings(identifier, reportType, startDate, endDate, theaEnabled, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyFilings> (response, "response is ApiResponseCompanyFilings");
        }
        
        /// <summary>
        /// Test GetCompanyFundamentals
        /// </summary>
        [Test]
        public void GetCompanyFundamentalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? filedAfter = null;
            //DateTime? filedBefore = null;
            //bool? reportedOnly = null;
            //int? fiscalYear = null;
            //string statementCode = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //DateTime? updatedAfter = null;
            //DateTime? updatedBefore = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCompanyFundamentals(identifier, filedAfter, filedBefore, reportedOnly, fiscalYear, statementCode, type, startDate, endDate, updatedAfter, updatedBefore, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyFundamentals> (response, "response is ApiResponseCompanyFundamentals");
        }
        
        /// <summary>
        /// Test GetCompanyHistoricalData
        /// </summary>
        [Test]
        public void GetCompanyHistoricalDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string tag = null;
            //string frequency = null;
            //string type = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string sortOrder = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCompanyHistoricalData(identifier, tag, frequency, type, startDate, endDate, sortOrder, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyHistoricalData> (response, "response is ApiResponseCompanyHistoricalData");
        }
        
        /// <summary>
        /// Test GetCompanyIpos
        /// </summary>
        [Test]
        public void GetCompanyIposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ticker = null;
            //string status = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? offerAmountGreaterThan = null;
            //int? offerAmountLessThan = null;
            //int? pageSize = null;
            //string nextPage = null;
            //var response = instance.GetCompanyIpos(ticker, status, startDate, endDate, offerAmountGreaterThan, offerAmountLessThan, pageSize, nextPage);
            //Assert.IsInstanceOf<ApiResponseInitialPublicOfferings> (response, "response is ApiResponseInitialPublicOfferings");
        }
        
        /// <summary>
        /// Test GetCompanyNews
        /// </summary>
        [Test]
        public void GetCompanyNewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string specificSource = null;
            //int? pageSize = null;
            //string sentiment = null;
            //string topic = null;
            //string security = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string language = null;
            //int? wordCountGreaterThan = null;
            //int? wordCountLessThan = null;
            //bool? isSpam = null;
            //decimal? businessRelevanceGreaterThan = null;
            //decimal? businessRelevanceLessThan = null;
            //string nextPage = null;
            //var response = instance.GetCompanyNews(identifier, specificSource, pageSize, sentiment, topic, security, startDate, endDate, language, wordCountGreaterThan, wordCountLessThan, isSpam, businessRelevanceGreaterThan, businessRelevanceLessThan, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyNews> (response, "response is ApiResponseCompanyNews");
        }
        
        /// <summary>
        /// Test GetCompanyNewsBody
        /// </summary>
        [Test]
        public void GetCompanyNewsBodyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string newsStoryId = null;
            //DateTime? publicationDate = null;
            //string specificSource = null;
            //string nextPage = null;
            //var response = instance.GetCompanyNewsBody(newsStoryId, publicationDate, specificSource, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanyNewsBody> (response, "response is ApiResponseCompanyNewsBody");
        }
        
        /// <summary>
        /// Test GetCompanyPublicFloat
        /// </summary>
        [Test]
        public void GetCompanyPublicFloatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? floatDateGreaterThan = null;
            //DateTime? floatDateLessThan = null;
            //string nextPage = null;
            //string nextPage2 = null;
            //var response = instance.GetCompanyPublicFloat(identifier, floatDateGreaterThan, floatDateLessThan, nextPage, nextPage2);
            //Assert.IsInstanceOf<ApiResponseCompanyPublicFloatResult> (response, "response is ApiResponseCompanyPublicFloatResult");
        }
        
        /// <summary>
        /// Test GetCompanySecurities
        /// </summary>
        [Test]
        public void GetCompanySecuritiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.GetCompanySecurities(identifier, nextPage);
            //Assert.IsInstanceOf<ApiResponseCompanySecurities> (response, "response is ApiResponseCompanySecurities");
        }
        
        /// <summary>
        /// Test InsiderTransactionFilingsByCompany
        /// </summary>
        [Test]
        public void InsiderTransactionFilingsByCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string ownershipType = null;
            //string nextPage = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string nextPage2 = null;
            //var response = instance.InsiderTransactionFilingsByCompany(identifier, startDate, endDate, ownershipType, nextPage, pageSize, sortBy, nextPage2);
            //Assert.IsInstanceOf<ApiResponseInsiderTransactionFilings> (response, "response is ApiResponseInsiderTransactionFilings");
        }
        
        /// <summary>
        /// Test LatestInsiderTransactionFilingByCompany
        /// </summary>
        [Test]
        public void LatestInsiderTransactionFilingByCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string nextPage = null;
            //var response = instance.LatestInsiderTransactionFilingByCompany(identifier, nextPage);
            //Assert.IsInstanceOf<InsiderTransactionFiling> (response, "response is InsiderTransactionFiling");
        }
        
        /// <summary>
        /// Test LookupCompanyFundamental
        /// </summary>
        [Test]
        public void LookupCompanyFundamentalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string statementCode = null;
            //string fiscalPeriod = null;
            //int? fiscalYear = null;
            //var response = instance.LookupCompanyFundamental(identifier, statementCode, fiscalPeriod, fiscalYear);
            //Assert.IsInstanceOf<Fundamental> (response, "response is Fundamental");
        }
        
        /// <summary>
        /// Test RecognizeCompany
        /// </summary>
        [Test]
        public void RecognizeCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string text = null;
            //var response = instance.RecognizeCompany(text);
            //Assert.IsInstanceOf<ApiResponseCompanyRecognize> (response, "response is ApiResponseCompanyRecognize");
        }
        
        /// <summary>
        /// Test SearchCompanies
        /// </summary>
        [Test]
        public void SearchCompaniesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //bool? active = null;
            //string mode = null;
            //int? pageSize = null;
            //var response = instance.SearchCompanies(query, active, mode, pageSize);
            //Assert.IsInstanceOf<ApiResponseCompaniesSearch> (response, "response is ApiResponseCompaniesSearch");
        }
        
        /// <summary>
        /// Test SharesOutstandingByCompany
        /// </summary>
        [Test]
        public void SharesOutstandingByCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //DateTime? endDateGreaterThan = null;
            //DateTime? endDateLessThan = null;
            //var response = instance.SharesOutstandingByCompany(identifier, endDateGreaterThan, endDateLessThan);
            //Assert.IsInstanceOf<ApiResponseCompanySharesOutstanding> (response, "response is ApiResponseCompanySharesOutstanding");
        }
        
    }

}



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
    ///  Class for testing FilingApi
    /// </summary>
    [TestFixture]
    public class FilingApiTests
    {
        private FilingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FilingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FilingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FilingApi
            //Assert.IsInstanceOfType(typeof(FilingApi), instance, "instance is a FilingApi");
        }

        
        /// <summary>
        /// Test FilterFilings
        /// </summary>
        [Test]
        public void FilterFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string company = null;
            //string reportType = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string nextPage = null;
            //var response = instance.FilterFilings(company, reportType, startDate, endDate, nextPage);
            //Assert.IsInstanceOf<ApiResponseFilings> (response, "response is ApiResponseFilings");
        }
        
        /// <summary>
        /// Test FilterNotes
        /// </summary>
        [Test]
        public void FilterNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string company = null;
            //string reportType = null;
            //DateTime? filingStartDate = null;
            //DateTime? filingEndDate = null;
            //DateTime? periodEndedStartDate = null;
            //DateTime? periodEndedEndDate = null;
            //string nextPage = null;
            //var response = instance.FilterNotes(company, reportType, filingStartDate, filingEndDate, periodEndedStartDate, periodEndedEndDate, nextPage);
            //Assert.IsInstanceOf<ApiResponseFilingNotes> (response, "response is ApiResponseFilingNotes");
        }
        
        /// <summary>
        /// Test GetAllFilings
        /// </summary>
        [Test]
        public void GetAllFilingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllFilings(nextPage);
            //Assert.IsInstanceOf<ApiResponseFilings> (response, "response is ApiResponseFilings");
        }
        
        /// <summary>
        /// Test GetAllNotes
        /// </summary>
        [Test]
        public void GetAllNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string nextPage = null;
            //var response = instance.GetAllNotes(nextPage);
            //Assert.IsInstanceOf<ApiResponseFilingNotes> (response, "response is ApiResponseFilingNotes");
        }
        
        /// <summary>
        /// Test GetFilingById
        /// </summary>
        [Test]
        public void GetFilingByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFilingById(id);
            //Assert.IsInstanceOf<Filing> (response, "response is Filing");
        }
        
        /// <summary>
        /// Test GetNote
        /// </summary>
        [Test]
        public void GetNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //string contentFormat = null;
            //var response = instance.GetNote(identifier, contentFormat);
            //Assert.IsInstanceOf<FilingNote> (response, "response is FilingNote");
        }
        
        /// <summary>
        /// Test GetNoteHtml
        /// </summary>
        [Test]
        public void GetNoteHtmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetNoteHtml(identifier);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetNoteText
        /// </summary>
        [Test]
        public void GetNoteTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //var response = instance.GetNoteText(identifier);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test SearchNotes
        /// </summary>
        [Test]
        public void SearchNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string query = null;
            //DateTime? filingStartDate = null;
            //DateTime? filingEndDate = null;
            //decimal? pageSize = null;
            //var response = instance.SearchNotes(query, filingStartDate, filingEndDate, pageSize);
            //Assert.IsInstanceOf<ApiResponseFilingNotesSearch> (response, "response is ApiResponseFilingNotesSearch");
        }
        
    }

}

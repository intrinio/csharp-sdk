


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Intrinio.SDK.Api;
using Intrinio.SDK.Model;
using Intrinio.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Intrinio.SDK.Test
{
    /// <summary>
    ///  Class for testing Security
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SecurityTests
    {
        // TODO uncomment below to declare an instance variable for Security
        //private Security instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Security
            //instance = new Security();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Security
        /// </summary>
        [Test]
        public void SecurityInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Security
            //Assert.IsInstanceOfType<Security> (instance, "variable 'instance' is a Security");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CompanyId'
        /// </summary>
        [Test]
        public void CompanyIdTest()
        {
            // TODO unit test for the property 'CompanyId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'ShareClass'
        /// </summary>
        [Test]
        public void ShareClassTest()
        {
            // TODO unit test for the property 'ShareClass'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'RoundLotSize'
        /// </summary>
        [Test]
        public void RoundLotSizeTest()
        {
            // TODO unit test for the property 'RoundLotSize'
        }
        /// <summary>
        /// Test the property 'Ticker'
        /// </summary>
        [Test]
        public void TickerTest()
        {
            // TODO unit test for the property 'Ticker'
        }
        /// <summary>
        /// Test the property 'ExchangeTicker'
        /// </summary>
        [Test]
        public void ExchangeTickerTest()
        {
            // TODO unit test for the property 'ExchangeTicker'
        }
        /// <summary>
        /// Test the property 'CompositeTicker'
        /// </summary>
        [Test]
        public void CompositeTickerTest()
        {
            // TODO unit test for the property 'CompositeTicker'
        }
        /// <summary>
        /// Test the property 'AlternateTickers'
        /// </summary>
        [Test]
        public void AlternateTickersTest()
        {
            // TODO unit test for the property 'AlternateTickers'
        }
        /// <summary>
        /// Test the property 'Figi'
        /// </summary>
        [Test]
        public void FigiTest()
        {
            // TODO unit test for the property 'Figi'
        }
        /// <summary>
        /// Test the property 'Cik'
        /// </summary>
        [Test]
        public void CikTest()
        {
            // TODO unit test for the property 'Cik'
        }
        /// <summary>
        /// Test the property 'CompositeFigi'
        /// </summary>
        [Test]
        public void CompositeFigiTest()
        {
            // TODO unit test for the property 'CompositeFigi'
        }
        /// <summary>
        /// Test the property 'ShareClassFigi'
        /// </summary>
        [Test]
        public void ShareClassFigiTest()
        {
            // TODO unit test for the property 'ShareClassFigi'
        }
        /// <summary>
        /// Test the property 'FigiUniqueid'
        /// </summary>
        [Test]
        public void FigiUniqueidTest()
        {
            // TODO unit test for the property 'FigiUniqueid'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'Etf'
        /// </summary>
        [Test]
        public void EtfTest()
        {
            // TODO unit test for the property 'Etf'
        }
        /// <summary>
        /// Test the property 'Delisted'
        /// </summary>
        [Test]
        public void DelistedTest()
        {
            // TODO unit test for the property 'Delisted'
        }
        /// <summary>
        /// Test the property 'PrimaryListing'
        /// </summary>
        [Test]
        public void PrimaryListingTest()
        {
            // TODO unit test for the property 'PrimaryListing'
        }
        /// <summary>
        /// Test the property 'PrimarySecurity'
        /// </summary>
        [Test]
        public void PrimarySecurityTest()
        {
            // TODO unit test for the property 'PrimarySecurity'
        }
        /// <summary>
        /// Test the property 'FirstStockPrice'
        /// </summary>
        [Test]
        public void FirstStockPriceTest()
        {
            // TODO unit test for the property 'FirstStockPrice'
        }
        /// <summary>
        /// Test the property 'LastStockPrice'
        /// </summary>
        [Test]
        public void LastStockPriceTest()
        {
            // TODO unit test for the property 'LastStockPrice'
        }
        /// <summary>
        /// Test the property 'LastStockPriceAdjustment'
        /// </summary>
        [Test]
        public void LastStockPriceAdjustmentTest()
        {
            // TODO unit test for the property 'LastStockPriceAdjustment'
        }
        /// <summary>
        /// Test the property 'LastCorporateAction'
        /// </summary>
        [Test]
        public void LastCorporateActionTest()
        {
            // TODO unit test for the property 'LastCorporateAction'
        }
        /// <summary>
        /// Test the property 'PreviousTickers'
        /// </summary>
        [Test]
        public void PreviousTickersTest()
        {
            // TODO unit test for the property 'PreviousTickers'
        }
        /// <summary>
        /// Test the property 'ListingExchangeMic'
        /// </summary>
        [Test]
        public void ListingExchangeMicTest()
        {
            // TODO unit test for the property 'ListingExchangeMic'
        }

    }

}
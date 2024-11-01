


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
    ///  Class for testing ApiResponseSecurityQuote
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ApiResponseSecurityQuoteTests
    {
        // TODO uncomment below to declare an instance variable for ApiResponseSecurityQuote
        //private ApiResponseSecurityQuote instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ApiResponseSecurityQuote
            //instance = new ApiResponseSecurityQuote();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApiResponseSecurityQuote
        /// </summary>
        [Test]
        public void ApiResponseSecurityQuoteInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ApiResponseSecurityQuote
            //Assert.IsInstanceOfType<ApiResponseSecurityQuote> (instance, "variable 'instance' is a ApiResponseSecurityQuote");
        }


        /// <summary>
        /// Test the property 'Security'
        /// </summary>
        [Test]
        public void SecurityTest()
        {
            // TODO unit test for the property 'Security'
        }
        /// <summary>
        /// Test the property 'Last'
        /// </summary>
        [Test]
        public void LastTest()
        {
            // TODO unit test for the property 'Last'
        }
        /// <summary>
        /// Test the property 'LastTime'
        /// </summary>
        [Test]
        public void LastTimeTest()
        {
            // TODO unit test for the property 'LastTime'
        }
        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Test]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }
        /// <summary>
        /// Test the property 'Open'
        /// </summary>
        [Test]
        public void OpenTest()
        {
            // TODO unit test for the property 'Open'
        }
        /// <summary>
        /// Test the property 'High'
        /// </summary>
        [Test]
        public void HighTest()
        {
            // TODO unit test for the property 'High'
        }
        /// <summary>
        /// Test the property 'Low'
        /// </summary>
        [Test]
        public void LowTest()
        {
            // TODO unit test for the property 'Low'
        }
        /// <summary>
        /// Test the property 'ExchangeVolume'
        /// </summary>
        [Test]
        public void ExchangeVolumeTest()
        {
            // TODO unit test for the property 'ExchangeVolume'
        }
        /// <summary>
        /// Test the property 'MarketVolume'
        /// </summary>
        [Test]
        public void MarketVolumeTest()
        {
            // TODO unit test for the property 'MarketVolume'
        }
        /// <summary>
        /// Test the property 'EodFiftyTwoWeekHigh'
        /// </summary>
        [Test]
        public void EodFiftyTwoWeekHighTest()
        {
            // TODO unit test for the property 'EodFiftyTwoWeekHigh'
        }
        /// <summary>
        /// Test the property 'EodFiftyTwoWeekLow'
        /// </summary>
        [Test]
        public void EodFiftyTwoWeekLowTest()
        {
            // TODO unit test for the property 'EodFiftyTwoWeekLow'
        }
        /// <summary>
        /// Test the property 'Marketcap'
        /// </summary>
        [Test]
        public void MarketcapTest()
        {
            // TODO unit test for the property 'Marketcap'
        }
        /// <summary>
        /// Test the property 'Pricetoearnings'
        /// </summary>
        [Test]
        public void PricetoearningsTest()
        {
            // TODO unit test for the property 'Pricetoearnings'
        }
        /// <summary>
        /// Test the property 'PreviousClose'
        /// </summary>
        [Test]
        public void PreviousCloseTest()
        {
            // TODO unit test for the property 'PreviousClose'
        }
        /// <summary>
        /// Test the property 'PreviousCloseDate'
        /// </summary>
        [Test]
        public void PreviousCloseDateTest()
        {
            // TODO unit test for the property 'PreviousCloseDate'
        }
        /// <summary>
        /// Test the property 'Change'
        /// </summary>
        [Test]
        public void ChangeTest()
        {
            // TODO unit test for the property 'Change'
        }
        /// <summary>
        /// Test the property 'ChangePercent'
        /// </summary>
        [Test]
        public void ChangePercentTest()
        {
            // TODO unit test for the property 'ChangePercent'
        }
        /// <summary>
        /// Test the property 'AdjClose5DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose5DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose5DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjClose30DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose30DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose30DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjClose90DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose90DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose90DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjClose180DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose180DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose180DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjClose365DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose365DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose365DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjClose730DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose730DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose730DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjClose1825DaysAgo'
        /// </summary>
        [Test]
        public void AdjClose1825DaysAgoTest()
        {
            // TODO unit test for the property 'AdjClose1825DaysAgo'
        }
        /// <summary>
        /// Test the property 'AdjCloseYearToDate'
        /// </summary>
        [Test]
        public void AdjCloseYearToDateTest()
        {
            // TODO unit test for the property 'AdjCloseYearToDate'
        }
        /// <summary>
        /// Test the property 'ChangePercent5Days'
        /// </summary>
        [Test]
        public void ChangePercent5DaysTest()
        {
            // TODO unit test for the property 'ChangePercent5Days'
        }
        /// <summary>
        /// Test the property 'ChangePercent30Days'
        /// </summary>
        [Test]
        public void ChangePercent30DaysTest()
        {
            // TODO unit test for the property 'ChangePercent30Days'
        }
        /// <summary>
        /// Test the property 'ChangePercent90Days'
        /// </summary>
        [Test]
        public void ChangePercent90DaysTest()
        {
            // TODO unit test for the property 'ChangePercent90Days'
        }
        /// <summary>
        /// Test the property 'ChangePercent180Days'
        /// </summary>
        [Test]
        public void ChangePercent180DaysTest()
        {
            // TODO unit test for the property 'ChangePercent180Days'
        }
        /// <summary>
        /// Test the property 'ChangePercent365Days'
        /// </summary>
        [Test]
        public void ChangePercent365DaysTest()
        {
            // TODO unit test for the property 'ChangePercent365Days'
        }
        /// <summary>
        /// Test the property 'ChangePercent730DaysAgo'
        /// </summary>
        [Test]
        public void ChangePercent730DaysAgoTest()
        {
            // TODO unit test for the property 'ChangePercent730DaysAgo'
        }
        /// <summary>
        /// Test the property 'ChangePercent1825Days'
        /// </summary>
        [Test]
        public void ChangePercent1825DaysTest()
        {
            // TODO unit test for the property 'ChangePercent1825Days'
        }
        /// <summary>
        /// Test the property 'ChangePercentYearToDate'
        /// </summary>
        [Test]
        public void ChangePercentYearToDateTest()
        {
            // TODO unit test for the property 'ChangePercentYearToDate'
        }
        /// <summary>
        /// Test the property 'ExtendedHoursLast'
        /// </summary>
        [Test]
        public void ExtendedHoursLastTest()
        {
            // TODO unit test for the property 'ExtendedHoursLast'
        }
        /// <summary>
        /// Test the property 'ExtendedHoursChange'
        /// </summary>
        [Test]
        public void ExtendedHoursChangeTest()
        {
            // TODO unit test for the property 'ExtendedHoursChange'
        }
        /// <summary>
        /// Test the property 'ExtendedHoursChangePercent'
        /// </summary>
        [Test]
        public void ExtendedHoursChangePercentTest()
        {
            // TODO unit test for the property 'ExtendedHoursChangePercent'
        }

    }

}

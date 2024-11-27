


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
    ///  Class for testing ZacksLongTermGrowthRate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ZacksLongTermGrowthRateTests
    {
        // TODO uncomment below to declare an instance variable for ZacksLongTermGrowthRate
        //private ZacksLongTermGrowthRate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ZacksLongTermGrowthRate
            //instance = new ZacksLongTermGrowthRate();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ZacksLongTermGrowthRate
        /// </summary>
        [Test]
        public void ZacksLongTermGrowthRateInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ZacksLongTermGrowthRate
            //Assert.IsInstanceOfType<ZacksLongTermGrowthRate> (instance, "variable 'instance' is a ZacksLongTermGrowthRate");
        }


        /// <summary>
        /// Test the property 'Mean'
        /// </summary>
        [Test]
        public void MeanTest()
        {
            // TODO unit test for the property 'Mean'
        }
        /// <summary>
        /// Test the property 'Median'
        /// </summary>
        [Test]
        public void MedianTest()
        {
            // TODO unit test for the property 'Median'
        }
        /// <summary>
        /// Test the property 'Count'
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO unit test for the property 'Count'
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
        /// Test the property 'StdDev'
        /// </summary>
        [Test]
        public void StdDevTest()
        {
            // TODO unit test for the property 'StdDev'
        }
        /// <summary>
        /// Test the property 'RevisionsUpward'
        /// </summary>
        [Test]
        public void RevisionsUpwardTest()
        {
            // TODO unit test for the property 'RevisionsUpward'
        }
        /// <summary>
        /// Test the property 'RevisionsDownward'
        /// </summary>
        [Test]
        public void RevisionsDownwardTest()
        {
            // TODO unit test for the property 'RevisionsDownward'
        }
        /// <summary>
        /// Test the property 'Mean7DaysAgo'
        /// </summary>
        [Test]
        public void Mean7DaysAgoTest()
        {
            // TODO unit test for the property 'Mean7DaysAgo'
        }
        /// <summary>
        /// Test the property 'Mean30DaysAgo'
        /// </summary>
        [Test]
        public void Mean30DaysAgoTest()
        {
            // TODO unit test for the property 'Mean30DaysAgo'
        }
        /// <summary>
        /// Test the property 'Mean60DaysAgo'
        /// </summary>
        [Test]
        public void Mean60DaysAgoTest()
        {
            // TODO unit test for the property 'Mean60DaysAgo'
        }
        /// <summary>
        /// Test the property 'Mean90DaysAgo'
        /// </summary>
        [Test]
        public void Mean90DaysAgoTest()
        {
            // TODO unit test for the property 'Mean90DaysAgo'
        }
        /// <summary>
        /// Test the property 'RevisionsUpwardLast7Days'
        /// </summary>
        [Test]
        public void RevisionsUpwardLast7DaysTest()
        {
            // TODO unit test for the property 'RevisionsUpwardLast7Days'
        }
        /// <summary>
        /// Test the property 'RevisionsDownwardLast7Days'
        /// </summary>
        [Test]
        public void RevisionsDownwardLast7DaysTest()
        {
            // TODO unit test for the property 'RevisionsDownwardLast7Days'
        }
        /// <summary>
        /// Test the property 'RevisionsUpwardLast30Days'
        /// </summary>
        [Test]
        public void RevisionsUpwardLast30DaysTest()
        {
            // TODO unit test for the property 'RevisionsUpwardLast30Days'
        }
        /// <summary>
        /// Test the property 'RevisionsDownwardLast30Days'
        /// </summary>
        [Test]
        public void RevisionsDownwardLast30DaysTest()
        {
            // TODO unit test for the property 'RevisionsDownwardLast30Days'
        }
        /// <summary>
        /// Test the property 'RevisionsUpwardLast60Days'
        /// </summary>
        [Test]
        public void RevisionsUpwardLast60DaysTest()
        {
            // TODO unit test for the property 'RevisionsUpwardLast60Days'
        }
        /// <summary>
        /// Test the property 'RevisionsDownwardLast60Days'
        /// </summary>
        [Test]
        public void RevisionsDownwardLast60DaysTest()
        {
            // TODO unit test for the property 'RevisionsDownwardLast60Days'
        }
        /// <summary>
        /// Test the property 'RevisionsUpwardLast90Days'
        /// </summary>
        [Test]
        public void RevisionsUpwardLast90DaysTest()
        {
            // TODO unit test for the property 'RevisionsUpwardLast90Days'
        }
        /// <summary>
        /// Test the property 'RevisionsDownwardLast90Days'
        /// </summary>
        [Test]
        public void RevisionsDownwardLast90DaysTest()
        {
            // TODO unit test for the property 'RevisionsDownwardLast90Days'
        }
        /// <summary>
        /// Test the property 'RevisionsUpwardLast120Days'
        /// </summary>
        [Test]
        public void RevisionsUpwardLast120DaysTest()
        {
            // TODO unit test for the property 'RevisionsUpwardLast120Days'
        }
        /// <summary>
        /// Test the property 'RevisionsDownwardLast120Days'
        /// </summary>
        [Test]
        public void RevisionsDownwardLast120DaysTest()
        {
            // TODO unit test for the property 'RevisionsDownwardLast120Days'
        }
        /// <summary>
        /// Test the property 'RevisionsUpwardLast150Days'
        /// </summary>
        [Test]
        public void RevisionsUpwardLast150DaysTest()
        {
            // TODO unit test for the property 'RevisionsUpwardLast150Days'
        }
        /// <summary>
        /// Test the property 'RevisionsDownwardLast150Days'
        /// </summary>
        [Test]
        public void RevisionsDownwardLast150DaysTest()
        {
            // TODO unit test for the property 'RevisionsDownwardLast150Days'
        }
        /// <summary>
        /// Test the property 'Security'
        /// </summary>
        [Test]
        public void SecurityTest()
        {
            // TODO unit test for the property 'Security'
        }

    }

}
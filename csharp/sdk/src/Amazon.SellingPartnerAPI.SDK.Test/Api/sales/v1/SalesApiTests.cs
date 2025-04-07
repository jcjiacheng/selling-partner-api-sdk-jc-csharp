/*
 * Selling Partner API for Sales
 *
 * The Selling Partner API for Sales provides APIs related to sales performance.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Amazon.SellingPartnerAPI.SDK.Client;
using Amazon.SellingPartnerAPI.SDK.Api/sales/v1;
using Amazon.SellingPartnerAPI.SDK.Model/sales/v1;

namespace Amazon.SellingPartnerAPI.SDK.Test
{
    /// <summary>
    ///  Class for testing SalesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SalesApiTests
    {
        private SalesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new SalesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SalesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SalesApi
            //Assert.IsInstanceOfType(typeof(SalesApi), instance, "instance is a SalesApi");
        }

        
        /// <summary>
        /// Test GetOrderMetrics
        /// </summary>
        [Test]
        public void GetOrderMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> marketplaceIds = null;
            //string interval = null;
            //string granularity = null;
            //string? granularityTimeZone = null;
            //string? buyerType = null;
            //string? fulfillmentNetwork = null;
            //string? firstDayOfWeek = null;
            //string? asin = null;
            //string? sku = null;
            //var response = instance.GetOrderMetrics(marketplaceIdsintervalgranularitygranularityTimeZonebuyerTypefulfillmentNetworkfirstDayOfWeekasinsku);
            //Assert.IsInstanceOf<GetOrderMetricsResponse> (response, "response is GetOrderMetricsResponse");
        }
        
    }

}

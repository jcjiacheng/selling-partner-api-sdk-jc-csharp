/*
 * The Selling Partner API for Transfers.
 *
 * The Selling Partner API for Transfers enables selling partners to retrieve payment methods and initiate payouts for their seller accounts. This API supports the following marketplaces: DE, FR, IT, ES, SE, NL, PL, and BE.
 *
 * The version of the OpenAPI document: 2024-06-01
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
using Amazon.SellingPartnerAPI.SDK.Api/transfers/v2024_06_01;
using Amazon.SellingPartnerAPI.SDK.Model/transfers/v2024_06_01;

namespace Amazon.SellingPartnerAPI.SDK.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test GetPaymentMethods
        /// </summary>
        [Test]
        public void GetPaymentMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string marketplaceId = null;
            //List<string>? paymentMethodTypes = null;
            //var response = instance.GetPaymentMethods(marketplaceIdpaymentMethodTypes);
            //Assert.IsInstanceOf<GetPaymentMethodsResponse> (response, "response is GetPaymentMethodsResponse");
        }
        
        /// <summary>
        /// Test InitiatePayout
        /// </summary>
        [Test]
        public void InitiatePayoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InitiatePayoutRequest body = null;
            //var response = instance.InitiatePayout(body);
            //Assert.IsInstanceOf<InitiatePayoutResponse> (response, "response is InitiatePayoutResponse");
        }
        
    }

}

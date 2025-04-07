/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer pricing information for Amazon Marketplace products.  For more information, refer to the [Product Pricing v2022-05-01 Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/product-pricing-api-v2022-05-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2022-05-01
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
using Amazon.SellingPartnerAPI.SDK.Api/pricing/v2022_05_01;
using Amazon.SellingPartnerAPI.SDK.Model/pricing/v2022_05_01;

namespace Amazon.SellingPartnerAPI.SDK.Test
{
    /// <summary>
    ///  Class for testing ProductPricingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductPricingApiTests
    {
        private ProductPricingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new ProductPricingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductPricingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductPricingApi
            //Assert.IsInstanceOfType(typeof(ProductPricingApi), instance, "instance is a ProductPricingApi");
        }

        
        /// <summary>
        /// Test GetCompetitiveSummary
        /// </summary>
        [Test]
        public void GetCompetitiveSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompetitiveSummaryBatchRequest requests = null;
            //var response = instance.GetCompetitiveSummary(requests);
            //Assert.IsInstanceOf<CompetitiveSummaryBatchResponse> (response, "response is CompetitiveSummaryBatchResponse");
        }
        
        /// <summary>
        /// Test GetFeaturedOfferExpectedPriceBatch
        /// </summary>
        [Test]
        public void GetFeaturedOfferExpectedPriceBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetFeaturedOfferExpectedPriceBatchRequest getFeaturedOfferExpectedPriceBatchRequestBody = null;
            //var response = instance.GetFeaturedOfferExpectedPriceBatch(getFeaturedOfferExpectedPriceBatchRequestBody);
            //Assert.IsInstanceOf<GetFeaturedOfferExpectedPriceBatchResponse> (response, "response is GetFeaturedOfferExpectedPriceBatchResponse");
        }
        
    }

}

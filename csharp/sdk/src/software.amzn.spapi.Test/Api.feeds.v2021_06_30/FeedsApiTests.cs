/*
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * The version of the OpenAPI document: 2021-06-30
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;
using Amazon.SellingPartnerAPIAA;

using software.amzn.spapi.Client;
using software.amzn.spapi.Api.feeds.v2021_06_30;
using software.amzn.spapi.Model.feeds.v2021_06_30;

namespace software.amzn.spapi.Api.feeds.v2021_06_30.Test
{
    /// <summary>
    ///  Class for testing FeedsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FeedsApiTests
    {
        private FeedsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new FeedsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeedsApi
        /// </summary>
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FeedsApi
            //Assert.IsInstanceOfType(typeof(FeedsApi), instance, "instance is a FeedsApi");
        }

        
        /// <summary>
        /// Test CancelFeed
        /// </summary>
        [Fact]
        public void CancelFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedId = null;
            //instance.CancelFeed(feedId);
            
        }
        
        /// <summary>
        /// Test CreateFeed
        /// </summary>
        [Fact]
        public void CreateFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFeedSpecification body = null;
            //var response = instance.CreateFeed(body);
            //Assert.IsInstanceOf<CreateFeedResponse> (response, "response is CreateFeedResponse");
        }
        
        /// <summary>
        /// Test CreateFeedDocument
        /// </summary>
        [Fact]
        public void CreateFeedDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFeedDocumentSpecification body = null;
            //var response = instance.CreateFeedDocument(body);
            //Assert.IsInstanceOf<CreateFeedDocumentResponse> (response, "response is CreateFeedDocumentResponse");
        }
        
        /// <summary>
        /// Test GetFeed
        /// </summary>
        [Fact]
        public void GetFeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedId = null;
            //var response = instance.GetFeed(feedId);
            //Assert.IsInstanceOf<Feed> (response, "response is Feed");
        }
        
        /// <summary>
        /// Test GetFeedDocument
        /// </summary>
        [Fact]
        public void GetFeedDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string feedDocumentId = null;
            //var response = instance.GetFeedDocument(feedDocumentId);
            //Assert.IsInstanceOf<FeedDocument> (response, "response is FeedDocument");
        }
        
        /// <summary>
        /// Test GetFeeds
        /// </summary>
        [Fact]
        public void GetFeedsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string>? feedTypes = null;
            //List<string>? marketplaceIds = null;
            //int? pageSize = null;
            //List<string>? processingStatuses = null;
            //DateTime? createdSince = null;
            //DateTime? createdUntil = null;
            //string? nextToken = null;
            //var response = instance.GetFeeds(feedTypesmarketplaceIdspageSizeprocessingStatusescreatedSincecreatedUntilnextToken);
            //Assert.IsInstanceOf<GetFeedsResponse> (response, "response is GetFeedsResponse");
        }
        
    }

}

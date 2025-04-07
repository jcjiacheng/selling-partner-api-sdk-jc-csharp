/*
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * The version of the OpenAPI document: 2022-11-07
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/replenishment/v2022_11_07;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing ListOfferMetricsRequestPagination
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListOfferMetricsRequestPaginationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListOfferMetricsRequestPagination
        //private ListOfferMetricsRequestPagination instance;

        public ListOfferMetricsRequestPaginationTests()
        {
            // TODO uncomment below to create an instance of ListOfferMetricsRequestPagination
            //instance = new ListOfferMetricsRequestPagination();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListOfferMetricsRequestPagination
        /// </summary>
        [Fact]
        public void ListOfferMetricsRequestPaginationInstanceTest()
        {
            // TODO uncomment below to test "IsType" ListOfferMetricsRequestPagination
            //Assert.IsType<ListOfferMetricsRequestPagination>(instance);
        }

        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

        /// <summary>
        /// Test the property 'Offset'
        /// </summary>
        [Fact]
        public void OffsetTest()
        {
            // TODO unit test for the property 'Offset'
        }
    }
}

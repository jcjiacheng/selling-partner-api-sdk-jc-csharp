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
    ///  Class for testing ListOfferMetricsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListOfferMetricsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListOfferMetricsRequest
        //private ListOfferMetricsRequest instance;

        public ListOfferMetricsRequestTests()
        {
            // TODO uncomment below to create an instance of ListOfferMetricsRequest
            //instance = new ListOfferMetricsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListOfferMetricsRequest
        /// </summary>
        [Fact]
        public void ListOfferMetricsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" ListOfferMetricsRequest
            //Assert.IsType<ListOfferMetricsRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Pagination'
        /// </summary>
        [Fact]
        public void PaginationTest()
        {
            // TODO unit test for the property 'Pagination'
        }

        /// <summary>
        /// Test the property 'Sort'
        /// </summary>
        [Fact]
        public void SortTest()
        {
            // TODO unit test for the property 'Sort'
        }

        /// <summary>
        /// Test the property 'Filters'
        /// </summary>
        [Fact]
        public void FiltersTest()
        {
            // TODO unit test for the property 'Filters'
        }
    }
}

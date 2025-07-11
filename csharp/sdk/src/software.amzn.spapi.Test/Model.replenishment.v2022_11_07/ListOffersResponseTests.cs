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
using software.amzn.spapi.Model.replenishment.v2022_11_07;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing ListOffersResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListOffersResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListOffersResponse
        //private ListOffersResponse instance;

        public ListOffersResponseTests()
        {
            // TODO uncomment below to create an instance of ListOffersResponse
            //instance = new ListOffersResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListOffersResponse
        /// </summary>
        [Fact]
        public void ListOffersResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ListOffersResponse
            //Assert.IsType<ListOffersResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Offers'
        /// </summary>
        [Fact]
        public void OffersTest()
        {
            // TODO unit test for the property 'Offers'
        }

        /// <summary>
        /// Test the property 'Pagination'
        /// </summary>
        [Fact]
        public void PaginationTest()
        {
            // TODO unit test for the property 'Pagination'
        }
    }
}

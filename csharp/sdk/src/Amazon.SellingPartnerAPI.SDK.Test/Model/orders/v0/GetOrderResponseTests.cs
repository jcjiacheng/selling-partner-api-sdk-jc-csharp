/*
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/orders/v0;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing GetOrderResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetOrderResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetOrderResponse
        //private GetOrderResponse instance;

        public GetOrderResponseTests()
        {
            // TODO uncomment below to create an instance of GetOrderResponse
            //instance = new GetOrderResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetOrderResponse
        /// </summary>
        [Fact]
        public void GetOrderResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetOrderResponse
            //Assert.IsType<GetOrderResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Payload'
        /// </summary>
        [Fact]
        public void PayloadTest()
        {
            // TODO unit test for the property 'Payload'
        }

        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
    }
}

/*
 * Amazon Shipping API
 *
 * The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.
 *
 * The version of the OpenAPI document: v2
 * Contact: swa-api-core@amazon.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using software.amzn.spapi.Model.shipping.v2;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing Promise
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PromiseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Promise
        //private Promise instance;

        public PromiseTests()
        {
            // TODO uncomment below to create an instance of Promise
            //instance = new Promise();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Promise
        /// </summary>
        [Fact]
        public void PromiseInstanceTest()
        {
            // TODO uncomment below to test "IsType" Promise
            //Assert.IsType<Promise>(instance);
        }

        /// <summary>
        /// Test the property 'DeliveryWindow'
        /// </summary>
        [Fact]
        public void DeliveryWindowTest()
        {
            // TODO unit test for the property 'DeliveryWindow'
        }

        /// <summary>
        /// Test the property 'PickupWindow'
        /// </summary>
        [Fact]
        public void PickupWindowTest()
        {
            // TODO unit test for the property 'PickupWindow'
        }
    }
}

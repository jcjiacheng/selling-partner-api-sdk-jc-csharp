/*
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * The version of the OpenAPI document: 2021-12-28
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/vendor/df/shipping/v2021_12_28;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing CreateShippingLabelsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateShippingLabelsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateShippingLabelsRequest
        //private CreateShippingLabelsRequest instance;

        public CreateShippingLabelsRequestTests()
        {
            // TODO uncomment below to create an instance of CreateShippingLabelsRequest
            //instance = new CreateShippingLabelsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateShippingLabelsRequest
        /// </summary>
        [Fact]
        public void CreateShippingLabelsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateShippingLabelsRequest
            //Assert.IsType<CreateShippingLabelsRequest>(instance);
        }

        /// <summary>
        /// Test the property 'SellingParty'
        /// </summary>
        [Fact]
        public void SellingPartyTest()
        {
            // TODO unit test for the property 'SellingParty'
        }

        /// <summary>
        /// Test the property 'ShipFromParty'
        /// </summary>
        [Fact]
        public void ShipFromPartyTest()
        {
            // TODO unit test for the property 'ShipFromParty'
        }

        /// <summary>
        /// Test the property 'Containers'
        /// </summary>
        [Fact]
        public void ContainersTest()
        {
            // TODO unit test for the property 'Containers'
        }
    }
}

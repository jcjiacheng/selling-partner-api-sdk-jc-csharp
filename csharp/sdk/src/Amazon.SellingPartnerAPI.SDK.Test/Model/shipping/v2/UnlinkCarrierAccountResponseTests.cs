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
using Amazon.SellingPartnerAPI.SDK.Model/shipping/v2;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing UnlinkCarrierAccountResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UnlinkCarrierAccountResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UnlinkCarrierAccountResponse
        //private UnlinkCarrierAccountResponse instance;

        public UnlinkCarrierAccountResponseTests()
        {
            // TODO uncomment below to create an instance of UnlinkCarrierAccountResponse
            //instance = new UnlinkCarrierAccountResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UnlinkCarrierAccountResponse
        /// </summary>
        [Fact]
        public void UnlinkCarrierAccountResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" UnlinkCarrierAccountResponse
            //Assert.IsType<UnlinkCarrierAccountResponse>(instance);
        }

        /// <summary>
        /// Test the property 'IsUnlinked'
        /// </summary>
        [Fact]
        public void IsUnlinkedTest()
        {
            // TODO unit test for the property 'IsUnlinked'
        }
    }
}

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
    ///  Class for testing LinkCarrierAccountRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LinkCarrierAccountRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LinkCarrierAccountRequest
        //private LinkCarrierAccountRequest instance;

        public LinkCarrierAccountRequestTests()
        {
            // TODO uncomment below to create an instance of LinkCarrierAccountRequest
            //instance = new LinkCarrierAccountRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LinkCarrierAccountRequest
        /// </summary>
        [Fact]
        public void LinkCarrierAccountRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" LinkCarrierAccountRequest
            //Assert.IsType<LinkCarrierAccountRequest>(instance);
        }

        /// <summary>
        /// Test the property 'ClientReferenceDetails'
        /// </summary>
        [Fact]
        public void ClientReferenceDetailsTest()
        {
            // TODO unit test for the property 'ClientReferenceDetails'
        }

        /// <summary>
        /// Test the property 'CarrierAccountType'
        /// </summary>
        [Fact]
        public void CarrierAccountTypeTest()
        {
            // TODO unit test for the property 'CarrierAccountType'
        }

        /// <summary>
        /// Test the property 'CarrierAccountAttributes'
        /// </summary>
        [Fact]
        public void CarrierAccountAttributesTest()
        {
            // TODO unit test for the property 'CarrierAccountAttributes'
        }

        /// <summary>
        /// Test the property 'EncryptedCarrierAccountAttributes'
        /// </summary>
        [Fact]
        public void EncryptedCarrierAccountAttributesTest()
        {
            // TODO unit test for the property 'EncryptedCarrierAccountAttributes'
        }
    }
}

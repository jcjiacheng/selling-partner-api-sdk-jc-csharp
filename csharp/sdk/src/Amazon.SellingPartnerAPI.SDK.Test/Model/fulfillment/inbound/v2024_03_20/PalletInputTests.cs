/*
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * The version of the OpenAPI document: 2024-03-20
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v2024_03_20;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing PalletInput
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PalletInputTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PalletInput
        //private PalletInput instance;

        public PalletInputTests()
        {
            // TODO uncomment below to create an instance of PalletInput
            //instance = new PalletInput();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PalletInput
        /// </summary>
        [Fact]
        public void PalletInputInstanceTest()
        {
            // TODO uncomment below to test "IsType" PalletInput
            //Assert.IsType<PalletInput>(instance);
        }

        /// <summary>
        /// Test the property 'Dimensions'
        /// </summary>
        [Fact]
        public void DimensionsTest()
        {
            // TODO unit test for the property 'Dimensions'
        }

        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }

        /// <summary>
        /// Test the property 'Stackability'
        /// </summary>
        [Fact]
        public void StackabilityTest()
        {
            // TODO unit test for the property 'Stackability'
        }

        /// <summary>
        /// Test the property 'Weight'
        /// </summary>
        [Fact]
        public void WeightTest()
        {
            // TODO unit test for the property 'Weight'
        }
    }
}

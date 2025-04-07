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
    ///  Class for testing TaxRate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaxRateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TaxRate
        //private TaxRate instance;

        public TaxRateTests()
        {
            // TODO uncomment below to create an instance of TaxRate
            //instance = new TaxRate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TaxRate
        /// </summary>
        [Fact]
        public void TaxRateInstanceTest()
        {
            // TODO uncomment below to test "IsType" TaxRate
            //Assert.IsType<TaxRate>(instance);
        }

        /// <summary>
        /// Test the property 'CessRate'
        /// </summary>
        [Fact]
        public void CessRateTest()
        {
            // TODO unit test for the property 'CessRate'
        }

        /// <summary>
        /// Test the property 'GstRate'
        /// </summary>
        [Fact]
        public void GstRateTest()
        {
            // TODO unit test for the property 'GstRate'
        }

        /// <summary>
        /// Test the property 'TaxType'
        /// </summary>
        [Fact]
        public void TaxTypeTest()
        {
            // TODO unit test for the property 'TaxType'
        }
    }
}

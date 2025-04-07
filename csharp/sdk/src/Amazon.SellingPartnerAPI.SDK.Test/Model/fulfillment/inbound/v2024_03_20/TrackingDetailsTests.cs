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
    ///  Class for testing TrackingDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TrackingDetailsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TrackingDetails
        //private TrackingDetails instance;

        public TrackingDetailsTests()
        {
            // TODO uncomment below to create an instance of TrackingDetails
            //instance = new TrackingDetails();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TrackingDetails
        /// </summary>
        [Fact]
        public void TrackingDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsType" TrackingDetails
            //Assert.IsType<TrackingDetails>(instance);
        }

        /// <summary>
        /// Test the property 'LtlTrackingDetail'
        /// </summary>
        [Fact]
        public void LtlTrackingDetailTest()
        {
            // TODO unit test for the property 'LtlTrackingDetail'
        }

        /// <summary>
        /// Test the property 'SpdTrackingDetail'
        /// </summary>
        [Fact]
        public void SpdTrackingDetailTest()
        {
            // TODO unit test for the property 'SpdTrackingDetail'
        }
    }
}

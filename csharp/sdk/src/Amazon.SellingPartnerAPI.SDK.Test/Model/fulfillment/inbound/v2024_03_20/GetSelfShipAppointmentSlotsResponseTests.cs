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
    ///  Class for testing GetSelfShipAppointmentSlotsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSelfShipAppointmentSlotsResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSelfShipAppointmentSlotsResponse
        //private GetSelfShipAppointmentSlotsResponse instance;

        public GetSelfShipAppointmentSlotsResponseTests()
        {
            // TODO uncomment below to create an instance of GetSelfShipAppointmentSlotsResponse
            //instance = new GetSelfShipAppointmentSlotsResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSelfShipAppointmentSlotsResponse
        /// </summary>
        [Fact]
        public void GetSelfShipAppointmentSlotsResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSelfShipAppointmentSlotsResponse
            //Assert.IsType<GetSelfShipAppointmentSlotsResponse>(instance);
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
        /// Test the property 'SelfShipAppointmentSlotsAvailability'
        /// </summary>
        [Fact]
        public void SelfShipAppointmentSlotsAvailabilityTest()
        {
            // TODO unit test for the property 'SelfShipAppointmentSlotsAvailability'
        }
    }
}

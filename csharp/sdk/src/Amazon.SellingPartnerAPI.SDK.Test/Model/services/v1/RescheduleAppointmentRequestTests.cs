/*
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/services/v1;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing RescheduleAppointmentRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RescheduleAppointmentRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RescheduleAppointmentRequest
        //private RescheduleAppointmentRequest instance;

        public RescheduleAppointmentRequestTests()
        {
            // TODO uncomment below to create an instance of RescheduleAppointmentRequest
            //instance = new RescheduleAppointmentRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RescheduleAppointmentRequest
        /// </summary>
        [Fact]
        public void RescheduleAppointmentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RescheduleAppointmentRequest
            //Assert.IsType<RescheduleAppointmentRequest>(instance);
        }

        /// <summary>
        /// Test the property 'AppointmentTime'
        /// </summary>
        [Fact]
        public void AppointmentTimeTest()
        {
            // TODO unit test for the property 'AppointmentTime'
        }

        /// <summary>
        /// Test the property 'RescheduleReasonCode'
        /// </summary>
        [Fact]
        public void RescheduleReasonCodeTest()
        {
            // TODO unit test for the property 'RescheduleReasonCode'
        }
    }
}

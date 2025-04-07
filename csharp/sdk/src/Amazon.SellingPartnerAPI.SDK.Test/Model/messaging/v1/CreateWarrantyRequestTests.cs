/*
 * Selling Partner API for Messaging
 *
 * With the Messaging API you can build applications that send messages to buyers. You can get a list of message types that are available for an order that you specify, then call an operation that sends a message to the buyer for that order. The Messaging API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/messaging/v1;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing CreateWarrantyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateWarrantyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateWarrantyRequest
        //private CreateWarrantyRequest instance;

        public CreateWarrantyRequestTests()
        {
            // TODO uncomment below to create an instance of CreateWarrantyRequest
            //instance = new CreateWarrantyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateWarrantyRequest
        /// </summary>
        [Fact]
        public void CreateWarrantyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateWarrantyRequest
            //Assert.IsType<CreateWarrantyRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }

        /// <summary>
        /// Test the property 'CoverageStartDate'
        /// </summary>
        [Fact]
        public void CoverageStartDateTest()
        {
            // TODO unit test for the property 'CoverageStartDate'
        }

        /// <summary>
        /// Test the property 'CoverageEndDate'
        /// </summary>
        [Fact]
        public void CoverageEndDateTest()
        {
            // TODO unit test for the property 'CoverageEndDate'
        }
    }
}

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
    ///  Class for testing CreateLegalDisclosureRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateLegalDisclosureRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateLegalDisclosureRequest
        //private CreateLegalDisclosureRequest instance;

        public CreateLegalDisclosureRequestTests()
        {
            // TODO uncomment below to create an instance of CreateLegalDisclosureRequest
            //instance = new CreateLegalDisclosureRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateLegalDisclosureRequest
        /// </summary>
        [Fact]
        public void CreateLegalDisclosureRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateLegalDisclosureRequest
            //Assert.IsType<CreateLegalDisclosureRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Attachments'
        /// </summary>
        [Fact]
        public void AttachmentsTest()
        {
            // TODO unit test for the property 'Attachments'
        }
    }
}

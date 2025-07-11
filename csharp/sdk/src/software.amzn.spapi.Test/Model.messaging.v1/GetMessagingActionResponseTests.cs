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
using software.amzn.spapi.Model.messaging.v1;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing GetMessagingActionResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetMessagingActionResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetMessagingActionResponse
        //private GetMessagingActionResponse instance;

        public GetMessagingActionResponseTests()
        {
            // TODO uncomment below to create an instance of GetMessagingActionResponse
            //instance = new GetMessagingActionResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetMessagingActionResponse
        /// </summary>
        [Fact]
        public void GetMessagingActionResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetMessagingActionResponse
            //Assert.IsType<GetMessagingActionResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Fact]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }

        /// <summary>
        /// Test the property 'Embedded'
        /// </summary>
        [Fact]
        public void EmbeddedTest()
        {
            // TODO unit test for the property 'Embedded'
        }

        /// <summary>
        /// Test the property 'Payload'
        /// </summary>
        [Fact]
        public void PayloadTest()
        {
            // TODO unit test for the property 'Payload'
        }

        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
    }
}

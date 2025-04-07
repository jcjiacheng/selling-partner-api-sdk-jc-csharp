/*
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, refer to the [Notifications Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/notifications-api-v1-use-case-guide).
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/notifications/v1;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing CreateSubscriptionRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateSubscriptionRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateSubscriptionRequest
        //private CreateSubscriptionRequest instance;

        public CreateSubscriptionRequestTests()
        {
            // TODO uncomment below to create an instance of CreateSubscriptionRequest
            //instance = new CreateSubscriptionRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateSubscriptionRequest
        /// </summary>
        [Fact]
        public void CreateSubscriptionRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateSubscriptionRequest
            //Assert.IsType<CreateSubscriptionRequest>(instance);
        }

        /// <summary>
        /// Test the property 'PayloadVersion'
        /// </summary>
        [Fact]
        public void PayloadVersionTest()
        {
            // TODO unit test for the property 'PayloadVersion'
        }

        /// <summary>
        /// Test the property 'DestinationId'
        /// </summary>
        [Fact]
        public void DestinationIdTest()
        {
            // TODO unit test for the property 'DestinationId'
        }

        /// <summary>
        /// Test the property 'ProcessingDirective'
        /// </summary>
        [Fact]
        public void ProcessingDirectiveTest()
        {
            // TODO unit test for the property 'ProcessingDirective'
        }
    }
}

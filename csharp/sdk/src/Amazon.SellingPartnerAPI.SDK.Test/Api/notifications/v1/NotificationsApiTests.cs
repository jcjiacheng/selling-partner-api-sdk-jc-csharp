/*
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, refer to the [Notifications Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/notifications-api-v1-use-case-guide).
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Amazon.SellingPartnerAPI.SDK.Client;
using Amazon.SellingPartnerAPI.SDK.Api/notifications/v1;
using Amazon.SellingPartnerAPI.SDK.Model/notifications/v1;

namespace Amazon.SellingPartnerAPI.SDK.Test
{
    /// <summary>
    ///  Class for testing NotificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NotificationsApiTests
    {
        private NotificationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new NotificationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NotificationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NotificationsApi
            //Assert.IsInstanceOfType(typeof(NotificationsApi), instance, "instance is a NotificationsApi");
        }

        
        /// <summary>
        /// Test CreateDestination
        /// </summary>
        [Test]
        public void CreateDestinationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateDestinationRequest body = null;
            //var response = instance.CreateDestination(body);
            //Assert.IsInstanceOf<CreateDestinationResponse> (response, "response is CreateDestinationResponse");
        }
        
        /// <summary>
        /// Test CreateSubscription
        /// </summary>
        [Test]
        public void CreateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string notificationType = null;
            //CreateSubscriptionRequest body = null;
            //var response = instance.CreateSubscription(notificationTypebody);
            //Assert.IsInstanceOf<CreateSubscriptionResponse> (response, "response is CreateSubscriptionResponse");
        }
        
        /// <summary>
        /// Test DeleteDestination
        /// </summary>
        [Test]
        public void DeleteDestinationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string destinationId = null;
            //var response = instance.DeleteDestination(destinationId);
            //Assert.IsInstanceOf<DeleteDestinationResponse> (response, "response is DeleteDestinationResponse");
        }
        
        /// <summary>
        /// Test DeleteSubscriptionById
        /// </summary>
        [Test]
        public void DeleteSubscriptionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string notificationType = null;
            //var response = instance.DeleteSubscriptionById(subscriptionIdnotificationType);
            //Assert.IsInstanceOf<DeleteSubscriptionByIdResponse> (response, "response is DeleteSubscriptionByIdResponse");
        }
        
        /// <summary>
        /// Test GetDestination
        /// </summary>
        [Test]
        public void GetDestinationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string destinationId = null;
            //var response = instance.GetDestination(destinationId);
            //Assert.IsInstanceOf<GetDestinationResponse> (response, "response is GetDestinationResponse");
        }
        
        /// <summary>
        /// Test GetDestinations
        /// </summary>
        [Test]
        public void GetDestinationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDestinations();
            //Assert.IsInstanceOf<GetDestinationsResponse> (response, "response is GetDestinationsResponse");
        }
        
        /// <summary>
        /// Test GetSubscription
        /// </summary>
        [Test]
        public void GetSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string notificationType = null;
            //string? payloadVersion = null;
            //var response = instance.GetSubscription(notificationTypepayloadVersion);
            //Assert.IsInstanceOf<GetSubscriptionResponse> (response, "response is GetSubscriptionResponse");
        }
        
        /// <summary>
        /// Test GetSubscriptionById
        /// </summary>
        [Test]
        public void GetSubscriptionByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string notificationType = null;
            //var response = instance.GetSubscriptionById(subscriptionIdnotificationType);
            //Assert.IsInstanceOf<GetSubscriptionByIdResponse> (response, "response is GetSubscriptionByIdResponse");
        }
        
    }

}

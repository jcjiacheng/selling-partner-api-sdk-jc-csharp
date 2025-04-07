/*
 * The Selling Partner API for third party application integrations.
 *
 * With the AppIntegrations API v2024-04-01, you can send notifications to Amazon Selling Partners and display the notifications in Seller Central.
 *
 * The version of the OpenAPI document: 2024-04-01
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/appIntegrations/v2024_04_01;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing DeleteNotificationsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DeleteNotificationsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DeleteNotificationsRequest
        //private DeleteNotificationsRequest instance;

        public DeleteNotificationsRequestTests()
        {
            // TODO uncomment below to create an instance of DeleteNotificationsRequest
            //instance = new DeleteNotificationsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeleteNotificationsRequest
        /// </summary>
        [Fact]
        public void DeleteNotificationsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" DeleteNotificationsRequest
            //Assert.IsType<DeleteNotificationsRequest>(instance);
        }

        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [Fact]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }

        /// <summary>
        /// Test the property 'DeletionReason'
        /// </summary>
        [Fact]
        public void DeletionReasonTest()
        {
            // TODO unit test for the property 'DeletionReason'
        }
    }
}

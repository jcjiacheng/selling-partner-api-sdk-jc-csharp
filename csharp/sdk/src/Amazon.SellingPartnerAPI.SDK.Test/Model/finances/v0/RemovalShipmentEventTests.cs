/*
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/finances/v0;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing RemovalShipmentEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RemovalShipmentEventTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RemovalShipmentEvent
        //private RemovalShipmentEvent instance;

        public RemovalShipmentEventTests()
        {
            // TODO uncomment below to create an instance of RemovalShipmentEvent
            //instance = new RemovalShipmentEvent();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RemovalShipmentEvent
        /// </summary>
        [Fact]
        public void RemovalShipmentEventInstanceTest()
        {
            // TODO uncomment below to test "IsType" RemovalShipmentEvent
            //Assert.IsType<RemovalShipmentEvent>(instance);
        }

        /// <summary>
        /// Test the property 'PostedDate'
        /// </summary>
        [Fact]
        public void PostedDateTest()
        {
            // TODO unit test for the property 'PostedDate'
        }

        /// <summary>
        /// Test the property 'MerchantOrderId'
        /// </summary>
        [Fact]
        public void MerchantOrderIdTest()
        {
            // TODO unit test for the property 'MerchantOrderId'
        }

        /// <summary>
        /// Test the property 'OrderId'
        /// </summary>
        [Fact]
        public void OrderIdTest()
        {
            // TODO unit test for the property 'OrderId'
        }

        /// <summary>
        /// Test the property 'TransactionType'
        /// </summary>
        [Fact]
        public void TransactionTypeTest()
        {
            // TODO unit test for the property 'TransactionType'
        }

        /// <summary>
        /// Test the property 'StoreName'
        /// </summary>
        [Fact]
        public void StoreNameTest()
        {
            // TODO unit test for the property 'StoreName'
        }

        /// <summary>
        /// Test the property 'RemovalShipmentItemList'
        /// </summary>
        [Fact]
        public void RemovalShipmentItemListTest()
        {
            // TODO unit test for the property 'RemovalShipmentItemList'
        }
    }
}

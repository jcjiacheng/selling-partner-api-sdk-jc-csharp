/*
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using software.amzn.spapi.Model.orders.v0;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing OrderItemBuyerInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OrderItemBuyerInfoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OrderItemBuyerInfo
        //private OrderItemBuyerInfo instance;

        public OrderItemBuyerInfoTests()
        {
            // TODO uncomment below to create an instance of OrderItemBuyerInfo
            //instance = new OrderItemBuyerInfo();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrderItemBuyerInfo
        /// </summary>
        [Fact]
        public void OrderItemBuyerInfoInstanceTest()
        {
            // TODO uncomment below to test "IsType" OrderItemBuyerInfo
            //Assert.IsType<OrderItemBuyerInfo>(instance);
        }

        /// <summary>
        /// Test the property 'OrderItemId'
        /// </summary>
        [Fact]
        public void OrderItemIdTest()
        {
            // TODO unit test for the property 'OrderItemId'
        }

        /// <summary>
        /// Test the property 'BuyerCustomizedInfo'
        /// </summary>
        [Fact]
        public void BuyerCustomizedInfoTest()
        {
            // TODO unit test for the property 'BuyerCustomizedInfo'
        }

        /// <summary>
        /// Test the property 'GiftWrapPrice'
        /// </summary>
        [Fact]
        public void GiftWrapPriceTest()
        {
            // TODO unit test for the property 'GiftWrapPrice'
        }

        /// <summary>
        /// Test the property 'GiftWrapTax'
        /// </summary>
        [Fact]
        public void GiftWrapTaxTest()
        {
            // TODO unit test for the property 'GiftWrapTax'
        }

        /// <summary>
        /// Test the property 'GiftMessageText'
        /// </summary>
        [Fact]
        public void GiftMessageTextTest()
        {
            // TODO unit test for the property 'GiftMessageText'
        }

        /// <summary>
        /// Test the property 'GiftWrapLevel'
        /// </summary>
        [Fact]
        public void GiftWrapLevelTest()
        {
            // TODO unit test for the property 'GiftWrapLevel'
        }
    }
}

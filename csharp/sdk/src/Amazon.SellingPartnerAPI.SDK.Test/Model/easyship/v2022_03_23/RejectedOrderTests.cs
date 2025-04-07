/*
 * Selling Partner API for Easy Ship
 *
 * Use the Selling Partner API for Easy Ship to build applications for sellers to manage and ship Amazon Easy Ship orders. With this API, you can get available time slots, schedule and reschedule Easy Ship orders, and print shipping labels, invoices, and warranties. To review the differences in Easy Ship operations by marketplace, refer to [Marketplace support](https://developer-docs.amazon.com/sp-api/docs/easyship-api-v2022-03-23-use-case-guide#marketplace-support).
 *
 * The version of the OpenAPI document: 2022-03-23
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/easyship/v2022_03_23;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing RejectedOrder
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RejectedOrderTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RejectedOrder
        //private RejectedOrder instance;

        public RejectedOrderTests()
        {
            // TODO uncomment below to create an instance of RejectedOrder
            //instance = new RejectedOrder();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RejectedOrder
        /// </summary>
        [Fact]
        public void RejectedOrderInstanceTest()
        {
            // TODO uncomment below to test "IsType" RejectedOrder
            //Assert.IsType<RejectedOrder>(instance);
        }

        /// <summary>
        /// Test the property 'AmazonOrderId'
        /// </summary>
        [Fact]
        public void AmazonOrderIdTest()
        {
            // TODO unit test for the property 'AmazonOrderId'
        }

        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }
    }
}

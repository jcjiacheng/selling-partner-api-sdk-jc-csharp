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
    ///  Class for testing ChargeRefundTransaction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ChargeRefundTransactionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ChargeRefundTransaction
        //private ChargeRefundTransaction instance;

        public ChargeRefundTransactionTests()
        {
            // TODO uncomment below to create an instance of ChargeRefundTransaction
            //instance = new ChargeRefundTransaction();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChargeRefundTransaction
        /// </summary>
        [Fact]
        public void ChargeRefundTransactionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ChargeRefundTransaction
            //Assert.IsType<ChargeRefundTransaction>(instance);
        }

        /// <summary>
        /// Test the property 'ChargeAmount'
        /// </summary>
        [Fact]
        public void ChargeAmountTest()
        {
            // TODO unit test for the property 'ChargeAmount'
        }

        /// <summary>
        /// Test the property 'ChargeType'
        /// </summary>
        [Fact]
        public void ChargeTypeTest()
        {
            // TODO unit test for the property 'ChargeType'
        }
    }
}

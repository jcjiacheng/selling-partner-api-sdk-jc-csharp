/*
 * Selling Partner API for FBA Inventory
 *
 * The Selling Partner API for FBA Inventory lets you programmatically retrieve information about inventory in Amazon's fulfillment network.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/fba/inventory/v1;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing ReservedQuantity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReservedQuantityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReservedQuantity
        //private ReservedQuantity instance;

        public ReservedQuantityTests()
        {
            // TODO uncomment below to create an instance of ReservedQuantity
            //instance = new ReservedQuantity();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReservedQuantity
        /// </summary>
        [Fact]
        public void ReservedQuantityInstanceTest()
        {
            // TODO uncomment below to test "IsType" ReservedQuantity
            //Assert.IsType<ReservedQuantity>(instance);
        }

        /// <summary>
        /// Test the property 'TotalReservedQuantity'
        /// </summary>
        [Fact]
        public void TotalReservedQuantityTest()
        {
            // TODO unit test for the property 'TotalReservedQuantity'
        }

        /// <summary>
        /// Test the property 'PendingCustomerOrderQuantity'
        /// </summary>
        [Fact]
        public void PendingCustomerOrderQuantityTest()
        {
            // TODO unit test for the property 'PendingCustomerOrderQuantity'
        }

        /// <summary>
        /// Test the property 'PendingTransshipmentQuantity'
        /// </summary>
        [Fact]
        public void PendingTransshipmentQuantityTest()
        {
            // TODO unit test for the property 'PendingTransshipmentQuantity'
        }

        /// <summary>
        /// Test the property 'FcProcessingQuantity'
        /// </summary>
        [Fact]
        public void FcProcessingQuantityTest()
        {
            // TODO unit test for the property 'FcProcessingQuantity'
        }
    }
}

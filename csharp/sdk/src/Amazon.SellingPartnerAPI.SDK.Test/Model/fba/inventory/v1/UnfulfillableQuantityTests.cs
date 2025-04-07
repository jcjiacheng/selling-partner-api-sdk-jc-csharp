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
    ///  Class for testing UnfulfillableQuantity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UnfulfillableQuantityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UnfulfillableQuantity
        //private UnfulfillableQuantity instance;

        public UnfulfillableQuantityTests()
        {
            // TODO uncomment below to create an instance of UnfulfillableQuantity
            //instance = new UnfulfillableQuantity();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UnfulfillableQuantity
        /// </summary>
        [Fact]
        public void UnfulfillableQuantityInstanceTest()
        {
            // TODO uncomment below to test "IsType" UnfulfillableQuantity
            //Assert.IsType<UnfulfillableQuantity>(instance);
        }

        /// <summary>
        /// Test the property 'TotalUnfulfillableQuantity'
        /// </summary>
        [Fact]
        public void TotalUnfulfillableQuantityTest()
        {
            // TODO unit test for the property 'TotalUnfulfillableQuantity'
        }

        /// <summary>
        /// Test the property 'CustomerDamagedQuantity'
        /// </summary>
        [Fact]
        public void CustomerDamagedQuantityTest()
        {
            // TODO unit test for the property 'CustomerDamagedQuantity'
        }

        /// <summary>
        /// Test the property 'WarehouseDamagedQuantity'
        /// </summary>
        [Fact]
        public void WarehouseDamagedQuantityTest()
        {
            // TODO unit test for the property 'WarehouseDamagedQuantity'
        }

        /// <summary>
        /// Test the property 'DistributorDamagedQuantity'
        /// </summary>
        [Fact]
        public void DistributorDamagedQuantityTest()
        {
            // TODO unit test for the property 'DistributorDamagedQuantity'
        }

        /// <summary>
        /// Test the property 'CarrierDamagedQuantity'
        /// </summary>
        [Fact]
        public void CarrierDamagedQuantityTest()
        {
            // TODO unit test for the property 'CarrierDamagedQuantity'
        }

        /// <summary>
        /// Test the property 'DefectiveQuantity'
        /// </summary>
        [Fact]
        public void DefectiveQuantityTest()
        {
            // TODO unit test for the property 'DefectiveQuantity'
        }

        /// <summary>
        /// Test the property 'ExpiredQuantity'
        /// </summary>
        [Fact]
        public void ExpiredQuantityTest()
        {
            // TODO unit test for the property 'ExpiredQuantity'
        }
    }
}

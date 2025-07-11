/*
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using software.amzn.spapi.Model.vendor.shipments.v1;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing PackageItemDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PackageItemDetailsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PackageItemDetails
        //private PackageItemDetails instance;

        public PackageItemDetailsTests()
        {
            // TODO uncomment below to create an instance of PackageItemDetails
            //instance = new PackageItemDetails();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PackageItemDetails
        /// </summary>
        [Fact]
        public void PackageItemDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsType" PackageItemDetails
            //Assert.IsType<PackageItemDetails>(instance);
        }

        /// <summary>
        /// Test the property 'PurchaseOrderNumber'
        /// </summary>
        [Fact]
        public void PurchaseOrderNumberTest()
        {
            // TODO unit test for the property 'PurchaseOrderNumber'
        }

        /// <summary>
        /// Test the property 'LotNumber'
        /// </summary>
        [Fact]
        public void LotNumberTest()
        {
            // TODO unit test for the property 'LotNumber'
        }

        /// <summary>
        /// Test the property 'Expiry'
        /// </summary>
        [Fact]
        public void ExpiryTest()
        {
            // TODO unit test for the property 'Expiry'
        }
    }
}

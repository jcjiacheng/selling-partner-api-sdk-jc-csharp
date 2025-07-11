/*
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/listings-items-api-v2021-08-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2021-08-01
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using software.amzn.spapi.Model.listings.items.v2021_08_01;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing PatchOperation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PatchOperationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PatchOperation
        //private PatchOperation instance;

        public PatchOperationTests()
        {
            // TODO uncomment below to create an instance of PatchOperation
            //instance = new PatchOperation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PatchOperation
        /// </summary>
        [Fact]
        public void PatchOperationInstanceTest()
        {
            // TODO uncomment below to test "IsType" PatchOperation
            //Assert.IsType<PatchOperation>(instance);
        }

        /// <summary>
        /// Test the property 'Op'
        /// </summary>
        [Fact]
        public void OpTest()
        {
            // TODO unit test for the property 'Op'
        }

        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Fact]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }

        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
    }
}

/*
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * The version of the OpenAPI document: 2024-03-20
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v2024_03_20;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing MskuPrepDetail
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MskuPrepDetailTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MskuPrepDetail
        //private MskuPrepDetail instance;

        public MskuPrepDetailTests()
        {
            // TODO uncomment below to create an instance of MskuPrepDetail
            //instance = new MskuPrepDetail();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MskuPrepDetail
        /// </summary>
        [Fact]
        public void MskuPrepDetailInstanceTest()
        {
            // TODO uncomment below to test "IsType" MskuPrepDetail
            //Assert.IsType<MskuPrepDetail>(instance);
        }

        /// <summary>
        /// Test the property 'AllOwnersConstraint'
        /// </summary>
        [Fact]
        public void AllOwnersConstraintTest()
        {
            // TODO unit test for the property 'AllOwnersConstraint'
        }

        /// <summary>
        /// Test the property 'LabelOwnerConstraint'
        /// </summary>
        [Fact]
        public void LabelOwnerConstraintTest()
        {
            // TODO unit test for the property 'LabelOwnerConstraint'
        }

        /// <summary>
        /// Test the property 'Msku'
        /// </summary>
        [Fact]
        public void MskuTest()
        {
            // TODO unit test for the property 'Msku'
        }

        /// <summary>
        /// Test the property 'PrepCategory'
        /// </summary>
        [Fact]
        public void PrepCategoryTest()
        {
            // TODO unit test for the property 'PrepCategory'
        }

        /// <summary>
        /// Test the property 'PrepOwnerConstraint'
        /// </summary>
        [Fact]
        public void PrepOwnerConstraintTest()
        {
            // TODO unit test for the property 'PrepOwnerConstraint'
        }

        /// <summary>
        /// Test the property 'PrepTypes'
        /// </summary>
        [Fact]
        public void PrepTypesTest()
        {
            // TODO unit test for the property 'PrepTypes'
        }
    }
}

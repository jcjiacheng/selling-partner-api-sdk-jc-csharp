/*
 * The Selling Partner API for Sellers
 *
 * The [Selling Partner API for Sellers](https://developer-docs.amazon.com/sp-api/docs/sellers-api-v1-reference) (Sellers API) provides essential information about seller accounts, such as:  - The marketplaces a seller can list in - The default language and currency of a marketplace - Whether the seller has suspended listings  Refer to the [Sellers API reference](https://developer-docs.amazon.com/sp-api/docs/sellers-api-v1-reference) for details about this API's operations, data types, and schemas.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/sellers/v1;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing Account
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Account
        //private Account instance;

        public AccountTests()
        {
            // TODO uncomment below to create an instance of Account
            //instance = new Account();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Account
        /// </summary>
        [Fact]
        public void AccountInstanceTest()
        {
            // TODO uncomment below to test "IsType" Account
            //Assert.IsType<Account>(instance);
        }

        /// <summary>
        /// Test the property 'MarketplaceParticipationList'
        /// </summary>
        [Fact]
        public void MarketplaceParticipationListTest()
        {
            // TODO unit test for the property 'MarketplaceParticipationList'
        }

        /// <summary>
        /// Test the property 'BusinessType'
        /// </summary>
        [Fact]
        public void BusinessTypeTest()
        {
            // TODO unit test for the property 'BusinessType'
        }

        /// <summary>
        /// Test the property 'SellingPlan'
        /// </summary>
        [Fact]
        public void SellingPlanTest()
        {
            // TODO unit test for the property 'SellingPlan'
        }

        /// <summary>
        /// Test the property 'Business'
        /// </summary>
        [Fact]
        public void BusinessTest()
        {
            // TODO unit test for the property 'Business'
        }

        /// <summary>
        /// Test the property 'PrimaryContact'
        /// </summary>
        [Fact]
        public void PrimaryContactTest()
        {
            // TODO unit test for the property 'PrimaryContact'
        }
    }
}

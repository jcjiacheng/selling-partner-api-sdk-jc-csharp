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
    ///  Class for testing MarketplaceParticipation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MarketplaceParticipationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MarketplaceParticipation
        //private MarketplaceParticipation instance;

        public MarketplaceParticipationTests()
        {
            // TODO uncomment below to create an instance of MarketplaceParticipation
            //instance = new MarketplaceParticipation();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MarketplaceParticipation
        /// </summary>
        [Fact]
        public void MarketplaceParticipationInstanceTest()
        {
            // TODO uncomment below to test "IsType" MarketplaceParticipation
            //Assert.IsType<MarketplaceParticipation>(instance);
        }

        /// <summary>
        /// Test the property 'Marketplace'
        /// </summary>
        [Fact]
        public void MarketplaceTest()
        {
            // TODO unit test for the property 'Marketplace'
        }

        /// <summary>
        /// Test the property 'Participation'
        /// </summary>
        [Fact]
        public void ParticipationTest()
        {
            // TODO unit test for the property 'Participation'
        }

        /// <summary>
        /// Test the property 'StoreName'
        /// </summary>
        [Fact]
        public void StoreNameTest()
        {
            // TODO unit test for the property 'StoreName'
        }
    }
}

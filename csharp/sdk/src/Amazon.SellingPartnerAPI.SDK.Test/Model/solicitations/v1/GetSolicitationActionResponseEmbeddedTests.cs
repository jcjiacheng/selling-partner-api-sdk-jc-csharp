/*
 * Selling Partner API for Solicitations
 *
 * With the Solicitations API you can build applications that send non-critical solicitations to buyers. You can get a list of solicitation types that are available for an order that you specify, then call an operation that sends a solicitation to the buyer for that order. Buyers cannot respond to solicitations sent by this API, and these solicitations do not appear in the Messaging section of Seller Central or in the recipient's Message Center. The Solicitations API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Amazon.SellingPartnerAPI.SDK.Model/solicitations/v1;
using Amazon.SellingPartnerAPI.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Amazon.SellingPartnerAPI.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing GetSolicitationActionResponseEmbedded
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSolicitationActionResponseEmbeddedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSolicitationActionResponseEmbedded
        //private GetSolicitationActionResponseEmbedded instance;

        public GetSolicitationActionResponseEmbeddedTests()
        {
            // TODO uncomment below to create an instance of GetSolicitationActionResponseEmbedded
            //instance = new GetSolicitationActionResponseEmbedded();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSolicitationActionResponseEmbedded
        /// </summary>
        [Fact]
        public void GetSolicitationActionResponseEmbeddedInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSolicitationActionResponseEmbedded
            //Assert.IsType<GetSolicitationActionResponseEmbedded>(instance);
        }

        /// <summary>
        /// Test the property 'Schema'
        /// </summary>
        [Fact]
        public void SchemaTest()
        {
            // TODO unit test for the property 'Schema'
        }
    }
}

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
    ///  Class for testing GetSchemaResponseLinks
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSchemaResponseLinksTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSchemaResponseLinks
        //private GetSchemaResponseLinks instance;

        public GetSchemaResponseLinksTests()
        {
            // TODO uncomment below to create an instance of GetSchemaResponseLinks
            //instance = new GetSchemaResponseLinks();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSchemaResponseLinks
        /// </summary>
        [Fact]
        public void GetSchemaResponseLinksInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSchemaResponseLinks
            //Assert.IsType<GetSchemaResponseLinks>(instance);
        }

        /// <summary>
        /// Test the property 'Self'
        /// </summary>
        [Fact]
        public void SelfTest()
        {
            // TODO unit test for the property 'Self'
        }
    }
}

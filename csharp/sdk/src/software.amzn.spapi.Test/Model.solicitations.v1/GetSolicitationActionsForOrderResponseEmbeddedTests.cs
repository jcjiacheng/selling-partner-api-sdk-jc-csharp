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
using software.amzn.spapi.Model.solicitations.v1;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing GetSolicitationActionsForOrderResponseEmbedded
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSolicitationActionsForOrderResponseEmbeddedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSolicitationActionsForOrderResponseEmbedded
        //private GetSolicitationActionsForOrderResponseEmbedded instance;

        public GetSolicitationActionsForOrderResponseEmbeddedTests()
        {
            // TODO uncomment below to create an instance of GetSolicitationActionsForOrderResponseEmbedded
            //instance = new GetSolicitationActionsForOrderResponseEmbedded();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSolicitationActionsForOrderResponseEmbedded
        /// </summary>
        [Fact]
        public void GetSolicitationActionsForOrderResponseEmbeddedInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSolicitationActionsForOrderResponseEmbedded
            //Assert.IsType<GetSolicitationActionsForOrderResponseEmbedded>(instance);
        }

        /// <summary>
        /// Test the property 'Actions'
        /// </summary>
        [Fact]
        public void ActionsTest()
        {
            // TODO unit test for the property 'Actions'
        }
    }
}

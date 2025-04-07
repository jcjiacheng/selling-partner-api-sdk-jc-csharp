/*
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * The version of the OpenAPI document: 2021-12-28
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Amazon.SellingPartnerAPI.SDK.Client;
using Amazon.SellingPartnerAPI.SDK.Api/vendor/df/shipping/v2021_12_28;
using Amazon.SellingPartnerAPI.SDK.Model/vendor/df/shipping/v2021_12_28;

namespace Amazon.SellingPartnerAPI.SDK.Test
{
    /// <summary>
    ///  Class for testing CustomerInvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerInvoicesApiTests
    {
        private CustomerInvoicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to initialize instance for testing
            //instance = new CustomerInvoicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerInvoicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerInvoicesApi
            //Assert.IsInstanceOfType(typeof(CustomerInvoicesApi), instance, "instance is a CustomerInvoicesApi");
        }

        
        /// <summary>
        /// Test GetCustomerInvoice
        /// </summary>
        [Test]
        public void GetCustomerInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string purchaseOrderNumber = null;
            //var response = instance.GetCustomerInvoice(purchaseOrderNumber);
            //Assert.IsInstanceOf<CustomerInvoice> (response, "response is CustomerInvoice");
        }
        
        /// <summary>
        /// Test GetCustomerInvoices
        /// </summary>
        [Test]
        public void GetCustomerInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime createdAfter = null;
            //DateTime createdBefore = null;
            //string? shipFromPartyId = null;
            //int? limit = null;
            //string? sortOrder = null;
            //string? nextToken = null;
            //var response = instance.GetCustomerInvoices(createdAftercreatedBeforeshipFromPartyIdlimitsortOrdernextToken);
            //Assert.IsInstanceOf<CustomerInvoiceList> (response, "response is CustomerInvoiceList");
        }
        
    }

}

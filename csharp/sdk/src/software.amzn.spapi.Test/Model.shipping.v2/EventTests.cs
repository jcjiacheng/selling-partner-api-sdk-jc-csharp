/*
 * Amazon Shipping API
 *
 * The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.
 *
 * The version of the OpenAPI document: v2
 * Contact: swa-api-core@amazon.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using software.amzn.spapi.Model.shipping.v2;
using software.amzn.spapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace software.amzn.spapi.Test.Model
{
    /// <summary>
    ///  Class for testing Event
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EventTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Event
        //private Event instance;

        public EventTests()
        {
            // TODO uncomment below to create an instance of Event
            //instance = new Event();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Event
        /// </summary>
        [Fact]
        public void EventInstanceTest()
        {
            // TODO uncomment below to test "IsType" Event
            //Assert.IsType<Event>(instance);
        }

        /// <summary>
        /// Test the property 'EventCode'
        /// </summary>
        [Fact]
        public void EventCodeTest()
        {
            // TODO unit test for the property 'EventCode'
        }

        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }

        /// <summary>
        /// Test the property 'EventTime'
        /// </summary>
        [Fact]
        public void EventTimeTest()
        {
            // TODO unit test for the property 'EventTime'
        }

        /// <summary>
        /// Test the property 'ShipmentType'
        /// </summary>
        [Fact]
        public void ShipmentTypeTest()
        {
            // TODO unit test for the property 'ShipmentType'
        }
    }
}

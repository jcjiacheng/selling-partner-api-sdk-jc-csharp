/*
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * The version of the OpenAPI document: 2020-07-01
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Amazon.SellingPartnerAPI.SDK.Client.OpenAPIDateConverter;

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/outbound/v2020_07_01
{
    /// <summary>
    /// Indicates if the return item has been processed by a fulfillment center.
    /// </summary>
    /// <value>Indicates if the return item has been processed by a fulfillment center.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FulfillmentReturnItemStatus
    {
        /// <summary>
        /// Enum New for value: New
        /// </summary>
        [EnumMember(Value = "New")]
        New = 1,

        /// <summary>
        /// Enum Processed for value: Processed
        /// </summary>
        [EnumMember(Value = "Processed")]
        Processed = 2
    }

}

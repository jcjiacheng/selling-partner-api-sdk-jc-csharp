/*
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * The version of the OpenAPI document: v0
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

namespace Amazon.SellingPartnerAPI.SDK.Model/orders/v0
{
    /// <summary>
    /// The verification status of the order.
    /// </summary>
    /// <value>The verification status of the order.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerificationStatus
    {
        /// <summary>
        /// Enum Pending for value: Pending
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending = 1,

        /// <summary>
        /// Enum Approved for value: Approved
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved = 2,

        /// <summary>
        /// Enum Rejected for value: Rejected
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected = 3,

        /// <summary>
        /// Enum Expired for value: Expired
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired = 4,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 5
    }

}

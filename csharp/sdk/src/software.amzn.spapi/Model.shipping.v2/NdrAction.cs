/*
 * Amazon Shipping API
 *
 * The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.
 *
 * The version of the OpenAPI document: v2
 * Contact: swa-api-core@amazon.com
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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.shipping.v2
{
    /// <summary>
    /// The type of NDR action shipper wants to take for a particular shipment.
    /// </summary>
    /// <value>The type of NDR action shipper wants to take for a particular shipment.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NdrAction
    {
        /// <summary>
        /// Enum RESCHEDULE for value: RESCHEDULE
        /// </summary>
        [EnumMember(Value = "RESCHEDULE")]
        RESCHEDULE = 1,

        /// <summary>
        /// Enum REATTEMPT for value: REATTEMPT
        /// </summary>
        [EnumMember(Value = "REATTEMPT")]
        REATTEMPT = 2,

        /// <summary>
        /// Enum RTO for value: RTO
        /// </summary>
        [EnumMember(Value = "RTO")]
        RTO = 3
    }

}

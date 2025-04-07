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
using OpenAPIDateConverter = Amazon.SellingPartnerAPI.SDK.Client.OpenAPIDateConverter;

namespace Amazon.SellingPartnerAPI.SDK.Model/shipping/v2
{
    /// <summary>
    /// The type of shipping document.
    /// </summary>
    /// <value>The type of shipping document.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentType
    {
        /// <summary>
        /// Enum PACKSLIP for value: PACKSLIP
        /// </summary>
        [EnumMember(Value = "PACKSLIP")]
        PACKSLIP = 1,

        /// <summary>
        /// Enum LABEL for value: LABEL
        /// </summary>
        [EnumMember(Value = "LABEL")]
        LABEL = 2,

        /// <summary>
        /// Enum RECEIPT for value: RECEIPT
        /// </summary>
        [EnumMember(Value = "RECEIPT")]
        RECEIPT = 3,

        /// <summary>
        /// Enum CUSTOMFORM for value: CUSTOM_FORM
        /// </summary>
        [EnumMember(Value = "CUSTOM_FORM")]
        CUSTOMFORM = 4
    }

}

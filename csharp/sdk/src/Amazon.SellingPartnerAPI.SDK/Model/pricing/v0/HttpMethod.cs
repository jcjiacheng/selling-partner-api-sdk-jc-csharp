/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/pricing/v0
{
    /// <summary>
    /// The HTTP method associated with the individual APIs being called as part of the batch request.
    /// </summary>
    /// <value>The HTTP method associated with the individual APIs being called as part of the batch request.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpMethod
    {
        /// <summary>
        /// Enum GET for value: GET
        /// </summary>
        [EnumMember(Value = "GET")]
        GET = 1,

        /// <summary>
        /// Enum PUT for value: PUT
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT = 2,

        /// <summary>
        /// Enum PATCH for value: PATCH
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH = 3,

        /// <summary>
        /// Enum DELETE for value: DELETE
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE = 4,

        /// <summary>
        /// Enum POST for value: POST
        /// </summary>
        [EnumMember(Value = "POST")]
        POST = 5
    }

}

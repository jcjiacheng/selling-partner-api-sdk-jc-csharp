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
    /// Indicates whether to request Consumer or Business offers. Default is Consumer.
    /// </summary>
    /// <value>Indicates whether to request Consumer or Business offers. Default is Consumer.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerType
    {
        /// <summary>
        /// Enum Consumer for value: Consumer
        /// </summary>
        [EnumMember(Value = "Consumer")]
        Consumer = 1,

        /// <summary>
        /// Enum Business for value: Business
        /// </summary>
        [EnumMember(Value = "Business")]
        Business = 2
    }

}

/*
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/supplySources/v2020_07_01
{
    /// <summary>
    /// The time unit
    /// </summary>
    /// <value>The time unit</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeUnit
    {
        /// <summary>
        /// Enum Hours for value: Hours
        /// </summary>
        [EnumMember(Value = "Hours")]
        Hours = 1,

        /// <summary>
        /// Enum Minutes for value: Minutes
        /// </summary>
        [EnumMember(Value = "Minutes")]
        Minutes = 2,

        /// <summary>
        /// Enum Days for value: Days
        /// </summary>
        [EnumMember(Value = "Days")]
        Days = 3
    }

}

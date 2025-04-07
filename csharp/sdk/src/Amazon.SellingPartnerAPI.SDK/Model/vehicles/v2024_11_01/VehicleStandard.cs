/*
 * The Selling Partner API for Automotive.
 *
 * The Selling Partner API for Automotive provides programmatic access to information needed by selling partners to provide compatibility information about their listed products.
 *
 * The version of the OpenAPI document: 2024-11-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vehicles/v2024_11_01
{
    /// <summary>
    /// Standard followed to uniquely identify a vehicle.
    /// </summary>
    /// <value>Standard followed to uniquely identify a vehicle.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VehicleStandard
    {
        /// <summary>
        /// Enum KTYPE for value: KTYPE
        /// </summary>
        [EnumMember(Value = "KTYPE")]
        KTYPE = 1,

        /// <summary>
        /// Enum AMAZONID for value: AMAZON_ID
        /// </summary>
        [EnumMember(Value = "AMAZON_ID")]
        AMAZONID = 2
    }

}

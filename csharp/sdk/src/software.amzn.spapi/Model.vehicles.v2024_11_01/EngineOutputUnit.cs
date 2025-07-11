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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.vehicles.v2024_11_01
{
    /// <summary>
    /// Unit for measuring engine power.
    /// </summary>
    /// <value>Unit for measuring engine power.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EngineOutputUnit
    {
        /// <summary>
        /// Enum KILOWATT for value: KILOWATT
        /// </summary>
        [EnumMember(Value = "KILOWATT")]
        KILOWATT = 1,

        /// <summary>
        /// Enum HORSEPOWER for value: HORSEPOWER
        /// </summary>
        [EnumMember(Value = "HORSEPOWER")]
        HORSEPOWER = 2
    }

}

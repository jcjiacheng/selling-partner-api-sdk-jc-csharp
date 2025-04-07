/*
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory.
 *
 * The version of the OpenAPI document: 2024-05-09
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

namespace Amazon.SellingPartnerAPI.SDK.Model/awd/v2024_05_09
{
    /// <summary>
    /// Unit of measurement for the inventory.
    /// </summary>
    /// <value>Unit of measurement for the inventory.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InventoryUnitOfMeasurement
    {
        /// <summary>
        /// Enum PRODUCTUNITS for value: PRODUCT_UNITS
        /// </summary>
        [EnumMember(Value = "PRODUCT_UNITS")]
        PRODUCTUNITS = 1,

        /// <summary>
        /// Enum CASES for value: CASES
        /// </summary>
        [EnumMember(Value = "CASES")]
        CASES = 2,

        /// <summary>
        /// Enum PALLETS for value: PALLETS
        /// </summary>
        [EnumMember(Value = "PALLETS")]
        PALLETS = 3
    }

}

/*
 * Selling Partner API for Retail Procurement Payments
 *
 * The Selling Partner API for Retail Procurement Payments provides programmatic access to vendors payments data.
 *
 * The version of the OpenAPI document: v1
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/invoices/v1
{
    /// <summary>
    /// This field represents weight unit of measure of items that are ordered by cases and supporting priced by weight.
    /// </summary>
    /// <value>This field represents weight unit of measure of items that are ordered by cases and supporting priced by weight.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NetCostUnitOfMeasure
    {
        /// <summary>
        /// Enum POUNDS for value: POUNDS
        /// </summary>
        [EnumMember(Value = "POUNDS")]
        POUNDS = 1,

        /// <summary>
        /// Enum OUNCES for value: OUNCES
        /// </summary>
        [EnumMember(Value = "OUNCES")]
        OUNCES = 2,

        /// <summary>
        /// Enum GRAMS for value: GRAMS
        /// </summary>
        [EnumMember(Value = "GRAMS")]
        GRAMS = 3,

        /// <summary>
        /// Enum KILOGRAMS for value: KILOGRAMS
        /// </summary>
        [EnumMember(Value = "KILOGRAMS")]
        KILOGRAMS = 4
    }

}

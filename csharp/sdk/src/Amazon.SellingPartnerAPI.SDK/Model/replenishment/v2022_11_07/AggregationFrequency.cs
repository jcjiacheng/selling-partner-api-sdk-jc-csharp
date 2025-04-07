/*
 * Selling Partner API for Replenishment
 *
 * The Selling Partner API for Replenishment (Replenishment API) provides programmatic access to replenishment program metrics and offers. These programs provide recurring delivery of any replenishable item at a frequency chosen by the customer.  The Replenishment API is available worldwide wherever Amazon Subscribe & Save is available or is supported. The API is available to vendors and FBA selling partners.
 *
 * The version of the OpenAPI document: 2022-11-07
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

namespace Amazon.SellingPartnerAPI.SDK.Model/replenishment/v2022_11_07
{
    /// <summary>
    /// The time period used to group data in the response. Note that this is only valid for the &#x60;PERFORMANCE&#x60; time period type.
    /// </summary>
    /// <value>The time period used to group data in the response. Note that this is only valid for the &#x60;PERFORMANCE&#x60; time period type.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AggregationFrequency
    {
        /// <summary>
        /// Enum WEEK for value: WEEK
        /// </summary>
        [EnumMember(Value = "WEEK")]
        WEEK = 1,

        /// <summary>
        /// Enum MONTH for value: MONTH
        /// </summary>
        [EnumMember(Value = "MONTH")]
        MONTH = 2,

        /// <summary>
        /// Enum QUARTER for value: QUARTER
        /// </summary>
        [EnumMember(Value = "QUARTER")]
        QUARTER = 3,

        /// <summary>
        /// Enum YEAR for value: YEAR
        /// </summary>
        [EnumMember(Value = "YEAR")]
        YEAR = 4
    }

}

/*
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v0
{
    /// <summary>
    /// Item preparation instructions.
    /// </summary>
    /// <value>Item preparation instructions.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepGuidance
    {
        /// <summary>
        /// Enum ConsultHelpDocuments for value: ConsultHelpDocuments
        /// </summary>
        [EnumMember(Value = "ConsultHelpDocuments")]
        ConsultHelpDocuments = 1,

        /// <summary>
        /// Enum NoAdditionalPrepRequired for value: NoAdditionalPrepRequired
        /// </summary>
        [EnumMember(Value = "NoAdditionalPrepRequired")]
        NoAdditionalPrepRequired = 2,

        /// <summary>
        /// Enum SeePrepInstructionsList for value: SeePrepInstructionsList
        /// </summary>
        [EnumMember(Value = "SeePrepInstructionsList")]
        SeePrepInstructionsList = 3
    }

}

/*
 * Selling Partner API for A+ Content Management
 *
 * Use the A+ Content API to build applications that help selling partners add rich marketing content to their Amazon product detail pages. Selling partners can use A+ content to share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners use content modules to add images and text.
 *
 * The version of the OpenAPI document: 2020-11-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/aplusContent/v2020_11_01
{
    /// <summary>
    /// The type of rich text decorator.
    /// </summary>
    /// <value>The type of rich text decorator.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DecoratorType
    {
        /// <summary>
        /// Enum LISTITEM for value: LIST_ITEM
        /// </summary>
        [EnumMember(Value = "LIST_ITEM")]
        LISTITEM = 1,

        /// <summary>
        /// Enum LISTORDERED for value: LIST_ORDERED
        /// </summary>
        [EnumMember(Value = "LIST_ORDERED")]
        LISTORDERED = 2,

        /// <summary>
        /// Enum LISTUNORDERED for value: LIST_UNORDERED
        /// </summary>
        [EnumMember(Value = "LIST_UNORDERED")]
        LISTUNORDERED = 3,

        /// <summary>
        /// Enum STYLEBOLD for value: STYLE_BOLD
        /// </summary>
        [EnumMember(Value = "STYLE_BOLD")]
        STYLEBOLD = 4,

        /// <summary>
        /// Enum STYLEITALIC for value: STYLE_ITALIC
        /// </summary>
        [EnumMember(Value = "STYLE_ITALIC")]
        STYLEITALIC = 5,

        /// <summary>
        /// Enum STYLELINEBREAK for value: STYLE_LINEBREAK
        /// </summary>
        [EnumMember(Value = "STYLE_LINEBREAK")]
        STYLELINEBREAK = 6,

        /// <summary>
        /// Enum STYLEPARAGRAPH for value: STYLE_PARAGRAPH
        /// </summary>
        [EnumMember(Value = "STYLE_PARAGRAPH")]
        STYLEPARAGRAPH = 7,

        /// <summary>
        /// Enum STYLEUNDERLINE for value: STYLE_UNDERLINE
        /// </summary>
        [EnumMember(Value = "STYLE_UNDERLINE")]
        STYLEUNDERLINE = 8
    }

}

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
    /// The metric name and description.
    /// </summary>
    /// <value>The metric name and description.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Metric
    {
        /// <summary>
        /// Enum SHIPPEDSUBSCRIPTIONUNITS for value: SHIPPED_SUBSCRIPTION_UNITS
        /// </summary>
        [EnumMember(Value = "SHIPPED_SUBSCRIPTION_UNITS")]
        SHIPPEDSUBSCRIPTIONUNITS = 1,

        /// <summary>
        /// Enum TOTALSUBSCRIPTIONSREVENUE for value: TOTAL_SUBSCRIPTIONS_REVENUE
        /// </summary>
        [EnumMember(Value = "TOTAL_SUBSCRIPTIONS_REVENUE")]
        TOTALSUBSCRIPTIONSREVENUE = 2,

        /// <summary>
        /// Enum ACTIVESUBSCRIPTIONS for value: ACTIVE_SUBSCRIPTIONS
        /// </summary>
        [EnumMember(Value = "ACTIVE_SUBSCRIPTIONS")]
        ACTIVESUBSCRIPTIONS = 3,

        /// <summary>
        /// Enum NOTDELIVEREDDUETOOOS for value: NOT_DELIVERED_DUE_TO_OOS
        /// </summary>
        [EnumMember(Value = "NOT_DELIVERED_DUE_TO_OOS")]
        NOTDELIVEREDDUETOOOS = 4,

        /// <summary>
        /// Enum SUBSCRIBERNONSUBSCRIBERAVERAGEREVENUE for value: SUBSCRIBER_NON_SUBSCRIBER_AVERAGE_REVENUE
        /// </summary>
        [EnumMember(Value = "SUBSCRIBER_NON_SUBSCRIBER_AVERAGE_REVENUE")]
        SUBSCRIBERNONSUBSCRIBERAVERAGEREVENUE = 5,

        /// <summary>
        /// Enum LOSTREVENUEDUETOOOS for value: LOST_REVENUE_DUE_TO_OOS
        /// </summary>
        [EnumMember(Value = "LOST_REVENUE_DUE_TO_OOS")]
        LOSTREVENUEDUETOOOS = 6,

        /// <summary>
        /// Enum SUBSCRIBERNONSUBSCRIBERAVERAGEREORDERS for value: SUBSCRIBER_NON_SUBSCRIBER_AVERAGE_REORDERS
        /// </summary>
        [EnumMember(Value = "SUBSCRIBER_NON_SUBSCRIBER_AVERAGE_REORDERS")]
        SUBSCRIBERNONSUBSCRIBERAVERAGEREORDERS = 7,

        /// <summary>
        /// Enum COUPONSREVENUEPENETRATION for value: COUPONS_REVENUE_PENETRATION
        /// </summary>
        [EnumMember(Value = "COUPONS_REVENUE_PENETRATION")]
        COUPONSREVENUEPENETRATION = 8,

        /// <summary>
        /// Enum REVENUEBYDELIVERIES for value: REVENUE_BY_DELIVERIES
        /// </summary>
        [EnumMember(Value = "REVENUE_BY_DELIVERIES")]
        REVENUEBYDELIVERIES = 9,

        /// <summary>
        /// Enum SUBSCRIBERRETENTION for value: SUBSCRIBER_RETENTION
        /// </summary>
        [EnumMember(Value = "SUBSCRIBER_RETENTION")]
        SUBSCRIBERRETENTION = 10,

        /// <summary>
        /// Enum REVENUEPENETRATIONBYSELLERFUNDING for value: REVENUE_PENETRATION_BY_SELLER_FUNDING
        /// </summary>
        [EnumMember(Value = "REVENUE_PENETRATION_BY_SELLER_FUNDING")]
        REVENUEPENETRATIONBYSELLERFUNDING = 11,

        /// <summary>
        /// Enum SHAREOFCOUPONSUBSCRIPTIONS for value: SHARE_OF_COUPON_SUBSCRIPTIONS
        /// </summary>
        [EnumMember(Value = "SHARE_OF_COUPON_SUBSCRIPTIONS")]
        SHAREOFCOUPONSUBSCRIPTIONS = 12
    }

}

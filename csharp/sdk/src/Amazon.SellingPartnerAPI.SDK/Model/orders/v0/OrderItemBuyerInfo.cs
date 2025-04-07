/*
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
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

namespace Amazon.SellingPartnerAPI.SDK.Model/orders/v0
{
    /// <summary>
    /// A single order item&#39;s buyer information.
    /// </summary>
    [DataContract(Name = "OrderItemBuyerInfo")]
    public partial class OrderItemBuyerInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemBuyerInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderItemBuyerInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemBuyerInfo" /> class.
        /// </summary>
        /// <param name="orderItemId">An Amazon-defined order item identifier. (required).</param>
        /// <param name="buyerCustomizedInfo">buyerCustomizedInfo.</param>
        /// <param name="giftWrapPrice">giftWrapPrice.</param>
        /// <param name="giftWrapTax">giftWrapTax.</param>
        /// <param name="giftMessageText">A gift message provided by the buyer.  **Note**: This attribute is only available for MFN (fulfilled by seller) orders..</param>
        /// <param name="giftWrapLevel">The gift wrap level specified by the buyer..</param>
        public OrderItemBuyerInfo(string orderItemId = default(string), BuyerCustomizedInfoDetail buyerCustomizedInfo = default(BuyerCustomizedInfoDetail), Money giftWrapPrice = default(Money), Money giftWrapTax = default(Money), string giftMessageText = default(string), string giftWrapLevel = default(string))
        {
            // to ensure "orderItemId" is required (not null)
            if (orderItemId == null)
            {
                throw new ArgumentNullException("orderItemId is a required property for OrderItemBuyerInfo and cannot be null");
            }
            this.OrderItemId = orderItemId;
            this.BuyerCustomizedInfo = buyerCustomizedInfo;
            this.GiftWrapPrice = giftWrapPrice;
            this.GiftWrapTax = giftWrapTax;
            this.GiftMessageText = giftMessageText;
            this.GiftWrapLevel = giftWrapLevel;
        }

        /// <summary>
        /// An Amazon-defined order item identifier.
        /// </summary>
        /// <value>An Amazon-defined order item identifier.</value>
        [DataMember(Name = "OrderItemId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderItemId { get; set; }

        /// <summary>
        /// Gets or Sets BuyerCustomizedInfo
        /// </summary>
        [DataMember(Name = "BuyerCustomizedInfo", EmitDefaultValue = false)]
        public BuyerCustomizedInfoDetail BuyerCustomizedInfo { get; set; }

        /// <summary>
        /// Gets or Sets GiftWrapPrice
        /// </summary>
        [DataMember(Name = "GiftWrapPrice", EmitDefaultValue = false)]
        public Money GiftWrapPrice { get; set; }

        /// <summary>
        /// Gets or Sets GiftWrapTax
        /// </summary>
        [DataMember(Name = "GiftWrapTax", EmitDefaultValue = false)]
        public Money GiftWrapTax { get; set; }

        /// <summary>
        /// A gift message provided by the buyer.  **Note**: This attribute is only available for MFN (fulfilled by seller) orders.
        /// </summary>
        /// <value>A gift message provided by the buyer.  **Note**: This attribute is only available for MFN (fulfilled by seller) orders.</value>
        [DataMember(Name = "GiftMessageText", EmitDefaultValue = false)]
        public string GiftMessageText { get; set; }

        /// <summary>
        /// The gift wrap level specified by the buyer.
        /// </summary>
        /// <value>The gift wrap level specified by the buyer.</value>
        [DataMember(Name = "GiftWrapLevel", EmitDefaultValue = false)]
        public string GiftWrapLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderItemBuyerInfo {\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  BuyerCustomizedInfo: ").Append(BuyerCustomizedInfo).Append("\n");
            sb.Append("  GiftWrapPrice: ").Append(GiftWrapPrice).Append("\n");
            sb.Append("  GiftWrapTax: ").Append(GiftWrapTax).Append("\n");
            sb.Append("  GiftMessageText: ").Append(GiftMessageText).Append("\n");
            sb.Append("  GiftWrapLevel: ").Append(GiftWrapLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

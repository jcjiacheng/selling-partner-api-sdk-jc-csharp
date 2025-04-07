/*
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/outbound/v2020_07_01
{
    /// <summary>
    /// Item information for creating a fulfillment order.
    /// </summary>
    [DataContract(Name = "CreateFulfillmentOrderItem")]
    public partial class CreateFulfillmentOrderItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentOrderItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFulfillmentOrderItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentOrderItem" /> class.
        /// </summary>
        /// <param name="sellerSku">The seller SKU of the item. (required).</param>
        /// <param name="sellerFulfillmentOrderItemId">A fulfillment order item identifier that the seller creates to track fulfillment order items. Used to disambiguate multiple fulfillment items that have the same &#x60;SellerSKU&#x60;. For example, the seller might assign different &#x60;SellerFulfillmentOrderItemId&#x60; values to two items in a fulfillment order that share the same &#x60;SellerSKU&#x60; but have different &#x60;GiftMessage&#x60; values. (required).</param>
        /// <param name="quantity">The item quantity. (required).</param>
        /// <param name="giftMessage">A message to the gift recipient, if applicable..</param>
        /// <param name="displayableComment">Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip..</param>
        /// <param name="fulfillmentNetworkSku">Amazon&#39;s fulfillment network SKU of the item..</param>
        /// <param name="perUnitDeclaredValue">perUnitDeclaredValue.</param>
        /// <param name="perUnitPrice">perUnitPrice.</param>
        /// <param name="perUnitTax">perUnitTax.</param>
        public CreateFulfillmentOrderItem(string sellerSku = default(string), string sellerFulfillmentOrderItemId = default(string), int quantity = default(int), string giftMessage = default(string), string displayableComment = default(string), string fulfillmentNetworkSku = default(string), Money perUnitDeclaredValue = default(Money), Money perUnitPrice = default(Money), Money perUnitTax = default(Money))
        {
            // to ensure "sellerSku" is required (not null)
            if (sellerSku == null)
            {
                throw new ArgumentNullException("sellerSku is a required property for CreateFulfillmentOrderItem and cannot be null");
            }
            this.SellerSku = sellerSku;
            // to ensure "sellerFulfillmentOrderItemId" is required (not null)
            if (sellerFulfillmentOrderItemId == null)
            {
                throw new ArgumentNullException("sellerFulfillmentOrderItemId is a required property for CreateFulfillmentOrderItem and cannot be null");
            }
            this.SellerFulfillmentOrderItemId = sellerFulfillmentOrderItemId;
            this.Quantity = quantity;
            this.GiftMessage = giftMessage;
            this.DisplayableComment = displayableComment;
            this.FulfillmentNetworkSku = fulfillmentNetworkSku;
            this.PerUnitDeclaredValue = perUnitDeclaredValue;
            this.PerUnitPrice = perUnitPrice;
            this.PerUnitTax = perUnitTax;
        }

        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "sellerSku", IsRequired = true, EmitDefaultValue = true)]
        public string SellerSku { get; set; }

        /// <summary>
        /// A fulfillment order item identifier that the seller creates to track fulfillment order items. Used to disambiguate multiple fulfillment items that have the same &#x60;SellerSKU&#x60;. For example, the seller might assign different &#x60;SellerFulfillmentOrderItemId&#x60; values to two items in a fulfillment order that share the same &#x60;SellerSKU&#x60; but have different &#x60;GiftMessage&#x60; values.
        /// </summary>
        /// <value>A fulfillment order item identifier that the seller creates to track fulfillment order items. Used to disambiguate multiple fulfillment items that have the same &#x60;SellerSKU&#x60;. For example, the seller might assign different &#x60;SellerFulfillmentOrderItemId&#x60; values to two items in a fulfillment order that share the same &#x60;SellerSKU&#x60; but have different &#x60;GiftMessage&#x60; values.</value>
        [DataMember(Name = "sellerFulfillmentOrderItemId", IsRequired = true, EmitDefaultValue = true)]
        public string SellerFulfillmentOrderItemId { get; set; }

        /// <summary>
        /// The item quantity.
        /// </summary>
        /// <value>The item quantity.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// A message to the gift recipient, if applicable.
        /// </summary>
        /// <value>A message to the gift recipient, if applicable.</value>
        [DataMember(Name = "giftMessage", EmitDefaultValue = false)]
        public string GiftMessage { get; set; }

        /// <summary>
        /// Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.
        /// </summary>
        /// <value>Item-specific text that displays in recipient-facing materials such as the outbound shipment packing slip.</value>
        [DataMember(Name = "displayableComment", EmitDefaultValue = false)]
        public string DisplayableComment { get; set; }

        /// <summary>
        /// Amazon&#39;s fulfillment network SKU of the item.
        /// </summary>
        /// <value>Amazon&#39;s fulfillment network SKU of the item.</value>
        [DataMember(Name = "fulfillmentNetworkSku", EmitDefaultValue = false)]
        public string FulfillmentNetworkSku { get; set; }

        /// <summary>
        /// Gets or Sets PerUnitDeclaredValue
        /// </summary>
        [DataMember(Name = "perUnitDeclaredValue", EmitDefaultValue = false)]
        public Money PerUnitDeclaredValue { get; set; }

        /// <summary>
        /// Gets or Sets PerUnitPrice
        /// </summary>
        [DataMember(Name = "perUnitPrice", EmitDefaultValue = false)]
        public Money PerUnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets PerUnitTax
        /// </summary>
        [DataMember(Name = "perUnitTax", EmitDefaultValue = false)]
        public Money PerUnitTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFulfillmentOrderItem {\n");
            sb.Append("  SellerSku: ").Append(SellerSku).Append("\n");
            sb.Append("  SellerFulfillmentOrderItemId: ").Append(SellerFulfillmentOrderItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  GiftMessage: ").Append(GiftMessage).Append("\n");
            sb.Append("  DisplayableComment: ").Append(DisplayableComment).Append("\n");
            sb.Append("  FulfillmentNetworkSku: ").Append(FulfillmentNetworkSku).Append("\n");
            sb.Append("  PerUnitDeclaredValue: ").Append(PerUnitDeclaredValue).Append("\n");
            sb.Append("  PerUnitPrice: ").Append(PerUnitPrice).Append("\n");
            sb.Append("  PerUnitTax: ").Append(PerUnitTax).Append("\n");
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
            // SellerSku (string) maxLength
            if (this.SellerSku != null && this.SellerSku.Length > 50)
            {
                yield return new ValidationResult("Invalid value for SellerSku, length must be less than 50.", new [] { "SellerSku" });
            }

            // SellerFulfillmentOrderItemId (string) maxLength
            if (this.SellerFulfillmentOrderItemId != null && this.SellerFulfillmentOrderItemId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for SellerFulfillmentOrderItemId, length must be less than 50.", new [] { "SellerFulfillmentOrderItemId" });
            }

            // GiftMessage (string) maxLength
            if (this.GiftMessage != null && this.GiftMessage.Length > 512)
            {
                yield return new ValidationResult("Invalid value for GiftMessage, length must be less than 512.", new [] { "GiftMessage" });
            }

            // DisplayableComment (string) maxLength
            if (this.DisplayableComment != null && this.DisplayableComment.Length > 250)
            {
                yield return new ValidationResult("Invalid value for DisplayableComment, length must be less than 250.", new [] { "DisplayableComment" });
            }

            yield break;
        }
    }

}

/*
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * The version of the OpenAPI document: 2021-12-28
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/df/shipping/v2021_12_28
{
    /// <summary>
    /// Details of the item being shipped.
    /// </summary>
    [DataContract(Name = "Item")]
    public partial class Item : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="itemSequenceNumber">The sequence number of the item. The number must be the same as the order number of the item. (required).</param>
        /// <param name="buyerProductIdentifier">The buyer&#39;s Amazon Standard Identification Number (ASIN) of an item. Either &#x60;buyerProductIdentifier&#x60; or &#x60;vendorProductIdentifier&#x60; is required..</param>
        /// <param name="vendorProductIdentifier">An item&#39;s product identifier, which the vendor selects. This identifier should be the same as the identifier, such as a SKU, in the purchase order..</param>
        /// <param name="shippedQuantity">shippedQuantity (required).</param>
        public Item(int itemSequenceNumber = default(int), string buyerProductIdentifier = default(string), string vendorProductIdentifier = default(string), ItemQuantity shippedQuantity = default(ItemQuantity))
        {
            this.ItemSequenceNumber = itemSequenceNumber;
            // to ensure "shippedQuantity" is required (not null)
            if (shippedQuantity == null)
            {
                throw new ArgumentNullException("shippedQuantity is a required property for Item and cannot be null");
            }
            this.ShippedQuantity = shippedQuantity;
            this.BuyerProductIdentifier = buyerProductIdentifier;
            this.VendorProductIdentifier = vendorProductIdentifier;
        }

        /// <summary>
        /// The sequence number of the item. The number must be the same as the order number of the item.
        /// </summary>
        /// <value>The sequence number of the item. The number must be the same as the order number of the item.</value>
        [DataMember(Name = "itemSequenceNumber", IsRequired = true, EmitDefaultValue = true)]
        public int ItemSequenceNumber { get; set; }

        /// <summary>
        /// The buyer&#39;s Amazon Standard Identification Number (ASIN) of an item. Either &#x60;buyerProductIdentifier&#x60; or &#x60;vendorProductIdentifier&#x60; is required.
        /// </summary>
        /// <value>The buyer&#39;s Amazon Standard Identification Number (ASIN) of an item. Either &#x60;buyerProductIdentifier&#x60; or &#x60;vendorProductIdentifier&#x60; is required.</value>
        [DataMember(Name = "buyerProductIdentifier", EmitDefaultValue = false)]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        /// An item&#39;s product identifier, which the vendor selects. This identifier should be the same as the identifier, such as a SKU, in the purchase order.
        /// </summary>
        /// <value>An item&#39;s product identifier, which the vendor selects. This identifier should be the same as the identifier, such as a SKU, in the purchase order.</value>
        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ShippedQuantity
        /// </summary>
        [DataMember(Name = "shippedQuantity", IsRequired = true, EmitDefaultValue = true)]
        public ItemQuantity ShippedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  ItemSequenceNumber: ").Append(ItemSequenceNumber).Append("\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  ShippedQuantity: ").Append(ShippedQuantity).Append("\n");
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

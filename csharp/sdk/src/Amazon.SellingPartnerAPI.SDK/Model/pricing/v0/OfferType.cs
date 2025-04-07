/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/pricing/v0
{
    /// <summary>
    /// Schema for an individual offer.
    /// </summary>
    [DataContract(Name = "OfferType")]
    public partial class OfferType : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VarOfferType
        /// </summary>
        [DataMember(Name = "offerType", EmitDefaultValue = false)]
        public OfferCustomerType? VarOfferType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferType" /> class.
        /// </summary>
        /// <param name="varOfferType">varOfferType.</param>
        /// <param name="buyingPrice">buyingPrice (required).</param>
        /// <param name="regularPrice">regularPrice (required).</param>
        /// <param name="businessPrice">businessPrice.</param>
        /// <param name="quantityDiscountPrices">List of &#x60;QuantityDiscountPrice&#x60; that contains item&#39;s pricing information when buy in bulk..</param>
        /// <param name="fulfillmentChannel">The fulfillment channel for the offer listing. Possible values:  * Amazon - Fulfilled by Amazon. * Merchant - Fulfilled by the seller. (required).</param>
        /// <param name="itemCondition">The item condition for the offer listing. Possible values: New, Used, Collectible, Refurbished, or Club. (required).</param>
        /// <param name="itemSubCondition">The item subcondition for the offer listing. Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other. (required).</param>
        /// <param name="sellerSKU">The seller stock keeping unit (SKU) of the item. (required).</param>
        public OfferType(OfferCustomerType? varOfferType = default(OfferCustomerType?), PriceType buyingPrice = default(PriceType), MoneyType regularPrice = default(MoneyType), MoneyType businessPrice = default(MoneyType), List<QuantityDiscountPriceType> quantityDiscountPrices = default(List<QuantityDiscountPriceType>), string fulfillmentChannel = default(string), string itemCondition = default(string), string itemSubCondition = default(string), string sellerSKU = default(string))
        {
            // to ensure "buyingPrice" is required (not null)
            if (buyingPrice == null)
            {
                throw new ArgumentNullException("buyingPrice is a required property for OfferType and cannot be null");
            }
            this.BuyingPrice = buyingPrice;
            // to ensure "regularPrice" is required (not null)
            if (regularPrice == null)
            {
                throw new ArgumentNullException("regularPrice is a required property for OfferType and cannot be null");
            }
            this.RegularPrice = regularPrice;
            // to ensure "fulfillmentChannel" is required (not null)
            if (fulfillmentChannel == null)
            {
                throw new ArgumentNullException("fulfillmentChannel is a required property for OfferType and cannot be null");
            }
            this.FulfillmentChannel = fulfillmentChannel;
            // to ensure "itemCondition" is required (not null)
            if (itemCondition == null)
            {
                throw new ArgumentNullException("itemCondition is a required property for OfferType and cannot be null");
            }
            this.ItemCondition = itemCondition;
            // to ensure "itemSubCondition" is required (not null)
            if (itemSubCondition == null)
            {
                throw new ArgumentNullException("itemSubCondition is a required property for OfferType and cannot be null");
            }
            this.ItemSubCondition = itemSubCondition;
            // to ensure "sellerSKU" is required (not null)
            if (sellerSKU == null)
            {
                throw new ArgumentNullException("sellerSKU is a required property for OfferType and cannot be null");
            }
            this.SellerSKU = sellerSKU;
            this.VarOfferType = varOfferType;
            this.BusinessPrice = businessPrice;
            this.QuantityDiscountPrices = quantityDiscountPrices;
        }

        /// <summary>
        /// Gets or Sets BuyingPrice
        /// </summary>
        [DataMember(Name = "BuyingPrice", IsRequired = true, EmitDefaultValue = true)]
        public PriceType BuyingPrice { get; set; }

        /// <summary>
        /// Gets or Sets RegularPrice
        /// </summary>
        [DataMember(Name = "RegularPrice", IsRequired = true, EmitDefaultValue = true)]
        public MoneyType RegularPrice { get; set; }

        /// <summary>
        /// Gets or Sets BusinessPrice
        /// </summary>
        [DataMember(Name = "businessPrice", EmitDefaultValue = false)]
        public MoneyType BusinessPrice { get; set; }

        /// <summary>
        /// List of &#x60;QuantityDiscountPrice&#x60; that contains item&#39;s pricing information when buy in bulk.
        /// </summary>
        /// <value>List of &#x60;QuantityDiscountPrice&#x60; that contains item&#39;s pricing information when buy in bulk.</value>
        [DataMember(Name = "quantityDiscountPrices", EmitDefaultValue = false)]
        public List<QuantityDiscountPriceType> QuantityDiscountPrices { get; set; }

        /// <summary>
        /// The fulfillment channel for the offer listing. Possible values:  * Amazon - Fulfilled by Amazon. * Merchant - Fulfilled by the seller.
        /// </summary>
        /// <value>The fulfillment channel for the offer listing. Possible values:  * Amazon - Fulfilled by Amazon. * Merchant - Fulfilled by the seller.</value>
        [DataMember(Name = "FulfillmentChannel", IsRequired = true, EmitDefaultValue = true)]
        public string FulfillmentChannel { get; set; }

        /// <summary>
        /// The item condition for the offer listing. Possible values: New, Used, Collectible, Refurbished, or Club.
        /// </summary>
        /// <value>The item condition for the offer listing. Possible values: New, Used, Collectible, Refurbished, or Club.</value>
        [DataMember(Name = "ItemCondition", IsRequired = true, EmitDefaultValue = true)]
        public string ItemCondition { get; set; }

        /// <summary>
        /// The item subcondition for the offer listing. Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other.
        /// </summary>
        /// <value>The item subcondition for the offer listing. Possible values: New, Mint, Very Good, Good, Acceptable, Poor, Club, OEM, Warranty, Refurbished Warranty, Refurbished, Open Box, or Other.</value>
        [DataMember(Name = "ItemSubCondition", IsRequired = true, EmitDefaultValue = true)]
        public string ItemSubCondition { get; set; }

        /// <summary>
        /// The seller stock keeping unit (SKU) of the item.
        /// </summary>
        /// <value>The seller stock keeping unit (SKU) of the item.</value>
        [DataMember(Name = "SellerSKU", IsRequired = true, EmitDefaultValue = true)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferType {\n");
            sb.Append("  VarOfferType: ").Append(VarOfferType).Append("\n");
            sb.Append("  BuyingPrice: ").Append(BuyingPrice).Append("\n");
            sb.Append("  RegularPrice: ").Append(RegularPrice).Append("\n");
            sb.Append("  BusinessPrice: ").Append(BusinessPrice).Append("\n");
            sb.Append("  QuantityDiscountPrices: ").Append(QuantityDiscountPrices).Append("\n");
            sb.Append("  FulfillmentChannel: ").Append(FulfillmentChannel).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
            sb.Append("  ItemSubCondition: ").Append(ItemSubCondition).Append("\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
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

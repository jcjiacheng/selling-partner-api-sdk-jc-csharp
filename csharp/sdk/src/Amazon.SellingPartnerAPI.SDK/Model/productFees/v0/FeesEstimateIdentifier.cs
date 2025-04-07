/*
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/productFees/v0
{
    /// <summary>
    /// An item identifier, marketplace, time of request, and other details that identify an estimate.
    /// </summary>
    [DataContract(Name = "FeesEstimateIdentifier")]
    public partial class FeesEstimateIdentifier : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets IdType
        /// </summary>
        [DataMember(Name = "IdType", EmitDefaultValue = false)]
        public IdType? IdType { get; set; }

        /// <summary>
        /// Gets or Sets OptionalFulfillmentProgram
        /// </summary>
        [DataMember(Name = "OptionalFulfillmentProgram", EmitDefaultValue = false)]
        public OptionalFulfillmentProgram? OptionalFulfillmentProgram { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimateIdentifier" /> class.
        /// </summary>
        /// <param name="marketplaceId">A marketplace identifier..</param>
        /// <param name="sellerId">The seller identifier..</param>
        /// <param name="idType">idType.</param>
        /// <param name="idValue">The item identifier..</param>
        /// <param name="isAmazonFulfilled">When true, the offer is fulfilled by Amazon..</param>
        /// <param name="priceToEstimateFees">priceToEstimateFees.</param>
        /// <param name="sellerInputIdentifier">A unique identifier provided by the caller to track this request..</param>
        /// <param name="optionalFulfillmentProgram">optionalFulfillmentProgram.</param>
        public FeesEstimateIdentifier(string marketplaceId = default(string), string sellerId = default(string), IdType? idType = default(IdType?), string idValue = default(string), bool isAmazonFulfilled = default(bool), PriceToEstimateFees priceToEstimateFees = default(PriceToEstimateFees), string sellerInputIdentifier = default(string), OptionalFulfillmentProgram? optionalFulfillmentProgram = default(OptionalFulfillmentProgram?))
        {
            this.MarketplaceId = marketplaceId;
            this.SellerId = sellerId;
            this.IdType = idType;
            this.IdValue = idValue;
            this.IsAmazonFulfilled = isAmazonFulfilled;
            this.PriceToEstimateFees = priceToEstimateFees;
            this.SellerInputIdentifier = sellerInputIdentifier;
            this.OptionalFulfillmentProgram = optionalFulfillmentProgram;
        }

        /// <summary>
        /// A marketplace identifier.
        /// </summary>
        /// <value>A marketplace identifier.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The seller identifier.
        /// </summary>
        /// <value>The seller identifier.</value>
        [DataMember(Name = "SellerId", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// The item identifier.
        /// </summary>
        /// <value>The item identifier.</value>
        [DataMember(Name = "IdValue", EmitDefaultValue = false)]
        public string IdValue { get; set; }

        /// <summary>
        /// When true, the offer is fulfilled by Amazon.
        /// </summary>
        /// <value>When true, the offer is fulfilled by Amazon.</value>
        [DataMember(Name = "IsAmazonFulfilled", EmitDefaultValue = true)]
        public bool IsAmazonFulfilled { get; set; }

        /// <summary>
        /// Gets or Sets PriceToEstimateFees
        /// </summary>
        [DataMember(Name = "PriceToEstimateFees", EmitDefaultValue = false)]
        public PriceToEstimateFees PriceToEstimateFees { get; set; }

        /// <summary>
        /// A unique identifier provided by the caller to track this request.
        /// </summary>
        /// <value>A unique identifier provided by the caller to track this request.</value>
        [DataMember(Name = "SellerInputIdentifier", EmitDefaultValue = false)]
        public string SellerInputIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeesEstimateIdentifier {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  IdValue: ").Append(IdValue).Append("\n");
            sb.Append("  IsAmazonFulfilled: ").Append(IsAmazonFulfilled).Append("\n");
            sb.Append("  PriceToEstimateFees: ").Append(PriceToEstimateFees).Append("\n");
            sb.Append("  SellerInputIdentifier: ").Append(SellerInputIdentifier).Append("\n");
            sb.Append("  OptionalFulfillmentProgram: ").Append(OptionalFulfillmentProgram).Append("\n");
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

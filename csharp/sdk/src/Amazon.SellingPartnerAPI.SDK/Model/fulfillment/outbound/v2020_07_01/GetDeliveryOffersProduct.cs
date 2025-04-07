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
    /// The product details for the delivery offer.
    /// </summary>
    [DataContract(Name = "GetDeliveryOffersProduct")]
    public partial class GetDeliveryOffersProduct : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOffersProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDeliveryOffersProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeliveryOffersProduct" /> class.
        /// </summary>
        /// <param name="productIdentifier">productIdentifier (required).</param>
        /// <param name="amount">amount.</param>
        public GetDeliveryOffersProduct(ProductIdentifier productIdentifier = default(ProductIdentifier), Amount amount = default(Amount))
        {
            // to ensure "productIdentifier" is required (not null)
            if (productIdentifier == null)
            {
                throw new ArgumentNullException("productIdentifier is a required property for GetDeliveryOffersProduct and cannot be null");
            }
            this.ProductIdentifier = productIdentifier;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or Sets ProductIdentifier
        /// </summary>
        [DataMember(Name = "productIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public ProductIdentifier ProductIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDeliveryOffersProduct {\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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

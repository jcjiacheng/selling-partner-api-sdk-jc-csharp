/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer pricing information for Amazon Marketplace products.  For more information, refer to the [Product Pricing v2022-05-01 Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/product-pricing-api-v2022-05-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2022-05-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/pricing/v2022_05_01
{
    /// <summary>
    /// The item price at or below which the target offer may be featured.
    /// </summary>
    [DataContract(Name = "FeaturedOfferExpectedPrice")]
    public partial class FeaturedOfferExpectedPrice : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturedOfferExpectedPrice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeaturedOfferExpectedPrice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturedOfferExpectedPrice" /> class.
        /// </summary>
        /// <param name="listingPrice">listingPrice (required).</param>
        /// <param name="points">points.</param>
        public FeaturedOfferExpectedPrice(MoneyType listingPrice = default(MoneyType), Points points = default(Points))
        {
            // to ensure "listingPrice" is required (not null)
            if (listingPrice == null)
            {
                throw new ArgumentNullException("listingPrice is a required property for FeaturedOfferExpectedPrice and cannot be null");
            }
            this.ListingPrice = listingPrice;
            this.Points = points;
        }

        /// <summary>
        /// Gets or Sets ListingPrice
        /// </summary>
        [DataMember(Name = "listingPrice", IsRequired = true, EmitDefaultValue = true)]
        public MoneyType ListingPrice { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name = "points", EmitDefaultValue = false)]
        public Points Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FeaturedOfferExpectedPrice {\n");
            sb.Append("  ListingPrice: ").Append(ListingPrice).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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

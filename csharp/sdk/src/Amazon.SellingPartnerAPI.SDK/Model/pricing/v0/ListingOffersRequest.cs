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
    /// List of request parameters that can be accepted by &#x60;ListingOffersRequest&#x60; operation
    /// </summary>
    [DataContract(Name = "ListingOffersRequest")]
    public partial class ListingOffersRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets ItemCondition
        /// </summary>
        [DataMember(Name = "ItemCondition", IsRequired = true, EmitDefaultValue = true)]
        public ItemCondition ItemCondition { get; set; }

        /// <summary>
        /// Gets or Sets CustomerType
        /// </summary>
        [DataMember(Name = "CustomerType", EmitDefaultValue = false)]
        public CustomerType? CustomerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingOffersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListingOffersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingOffersRequest" /> class.
        /// </summary>
        /// <param name="uri">The resource path of the operation you are calling in batch without any query parameters.  If you are calling &#x60;getItemOffersBatch&#x60;, supply the path of &#x60;getItemOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/items/B000P6Q7MY/offers&#x60;  If you are calling &#x60;getListingOffersBatch&#x60;, supply the path of &#x60;getListingOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/listings/B000P6Q7MY/offers&#x60; (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="headers">A mapping of additional HTTP headers to send/receive for the individual batch request..</param>
        /// <param name="marketplaceId">A marketplace identifier. Specifies the marketplace for which prices are returned. (required).</param>
        /// <param name="itemCondition">itemCondition (required).</param>
        /// <param name="customerType">customerType.</param>
        public ListingOffersRequest(string uri = default(string), HttpMethod method = default(HttpMethod), Dictionary<string, string> headers = default(Dictionary<string, string>), string marketplaceId = default(string), ItemCondition itemCondition = default(ItemCondition), CustomerType? customerType = default(CustomerType?))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for ListingOffersRequest and cannot be null");
            }
            this.Uri = uri;
            this.Method = method;
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new ArgumentNullException("marketplaceId is a required property for ListingOffersRequest and cannot be null");
            }
            this.MarketplaceId = marketplaceId;
            this.ItemCondition = itemCondition;
            this.Headers = headers;
            this.CustomerType = customerType;
        }

        /// <summary>
        /// The resource path of the operation you are calling in batch without any query parameters.  If you are calling &#x60;getItemOffersBatch&#x60;, supply the path of &#x60;getItemOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/items/B000P6Q7MY/offers&#x60;  If you are calling &#x60;getListingOffersBatch&#x60;, supply the path of &#x60;getListingOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/listings/B000P6Q7MY/offers&#x60;
        /// </summary>
        /// <value>The resource path of the operation you are calling in batch without any query parameters.  If you are calling &#x60;getItemOffersBatch&#x60;, supply the path of &#x60;getItemOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/items/B000P6Q7MY/offers&#x60;  If you are calling &#x60;getListingOffersBatch&#x60;, supply the path of &#x60;getListingOffers&#x60;.  **Example:** &#x60;/products/pricing/v0/listings/B000P6Q7MY/offers&#x60;</value>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// A mapping of additional HTTP headers to send/receive for the individual batch request.
        /// </summary>
        /// <value>A mapping of additional HTTP headers to send/receive for the individual batch request.</value>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// A marketplace identifier. Specifies the marketplace for which prices are returned.
        /// </summary>
        /// <value>A marketplace identifier. Specifies the marketplace for which prices are returned.</value>
        [DataMember(Name = "MarketplaceId", IsRequired = true, EmitDefaultValue = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListingOffersRequest {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  ItemCondition: ").Append(ItemCondition).Append("\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
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

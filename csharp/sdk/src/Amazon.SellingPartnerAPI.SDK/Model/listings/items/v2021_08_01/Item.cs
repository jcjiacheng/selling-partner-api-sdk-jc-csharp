/*
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/listings-items-api-v2021-08-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2021-08-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/listings/items/v2021_08_01
{
    /// <summary>
    /// A listings item.
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
        /// <param name="sku">A selling partner provided identifier for an Amazon listing. (required).</param>
        /// <param name="summaries">Summary details of a listings item..</param>
        /// <param name="attributes">A JSON object containing structured listings item attribute data keyed by attribute name..</param>
        /// <param name="issues">The issues associated with the listings item..</param>
        /// <param name="offers">Offer details for the listings item..</param>
        /// <param name="fulfillmentAvailability">The fulfillment availability for the listings item..</param>
        /// <param name="procurement">The vendor procurement information for the listings item..</param>
        /// <param name="relationships">Relationships for a listing item, by marketplace (for example, variations)..</param>
        /// <param name="productTypes">Product types for a listing item, by marketplace..</param>
        public Item(string sku = default(string), List<ItemSummaryByMarketplace> summaries = default(List<ItemSummaryByMarketplace>), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), List<Issue> issues = default(List<Issue>), List<ItemOfferByMarketplace> offers = default(List<ItemOfferByMarketplace>), List<FulfillmentAvailability> fulfillmentAvailability = default(List<FulfillmentAvailability>), List<ItemProcurement> procurement = default(List<ItemProcurement>), List<ItemRelationshipsByMarketplace> relationships = default(List<ItemRelationshipsByMarketplace>), List<ItemProductTypeByMarketplace> productTypes = default(List<ItemProductTypeByMarketplace>))
        {
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new ArgumentNullException("sku is a required property for Item and cannot be null");
            }
            this.Sku = sku;
            this.Summaries = summaries;
            this.Attributes = attributes;
            this.Issues = issues;
            this.Offers = offers;
            this.FulfillmentAvailability = fulfillmentAvailability;
            this.Procurement = procurement;
            this.Relationships = relationships;
            this.ProductTypes = productTypes;
        }

        /// <summary>
        /// A selling partner provided identifier for an Amazon listing.
        /// </summary>
        /// <value>A selling partner provided identifier for an Amazon listing.</value>
        [DataMember(Name = "sku", IsRequired = true, EmitDefaultValue = true)]
        public string Sku { get; set; }

        /// <summary>
        /// Summary details of a listings item.
        /// </summary>
        /// <value>Summary details of a listings item.</value>
        [DataMember(Name = "summaries", EmitDefaultValue = false)]
        public List<ItemSummaryByMarketplace> Summaries { get; set; }

        /// <summary>
        /// A JSON object containing structured listings item attribute data keyed by attribute name.
        /// </summary>
        /// <value>A JSON object containing structured listings item attribute data keyed by attribute name.</value>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// The issues associated with the listings item.
        /// </summary>
        /// <value>The issues associated with the listings item.</value>
        [DataMember(Name = "issues", EmitDefaultValue = false)]
        public List<Issue> Issues { get; set; }

        /// <summary>
        /// Offer details for the listings item.
        /// </summary>
        /// <value>Offer details for the listings item.</value>
        [DataMember(Name = "offers", EmitDefaultValue = false)]
        public List<ItemOfferByMarketplace> Offers { get; set; }

        /// <summary>
        /// The fulfillment availability for the listings item.
        /// </summary>
        /// <value>The fulfillment availability for the listings item.</value>
        [DataMember(Name = "fulfillmentAvailability", EmitDefaultValue = false)]
        public List<FulfillmentAvailability> FulfillmentAvailability { get; set; }

        /// <summary>
        /// The vendor procurement information for the listings item.
        /// </summary>
        /// <value>The vendor procurement information for the listings item.</value>
        [DataMember(Name = "procurement", EmitDefaultValue = false)]
        public List<ItemProcurement> Procurement { get; set; }

        /// <summary>
        /// Relationships for a listing item, by marketplace (for example, variations).
        /// </summary>
        /// <value>Relationships for a listing item, by marketplace (for example, variations).</value>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        public List<ItemRelationshipsByMarketplace> Relationships { get; set; }

        /// <summary>
        /// Product types for a listing item, by marketplace.
        /// </summary>
        /// <value>Product types for a listing item, by marketplace.</value>
        [DataMember(Name = "productTypes", EmitDefaultValue = false)]
        public List<ItemProductTypeByMarketplace> ProductTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Issues: ").Append(Issues).Append("\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
            sb.Append("  FulfillmentAvailability: ").Append(FulfillmentAvailability).Append("\n");
            sb.Append("  Procurement: ").Append(Procurement).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  ProductTypes: ").Append(ProductTypes).Append("\n");
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

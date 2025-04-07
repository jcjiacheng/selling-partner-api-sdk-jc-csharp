/*
 * Selling Partner API for Catalog Items
 *
 * Use the Selling Partner API for Catalog Items to retrieve information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2022-04-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/catalogItems/v2022_04_01
{
    /// <summary>
    /// Classifications (browse nodes) that are associated with the item in the Amazon catalog for the indicated &#x60;marketplaceId&#x60;.
    /// </summary>
    [DataContract(Name = "ItemBrowseClassificationsByMarketplace")]
    public partial class ItemBrowseClassificationsByMarketplace : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBrowseClassificationsByMarketplace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemBrowseClassificationsByMarketplace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBrowseClassificationsByMarketplace" /> class.
        /// </summary>
        /// <param name="marketplaceId">Amazon marketplace identifier. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids). (required).</param>
        /// <param name="classifications">Classifications (browse nodes) that are associated with the item in the Amazon catalog..</param>
        public ItemBrowseClassificationsByMarketplace(string marketplaceId = default(string), List<ItemBrowseClassification> classifications = default(List<ItemBrowseClassification>))
        {
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new ArgumentNullException("marketplaceId is a required property for ItemBrowseClassificationsByMarketplace and cannot be null");
            }
            this.MarketplaceId = marketplaceId;
            this.Classifications = classifications;
        }

        /// <summary>
        /// Amazon marketplace identifier. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).
        /// </summary>
        /// <value>Amazon marketplace identifier. To find the ID for your marketplace, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/marketplace-ids).</value>
        [DataMember(Name = "marketplaceId", IsRequired = true, EmitDefaultValue = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Classifications (browse nodes) that are associated with the item in the Amazon catalog.
        /// </summary>
        /// <value>Classifications (browse nodes) that are associated with the item in the Amazon catalog.</value>
        [DataMember(Name = "classifications", EmitDefaultValue = false)]
        public List<ItemBrowseClassification> Classifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemBrowseClassificationsByMarketplace {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
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

/*
 * Selling Partner API for Direct Fulfillment Inventory Updates
 *
 * The Selling Partner API for Direct Fulfillment Inventory Updates provides programmatic access to a direct fulfillment vendor's inventory updates.
 *
 * The version of the OpenAPI document: v1
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/df/inventory/v1
{
    /// <summary>
    /// Updated inventory details for an item.
    /// </summary>
    [DataContract(Name = "ItemDetails")]
    public partial class ItemDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDetails" /> class.
        /// </summary>
        /// <param name="buyerProductIdentifier">The buyer selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifier should be submitted..</param>
        /// <param name="vendorProductIdentifier">The vendor selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifier should be submitted..</param>
        /// <param name="availableQuantity">availableQuantity (required).</param>
        /// <param name="isObsolete">When true, the item is permanently unavailable..</param>
        public ItemDetails(string buyerProductIdentifier = default(string), string vendorProductIdentifier = default(string), ItemQuantity availableQuantity = default(ItemQuantity), bool isObsolete = default(bool))
        {
            // to ensure "availableQuantity" is required (not null)
            if (availableQuantity == null)
            {
                throw new ArgumentNullException("availableQuantity is a required property for ItemDetails and cannot be null");
            }
            this.AvailableQuantity = availableQuantity;
            this.BuyerProductIdentifier = buyerProductIdentifier;
            this.VendorProductIdentifier = vendorProductIdentifier;
            this.IsObsolete = isObsolete;
        }

        /// <summary>
        /// The buyer selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifier should be submitted.
        /// </summary>
        /// <value>The buyer selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifier should be submitted.</value>
        [DataMember(Name = "buyerProductIdentifier", EmitDefaultValue = false)]
        public string BuyerProductIdentifier { get; set; }

        /// <summary>
        /// The vendor selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifier should be submitted.
        /// </summary>
        /// <value>The vendor selected product identification of the item. Either buyerProductIdentifier or vendorProductIdentifier should be submitted.</value>
        [DataMember(Name = "vendorProductIdentifier", EmitDefaultValue = false)]
        public string VendorProductIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AvailableQuantity
        /// </summary>
        [DataMember(Name = "availableQuantity", IsRequired = true, EmitDefaultValue = true)]
        public ItemQuantity AvailableQuantity { get; set; }

        /// <summary>
        /// When true, the item is permanently unavailable.
        /// </summary>
        /// <value>When true, the item is permanently unavailable.</value>
        [DataMember(Name = "isObsolete", EmitDefaultValue = true)]
        public bool IsObsolete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemDetails {\n");
            sb.Append("  BuyerProductIdentifier: ").Append(BuyerProductIdentifier).Append("\n");
            sb.Append("  VendorProductIdentifier: ").Append(VendorProductIdentifier).Append("\n");
            sb.Append("  AvailableQuantity: ").Append(AvailableQuantity).Append("\n");
            sb.Append("  IsObsolete: ").Append(IsObsolete).Append("\n");
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

/*
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * The version of the OpenAPI document: 2024-03-20
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v2024_03_20
{
    /// <summary>
    /// Information associated with a single SKU in the seller&#39;s catalog.
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
        /// <param name="asin">The Amazon Standard Identification Number (ASIN) of the item. (required).</param>
        /// <param name="expiration">The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern&#x60;YYYY-MM-DD&#x60;. The same MSKU with different expiration dates cannot go into the same box..</param>
        /// <param name="fnsku">A unique identifier assigned by Amazon to products stored in and fulfilled from an Amazon fulfillment center. (required).</param>
        /// <param name="labelOwner">Specifies who will label the items. Options include &#x60;AMAZON&#x60;, &#x60;SELLER&#x60;, and &#x60;NONE&#x60;. (required).</param>
        /// <param name="manufacturingLotCode">The manufacturing lot code..</param>
        /// <param name="msku">The merchant SKU, a merchant-supplied identifier of a specific SKU. (required).</param>
        /// <param name="prepInstructions">Special preparations that are required for an item. (required).</param>
        /// <param name="quantity">The number of the specified MSKU. (required).</param>
        public Item(string asin = default(string), string expiration = default(string), string fnsku = default(string), string labelOwner = default(string), string manufacturingLotCode = default(string), string msku = default(string), List<PrepInstruction> prepInstructions = default(List<PrepInstruction>), int quantity = default(int))
        {
            // to ensure "asin" is required (not null)
            if (asin == null)
            {
                throw new ArgumentNullException("asin is a required property for Item and cannot be null");
            }
            this.Asin = asin;
            // to ensure "fnsku" is required (not null)
            if (fnsku == null)
            {
                throw new ArgumentNullException("fnsku is a required property for Item and cannot be null");
            }
            this.Fnsku = fnsku;
            // to ensure "labelOwner" is required (not null)
            if (labelOwner == null)
            {
                throw new ArgumentNullException("labelOwner is a required property for Item and cannot be null");
            }
            this.LabelOwner = labelOwner;
            // to ensure "msku" is required (not null)
            if (msku == null)
            {
                throw new ArgumentNullException("msku is a required property for Item and cannot be null");
            }
            this.Msku = msku;
            // to ensure "prepInstructions" is required (not null)
            if (prepInstructions == null)
            {
                throw new ArgumentNullException("prepInstructions is a required property for Item and cannot be null");
            }
            this.PrepInstructions = prepInstructions;
            this.Quantity = quantity;
            this.Expiration = expiration;
            this.ManufacturingLotCode = manufacturingLotCode;
        }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "asin", IsRequired = true, EmitDefaultValue = true)]
        public string Asin { get; set; }

        /// <summary>
        /// The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern&#x60;YYYY-MM-DD&#x60;. The same MSKU with different expiration dates cannot go into the same box.
        /// </summary>
        /// <value>The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern&#x60;YYYY-MM-DD&#x60;. The same MSKU with different expiration dates cannot go into the same box.</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public string Expiration { get; set; }

        /// <summary>
        /// A unique identifier assigned by Amazon to products stored in and fulfilled from an Amazon fulfillment center.
        /// </summary>
        /// <value>A unique identifier assigned by Amazon to products stored in and fulfilled from an Amazon fulfillment center.</value>
        [DataMember(Name = "fnsku", IsRequired = true, EmitDefaultValue = true)]
        public string Fnsku { get; set; }

        /// <summary>
        /// Specifies who will label the items. Options include &#x60;AMAZON&#x60;, &#x60;SELLER&#x60;, and &#x60;NONE&#x60;.
        /// </summary>
        /// <value>Specifies who will label the items. Options include &#x60;AMAZON&#x60;, &#x60;SELLER&#x60;, and &#x60;NONE&#x60;.</value>
        [DataMember(Name = "labelOwner", IsRequired = true, EmitDefaultValue = true)]
        public string LabelOwner { get; set; }

        /// <summary>
        /// The manufacturing lot code.
        /// </summary>
        /// <value>The manufacturing lot code.</value>
        [DataMember(Name = "manufacturingLotCode", EmitDefaultValue = false)]
        public string ManufacturingLotCode { get; set; }

        /// <summary>
        /// The merchant SKU, a merchant-supplied identifier of a specific SKU.
        /// </summary>
        /// <value>The merchant SKU, a merchant-supplied identifier of a specific SKU.</value>
        [DataMember(Name = "msku", IsRequired = true, EmitDefaultValue = true)]
        public string Msku { get; set; }

        /// <summary>
        /// Special preparations that are required for an item.
        /// </summary>
        /// <value>Special preparations that are required for an item.</value>
        [DataMember(Name = "prepInstructions", IsRequired = true, EmitDefaultValue = true)]
        public List<PrepInstruction> PrepInstructions { get; set; }

        /// <summary>
        /// The number of the specified MSKU.
        /// </summary>
        /// <value>The number of the specified MSKU.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Asin: ").Append(Asin).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Fnsku: ").Append(Fnsku).Append("\n");
            sb.Append("  LabelOwner: ").Append(LabelOwner).Append("\n");
            sb.Append("  ManufacturingLotCode: ").Append(ManufacturingLotCode).Append("\n");
            sb.Append("  Msku: ").Append(Msku).Append("\n");
            sb.Append("  PrepInstructions: ").Append(PrepInstructions).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            // Asin (string) maxLength
            if (this.Asin != null && this.Asin.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Asin, length must be less than 10.", new [] { "Asin" });
            }

            // Asin (string) minLength
            if (this.Asin != null && this.Asin.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Asin, length must be greater than 1.", new [] { "Asin" });
            }

            if (this.Expiration != null) {
                // Expiration (string) pattern
                Regex regexExpiration = new Regex(@"^([0-9]{4})-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$", RegexOptions.CultureInvariant);
                if (!regexExpiration.Match(this.Expiration).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Expiration, must match a pattern of " + regexExpiration, new [] { "Expiration" });
                }
            }

            // Fnsku (string) maxLength
            if (this.Fnsku != null && this.Fnsku.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Fnsku, length must be less than 10.", new [] { "Fnsku" });
            }

            // Fnsku (string) minLength
            if (this.Fnsku != null && this.Fnsku.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Fnsku, length must be greater than 1.", new [] { "Fnsku" });
            }

            // LabelOwner (string) maxLength
            if (this.LabelOwner != null && this.LabelOwner.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for LabelOwner, length must be less than 1024.", new [] { "LabelOwner" });
            }

            // LabelOwner (string) minLength
            if (this.LabelOwner != null && this.LabelOwner.Length < 1)
            {
                yield return new ValidationResult("Invalid value for LabelOwner, length must be greater than 1.", new [] { "LabelOwner" });
            }

            // ManufacturingLotCode (string) maxLength
            if (this.ManufacturingLotCode != null && this.ManufacturingLotCode.Length > 256)
            {
                yield return new ValidationResult("Invalid value for ManufacturingLotCode, length must be less than 256.", new [] { "ManufacturingLotCode" });
            }

            // ManufacturingLotCode (string) minLength
            if (this.ManufacturingLotCode != null && this.ManufacturingLotCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ManufacturingLotCode, length must be greater than 1.", new [] { "ManufacturingLotCode" });
            }

            // Msku (string) maxLength
            if (this.Msku != null && this.Msku.Length > 40)
            {
                yield return new ValidationResult("Invalid value for Msku, length must be less than 40.", new [] { "Msku" });
            }

            // Msku (string) minLength
            if (this.Msku != null && this.Msku.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Msku, length must be greater than 1.", new [] { "Msku" });
            }

            // Quantity (int) maximum
            if (this.Quantity > (int)10000)
            {
                yield return new ValidationResult("Invalid value for Quantity, must be a value less than or equal to 10000.", new [] { "Quantity" });
            }

            // Quantity (int) minimum
            if (this.Quantity < (int)1)
            {
                yield return new ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}

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
    /// Defines an item&#39;s input parameters.
    /// </summary>
    [DataContract(Name = "ItemInput")]
    public partial class ItemInput : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LabelOwner
        /// </summary>
        [DataMember(Name = "labelOwner", IsRequired = true, EmitDefaultValue = true)]
        public LabelOwner LabelOwner { get; set; }

        /// <summary>
        /// Gets or Sets PrepOwner
        /// </summary>
        [DataMember(Name = "prepOwner", IsRequired = true, EmitDefaultValue = true)]
        public PrepOwner PrepOwner { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemInput" /> class.
        /// </summary>
        /// <param name="expiration">The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;YYYY-MM-DD&#x60;. Items with the same MSKU but different expiration dates cannot go into the same box..</param>
        /// <param name="labelOwner">labelOwner (required).</param>
        /// <param name="manufacturingLotCode">The manufacturing lot code..</param>
        /// <param name="msku">The merchant SKU, a merchant-supplied identifier of a specific SKU. (required).</param>
        /// <param name="prepOwner">prepOwner (required).</param>
        /// <param name="quantity">The number of units of the specified MSKU that will be shipped. (required).</param>
        public ItemInput(string expiration = default(string), LabelOwner labelOwner = default(LabelOwner), string manufacturingLotCode = default(string), string msku = default(string), PrepOwner prepOwner = default(PrepOwner), int quantity = default(int))
        {
            this.LabelOwner = labelOwner;
            // to ensure "msku" is required (not null)
            if (msku == null)
            {
                throw new ArgumentNullException("msku is a required property for ItemInput and cannot be null");
            }
            this.Msku = msku;
            this.PrepOwner = prepOwner;
            this.Quantity = quantity;
            this.Expiration = expiration;
            this.ManufacturingLotCode = manufacturingLotCode;
        }

        /// <summary>
        /// The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;YYYY-MM-DD&#x60;. Items with the same MSKU but different expiration dates cannot go into the same box.
        /// </summary>
        /// <value>The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;YYYY-MM-DD&#x60;. Items with the same MSKU but different expiration dates cannot go into the same box.</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public string Expiration { get; set; }

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
        /// The number of units of the specified MSKU that will be shipped.
        /// </summary>
        /// <value>The number of units of the specified MSKU that will be shipped.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemInput {\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  LabelOwner: ").Append(LabelOwner).Append("\n");
            sb.Append("  ManufacturingLotCode: ").Append(ManufacturingLotCode).Append("\n");
            sb.Append("  Msku: ").Append(Msku).Append("\n");
            sb.Append("  PrepOwner: ").Append(PrepOwner).Append("\n");
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
            if (this.Expiration != null) {
                // Expiration (string) pattern
                Regex regexExpiration = new Regex(@"^([0-9]{4})-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$", RegexOptions.CultureInvariant);
                if (!regexExpiration.Match(this.Expiration).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Expiration, must match a pattern of " + regexExpiration, new [] { "Expiration" });
                }
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

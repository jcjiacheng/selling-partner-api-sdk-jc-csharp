/*
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * The version of the OpenAPI document: 2021-12-28
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/df/shipping/v2021_12_28
{
    /// <summary>
    /// The request body schema for the &#x60;createContainerLabel&#x60; operation.
    /// </summary>
    [DataContract(Name = "CreateContainerLabelRequest")]
    public partial class CreateContainerLabelRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name = "carrierId", IsRequired = true, EmitDefaultValue = true)]
        public CarrierId CarrierId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateContainerLabelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerLabelRequest" /> class.
        /// </summary>
        /// <param name="sellingParty">sellingParty (required).</param>
        /// <param name="shipFromParty">shipFromParty (required).</param>
        /// <param name="carrierId">carrierId (required).</param>
        /// <param name="vendorContainerId">The unique, vendor-provided identifier for the container. (required).</param>
        /// <param name="packages">An array of package objects in a container. (required).</param>
        public CreateContainerLabelRequest(PartyIdentification sellingParty = default(PartyIdentification), PartyIdentification shipFromParty = default(PartyIdentification), CarrierId carrierId = default(CarrierId), string vendorContainerId = default(string), List<Package> packages = default(List<Package>))
        {
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new ArgumentNullException("sellingParty is a required property for CreateContainerLabelRequest and cannot be null");
            }
            this.SellingParty = sellingParty;
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new ArgumentNullException("shipFromParty is a required property for CreateContainerLabelRequest and cannot be null");
            }
            this.ShipFromParty = shipFromParty;
            this.CarrierId = carrierId;
            // to ensure "vendorContainerId" is required (not null)
            if (vendorContainerId == null)
            {
                throw new ArgumentNullException("vendorContainerId is a required property for CreateContainerLabelRequest and cannot be null");
            }
            this.VendorContainerId = vendorContainerId;
            // to ensure "packages" is required (not null)
            if (packages == null)
            {
                throw new ArgumentNullException("packages is a required property for CreateContainerLabelRequest and cannot be null");
            }
            this.Packages = packages;
        }

        /// <summary>
        /// Gets or Sets SellingParty
        /// </summary>
        [DataMember(Name = "sellingParty", IsRequired = true, EmitDefaultValue = true)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// Gets or Sets ShipFromParty
        /// </summary>
        [DataMember(Name = "shipFromParty", IsRequired = true, EmitDefaultValue = true)]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// The unique, vendor-provided identifier for the container.
        /// </summary>
        /// <value>The unique, vendor-provided identifier for the container.</value>
        [DataMember(Name = "vendorContainerId", IsRequired = true, EmitDefaultValue = true)]
        public string VendorContainerId { get; set; }

        /// <summary>
        /// An array of package objects in a container.
        /// </summary>
        /// <value>An array of package objects in a container.</value>
        [DataMember(Name = "packages", IsRequired = true, EmitDefaultValue = true)]
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateContainerLabelRequest {\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  VendorContainerId: ").Append(VendorContainerId).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
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

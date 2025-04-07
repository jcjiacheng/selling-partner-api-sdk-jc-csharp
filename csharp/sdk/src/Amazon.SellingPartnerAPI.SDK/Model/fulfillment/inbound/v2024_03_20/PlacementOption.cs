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
    /// Contains information pertaining to the placement of the contents of an inbound plan and the related costs.
    /// </summary>
    [DataContract(Name = "PlacementOption")]
    public partial class PlacementOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlacementOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlacementOption" /> class.
        /// </summary>
        /// <param name="discounts">Discount for the offered option. (required).</param>
        /// <param name="expiration">The expiration date of the placement option. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;..</param>
        /// <param name="fees">The fee for the offered option. (required).</param>
        /// <param name="placementOptionId">The identifier of a placement option. A placement option represents the shipment splits and destinations of SKUs. (required).</param>
        /// <param name="shipmentIds">Shipment ids. (required).</param>
        /// <param name="status">The status of a placement option. Possible values: &#x60;OFFERED&#x60;, &#x60;ACCEPTED&#x60;, &#x60;EXPIRED&#x60;. (required).</param>
        public PlacementOption(List<Incentive> discounts = default(List<Incentive>), DateTime expiration = default(DateTime), List<Incentive> fees = default(List<Incentive>), string placementOptionId = default(string), List<string> shipmentIds = default(List<string>), string status = default(string))
        {
            // to ensure "discounts" is required (not null)
            if (discounts == null)
            {
                throw new ArgumentNullException("discounts is a required property for PlacementOption and cannot be null");
            }
            this.Discounts = discounts;
            // to ensure "fees" is required (not null)
            if (fees == null)
            {
                throw new ArgumentNullException("fees is a required property for PlacementOption and cannot be null");
            }
            this.Fees = fees;
            // to ensure "placementOptionId" is required (not null)
            if (placementOptionId == null)
            {
                throw new ArgumentNullException("placementOptionId is a required property for PlacementOption and cannot be null");
            }
            this.PlacementOptionId = placementOptionId;
            // to ensure "shipmentIds" is required (not null)
            if (shipmentIds == null)
            {
                throw new ArgumentNullException("shipmentIds is a required property for PlacementOption and cannot be null");
            }
            this.ShipmentIds = shipmentIds;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PlacementOption and cannot be null");
            }
            this.Status = status;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Discount for the offered option.
        /// </summary>
        /// <value>Discount for the offered option.</value>
        [DataMember(Name = "discounts", IsRequired = true, EmitDefaultValue = true)]
        public List<Incentive> Discounts { get; set; }

        /// <summary>
        /// The expiration date of the placement option. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;.
        /// </summary>
        /// <value>The expiration date of the placement option. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ss.sssZ&#x60;.</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public DateTime Expiration { get; set; }

        /// <summary>
        /// The fee for the offered option.
        /// </summary>
        /// <value>The fee for the offered option.</value>
        [DataMember(Name = "fees", IsRequired = true, EmitDefaultValue = true)]
        public List<Incentive> Fees { get; set; }

        /// <summary>
        /// The identifier of a placement option. A placement option represents the shipment splits and destinations of SKUs.
        /// </summary>
        /// <value>The identifier of a placement option. A placement option represents the shipment splits and destinations of SKUs.</value>
        [DataMember(Name = "placementOptionId", IsRequired = true, EmitDefaultValue = true)]
        public string PlacementOptionId { get; set; }

        /// <summary>
        /// Shipment ids.
        /// </summary>
        /// <value>Shipment ids.</value>
        [DataMember(Name = "shipmentIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ShipmentIds { get; set; }

        /// <summary>
        /// The status of a placement option. Possible values: &#x60;OFFERED&#x60;, &#x60;ACCEPTED&#x60;, &#x60;EXPIRED&#x60;.
        /// </summary>
        /// <value>The status of a placement option. Possible values: &#x60;OFFERED&#x60;, &#x60;ACCEPTED&#x60;, &#x60;EXPIRED&#x60;.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlacementOption {\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  PlacementOptionId: ").Append(PlacementOptionId).Append("\n");
            sb.Append("  ShipmentIds: ").Append(ShipmentIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            // PlacementOptionId (string) maxLength
            if (this.PlacementOptionId != null && this.PlacementOptionId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for PlacementOptionId, length must be less than 38.", new [] { "PlacementOptionId" });
            }

            // PlacementOptionId (string) minLength
            if (this.PlacementOptionId != null && this.PlacementOptionId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for PlacementOptionId, length must be greater than 38.", new [] { "PlacementOptionId" });
            }

            if (this.PlacementOptionId != null) {
                // PlacementOptionId (string) pattern
                Regex regexPlacementOptionId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
                if (!regexPlacementOptionId.Match(this.PlacementOptionId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PlacementOptionId, must match a pattern of " + regexPlacementOptionId, new [] { "PlacementOptionId" });
                }
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Status, length must be less than 1024.", new [] { "Status" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }

}

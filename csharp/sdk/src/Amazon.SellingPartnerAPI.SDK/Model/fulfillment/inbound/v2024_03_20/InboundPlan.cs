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
    /// Inbound plan containing details of the inbound workflow.
    /// </summary>
    [DataContract(Name = "InboundPlan")]
    public partial class InboundPlan : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPlan" /> class.
        /// </summary>
        /// <param name="createdAt">The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;. (required).</param>
        /// <param name="inboundPlanId">Identifier of an inbound plan. (required).</param>
        /// <param name="lastUpdatedAt">The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;. (required).</param>
        /// <param name="marketplaceIds">A list of marketplace IDs. (required).</param>
        /// <param name="name">Human-readable name of the inbound plan. (required).</param>
        /// <param name="packingOptions">Packing options for the inbound plan. This property will be populated when it has been generated via the corresponding operation. If there is a chosen placement option, only packing options for that placement option will be returned. If there are confirmed shipments, only packing options for those shipments will be returned. Query the packing option for more details..</param>
        /// <param name="placementOptions">Placement options for the inbound plan. This property will be populated when it has been generated via the corresponding operation. If there is a chosen placement option, that will be the only returned option. Query the placement option for more details..</param>
        /// <param name="shipments">A list of shipment IDs for the inbound plan. This property is populated when it has been generated with the &#x60;confirmPlacementOptions&#x60; operation. Only shipments from the chosen placement option are returned. Query the shipment for more details..</param>
        /// <param name="sourceAddress">sourceAddress (required).</param>
        /// <param name="status">Current status of the inbound plan. Possible values: &#x60;ACTIVE&#x60;, &#x60;VOIDED&#x60;, &#x60;SHIPPED&#x60;, &#x60;ERRORED&#x60;. (required).</param>
        public InboundPlan(DateTime createdAt = default(DateTime), string inboundPlanId = default(string), DateTime lastUpdatedAt = default(DateTime), List<string> marketplaceIds = default(List<string>), string name = default(string), List<PackingOptionSummary> packingOptions = default(List<PackingOptionSummary>), List<PlacementOptionSummary> placementOptions = default(List<PlacementOptionSummary>), List<ShipmentSummary> shipments = default(List<ShipmentSummary>), Address sourceAddress = default(Address), string status = default(string))
        {
            this.CreatedAt = createdAt;
            // to ensure "inboundPlanId" is required (not null)
            if (inboundPlanId == null)
            {
                throw new ArgumentNullException("inboundPlanId is a required property for InboundPlan and cannot be null");
            }
            this.InboundPlanId = inboundPlanId;
            this.LastUpdatedAt = lastUpdatedAt;
            // to ensure "marketplaceIds" is required (not null)
            if (marketplaceIds == null)
            {
                throw new ArgumentNullException("marketplaceIds is a required property for InboundPlan and cannot be null");
            }
            this.MarketplaceIds = marketplaceIds;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for InboundPlan and cannot be null");
            }
            this.Name = name;
            // to ensure "sourceAddress" is required (not null)
            if (sourceAddress == null)
            {
                throw new ArgumentNullException("sourceAddress is a required property for InboundPlan and cannot be null");
            }
            this.SourceAddress = sourceAddress;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for InboundPlan and cannot be null");
            }
            this.Status = status;
            this.PackingOptions = packingOptions;
            this.PlacementOptions = placementOptions;
            this.Shipments = shipments;
        }

        /// <summary>
        /// The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.
        /// </summary>
        /// <value>The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Identifier of an inbound plan.
        /// </summary>
        /// <value>Identifier of an inbound plan.</value>
        [DataMember(Name = "inboundPlanId", IsRequired = true, EmitDefaultValue = true)]
        public string InboundPlanId { get; set; }

        /// <summary>
        /// The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.
        /// </summary>
        /// <value>The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format with pattern &#x60;yyyy-MM-ddTHH:mm:ssZ&#x60;.</value>
        [DataMember(Name = "lastUpdatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LastUpdatedAt { get; set; }

        /// <summary>
        /// A list of marketplace IDs.
        /// </summary>
        /// <value>A list of marketplace IDs.</value>
        [DataMember(Name = "marketplaceIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> MarketplaceIds { get; set; }

        /// <summary>
        /// Human-readable name of the inbound plan.
        /// </summary>
        /// <value>Human-readable name of the inbound plan.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Packing options for the inbound plan. This property will be populated when it has been generated via the corresponding operation. If there is a chosen placement option, only packing options for that placement option will be returned. If there are confirmed shipments, only packing options for those shipments will be returned. Query the packing option for more details.
        /// </summary>
        /// <value>Packing options for the inbound plan. This property will be populated when it has been generated via the corresponding operation. If there is a chosen placement option, only packing options for that placement option will be returned. If there are confirmed shipments, only packing options for those shipments will be returned. Query the packing option for more details.</value>
        [DataMember(Name = "packingOptions", EmitDefaultValue = false)]
        public List<PackingOptionSummary> PackingOptions { get; set; }

        /// <summary>
        /// Placement options for the inbound plan. This property will be populated when it has been generated via the corresponding operation. If there is a chosen placement option, that will be the only returned option. Query the placement option for more details.
        /// </summary>
        /// <value>Placement options for the inbound plan. This property will be populated when it has been generated via the corresponding operation. If there is a chosen placement option, that will be the only returned option. Query the placement option for more details.</value>
        [DataMember(Name = "placementOptions", EmitDefaultValue = false)]
        public List<PlacementOptionSummary> PlacementOptions { get; set; }

        /// <summary>
        /// A list of shipment IDs for the inbound plan. This property is populated when it has been generated with the &#x60;confirmPlacementOptions&#x60; operation. Only shipments from the chosen placement option are returned. Query the shipment for more details.
        /// </summary>
        /// <value>A list of shipment IDs for the inbound plan. This property is populated when it has been generated with the &#x60;confirmPlacementOptions&#x60; operation. Only shipments from the chosen placement option are returned. Query the shipment for more details.</value>
        [DataMember(Name = "shipments", EmitDefaultValue = false)]
        public List<ShipmentSummary> Shipments { get; set; }

        /// <summary>
        /// Gets or Sets SourceAddress
        /// </summary>
        [DataMember(Name = "sourceAddress", IsRequired = true, EmitDefaultValue = true)]
        public Address SourceAddress { get; set; }

        /// <summary>
        /// Current status of the inbound plan. Possible values: &#x60;ACTIVE&#x60;, &#x60;VOIDED&#x60;, &#x60;SHIPPED&#x60;, &#x60;ERRORED&#x60;.
        /// </summary>
        /// <value>Current status of the inbound plan. Possible values: &#x60;ACTIVE&#x60;, &#x60;VOIDED&#x60;, &#x60;SHIPPED&#x60;, &#x60;ERRORED&#x60;.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboundPlan {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  InboundPlanId: ").Append(InboundPlanId).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
            sb.Append("  MarketplaceIds: ").Append(MarketplaceIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PackingOptions: ").Append(PackingOptions).Append("\n");
            sb.Append("  PlacementOptions: ").Append(PlacementOptions).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
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
            // InboundPlanId (string) maxLength
            if (this.InboundPlanId != null && this.InboundPlanId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for InboundPlanId, length must be less than 38.", new [] { "InboundPlanId" });
            }

            // InboundPlanId (string) minLength
            if (this.InboundPlanId != null && this.InboundPlanId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for InboundPlanId, length must be greater than 38.", new [] { "InboundPlanId" });
            }

            if (this.InboundPlanId != null) {
                // InboundPlanId (string) pattern
                Regex regexInboundPlanId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
                if (!regexInboundPlanId.Match(this.InboundPlanId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InboundPlanId, must match a pattern of " + regexInboundPlanId, new [] { "InboundPlanId" });
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

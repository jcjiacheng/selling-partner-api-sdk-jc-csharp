/*
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory.
 *
 * The version of the OpenAPI document: 2024-05-09
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

namespace Amazon.SellingPartnerAPI.SDK.Model/awd/v2024_05_09
{
    /// <summary>
    /// Represents an AWD inbound shipment.
    /// </summary>
    [DataContract(Name = "InboundShipment")]
    public partial class InboundShipment : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [DataMember(Name = "shipmentStatus", IsRequired = true, EmitDefaultValue = true)]
        public InboundShipmentStatus ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundShipment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboundShipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundShipment" /> class.
        /// </summary>
        /// <param name="carrierCode">carrierCode.</param>
        /// <param name="createdAt">Timestamp when the shipment was created. The date is returned in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format..</param>
        /// <param name="destinationAddress">destinationAddress (required).</param>
        /// <param name="externalReferenceId">Client-provided reference ID that can correlate this shipment to client resources. For example, to map this shipment to an internal bookkeeping order record..</param>
        /// <param name="orderId">The AWD inbound order ID that this inbound shipment belongs to. (required).</param>
        /// <param name="originAddress">originAddress (required).</param>
        /// <param name="receivedQuantity">Quantity received (at the receiving end) as part of this shipment..</param>
        /// <param name="shipBy">Timestamp when the shipment will be shipped..</param>
        /// <param name="shipmentContainerQuantities">Packages that are part of this shipment. (required).</param>
        /// <param name="shipmentId">Unique shipment ID. (required).</param>
        /// <param name="shipmentSkuQuantities">Quantity details at SKU level for the shipment. This attribute will only appear if the skuQuantities parameter in the request is set to SHOW..</param>
        /// <param name="destinationRegion">Assigned region where the order will be shipped. This can differ from what was passed as preference. AWD currently supports following region IDs: [us-west, us-east, us-southcentral, us-southeast].</param>
        /// <param name="shipmentStatus">shipmentStatus (required).</param>
        /// <param name="trackingId">Carrier-unique tracking ID for this shipment..</param>
        /// <param name="updatedAt">Timestamp when the shipment was updated. The date is returned in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format..</param>
        /// <param name="warehouseReferenceId">An AWD-provided reference ID that you can use to interact with the warehouse. For example, a carrier appointment booking..</param>
        public InboundShipment(CarrierCode carrierCode = default(CarrierCode), DateTime createdAt = default(DateTime), Address destinationAddress = default(Address), string externalReferenceId = default(string), string orderId = default(string), Address originAddress = default(Address), List<InventoryQuantity> receivedQuantity = default(List<InventoryQuantity>), DateTime shipBy = default(DateTime), List<DistributionPackageQuantity> shipmentContainerQuantities = default(List<DistributionPackageQuantity>), string shipmentId = default(string), List<SkuQuantity> shipmentSkuQuantities = default(List<SkuQuantity>), string destinationRegion = default(string), InboundShipmentStatus shipmentStatus = default(InboundShipmentStatus), string trackingId = default(string), DateTime updatedAt = default(DateTime), string warehouseReferenceId = default(string))
        {
            // to ensure "destinationAddress" is required (not null)
            if (destinationAddress == null)
            {
                throw new ArgumentNullException("destinationAddress is a required property for InboundShipment and cannot be null");
            }
            this.DestinationAddress = destinationAddress;
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new ArgumentNullException("orderId is a required property for InboundShipment and cannot be null");
            }
            this.OrderId = orderId;
            // to ensure "originAddress" is required (not null)
            if (originAddress == null)
            {
                throw new ArgumentNullException("originAddress is a required property for InboundShipment and cannot be null");
            }
            this.OriginAddress = originAddress;
            // to ensure "shipmentContainerQuantities" is required (not null)
            if (shipmentContainerQuantities == null)
            {
                throw new ArgumentNullException("shipmentContainerQuantities is a required property for InboundShipment and cannot be null");
            }
            this.ShipmentContainerQuantities = shipmentContainerQuantities;
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new ArgumentNullException("shipmentId is a required property for InboundShipment and cannot be null");
            }
            this.ShipmentId = shipmentId;
            this.ShipmentStatus = shipmentStatus;
            this.CarrierCode = carrierCode;
            this.CreatedAt = createdAt;
            this.ExternalReferenceId = externalReferenceId;
            this.ReceivedQuantity = receivedQuantity;
            this.ShipBy = shipBy;
            this.ShipmentSkuQuantities = shipmentSkuQuantities;
            this.DestinationRegion = destinationRegion;
            this.TrackingId = trackingId;
            this.UpdatedAt = updatedAt;
            this.WarehouseReferenceId = warehouseReferenceId;
        }

        /// <summary>
        /// Gets or Sets CarrierCode
        /// </summary>
        [DataMember(Name = "carrierCode", EmitDefaultValue = false)]
        public CarrierCode CarrierCode { get; set; }

        /// <summary>
        /// Timestamp when the shipment was created. The date is returned in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format.
        /// </summary>
        /// <value>Timestamp when the shipment was created. The date is returned in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DestinationAddress
        /// </summary>
        [DataMember(Name = "destinationAddress", IsRequired = true, EmitDefaultValue = true)]
        public Address DestinationAddress { get; set; }

        /// <summary>
        /// Client-provided reference ID that can correlate this shipment to client resources. For example, to map this shipment to an internal bookkeeping order record.
        /// </summary>
        /// <value>Client-provided reference ID that can correlate this shipment to client resources. For example, to map this shipment to an internal bookkeeping order record.</value>
        /*
        <example>TestReferenceId</example>
        */
        [DataMember(Name = "externalReferenceId", EmitDefaultValue = false)]
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// The AWD inbound order ID that this inbound shipment belongs to.
        /// </summary>
        /// <value>The AWD inbound order ID that this inbound shipment belongs to.</value>
        [DataMember(Name = "orderId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets OriginAddress
        /// </summary>
        [DataMember(Name = "originAddress", IsRequired = true, EmitDefaultValue = true)]
        public Address OriginAddress { get; set; }

        /// <summary>
        /// Quantity received (at the receiving end) as part of this shipment.
        /// </summary>
        /// <value>Quantity received (at the receiving end) as part of this shipment.</value>
        [DataMember(Name = "receivedQuantity", EmitDefaultValue = false)]
        public List<InventoryQuantity> ReceivedQuantity { get; set; }

        /// <summary>
        /// Timestamp when the shipment will be shipped.
        /// </summary>
        /// <value>Timestamp when the shipment will be shipped.</value>
        [DataMember(Name = "shipBy", EmitDefaultValue = false)]
        public DateTime ShipBy { get; set; }

        /// <summary>
        /// Packages that are part of this shipment.
        /// </summary>
        /// <value>Packages that are part of this shipment.</value>
        [DataMember(Name = "shipmentContainerQuantities", IsRequired = true, EmitDefaultValue = true)]
        public List<DistributionPackageQuantity> ShipmentContainerQuantities { get; set; }

        /// <summary>
        /// Unique shipment ID.
        /// </summary>
        /// <value>Unique shipment ID.</value>
        [DataMember(Name = "shipmentId", IsRequired = true, EmitDefaultValue = true)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Quantity details at SKU level for the shipment. This attribute will only appear if the skuQuantities parameter in the request is set to SHOW.
        /// </summary>
        /// <value>Quantity details at SKU level for the shipment. This attribute will only appear if the skuQuantities parameter in the request is set to SHOW.</value>
        [DataMember(Name = "shipmentSkuQuantities", EmitDefaultValue = false)]
        public List<SkuQuantity> ShipmentSkuQuantities { get; set; }

        /// <summary>
        /// Assigned region where the order will be shipped. This can differ from what was passed as preference. AWD currently supports following region IDs: [us-west, us-east, us-southcentral, us-southeast]
        /// </summary>
        /// <value>Assigned region where the order will be shipped. This can differ from what was passed as preference. AWD currently supports following region IDs: [us-west, us-east, us-southcentral, us-southeast]</value>
        /*
        <example>us-west</example>
        */
        [DataMember(Name = "destinationRegion", EmitDefaultValue = false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Carrier-unique tracking ID for this shipment.
        /// </summary>
        /// <value>Carrier-unique tracking ID for this shipment.</value>
        [DataMember(Name = "trackingId", EmitDefaultValue = false)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Timestamp when the shipment was updated. The date is returned in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format.
        /// </summary>
        /// <value>Timestamp when the shipment was updated. The date is returned in &lt;a href&#x3D;&#39;https://developer-docs.amazon.com/sp-api/docs/iso-8601&#39;&gt;ISO 8601&lt;/a&gt; format.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// An AWD-provided reference ID that you can use to interact with the warehouse. For example, a carrier appointment booking.
        /// </summary>
        /// <value>An AWD-provided reference ID that you can use to interact with the warehouse. For example, a carrier appointment booking.</value>
        /*
        <example>TestWarehouseReferenceId</example>
        */
        [DataMember(Name = "warehouseReferenceId", EmitDefaultValue = false)]
        public string WarehouseReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboundShipment {\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  ExternalReferenceId: ").Append(ExternalReferenceId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OriginAddress: ").Append(OriginAddress).Append("\n");
            sb.Append("  ReceivedQuantity: ").Append(ReceivedQuantity).Append("\n");
            sb.Append("  ShipBy: ").Append(ShipBy).Append("\n");
            sb.Append("  ShipmentContainerQuantities: ").Append(ShipmentContainerQuantities).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  ShipmentSkuQuantities: ").Append(ShipmentSkuQuantities).Append("\n");
            sb.Append("  DestinationRegion: ").Append(DestinationRegion).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WarehouseReferenceId: ").Append(WarehouseReferenceId).Append("\n");
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
            // OrderId (string) minLength
            if (this.OrderId != null && this.OrderId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for OrderId, length must be greater than 1.", new [] { "OrderId" });
            }

            // ShipmentId (string) minLength
            if (this.ShipmentId != null && this.ShipmentId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ShipmentId, length must be greater than 1.", new [] { "ShipmentId" });
            }

            // TrackingId (string) minLength
            if (this.TrackingId != null && this.TrackingId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for TrackingId, length must be greater than 1.", new [] { "TrackingId" });
            }

            yield break;
        }
    }

}

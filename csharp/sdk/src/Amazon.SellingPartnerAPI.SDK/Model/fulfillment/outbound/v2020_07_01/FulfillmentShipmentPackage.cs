/*
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * The version of the OpenAPI document: 2020-07-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/outbound/v2020_07_01
{
    /// <summary>
    /// Package information for a shipment in a fulfillment order.
    /// </summary>
    [DataContract(Name = "FulfillmentShipmentPackage")]
    public partial class FulfillmentShipmentPackage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentShipmentPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentShipmentPackage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentShipmentPackage" /> class.
        /// </summary>
        /// <param name="packageNumber">Identifies a package in a shipment. (required).</param>
        /// <param name="carrierCode">Identifies the carrier who will deliver the shipment to the recipient. (required).</param>
        /// <param name="trackingNumber">The tracking number, if provided, can be used to obtain tracking and delivery information..</param>
        /// <param name="estimatedArrivalDate">Date timestamp.</param>
        /// <param name="lockerDetails">lockerDetails.</param>
        /// <param name="deliveryInformation">deliveryInformation.</param>
        public FulfillmentShipmentPackage(int packageNumber = default(int), string carrierCode = default(string), string trackingNumber = default(string), DateTime estimatedArrivalDate = default(DateTime), LockerDetails lockerDetails = default(LockerDetails), DeliveryInformation deliveryInformation = default(DeliveryInformation))
        {
            this.PackageNumber = packageNumber;
            // to ensure "carrierCode" is required (not null)
            if (carrierCode == null)
            {
                throw new ArgumentNullException("carrierCode is a required property for FulfillmentShipmentPackage and cannot be null");
            }
            this.CarrierCode = carrierCode;
            this.TrackingNumber = trackingNumber;
            this.EstimatedArrivalDate = estimatedArrivalDate;
            this.LockerDetails = lockerDetails;
            this.DeliveryInformation = deliveryInformation;
        }

        /// <summary>
        /// Identifies a package in a shipment.
        /// </summary>
        /// <value>Identifies a package in a shipment.</value>
        [DataMember(Name = "packageNumber", IsRequired = true, EmitDefaultValue = true)]
        public int PackageNumber { get; set; }

        /// <summary>
        /// Identifies the carrier who will deliver the shipment to the recipient.
        /// </summary>
        /// <value>Identifies the carrier who will deliver the shipment to the recipient.</value>
        [DataMember(Name = "carrierCode", IsRequired = true, EmitDefaultValue = true)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The tracking number, if provided, can be used to obtain tracking and delivery information.
        /// </summary>
        /// <value>The tracking number, if provided, can be used to obtain tracking and delivery information.</value>
        [DataMember(Name = "trackingNumber", EmitDefaultValue = false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Date timestamp
        /// </summary>
        /// <value>Date timestamp</value>
        [DataMember(Name = "estimatedArrivalDate", EmitDefaultValue = false)]
        public DateTime EstimatedArrivalDate { get; set; }

        /// <summary>
        /// Gets or Sets LockerDetails
        /// </summary>
        [DataMember(Name = "lockerDetails", EmitDefaultValue = false)]
        public LockerDetails LockerDetails { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryInformation
        /// </summary>
        [DataMember(Name = "deliveryInformation", EmitDefaultValue = false)]
        public DeliveryInformation DeliveryInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FulfillmentShipmentPackage {\n");
            sb.Append("  PackageNumber: ").Append(PackageNumber).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  EstimatedArrivalDate: ").Append(EstimatedArrivalDate).Append("\n");
            sb.Append("  LockerDetails: ").Append(LockerDetails).Append("\n");
            sb.Append("  DeliveryInformation: ").Append(DeliveryInformation).Append("\n");
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

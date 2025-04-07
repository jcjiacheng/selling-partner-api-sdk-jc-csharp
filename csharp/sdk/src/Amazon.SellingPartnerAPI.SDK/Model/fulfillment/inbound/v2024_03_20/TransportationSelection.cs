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
    /// The transportation option selected to confirm.
    /// </summary>
    [DataContract(Name = "TransportationSelection")]
    public partial class TransportationSelection : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportationSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransportationSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportationSelection" /> class.
        /// </summary>
        /// <param name="contactInformation">contactInformation.</param>
        /// <param name="shipmentId">Shipment ID that the transportation Option is for. (required).</param>
        /// <param name="transportationOptionId">Transportation option being selected for the provided shipment. (required).</param>
        public TransportationSelection(ContactInformation contactInformation = default(ContactInformation), string shipmentId = default(string), string transportationOptionId = default(string))
        {
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new ArgumentNullException("shipmentId is a required property for TransportationSelection and cannot be null");
            }
            this.ShipmentId = shipmentId;
            // to ensure "transportationOptionId" is required (not null)
            if (transportationOptionId == null)
            {
                throw new ArgumentNullException("transportationOptionId is a required property for TransportationSelection and cannot be null");
            }
            this.TransportationOptionId = transportationOptionId;
            this.ContactInformation = contactInformation;
        }

        /// <summary>
        /// Gets or Sets ContactInformation
        /// </summary>
        [DataMember(Name = "contactInformation", EmitDefaultValue = false)]
        public ContactInformation ContactInformation { get; set; }

        /// <summary>
        /// Shipment ID that the transportation Option is for.
        /// </summary>
        /// <value>Shipment ID that the transportation Option is for.</value>
        [DataMember(Name = "shipmentId", IsRequired = true, EmitDefaultValue = true)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Transportation option being selected for the provided shipment.
        /// </summary>
        /// <value>Transportation option being selected for the provided shipment.</value>
        [DataMember(Name = "transportationOptionId", IsRequired = true, EmitDefaultValue = true)]
        public string TransportationOptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransportationSelection {\n");
            sb.Append("  ContactInformation: ").Append(ContactInformation).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  TransportationOptionId: ").Append(TransportationOptionId).Append("\n");
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
            // ShipmentId (string) maxLength
            if (this.ShipmentId != null && this.ShipmentId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for ShipmentId, length must be less than 38.", new [] { "ShipmentId" });
            }

            // ShipmentId (string) minLength
            if (this.ShipmentId != null && this.ShipmentId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for ShipmentId, length must be greater than 38.", new [] { "ShipmentId" });
            }

            if (this.ShipmentId != null) {
                // ShipmentId (string) pattern
                Regex regexShipmentId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
                if (!regexShipmentId.Match(this.ShipmentId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShipmentId, must match a pattern of " + regexShipmentId, new [] { "ShipmentId" });
                }
            }

            // TransportationOptionId (string) maxLength
            if (this.TransportationOptionId != null && this.TransportationOptionId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for TransportationOptionId, length must be less than 38.", new [] { "TransportationOptionId" });
            }

            // TransportationOptionId (string) minLength
            if (this.TransportationOptionId != null && this.TransportationOptionId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for TransportationOptionId, length must be greater than 38.", new [] { "TransportationOptionId" });
            }

            if (this.TransportationOptionId != null) {
                // TransportationOptionId (string) pattern
                Regex regexTransportationOptionId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
                if (!regexTransportationOptionId.Match(this.TransportationOptionId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransportationOptionId, must match a pattern of " + regexTransportationOptionId, new [] { "TransportationOptionId" });
                }
            }

            yield break;
        }
    }

}

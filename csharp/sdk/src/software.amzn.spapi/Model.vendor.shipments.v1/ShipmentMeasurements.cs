/*
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.vendor.shipments.v1
{
    /// <summary>
    /// Shipment measurement details.
    /// </summary>
    [DataContract(Name = "ShipmentMeasurements")]
    public partial class ShipmentMeasurements : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentMeasurements" /> class.
        /// </summary>
        /// <param name="grossShipmentWeight">grossShipmentWeight.</param>
        /// <param name="shipmentVolume">shipmentVolume.</param>
        /// <param name="cartonCount">Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments..</param>
        /// <param name="palletCount">Number of pallets present in the shipment. Provide the palletCount only for palletized shipments..</param>
        public ShipmentMeasurements(Weight grossShipmentWeight = default(Weight), Volume shipmentVolume = default(Volume), int cartonCount = default(int), int palletCount = default(int))
        {
            this.GrossShipmentWeight = grossShipmentWeight;
            this.ShipmentVolume = shipmentVolume;
            this.CartonCount = cartonCount;
            this.PalletCount = palletCount;
        }

        /// <summary>
        /// Gets or Sets GrossShipmentWeight
        /// </summary>
        [DataMember(Name = "grossShipmentWeight", EmitDefaultValue = false)]
        public Weight GrossShipmentWeight { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentVolume
        /// </summary>
        [DataMember(Name = "shipmentVolume", EmitDefaultValue = false)]
        public Volume ShipmentVolume { get; set; }

        /// <summary>
        /// Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments.
        /// </summary>
        /// <value>Number of cartons present in the shipment. Provide the cartonCount only for non-palletized shipments.</value>
        [DataMember(Name = "cartonCount", EmitDefaultValue = false)]
        public int CartonCount { get; set; }

        /// <summary>
        /// Number of pallets present in the shipment. Provide the palletCount only for palletized shipments.
        /// </summary>
        /// <value>Number of pallets present in the shipment. Provide the palletCount only for palletized shipments.</value>
        [DataMember(Name = "palletCount", EmitDefaultValue = false)]
        public int PalletCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentMeasurements {\n");
            sb.Append("  GrossShipmentWeight: ").Append(GrossShipmentWeight).Append("\n");
            sb.Append("  ShipmentVolume: ").Append(ShipmentVolume).Append("\n");
            sb.Append("  CartonCount: ").Append(CartonCount).Append("\n");
            sb.Append("  PalletCount: ").Append(PalletCount).Append("\n");
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

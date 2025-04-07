/*
 * Selling Partner API for Shipment Invoicing
 *
 * The Selling Partner API for Shipment Invoicing helps you programmatically retrieve shipment invoice information in the Brazil marketplace for a selling partner’s Fulfillment by Amazon (FBA) orders.
 *
 * The version of the OpenAPI document: v0
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

namespace Amazon.SellingPartnerAPI.SDK.Model/invoicing/v0
{
    /// <summary>
    /// The shipment invoice status response.
    /// </summary>
    [DataContract(Name = "ShipmentInvoiceStatusResponse")]
    public partial class ShipmentInvoiceStatusResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentInvoiceStatusResponse" /> class.
        /// </summary>
        /// <param name="shipments">shipments.</param>
        public ShipmentInvoiceStatusResponse(ShipmentInvoiceStatusInfo shipments = default(ShipmentInvoiceStatusInfo))
        {
            this.Shipments = shipments;
        }

        /// <summary>
        /// Gets or Sets Shipments
        /// </summary>
        [DataMember(Name = "Shipments", EmitDefaultValue = false)]
        public ShipmentInvoiceStatusInfo Shipments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentInvoiceStatusResponse {\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
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

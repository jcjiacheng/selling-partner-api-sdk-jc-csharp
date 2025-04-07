/*
 * Amazon Shipping API
 *
 * The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.
 *
 * The version of the OpenAPI document: v2
 * Contact: swa-api-core@amazon.com
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

namespace Amazon.SellingPartnerAPI.SDK.Model/shipping/v2
{
    /// <summary>
    /// The payload for the purchaseShipment operation.
    /// </summary>
    [DataContract(Name = "PurchaseShipmentResult")]
    public partial class PurchaseShipmentResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseShipmentResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseShipmentResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseShipmentResult" /> class.
        /// </summary>
        /// <param name="shipmentId">The unique shipment identifier provided by a shipping service. (required).</param>
        /// <param name="packageDocumentDetails">A list of post-purchase details about a package that will be shipped using a shipping service. (required).</param>
        /// <param name="promise">promise (required).</param>
        /// <param name="benefits">benefits.</param>
        public PurchaseShipmentResult(string shipmentId = default(string), List<PackageDocumentDetail> packageDocumentDetails = default(List<PackageDocumentDetail>), Promise promise = default(Promise), Benefits benefits = default(Benefits))
        {
            // to ensure "shipmentId" is required (not null)
            if (shipmentId == null)
            {
                throw new ArgumentNullException("shipmentId is a required property for PurchaseShipmentResult and cannot be null");
            }
            this.ShipmentId = shipmentId;
            // to ensure "packageDocumentDetails" is required (not null)
            if (packageDocumentDetails == null)
            {
                throw new ArgumentNullException("packageDocumentDetails is a required property for PurchaseShipmentResult and cannot be null");
            }
            this.PackageDocumentDetails = packageDocumentDetails;
            // to ensure "promise" is required (not null)
            if (promise == null)
            {
                throw new ArgumentNullException("promise is a required property for PurchaseShipmentResult and cannot be null");
            }
            this.Promise = promise;
            this.Benefits = benefits;
        }

        /// <summary>
        /// The unique shipment identifier provided by a shipping service.
        /// </summary>
        /// <value>The unique shipment identifier provided by a shipping service.</value>
        [DataMember(Name = "shipmentId", IsRequired = true, EmitDefaultValue = true)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// A list of post-purchase details about a package that will be shipped using a shipping service.
        /// </summary>
        /// <value>A list of post-purchase details about a package that will be shipped using a shipping service.</value>
        [DataMember(Name = "packageDocumentDetails", IsRequired = true, EmitDefaultValue = true)]
        public List<PackageDocumentDetail> PackageDocumentDetails { get; set; }

        /// <summary>
        /// Gets or Sets Promise
        /// </summary>
        [DataMember(Name = "promise", IsRequired = true, EmitDefaultValue = true)]
        public Promise Promise { get; set; }

        /// <summary>
        /// Gets or Sets Benefits
        /// </summary>
        [DataMember(Name = "benefits", EmitDefaultValue = false)]
        public Benefits Benefits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PurchaseShipmentResult {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  PackageDocumentDetails: ").Append(PackageDocumentDetails).Append("\n");
            sb.Append("  Promise: ").Append(Promise).Append("\n");
            sb.Append("  Benefits: ").Append(Benefits).Append("\n");
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

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
    /// The time windows promised for pickup and delivery events.
    /// </summary>
    [DataContract(Name = "Promise")]
    public partial class Promise : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Promise" /> class.
        /// </summary>
        /// <param name="deliveryWindow">deliveryWindow.</param>
        /// <param name="pickupWindow">pickupWindow.</param>
        public Promise(TimeWindow deliveryWindow = default(TimeWindow), TimeWindow pickupWindow = default(TimeWindow))
        {
            this.DeliveryWindow = deliveryWindow;
            this.PickupWindow = pickupWindow;
        }

        /// <summary>
        /// Gets or Sets DeliveryWindow
        /// </summary>
        [DataMember(Name = "deliveryWindow", EmitDefaultValue = false)]
        public TimeWindow DeliveryWindow { get; set; }

        /// <summary>
        /// Gets or Sets PickupWindow
        /// </summary>
        [DataMember(Name = "pickupWindow", EmitDefaultValue = false)]
        public TimeWindow PickupWindow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Promise {\n");
            sb.Append("  DeliveryWindow: ").Append(DeliveryWindow).Append("\n");
            sb.Append("  PickupWindow: ").Append(PickupWindow).Append("\n");
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

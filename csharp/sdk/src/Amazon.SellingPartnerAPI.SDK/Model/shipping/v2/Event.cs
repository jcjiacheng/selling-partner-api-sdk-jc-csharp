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
    /// A tracking event.
    /// </summary>
    [DataContract(Name = "Event")]
    public partial class Event : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EventCode
        /// </summary>
        [DataMember(Name = "eventCode", IsRequired = true, EmitDefaultValue = true)]
        public EventCode EventCode { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentType
        /// </summary>
        [DataMember(Name = "shipmentType", EmitDefaultValue = false)]
        public ShipmentType? ShipmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="eventCode">eventCode (required).</param>
        /// <param name="location">location.</param>
        /// <param name="eventTime">The ISO 8601 formatted timestamp of the event. (required).</param>
        /// <param name="shipmentType">shipmentType.</param>
        public Event(EventCode eventCode = default(EventCode), Location location = default(Location), DateTime eventTime = default(DateTime), ShipmentType? shipmentType = default(ShipmentType?))
        {
            this.EventCode = eventCode;
            this.EventTime = eventTime;
            this.Location = location;
            this.ShipmentType = shipmentType;
        }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public Location Location { get; set; }

        /// <summary>
        /// The ISO 8601 formatted timestamp of the event.
        /// </summary>
        /// <value>The ISO 8601 formatted timestamp of the event.</value>
        [DataMember(Name = "eventTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime EventTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  EventCode: ").Append(EventCode).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
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

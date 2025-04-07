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
    /// The payload for the getTracking operation.
    /// </summary>
    [DataContract(Name = "GetTrackingResult")]
    public partial class GetTrackingResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrackingResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTrackingResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrackingResult" /> class.
        /// </summary>
        /// <param name="trackingId">The carrier generated identifier for a package in a purchased shipment. (required).</param>
        /// <param name="alternateLegTrackingId">The carrier generated reverse identifier for a returned package in a purchased shipment. (required).</param>
        /// <param name="eventHistory">A list of tracking events. (required).</param>
        /// <param name="promisedDeliveryDate">The date and time by which the shipment is promised to be delivered. (required).</param>
        /// <param name="summary">summary (required).</param>
        public GetTrackingResult(string trackingId = default(string), string alternateLegTrackingId = default(string), List<Event> eventHistory = default(List<Event>), DateTime promisedDeliveryDate = default(DateTime), TrackingSummary summary = default(TrackingSummary))
        {
            // to ensure "trackingId" is required (not null)
            if (trackingId == null)
            {
                throw new ArgumentNullException("trackingId is a required property for GetTrackingResult and cannot be null");
            }
            this.TrackingId = trackingId;
            // to ensure "alternateLegTrackingId" is required (not null)
            if (alternateLegTrackingId == null)
            {
                throw new ArgumentNullException("alternateLegTrackingId is a required property for GetTrackingResult and cannot be null");
            }
            this.AlternateLegTrackingId = alternateLegTrackingId;
            // to ensure "eventHistory" is required (not null)
            if (eventHistory == null)
            {
                throw new ArgumentNullException("eventHistory is a required property for GetTrackingResult and cannot be null");
            }
            this.EventHistory = eventHistory;
            this.PromisedDeliveryDate = promisedDeliveryDate;
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new ArgumentNullException("summary is a required property for GetTrackingResult and cannot be null");
            }
            this.Summary = summary;
        }

        /// <summary>
        /// The carrier generated identifier for a package in a purchased shipment.
        /// </summary>
        /// <value>The carrier generated identifier for a package in a purchased shipment.</value>
        [DataMember(Name = "trackingId", IsRequired = true, EmitDefaultValue = true)]
        public string TrackingId { get; set; }

        /// <summary>
        /// The carrier generated reverse identifier for a returned package in a purchased shipment.
        /// </summary>
        /// <value>The carrier generated reverse identifier for a returned package in a purchased shipment.</value>
        [DataMember(Name = "alternateLegTrackingId", IsRequired = true, EmitDefaultValue = true)]
        public string AlternateLegTrackingId { get; set; }

        /// <summary>
        /// A list of tracking events.
        /// </summary>
        /// <value>A list of tracking events.</value>
        [DataMember(Name = "eventHistory", IsRequired = true, EmitDefaultValue = true)]
        public List<Event> EventHistory { get; set; }

        /// <summary>
        /// The date and time by which the shipment is promised to be delivered.
        /// </summary>
        /// <value>The date and time by which the shipment is promised to be delivered.</value>
        [DataMember(Name = "promisedDeliveryDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime PromisedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = true)]
        public TrackingSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTrackingResult {\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  AlternateLegTrackingId: ").Append(AlternateLegTrackingId).Append("\n");
            sb.Append("  EventHistory: ").Append(EventHistory).Append("\n");
            sb.Append("  PromisedDeliveryDate: ").Append(PromisedDeliveryDate).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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

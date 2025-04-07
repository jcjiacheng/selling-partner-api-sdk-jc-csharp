/*
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
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
using OpenAPIDateConverter = Amazon.SellingPartnerAPI.SDK.Client.OpenAPIDateConverter;

namespace Amazon.SellingPartnerAPI.SDK.Model/services/v1
{
    /// <summary>
    /// Input for set appointment fulfillment data operation.
    /// </summary>
    [DataContract(Name = "SetAppointmentFulfillmentDataRequest")]
    public partial class SetAppointmentFulfillmentDataRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetAppointmentFulfillmentDataRequest" /> class.
        /// </summary>
        /// <param name="estimatedArrivalTime">estimatedArrivalTime.</param>
        /// <param name="fulfillmentTime">fulfillmentTime.</param>
        /// <param name="appointmentResources">List of resources that performs or performed job appointment fulfillment..</param>
        /// <param name="fulfillmentDocuments">List of documents captured during service appointment fulfillment..</param>
        public SetAppointmentFulfillmentDataRequest(DateTimeRange estimatedArrivalTime = default(DateTimeRange), FulfillmentTime fulfillmentTime = default(FulfillmentTime), List<AppointmentResource> appointmentResources = default(List<AppointmentResource>), List<FulfillmentDocument> fulfillmentDocuments = default(List<FulfillmentDocument>))
        {
            this.EstimatedArrivalTime = estimatedArrivalTime;
            this.FulfillmentTime = fulfillmentTime;
            this.AppointmentResources = appointmentResources;
            this.FulfillmentDocuments = fulfillmentDocuments;
        }

        /// <summary>
        /// Gets or Sets EstimatedArrivalTime
        /// </summary>
        [DataMember(Name = "estimatedArrivalTime", EmitDefaultValue = false)]
        public DateTimeRange EstimatedArrivalTime { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentTime
        /// </summary>
        [DataMember(Name = "fulfillmentTime", EmitDefaultValue = false)]
        public FulfillmentTime FulfillmentTime { get; set; }

        /// <summary>
        /// List of resources that performs or performed job appointment fulfillment.
        /// </summary>
        /// <value>List of resources that performs or performed job appointment fulfillment.</value>
        [DataMember(Name = "appointmentResources", EmitDefaultValue = false)]
        public List<AppointmentResource> AppointmentResources { get; set; }

        /// <summary>
        /// List of documents captured during service appointment fulfillment.
        /// </summary>
        /// <value>List of documents captured during service appointment fulfillment.</value>
        [DataMember(Name = "fulfillmentDocuments", EmitDefaultValue = false)]
        public List<FulfillmentDocument> FulfillmentDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetAppointmentFulfillmentDataRequest {\n");
            sb.Append("  EstimatedArrivalTime: ").Append(EstimatedArrivalTime).Append("\n");
            sb.Append("  FulfillmentTime: ").Append(FulfillmentTime).Append("\n");
            sb.Append("  AppointmentResources: ").Append(AppointmentResources).Append("\n");
            sb.Append("  FulfillmentDocuments: ").Append(FulfillmentDocuments).Append("\n");
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

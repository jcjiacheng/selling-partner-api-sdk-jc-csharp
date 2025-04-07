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
    /// Input for rescheduled appointment operation.
    /// </summary>
    [DataContract(Name = "RescheduleAppointmentRequest")]
    public partial class RescheduleAppointmentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RescheduleAppointmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RescheduleAppointmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RescheduleAppointmentRequest" /> class.
        /// </summary>
        /// <param name="appointmentTime">appointmentTime (required).</param>
        /// <param name="rescheduleReasonCode">The appointment reschedule reason code. (required).</param>
        public RescheduleAppointmentRequest(AppointmentTimeInput appointmentTime = default(AppointmentTimeInput), string rescheduleReasonCode = default(string))
        {
            // to ensure "appointmentTime" is required (not null)
            if (appointmentTime == null)
            {
                throw new ArgumentNullException("appointmentTime is a required property for RescheduleAppointmentRequest and cannot be null");
            }
            this.AppointmentTime = appointmentTime;
            // to ensure "rescheduleReasonCode" is required (not null)
            if (rescheduleReasonCode == null)
            {
                throw new ArgumentNullException("rescheduleReasonCode is a required property for RescheduleAppointmentRequest and cannot be null");
            }
            this.RescheduleReasonCode = rescheduleReasonCode;
        }

        /// <summary>
        /// Gets or Sets AppointmentTime
        /// </summary>
        [DataMember(Name = "appointmentTime", IsRequired = true, EmitDefaultValue = true)]
        public AppointmentTimeInput AppointmentTime { get; set; }

        /// <summary>
        /// The appointment reschedule reason code.
        /// </summary>
        /// <value>The appointment reschedule reason code.</value>
        [DataMember(Name = "rescheduleReasonCode", IsRequired = true, EmitDefaultValue = true)]
        public string RescheduleReasonCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RescheduleAppointmentRequest {\n");
            sb.Append("  AppointmentTime: ").Append(AppointmentTime).Append("\n");
            sb.Append("  RescheduleReasonCode: ").Append(RescheduleReasonCode).Append("\n");
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

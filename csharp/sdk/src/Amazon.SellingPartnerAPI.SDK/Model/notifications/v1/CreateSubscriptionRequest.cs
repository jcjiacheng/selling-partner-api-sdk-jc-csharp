/*
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.  For more information, refer to the [Notifications Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/notifications-api-v1-use-case-guide).
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

namespace Amazon.SellingPartnerAPI.SDK.Model/notifications/v1
{
    /// <summary>
    /// The request schema for the &#x60;createSubscription&#x60; operation.
    /// </summary>
    [DataContract(Name = "CreateSubscriptionRequest")]
    public partial class CreateSubscriptionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="payloadVersion">The version of the payload object to be used in the notification. (required).</param>
        /// <param name="destinationId">The identifier for the destination where notifications will be delivered. (required).</param>
        /// <param name="processingDirective">processingDirective.</param>
        public CreateSubscriptionRequest(string payloadVersion = default(string), string destinationId = default(string), ProcessingDirective processingDirective = default(ProcessingDirective))
        {
            // to ensure "payloadVersion" is required (not null)
            if (payloadVersion == null)
            {
                throw new ArgumentNullException("payloadVersion is a required property for CreateSubscriptionRequest and cannot be null");
            }
            this.PayloadVersion = payloadVersion;
            // to ensure "destinationId" is required (not null)
            if (destinationId == null)
            {
                throw new ArgumentNullException("destinationId is a required property for CreateSubscriptionRequest and cannot be null");
            }
            this.DestinationId = destinationId;
            this.ProcessingDirective = processingDirective;
        }

        /// <summary>
        /// The version of the payload object to be used in the notification.
        /// </summary>
        /// <value>The version of the payload object to be used in the notification.</value>
        [DataMember(Name = "payloadVersion", IsRequired = true, EmitDefaultValue = true)]
        public string PayloadVersion { get; set; }

        /// <summary>
        /// The identifier for the destination where notifications will be delivered.
        /// </summary>
        /// <value>The identifier for the destination where notifications will be delivered.</value>
        [DataMember(Name = "destinationId", IsRequired = true, EmitDefaultValue = true)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingDirective
        /// </summary>
        [DataMember(Name = "processingDirective", EmitDefaultValue = false)]
        public ProcessingDirective ProcessingDirective { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequest {\n");
            sb.Append("  PayloadVersion: ").Append(PayloadVersion).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  ProcessingDirective: ").Append(ProcessingDirective).Append("\n");
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

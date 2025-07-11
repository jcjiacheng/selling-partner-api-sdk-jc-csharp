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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.notifications.v1
{
    /// <summary>
    /// The response schema for the &#x60;getDestinations&#x60; operation.
    /// </summary>
    [DataContract(Name = "GetDestinationsResponse")]
    public partial class GetDestinationsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDestinationsResponse" /> class.
        /// </summary>
        /// <param name="payload">A list of destinations..</param>
        /// <param name="errors">A list of error responses returned when a request is unsuccessful..</param>
        public GetDestinationsResponse(List<Destination> payload = default(List<Destination>), List<Error> errors = default(List<Error>))
        {
            this.Payload = payload;
            this.Errors = errors;
        }

        /// <summary>
        /// A list of destinations.
        /// </summary>
        /// <value>A list of destinations.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public List<Destination> Payload { get; set; }

        /// <summary>
        /// A list of error responses returned when a request is unsuccessful.
        /// </summary>
        /// <value>A list of error responses returned when a request is unsuccessful.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDestinationsResponse {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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

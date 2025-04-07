/*
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * The version of the OpenAPI document: 2020-07-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/outbound/v2020_07_01
{
    /// <summary>
    /// The response schema for the &#x60;listReturnReasonCodes&#x60; operation.
    /// </summary>
    [DataContract(Name = "ListReturnReasonCodesResponse")]
    public partial class ListReturnReasonCodesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReturnReasonCodesResponse" /> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="errors">A list of error responses returned when a request is unsuccessful..</param>
        public ListReturnReasonCodesResponse(ListReturnReasonCodesResult payload = default(ListReturnReasonCodesResult), List<Error> errors = default(List<Error>))
        {
            this.Payload = payload;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public ListReturnReasonCodesResult Payload { get; set; }

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
            sb.Append("class ListReturnReasonCodesResponse {\n");
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

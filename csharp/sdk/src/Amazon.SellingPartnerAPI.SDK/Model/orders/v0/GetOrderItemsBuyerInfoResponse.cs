/*
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
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

namespace Amazon.SellingPartnerAPI.SDK.Model/orders/v0
{
    /// <summary>
    /// The response schema for the &#x60;getOrderItemsBuyerInfo&#x60; operation.
    /// </summary>
    [DataContract(Name = "GetOrderItemsBuyerInfoResponse")]
    public partial class GetOrderItemsBuyerInfoResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrderItemsBuyerInfoResponse" /> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="errors">A list of error responses returned when a request is unsuccessful..</param>
        public GetOrderItemsBuyerInfoResponse(OrderItemsBuyerInfoList payload = default(OrderItemsBuyerInfoList), List<Error> errors = default(List<Error>))
        {
            this.Payload = payload;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public OrderItemsBuyerInfoList Payload { get; set; }

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
            sb.Append("class GetOrderItemsBuyerInfoResponse {\n");
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

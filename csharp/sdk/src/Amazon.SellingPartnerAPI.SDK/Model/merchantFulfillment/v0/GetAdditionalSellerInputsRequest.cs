/*
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/merchantFulfillment/v0
{
    /// <summary>
    /// Request schema.
    /// </summary>
    [DataContract(Name = "GetAdditionalSellerInputsRequest")]
    public partial class GetAdditionalSellerInputsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdditionalSellerInputsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAdditionalSellerInputsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAdditionalSellerInputsRequest" /> class.
        /// </summary>
        /// <param name="shippingServiceId">An Amazon-defined shipping service identifier. (required).</param>
        /// <param name="shipFromAddress">shipFromAddress (required).</param>
        /// <param name="orderId">An Amazon-defined order identifier, in 3-7-7 format. (required).</param>
        public GetAdditionalSellerInputsRequest(string shippingServiceId = default(string), Address shipFromAddress = default(Address), string orderId = default(string))
        {
            // to ensure "shippingServiceId" is required (not null)
            if (shippingServiceId == null)
            {
                throw new ArgumentNullException("shippingServiceId is a required property for GetAdditionalSellerInputsRequest and cannot be null");
            }
            this.ShippingServiceId = shippingServiceId;
            // to ensure "shipFromAddress" is required (not null)
            if (shipFromAddress == null)
            {
                throw new ArgumentNullException("shipFromAddress is a required property for GetAdditionalSellerInputsRequest and cannot be null");
            }
            this.ShipFromAddress = shipFromAddress;
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new ArgumentNullException("orderId is a required property for GetAdditionalSellerInputsRequest and cannot be null");
            }
            this.OrderId = orderId;
        }

        /// <summary>
        /// An Amazon-defined shipping service identifier.
        /// </summary>
        /// <value>An Amazon-defined shipping service identifier.</value>
        [DataMember(Name = "ShippingServiceId", IsRequired = true, EmitDefaultValue = true)]
        public string ShippingServiceId { get; set; }

        /// <summary>
        /// Gets or Sets ShipFromAddress
        /// </summary>
        [DataMember(Name = "ShipFromAddress", IsRequired = true, EmitDefaultValue = true)]
        public Address ShipFromAddress { get; set; }

        /// <summary>
        /// An Amazon-defined order identifier, in 3-7-7 format.
        /// </summary>
        /// <value>An Amazon-defined order identifier, in 3-7-7 format.</value>
        [DataMember(Name = "OrderId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAdditionalSellerInputsRequest {\n");
            sb.Append("  ShippingServiceId: ").Append(ShippingServiceId).Append("\n");
            sb.Append("  ShipFromAddress: ").Append(ShipFromAddress).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
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

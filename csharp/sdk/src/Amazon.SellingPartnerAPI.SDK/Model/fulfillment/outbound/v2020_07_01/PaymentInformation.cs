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
    /// The attributes related to the payment made from customer to seller for this order.
    /// </summary>
    [DataContract(Name = "PaymentInformation")]
    public partial class PaymentInformation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInformation" /> class.
        /// </summary>
        /// <param name="paymentTransactionId">The transaction identifier of this payment. (required).</param>
        /// <param name="paymentMode">The transaction mode of this payment. (required).</param>
        /// <param name="paymentDate">Date timestamp (required).</param>
        public PaymentInformation(string paymentTransactionId = default(string), string paymentMode = default(string), DateTime paymentDate = default(DateTime))
        {
            // to ensure "paymentTransactionId" is required (not null)
            if (paymentTransactionId == null)
            {
                throw new ArgumentNullException("paymentTransactionId is a required property for PaymentInformation and cannot be null");
            }
            this.PaymentTransactionId = paymentTransactionId;
            // to ensure "paymentMode" is required (not null)
            if (paymentMode == null)
            {
                throw new ArgumentNullException("paymentMode is a required property for PaymentInformation and cannot be null");
            }
            this.PaymentMode = paymentMode;
            this.PaymentDate = paymentDate;
        }

        /// <summary>
        /// The transaction identifier of this payment.
        /// </summary>
        /// <value>The transaction identifier of this payment.</value>
        [DataMember(Name = "paymentTransactionId", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// The transaction mode of this payment.
        /// </summary>
        /// <value>The transaction mode of this payment.</value>
        [DataMember(Name = "paymentMode", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentMode { get; set; }

        /// <summary>
        /// Date timestamp
        /// </summary>
        /// <value>Date timestamp</value>
        [DataMember(Name = "paymentDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInformation {\n");
            sb.Append("  PaymentTransactionId: ").Append(PaymentTransactionId).Append("\n");
            sb.Append("  PaymentMode: ").Append(PaymentMode).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
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

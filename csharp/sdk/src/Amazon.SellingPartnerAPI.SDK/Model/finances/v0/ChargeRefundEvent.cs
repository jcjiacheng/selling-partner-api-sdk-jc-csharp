/*
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/finances/v0
{
    /// <summary>
    /// An event related to charge refund.
    /// </summary>
    [DataContract(Name = "ChargeRefundEvent")]
    public partial class ChargeRefundEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRefundEvent" /> class.
        /// </summary>
        /// <param name="postedDate">Fields with a schema type of date are in ISO 8601 date time format (for example GroupBeginDate)..</param>
        /// <param name="reasonCode">The reason given for a charge refund.  Example: &#x60;SubscriptionFeeCorrection&#x60;.</param>
        /// <param name="reasonCodeDescription">A description of the Reason Code.   Example: &#x60;SubscriptionFeeCorrection&#x60;.</param>
        /// <param name="chargeRefundTransactions">A list of &#x60;ChargeRefund&#x60; transactions.</param>
        public ChargeRefundEvent(DateTime postedDate = default(DateTime), string reasonCode = default(string), string reasonCodeDescription = default(string), List<ChargeRefundTransaction> chargeRefundTransactions = default(List<ChargeRefundTransaction>))
        {
            this.PostedDate = postedDate;
            this.ReasonCode = reasonCode;
            this.ReasonCodeDescription = reasonCodeDescription;
            this.ChargeRefundTransactions = chargeRefundTransactions;
        }

        /// <summary>
        /// Fields with a schema type of date are in ISO 8601 date time format (for example GroupBeginDate).
        /// </summary>
        /// <value>Fields with a schema type of date are in ISO 8601 date time format (for example GroupBeginDate).</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime PostedDate { get; set; }

        /// <summary>
        /// The reason given for a charge refund.  Example: &#x60;SubscriptionFeeCorrection&#x60;
        /// </summary>
        /// <value>The reason given for a charge refund.  Example: &#x60;SubscriptionFeeCorrection&#x60;</value>
        [DataMember(Name = "ReasonCode", EmitDefaultValue = false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// A description of the Reason Code.   Example: &#x60;SubscriptionFeeCorrection&#x60;
        /// </summary>
        /// <value>A description of the Reason Code.   Example: &#x60;SubscriptionFeeCorrection&#x60;</value>
        [DataMember(Name = "ReasonCodeDescription", EmitDefaultValue = false)]
        public string ReasonCodeDescription { get; set; }

        /// <summary>
        /// A list of &#x60;ChargeRefund&#x60; transactions
        /// </summary>
        /// <value>A list of &#x60;ChargeRefund&#x60; transactions</value>
        [DataMember(Name = "ChargeRefundTransactions", EmitDefaultValue = false)]
        public List<ChargeRefundTransaction> ChargeRefundTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeRefundEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  ReasonCodeDescription: ").Append(ReasonCodeDescription).Append("\n");
            sb.Append("  ChargeRefundTransactions: ").Append(ChargeRefundTransactions).Append("\n");
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

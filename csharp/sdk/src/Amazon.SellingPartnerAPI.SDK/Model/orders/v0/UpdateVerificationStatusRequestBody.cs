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
    /// The updated values of the &#x60;VerificationStatus&#x60; field.
    /// </summary>
    [DataContract(Name = "UpdateVerificationStatusRequestBody")]
    public partial class UpdateVerificationStatusRequestBody : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public VerificationStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerificationStatusRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateVerificationStatusRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVerificationStatusRequestBody" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="externalReviewerId">The identifier of the order&#39;s regulated information reviewer. (required).</param>
        /// <param name="rejectionReasonId">The unique identifier of the rejection reason used for rejecting the order&#39;s regulated information. Only required if the new status is rejected..</param>
        /// <param name="verificationDetails">verificationDetails.</param>
        public UpdateVerificationStatusRequestBody(VerificationStatus? status = default(VerificationStatus?), string externalReviewerId = default(string), string rejectionReasonId = default(string), VerificationDetails verificationDetails = default(VerificationDetails))
        {
            // to ensure "externalReviewerId" is required (not null)
            if (externalReviewerId == null)
            {
                throw new ArgumentNullException("externalReviewerId is a required property for UpdateVerificationStatusRequestBody and cannot be null");
            }
            this.ExternalReviewerId = externalReviewerId;
            this.Status = status;
            this.RejectionReasonId = rejectionReasonId;
            this.VerificationDetails = verificationDetails;
        }

        /// <summary>
        /// The identifier of the order&#39;s regulated information reviewer.
        /// </summary>
        /// <value>The identifier of the order&#39;s regulated information reviewer.</value>
        [DataMember(Name = "externalReviewerId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalReviewerId { get; set; }

        /// <summary>
        /// The unique identifier of the rejection reason used for rejecting the order&#39;s regulated information. Only required if the new status is rejected.
        /// </summary>
        /// <value>The unique identifier of the rejection reason used for rejecting the order&#39;s regulated information. Only required if the new status is rejected.</value>
        [DataMember(Name = "rejectionReasonId", EmitDefaultValue = false)]
        public string RejectionReasonId { get; set; }

        /// <summary>
        /// Gets or Sets VerificationDetails
        /// </summary>
        [DataMember(Name = "verificationDetails", EmitDefaultValue = false)]
        public VerificationDetails VerificationDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateVerificationStatusRequestBody {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExternalReviewerId: ").Append(ExternalReviewerId).Append("\n");
            sb.Append("  RejectionReasonId: ").Append(RejectionReasonId).Append("\n");
            sb.Append("  VerificationDetails: ").Append(VerificationDetails).Append("\n");
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

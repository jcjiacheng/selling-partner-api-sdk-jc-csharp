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
    /// The types of verification details that may be provided for the order and the criteria required for when the type of verification detail can be provided. The types of verification details allowed depend on the type of regulated product and will not change order to order.
    /// </summary>
    [DataContract(Name = "ValidVerificationDetail")]
    public partial class ValidVerificationDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidVerificationDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidVerificationDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidVerificationDetail" /> class.
        /// </summary>
        /// <param name="verificationDetailType">A supported type of verification detail. The type indicates which verification detail could be shared while updating the regulated order. Valid value: &#x60;prescriptionDetail&#x60;. (required).</param>
        /// <param name="validVerificationStatuses">A list of valid verification statuses where the associated verification detail type may be provided. For example, if the value of this field is [\&quot;Approved\&quot;], calls to provide the associated verification detail will fail for orders with a &#x60;VerificationStatus&#x60; of &#x60;Pending&#x60;, &#x60;Rejected&#x60;, &#x60;Expired&#x60;, or &#x60;Cancelled&#x60;. (required).</param>
        public ValidVerificationDetail(string verificationDetailType = default(string), List<VerificationStatus> validVerificationStatuses = default(List<VerificationStatus>))
        {
            // to ensure "verificationDetailType" is required (not null)
            if (verificationDetailType == null)
            {
                throw new ArgumentNullException("verificationDetailType is a required property for ValidVerificationDetail and cannot be null");
            }
            this.VerificationDetailType = verificationDetailType;
            // to ensure "validVerificationStatuses" is required (not null)
            if (validVerificationStatuses == null)
            {
                throw new ArgumentNullException("validVerificationStatuses is a required property for ValidVerificationDetail and cannot be null");
            }
            this.ValidVerificationStatuses = validVerificationStatuses;
        }

        /// <summary>
        /// A supported type of verification detail. The type indicates which verification detail could be shared while updating the regulated order. Valid value: &#x60;prescriptionDetail&#x60;.
        /// </summary>
        /// <value>A supported type of verification detail. The type indicates which verification detail could be shared while updating the regulated order. Valid value: &#x60;prescriptionDetail&#x60;.</value>
        [DataMember(Name = "VerificationDetailType", IsRequired = true, EmitDefaultValue = true)]
        public string VerificationDetailType { get; set; }

        /// <summary>
        /// A list of valid verification statuses where the associated verification detail type may be provided. For example, if the value of this field is [\&quot;Approved\&quot;], calls to provide the associated verification detail will fail for orders with a &#x60;VerificationStatus&#x60; of &#x60;Pending&#x60;, &#x60;Rejected&#x60;, &#x60;Expired&#x60;, or &#x60;Cancelled&#x60;.
        /// </summary>
        /// <value>A list of valid verification statuses where the associated verification detail type may be provided. For example, if the value of this field is [\&quot;Approved\&quot;], calls to provide the associated verification detail will fail for orders with a &#x60;VerificationStatus&#x60; of &#x60;Pending&#x60;, &#x60;Rejected&#x60;, &#x60;Expired&#x60;, or &#x60;Cancelled&#x60;.</value>
        [DataMember(Name = "ValidVerificationStatuses", IsRequired = true, EmitDefaultValue = true)]
        public List<VerificationStatus> ValidVerificationStatuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidVerificationDetail {\n");
            sb.Append("  VerificationDetailType: ").Append(VerificationDetailType).Append("\n");
            sb.Append("  ValidVerificationStatuses: ").Append(ValidVerificationStatuses).Append("\n");
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

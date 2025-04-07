/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer pricing information for Amazon Marketplace products.  For more information, refer to the [Product Pricing v2022-05-01 Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/product-pricing-api-v2022-05-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2022-05-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/pricing/v2022_05_01
{
    /// <summary>
    /// The response for the individual &#x60;competitiveSummary&#x60; request in the batch operation.
    /// </summary>
    [DataContract(Name = "CompetitiveSummaryResponse")]
    public partial class CompetitiveSummaryResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitiveSummaryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompetitiveSummaryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitiveSummaryResponse" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="body">body (required).</param>
        public CompetitiveSummaryResponse(HttpStatusLine status = default(HttpStatusLine), CompetitiveSummaryResponseBody body = default(CompetitiveSummaryResponseBody))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for CompetitiveSummaryResponse and cannot be null");
            }
            this.Status = status;
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for CompetitiveSummaryResponse and cannot be null");
            }
            this.Body = body;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public HttpStatusLine Status { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public CompetitiveSummaryResponseBody Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompetitiveSummaryResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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

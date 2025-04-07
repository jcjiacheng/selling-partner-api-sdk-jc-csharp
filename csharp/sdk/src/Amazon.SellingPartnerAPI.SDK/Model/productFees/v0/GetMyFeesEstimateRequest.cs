/*
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/productFees/v0
{
    /// <summary>
    /// Request schema.
    /// </summary>
    [DataContract(Name = "GetMyFeesEstimateRequest")]
    public partial class GetMyFeesEstimateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMyFeesEstimateRequest" /> class.
        /// </summary>
        /// <param name="feesEstimateRequest">feesEstimateRequest.</param>
        public GetMyFeesEstimateRequest(FeesEstimateRequest feesEstimateRequest = default(FeesEstimateRequest))
        {
            this.FeesEstimateRequest = feesEstimateRequest;
        }

        /// <summary>
        /// Gets or Sets FeesEstimateRequest
        /// </summary>
        [DataMember(Name = "FeesEstimateRequest", EmitDefaultValue = false)]
        public FeesEstimateRequest FeesEstimateRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetMyFeesEstimateRequest {\n");
            sb.Append("  FeesEstimateRequest: ").Append(FeesEstimateRequest).Append("\n");
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

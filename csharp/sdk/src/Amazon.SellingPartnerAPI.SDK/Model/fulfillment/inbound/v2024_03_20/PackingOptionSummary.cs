/*
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * The version of the OpenAPI document: 2024-03-20
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v2024_03_20
{
    /// <summary>
    /// Summary information about a packing option.
    /// </summary>
    [DataContract(Name = "PackingOptionSummary")]
    public partial class PackingOptionSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingOptionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackingOptionSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackingOptionSummary" /> class.
        /// </summary>
        /// <param name="packingOptionId">Identifier of a packing option. (required).</param>
        /// <param name="status">The status of a packing option. Possible values: &#39;OFFERED&#39;, &#39;ACCEPTED&#39;, &#39;EXPIRED&#39;. (required).</param>
        public PackingOptionSummary(string packingOptionId = default(string), string status = default(string))
        {
            // to ensure "packingOptionId" is required (not null)
            if (packingOptionId == null)
            {
                throw new ArgumentNullException("packingOptionId is a required property for PackingOptionSummary and cannot be null");
            }
            this.PackingOptionId = packingOptionId;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PackingOptionSummary and cannot be null");
            }
            this.Status = status;
        }

        /// <summary>
        /// Identifier of a packing option.
        /// </summary>
        /// <value>Identifier of a packing option.</value>
        [DataMember(Name = "packingOptionId", IsRequired = true, EmitDefaultValue = true)]
        public string PackingOptionId { get; set; }

        /// <summary>
        /// The status of a packing option. Possible values: &#39;OFFERED&#39;, &#39;ACCEPTED&#39;, &#39;EXPIRED&#39;.
        /// </summary>
        /// <value>The status of a packing option. Possible values: &#39;OFFERED&#39;, &#39;ACCEPTED&#39;, &#39;EXPIRED&#39;.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PackingOptionSummary {\n");
            sb.Append("  PackingOptionId: ").Append(PackingOptionId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            // PackingOptionId (string) maxLength
            if (this.PackingOptionId != null && this.PackingOptionId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for PackingOptionId, length must be less than 38.", new [] { "PackingOptionId" });
            }

            // PackingOptionId (string) minLength
            if (this.PackingOptionId != null && this.PackingOptionId.Length < 38)
            {
                yield return new ValidationResult("Invalid value for PackingOptionId, length must be greater than 38.", new [] { "PackingOptionId" });
            }

            if (this.PackingOptionId != null) {
                // PackingOptionId (string) pattern
                Regex regexPackingOptionId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
                if (!regexPackingOptionId.Match(this.PackingOptionId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PackingOptionId, must match a pattern of " + regexPackingOptionId, new [] { "PackingOptionId" });
                }
            }

            // Status (string) maxLength
            if (this.Status != null && this.Status.Length > 1024)
            {
                yield return new ValidationResult("Invalid value for Status, length must be less than 1024.", new [] { "Status" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }

}

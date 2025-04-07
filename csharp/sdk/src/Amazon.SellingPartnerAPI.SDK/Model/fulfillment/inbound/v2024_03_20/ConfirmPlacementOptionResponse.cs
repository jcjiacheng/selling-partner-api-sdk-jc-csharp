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
    /// The &#x60;confirmPlacementOption&#x60; response.
    /// </summary>
    [DataContract(Name = "ConfirmPlacementOptionResponse")]
    public partial class ConfirmPlacementOptionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmPlacementOptionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfirmPlacementOptionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmPlacementOptionResponse" /> class.
        /// </summary>
        /// <param name="operationId">UUID for the given operation. (required).</param>
        public ConfirmPlacementOptionResponse(string operationId = default(string))
        {
            // to ensure "operationId" is required (not null)
            if (operationId == null)
            {
                throw new ArgumentNullException("operationId is a required property for ConfirmPlacementOptionResponse and cannot be null");
            }
            this.OperationId = operationId;
        }

        /// <summary>
        /// UUID for the given operation.
        /// </summary>
        /// <value>UUID for the given operation.</value>
        [DataMember(Name = "operationId", IsRequired = true, EmitDefaultValue = true)]
        public string OperationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfirmPlacementOptionResponse {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
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
            // OperationId (string) maxLength
            if (this.OperationId != null && this.OperationId.Length > 38)
            {
                yield return new ValidationResult("Invalid value for OperationId, length must be less than 38.", new [] { "OperationId" });
            }

            // OperationId (string) minLength
            if (this.OperationId != null && this.OperationId.Length < 36)
            {
                yield return new ValidationResult("Invalid value for OperationId, length must be greater than 36.", new [] { "OperationId" });
            }

            if (this.OperationId != null) {
                // OperationId (string) pattern
                Regex regexOperationId = new Regex(@"^[a-zA-Z0-9-]*$", RegexOptions.CultureInvariant);
                if (!regexOperationId.Match(this.OperationId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, must match a pattern of " + regexOperationId, new [] { "OperationId" });
                }
            }

            yield break;
        }
    }

}

/*
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
 *
 * The version of the OpenAPI document: v1
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

namespace Amazon.SellingPartnerAPI.SDK.Model/services/v1
{
    /// <summary>
    /// Document that captured during service appointment fulfillment that portrays proof of completion
    /// </summary>
    [DataContract(Name = "FulfillmentDocument")]
    public partial class FulfillmentDocument : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentDocument" /> class.
        /// </summary>
        /// <param name="uploadDestinationId">The identifier of the upload destination. Get this value by calling the &#x60;createServiceDocumentUploadDestination&#x60; operation of the Services API..</param>
        /// <param name="contentSha256">Sha256 hash of the file content. This value is used to determine if the file has been corrupted or tampered with during transit..</param>
        public FulfillmentDocument(string uploadDestinationId = default(string), string contentSha256 = default(string))
        {
            this.UploadDestinationId = uploadDestinationId;
            this.ContentSha256 = contentSha256;
        }

        /// <summary>
        /// The identifier of the upload destination. Get this value by calling the &#x60;createServiceDocumentUploadDestination&#x60; operation of the Services API.
        /// </summary>
        /// <value>The identifier of the upload destination. Get this value by calling the &#x60;createServiceDocumentUploadDestination&#x60; operation of the Services API.</value>
        [DataMember(Name = "uploadDestinationId", EmitDefaultValue = false)]
        public string UploadDestinationId { get; set; }

        /// <summary>
        /// Sha256 hash of the file content. This value is used to determine if the file has been corrupted or tampered with during transit.
        /// </summary>
        /// <value>Sha256 hash of the file content. This value is used to determine if the file has been corrupted or tampered with during transit.</value>
        [DataMember(Name = "contentSha256", EmitDefaultValue = false)]
        public string ContentSha256 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FulfillmentDocument {\n");
            sb.Append("  UploadDestinationId: ").Append(UploadDestinationId).Append("\n");
            sb.Append("  ContentSha256: ").Append(ContentSha256).Append("\n");
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

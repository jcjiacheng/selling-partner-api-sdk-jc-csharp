/*
 * Selling Partner API for A+ Content Management
 *
 * Use the A+ Content API to build applications that help selling partners add rich marketing content to their Amazon product detail pages. Selling partners can use A+ content to share their brand and product story, which helps buyers make informed purchasing decisions. Selling partners use content modules to add images and text.
 *
 * The version of the OpenAPI document: 2020-11-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/aplusContent/v2020_11_01
{
    /// <summary>
    /// PostContentDocumentResponse
    /// </summary>
    [DataContract(Name = "PostContentDocumentResponse")]
    public partial class PostContentDocumentResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContentDocumentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostContentDocumentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContentDocumentResponse" /> class.
        /// </summary>
        /// <param name="warnings">A set of messages to the user, such as warnings or comments..</param>
        /// <param name="contentReferenceKey">A unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier. (required).</param>
        public PostContentDocumentResponse(List<Error> warnings = default(List<Error>), string contentReferenceKey = default(string))
        {
            // to ensure "contentReferenceKey" is required (not null)
            if (contentReferenceKey == null)
            {
                throw new ArgumentNullException("contentReferenceKey is a required property for PostContentDocumentResponse and cannot be null");
            }
            this.ContentReferenceKey = contentReferenceKey;
            this.Warnings = warnings;
        }

        /// <summary>
        /// A set of messages to the user, such as warnings or comments.
        /// </summary>
        /// <value>A set of messages to the user, such as warnings or comments.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<Error> Warnings { get; set; }

        /// <summary>
        /// A unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier.
        /// </summary>
        /// <value>A unique reference key for the A+ Content document. A content reference key cannot form a permalink and might change in the future. A content reference key is not guaranteed to match any A+ content identifier.</value>
        [DataMember(Name = "contentReferenceKey", IsRequired = true, EmitDefaultValue = true)]
        public string ContentReferenceKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostContentDocumentResponse {\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  ContentReferenceKey: ").Append(ContentReferenceKey).Append("\n");
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
            // ContentReferenceKey (string) minLength
            if (this.ContentReferenceKey != null && this.ContentReferenceKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ContentReferenceKey, length must be greater than 1.", new [] { "ContentReferenceKey" });
            }

            yield break;
        }
    }

}

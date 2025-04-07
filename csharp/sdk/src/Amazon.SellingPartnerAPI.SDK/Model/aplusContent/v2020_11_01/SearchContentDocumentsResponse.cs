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
    /// SearchContentDocumentsResponse
    /// </summary>
    [DataContract(Name = "SearchContentDocumentsResponse")]
    public partial class SearchContentDocumentsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchContentDocumentsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchContentDocumentsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchContentDocumentsResponse" /> class.
        /// </summary>
        /// <param name="warnings">A set of messages to the user, such as warnings or comments..</param>
        /// <param name="nextPageToken">A token that you use to fetch a specific page when there are multiple pages of results..</param>
        /// <param name="contentMetadataRecords">A list of A+ Content metadata records. (required).</param>
        public SearchContentDocumentsResponse(List<Error> warnings = default(List<Error>), string nextPageToken = default(string), List<ContentMetadataRecord> contentMetadataRecords = default(List<ContentMetadataRecord>))
        {
            // to ensure "contentMetadataRecords" is required (not null)
            if (contentMetadataRecords == null)
            {
                throw new ArgumentNullException("contentMetadataRecords is a required property for SearchContentDocumentsResponse and cannot be null");
            }
            this.ContentMetadataRecords = contentMetadataRecords;
            this.Warnings = warnings;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// A set of messages to the user, such as warnings or comments.
        /// </summary>
        /// <value>A set of messages to the user, such as warnings or comments.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<Error> Warnings { get; set; }

        /// <summary>
        /// A token that you use to fetch a specific page when there are multiple pages of results.
        /// </summary>
        /// <value>A token that you use to fetch a specific page when there are multiple pages of results.</value>
        [DataMember(Name = "nextPageToken", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// A list of A+ Content metadata records.
        /// </summary>
        /// <value>A list of A+ Content metadata records.</value>
        [DataMember(Name = "contentMetadataRecords", IsRequired = true, EmitDefaultValue = true)]
        public List<ContentMetadataRecord> ContentMetadataRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchContentDocumentsResponse {\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
            sb.Append("  ContentMetadataRecords: ").Append(ContentMetadataRecords).Append("\n");
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
            // NextPageToken (string) minLength
            if (this.NextPageToken != null && this.NextPageToken.Length < 1)
            {
                yield return new ValidationResult("Invalid value for NextPageToken, length must be greater than 1.", new [] { "NextPageToken" });
            }

            yield break;
        }
    }

}

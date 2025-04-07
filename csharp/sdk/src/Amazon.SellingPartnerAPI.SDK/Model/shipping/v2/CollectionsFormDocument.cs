/*
 * Amazon Shipping API
 *
 * The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.
 *
 * The version of the OpenAPI document: v2
 * Contact: swa-api-core@amazon.com
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

namespace Amazon.SellingPartnerAPI.SDK.Model/shipping/v2
{
    /// <summary>
    /// Collection Form Document Details
    /// </summary>
    [DataContract(Name = "CollectionsFormDocument")]
    public partial class CollectionsFormDocument : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsFormDocument" /> class.
        /// </summary>
        /// <param name="base64EncodedContent">Base64 document Value of Collection..</param>
        /// <param name="documentFormat">Collection Document format is PDF..</param>
        public CollectionsFormDocument(string base64EncodedContent = default(string), string documentFormat = default(string))
        {
            this.Base64EncodedContent = base64EncodedContent;
            this.DocumentFormat = documentFormat;
        }

        /// <summary>
        /// Base64 document Value of Collection.
        /// </summary>
        /// <value>Base64 document Value of Collection.</value>
        [DataMember(Name = "base64EncodedContent", EmitDefaultValue = false)]
        public string Base64EncodedContent { get; set; }

        /// <summary>
        /// Collection Document format is PDF.
        /// </summary>
        /// <value>Collection Document format is PDF.</value>
        [DataMember(Name = "documentFormat", EmitDefaultValue = false)]
        public string DocumentFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionsFormDocument {\n");
            sb.Append("  Base64EncodedContent: ").Append(Base64EncodedContent).Append("\n");
            sb.Append("  DocumentFormat: ").Append(DocumentFormat).Append("\n");
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

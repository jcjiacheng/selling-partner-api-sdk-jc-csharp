/*
 * Selling Partner API for Product Type Definitions
 *
 * The Selling Partner API for Product Type Definitions provides programmatic access to attribute and data requirements for product types in the Amazon catalog. Use this API to return the JSON Schema for a product type that you can then use with other Selling Partner APIs, such as the Selling Partner API for Listings Items, the Selling Partner API for Catalog Items, and the Selling Partner API for Feeds (for JSON-based listing feeds).  For more information, see the [Product Type Definitions API Use Case Guide](doc:product-type-api-use-case-guide).
 *
 * The version of the OpenAPI document: 2020-09-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/productTypeDefinitions/v2020_09_01
{
    /// <summary>
    /// Link to retrieve the schema.
    /// </summary>
    [DataContract(Name = "SchemaLink_link")]
    public partial class SchemaLinkLink : IValidatableObject
    {
        /// <summary>
        /// HTTP method for the link operation.
        /// </summary>
        /// <value>HTTP method for the link operation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerbEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 1
        }


        /// <summary>
        /// HTTP method for the link operation.
        /// </summary>
        /// <value>HTTP method for the link operation.</value>
        [DataMember(Name = "verb", IsRequired = true, EmitDefaultValue = true)]
        public VerbEnum Verb { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaLinkLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchemaLinkLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaLinkLink" /> class.
        /// </summary>
        /// <param name="resource">URI resource for the link. (required).</param>
        /// <param name="verb">HTTP method for the link operation. (required).</param>
        public SchemaLinkLink(string resource = default(string), VerbEnum verb = default(VerbEnum))
        {
            // to ensure "resource" is required (not null)
            if (resource == null)
            {
                throw new ArgumentNullException("resource is a required property for SchemaLinkLink and cannot be null");
            }
            this.Resource = resource;
            this.Verb = verb;
        }

        /// <summary>
        /// URI resource for the link.
        /// </summary>
        /// <value>URI resource for the link.</value>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = true)]
        public string Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchemaLinkLink {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
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

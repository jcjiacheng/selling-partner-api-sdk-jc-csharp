/*
 * Selling Partner API for Solicitations
 *
 * With the Solicitations API you can build applications that send non-critical solicitations to buyers. You can get a list of solicitation types that are available for an order that you specify, then call an operation that sends a solicitation to the buyer for that order. Buyers cannot respond to solicitations sent by this API, and these solicitations do not appear in the Messaging section of Seller Central or in the recipient's Message Center. The Solicitations API returns responses that are formed according to the <a href=https://tools.ietf.org/html/draft-kelly-json-hal-08>JSON Hypertext Application Language</a> (HAL) standard.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/solicitations/v1
{
    /// <summary>
    /// GetSolicitationActionResponseLinks
    /// </summary>
    [DataContract(Name = "GetSolicitationActionResponse__links")]
    public partial class GetSolicitationActionResponseLinks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolicitationActionResponseLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSolicitationActionResponseLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSolicitationActionResponseLinks" /> class.
        /// </summary>
        /// <param name="self">self (required).</param>
        /// <param name="schema">schema (required).</param>
        public GetSolicitationActionResponseLinks(LinkObject self = default(LinkObject), LinkObject schema = default(LinkObject))
        {
            // to ensure "self" is required (not null)
            if (self == null)
            {
                throw new ArgumentNullException("self is a required property for GetSolicitationActionResponseLinks and cannot be null");
            }
            this.Self = self;
            // to ensure "schema" is required (not null)
            if (schema == null)
            {
                throw new ArgumentNullException("schema is a required property for GetSolicitationActionResponseLinks and cannot be null");
            }
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", IsRequired = true, EmitDefaultValue = true)]
        public LinkObject Self { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", IsRequired = true, EmitDefaultValue = true)]
        public LinkObject Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSolicitationActionResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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

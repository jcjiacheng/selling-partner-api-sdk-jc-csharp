/*
 * Selling Partner API for Catalog Items
 *
 * Use the Selling Partner API for Catalog Items to retrieve information about items in the Amazon catalog.  For more information, refer to the [Catalog Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/:catalog-items-api-v2022-04-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2022-04-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/catalogItems/v2022_04_01
{
    /// <summary>
    /// Individual contributor to the creation of an item, such as an author or actor.
    /// </summary>
    [DataContract(Name = "ItemContributor")]
    public partial class ItemContributor : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemContributor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemContributor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemContributor" /> class.
        /// </summary>
        /// <param name="role">role (required).</param>
        /// <param name="value">Name of the contributor, such as &#x60;Jane Austen&#x60;. (required).</param>
        public ItemContributor(ItemContributorRole role = default(ItemContributorRole), string value = default(string))
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for ItemContributor and cannot be null");
            }
            this.Role = role;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ItemContributor and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public ItemContributorRole Role { get; set; }

        /// <summary>
        /// Name of the contributor, such as &#x60;Jane Austen&#x60;.
        /// </summary>
        /// <value>Name of the contributor, such as &#x60;Jane Austen&#x60;.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemContributor {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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

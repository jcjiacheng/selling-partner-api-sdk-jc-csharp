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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.productTypeDefinitions.v2020_09_01
{
    /// <summary>
    /// A property group represents a logical grouping of schema properties that can be used for display or informational purposes.
    /// </summary>
    [DataContract(Name = "PropertyGroup")]
    public partial class PropertyGroup : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyGroup" /> class.
        /// </summary>
        /// <param name="title">The display label of the property group..</param>
        /// <param name="description">The description of the property group..</param>
        /// <param name="propertyNames">The names of the schema properties for the property group..</param>
        public PropertyGroup(string title = default(string), string description = default(string), List<string> propertyNames = default(List<string>))
        {
            this.Title = title;
            this.Description = description;
            this.PropertyNames = propertyNames;
        }

        /// <summary>
        /// The display label of the property group.
        /// </summary>
        /// <value>The display label of the property group.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the property group.
        /// </summary>
        /// <value>The description of the property group.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The names of the schema properties for the property group.
        /// </summary>
        /// <value>The names of the schema properties for the property group.</value>
        [DataMember(Name = "propertyNames", EmitDefaultValue = false)]
        public List<string> PropertyNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyGroup {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PropertyNames: ").Append(PropertyNames).Append("\n");
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

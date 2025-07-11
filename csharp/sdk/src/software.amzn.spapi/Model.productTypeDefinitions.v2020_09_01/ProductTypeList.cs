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
    /// A list of Amazon product types with definitions available.
    /// </summary>
    [DataContract(Name = "ProductTypeList")]
    public partial class ProductTypeList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTypeList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductTypeList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTypeList" /> class.
        /// </summary>
        /// <param name="productTypes">productTypes (required).</param>
        /// <param name="productTypeVersion">Amazon product type version identifier. (required).</param>
        public ProductTypeList(List<ProductType> productTypes = default(List<ProductType>), string productTypeVersion = default(string))
        {
            // to ensure "productTypes" is required (not null)
            if (productTypes == null)
            {
                throw new ArgumentNullException("productTypes is a required property for ProductTypeList and cannot be null");
            }
            this.ProductTypes = productTypes;
            // to ensure "productTypeVersion" is required (not null)
            if (productTypeVersion == null)
            {
                throw new ArgumentNullException("productTypeVersion is a required property for ProductTypeList and cannot be null");
            }
            this.ProductTypeVersion = productTypeVersion;
        }

        /// <summary>
        /// Gets or Sets ProductTypes
        /// </summary>
        [DataMember(Name = "productTypes", IsRequired = true, EmitDefaultValue = true)]
        public List<ProductType> ProductTypes { get; set; }

        /// <summary>
        /// Amazon product type version identifier.
        /// </summary>
        /// <value>Amazon product type version identifier.</value>
        [DataMember(Name = "productTypeVersion", IsRequired = true, EmitDefaultValue = true)]
        public string ProductTypeVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductTypeList {\n");
            sb.Append("  ProductTypes: ").Append(ProductTypes).Append("\n");
            sb.Append("  ProductTypeVersion: ").Append(ProductTypeVersion).Append("\n");
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

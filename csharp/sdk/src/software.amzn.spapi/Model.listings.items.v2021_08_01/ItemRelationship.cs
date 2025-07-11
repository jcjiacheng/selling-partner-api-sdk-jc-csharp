/*
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/listings-items-api-v2021-08-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2021-08-01
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

namespace software.amzn.spapi.Model.listings.items.v2021_08_01
{
    /// <summary>
    /// The relationship details for a listing item.
    /// </summary>
    [DataContract(Name = "ItemRelationship")]
    public partial class ItemRelationship : IValidatableObject
    {
        /// <summary>
        /// The type of relationship.
        /// </summary>
        /// <value>The type of relationship.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum VARIATION for value: VARIATION
            /// </summary>
            [EnumMember(Value = "VARIATION")]
            VARIATION = 1,

            /// <summary>
            /// Enum PACKAGEHIERARCHY for value: PACKAGE_HIERARCHY
            /// </summary>
            [EnumMember(Value = "PACKAGE_HIERARCHY")]
            PACKAGEHIERARCHY = 2
        }


        /// <summary>
        /// The type of relationship.
        /// </summary>
        /// <value>The type of relationship.</value>
        /*
        <example>VARIATION</example>
        */
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelationship" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemRelationship() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelationship" /> class.
        /// </summary>
        /// <param name="childSkus">Identifiers (SKUs) of the related items that are children of this listing item..</param>
        /// <param name="parentSkus">Identifiers (SKUs) of the related items that are parents of this listing item..</param>
        /// <param name="variationTheme">variationTheme.</param>
        /// <param name="type">The type of relationship. (required).</param>
        public ItemRelationship(List<string> childSkus = default(List<string>), List<string> parentSkus = default(List<string>), ItemVariationTheme variationTheme = default(ItemVariationTheme), TypeEnum type = default(TypeEnum))
        {
            this.Type = type;
            this.ChildSkus = childSkus;
            this.ParentSkus = parentSkus;
            this.VariationTheme = variationTheme;
        }

        /// <summary>
        /// Identifiers (SKUs) of the related items that are children of this listing item.
        /// </summary>
        /// <value>Identifiers (SKUs) of the related items that are children of this listing item.</value>
        [DataMember(Name = "childSkus", EmitDefaultValue = false)]
        public List<string> ChildSkus { get; set; }

        /// <summary>
        /// Identifiers (SKUs) of the related items that are parents of this listing item.
        /// </summary>
        /// <value>Identifiers (SKUs) of the related items that are parents of this listing item.</value>
        [DataMember(Name = "parentSkus", EmitDefaultValue = false)]
        public List<string> ParentSkus { get; set; }

        /// <summary>
        /// Gets or Sets VariationTheme
        /// </summary>
        [DataMember(Name = "variationTheme", EmitDefaultValue = false)]
        public ItemVariationTheme VariationTheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemRelationship {\n");
            sb.Append("  ChildSkus: ").Append(ChildSkus).Append("\n");
            sb.Append("  ParentSkus: ").Append(ParentSkus).Append("\n");
            sb.Append("  VariationTheme: ").Append(VariationTheme).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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

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
    /// The standard table of technical feature names and definitions.
    /// </summary>
    [DataContract(Name = "StandardTechSpecsModule")]
    public partial class StandardTechSpecsModule : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardTechSpecsModule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StandardTechSpecsModule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardTechSpecsModule" /> class.
        /// </summary>
        /// <param name="headline">headline.</param>
        /// <param name="specificationList">The specification list. (required).</param>
        /// <param name="tableCount">The number of tables you want present. Features are evenly divided between the tables..</param>
        public StandardTechSpecsModule(TextComponent headline = default(TextComponent), List<StandardTextPairBlock> specificationList = default(List<StandardTextPairBlock>), int tableCount = default(int))
        {
            // to ensure "specificationList" is required (not null)
            if (specificationList == null)
            {
                throw new ArgumentNullException("specificationList is a required property for StandardTechSpecsModule and cannot be null");
            }
            this.SpecificationList = specificationList;
            this.Headline = headline;
            this.TableCount = tableCount;
        }

        /// <summary>
        /// Gets or Sets Headline
        /// </summary>
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        public TextComponent Headline { get; set; }

        /// <summary>
        /// The specification list.
        /// </summary>
        /// <value>The specification list.</value>
        [DataMember(Name = "specificationList", IsRequired = true, EmitDefaultValue = true)]
        public List<StandardTextPairBlock> SpecificationList { get; set; }

        /// <summary>
        /// The number of tables you want present. Features are evenly divided between the tables.
        /// </summary>
        /// <value>The number of tables you want present. Features are evenly divided between the tables.</value>
        [DataMember(Name = "tableCount", EmitDefaultValue = false)]
        public int TableCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StandardTechSpecsModule {\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  SpecificationList: ").Append(SpecificationList).Append("\n");
            sb.Append("  TableCount: ").Append(TableCount).Append("\n");
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
            // TableCount (int) maximum
            if (this.TableCount > (int)2)
            {
                yield return new ValidationResult("Invalid value for TableCount, must be a value less than or equal to 2.", new [] { "TableCount" });
            }

            // TableCount (int) minimum
            if (this.TableCount < (int)1)
            {
                yield return new ValidationResult("Invalid value for TableCount, must be a value greater than or equal to 1.", new [] { "TableCount" });
            }

            yield break;
        }
    }

}

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
    /// A classification that you can use to refine your search.
    /// </summary>
    [DataContract(Name = "ClassificationRefinement")]
    public partial class ClassificationRefinement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationRefinement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClassificationRefinement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationRefinement" /> class.
        /// </summary>
        /// <param name="numberOfResults">The estimated number of results that would be returned if you refine your search by the specified &#x60;classificationId&#x60;. (required).</param>
        /// <param name="displayName">Display name for the classification. (required).</param>
        /// <param name="classificationId">The identifier of the classification that you can use to refine your search. (required).</param>
        public ClassificationRefinement(int numberOfResults = default(int), string displayName = default(string), string classificationId = default(string))
        {
            this.NumberOfResults = numberOfResults;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for ClassificationRefinement and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "classificationId" is required (not null)
            if (classificationId == null)
            {
                throw new ArgumentNullException("classificationId is a required property for ClassificationRefinement and cannot be null");
            }
            this.ClassificationId = classificationId;
        }

        /// <summary>
        /// The estimated number of results that would be returned if you refine your search by the specified &#x60;classificationId&#x60;.
        /// </summary>
        /// <value>The estimated number of results that would be returned if you refine your search by the specified &#x60;classificationId&#x60;.</value>
        [DataMember(Name = "numberOfResults", IsRequired = true, EmitDefaultValue = true)]
        public int NumberOfResults { get; set; }

        /// <summary>
        /// Display name for the classification.
        /// </summary>
        /// <value>Display name for the classification.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The identifier of the classification that you can use to refine your search.
        /// </summary>
        /// <value>The identifier of the classification that you can use to refine your search.</value>
        [DataMember(Name = "classificationId", IsRequired = true, EmitDefaultValue = true)]
        public string ClassificationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClassificationRefinement {\n");
            sb.Append("  NumberOfResults: ").Append(NumberOfResults).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ClassificationId: ").Append(ClassificationId).Append("\n");
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

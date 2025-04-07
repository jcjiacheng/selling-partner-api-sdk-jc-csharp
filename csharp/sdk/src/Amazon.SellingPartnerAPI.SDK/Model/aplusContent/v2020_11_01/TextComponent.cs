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
    /// Rich text content.
    /// </summary>
    [DataContract(Name = "TextComponent")]
    public partial class TextComponent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextComponent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextComponent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextComponent" /> class.
        /// </summary>
        /// <param name="value">The actual plain text. (required).</param>
        /// <param name="decoratorSet">A set of content decorators..</param>
        public TextComponent(string value = default(string), List<Decorator> decoratorSet = default(List<Decorator>))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for TextComponent and cannot be null");
            }
            this.Value = value;
            this.DecoratorSet = decoratorSet;
        }

        /// <summary>
        /// The actual plain text.
        /// </summary>
        /// <value>The actual plain text.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// A set of content decorators.
        /// </summary>
        /// <value>A set of content decorators.</value>
        [DataMember(Name = "decoratorSet", EmitDefaultValue = false)]
        public List<Decorator> DecoratorSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TextComponent {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DecoratorSet: ").Append(DecoratorSet).Append("\n");
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
            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 10000)
            {
                yield return new ValidationResult("Invalid value for Value, length must be less than 10000.", new [] { "Value" });
            }

            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Value, length must be greater than 1.", new [] { "Value" });
            }

            yield break;
        }
    }

}

/*
 * Selling Partner API for Direct Fulfillment Shipping
 *
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * The version of the OpenAPI document: 2021-12-28
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/df/shipping/v2021_12_28
{
    /// <summary>
    /// The weight.
    /// </summary>
    [DataContract(Name = "Weight")]
    public partial class Weight : IValidatableObject
    {
        /// <summary>
        /// The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            /// <summary>
            /// Enum KG for value: KG
            /// </summary>
            [EnumMember(Value = "KG")]
            KG = 1,

            /// <summary>
            /// Enum LB for value: LB
            /// </summary>
            [EnumMember(Value = "LB")]
            LB = 2
        }


        /// <summary>
        /// The unit of measurement.
        /// </summary>
        /// <value>The unit of measurement.</value>
        [DataMember(Name = "unitOfMeasure", IsRequired = true, EmitDefaultValue = true)]
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Weight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Weight" /> class.
        /// </summary>
        /// <param name="unitOfMeasure">The unit of measurement. (required).</param>
        /// <param name="value">A decimal number with no loss of precision. Useful when precision loss is unacceptable, as with currencies. Follows RFC7159 for number representation.  &lt;br&gt;**Pattern** : &#x60;^-?(0|([1-9]\\\\d*))(\\\\.\\\\d+)?([eE][+-]?\\\\d+)?$&#x60;. (required).</param>
        public Weight(UnitOfMeasureEnum unitOfMeasure = default(UnitOfMeasureEnum), string value = default(string))
        {
            this.UnitOfMeasure = unitOfMeasure;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for Weight and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// A decimal number with no loss of precision. Useful when precision loss is unacceptable, as with currencies. Follows RFC7159 for number representation.  &lt;br&gt;**Pattern** : &#x60;^-?(0|([1-9]\\\\d*))(\\\\.\\\\d+)?([eE][+-]?\\\\d+)?$&#x60;.
        /// </summary>
        /// <value>A decimal number with no loss of precision. Useful when precision loss is unacceptable, as with currencies. Follows RFC7159 for number representation.  &lt;br&gt;**Pattern** : &#x60;^-?(0|([1-9]\\\\d*))(\\\\.\\\\d+)?([eE][+-]?\\\\d+)?$&#x60;.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Weight {\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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

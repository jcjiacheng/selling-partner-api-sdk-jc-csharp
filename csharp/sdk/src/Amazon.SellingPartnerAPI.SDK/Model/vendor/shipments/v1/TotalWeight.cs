/*
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/shipments/v1
{
    /// <summary>
    /// The total weight of units that are sold by weight in a shipment.
    /// </summary>
    [DataContract(Name = "TotalWeight")]
    public partial class TotalWeight : IValidatableObject
    {
        /// <summary>
        /// The unit of measure for the weight of items that are ordered by cases and support pricing by weight.
        /// </summary>
        /// <value>The unit of measure for the weight of items that are ordered by cases and support pricing by weight.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            /// <summary>
            /// Enum POUNDS for value: POUNDS
            /// </summary>
            [EnumMember(Value = "POUNDS")]
            POUNDS = 1,

            /// <summary>
            /// Enum OUNCES for value: OUNCES
            /// </summary>
            [EnumMember(Value = "OUNCES")]
            OUNCES = 2,

            /// <summary>
            /// Enum GRAMS for value: GRAMS
            /// </summary>
            [EnumMember(Value = "GRAMS")]
            GRAMS = 3,

            /// <summary>
            /// Enum KILOGRAMS for value: KILOGRAMS
            /// </summary>
            [EnumMember(Value = "KILOGRAMS")]
            KILOGRAMS = 4
        }


        /// <summary>
        /// The unit of measure for the weight of items that are ordered by cases and support pricing by weight.
        /// </summary>
        /// <value>The unit of measure for the weight of items that are ordered by cases and support pricing by weight.</value>
        [DataMember(Name = "unitOfMeasure", IsRequired = true, EmitDefaultValue = true)]
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalWeight" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TotalWeight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalWeight" /> class.
        /// </summary>
        /// <param name="unitOfMeasure">The unit of measure for the weight of items that are ordered by cases and support pricing by weight. (required).</param>
        /// <param name="amount">A decimal number with no loss of precision. Useful when precision loss is unacceptable, as with currencies. Follows RFC7159 for number representation. &lt;br&gt;**Pattern** : &#x60;^-?(0|([1-9]\\d*))(\\.\\d+)?([eE][+-]?\\d+)?$&#x60;. (required).</param>
        public TotalWeight(UnitOfMeasureEnum unitOfMeasure = default(UnitOfMeasureEnum), string amount = default(string))
        {
            this.UnitOfMeasure = unitOfMeasure;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TotalWeight and cannot be null");
            }
            this.Amount = amount;
        }

        /// <summary>
        /// A decimal number with no loss of precision. Useful when precision loss is unacceptable, as with currencies. Follows RFC7159 for number representation. &lt;br&gt;**Pattern** : &#x60;^-?(0|([1-9]\\d*))(\\.\\d+)?([eE][+-]?\\d+)?$&#x60;.
        /// </summary>
        /// <value>A decimal number with no loss of precision. Useful when precision loss is unacceptable, as with currencies. Follows RFC7159 for number representation. &lt;br&gt;**Pattern** : &#x60;^-?(0|([1-9]\\d*))(\\.\\d+)?([eE][+-]?\\d+)?$&#x60;.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TotalWeight {\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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

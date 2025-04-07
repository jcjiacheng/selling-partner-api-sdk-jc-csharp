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
    /// Duration after manufacturing date during which the product is valid for consumption.
    /// </summary>
    [DataContract(Name = "Duration")]
    public partial class Duration : IValidatableObject
    {
        /// <summary>
        /// Unit for duration.
        /// </summary>
        /// <value>Unit for duration.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DurationUnitEnum
        {
            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 1,

            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 2
        }


        /// <summary>
        /// Unit for duration.
        /// </summary>
        /// <value>Unit for duration.</value>
        [DataMember(Name = "durationUnit", IsRequired = true, EmitDefaultValue = true)]
        public DurationUnitEnum DurationUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Duration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        /// <param name="durationUnit">Unit for duration. (required).</param>
        /// <param name="durationValue">Value for the duration in terms of the durationUnit. (required).</param>
        public Duration(DurationUnitEnum durationUnit = default(DurationUnitEnum), int durationValue = default(int))
        {
            this.DurationUnit = durationUnit;
            this.DurationValue = durationValue;
        }

        /// <summary>
        /// Value for the duration in terms of the durationUnit.
        /// </summary>
        /// <value>Value for the duration in terms of the durationUnit.</value>
        [DataMember(Name = "durationValue", IsRequired = true, EmitDefaultValue = true)]
        public int DurationValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  DurationUnit: ").Append(DurationUnit).Append("\n");
            sb.Append("  DurationValue: ").Append(DurationValue).Append("\n");
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

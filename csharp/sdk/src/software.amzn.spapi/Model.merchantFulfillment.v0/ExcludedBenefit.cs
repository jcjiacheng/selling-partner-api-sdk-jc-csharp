/*
 * Selling Partner API for Merchant Fulfillment
 *
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
 *
 * The version of the OpenAPI document: v0
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

namespace software.amzn.spapi.Model.merchantFulfillment.v0
{
    /// <summary>
    /// An object representing an excluded benefit that is excluded for a shipping offer or rate.
    /// </summary>
    [DataContract(Name = "ExcludedBenefit")]
    public partial class ExcludedBenefit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcludedBenefit" /> class.
        /// </summary>
        /// <param name="benefit">A benefit that is being excluded from a shipment..</param>
        /// <param name="reasonCodes">List of reasons why a benefit is excluded for a shipping offer (for example, &#x60;LATE_DELIVERY_RISK&#x60;)..</param>
        public ExcludedBenefit(string benefit = default(string), List<string> reasonCodes = default(List<string>))
        {
            this.Benefit = benefit;
            this.ReasonCodes = reasonCodes;
        }

        /// <summary>
        /// A benefit that is being excluded from a shipment.
        /// </summary>
        /// <value>A benefit that is being excluded from a shipment.</value>
        [DataMember(Name = "Benefit", EmitDefaultValue = false)]
        public string Benefit { get; set; }

        /// <summary>
        /// List of reasons why a benefit is excluded for a shipping offer (for example, &#x60;LATE_DELIVERY_RISK&#x60;).
        /// </summary>
        /// <value>List of reasons why a benefit is excluded for a shipping offer (for example, &#x60;LATE_DELIVERY_RISK&#x60;).</value>
        [DataMember(Name = "ReasonCodes", EmitDefaultValue = false)]
        public List<string> ReasonCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExcludedBenefit {\n");
            sb.Append("  Benefit: ").Append(Benefit).Append("\n");
            sb.Append("  ReasonCodes: ").Append(ReasonCodes).Append("\n");
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

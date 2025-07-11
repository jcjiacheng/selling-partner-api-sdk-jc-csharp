/*
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
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

namespace software.amzn.spapi.Model.productFees.v0
{
    /// <summary>
    /// MoneyType
    /// </summary>
    [DataContract(Name = "MoneyType")]
    public partial class MoneyType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyType" /> class.
        /// </summary>
        /// <param name="currencyCode">The currency code in ISO 4217 format..</param>
        /// <param name="amount">The monetary value..</param>
        public MoneyType(string currencyCode = default(string), decimal amount = default(decimal))
        {
            this.CurrencyCode = currencyCode;
            this.Amount = amount;
        }

        /// <summary>
        /// The currency code in ISO 4217 format.
        /// </summary>
        /// <value>The currency code in ISO 4217 format.</value>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The monetary value.
        /// </summary>
        /// <value>The monetary value.</value>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MoneyType {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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

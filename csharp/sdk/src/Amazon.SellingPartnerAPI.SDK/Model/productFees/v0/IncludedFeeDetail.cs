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
using OpenAPIDateConverter = Amazon.SellingPartnerAPI.SDK.Client.OpenAPIDateConverter;

namespace Amazon.SellingPartnerAPI.SDK.Model/productFees/v0
{
    /// <summary>
    /// The type of fee, fee amount, and other details.
    /// </summary>
    [DataContract(Name = "IncludedFeeDetail")]
    public partial class IncludedFeeDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncludedFeeDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncludedFeeDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncludedFeeDetail" /> class.
        /// </summary>
        /// <param name="feeType">The type of fee charged to a seller. (required).</param>
        /// <param name="feeAmount">feeAmount (required).</param>
        /// <param name="feePromotion">feePromotion.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="finalFee">finalFee (required).</param>
        public IncludedFeeDetail(string feeType = default(string), MoneyType feeAmount = default(MoneyType), MoneyType feePromotion = default(MoneyType), MoneyType taxAmount = default(MoneyType), MoneyType finalFee = default(MoneyType))
        {
            // to ensure "feeType" is required (not null)
            if (feeType == null)
            {
                throw new ArgumentNullException("feeType is a required property for IncludedFeeDetail and cannot be null");
            }
            this.FeeType = feeType;
            // to ensure "feeAmount" is required (not null)
            if (feeAmount == null)
            {
                throw new ArgumentNullException("feeAmount is a required property for IncludedFeeDetail and cannot be null");
            }
            this.FeeAmount = feeAmount;
            // to ensure "finalFee" is required (not null)
            if (finalFee == null)
            {
                throw new ArgumentNullException("finalFee is a required property for IncludedFeeDetail and cannot be null");
            }
            this.FinalFee = finalFee;
            this.FeePromotion = feePromotion;
            this.TaxAmount = taxAmount;
        }

        /// <summary>
        /// The type of fee charged to a seller.
        /// </summary>
        /// <value>The type of fee charged to a seller.</value>
        [DataMember(Name = "FeeType", IsRequired = true, EmitDefaultValue = true)]
        public string FeeType { get; set; }

        /// <summary>
        /// Gets or Sets FeeAmount
        /// </summary>
        [DataMember(Name = "FeeAmount", IsRequired = true, EmitDefaultValue = true)]
        public MoneyType FeeAmount { get; set; }

        /// <summary>
        /// Gets or Sets FeePromotion
        /// </summary>
        [DataMember(Name = "FeePromotion", EmitDefaultValue = false)]
        public MoneyType FeePromotion { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name = "TaxAmount", EmitDefaultValue = false)]
        public MoneyType TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets FinalFee
        /// </summary>
        [DataMember(Name = "FinalFee", IsRequired = true, EmitDefaultValue = true)]
        public MoneyType FinalFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IncludedFeeDetail {\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
            sb.Append("  FeePromotion: ").Append(FeePromotion).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  FinalFee: ").Append(FinalFee).Append("\n");
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

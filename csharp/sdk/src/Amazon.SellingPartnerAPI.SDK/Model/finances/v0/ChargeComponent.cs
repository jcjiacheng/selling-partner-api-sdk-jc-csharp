/*
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/finances/v0
{
    /// <summary>
    /// A charge on the seller&#39;s account.  Possible values:  * Principal - The selling price of the order item, equal to the selling price of the item multiplied by the quantity ordered.  * Tax - The tax collected by the seller on the Principal.  * MarketplaceFacilitatorTax-Principal - The tax withheld on the Principal.  * MarketplaceFacilitatorTax-Shipping - The tax withheld on the ShippingCharge.  * MarketplaceFacilitatorTax-Giftwrap - The tax withheld on the Giftwrap charge.  * MarketplaceFacilitatorTax-Other - The tax withheld on other miscellaneous charges.  * Discount - The promotional discount for an order item.  * TaxDiscount - The tax amount deducted for promotional rebates.  * CODItemCharge - The COD charge for an order item.  * CODItemTaxCharge - The tax collected by the seller on a CODItemCharge.  * CODOrderCharge - The COD charge for an order.  * CODOrderTaxCharge - The tax collected by the seller on a CODOrderCharge.  * CODShippingCharge - Shipping charges for a COD order.  * CODShippingTaxCharge - The tax collected by the seller on a CODShippingCharge.  * ShippingCharge - The shipping charge.  * ShippingTax - The tax collected by the seller on a ShippingCharge.  * Goodwill - The amount given to a buyer as a gesture of goodwill or to compensate for pain and suffering in the buying experience.  * Giftwrap - The gift wrap charge.  * GiftwrapTax - The tax collected by the seller on a Giftwrap charge.  * RestockingFee - The charge applied to the buyer when returning a product in certain categories.  * ReturnShipping - The amount given to the buyer to compensate for shipping the item back in the event we are at fault.  * PointsFee - The value of Amazon Points deducted from the refund if the buyer does not have enough Amazon Points to cover the deduction.  * GenericDeduction - A generic bad debt deduction.  * FreeReplacementReturnShipping - The compensation for return shipping when a buyer receives the wrong item, requests a free replacement, and returns the incorrect item.  * PaymentMethodFee - The fee collected for certain payment methods in certain marketplaces.  * ExportCharge - The export duty that is charged when an item is shipped to an international destination as part of the Amazon Global program.  * SAFE-TReimbursement - The SAFE-T claim amount for the item.  * TCS-CGST - Tax Collected at Source (TCS) for Central Goods and Services Tax (CGST).  * TCS-SGST - Tax Collected at Source for State Goods and Services Tax (SGST).  * TCS-IGST - Tax Collected at Source for Integrated Goods and Services Tax (IGST).  * TCS-UTGST - Tax Collected at Source for Union Territories Goods and Services Tax (UTGST).
    /// </summary>
    [DataContract(Name = "ChargeComponent")]
    public partial class ChargeComponent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeComponent" /> class.
        /// </summary>
        /// <param name="chargeType">The type of charge..</param>
        /// <param name="chargeAmount">chargeAmount.</param>
        public ChargeComponent(string chargeType = default(string), Currency chargeAmount = default(Currency))
        {
            this.ChargeType = chargeType;
            this.ChargeAmount = chargeAmount;
        }

        /// <summary>
        /// The type of charge.
        /// </summary>
        /// <value>The type of charge.</value>
        [DataMember(Name = "ChargeType", EmitDefaultValue = false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// Gets or Sets ChargeAmount
        /// </summary>
        [DataMember(Name = "ChargeAmount", EmitDefaultValue = false)]
        public Currency ChargeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeComponent {\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  ChargeAmount: ").Append(ChargeAmount).Append("\n");
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

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
    /// An event related to coupon payments.
    /// </summary>
    [DataContract(Name = "CouponPaymentEvent")]
    public partial class CouponPaymentEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPaymentEvent" /> class.
        /// </summary>
        /// <param name="postedDate">Fields with a schema type of date are in ISO 8601 date time format (for example GroupBeginDate)..</param>
        /// <param name="couponId">A coupon identifier..</param>
        /// <param name="sellerCouponDescription">The description provided by the seller when they created the coupon..</param>
        /// <param name="clipOrRedemptionCount">The number of coupon clips or redemptions..</param>
        /// <param name="paymentEventId">A payment event identifier..</param>
        /// <param name="feeComponent">feeComponent.</param>
        /// <param name="chargeComponent">chargeComponent.</param>
        /// <param name="totalAmount">totalAmount.</param>
        public CouponPaymentEvent(DateTime postedDate = default(DateTime), string couponId = default(string), string sellerCouponDescription = default(string), long clipOrRedemptionCount = default(long), string paymentEventId = default(string), FeeComponent feeComponent = default(FeeComponent), ChargeComponent chargeComponent = default(ChargeComponent), Currency totalAmount = default(Currency))
        {
            this.PostedDate = postedDate;
            this.CouponId = couponId;
            this.SellerCouponDescription = sellerCouponDescription;
            this.ClipOrRedemptionCount = clipOrRedemptionCount;
            this.PaymentEventId = paymentEventId;
            this.FeeComponent = feeComponent;
            this.ChargeComponent = chargeComponent;
            this.TotalAmount = totalAmount;
        }

        /// <summary>
        /// Fields with a schema type of date are in ISO 8601 date time format (for example GroupBeginDate).
        /// </summary>
        /// <value>Fields with a schema type of date are in ISO 8601 date time format (for example GroupBeginDate).</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime PostedDate { get; set; }

        /// <summary>
        /// A coupon identifier.
        /// </summary>
        /// <value>A coupon identifier.</value>
        [DataMember(Name = "CouponId", EmitDefaultValue = false)]
        public string CouponId { get; set; }

        /// <summary>
        /// The description provided by the seller when they created the coupon.
        /// </summary>
        /// <value>The description provided by the seller when they created the coupon.</value>
        [DataMember(Name = "SellerCouponDescription", EmitDefaultValue = false)]
        public string SellerCouponDescription { get; set; }

        /// <summary>
        /// The number of coupon clips or redemptions.
        /// </summary>
        /// <value>The number of coupon clips or redemptions.</value>
        [DataMember(Name = "ClipOrRedemptionCount", EmitDefaultValue = false)]
        public long ClipOrRedemptionCount { get; set; }

        /// <summary>
        /// A payment event identifier.
        /// </summary>
        /// <value>A payment event identifier.</value>
        [DataMember(Name = "PaymentEventId", EmitDefaultValue = false)]
        public string PaymentEventId { get; set; }

        /// <summary>
        /// Gets or Sets FeeComponent
        /// </summary>
        [DataMember(Name = "FeeComponent", EmitDefaultValue = false)]
        public FeeComponent FeeComponent { get; set; }

        /// <summary>
        /// Gets or Sets ChargeComponent
        /// </summary>
        [DataMember(Name = "ChargeComponent", EmitDefaultValue = false)]
        public ChargeComponent ChargeComponent { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CouponPaymentEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  CouponId: ").Append(CouponId).Append("\n");
            sb.Append("  SellerCouponDescription: ").Append(SellerCouponDescription).Append("\n");
            sb.Append("  ClipOrRedemptionCount: ").Append(ClipOrRedemptionCount).Append("\n");
            sb.Append("  PaymentEventId: ").Append(PaymentEventId).Append("\n");
            sb.Append("  FeeComponent: ").Append(FeeComponent).Append("\n");
            sb.Append("  ChargeComponent: ").Append(ChargeComponent).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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

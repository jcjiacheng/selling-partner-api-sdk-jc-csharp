/*
 * Selling Partner API for Direct Fulfillment Orders
 *
 * The Selling Partner API for Direct Fulfillment Orders provides programmatic access to a direct fulfillment vendor's order data.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/df/orders/v2021_12_28
{
    /// <summary>
    /// Details of an individual order being acknowledged.
    /// </summary>
    [DataContract(Name = "OrderAcknowledgementItem")]
    public partial class OrderAcknowledgementItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAcknowledgementItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderAcknowledgementItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAcknowledgementItem" /> class.
        /// </summary>
        /// <param name="purchaseOrderNumber">The purchase order number for this order. Formatting Notes: alpha-numeric code. (required).</param>
        /// <param name="vendorOrderNumber">The vendor&#39;s order number for this order. (required).</param>
        /// <param name="acknowledgementDate">The date and time when the order is acknowledged, in ISO-8601 date/time format. For example: 2018-07-16T23:00:00Z / 2018-07-16T23:00:00-05:00 / 2018-07-16T23:00:00-08:00. (required).</param>
        /// <param name="acknowledgementStatus">acknowledgementStatus (required).</param>
        /// <param name="sellingParty">sellingParty (required).</param>
        /// <param name="shipFromParty">shipFromParty (required).</param>
        /// <param name="itemAcknowledgements">Item details including acknowledged quantity. (required).</param>
        public OrderAcknowledgementItem(string purchaseOrderNumber = default(string), string vendorOrderNumber = default(string), DateTime acknowledgementDate = default(DateTime), AcknowledgementStatus acknowledgementStatus = default(AcknowledgementStatus), PartyIdentification sellingParty = default(PartyIdentification), PartyIdentification shipFromParty = default(PartyIdentification), List<OrderItemAcknowledgement> itemAcknowledgements = default(List<OrderItemAcknowledgement>))
        {
            // to ensure "purchaseOrderNumber" is required (not null)
            if (purchaseOrderNumber == null)
            {
                throw new ArgumentNullException("purchaseOrderNumber is a required property for OrderAcknowledgementItem and cannot be null");
            }
            this.PurchaseOrderNumber = purchaseOrderNumber;
            // to ensure "vendorOrderNumber" is required (not null)
            if (vendorOrderNumber == null)
            {
                throw new ArgumentNullException("vendorOrderNumber is a required property for OrderAcknowledgementItem and cannot be null");
            }
            this.VendorOrderNumber = vendorOrderNumber;
            this.AcknowledgementDate = acknowledgementDate;
            // to ensure "acknowledgementStatus" is required (not null)
            if (acknowledgementStatus == null)
            {
                throw new ArgumentNullException("acknowledgementStatus is a required property for OrderAcknowledgementItem and cannot be null");
            }
            this.AcknowledgementStatus = acknowledgementStatus;
            // to ensure "sellingParty" is required (not null)
            if (sellingParty == null)
            {
                throw new ArgumentNullException("sellingParty is a required property for OrderAcknowledgementItem and cannot be null");
            }
            this.SellingParty = sellingParty;
            // to ensure "shipFromParty" is required (not null)
            if (shipFromParty == null)
            {
                throw new ArgumentNullException("shipFromParty is a required property for OrderAcknowledgementItem and cannot be null");
            }
            this.ShipFromParty = shipFromParty;
            // to ensure "itemAcknowledgements" is required (not null)
            if (itemAcknowledgements == null)
            {
                throw new ArgumentNullException("itemAcknowledgements is a required property for OrderAcknowledgementItem and cannot be null");
            }
            this.ItemAcknowledgements = itemAcknowledgements;
        }

        /// <summary>
        /// The purchase order number for this order. Formatting Notes: alpha-numeric code.
        /// </summary>
        /// <value>The purchase order number for this order. Formatting Notes: alpha-numeric code.</value>
        [DataMember(Name = "purchaseOrderNumber", IsRequired = true, EmitDefaultValue = true)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The vendor&#39;s order number for this order.
        /// </summary>
        /// <value>The vendor&#39;s order number for this order.</value>
        [DataMember(Name = "vendorOrderNumber", IsRequired = true, EmitDefaultValue = true)]
        public string VendorOrderNumber { get; set; }

        /// <summary>
        /// The date and time when the order is acknowledged, in ISO-8601 date/time format. For example: 2018-07-16T23:00:00Z / 2018-07-16T23:00:00-05:00 / 2018-07-16T23:00:00-08:00.
        /// </summary>
        /// <value>The date and time when the order is acknowledged, in ISO-8601 date/time format. For example: 2018-07-16T23:00:00Z / 2018-07-16T23:00:00-05:00 / 2018-07-16T23:00:00-08:00.</value>
        [DataMember(Name = "acknowledgementDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime AcknowledgementDate { get; set; }

        /// <summary>
        /// Gets or Sets AcknowledgementStatus
        /// </summary>
        [DataMember(Name = "acknowledgementStatus", IsRequired = true, EmitDefaultValue = true)]
        public AcknowledgementStatus AcknowledgementStatus { get; set; }

        /// <summary>
        /// Gets or Sets SellingParty
        /// </summary>
        [DataMember(Name = "sellingParty", IsRequired = true, EmitDefaultValue = true)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// Gets or Sets ShipFromParty
        /// </summary>
        [DataMember(Name = "shipFromParty", IsRequired = true, EmitDefaultValue = true)]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// Item details including acknowledged quantity.
        /// </summary>
        /// <value>Item details including acknowledged quantity.</value>
        [DataMember(Name = "itemAcknowledgements", IsRequired = true, EmitDefaultValue = true)]
        public List<OrderItemAcknowledgement> ItemAcknowledgements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderAcknowledgementItem {\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  VendorOrderNumber: ").Append(VendorOrderNumber).Append("\n");
            sb.Append("  AcknowledgementDate: ").Append(AcknowledgementDate).Append("\n");
            sb.Append("  AcknowledgementStatus: ").Append(AcknowledgementStatus).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipFromParty: ").Append(ShipFromParty).Append("\n");
            sb.Append("  ItemAcknowledgements: ").Append(ItemAcknowledgements).Append("\n");
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

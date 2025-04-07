/*
 * Selling Partner API for Retail Procurement Orders
 *
 * The Selling Partner API for Retail Procurement Orders provides programmatic access to vendor orders data.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/orders/v1
{
    /// <summary>
    /// Details of an order.
    /// </summary>
    [DataContract(Name = "OrderDetails")]
    public partial class OrderDetails : IValidatableObject
    {
        /// <summary>
        /// Type of purchase order.
        /// </summary>
        /// <value>Type of purchase order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PurchaseOrderTypeEnum
        {
            /// <summary>
            /// Enum RegularOrder for value: RegularOrder
            /// </summary>
            [EnumMember(Value = "RegularOrder")]
            RegularOrder = 1,

            /// <summary>
            /// Enum ConsignedOrder for value: ConsignedOrder
            /// </summary>
            [EnumMember(Value = "ConsignedOrder")]
            ConsignedOrder = 2,

            /// <summary>
            /// Enum NewProductIntroduction for value: NewProductIntroduction
            /// </summary>
            [EnumMember(Value = "NewProductIntroduction")]
            NewProductIntroduction = 3,

            /// <summary>
            /// Enum RushOrder for value: RushOrder
            /// </summary>
            [EnumMember(Value = "RushOrder")]
            RushOrder = 4
        }


        /// <summary>
        /// Type of purchase order.
        /// </summary>
        /// <value>Type of purchase order.</value>
        [DataMember(Name = "purchaseOrderType", EmitDefaultValue = false)]
        public PurchaseOrderTypeEnum? PurchaseOrderType { get; set; }
        /// <summary>
        /// Payment method used.
        /// </summary>
        /// <value>Payment method used.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentMethodEnum
        {
            /// <summary>
            /// Enum Invoice for value: Invoice
            /// </summary>
            [EnumMember(Value = "Invoice")]
            Invoice = 1,

            /// <summary>
            /// Enum Consignment for value: Consignment
            /// </summary>
            [EnumMember(Value = "Consignment")]
            Consignment = 2,

            /// <summary>
            /// Enum CreditCard for value: CreditCard
            /// </summary>
            [EnumMember(Value = "CreditCard")]
            CreditCard = 3,

            /// <summary>
            /// Enum Prepaid for value: Prepaid
            /// </summary>
            [EnumMember(Value = "Prepaid")]
            Prepaid = 4
        }


        /// <summary>
        /// Payment method used.
        /// </summary>
        /// <value>Payment method used.</value>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentMethodEnum? PaymentMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetails" /> class.
        /// </summary>
        /// <param name="purchaseOrderDate">The date the purchase order was placed. Must be in ISO-8601 date/time format. (required).</param>
        /// <param name="purchaseOrderChangedDate">The date when purchase order was last changed by Amazon after the order was placed. This date will be greater than &#39;purchaseOrderDate&#39;. This means the PO data was changed on that date and vendors are required to fulfill the  updated PO. The PO changes can be related to Item Quantity, Ship to Location, Ship Window etc. This field will not be present in orders that have not changed after creation. Must be in ISO-8601 date/time format..</param>
        /// <param name="purchaseOrderStateChangedDate">The date when current purchase order state was changed. Current purchase order state is available in the field &#39;purchaseOrderState&#39;. Must be in ISO-8601 date/time format. (required).</param>
        /// <param name="purchaseOrderType">Type of purchase order..</param>
        /// <param name="importDetails">importDetails.</param>
        /// <param name="dealCode">If requested by the recipient, this field will contain a promotional/deal number. The discount code line is optional. It is used to obtain a price discount on items on the order..</param>
        /// <param name="paymentMethod">Payment method used..</param>
        /// <param name="buyingParty">buyingParty.</param>
        /// <param name="sellingParty">sellingParty.</param>
        /// <param name="shipToParty">shipToParty.</param>
        /// <param name="billToParty">billToParty.</param>
        /// <param name="shipWindow">Defines a date time interval according to ISO8601. Interval is separated by double hyphen (- -)..</param>
        /// <param name="deliveryWindow">Defines a date time interval according to ISO8601. Interval is separated by double hyphen (- -)..</param>
        /// <param name="items">A list of items in this purchase order. (required).</param>
        public OrderDetails(DateTime purchaseOrderDate = default(DateTime), DateTime purchaseOrderChangedDate = default(DateTime), DateTime purchaseOrderStateChangedDate = default(DateTime), PurchaseOrderTypeEnum? purchaseOrderType = default(PurchaseOrderTypeEnum?), ImportDetails importDetails = default(ImportDetails), string dealCode = default(string), PaymentMethodEnum? paymentMethod = default(PaymentMethodEnum?), PartyIdentification buyingParty = default(PartyIdentification), PartyIdentification sellingParty = default(PartyIdentification), PartyIdentification shipToParty = default(PartyIdentification), PartyIdentification billToParty = default(PartyIdentification), string shipWindow = default(string), string deliveryWindow = default(string), List<OrderItem> items = default(List<OrderItem>))
        {
            this.PurchaseOrderDate = purchaseOrderDate;
            this.PurchaseOrderStateChangedDate = purchaseOrderStateChangedDate;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for OrderDetails and cannot be null");
            }
            this.Items = items;
            this.PurchaseOrderChangedDate = purchaseOrderChangedDate;
            this.PurchaseOrderType = purchaseOrderType;
            this.ImportDetails = importDetails;
            this.DealCode = dealCode;
            this.PaymentMethod = paymentMethod;
            this.BuyingParty = buyingParty;
            this.SellingParty = sellingParty;
            this.ShipToParty = shipToParty;
            this.BillToParty = billToParty;
            this.ShipWindow = shipWindow;
            this.DeliveryWindow = deliveryWindow;
        }

        /// <summary>
        /// The date the purchase order was placed. Must be in ISO-8601 date/time format.
        /// </summary>
        /// <value>The date the purchase order was placed. Must be in ISO-8601 date/time format.</value>
        [DataMember(Name = "purchaseOrderDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime PurchaseOrderDate { get; set; }

        /// <summary>
        /// The date when purchase order was last changed by Amazon after the order was placed. This date will be greater than &#39;purchaseOrderDate&#39;. This means the PO data was changed on that date and vendors are required to fulfill the  updated PO. The PO changes can be related to Item Quantity, Ship to Location, Ship Window etc. This field will not be present in orders that have not changed after creation. Must be in ISO-8601 date/time format.
        /// </summary>
        /// <value>The date when purchase order was last changed by Amazon after the order was placed. This date will be greater than &#39;purchaseOrderDate&#39;. This means the PO data was changed on that date and vendors are required to fulfill the  updated PO. The PO changes can be related to Item Quantity, Ship to Location, Ship Window etc. This field will not be present in orders that have not changed after creation. Must be in ISO-8601 date/time format.</value>
        [DataMember(Name = "purchaseOrderChangedDate", EmitDefaultValue = false)]
        public DateTime PurchaseOrderChangedDate { get; set; }

        /// <summary>
        /// The date when current purchase order state was changed. Current purchase order state is available in the field &#39;purchaseOrderState&#39;. Must be in ISO-8601 date/time format.
        /// </summary>
        /// <value>The date when current purchase order state was changed. Current purchase order state is available in the field &#39;purchaseOrderState&#39;. Must be in ISO-8601 date/time format.</value>
        [DataMember(Name = "purchaseOrderStateChangedDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime PurchaseOrderStateChangedDate { get; set; }

        /// <summary>
        /// Gets or Sets ImportDetails
        /// </summary>
        [DataMember(Name = "importDetails", EmitDefaultValue = false)]
        public ImportDetails ImportDetails { get; set; }

        /// <summary>
        /// If requested by the recipient, this field will contain a promotional/deal number. The discount code line is optional. It is used to obtain a price discount on items on the order.
        /// </summary>
        /// <value>If requested by the recipient, this field will contain a promotional/deal number. The discount code line is optional. It is used to obtain a price discount on items on the order.</value>
        [DataMember(Name = "dealCode", EmitDefaultValue = false)]
        public string DealCode { get; set; }

        /// <summary>
        /// Gets or Sets BuyingParty
        /// </summary>
        [DataMember(Name = "buyingParty", EmitDefaultValue = false)]
        public PartyIdentification BuyingParty { get; set; }

        /// <summary>
        /// Gets or Sets SellingParty
        /// </summary>
        [DataMember(Name = "sellingParty", EmitDefaultValue = false)]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// Gets or Sets ShipToParty
        /// </summary>
        [DataMember(Name = "shipToParty", EmitDefaultValue = false)]
        public PartyIdentification ShipToParty { get; set; }

        /// <summary>
        /// Gets or Sets BillToParty
        /// </summary>
        [DataMember(Name = "billToParty", EmitDefaultValue = false)]
        public PartyIdentification BillToParty { get; set; }

        /// <summary>
        /// Defines a date time interval according to ISO8601. Interval is separated by double hyphen (- -).
        /// </summary>
        /// <value>Defines a date time interval according to ISO8601. Interval is separated by double hyphen (- -).</value>
        [DataMember(Name = "shipWindow", EmitDefaultValue = false)]
        public string ShipWindow { get; set; }

        /// <summary>
        /// Defines a date time interval according to ISO8601. Interval is separated by double hyphen (- -).
        /// </summary>
        /// <value>Defines a date time interval according to ISO8601. Interval is separated by double hyphen (- -).</value>
        [DataMember(Name = "deliveryWindow", EmitDefaultValue = false)]
        public string DeliveryWindow { get; set; }

        /// <summary>
        /// A list of items in this purchase order.
        /// </summary>
        /// <value>A list of items in this purchase order.</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<OrderItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetails {\n");
            sb.Append("  PurchaseOrderDate: ").Append(PurchaseOrderDate).Append("\n");
            sb.Append("  PurchaseOrderChangedDate: ").Append(PurchaseOrderChangedDate).Append("\n");
            sb.Append("  PurchaseOrderStateChangedDate: ").Append(PurchaseOrderStateChangedDate).Append("\n");
            sb.Append("  PurchaseOrderType: ").Append(PurchaseOrderType).Append("\n");
            sb.Append("  ImportDetails: ").Append(ImportDetails).Append("\n");
            sb.Append("  DealCode: ").Append(DealCode).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  BuyingParty: ").Append(BuyingParty).Append("\n");
            sb.Append("  SellingParty: ").Append(SellingParty).Append("\n");
            sb.Append("  ShipToParty: ").Append(ShipToParty).Append("\n");
            sb.Append("  BillToParty: ").Append(BillToParty).Append("\n");
            sb.Append("  ShipWindow: ").Append(ShipWindow).Append("\n");
            sb.Append("  DeliveryWindow: ").Append(DeliveryWindow).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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

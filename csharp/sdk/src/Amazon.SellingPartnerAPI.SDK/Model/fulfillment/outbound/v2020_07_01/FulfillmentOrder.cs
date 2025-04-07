/*
 * Selling Partner APIs for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
 *
 * The version of the OpenAPI document: 2020-07-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/outbound/v2020_07_01
{
    /// <summary>
    /// General information about a fulfillment order, including its status.
    /// </summary>
    [DataContract(Name = "FulfillmentOrder")]
    public partial class FulfillmentOrder : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShippingSpeedCategory
        /// </summary>
        [DataMember(Name = "shippingSpeedCategory", IsRequired = true, EmitDefaultValue = true)]
        public ShippingSpeedCategory ShippingSpeedCategory { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentAction
        /// </summary>
        [DataMember(Name = "fulfillmentAction", EmitDefaultValue = false)]
        public FulfillmentAction? FulfillmentAction { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentPolicy
        /// </summary>
        [DataMember(Name = "fulfillmentPolicy", EmitDefaultValue = false)]
        public FulfillmentPolicy? FulfillmentPolicy { get; set; }

        /// <summary>
        /// Gets or Sets FulfillmentOrderStatus
        /// </summary>
        [DataMember(Name = "fulfillmentOrderStatus", IsRequired = true, EmitDefaultValue = true)]
        public FulfillmentOrderStatus FulfillmentOrderStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FulfillmentOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentOrder" /> class.
        /// </summary>
        /// <param name="sellerFulfillmentOrderId">The fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation. (required).</param>
        /// <param name="marketplaceId">The identifier for the marketplace the fulfillment order is placed against. (required).</param>
        /// <param name="displayableOrderId">A fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays as the order identifier in recipient-facing materials such as the packing slip. (required).</param>
        /// <param name="displayableOrderDate">Date timestamp (required).</param>
        /// <param name="displayableOrderComment">A text block submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays in recipient-facing materials such as the packing slip. (required).</param>
        /// <param name="shippingSpeedCategory">shippingSpeedCategory (required).</param>
        /// <param name="deliveryWindow">deliveryWindow.</param>
        /// <param name="destinationAddress">destinationAddress (required).</param>
        /// <param name="fulfillmentAction">fulfillmentAction.</param>
        /// <param name="fulfillmentPolicy">fulfillmentPolicy.</param>
        /// <param name="codSettings">codSettings.</param>
        /// <param name="receivedDate">Date timestamp (required).</param>
        /// <param name="fulfillmentOrderStatus">fulfillmentOrderStatus (required).</param>
        /// <param name="statusUpdatedDate">Date timestamp (required).</param>
        /// <param name="notificationEmails">A list of email addresses that the seller provides that are used by Amazon to send ship-complete notifications to recipients on behalf of the seller..</param>
        /// <param name="featureConstraints">A list of features and their fulfillment policies to apply to the order..</param>
        public FulfillmentOrder(string sellerFulfillmentOrderId = default(string), string marketplaceId = default(string), string displayableOrderId = default(string), DateTime displayableOrderDate = default(DateTime), string displayableOrderComment = default(string), ShippingSpeedCategory shippingSpeedCategory = default(ShippingSpeedCategory), DeliveryWindow deliveryWindow = default(DeliveryWindow), Address destinationAddress = default(Address), FulfillmentAction? fulfillmentAction = default(FulfillmentAction?), FulfillmentPolicy? fulfillmentPolicy = default(FulfillmentPolicy?), CODSettings codSettings = default(CODSettings), DateTime receivedDate = default(DateTime), FulfillmentOrderStatus fulfillmentOrderStatus = default(FulfillmentOrderStatus), DateTime statusUpdatedDate = default(DateTime), List<string> notificationEmails = default(List<string>), List<FeatureSettings> featureConstraints = default(List<FeatureSettings>))
        {
            // to ensure "sellerFulfillmentOrderId" is required (not null)
            if (sellerFulfillmentOrderId == null)
            {
                throw new ArgumentNullException("sellerFulfillmentOrderId is a required property for FulfillmentOrder and cannot be null");
            }
            this.SellerFulfillmentOrderId = sellerFulfillmentOrderId;
            // to ensure "marketplaceId" is required (not null)
            if (marketplaceId == null)
            {
                throw new ArgumentNullException("marketplaceId is a required property for FulfillmentOrder and cannot be null");
            }
            this.MarketplaceId = marketplaceId;
            // to ensure "displayableOrderId" is required (not null)
            if (displayableOrderId == null)
            {
                throw new ArgumentNullException("displayableOrderId is a required property for FulfillmentOrder and cannot be null");
            }
            this.DisplayableOrderId = displayableOrderId;
            this.DisplayableOrderDate = displayableOrderDate;
            // to ensure "displayableOrderComment" is required (not null)
            if (displayableOrderComment == null)
            {
                throw new ArgumentNullException("displayableOrderComment is a required property for FulfillmentOrder and cannot be null");
            }
            this.DisplayableOrderComment = displayableOrderComment;
            this.ShippingSpeedCategory = shippingSpeedCategory;
            // to ensure "destinationAddress" is required (not null)
            if (destinationAddress == null)
            {
                throw new ArgumentNullException("destinationAddress is a required property for FulfillmentOrder and cannot be null");
            }
            this.DestinationAddress = destinationAddress;
            this.ReceivedDate = receivedDate;
            this.FulfillmentOrderStatus = fulfillmentOrderStatus;
            this.StatusUpdatedDate = statusUpdatedDate;
            this.DeliveryWindow = deliveryWindow;
            this.FulfillmentAction = fulfillmentAction;
            this.FulfillmentPolicy = fulfillmentPolicy;
            this.CodSettings = codSettings;
            this.NotificationEmails = notificationEmails;
            this.FeatureConstraints = featureConstraints;
        }

        /// <summary>
        /// The fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation.
        /// </summary>
        /// <value>The fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation.</value>
        [DataMember(Name = "sellerFulfillmentOrderId", IsRequired = true, EmitDefaultValue = true)]
        public string SellerFulfillmentOrderId { get; set; }

        /// <summary>
        /// The identifier for the marketplace the fulfillment order is placed against.
        /// </summary>
        /// <value>The identifier for the marketplace the fulfillment order is placed against.</value>
        [DataMember(Name = "marketplaceId", IsRequired = true, EmitDefaultValue = true)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// A fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays as the order identifier in recipient-facing materials such as the packing slip.
        /// </summary>
        /// <value>A fulfillment order identifier submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays as the order identifier in recipient-facing materials such as the packing slip.</value>
        [DataMember(Name = "displayableOrderId", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayableOrderId { get; set; }

        /// <summary>
        /// Date timestamp
        /// </summary>
        /// <value>Date timestamp</value>
        [DataMember(Name = "displayableOrderDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime DisplayableOrderDate { get; set; }

        /// <summary>
        /// A text block submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays in recipient-facing materials such as the packing slip.
        /// </summary>
        /// <value>A text block submitted with the &#x60;createFulfillmentOrder&#x60; operation. Displays in recipient-facing materials such as the packing slip.</value>
        [DataMember(Name = "displayableOrderComment", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayableOrderComment { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryWindow
        /// </summary>
        [DataMember(Name = "deliveryWindow", EmitDefaultValue = false)]
        public DeliveryWindow DeliveryWindow { get; set; }

        /// <summary>
        /// Gets or Sets DestinationAddress
        /// </summary>
        [DataMember(Name = "destinationAddress", IsRequired = true, EmitDefaultValue = true)]
        public Address DestinationAddress { get; set; }

        /// <summary>
        /// Gets or Sets CodSettings
        /// </summary>
        [DataMember(Name = "codSettings", EmitDefaultValue = false)]
        public CODSettings CodSettings { get; set; }

        /// <summary>
        /// Date timestamp
        /// </summary>
        /// <value>Date timestamp</value>
        [DataMember(Name = "receivedDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Date timestamp
        /// </summary>
        /// <value>Date timestamp</value>
        [DataMember(Name = "statusUpdatedDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StatusUpdatedDate { get; set; }

        /// <summary>
        /// A list of email addresses that the seller provides that are used by Amazon to send ship-complete notifications to recipients on behalf of the seller.
        /// </summary>
        /// <value>A list of email addresses that the seller provides that are used by Amazon to send ship-complete notifications to recipients on behalf of the seller.</value>
        [DataMember(Name = "notificationEmails", EmitDefaultValue = false)]
        public List<string> NotificationEmails { get; set; }

        /// <summary>
        /// A list of features and their fulfillment policies to apply to the order.
        /// </summary>
        /// <value>A list of features and their fulfillment policies to apply to the order.</value>
        [DataMember(Name = "featureConstraints", EmitDefaultValue = false)]
        public List<FeatureSettings> FeatureConstraints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FulfillmentOrder {\n");
            sb.Append("  SellerFulfillmentOrderId: ").Append(SellerFulfillmentOrderId).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  DisplayableOrderId: ").Append(DisplayableOrderId).Append("\n");
            sb.Append("  DisplayableOrderDate: ").Append(DisplayableOrderDate).Append("\n");
            sb.Append("  DisplayableOrderComment: ").Append(DisplayableOrderComment).Append("\n");
            sb.Append("  ShippingSpeedCategory: ").Append(ShippingSpeedCategory).Append("\n");
            sb.Append("  DeliveryWindow: ").Append(DeliveryWindow).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  FulfillmentAction: ").Append(FulfillmentAction).Append("\n");
            sb.Append("  FulfillmentPolicy: ").Append(FulfillmentPolicy).Append("\n");
            sb.Append("  CodSettings: ").Append(CodSettings).Append("\n");
            sb.Append("  ReceivedDate: ").Append(ReceivedDate).Append("\n");
            sb.Append("  FulfillmentOrderStatus: ").Append(FulfillmentOrderStatus).Append("\n");
            sb.Append("  StatusUpdatedDate: ").Append(StatusUpdatedDate).Append("\n");
            sb.Append("  NotificationEmails: ").Append(NotificationEmails).Append("\n");
            sb.Append("  FeatureConstraints: ").Append(FeatureConstraints).Append("\n");
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

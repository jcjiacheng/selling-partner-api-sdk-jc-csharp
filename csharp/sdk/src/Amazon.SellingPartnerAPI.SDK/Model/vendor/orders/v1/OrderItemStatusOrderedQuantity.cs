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
    /// Ordered quantity information.
    /// </summary>
    [DataContract(Name = "OrderItemStatus_orderedQuantity")]
    public partial class OrderItemStatusOrderedQuantity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemStatusOrderedQuantity" /> class.
        /// </summary>
        /// <param name="orderedQuantity">orderedQuantity.</param>
        /// <param name="orderedQuantityDetails">Details of item quantity ordered..</param>
        public OrderItemStatusOrderedQuantity(ItemQuantity orderedQuantity = default(ItemQuantity), List<OrderedQuantityDetails> orderedQuantityDetails = default(List<OrderedQuantityDetails>))
        {
            this.OrderedQuantity = orderedQuantity;
            this.OrderedQuantityDetails = orderedQuantityDetails;
        }

        /// <summary>
        /// Gets or Sets OrderedQuantity
        /// </summary>
        [DataMember(Name = "orderedQuantity", EmitDefaultValue = false)]
        public ItemQuantity OrderedQuantity { get; set; }

        /// <summary>
        /// Details of item quantity ordered.
        /// </summary>
        /// <value>Details of item quantity ordered.</value>
        [DataMember(Name = "orderedQuantityDetails", EmitDefaultValue = false)]
        public List<OrderedQuantityDetails> OrderedQuantityDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderItemStatusOrderedQuantity {\n");
            sb.Append("  OrderedQuantity: ").Append(OrderedQuantity).Append("\n");
            sb.Append("  OrderedQuantityDetails: ").Append(OrderedQuantityDetails).Append("\n");
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

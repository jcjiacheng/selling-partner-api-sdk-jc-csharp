/*
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v0
{
    /// <summary>
    /// Labeling requirements and item preparation instructions to help you prepare items for shipment to Amazon&#39;s fulfillment network.
    /// </summary>
    [DataContract(Name = "SKUPrepInstructions")]
    public partial class SKUPrepInstructions : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets BarcodeInstruction
        /// </summary>
        [DataMember(Name = "BarcodeInstruction", EmitDefaultValue = false)]
        public BarcodeInstruction? BarcodeInstruction { get; set; }

        /// <summary>
        /// Gets or Sets PrepGuidance
        /// </summary>
        [DataMember(Name = "PrepGuidance", EmitDefaultValue = false)]
        public PrepGuidance? PrepGuidance { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SKUPrepInstructions" /> class.
        /// </summary>
        /// <param name="sellerSKU">The seller SKU of the item..</param>
        /// <param name="aSIN">The Amazon Standard Identification Number (ASIN) of the item..</param>
        /// <param name="barcodeInstruction">barcodeInstruction.</param>
        /// <param name="prepGuidance">prepGuidance.</param>
        /// <param name="prepInstructionList">A list of preparation instructions to help with item sourcing decisions..</param>
        /// <param name="amazonPrepFeesDetailsList">A list of preparation instructions and fees for Amazon to prep goods for shipment..</param>
        public SKUPrepInstructions(string sellerSKU = default(string), string aSIN = default(string), BarcodeInstruction? barcodeInstruction = default(BarcodeInstruction?), PrepGuidance? prepGuidance = default(PrepGuidance?), List<PrepInstruction> prepInstructionList = default(List<PrepInstruction>), List<AmazonPrepFeesDetails> amazonPrepFeesDetailsList = default(List<AmazonPrepFeesDetails>))
        {
            this.SellerSKU = sellerSKU;
            this.ASIN = aSIN;
            this.BarcodeInstruction = barcodeInstruction;
            this.PrepGuidance = prepGuidance;
            this.PrepInstructionList = prepInstructionList;
            this.AmazonPrepFeesDetailsList = amazonPrepFeesDetailsList;
        }

        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        /// <value>The seller SKU of the item.</value>
        [DataMember(Name = "SellerSKU", EmitDefaultValue = false)]
        public string SellerSKU { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item.</value>
        [DataMember(Name = "ASIN", EmitDefaultValue = false)]
        public string ASIN { get; set; }

        /// <summary>
        /// A list of preparation instructions to help with item sourcing decisions.
        /// </summary>
        /// <value>A list of preparation instructions to help with item sourcing decisions.</value>
        [DataMember(Name = "PrepInstructionList", EmitDefaultValue = false)]
        public List<PrepInstruction> PrepInstructionList { get; set; }

        /// <summary>
        /// A list of preparation instructions and fees for Amazon to prep goods for shipment.
        /// </summary>
        /// <value>A list of preparation instructions and fees for Amazon to prep goods for shipment.</value>
        [DataMember(Name = "AmazonPrepFeesDetailsList", EmitDefaultValue = false)]
        public List<AmazonPrepFeesDetails> AmazonPrepFeesDetailsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SKUPrepInstructions {\n");
            sb.Append("  SellerSKU: ").Append(SellerSKU).Append("\n");
            sb.Append("  ASIN: ").Append(ASIN).Append("\n");
            sb.Append("  BarcodeInstruction: ").Append(BarcodeInstruction).Append("\n");
            sb.Append("  PrepGuidance: ").Append(PrepGuidance).Append("\n");
            sb.Append("  PrepInstructionList: ").Append(PrepInstructionList).Append("\n");
            sb.Append("  AmazonPrepFeesDetailsList: ").Append(AmazonPrepFeesDetailsList).Append("\n");
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

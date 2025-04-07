/*
 * The Selling Partner API for FBA inbound operations.
 *
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * The version of the OpenAPI document: 2024-03-20
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

namespace Amazon.SellingPartnerAPI.SDK.Model/fulfillment/inbound/v2024_03_20
{
    /// <summary>
    /// The &#x60;createInboundPlan&#x60; request.
    /// </summary>
    [DataContract(Name = "CreateInboundPlanRequest")]
    public partial class CreateInboundPlanRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboundPlanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInboundPlanRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboundPlanRequest" /> class.
        /// </summary>
        /// <param name="destinationMarketplaces">Marketplaces where the items need to be shipped to. Currently only one marketplace can be selected in this request. (required).</param>
        /// <param name="items">Items included in this plan. (required).</param>
        /// <param name="name">Name for the Inbound Plan. If one isn&#39;t provided, a default name will be provided..</param>
        /// <param name="sourceAddress">sourceAddress (required).</param>
        public CreateInboundPlanRequest(List<string> destinationMarketplaces = default(List<string>), List<ItemInput> items = default(List<ItemInput>), string name = default(string), AddressInput sourceAddress = default(AddressInput))
        {
            // to ensure "destinationMarketplaces" is required (not null)
            if (destinationMarketplaces == null)
            {
                throw new ArgumentNullException("destinationMarketplaces is a required property for CreateInboundPlanRequest and cannot be null");
            }
            this.DestinationMarketplaces = destinationMarketplaces;
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for CreateInboundPlanRequest and cannot be null");
            }
            this.Items = items;
            // to ensure "sourceAddress" is required (not null)
            if (sourceAddress == null)
            {
                throw new ArgumentNullException("sourceAddress is a required property for CreateInboundPlanRequest and cannot be null");
            }
            this.SourceAddress = sourceAddress;
            this.Name = name;
        }

        /// <summary>
        /// Marketplaces where the items need to be shipped to. Currently only one marketplace can be selected in this request.
        /// </summary>
        /// <value>Marketplaces where the items need to be shipped to. Currently only one marketplace can be selected in this request.</value>
        [DataMember(Name = "destinationMarketplaces", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DestinationMarketplaces { get; set; }

        /// <summary>
        /// Items included in this plan.
        /// </summary>
        /// <value>Items included in this plan.</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<ItemInput> Items { get; set; }

        /// <summary>
        /// Name for the Inbound Plan. If one isn&#39;t provided, a default name will be provided.
        /// </summary>
        /// <value>Name for the Inbound Plan. If one isn&#39;t provided, a default name will be provided.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SourceAddress
        /// </summary>
        [DataMember(Name = "sourceAddress", IsRequired = true, EmitDefaultValue = true)]
        public AddressInput SourceAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateInboundPlanRequest {\n");
            sb.Append("  DestinationMarketplaces: ").Append(DestinationMarketplaces).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 40)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 40.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}

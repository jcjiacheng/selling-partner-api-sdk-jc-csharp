/*
 * Selling Partner API for Supply Sources
 *
 * Manage configurations and capabilities of seller supply sources.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/supplySources/v2020_07_01
{
    /// <summary>
    /// The capabilities of a supply source.
    /// </summary>
    [DataContract(Name = "SupplySourceCapabilities")]
    public partial class SupplySourceCapabilities : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplySourceCapabilities" /> class.
        /// </summary>
        /// <param name="outbound">outbound.</param>
        /// <param name="services">services.</param>
        public SupplySourceCapabilities(OutboundCapability outbound = default(OutboundCapability), ServicesCapability services = default(ServicesCapability))
        {
            this.Outbound = outbound;
            this.Services = services;
        }

        /// <summary>
        /// Gets or Sets Outbound
        /// </summary>
        [DataMember(Name = "outbound", EmitDefaultValue = false)]
        public OutboundCapability Outbound { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public ServicesCapability Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SupplySourceCapabilities {\n");
            sb.Append("  Outbound: ").Append(Outbound).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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

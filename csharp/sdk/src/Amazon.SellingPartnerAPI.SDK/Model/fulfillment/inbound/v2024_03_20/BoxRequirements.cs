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
    /// The requirements for a box in the packing option.
    /// </summary>
    [DataContract(Name = "BoxRequirements")]
    public partial class BoxRequirements : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxRequirements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BoxRequirements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxRequirements" /> class.
        /// </summary>
        /// <param name="weight">weight (required).</param>
        public BoxRequirements(WeightRange weight = default(WeightRange))
        {
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new ArgumentNullException("weight is a required property for BoxRequirements and cannot be null");
            }
            this.Weight = weight;
        }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public WeightRange Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BoxRequirements {\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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

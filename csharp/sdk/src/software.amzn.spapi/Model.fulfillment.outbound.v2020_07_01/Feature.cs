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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.fulfillment.outbound.v2020_07_01
{
    /// <summary>
    /// A Multi-Channel Fulfillment feature.
    /// </summary>
    [DataContract(Name = "Feature")]
    public partial class Feature : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Feature() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Feature" /> class.
        /// </summary>
        /// <param name="featureName">The feature name. (required).</param>
        /// <param name="featureDescription">The feature description. (required).</param>
        /// <param name="sellerEligible">When true, indicates that the seller is eligible to use the feature..</param>
        public Feature(string featureName = default(string), string featureDescription = default(string), bool sellerEligible = default(bool))
        {
            // to ensure "featureName" is required (not null)
            if (featureName == null)
            {
                throw new ArgumentNullException("featureName is a required property for Feature and cannot be null");
            }
            this.FeatureName = featureName;
            // to ensure "featureDescription" is required (not null)
            if (featureDescription == null)
            {
                throw new ArgumentNullException("featureDescription is a required property for Feature and cannot be null");
            }
            this.FeatureDescription = featureDescription;
            this.SellerEligible = sellerEligible;
        }

        /// <summary>
        /// The feature name.
        /// </summary>
        /// <value>The feature name.</value>
        [DataMember(Name = "featureName", IsRequired = true, EmitDefaultValue = true)]
        public string FeatureName { get; set; }

        /// <summary>
        /// The feature description.
        /// </summary>
        /// <value>The feature description.</value>
        [DataMember(Name = "featureDescription", IsRequired = true, EmitDefaultValue = true)]
        public string FeatureDescription { get; set; }

        /// <summary>
        /// When true, indicates that the seller is eligible to use the feature.
        /// </summary>
        /// <value>When true, indicates that the seller is eligible to use the feature.</value>
        [DataMember(Name = "sellerEligible", EmitDefaultValue = true)]
        public bool SellerEligible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Feature {\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  FeatureDescription: ").Append(FeatureDescription).Append("\n");
            sb.Append("  SellerEligible: ").Append(SellerEligible).Append("\n");
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

/*
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](https://developer-docs.amazon.com/sp-api/docs/listings-items-api-v2021-08-01-use-case-guide).
 *
 * The version of the OpenAPI document: 2021-08-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/listings/items/v2021_08_01
{
    /// <summary>
    /// This field provides information about the enforcement actions taken by Amazon that affect the publishing or status of a listing. It also includes details about any associated exemptions.
    /// </summary>
    [DataContract(Name = "IssueEnforcements")]
    public partial class IssueEnforcements : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEnforcements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssueEnforcements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEnforcements" /> class.
        /// </summary>
        /// <param name="actions">List of enforcement actions taken by Amazon that affect the publishing or status of a listing. (required).</param>
        /// <param name="exemption">exemption (required).</param>
        public IssueEnforcements(List<IssueEnforcementAction> actions = default(List<IssueEnforcementAction>), IssueExemption exemption = default(IssueExemption))
        {
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for IssueEnforcements and cannot be null");
            }
            this.Actions = actions;
            // to ensure "exemption" is required (not null)
            if (exemption == null)
            {
                throw new ArgumentNullException("exemption is a required property for IssueEnforcements and cannot be null");
            }
            this.Exemption = exemption;
        }

        /// <summary>
        /// List of enforcement actions taken by Amazon that affect the publishing or status of a listing.
        /// </summary>
        /// <value>List of enforcement actions taken by Amazon that affect the publishing or status of a listing.</value>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<IssueEnforcementAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Exemption
        /// </summary>
        [DataMember(Name = "exemption", IsRequired = true, EmitDefaultValue = true)]
        public IssueExemption Exemption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssueEnforcements {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Exemption: ").Append(Exemption).Append("\n");
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

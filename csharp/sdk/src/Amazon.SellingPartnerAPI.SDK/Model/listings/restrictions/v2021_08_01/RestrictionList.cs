/*
 * Selling Partner API for Listings Restrictions
 *
 * The Selling Partner API for Listings Restrictions provides programmatic access to restrictions on Amazon catalog listings.  For more information, see the [Listings Restrictions API Use Case Guide](doc:listings-restrictions-api-v2021-08-01-use-case-guide).
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

namespace Amazon.SellingPartnerAPI.SDK.Model/listings/restrictions/v2021_08_01
{
    /// <summary>
    /// A list of restrictions for the specified Amazon catalog item.
    /// </summary>
    [DataContract(Name = "RestrictionList")]
    public partial class RestrictionList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestrictionList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictionList" /> class.
        /// </summary>
        /// <param name="restrictions">restrictions (required).</param>
        public RestrictionList(List<Restriction> restrictions = default(List<Restriction>))
        {
            // to ensure "restrictions" is required (not null)
            if (restrictions == null)
            {
                throw new ArgumentNullException("restrictions is a required property for RestrictionList and cannot be null");
            }
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// Gets or Sets Restrictions
        /// </summary>
        [DataMember(Name = "restrictions", IsRequired = true, EmitDefaultValue = true)]
        public List<Restriction> Restrictions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RestrictionList {\n");
            sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
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

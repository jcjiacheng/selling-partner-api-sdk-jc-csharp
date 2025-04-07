/*
 * Selling Partner API for Retail Procurement Shipments
 *
 * The Selling Partner API for Retail Procurement Shipments provides programmatic access to retail shipping data for vendors.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/shipments/v1
{
    /// <summary>
    /// Tax registration details of the entity.
    /// </summary>
    [DataContract(Name = "TaxRegistrationDetails")]
    public partial class TaxRegistrationDetails : IValidatableObject
    {
        /// <summary>
        /// Tax registration type for the entity.
        /// </summary>
        /// <value>Tax registration type for the entity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxRegistrationTypeEnum
        {
            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 1,

            /// <summary>
            /// Enum GST for value: GST
            /// </summary>
            [EnumMember(Value = "GST")]
            GST = 2
        }


        /// <summary>
        /// Tax registration type for the entity.
        /// </summary>
        /// <value>Tax registration type for the entity.</value>
        [DataMember(Name = "taxRegistrationType", IsRequired = true, EmitDefaultValue = true)]
        public TaxRegistrationTypeEnum TaxRegistrationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRegistrationDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxRegistrationDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRegistrationDetails" /> class.
        /// </summary>
        /// <param name="taxRegistrationType">Tax registration type for the entity. (required).</param>
        /// <param name="taxRegistrationNumber">Tax registration number for the entity. For example, VAT ID. (required).</param>
        public TaxRegistrationDetails(TaxRegistrationTypeEnum taxRegistrationType = default(TaxRegistrationTypeEnum), string taxRegistrationNumber = default(string))
        {
            this.TaxRegistrationType = taxRegistrationType;
            // to ensure "taxRegistrationNumber" is required (not null)
            if (taxRegistrationNumber == null)
            {
                throw new ArgumentNullException("taxRegistrationNumber is a required property for TaxRegistrationDetails and cannot be null");
            }
            this.TaxRegistrationNumber = taxRegistrationNumber;
        }

        /// <summary>
        /// Tax registration number for the entity. For example, VAT ID.
        /// </summary>
        /// <value>Tax registration number for the entity. For example, VAT ID.</value>
        [DataMember(Name = "taxRegistrationNumber", IsRequired = true, EmitDefaultValue = true)]
        public string TaxRegistrationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxRegistrationDetails {\n");
            sb.Append("  TaxRegistrationType: ").Append(TaxRegistrationType).Append("\n");
            sb.Append("  TaxRegistrationNumber: ").Append(TaxRegistrationNumber).Append("\n");
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

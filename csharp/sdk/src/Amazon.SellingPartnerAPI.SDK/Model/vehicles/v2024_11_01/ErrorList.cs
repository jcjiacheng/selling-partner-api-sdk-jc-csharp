/*
 * The Selling Partner API for Automotive.
 *
 * The Selling Partner API for Automotive provides programmatic access to information needed by selling partners to provide compatibility information about their listed products.
 *
 * The version of the OpenAPI document: 2024-11-01
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vehicles/v2024_11_01
{
    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    [DataContract(Name = "ErrorList")]
    public partial class ErrorList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorList" /> class.
        /// </summary>
        /// <param name="errors">array of errors (required).</param>
        public ErrorList(List<Error> errors = default(List<Error>))
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for ErrorList and cannot be null");
            }
            this.Errors = errors;
        }

        /// <summary>
        /// array of errors
        /// </summary>
        /// <value>array of errors</value>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
        public List<Error> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorList {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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

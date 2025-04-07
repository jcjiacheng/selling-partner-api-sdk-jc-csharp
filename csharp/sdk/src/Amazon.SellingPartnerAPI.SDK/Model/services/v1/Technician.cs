/*
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders and manage their resources.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/services/v1
{
    /// <summary>
    /// A technician who is assigned to perform the service job in part or in full.
    /// </summary>
    [DataContract(Name = "Technician")]
    public partial class Technician : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Technician" /> class.
        /// </summary>
        /// <param name="technicianId">The technician identifier..</param>
        /// <param name="name">The name of the technician..</param>
        public Technician(string technicianId = default(string), string name = default(string))
        {
            this.TechnicianId = technicianId;
            this.Name = name;
        }

        /// <summary>
        /// The technician identifier.
        /// </summary>
        /// <value>The technician identifier.</value>
        [DataMember(Name = "technicianId", EmitDefaultValue = false)]
        public string TechnicianId { get; set; }

        /// <summary>
        /// The name of the technician.
        /// </summary>
        /// <value>The name of the technician.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Technician {\n");
            sb.Append("  TechnicianId: ").Append(TechnicianId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            // TechnicianId (string) maxLength
            if (this.TechnicianId != null && this.TechnicianId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for TechnicianId, length must be less than 50.", new [] { "TechnicianId" });
            }

            // TechnicianId (string) minLength
            if (this.TechnicianId != null && this.TechnicianId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for TechnicianId, length must be greater than 1.", new [] { "TechnicianId" });
            }

            yield break;
        }
    }

}

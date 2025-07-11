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
using OpenAPIDateConverter = software.amzn.spapi.Client.OpenAPIDateConverter;

namespace software.amzn.spapi.Model.services.v1
{
    /// <summary>
    /// Range capacity entity where each entry has a capacity type and corresponding slots.
    /// </summary>
    [DataContract(Name = "RangeCapacity")]
    public partial class RangeCapacity : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CapacityType
        /// </summary>
        [DataMember(Name = "capacityType", EmitDefaultValue = false)]
        public CapacityType? CapacityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeCapacity" /> class.
        /// </summary>
        /// <param name="capacityType">capacityType.</param>
        /// <param name="slots">Array of capacity slots in range slot format..</param>
        public RangeCapacity(CapacityType? capacityType = default(CapacityType?), List<RangeSlot> slots = default(List<RangeSlot>))
        {
            this.CapacityType = capacityType;
            this.Slots = slots;
        }

        /// <summary>
        /// Array of capacity slots in range slot format.
        /// </summary>
        /// <value>Array of capacity slots in range slot format.</value>
        [DataMember(Name = "slots", EmitDefaultValue = false)]
        public List<RangeSlot> Slots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RangeCapacity {\n");
            sb.Append("  CapacityType: ").Append(CapacityType).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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

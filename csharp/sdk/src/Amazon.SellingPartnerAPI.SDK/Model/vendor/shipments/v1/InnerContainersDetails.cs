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
    /// Details of the innerContainersDetails.
    /// </summary>
    [DataContract(Name = "InnerContainersDetails")]
    public partial class InnerContainersDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InnerContainersDetails" /> class.
        /// </summary>
        /// <param name="containerCount">Total containers as part of the shipment.</param>
        /// <param name="containerSequenceNumbers">Container sequence numbers that are involved in this shipment..</param>
        public InnerContainersDetails(int containerCount = default(int), List<ContainerSequenceNumbers> containerSequenceNumbers = default(List<ContainerSequenceNumbers>))
        {
            this.ContainerCount = containerCount;
            this.ContainerSequenceNumbers = containerSequenceNumbers;
        }

        /// <summary>
        /// Total containers as part of the shipment
        /// </summary>
        /// <value>Total containers as part of the shipment</value>
        [DataMember(Name = "containerCount", EmitDefaultValue = false)]
        public int ContainerCount { get; set; }

        /// <summary>
        /// Container sequence numbers that are involved in this shipment.
        /// </summary>
        /// <value>Container sequence numbers that are involved in this shipment.</value>
        [DataMember(Name = "containerSequenceNumbers", EmitDefaultValue = false)]
        public List<ContainerSequenceNumbers> ContainerSequenceNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InnerContainersDetails {\n");
            sb.Append("  ContainerCount: ").Append(ContainerCount).Append("\n");
            sb.Append("  ContainerSequenceNumbers: ").Append(ContainerSequenceNumbers).Append("\n");
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

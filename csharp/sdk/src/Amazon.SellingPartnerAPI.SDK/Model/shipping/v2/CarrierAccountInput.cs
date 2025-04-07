/*
 * Amazon Shipping API
 *
 * The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.
 *
 * The version of the OpenAPI document: v2
 * Contact: swa-api-core@amazon.com
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

namespace Amazon.SellingPartnerAPI.SDK.Model/shipping/v2
{
    /// <summary>
    /// Info About CarrierAccountInput
    /// </summary>
    [DataContract(Name = "CarrierAccountInput")]
    public partial class CarrierAccountInput : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets InputType
        /// </summary>
        [DataMember(Name = "inputType", EmitDefaultValue = false)]
        public InputType? InputType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierAccountInput" /> class.
        /// </summary>
        /// <param name="descriptionLocalizationKey">descriptionLocalizationKey value ..</param>
        /// <param name="name">name value ..</param>
        /// <param name="groupName">groupName value ..</param>
        /// <param name="inputType">inputType.</param>
        /// <param name="isMandatory">mandatory or not  value ..</param>
        /// <param name="isConfidential">is value is Confidential ..</param>
        /// <param name="isHidden">is value is hidden ..</param>
        /// <param name="validationMetadata">A list of ValidationMetadata.</param>
        public CarrierAccountInput(string descriptionLocalizationKey = default(string), string name = default(string), string groupName = default(string), InputType? inputType = default(InputType?), bool isMandatory = default(bool), bool isConfidential = default(bool), bool isHidden = default(bool), List<ValidationMetadata> validationMetadata = default(List<ValidationMetadata>))
        {
            this.DescriptionLocalizationKey = descriptionLocalizationKey;
            this.Name = name;
            this.GroupName = groupName;
            this.InputType = inputType;
            this.IsMandatory = isMandatory;
            this.IsConfidential = isConfidential;
            this.IsHidden = isHidden;
            this.ValidationMetadata = validationMetadata;
        }

        /// <summary>
        /// descriptionLocalizationKey value .
        /// </summary>
        /// <value>descriptionLocalizationKey value .</value>
        [DataMember(Name = "descriptionLocalizationKey", EmitDefaultValue = false)]
        public string DescriptionLocalizationKey { get; set; }

        /// <summary>
        /// name value .
        /// </summary>
        /// <value>name value .</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// groupName value .
        /// </summary>
        /// <value>groupName value .</value>
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// mandatory or not  value .
        /// </summary>
        /// <value>mandatory or not  value .</value>
        [DataMember(Name = "isMandatory", EmitDefaultValue = true)]
        public bool IsMandatory { get; set; }

        /// <summary>
        /// is value is Confidential .
        /// </summary>
        /// <value>is value is Confidential .</value>
        [DataMember(Name = "isConfidential", EmitDefaultValue = true)]
        public bool IsConfidential { get; set; }

        /// <summary>
        /// is value is hidden .
        /// </summary>
        /// <value>is value is hidden .</value>
        [DataMember(Name = "isHidden", EmitDefaultValue = true)]
        public bool IsHidden { get; set; }

        /// <summary>
        /// A list of ValidationMetadata
        /// </summary>
        /// <value>A list of ValidationMetadata</value>
        [DataMember(Name = "validationMetadata", EmitDefaultValue = false)]
        public List<ValidationMetadata> ValidationMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CarrierAccountInput {\n");
            sb.Append("  DescriptionLocalizationKey: ").Append(DescriptionLocalizationKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  InputType: ").Append(InputType).Append("\n");
            sb.Append("  IsMandatory: ").Append(IsMandatory).Append("\n");
            sb.Append("  IsConfidential: ").Append(IsConfidential).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
            sb.Append("  ValidationMetadata: ").Append(ValidationMetadata).Append("\n");
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

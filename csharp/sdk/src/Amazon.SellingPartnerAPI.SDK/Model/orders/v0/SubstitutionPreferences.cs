/*
 * Selling Partner API for Orders
 *
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * The version of the OpenAPI document: v0
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

namespace Amazon.SellingPartnerAPI.SDK.Model/orders/v0
{
    /// <summary>
    /// Substitution preferences for an order item.
    /// </summary>
    [DataContract(Name = "SubstitutionPreferences")]
    public partial class SubstitutionPreferences : IValidatableObject
    {
        /// <summary>
        /// The type of substitution that these preferences represent.
        /// </summary>
        /// <value>The type of substitution that these preferences represent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubstitutionTypeEnum
        {
            /// <summary>
            /// Enum CUSTOMERPREFERENCE for value: CUSTOMER_PREFERENCE
            /// </summary>
            [EnumMember(Value = "CUSTOMER_PREFERENCE")]
            CUSTOMERPREFERENCE = 1,

            /// <summary>
            /// Enum AMAZONRECOMMENDED for value: AMAZON_RECOMMENDED
            /// </summary>
            [EnumMember(Value = "AMAZON_RECOMMENDED")]
            AMAZONRECOMMENDED = 2,

            /// <summary>
            /// Enum DONOTSUBSTITUTE for value: DO_NOT_SUBSTITUTE
            /// </summary>
            [EnumMember(Value = "DO_NOT_SUBSTITUTE")]
            DONOTSUBSTITUTE = 3
        }


        /// <summary>
        /// The type of substitution that these preferences represent.
        /// </summary>
        /// <value>The type of substitution that these preferences represent.</value>
        [DataMember(Name = "SubstitutionType", IsRequired = true, EmitDefaultValue = true)]
        public SubstitutionTypeEnum SubstitutionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionPreferences" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubstitutionPreferences() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubstitutionPreferences" /> class.
        /// </summary>
        /// <param name="substitutionType">The type of substitution that these preferences represent. (required).</param>
        /// <param name="substitutionOptions">A collection of substitution options..</param>
        public SubstitutionPreferences(SubstitutionTypeEnum substitutionType = default(SubstitutionTypeEnum), List<SubstitutionOption> substitutionOptions = default(List<SubstitutionOption>))
        {
            this.SubstitutionType = substitutionType;
            this.SubstitutionOptions = substitutionOptions;
        }

        /// <summary>
        /// A collection of substitution options.
        /// </summary>
        /// <value>A collection of substitution options.</value>
        [DataMember(Name = "SubstitutionOptions", EmitDefaultValue = false)]
        public List<SubstitutionOption> SubstitutionOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubstitutionPreferences {\n");
            sb.Append("  SubstitutionType: ").Append(SubstitutionType).Append("\n");
            sb.Append("  SubstitutionOptions: ").Append(SubstitutionOptions).Append("\n");
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

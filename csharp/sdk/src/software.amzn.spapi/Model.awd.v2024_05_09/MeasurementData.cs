/*
 * The Selling Partner API for Amazon Warehousing and Distribution
 *
 * The Selling Partner API for Amazon Warehousing and Distribution (AWD) provides programmatic access to information about AWD shipments and inventory.
 *
 * The version of the OpenAPI document: 2024-05-09
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

namespace software.amzn.spapi.Model.awd.v2024_05_09
{
    /// <summary>
    /// Package weight and dimension.
    /// </summary>
    [DataContract(Name = "MeasurementData")]
    public partial class MeasurementData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MeasurementData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementData" /> class.
        /// </summary>
        /// <param name="dimensions">dimensions.</param>
        /// <param name="volume">volume.</param>
        /// <param name="weight">weight (required).</param>
        public MeasurementData(PackageDimensions dimensions = default(PackageDimensions), PackageVolume volume = default(PackageVolume), PackageWeight weight = default(PackageWeight))
        {
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new ArgumentNullException("weight is a required property for MeasurementData and cannot be null");
            }
            this.Weight = weight;
            this.Dimensions = dimensions;
            this.Volume = volume;
        }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public PackageDimensions Dimensions { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name = "volume", EmitDefaultValue = false)]
        public PackageVolume Volume { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public PackageWeight Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MeasurementData {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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

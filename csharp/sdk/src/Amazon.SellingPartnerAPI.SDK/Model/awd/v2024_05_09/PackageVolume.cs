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
using OpenAPIDateConverter = Amazon.SellingPartnerAPI.SDK.Client.OpenAPIDateConverter;

namespace Amazon.SellingPartnerAPI.SDK.Model/awd/v2024_05_09
{
    /// <summary>
    /// Represents the volume of the package with a unit of measurement.
    /// </summary>
    [DataContract(Name = "PackageVolume")]
    public partial class PackageVolume : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UnitOfMeasurement
        /// </summary>
        [DataMember(Name = "unitOfMeasurement", IsRequired = true, EmitDefaultValue = true)]
        public VolumeUnitOfMeasurement UnitOfMeasurement { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVolume" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageVolume() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVolume" /> class.
        /// </summary>
        /// <param name="unitOfMeasurement">unitOfMeasurement (required).</param>
        /// <param name="volume">The package volume value. (required).</param>
        public PackageVolume(VolumeUnitOfMeasurement unitOfMeasurement = default(VolumeUnitOfMeasurement), double volume = default(double))
        {
            this.UnitOfMeasurement = unitOfMeasurement;
            this.Volume = volume;
        }

        /// <summary>
        /// The package volume value.
        /// </summary>
        /// <value>The package volume value.</value>
        [DataMember(Name = "volume", IsRequired = true, EmitDefaultValue = true)]
        public double Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PackageVolume {\n");
            sb.Append("  UnitOfMeasurement: ").Append(UnitOfMeasurement).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
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

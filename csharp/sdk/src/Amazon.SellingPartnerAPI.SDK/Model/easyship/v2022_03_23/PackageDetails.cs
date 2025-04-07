/*
 * Selling Partner API for Easy Ship
 *
 * Use the Selling Partner API for Easy Ship to build applications for sellers to manage and ship Amazon Easy Ship orders. With this API, you can get available time slots, schedule and reschedule Easy Ship orders, and print shipping labels, invoices, and warranties. To review the differences in Easy Ship operations by marketplace, refer to [Marketplace support](https://developer-docs.amazon.com/sp-api/docs/easyship-api-v2022-03-23-use-case-guide#marketplace-support).
 *
 * The version of the OpenAPI document: 2022-03-23
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

namespace Amazon.SellingPartnerAPI.SDK.Model/easyship/v2022_03_23
{
    /// <summary>
    /// Package details. Includes &#x60;packageItems&#x60;, &#x60;packageTimeSlot&#x60;, and &#x60;packageIdentifier&#x60;.
    /// </summary>
    [DataContract(Name = "PackageDetails")]
    public partial class PackageDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PackageDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageDetails" /> class.
        /// </summary>
        /// <param name="packageItems">A list of items contained in the package..</param>
        /// <param name="packageTimeSlot">packageTimeSlot (required).</param>
        /// <param name="packageIdentifier">Optional seller-created identifier that is printed on the shipping label to help the seller identify the package..</param>
        public PackageDetails(List<Item> packageItems = default(List<Item>), TimeSlot packageTimeSlot = default(TimeSlot), string packageIdentifier = default(string))
        {
            // to ensure "packageTimeSlot" is required (not null)
            if (packageTimeSlot == null)
            {
                throw new ArgumentNullException("packageTimeSlot is a required property for PackageDetails and cannot be null");
            }
            this.PackageTimeSlot = packageTimeSlot;
            this.PackageItems = packageItems;
            this.PackageIdentifier = packageIdentifier;
        }

        /// <summary>
        /// A list of items contained in the package.
        /// </summary>
        /// <value>A list of items contained in the package.</value>
        [DataMember(Name = "packageItems", EmitDefaultValue = false)]
        public List<Item> PackageItems { get; set; }

        /// <summary>
        /// Gets or Sets PackageTimeSlot
        /// </summary>
        [DataMember(Name = "packageTimeSlot", IsRequired = true, EmitDefaultValue = true)]
        public TimeSlot PackageTimeSlot { get; set; }

        /// <summary>
        /// Optional seller-created identifier that is printed on the shipping label to help the seller identify the package.
        /// </summary>
        /// <value>Optional seller-created identifier that is printed on the shipping label to help the seller identify the package.</value>
        [DataMember(Name = "packageIdentifier", EmitDefaultValue = false)]
        public string PackageIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PackageDetails {\n");
            sb.Append("  PackageItems: ").Append(PackageItems).Append("\n");
            sb.Append("  PackageTimeSlot: ").Append(PackageTimeSlot).Append("\n");
            sb.Append("  PackageIdentifier: ").Append(PackageIdentifier).Append("\n");
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

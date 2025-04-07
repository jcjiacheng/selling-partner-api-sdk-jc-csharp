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
    /// Request to update the time slot of a package.
    /// </summary>
    [DataContract(Name = "UpdatePackageDetails")]
    public partial class UpdatePackageDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePackageDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePackageDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePackageDetails" /> class.
        /// </summary>
        /// <param name="scheduledPackageId">scheduledPackageId (required).</param>
        /// <param name="packageTimeSlot">packageTimeSlot (required).</param>
        public UpdatePackageDetails(ScheduledPackageId scheduledPackageId = default(ScheduledPackageId), TimeSlot packageTimeSlot = default(TimeSlot))
        {
            // to ensure "scheduledPackageId" is required (not null)
            if (scheduledPackageId == null)
            {
                throw new ArgumentNullException("scheduledPackageId is a required property for UpdatePackageDetails and cannot be null");
            }
            this.ScheduledPackageId = scheduledPackageId;
            // to ensure "packageTimeSlot" is required (not null)
            if (packageTimeSlot == null)
            {
                throw new ArgumentNullException("packageTimeSlot is a required property for UpdatePackageDetails and cannot be null");
            }
            this.PackageTimeSlot = packageTimeSlot;
        }

        /// <summary>
        /// Gets or Sets ScheduledPackageId
        /// </summary>
        [DataMember(Name = "scheduledPackageId", IsRequired = true, EmitDefaultValue = true)]
        public ScheduledPackageId ScheduledPackageId { get; set; }

        /// <summary>
        /// Gets or Sets PackageTimeSlot
        /// </summary>
        [DataMember(Name = "packageTimeSlot", IsRequired = true, EmitDefaultValue = true)]
        public TimeSlot PackageTimeSlot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePackageDetails {\n");
            sb.Append("  ScheduledPackageId: ").Append(ScheduledPackageId).Append("\n");
            sb.Append("  PackageTimeSlot: ").Append(PackageTimeSlot).Append("\n");
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

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
    /// This object contains all the details of the scheduled Easy Ship package.
    /// </summary>
    [DataContract(Name = "Package")]
    public partial class Package : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PackageStatus
        /// </summary>
        [DataMember(Name = "packageStatus", EmitDefaultValue = false)]
        public PackageStatus? PackageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Package() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        /// <param name="scheduledPackageId">scheduledPackageId (required).</param>
        /// <param name="packageDimensions">packageDimensions (required).</param>
        /// <param name="packageWeight">packageWeight (required).</param>
        /// <param name="packageItems">A list of items contained in the package..</param>
        /// <param name="packageTimeSlot">packageTimeSlot (required).</param>
        /// <param name="packageIdentifier">Optional seller-created identifier that is printed on the shipping label to help the seller identify the package..</param>
        /// <param name="invoice">invoice.</param>
        /// <param name="packageStatus">packageStatus.</param>
        /// <param name="trackingDetails">trackingDetails.</param>
        public Package(ScheduledPackageId scheduledPackageId = default(ScheduledPackageId), Dimensions packageDimensions = default(Dimensions), Weight packageWeight = default(Weight), List<Item> packageItems = default(List<Item>), TimeSlot packageTimeSlot = default(TimeSlot), string packageIdentifier = default(string), InvoiceData invoice = default(InvoiceData), PackageStatus? packageStatus = default(PackageStatus?), TrackingDetails trackingDetails = default(TrackingDetails))
        {
            // to ensure "scheduledPackageId" is required (not null)
            if (scheduledPackageId == null)
            {
                throw new ArgumentNullException("scheduledPackageId is a required property for Package and cannot be null");
            }
            this.ScheduledPackageId = scheduledPackageId;
            // to ensure "packageDimensions" is required (not null)
            if (packageDimensions == null)
            {
                throw new ArgumentNullException("packageDimensions is a required property for Package and cannot be null");
            }
            this.PackageDimensions = packageDimensions;
            // to ensure "packageWeight" is required (not null)
            if (packageWeight == null)
            {
                throw new ArgumentNullException("packageWeight is a required property for Package and cannot be null");
            }
            this.PackageWeight = packageWeight;
            // to ensure "packageTimeSlot" is required (not null)
            if (packageTimeSlot == null)
            {
                throw new ArgumentNullException("packageTimeSlot is a required property for Package and cannot be null");
            }
            this.PackageTimeSlot = packageTimeSlot;
            this.PackageItems = packageItems;
            this.PackageIdentifier = packageIdentifier;
            this.Invoice = invoice;
            this.PackageStatus = packageStatus;
            this.TrackingDetails = trackingDetails;
        }

        /// <summary>
        /// Gets or Sets ScheduledPackageId
        /// </summary>
        [DataMember(Name = "scheduledPackageId", IsRequired = true, EmitDefaultValue = true)]
        public ScheduledPackageId ScheduledPackageId { get; set; }

        /// <summary>
        /// Gets or Sets PackageDimensions
        /// </summary>
        [DataMember(Name = "packageDimensions", IsRequired = true, EmitDefaultValue = true)]
        public Dimensions PackageDimensions { get; set; }

        /// <summary>
        /// Gets or Sets PackageWeight
        /// </summary>
        [DataMember(Name = "packageWeight", IsRequired = true, EmitDefaultValue = true)]
        public Weight PackageWeight { get; set; }

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
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name = "invoice", EmitDefaultValue = false)]
        public InvoiceData Invoice { get; set; }

        /// <summary>
        /// Gets or Sets TrackingDetails
        /// </summary>
        [DataMember(Name = "trackingDetails", EmitDefaultValue = false)]
        public TrackingDetails TrackingDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Package {\n");
            sb.Append("  ScheduledPackageId: ").Append(ScheduledPackageId).Append("\n");
            sb.Append("  PackageDimensions: ").Append(PackageDimensions).Append("\n");
            sb.Append("  PackageWeight: ").Append(PackageWeight).Append("\n");
            sb.Append("  PackageItems: ").Append(PackageItems).Append("\n");
            sb.Append("  PackageTimeSlot: ").Append(PackageTimeSlot).Append("\n");
            sb.Append("  PackageIdentifier: ").Append(PackageIdentifier).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  PackageStatus: ").Append(PackageStatus).Append("\n");
            sb.Append("  TrackingDetails: ").Append(TrackingDetails).Append("\n");
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

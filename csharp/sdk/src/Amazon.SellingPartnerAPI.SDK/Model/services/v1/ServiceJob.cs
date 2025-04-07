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
    /// The job details of a service.
    /// </summary>
    [DataContract(Name = "ServiceJob")]
    public partial class ServiceJob : IValidatableObject
    {
        /// <summary>
        /// The status of the service job.
        /// </summary>
        /// <value>The status of the service job.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceJobStatusEnum
        {
            /// <summary>
            /// Enum NOTSERVICED for value: NOT_SERVICED
            /// </summary>
            [EnumMember(Value = "NOT_SERVICED")]
            NOTSERVICED = 1,

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 2,

            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 3,

            /// <summary>
            /// Enum PENDINGSCHEDULE for value: PENDING_SCHEDULE
            /// </summary>
            [EnumMember(Value = "PENDING_SCHEDULE")]
            PENDINGSCHEDULE = 4,

            /// <summary>
            /// Enum NOTFULFILLABLE for value: NOT_FULFILLABLE
            /// </summary>
            [EnumMember(Value = "NOT_FULFILLABLE")]
            NOTFULFILLABLE = 5,

            /// <summary>
            /// Enum HOLD for value: HOLD
            /// </summary>
            [EnumMember(Value = "HOLD")]
            HOLD = 6,

            /// <summary>
            /// Enum PAYMENTDECLINED for value: PAYMENT_DECLINED
            /// </summary>
            [EnumMember(Value = "PAYMENT_DECLINED")]
            PAYMENTDECLINED = 7
        }


        /// <summary>
        /// The status of the service job.
        /// </summary>
        /// <value>The status of the service job.</value>
        [DataMember(Name = "serviceJobStatus", EmitDefaultValue = false)]
        public ServiceJobStatusEnum? ServiceJobStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceJob" /> class.
        /// </summary>
        /// <param name="createTime">The date and time of the creation of the job in ISO 8601 format..</param>
        /// <param name="serviceJobId">Amazon identifier for the service job..</param>
        /// <param name="serviceJobStatus">The status of the service job..</param>
        /// <param name="scopeOfWork">scopeOfWork.</param>
        /// <param name="seller">seller.</param>
        /// <param name="serviceJobProvider">serviceJobProvider.</param>
        /// <param name="preferredAppointmentTimes">A list of appointment windows preferred by the buyer. Included only if the buyer selected appointment windows when creating the order..</param>
        /// <param name="appointments">A list of appointments..</param>
        /// <param name="serviceOrderId">The Amazon-defined identifier for an order placed by the buyer, in 3-7-7 format..</param>
        /// <param name="marketplaceId">The marketplace identifier..</param>
        /// <param name="storeId">The Amazon-defined identifier for the region scope..</param>
        /// <param name="buyer">buyer.</param>
        /// <param name="associatedItems">A list of items associated with the service job..</param>
        /// <param name="serviceLocation">serviceLocation.</param>
        public ServiceJob(DateTime createTime = default(DateTime), string serviceJobId = default(string), ServiceJobStatusEnum? serviceJobStatus = default(ServiceJobStatusEnum?), ScopeOfWork scopeOfWork = default(ScopeOfWork), Seller seller = default(Seller), ServiceJobProvider serviceJobProvider = default(ServiceJobProvider), List<AppointmentTime> preferredAppointmentTimes = default(List<AppointmentTime>), List<Appointment> appointments = default(List<Appointment>), string serviceOrderId = default(string), string marketplaceId = default(string), string storeId = default(string), Buyer buyer = default(Buyer), List<AssociatedItem> associatedItems = default(List<AssociatedItem>), ServiceLocation serviceLocation = default(ServiceLocation))
        {
            this.CreateTime = createTime;
            this.ServiceJobId = serviceJobId;
            this.ServiceJobStatus = serviceJobStatus;
            this.ScopeOfWork = scopeOfWork;
            this.Seller = seller;
            this.ServiceJobProvider = serviceJobProvider;
            this.PreferredAppointmentTimes = preferredAppointmentTimes;
            this.Appointments = appointments;
            this.ServiceOrderId = serviceOrderId;
            this.MarketplaceId = marketplaceId;
            this.StoreId = storeId;
            this.Buyer = buyer;
            this.AssociatedItems = associatedItems;
            this.ServiceLocation = serviceLocation;
        }

        /// <summary>
        /// The date and time of the creation of the job in ISO 8601 format.
        /// </summary>
        /// <value>The date and time of the creation of the job in ISO 8601 format.</value>
        [DataMember(Name = "createTime", EmitDefaultValue = false)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Amazon identifier for the service job.
        /// </summary>
        /// <value>Amazon identifier for the service job.</value>
        [DataMember(Name = "serviceJobId", EmitDefaultValue = false)]
        public string ServiceJobId { get; set; }

        /// <summary>
        /// Gets or Sets ScopeOfWork
        /// </summary>
        [DataMember(Name = "scopeOfWork", EmitDefaultValue = false)]
        public ScopeOfWork ScopeOfWork { get; set; }

        /// <summary>
        /// Gets or Sets Seller
        /// </summary>
        [DataMember(Name = "seller", EmitDefaultValue = false)]
        public Seller Seller { get; set; }

        /// <summary>
        /// Gets or Sets ServiceJobProvider
        /// </summary>
        [DataMember(Name = "serviceJobProvider", EmitDefaultValue = false)]
        public ServiceJobProvider ServiceJobProvider { get; set; }

        /// <summary>
        /// A list of appointment windows preferred by the buyer. Included only if the buyer selected appointment windows when creating the order.
        /// </summary>
        /// <value>A list of appointment windows preferred by the buyer. Included only if the buyer selected appointment windows when creating the order.</value>
        [DataMember(Name = "preferredAppointmentTimes", EmitDefaultValue = false)]
        public List<AppointmentTime> PreferredAppointmentTimes { get; set; }

        /// <summary>
        /// A list of appointments.
        /// </summary>
        /// <value>A list of appointments.</value>
        [DataMember(Name = "appointments", EmitDefaultValue = false)]
        public List<Appointment> Appointments { get; set; }

        /// <summary>
        /// The Amazon-defined identifier for an order placed by the buyer, in 3-7-7 format.
        /// </summary>
        /// <value>The Amazon-defined identifier for an order placed by the buyer, in 3-7-7 format.</value>
        [DataMember(Name = "serviceOrderId", EmitDefaultValue = false)]
        public string ServiceOrderId { get; set; }

        /// <summary>
        /// The marketplace identifier.
        /// </summary>
        /// <value>The marketplace identifier.</value>
        [DataMember(Name = "marketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The Amazon-defined identifier for the region scope.
        /// </summary>
        /// <value>The Amazon-defined identifier for the region scope.</value>
        [DataMember(Name = "storeId", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets Buyer
        /// </summary>
        [DataMember(Name = "buyer", EmitDefaultValue = false)]
        public Buyer Buyer { get; set; }

        /// <summary>
        /// A list of items associated with the service job.
        /// </summary>
        /// <value>A list of items associated with the service job.</value>
        [DataMember(Name = "associatedItems", EmitDefaultValue = false)]
        public List<AssociatedItem> AssociatedItems { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLocation
        /// </summary>
        [DataMember(Name = "serviceLocation", EmitDefaultValue = false)]
        public ServiceLocation ServiceLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceJob {\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ServiceJobId: ").Append(ServiceJobId).Append("\n");
            sb.Append("  ServiceJobStatus: ").Append(ServiceJobStatus).Append("\n");
            sb.Append("  ScopeOfWork: ").Append(ScopeOfWork).Append("\n");
            sb.Append("  Seller: ").Append(Seller).Append("\n");
            sb.Append("  ServiceJobProvider: ").Append(ServiceJobProvider).Append("\n");
            sb.Append("  PreferredAppointmentTimes: ").Append(PreferredAppointmentTimes).Append("\n");
            sb.Append("  Appointments: ").Append(Appointments).Append("\n");
            sb.Append("  ServiceOrderId: ").Append(ServiceOrderId).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  AssociatedItems: ").Append(AssociatedItems).Append("\n");
            sb.Append("  ServiceLocation: ").Append(ServiceLocation).Append("\n");
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
            // ServiceJobId (string) maxLength
            if (this.ServiceJobId != null && this.ServiceJobId.Length > 100)
            {
                yield return new ValidationResult("Invalid value for ServiceJobId, length must be less than 100.", new [] { "ServiceJobId" });
            }

            // ServiceJobId (string) minLength
            if (this.ServiceJobId != null && this.ServiceJobId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ServiceJobId, length must be greater than 1.", new [] { "ServiceJobId" });
            }

            // ServiceOrderId (string) maxLength
            if (this.ServiceOrderId != null && this.ServiceOrderId.Length > 20)
            {
                yield return new ValidationResult("Invalid value for ServiceOrderId, length must be less than 20.", new [] { "ServiceOrderId" });
            }

            // ServiceOrderId (string) minLength
            if (this.ServiceOrderId != null && this.ServiceOrderId.Length < 5)
            {
                yield return new ValidationResult("Invalid value for ServiceOrderId, length must be greater than 5.", new [] { "ServiceOrderId" });
            }

            if (this.MarketplaceId != null) {
                // MarketplaceId (string) pattern
                Regex regexMarketplaceId = new Regex(@"^[A-Z0-9]*$", RegexOptions.CultureInvariant);
                if (!regexMarketplaceId.Match(this.MarketplaceId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MarketplaceId, must match a pattern of " + regexMarketplaceId, new [] { "MarketplaceId" });
                }
            }

            // StoreId (string) maxLength
            if (this.StoreId != null && this.StoreId.Length > 100)
            {
                yield return new ValidationResult("Invalid value for StoreId, length must be less than 100.", new [] { "StoreId" });
            }

            // StoreId (string) minLength
            if (this.StoreId != null && this.StoreId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for StoreId, length must be greater than 1.", new [] { "StoreId" });
            }

            yield break;
        }
    }

}

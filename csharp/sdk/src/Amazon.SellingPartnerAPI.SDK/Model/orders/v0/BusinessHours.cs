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
    /// Business days and hours when the destination is open for deliveries.
    /// </summary>
    [DataContract(Name = "BusinessHours")]
    public partial class BusinessHours : IValidatableObject
    {
        /// <summary>
        /// Day of the week.
        /// </summary>
        /// <value>Day of the week.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DayOfWeekEnum
        {
            /// <summary>
            /// Enum SUN for value: SUN
            /// </summary>
            [EnumMember(Value = "SUN")]
            SUN = 1,

            /// <summary>
            /// Enum MON for value: MON
            /// </summary>
            [EnumMember(Value = "MON")]
            MON = 2,

            /// <summary>
            /// Enum TUE for value: TUE
            /// </summary>
            [EnumMember(Value = "TUE")]
            TUE = 3,

            /// <summary>
            /// Enum WED for value: WED
            /// </summary>
            [EnumMember(Value = "WED")]
            WED = 4,

            /// <summary>
            /// Enum THU for value: THU
            /// </summary>
            [EnumMember(Value = "THU")]
            THU = 5,

            /// <summary>
            /// Enum FRI for value: FRI
            /// </summary>
            [EnumMember(Value = "FRI")]
            FRI = 6,

            /// <summary>
            /// Enum SAT for value: SAT
            /// </summary>
            [EnumMember(Value = "SAT")]
            SAT = 7
        }


        /// <summary>
        /// Day of the week.
        /// </summary>
        /// <value>Day of the week.</value>
        [DataMember(Name = "DayOfWeek", EmitDefaultValue = false)]
        public DayOfWeekEnum? DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHours" /> class.
        /// </summary>
        /// <param name="dayOfWeek">Day of the week..</param>
        /// <param name="openIntervals">Time window during the day when the business is open..</param>
        public BusinessHours(DayOfWeekEnum? dayOfWeek = default(DayOfWeekEnum?), List<OpenInterval> openIntervals = default(List<OpenInterval>))
        {
            this.DayOfWeek = dayOfWeek;
            this.OpenIntervals = openIntervals;
        }

        /// <summary>
        /// Time window during the day when the business is open.
        /// </summary>
        /// <value>Time window during the day when the business is open.</value>
        [DataMember(Name = "OpenIntervals", EmitDefaultValue = false)]
        public List<OpenInterval> OpenIntervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessHours {\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  OpenIntervals: ").Append(OpenIntervals).Append("\n");
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

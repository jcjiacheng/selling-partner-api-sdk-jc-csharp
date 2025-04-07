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
    /// Contains all of the delivery instructions provided by the customer for the shipping address.
    /// </summary>
    [DataContract(Name = "DeliveryPreferences")]
    public partial class DeliveryPreferences : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryPreferences" /> class.
        /// </summary>
        /// <param name="dropOffLocation">Drop-off location selected by the customer..</param>
        /// <param name="preferredDeliveryTime">preferredDeliveryTime.</param>
        /// <param name="otherAttributes">Enumerated list of miscellaneous delivery attributes associated with the shipping address..</param>
        /// <param name="addressInstructions">Building instructions, nearby landmark or navigation instructions..</param>
        public DeliveryPreferences(string dropOffLocation = default(string), PreferredDeliveryTime preferredDeliveryTime = default(PreferredDeliveryTime), List<OtherDeliveryAttributes> otherAttributes = default(List<OtherDeliveryAttributes>), string addressInstructions = default(string))
        {
            this.DropOffLocation = dropOffLocation;
            this.PreferredDeliveryTime = preferredDeliveryTime;
            this.OtherAttributes = otherAttributes;
            this.AddressInstructions = addressInstructions;
        }

        /// <summary>
        /// Drop-off location selected by the customer.
        /// </summary>
        /// <value>Drop-off location selected by the customer.</value>
        [DataMember(Name = "DropOffLocation", EmitDefaultValue = false)]
        public string DropOffLocation { get; set; }

        /// <summary>
        /// Gets or Sets PreferredDeliveryTime
        /// </summary>
        [DataMember(Name = "PreferredDeliveryTime", EmitDefaultValue = false)]
        public PreferredDeliveryTime PreferredDeliveryTime { get; set; }

        /// <summary>
        /// Enumerated list of miscellaneous delivery attributes associated with the shipping address.
        /// </summary>
        /// <value>Enumerated list of miscellaneous delivery attributes associated with the shipping address.</value>
        [DataMember(Name = "OtherAttributes", EmitDefaultValue = false)]
        public List<OtherDeliveryAttributes> OtherAttributes { get; set; }

        /// <summary>
        /// Building instructions, nearby landmark or navigation instructions.
        /// </summary>
        /// <value>Building instructions, nearby landmark or navigation instructions.</value>
        [DataMember(Name = "AddressInstructions", EmitDefaultValue = false)]
        public string AddressInstructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryPreferences {\n");
            sb.Append("  DropOffLocation: ").Append(DropOffLocation).Append("\n");
            sb.Append("  PreferredDeliveryTime: ").Append(PreferredDeliveryTime).Append("\n");
            sb.Append("  OtherAttributes: ").Append(OtherAttributes).Append("\n");
            sb.Append("  AddressInstructions: ").Append(AddressInstructions).Append("\n");
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

/*
 * Selling Partner API for Direct Fulfillment Payments
 *
 * The Selling Partner API for Direct Fulfillment Payments provides programmatic access to a direct fulfillment vendor's invoice data.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/df/payments/v1
{
    /// <summary>
    /// Address of the party.
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="name">The name of the person, business or institution at that address. (required).</param>
        /// <param name="addressLine1">First line of the address. (required).</param>
        /// <param name="addressLine2">Additional street address information, if required..</param>
        /// <param name="addressLine3">Additional street address information, if required..</param>
        /// <param name="city">The city where the person, business or institution is located. (required).</param>
        /// <param name="county">The county where person, business or institution is located..</param>
        /// <param name="district">The district where person, business or institution is located..</param>
        /// <param name="stateOrRegion">The state or region where person, business or institution is located. (required).</param>
        /// <param name="postalCode">The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces or punctuation. (required).</param>
        /// <param name="countryCode">The two digit country code in ISO 3166-1 alpha-2 format. (required).</param>
        /// <param name="phone">The phone number of the person, business or institution located at that address..</param>
        public Address(string name = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string county = default(string), string district = default(string), string stateOrRegion = default(string), string postalCode = default(string), string countryCode = default(string), string phone = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Address and cannot be null");
            }
            this.Name = name;
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new ArgumentNullException("addressLine1 is a required property for Address and cannot be null");
            }
            this.AddressLine1 = addressLine1;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Address and cannot be null");
            }
            this.City = city;
            // to ensure "stateOrRegion" is required (not null)
            if (stateOrRegion == null)
            {
                throw new ArgumentNullException("stateOrRegion is a required property for Address and cannot be null");
            }
            this.StateOrRegion = stateOrRegion;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for Address and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Address and cannot be null");
            }
            this.CountryCode = countryCode;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.County = county;
            this.District = district;
            this.Phone = phone;
        }

        /// <summary>
        /// The name of the person, business or institution at that address.
        /// </summary>
        /// <value>The name of the person, business or institution at that address.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// First line of the address.
        /// </summary>
        /// <value>First line of the address.</value>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        /// <value>Additional street address information, if required.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional street address information, if required.
        /// </summary>
        /// <value>Additional street address information, if required.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city where the person, business or institution is located.
        /// </summary>
        /// <value>The city where the person, business or institution is located.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The county where person, business or institution is located.
        /// </summary>
        /// <value>The county where person, business or institution is located.</value>
        [DataMember(Name = "county", EmitDefaultValue = false)]
        public string County { get; set; }

        /// <summary>
        /// The district where person, business or institution is located.
        /// </summary>
        /// <value>The district where person, business or institution is located.</value>
        [DataMember(Name = "district", EmitDefaultValue = false)]
        public string District { get; set; }

        /// <summary>
        /// The state or region where person, business or institution is located.
        /// </summary>
        /// <value>The state or region where person, business or institution is located.</value>
        [DataMember(Name = "stateOrRegion", IsRequired = true, EmitDefaultValue = true)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces or punctuation.
        /// </summary>
        /// <value>The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces or punctuation.</value>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two digit country code in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The two digit country code in ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone number of the person, business or institution located at that address.
        /// </summary>
        /// <value>The phone number of the person, business or institution located at that address.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  StateOrRegion: ").Append(StateOrRegion).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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

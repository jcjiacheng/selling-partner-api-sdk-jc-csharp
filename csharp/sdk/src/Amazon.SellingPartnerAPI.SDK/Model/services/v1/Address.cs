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
    /// The shipping address for the service job.
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
        /// <param name="name">The name of the person, business, or institution. (required).</param>
        /// <param name="addressLine1">The first line of the address. (required).</param>
        /// <param name="addressLine2">Additional address information, if required..</param>
        /// <param name="addressLine3">Additional address information, if required..</param>
        /// <param name="city">The city..</param>
        /// <param name="county">The county..</param>
        /// <param name="district">The district..</param>
        /// <param name="stateOrRegion">The state or region..</param>
        /// <param name="postalCode">The postal code. This can contain letters, digits, spaces, and/or punctuation..</param>
        /// <param name="countryCode">The two digit country code, in ISO 3166-1 alpha-2 format..</param>
        /// <param name="phone">The phone number..</param>
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
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.County = county;
            this.District = district;
            this.StateOrRegion = stateOrRegion;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.Phone = phone;
        }

        /// <summary>
        /// The name of the person, business, or institution.
        /// </summary>
        /// <value>The name of the person, business, or institution.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <value>The first line of the address.</value>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        /// <value>Additional address information, if required.</value>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Additional address information, if required.
        /// </summary>
        /// <value>Additional address information, if required.</value>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The county.
        /// </summary>
        /// <value>The county.</value>
        [DataMember(Name = "county", EmitDefaultValue = false)]
        public string County { get; set; }

        /// <summary>
        /// The district.
        /// </summary>
        /// <value>The district.</value>
        [DataMember(Name = "district", EmitDefaultValue = false)]
        public string District { get; set; }

        /// <summary>
        /// The state or region.
        /// </summary>
        /// <value>The state or region.</value>
        [DataMember(Name = "stateOrRegion", EmitDefaultValue = false)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// The postal code. This can contain letters, digits, spaces, and/or punctuation.
        /// </summary>
        /// <value>The postal code. This can contain letters, digits, spaces, and/or punctuation.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The two digit country code, in ISO 3166-1 alpha-2 format.
        /// </summary>
        /// <value>The two digit country code, in ISO 3166-1 alpha-2 format.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
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

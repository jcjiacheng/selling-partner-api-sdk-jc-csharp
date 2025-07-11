/*
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * The version of the OpenAPI document: 2021-06-30
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

namespace software.amzn.spapi.Model.feeds.v2021_06_30
{
    /// <summary>
    /// Response schema.
    /// </summary>
    [DataContract(Name = "GetFeedsResponse")]
    public partial class GetFeedsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFeedsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedsResponse" /> class.
        /// </summary>
        /// <param name="feeds">A list of feeds. (required).</param>
        /// <param name="nextToken">Returned when the number of results exceeds pageSize. To get the next page of results, call the getFeeds operation with this token as the only parameter..</param>
        public GetFeedsResponse(List<Feed> feeds = default(List<Feed>), string nextToken = default(string))
        {
            // to ensure "feeds" is required (not null)
            if (feeds == null)
            {
                throw new ArgumentNullException("feeds is a required property for GetFeedsResponse and cannot be null");
            }
            this.Feeds = feeds;
            this.NextToken = nextToken;
        }

        /// <summary>
        /// A list of feeds.
        /// </summary>
        /// <value>A list of feeds.</value>
        [DataMember(Name = "feeds", IsRequired = true, EmitDefaultValue = true)]
        public List<Feed> Feeds { get; set; }

        /// <summary>
        /// Returned when the number of results exceeds pageSize. To get the next page of results, call the getFeeds operation with this token as the only parameter.
        /// </summary>
        /// <value>Returned when the number of results exceeds pageSize. To get the next page of results, call the getFeeds operation with this token as the only parameter.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetFeedsResponse {\n");
            sb.Append("  Feeds: ").Append(Feeds).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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

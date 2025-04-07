/*
 * Selling Partner API for Data Kiosk
 *
 * The Selling Partner API for Data Kiosk lets you submit GraphQL queries from a variety of schemas to help selling partners manage their businesses.
 *
 * The version of the OpenAPI document: 2023-11-15
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

namespace Amazon.SellingPartnerAPI.SDK.Model/datakiosk/v2023_11_15
{
    /// <summary>
    /// When a request has results that are not included in this response, pagination occurs. This means the results are divided into pages. To retrieve the next page, you must pass the &#x60;nextToken&#x60; as the &#x60;paginationToken&#x60; query parameter in the subsequent &#x60;getQueries&#x60; request. All other parameters must be provided with the same values that were provided with the request that generated this token, with the exception of &#x60;pageSize&#x60; which can be modified between calls to &#x60;getQueries&#x60;. When there are no more pages to fetch, the &#x60;nextToken&#x60; field will be absent.
    /// </summary>
    [DataContract(Name = "GetQueriesResponse_pagination")]
    public partial class GetQueriesResponsePagination : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueriesResponsePagination" /> class.
        /// </summary>
        /// <param name="nextToken">A token that can be used to fetch the next page of results..</param>
        public GetQueriesResponsePagination(string nextToken = default(string))
        {
            this.NextToken = nextToken;
        }

        /// <summary>
        /// A token that can be used to fetch the next page of results.
        /// </summary>
        /// <value>A token that can be used to fetch the next page of results.</value>
        [DataMember(Name = "nextToken", EmitDefaultValue = false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetQueriesResponsePagination {\n");
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

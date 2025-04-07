/*
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/pricing/v0
{
    /// <summary>
    /// Information about the seller&#39;s feedback, including the percentage of positive feedback, and the total number of ratings received.
    /// </summary>
    [DataContract(Name = "SellerFeedbackType")]
    public partial class SellerFeedbackType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerFeedbackType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SellerFeedbackType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerFeedbackType" /> class.
        /// </summary>
        /// <param name="sellerPositiveFeedbackRating">The percentage of positive feedback for the seller in the past 365 days..</param>
        /// <param name="feedbackCount">The number of ratings received about the seller. (required).</param>
        public SellerFeedbackType(double sellerPositiveFeedbackRating = default(double), long feedbackCount = default(long))
        {
            this.FeedbackCount = feedbackCount;
            this.SellerPositiveFeedbackRating = sellerPositiveFeedbackRating;
        }

        /// <summary>
        /// The percentage of positive feedback for the seller in the past 365 days.
        /// </summary>
        /// <value>The percentage of positive feedback for the seller in the past 365 days.</value>
        [DataMember(Name = "SellerPositiveFeedbackRating", EmitDefaultValue = false)]
        public double SellerPositiveFeedbackRating { get; set; }

        /// <summary>
        /// The number of ratings received about the seller.
        /// </summary>
        /// <value>The number of ratings received about the seller.</value>
        [DataMember(Name = "FeedbackCount", IsRequired = true, EmitDefaultValue = true)]
        public long FeedbackCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SellerFeedbackType {\n");
            sb.Append("  SellerPositiveFeedbackRating: ").Append(SellerPositiveFeedbackRating).Append("\n");
            sb.Append("  FeedbackCount: ").Append(FeedbackCount).Append("\n");
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

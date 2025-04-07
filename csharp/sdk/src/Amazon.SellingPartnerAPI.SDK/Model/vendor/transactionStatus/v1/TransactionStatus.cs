/*
 * Selling Partner API for Retail Procurement Transaction Status
 *
 * The Selling Partner API for Retail Procurement Transaction Status provides programmatic access to status information on specific asynchronous POST transactions for vendors.
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

namespace Amazon.SellingPartnerAPI.SDK.Model/vendor/transactionStatus/v1
{
    /// <summary>
    /// Represents the status of a transaction.
    /// </summary>
    [DataContract(Name = "TransactionStatus")]
    public partial class TransactionStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatus" /> class.
        /// </summary>
        /// <param name="varTransactionStatus">varTransactionStatus.</param>
        public TransactionStatus(Transaction varTransactionStatus = default(Transaction))
        {
            this.VarTransactionStatus = varTransactionStatus;
        }

        /// <summary>
        /// Gets or Sets VarTransactionStatus
        /// </summary>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public Transaction VarTransactionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionStatus {\n");
            sb.Append("  VarTransactionStatus: ").Append(VarTransactionStatus).Append("\n");
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

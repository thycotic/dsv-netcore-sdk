/* 
 * DevOps Vault API
 *
 * The purpose of this application is to provide a simple service for storing and getting secrets
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DevOpsVault.SDK.Core.Client.OpenAPIDateConverter;

namespace DevOpsVault.SDK.Core.Model
{
    /// <summary>
    /// User search response with metadata
    /// </summary>
    [DataContract]
    public partial class UserSearch :  IEquatable<UserSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearch" /> class.
        /// </summary>
        /// <param name="cursor">Cursor to next batch of results.</param>
        /// <param name="data">Users that match the search term.</param>
        /// <param name="length">The number of results in this response.</param>
        /// <param name="limit">The maximum number of results per cursor.</param>
        public UserSearch(string cursor = default(string), List<UserResponse> data = default(List<UserResponse>), long length = default(long), long limit = default(long))
        {
            this.Cursor = cursor;
            this.Data = data;
            this.Length = length;
            this.Limit = limit;
        }
        
        /// <summary>
        /// Cursor to next batch of results
        /// </summary>
        /// <value>Cursor to next batch of results</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Users that match the search term
        /// </summary>
        /// <value>Users that match the search term</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<UserResponse> Data { get; set; }

        /// <summary>
        /// The number of results in this response
        /// </summary>
        /// <value>The number of results in this response</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public long Length { get; set; }

        /// <summary>
        /// The maximum number of results per cursor
        /// </summary>
        /// <value>The maximum number of results per cursor</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearch {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserSearch);
        }

        /// <summary>
        /// Returns true if UserSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Cursor != null)
                    hashCode = hashCode * 59 + this.Cursor.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

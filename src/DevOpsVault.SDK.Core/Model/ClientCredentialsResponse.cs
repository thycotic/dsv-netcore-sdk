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
    /// ClientCredentials are used in the client_credentials authentication flow
    /// </summary>
    [DataContract]
    public partial class ClientCredentialsResponse :  IEquatable<ClientCredentialsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredentialsResponse" /> class.
        /// </summary>
        /// <param name="clientId">Unique uuid of client credentials.</param>
        /// <param name="clientSecret">Secret key returned on create.</param>
        /// <param name="created">Created date.</param>
        /// <param name="createdBy">Who created.</param>
        /// <param name="id">the id for this item.</param>
        /// <param name="role">Assigned role for determining access.</param>
        public ClientCredentialsResponse(string clientId = default(string), string clientSecret = default(string), string created = default(string), string createdBy = default(string), string id = default(string), string role = default(string))
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.Id = id;
            this.Role = role;
        }
        
        /// <summary>
        /// Unique uuid of client credentials
        /// </summary>
        /// <value>Unique uuid of client credentials</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Secret key returned on create
        /// </summary>
        /// <value>Secret key returned on create</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        /// <value>Created date</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Who created
        /// </summary>
        /// <value>Who created</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// the id for this item
        /// </summary>
        /// <value>the id for this item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Assigned role for determining access
        /// </summary>
        /// <value>Assigned role for determining access</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientCredentialsResponse {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as ClientCredentialsResponse);
        }

        /// <summary>
        /// Returns true if ClientCredentialsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCredentialsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCredentialsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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
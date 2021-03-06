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
    /// AuthProperties
    /// </summary>
    [DataContract]
    public partial class AuthProperties :  IEquatable<AuthProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthProperties" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="baseUri">baseUri.</param>
        /// <param name="clientEmail">clientEmail.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="_default">_default.</param>
        /// <param name="privateKey">privateKey.</param>
        /// <param name="privateKeyId">privateKeyId.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="tokenUri">tokenUri.</param>
        /// <param name="type">type.</param>
        public AuthProperties(string accountId = default(string), string baseUri = default(string), string clientEmail = default(string), string clientId = default(string), string clientSecret = default(string), bool _default = default(bool), string privateKey = default(string), string privateKeyId = default(string), string projectId = default(string), string tenantId = default(string), string tokenUri = default(string), string type = default(string))
        {
            this.AccountId = accountId;
            this.BaseUri = baseUri;
            this.ClientEmail = clientEmail;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Default = _default;
            this.PrivateKey = privateKey;
            this.PrivateKeyId = privateKeyId;
            this.ProjectId = projectId;
            this.TenantId = tenantId;
            this.TokenUri = tokenUri;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets BaseUri
        /// </summary>
        [DataMember(Name="baseUri", EmitDefaultValue=false)]
        public string BaseUri { get; set; }

        /// <summary>
        /// Gets or Sets ClientEmail
        /// </summary>
        [DataMember(Name="clientEmail", EmitDefaultValue=false)]
        public string ClientEmail { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool Default { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKey
        /// </summary>
        [DataMember(Name="privateKey", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKeyId
        /// </summary>
        [DataMember(Name="privateKeyId", EmitDefaultValue=false)]
        public string PrivateKeyId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets TokenUri
        /// </summary>
        [DataMember(Name="tokenUri", EmitDefaultValue=false)]
        public string TokenUri { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthProperties {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  BaseUri: ").Append(BaseUri).Append("\n");
            sb.Append("  ClientEmail: ").Append(ClientEmail).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  PrivateKeyId: ").Append(PrivateKeyId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TokenUri: ").Append(TokenUri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AuthProperties);
        }

        /// <summary>
        /// Returns true if AuthProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.BaseUri == input.BaseUri ||
                    (this.BaseUri != null &&
                    this.BaseUri.Equals(input.BaseUri))
                ) && 
                (
                    this.ClientEmail == input.ClientEmail ||
                    (this.ClientEmail != null &&
                    this.ClientEmail.Equals(input.ClientEmail))
                ) && 
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
                    this.Default == input.Default ||
                    this.Default.Equals(input.Default)
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.PrivateKeyId == input.PrivateKeyId ||
                    (this.PrivateKeyId != null &&
                    this.PrivateKeyId.Equals(input.PrivateKeyId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.TokenUri == input.TokenUri ||
                    (this.TokenUri != null &&
                    this.TokenUri.Equals(input.TokenUri))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.BaseUri != null)
                    hashCode = hashCode * 59 + this.BaseUri.GetHashCode();
                if (this.ClientEmail != null)
                    hashCode = hashCode * 59 + this.ClientEmail.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.PrivateKeyId != null)
                    hashCode = hashCode * 59 + this.PrivateKeyId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TokenUri != null)
                    hashCode = hashCode * 59 + this.TokenUri.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

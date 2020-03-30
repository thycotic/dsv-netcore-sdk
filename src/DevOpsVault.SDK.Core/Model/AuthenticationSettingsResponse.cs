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
    /// AuthenticationSettings is the 3rd party authentication providers
    /// </summary>
    [DataContract]
    public partial class AuthenticationSettingsResponse :  IEquatable<AuthenticationSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationSettingsResponse" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="id">id.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="name">name.</param>
        /// <param name="properties">properties.</param>
        /// <param name="type">AuthenticationSettings provider system type.</param>
        /// <param name="version">version.</param>
        public AuthenticationSettingsResponse(string created = default(string), string createdBy = default(string), string id = default(string), string lastModified = default(string), string lastModifiedBy = default(string), string name = default(string), AuthenticationProviderPropertiesModel properties = default(AuthenticationProviderPropertiesModel), string type = default(string), string version = default(string))
        {
            this.Created = created;
            this.CreatedBy = createdBy;
            this.Id = id;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.Name = name;
            this.Properties = properties;
            this.Type = type;
            this.Version = version;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public AuthenticationProviderPropertiesModel Properties { get; set; }

        /// <summary>
        /// AuthenticationSettings provider system type
        /// </summary>
        /// <value>AuthenticationSettings provider system type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationSettingsResponse {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as AuthenticationSettingsResponse);
        }

        /// <summary>
        /// Returns true if AuthenticationSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
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
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
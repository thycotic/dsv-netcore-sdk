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
    /// Policy is a named set of permissions
    /// </summary>
    [DataContract]
    public partial class PolicyResponse :  IEquatable<PolicyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResponse" /> class.
        /// </summary>
        /// <param name="created">Created date.</param>
        /// <param name="createdBy">Who created the item.</param>
        /// <param name="id">id.</param>
        /// <param name="lastModified">Last updated date.</param>
        /// <param name="lastModifiedBy">Who performed the last modification.</param>
        /// <param name="path">path.</param>
        /// <param name="permissionDocument">permissionDocument.</param>
        /// <param name="version">Current version.</param>
        public PolicyResponse(string created = default(string), string createdBy = default(string), string id = default(string), string lastModified = default(string), string lastModifiedBy = default(string), string path = default(string), List<DefaultPolicy> permissionDocument = default(List<DefaultPolicy>), string version = default(string))
        {
            this.Created = created;
            this.CreatedBy = createdBy;
            this.Id = id;
            this.LastModified = lastModified;
            this.LastModifiedBy = lastModifiedBy;
            this.Path = path;
            this.PermissionDocument = permissionDocument;
            this.Version = version;
        }
        
        /// <summary>
        /// Created date
        /// </summary>
        /// <value>Created date</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Who created the item
        /// </summary>
        /// <value>Who created the item</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Last updated date
        /// </summary>
        /// <value>Last updated date</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// Who performed the last modification
        /// </summary>
        /// <value>Who performed the last modification</value>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets PermissionDocument
        /// </summary>
        [DataMember(Name="permissionDocument", EmitDefaultValue=false)]
        public List<DefaultPolicy> PermissionDocument { get; set; }

        /// <summary>
        /// Current version
        /// </summary>
        /// <value>Current version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyResponse {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  PermissionDocument: ").Append(PermissionDocument).Append("\n");
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
            return this.Equals(input as PolicyResponse);
        }

        /// <summary>
        /// Returns true if PolicyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyResponse input)
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.PermissionDocument == input.PermissionDocument ||
                    this.PermissionDocument != null &&
                    input.PermissionDocument != null &&
                    this.PermissionDocument.SequenceEqual(input.PermissionDocument)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.PermissionDocument != null)
                    hashCode = hashCode * 59 + this.PermissionDocument.GetHashCode();
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

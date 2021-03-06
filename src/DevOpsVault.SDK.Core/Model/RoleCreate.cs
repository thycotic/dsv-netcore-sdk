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
    /// RoleCreate
    /// </summary>
    [DataContract]
    public partial class RoleCreate :  IEquatable<RoleCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCreate" /> class.
        /// </summary>
        /// <param name="description">Role description.</param>
        /// <param name="externalId">External identifier, such as an AWS arn for 3rd party authentication.</param>
        /// <param name="name">Name of role (required).</param>
        /// <param name="provider">Provider name defined in the authentication settings section of configuration.</param>
        public RoleCreate(string description = default(string), string externalId = default(string), string name = default(string), string provider = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for RoleCreate and cannot be null");;
            this.Description = description;
            this.ExternalId = externalId;
            this.Provider = provider;
        }
        
        /// <summary>
        /// Role description
        /// </summary>
        /// <value>Role description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// External identifier, such as an AWS arn for 3rd party authentication
        /// </summary>
        /// <value>External identifier, such as an AWS arn for 3rd party authentication</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Name of role
        /// </summary>
        /// <value>Name of role</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Provider name defined in the authentication settings section of configuration
        /// </summary>
        /// <value>Provider name defined in the authentication settings section of configuration</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleCreate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
            return this.Equals(input as RoleCreate);
        }

        /// <summary>
        /// Returns true if RoleCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
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

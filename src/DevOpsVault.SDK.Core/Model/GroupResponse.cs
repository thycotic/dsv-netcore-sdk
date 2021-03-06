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
    /// GroupResponse  response with metadata
    /// </summary>
    [DataContract]
    public partial class GroupResponse :  IEquatable<GroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponse" /> class.
        /// </summary>
        /// <param name="groupName">group name.</param>
        /// <param name="id">the id for this item.</param>
        /// <param name="members">members.</param>
        /// <param name="metaData">MetaData.</param>
        /// <param name="version">Current version.</param>
        public GroupResponse(string groupName = default(string), string id = default(string), List<string> members = default(List<string>), List<Dictionary<string, string>> metaData = default(List<Dictionary<string, string>>), string version = default(string))
        {
            this.GroupName = groupName;
            this.Id = id;
            this.Members = members;
            this.MetaData = metaData;
            this.Version = version;
        }
        
        /// <summary>
        /// group name
        /// </summary>
        /// <value>group name</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// the id for this item
        /// </summary>
        /// <value>the id for this item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// members
        /// </summary>
        /// <value>members</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<string> Members { get; set; }

        /// <summary>
        /// MetaData
        /// </summary>
        /// <value>MetaData</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public List<Dictionary<string, string>> MetaData { get; set; }

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
            sb.Append("class GroupResponse {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
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
            return this.Equals(input as GroupResponse);
        }

        /// <summary>
        /// Returns true if GroupResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
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
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
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

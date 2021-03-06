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
    /// RootCASecret
    /// </summary>
    [DataContract]
    public partial class RootCASecret :  IEquatable<RootCASecret>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootCASecret" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RootCASecret() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RootCASecret" /> class.
        /// </summary>
        /// <param name="cert">Certificate of the root CA that contains information about it and public key (required).</param>
        /// <param name="domains">List of domains for which to sign certificate signing is allowed (required).</param>
        /// <param name="maxTTL">Maximum TTL of any signed certificate with a given root CA (in hours) (required).</param>
        /// <param name="privateKey">Private key of the root CA (required).</param>
        /// <param name="rootCAPath">Path to secret, which also serves as an identifier of the root CA (required).</param>
        public RootCASecret(string cert = default(string), List<string> domains = default(List<string>), long maxTTL = default(long), string privateKey = default(string), string rootCAPath = default(string))
        {
            // to ensure "cert" is required (not null)
            this.Cert = cert ?? throw new ArgumentNullException("cert is a required property for RootCASecret and cannot be null");;
            // to ensure "domains" is required (not null)
            this.Domains = domains ?? throw new ArgumentNullException("domains is a required property for RootCASecret and cannot be null");;
            this.MaxTTL = maxTTL;
            // to ensure "privateKey" is required (not null)
            this.PrivateKey = privateKey ?? throw new ArgumentNullException("privateKey is a required property for RootCASecret and cannot be null");;
            // to ensure "rootCAPath" is required (not null)
            this.RootCAPath = rootCAPath ?? throw new ArgumentNullException("rootCAPath is a required property for RootCASecret and cannot be null");;
        }
        
        /// <summary>
        /// Certificate of the root CA that contains information about it and public key
        /// </summary>
        /// <value>Certificate of the root CA that contains information about it and public key</value>
        [DataMember(Name="cert", EmitDefaultValue=false)]
        public string Cert { get; set; }

        /// <summary>
        /// List of domains for which to sign certificate signing is allowed
        /// </summary>
        /// <value>List of domains for which to sign certificate signing is allowed</value>
        [DataMember(Name="domains", EmitDefaultValue=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Maximum TTL of any signed certificate with a given root CA (in hours)
        /// </summary>
        /// <value>Maximum TTL of any signed certificate with a given root CA (in hours)</value>
        [DataMember(Name="maxTTL", EmitDefaultValue=false)]
        public long MaxTTL { get; set; }

        /// <summary>
        /// Private key of the root CA
        /// </summary>
        /// <value>Private key of the root CA</value>
        [DataMember(Name="privateKey", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Path to secret, which also serves as an identifier of the root CA
        /// </summary>
        /// <value>Path to secret, which also serves as an identifier of the root CA</value>
        [DataMember(Name="rootCAPath", EmitDefaultValue=false)]
        public string RootCAPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RootCASecret {\n");
            sb.Append("  Cert: ").Append(Cert).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  MaxTTL: ").Append(MaxTTL).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  RootCAPath: ").Append(RootCAPath).Append("\n");
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
            return this.Equals(input as RootCASecret);
        }

        /// <summary>
        /// Returns true if RootCASecret instances are equal
        /// </summary>
        /// <param name="input">Instance of RootCASecret to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RootCASecret input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cert == input.Cert ||
                    (this.Cert != null &&
                    this.Cert.Equals(input.Cert))
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.MaxTTL == input.MaxTTL ||
                    this.MaxTTL.Equals(input.MaxTTL)
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.RootCAPath == input.RootCAPath ||
                    (this.RootCAPath != null &&
                    this.RootCAPath.Equals(input.RootCAPath))
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
                if (this.Cert != null)
                    hashCode = hashCode * 59 + this.Cert.GetHashCode();
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                hashCode = hashCode * 59 + this.MaxTTL.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.RootCAPath != null)
                    hashCode = hashCode * 59 + this.RootCAPath.GetHashCode();
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

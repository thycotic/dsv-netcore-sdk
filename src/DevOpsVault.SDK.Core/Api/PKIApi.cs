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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using DevOpsVault.SDK.Core.Client;
using DevOpsVault.SDK.Core.Model;

namespace DevOpsVault.SDK.Core.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPKIApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Register a Root CA
        /// </summary>
        /// <remarks>
        /// Register a root CA as a secret.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SecretResponse</returns>
        SecretResponse RegisterRoot (RootCASecret body = default(RootCASecret));

        /// <summary>
        /// Register a Root CA
        /// </summary>
        /// <remarks>
        /// Register a root CA as a secret.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SecretResponse</returns>
        ApiResponse<SecretResponse> RegisterRootWithHttpInfo (RootCASecret body = default(RootCASecret));
        /// <summary>
        /// Create a signed certificate
        /// </summary>
        /// <remarks>
        /// Create and return a signed certificate based on a registered root CA.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ResponseCertificate</returns>
        ResponseCertificate SignCertificate (SigningRequest body = default(SigningRequest));

        /// <summary>
        /// Create a signed certificate
        /// </summary>
        /// <remarks>
        /// Create and return a signed certificate based on a registered root CA.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ResponseCertificate</returns>
        ApiResponse<ResponseCertificate> SignCertificateWithHttpInfo (SigningRequest body = default(SigningRequest));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPKIApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Register a Root CA
        /// </summary>
        /// <remarks>
        /// Register a root CA as a secret.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SecretResponse</returns>
        System.Threading.Tasks.Task<SecretResponse> RegisterRootAsync (RootCASecret body = default(RootCASecret));

        /// <summary>
        /// Register a Root CA
        /// </summary>
        /// <remarks>
        /// Register a root CA as a secret.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SecretResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SecretResponse>> RegisterRootAsyncWithHttpInfo (RootCASecret body = default(RootCASecret));
        /// <summary>
        /// Create a signed certificate
        /// </summary>
        /// <remarks>
        /// Create and return a signed certificate based on a registered root CA.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ResponseCertificate</returns>
        System.Threading.Tasks.Task<ResponseCertificate> SignCertificateAsync (SigningRequest body = default(SigningRequest));

        /// <summary>
        /// Create a signed certificate
        /// </summary>
        /// <remarks>
        /// Create and return a signed certificate based on a registered root CA.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ResponseCertificate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResponseCertificate>> SignCertificateAsyncWithHttpInfo (SigningRequest body = default(SigningRequest));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPKIApi : IPKIApiSync, IPKIApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PKIApi : IPKIApi
    {
        private DevOpsVault.SDK.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PKIApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PKIApi(String basePath)
        {
            this.Configuration = DevOpsVault.SDK.Core.Client.Configuration.MergeConfigurations(
                DevOpsVault.SDK.Core.Client.GlobalConfiguration.Instance,
                new DevOpsVault.SDK.Core.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DevOpsVault.SDK.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DevOpsVault.SDK.Core.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DevOpsVault.SDK.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PKIApi(DevOpsVault.SDK.Core.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DevOpsVault.SDK.Core.Client.Configuration.MergeConfigurations(
                DevOpsVault.SDK.Core.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DevOpsVault.SDK.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DevOpsVault.SDK.Core.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DevOpsVault.SDK.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PKIApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PKIApi(DevOpsVault.SDK.Core.Client.ISynchronousClient client,DevOpsVault.SDK.Core.Client.IAsynchronousClient asyncClient, DevOpsVault.SDK.Core.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DevOpsVault.SDK.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DevOpsVault.SDK.Core.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DevOpsVault.SDK.Core.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public DevOpsVault.SDK.Core.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DevOpsVault.SDK.Core.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Register a Root CA Register a root CA as a secret.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>SecretResponse</returns>
        public SecretResponse RegisterRoot (RootCASecret body = default(RootCASecret))
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<SecretResponse> localVarResponse = RegisterRootWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Register a Root CA Register a root CA as a secret.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SecretResponse</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< SecretResponse > RegisterRootWithHttpInfo (RootCASecret body = default(RootCASecret))
        {
            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< SecretResponse >("/pki/register", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterRoot", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register a Root CA Register a root CA as a secret.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SecretResponse</returns>
        public async System.Threading.Tasks.Task<SecretResponse> RegisterRootAsync (RootCASecret body = default(RootCASecret))
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<SecretResponse> localVarResponse = await RegisterRootAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Register a Root CA Register a root CA as a secret.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SecretResponse)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<SecretResponse>> RegisterRootAsyncWithHttpInfo (RootCASecret body = default(RootCASecret))
        {

            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = body;

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<SecretResponse>("/pki/register", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterRoot", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a signed certificate Create and return a signed certificate based on a registered root CA.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ResponseCertificate</returns>
        public ResponseCertificate SignCertificate (SigningRequest body = default(SigningRequest))
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ResponseCertificate> localVarResponse = SignCertificateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a signed certificate Create and return a signed certificate based on a registered root CA.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ResponseCertificate</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< ResponseCertificate > SignCertificateWithHttpInfo (SigningRequest body = default(SigningRequest))
        {
            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< ResponseCertificate >("/pki/sign", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SignCertificate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a signed certificate Create and return a signed certificate based on a registered root CA.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ResponseCertificate</returns>
        public async System.Threading.Tasks.Task<ResponseCertificate> SignCertificateAsync (SigningRequest body = default(SigningRequest))
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ResponseCertificate> localVarResponse = await SignCertificateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a signed certificate Create and return a signed certificate based on a registered root CA.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ResponseCertificate)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<ResponseCertificate>> SignCertificateAsyncWithHttpInfo (SigningRequest body = default(SigningRequest))
        {

            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = body;

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ResponseCertificate>("/pki/sign", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SignCertificate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

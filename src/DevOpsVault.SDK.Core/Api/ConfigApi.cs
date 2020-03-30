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
    public interface IConfigApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Config
        /// </summary>
        /// <remarks>
        /// Get config data.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigResponse</returns>
        ConfigResponse GetConfig ();

        /// <summary>
        /// Get Config
        /// </summary>
        /// <remarks>
        /// Get config data.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigResponse</returns>
        ApiResponse<ConfigResponse> GetConfigWithHttpInfo ();
        /// <summary>
        /// Get Config By Version
        /// </summary>
        /// <remarks>
        /// Get zero or more representations of config specified by version number.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>ConfigVersionResponse</returns>
        ConfigVersionResponse GetConfigByVersion (long version);

        /// <summary>
        /// Get Config By Version
        /// </summary>
        /// <remarks>
        /// Get zero or more representations of config specified by version number.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>ApiResponse of ConfigVersionResponse</returns>
        ApiResponse<ConfigVersionResponse> GetConfigByVersionWithHttpInfo (long version);
        /// <summary>
        /// Create Config
        /// </summary>
        /// <remarks>
        /// Create or update config.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigResponse</returns>
        ConfigResponse PostConfig ();

        /// <summary>
        /// Create Config
        /// </summary>
        /// <remarks>
        /// Create or update config.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigResponse</returns>
        ApiResponse<ConfigResponse> PostConfigWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Config
        /// </summary>
        /// <remarks>
        /// Get config data.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigResponse</returns>
        System.Threading.Tasks.Task<ConfigResponse> GetConfigAsync ();

        /// <summary>
        /// Get Config
        /// </summary>
        /// <remarks>
        /// Get config data.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigResponse>> GetConfigAsyncWithHttpInfo ();
        /// <summary>
        /// Get Config By Version
        /// </summary>
        /// <remarks>
        /// Get zero or more representations of config specified by version number.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>Task of ConfigVersionResponse</returns>
        System.Threading.Tasks.Task<ConfigVersionResponse> GetConfigByVersionAsync (long version);

        /// <summary>
        /// Get Config By Version
        /// </summary>
        /// <remarks>
        /// Get zero or more representations of config specified by version number.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>Task of ApiResponse (ConfigVersionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigVersionResponse>> GetConfigByVersionAsyncWithHttpInfo (long version);
        /// <summary>
        /// Create Config
        /// </summary>
        /// <remarks>
        /// Create or update config.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigResponse</returns>
        System.Threading.Tasks.Task<ConfigResponse> PostConfigAsync ();

        /// <summary>
        /// Create Config
        /// </summary>
        /// <remarks>
        /// Create or update config.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigResponse>> PostConfigAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigApi : IConfigApiSync, IConfigApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConfigApi : IConfigApi
    {
        private DevOpsVault.SDK.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigApi(DevOpsVault.SDK.Core.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ConfigApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConfigApi(DevOpsVault.SDK.Core.Client.ISynchronousClient client,DevOpsVault.SDK.Core.Client.IAsynchronousClient asyncClient, DevOpsVault.SDK.Core.Client.IReadableConfiguration configuration)
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
        /// Get Config Get config data.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigResponse</returns>
        public ConfigResponse GetConfig ()
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ConfigResponse> localVarResponse = GetConfigWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Config Get config data.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigResponse</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< ConfigResponse > GetConfigWithHttpInfo ()
        {
            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< ConfigResponse >("/config", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetConfig", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Config Get config data.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigResponse</returns>
        public async System.Threading.Tasks.Task<ConfigResponse> GetConfigAsync ()
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ConfigResponse> localVarResponse = await GetConfigAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Config Get config data.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigResponse)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<ConfigResponse>> GetConfigAsyncWithHttpInfo ()
        {

            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ConfigResponse>("/config", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetConfig", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Config By Version Get zero or more representations of config specified by version number.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>ConfigVersionResponse</returns>
        public ConfigVersionResponse GetConfigByVersion (long version)
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ConfigVersionResponse> localVarResponse = GetConfigByVersionWithHttpInfo(version);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Config By Version Get zero or more representations of config specified by version number.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>ApiResponse of ConfigVersionResponse</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< ConfigVersionResponse > GetConfigByVersionWithHttpInfo (long version)
        {
            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("version", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(version)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< ConfigVersionResponse >("/config/version/{version}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetConfigByVersion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Config By Version Get zero or more representations of config specified by version number.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>Task of ConfigVersionResponse</returns>
        public async System.Threading.Tasks.Task<ConfigVersionResponse> GetConfigByVersionAsync (long version)
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ConfigVersionResponse> localVarResponse = await GetConfigByVersionAsyncWithHttpInfo(version);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Config By Version Get zero or more representations of config specified by version number.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="version">Versions to return</param>
        /// <returns>Task of ApiResponse (ConfigVersionResponse)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<ConfigVersionResponse>> GetConfigByVersionAsyncWithHttpInfo (long version)
        {

            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("version", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(version)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ConfigVersionResponse>("/config/version/{version}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetConfigByVersion", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Config Create or update config.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ConfigResponse</returns>
        public ConfigResponse PostConfig ()
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ConfigResponse> localVarResponse = PostConfigWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Config Create or update config.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ConfigResponse</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< ConfigResponse > PostConfigWithHttpInfo ()
        {
            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< ConfigResponse >("/config", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostConfig", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Config Create or update config.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ConfigResponse</returns>
        public async System.Threading.Tasks.Task<ConfigResponse> PostConfigAsync ()
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<ConfigResponse> localVarResponse = await PostConfigAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Config Create or update config.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ConfigResponse)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<ConfigResponse>> PostConfigAsyncWithHttpInfo ()
        {

            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ConfigResponse>("/config", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PostConfig", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

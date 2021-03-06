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
    public interface ITasksApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get background task status
        /// </summary>
        /// <remarks>
        /// Get background task status by task uuid
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>TaskState</returns>
        TaskState GetTaskStatus (string id);

        /// <summary>
        /// Get background task status
        /// </summary>
        /// <remarks>
        /// Get background task status by task uuid
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>ApiResponse of TaskState</returns>
        ApiResponse<TaskState> GetTaskStatusWithHttpInfo (string id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITasksApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get background task status
        /// </summary>
        /// <remarks>
        /// Get background task status by task uuid
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>Task of TaskState</returns>
        System.Threading.Tasks.Task<TaskState> GetTaskStatusAsync (string id);

        /// <summary>
        /// Get background task status
        /// </summary>
        /// <remarks>
        /// Get background task status by task uuid
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>Task of ApiResponse (TaskState)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskState>> GetTaskStatusAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITasksApi : ITasksApiSync, ITasksApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TasksApi : ITasksApi
    {
        private DevOpsVault.SDK.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TasksApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TasksApi(String basePath)
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
        /// Initializes a new instance of the <see cref="TasksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TasksApi(DevOpsVault.SDK.Core.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TasksApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TasksApi(DevOpsVault.SDK.Core.Client.ISynchronousClient client,DevOpsVault.SDK.Core.Client.IAsynchronousClient asyncClient, DevOpsVault.SDK.Core.Client.IReadableConfiguration configuration)
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
        /// Get background task status Get background task status by task uuid
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>TaskState</returns>
        public TaskState GetTaskStatus (string id)
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<TaskState> localVarResponse = GetTaskStatusWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get background task status Get background task status by task uuid
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>ApiResponse of TaskState</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< TaskState > GetTaskStatusWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new DevOpsVault.SDK.Core.Client.ApiException(400, "Missing required parameter 'id' when calling TasksApi->GetTaskStatus");

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

            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< TaskState >("/task/status/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTaskStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get background task status Get background task status by task uuid
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>Task of TaskState</returns>
        public async System.Threading.Tasks.Task<TaskState> GetTaskStatusAsync (string id)
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<TaskState> localVarResponse = await GetTaskStatusAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get background task status Get background task status by task uuid
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Task status uuid</param>
        /// <returns>Task of ApiResponse (TaskState)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<TaskState>> GetTaskStatusAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new DevOpsVault.SDK.Core.Client.ApiException(400, "Missing required parameter 'id' when calling TasksApi->GetTaskStatus");


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
            
            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TaskState>("/task/status/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTaskStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

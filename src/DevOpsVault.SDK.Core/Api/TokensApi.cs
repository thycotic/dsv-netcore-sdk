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
    public interface ITokensApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Revoke Refresh Token
        /// </summary>
        /// <remarks>
        /// Revoke an existing refresh token to prevent it from being used for authentication.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns></returns>
        void Revoke (string refreshtoken);

        /// <summary>
        /// Revoke Refresh Token
        /// </summary>
        /// <remarks>
        /// Revoke an existing refresh token to prevent it from being used for authentication.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RevokeWithHttpInfo (string refreshtoken);
        /// <summary>
        /// Authenticate
        /// </summary>
        /// <remarks>
        /// Submit parameters to get a new access token for use on protected endpoints
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>AccessTokenResponse</returns>
        AccessTokenResponse Token (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string));

        /// <summary>
        /// Authenticate
        /// </summary>
        /// <remarks>
        /// Submit parameters to get a new access token for use on protected endpoints
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        ApiResponse<AccessTokenResponse> TokenWithHttpInfo (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Revoke Refresh Token
        /// </summary>
        /// <remarks>
        /// Revoke an existing refresh token to prevent it from being used for authentication.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RevokeAsync (string refreshtoken);

        /// <summary>
        /// Revoke Refresh Token
        /// </summary>
        /// <remarks>
        /// Revoke an existing refresh token to prevent it from being used for authentication.
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RevokeAsyncWithHttpInfo (string refreshtoken);
        /// <summary>
        /// Authenticate
        /// </summary>
        /// <remarks>
        /// Submit parameters to get a new access token for use on protected endpoints
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>Task of AccessTokenResponse</returns>
        System.Threading.Tasks.Task<AccessTokenResponse> TokenAsync (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string));

        /// <summary>
        /// Authenticate
        /// </summary>
        /// <remarks>
        /// Submit parameters to get a new access token for use on protected endpoints
        /// </remarks>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessTokenResponse>> TokenAsyncWithHttpInfo (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokensApi : ITokensApiSync, ITokensApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokensApi : ITokensApi
    {
        private DevOpsVault.SDK.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokensApi(String basePath)
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
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokensApi(DevOpsVault.SDK.Core.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TokensApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TokensApi(DevOpsVault.SDK.Core.Client.ISynchronousClient client,DevOpsVault.SDK.Core.Client.IAsynchronousClient asyncClient, DevOpsVault.SDK.Core.Client.IReadableConfiguration configuration)
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
        /// Revoke Refresh Token Revoke an existing refresh token to prevent it from being used for authentication.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns></returns>
        public void Revoke (string refreshtoken)
        {
             RevokeWithHttpInfo(refreshtoken);
        }

        /// <summary>
        /// Revoke Refresh Token Revoke an existing refresh token to prevent it from being used for authentication.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse<Object> RevokeWithHttpInfo (string refreshtoken)
        {
            // verify the required parameter 'refreshtoken' is set
            if (refreshtoken == null)
                throw new DevOpsVault.SDK.Core.Client.ApiException(400, "Missing required parameter 'refreshtoken' when calling TokensApi->Revoke");

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

            if (refreshtoken != null)
                localVarRequestOptions.PathParameters.Add("refreshtoken", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(refreshtoken)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/revoke/{refreshtoken}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Revoke", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Revoke Refresh Token Revoke an existing refresh token to prevent it from being used for authentication.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RevokeAsync (string refreshtoken)
        {
             await RevokeAsyncWithHttpInfo(refreshtoken);

        }

        /// <summary>
        /// Revoke Refresh Token Revoke an existing refresh token to prevent it from being used for authentication.
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refreshtoken">Refresh token to revoke</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<Object>> RevokeAsyncWithHttpInfo (string refreshtoken)
        {
            // verify the required parameter 'refreshtoken' is set
            if (refreshtoken == null)
                throw new DevOpsVault.SDK.Core.Client.ApiException(400, "Missing required parameter 'refreshtoken' when calling TokensApi->Revoke");


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
            
            if (refreshtoken != null)
                localVarRequestOptions.PathParameters.Add("refreshtoken", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(refreshtoken)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/revoke/{refreshtoken}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Revoke", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authenticate Submit parameters to get a new access token for use on protected endpoints
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>AccessTokenResponse</returns>
        public AccessTokenResponse Token (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string))
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<AccessTokenResponse> localVarResponse = TokenWithHttpInfo(grantType, username, password, provider, awsBody, awsHeaders, jwt, clientId, clientSecret, refreshToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticate Submit parameters to get a new access token for use on protected endpoints
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        public DevOpsVault.SDK.Core.Client.ApiResponse< AccessTokenResponse > TokenWithHttpInfo (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string))
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new DevOpsVault.SDK.Core.Client.ApiException(400, "Missing required parameter 'grantType' when calling TokensApi->Token");

            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DevOpsVault.SDK.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (grantType != null)
            {
                localVarRequestOptions.FormParameters.Add("grant_type", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(grantType)); // form parameter
            }
            if (username != null)
            {
                localVarRequestOptions.FormParameters.Add("username", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(username)); // form parameter
            }
            if (password != null)
            {
                localVarRequestOptions.FormParameters.Add("password", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(password)); // form parameter
            }
            if (provider != null)
            {
                localVarRequestOptions.FormParameters.Add("provider", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(provider)); // form parameter
            }
            if (awsBody != null)
            {
                localVarRequestOptions.FormParameters.Add("aws_body", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(awsBody)); // form parameter
            }
            if (awsHeaders != null)
            {
                localVarRequestOptions.FormParameters.Add("aws_headers", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(awsHeaders)); // form parameter
            }
            if (jwt != null)
            {
                localVarRequestOptions.FormParameters.Add("jwt", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(jwt)); // form parameter
            }
            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (clientSecret != null)
            {
                localVarRequestOptions.FormParameters.Add("client_secret", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(clientSecret)); // form parameter
            }
            if (refreshToken != null)
            {
                localVarRequestOptions.FormParameters.Add("refresh_token", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(refreshToken)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Post< AccessTokenResponse >("/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Token", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authenticate Submit parameters to get a new access token for use on protected endpoints
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>Task of AccessTokenResponse</returns>
        public async System.Threading.Tasks.Task<AccessTokenResponse> TokenAsync (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string))
        {
             DevOpsVault.SDK.Core.Client.ApiResponse<AccessTokenResponse> localVarResponse = await TokenAsyncWithHttpInfo(grantType, username, password, provider, awsBody, awsHeaders, jwt, clientId, clientSecret, refreshToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authenticate Submit parameters to get a new access token for use on protected endpoints
        /// </summary>
        /// <exception cref="DevOpsVault.SDK.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="username">Username for password grant type (optional)</param>
        /// <param name="password">Password for password grant type (optional)</param>
        /// <param name="provider">Provider name for password grant flow for Thycotic One authentication (optional)</param>
        /// <param name="awsBody">Base64 encoded signed aws request body for aws_iam grant type (optional)</param>
        /// <param name="awsHeaders">Base64 encoded signed aws request headers for aws_iam grant type (optional)</param>
        /// <param name="jwt">JWT token for azure and gcp grant types (optional)</param>
        /// <param name="clientId">Client id for client_credentials grant type (optional)</param>
        /// <param name="clientSecret">Client secret for client_credentials grant type (optional)</param>
        /// <param name="refreshToken">Previously issued refresh token for the refresh_token grant type (optional)</param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        public async System.Threading.Tasks.Task<DevOpsVault.SDK.Core.Client.ApiResponse<AccessTokenResponse>> TokenAsyncWithHttpInfo (string grantType, string username = default(string), string password = default(string), string provider = default(string), string awsBody = default(string), string awsHeaders = default(string), string jwt = default(string), string clientId = default(string), string clientSecret = default(string), string refreshToken = default(string))
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new DevOpsVault.SDK.Core.Client.ApiException(400, "Missing required parameter 'grantType' when calling TokensApi->Token");


            DevOpsVault.SDK.Core.Client.RequestOptions localVarRequestOptions = new DevOpsVault.SDK.Core.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (grantType != null)
            {
                localVarRequestOptions.FormParameters.Add("grant_type", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(grantType)); // form parameter
            }
            if (username != null)
            {
                localVarRequestOptions.FormParameters.Add("username", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(username)); // form parameter
            }
            if (password != null)
            {
                localVarRequestOptions.FormParameters.Add("password", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(password)); // form parameter
            }
            if (provider != null)
            {
                localVarRequestOptions.FormParameters.Add("provider", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(provider)); // form parameter
            }
            if (awsBody != null)
            {
                localVarRequestOptions.FormParameters.Add("aws_body", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(awsBody)); // form parameter
            }
            if (awsHeaders != null)
            {
                localVarRequestOptions.FormParameters.Add("aws_headers", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(awsHeaders)); // form parameter
            }
            if (jwt != null)
            {
                localVarRequestOptions.FormParameters.Add("jwt", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(jwt)); // form parameter
            }
            if (clientId != null)
            {
                localVarRequestOptions.FormParameters.Add("client_id", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(clientId)); // form parameter
            }
            if (clientSecret != null)
            {
                localVarRequestOptions.FormParameters.Add("client_secret", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(clientSecret)); // form parameter
            }
            if (refreshToken != null)
            {
                localVarRequestOptions.FormParameters.Add("refresh_token", DevOpsVault.SDK.Core.Client.ClientUtils.ParameterToString(refreshToken)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AccessTokenResponse>("/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Token", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

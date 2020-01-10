﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Identity
{
    /// <summary>
    /// Enables authentication to Azure Active Directory using configuration information stored Azure SDK Auth File.
    /// </summary>
    /// <remarks>
    /// An Azaure SDK Auth file may be generated by passing <code>--sdk-auth</code> when generating an service principal
    /// with <code>az ad sp create-for-rbac</code>. At this time <see cref="AuthFileCredential"/> only supports
    /// SDK Auth Files which contain a client secret, client certificates are not supported at this time.
    /// </remarks>
    public class AuthFileCredential : TokenCredential
    {
        internal string FilePath { get; }

        private readonly CredentialPipeline _pipeline;

        // Initialized on first use by EnsureCredential
        private TokenCredential _credential;

        /// <summary>
        /// Creates an instance of the SdkAuthFileCredential class based on information in given SDK Auth file.
        /// If the file is not found or there are errors parsing it, <see cref="GetToken(TokenRequestContext, CancellationToken)"/>
        /// and <see cref="GetTokenAsync(TokenRequestContext, CancellationToken)"/> will throw a <see cref="AuthenticationFailedException"/>
        /// with details on why the file could not be used.
        /// </summary>
        /// <param name="filePath">The path to the SDK Auth file.</param>
        public AuthFileCredential(string filePath):
            this(filePath, CredentialPipeline.GetInstance(null))
        {
        }

        /// <summary>
        /// Creates an instance of the SdkAuthFileCredential class based on information in given SDK Auth file.
        /// If the file is not found or there are errors parsing it, <see cref="GetToken(TokenRequestContext, CancellationToken)"/>
        /// and <see cref="GetTokenAsync(TokenRequestContext, CancellationToken)"/> will throw a <see cref="AuthenticationFailedException"/>
        /// with details on why the file could not be used.
        /// </summary>
        /// <param name="pathToFile">The path to the SDK Auth file.</param>
        /// <param name="options">Options that allow to configure the management of the requests sent to the Azure Active Directory service. Note that
        /// <see cref="TokenCredentialOptions.AuthorityHost"/> is ignored in favor of the <code>activeDirectoryEndpointUrl</code> property
        /// of the SDK Auth file.</param>
        public AuthFileCredential(string pathToFile, TokenCredentialOptions options)
            : this(pathToFile, CredentialPipeline.GetInstance(options))
        {
        }

        internal AuthFileCredential(string pathToFile, CredentialPipeline pipeline)
        {
            FilePath = pathToFile ?? throw new ArgumentNullException(nameof(pathToFile));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
        }

        /// <summary>
        /// Obtains a token from the Azure Active Directory service, using the specified client detailed specified in the SDK Auth file.
        /// This method is called by Azure SDK clients. It isn't intended for use in application code.
        /// </summary>
        /// <remarks>
        /// If the SDK Auth file is missing or invalid, this method throws a <see cref="AuthenticationFailedException"/> exception.
        /// </remarks>
        /// <param name="requestContext">The details of the authentication request</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An <see cref="AccessToken"/> which can be used to authenticate service client calls.</returns>
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            EnsureCredential(false, cancellationToken).GetAwaiter().GetResult();

            return _credential.GetToken(requestContext, cancellationToken);
        }

        /// <summary>
        /// Obtains a token from the Azure Active Directory service, using the specified client detailed specified in the SDK Auth file.
        /// This method is called by Azure SDK clients. It isn't intended for use in application code.
        /// </summary>
        /// <remarks>
        /// If the SDK Auth file is missing or invalid, this method throws a <see cref="AuthenticationFailedException"/> exception.
        /// </remarks>
        /// <param name="requestContext">The details of the authentication request</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An <see cref="AccessToken"/> which can be used to authenticate service client calls.</returns>
        public async override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            await EnsureCredential(true, cancellationToken).ConfigureAwait(false);

            return await _credential.GetTokenAsync(requestContext, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Ensures that credential information is loaded from the SDK Auth file. This method should be called to initialize
        /// <code>_credential</code> before it is used. If the SDK Auth file is not found or invalid, this method will throw
        /// <see cref="AuthenticationFailedException"/>.
        /// </summary>
        /// <param name="isAsync">When true, the task reutrned by this method may complete asynchronously.</param>
        /// <param name="cancellationToken">>A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>A task that will ensure <code>_credential</code> has been initialized</returns>
        internal async Task EnsureCredential(bool isAsync, CancellationToken cancellationToken)
        {
            if (_credential == null)
            {
                try
                {
                    _credential = BuildCredentialForCredentialsFile(isAsync ? await ParseCredentialsFileAsync(FilePath, cancellationToken).ConfigureAwait(false) : ParseCredentialsFile(FilePath));
                } catch (Exception e) when (!(e is OperationCanceledException))
                {
                    throw new AuthenticationFailedException("Error parsing SDK Auth File", e);
                }
            }
        }

        private static Dictionary<string, string> ParseCredentialsFile(string filePath)
        {
            return JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(filePath));
        }

        private static async Task<Dictionary<string, string>> ParseCredentialsFileAsync(string filePath, CancellationToken cancellationToken)
        {
            using Stream s = File.OpenRead(filePath);
            return await JsonSerializer.DeserializeAsync<Dictionary<string, string>>(s, null, cancellationToken);
        }

        private TokenCredential BuildCredentialForCredentialsFile(Dictionary<string, string> authData)
        {
            authData.TryGetValue("clientId", out string clientId);
            authData.TryGetValue("clientSecret", out string clientSecret);
            authData.TryGetValue("tenantId", out string tenantId);
            authData.TryGetValue("activeDirectoryEndpointUrl", out string activeDirectoryEndpointUrl);

            if (clientId == null || clientSecret == null || tenantId == null || activeDirectoryEndpointUrl == null)
            {
                throw new Exception("Malformed Azure SDK Auth file. The file should contain 'clientId', 'clientSecret', 'tenentId' and 'activeDirectoryEndpointUrl' values.");
            }

            return new ClientSecretCredential(tenantId, clientId, clientSecret, _pipeline.WithAuthorityHost(new Uri(activeDirectoryEndpointUrl)));
        }
    }
}

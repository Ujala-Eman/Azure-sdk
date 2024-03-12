// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionFileWorkspaceResource"/> and their operations.
    /// Each <see cref="SubscriptionFileWorkspaceResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SubscriptionFileWorkspaceCollection"/> instance call the GetSubscriptionFileWorkspaces method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SubscriptionFileWorkspaceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics;
        private readonly FileWorkspacesRestOperations _subscriptionFileWorkspaceFileWorkspacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionFileWorkspaceCollection"/> class for mocking. </summary>
        protected SubscriptionFileWorkspaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionFileWorkspaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionFileWorkspaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SubscriptionFileWorkspaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionFileWorkspaceResource.ResourceType, out string subscriptionFileWorkspaceFileWorkspacesApiVersion);
            _subscriptionFileWorkspaceFileWorkspacesRestClient = new FileWorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionFileWorkspaceFileWorkspacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new file workspace for the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionFileWorkspaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionFileWorkspaceFileWorkspacesRestClient.CreateAsync(Id.SubscriptionId, fileWorkspaceName, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<SubscriptionFileWorkspaceResource>(Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new file workspace for the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual ArmOperation<SubscriptionFileWorkspaceResource> CreateOrUpdate(WaitUntil waitUntil, string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionFileWorkspaceFileWorkspacesRestClient.Create(Id.SubscriptionId, fileWorkspaceName, cancellationToken);
                var operation = new SupportArmOperation<SubscriptionFileWorkspaceResource>(Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details for a specific file workspace in an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionFileWorkspaceResource>> GetAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionFileWorkspaceFileWorkspacesRestClient.GetAsync(Id.SubscriptionId, fileWorkspaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details for a specific file workspace in an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual Response<SubscriptionFileWorkspaceResource> Get(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionFileWorkspaceFileWorkspacesRestClient.Get(Id.SubscriptionId, fileWorkspaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionFileWorkspaceFileWorkspacesRestClient.GetAsync(Id.SubscriptionId, fileWorkspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionFileWorkspaceFileWorkspacesRestClient.Get(Id.SubscriptionId, fileWorkspaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual async Task<NullableResponse<SubscriptionFileWorkspaceResource>> GetIfExistsAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionFileWorkspaceFileWorkspacesRestClient.GetAsync(Id.SubscriptionId, fileWorkspaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionFileWorkspaceResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        public virtual NullableResponse<SubscriptionFileWorkspaceResource> GetIfExists(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileWorkspaceName, nameof(fileWorkspaceName));

            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionFileWorkspaceFileWorkspacesRestClient.Get(Id.SubscriptionId, fileWorkspaceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SubscriptionFileWorkspaceResource>(response.GetRawResponse());
                return Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

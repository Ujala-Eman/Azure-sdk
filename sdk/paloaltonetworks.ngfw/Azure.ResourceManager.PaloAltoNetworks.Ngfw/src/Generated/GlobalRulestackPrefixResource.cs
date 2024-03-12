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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a GlobalRulestackPrefix along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GlobalRulestackPrefixResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGlobalRulestackPrefixResource method.
    /// Otherwise you can get one from its parent resource <see cref="GlobalRulestackResource"/> using the GetGlobalRulestackPrefix method.
    /// </summary>
    public partial class GlobalRulestackPrefixResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GlobalRulestackPrefixResource"/> instance. </summary>
        /// <param name="globalRulestackName"> The globalRulestackName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string globalRulestackName, string name)
        {
            var resourceId = $"/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics;
        private readonly PrefixListGlobalRulestackRestOperations _globalRulestackPrefixPrefixListGlobalRulestackRestClient;
        private readonly GlobalRulestackPrefixData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/globalRulestacks/prefixlists";

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackPrefixResource"/> class for mocking. </summary>
        protected GlobalRulestackPrefixResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackPrefixResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GlobalRulestackPrefixResource(ArmClient client, GlobalRulestackPrefixData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackPrefixResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GlobalRulestackPrefixResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string globalRulestackPrefixPrefixListGlobalRulestackApiVersion);
            _globalRulestackPrefixPrefixListGlobalRulestackRestClient = new PrefixListGlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalRulestackPrefixPrefixListGlobalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GlobalRulestackPrefixData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GlobalRulestackPrefixResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixResource.Get");
            scope.Start();
            try
            {
                var response = await _globalRulestackPrefixPrefixListGlobalRulestackRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GlobalRulestackPrefixResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixResource.Get");
            scope.Start();
            try
            {
                var response = _globalRulestackPrefixPrefixListGlobalRulestackRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixResource.Delete");
            scope.Start();
            try
            {
                var response = await _globalRulestackPrefixPrefixListGlobalRulestackRestClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixResource.Delete");
            scope.Start();
            try
            {
                var response = _globalRulestackPrefixPrefixListGlobalRulestackRestClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalRulestackPrefixResource>> UpdateAsync(WaitUntil waitUntil, GlobalRulestackPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixResource.Update");
            scope.Start();
            try
            {
                var response = await _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<GlobalRulestackPrefixResource>(new GlobalRulestackPrefixOperationSource(Client), _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackPrefixResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalRulestackPrefixResource> Update(WaitUntil waitUntil, GlobalRulestackPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixResource.Update");
            scope.Start();
            try
            {
                var response = _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<GlobalRulestackPrefixResource>(new GlobalRulestackPrefixOperationSource(Client), _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}

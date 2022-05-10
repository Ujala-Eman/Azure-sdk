// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A Class representing a CdnWebApplicationFirewallPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CdnWebApplicationFirewallPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCdnWebApplicationFirewallPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetCdnWebApplicationFirewallPolicy method.
    /// </summary>
    public partial class CdnWebApplicationFirewallPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CdnWebApplicationFirewallPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string policyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics;
        private readonly PoliciesRestOperations _cdnWebApplicationFirewallPolicyPoliciesRestClient;
        private readonly CdnWebApplicationFirewallPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="CdnWebApplicationFirewallPolicyResource"/> class for mocking. </summary>
        protected CdnWebApplicationFirewallPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CdnWebApplicationFirewallPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CdnWebApplicationFirewallPolicyResource(ArmClient client, CdnWebApplicationFirewallPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CdnWebApplicationFirewallPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CdnWebApplicationFirewallPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cdnWebApplicationFirewallPolicyPoliciesApiVersion);
            _cdnWebApplicationFirewallPolicyPoliciesRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cdnWebApplicationFirewallPolicyPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/cdnWebApplicationFirewallPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CdnWebApplicationFirewallPolicyData Data
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
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CdnWebApplicationFirewallPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve protection policy with specified name within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CdnWebApplicationFirewallPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes Policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(response);
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
        /// Deletes Policy
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.Delete");
            scope.Start();
            try
            {
                var response = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(response);
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
        /// Update an existing CdnWebApplicationFirewallPolicy with the specified policy name under the specified subscription and resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> CdnWebApplicationFirewallPolicy parameters to be patched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<CdnWebApplicationFirewallPolicyResource>> UpdateAsync(WaitUntil waitUntil, CdnWebApplicationFirewallPolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<CdnWebApplicationFirewallPolicyResource>(new CdnWebApplicationFirewallPolicyOperationSource(Client), _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Update an existing CdnWebApplicationFirewallPolicy with the specified policy name under the specified subscription and resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> CdnWebApplicationFirewallPolicy parameters to be patched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<CdnWebApplicationFirewallPolicyResource> Update(WaitUntil waitUntil, CdnWebApplicationFirewallPolicyPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new CdnArmOperation<CdnWebApplicationFirewallPolicyResource>(new CdnWebApplicationFirewallPolicyOperationSource(Client), _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics, Pipeline, _cdnWebApplicationFirewallPolicyPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<CdnWebApplicationFirewallPolicyResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<CdnWebApplicationFirewallPolicyResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<CdnWebApplicationFirewallPolicyResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<CdnWebApplicationFirewallPolicyResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<CdnWebApplicationFirewallPolicyResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _cdnWebApplicationFirewallPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/cdnWebApplicationFirewallPolicies/{policyName}
        /// Operation Id: Policies_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<CdnWebApplicationFirewallPolicyResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _cdnWebApplicationFirewallPolicyPoliciesClientDiagnostics.CreateScope("CdnWebApplicationFirewallPolicyResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _cdnWebApplicationFirewallPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new CdnWebApplicationFirewallPolicyResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

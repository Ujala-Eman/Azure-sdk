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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a PreRulestackRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PreRulestackRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPreRulestackRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="GlobalRulestackResource"/> using the GetPreRulestackRule method.
    /// </summary>
    public partial class PreRulestackRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PreRulestackRuleResource"/> instance. </summary>
        /// <param name="globalRulestackName"> The globalRulestackName. </param>
        /// <param name="priority"> The priority. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string globalRulestackName, string priority)
        {
            var resourceId = $"/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _preRulestackRulePreRulesClientDiagnostics;
        private readonly PreRulesRestOperations _preRulestackRulePreRulesRestClient;
        private readonly PreRulestackRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/globalRulestacks/preRules";

        /// <summary> Initializes a new instance of the <see cref="PreRulestackRuleResource"/> class for mocking. </summary>
        protected PreRulestackRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PreRulestackRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PreRulestackRuleResource(ArmClient client, PreRulestackRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PreRulestackRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PreRulestackRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _preRulestackRulePreRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string preRulestackRulePreRulesApiVersion);
            _preRulestackRulePreRulesRestClient = new PreRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, preRulestackRulePreRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PreRulestackRuleData Data
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
        /// Get a PreRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PreRulestackRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _preRulestackRulePreRulesRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PreRulestackRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PreRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PreRulestackRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.Get");
            scope.Start();
            try
            {
                var response = _preRulestackRulePreRulesRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PreRulestackRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a PreRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _preRulestackRulePreRulesRestClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_preRulestackRulePreRulesClientDiagnostics, Pipeline, _preRulestackRulePreRulesRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a PreRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _preRulestackRulePreRulesRestClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_preRulestackRulePreRulesClientDiagnostics, Pipeline, _preRulestackRulePreRulesRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PreRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PreRulestackRuleResource>> UpdateAsync(WaitUntil waitUntil, PreRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _preRulestackRulePreRulesRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<PreRulestackRuleResource>(new PreRulestackRuleOperationSource(Client), _preRulestackRulePreRulesClientDiagnostics, Pipeline, _preRulestackRulePreRulesRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PreRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PreRulestackRuleResource> Update(WaitUntil waitUntil, PreRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.Update");
            scope.Start();
            try
            {
                var response = _preRulestackRulePreRulesRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<PreRulestackRuleResource>(new PreRulestackRuleOperationSource(Client), _preRulestackRulePreRulesClientDiagnostics, Pipeline, _preRulestackRulePreRulesRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}/getCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_getCounters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallRuleCounter>> GetCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.GetCounters");
            scope.Start();
            try
            {
                var response = await _preRulestackRulePreRulesRestClient.GetCountersAsync(Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}/getCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_getCounters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallRuleCounter> GetCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.GetCounters");
            scope.Start();
            try
            {
                var response = _preRulestackRulePreRulesRestClient.GetCounters(Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refresh counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}/refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RefreshCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.RefreshCounters");
            scope.Start();
            try
            {
                var response = await _preRulestackRulePreRulesRestClient.RefreshCountersAsync(Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refresh counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}/refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RefreshCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.RefreshCounters");
            scope.Start();
            try
            {
                var response = _preRulestackRulePreRulesRestClient.RefreshCounters(Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reset counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}/resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallRuleResetConter>> ResetCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.ResetCounters");
            scope.Start();
            try
            {
                var response = await _preRulestackRulePreRulesRestClient.ResetCountersAsync(Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reset counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/preRules/{priority}/resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PreRules_resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PreRulestackRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallRuleResetConter> ResetCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _preRulestackRulePreRulesClientDiagnostics.CreateScope("PreRulestackRuleResource.ResetCounters");
            scope.Start();
            try
            {
                var response = _preRulestackRulePreRulesRestClient.ResetCounters(Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

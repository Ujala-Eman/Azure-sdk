// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.VoiceServices;
using Azure.ResourceManager.VoiceServices.Models;

namespace Azure.ResourceManager.VoiceServices.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableVoiceServicesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics;
        private CommunicationsGatewaysRestOperations _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient;
        private ClientDiagnostics _nameAvailabilityClientDiagnostics;
        private NameAvailabilityRestOperations _nameAvailabilityRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableVoiceServicesSubscriptionResource"/> class for mocking. </summary>
        protected MockableVoiceServicesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableVoiceServicesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableVoiceServicesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics VoiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics => _voiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.VoiceServices", VoiceServicesCommunicationsGatewayResource.ResourceType.Namespace, Diagnostics);
        private CommunicationsGatewaysRestOperations VoiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient => _voiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient ??= new CommunicationsGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(VoiceServicesCommunicationsGatewayResource.ResourceType));
        private ClientDiagnostics NameAvailabilityClientDiagnostics => _nameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.VoiceServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private NameAvailabilityRestOperations NameAvailabilityRestClient => _nameAvailabilityRestClient ??= new NameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List CommunicationsGateway resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/communicationsGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VoiceServicesCommunicationsGatewayResource> GetVoiceServicesCommunicationsGatewaysAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VoiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VoiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VoiceServicesCommunicationsGatewayResource(Client, VoiceServicesCommunicationsGatewayData.DeserializeVoiceServicesCommunicationsGatewayData(e)), VoiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics, Pipeline, "MockableVoiceServicesSubscriptionResource.GetVoiceServicesCommunicationsGateways", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List CommunicationsGateway resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/communicationsGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VoiceServicesCommunicationsGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VoiceServicesCommunicationsGatewayResource> GetVoiceServicesCommunicationsGateways(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => VoiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => VoiceServicesCommunicationsGatewayCommunicationsGatewaysRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VoiceServicesCommunicationsGatewayResource(Client, VoiceServicesCommunicationsGatewayData.DeserializeVoiceServicesCommunicationsGatewayData(e)), VoiceServicesCommunicationsGatewayCommunicationsGatewaysClientDiagnostics, Pipeline, "MockableVoiceServicesSubscriptionResource.GetVoiceServicesCommunicationsGateways", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check whether the resource name is available in the given region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NameAvailability_CheckLocal</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> The check availability request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<VoiceServicesCheckNameAvailabilityResult>> CheckVoiceServicesNameAvailabilityAsync(AzureLocation location, VoiceServicesCheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = NameAvailabilityClientDiagnostics.CreateScope("MockableVoiceServicesSubscriptionResource.CheckVoiceServicesNameAvailability");
            scope.Start();
            try
            {
                var response = await NameAvailabilityRestClient.CheckLocalAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check whether the resource name is available in the given region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.VoiceServices/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NameAvailability_CheckLocal</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> The check availability request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<VoiceServicesCheckNameAvailabilityResult> CheckVoiceServicesNameAvailability(AzureLocation location, VoiceServicesCheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = NameAvailabilityClientDiagnostics.CreateScope("MockableVoiceServicesSubscriptionResource.CheckVoiceServicesNameAvailability");
            scope.Start();
            try
            {
                var response = NameAvailabilityRestClient.CheckLocal(Id.SubscriptionId, location, content, cancellationToken);
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

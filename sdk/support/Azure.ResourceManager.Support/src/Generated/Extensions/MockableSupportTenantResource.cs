// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Support;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableSupportTenantResource : ArmResource
    {
        private ClientDiagnostics _serviceClassificationsNoSubscriptionClientDiagnostics;
        private ServiceClassificationsNoSubscriptionRestOperations _serviceClassificationsNoSubscriptionRestClient;
        private ClientDiagnostics _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics;
        private SupportTicketsNoSubscriptionRestOperations _tenantSupportTicketSupportTicketsNoSubscriptionRestClient;
        private ClientDiagnostics _lookUpResourceIdClientDiagnostics;
        private LookUpResourceIdRestOperations _lookUpResourceIdRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableSupportTenantResource"/> class for mocking. </summary>
        protected MockableSupportTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSupportTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSupportTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ServiceClassificationsNoSubscriptionClientDiagnostics => _serviceClassificationsNoSubscriptionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Support", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ServiceClassificationsNoSubscriptionRestOperations ServiceClassificationsNoSubscriptionRestClient => _serviceClassificationsNoSubscriptionRestClient ??= new ServiceClassificationsNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics TenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics => _tenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Support", TenantSupportTicketResource.ResourceType.Namespace, Diagnostics);
        private SupportTicketsNoSubscriptionRestOperations TenantSupportTicketSupportTicketsNoSubscriptionRestClient => _tenantSupportTicketSupportTicketsNoSubscriptionRestClient ??= new SupportTicketsNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(TenantSupportTicketResource.ResourceType));
        private ClientDiagnostics LookUpResourceIdClientDiagnostics => _lookUpResourceIdClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Support", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LookUpResourceIdRestOperations LookUpResourceIdRestClient => _lookUpResourceIdRestClient ??= new LookUpResourceIdRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SupportAzureServiceResources in the TenantResource. </summary>
        /// <returns> An object representing collection of SupportAzureServiceResources and their operations over a SupportAzureServiceResource. </returns>
        public virtual SupportAzureServiceCollection GetSupportAzureServices()
        {
            return GetCachedClient(client => new SupportAzureServiceCollection(client, Id));
        }

        /// <summary>
        /// Gets a specific Azure service for support ticket creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportAzureServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Name of the Azure service for which the problem classifications need to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupportAzureServiceResource>> GetSupportAzureServiceAsync(string serviceName, CancellationToken cancellationToken = default)
        {
            return await GetSupportAzureServices().GetAsync(serviceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a specific Azure service for support ticket creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportAzureServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceName"> Name of the Azure service for which the problem classifications need to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="serviceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupportAzureServiceResource> GetSupportAzureService(string serviceName, CancellationToken cancellationToken = default)
        {
            return GetSupportAzureServices().Get(serviceName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantSupportTicketResources in the TenantResource. </summary>
        /// <returns> An object representing collection of TenantSupportTicketResources and their operations over a TenantSupportTicketResource. </returns>
        public virtual TenantSupportTicketCollection GetTenantSupportTickets()
        {
            return GetCachedClient(client => new TenantSupportTicketCollection(client, Id));
        }

        /// <summary>
        /// Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantSupportTicketResource>> GetTenantSupportTicketAsync(string supportTicketName, CancellationToken cancellationToken = default)
        {
            return await GetTenantSupportTickets().GetAsync(supportTicketName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details for a specific support ticket. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantSupportTicketResource> GetTenantSupportTicket(string supportTicketName, CancellationToken cancellationToken = default)
        {
            return GetTenantSupportTickets().Get(supportTicketName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantFileWorkspaceResources in the TenantResource. </summary>
        /// <returns> An object representing collection of TenantFileWorkspaceResources and their operations over a TenantFileWorkspaceResource. </returns>
        public virtual TenantFileWorkspaceCollection GetTenantFileWorkspaces()
        {
            return GetCachedClient(client => new TenantFileWorkspaceCollection(client, Id));
        }

        /// <summary>
        /// Gets details for a specific file workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantFileWorkspaceResource>> GetTenantFileWorkspaceAsync(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            return await GetTenantFileWorkspaces().GetAsync(fileWorkspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details for a specific file workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspacesNoSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileWorkspaceName"> File Workspace Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileWorkspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileWorkspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantFileWorkspaceResource> GetTenantFileWorkspace(string fileWorkspaceName, CancellationToken cancellationToken = default)
        {
            return GetTenantFileWorkspaces().Get(fileWorkspaceName, cancellationToken);
        }

        /// <summary>
        /// Classify the list of right Azure services.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/classifyServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceClassificationsNoSubscription_classifyServices</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ServiceClassificationOutput>> ClassifyServicesServiceClassificationsNoSubscriptionAsync(ServiceClassificationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ServiceClassificationsNoSubscriptionClientDiagnostics.CreateScope("MockableSupportTenantResource.ClassifyServicesServiceClassificationsNoSubscription");
            scope.Start();
            try
            {
                var response = await ServiceClassificationsNoSubscriptionRestClient.ClassifyServicesAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Classify the list of right Azure services.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/classifyServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceClassificationsNoSubscription_classifyServices</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ServiceClassificationOutput> ClassifyServicesServiceClassificationsNoSubscription(ServiceClassificationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ServiceClassificationsNoSubscriptionClientDiagnostics.CreateScope("MockableSupportTenantResource.ClassifyServicesServiceClassificationsNoSubscription");
            scope.Start();
            try
            {
                var response = ServiceClassificationsNoSubscriptionRestClient.ClassifyServices(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for support ticket creation for the selected subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<SupportNameAvailabilityResult>> CheckNameAvailabilitySupportTicketsNoSubscriptionAsync(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = TenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("MockableSupportTenantResource.CheckNameAvailabilitySupportTicketsNoSubscription");
            scope.Start();
            try
            {
                var response = await TenantSupportTicketSupportTicketsNoSubscriptionRestClient.CheckNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for support ticket creation for the selected subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTicketsNoSubscription_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TenantSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<SupportNameAvailabilityResult> CheckNameAvailabilitySupportTicketsNoSubscription(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = TenantSupportTicketSupportTicketsNoSubscriptionClientDiagnostics.CreateScope("MockableSupportTenantResource.CheckNameAvailabilitySupportTicketsNoSubscription");
            scope.Start();
            try
            {
                var response = TenantSupportTicketSupportTicketsNoSubscriptionRestClient.CheckNameAvailability(content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation fetches ARM resource id of support resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/lookUpResourceId</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LookUpResourceId_Post</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Look up resource id request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<LookUpResourceIdResult>> LookUpResourceIdAsync(LookUpResourceIdContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = LookUpResourceIdClientDiagnostics.CreateScope("MockableSupportTenantResource.LookUpResourceId");
            scope.Start();
            try
            {
                var response = await LookUpResourceIdRestClient.PostAsync(content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation fetches ARM resource id of support resource type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/lookUpResourceId</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LookUpResourceId_Post</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Look up resource id request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<LookUpResourceIdResult> LookUpResourceId(LookUpResourceIdContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = LookUpResourceIdClientDiagnostics.CreateScope("MockableSupportTenantResource.LookUpResourceId");
            scope.Start();
            try
            {
                var response = LookUpResourceIdRestClient.Post(content, cancellationToken);
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

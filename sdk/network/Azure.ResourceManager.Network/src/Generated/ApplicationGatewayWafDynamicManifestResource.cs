// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing an ApplicationGatewayWafDynamicManifest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ApplicationGatewayWafDynamicManifestResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetApplicationGatewayWafDynamicManifestResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetApplicationGatewayWafDynamicManifest method.
    /// </summary>
    public partial class ApplicationGatewayWafDynamicManifestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApplicationGatewayWafDynamicManifestResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics;
        private readonly ApplicationGatewayWafDynamicManifestsDefaultRestOperations _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient;
        private readonly ApplicationGatewayWafDynamicManifestData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/locations/applicationGatewayWafDynamicManifests";

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayWafDynamicManifestResource"/> class for mocking. </summary>
        protected ApplicationGatewayWafDynamicManifestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayWafDynamicManifestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApplicationGatewayWafDynamicManifestResource(ArmClient client, ApplicationGatewayWafDynamicManifestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewayWafDynamicManifestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApplicationGatewayWafDynamicManifestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultApiVersion);
            _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient = new ApplicationGatewayWafDynamicManifestsDefaultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApplicationGatewayWafDynamicManifestData Data
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
        /// Gets the regional application gateway waf manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationGatewayWafDynamicManifestResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestResource.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayWafDynamicManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the regional application gateway waf manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/applicationGatewayWafDynamicManifests/dafault</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationGatewayWafDynamicManifestsDefault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApplicationGatewayWafDynamicManifestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationGatewayWafDynamicManifestResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultClientDiagnostics.CreateScope("ApplicationGatewayWafDynamicManifestResource.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewayWafDynamicManifestApplicationGatewayWafDynamicManifestsDefaultRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewayWafDynamicManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

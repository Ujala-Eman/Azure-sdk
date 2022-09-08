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
using Azure.ResourceManager.LoadTestService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTestService
{
    /// <summary>
    /// A Class representing a QuotaResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="QuotaResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetQuotaResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetQuotaResource method.
    /// </summary>
    public partial class QuotaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="QuotaResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string quotaBucketName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _quotaResourceQuotasClientDiagnostics;
        private readonly QuotasRestOperations _quotaResourceQuotasRestClient;
        private readonly QuotaResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="QuotaResource"/> class for mocking. </summary>
        protected QuotaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "QuotaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal QuotaResource(ArmClient client, QuotaResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="QuotaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal QuotaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _quotaResourceQuotasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LoadTestService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string quotaResourceQuotasApiVersion);
            _quotaResourceQuotasRestClient = new QuotasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, quotaResourceQuotasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.LoadTestService/locations/quotas";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual QuotaResourceData Data
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
        /// Get the available quota for a quota bucket per region per subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}
        /// Operation Id: Quotas_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QuotaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _quotaResourceQuotasClientDiagnostics.CreateScope("QuotaResource.Get");
            scope.Start();
            try
            {
                var response = await _quotaResourceQuotasRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}
        /// Operation Id: Quotas_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QuotaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _quotaResourceQuotasClientDiagnostics.CreateScope("QuotaResource.Get");
            scope.Start();
            try
            {
                var response = _quotaResourceQuotasRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new QuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check Quota Availability on quota bucket per region per subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}/checkAvailability
        /// Operation Id: Quotas_CheckAvailability
        /// </summary>
        /// <param name="content"> Quota Bucket Request data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<CheckQuotaAvailabilityResponse>> CheckAvailabilityAsync(QuotaBucketContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _quotaResourceQuotasClientDiagnostics.CreateScope("QuotaResource.CheckAvailability");
            scope.Start();
            try
            {
                var response = await _quotaResourceQuotasRestClient.CheckAvailabilityAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check Quota Availability on quota bucket per region per subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}/checkAvailability
        /// Operation Id: Quotas_CheckAvailability
        /// </summary>
        /// <param name="content"> Quota Bucket Request data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<CheckQuotaAvailabilityResponse> CheckAvailability(QuotaBucketContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _quotaResourceQuotasClientDiagnostics.CreateScope("QuotaResource.CheckAvailability");
            scope.Start();
            try
            {
                var response = _quotaResourceQuotasRestClient.CheckAvailability(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, content, cancellationToken);
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

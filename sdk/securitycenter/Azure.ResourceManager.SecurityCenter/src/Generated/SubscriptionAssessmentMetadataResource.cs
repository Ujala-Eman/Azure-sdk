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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SubscriptionAssessmentMetadata along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SubscriptionAssessmentMetadataResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSubscriptionAssessmentMetadataResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetSubscriptionAssessmentMetadata method.
    /// </summary>
    public partial class SubscriptionAssessmentMetadataResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionAssessmentMetadataResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="assessmentMetadataName"> The assessmentMetadataName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string assessmentMetadataName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics;
        private readonly AssessmentsMetadataRestOperations _subscriptionAssessmentMetadataAssessmentsMetadataRestClient;
        private readonly SecurityAssessmentMetadataData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAssessmentMetadataResource"/> class for mocking. </summary>
        protected SubscriptionAssessmentMetadataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionAssessmentMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionAssessmentMetadataResource(ArmClient client, SecurityAssessmentMetadataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAssessmentMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionAssessmentMetadataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionAssessmentMetadataAssessmentsMetadataApiVersion);
            _subscriptionAssessmentMetadataAssessmentsMetadataRestClient = new AssessmentsMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionAssessmentMetadataAssessmentsMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/assessmentMetadata";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityAssessmentMetadataData Data
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
        /// Get metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionAssessmentMetadataResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.GetInSubscriptionAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_GetInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionAssessmentMetadataResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.GetInSubscription(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete metadata information on an assessment type in a specific subscription, will cause the deletion of all the assessments of that type in that subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_DeleteInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataResource.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.DeleteInSubscriptionAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Delete metadata information on an assessment type in a specific subscription, will cause the deletion of all the assessments of that type in that subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_DeleteInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataResource.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.DeleteInSubscription(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new SecurityCenterArmOperation(response);
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
        /// Create metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> AssessmentMetadata object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionAssessmentMetadataResource>> UpdateAsync(WaitUntil waitUntil, SecurityAssessmentMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateInSubscriptionAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SubscriptionAssessmentMetadataResource>(Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response), response.GetRawResponse()));
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
        /// Create metadata information on an assessment type in a specific subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/assessmentMetadata/{assessmentMetadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssessmentsMetadata_CreateInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> AssessmentMetadata object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubscriptionAssessmentMetadataResource> Update(WaitUntil waitUntil, SecurityAssessmentMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subscriptionAssessmentMetadataAssessmentsMetadataClientDiagnostics.CreateScope("SubscriptionAssessmentMetadataResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionAssessmentMetadataAssessmentsMetadataRestClient.CreateInSubscription(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SubscriptionAssessmentMetadataResource>(Response.FromValue(new SubscriptionAssessmentMetadataResource(Client, response), response.GetRawResponse()));
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

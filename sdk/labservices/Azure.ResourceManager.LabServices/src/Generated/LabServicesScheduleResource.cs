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
using Azure.ResourceManager.LabServices.Models;

namespace Azure.ResourceManager.LabServices
{
    /// <summary>
    /// A Class representing a LabServicesSchedule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LabServicesScheduleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLabServicesScheduleResource method.
    /// Otherwise you can get one from its parent resource <see cref="LabResource"/> using the GetLabServicesSchedule method.
    /// </summary>
    public partial class LabServicesScheduleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LabServicesScheduleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="labName"> The labName. </param>
        /// <param name="scheduleName"> The scheduleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string labName, string scheduleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _labServicesScheduleSchedulesClientDiagnostics;
        private readonly SchedulesRestOperations _labServicesScheduleSchedulesRestClient;
        private readonly LabServicesScheduleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.LabServices/labs/schedules";

        /// <summary> Initializes a new instance of the <see cref="LabServicesScheduleResource"/> class for mocking. </summary>
        protected LabServicesScheduleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabServicesScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LabServicesScheduleResource(ArmClient client, LabServicesScheduleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LabServicesScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LabServicesScheduleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _labServicesScheduleSchedulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LabServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string labServicesScheduleSchedulesApiVersion);
            _labServicesScheduleSchedulesRestClient = new SchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, labServicesScheduleSchedulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LabServicesScheduleData Data
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
        /// Returns the properties of a lab Schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabServicesScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LabServicesScheduleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleResource.Get");
            scope.Start();
            try
            {
                var response = await _labServicesScheduleSchedulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabServicesScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the properties of a lab Schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabServicesScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LabServicesScheduleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleResource.Get");
            scope.Start();
            try
            {
                var response = _labServicesScheduleSchedulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabServicesScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to delete a schedule resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabServicesScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleResource.Delete");
            scope.Start();
            try
            {
                var response = await _labServicesScheduleSchedulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new LabServicesArmOperation(_labServicesScheduleSchedulesClientDiagnostics, Pipeline, _labServicesScheduleSchedulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Operation to delete a schedule resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabServicesScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleResource.Delete");
            scope.Start();
            try
            {
                var response = _labServicesScheduleSchedulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new LabServicesArmOperation(_labServicesScheduleSchedulesClientDiagnostics, Pipeline, _labServicesScheduleSchedulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Operation to update a lab schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabServicesScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<LabServicesScheduleResource>> UpdateAsync(LabServicesSchedulePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleResource.Update");
            scope.Start();
            try
            {
                var response = await _labServicesScheduleSchedulesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new LabServicesScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to update a lab schedule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LabServices/labs/{labName}/schedules/{scheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Schedules_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LabServicesScheduleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<LabServicesScheduleResource> Update(LabServicesSchedulePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _labServicesScheduleSchedulesClientDiagnostics.CreateScope("LabServicesScheduleResource.Update");
            scope.Start();
            try
            {
                var response = _labServicesScheduleSchedulesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new LabServicesScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

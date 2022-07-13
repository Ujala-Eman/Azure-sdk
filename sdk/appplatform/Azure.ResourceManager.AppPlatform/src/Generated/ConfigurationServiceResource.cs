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
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing a ConfigurationServiceResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ConfigurationServiceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetConfigurationServiceResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformServiceResource" /> using the GetConfigurationServiceResource method.
    /// </summary>
    public partial class ConfigurationServiceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ConfigurationServiceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string configurationServiceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _configurationServiceResourceConfigurationServicesClientDiagnostics;
        private readonly ConfigurationServicesRestOperations _configurationServiceResourceConfigurationServicesRestClient;
        private readonly ConfigurationServiceResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationServiceResource"/> class for mocking. </summary>
        protected ConfigurationServiceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ConfigurationServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ConfigurationServiceResource(ArmClient client, ConfigurationServiceResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ConfigurationServiceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _configurationServiceResourceConfigurationServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string configurationServiceResourceConfigurationServicesApiVersion);
            _configurationServiceResourceConfigurationServicesRestClient = new ConfigurationServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, configurationServiceResourceConfigurationServicesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/configurationServices";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ConfigurationServiceResourceData Data
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
        /// Get the Application Configuration Service and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}
        /// Operation Id: ConfigurationServices_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConfigurationServiceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Get");
            scope.Start();
            try
            {
                var response = await _configurationServiceResourceConfigurationServicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Application Configuration Service and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}
        /// Operation Id: ConfigurationServices_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConfigurationServiceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Get");
            scope.Start();
            try
            {
                var response = _configurationServiceResourceConfigurationServicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disable the default Application Configuration Service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}
        /// Operation Id: ConfigurationServices_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Delete");
            scope.Start();
            try
            {
                var response = await _configurationServiceResourceConfigurationServicesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation(_configurationServiceResourceConfigurationServicesClientDiagnostics, Pipeline, _configurationServiceResourceConfigurationServicesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Disable the default Application Configuration Service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}
        /// Operation Id: ConfigurationServices_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Delete");
            scope.Start();
            try
            {
                var response = _configurationServiceResourceConfigurationServicesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppPlatformArmOperation(_configurationServiceResourceConfigurationServicesClientDiagnostics, Pipeline, _configurationServiceResourceConfigurationServicesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create the default Application Configuration Service or update the existing Application Configuration Service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}
        /// Operation Id: ConfigurationServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConfigurationServiceResource>> UpdateAsync(WaitUntil waitUntil, ConfigurationServiceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Update");
            scope.Start();
            try
            {
                var response = await _configurationServiceResourceConfigurationServicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<ConfigurationServiceResource>(new ConfigurationServiceResourceOperationSource(Client), _configurationServiceResourceConfigurationServicesClientDiagnostics, Pipeline, _configurationServiceResourceConfigurationServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create the default Application Configuration Service or update the existing Application Configuration Service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}
        /// Operation Id: ConfigurationServices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConfigurationServiceResource> Update(WaitUntil waitUntil, ConfigurationServiceResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Update");
            scope.Start();
            try
            {
                var response = _configurationServiceResourceConfigurationServicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppPlatformArmOperation<ConfigurationServiceResource>(new ConfigurationServiceResourceOperationSource(Client), _configurationServiceResourceConfigurationServicesClientDiagnostics, Pipeline, _configurationServiceResourceConfigurationServicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Check if the Application Configuration Service settings are valid.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}/validate
        /// Operation Id: ConfigurationServices_Validate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settings"> Application Configuration Service settings to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="settings"/> is null. </exception>
        public virtual async Task<ArmOperation<ConfigurationServiceSettingsValidateResult>> ValidateAsync(WaitUntil waitUntil, ConfigurationServiceSettings settings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(settings, nameof(settings));

            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Validate");
            scope.Start();
            try
            {
                var response = await _configurationServiceResourceConfigurationServicesRestClient.ValidateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, settings, cancellationToken).ConfigureAwait(false);
                var operation = new AppPlatformArmOperation<ConfigurationServiceSettingsValidateResult>(new ConfigurationServiceSettingsValidateResultOperationSource(), _configurationServiceResourceConfigurationServicesClientDiagnostics, Pipeline, _configurationServiceResourceConfigurationServicesRestClient.CreateValidateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, settings).Request, response, OperationFinalStateVia.Location);
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
        /// Check if the Application Configuration Service settings are valid.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/configurationServices/{configurationServiceName}/validate
        /// Operation Id: ConfigurationServices_Validate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settings"> Application Configuration Service settings to be validated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="settings"/> is null. </exception>
        public virtual ArmOperation<ConfigurationServiceSettingsValidateResult> Validate(WaitUntil waitUntil, ConfigurationServiceSettings settings, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(settings, nameof(settings));

            using var scope = _configurationServiceResourceConfigurationServicesClientDiagnostics.CreateScope("ConfigurationServiceResource.Validate");
            scope.Start();
            try
            {
                var response = _configurationServiceResourceConfigurationServicesRestClient.Validate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, settings, cancellationToken);
                var operation = new AppPlatformArmOperation<ConfigurationServiceSettingsValidateResult>(new ConfigurationServiceSettingsValidateResultOperationSource(), _configurationServiceResourceConfigurationServicesClientDiagnostics, Pipeline, _configurationServiceResourceConfigurationServicesRestClient.CreateValidateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, settings).Request, response, OperationFinalStateVia.Location);
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

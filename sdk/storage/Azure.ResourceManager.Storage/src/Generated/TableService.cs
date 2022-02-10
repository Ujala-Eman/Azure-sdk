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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A Class representing a TableService along with the instance operations that can be performed on it. </summary>
    public partial class TableService : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TableService"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tableServiceClientDiagnostics;
        private readonly TableServicesRestOperations _tableServiceRestClient;
        private readonly TableServiceData _data;

        /// <summary> Initializes a new instance of the <see cref="TableService"/> class for mocking. </summary>
        protected TableService()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TableService"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TableService(ArmClient client, TableServiceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TableService"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TableService(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tableServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string tableServiceApiVersion);
            _tableServiceRestClient = new TableServicesRestOperations(_tableServiceClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, tableServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/tableServices";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TableServiceData Data
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

        /// <summary> Gets a collection of Tables in the Table. </summary>
        /// <returns> An object representing collection of Tables and their operations over a Table. </returns>
        public virtual TableCollection GetTables()
        {
            return new TableCollection(Client, Id);
        }

        /// <summary>
        /// Gets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default
        /// Operation Id: TableServices_GetServiceProperties
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<TableService>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _tableServiceClientDiagnostics.CreateScope("TableService.Get");
            scope.Start();
            try
            {
                var response = await _tableServiceRestClient.GetServicePropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _tableServiceClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TableService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default
        /// Operation Id: TableServices_GetServiceProperties
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TableService> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _tableServiceClientDiagnostics.CreateScope("TableService.Get");
            scope.Start();
            try
            {
                var response = _tableServiceRestClient.GetServiceProperties(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _tableServiceClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TableService(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default
        /// Operation Id: TableServices_SetServiceProperties
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The properties of a storage account’s Table service, only properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules can be specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<TableService>> CreateOrUpdateAsync(bool waitForCompletion, TableServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _tableServiceClientDiagnostics.CreateScope("TableService.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tableServiceRestClient.SetServicePropertiesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<TableService>(Response.FromValue(new TableService(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Sets the properties of a storage account’s Table service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/tableServices/default
        /// Operation Id: TableServices_SetServiceProperties
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The properties of a storage account’s Table service, only properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules can be specified. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<TableService> CreateOrUpdate(bool waitForCompletion, TableServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _tableServiceClientDiagnostics.CreateScope("TableService.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tableServiceRestClient.SetServiceProperties(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, parameters, cancellationToken);
                var operation = new StorageArmOperation<TableService>(Response.FromValue(new TableService(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
